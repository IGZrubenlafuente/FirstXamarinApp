using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using TechTalk.SpecFlow;

namespace FirstXamarinApp.Tests
{
    /*[ TestFixture(Platform.iOS) ]*/
    [TestFixture(Platform.Android)]
    public class FeatureBase
    {
        protected static IApp app;
        protected Platform platform;

        public FeatureBase(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
            //we add the app to the context so it can be used in the Steps files
            FeatureContext.Current.Add("App", app);
        }

    }
}

