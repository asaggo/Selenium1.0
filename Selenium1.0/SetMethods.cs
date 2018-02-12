using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium1._0
{
    class SetMethods
    {
        public static void EnterText(string elementName, string value, PropertyType elementType)
        {

            WebDriverWait wait = new WebDriverWait(Properties.driver, TimeSpan.FromSeconds(15));
            if (elementType == PropertyType.Id)
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(elementName))).SendKeys(value);
            else if (elementType == PropertyType.Name)
                Properties.driver.FindElement(By.Name(elementName)).SendKeys(value);
        }

        //click a button, checkbox etc
        public static void Click(string elementName, PropertyType elementType)
        {
            WebDriverWait wait = new WebDriverWait(Properties.driver, TimeSpan.FromSeconds(15));

            if (elementType == PropertyType.Id)
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(elementName))).Click();
            else if (elementType == PropertyType.Name)
                Properties.driver.FindElement(By.Name(elementName)).Click();
            else if (elementType == PropertyType.ClassName)
                Properties.driver.FindElement(By.ClassName(elementName)).Click();
        }

        public static void SelectDropDown(string elementName, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                new SelectElement(Properties.driver.FindElement(By.Id(elementName))).SelectByValue(value);
            else if (elementType == PropertyType.Name)
                new SelectElement(Properties.driver.FindElement(By.Name(elementName))).SelectByValue(value);
            else if (elementType == PropertyType.ClassName)
                new SelectElement(Properties.driver.FindElement(By.ClassName(elementName))).SelectByValue(value);
        }

        public static void HoverAndClick(IWebElement elementToHover, IWebElement elementToClick)
        {
            Actions action = new Actions(Properties.driver);
            action.MoveToElement(elementToHover).Click(elementToClick);

        }
    }
}
