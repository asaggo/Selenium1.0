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
    class SignUpPageObject : PageObject
    {
        public SignUpPageObject()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        [FindsBy(How = How.Id,Using = "signUpEmail")]
        public IWebElement txtSignUpEmail { get; set; }
        
        [FindsBy(How = How.Id,Using ="signUpPassword")]
        public IWebElement txtSignUpPassword { get; set; }
        
        [FindsBy(How = How.CssSelector,Using ="loginDlgSignUpBtn.gd-btn.gd-btn-button.gd-btn-1g.gd-btn-med.gradient")]
        public IWebElement btnCreateAccount { get; set; }
        
        [FindsBy(How = How.ClassName,Using ="sign-in")]
        public IWebElement btnSignIn { get; set; }

        [FindsBy(How = How.ClassName,Using ="link altSignUp padLtSm")]
        public IWebElement btnSignUp { get; set; }
        

        public void LinkToSignUpPage()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".sign-in"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".link.altSignUp.padLtSm"))).Click();
        }

        public void SignUp(string email, string password)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("signUpEmail"))).SendKeys(email);
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("signUpPassword"))).SendKeys(password);
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".loginDlgSignUpBtn.gd-btn.gd-btn-button.gd-btn-1.gd-btn-med.gradient"))).Click();
        }
    }
}
