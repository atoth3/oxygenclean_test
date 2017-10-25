using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OxygenCleanTest.Models.Pages;
using System;

namespace OxygenCleanTest
{
    public class BasicTests
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
        public void openPage()
        {
            LogIn loginPage = new LogIn(driver);

            driver.Url = loginPage.url;
            Assert.AreEqual(driver.Title, loginPage.title);
        }

        [Test]
        public void signIn_from_LoginPage_with_Bad_Email()
        {
            string user = "kicsi";
            string pass = "kocsi";

            LogIn loginPage = new LogIn(driver);
            driver.Url = loginPage.url;

            loginPage.SignIn(user, pass);
        }

        [Test]
        public void signUp_form_LoginPage_with_Bad_User()
        {
            SignUp signUp = new SignUp(driver);
            driver.Url = signUp.url;

            signUp.CreateAccount("kis", "pista", "pista@gmail.com", "nope123?", new DateTime(1988, 01, 28), "male");
        }

        [TearDown]
        public void EndTest()
        {
            //driver.Close();
        }
    }
}
