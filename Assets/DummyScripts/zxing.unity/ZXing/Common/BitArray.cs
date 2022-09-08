/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.Common
{
	public sealed class BitArray // TypeDefIndex: 4589
	{
		// Fields
		private int[] bits; // 0x10
		private int size; // 0x18
		private static readonly int[] _lookup; // 0x00
	
		// Properties
		public int Size { get => default; } // 0x0000000186AE1AA0-0x0000000186AE1B00 
		public int SizeInBytes { get => default; } // 0x0000000186AE1A40-0x0000000186AE1AA0 
		public bool this[int i] { get => default; } // 0x0000000186AE1990-0x0000000186AE1A40 
		public int[] Array { get => default; } // 0x0000000186AE1930-0x0000000186AE1990 
	
		// Constructors
		public BitArray() {} // 0x0000000186AE14C0-0x0000000186AE1550
		public BitArray(int size) {} // 0x0000000186AE13E0-0x0000000186AE14C0
		static BitArray() {} // 0x0000000186AE1340-0x0000000186AE13E0
	
		// Methods
		private void ensureCapacity(int size) {} // 0x0000000186AE1850-0x0000000186AE1930
		public void setBulk(int i, int newBits) {} // 0x0000000186AE1B90-0x0000000186AE1C30
		public void clear() {} // 0x0000000186AE17A0-0x0000000186AE1850
		public void appendBit(bool bit) {} // 0x0000000186AE1600-0x0000000186AE16C0
		public void appendBits(int value, int numBits) {} // 0x0000000186AE16C0-0x0000000186AE17A0
		public void appendBitArray(BitArray other) {} // 0x0000000186AE1550-0x0000000186AE1600
		public void xor(BitArray other) {} // 0x0000000186AE1D40-0x0000000186AE1E80
		public void toBytes(int bitOffset, byte[] array, int offset, int numBytes) {} // 0x0000000186AE1C30-0x0000000186AE1D40
		private static int[] makeArray(int size) => default; // 0x0000000186AE1B00-0x0000000186AE1B90
		public override bool Equals(object o) => default; // 0x0000000186AE1040-0x0000000186AE1160
		public override int GetHashCode() => default; // 0x0000000186AE1160-0x0000000186AE1220
		public override string ToString() => default; // 0x0000000186AE1220-0x0000000186AE1340
	}
}
