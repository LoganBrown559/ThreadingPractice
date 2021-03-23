using System;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Creating Thread. Please work!");
            FindPiThread yes = new FindPiThread(5);
        }
    }
}
