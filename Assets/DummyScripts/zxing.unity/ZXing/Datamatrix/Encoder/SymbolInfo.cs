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
	public class SymbolInfo // TypeDefIndex: 4634
	{
		// Fields
		internal static readonly SymbolInfo[] PROD_SYMBOLS; // 0x00
		private static SymbolInfo[] symbols; // 0x08
		private readonly bool rectangular; // 0x10
		internal readonly int dataCapacity; // 0x14
		internal readonly int errorCodewords; // 0x18
		public readonly int matrixWidth; // 0x1C
		public readonly int matrixHeight; // 0x20
		private readonly int dataRegions; // 0x24
		private readonly int rsBlockData; // 0x28
		private readonly int rsBlockError; // 0x2C
	
		// Constructors
		public SymbolInfo() {} // Dummy constructor
		public SymbolInfo(bool rectangular, int dataCapacity, int errorCodewords, int matrixWidth, int matrixHeight, int dataRegions) {} // 0x0000000186B02480-0x0000000186B02540
		internal SymbolInfo(bool rectangular, int dataCapacity, int errorCodewords, int matrixWidth, int matrixHeight, int dataRegions, int rsBlockData, int rsBlockError) {} // 0x0000000186B02540-0x0000000186B02600
		static SymbolInfo() {} // 0x0000000186B00C30-0x0000000186B02480
	
		// Methods
		public static SymbolInfo lookup(int dataCodewords, SymbolShapeHint shape, Dimension minSize, Dimension maxSize, bool fail) => default; // 0x0000000186B02B40-0x0000000186B02DD0
		private int getHorizontalDataRegions() => default; // 0x0000000186B026C0-0x0000000186B027A0
		private int getVerticalDataRegions() => default; // 0x0000000186B02A60-0x0000000186B02B40
		public int getSymbolDataWidth() => default; // 0x0000000186B02870-0x0000000186B028E0
		public int getSymbolDataHeight() => default; // 0x0000000186B02800-0x0000000186B02870
		public int getSymbolWidth() => default; // 0x0000000186B029A0-0x0000000186B02A60
		public int getSymbolHeight() => default; // 0x0000000186B028E0-0x0000000186B029A0
		public virtual int getInterleavedBlockCount() => default; // 0x0000000186B027A0-0x0000000186B02800
		public virtual int getDataLengthForInterleavedBlock(int index) => default; // 0x0000000186B02600-0x0000000186B02660
		public int getErrorLengthForInterleavedBlock(int index) => default; // 0x0000000186B02660-0x0000000186B026C0
		public override string ToString() => default; // 0x0000000186B00900-0x0000000186B00C30
	}
}
