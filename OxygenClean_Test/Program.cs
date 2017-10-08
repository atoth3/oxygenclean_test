using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace OxygenClean_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new ChromeOptions();
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "http://www.oxygenclean.hu/";
        }
    }
}
