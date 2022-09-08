/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.Datamatrix.Encoder
{
	public static class ErrorCorrection // TypeDefIndex: 4660
	{
		// Fields
		private static readonly int[] FACTOR_SETS; // 0x00
		private static readonly int[][] FACTORS; // 0x08
		private static readonly int[] LOG; // 0x10
		private static readonly int[] ALOG; // 0x18
	
		// Constructors
		static ErrorCorrection() {} // 0x0000000186AF44B0-0x0000000186AF4E00
	
		// Methods
		public static string encodeECC200(string codewords, SymbolInfo symbolInfo) => default; // 0x0000000186AF55E0-0x0000000186AF5B10
		private static string createECCBlock(string codewords, int numECWords) => default; // 0x0000000186AF4E00-0x0000000186AF4ED0
		private static string createECCBlock(string codewords, int start, int len, int numECWords) => default; // 0x0000000186AF4ED0-0x0000000186AF55E0
	}
}
