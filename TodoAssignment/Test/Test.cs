using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TodoAssignment.Common;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TodoAssignment

{
    [TestClass]
	public class FirefoxTesting:Hook
	{
        private TestContext testContextInstance;
        public FirefoxTesting():base(BrowserType.FireFox)
        {

        }
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\Todo.xml", "Row", DataAccessMethod.Sequential), DeploymentItem("TodoAssignment\\Data\\Todo.xml"), TestMethod]
        public void FirefoxAddTodotest()
        {
            var convertVal = TestContext.DataRow["note"].ToString();
            driver.Navigate().GoToUrl("http://todomvc.com/examples/angularjs/#/");
            PropertiesCollection.driver.Manage().Window.Maximize();
            ManageTodoOp TodoObj1 = new ManageTodoOp();
            TodoObj1.AddTodo();
            Thread.Sleep(2000);
           


        }
        [TestMethod]
        public void FirefoxEditTodotest()
        {
            driver.Navigate().GoToUrl("http://todomvc.com/examples/angularjs/#/");
            PropertiesCollection.driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            ManageTodoOp TodoObj2= new ManageTodoOp();
            TodoObj2.AddTodo();
            TodoObj2.EditTodo();
            Thread.Sleep(2000);
            

        }

        [TestClass]
        public class GoogleChromeTesting : Hook
        {
            public GoogleChromeTesting() : base(BrowserType.Chrome)
            {
            }

            [TestMethod]
            public void ChromeAddTodotest()
            {
                driver.Navigate().GoToUrl("http://todomvc.com/examples/angularjs/#/");
                PropertiesCollection.driver.Manage().Window.Maximize();
                ManageTodoOp TodoObj3 = new ManageTodoOp();
                TodoObj3.AddTodo();
                Thread.Sleep(2000);

            }
            [TestMethod]
            public void ChromeEditTodotest()
            {
                driver.Navigate().GoToUrl("http://todomvc.com/examples/angularjs/#/");
                PropertiesCollection.driver.Manage().Window.Maximize();
                ManageTodoOp TodoObj4 = new ManageTodoOp();
                TodoObj4.AddTodo();
                TodoObj4.EditTodo();
                Thread.Sleep(2000);

            }

        }

            static void Main(string[] args)
		{
		}
		
       
    }
}
