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

namespace ZXing.OneD
{
	public sealed class ITFWriter : OneDimensionalCodeWriter // TypeDefIndex: 4591
	{
		// Fields
		private static readonly int[] START_PATTERN; // 0x00
		private static readonly int[] END_PATTERN; // 0x08
	
		// Constructors
		public ITFWriter() {} // 0x0000000186AFCA50-0x0000000186AFCAB0
		static ITFWriter() {} // 0x0000000186AFC970-0x0000000186AFCA50
	
		// Methods
		public override BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints) => default; // 0x0000000186AFCAB0-0x0000000186AFCC00
		public override bool[] encode(string contents) => default; // 0x0000000186AFCC00-0x0000000186AFD190
	}
}
