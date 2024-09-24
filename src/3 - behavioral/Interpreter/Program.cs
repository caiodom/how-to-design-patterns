using Interpreter.Expression;
using Interpreter.NonTerminal;
using Interpreter.Terminal;

//Client


IExpression trueExp = new BooleanExpression(true);
IExpression falseExp = new BooleanExpression(false);


IExpression andExpression = new AndExpression(trueExp, falseExp);
Console.WriteLine($"true AND false = {andExpression.Interpret()}");  


IExpression orExpression = new OrExpression(trueExp, falseExp);
Console.WriteLine($"true OR false = {orExpression.Interpret()}"); 

IExpression notExpression = new NotExpression(trueExp);
Console.WriteLine($"NOT true = {notExpression.Interpret()}");


IExpression complexExpression =new OrExpression(trueExp,new AndExpression(falseExp,new NotExpression(falseExp)));
Console.WriteLine($"true OR (false AND NOT false) = {complexExpression.Interpret()}");  

