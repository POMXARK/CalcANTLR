//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: null
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR null /home/roman/FakeGames/Calc.g 2024-05-05 14:03:17

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;
using ConditionalAttribute = System.Diagnostics.ConditionalAttribute;


[System.CodeDom.Compiler.GeneratedCode("ANTLR", "null")]
[System.CLSCompliant(false)]
public partial class CalcParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "ID", "INT", "NEWLINE", "'('", "')'", "'*'", "'+'", "'-'", "'/'", "'='"
	};
	public const int EOF=-1;
	public const int T__7=7;
	public const int T__8=8;
	public const int T__9=9;
	public const int T__10=10;
	public const int T__11=11;
	public const int T__12=12;
	public const int T__13=13;
	public const int ID=4;
	public const int INT=5;
	public const int NEWLINE=6;

	#if ANTLR_DEBUG
	private static readonly bool[] decisionCanBacktrack =
		new bool[]
		{
			false, // invalid decision
			false, false, false, false, false
		};
	#else
	private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public CalcParser(ITokenStream input)
		: this(input, new RecognizerSharedState())
	{
	}
	public CalcParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		OnCreated();
	}

	public override string[] TokenNames { get { return CalcParser.tokenNames; } }
	public override string GrammarFileName { get { return "/home/roman/FakeGames/Calc.g"; } }


	[Conditional("ANTLR_TRACE")]
	protected virtual void OnCreated() {}
	[Conditional("ANTLR_TRACE")]
	protected virtual void EnterRule(string ruleName, int ruleIndex) {}
	[Conditional("ANTLR_TRACE")]
	protected virtual void LeaveRule(string ruleName, int ruleIndex) {}

	#region Rules

	[Conditional("ANTLR_TRACE")]
	protected virtual void EnterRule_calc() {}
	[Conditional("ANTLR_TRACE")]
	protected virtual void LeaveRule_calc() {}
	// $ANTLR start "calc"
	// /home/roman/FakeGames/Calc.g:18:1: calc : ( statement )+ ;
	[GrammarRule("calc")]
	public void calc()
	{
		EnterRule_calc();
		EnterRule("calc", 1);
		TraceIn("calc", 1);
		try { DebugEnterRule(GrammarFileName, "calc");
		DebugLocation(18, 1);
		try
		{
			// /home/roman/FakeGames/Calc.g:19:2: ( ( statement )+ )
			DebugEnterAlt(1);
			// /home/roman/FakeGames/Calc.g:19:4: ( statement )+
			{
			DebugLocation(19, 4);
			// /home/roman/FakeGames/Calc.g:19:4: ( statement )+
			int cnt1=0;
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_1 = input.LA(1);

				if (((LA1_1>=ID && LA1_1<=7)))
				{
					alt1 = 1;
				}


				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// /home/roman/FakeGames/Calc.g:19:4: statement
					{
					DebugLocation(19, 4);
					PushFollow(Follow._statement_in_calc113);
					statement();
					PopFollow();


					}
					break;

				default:
					if (cnt1 >= 1)
						goto loop1;

					EarlyExitException eee1 = new EarlyExitException( 1, input );
					DebugRecognitionException(eee1);
					throw eee1;
				}
				cnt1++;
			}
			loop1:
				;

			} finally { DebugExitSubRule(1); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("calc", 1);
			LeaveRule("calc", 1);
			LeaveRule_calc();
	    }
	 	DebugLocation(20, 1);
		} finally { DebugExitRule(GrammarFileName, "calc"); }
		return;

	}
	// $ANTLR end "calc"


	[Conditional("ANTLR_TRACE")]
	protected virtual void EnterRule_statement() {}
	[Conditional("ANTLR_TRACE")]
	protected virtual void LeaveRule_statement() {}
	// $ANTLR start "statement"
	// /home/roman/FakeGames/Calc.g:21:1: statement : ( expr NEWLINE | ID '=' expr NEWLINE | NEWLINE );
	[GrammarRule("statement")]
	private void statement()
	{
		EnterRule_statement();
		EnterRule("statement", 2);
		TraceIn("statement", 2);
		try { DebugEnterRule(GrammarFileName, "statement");
		DebugLocation(21, 1);
		try
		{
			// /home/roman/FakeGames/Calc.g:22:2: ( expr NEWLINE | ID '=' expr NEWLINE | NEWLINE )
			int alt2=3;
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			switch (input.LA(1))
			{
			case ID:
				{
				int LA2_2 = input.LA(2);

				if ((LA2_2==13))
				{
					alt2 = 2;
				}
				else if ((LA2_2==NEWLINE||(LA2_2>=9 && LA2_2<=12)))
				{
					alt2 = 1;
				}

				else
				{
					NoViableAltException nvae = new NoViableAltException("", 2, 1, input, 2);
					DebugRecognitionException(nvae);
					throw nvae;
				}

				}
				break;
			case INT:
			case 7:
				{
				alt2 = 1;
				}
				break;
			case NEWLINE:
				{
				alt2 = 3;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 2, 0, input, 1);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// /home/roman/FakeGames/Calc.g:22:4: expr NEWLINE
				{
				DebugLocation(22, 4);
				PushFollow(Follow._expr_in_statement124);
				expr();
				PopFollow();

				DebugLocation(22, 9);
				Match(input,NEWLINE,Follow._NEWLINE_in_statement126); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// /home/roman/FakeGames/Calc.g:23:4: ID '=' expr NEWLINE
				{
				DebugLocation(23, 4);
				Match(input,ID,Follow._ID_in_statement131); 
				DebugLocation(23, 7);
				Match(input,13,Follow._13_in_statement133); 
				DebugLocation(23, 11);
				PushFollow(Follow._expr_in_statement135);
				expr();
				PopFollow();

				DebugLocation(23, 16);
				Match(input,NEWLINE,Follow._NEWLINE_in_statement137); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// /home/roman/FakeGames/Calc.g:24:4: NEWLINE
				{
				DebugLocation(24, 4);
				Match(input,NEWLINE,Follow._NEWLINE_in_statement142); 

				}
				break;

			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("statement", 2);
			LeaveRule("statement", 2);
			LeaveRule_statement();
	    }
	 	DebugLocation(25, 1);
		} finally { DebugExitRule(GrammarFileName, "statement"); }
		return;

	}
	// $ANTLR end "statement"


	[Conditional("ANTLR_TRACE")]
	protected virtual void EnterRule_expr() {}
	[Conditional("ANTLR_TRACE")]
	protected virtual void LeaveRule_expr() {}
	// $ANTLR start "expr"
	// /home/roman/FakeGames/Calc.g:28:2: expr : multExpression ( '+' multExpression | '-' multExpression )* ;
	[GrammarRule("expr")]
	private void expr()
	{
		EnterRule_expr();
		EnterRule("expr", 3);
		TraceIn("expr", 3);
		try { DebugEnterRule(GrammarFileName, "expr");
		DebugLocation(28, 1);
		try
		{
			// /home/roman/FakeGames/Calc.g:29:2: ( multExpression ( '+' multExpression | '-' multExpression )* )
			DebugEnterAlt(1);
			// /home/roman/FakeGames/Calc.g:29:4: multExpression ( '+' multExpression | '-' multExpression )*
			{
			DebugLocation(29, 4);
			PushFollow(Follow._multExpression_in_expr166);
			multExpression();
			PopFollow();

			DebugLocation(29, 19);
			// /home/roman/FakeGames/Calc.g:29:19: ( '+' multExpression | '-' multExpression )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=3;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_1 = input.LA(1);

				if ((LA3_1==10))
				{
					alt3 = 1;
				}
				else if ((LA3_1==11))
				{
					alt3 = 2;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// /home/roman/FakeGames/Calc.g:29:20: '+' multExpression
					{
					DebugLocation(29, 20);
					Match(input,10,Follow._10_in_expr169); 
					DebugLocation(29, 24);
					PushFollow(Follow._multExpression_in_expr171);
					multExpression();
					PopFollow();


					}
					break;
				case 2:
					DebugEnterAlt(2);
					// /home/roman/FakeGames/Calc.g:29:40: '-' multExpression
					{
					DebugLocation(29, 40);
					Match(input,11,Follow._11_in_expr174); 
					DebugLocation(29, 44);
					PushFollow(Follow._multExpression_in_expr176);
					multExpression();
					PopFollow();


					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("expr", 3);
			LeaveRule("expr", 3);
			LeaveRule_expr();
	    }
	 	DebugLocation(30, 1);
		} finally { DebugExitRule(GrammarFileName, "expr"); }
		return;

	}
	// $ANTLR end "expr"


	[Conditional("ANTLR_TRACE")]
	protected virtual void EnterRule_multExpression() {}
	[Conditional("ANTLR_TRACE")]
	protected virtual void LeaveRule_multExpression() {}
	// $ANTLR start "multExpression"
	// /home/roman/FakeGames/Calc.g:31:2: multExpression : a1= atom ( '*' a2= atom | '/' a2= atom )* ;
	[GrammarRule("multExpression")]
	private void multExpression()
	{
		EnterRule_multExpression();
		EnterRule("multExpression", 4);
		TraceIn("multExpression", 4);
		try { DebugEnterRule(GrammarFileName, "multExpression");
		DebugLocation(31, 1);
		try
		{
			// /home/roman/FakeGames/Calc.g:32:2: (a1= atom ( '*' a2= atom | '/' a2= atom )* )
			DebugEnterAlt(1);
			// /home/roman/FakeGames/Calc.g:32:4: a1= atom ( '*' a2= atom | '/' a2= atom )*
			{
			DebugLocation(32, 6);
			PushFollow(Follow._atom_in_multExpression191);
			atom();
			PopFollow();

			DebugLocation(32, 12);
			// /home/roman/FakeGames/Calc.g:32:12: ( '*' a2= atom | '/' a2= atom )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=3;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_1 = input.LA(1);

				if ((LA4_1==9))
				{
					alt4 = 1;
				}
				else if ((LA4_1==12))
				{
					alt4 = 2;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// /home/roman/FakeGames/Calc.g:32:13: '*' a2= atom
					{
					DebugLocation(32, 13);
					Match(input,9,Follow._9_in_multExpression194); 
					DebugLocation(32, 19);
					PushFollow(Follow._atom_in_multExpression198);
					atom();
					PopFollow();


					}
					break;
				case 2:
					DebugEnterAlt(2);
					// /home/roman/FakeGames/Calc.g:32:27: '/' a2= atom
					{
					DebugLocation(32, 27);
					Match(input,12,Follow._12_in_multExpression202); 
					DebugLocation(32, 33);
					PushFollow(Follow._atom_in_multExpression206);
					atom();
					PopFollow();


					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("multExpression", 4);
			LeaveRule("multExpression", 4);
			LeaveRule_multExpression();
	    }
	 	DebugLocation(33, 1);
		} finally { DebugExitRule(GrammarFileName, "multExpression"); }
		return;

	}
	// $ANTLR end "multExpression"


	[Conditional("ANTLR_TRACE")]
	protected virtual void EnterRule_atom() {}
	[Conditional("ANTLR_TRACE")]
	protected virtual void LeaveRule_atom() {}
	// $ANTLR start "atom"
	// /home/roman/FakeGames/Calc.g:35:1: atom : ( ID | INT | '(' expr ')' );
	[GrammarRule("atom")]
	private void atom()
	{
		EnterRule_atom();
		EnterRule("atom", 5);
		TraceIn("atom", 5);
		try { DebugEnterRule(GrammarFileName, "atom");
		DebugLocation(35, 1);
		try
		{
			// /home/roman/FakeGames/Calc.g:36:2: ( ID | INT | '(' expr ')' )
			int alt5=3;
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			switch (input.LA(1))
			{
			case ID:
				{
				alt5 = 1;
				}
				break;
			case INT:
				{
				alt5 = 2;
				}
				break;
			case 7:
				{
				alt5 = 3;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 5, 0, input, 1);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// /home/roman/FakeGames/Calc.g:36:4: ID
				{
				DebugLocation(36, 4);
				Match(input,ID,Follow._ID_in_atom220); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// /home/roman/FakeGames/Calc.g:37:4: INT
				{
				DebugLocation(37, 4);
				Match(input,INT,Follow._INT_in_atom225); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// /home/roman/FakeGames/Calc.g:38:4: '(' expr ')'
				{
				DebugLocation(38, 4);
				Match(input,7,Follow._7_in_atom230); 
				DebugLocation(38, 8);
				PushFollow(Follow._expr_in_atom232);
				expr();
				PopFollow();

				DebugLocation(38, 13);
				Match(input,8,Follow._8_in_atom234); 

				}
				break;

			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("atom", 5);
			LeaveRule("atom", 5);
			LeaveRule_atom();
	    }
	 	DebugLocation(39, 1);
		} finally { DebugExitRule(GrammarFileName, "atom"); }
		return;

	}
	// $ANTLR end "atom"
	#endregion Rules


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _statement_in_calc113 = new BitSet(new ulong[]{0xF2UL});
		public static readonly BitSet _expr_in_statement124 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _NEWLINE_in_statement126 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_statement131 = new BitSet(new ulong[]{0x2000UL});
		public static readonly BitSet _13_in_statement133 = new BitSet(new ulong[]{0xB0UL});
		public static readonly BitSet _expr_in_statement135 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _NEWLINE_in_statement137 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NEWLINE_in_statement142 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _multExpression_in_expr166 = new BitSet(new ulong[]{0xC02UL});
		public static readonly BitSet _10_in_expr169 = new BitSet(new ulong[]{0xB0UL});
		public static readonly BitSet _multExpression_in_expr171 = new BitSet(new ulong[]{0xC02UL});
		public static readonly BitSet _11_in_expr174 = new BitSet(new ulong[]{0xB0UL});
		public static readonly BitSet _multExpression_in_expr176 = new BitSet(new ulong[]{0xC02UL});
		public static readonly BitSet _atom_in_multExpression191 = new BitSet(new ulong[]{0x1202UL});
		public static readonly BitSet _9_in_multExpression194 = new BitSet(new ulong[]{0xB0UL});
		public static readonly BitSet _atom_in_multExpression198 = new BitSet(new ulong[]{0x1202UL});
		public static readonly BitSet _12_in_multExpression202 = new BitSet(new ulong[]{0xB0UL});
		public static readonly BitSet _atom_in_multExpression206 = new BitSet(new ulong[]{0x1202UL});
		public static readonly BitSet _ID_in_atom220 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _INT_in_atom225 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _7_in_atom230 = new BitSet(new ulong[]{0xB0UL});
		public static readonly BitSet _expr_in_atom232 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _8_in_atom234 = new BitSet(new ulong[]{0x2UL});
	}
	#endregion Follow sets
}

