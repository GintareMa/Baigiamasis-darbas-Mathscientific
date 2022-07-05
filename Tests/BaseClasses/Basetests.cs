using Baigiamasis_darbas_Mathscientific;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests.BaseClasses
{
    public class Basetests
    {
        [SetUp]

        public static void setup()
        {
            Driver.setDriver();
        }

        [TearDown]
        public static void close()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.takeScreenshot();
            }

            Driver.closeDriver();
        }
    }
}
