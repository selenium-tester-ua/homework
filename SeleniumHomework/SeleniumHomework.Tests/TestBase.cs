using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver(_pathToDriver);
        }

        [TearDown]
        public void TearDown()
        {
            _driver?.Quit();
        }
    }
}