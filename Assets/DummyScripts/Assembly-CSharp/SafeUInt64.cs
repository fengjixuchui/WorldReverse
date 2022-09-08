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
public struct SafeUInt64 : IComparable, IComparable<SafeUInt64>, IEquatable<SafeUInt64> // TypeDefIndex: 31829
{
	// Fields
	private long _data1; // 0x00
	private long _data2; // 0x08
	private static Random _random; // 0x00
	private static byte[,] _map; // 0x08

	// Properties
	public ulong Value { /* [XID] */ /* 0x000000018960B240-0x000000018960B260 */ get => default; /* [XID] */ /* 0x00000001896125F0-0x0000000189612610 */ set {} } // 0x0000000183BCF810-0x0000000183BCFB40 0x0000000183BCFCE0-0x0000000183BCFCF0

	// Constructors
	public SafeUInt64(ulong value) : this() {
		_data1 = default;
		_data2 = default;
	} // 0x0000000183BD0430-0x0000000183BD0440
	static SafeUInt64() {
		_random = default;
		_map = default;
	} // 0x0000000183BD00B0-0x0000000183BD0430

	// Methods
	// [XID] // 0x0000000189619F60-0x0000000189619F80
	private ulong Get() => default; // 0x0000000183BCF6A0-0x0000000183BCF750
	// [XID] // 0x0000000189621490-0x00000001896214B0
	private void Set(ulong value) {} // 0x0000000183BCFB40-0x0000000183BCFC20
	// [XID] // 0x0000000189628DE0-0x0000000189628E00
	private byte GetByte(int index) => default; // 0x0000000183BCFC20-0x0000000183BCFCE0
	// [XID] // 0x0000000189630760-0x0000000189630780
	private void SetByte(int index, byte value) {} // 0x0000000183BCFFD0-0x0000000183BD00A0
	// [XID] // 0x00000001896381A0-0x00000001896381C0
	public override string ToString() => default; // 0x0000000183BD00A0-0x0000000183BD00B0
	// [XID] // 0x000000018963F580-0x000000018963F5A0
	public override int GetHashCode() => default; // 0x0000000183BCF150-0x0000000183BCF160
	// [IDTag] // 0x0000000189646CF0-0x0000000189646D30
	// [XID] // 0x0000000189646CF0-0x0000000189646D30
	public override bool Equals(object obj) => default; // 0x0000000183BCF080-0x0000000183BCF150
	// [IDTag] // 0x0000000189651410-0x0000000189651450
	// [XID] // 0x0000000189651410-0x0000000189651450
	public int CompareTo(object obj) => default; // 0x0000000183BCECA0-0x0000000183BCEDA0
	// [IDTag] // 0x000000018965BD90-0x000000018965BDD0
	// [XID] // 0x000000018965BD90-0x000000018965BDD0
	public int CompareTo(SafeUInt64 other) => default; // 0x0000000183BCEDA0-0x0000000183BCEE50
	// [IDTag] // 0x00000001896661E0-0x0000000189666220
	// [XID] // 0x00000001896661E0-0x0000000189666220
	public bool Equals(SafeUInt64 other) => default; // 0x0000000183BCEF40-0x0000000183BCF080
	// [IDTag] // 0x0000000189671100-0x0000000189671140
	// [XID] // 0x0000000189671100-0x0000000189671140
	public static implicit operator SafeUInt64(ulong v) => default; // 0x0000000183BCE8C0-0x0000000183BCEB20
	// [IDTag] // 0x000000018967B890-0x000000018967B8D0
	// [XID] // 0x000000018967B890-0x000000018967B8D0
	public static implicit operator ulong(SafeUInt64 v) => default; // 0x0000000183BCE810-0x0000000183BCE8C0
	// [XID] // 0x0000000189685DF0-0x0000000189685E10
	public static SafeUInt64 operator ++(SafeUInt64 a) => default; // 0x0000000183BCFCF0-0x0000000183BCFFD0
	// [XID] // 0x000000018968DC70-0x000000018968DC90
	public static SafeUInt64 operator --(SafeUInt64 a) => default; // 0x0000000183BCF160-0x0000000183BCF6A0
}

