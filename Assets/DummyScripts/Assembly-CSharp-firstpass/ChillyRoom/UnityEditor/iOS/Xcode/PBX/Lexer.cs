/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace ChillyRoom.UnityEditor.iOS.Xcode.PBX
{
	internal class Lexer // TypeDefIndex: 10370
	{
		// Fields
		private string text; // 0x10
		private int pos; // 0x18
		private int length; // 0x1C
		private int line; // 0x20
	
		// Constructors
		public Lexer() {} // 0x00000001864DE440-0x00000001864DE4A0
	
		// Methods
		// [XID] // 0x000000018969C750-0x000000018969C770
		public static TokenList Tokenize(string text) => default; // 0x00000001864DE270-0x00000001864DE390
		// [XID] // 0x0000000189797690-0x00000001897976B0
		public void SetText(string text) {} // 0x00000001864DE160-0x00000001864DE270
		// [XID] // 0x00000001896BC900-0x00000001896BC920
		public TokenList ScanAll() => default; // 0x00000001864DD580-0x00000001864DD6D0
		// [XID] // 0x00000001897A6B40-0x00000001897A6B60
		private void UpdateNewlineStats(char ch) {} // 0x00000001864DE390-0x00000001864DE440
		// [XID] // 0x00000001896C3E60-0x00000001896C3E80
		private void ScanOne(Token tok) {} // 0x00000001864DD970-0x00000001864DDB90
		// [XID] // 0x00000001897B63D0-0x00000001897B63F0
		private void ScanString(Token tok) {} // 0x00000001864DDFB0-0x00000001864DE160
		// [XID] // 0x000000018965D4E0-0x000000018965D500
		private void ScanQuotedString(Token tok) {} // 0x00000001864DDE20-0x00000001864DDFB0
		// [XID] // 0x00000001897C5850-0x00000001897C5870
		private void ScanMultilineComment(Token tok) {} // 0x00000001864DD810-0x00000001864DD970
		// [XID] // 0x00000001897CCEC0-0x00000001897CCEE0
		private void ScanComment(Token tok) {} // 0x00000001864DD6D0-0x00000001864DD810
		// [XID] // 0x0000000189676260-0x0000000189676280
		private bool IsOperator(char ch) => default; // 0x00000001864DD4A0-0x00000001864DD580
		// [XID] // 0x0000000189666EB0-0x0000000189666ED0
		private void ScanOperator(Token tok) {} // 0x00000001864DDC70-0x00000001864DDE20
		// [XID] // 0x00000001897E3730-0x00000001897E3750
		private void ScanOperatorSpecific(Token tok, TokenType type) {} // 0x00000001864DDB90-0x00000001864DDC70
	}
}
