using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace MailLoginAutomation
{
    class MailLoginAutomation
    {
        static void Main(string[] args)
        {
            var login = new Login();
            var newMailChecker = new NewMailChecker();
            IWebDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(130));

            login.LogIn(driver, wait, "csharppractice", "FoundationOfProgramming", "https://account.mail.ru/");
            Console.WriteLine(newMailChecker.GetNewMails(wait));

        }
    }
}