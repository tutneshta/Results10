using System;
using System.Collections.Generic;
using System.Text;

namespace Task10._1
{
    public interface ILogger
    {
        void Event(string message);

        void Error(string message);
    }
}
