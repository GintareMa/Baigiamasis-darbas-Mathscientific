using Baigiamasis_darbas_Mathscientific.Pages;
using NUnit.Framework;
using Tests.BaseClasses;

namespace Tests.NUnit
{
    public class Home : Basetests
    {
        [SetUp]
        public static void openPage()
        {
            HomePage.open();
        }

        [Test, Order (1)]
        public static void switchLanguagefromLtToEn()
        {
            HomePage.hoverMouseOnLanguageSymbol();
            HomePage.clickButtonToChoseInternationlLanguage();
            string actualMessage = HomePage.readEnglishLoginName();
            Assert.IsTrue(actualMessage.Contains("Log In"));
        }

        [Test, Order (2)]
        public static void openMenu()
        {
            string expectedChoosedMenuText = "Mokslas";
            HomePage.moveMouseOnMenu();
            string actualChoosedMenuText = HomePage.readTextFromChoosedMenu();

            Assert.AreEqual(expectedChoosedMenuText, actualChoosedMenuText);

            HomePage.closeMenu();
        }

        [Test]
        public static void joinToSubscribersClub()
        {
            string name = "Saule";

            string expectedSubscriberMessage = "Dėkojame, kad prenumeruojate mūsų naujienas!";
            HomePage.enterEmail();
            HomePage.enterName(name);
            HomePage.cklickOnSkinType();
            HomePage.cklickOnNormaliOda();
            HomePage.cklickButtonSubscribeNewsletter();
            string actualSubscriberMessage = HomePage.readConfirmationMessageAfterSubscribe();

            Assert.AreEqual(expectedSubscriberMessage, actualSubscriberMessage, "Invalid provided information");

            HomePage.closeSubscriberWindow();
        }
    }
}
