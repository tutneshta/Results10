using System;
using System.Collections.Generic;
using System.Text;

namespace Task10._1
{
    class Calculator : ICalculate
    {
        ILogger Logger { get; }

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }
        public int Sum(int x, int y)
        {
            Logger.Event("Сумма ");

            return x + y;
        }
    }

}
