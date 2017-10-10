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
            string title = driver.Title;
            Assert.AreEqual(title, "Oxygen Clean");
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }

    }
}
