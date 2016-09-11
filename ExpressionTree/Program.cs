using System;
using System.Linq.Expressions;

namespace ExpressionTree
{
    // Linq: internally creates expression trees

    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> isGreater = i => i > 10;

            //ConstantExpression rightConstant = Expression.Constant(10, typeof(int));
            //ParameterExpression leftParameter = Expression.Parameter(typeof(int), "i");
            //BinaryExpression binaryExpr = Expression.GreaterThan(leftParameter, rightConstant);
            //Expression<Func<int, bool>> rootExpression = Expression.Lambda<Func<int, bool>>(binaryExpr, leftParameter);
            //Func<int, bool> isGreaterFunc = rootExpression.Compile();
            //Console.WriteLine(isGreater(20));


            Console.WriteLine("------- RIGHT (10) -----");

            ConstantExpression rightConstant = Expression.Constant(10, typeof(int));
            Console.WriteLine(rightConstant.NodeType);
            Console.WriteLine(rightConstant.Type);
            Console.WriteLine(rightConstant.Value);

            Console.WriteLine("------- LEFT (i) -----");
            ParameterExpression leftParameter = Expression.Parameter(typeof(int), "i");
            Console.WriteLine(leftParameter.NodeType);
            Console.WriteLine(leftParameter.Type);
            Console.WriteLine(leftParameter.Name);

            Console.WriteLine("------- Greater root (i > 10) -----");
            BinaryExpression binaryExpr = Expression.GreaterThan(leftParameter, rightConstant);

            Console.WriteLine("------- Lamda (i => i > 10) -----");

            Expression<Func<int, bool>> rootExpression = Expression.Lambda<Func<int, bool>>(binaryExpr, leftParameter);
            // Here the input lamda parameter was already defined in leftParameter so passed direclty to expression.

            Console.WriteLine("--- Compiling the expression at runtime -------");

            Func<int, bool> isGreaterFunc = rootExpression.Compile();

            Console.WriteLine("------- invoking the Func by passing 20 as input -----");

            Console.WriteLine(isGreaterFunc(20));
            Console.WriteLine(isGreater(20));

            Console.ReadKey();
        }
    }
}
