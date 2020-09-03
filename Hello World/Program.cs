using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            helloWorldHomework();
        }
        static void helloWorldHomework()
        {
            Console.WriteLine("Hello there\nwhat are you doing?");
            string userAnswer = Console.ReadLine();
            Console.WriteLine($"That's cool.. You said: '{ userAnswer}'");
        }
    }
}
