using System;
using System.Collections.Generic;
using System.Text;

namespace Task10._1
{
    class ErrorNumber : IError
    {
        ILogger Logger { get; }

        public ErrorNumber(ILogger logger)
        {
            Logger = logger;
        }

        public void Error(string message)
        {
            Logger.Error(message);

            Console.WriteLine(message);
        }
    }
}
