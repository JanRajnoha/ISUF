using ISUF.UI.EventArgs;
using System;
using System.Windows.Input;

namespace ISUF.UI.Command
{
    public abstract class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public abstract bool CanExecute(object parameter);

        public abstract void Execute(object parameter);

        public void CommandCompletedChangedEvent(CommandCompletedEventArgs e)
        {
            CommandCompletedChanged?.Invoke(null, e);
        }

        public event EventHandler<CommandCompletedEventArgs> CommandCompletedChanged;
    }
}
