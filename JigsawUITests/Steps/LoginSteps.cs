using JigsawUITests.Objects;
using Pages.LoginPage;
using System;
using TechTalk.SpecFlow;

namespace JigsawUITests.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        private string _email = new Random().Next(10000, 99999).ToString() + "@test.com" ;
        private readonly Login login;
        private readonly MyProfileForm myProfileForm;

        public LoginSteps(Login login, MyProfileForm myProfileForm)
        {
            this.login = login;
            this.myProfileForm = myProfileForm;
        }

        [Given(@"Navigate to Login page")]
        public void GivenNavigateToLoginPage()
        {
            this.login.NavigateToLoginPage();
        }

        [When(@"Click on First Time User button")]
        public void WhenClickOnFirstTimeUserButton()
        {
            this.login.ClickFirstTimeButton();
        }

        [When(@"Enter my email")]
        public void WhenEnterMyEmail()
        {
            this.login.EnterEmailAdress(_email);
            myProfileForm.EmailAddress = _email;
        }

        [When(@"Click Continue button")]
        public void WhenClickContinueButton()
        {
            this.login.ClickContinueButton();
        }

        [Then(@"I am on My Profile page with title ""(.*)""")]
        [Then(@"I am on Login page with title ""(.*)""")]
        public void ThenIAmOnLoginPageWithTitle(string pageTitle)
        {
            this.login.AssertPageTitle(pageTitle);
        }
    }
}
