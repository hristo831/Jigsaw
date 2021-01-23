using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages.Base
{
    /// <summary>
    /// Implement common method.
    /// </summary>
    public class BaseOperations : BasePage
    {
        /// <summary>
        /// Initializes a new instance of the BaseOperations class.
        /// </summary>
        /// <param name="driver"></param>
        public BaseOperations(IWebDriver driver)
            : base(driver)
        {
        }

        /// <summary>
        /// Select element from dropdown by value.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public void SelectElementFromDropdownByValue(IWebElement element, string value)
        {
            SelectElement selectedElement = new SelectElement(element);
            selectedElement.SelectByValue(value);
        }

        /// <summary>
        /// Assert page title.
        /// </summary>
        /// <param name="pageTitle"></param>
        public void AssertPageTitle(string pageTitle)
        {
            Assert.AreEqual(Driver.Title, pageTitle);
        }
    }
}
