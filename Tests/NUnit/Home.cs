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
            //HomePage.closeCokies();
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
