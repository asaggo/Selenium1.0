using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium1._0
{
    enum PropertyType
    {
        Id,
        Name,
        ClassName,
        CssName,
        LinkText
    }

    class Properties
    {
        public static IWebDriver driver { get; set; }
    }
}
