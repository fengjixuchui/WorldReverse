/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace ChillyRoom.UnityEditor.iOS.Xcode.PBX
{
	internal class Serializer // TypeDefIndex: 10404
	{
		// Fields
		private static string k_Indent; // 0x00
	
		// Constructors
		public Serializer() {} // 0x0000000186D44520-0x0000000186D44580
		static Serializer() {} // 0x0000000186D444B0-0x0000000186D44520
	
		// Methods
		// [XID] // 0x00000001897B8D80-0x00000001897B8DA0
		public static PBXElementDict ParseTreeAST(TreeAST ast, TokenList tokens, string text) => default; // 0x0000000186D43040-0x0000000186D432A0
		// [XID] // 0x000000018971B910-0x000000018971B930
		public static PBXElementArray ParseArrayAST(ArrayAST ast, TokenList tokens, string text) => default; // 0x0000000186D42C50-0x0000000186D42E80
		// [XID] // 0x00000001897C0E30-0x00000001897C0E50
		public static PBXElement ParseValueAST(ValueAST ast, TokenList tokens, string text) => default; // 0x0000000186D432A0-0x0000000186D435D0
		// [XID] // 0x0000000189713FB0-0x0000000189713FD0
		public static PBXElementString ParseIdentifierAST(IdentifierAST ast, TokenList tokens, string text) => default; // 0x0000000186D42E80-0x0000000186D43040
		// [XID] // 0x0000000189A92C00-0x0000000189A92C20
		private static string GetIndent(int indent) => default; // 0x0000000186D42B60-0x0000000186D42C50
		// [XID] // 0x0000000189B6D910-0x0000000189B6D930
		private static void WriteStringImpl(StringBuilder sb, string s, bool comment, GUIDToCommentMap comments) {} // 0x0000000186D44390-0x0000000186D444B0
		// [XID] // 0x00000001899EFFA0-0x00000001899EFFC0
		public static void WriteDictKeyValue(StringBuilder sb, string key, PBXElement value, int indent, bool compact, PropertyCommentChecker checker, GUIDToCommentMap comments) {} // 0x0000000186D43B00-0x0000000186D43F20
		// [XID] // 0x0000000189A06580-0x0000000189A065A0
		public static void WriteDict(StringBuilder sb, PBXElementDict el, int indent, bool compact, PropertyCommentChecker checker, GUIDToCommentMap comments) {} // 0x0000000186D43F20-0x0000000186D44390
		// [XID] // 0x0000000189AB8020-0x0000000189AB8040
		public static void WriteArray(StringBuilder sb, PBXElementArray el, int indent, bool compact, PropertyCommentChecker checker, GUIDToCommentMap comments) {} // 0x0000000186D435D0-0x0000000186D43B00
	}
}
