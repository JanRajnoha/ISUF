using ISUF.UI.EventArgs;
using System;
using System.Windows.Input;

namespace ISUF.UI.Command
{
    public abstract class Command : ICommand
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="parameter"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public abstract bool CanExecute(object parameter);

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="parameter"><inheritdoc/></param>
        public abstract void Execute(object parameter);

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="e"><inheritdoc/></param>
        public void CommandCompletedChangedEvent(CommandCompletedEventArgs e)
        {
            CommandCompletedChanged?.Invoke(null, e);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public event EventHandler<CommandCompletedEventArgs> CommandCompletedChanged;
    }
}