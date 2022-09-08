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
public class OutputControlConfig : IAutoAllocRecycle // TypeDefIndex: 15783
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected OptionalLimitConfig _dailyOutputLimit; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected OptionalLimitConfig _totalOutputLimit; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected OptionalLimitConfig _activityOutputLimit; // 0x20

	// Properties
	public OptionalLimitConfig dailyOutputLimit { /* [XID] */ /* 0x0000000189A86530-0x0000000189A86550 */ get => default; /* [XID] */ /* 0x0000000189A8E090-0x0000000189A8E0B0 */ protected set {} } // 0x0000000183C20010-0x0000000183C200B0 0x0000000183C1FDA0-0x0000000183C1FE50
	public OptionalLimitConfig totalOutputLimit { /* [XID] */ /* 0x0000000189A95570-0x0000000189A95590 */ get => default; /* [XID] */ /* 0x0000000189A9CE10-0x0000000189A9CE30 */ protected set {} } // 0x0000000183C1FF70-0x0000000183C20010 0x0000000183C200B0-0x0000000183C20160
	public OptionalLimitConfig activityOutputLimit { /* [XID] */ /* 0x0000000189AA4560-0x0000000189AA4580 */ get => default; /* [XID] */ /* 0x0000000189AABB90-0x0000000189AABBB0 */ protected set {} } // 0x0000000183C20380-0x0000000183C20420 0x0000000183C1FCF0-0x0000000183C1FDA0

	// Constructors
	public OutputControlConfig() {} // 0x0000000183C20600-0x0000000183C20660

	// Methods
	// [XID] // 0x0000000189AB3520-0x0000000189AB3540
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183C1FE50-0x0000000183C1FF70
	// [XID] // 0x0000000189ABB230-0x0000000189ABB250
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF25E3 */, bool useObjectPool = false /* Metadata: 0x00AF25E7 */) => default; // 0x0000000183C20160-0x0000000183C20380
	[BlackList] // 0x0000000189AC29C0-0x0000000189AC2A00
	// [XID] // 0x0000000189AC29C0-0x0000000189AC2A00
	public virtual void AutoAllocTypeFields() {} // 0x0000000183C1FBA0-0x0000000183C1FC40
	[BlackList] // 0x0000000189ACD040-0x0000000189ACD080
	// [XID] // 0x0000000189ACD040-0x0000000189ACD080
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183C1FC40-0x0000000183C1FCF0
	[BlackList] // 0x0000000189AD7D20-0x0000000189AD7D60
	// [XID] // 0x0000000189AD7D20-0x0000000189AD7D60
	public virtual void ReturnToObjectPool() {} // 0x0000000183C20560-0x0000000183C20600
	[BlackList] // 0x0000000189AE2420-0x0000000189AE2460
	// [XID] // 0x0000000189AE2420-0x0000000189AE2460
	public virtual void OnPoolAllocated() {} // 0x0000000183C204C0-0x0000000183C20560
	[BlackList] // 0x0000000189AECDA0-0x0000000189AECDE0
	// [XID] // 0x0000000189AECDA0-0x0000000189AECDE0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183C20420-0x0000000183C204C0
}

