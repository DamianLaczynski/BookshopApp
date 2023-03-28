using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BookshopApp.Model
{
    public class LogInPage
    {
        public string? LoginText { get; set; }
        public SecureString SecurePassword { private get; set; } = new SecureString();

        public LogInPage() {   }

        public void logIn()
        {
            //TODO
            SecurePassword.Clear();
        }
    }
}
