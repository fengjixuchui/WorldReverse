/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ZXing;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.Datamatrix.Encoder
{
	internal static class HighLevelEncoder // TypeDefIndex: 4572
	{
		// Methods
		private static char randomize253State(char ch, int codewordPosition) => default; // 0x0000000186AFB2B0-0x0000000186AFB350
		public static string encodeHighLevel(string msg, SymbolShapeHint shape, Dimension minSize, Dimension maxSize, int defaultEncodation) => default; // 0x0000000186AF9040-0x0000000186AF9A90
		internal static int lookAheadTest(string msg, int startpos, int currentMode) => default; // 0x0000000186AFA560-0x0000000186AFB2B0
		private static int findMinimums(float[] charCounts, int[] intCharCounts, int min, byte[] mins) => default; // 0x0000000186AF9E70-0x0000000186AF9FE0
		private static int getMinimumCount(byte[] mins) => default; // 0x0000000186AF9FE0-0x0000000186AFA080
		internal static bool isDigit(char ch) => default; // 0x0000000186AFA170-0x0000000186AFA1E0
		internal static bool isExtendedASCII(char ch) => default; // 0x0000000186AFA1E0-0x0000000186AFA250
		internal static bool isNativeC40(char ch) => default; // 0x0000000186AFA250-0x0000000186AFA2D0
		internal static bool isNativeText(char ch) => default; // 0x0000000186AFA340-0x0000000186AFA3C0
		internal static bool isNativeX12(char ch) => default; // 0x0000000186AFA3C0-0x0000000186AFA4A0
		internal static bool isX12TermSep(char ch) => default; // 0x0000000186AFA4F0-0x0000000186AFA560
		internal static bool isNativeEDIFACT(char ch) => default; // 0x0000000186AFA2D0-0x0000000186AFA340
		internal static bool isSpecialB256(char ch) => default; // 0x0000000186AFA4A0-0x0000000186AFA4F0
		public static int determineConsecutiveDigitCount(string msg, int startpos) => default; // 0x0000000186AF8F20-0x0000000186AF9040
		internal static void illegalCharacter(char c) {} // 0x0000000186AFA080-0x0000000186AFA170
	}
}
