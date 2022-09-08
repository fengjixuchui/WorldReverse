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
	public sealed class PlesseyWriter : OneDimensionalCodeWriter // TypeDefIndex: 4601
	{
		// Fields
		private static readonly int[] startWidths; // 0x00
		private static readonly int[] terminationWidths; // 0x08
		private static readonly int[] endWidths; // 0x10
		private static readonly int[][] numberWidths; // 0x18
		private static readonly byte[] crcGrid; // 0x20
		private static readonly int[] crc0Widths; // 0x28
		private static readonly int[] crc1Widths; // 0x30
	
		// Constructors
		public PlesseyWriter() {} // 0x0000000188DB4F90-0x0000000188DB5030
		static PlesseyWriter() {} // 0x0000000188DB4560-0x0000000188DB4F90
	
		// Methods
		public override BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints) => default; // 0x0000000188DB5600-0x0000000188DB5750
		public override bool[] encode(string contents) => default; // 0x0000000188DB5030-0x0000000188DB5600
	}
}
