using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Interface
{
    /// <summary>
    /// Messenger design patter interface
    /// </summary>
    public interface IMessenger
    {
        /// <summary>
        /// Register for messages
        /// </summary>
        /// <typeparam name="TMessage">Type of message</typeparam>
        /// <param name="action">Function to call</param>
        void Register<TMessage>(Action<TMessage> action);

        /// <summary>
        /// Send message
        /// </summary>
        /// <typeparam name="TMessage">Type of message</typeparam>
        /// <param name="message">Message</param>
        void Send<TMessage>(TMessage message);

        /// <summary>
        /// Unregister from messages
        /// </summary>
        /// <typeparam name="TMessage">Type of message</typeparam>
        /// <param name="action">Function to call</param>
        void UnRegister<TMessage>(Action<TMessage> action);
    }
}