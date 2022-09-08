/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia.FullSerializer
{
	public static class fsJsonPrinter // TypeDefIndex: 9255
	{
		// Methods
		// [XID] // 0x0000000189709C90-0x0000000189709CB0
		private static void InsertSpacing(TextWriter stream, int count) {} // 0x0000000186B555C0-0x0000000186B556B0
		// [XID] // 0x00000001897C9320-0x00000001897C9340
		private static string EscapeString(string str) => default; // 0x0000000186B551E0-0x0000000186B555C0
		// [XID] // 0x0000000189718B70-0x0000000189718B90
		private static void BuildCompressedString(fsData data, TextWriter stream) {} // 0x0000000186B540E0-0x0000000186B546B0
		// [XID] // 0x0000000189B045A0-0x0000000189B045C0
		private static void BuildPrettyString(fsData data, TextWriter stream, int depth) {} // 0x0000000186B546B0-0x0000000186B54DE0
		// [IDTag] // 0x00000001897279C0-0x0000000189727A00
		// [XID] // 0x00000001897279C0-0x0000000189727A00
		public static void PrettyJson(fsData data, TextWriter outputStream) {} // 0x0000000186B55850-0x0000000186B55910
		// [IDTag] // 0x0000000189731E40-0x0000000189731E80
		// [XID] // 0x0000000189731E40-0x0000000189731E80
		public static string PrettyJson(fsData data) => default; // 0x0000000186B556B0-0x0000000186B55850
		// [IDTag] // 0x000000018973CA10-0x000000018973CA50
		// [XID] // 0x000000018973CA10-0x000000018973CA50
		public static void CompressedJson(fsData data, StreamWriter outputStream) {} // 0x0000000186B54DE0-0x0000000186B54EA0
		// [IDTag] // 0x00000001897470D0-0x0000000189747110
		// [XID] // 0x00000001897470D0-0x0000000189747110
		public static string CompressedJson(fsData data) => default; // 0x0000000186B54EA0-0x0000000186B55040
		// [XID] // 0x0000000189751500-0x0000000189751520
		private static string ConvertDoubleToString(double d) => default; // 0x0000000186B55040-0x0000000186B551E0
	}
}
