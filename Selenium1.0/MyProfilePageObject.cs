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
    class MyProfilePageObject : PageObject
    {
        public MyProfilePageObject()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        public void LinkToMyProfile()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".signed-in"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[href*='/member/profile/index.htm']"))).Click();
        }

        public void ChangePreferences()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("PreferencesTab"))).Click();
            checkJobStatusElements();
        }

        public void checkJobStatusElements()
        {
            using (new DriverImplicitWait())
            {
                //check header text
                Assert.AreEqual(Properties.driver.FindElement(By.CssSelector(".profileHeading.padTopMd.ib")).Text, "Job Search Status");
                

                /* NEED TO FIGURE OUT HOW TO DELAY ASSERT WHILE RUNNING JAVASCRIPT
                IWebElement searchJobStatusBtn = Properties.driver.FindElement(By.CssSelector(".theme__knob___3Lgum.jobSearchStatusStyle__knob___JbYM1"));
                IJavaScriptExecutor js = Properties.driver as IJavaScriptExecutor;
                js.ExecuteScript("arguments[0].style='left:66.6667%'", searchJobStatusBtn);
                IWebElement searchJobStatusBar = Properties.driver.FindElement(By.CssSelector(".theme__innerknob___3mTgP.jobSearchStatusStyle__innerknob___x8JKt"));
                js.ExecuteScript("document.querySelector('.theme__innerknob___3mTgP.jobSearchStatusStyle__innerknob___x8JKt').setAttribute('data-value', '3')");
                Assert.AreEqual(Properties.driver.FindElement(By.CssSelector(".jobSearchStatusStyle__bold___9iRe7")).Text, "Casually looking");
                
                js.ExecuteScript("arguments[0].style='left:0%'", searchJobStatusBtn);
                js.ExecuteScript("document.querySelector('.theme__innerknob___3mTgP.jobSearchStatusStyle__innerknob___x8JKt').setAttribute('data-value', '1')");
                Assert.AreEqual(Properties.driver.FindElement(By.CssSelector(".jobSearchStatusStyle__bold___9iRe7")).Text, "Not looking");
                */
            }
        }
    }
}