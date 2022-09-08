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
	internal sealed class PDF417 // TypeDefIndex: 4641
	{
		// Fields
		private static readonly int[][] CODEWORD_TABLE; // 0x00
		private BarcodeMatrix barcodeMatrix; // 0x10
		private bool compact; // 0x18
		private Compaction compaction; // 0x1C
		private Encoding encoding; // 0x20
		private bool disableEci; // 0x28
		private int minCols; // 0x2C
		private int maxCols; // 0x30
		private int maxRows; // 0x34
		private int minRows; // 0x38
	
		// Properties
		internal BarcodeMatrix BarcodeMatrix { get => default; } // 0x0000000188DB42B0-0x0000000188DB4310 
	
		// Constructors
		internal PDF417() {} // 0x0000000188DB34A0-0x0000000188DB3510
		internal PDF417(bool compact) {} // 0x0000000188DB3400-0x0000000188DB34A0
		static PDF417() {} // 0x0000000188DB3200-0x0000000188DB3400
	
		// Methods
		private static int calculateNumberOfRows(int m, int k, int c) => default; // 0x0000000188DB3510-0x0000000188DB35A0
		private static int getNumberOfPadCodewords(int m, int k, int c, int r) => default; // 0x0000000188DB4230-0x0000000188DB42B0
		private static void encodeChar(int pattern, int len, BarcodeRow logic) {} // 0x0000000188DB3880-0x0000000188DB3980
		private void encodeLowLevel(string fullCodewords, int c, int r, int errorCorrectionLevel, BarcodeMatrix logic) {} // 0x0000000188DB3980-0x0000000188DB3E50
		internal void generateBarcodeLogic(string msg, int errorCorrectionLevel) {} // 0x0000000188DB3E50-0x0000000188DB4230
		private int[] determineDimensions(int sourceCodeWords, int errorCorrectionCodeWords) => default; // 0x0000000188DB35A0-0x0000000188DB3880
		internal void setDimensions(int maxCols, int minCols, int maxRows, int minRows) {} // 0x0000000188DB43D0-0x0000000188DB4460
		internal void setCompaction(Compaction compaction) {} // 0x0000000188DB4370-0x0000000188DB43D0
		internal void setCompact(bool compact) {} // 0x0000000188DB4310-0x0000000188DB4370
		internal void setEncoding(string encodingname) {} // 0x0000000188DB44C0-0x0000000188DB4560
		internal void setDisableEci(bool disabled) {} // 0x0000000188DB4460-0x0000000188DB44C0
	}
}
