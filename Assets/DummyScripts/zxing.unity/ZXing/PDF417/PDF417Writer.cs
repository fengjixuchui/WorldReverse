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
using ZXing.PDF417.Internal;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.PDF417
{
	public sealed class PDF417Writer : Writer // TypeDefIndex: 4658
	{
		// Constructors
		public PDF417Writer() {} // 0x0000000188DB2230-0x0000000188DB2290
	
		// Methods
		public BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints) => default; // 0x0000000188DB2670-0x0000000188DB2F60
		private static BitMatrix bitMatrixFromEncoder(Internal.PDF417 encoder, string contents, int errorCorrectionLevel, int width, int height, int margin) => default; // 0x0000000188DB2430-0x0000000188DB2670
		private static BitMatrix bitMatrixFromBitArray(sbyte[][] input, int margin) => default; // 0x0000000188DB2290-0x0000000188DB2430
		private static sbyte[][] rotateArray(sbyte[][] bitarray) => default; // 0x0000000188DB2F60-0x0000000188DB3200
	}
}
