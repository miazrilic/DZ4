using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4_2.ZAD
{
    class ChromeLogInPage : ILogInPage
    {
        public WebElement loginButton()
        {
            return new WebElement("Click!");
        }

        public WebElement passwordInput()
        {
            return new WebElement("Password");
        }

        public WebElement usernameInput()
        {
            return new WebElement("Username");
        }
    }
}
