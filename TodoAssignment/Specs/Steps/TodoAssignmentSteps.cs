using System;
using TechTalk.SpecFlow;
using TodoAssignment.Common;

namespace TodoAssignment.Specs.Steps
{
    [Binding]
    public class TodoAssignmentSteps
    {
        [Given(@"I have opened a Chrome Browser")]
        public void GivenIHaveOpenedAChromeBrowser()
        {
            Hook myhook = new Hook(BrowserType.Chrome);
        }
        
        [Given(@"I have opened Todo website")]
        public void GivenIHaveOpenedTodoWebsite()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://todomvc.com/examples/angularjs/#/");
            PropertiesCollection.driver.Manage().Window.Maximize();
        }
        
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            TodoPage pageobj1 = new TodoPage();
            pageobj1.AddTodo();
        }
        [Then(@"Add to do should be added")]
        public void ThenAddToDoShouldBeAdded()
        {
            TodoPage pageobj1 = new TodoPage();
            pageobj1.AddTodoAssert();
        }



        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
