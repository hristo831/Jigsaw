using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Pages.MyProfilePage
{
    /// <summary>
    /// My Profile page elements.
    /// </summary>
    public partial class MyProfile
    {
        [FindsBy(How = How.Id, Using = "EmailAddress")]
        private readonly IWebElement _emailAddress;

        [FindsBy(How = How.Id, Using = "Password")]
        private readonly IWebElement _password;

        [FindsBy(How = How.Id, Using = "ConfirmPassword")]
        private readonly IWebElement _confirmPassword;

        [FindsBy(How = How.Id, Using = "FirstName")]
        private readonly IWebElement _firstName;

        [FindsBy(How = How.Id, Using = "LastName")]
        private readonly IWebElement _lastName;

        [FindsBy(How = How.CssSelector, Using = "input[name = 'CountryId_input']")]
        private readonly IWebElement _country;

        [FindsBy(How = How.CssSelector, Using = "input[name = 'RegionId_input']")]
        private readonly IWebElement _stateRegion;

        [FindsBy(How = How.CssSelector, Using = "input[name = 'CityId_input']")]
        private readonly IWebElement _city;

        [FindsBy(How = How.CssSelector, Using = "input[name = 'TimeZoneInfoId_input']")]
        private readonly IWebElement _timeZone;

        [FindsBy(How = How.CssSelector, Using = "label[class = 'k-checkbox-label']")]
        private readonly IWebElement _useSecurityQuestions;

        [FindsBy(How = How.Id, Using = "SecurityQuestionAnswer1")]
        private readonly IWebElement _firstSecurityQuestionAnswer;

        [FindsBy(How = How.Id, Using = "SecurityQuestionAnswer2")]
        private readonly IWebElement _secondSecurityQuestionAnswer;

        [FindsBy(How = How.Id, Using = "SecurityQuestionAnswer3")]
        private readonly IWebElement _thirdSecurityQuestionAnswer;

        [FindsBy(How = How.Id, Using = "Presenter_File")]
        private readonly IWebElement _presenterFile;

        [FindsBy(How = How.Id, Using = "saveButton")]
        private readonly IWebElement _save;
    }
}
