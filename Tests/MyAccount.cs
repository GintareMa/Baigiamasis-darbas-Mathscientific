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
            //HomePage.closeCokies();
        }

        [Test]
        public static void createAccountWithAlreadyExistingCredentials()
        {
            string registrationEmail = "saule@saule.lt";
            string registrationPassword = "KatinasSuo01!";
            string expectedMessage = "Klaida: Paskyra su tokiu el.pašto adresu jau yra sukurta. Prisijunkite.";
            MyAccountPage.navigateToRegistrationPage();
            MyAccountPage.enterEmail(registrationEmail);
            MyAccountPage.enterPassword(registrationPassword);
            MyAccountPage.clickRegistrationButton();
            string actualMessage = MyAccountPage.readErrorMessage();
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public static void loginWithExistingCredentials()
        {
            string loginEmail = "saule@saule.lt";
            string loginPassword = "KatinasSuo01!";
            string expectedMessageAfterLogin = "Mano paskyra";
            MyAccountPage.navigateToRegistrationPage();
            MyAccountPage.enterUserName(loginEmail);
            MyAccountPage.enterLoginPassword(loginPassword);
            MyAccountPage.clickLoginButton();
            string actualMessage = MyAccountPage.readLoginConfirmationMessage();
            Assert.AreEqual(expectedMessageAfterLogin, actualMessage);

            MyAccountPage.clickLogoutButton();
        }
    }
}
