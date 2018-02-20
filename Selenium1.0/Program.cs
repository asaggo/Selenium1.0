using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium1._0
{
    class Program
    {
        
        static void Main(string[] args)
        {

        }
        
        
        [SetUp]
        public void Initialize()
        {
            Properties.driver = new ChromeDriver();
            PageObject pageObject = new PageObject();
            pageObject.LinkToMainPage();
        }
        
        /*
        [Test]
        public void ExecuteTest_SignUp()
        {
            //initialize the pageobject

            SignUpPageObject signupPage = new SignUpPageObject();
            signupPage.LinkToSignUpPage();
            signupPage.SignUp("usernameJJ@dwdf.com","passwordJJ!123");
            

        }
        */

        [Test]
        public void ExecuteTest_SignIn()
        {
            SignInPageObject signInPage = new SignInPageObject();
            signInPage.LinkToLoginPage();
            signInPage.Login("asaggo0717@gmail.com", "9002dnjs");
            signInPage.checkUserEmailAfterSignIn();
        }

        [Test]
        public void Execute_ChangeProfile()
        {
            ExecuteTest_SignIn();
            //start change profile
            MyProfilePageObject myProfilePage = new MyProfilePageObject();
            myProfilePage.LinkToMyProfile();
            myProfilePage.ChangePreferences();
        }

        /*
        [TearDown]
        public void CleanUp()
        {
            //Properties.driver.Close();
            Console.WriteLine("Close browser");
        }
        */
    }
}
