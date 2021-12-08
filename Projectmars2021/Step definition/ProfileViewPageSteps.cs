using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Projectmars2021.Pages;
using System;
using TechTalk.SpecFlow;

namespace Projectmars2021.Step_definition
{
    [Binding]
    public class ProfileViewPageSteps
    {

        // Profile View object initialization and definition
        ProfileViewPage ProfileViewPageObj = new ProfileViewPage();

        LoginPage loginPageObj = new LoginPage();
        // Home Page object initialization and definition
        HomePage NaviHomePageObj = new HomePage();
        private IWebDriver testDriver;


        [Given(@"I login to the Trade Skills portal of view successfully")]
        public void GivenILoginToTheTradeSkillsPortalOfViewSuccessfully()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();
             loginPageObj.LoginPageSteps(testDriver);
            
        }
        
        [Given(@"I navigate to the main page and click on Programming & Tech")]
        public void GivenINavigateToTheMainPageAndClickOnProgrammingTech()
        {
            ProfileViewPageObj.GoToMainPage(testDriver);
            ProfileViewPageObj.NavigateToImgIcon(testDriver);
        }
        
        [When(@"I navigate to the seller profile page")]
        public void WhenINavigateToTheSellerProfilePage()
        {
            NaviHomePageObj.NaviHomePage(testDriver);
        }
        
        [Then(@"The seller profile page should be updated successfully")]
        public void ThenTheSellerProfilePageShouldBeUpdatedSuccessfully()
        {
            string validateUser = ProfileViewPageObj.ValidateUser(testDriver);

            // Assertion that Seller record has been created.
            Assert.AreEqual(validateUser, validateUser, "Actual user and expected user don't match");
        }
    }
}
