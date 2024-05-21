using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

[assembly: System.CLSCompliant(false)]

namespace SimpleMathParsingCalculator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Parsing Math!");
            RunCalculator();
            Console.WriteLine("Finished parsing");
        }

        private static void DoTests()
        {
            EvaluateAndPrint("2 + 1 + 1 + 0.2");
            EvaluateAndPrint("2 * 3 + 1");
            EvaluateAndPrint("2 * (3 + 1)");
            EvaluateAndPrint("2 * (3 + 1)^.5");
            EvaluateAndPrint("2 * (5 + - 1)^.5");
        }

        private static void RunCalculator()
        {
            string? input = Console.ReadLine();
            while (!string.IsNullOrWhiteSpace(input))
            {
                EvaluateAndPrint(input);
                input = Console.ReadLine();
            }
        }

        private static void EvaluateAndPrint(string input)
        {
            Console.WriteLine($"{input} = {Evaluate(input)}");
        }

        private static double Evaluate(string input)
        {
            AntlrInputStream stream = new AntlrInputStream(input);
            ITokenSource lexer = new MathLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            MathParser parser = new MathParser(tokens);
            parser.BuildParseTree = true;
            IParseTree tree = parser.exp();
            EvaluatingListener listener = new();
            ParseTreeWalker.Default.Walk(listener, tree);
            return listener.CalculatedValues.Get(tree);
        }
    }
}