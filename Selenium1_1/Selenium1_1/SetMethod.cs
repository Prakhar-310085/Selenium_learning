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
        public static void EnterText(IWebDriver driver,string element, string valuestobepassed,string elementtype)
        {
            if(elementtype=="Id")
            driver.FindElement(By.Id(element)).SendKeys(valuestobepassed);
            if (elementtype == "Name")
            driver.FindElement(By.Name(element)).SendKeys(valuestobepassed);
        }
        //to click any button, checkbox etc
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
        }
        // to select a dropdown
        public static void Dropdown(IWebDriver driver, string element, string dropdownvalues, string elementtype)
        {
            if (elementtype == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(dropdownvalues);
            if (elementtype == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(dropdownvalues);
        }


    }
}
