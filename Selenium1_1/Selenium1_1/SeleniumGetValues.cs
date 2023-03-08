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
        public static string GetValueFromTextBox(string element, Propertytype elementype)
        {
            if (elementype == Propertytype.Id)
                return PropertyCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementype == Propertytype.Name)
                return PropertyCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            else
                return string.Empty;
        }
        public static string GetValueFromDropdown(string element, Propertytype elementype)
        {
            if (elementype == Propertytype.Id)
                return new SelectElement(PropertyCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementype == Propertytype.Name)
                return new SelectElement(PropertyCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else
                return string.Empty;
        }
    }
}
