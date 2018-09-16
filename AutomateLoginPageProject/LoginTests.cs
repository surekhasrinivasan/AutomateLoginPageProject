using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateLoginPageProject
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void VerifyValidLogin()
        {
            //Open the login page
            driver.Url = "https://www.yahoo.com/";
            driver.FindElement(By.XPath("//*[@id=\"uh-signin\"]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine("Opening " + driver.Url);

            //Enter the username and password
            driver.FindElement(By.XPath("//*[@id=\"login-username\"]")).SendKeys("surekha.srinivasan@yahoo.com");
            driver.FindElement(By.Id("login-signin")).Click();
            
            driver.FindElement(By.Id("login-passwd")).SendKeys("Careerdevs");
            Console.WriteLine("Enter username and password");

            //Click Signin button
            driver.FindElement(By.Name("verifyPassword")).Click();
            Console.WriteLine("Clicked Login Button");            
        }

        [Test]
        public void VerifyInvalidLogin()
        {
            
        }
    }
}
