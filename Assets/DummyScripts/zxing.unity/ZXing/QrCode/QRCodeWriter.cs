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
using ZXing.QrCode.Internal;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.QrCode
{
	public sealed class QRCodeWriter : Writer // TypeDefIndex: 4627
	{
		// Constructors
		public QRCodeWriter() {} // 0x0000000188DB5750-0x0000000188DB57B0
	
		// Methods
		public BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints) => default; // 0x0000000188DB57B0-0x0000000188DB5E90
		private static BitMatrix renderResult(QRCode code, int width, int height, int quietZone) => default; // 0x0000000188DB5E90-0x0000000188DB6150
	}
}
