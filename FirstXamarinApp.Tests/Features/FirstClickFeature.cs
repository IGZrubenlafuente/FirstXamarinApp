using Xamarin.UITest;
using NUnit.Framework;

namespace FirstXamarinApp.Tests.Features
{
    //we complete the partial class (auto-generated in the feature.cs file) by extending from FeatureBase
    //this way we can start the app
    public partial class FirstClickFeature : FeatureBase
    {
        
        public FirstClickFeature(Platform platform) : base(platform)
        {
        }

        //NUnit test
        [Test]
        public void IClick1Time()
        {
            app.WaitForElement(c => c.Id("myButton"));
            app.Tap(c => c.Id("myButton"));
            app.WaitForElement(c => c.Id("myButton").Text("You clicked 1 times"));
        }

    }
}
