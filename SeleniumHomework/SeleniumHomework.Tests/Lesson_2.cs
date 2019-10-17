using NUnit.Framework;
using OpenQA.Selenium;
using Tests;

namespace SeleniumHomework.Tests
{
    [TestFixture]
    public class Lesson_2 : TestBase
    {
        [Test]
        public void Task_1()
        {
            _driver.Navigate().GoToUrl("https://www.google.com");
        }

        [Test]
        public void Task_3()
        {
            _driver.Navigate().GoToUrl("http://localhost/litecart/admin/");
            _wait.Until(d => d.FindElement(By.Name("username")));
            _driver.FindElement(By.Name("username")).SendKeys("admin");
            _driver.FindElement(By.Name("password")).SendKeys("admin");
            _driver.FindElement(By.Name("login")).Click();
            _wait.Until(d => d.FindElement(By.ClassName("logotype")));
        }
    }
}
