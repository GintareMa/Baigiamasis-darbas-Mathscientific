using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;

namespace Baigiamasis_darbas_Mathscientific
{
    public class Driver
    {
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public static void setDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--window-size=1600,1000");

            driver.Value = new ChromeDriver(options);
 //           driver.Value.Manage().Window.Maximize(); paliktas lango pilnas ispletimas
            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void takeScreenshot()
        {
            string screenshotsPath = $"{AppDomain.CurrentDomain.BaseDirectory}screenshots";
            string screenshotName = $"{screenshotsPath}\\src-{Guid.NewGuid()}.png";

            Directory.CreateDirectory(screenshotsPath);
            Screenshot screenshot = ((ITakesScreenshot)Driver.getDriver()).GetScreenshot();
            screenshot.SaveAsFile(screenshotName, ScreenshotImageFormat.Png);
        }

        public static IWebDriver getDriver()
        {
            return driver.Value;
        }

        public static void open(string url)
        {
            driver.Value.Url = url;
        }

        public static void closeDriver()
        {
            driver.Value.Quit();
        }
    }
}
