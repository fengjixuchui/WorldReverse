/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct LCRockGadgetCollisionCheckerData : ITaskData // TypeDefIndex: 26603
{
	// Fields
	private const int INIT_MAX_NUM = 10; // Metadata: 0x00B0C65C
	private static bool[] _dataIdentifies; // 0x00
	private static int _nextDataId; // 0x08
	private static ThreadList<LCRockGadgetCollisionCheckerData> _datas; // 0x10
	private static Queue<int> _freeIndex; // 0x18
	public const int staticTypeId = 6; // Metadata: 0x00B0C660
	private int _uid; // 0x04
	public int connectTriggerNumber; // 0x08
	public int detectTriggerNumber; // 0x0C
	public ColliderType[] colType; // 0x10
	public Vector3[] centerOriginalOffset; // 0x18
	public Vector3[] scale; // 0x20
	public Vector3[] colliderInfo; // 0x28
	public ColliderType[] detectColType; // 0x30
	public Vector3[] detectCenterOriginalOffset; // 0x38
	public Vector3[] detectScale; // 0x40
	public Vector3[] detectColliderInfo; // 0x48
	public LevelMoveScenePropPlugin scenePropPlugin; // 0x50
	public Rigidbody rigidbody; // 0x58
	public Transform transform; // 0x60
	public Vector3 position; // 0x68
	public Quaternion rotation; // 0x74
	public BaseEntity entity; // 0x88
	public int tickCount; // 0x90
	public int detectTickCount; // 0x94
	public bool suicide; // 0x98
	public HashSet<Collider> selfColliders; // 0xA0

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x0000000189B947A0-0x0000000189B947C0 */ get => default; } // 0x00000001811F7210-0x00000001811F7690 
	public int nodeIndex { /* [XID] */ /* 0x0000000189B9BE30-0x0000000189B9BE70 */ get; /* [XID] */ /* 0x0000000189BA63D0-0x0000000189BA6410 */ set; } // 0x00000001811F7C00-0x00000001811F7D00 0x00000001811F7E20-0x00000001811F7EA0
	public int typeId { /* [XID] */ /* 0x0000000189BB0800-0x0000000189BB0820 */ get => default; } // 0x00000001811F7D00-0x00000001811F7DB0 
	public int uid { /* [XID] */ /* 0x0000000189BD5E20-0x0000000189BD5E40 */ get => default; } // 0x00000001811F7DB0-0x00000001811F7E20 

	// Constructors
	static LCRockGadgetCollisionCheckerData() {
		_dataIdentifies = default;
		_nextDataId = default;
		_datas = default;
		_freeIndex = default;
	} // 0x00000001811F7AA0-0x00000001811F7C00

	// Methods
	// [XID] // 0x0000000189BB7B80-0x0000000189BB7BA0
	public static LCRockGadgetCollisionCheckerData Read(int id) => default; // 0x00000001811F7690-0x00000001811F7A90
	// [XID] // 0x0000000189BBF180-0x0000000189BBF1A0
	public void Init() {} // 0x00000001811F7200-0x00000001811F7210
	// [XID] // 0x0000000189BC6E90-0x0000000189BC6EB0
	public void Write() {} // 0x00000001811F7A90-0x00000001811F7AA0
	// [XID] // 0x0000000189BCEB00-0x0000000189BCEB20
	public void Free() {} // 0x00000001811F7060-0x00000001811F7130
	// [XID] // 0x0000000189BDDA90-0x0000000189BDDAB0
	private void Clear() {} // 0x00000001811F7130-0x00000001811F7200
}

