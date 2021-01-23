using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Pages.LoginPage
{
    /// <summary>
    /// Login page elements.
    /// </summary>
    public partial class Login
    {
        [FindsBy(How = How.Id, Using = "btnFirstTimeUser")]
        private readonly IWebElement _firstTimeUserButton;

        [FindsBy(How = How.Id, Using = "txtEmail")]
        private readonly IWebElement _emailAddressField;

        [FindsBy(How = How.Id, Using = "btnContinue")]
        private readonly IWebElement _continueButton;
    }
}
