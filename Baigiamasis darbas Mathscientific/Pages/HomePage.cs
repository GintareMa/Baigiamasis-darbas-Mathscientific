using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis_darbas_Mathscientific.Pages
{
    public class HomePage
    {
        public static void hoverMouseOnLanguageSymbol()
        {
            string locator = "//*[@alt='lt']";
            Common.performHoverMouse(locator);
        }

        public static void clickButtonToChoseInternationlLanguage()
        {
            string locator = "//*[@class='lang-item']";
            Common.clickElement(locator);
        }

        public static string readEnglishLoginName()
        {
            string locator = "//*[@class='navbar__user-area__login']";
            return Common.getElementText(locator);
        }
    }
}
