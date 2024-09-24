using Interpreter.Expression;

namespace Interpreter.Terminal
{
    //terminal
    public class BooleanExpression : IExpression
    {
        private readonly bool _booleanValue;

        public BooleanExpression(bool booleanValue)
        {
            _booleanValue = booleanValue;
        }

        public bool Interpret()
        {
            return _booleanValue;
        }
    }
}
