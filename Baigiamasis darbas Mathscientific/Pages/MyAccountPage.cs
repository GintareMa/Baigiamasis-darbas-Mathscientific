using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis_darbas_Mathscientific.Pages
{
    public class MyAccountPage
    {
        public static void navigateToRegistrationPage()
        {
            string locator = "//*[@class='navbar__user-area__login']";
            Common.clickElement(locator);
        }

        public static void enterEmail(string name)
        {
            string locator = "//*[@id='reg_email']";
            Common.sendKeysToElement(locator, name);
        }

        public static void enterPassword(string name)
        {
            string locator = "//*[@id='reg_password']";
            Common.sendKeysToElement(locator, name);
        }

        public static void clickRegistrationButton()
        {
            string locator = "//*[@value='Registruotis']";
            Common.clickElement(locator);
        }

        public static string readErrorMessage()
        {
            string locator = "//*[@id='content']//*[text()=' Paskyra su tokiu el.pašto adresu jau yra sukurta. ']";
            //*[@id="content"]/div/div/div[1]/ul/li/text()
            return Common.getElementText(locator);
        }
    }
}
