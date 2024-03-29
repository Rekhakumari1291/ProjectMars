﻿using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Projectmars2021.Pages;
using System;
using TechTalk.SpecFlow;

namespace Projectmars2021.Step_definition
{
    [Binding]
    public class ProfileDescriptionSteps
    {

        // Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        // Login Page object initialization and definition
        ProfileDescription profileDetailsObj = new ProfileDescription();
        private ChromeDriver testDriver;

        [Given(@"I login to the Trade Skills portal description successfully")]
        public void GivenILoginToTheTradeSkillsPortalDescriptionSuccessfully()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();
            loginPageObj.LoginPageSteps(testDriver);
        }
        
        [Given(@"I click on the description pen icon")]
        public void GivenIClickOnTheDescriptionPenIcon()
        {
            profileDetailsObj.DescriptionPenIcon(testDriver);
        }
        
        [When(@"I add the '(.*)' and click on Save button")]
        public void WhenIAddTheAndClickOnSaveButton(string Description)
        {
            profileDetailsObj.AddDescription(testDriver, Description);
        }
        
        [Then(@"the Description should be added as '(.*)' successfully")]
        public void ThenTheDescriptionShouldBeAddedAsSuccessfully(string Description)
        {
            // Assertion that Description record has been created.
            Assert.AreEqual(profileDetailsObj.GetDescription1(testDriver), Description, "Actual Description and expected Description don't match");
        }
        [When(@"I edit the '(.*)' and click on Save button")]
        public void WhenIEditTheAndClickOnSaveButton(string Description)
        {
            profileDetailsObj.EditDescription(testDriver, Description);
        }
        [Then(@"the Description should be updated as '(.*)' successfully")]
        public void ThenTheDescriptionShouldBeUpdatedAsSuccessfully(string Description)
        {
            // Assertion that Description record has been created.
            Assert.AreEqual(profileDetailsObj.GetDescription2(testDriver), Description, "Actual Description and expected Description don't match");
        
    }

    }
}
