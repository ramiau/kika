using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace kika
{
    public class Tests
    {
        private ChromeDriver _driver;
        [SetUp]
        public void Setup()
        {
            var option = new ChromeOptions();
            option.AddArgument("incognito");
            _driver = new ChromeDriver(option);
            _driver.Manage().Window.Maximize();

            _driver.Url = "https://www.kika.lt";

        }

        [Test]
        public void Test1()
        {
            _driver.FindElement(By.CssSelector("#editable_popup[style*'display: block;'] .close")).Click();

            Assert.Pass();

            _driver.Quit();
        }
    }
}