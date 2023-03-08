using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium1_1
{
    enum Propertytype
    {
        Id,
        Name,
        Value,
        ClassName,
        LinkText,
        CssName
    }
    internal class PropertyCollection
    {
        //auto-implemented properties
        public static IWebDriver driver { get; set; }       
    }
}
