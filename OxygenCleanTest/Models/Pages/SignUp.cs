using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace OxygenCleanTest.Models.Pages
{
    class SignUp : BasePage
    {
        By firstNameID = By.Name("firstname");
        By lastNameID = By.Name("lastname");
        By emailID = By.Name("reg_email__");
        By emailConfirmationID = By.Name("reg_email_confirmation__");
        By passID = By.Name("reg_passwd__");
        By sexID = By.Name("sex"); //lista
        By birthday_monthID = By.Id("month");
        By birthday_dayID = By.Id("day");
        By birthday_yearID = By.Id("year");
        By submitButtonID = By.Name("websubmit");

        public SignUp(IWebDriver driver) : base(driver, "signup", "Sign Up for Facebook | Facebook")
        {
        }

        public void CreateAccount(string firstName, string lastName, string email, string passw, DateTime birthday, string sex)
        {
            findAndSendKey(firstNameID, firstName);
            findAndSendKey(lastNameID, lastName);
            findAndSendKey(emailID, email);
            findAndSendKey(emailConfirmationID, email);
            findAndSendKey(passID, passw);
            Driver.FindElements(sexID)[1].Click();

            selectFromDropDown(birthday_monthID, birthday.Month.ToString());
            selectFromDropDown(birthday_dayID, birthday.Day.ToString());
            selectFromDropDown(birthday_yearID, birthday.Year.ToString());

            //Driver.FindElement(submitButtonID).Click();
        }
    }
}
