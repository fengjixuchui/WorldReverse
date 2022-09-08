/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct DualClientSequenceId // TypeDefIndex: 20636
{
	// Fields
	public uint clientSequenceId; // 0x00
	public uint subSequenceId; // 0x04
	public static DualClientSequenceId MaxValue; // 0x00
	public static DualClientSequenceId MinValue; // 0x08

	// Constructors
	public DualClientSequenceId(uint clientSequenceId, uint subSequenceId) {
		this.clientSequenceId = default;
		this.subSequenceId = default;
	} // 0x0000000181E02DD0-0x0000000181E02E40
	static DualClientSequenceId() {
		MaxValue = default;
		MinValue = default;
	} // 0x0000000181E02C50-0x0000000181E02DD0

	// Methods
	// [IDTag] // 0x0000000189B3E2F0-0x0000000189B3E330
	// [XID] // 0x0000000189B3E2F0-0x0000000189B3E330
	public static bool operator ==(DualClientSequenceId a, DualClientSequenceId b) => default; // 0x0000000181E02960-0x0000000181E02A20
	// [IDTag] // 0x0000000189B48EC0-0x0000000189B48F00
	// [XID] // 0x0000000189B48EC0-0x0000000189B48F00
	public static bool operator ==(DualClientSequenceId a, int b) => default; // 0x0000000181E02A20-0x0000000181E02AD0
	// [IDTag] // 0x0000000189B53480-0x0000000189B534C0
	// [XID] // 0x0000000189B53480-0x0000000189B534C0
	public static bool operator !=(DualClientSequenceId a, int b) => default; // 0x0000000181E02AD0-0x0000000181E02B80
	// [IDTag] // 0x0000000189B5DE60-0x0000000189B5DEA0
	// [XID] // 0x0000000189B5DE60-0x0000000189B5DEA0
	public static bool operator !=(DualClientSequenceId a, DualClientSequenceId b) => default; // 0x0000000181E02B80-0x0000000181E02C50
	// [XID] // 0x0000000189AA0230-0x0000000189AA0250
	public static bool operator >(DualClientSequenceId a, DualClientSequenceId b) => default; // 0x0000000181E022F0-0x0000000181E023C0
	// [XID] // 0x0000000189B6FA00-0x0000000189B6FA20
	public static bool operator <(DualClientSequenceId a, DualClientSequenceId b) => default; // 0x0000000181E023C0-0x0000000181E02520
	// [XID] // 0x0000000189B76F90-0x0000000189B76FB0
	public static bool operator >=(DualClientSequenceId a, DualClientSequenceId b) => default; // 0x0000000181E02530-0x0000000181E02600
	// [XID] // 0x0000000189B7E5A0-0x0000000189B7E5C0
	public static bool operator <=(DualClientSequenceId a, DualClientSequenceId b) => default; // 0x0000000181E02600-0x0000000181E027F0
	// [XID] // 0x0000000189B861B0-0x0000000189B861D0
	public override bool Equals(object obj) => default; // 0x0000000181E027F0-0x0000000181E028A0
	// [XID] // 0x0000000189B8D250-0x0000000189B8D270
	public override int GetHashCode() => default; // 0x0000000181E028A0-0x0000000181E02950
}

