using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class LoggerDecorator : ILogger
    {
        protected ILogger _logger;

        protected LoggerDecorator(ILogger logger)
        {
            _logger= logger;    
        }
        public virtual void Log(string message)
        {
            _logger.Log(message);
        }
    }
}
