//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/thaut/Desktop/testp/testjson.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

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
public partial class testjsonParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, STR_2=7, WS_3=8, INT_5=9, 
		FLOAT_6=10;
	public const int
		RULE_json = 0, RULE_gen__seplist__L44__pair = 1, RULE_gen__seplist__L44__json = 2, 
		RULE_pair = 3, RULE_str = 4, RULE_start = 5;
	public static readonly string[] ruleNames = {
		"json", "gen__seplist__L44__pair", "gen__seplist__L44__json", "pair", 
		"str", "start"
	};

	private static readonly string[] _LiteralNames = {
		null, "'['", "']'", "'{'", "'}'", "','", "':'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, "STR_2", "WS_3", "INT_5", "FLOAT_6"
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

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static testjsonParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public testjsonParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public testjsonParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class JsonContext : ParserRuleContext {
		public json result;
		public Gen__seplist__L44__jsonContext local__2_json_case0;
		public Gen__seplist__L44__pairContext local__2_json_case1;
		public IToken local__1_json_case2;
		public IToken local__1_json_case3;
		public StrContext local__1_json_case4;
		public Gen__seplist__L44__jsonContext gen__seplist__L44__json() {
			return GetRuleContext<Gen__seplist__L44__jsonContext>(0);
		}
		public Gen__seplist__L44__pairContext gen__seplist__L44__pair() {
			return GetRuleContext<Gen__seplist__L44__pairContext>(0);
		}
		public ITerminalNode INT_5() { return GetToken(testjsonParser.INT_5, 0); }
		public ITerminalNode FLOAT_6() { return GetToken(testjsonParser.FLOAT_6, 0); }
		public StrContext str() {
			return GetRuleContext<StrContext>(0);
		}
		public JsonContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_json; } }
	}

	[RuleVersion(0)]
	public JsonContext json() {
		JsonContext _localctx = new JsonContext(Context, State);
		EnterRule(_localctx, 0, RULE_json);
		try {
			State = 29;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__0:
				EnterOuterAlt(_localctx, 1);
				{
				State = 12; Match(T__0);
				State = 13; _localctx.local__2_json_case0 = gen__seplist__L44__json(0);
				State = 14; Match(T__1);
				 
				        json tmp__2 ; 
				        System.Collections.Generic.List<json> tmp__1 ; 
				        tmp__1 = ( System.Collections.Generic.List<json> ) _localctx.local__2_json_case0.result ; 
				        tmp__2 = (json) json_list( tmp__1 ); 
				        _localctx.result =  tmp__2; 
				      
				}
				break;
			case T__2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 17; Match(T__2);
				State = 18; _localctx.local__2_json_case1 = gen__seplist__L44__pair(0);
				State = 19; Match(T__3);
				 
				        json tmp__5 ; 
				        System.Collections.Generic.Dictionary<string, json> tmp__4 ; 
				        System.Collections.Generic.List<(string, json)> tmp__3 ; 
				        tmp__3 = ( System.Collections.Generic.List<(string, json)> ) _localctx.local__2_json_case1.result ; 
				        tmp__4 = (System.Collections.Generic.Dictionary<string, json>) mk_dict<string,json>( tmp__3 ); 
				        tmp__5 = (json) json_dict( tmp__4 ); 
				        _localctx.result =  tmp__5; 
				      
				}
				break;
			case INT_5:
				EnterOuterAlt(_localctx, 3);
				{
				State = 22; _localctx.local__1_json_case2 = Match(INT_5);
				 
				        json tmp__8 ; 
				        int tmp__7 ; 
				        CommonToken tmp__6 ; 
				        tmp__6 = ( CommonToken ) _localctx.local__1_json_case2 ; 
				        tmp__7 = (int) parse_int( tmp__6.Text ); 
				        tmp__8 = (json) json_int( tmp__7 ); 
				        _localctx.result =  tmp__8; 
				      
				}
				break;
			case FLOAT_6:
				EnterOuterAlt(_localctx, 4);
				{
				State = 24; _localctx.local__1_json_case3 = Match(FLOAT_6);
				 
				        json tmp__11 ; 
				        float tmp__10 ; 
				        CommonToken tmp__9 ; 
				        tmp__9 = ( CommonToken ) _localctx.local__1_json_case3 ; 
				        tmp__10 = (float) parse_float( tmp__9.Text ); 
				        tmp__11 = (json) json_float( tmp__10 ); 
				        _localctx.result =  tmp__11; 
				      
				}
				break;
			case STR_2:
				EnterOuterAlt(_localctx, 5);
				{
				State = 26; _localctx.local__1_json_case4 = str();
				 
				        json tmp__14 ; 
				        string tmp__13 ; 
				        string tmp__12 ; 
				        tmp__12 = ( string ) _localctx.local__1_json_case4.result ; 
				        tmp__13 = (string) unesc_string( tmp__12 ); 
				        tmp__14 = (json) json_string( tmp__13 ); 
				        _localctx.result =  tmp__14; 
				      
				}
				break;
			default:
				throw new NoViableAltException(this);
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

	public partial class Gen__seplist__L44__pairContext : ParserRuleContext {
		public System.Collections.Generic.List<(string, json)> result;
		public Gen__seplist__L44__pairContext local__1_gen__seplist__L44__pair_case0;
		public PairContext local__3_gen__seplist__L44__pair_case0;
		public Gen__seplist__L44__pairContext gen__seplist__L44__pair() {
			return GetRuleContext<Gen__seplist__L44__pairContext>(0);
		}
		public PairContext pair() {
			return GetRuleContext<PairContext>(0);
		}
		public Gen__seplist__L44__pairContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_gen__seplist__L44__pair; } }
	}

	[RuleVersion(0)]
	public Gen__seplist__L44__pairContext gen__seplist__L44__pair() {
		return gen__seplist__L44__pair(0);
	}

	private Gen__seplist__L44__pairContext gen__seplist__L44__pair(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		Gen__seplist__L44__pairContext _localctx = new Gen__seplist__L44__pairContext(Context, _parentState);
		Gen__seplist__L44__pairContext _prevctx = _localctx;
		int _startState = 2;
		EnterRecursionRule(_localctx, 2, RULE_gen__seplist__L44__pair, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			 
			        System.Collections.Generic.List<(string, json)> tmp__18 ; 
			        tmp__18 = (System.Collections.Generic.List<(string, json)>) nil<(string, json)>(  ); 
			        _localctx.result =  tmp__18; 
			      
			}
			Context.Stop = TokenStream.LT(-1);
			State = 41;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,1,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new Gen__seplist__L44__pairContext(_parentctx, _parentState);
					_localctx.local__1_gen__seplist__L44__pair_case0 = _prevctx;
					PushNewRecursionContext(_localctx, _startState, RULE_gen__seplist__L44__pair);
					State = 34;
					if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
					State = 35; Match(T__4);
					State = 36; _localctx.local__3_gen__seplist__L44__pair_case0 = pair();
					 
					                  System.Collections.Generic.List<(string, json)> tmp__17 ; 
					                  (string, json) tmp__16 ; 
					                  System.Collections.Generic.List<(string, json)> tmp__15 ; 
					                  tmp__15 = ( System.Collections.Generic.List<(string, json)> ) _localctx.local__1_gen__seplist__L44__pair_case0.result ; 
					                  tmp__16 = ( (string, json) ) _localctx.local__3_gen__seplist__L44__pair_case0.result ; 
					                  tmp__17 = (System.Collections.Generic.List<(string, json)>) append<(string, json)>( tmp__15, tmp__16 ); 
					                  _localctx.result =  tmp__17; 
					                
					}
					} 
				}
				State = 43;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,1,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class Gen__seplist__L44__jsonContext : ParserRuleContext {
		public System.Collections.Generic.List<json> result;
		public Gen__seplist__L44__jsonContext local__1_gen__seplist__L44__json_case0;
		public JsonContext local__3_gen__seplist__L44__json_case0;
		public Gen__seplist__L44__jsonContext gen__seplist__L44__json() {
			return GetRuleContext<Gen__seplist__L44__jsonContext>(0);
		}
		public JsonContext json() {
			return GetRuleContext<JsonContext>(0);
		}
		public Gen__seplist__L44__jsonContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_gen__seplist__L44__json; } }
	}

	[RuleVersion(0)]
	public Gen__seplist__L44__jsonContext gen__seplist__L44__json() {
		return gen__seplist__L44__json(0);
	}

	private Gen__seplist__L44__jsonContext gen__seplist__L44__json(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		Gen__seplist__L44__jsonContext _localctx = new Gen__seplist__L44__jsonContext(Context, _parentState);
		Gen__seplist__L44__jsonContext _prevctx = _localctx;
		int _startState = 4;
		EnterRecursionRule(_localctx, 4, RULE_gen__seplist__L44__json, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			 
			        System.Collections.Generic.List<json> tmp__22 ; 
			        tmp__22 = (System.Collections.Generic.List<json>) nil<json>(  ); 
			        _localctx.result =  tmp__22; 
			      
			}
			Context.Stop = TokenStream.LT(-1);
			State = 54;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new Gen__seplist__L44__jsonContext(_parentctx, _parentState);
					_localctx.local__1_gen__seplist__L44__json_case0 = _prevctx;
					PushNewRecursionContext(_localctx, _startState, RULE_gen__seplist__L44__json);
					State = 47;
					if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
					State = 48; Match(T__4);
					State = 49; _localctx.local__3_gen__seplist__L44__json_case0 = json();
					 
					                  System.Collections.Generic.List<json> tmp__21 ; 
					                  json tmp__20 ; 
					                  System.Collections.Generic.List<json> tmp__19 ; 
					                  tmp__19 = ( System.Collections.Generic.List<json> ) _localctx.local__1_gen__seplist__L44__json_case0.result ; 
					                  tmp__20 = ( json ) _localctx.local__3_gen__seplist__L44__json_case0.result ; 
					                  tmp__21 = (System.Collections.Generic.List<json>) append<json>( tmp__19, tmp__20 ); 
					                  _localctx.result =  tmp__21; 
					                
					}
					} 
				}
				State = 56;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class PairContext : ParserRuleContext {
		public (string, json) result;
		public StrContext local__1_pair_case0;
		public JsonContext local__3_pair_case0;
		public StrContext str() {
			return GetRuleContext<StrContext>(0);
		}
		public JsonContext json() {
			return GetRuleContext<JsonContext>(0);
		}
		public PairContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_pair; } }
	}

	[RuleVersion(0)]
	public PairContext pair() {
		PairContext _localctx = new PairContext(Context, State);
		EnterRule(_localctx, 6, RULE_pair);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 57; _localctx.local__1_pair_case0 = str();
			State = 58; Match(T__5);
			State = 59; _localctx.local__3_pair_case0 = json();
			 
			        json tmp__25 ; 
			        string tmp__24 ; 
			        (string, json) tmp__23 ; 
			        tmp__24 = ( string ) _localctx.local__1_pair_case0.result ; 
			        tmp__25 = ( json ) _localctx.local__3_pair_case0.result ; 
			        tmp__23 = ( tmp__24 , tmp__25 ); 
			        _localctx.result =  tmp__23; 
			      
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

	public partial class StrContext : ParserRuleContext {
		public string result;
		public IToken local__1_str_case0;
		public ITerminalNode STR_2() { return GetToken(testjsonParser.STR_2, 0); }
		public StrContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_str; } }
	}

	[RuleVersion(0)]
	public StrContext str() {
		StrContext _localctx = new StrContext(Context, State);
		EnterRule(_localctx, 8, RULE_str);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 62; _localctx.local__1_str_case0 = Match(STR_2);
			 
			        CommonToken tmp__26 ; 
			        tmp__26 = ( CommonToken ) _localctx.local__1_str_case0 ; 
			        _localctx.result =  tmp__26.Text; 
			      
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

	public partial class StartContext : ParserRuleContext {
		public json result;
		public JsonContext local__1_start_case0;
		public JsonContext json() {
			return GetRuleContext<JsonContext>(0);
		}
		public StartContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_start; } }
	}

	[RuleVersion(0)]
	public StartContext start() {
		StartContext _localctx = new StartContext(Context, State);
		EnterRule(_localctx, 10, RULE_start);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 65; _localctx.local__1_start_case0 = json();
			 
			        json tmp__27 ; 
			        tmp__27 = ( json ) _localctx.local__1_start_case0.result ; 
			        _localctx.result =  tmp__27; 
			      
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

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 1: return gen__seplist__L44__pair_sempred((Gen__seplist__L44__pairContext)_localctx, predIndex);
		case 2: return gen__seplist__L44__json_sempred((Gen__seplist__L44__jsonContext)_localctx, predIndex);
		}
		return true;
	}
	private bool gen__seplist__L44__pair_sempred(Gen__seplist__L44__pairContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 2);
		}
		return true;
	}
	private bool gen__seplist__L44__json_sempred(Gen__seplist__L44__jsonContext _localctx, int predIndex) {
		switch (predIndex) {
		case 1: return Precpred(Context, 2);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\f', 'G', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', '\t', 
		'\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', '\x6', 
		'\t', '\x6', '\x4', '\a', '\t', '\a', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x5', 
		'\x2', ' ', '\n', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\a', '\x3', 
		'*', '\n', '\x3', '\f', '\x3', '\xE', '\x3', '-', '\v', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\a', '\x4', '\x37', '\n', '\x4', '\f', 
		'\x4', '\xE', '\x4', ':', '\v', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x2', '\x4', 
		'\x4', '\x6', '\b', '\x2', '\x4', '\x6', '\b', '\n', '\f', '\x2', '\x2', 
		'\x2', '\x46', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x4', '!', 
		'\x3', '\x2', '\x2', '\x2', '\x6', '.', '\x3', '\x2', '\x2', '\x2', '\b', 
		';', '\x3', '\x2', '\x2', '\x2', '\n', '@', '\x3', '\x2', '\x2', '\x2', 
		'\f', '\x43', '\x3', '\x2', '\x2', '\x2', '\xE', '\xF', '\a', '\x3', '\x2', 
		'\x2', '\xF', '\x10', '\x5', '\x6', '\x4', '\x2', '\x10', '\x11', '\a', 
		'\x4', '\x2', '\x2', '\x11', '\x12', '\b', '\x2', '\x1', '\x2', '\x12', 
		' ', '\x3', '\x2', '\x2', '\x2', '\x13', '\x14', '\a', '\x5', '\x2', '\x2', 
		'\x14', '\x15', '\x5', '\x4', '\x3', '\x2', '\x15', '\x16', '\a', '\x6', 
		'\x2', '\x2', '\x16', '\x17', '\b', '\x2', '\x1', '\x2', '\x17', ' ', 
		'\x3', '\x2', '\x2', '\x2', '\x18', '\x19', '\a', '\v', '\x2', '\x2', 
		'\x19', ' ', '\b', '\x2', '\x1', '\x2', '\x1A', '\x1B', '\a', '\f', '\x2', 
		'\x2', '\x1B', ' ', '\b', '\x2', '\x1', '\x2', '\x1C', '\x1D', '\x5', 
		'\n', '\x6', '\x2', '\x1D', '\x1E', '\b', '\x2', '\x1', '\x2', '\x1E', 
		' ', '\x3', '\x2', '\x2', '\x2', '\x1F', '\xE', '\x3', '\x2', '\x2', '\x2', 
		'\x1F', '\x13', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x18', '\x3', '\x2', 
		'\x2', '\x2', '\x1F', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x1C', 
		'\x3', '\x2', '\x2', '\x2', ' ', '\x3', '\x3', '\x2', '\x2', '\x2', '!', 
		'\"', '\b', '\x3', '\x1', '\x2', '\"', '#', '\b', '\x3', '\x1', '\x2', 
		'#', '+', '\x3', '\x2', '\x2', '\x2', '$', '%', '\f', '\x4', '\x2', '\x2', 
		'%', '&', '\a', '\a', '\x2', '\x2', '&', '\'', '\x5', '\b', '\x5', '\x2', 
		'\'', '(', '\b', '\x3', '\x1', '\x2', '(', '*', '\x3', '\x2', '\x2', '\x2', 
		')', '$', '\x3', '\x2', '\x2', '\x2', '*', '-', '\x3', '\x2', '\x2', '\x2', 
		'+', ')', '\x3', '\x2', '\x2', '\x2', '+', ',', '\x3', '\x2', '\x2', '\x2', 
		',', '\x5', '\x3', '\x2', '\x2', '\x2', '-', '+', '\x3', '\x2', '\x2', 
		'\x2', '.', '/', '\b', '\x4', '\x1', '\x2', '/', '\x30', '\b', '\x4', 
		'\x1', '\x2', '\x30', '\x38', '\x3', '\x2', '\x2', '\x2', '\x31', '\x32', 
		'\f', '\x4', '\x2', '\x2', '\x32', '\x33', '\a', '\a', '\x2', '\x2', '\x33', 
		'\x34', '\x5', '\x2', '\x2', '\x2', '\x34', '\x35', '\b', '\x4', '\x1', 
		'\x2', '\x35', '\x37', '\x3', '\x2', '\x2', '\x2', '\x36', '\x31', '\x3', 
		'\x2', '\x2', '\x2', '\x37', ':', '\x3', '\x2', '\x2', '\x2', '\x38', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '\x38', '\x39', '\x3', '\x2', '\x2', 
		'\x2', '\x39', '\a', '\x3', '\x2', '\x2', '\x2', ':', '\x38', '\x3', '\x2', 
		'\x2', '\x2', ';', '<', '\x5', '\n', '\x6', '\x2', '<', '=', '\a', '\b', 
		'\x2', '\x2', '=', '>', '\x5', '\x2', '\x2', '\x2', '>', '?', '\b', '\x5', 
		'\x1', '\x2', '?', '\t', '\x3', '\x2', '\x2', '\x2', '@', '\x41', '\a', 
		'\t', '\x2', '\x2', '\x41', '\x42', '\b', '\x6', '\x1', '\x2', '\x42', 
		'\v', '\x3', '\x2', '\x2', '\x2', '\x43', '\x44', '\x5', '\x2', '\x2', 
		'\x2', '\x44', '\x45', '\b', '\a', '\x1', '\x2', '\x45', '\r', '\x3', 
		'\x2', '\x2', '\x2', '\x5', '\x1F', '+', '\x38',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}