using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Projectmars2021.Pages;
using Projectmars2021.Utilities;
using System;
using System.Threading;

namespace Projectmars2021
{
    class Tests :CommonDriver
    {
        static void signInActions()
        {
             driver = new ChromeDriver();

            SignIn signInPage = new SignIn();
                      signInPage.LogInActions(driver);   
        }

        }
    }
