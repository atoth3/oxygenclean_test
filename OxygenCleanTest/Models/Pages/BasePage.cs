using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OxygenCleanTest.Models.Pages
{
    public class BasePage
    {
        private string URL;

        private string Title;
        protected IWebDriver Driver;

        public BasePage(IWebDriver driver, string pageName, string title)
        {
            URL = "https://www.facebook.com/" + pageName;
            Title = title;
            Driver = driver;
        }

        public string title
        {
            get
            {
                return Title;
            }
        }


        public string url
        {
            get
            {
                return URL;
            }
        }

        public void findAndSendKey(By id, string key)
        {
            Driver.FindElement(id).SendKeys(key);
        }

        public void selectFromDropDown(By id, string value)
        {
            SelectElement oSelect = new SelectElement(Driver.FindElement(id));
            oSelect.SelectByValue(value);
        }
    }
}
