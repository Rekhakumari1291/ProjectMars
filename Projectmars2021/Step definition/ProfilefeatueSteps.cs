using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Projectmars2021.Pages;
using Projectmars2021.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Projectmars2021.Step_definition
{
    [Binding]
    public class ProfilefeatueSteps :CommonDriver

    {
        [Given(@"I go to website Url")]
        public void GivenIGoToWebsiteUrl()
        {
             driver = new ChromeDriver();

            SignIn signInPage = new SignIn();
            signInPage.LogInActions(driver);
        }
        
        [Given(@"I click to SignIn Button")]
        public void GivenIClickToSignInButton()
        {
            SignIn signInPage = new SignIn();
            signInPage.LogInActions(driver);
            
        }
        
        [When(@"I enter my valid '(.*)' and '(.*)' and click on login button")]
        public void WhenIEnterMyValidAndAndClickOnLoginButton(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Then I should be able to see my name on the page")]
        public void ThenThenIShouldBeAbleToSeeMyNameOnThePage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
