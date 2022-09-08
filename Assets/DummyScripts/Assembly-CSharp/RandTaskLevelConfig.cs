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
public class RandTaskLevelConfig : IAutoAllocRecycle // TypeDefIndex: 16003
{
	// Fields
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	protected SimpleSafeUInt32 minZoneLevelRawNum; // 0x14
	protected SimpleSafeUInt32 maxZoneLevelRawNum; // 0x18
	protected SimpleSafeUInt32 reviseLevelRawNum; // 0x1C

	// Properties
	public uint ID { /* [XID] */ /* 0x00000001896A36C0-0x00000001896A36E0 */ get => default; /* [XID] */ /* 0x00000001896AAB90-0x00000001896AABB0 */ protected set {} } // 0x00000001817CF380-0x00000001817CF450 0x00000001817CE720-0x00000001817CE800
	public uint minZoneLevel { /* [XID] */ /* 0x00000001896B1B10-0x00000001896B1B30 */ get => default; /* [XID] */ /* 0x00000001896B9570-0x00000001896B9590 */ protected set {} } // 0x00000001817CF9E0-0x00000001817CFAB0 0x00000001817CF450-0x00000001817CF530
	public uint maxZoneLevel { /* [XID] */ /* 0x00000001896C08E0-0x00000001896C0900 */ get => default; /* [XID] */ /* 0x00000001896C80B0-0x00000001896C80D0 */ protected set {} } // 0x00000001817CE800-0x00000001817CE8D0 0x00000001817CEA80-0x00000001817CEB60
	public uint reviseLevel { /* [XID] */ /* 0x00000001896CF950-0x00000001896CF970 */ get => default; /* [XID] */ /* 0x00000001896D6C00-0x00000001896D6C20 */ protected set {} } // 0x00000001817CF1D0-0x00000001817CF2A0 0x00000001817CF2A0-0x00000001817CF380

	// Constructors
	public RandTaskLevelConfig() {} // 0x00000001817CFC90-0x00000001817CFCF0

	// Methods
	// [IDTag] // 0x00000001896DE320-0x00000001896DE360
	// [XID] // 0x00000001896DE320-0x00000001896DE360
	public virtual bool ParseFromLine(string line) => default; // 0x00000001817CEB60-0x00000001817CEEB0
	// [IDTag] // 0x00000001896E8720-0x00000001896E8760
	// [XID] // 0x00000001896E8720-0x00000001896E8760
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001817CEEB0-0x00000001817CF1D0
	// [XID] // 0x00000001896F2C50-0x00000001896F2C70
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2D77 */, bool useObjectPool = false /* Metadata: 0x00AF2D7B */) => default; // 0x00000001817CF530-0x00000001817CF9E0
	[BlackList] // 0x00000001896FA530-0x00000001896FA570
	// [XID] // 0x00000001896FA530-0x00000001896FA570
	public virtual void AutoAllocTypeFields() {} // 0x00000001817CE8D0-0x00000001817CE970
	[BlackList] // 0x0000000189704BB0-0x0000000189704BF0
	// [XID] // 0x0000000189704BB0-0x0000000189704BF0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001817CE970-0x00000001817CEA80
	[BlackList] // 0x000000018970F560-0x000000018970F5A0
	// [XID] // 0x000000018970F560-0x000000018970F5A0
	public virtual void ReturnToObjectPool() {} // 0x00000001817CFBF0-0x00000001817CFC90
	[BlackList] // 0x0000000189719CD0-0x0000000189719D10
	// [XID] // 0x0000000189719CD0-0x0000000189719D10
	public virtual void OnPoolAllocated() {} // 0x00000001817CFB50-0x00000001817CFBF0
	[BlackList] // 0x0000000189723EF0-0x0000000189723F30
	// [XID] // 0x0000000189723EF0-0x0000000189723F30
	public virtual void OnBeforePoolRecycled() {} // 0x00000001817CFAB0-0x00000001817CFB50
}

