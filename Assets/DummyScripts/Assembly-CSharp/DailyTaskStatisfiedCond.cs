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
public class DailyTaskStatisfiedCond : IAutoAllocRecycle // TypeDefIndex: 15480
{
	// Fields
	protected ConditionType _type; // 0x10
	protected SimpleSafeUInt32 param1RawNum; // 0x14
	protected SimpleSafeUInt32 param2RawNum; // 0x18
	protected SimpleSafeUInt32 param3RawNum; // 0x1C

	// Properties
	public ConditionType type { /* [XID] */ /* 0x00000001899EAF20-0x00000001899EAF40 */ get => default; /* [XID] */ /* 0x00000001899F2B80-0x00000001899F2BA0 */ protected set {} } // 0x00000001828E78B0-0x00000001828E7950 0x00000001828E7500-0x00000001828E75B0
	public uint param1 { /* [XID] */ /* 0x00000001899FA150-0x00000001899FA170 */ get => default; /* [XID] */ /* 0x0000000189A01550-0x0000000189A01570 */ protected set {} } // 0x00000001828E6AA0-0x00000001828E6B70 0x00000001828E6EA0-0x00000001828E6F80
	public uint param2 { /* [XID] */ /* 0x0000000189A08ED0-0x0000000189A08EF0 */ get => default; /* [XID] */ /* 0x0000000189A10410-0x0000000189A10430 */ protected set {} } // 0x00000001828E6F80-0x00000001828E7050 0x00000001828E7690-0x00000001828E7770
	public uint param3 { /* [XID] */ /* 0x0000000189A179D0-0x0000000189A179F0 */ get => default; /* [XID] */ /* 0x0000000189A1F0F0-0x0000000189A1F110 */ protected set {} } // 0x00000001828E6830-0x00000001828E6900 0x00000001828E75B0-0x00000001828E7690

	// Constructors
	public DailyTaskStatisfiedCond() {} // 0x00000001828E79F0-0x00000001828E7A50

	// Methods
	// [XID] // 0x0000000189A266E0-0x0000000189A26700
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001828E6B70-0x00000001828E6EA0
	// [XID] // 0x0000000189A2DA10-0x0000000189A2DA30
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1BE6 */, bool useObjectPool = false /* Metadata: 0x00AF1BEA */) => default; // 0x00000001828E7050-0x00000001828E7500
	[BlackList] // 0x0000000189A35610-0x0000000189A35650
	// [XID] // 0x0000000189A35610-0x0000000189A35650
	public virtual void AutoAllocTypeFields() {} // 0x00000001828E6900-0x00000001828E69A0
	[BlackList] // 0x0000000189A3FCC0-0x0000000189A3FD00
	// [XID] // 0x0000000189A3FCC0-0x0000000189A3FD00
	public virtual void AutoRecycleTypeFields() {} // 0x00000001828E69A0-0x00000001828E6AA0
	[BlackList] // 0x0000000189A4A1A0-0x0000000189A4A1E0
	// [XID] // 0x0000000189A4A1A0-0x0000000189A4A1E0
	public virtual void ReturnToObjectPool() {} // 0x00000001828E7950-0x00000001828E79F0
	[BlackList] // 0x0000000189A54AD0-0x0000000189A54B10
	// [XID] // 0x0000000189A54AD0-0x0000000189A54B10
	public virtual void OnPoolAllocated() {} // 0x00000001828E7810-0x00000001828E78B0
	[BlackList] // 0x0000000189A5F410-0x0000000189A5F450
	// [XID] // 0x0000000189A5F410-0x0000000189A5F450
	public virtual void OnBeforePoolRecycled() {} // 0x00000001828E7770-0x00000001828E7810
}

