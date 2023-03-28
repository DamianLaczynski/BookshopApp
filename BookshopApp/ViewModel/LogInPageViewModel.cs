using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BookshopApp.ViewModel
{
    using Model;
    using System.Windows;
    using System.Windows.Input;

    public class LogInPageViewModel : ObservedObject
    {
        private LogInPage logInPage = new();

        private ICommand? logInCommand;
        private ICommand? closeCommand;

        public ICommand LogIn
        {
            get 
            {
                if (logInCommand == null) logInCommand = new LogInCommand(this);
                return logInCommand;
            }
        }

        public ICommand Close
        {
            get
            {
                if (closeCommand == null) closeCommand = new CloseCommand(this);
                return closeCommand;
            }
        }

        public string? LoginText
        {
            get
            {
                return logInPage.LoginText;
            }
            set
            {
                logInPage.LoginText = value;
                this.OnPropertyChanged(nameof(logInPage.LoginText));
            }
        }
        public SecureString PasswordSecureText
        {
            set
            {
                logInPage.SecurePassword = value;
            }
        }

        public void startLogIn()
        {
            MessageBox.Show("Give me a moment");
            logInPage.logIn();
        }
        public void windowClose()
        {
            MessageBox.Show("Closing");
            //TODO
        }
    }
}
