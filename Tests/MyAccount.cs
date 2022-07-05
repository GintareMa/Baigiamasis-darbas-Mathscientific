using Baigiamasis_darbas_Mathscientific.Pages;
using NUnit.Framework;
using Tests.BaseClasses;

namespace Tests
{
    public class MyAccount : Basetests
    {
        [SetUp]
        public static void openPage()
        {
            HomePage.open();

            //HomePage.clickCloseSuscriberButtonWhichEnabledAfter15sec();
            //HomePage.closeCokiesWithButtonOnlyEssentials();
        }

        [Test]
        public static void createAccountWithAlreadyExistingCredentials()
        {
            string email = "saule@saule.lt";
            string password = "KatinasSuo01!";
            string expectedMessage = "Klaida: Paskyra su tokiu el.pašto adresu jau yra sukurta. Prisijunkite.";
            MyAccountPage.navigateToRegistrationPage();
            MyAccountPage.enterEmail(email);
            MyAccountPage.enterPassword(password);
            MyAccountPage.clickRegistrationButton();
            string actualMessage = MyAccountPage.readErrorMessage();
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
