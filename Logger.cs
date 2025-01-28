using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    sealed class Logger
    {
        private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());
        public Logger()
        {
            
        }
        public static Logger Instance => _instance.Value;

        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }

    }
}
