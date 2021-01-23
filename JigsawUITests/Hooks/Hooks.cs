using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace JigsawUITests.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IWebDriver _driver;

        public Hooks(IWebDriver driver)
        {
            _driver = driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}
