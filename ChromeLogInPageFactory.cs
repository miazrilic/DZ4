using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4_2.ZAD
{
    public class ChromeLogInPageFactory : LogInPageFactory
    {
        public override ILogInPage CreatePage()
        {
            return new ChromeLogInPage();
        }
    }
}
