/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BitSet : ICloneable, IEnumerable<bool>, IEnumerable<int> // TypeDefIndex: 11051
{
	// Fields
	private const int BitsPerInt32 = 32; // Metadata: 0x00AE8B3C
	private int[] m_array; // 0x10
	private int m_length; // 0x18
	private int _version; // 0x1C

	// Properties
	public int Length { /* [XID] */ /* 0x0000000189ACED10-0x0000000189ACED30 */ get => default; } // 0x0000000181AF5F90-0x0000000181AF6030 
	public bool this[int index] { /* [XID] */ /* 0x0000000189888290-0x00000001898882B0 */ get => default; /* [XID] */ /* 0x0000000189AE5F40-0x0000000189AE5F60 */ set {} } // 0x0000000181AF6140-0x0000000181AF6200 0x0000000181AF5D10-0x0000000181AF5DE0

	// Nested types
	private struct BitSetEnumeratorAllBits : IEnumerator<bool> // TypeDefIndex: 11052
	{
		// Fields
		private readonly BitSet bitSet; // 0x00
		private int index; // 0x08
		private int version; // 0x0C
		private bool currentElement; // 0x10

		// Properties
		object IEnumerator.Current { /* [XID] */ /* 0x0000000189B64B10-0x0000000189B64B30 */ get => default; } // 0x0000000181AF0A90-0x0000000181AF0B30 
		public bool Current { /* [XID] */ /* 0x0000000189B5D430-0x0000000189B5D450 */ get => default; } // 0x0000000181AF0C70-0x0000000181AF0CA0 

		// Constructors
		public BitSetEnumeratorAllBits(BitSet bitSet) : this() {
			this.bitSet = default;
			index = default;
			version = default;
			currentElement = default;
		} // 0x0000000181AF0B30-0x0000000181AF0C70

		// Methods
		// [XID] // 0x0000000189986C60-0x0000000189986C80
		public bool MoveNext() => default; // 0x0000000181AF0910-0x0000000181AF09C0
		// [XID] // 0x0000000189B73830-0x0000000189B73850
		public void Reset() {} // 0x0000000181AF09C0-0x0000000181AF0A90
		// [XID] // 0x000000018993C290-0x000000018993C2B0
		public void Dispose() {} // 0x0000000181AF07B0-0x0000000181AF0910
	}

	private struct BitSetEnumeratortTrueIndex : IEnumerator<int> // TypeDefIndex: 11053
	{
		// Fields
		private static readonly int[] _lookup; // 0x00
		private readonly BitSet bitSet; // 0x00
		private int version; // 0x08
		private int currentElement; // 0x0C
		private int currentArrayIndex; // 0x10
		private int currentIntValue; // 0x14
		private int currentBase; // 0x18

		// Properties
		object IEnumerator.Current { /* [XID] */ /* 0x0000000189959CB0-0x0000000189959CD0 */ get => default; } // 0x0000000181B12320-0x0000000181B12330 
		public int Current { /* [XID] */ /* 0x0000000189B82610-0x0000000189B82630 */ get => default; } // 0x0000000181B125B0-0x0000000181B126B0 

		// Constructors
		public BitSetEnumeratortTrueIndex(BitSet bitSet) : this() {
			this.bitSet = default;
			version = default;
			currentElement = default;
			currentArrayIndex = default;
			currentIntValue = default;
			currentBase = default;
		} // 0x0000000181B12470-0x0000000181B125B0
		static BitSetEnumeratortTrueIndex() {
			_lookup = default;
		} // 0x0000000181B12330-0x0000000181B12470

		// Methods
		// [XID] // 0x0000000189968C30-0x0000000189968C50
		public void Dispose() {} // 0x0000000181B11FA0-0x0000000181B12190
		// [XID] // 0x0000000189B98610-0x0000000189B98630
		public bool MoveNext() => default; // 0x0000000181B12190-0x0000000181B12250
		// [XID] // 0x0000000189B9FBA0-0x0000000189B9FBC0
		public void Reset() {} // 0x0000000181B12250-0x0000000181B12320
	}

	// Constructors
	public BitSet() {} // Dummy constructor
	public BitSet(int length) {} // 0x0000000181AF6D50-0x0000000181AF6DD0
	public BitSet(int length, bool defaultValue) {} // 0x0000000181AF67A0-0x0000000181AF6900
	public BitSet(string val) {} // 0x0000000181AF6DD0-0x0000000181AF6E60
	public BitSet(int length, string val) {} // 0x0000000181AF6BC0-0x0000000181AF6D50
	public BitSet(int[] values) {} // 0x0000000181AF6900-0x0000000181AF6A30
	public BitSet(int length, int[] values) {} // 0x0000000181AF6A30-0x0000000181AF6BC0

	// Methods
	// [XID] // 0x000000018986ACC0-0x000000018986ACE0
	public override string ToString() => default; // 0x0000000181AF6660-0x0000000181AF67A0
	// [XID] // 0x0000000189879920-0x0000000189879940
	public bool Get(int index) => default; // 0x0000000181AF5B50-0x0000000181AF5C90
	// [XID] // 0x0000000189AF4E20-0x0000000189AF4E40
	public void Set(int index, bool value) {} // 0x0000000181AF5DE0-0x0000000181AF5F90
	// [XID] // 0x0000000189896E10-0x0000000189896E30
	public void SetAll(bool value) {} // 0x0000000181AF4ED0-0x0000000181AF4FE0
	// [XID] // 0x00000001898A5CB0-0x00000001898A5CD0
	public BitSet And(BitSet value) => default; // 0x0000000181AF5310-0x0000000181AF54E0
	// [XID] // 0x0000000189B0B320-0x0000000189B0B340
	public BitSet Or(BitSet value) => default; // 0x0000000181AF6200-0x0000000181AF63D0
	// [XID] // 0x00000001897412B0-0x00000001897412D0
	public BitSet Xor(BitSet value) => default; // 0x0000000181AF5050-0x0000000181AF5220
	// [XID] // 0x0000000189B19F00-0x0000000189B19F20
	public BitSet Not() => default; // 0x0000000181AF6030-0x0000000181AF6140
	// [XID] // 0x0000000189B21430-0x0000000189B21450
	public object Clone() => default; // 0x0000000181AF5220-0x0000000181AF5310
	// [XID] // 0x00000001898F10E0-0x00000001898F1100
	public void CopyTo(BitSet value) {} // 0x0000000181AF5550-0x0000000181AF5690
	// [XID] // 0x0000000189B30150-0x0000000189B30170
	private static int GetArrayLength(int n, int div) => default; // 0x0000000181AF5A90-0x0000000181AF5B50
	// [XID] // 0x0000000189B37900-0x0000000189B37920
	IEnumerator<bool> IEnumerable<bool>.GetEnumerator() => default; // 0x0000000181AF63D0-0x0000000181AF6510
	// [XID] // 0x0000000189B3F250-0x0000000189B3F270
	IEnumerator<int> IEnumerable<int>.GetEnumerator() => default; // 0x0000000181AF6510-0x0000000181AF6660
	// [XID] // 0x00000001898E1E90-0x00000001898E1EB0
	public IEnumerator GetEnumerator() => default; // 0x0000000181AF5850-0x0000000181AF5990
	// [XID] // 0x00000001899A5650-0x00000001899A5670
	public override bool Equals(object obj) => default; // 0x0000000181AF5690-0x0000000181AF5850
	// [XID] // 0x00000001899B4760-0x00000001899B4780
	public override int GetHashCode() => default; // 0x0000000181AF5990-0x0000000181AF5A90
}

