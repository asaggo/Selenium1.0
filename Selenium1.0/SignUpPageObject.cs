using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium1._0
{
    class SignUpPageObject
    {
        public SignUpPageObject()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        [FindsBy(How = How.Id,Using ="username")]
        public IWebElement txtUsername { get; set; }

        [FindsBy(How = How.Id,Using ="firstname")]
        public IWebElement txtFirstname { get; set; }

        [FindsBy(How = How.Id,Using ="lastname")]
        public IWebElement txtLastname { get; set; }

        [FindsBy(How = How.Id,Using ="password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id,Using ="createAccount")]
        public IWebElement btnCreateAccount { get; set; }

        [FindsBy(How = How.Id,Using = "js-toggleRightNavLg")]
        public IWebElement btnRightNav { get; set; }

        [FindsBy(How = How.Id, Using = "rightNav-createAccount")]
        public IWebElement btnRightNavCreateAccount { get; set; }


        public void LinkToSignUpPage()
        {
            btnRightNav.Click();
            btnRightNavCreateAccount.Click();
        }

        public SignInPageObject SignUp(string uname, string fname, string lname, string pword)
        {
            txtUsername.SendKeys(uname);
            txtFirstname.SendKeys(fname);
            txtLastname.SendKeys(lname);
            txtPassword.SendKeys(pword);
            btnCreateAccount.Click();

            return new SignInPageObject();
        }
    }
}
