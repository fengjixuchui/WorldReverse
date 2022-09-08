/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ZXing;
using ZXing.Aztec.Internal;
using ZXing.Common;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.Aztec
{
	public sealed class AztecWriter : Writer // TypeDefIndex: 4648
	{
		// Fields
		private static readonly Encoding DEFAULT_CHARSET; // 0x00
	
		// Constructors
		static AztecWriter() {} // 0x0000000186ADA2B0-0x0000000186ADA340
		public AztecWriter() {} // 0x0000000186ADA340-0x0000000186ADA3A0
	
		// Methods
		public BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints) => default; // 0x0000000186ADA3A0-0x0000000186ADA620
		private static BitMatrix encode(string contents, BarcodeFormat format, int width, int height, Encoding charset, int eccPercent, int layers) => default; // 0x0000000186ADA620-0x0000000186ADA7D0
		private static BitMatrix renderResult(AztecCode code, int width, int height) => default; // 0x0000000186ADA7D0-0x0000000186ADAA70
	}
}
