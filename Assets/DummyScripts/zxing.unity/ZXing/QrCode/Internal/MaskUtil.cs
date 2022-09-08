/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.QrCode.Internal
{
	public static class MaskUtil // TypeDefIndex: 4593
	{
		// Methods
		public static int applyMaskPenaltyRule1(ByteMatrix matrix) => default; // 0x0000000188DA8C70-0x0000000188DA8D00
		public static int applyMaskPenaltyRule2(ByteMatrix matrix) => default; // 0x0000000188DA8D00-0x0000000188DA8F70
		public static int applyMaskPenaltyRule3(ByteMatrix matrix) => default; // 0x0000000188DA8F70-0x0000000188DA9560
		private static bool isWhiteHorizontal(byte[] rowArray, int from, int to) => default; // 0x0000000188DA9990-0x0000000188DA9A70
		private static bool isWhiteVertical(byte[][] array, int col, int from, int to) => default; // 0x0000000188DA9A70-0x0000000188DA9B80
		public static int applyMaskPenaltyRule4(ByteMatrix matrix) => default; // 0x0000000188DA9560-0x0000000188DA97C0
		public static bool getDataMaskBit(int maskPattern, int x, int y) => default; // 0x0000000188DA97C0-0x0000000188DA9990
		private static int applyMaskPenaltyRule1Internal(ByteMatrix matrix, bool isHorizontal) => default; // 0x0000000188DA8970-0x0000000188DA8C70
	}
}
