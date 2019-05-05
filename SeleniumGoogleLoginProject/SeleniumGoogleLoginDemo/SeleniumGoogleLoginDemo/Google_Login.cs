using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGoogleLoginDemo
{
    // Program does the following:
    // 
    // Launch the browser and open “Gmail.com”.
    // Verify the title of the page and print the verification result.
    // Enter the username and Password.
    // Click on the Sign in button.
    // Close the web browser.
    public class Google_Login
    {
        static void Main(string[] args)
        {
            // Instantiation of object and variables
            IWebDriver driver = new ChromeDriver();

            // launch the browser and open the url
            driver.Navigate().GoToUrl("https://accounts.google.com");

            // maximize the window
            driver.Manage().Window.Maximize();

            // declare and initialize the variable to store the expected title of the webpage.
            string expectedTitle = " Sign in - Google Accounts ";

            // fetch the title of the web page and save it into a string variable
            string actualTitle = driver.Title;                                  
        }
    }
}
