namespace Baigiamasis_darbas_Mathscientific.Pages
{
    public class HomePage
    {
        public static void open()
        {
            Driver.open("https://mathscientific.com/lt/");
        }

        public static void hoverMouseOnLanguageSymbol()
        {
            string locator = "//*[@id='menu-language-switcher']";
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

        public static void moveMouseOnMenu()
        {
            string locator = "//*[@class='main-navigation__toggler-content']";
            Common.performHoverMouse(locator);
            
        }

        public static string readTextFromChoosedMenu()
        {
            string locator = "//*[@id='menu-item-154']//a[@href='#']";
            return Common.getElementText(locator);
        }

        public static void closeMenu()
        {
            string locator = "//*[@class='main-navigation__toggler-content']";
            Common.clickElement(locator);
        }
    }
}
