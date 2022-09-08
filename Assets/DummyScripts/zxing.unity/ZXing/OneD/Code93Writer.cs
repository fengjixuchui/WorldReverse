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
	public class Code93Writer : OneDimensionalCodeWriter // TypeDefIndex: 4584
	{
		// Constructors
		public Code93Writer() {} // 0x0000000186AEB160-0x0000000186AEB1C0
	
		// Methods
		public override BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints) => default; // 0x0000000186AEB870-0x0000000186AEB9B0
		public override bool[] encode(string contents) => default; // 0x0000000186AEB3B0-0x0000000186AEB870
		private static void toIntArray(int a, int[] toReturn) {} // 0x0000000186AEB9B0-0x0000000186AEBA70
		private static int appendPattern(bool[] target, int pos, int[] pattern) => default; // 0x0000000186AEB1C0-0x0000000186AEB2A0
		private static int computeChecksumIndex(string contents, int maxWeight) => default; // 0x0000000186AEB2A0-0x0000000186AEB3B0
	}
}
