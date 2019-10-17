using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace Tests
{
    [TestFixture]
    public class TestBase
    {
        private string _pathToDriver = 
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        protected IWebDriver _driver;
        protected WebDriverWait _wait;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver(_pathToDriver);
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(2));
            _driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            _driver?.Quit();
        }
    }
}