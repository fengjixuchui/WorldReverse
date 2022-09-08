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
public class ActivitySalesmanExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15169
{
	// Fields
	protected SimpleSafeUInt32 scheduleIdRawNum; // 0x10
	protected SimpleSafeUInt32[] _dailyConfigIdList; // 0x18
	protected SimpleSafeUInt32[] _normalRewardIdList; // 0x20
	protected SimpleSafeUInt32[] _specialRewardIdList; // 0x28
	protected SimpleSafeFloat[] _specialProbList; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected SalesmanSpecialReward _specialReward; // 0x38

	// Properties
	public uint scheduleId { /* [XID] */ /* 0x00000001898FE180-0x00000001898FE1A0 */ get => default; /* [XID] */ /* 0x0000000189905A60-0x0000000189905A80 */ protected set {} } // 0x0000000183B3B490-0x0000000183B3B560 0x0000000183B3D680-0x0000000183B3D760
	public SimpleSafeUInt32[] dailyConfigIdList { /* [XID] */ /* 0x000000018990D310-0x000000018990D330 */ get => default; /* [XID] */ /* 0x0000000189914A40-0x0000000189914A60 */ protected set {} } // 0x0000000183B3B560-0x0000000183B3B600 0x0000000183B3D760-0x0000000183B3D810
	public SimpleSafeUInt32[] normalRewardIdList { /* [XID] */ /* 0x000000018991C6C0-0x000000018991C6E0 */ get => default; /* [XID] */ /* 0x0000000189923E60-0x0000000189923E80 */ protected set {} } // 0x0000000183B3DA00-0x0000000183B3DAA0 0x0000000183B3B8D0-0x0000000183B3B980
	public SimpleSafeUInt32[] specialRewardIdList { /* [XID] */ /* 0x000000018992B440-0x000000018992B460 */ get => default; /* [XID] */ /* 0x0000000189932AE0-0x0000000189932B00 */ protected set {} } // 0x0000000183B3D5E0-0x0000000183B3D680 0x0000000183B3B980-0x0000000183B3BA30
	public SimpleSafeFloat[] specialProbList { /* [XID] */ /* 0x000000018993A510-0x000000018993A530 */ get => default; /* [XID] */ /* 0x0000000189941560-0x0000000189941580 */ protected set {} } // 0x0000000183B3B830-0x0000000183B3B8D0 0x0000000183B3B780-0x0000000183B3B830
	public SalesmanSpecialReward specialReward { /* [XID] */ /* 0x00000001899490E0-0x0000000189949100 */ get => default; /* [XID] */ /* 0x00000001899508B0-0x00000001899508D0 */ protected set {} } // 0x0000000183B3CF40-0x0000000183B3CFE0 0x0000000183B3D810-0x0000000183B3D8C0

	// Constructors
	public ActivitySalesmanExcelConfig() {} // 0x0000000183B3DB40-0x0000000183B3DBA0

	// Methods
	// [IDTag] // 0x0000000189957F40-0x0000000189957F80
	// [XID] // 0x0000000189957F40-0x0000000189957F80
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183B3C470-0x0000000183B3CF40
	// [IDTag] // 0x0000000189962990-0x00000001899629D0
	// [XID] // 0x0000000189962990-0x00000001899629D0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183B3BA30-0x0000000183B3C470
	// [XID] // 0x000000018996CDF0-0x000000018996CE10
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF02BD */, bool useObjectPool = false /* Metadata: 0x00AF02C1 */) => default; // 0x0000000183B3CFE0-0x0000000183B3D5E0
	[BlackList] // 0x00000001899746F0-0x0000000189974730
	// [XID] // 0x00000001899746F0-0x0000000189974730
	public virtual void AutoAllocTypeFields() {} // 0x0000000183B3B600-0x0000000183B3B6A0
	[BlackList] // 0x000000018997EB20-0x000000018997EB60
	// [XID] // 0x000000018997EB20-0x000000018997EB60
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183B3B6A0-0x0000000183B3B780
	[BlackList] // 0x00000001899899C0-0x0000000189989A00
	// [XID] // 0x00000001899899C0-0x0000000189989A00
	public virtual void ReturnToObjectPool() {} // 0x0000000183B3DAA0-0x0000000183B3DB40
	[BlackList] // 0x0000000189994590-0x00000001899945D0
	// [XID] // 0x0000000189994590-0x00000001899945D0
	public virtual void OnPoolAllocated() {} // 0x0000000183B3D960-0x0000000183B3DA00
	[BlackList] // 0x000000018999EE90-0x000000018999EED0
	// [XID] // 0x000000018999EE90-0x000000018999EED0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183B3D8C0-0x0000000183B3D960
}

