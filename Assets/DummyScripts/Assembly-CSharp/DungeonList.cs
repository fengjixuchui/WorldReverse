/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class DungeonList : IAutoAllocRecycle // TypeDefIndex: 15558
{
	// Fields
	protected SimpleSafeUInt32[] _dungeonList; // 0x10

	// Properties
	public SimpleSafeUInt32[] dungeonList { /* [XID] */ /* 0x00000001898A54A0-0x00000001898A54C0 */ get => default; /* [XID] */ /* 0x00000001898ACA80-0x00000001898ACAA0 */ protected set {} } // 0x00000001831D2BD0-0x00000001831D2C70 0x00000001831D2FE0-0x00000001831D3090

	// Constructors
	public DungeonList() {} // 0x00000001831D3530-0x00000001831D3590

	// Methods
	// [XID] // 0x00000001898B3F00-0x00000001898B3F20
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001831D2C70-0x00000001831D2FE0
	// [XID] // 0x00000001898BBBD0-0x00000001898BBBF0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1F0C */, bool useObjectPool = false /* Metadata: 0x00AF1F10 */) => default; // 0x00000001831D3090-0x00000001831D3350
	[BlackList] // 0x00000001898C30C0-0x00000001898C3100
	// [XID] // 0x00000001898C30C0-0x00000001898C3100
	public virtual void AutoAllocTypeFields() {} // 0x00000001831D2A90-0x00000001831D2B30
	[BlackList] // 0x00000001898CD720-0x00000001898CD760
	// [XID] // 0x00000001898CD720-0x00000001898CD760
	public virtual void AutoRecycleTypeFields() {} // 0x00000001831D2B30-0x00000001831D2BD0
	[BlackList] // 0x00000001898D8100-0x00000001898D8140
	// [XID] // 0x00000001898D8100-0x00000001898D8140
	public virtual void ReturnToObjectPool() {} // 0x00000001831D3490-0x00000001831D3530
	[BlackList] // 0x00000001898E2D20-0x00000001898E2D60
	// [XID] // 0x00000001898E2D20-0x00000001898E2D60
	public virtual void OnPoolAllocated() {} // 0x00000001831D33F0-0x00000001831D3490
	[BlackList] // 0x00000001898ED800-0x00000001898ED840
	// [XID] // 0x00000001898ED800-0x00000001898ED840
	public virtual void OnBeforePoolRecycled() {} // 0x00000001831D3350-0x00000001831D33F0
}

