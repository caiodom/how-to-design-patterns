using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class TimestampDecorator : LoggerDecorator
    {
        
        public TimestampDecorator(ILogger logger):base(logger)
        {
            
        }
        public override void Log(string message)
        {
            string timestampedMessage = $"{DateTime.Now}: {message}";
            base.Log(timestampedMessage);
        }
    }
}
