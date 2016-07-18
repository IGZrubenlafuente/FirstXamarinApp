using System;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using NUnit.Framework;
using Xamarin.UITest.Queries;

namespace FirstXamarinApp.Tests
{
    //if we extend from Steps, we will be able to use Given(...), When(...), Then(...), etc.
    [Binding]
    public class HomeSteps : Steps
    {
        private FeatureContext _featureContext;
        private IApp _app;
        IHomeScreen screen;

        public HomeSteps(FeatureContext featureContext)
        {
            _featureContext = featureContext;
            _app = _featureContext.Get<IApp>("App");
            screen = _featureContext.Get<IHomeScreen>(ScreenNames.Home);
        }

        [Given(@"I see the ""(.*)"" button")]
        public void IEnterTheApp(string buttonName)
        {
            _app.WaitForElement(screen.elements[buttonName]);
        }

        /*[When(@"I click the ""(.*)"" button 1 time")]
        public void IClickTheButton1Time(string buttonName)
        {
            //Console.WriteLine("buttonName = " + buttonName);
            //_app.Tap(homeScreen.myButton);
            _app.Tap(screen.buttons[buttonName]);
        }
        */
        [Then(@"the message in the ""(.*)"" button shows I clicked 1 time")]
        public void TheMessageShowsIClicked1Time(string buttonName)
        {
            AppResult myButton = _app.WaitForElement(screen.elements[buttonName])[0];
            Assert.That("You clicked 1 times", Is.EqualTo(myButton.Text));
        }

    }
    
}
