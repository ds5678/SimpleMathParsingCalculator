using Antlr4.Runtime.Tree;

namespace SimpleMathParsingCalculator
{
    public sealed class CustomParseTreeProperty<T> : ParseTreeProperty<T>
    {
        public bool TryGet(IParseTree node, out T? value)
        {
            return annotations.TryGetValue(node, out value);
        }
    }
}