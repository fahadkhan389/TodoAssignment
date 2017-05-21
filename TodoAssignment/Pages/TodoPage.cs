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
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;

namespace TodoAssignment
{
    public class TodoPage
    {

        public TodoPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        //string newtodo = "new-todo";
        //string LabelXpath = ".//*[@id='todo-list']/li/div/label";
        //string labelxpath2=".//*[@id='todo-list']/li/form/input";
        [FindsBy(How =How.Id,Using="new-todo")]
        public IWebElement newtodo { get; set; }
        [FindsBy(How =How.XPath,Using = ".//*[@id='todo-list']/li/div/label")]
        public IWebElement LabelXpath { get; set; }
        [FindsBy(How =How.XPath,Using = ".//*[@id='todo-list']/li/form/input")]
        public IWebElement labelxpath2 { get; set; }

        public void AddTodo()
        {
            //SeleniumWrapper.EnterFillTextBox(newtodo, "FirstTodo", IdentityType.Id);
            //Thread.Sleep(3000);
            //SeleniumWrapper.DoubleClickElement(LabelXpath, IdentityType.Xpath);
            //string text =SeleniumWrapper.GetText(labelxpath2, IdentityType.Xpath);
            //Thread.Sleep(3000);
            //Assert.IsTrue(string.Equals(text, "FirstTodo",StringComparison.InvariantCultureIgnoreCase),"Not Equal");
            //Thread.Sleep(3000);
            SeleniumWrapper.EnterFillTextBox(newtodo,"FirstTodo");
            Thread.Sleep(3000);
            SeleniumWrapper.DoubleClickElement(LabelXpath);
            string text = SeleniumWrapper.GetText(labelxpath2);
            Thread.Sleep(3000);
            Assert.IsTrue(string.Equals(text, "FirstTodo", StringComparison.InvariantCultureIgnoreCase), "Not Equal");
            Thread.Sleep(3000);


        }
        public void EditTodo()
        {
           // SeleniumWrapper.DoubleClickElement(LabelXpath, IdentityType.Xpath);
           //// SeleniumWrapper.ClearTextBox(labelxpath2, IdentityType.Xpath);
           // SeleniumWrapper.FilltextBox(labelxpath2, "123", IdentityType.Xpath);
           // SeleniumWrapper.DoubleClickElement(LabelXpath, IdentityType.Xpath);
           // string text = SeleniumWrapper.GetText(labelxpath2, IdentityType.Xpath);
           // Assert.IsTrue(string.Equals(text, "FirstTodo123", StringComparison.InvariantCultureIgnoreCase), "Not Equal");
           // Thread.Sleep(3000);

            SeleniumWrapper.DoubleClickElement(LabelXpath);
            // SeleniumWrapper.ClearTextBox(labelxpath2, IdentityType.Xpath);
            SeleniumWrapper.FilltextBox(labelxpath2, "123");
            SeleniumWrapper.DoubleClickElement(LabelXpath);
            string text = SeleniumWrapper.GetText(labelxpath2);
            Assert.IsTrue(string.Equals(text, "FirstTodo123", StringComparison.InvariantCultureIgnoreCase), "Not Equal");
            Thread.Sleep(3000);

        }
    }
}
