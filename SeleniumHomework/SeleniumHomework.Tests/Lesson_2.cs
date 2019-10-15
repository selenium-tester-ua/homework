using NUnit.Framework;
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
    }
}
