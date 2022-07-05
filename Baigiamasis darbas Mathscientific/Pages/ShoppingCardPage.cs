namespace Baigiamasis_darbas_Mathscientific.Pages
{
    public class ShoppingCardPage
    {
        public static void moveMouseOnMaistoPapildai()
        {
            string locator = "//*[@id='menu-item-62457']/a";
            Common.performHoverMouse(locator);
        }

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
                //string locator = "//*[@class='add-to-cart__wrapper']//span";
                //string locator = "//*[@class='added-to-cart-msg__text' and text()='Produktas sėkmingai įdėtas į krepšelį.']";
                string locator = "//*[text()='Produktas sėkmingai įdėtas į krepšelį.']";
                Common.waitForElementToBeVisible(locator);
                //*[contains(text(),'Produktas sėkmingai įdėtas į krepšelį')]";
                //*[@class='added-to-cart-msg__text']";
                //*[contains(text(),'Produktas sėkmingai įdėtas į krepšelį')]
                //span[@class='added-to-cart-msg__text']"

                return Common.getElementText(locator);
        }

        public static void addProductSuAvietemisToShoppCard()
        {
            string locator = "//*[@data-name='Grynas kolagenas su avietėmis']";
            Common.clickElement(locator);
        }
    }
}
