using System;
using System.Collections.Generic;
using System.Text;

namespace BetterConsoleApp
{
    public class MyService : IMyService
    {
        public void Run()
        {
            Console.WriteLine("Run method from MyService is run");
        }
    }
}
