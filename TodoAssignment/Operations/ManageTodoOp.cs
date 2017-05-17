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

namespace TodoAssignment
{
    public class ManageTodoOp
    {


        public void AddTodo()
        {
            try
            {
                TodoPage pageobj1 = new TodoPage();
                pageobj1.AddTodo();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }
        public void EditTodo()
        {
            try
            {
                TodoPage pageobj2 = new TodoPage();
                pageobj2.EditTodo();
            }
            catch (Exception e)
            {
                throw e;

            }
        }
    }
}
