using OpenQA.Selenium;
using System;
using System.Threading;

namespace SeleniumWebDriver
{
    /// <summary>
    /// Implement custom wait methods.
    /// </summary>
    public class CustomWaits
    {
        /// <summary>
        /// Wait until element displayed.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="reTryCount"></param>
        /// <returns></returns>
        public static bool WaitUntilElementDisplayed(IWebElement element, int reTryCount = 40)
        {
            for (int i = 0; i < reTryCount; i++)
            {
                try
                {
                    if (element.Displayed.Equals(true))
                        return element.Displayed;
                }
                catch (NoSuchElementException)
                {
                }
                Thread.Sleep(TimeSpan.FromMilliseconds(250));
            }
            return false;
        }
    }
}
