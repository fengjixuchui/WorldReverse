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
	public abstract class OneDimensionalCodeWriter : Writer // TypeDefIndex: 4583
	{
		// Properties
		public virtual int DefaultMargin { get; } // 0x0000000188DAEE50-0x0000000188DAEEA0 
	
		// Constructors
		protected OneDimensionalCodeWriter() {} // 0x0000000188DAE920-0x0000000188DAE980
	
		// Methods
		public virtual BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints) => default; // 0x0000000188DAEA90-0x0000000188DAEE50
		private static BitMatrix renderResult(bool[] code, int width, int height, int sidesMargin) => default; // 0x0000000188DAEEA0-0x0000000188DAF000
		protected static int appendPattern(bool[] target, int pos, int[] pattern, bool startColor) => default; // 0x0000000188DAE980-0x0000000188DAEA90
		public abstract bool[] encode(string contents);
	}
}
