using Baigiamasis_darbas_Mathscientific.Pages;
using NUnit.Framework;
using Tests.BaseClasses;

namespace Tests
{
    public class Home : Basetests
    {
        [SetUp]
        public static void openPage()
        {
            HomePage.open();

            //HomePage.clickCloseSuscriberButtonWhichEnabledAfter15sec();
            //HomePage.closeCokiesWithButtonOnlyEssentials();
        }

        [Test]
        public static void switchLanguagefromLtToEn()
        {
            string excpectedMessage = "Log In";
            HomePage.hoverMouseOnLanguageSymbol();
            HomePage.clickButtonToChoseInternationlLanguage();
            string actualMessage = HomePage.readEnglishLoginName();
            Assert.AreEqual(excpectedMessage, actualMessage);
        }

        [Test]
        public static void openMenu()
        {
            string expectedChoosedMenuText = "Mokslas";
            HomePage.moveMouseOnMenu();
            string actualChoosedMenuText = HomePage.readTextFromChoosedMenu();

            Assert.AreEqual(expectedChoosedMenuText, actualChoosedMenuText);

            HomePage.closeMenu();
        }
    }
}
