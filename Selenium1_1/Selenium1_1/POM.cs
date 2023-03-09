using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium1_1
{
    internal class POM
    {
        public POM()
        {
            //to initialize the POM we need to create the pagefactory in a constructor 
            PageFactory.InitElements(PropertyCollection.driver, this);
        }
        [FindsBy(How = How.Id, Using = "TitleId")]              //created a POM for webelement ie dropdown
        public IWebElement Dropdownvalues { get; set; }        //created the property for the Webelement dropdown

        [FindsBy(How = How.Id, Using = "Initial")]               //created a POM for webelement ie textbox
        public IWebElement InitialTextbox { get; set; }                //created the property for the Webelement InitialName Textbox

        [FindsBy(How = How.Id, Using = "FirstName")]               //created a POM for webelement ie FirstNametextbox
        public IWebElement FirstNameTextbox { get; set; }

        [FindsBy(How = How.Id, Using = "MiddleName")]               //created a POM for webelement ie MiddleNametextbox
        public IWebElement MiddleNameTextbox { get; set; }


        [FindsBy(How = How.Name, Using = "Save")]                //created a POM for webelement ie BUtton
        public IWebElement SaveButton { get; set; }                 //created the property for the Webelement Button


        public void FillUserForm(string valueofInitial, string valueofFirstName, string valueofMiddleName)
        {
            InitialTextbox.SendKeys(valueofInitial);
            FirstNameTextbox.SendKeys(valueofFirstName);
            MiddleNameTextbox.SendKeys(valueofMiddleName);
        }
    }
}
