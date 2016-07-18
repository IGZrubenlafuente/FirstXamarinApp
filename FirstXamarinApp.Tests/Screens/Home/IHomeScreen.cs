using System;
using System.Collections.Generic;
using Xamarin.UITest.Queries;

namespace FirstXamarinApp.Tests
{
    public interface IHomeScreen
    {
        //match the "readable" element description with the Query needed to find it
        Dictionary<String, Func<AppQuery, AppQuery>> elements { get; }
    }
}
