using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BookshopApp.ViewModel
{
    public class LogInCommand : ICommand
    {
        private readonly LogInPageViewModel? logInPageViewModel;

        public LogInCommand(LogInPageViewModel logInVM)
        {
            if (logInVM == null)
                throw new ArgumentNullException(nameof(logInVM));
            this.logInPageViewModel = logInVM;
        }

        public event EventHandler? CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object? parameter)
        {
            if (logInPageViewModel?.LoginText?.Length != 0)
                return true;
            return false;
        }

        public void Execute(object? parameter)
        {
            logInPageViewModel?.startLogIn();
        }
    }

    public class CloseCommand : ICommand
    {
        private readonly LogInPageViewModel? logInPageViewModel;

        public CloseCommand(LogInPageViewModel logInVM)
        {
            if (logInVM == null)
                throw new ArgumentNullException(nameof(logInVM));
            this.logInPageViewModel = logInVM;
        }

        public event EventHandler? CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            logInPageViewModel?.windowClose();
        }
    }
}
