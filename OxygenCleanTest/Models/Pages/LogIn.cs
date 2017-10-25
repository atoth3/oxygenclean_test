using OpenQA.Selenium;

namespace OxygenCleanTest.Models.Pages
{
    class LogIn : BasePage
    {

        By emailID = By.Id("email");
        By passID = By.Id("pass");
        By loginButtonID = By.Id("loginbutton");

        public LogIn(IWebDriver driver) : base(driver, "login", "Log into Facebook | Facebook")
        {
        }

        public void SignIn(string email, string pass)
        {
            IWebElement elementEmail = Driver.FindElement(emailID);
            IWebElement elementPass = Driver.FindElement(passID);
            IWebElement elementLoginButton = Driver.FindElement(loginButtonID);

            elementEmail.SendKeys(email);
            elementPass.SendKeys(pass);

            elementLoginButton.Click();
        }
    }
}
