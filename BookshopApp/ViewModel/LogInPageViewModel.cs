using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BookshopApp.ViewModel
{
    using Model;
    public class LogInPageViewModel : ObservedObject
    {
        private LogInPage logInPage = new();
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

        //TODO binding password
        //TODO binding LogIn button method
    }
}
