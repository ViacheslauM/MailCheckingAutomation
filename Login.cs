using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MailLoginAutomation
{
    class Login
    {
        public void LogIn(IWebDriver driver, WebDriverWait wait, string name, string pass)
        {
            driver.Url = "https://account.mail.ru/";

            IWebElement username = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("username")));
            username.SendKeys(name);
            username.SendKeys(Keys.Return);

            IWebElement password = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("password")));
            password.SendKeys(pass);
            password.SendKeys(Keys.Return);
        }
    }
}
