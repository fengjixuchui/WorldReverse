/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.OneD
{
	public sealed class CodaBarWriter : OneDimensionalCodeWriter // TypeDefIndex: 4586
	{
		// Fields
		private static readonly char[] START_END_CHARS; // 0x00
		private static readonly char[] ALT_START_END_CHARS; // 0x08
		private static readonly char[] CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED; // 0x10
		private static readonly char DEFAULT_GUARD; // 0x18
	
		// Constructors
		public CodaBarWriter() {} // 0x0000000186AE5EE0-0x0000000186AE5F40
		static CodaBarWriter() {} // 0x0000000186AE5D80-0x0000000186AE5EE0
	
		// Methods
		public override bool[] encode(string contents) => default; // 0x0000000186AE5F40-0x0000000186AE67F0
	}
}
