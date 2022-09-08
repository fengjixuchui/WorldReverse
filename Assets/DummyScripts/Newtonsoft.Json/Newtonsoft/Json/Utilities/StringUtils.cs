/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x0000000189B2BE30-0x0000000189B2BE60
	internal static class StringUtils // TypeDefIndex: 5346
	{
		// Methods
		public static StringWriter CreateStringWriter(int capacity) => default; // 0x0000000185E67F00-0x0000000185E67FE0
		public static int? GetLength(string value) => default; // 0x0000000185E68720-0x0000000185E687B0
		public static void ToCharAsUnicode(char c, char[] buffer) {} // 0x0000000185E68C10-0x0000000185E68E80
		public static string ToCamelCase(string s) => default; // 0x0000000185E68970-0x0000000185E68C10
		public static bool IsHighSurrogate(char c) => default; // 0x0000000185E687B0-0x0000000185E68840
		public static bool IsLowSurrogate(char c) => default; // 0x0000000185E68840-0x0000000185E688D0
	
		// Extension methods
		public static string FormatWith(this string format, IFormatProvider provider, object arg0) => default; // 0x0000000185E684D0-0x0000000185E685D0
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1) => default; // 0x0000000185E685D0-0x0000000185E68720
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2) => default; // 0x0000000185E68150-0x0000000185E682F0
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) => default; // 0x0000000185E682F0-0x0000000185E684D0
		private static string FormatWith(this string format, IFormatProvider provider, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) => default; // 0x0000000185E68090-0x0000000185E68150
		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue) => default;
		public static bool StartsWith(this string source, char value) => default; // 0x0000000185E688D0-0x0000000185E68970
		public static bool EndsWith(this string source, char value) => default; // 0x0000000185E67FE0-0x0000000185E68090
	}
}
