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
public struct SafeFloat : IComparable, IComparable<SafeFloat>, IEquatable<SafeFloat> // TypeDefIndex: 31824
{
	// Fields
	private long _data1; // 0x00
	private long _data2; // 0x08
	private static Random _random; // 0x00
	private static byte[,] _map; // 0x08

	// Properties
	public float Value { /* [XID] */ /* 0x00000001899273F0-0x0000000189927410 */ get => default; /* [XID] */ /* 0x000000018992EBF0-0x000000018992EC10 */ set {} } // 0x0000000183130E50-0x00000001831311A0 0x0000000183131340-0x0000000183131350

	// Constructors
	public SafeFloat(float value) : this() {
		_data1 = default;
		_data2 = default;
	} // 0x0000000183131AA0-0x0000000183131AB0
	static SafeFloat() {
		_random = default;
		_map = default;
	} // 0x0000000183131720-0x0000000183131AA0

	// Methods
	// [XID] // 0x0000000189936050-0x0000000189936070
	private float Get() => default; // 0x0000000183130CE0-0x0000000183130D90
	// [XID] // 0x000000018993DAB0-0x000000018993DAD0
	private void Set(float value) {} // 0x00000001831311A0-0x0000000183131280
	// [XID] // 0x0000000189945260-0x0000000189945280
	private byte GetByte(int index) => default; // 0x0000000183131280-0x0000000183131340
	// [XID] // 0x000000018994C730-0x000000018994C750
	private void SetByte(int index, byte value) {} // 0x0000000183131640-0x0000000183131710
	// [XID] // 0x0000000189953E00-0x0000000189953E20
	public override string ToString() => default; // 0x0000000183131710-0x0000000183131720
	// [XID] // 0x000000018995B620-0x000000018995B640
	public override int GetHashCode() => default; // 0x0000000183130750-0x0000000183130760
	// [IDTag] // 0x00000001899631E0-0x0000000189963220
	// [XID] // 0x00000001899631E0-0x0000000189963220
	public override bool Equals(object obj) => default; // 0x0000000183130680-0x0000000183130750
	// [IDTag] // 0x000000018996D460-0x000000018996D4A0
	// [XID] // 0x000000018996D460-0x000000018996D4A0
	public int CompareTo(object obj) => default; // 0x0000000183130280-0x0000000183130380
	// [IDTag] // 0x00000001899783B0-0x00000001899783F0
	// [XID] // 0x00000001899783B0-0x00000001899783F0
	public int CompareTo(SafeFloat other) => default; // 0x0000000183130380-0x0000000183130430
	// [IDTag] // 0x00000001899829F0-0x0000000189982A30
	// [XID] // 0x00000001899829F0-0x0000000189982A30
	public bool Equals(SafeFloat other) => default; // 0x0000000183130530-0x0000000183130680
	// [IDTag] // 0x000000018998D1D0-0x000000018998D210
	// [XID] // 0x000000018998D1D0-0x000000018998D210
	public static implicit operator SafeFloat(float v) => default; // 0x000000018312FC80-0x000000018312FED0
	// [IDTag] // 0x0000000189997D30-0x0000000189997D70
	// [XID] // 0x0000000189997D30-0x0000000189997D70
	public static implicit operator float(SafeFloat v) => default; // 0x000000018312FBC0-0x000000018312FC80
	// [IDTag] // 0x00000001899A2780-0x00000001899A27C0
	// [XID] // 0x00000001899A2780-0x00000001899A27C0
	public static explicit operator double(SafeFloat v) => default; // 0x000000018312FF90-0x0000000183130050
	// [IDTag] // 0x00000001899AD070-0x00000001899AD0B0
	// [XID] // 0x00000001899AD070-0x00000001899AD0B0
	public static explicit operator int(SafeFloat v) => default; // 0x000000018312FEE0-0x000000018312FF90
	// [IDTag] // 0x00000001899B74C0-0x00000001899B7500
	// [XID] // 0x00000001899B74C0-0x00000001899B7500
	public static explicit operator uint(SafeFloat v) => default; // 0x0000000183130050-0x0000000183130280
	// [XID] // 0x00000001899C2070-0x00000001899C2090
	public static SafeFloat operator ++(SafeFloat a) => default; // 0x0000000183131350-0x0000000183131640
	// [XID] // 0x00000001899C9750-0x00000001899C9770
	public static SafeFloat operator --(SafeFloat a) => default; // 0x0000000183130760-0x0000000183130CE0
}

