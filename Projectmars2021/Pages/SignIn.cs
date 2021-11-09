using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Projectmars2021.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Projectmars2021.Pages
{
    class SignIn:CommonDriver
    {
        public void LogInActions(IWebDriver driver)
        {
            IWebDriver Driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1500);
            //click on Sign In botton
            IWebElement SignInButton = driver.FindElement(By.XPath("//*[@id='abId0.4573858679661422']/div[1]/div/a"));
            SignInButton.Click();
            //type email address in username box
            IWebElement EmailaddressTextbox = driver.FindElement(By.XPath("//*[@id='abId0.6398397952919739']/input"));
            EmailaddressTextbox.SendKeys("rekhakumari.1291@gmail.com");
            IWebElement PasswordTextbox = driver.FindElement(By.XPath("//*[@id='abId0.015848023141404655']/input"));
            PasswordTextbox.SendKeys("2Rekharakesh");
            //Click on Login Button
            IWebElement logInButton = driver.FindElement(By.XPath("//*[@id='abId0.9730291551109582']/div[4]/button"));
            logInButton.Click();
            Thread.Sleep(2000);
        }
    }
}
