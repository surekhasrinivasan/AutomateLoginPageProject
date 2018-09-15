using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateLoginPageProject
{
    public class TestBase
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(); //launches chrome browser
            driver.Manage().Window.Maximize();//maximizes the window
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);//set LocatorTimeout to be 20 seconds at max
        }
        
        [Test]
        public void OpenWebPage()
        {
            driver.Url = "https://www.yahoo.com/";
            driver.FindElement(By.XPath("//*[@id=\"uh-signin\"]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        } 
        
        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
