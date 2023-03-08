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
            PropertyCollection.driver.Navigate().GoToUrl("http://demosite.executeautomation.com/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Setup Executed sucessfully");
        }

        [Test]
        public void Test1()
        {

            //for dropdowns
            SeleniumSetMethod.Dropdown("TitleId", "Mr.", Propertytype.Id);
            //to get the values from the seelcted dropdown list of values
            Console.WriteLine("The selected value from dropdown is:" + SeleniumGetValues.GetValueFromDropdown("TitleId", Propertytype.Id));
            //for textbox
            SeleniumSetMethod.EnterText("Initial", "abcd",Propertytype.Id);
            //for Click
            //to get the values from the textbox
            Console.WriteLine("The value extracted from textbox is:" + SeleniumGetValues.GetValueFromTextBox("Initial", Propertytype.Id));
            SeleniumSetMethod.Click("Save",Propertytype.Name);
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