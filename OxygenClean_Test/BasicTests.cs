using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace OxygenClean_Test
{
    class BasicTests
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void openPage()
        {
            driver.Url = "http://www.oxygenclean.hu/";
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }

    }
}
