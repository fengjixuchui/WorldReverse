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
	internal class Parser // TypeDefIndex: 10399
	{
		// Fields
		private TokenList tokens; // 0x10
		private int currPos; // 0x18
	
		// Constructors
		public Parser() {} // Dummy constructor
		public Parser(TokenList tokens) {} // 0x00000001864E5070-0x00000001864E50F0
	
		// Methods
		// [XID] // 0x00000001898556B0-0x00000001898556D0
		private int SkipComments(int pos) => default; // 0x00000001864E4DA0-0x00000001864E4EB0
		// [XID] // 0x0000000189864570-0x0000000189864590
		private int IncInternal(int pos) => default; // 0x00000001864E44A0-0x00000001864E4580
		// [XID] // 0x0000000189AD0540-0x0000000189AD0560
		private int Inc() => default; // 0x00000001864E4580-0x00000001864E4640
		// [XID] // 0x0000000189AD82D0-0x0000000189AD82F0
		private TokenType Tok() => default; // 0x00000001864E4F70-0x00000001864E5070
		// [XID] // 0x000000018986BAA0-0x000000018986BAC0
		private void SkipIf(TokenType type) {} // 0x00000001864E4EB0-0x00000001864E4F70
		// [XID] // 0x0000000189AE7580-0x0000000189AE75A0
		private string GetErrorMsg() => default; // 0x00000001864E4370-0x00000001864E44A0
		// [XID] // 0x0000000189AEF2F0-0x0000000189AEF310
		public IdentifierAST ParseIdentifier() => default; // 0x00000001864E4640-0x00000001864E4780
		// [XID] // 0x0000000189AA78D0-0x0000000189AA78F0
		public TreeAST ParseTree() => default; // 0x00000001864E4AC0-0x00000001864E4C60
		// [XID] // 0x00000001896F64A0-0x00000001896F64C0
		public ArrayAST ParseList() => default; // 0x00000001864E4910-0x00000001864E4AC0
		// [XID] // 0x0000000189B05410-0x0000000189B05430
		public KeyValueAST ParseKeyValue() => default; // 0x00000001864E4780-0x00000001864E4910
		// [XID] // 0x000000018979A350-0x000000018979A370
		public ValueAST ParseValue() => default; // 0x00000001864E4C60-0x00000001864E4DA0
	}
}
