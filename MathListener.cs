//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Math.g4 by ANTLR 4.10.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace SimpleMathParsingCalculator {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="MathParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.CLSCompliant(false)]
public interface IMathListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>AdditionExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditionExpression([NotNull] MathParser.AdditionExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AdditionExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditionExpression([NotNull] MathParser.AdditionExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SineExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSineExpression([NotNull] MathParser.SineExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SineExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSineExpression([NotNull] MathParser.SineExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>TangentExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTangentExpression([NotNull] MathParser.TangentExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TangentExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTangentExpression([NotNull] MathParser.TangentExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>IntNumber</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntNumber([NotNull] MathParser.IntNumberContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>IntNumber</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntNumber([NotNull] MathParser.IntNumberContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ParensExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParensExpression([NotNull] MathParser.ParensExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ParensExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParensExpression([NotNull] MathParser.ParensExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PiExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPiExpression([NotNull] MathParser.PiExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PiExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPiExpression([NotNull] MathParser.PiExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SubtractionExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubtractionExpression([NotNull] MathParser.SubtractionExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SubtractionExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubtractionExpression([NotNull] MathParser.SubtractionExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ExponentialExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExponentialExpression([NotNull] MathParser.ExponentialExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExponentialExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExponentialExpression([NotNull] MathParser.ExponentialExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FloatNumber</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloatNumber([NotNull] MathParser.FloatNumberContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FloatNumber</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloatNumber([NotNull] MathParser.FloatNumberContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DivisionExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDivisionExpression([NotNull] MathParser.DivisionExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DivisionExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDivisionExpression([NotNull] MathParser.DivisionExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>MultiplicationExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicationExpression([NotNull] MathParser.MultiplicationExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MultiplicationExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicationExpression([NotNull] MathParser.MultiplicationExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NegationExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNegationExpression([NotNull] MathParser.NegationExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NegationExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNegationExpression([NotNull] MathParser.NegationExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CosineExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCosineExpression([NotNull] MathParser.CosineExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CosineExpression</c>
	/// labeled alternative in <see cref="MathParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCosineExpression([NotNull] MathParser.CosineExpressionContext context);
}
} // namespace MathParsingTest