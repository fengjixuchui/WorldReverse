/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct IdCountStrConfig // TypeDefIndex: 14949
{
	// Fields
	private SimpleSafeUInt32 idRawNum; // 0x00
	private string _count; // 0x08

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A6E6C0-0x0000000189A6E6E0 */ get => default; /* [XID] */ /* 0x0000000189A75D50-0x0000000189A75D70 */ private set {} } // 0x0000000185181870-0x0000000185181920 0x0000000185181270-0x00000001851815F0
	public string count { /* [XID] */ /* 0x0000000189A7D890-0x0000000189A7D8B0 */ get => default; /* [XID] */ /* 0x0000000189A850E0-0x0000000189A85100 */ private set {} } // 0x0000000185181790-0x0000000185181870 0x0000000185180F10-0x0000000185180FF0

	// Constructors
	public IdCountStrConfig(uint id, string count) : this() {
		idRawNum = default;
		_count = default;
	} // 0x0000000185181920-0x0000000185181930

	// Methods
	// [XID] // 0x0000000189A8CA50-0x0000000189A8CA70
	public override bool Equals(object o) => default; // 0x0000000185180E50-0x0000000185180F10
	// [XID] // 0x0000000189A93DF0-0x0000000189A93E10
	public override int GetHashCode() => default; // 0x0000000185180FF0-0x00000001851810A0
	// [XID] // 0x0000000189A9B840-0x0000000189A9B860
	public static bool operator ==(IdCountStrConfig left, IdCountStrConfig right) => default; // 0x00000001851810B0-0x0000000185181270
	// [XID] // 0x0000000189AA2CE0-0x0000000189AA2D00
	public static bool operator !=(IdCountStrConfig left, IdCountStrConfig right) => default; // 0x0000000185181600-0x0000000185181790
	// [XID] // 0x0000000189AAA2A0-0x0000000189AAA2C0
	public bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000185180D60-0x0000000185180E50
	// [XID] // 0x0000000189AB20C0-0x0000000189AB20E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB88 */, bool useObjectPool = false /* Metadata: 0x00AEFB8C */) => default; // 0x00000001851815F0-0x0000000185181600
}

