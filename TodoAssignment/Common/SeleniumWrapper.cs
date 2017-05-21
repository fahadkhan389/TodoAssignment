using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal;
//using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;
using TodoAssignment.Common;
namespace TodoAssignment
{
   public class SeleniumWrapper
    {
        

        public static void FilltextBox(IWebElement element, string value)
        {
                 element.SendKeys(value);
           
        }

        //public static void FilltextBox(string element, string value, IdentityType Elementtype)
        //{
        //    switch (Elementtype)
        //    {
        //        case IdentityType.Id:
        //            PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
        //            break;
        //        case IdentityType.Name:
        //            PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        //            break;
        //        case IdentityType.Xpath:
        //            PropertiesCollection.driver.FindElement(By.XPath(element)).SendKeys(value);
        //            break;

        //    }


        //}

        //public static IWebElement FindElement(string element, IdentityType Elementtype)
        //{
        //    IWebElement Webelement;
        //    switch (Elementtype)
        //    {
        //        case IdentityType.Id:
        //            Webelement = PropertiesCollection.driver.FindElement(By.Id(element));
        //            break;
        //        case IdentityType.Name:
        //            Webelement = PropertiesCollection.driver.FindElement(By.Name(element));
        //            break;
        //        case IdentityType.Xpath:
        //            Webelement = PropertiesCollection.driver.FindElement(By.XPath(element));
        //            break;
        //        default:
        //            throw new Exception();
        //    }
        //    return Webelement;
        //}
        public static Boolean IsElementDisplayed(IWebElement element)

        {
            return (element.Displayed && element.Enabled);
            
        }
        //public static Boolean IsElementDisplayed(string element, IdentityType Elementtype)

        //{
        //    IWebElement webelement = FindElement(element, Elementtype);
        //    return (webelement.Displayed && webelement.Enabled);

        //}
        //public static void EnterFillTextBox(string element, string value, IdentityType Elementtype)
        //{
        //    switch (Elementtype)
        //    {
        //        case IdentityType.Id:
        //            PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
        //            PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(Keys.Enter);

        //            break;
        //        case IdentityType.Name:
        //            PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        //            PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(Keys.Enter);

        //            break;
        //        case IdentityType.Xpath:
        //            PropertiesCollection.driver.FindElement(By.XPath(element)).SendKeys(value);
        //            PropertiesCollection.driver.FindElement(By.XPath(element)).SendKeys(Keys.Enter);

        //            break;
        //    }
        //}

        public static void EnterFillTextBox(IWebElement element, string value)
        {
                    element.SendKeys(value);
                    element.SendKeys(Keys.Enter);
                    
        }

        public static void DoubleClickElement(IWebElement element)
        {

                   Actions builder1 = new Actions(PropertiesCollection.driver);
                    
                    builder1.DoubleClick(element).Build().Perform();
                   
            }
        //switch (Elementtype)
        //{

        //    case IdentityType.Xpath:
        //        Actions builder1 = new Actions(PropertiesCollection.driver);
        //        IWebElement webelement1 = PropertiesCollection.driver.FindElement(By.XPath(element));

        //        builder1.DoubleClick(webelement1).Build().Perform();
        //        break;
        //    case IdentityType.Name:
        //        Actions builder2 = new Actions(PropertiesCollection.driver);
        //        IWebElement webelement2 = PropertiesCollection.driver.FindElement(By.Name(element));

        //        builder2.DoubleClick(webelement2).Build().Perform();
        //        break;
        //    case IdentityType.Id:
        //        Actions builder3 = new Actions(PropertiesCollection.driver);
        //        IWebElement webelement3 = PropertiesCollection.driver.FindElement(By.Id(element));

        //        builder3.DoubleClick(webelement3).Build().Perform();
        //        break;
        //}


        //public static void ClickElement(string element, IdentityType Elementtype)
        //{

        //    switch (Elementtype)
        //    {

        //        case IdentityType.Id:
        //            PropertiesCollection.driver.FindElement(By.Id(element)).Click();

        //            break;
        //        case IdentityType.Name:
        //            PropertiesCollection.driver.FindElement(By.Name(element)).Click();

        //            break;
        //        case IdentityType.Xpath:
        //            PropertiesCollection.driver.FindElement(By.XPath(element)).Click();

        //            break;

        //    }
        //}
        public static void ClickElement(IWebElement element)
        {
            element.Click();
            
        }
        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");

               }
        //public static string GetText(string element, IdentityType Elementtype)
        //{

        //    switch (Elementtype)
        //    {

        //        case IdentityType.Id:
        //            return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");

        //        case IdentityType.Name:
        //            return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");

        //        case IdentityType.Xpath:
        //            return PropertiesCollection.driver.FindElement(By.XPath(element)).GetAttribute("value");


        //        default: return "default";

        //    }
        //}
        public static void ClearTextBox(IWebElement element)
            {
              element.Clear();
                    
                }


            //public static void ClearTextBox(string element, IdentityType Elementtype)
            //{

            //    switch (Elementtype)
            //    {

            //        case IdentityType.Id:
            //            PropertiesCollection.driver.FindElement(By.Id(element)).Clear();
            //            break;
            //        case IdentityType.Name:
            //            PropertiesCollection.driver.FindElement(By.Name(element)).Clear();
            //            break;
            //        case IdentityType.Xpath:
            //            PropertiesCollection.driver.FindElement(By.XPath(element)).Clear();
            //            break;
            //    }



            }
        }
}
