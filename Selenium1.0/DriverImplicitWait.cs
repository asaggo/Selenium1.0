using System;

namespace Selenium1._0
{
    internal class DriverImplicitWait : IDisposable
    {
        public DriverImplicitWait()
        {
            Properties.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void Dispose()
        {
            Properties.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            //throw new NotImplementedException();
        }
    }
}