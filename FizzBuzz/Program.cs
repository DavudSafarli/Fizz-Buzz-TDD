using System;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Example real world usecase of FizzBuzz
            FizzBuzz app = new FizzBuzz();
            app.PrintFizzBuzz(100, new ConsoleWriter());
        }
    }

    public class ConsoleWriter : Writer
    {
        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
    }
}
