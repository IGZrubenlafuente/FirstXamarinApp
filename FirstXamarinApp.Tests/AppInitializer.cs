using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

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
    }
}

