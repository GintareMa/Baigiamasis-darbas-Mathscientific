using Baigiamasis_darbas_Mathscientific;
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
            Driver.open("https://mathscientific.com/lt/");

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
    }
}
