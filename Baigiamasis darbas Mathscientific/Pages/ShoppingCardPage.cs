namespace Baigiamasis_darbas_Mathscientific.Pages
{
    public class ShoppingCardPage
    {
        public static void cklickOnKolagenasFromTheList()
        {
            string locator = "//*[@id='menu-item-62473']";
            Common.clickElement(locator);
        }

        public static void cklickOnTheKolagenasSuAvietemis()
        {
            string locator = "//*[text()='Grynas kolagenas su avietėmis']";
            Common.clickElement(locator);
        }

        public static string readMessageInBasket()
        {
            string locator = "//*[text()='Produktas sėkmingai įdėtas į krepšelį.']";
            Common.waitForElementToBeVisible(locator);
            return Common.getElementText(locator);
        }

        public static void addProductSuAvietemisToShoppCard()
        {
            string locator = "//*[@data-name='Grynas kolagenas su avietėmis']";
            Common.clickElement(locator);
        }
    }
}
