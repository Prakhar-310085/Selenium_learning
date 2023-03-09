using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Selenium1_1
{
    
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
            PropertyCollection.driver = new ChromeDriver();
            PropertyCollection.driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");
            Console.WriteLine("Setup Executed sucessfully");
        }

        [Test]
        public void Test1()
        {
            //LoginApplication
            LoginPageObject pagelogin = new LoginPageObject();
            POM pageobject=  pagelogin.Login("PrakharTest","Prakhar@123");
            pageobject.FillUserForm("Test", "Prakhar", "Ranjan");

            //to initialize the page by calling its reference
            //POM page =new POM();
            //page.InitialTextbox.SendKeys("abcd");
            //Console.WriteLine("abcd is entered in textbox");
            
            //page.SaveButton.Click();
            //Console.WriteLine("button is clicked");


            ////for dropdowns
            //SeleniumSetMethod.Dropdown("TitleId", "Mr.", Propertytype.Id);
            ////to get the values from the seelcted dropdown list of values
            //Console.WriteLine("The selected value from dropdown is:" + SeleniumGetValues.GetValueFromDropdown("TitleId", Propertytype.Id));
            ////for textbox
            //SeleniumSetMethod.EnterText("Initial", "abcd",Propertytype.Id);
            ////for Click
            ////to get the values from the textbox
            //Console.WriteLine("The value extracted from textbox is:" + SeleniumGetValues.GetValueFromTextBox("Initial", Propertytype.Id));
            //SeleniumSetMethod.Click("Save",Propertytype.Name);
        }
        
        [TearDown]
        public void CloseBrowser() 
        {
            Thread.Sleep(2000);
            PropertyCollection.driver.Close();
            Console.WriteLine("CloseBrowser Executed sucessfully");
        }
    }
}