/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ZXing.Common;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.QrCode.Internal
{
	public static class MatrixUtil // TypeDefIndex: 4644
	{
		// Fields
		private static readonly int[][] POSITION_DETECTION_PATTERN; // 0x00
		private static readonly int[][] POSITION_ADJUSTMENT_PATTERN; // 0x08
		private static readonly int[][] POSITION_ADJUSTMENT_PATTERN_COORDINATE_TABLE; // 0x10
		private static readonly int[][] TYPE_INFO_COORDINATES; // 0x18
	
		// Constructors
		static MatrixUtil() {} // 0x0000000188DA9B80-0x0000000188DABF80
	
		// Methods
		public static void clearMatrix(ByteMatrix matrix) {} // 0x0000000188DAC2D0-0x0000000188DAC340
		public static void buildMatrix(BitArray dataBits, ErrorCorrectionLevel ecLevel, Version version, int maskPattern, ByteMatrix matrix) {} // 0x0000000188DABF80-0x0000000188DAC0E0
		public static void embedBasicPatterns(Version version, ByteMatrix matrix) {} // 0x0000000188DAC340-0x0000000188DAC400
		public static void embedTypeInfo(ErrorCorrectionLevel ecLevel, int maskPattern, ByteMatrix matrix) {} // 0x0000000188DAD2C0-0x0000000188DAD4E0
		public static void maybeEmbedVersionInfo(Version version, ByteMatrix matrix) {} // 0x0000000188DADDF0-0x0000000188DADFB0
		public static void embedDataBits(BitArray dataBits, int maskPattern, ByteMatrix matrix) {} // 0x0000000188DAC590-0x0000000188DACA00
		public static int findMSBSet(int value_Renamed) => default; // 0x0000000188DAD610-0x0000000188DAD680
		public static int calculateBCHCode(int value, int poly) => default; // 0x0000000188DAC0E0-0x0000000188DAC2D0
		public static void makeTypeInfoBits(ErrorCorrectionLevel ecLevel, int maskPattern, BitArray bits) {} // 0x0000000188DAD6E0-0x0000000188DAD950
		public static void makeVersionInfoBits(Version version, BitArray bits) {} // 0x0000000188DAD950-0x0000000188DADB40
		private static bool isEmpty(int value) => default; // 0x0000000188DAD680-0x0000000188DAD6E0
		private static void embedTimingPatterns(ByteMatrix matrix) {} // 0x0000000188DAD110-0x0000000188DAD2C0
		private static void embedDarkDotAtLeftBottomCorner(ByteMatrix matrix) {} // 0x0000000188DAC400-0x0000000188DAC590
		private static void embedHorizontalSeparationPattern(int xStart, int yStart, ByteMatrix matrix) {} // 0x0000000188DACA00-0x0000000188DACB30
		private static void embedVerticalSeparationPattern(int xStart, int yStart, ByteMatrix matrix) {} // 0x0000000188DAD4E0-0x0000000188DAD610
		private static void embedPositionAdjustmentPattern(int xStart, int yStart, ByteMatrix matrix) {} // 0x0000000188DACB30-0x0000000188DACC90
		private static void embedPositionDetectionPattern(int xStart, int yStart, ByteMatrix matrix) {} // 0x0000000188DACC90-0x0000000188DACDF0
		private static void embedPositionDetectionPatternsAndSeparators(ByteMatrix matrix) {} // 0x0000000188DACDF0-0x0000000188DAD110
		private static void maybeEmbedPositionAdjustmentPatterns(Version version, ByteMatrix matrix) {} // 0x0000000188DADB40-0x0000000188DADDF0
	}
}
