using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Projectmars2021.Pages;
using Projectmars2021.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Projectmars2021.Step_definition
{
    [Binding]
    public class LoginPageSteps

    {
        LoginPage loginPageObj = new LoginPage();
        private IWebDriver testDriver;

        [Given(@"I logged into the Trade Skills portal successfully")]
        public void GivenILoggedIntoTheTradeSkillsPortalSuccessfully()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();

            loginPageObj.GoToHomePage(testDriver);
        }
        
        [Given(@"I click on the sign in button")]
        public void GivenIClickOnTheSignInButton()
        {
            loginPageObj.ClickSignInBtn(testDriver);
        }
        
        [When(@"I enter valid '(.*)', '(.*)' records")]
        public void WhenIEnterValidRecords(string Email, string Password)
        {
            loginPageObj.KeyInCredentials1(testDriver, Email, Password);
        }
        
        [Then(@"I click on the login button")]
        public void ThenIClickOnTheLoginButton()
        {
            loginPageObj.ClickLoginBtn(testDriver);
        }
    }
}
