using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Projectmars2021.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projectmars2021.Tests
{
    class Profiletests
    {
        static void Main(string[] args)
        {
            // open chrome Browser
            IWebDriver testDriver = new ChromeDriver();

            ////login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.GoToHomePage(testDriver);

            //Home Page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.NaviHomePage(testDriver);

            //profileCertification Page object initialization and definition
            ProfileCertifications profileCertsObj = new ProfileCertifications();
            profileCertsObj.AddNewCertBtn(testDriver);

            // edit profileCertification Page object initialization and definition
            profileCertsObj.EditNewCertBtn(testDriver);

            //delete profileCertification Page object initialization and definition
            profileCertsObj.DeleteNewCertBtn(testDriver);

            //profileDescription Page object initialization and definition
            ProfileDescription profileDescrObj = new ProfileDescription();
            profileDescrObj.DescriptionPenIcon(testDriver);

           

            //profileDetails Page object initialization and definition
            ProfileDetails profileDetailsObj = new ProfileDetails();
            profileDetailsObj.AddNameIcon(testDriver);

            //profileEducation Page object initialization and definition
            ProfileEducation profileEducObj = new ProfileEducation();
            profileEducObj.AddNewEducationBtn(testDriver);
            //edit profileEducation Page object initialization and definition
            profileEducObj.EditEducationBtn(testDriver);
            //delete profileEducation Page object initialization and definition
            profileEducObj.DeleteEducationBtn(testDriver);

            // Profile Language Page object initialization and definition
            ProfileLangauge profileLanguageObj = new ProfileLangauge();
            profileLanguageObj.AddNewLanguageBtn(testDriver);
            // edit Profile Language Page object initialization and definition
            profileLanguageObj.EditNewLanguageBtn(testDriver);
            // delete Profile Language Page object initialization and definition
            profileLanguageObj.DeleteNewLanguageBtn(testDriver);

            // Profile Language Page object initialization and definition
            ProfileSkills profileSkillsObj = new ProfileSkills();
            profileSkillsObj.AddNewSkillsBtn(testDriver);

            // Profile Language Page object initialization and definition
            profileSkillsObj.EditNewLanguageBtn(testDriver);

            // deleteProfile Language Page object initialization and definition
            profileSkillsObj.DeleteNewLanguageBtn(testDriver);

            // Profile View object initialization and definition
            ProfileViewPage ProfileViewPageObj = new ProfileViewPage();
            ProfileViewPageObj.NavigateToImgIcon(testDriver);


        }
    }
}
