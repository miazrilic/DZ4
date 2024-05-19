namespace DZ4_2.ZAD
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LogInPageFactory chromeLogInPageFactory = new ChromeLogInPageFactory();
            ILogInPage page = chromeLogInPageFactory.CreatePage();
            
            WebElement webElement1 = page.loginButton();
            webElement1.Click();
            webElement1 = page.usernameInput();
            webElement1.Click();
            webElement1 = page.passwordInput();
           
            webElement1.Click();








        }
    }
}