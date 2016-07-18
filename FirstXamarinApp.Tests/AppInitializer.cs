using System;
using Xamarin.UITest;
using TechTalk.SpecFlow;

namespace FirstXamarinApp.Tests
{
    public static class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .StartApp();
            }

            else if (platform == Platform.iOS)
            {
                return ConfigureApp
                .iOS
                .StartApp();
            }

            throw new ArgumentException("Unsupported platform " + platform);
        }

        public static void InitializeScreens(Platform platform)
        {
            if (platform == Platform.Android)
            {
                FeatureContext.Current.Add(ScreenNames.Home, new AndroidHomeScreen());
            }
            else if (platform == Platform.iOS)
            {
                FeatureContext.Current.Add(ScreenNames.Home, new iOSHomeScreen());
            } 
        }
    }
}

