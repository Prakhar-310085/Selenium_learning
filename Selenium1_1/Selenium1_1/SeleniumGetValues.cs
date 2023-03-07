using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Selenium1_1
{
    internal class SeleniumGetValues
    {
        public static string GetValueFromTextBox(IWebDriver driver, string element, string elementype)
        {
            if (elementype == "Id")
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementype == "Name")
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            else
                return string.Empty;
        }
        public static string GetValueFromDropdown(IWebDriver driver, string element, string elementype)
        {
            if (elementype == "Id")
                return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementype == "Name")
                return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else
                return string.Empty;
        }
    }
}
