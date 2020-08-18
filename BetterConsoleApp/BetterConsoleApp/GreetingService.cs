using System;

namespace BetterConsoleApp
{
    public class GreetingService
    {
        private readonly IMyService _myService;
        public GreetingService(IMyService myService)
        {
            _myService = myService;
        }
        public void Run()
        {
            Console.WriteLine("Method from GreetingService is run");
            _myService.Run();
        }
    }
}