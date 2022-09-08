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
using ZXing.Datamatrix.Encoder;
using ZXing.QrCode.Internal;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.Datamatrix
{
	public sealed class DataMatrixWriter : Writer // TypeDefIndex: 4663
	{
		// Constructors
		public DataMatrixWriter() {} // 0x0000000186AEC2C0-0x0000000186AEC320
	
		// Methods
		public BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints) => default; // 0x0000000186AEC790-0x0000000186AECF40
		private static BitMatrix encodeLowLevel(DefaultPlacement placement, SymbolInfo symbolInfo) => default; // 0x0000000186AEC460-0x0000000186AEC790
		private static BitMatrix convertByteMatrixToBitMatrix(ByteMatrix matrix) => default; // 0x0000000186AEC320-0x0000000186AEC460
	}
}
