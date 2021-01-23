using NUnit.Framework;
using SeleniumWebDriver;

namespace Pages.MyProfilePage
{
    /// <summary>
    /// My Profile page asserts methods.
    /// </summary>
    public partial class MyProfile
    {
        /// <summary>
        /// Assert Email Address is pre-populated.
        /// </summary>
        /// <param name="email"></param>
        public void AssertEmailAddressIsPrepopulated(string email)
        {
            CustomWaits.WaitUntilElementDisplayed(_emailAddress);
            Assert.AreEqual(email, _emailAddress.GetAttribute("value"));
        }

        /// <summary>
        /// Assert session list is empty.
        /// </summary>
        public void AssertSessionListIsEmpty()
        {

        }
    }
}
