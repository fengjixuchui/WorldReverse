/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

// [DebuggerDisplay] // 0x0000000189912460-0x0000000189912490
public struct SafeInt32 : IComparable, IComparable<SafeInt32>, IEquatable<SafeInt32> // TypeDefIndex: 31825
{
	// Fields
	private long _data1; // 0x00
	private long _data2; // 0x08
	private static Random _random; // 0x00
	private static byte[,] _map; // 0x08

	// Properties
	public int Value { /* [XID] */ /* 0x00000001899D8520-0x00000001899D8540 */ get => default; /* [XID] */ /* 0x00000001899DFB90-0x00000001899DFBB0 */ set {} } // 0x0000000183785E30-0x0000000183786170 0x0000000183786310-0x0000000183786320

	// Constructors
	public SafeInt32(int value) : this() {
		_data1 = default;
		_data2 = default;
	} // 0x0000000183786A60-0x0000000183786A70
	static SafeInt32() {
		_random = default;
		_map = default;
	} // 0x00000001837866E0-0x0000000183786A60

	// Methods
	// [XID] // 0x00000001899E7620-0x00000001899E7640
	private int Get() => default; // 0x0000000183785CC0-0x0000000183785D70
	// [XID] // 0x00000001899EEBD0-0x00000001899EEBF0
	private void Set(int value) {} // 0x0000000183786170-0x0000000183786250
	// [XID] // 0x00000001899F6410-0x00000001899F6430
	private byte GetByte(int index) => default; // 0x0000000183786250-0x0000000183786310
	// [XID] // 0x00000001899FD990-0x00000001899FD9B0
	private void SetByte(int index, byte value) {} // 0x0000000183786600-0x00000001837866D0
	// [XID] // 0x0000000189A05410-0x0000000189A05430
	public override string ToString() => default; // 0x00000001837866D0-0x00000001837866E0
	// [XID] // 0x0000000189A0C730-0x0000000189A0C750
	public override int GetHashCode() => default; // 0x0000000183785750-0x0000000183785760
	// [IDTag] // 0x0000000189A140A0-0x0000000189A140E0
	// [XID] // 0x0000000189A140A0-0x0000000189A140E0
	public override bool Equals(object obj) => default; // 0x0000000183785590-0x0000000183785670
	// [IDTag] // 0x0000000189A1E120-0x0000000189A1E160
	// [XID] // 0x0000000189A1E120-0x0000000189A1E160
	public int CompareTo(object obj) => default; // 0x00000001837852B0-0x00000001837853B0
	// [IDTag] // 0x0000000189A28660-0x0000000189A286A0
	// [XID] // 0x0000000189A28660-0x0000000189A286A0
	public int CompareTo(SafeInt32 other) => default; // 0x00000001837853B0-0x0000000183785460
	// [IDTag] // 0x0000000189A32B90-0x0000000189A32BD0
	// [XID] // 0x0000000189A32B90-0x0000000189A32BD0
	public bool Equals(SafeInt32 other) => default; // 0x0000000183785670-0x0000000183785750
	// [IDTag] // 0x0000000189A3D4E0-0x0000000189A3D520
	// [XID] // 0x0000000189A3D4E0-0x0000000189A3D520
	public static implicit operator SafeInt32(int v) => default; // 0x0000000183784CA0-0x0000000183784F00
	// [IDTag] // 0x0000000189A47CB0-0x0000000189A47CF0
	// [XID] // 0x0000000189A47CB0-0x0000000189A47CF0
	public static implicit operator int(SafeInt32 v) => default; // 0x0000000183784BF0-0x0000000183784CA0
	// [IDTag] // 0x0000000189A521E0-0x0000000189A52220
	// [XID] // 0x0000000189A521E0-0x0000000189A52220
	public static explicit operator uint(SafeInt32 v) => default; // 0x0000000183784FD0-0x0000000183785080
	// [IDTag] // 0x0000000189A5CD50-0x0000000189A5CD90
	// [XID] // 0x0000000189A5CD50-0x0000000189A5CD90
	public static explicit operator float(SafeInt32 v) => default; // 0x0000000183785080-0x00000001837852B0
	// [IDTag] // 0x0000000189A67940-0x0000000189A67980
	// [XID] // 0x0000000189A67940-0x0000000189A67980
	public static explicit operator double(SafeInt32 v) => default; // 0x0000000183784F10-0x0000000183784FD0
	// [XID] // 0x0000000189A71E60-0x0000000189A71E80
	public static SafeInt32 operator ++(SafeInt32 a) => default; // 0x0000000183786320-0x0000000183786600
	// [XID] // 0x0000000189A79AE0-0x0000000189A79B00
	public static SafeInt32 operator --(SafeInt32 a) => default; // 0x0000000183785760-0x0000000183785CC0
}

