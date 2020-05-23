using ISUF.Base.Interface;
using System;
using System.Collections.Concurrent;
using System.Linq;

namespace ISUF.Base.Classes
{
    /// <summary>
    /// Messenger design patttern implementation
    /// </summary>
    public class Messenger : IMessenger
    {
        private readonly ConcurrentDictionary<Type, ConcurrentBag<Delegate>> registeredActions = new ConcurrentDictionary<Type, ConcurrentBag<Delegate>>();
        private readonly object bagLock = new object();

        /// <inheritdoc/>
        public void Register<TMessage>(Action<TMessage> action)
        {
            var key = typeof(TMessage);

            lock (bagLock)
            {
                if (!registeredActions.TryGetValue(key, out ConcurrentBag<Delegate> actions))
                {
                    actions = new ConcurrentBag<Delegate>();
                    registeredActions[key] = actions;
                }

                actions.Add(action);
            }
        }

        /// <inheritdoc/>
        public void Send<TMessage>(TMessage message)
        {
            if (registeredActions.TryGetValue(typeof(TMessage), out ConcurrentBag<Delegate> actions))
            {
                foreach (var action in actions.Select(a => a as Action<TMessage>).Where(a => a != null))
                {
                    action(message);
                }
            }
        }

        /// <inheritdoc/>
        public void UnRegister<TMessage>(Action<TMessage> action)
        {
            var key = typeof(TMessage);

            if (registeredActions.TryGetValue(key, out ConcurrentBag<Delegate> actions))
            {
                lock (bagLock)
                {
                    var actionsList = actions.ToList();
                    actionsList.Remove(action);
                    registeredActions[key] = new ConcurrentBag<Delegate>(actionsList);
                }
            }
        }
    }
}
