using System;

namespace Baigiamasis_darbas_Mathscientific.Pages
{
    public class HomePage
    {
        public static void open()
        {
            Driver.open("https://mathscientific.com/lt/");
        }

        public static void closeCokies()
        {
            string locator = "//*[@id='CybotCookiebotDialog' and contains(@class,'CybotCookiebotDialogActive')]//*[@id='CybotCookiebotDialogBodyButtonDecline']";
            Common.waitForElementToBeVisible(locator);
            Common.clickElement(locator);
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

        public static void cklickOnNormaliOda()
        {
            string locator = "//select[@class='soundest-form-image-right-field-dropdown']/option[2]";
            Common.clickElement(locator);
        }

        public static string readConfirmationMessageAfterSubscribe()
        {
            string locator = "//*[@class='soundest-form-image-right-headline soundest-form-image-right-state-success-subscribed']";
            return Common.getElementText(locator);
        }

        public static void closeSubscriberWindow()
        {
            string locator = "//*[@class='soundest-form-image-right-close']";
            Common.clickElement(locator);
        }

        public static void cklickButtonSubscribeNewsletter()
        {
            string locator = "//input[@class='soundest-form-image-right-submit']";
            Common.clickElement(locator);
        }

        public static void cklickOnSkinType()
        {
            string locator = "//select[@class='soundest-form-image-right-field-dropdown']";
            Common.clickElement(locator);
        }

        public static void enterName(string name)
        {
            string locator = "//input[@name='omnisend-name']";
            Common.sendKeysToElement(locator, name);
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

        public static void enterEmail()
        { 
            Random r = new Random();
            string locator = "//input[@name='omnisend-email']";
            string email = String.Format($"katinas{r.Next(1000)}@gmail.com");
            Common.waitForElementToBeCkilkable(locator);
            Common.sendKeysToElement(locator, email);
        }
    }
}
