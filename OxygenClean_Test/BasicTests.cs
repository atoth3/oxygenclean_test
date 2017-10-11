using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace OxygenClean_Test
{
    class BasicTests
    {
        IWebDriver driver;
        ChromeOptions options = new ChromeOptions();

        [SetUp]
        public void Initialize()
        {
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(options);
        }
        [Test]
        public void BackToMainPage()
        {
            driver.Url = "http://www.oxygenclean.hu/";

            driver.FindElement(By.XPath("//A[@href='http://www.oxygenclean.hu/kapcsolat/'][text()='Kapcsolat']"))
                .Click();

            driver.Navigate().Back();
            string title = driver.Title;
            Assert.AreEqual(title, "Oxygen Clean");
        }
        [Test]
        public void ClickToContact()
        {
            driver.Url = "http://www.oxygenclean.hu/";

            By Locator = By.XPath("//A[@href='http://www.oxygenclean.hu/ajanlatot-kerek/'][text()='Ajánlatot kérek']");

            IWebElement askOffer = driver.FindElement(Locator);

            askOffer.Click();

            IWebElement name = driver.FindElement(By.XPath("//INPUT[@id='ninja_forms_field_25']"));

            name.Submit();

            string title = driver.Title;
            Assert.AreEqual(title, "Ajánlatot kérek | Oxygen Clean");
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
