using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium1._0
{
    class SignInPageObject : PageObject
    {
        public SignInPageObject()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        [FindsBy(How = How.Id, Using = "signInEmail")]
        public IWebElement txtUsername { get; set; }

        [FindsBy(How = How.Id, Using = "signInPassword")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.CssSelector,Using = "loginDlgSignInBtn.gd-btn.gd-btn-button.gd-btn-1.gd-btn-med.gradient")]
        public IWebElement btnSignIn { get; set; }

        public void LinkToLoginPage()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".sign-in"))).Click();
        }

        public void Login(string uname, string pword)
        {
            //cannot use these because I need to use "wait until exists"
            //txtUsername.SendKeys(uname);
            //txtPassword.SendKeys(pword);
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("signInUsername"))).SendKeys(uname);
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("signInPassword"))).SendKeys(pword);
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".loginDlgSignInBtn.gd-btn.gd-btn-button.gd-btn-1.gd-btn-med.gradient"))).Click();
        }
        public void checkUserEmailAfterSignIn()
        {
            using (new DriverImplicitWait())
            {
                try
                {
                    IWebElement temp = Properties.driver.FindElement(By.CssSelector(".userEmail"));
                    Assert.AreEqual(temp.Text, "asaggo0717@gmail.com");
                }
                catch (NoSuchElementException e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }
    }
}
