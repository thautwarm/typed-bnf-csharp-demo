//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/thaut/Desktop/testp/ch.tbnf by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


    using Ava;

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class chParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		INT=1, LETTER=2, NAME=3, FLOAT_NUMBER=4, INT_NUMBER=5, STRING=6, COMMENT=7, 
		WS=8, NEWLINE=9;
	public const int
		RULE_start2 = 0;
	public static readonly string[] ruleNames = {
		"start2"
	};

	private static readonly string[] _LiteralNames = {
	};
	private static readonly string[] _SymbolicNames = {
		null, "INT", "LETTER", "NAME", "FLOAT_NUMBER", "INT_NUMBER", "STRING", 
		"COMMENT", "WS", "NEWLINE"
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

	public override string GrammarFileName { get { return "ch.tbnf"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static chParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public chParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public chParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class Start2Context : ParserRuleContext {
		public int[] a;
		public IToken aaa;
		public ITerminalNode INT() { return GetToken(chParser.INT, 0); }
		public Start2Context(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_start2; } }
	}

	[RuleVersion(0)]
	public Start2Context start2() {
		Start2Context _localctx = new Start2Context(Context, State);
		EnterRule(_localctx, 0, RULE_start2);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2; _localctx.aaa = Match(INT);
			 _localctx.a =  new int[] { int.Parse((_localctx.aaa!=null?_localctx.aaa.Text:null))}; 
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\v', '\b', '\x4', '\x2', '\t', '\x2', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x2', '\x2', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x6', '\x2', '\x4', '\x3', '\x2', '\x2', '\x2', 
		'\x4', '\x5', '\a', '\x3', '\x2', '\x2', '\x5', '\x6', '\b', '\x2', '\x1', 
		'\x2', '\x6', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}