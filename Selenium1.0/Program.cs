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
            Properties.driver.Navigate().GoToUrl("https://www.target.com/");
            Console.WriteLine("Open URL");
        }

        [Test]
        public void ExecuteTest_Search()
        {
            /*
            IWebElement element = Properties.driver.FindElement(By.Name("q"));
            element.SendKeys("Jessie Ji");
            */
            
            Console.WriteLine("Execute Test - Search");
        }

        [Test]
        public void ExecuteTest_SignUp()
        {
            SetMethods.Click("js-toggleRightNavLg", "Id");
            SetMethods.Click("rightNav-createAccount", "Id");


            SetMethods.EnterText("username", "asaggo", "Id");
            SetMethods.EnterText("firstname", "jessie", "Id");
            SetMethods.EnterText("lastname", "ji", "Id");
            SetMethods.EnterText("password", "1234qwer", "Id");
            SetMethods.Click("createAccount", "Id");
            Console.WriteLine("Execute Test - SignUp");
        }
        
        [Test]
        public void Signup_InputTest()
        {

            SetMethods.Click("js-toggleRightNavLg", "Id");
            SetMethods.Click("rightNav-createAccount", "Id");

            try
            {

            }
            catch (NoSuchElementException e)
            {

            }

            SetMethods.Click("js-toggleRightNavLg", "Id");
            SetMethods.Click("rightNav-createAccount", "Id");


            SetMethods.EnterText("username", "asaggo", "Id");
            SetMethods.EnterText("firstname", "jessie", "Id");
        }
        
        [TearDown]
        public void CleanUp()
        {
            //Properties.driver.Close();
            Console.WriteLine("Close browser");
        }
    }
}
