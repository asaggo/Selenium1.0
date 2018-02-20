using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium1._0
{
    class PageObject
    {
        public WebDriverWait wait = new WebDriverWait(Properties.driver, TimeSpan.FromSeconds(10));

        public void LinkToMainPage()
        {
            Properties.driver.Url = "https://www.glassdoor.com/";
            Properties.driver.Navigate();
        }
    }
}
