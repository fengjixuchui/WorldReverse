/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ZXing.Common;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing
{
	public sealed class MultiFormatWriter : Writer // TypeDefIndex: 4571
	{
		// Fields
		private static readonly IDictionary<BarcodeFormat, Func<Writer>> formatMap; // 0x00
	
		// Constructors
		static MultiFormatWriter() {} // 0x0000000186AFE6F0-0x0000000186AFEE90
		public MultiFormatWriter() {} // 0x0000000186AFEE90-0x0000000186AFEEF0
	
		// Methods
		public BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints) => default; // 0x0000000186AFEEF0-0x0000000186AFF100
	}
}
