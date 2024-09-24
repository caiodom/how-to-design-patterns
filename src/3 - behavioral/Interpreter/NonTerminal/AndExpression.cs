using Interpreter.Expression;

namespace Interpreter.NonTerminal
{
    public class AndExpression : IExpression
    {
        private readonly IExpression _leftExpression;
        private readonly IExpression _rightExpression;

        public AndExpression(IExpression leftExpression, IExpression rightExpression)
        {

            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public bool Interpret()
        {
            return _leftExpression.Interpret() && _rightExpression.Interpret();
        }
    }
}
