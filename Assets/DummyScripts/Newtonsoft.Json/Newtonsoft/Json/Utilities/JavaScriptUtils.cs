/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal static class JavaScriptUtils // TypeDefIndex: 5336
	{
		// Fields
		internal static readonly bool[] SingleQuoteCharEscapeFlags; // 0x00
		internal static readonly bool[] DoubleQuoteCharEscapeFlags; // 0x08
		internal static readonly bool[] HtmlCharEscapeFlags; // 0x10
	
		// Constructors
		static JavaScriptUtils() {} // 0x0000000185E55C10-0x0000000185E56660
	
		// Methods
		public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar) => default; // 0x0000000185E55300-0x0000000185E55400
		public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags) => default; // 0x0000000185E55400-0x0000000185E554E0
		public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer) {} // 0x0000000185E556F0-0x0000000185E55C10
		public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) => default; // 0x0000000185E554E0-0x0000000185E556F0
	}
}
