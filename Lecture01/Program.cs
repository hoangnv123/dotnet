using System;

namespace Lecture01;

static class Program
{
    interface IContext
    {
        int GetContext();
    }

    class BaseWindow : IContext
    {
        public int GetContext() => 3;
    }

    class DerivedWindow : BaseWindow
    {
        public new int GetContext() => 7;
    }

    static void Main()
    {
        IContext baseContext = new BaseWindow();
        IContext derivedContext = new DerivedWindow();
        Console.WriteLine(baseContext.GetContext());
        Console.WriteLine(derivedContext.GetContext());
    }
}