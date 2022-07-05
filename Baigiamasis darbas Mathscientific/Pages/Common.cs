using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis_darbas_Mathscientific.Pages
{
    internal class Common
    {
        internal static IWebElement getElement(string locator)
        {
            return Driver.getDriver().FindElement(By.XPath(locator));
        }

        internal static void performHoverMouse(string locator)
        {
            IWebElement element = getElement(locator);
            Actions actions = new Actions(Driver.getDriver());

            actions.MoveToElement(element).Perform();
        }

        internal static void clickElement(string locator)
        {
            getElement(locator).Click();
        }

        internal static string getElementText(string locator)
        {
            return getElement(locator).Text;
        }
    }
}
