using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TodoAssignment.Common
{
    public enum BrowserType
    {
        Chrome,
        FireFox,
        IE
    }

    [TestClass]
   public class Hook:PropertiesCollection
       
      {
        private BrowserType _browsertype;

        public Hook(BrowserType browser)

        {
            _browsertype = browser;
        }
        private void chooseDriverInstance(BrowserType browsertype)

        {
            if (browsertype == BrowserType.Chrome)
            {
                driver = new ChromeDriver(@"C:\Users\fukha\Desktop\chromedriver_win32");

            }
            else
                if (browsertype == BrowserType.FireFox)
            {
                driver = new FirefoxDriver();

            }
        }
            [TestInitialize]
        public void InitializeTest()
        {
            chooseDriverInstance(_browsertype);
        }
        [TestCleanup]
        public void CloseTest()
        {
            PropertiesCollection.driver.Close();
            PropertiesCollection.driver.Quit();


        }

    }
        

    }

