/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ZXing;
using ZXing.Common;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.QrCode.Internal
{
	public static class Encoder // TypeDefIndex: 4638
	{
		// Fields
		private static readonly int[] ALPHANUMERIC_TABLE; // 0x00
		internal static string DEFAULT_BYTE_MODE_ENCODING; // 0x08
	
		// Constructors
		static Encoder() {} // 0x0000000188DA51B0-0x0000000188DA5260
	
		// Methods
		private static int calculateMaskPenalty(ByteMatrix matrix) => default; // 0x0000000188DA60C0-0x0000000188DA6170
		public static QRCode encode(string content, ErrorCorrectionLevel ecLevel, IDictionary<EncodeHintType, object> hints) => default; // 0x0000000188DA6620-0x0000000188DA6F60
		private static Version recommendVersion(ErrorCorrectionLevel ecLevel, Mode mode, BitArray headerBits, BitArray dataBits) => default; // 0x0000000188DA7DC0-0x0000000188DA7EE0
		private static int calculateBitsNeeded(Mode mode, BitArray headerBits, BitArray dataBits, Version version) => default; // 0x0000000188DA5FF0-0x0000000188DA60C0
		internal static int getAlphanumericCode(int code) => default; // 0x0000000188DA7160-0x0000000188DA7250
		private static Mode chooseMode(string content, string encoding) => default; // 0x0000000188DA62C0-0x0000000188DA64F0
		private static bool isOnlyDoubleByteKanji(string content) => default; // 0x0000000188DA7C90-0x0000000188DA7DC0
		private static int chooseMaskPattern(BitArray bits, ErrorCorrectionLevel ecLevel, Version version, ByteMatrix matrix) => default; // 0x0000000188DA6170-0x0000000188DA62C0
		private static Version chooseVersion(int numInputBits, ErrorCorrectionLevel ecLevel) => default; // 0x0000000188DA64F0-0x0000000188DA6620
		private static bool willFit(int numInputBits, Version version, ErrorCorrectionLevel ecLevel) => default; // 0x0000000188DA8290-0x0000000188DA83E0
		internal static void terminateBits(int numDataBytes, BitArray bits) {} // 0x0000000188DA7EE0-0x0000000188DA8290
		internal static void getNumDataBytesAndNumECBytesForBlockID(int numTotalBytes, int numDataBytes, int numRSBlocks, int blockID, int[] numDataBytesInBlock, int[] numECBytesInBlock) {} // 0x0000000188DA7250-0x0000000188DA7470
		internal static BitArray interleaveWithECBytes(BitArray bits, int numTotalBytes, int numDataBytes, int numRSBlocks) => default; // 0x0000000188DA7470-0x0000000188DA7C90
		internal static byte[] generateECBytes(byte[] dataBytes, int numEcBytesInBlock) => default; // 0x0000000188DA6F60-0x0000000188DA7160
		internal static void appendModeInfo(Mode mode, BitArray bits) {} // 0x0000000188DA5D90-0x0000000188DA5E60
		internal static void appendLengthInfo(int numLetters, Version version, Mode mode, BitArray bits) {} // 0x0000000188DA5C30-0x0000000188DA5D90
		internal static void appendBytes(string content, Mode mode, BitArray bits, string encoding) {} // 0x0000000188DA55B0-0x0000000188DA58B0
		internal static void appendNumericBytes(string content, BitArray bits) {} // 0x0000000188DA5E60-0x0000000188DA5FF0
		internal static void appendAlphanumericBytes(string content, BitArray bits) {} // 0x0000000188DA53D0-0x0000000188DA55B0
		internal static void append8BitBytes(string content, BitArray bits, string encoding) {} // 0x0000000188DA5260-0x0000000188DA53D0
		internal static void appendKanjiBytes(string content, BitArray bits) {} // 0x0000000188DA59F0-0x0000000188DA5C30
		private static void appendECI(CharacterSetECI eci, BitArray bits) {} // 0x0000000188DA58B0-0x0000000188DA59F0
	}
}
