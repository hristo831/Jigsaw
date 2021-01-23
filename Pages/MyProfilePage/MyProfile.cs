using OpenQA.Selenium;
using Pages.Base;
using SeleniumWebDriver;
using TestConfiguration;

namespace Pages.MyProfilePage
{
    /// <summary>
    /// My Profile page action methods.
    /// </summary>
    public partial class MyProfile : BaseOperations
    {
        /// <summary>
        /// Initializes a new instance of the MyProfile class.
        /// </summary>
        /// <param name="driver"></param>
        public MyProfile(IWebDriver driver)
            : base(driver)
        {
        }

        /// <summary>
        /// Fill My Profile form.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="confirmPassword"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="firstSecurityQuestionAnswer"></param>
        /// <param name="secondSecurityQuestionAnswer"></param>
        /// <param name="thirdSecurityQuestionAnswer"></param>
        public void FillMyProfileForm(
            string password,
            string confirmPassword,
            string firstName,
            string lastName,
            //string country,
            //string stateRegion,
            //string city,
            //string timeZone,
            string firstSecurityQuestionAnswer,
            string secondSecurityQuestionAnswer,
            string thirdSecurityQuestionAnswer)
        {
            CustomWaits.WaitUntilElementDisplayed(_password);

            _password.SendKeys(password);
            _confirmPassword.SendKeys(confirmPassword);
            _firstName.SendKeys(firstName);
            _lastName.SendKeys(lastName);
            //SelectElementFromDropdownByValue(_country, country);
            //SelectElementFromDropdownByValue(_stateRegion, stateRegion);
            //SelectElementFromDropdownByValue(_city, city);
            //SelectElementFromDropdownByValue(_timeZone, timeZone);
            _useSecurityQuestions.Click();
            _firstSecurityQuestionAnswer.SendKeys(firstSecurityQuestionAnswer);
            _secondSecurityQuestionAnswer.SendKeys(secondSecurityQuestionAnswer);
            _thirdSecurityQuestionAnswer.SendKeys(thirdSecurityQuestionAnswer);
            _presenterFile.SendKeys(Configurator.TryGetSolutionDirectoryInfo() + "/jigsaw.png");
        }

        /// <summary>
        /// Click Save button.
        /// </summary>
        public void ClickSaveButton()
        {
            _save.Click();
        }
    }
}
