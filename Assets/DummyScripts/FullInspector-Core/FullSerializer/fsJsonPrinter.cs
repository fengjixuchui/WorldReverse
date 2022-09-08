/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer
{
	public static class fsJsonPrinter // TypeDefIndex: 4726
	{
		// Methods
		private static void InsertSpacing(TextWriter stream, int count) {} // 0x0000000185D0F690-0x0000000185D0F740
		private static string EscapeString(string str) => default; // 0x0000000185D0F2D0-0x0000000185D0F690
		private static void BuildCompressedString(fsData data, TextWriter stream) {} // 0x0000000185D0E2D0-0x0000000185D0E890
		private static void BuildPrettyString(fsData data, TextWriter stream, int depth) {} // 0x0000000185D0E890-0x0000000185D0EFB0
		public static void PrettyJson(fsData data, TextWriter outputStream) {} // 0x0000000185D0F890-0x0000000185D0F910
		public static string PrettyJson(fsData data) => default; // 0x0000000185D0F740-0x0000000185D0F890
		public static void CompressedJson(fsData data, StreamWriter outputStream) {} // 0x0000000185D0EFB0-0x0000000185D0F030
		public static string CompressedJson(fsData data) => default; // 0x0000000185D0F030-0x0000000185D0F170
		private static string ConvertDoubleToString(double d) => default; // 0x0000000185D0F170-0x0000000185D0F2D0
	}
}
