using System;

namespace FirstXamarinApp
{
    public class MyClass
    {
        public MyClass() { }

        public int Count { get; set; } = 0;

        public string IncreaseCount()
        {
            Count++;
            return $"You clicked {Count} times";
        }

    }
}

