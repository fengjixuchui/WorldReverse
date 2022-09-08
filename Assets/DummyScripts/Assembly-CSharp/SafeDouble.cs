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
public struct SafeDouble : IComparable, IComparable<SafeDouble>, IEquatable<SafeDouble> // TypeDefIndex: 31823
{
	// Fields
	private long _data1; // 0x00
	private long _data2; // 0x08
	private static Random _random; // 0x00
	private static byte[,] _map; // 0x08

	// Properties
	public double Value { /* [XID] */ /* 0x000000018977F780-0x000000018977F7A0 */ get => default; /* [XID] */ /* 0x00000001898955F0-0x0000000189895610 */ set {} } // 0x00000001838EE000-0x00000001838EE340 0x00000001838EE4E0-0x00000001838EE4F0

	// Constructors
	public SafeDouble(double value) : this() {
		_data1 = default;
		_data2 = default;
	} // 0x00000001838EEC40-0x00000001838EEC50
	static SafeDouble() {
		_random = default;
		_map = default;
	} // 0x00000001838EE8C0-0x00000001838EEC40

	// Methods
	// [XID] // 0x0000000189787150-0x0000000189787170
	private double Get() => default; // 0x00000001838EDE90-0x00000001838EDF40
	// [XID] // 0x00000001898A4520-0x00000001898A4540
	private void Set(double value) {} // 0x00000001838EE340-0x00000001838EE420
	// [XID] // 0x00000001898AB990-0x00000001898AB9B0
	private byte GetByte(int index) => default; // 0x00000001838EE420-0x00000001838EE4E0
	// [XID] // 0x00000001898B3150-0x00000001898B3170
	private void SetByte(int index, byte value) {} // 0x00000001838EE7E0-0x00000001838EE8B0
	// [XID] // 0x00000001898BAE50-0x00000001898BAE70
	public override string ToString() => default; // 0x00000001838EE8B0-0x00000001838EE8C0
	// [XID] // 0x00000001898C21A0-0x00000001898C21C0
	public override int GetHashCode() => default; // 0x00000001838ED920-0x00000001838ED930
	// [IDTag] // 0x00000001898C9BF0-0x00000001898C9C30
	// [XID] // 0x00000001898C9BF0-0x00000001898C9C30
	public override bool Equals(object obj) => default; // 0x00000001838ED740-0x00000001838ED840
	// [IDTag] // 0x00000001898D4210-0x00000001898D4250
	// [XID] // 0x00000001898D4210-0x00000001898D4250
	public int CompareTo(object obj) => default; // 0x00000001838ED450-0x00000001838ED550
	// [IDTag] // 0x00000001898DF160-0x00000001898DF1A0
	// [XID] // 0x00000001898DF160-0x00000001898DF1A0
	public int CompareTo(SafeDouble other) => default; // 0x00000001838ED550-0x00000001838ED600
	// [IDTag] // 0x00000001898E9CD0-0x00000001898E9D10
	// [XID] // 0x00000001898E9CD0-0x00000001898E9D10
	public bool Equals(SafeDouble other) => default; // 0x00000001838ED840-0x00000001838ED920
	// [IDTag] // 0x00000001898F41B0-0x00000001898F41F0
	// [XID] // 0x00000001898F41B0-0x00000001898F41F0
	public static implicit operator SafeDouble(double v) => default; // 0x00000001838ECF00-0x00000001838ED0C0
	// [IDTag] // 0x00000001898FE9D0-0x00000001898FEA10
	// [XID] // 0x00000001898FE9D0-0x00000001898FEA10
	public static implicit operator double(SafeDouble v) => default; // 0x00000001838ED0C0-0x00000001838ED210
	// [XID] // 0x00000001899092F0-0x0000000189909310
	public static explicit operator float(SafeDouble v) => default; // 0x00000001838ED220-0x00000001838ED450
	// [XID] // 0x00000001899107C0-0x00000001899107E0
	public static SafeDouble operator ++(SafeDouble a) => default; // 0x00000001838EE4F0-0x00000001838EE7E0
	// [XID] // 0x0000000189918360-0x0000000189918380
	public static SafeDouble operator --(SafeDouble a) => default; // 0x00000001838ED930-0x00000001838EDE90
}

