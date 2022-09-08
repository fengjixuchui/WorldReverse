/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class RoomPortal // TypeDefIndex: 11413
{
	// Fields
	public const int MAX_ROOMS_PER_PORTAL = 2; // Metadata: 0x00AE9836
	public SyncId syncId; // 0x10
	public Vector3 position; // 0x28
	public Quaternion rotation; // 0x34
	public Vector3 extent; // 0x44
	public bool enabled; // 0x50
	public string name; // 0x58
	public uint[] linkedRoomNameIds; // 0x60
	public ulong[] realLinkedRoomIds; // 0x68

	// Constructors
	public RoomPortal() {} // Dummy constructor
	public RoomPortal(SyncId syncId, ref RoomPortalParams @params) {} // 0x0000000182615EA0-0x0000000182616090

	// Methods
	// [XID] // 0x00000001898B91A0-0x00000001898B91C0
	public override string ToString() => default; // 0x0000000182615D90-0x0000000182615EA0
	// [XID] // 0x00000001896B7030-0x00000001896B7050
	public void UpdateParams(ref RoomPortalParams @params) {} // 0x0000000182615970-0x0000000182615B50
	// [XID] // 0x00000001898C7F00-0x00000001898C7F20
	public MmoronPortalParams GetWwisePortalParams() => default; // 0x0000000182615B50-0x0000000182615D90
}

