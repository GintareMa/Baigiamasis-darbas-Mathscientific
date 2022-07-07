using Baigiamasis_darbas_Mathscientific.Pages;
using NUnit.Framework;
using Tests.BaseClasses;

namespace Tests.NUnit
{
    public class ShoppingCard : Basetests
    {
        [SetUp]
        public static void openPage()
        {
            HomePage.open();
        }

        [Test]
        public static void addToCard()
        {
            string expectedMessage = "Produktas sėkmingai įdėtas į krepšelį.";

            HomePage.moveMouseOnMenu();
            ShoppingCardPage.cklickOnKolagenasFromTheList();
            ShoppingCardPage.cklickOnTheKolagenasSuAvietemis();
            ShoppingCardPage.addProductSuAvietemisToShoppCard();
            string actualMessage = ShoppingCardPage.readMessageInBasket();

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
