using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CrossCuttingConcerns
{
    public class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database.");
        }
    }
}
