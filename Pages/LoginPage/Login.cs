using OpenQA.Selenium;
using Pages.Base;
using TestConfiguration;

namespace Pages.LoginPage
{
    /// <summary>
    /// Login page action methods.
    /// </summary>
    public partial class Login : BaseOperations
    {
        /// <summary>
        /// Initializes a new instance of the Login class.
        /// </summary>
        /// <param name="driver"></param>
        public Login(IWebDriver driver)
            : base(driver)
        {
        }

        /// <summary>
        /// Navigate to Login page.
        /// </summary>
        public void NavigateToLoginPage()
        {
            Driver.Navigate().GoToUrl(Configurator.Settings.BaseUrl);
        }

        /// <summary>
        /// Click First Time button.
        /// </summary>
        public void ClickFirstTimeButton()
        {
            _firstTimeUserButton.Click();
        }

        /// <summary>
        /// Enter Email Adress.
        /// </summary>
        /// <param name="email"></param>
        public void EnterEmailAdress(string email)
        {
            _emailAddressField.SendKeys(email);
        }

        /// <summary>
        /// Click Continue button.
        /// </summary>
        public void ClickContinueButton()
        {
            _continueButton.Click();
        }
    }
}
