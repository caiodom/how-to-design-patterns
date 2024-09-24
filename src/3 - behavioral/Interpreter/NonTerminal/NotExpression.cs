using Interpreter.Expression;

namespace Interpreter.NonTerminal
{

    public class NotExpression : IExpression
    {
        private readonly IExpression _expression;
        public NotExpression(IExpression expression)
        {
            _expression= expression;
        }
        public bool Interpret()
        {
            return !_expression.Interpret();
        }
    }
}
