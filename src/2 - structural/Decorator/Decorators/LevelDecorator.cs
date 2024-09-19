using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class LevelDecorator : LoggerDecorator
    {
        private readonly string _level;
        public LevelDecorator(ILogger logger, string level) : base(logger)
        {
            _level = level;
        }

        public override void Log(string message)
        {
            string levelMessage = $"[{_level}] {message}";
            base.Log(levelMessage);
        }
    }
}
