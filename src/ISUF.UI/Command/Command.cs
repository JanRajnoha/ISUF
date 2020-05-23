using ISUF.UI.EventArgs;
using System;
using System.Windows.Input;

namespace ISUF.UI.Command
{
    public abstract class Command : ICommand
    {
        /// <inheritdoc/>
        public event EventHandler CanExecuteChanged;

        /// <inheritdoc/>
        public abstract bool CanExecute(object parameter);

        /// <inheritdoc/>
        public abstract void Execute(object parameter);

        /// <inheritdoc/>
        public void CommandCompletedChangedEvent(CommandCompletedEventArgs e)
        {
            CommandCompletedChanged?.Invoke(null, e);
        }

        /// <inheritdoc/>
        public event EventHandler<CommandCompletedEventArgs> CommandCompletedChanged;
    }
}