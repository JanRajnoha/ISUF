using ISUF.Base.Service;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.Storage;

namespace ISUF.Base.Storage
{
    public class FileStream<T>
    {
        /// <summary>
        /// Read data from file
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <param name="path">Path to file</param>
        /// <param name="attempts">Number of attempts</param>
        /// <returns>Collection of items of type T</returns>
        public static async Task<T> ReadDataAsync(string fileName, string path, int attempts = 0)
        {
            T readedObjects = default(T);
            Stream xmlStream = null;

            try
            {
                XmlSerializer serializ = new XmlSerializer(typeof(T));
                xmlStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(fileName);

                using (xmlStream)
                {
                    readedObjects = (T)serializ.Deserialize(xmlStream);
                }

                if (readedObjects != null)
                {
                    return readedObjects;
                }
                else
                {
                    return default(T);
                }
            }

            // When is file unavailable - 10 attempts is enough
            catch (Exception e) when (e.Message.Contains("denied") && attempts < 10)
            {
                await LogService.AddLogMessageAsync("File is in use");
                return await ReadDataAsync(fileName, path, attempts + 1);
            }

            catch (Exception e)
            {
                throw new Exceptions.Exception("Unhandled exception", e);
            }

            finally
            {
                xmlStream?.Close();
            }
        }

        /// <summary>
        /// Save data to file
        /// </summary>
        /// <param name="data">Data to save</param>
        /// <param name="fileName">File name</param>
        /// <param name="path">Path to file</param>
        /// <param name="attempts">Number of attempts</param>
        /// <returns>True, if save was succesful</returns>
        public static async Task<bool> SaveDataAsync(T data, string fileName, string path, int attempts = 0)
        {
            Stream xmlStream = null;

            try
            {
                var serializer = new XmlSerializer(typeof(T));
                xmlStream = await ApplicationData.Current.LocalFolder.OpenStreamForWriteAsync(fileName, CreationCollisionOption.ReplaceExisting);

                using (xmlStream)
                {
                    serializer.Serialize(xmlStream, data);
                }

                return true;
            }

            // When file is unavailable
            catch (Exception e) when ((e.Message.Contains("denied") || e.Message.Contains("is in use")) && attempts <= 10)
            {
                await LogService.AddLogMessageAsync("File is in use");
                return await SaveDataAsync(data, fileName, path, attempts + 1);
            }

            catch (Exception e)
            {
                throw new Exceptions.Exception("Unhandled exception", e);
            }

            finally
            {
                xmlStream?.Close();
            }
        }
    }
}