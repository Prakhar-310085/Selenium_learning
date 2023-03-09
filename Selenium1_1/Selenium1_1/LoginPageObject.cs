using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium1_1
{
    internal class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }
        [FindsBy(How =How.Name, Using = "UserName")]
        public  IWebElement UsernameTextBox { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement PasswordBox { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement LoginButton { get; set; }

        public POM Login(string UserNametopass, string LoginPassword)
        {
            UsernameTextBox.SendKeys(UserNametopass);
            PasswordBox.SendKeys(LoginPassword);
            LoginButton.Submit();
            return new POM();
        }
    }
}
