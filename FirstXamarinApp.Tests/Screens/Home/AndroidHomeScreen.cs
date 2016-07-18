using System;
using Xamarin.UITest.Queries;
using System.Collections.Generic;

namespace FirstXamarinApp.Tests
{
    public class AndroidHomeScreen : IHomeScreen
    {
        public Dictionary<String, Func<AppQuery, AppQuery>> elements
        {
            get
            {
                Dictionary<String, Func<AppQuery, AppQuery>> _elements = new Dictionary<string, Func<AppQuery, AppQuery>>();
                _elements.Add("Click me", new Func<AppQuery, AppQuery>(c => c.Id("myButton")));
                return _elements;
            }
        }
    }
}
