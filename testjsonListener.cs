//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from testjson.g4 by ANTLR 4.9

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace testjson {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="testjsonParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9")]
[System.CLSCompliant(false)]
public interface ItestjsonListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="testjsonParser.json"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJson([NotNull] testjsonParser.JsonContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="testjsonParser.json"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJson([NotNull] testjsonParser.JsonContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="testjsonParser.gen__seplist__L44__pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__seplist__L44__pair([NotNull] testjsonParser.Gen__seplist__L44__pairContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="testjsonParser.gen__seplist__L44__pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__seplist__L44__pair([NotNull] testjsonParser.Gen__seplist__L44__pairContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="testjsonParser.gen__seplist__L44__json"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGen__seplist__L44__json([NotNull] testjsonParser.Gen__seplist__L44__jsonContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="testjsonParser.gen__seplist__L44__json"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGen__seplist__L44__json([NotNull] testjsonParser.Gen__seplist__L44__jsonContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="testjsonParser.pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPair([NotNull] testjsonParser.PairContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="testjsonParser.pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPair([NotNull] testjsonParser.PairContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="testjsonParser.str"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStr([NotNull] testjsonParser.StrContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="testjsonParser.str"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStr([NotNull] testjsonParser.StrContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="testjsonParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStart([NotNull] testjsonParser.StartContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="testjsonParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStart([NotNull] testjsonParser.StartContext context);
}
} // namespace testjson
