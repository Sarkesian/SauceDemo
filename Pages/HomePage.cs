using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Current_Project
{
    public class HomePage
    {
                                        //see if username box is visible
        public bool userBoxDisplayed(IWebDriver driver) => driver.FindElement(By.Id("user-name")).Displayed;
                                            //click username box
        public void usernameboxClick(IWebDriver driver) => driver.FindElement(By.Id("user-name")).Click();
                                   //send username for login from test screen
        public void usernameboxSendKeys(IWebDriver driver, String username) => driver.FindElement(By.Id("user-name")).SendKeys(username);
                                       //see if password box is visible
        public bool passBoxDisplayed(IWebDriver driver) => driver.FindElement(By.Id("password")).Displayed;
                                             //click password box
        public void passboxClick(IWebDriver driver) => driver.FindElement(By.Id("password")).Click();
                                       //send password from test screen
        public void passSendKeys(IWebDriver driver, String username) => driver.FindElement(By.Id("password")).SendKeys(username);
                                       //see if login button is visible 
        public bool loginBoxDisplayed(IWebDriver driver) => driver.FindElement(By.Id("login-button")).Displayed;
                                             //click login button
        public void loginBoxClick(IWebDriver driver) => driver.FindElement(By.Id("login-button")).Click();
        public bool titleDisplayed(IWebDriver driver) => driver.FindElement(By.ClassName("title")).Displayed;
    }
}
