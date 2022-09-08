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
	public sealed class MSIWriter : OneDimensionalCodeWriter // TypeDefIndex: 4621
	{
		// Fields
		private static readonly int[] startWidths; // 0x00
		private static readonly int[] endWidths; // 0x08
		private static readonly int[][] numberWidths; // 0x10
	
		// Constructors
		public MSIWriter() {} // 0x0000000186AFD8C0-0x0000000186AFD920
		static MSIWriter() {} // 0x0000000186AFD2C0-0x0000000186AFD8C0
	
		// Methods
		public override BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints) => default; // 0x0000000186AFD920-0x0000000186AFDA70
		public override bool[] encode(string contents) => default; // 0x0000000186AFDA70-0x0000000186AFDDE0
	}
}
