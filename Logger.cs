using System;
using System.Collections.Generic;
using System.Text;

namespace Task10._1
{
    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = (ConsoleColor.Red);
        }

        public void Event(string message)
        {
            Console.ForegroundColor = (ConsoleColor.Blue);
        }
    }
}
