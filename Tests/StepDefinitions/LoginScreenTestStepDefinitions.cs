using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Current_Project
{
    [Binding]
    public class LoginScreenTestStepDefinitions : TestBaseDriver
    {
        Navigate navigate = new Navigate();
        HomePage homePage = new HomePage();
   
        [Given(@"User has navigated to website")]
        public void GivenUserHasNavigatedToWebsite()
        {                                       // enter URL
            navigate.CNavigate ( _driver, "https://www.saucedemo.com/");
        }

        [Given(@"username is entered")]
        public void GivenUsernameIsEntered()
        {
            Assert.True(homePage.userBoxDisplayed(_driver));
            homePage.usernameboxClick(_driver);  //Enter username
            homePage.usernameboxSendKeys(_driver, "standard_user"); 
        }
        
        [Given(@"password is entered")]
        public void GivenPasswordIsEntered()
        {
            Assert.True(homePage.passBoxDisplayed(_driver));
            homePage.passboxClick(_driver);//Enter Password
            homePage.passSendKeys(_driver, "secret_sauce");   
        }

        [Then(@"User is logged in")]
        public void ThenUserIsLoggedIn()
        {    
            Assert.True(homePage.loginBoxDisplayed(_driver));
            homePage.loginBoxClick(_driver);                     //Login button is clicked
            Assert.True(homePage.titleDisplayed(_driver));      //Checks login page for title logo
        }
        
    }
}
