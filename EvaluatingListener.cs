using System;
using Antlr4.Runtime.Misc;

namespace SimpleMathParsingCalculator
{
    public sealed class EvaluatingListener : MathBaseListener
    {
        public CustomParseTreeProperty<double> CalculatedValues { get; } = new();

        public override void ExitAdditionExpression([NotNull] MathParser.AdditionExpressionContext context)
        {
            double left = CalculatedValues.Get(context.exp(0));
            double right = CalculatedValues.Get(context.exp(1));
            CalculatedValues.Put(context, left + right);
        }

        public override void ExitSubtractionExpression([NotNull] MathParser.SubtractionExpressionContext context)
        {
            double left = CalculatedValues.Get(context.exp(0));
            double right = CalculatedValues.Get(context.exp(1));
            CalculatedValues.Put(context, left - right);
        }

        public override void ExitMultiplicationExpression([NotNull] MathParser.MultiplicationExpressionContext context)
        {
            double left = CalculatedValues.Get(context.exp(0));
            double right = CalculatedValues.Get(context.exp(1));
            CalculatedValues.Put(context, left * right);
        }

        public override void ExitDivisionExpression([NotNull] MathParser.DivisionExpressionContext context)
        {
            double left = CalculatedValues.Get(context.exp(0));
            double right = CalculatedValues.Get(context.exp(1));
            CalculatedValues.Put(context, left / right);
        }

        public override void ExitParensExpression([NotNull] MathParser.ParensExpressionContext context)
        {
            double value = CalculatedValues.Get(context.exp());
            CalculatedValues.Put(context, value);
        }

        public override void ExitNegationExpression([NotNull] MathParser.NegationExpressionContext context)
        {
            double value = CalculatedValues.Get(context.exp());
            CalculatedValues.Put(context, - value);
        }

        public override void ExitExponentialExpression([NotNull] MathParser.ExponentialExpressionContext context)
        {
            double left = CalculatedValues.Get(context.exp(0));
            double right = CalculatedValues.Get(context.exp(1));
            CalculatedValues.Put(context, Math.Pow(left, right));
        }

        public override void ExitSineExpression([NotNull] MathParser.SineExpressionContext context)
        {
            double value = CalculatedValues.Get(context.exp());
            CalculatedValues.Put(context, Math.Sin(value));
        }

        public override void ExitCosineExpression([NotNull] MathParser.CosineExpressionContext context)
        {
            double value = CalculatedValues.Get(context.exp());
            CalculatedValues.Put(context, Math.Cos(value));
        }

        public override void ExitTangentExpression([NotNull] MathParser.TangentExpressionContext context)
        {
            double value = CalculatedValues.Get(context.exp());
            CalculatedValues.Put(context, Math.Tan(value));
        }

        public override void ExitPiExpression([NotNull] MathParser.PiExpressionContext context)
        {
            CalculatedValues.Put(context, Math.PI);
        }

        public override void ExitFloatNumber([NotNull] MathParser.FloatNumberContext context)
        {
            double num = double.Parse(context.PositiveFloat().GetText());
            CalculatedValues.Put(context, num);
        }

        public override void ExitIntNumber([NotNull] MathParser.IntNumberContext context)
        {
            double num = double.Parse(context.PositiveInt().GetText());
            CalculatedValues.Put(context, num);
        }
    }
}