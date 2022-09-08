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

public class NpcBornInfo // TypeDefIndex: 21255
{
	// Fields
	public uint npcConfigId; // 0x10
	public uint questMainId; // 0x14
	public List<BornPosData> bornPosList; // 0x18
	public BornPosData bornPos; // 0x20
	public uint curRuntimeId; // 0x28
	public BaseEntity curEntity; // 0x30
	public NpcBornState state; // 0x38
	public Vector3 curPos; // 0x3C
	public Vector3 curRot; // 0x48
	public uint curRoomId; // 0x54
	public RecycledLinkedList<NpcBornInfo> appearNode; // 0x58
	public RecycledLinkedList<NpcBornInfo> disappearNode; // 0x60
	public RecycledLinkedList<NpcBornInfo> dirtyNode; // 0x68
	public bool isForceNotDestroy; // 0x70
	private int _disableCount; // 0x74
	private BornPosData _curBornPos; // 0x78

	// Properties
	public bool isDirty { /* [XID] */ /* 0x00000001898B7750-0x00000001898B7770 */ get => default; } // 0x0000000182A9B1C0-0x0000000182A9B270 
	public BornPosData curBornPos { /* [XID] */ /* 0x0000000189A0B550-0x0000000189A0B570 */ get => default; } // 0x0000000182A9B060-0x0000000182A9B110 
	public bool isCurBornPosEnable { /* [XID] */ /* 0x0000000189A12CD0-0x0000000189A12CF0 */ get => default; } // 0x0000000182A9AF00-0x0000000182A9AFC0 

	// Constructors
	public NpcBornInfo() {} // 0x0000000182A9B270-0x0000000182A9B300

	// Methods
	// [XID] // 0x00000001899F5310-0x00000001899F5330
	public void Reset() {} // 0x0000000182A9AD40-0x0000000182A9AF00
	// [XID] // 0x0000000189B77F90-0x0000000189B77FB0
	public void SetCurBornPos(BornPosData bornPos) {} // 0x0000000182A9B110-0x0000000182A9B1C0
	// [XID] // 0x00000001898A8580-0x00000001898A85A0
	public void ResetCurBornPos() {} // 0x0000000182A9AFC0-0x0000000182A9B060
}

