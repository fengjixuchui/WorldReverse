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
	internal sealed class State // TypeDefIndex: 4611
	{
		// Fields
		public static readonly State INITIAL_STATE; // 0x00
		private readonly int mode; // 0x10
		private readonly Token token; // 0x18
		private readonly int binaryShiftByteCount; // 0x20
		private readonly int bitCount; // 0x24
	
		// Properties
		public int Mode { get => default; } // 0x0000000186B00120-0x0000000186B00180 
		public int BinaryShiftByteCount { get => default; } // 0x0000000186B00060-0x0000000186B000C0 
		public int BitCount { get => default; } // 0x0000000186B000C0-0x0000000186B00120 
	
		// Constructors
		public State() {} // Dummy constructor
		public State(Token token, int mode, int binaryBytes, int bitCount) {} // 0x0000000186AFFD30-0x0000000186AFFDC0
		static State() {} // 0x0000000186AFFC20-0x0000000186AFFD30
	
		// Methods
		public State latchAndAppend(int mode, int value) => default; // 0x0000000186B002B0-0x0000000186B00480
		public State shiftAndAppend(int mode, int value) => default; // 0x0000000186B00480-0x0000000186B00650
		public State addBinaryShiftChar(int index) => default; // 0x0000000186AFFDC0-0x0000000186AFFF90
		public State endBinaryShift(int index) => default; // 0x0000000186AFFF90-0x0000000186B00060
		public bool isBetterThanOrEqualTo(State other) => default; // 0x0000000186B00180-0x0000000186B002B0
		public BitArray toBitArray(byte[] text) => default; // 0x0000000186B00650-0x0000000186B00900
		public override string ToString() => default; // 0x0000000186AFFAE0-0x0000000186AFFC20
	}
}
