using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Selenium1_1
{
    
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void Setup()
        {
            driver.Navigate().GoToUrl("http://demosite.executeautomation.com/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Setup Executed sucessfully");
        }

        [Test]
        public void Test1()
        {
            //for dropdowns
            SeleniumSetMethod.Dropdown(driver, "TitleId", "Mr.", "Id");
            //to get the values from the seelcted dropdown list of values
            Console.WriteLine("The selected value from dropdown is:" + SeleniumGetValues.GetValueFromDropdown(driver, "TitleId", "Id"));
            //for textbox
            SeleniumSetMethod.EnterText(driver, "Initial", "abcd","Id");
            //for Click
            //to get the values from the textbox
            Console.WriteLine("The value extracted from textbox is:" + SeleniumGetValues.GetValueFromTextBox(driver, "Initial", "Id"));
            SeleniumSetMethod.Click(driver,"Save","Name");
        }
        
        [TearDown]
        public void CloseBrowser() 
        {
            Thread.Sleep(2000);
            driver.Close();
            Console.WriteLine("CloseBrowser Executed sucessfully");
        }
    }
}