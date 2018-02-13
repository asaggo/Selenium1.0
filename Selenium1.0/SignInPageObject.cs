using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium1._0
{
    class SignInPageObject
    {
        public SignInPageObject()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement txtUsername { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement btnLogin { get; set; }

        [FindsBy(How = How.Id, Using = "rightNav-signIn")]
        public IWebElement btnRightNavSignIn { get; set; }

        public void LinkToLoginPage()
        {

        }

        public void Login(string uname, string pword)
        {
            txtUsername.SendKeys(uname);
            txtPassword.SendKeys(pword);
            btnLogin.Click();
        }
    }
}
