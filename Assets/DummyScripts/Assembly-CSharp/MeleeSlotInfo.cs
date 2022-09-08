/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MeleeSlotInfo // TypeDefIndex: 20457
{
	// Fields
	public static float KEEP_SAME_SLOT_ARC_PERCENT; // 0x00
	public BaseEntity owner; // 0x10
	public Vector3 center; // 0x18
	public int numOfSlots; // 0x24
	public int numOfSlotsOccupied; // 0x28
	private float _radius; // 0x40
	private float _sinStep; // 0x44
	private float _cosStep; // 0x48
	private float _keepSameSlotArcDistance; // 0x4C

	// Properties
	public List<MeleeSlot> slots { /* [XID] */ /* 0x0000000189B07570-0x0000000189B075B0 */ get; protected set; } // 0x00000001814DB930-0x00000001814DB990 0x00000001814DB1F0-0x00000001814DB250
	public Dictionary<uint, int> slotsAssignment { /* [XID] */ /* 0x0000000189B190F0-0x0000000189B19130 */ get; protected set; } // 0x00000001814DB990-0x00000001814DB9F0 0x00000001814DB8D0-0x00000001814DB930

	// Nested types
	public class MeleeSlot // TypeDefIndex: 20458
	{
		// Fields
		public Vector3 pos; // 0x10
		public Vector3 dir; // 0x1C
		public uint attackerRuntimeID; // 0x28

		// Constructors
		public MeleeSlot() {} // Dummy constructor
		public MeleeSlot(Vector3 position) {} // 0x00000001814F1690-0x00000001814F1800
	}

	// Constructors
	public MeleeSlotInfo() {} // Dummy constructor
	public MeleeSlotInfo(BaseEntity ownerEntity, int slotCount, float radius) {} // 0x00000001814DBF60-0x00000001814DC250
	static MeleeSlotInfo() {} // 0x00000001814DBF00-0x00000001814DBF60

	// Methods
	// [XID] // 0x0000000189B2AD80-0x0000000189B2ADA0
	public void UpdateAllSlots() {} // 0x00000001814DB600-0x00000001814DB8D0
	// [XID] // 0x0000000189B322E0-0x0000000189B32300
	private void ClearInvalidSlots() {} // 0x00000001814DB3E0-0x00000001814DB600
	// [XID] // 0x0000000189AD83E0-0x0000000189AD8400
	public bool RequestSlot(uint attackerID, ref Vector3 slotPosOut) => default; // 0x00000001814DB9F0-0x00000001814DBCA0
	// [XID] // 0x0000000189B414F0-0x0000000189B41510
	private void AcquireSlot(int slotIndex, uint attackerID) {} // 0x00000001814DBCA0-0x00000001814DBF00
	// [XID] // 0x0000000189AFDD10-0x0000000189AFDD30
	private void ReleaseSlot(int slotIndex) {} // 0x00000001814DB250-0x00000001814DB3E0
}

