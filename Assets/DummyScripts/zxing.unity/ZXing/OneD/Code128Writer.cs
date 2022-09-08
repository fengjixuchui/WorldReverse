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
	public sealed class Code128Writer : OneDimensionalCodeWriter // TypeDefIndex: 4654
	{
		// Fields
		private bool forceCodesetB; // 0x10
	
		// Nested types
		private enum CType // TypeDefIndex: 4655
		{
			UNCODABLE = 0,
			ONE_DIGIT = 1,
			TWO_DIGITS = 2,
			FNC_1 = 3
		}
	
		// Constructors
		public Code128Writer() {} // 0x0000000186AE9B90-0x0000000186AE9BF0
	
		// Methods
		public override BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints) => default; // 0x0000000186AE9D30-0x0000000186AE9F40
		public override bool[] encode(string contents) => default; // 0x0000000186AE9F40-0x0000000186AEA5D0
		private static CType findCType(string value, int start) => default; // 0x0000000186AEA5D0-0x0000000186AEA6B0
		private int chooseCode(string value, int start, int oldCode) => default; // 0x0000000186AE9BF0-0x0000000186AE9D30
	}
}
