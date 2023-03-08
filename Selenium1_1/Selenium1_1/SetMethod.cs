using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium1_1
{
    
    internal class SeleniumSetMethod
    {
        //to enter any text
        public static void EnterText(string element, string valuestobepassed,Propertytype elementtype)
        {
            if(elementtype==Propertytype.Id)
            PropertyCollection.driver.FindElement(By.Id(element)).SendKeys(valuestobepassed);
            if (elementtype == Propertytype.Name)
            PropertyCollection.driver.FindElement(By.Name(element)).SendKeys(valuestobepassed);
        }
        //to click any button, checkbox etc
        public static void Click(string element, Propertytype elementtype)
        {
            if (elementtype == Propertytype.Id)
                PropertyCollection.driver.FindElement(By.Id(element)).Click();
            if (elementtype == Propertytype.Name)
                PropertyCollection.driver.FindElement(By.Name(element)).Click();
        }
        // to select a dropdown
        public static void Dropdown(string element, string dropdownvalues, Propertytype elementtype)
        {
            if (elementtype == Propertytype.Id)
                new SelectElement(PropertyCollection.driver.FindElement(By.Id(element))).SelectByText(dropdownvalues);
            if (elementtype == Propertytype.Name)
                new SelectElement(PropertyCollection.driver.FindElement(By.Name(element))).SelectByText(dropdownvalues);
        }


    }
}
