// See https://aka.ms/new-console-template for more information
using System;
namespace Delegates_Events
{
    class program
    {
        public static void Main(String[] args)
        {
            DelegateDemo delegateDemo = new DelegateDemo();
            delegateDemo.Run();
            MultiCastDelegate multiCastDelegate = new MultiCastDelegate();
            multiCastDelegate.Run();
            EventDemo eventDemo = new EventDemo();
            eventDemo.Run();
        }
    }
}