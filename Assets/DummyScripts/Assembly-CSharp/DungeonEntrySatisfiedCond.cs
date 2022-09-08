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
public class DungeonEntrySatisfiedCond : IAutoAllocRecycle // TypeDefIndex: 15519
{
	// Fields
	protected DungeonEntrySatisfiedConditionType _type; // 0x10
	protected SimpleSafeUInt32 param1RawNum; // 0x14
	protected SimpleSafeUInt32 param2RawNum; // 0x18

	// Properties
	public DungeonEntrySatisfiedConditionType type { /* [XID] */ /* 0x0000000189B28670-0x0000000189B28690 */ get => default; /* [XID] */ /* 0x0000000189B2FA30-0x0000000189B2FA50 */ protected set {} } // 0x000000018413F4F0-0x000000018413F590 0x000000018413F220-0x000000018413F2D0
	public uint param1 { /* [XID] */ /* 0x0000000189B373D0-0x0000000189B373F0 */ get => default; /* [XID] */ /* 0x0000000189B3EC40-0x0000000189B3EC60 */ protected set {} } // 0x000000018413E8D0-0x000000018413E9A0 0x000000018413EC60-0x000000018413ED40
	public uint param2 { /* [XID] */ /* 0x0000000189B46700-0x0000000189B46720 */ get => default; /* [XID] */ /* 0x0000000189B4DC80-0x0000000189B4DCA0 */ protected set {} } // 0x000000018413ED40-0x000000018413EE10 0x000000018413F2D0-0x000000018413F3B0

	// Constructors
	public DungeonEntrySatisfiedCond() {} // 0x000000018413F630-0x000000018413F690

	// Methods
	// [XID] // 0x0000000189B554D0-0x0000000189B554F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018413E9A0-0x000000018413EC60
	// [XID] // 0x0000000189B5CE10-0x0000000189B5CE30
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1D0A */, bool useObjectPool = false /* Metadata: 0x00AF1D0E */) => default; // 0x000000018413EE10-0x000000018413F220
	[BlackList] // 0x0000000189B644F0-0x0000000189B64530
	// [XID] // 0x0000000189B644F0-0x0000000189B64530
	public virtual void AutoAllocTypeFields() {} // 0x000000018413E740-0x000000018413E7E0
	[BlackList] // 0x0000000189B6E940-0x0000000189B6E980
	// [XID] // 0x0000000189B6E940-0x0000000189B6E980
	public virtual void AutoRecycleTypeFields() {} // 0x000000018413E7E0-0x000000018413E8D0
	[BlackList] // 0x0000000189B78F80-0x0000000189B78FC0
	// [XID] // 0x0000000189B78F80-0x0000000189B78FC0
	public virtual void ReturnToObjectPool() {} // 0x000000018413F590-0x000000018413F630
	[BlackList] // 0x0000000189B838A0-0x0000000189B838E0
	// [XID] // 0x0000000189B838A0-0x0000000189B838E0
	public virtual void OnPoolAllocated() {} // 0x000000018413F450-0x000000018413F4F0
	[BlackList] // 0x0000000189B8DB90-0x0000000189B8DBD0
	// [XID] // 0x0000000189B8DB90-0x0000000189B8DBD0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018413F3B0-0x000000018413F450
}

