using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TodoAssignment.Common;

namespace TodoAssignment
{   [Parallelizable]
    [TestFixture]
	public class FirefoxTesting:Hook
	{
        public FirefoxTesting():base(BrowserType.FireFox)
        {

        }
        [Test]
        public void FirefoxAddTodotest()
        {
            driver.Navigate().GoToUrl("http://todomvc.com/examples/angularjs/#/");
            PropertiesCollection.driver.Manage().Window.Maximize();
            ManageTodoOp TodoObj1 = new ManageTodoOp();
            TodoObj1.AddTodo();
            Thread.Sleep(2000);
           


        }
        [Test]
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

        [Parallelizable]
        [TestFixture]
        public class GoogleChromeTesting : Hook
        {
            public GoogleChromeTesting() : base(BrowserType.Chrome)
            {
            }

            [Test]
            public void ChromeAddTodotest()
            {
                driver.Navigate().GoToUrl("http://todomvc.com/examples/angularjs/#/");
                PropertiesCollection.driver.Manage().Window.Maximize();
                ManageTodoOp TodoObj3 = new ManageTodoOp();
                TodoObj3.AddTodo();
                Thread.Sleep(2000);

            }
            [Test]
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
