using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace FirstXamarinApp.Tests
{
    [Binding]
    public class Steps
    {
        readonly IApp app;

        public Steps()
        {
            app = FeatureContext.Current.Get<IApp>("App");
        }

        [Given(@"I see the button")]
        public void IEnterTheApp()
        {
            app.WaitForElement(c => c.Id("myButton"));
        }

        [When(@"I click the button 1 time")]
        public void IClickTheButton1Time()
        {
            app.Tap(c => c.Id("myButton"));
        }

        [Then(@"the message shows I clicked 1 time")]
        public void TheMessageShowsIClicked1Time()
        {
            app.WaitForElement(c => c.Id("myButton").Text("You clicked 1 times"));
        }

    }
    
}
