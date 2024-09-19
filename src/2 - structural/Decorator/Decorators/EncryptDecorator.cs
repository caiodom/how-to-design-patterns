using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class EncryptDecorator:LoggerDecorator
    {
        public EncryptDecorator(ILogger logger) : base(logger) { }        
               
        

        public override void Log(string message)
        {
            string encryptedMessage = Encrypt(message);
            base.Log(encryptedMessage);
        }


        private string Encrypt(string message)
        {
            char[] buffer = message.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (char)(buffer[i] + 1);
            }

            return new string(buffer);

        }

    }
}
