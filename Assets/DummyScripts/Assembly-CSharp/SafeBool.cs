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
public struct SafeBool : IComparable, IComparable<SafeBool>, IEquatable<SafeBool> // TypeDefIndex: 31822
{
	// Fields
	private long _data1; // 0x00
	private long _data2; // 0x08
	private static Random _random; // 0x00
	private static byte[,] _map; // 0x08

	// Properties
	public bool Value { /* [XID] */ /* 0x000000018980D8F0-0x000000018980D910 */ get => default; /* [XID] */ /* 0x0000000189814FE0-0x0000000189815000 */ set {} } // 0x0000000180F84480-0x0000000180F84830 0x0000000180F849E0-0x0000000180F84AF0

	// Constructors
	public SafeBool(bool value) : this() {
		_data1 = default;
		_data2 = default;
	} // 0x0000000180F84F50-0x0000000180F84F60
	static SafeBool() {
		_random = default;
		_map = default;
	} // 0x0000000180F84BD0-0x0000000180F84F50

	// Methods
	// [XID] // 0x000000018981CAE0-0x000000018981CB00
	private bool Get() => default; // 0x0000000180F84310-0x0000000180F843C0
	// [XID] // 0x0000000189823F70-0x0000000189823F90
	private void Set(bool value) {} // 0x0000000180F84830-0x0000000180F84910
	// [XID] // 0x000000018982B9B0-0x000000018982B9D0
	private byte GetByte(int index) => default; // 0x0000000180F84910-0x0000000180F849E0
	// [XID] // 0x0000000189832F70-0x0000000189832F90
	private void SetByte(int index, byte value) {} // 0x0000000180F84AF0-0x0000000180F84BC0
	// [XID] // 0x000000018983A460-0x000000018983A480
	public override string ToString() => default; // 0x0000000180F84BC0-0x0000000180F84BD0
	// [XID] // 0x00000001898419B0-0x00000001898419D0
	public override int GetHashCode() => default; // 0x0000000180F83F70-0x0000000180F84310
	// [IDTag] // 0x0000000189848E50-0x0000000189848E90
	// [XID] // 0x0000000189848E50-0x0000000189848E90
	public override bool Equals(object obj) => default; // 0x0000000180F83EA0-0x0000000180F83F70
	// [IDTag] // 0x0000000189853110-0x0000000189853150
	// [XID] // 0x0000000189853110-0x0000000189853150
	public int CompareTo(object obj) => default; // 0x0000000180F83AE0-0x0000000180F83BD0
	// [IDTag] // 0x000000018985D430-0x000000018985D470
	// [XID] // 0x000000018985D430-0x000000018985D470
	public int CompareTo(SafeBool other) => default; // 0x0000000180F83BD0-0x0000000180F83C80
	// [IDTag] // 0x0000000189867D30-0x0000000189867D70
	// [XID] // 0x0000000189867D30-0x0000000189867D70
	public bool Equals(SafeBool other) => default; // 0x0000000180F83D60-0x0000000180F83EA0
	// [IDTag] // 0x0000000189872220-0x0000000189872260
	// [XID] // 0x0000000189872220-0x0000000189872260
	public static implicit operator SafeBool(bool v) => default; // 0x0000000180F83700-0x0000000180F83960
	// [IDTag] // 0x000000018987CBC0-0x000000018987CC00
	// [XID] // 0x000000018987CBC0-0x000000018987CC00
	public static implicit operator bool(SafeBool v) => default; // 0x0000000180F83650-0x0000000180F83700
}

