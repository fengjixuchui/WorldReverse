/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ZXing.Common;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.Aztec.Internal
{
	public sealed class BinaryShiftToken : Token // TypeDefIndex: 4661
	{
		// Fields
		private readonly short binaryShiftStart; // 0x18
		private readonly short binaryShiftByteCount; // 0x1A
	
		// Constructors
		public BinaryShiftToken() {} // Dummy constructor
		public BinaryShiftToken(Token previous, int binaryShiftStart, int binaryShiftByteCount) {} // 0x0000000186AE0CA0-0x0000000186AE0D80
	
		// Methods
		public override void appendTo(BitArray bitArray, byte[] text) {} // 0x0000000186AE0D80-0x0000000186AE1040
		public override string ToString() => default; // 0x0000000186AE0A00-0x0000000186AE0CA0
	}
}
