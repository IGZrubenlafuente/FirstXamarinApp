using System;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using NUnit.Framework;
using Xamarin.UITest.Queries;

namespace FirstXamarinApp.Tests
{
    //if we extend from Steps, we will be able to use Given(...), When(...), Then(...), etc.
    [Binding]
    public class CommonSteps : Steps
    {

        private FeatureContext _featureContext;
        private IApp _app;
        //IHomeScreen screen;

        public CommonSteps(FeatureContext featureContext)
        {
            _featureContext = featureContext;
            _app = _featureContext.Get<IApp>("App");
            //screen = FeatureContext.Current.Get<IHomeScreen>(ScreenNames.Home);
        }

        [When(@"I click the ""(.*)"" button in the ""(.*)"" screen")]
        public void IClickTheButton(string buttonName, string screenName)
        {
            screenName += "Screen";
            IHomeScreen screen = _featureContext.Get<IHomeScreen>(screenName);
            //Console.WriteLine("buttonName = " + buttonName);
            //_app.Tap(homeScreen.myButton);
            _app.Tap(screen.elements[buttonName]);
        }

    }
}
