using System;

namespace pattern_iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var history1 = new BrowserHistory("a", DateTime.Now);
            var history2 = new BrowserHistory("b", DateTime.Now.AddMinutes(10));
            var history3 = new BrowserHistory("c", DateTime.Now.AddHours(1));
        }
    }
}
