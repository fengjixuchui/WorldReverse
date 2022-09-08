/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.PDF417.Internal
{
	internal static class PDF417HighLevelEncoder // TypeDefIndex: 4659
	{
		// Fields
		private static readonly sbyte[] TEXT_MIXED_RAW; // 0x00
		private static readonly sbyte[] TEXT_PUNCTUATION_RAW; // 0x08
		private static readonly sbyte[] MIXED; // 0x10
		private static readonly sbyte[] PUNCTUATION; // 0x18
		internal static string DEFAULT_ENCODING_NAME; // 0x20
	
		// Constructors
		static PDF417HighLevelEncoder() {} // 0x0000000188DAFA20-0x0000000188DAFD80
	
		// Methods
		internal static string encodeHighLevel(string msg, Compaction compaction, Encoding encoding, bool disableEci) => default; // 0x0000000188DB06C0-0x0000000188DB0D10
		private static Encoding getEncoder(Encoding encoding) => default; // 0x0000000188DB1B50-0x0000000188DB1D10
		private static byte[] toBytes(string msg, Encoding encoding) => default; // 0x0000000188DB2060-0x0000000188DB2120
		private static byte[] toBytes(char msg, Encoding encoding) => default; // 0x0000000188DB2120-0x0000000188DB2230
		private static int encodeText(string msg, int startpos, int count, StringBuilder sb, int initialSubmode) => default; // 0x0000000188DB0FE0-0x0000000188DB1980
		private static void encodeBinary(byte[] bytes, int startpos, int count, int startmode, StringBuilder sb) {} // 0x0000000188DB0420-0x0000000188DB06C0
		private static void encodeNumeric(string msg, int startpos, int count, StringBuilder sb) {} // 0x0000000188DB0D10-0x0000000188DB0FE0
		private static bool isDigit(char ch) => default; // 0x0000000188DB1DF0-0x0000000188DB1E60
		private static bool isAlphaUpper(char ch) => default; // 0x0000000188DB1D80-0x0000000188DB1DF0
		private static bool isAlphaLower(char ch) => default; // 0x0000000188DB1D10-0x0000000188DB1D80
		private static bool isMixed(char ch) => default; // 0x0000000188DB1E60-0x0000000188DB1F20
		private static bool isPunctuation(char ch) => default; // 0x0000000188DB1F20-0x0000000188DB1FE0
		private static bool isText(char ch) => default; // 0x0000000188DB1FE0-0x0000000188DB2060
		private static int determineConsecutiveDigitCount(string msg, int startpos) => default; // 0x0000000188DB0160-0x0000000188DB02A0
		private static int determineConsecutiveTextCount(string msg, int startpos) => default; // 0x0000000188DB02A0-0x0000000188DB0420
		private static int determineConsecutiveBinaryCount(string msg, byte[] bytes, int startpos, Encoding encoding) => default; // 0x0000000188DAFD80-0x0000000188DB0160
		private static void encodingECI(int eci, StringBuilder sb) {} // 0x0000000188DB1980-0x0000000188DB1B50
	}
}
