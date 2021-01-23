using JigsawUITests.Objects;
using Pages.MyProfilePage;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace JigsawUITests.Steps
{
    [Binding]
    public sealed class MyProfileSteps
    {
        private readonly MyProfile myProfile;
        private readonly MyProfileForm myProfileForm;

        public MyProfileSteps(MyProfile myProfile, MyProfileForm myProfileForm)
        {
            this.myProfile = myProfile;
            this.myProfileForm = myProfileForm;
        }

        [When(@"Fill my profile form")]
        public void WhenFillMyProfileForm(Table myProfileInfo)
        {
            var myProfile = myProfileInfo.CreateInstance<MyProfileForm>();

            this.myProfile.FillMyProfileForm(
                myProfile.Password,
                myProfile.ConfirmPassword,
                myProfile.FirstName,
                myProfile.LastName,
                myProfile.FirstSecurityQuestionAnswer,
                myProfile.SecondSecurityQuestionAnswer,
                myProfile.ThirdSecurityQuestionAnswer);
        }

        [When(@"Click Save button")]
        public void WhenClickSaveButton()
        {
            //this.myProfile.ClickSaveButton();
        }


        [Then(@"Email is pre-populated from Login page")]
        public void ThenEmailIsPre_PopulatedFromLoginPage()
        {
            this.myProfile.AssertEmailAddressIsPrepopulated(this.myProfileForm.EmailAddress);
        }

        [Then(@"I am on My Sessions page with title ""(.*)""")]
        public void ThenIAmOnMySessionsPageWithTitle(string pageTitle)
        {
            //this.myProfile.AssertPageTitle(pageTitle);
        }

        [Then(@"Session list is empty")]
        public void ThenSessionListIsEmpty()
        {
            this.myProfile.AssertSessionListIsEmpty();
        }

    }
}
