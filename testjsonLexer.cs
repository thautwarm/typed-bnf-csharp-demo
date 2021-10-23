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
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9")]
[System.CLSCompliant(false)]
public partial class testjsonLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, STR_2=8, WS_3=9, 
		INT_5=10, FLOAT_6=11;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "ESCAPED_QUOTE_1", 
		"STR_2", "WS_3", "INT_5", "DIGIT_4", "FLOAT_6"
	};


	public testjsonLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public testjsonLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'['", "']'", "'{'", "'}'", "'null'", "','", "':'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, "STR_2", "WS_3", "INT_5", 
		"FLOAT_6"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "testjson.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static testjsonLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\r', 'J', '\b', '\x1', '\x4', '\x2', '\t', '\x2', '\x4', 
		'\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', 
		'\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', 
		'\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', 
		'\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', 
		'\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\a', '\n', '\x35', '\n', '\n', '\f', 
		'\n', '\xE', '\n', '\x38', '\v', '\n', '\x3', '\n', '\x3', '\n', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x6', '\f', 
		'\x41', '\n', '\f', '\r', '\f', '\xE', '\f', '\x42', '\x3', '\r', '\x3', 
		'\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x2', '\x2', 
		'\xF', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\x2', '\x13', '\n', '\x15', '\v', '\x17', 
		'\f', '\x19', '\x2', '\x1B', '\r', '\x3', '\x2', '\x5', '\x3', '\x2', 
		'$', '$', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x3', '\x2', 
		'\x32', ';', '\x2', 'J', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x3', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\x5', '\x1F', '\x3', '\x2', '\x2', '\x2', '\a', '!', '\x3', 
		'\x2', '\x2', '\x2', '\t', '#', '\x3', '\x2', '\x2', '\x2', '\v', '%', 
		'\x3', '\x2', '\x2', '\x2', '\r', '*', '\x3', '\x2', '\x2', '\x2', '\xF', 
		',', '\x3', '\x2', '\x2', '\x2', '\x11', '.', '\x3', '\x2', '\x2', '\x2', 
		'\x13', '\x31', '\x3', '\x2', '\x2', '\x2', '\x15', ';', '\x3', '\x2', 
		'\x2', '\x2', '\x17', '@', '\x3', '\x2', '\x2', '\x2', '\x19', '\x44', 
		'\x3', '\x2', '\x2', '\x2', '\x1B', '\x46', '\x3', '\x2', '\x2', '\x2', 
		'\x1D', '\x1E', '\a', ']', '\x2', '\x2', '\x1E', '\x4', '\x3', '\x2', 
		'\x2', '\x2', '\x1F', ' ', '\a', '_', '\x2', '\x2', ' ', '\x6', '\x3', 
		'\x2', '\x2', '\x2', '!', '\"', '\a', '}', '\x2', '\x2', '\"', '\b', '\x3', 
		'\x2', '\x2', '\x2', '#', '$', '\a', '\x7F', '\x2', '\x2', '$', '\n', 
		'\x3', '\x2', '\x2', '\x2', '%', '&', '\a', 'p', '\x2', '\x2', '&', '\'', 
		'\a', 'w', '\x2', '\x2', '\'', '(', '\a', 'n', '\x2', '\x2', '(', ')', 
		'\a', 'n', '\x2', '\x2', ')', '\f', '\x3', '\x2', '\x2', '\x2', '*', '+', 
		'\a', '.', '\x2', '\x2', '+', '\xE', '\x3', '\x2', '\x2', '\x2', ',', 
		'-', '\a', '<', '\x2', '\x2', '-', '\x10', '\x3', '\x2', '\x2', '\x2', 
		'.', '/', '\a', '^', '\x2', '\x2', '/', '\x30', '\a', '$', '\x2', '\x2', 
		'\x30', '\x12', '\x3', '\x2', '\x2', '\x2', '\x31', '\x36', '\a', '$', 
		'\x2', '\x2', '\x32', '\x35', '\x5', '\x11', '\t', '\x2', '\x33', '\x35', 
		'\n', '\x2', '\x2', '\x2', '\x34', '\x32', '\x3', '\x2', '\x2', '\x2', 
		'\x34', '\x33', '\x3', '\x2', '\x2', '\x2', '\x35', '\x38', '\x3', '\x2', 
		'\x2', '\x2', '\x36', '\x34', '\x3', '\x2', '\x2', '\x2', '\x36', '\x37', 
		'\x3', '\x2', '\x2', '\x2', '\x37', '\x39', '\x3', '\x2', '\x2', '\x2', 
		'\x38', '\x36', '\x3', '\x2', '\x2', '\x2', '\x39', ':', '\a', '$', '\x2', 
		'\x2', ':', '\x14', '\x3', '\x2', '\x2', '\x2', ';', '<', '\t', '\x3', 
		'\x2', '\x2', '<', '=', '\x3', '\x2', '\x2', '\x2', '=', '>', '\b', '\v', 
		'\x2', '\x2', '>', '\x16', '\x3', '\x2', '\x2', '\x2', '?', '\x41', '\x5', 
		'\x19', '\r', '\x2', '@', '?', '\x3', '\x2', '\x2', '\x2', '\x41', '\x42', 
		'\x3', '\x2', '\x2', '\x2', '\x42', '@', '\x3', '\x2', '\x2', '\x2', '\x42', 
		'\x43', '\x3', '\x2', '\x2', '\x2', '\x43', '\x18', '\x3', '\x2', '\x2', 
		'\x2', '\x44', '\x45', '\t', '\x4', '\x2', '\x2', '\x45', '\x1A', '\x3', 
		'\x2', '\x2', '\x2', '\x46', 'G', '\x5', '\x17', '\f', '\x2', 'G', 'H', 
		'\a', '\x30', '\x2', '\x2', 'H', 'I', '\x5', '\x17', '\f', '\x2', 'I', 
		'\x1C', '\x3', '\x2', '\x2', '\x2', '\x6', '\x2', '\x34', '\x36', '\x42', 
		'\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace testjson
