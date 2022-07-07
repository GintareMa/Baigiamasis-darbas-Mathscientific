using Baigiamasis_darbas_Mathscientific.Pages;
using NUnit.Framework;
using Tests.BaseClasses;

namespace Tests.NUnit
{
    public class Account : Basetests
    {
        [SetUp]
        public static void openPage()
        {
            HomePage.open();
            HomePage.hoverMouseOnLanguageSymbol();
            HomePage.clickButtonToChoseInternationlLanguage();
        }

        [Test]
        public static void createAccountWithAlreadyExistingCredentials()
        {
            string registrationEmail = "saule@saule.lt";
            string registrationPassword = "KatinasSuo01!";
            string expectedMessage = "Klaida: Paskyra su tokiu el.pašto adresu jau yra sukurta. Prisijunkite.";
            AccountPage.navigateToLoginPage();
            HomePage.closeCokies();
            AccountPage.enterEmail(registrationEmail);
            AccountPage.enterPassword(registrationPassword);
            AccountPage.clickRegistrationButton();
            string actualMessage = AccountPage.readErrorMessage();
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public static void loginWithExistingCredentials()
        {
            string loginEmail = "saule@saule.lt";
            string loginPassword = "KatinasSuo01!";
            string expectedMessageAfterLogin = "Mano paskyra";
            AccountPage.navigateToLoginPage();
            HomePage.closeCokies();
            AccountPage.enterUserName(loginEmail);
            AccountPage.enterLoginPassword(loginPassword);
            AccountPage.clickLoginButton();
            string actualMessage = AccountPage.readLoginConfirmationMessage();
            Assert.AreEqual(expectedMessageAfterLogin, actualMessage, "Login is wrong or Enter wasnt completed");

            AccountPage.clickLogoutButton();
        }
    }
}
