/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ZXing.Common;
using ZXing.Common.ReedSolomon;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.Aztec.Internal
{
	public static class Encoder // TypeDefIndex: 4598
	{
		// Fields
		private static readonly int[] WORD_SIZE; // 0x00
	
		// Constructors
		static Encoder() {} // 0x0000000186AF17A0-0x0000000186AF1840
	
		// Methods
		public static AztecCode encode(byte[] data, int minECCPercent, int userSpecifiedLayers) => default; // 0x0000000186AF2420-0x0000000186AF3390
		private static void drawBullsEye(BitMatrix matrix, int center, int size) {} // 0x0000000186AF19D0-0x0000000186AF1F30
		internal static BitArray generateModeMessage(bool compact, int layers, int messageSizeInWords) => default; // 0x0000000186AF35F0-0x0000000186AF38F0
		private static void drawModeMessage(BitMatrix matrix, bool compact, int matrixSize, BitArray modeMessage) {} // 0x0000000186AF1F30-0x0000000186AF2420
		private static BitArray generateCheckWords(BitArray bitArray, int totalBits, int wordSize) => default; // 0x0000000186AF3390-0x0000000186AF35F0
		private static int[] bitsToWords(BitArray stuffedBits, int wordSize, int totalWords) => default; // 0x0000000186AF1840-0x0000000186AF19D0
		private static GenericGF getGF(int wordSize) => default; // 0x0000000186AF38F0-0x0000000186AF3B40
		internal static BitArray stuffBits(BitArray bits, int wordSize) => default; // 0x0000000186AF3B40-0x0000000186AF3D20
		private static int TotalBitsInLayer(int layers, bool compact) => default; // 0x0000000186AF1710-0x0000000186AF17A0
	}
}
