/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct SyncId // TypeDefIndex: 11470
{
	// Fields
	private static readonly SyncId _empty; // 0x00
	private static readonly UInt64EqualityComparer _uInt64EqualityComparer; // 0x18
	private string _name; // 0x00

	// Properties
	public static SyncId empty { /* [XID] */ /* 0x00000001897A0B30-0x00000001897A0B50 */ get => default; } // 0x00000001818FCF60-0x00000001818FD0D0 
	public ulong akId { /* [XID] */ /* 0x00000001897A8160-0x00000001897A8190 */ get; /* [XID] */ /* 0x00000001897B2B10-0x00000001897B2B50 */ set; } // 0x00000001818FD640-0x00000001818FD7D0 0x00000001818FD0D0-0x00000001818FD1D0
	public int instanceId { /* [XID] */ /* 0x00000001897BE120-0x00000001897BE160 */ get; set; } // 0x00000001818FCF00-0x00000001818FCF60 0x00000001818FD350-0x00000001818FD460
	public string name { /* [XID] */ /* 0x00000001897CFE30-0x00000001897CFE50 */ get => default; /* [XID] */ /* 0x0000000189723110-0x0000000189723130 */ set {} } // 0x00000001818FE070-0x00000001818FE1C0 0x00000001818FD890-0x00000001818FD950
	public bool invalid { /* [XID] */ /* 0x00000001897DEB60-0x00000001897DEB80 */ get => default; } // 0x00000001818FDEE0-0x00000001818FE070 

	// Constructors
	static SyncId() {
		_empty = default;
		_uInt64EqualityComparer = default;
	} // 0x00000001818FE1D0-0x00000001818FE420
	public SyncId(SyncCategory category) : this() {
		_name = default;
	} // 0x00000001818FE420-0x00000001818FE5F0
	public SyncId(GameObject go) : this() {
		_name = default;
	} // 0x00000001818FE5F0-0x00000001818FE680

	// Methods
	// [XID] // 0x00000001897E6590-0x00000001897E65B0
	public override bool Equals(object obj) => default; // 0x00000001818FD340-0x00000001818FD350
	// [XID] // 0x00000001897EE0C0-0x00000001897EE0E0
	public override int GetHashCode() => default; // 0x00000001818FD7D0-0x00000001818FD890
	// [XID] // 0x00000001895F4560-0x00000001895F4580
	public override string ToString() => default; // 0x00000001818FE1C0-0x00000001818FE1D0
	// [XID] // 0x00000001899CDD70-0x00000001899CDD90
	public static bool operator ==(SyncId lhs, SyncId rhs) => default; // 0x00000001818FD960-0x00000001818FDB50
	// [XID] // 0x00000001896F6950-0x00000001896F6970
	public static bool operator !=(SyncId lhs, SyncId rhs) => default; // 0x00000001818FDB50-0x00000001818FDDF0
	// [Conditional] // 0x000000018980BBF0-0x000000018980BC40
	// [XID] // 0x000000018980BBF0-0x000000018980BC40
	private void SetName(GameObject go) {} // 0x00000001818FD460-0x00000001818FD5D0
	// [Conditional] // 0x0000000189816550-0x00000001898165A0
	// [XID] // 0x0000000189816550-0x00000001898165A0
	private void SetNameOnlyInEditor(GameObject go) {} // 0x00000001818FD5D0-0x00000001818FD640
	// [Conditional] // 0x0000000189821190-0x00000001898211E0
	// [XID] // 0x0000000189821190-0x00000001898211E0
	private void GetName(ref string name) {} // 0x00000001818FDDF0-0x00000001818FDEE0
}

