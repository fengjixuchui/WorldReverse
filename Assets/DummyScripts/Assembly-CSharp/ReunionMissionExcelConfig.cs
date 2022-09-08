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
public class ReunionMissionExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16058
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 watcherGroupIdRawNum; // 0x14
	protected SimpleSafeUInt32 targetScoreRawNum; // 0x18
	protected SimpleSafeUInt32 finishRewardIdRawNum; // 0x1C

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B67640-0x0000000189B67660 */ get => default; /* [XID] */ /* 0x0000000189B6E880-0x0000000189B6E8A0 */ protected set {} } // 0x0000000182AC1C60-0x0000000182AC1D30 0x0000000182AC13E0-0x0000000182AC14C0
	public uint watcherGroupId { /* [XID] */ /* 0x0000000189B76130-0x0000000189B76150 */ get => default; /* [XID] */ /* 0x0000000189B7D620-0x0000000189B7D640 */ protected set {} } // 0x0000000182AC1E10-0x0000000182AC1EE0 0x0000000182AC1300-0x0000000182AC13E0
	public uint targetScore { /* [XID] */ /* 0x0000000189B85370-0x0000000189B85390 */ get => default; /* [XID] */ /* 0x0000000189B8C1C0-0x0000000189B8C1E0 */ protected set {} } // 0x0000000182AC1A50-0x0000000182AC1B20 0x0000000182AC1D30-0x0000000182AC1E10
	public uint finishRewardId { /* [XID] */ /* 0x0000000189B93A50-0x0000000189B93A70 */ get => default; /* [XID] */ /* 0x0000000189B9B020-0x0000000189B9B040 */ protected set {} } // 0x0000000182AC0A10-0x0000000182AC0AE0 0x0000000182AC1970-0x0000000182AC1A50

	// Constructors
	public ReunionMissionExcelConfig() {} // 0x0000000182AC1F80-0x0000000182AC1FE0

	// Methods
	// [IDTag] // 0x0000000189BA2830-0x0000000189BA2870
	// [XID] // 0x0000000189BA2830-0x0000000189BA2870
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182AC0FB0-0x0000000182AC1300
	// [IDTag] // 0x0000000189BAC730-0x0000000189BAC770
	// [XID] // 0x0000000189BAC730-0x0000000189BAC770
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182AC0C90-0x0000000182AC0FB0
	// [XID] // 0x0000000189BB6E30-0x0000000189BB6E50
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2F25 */, bool useObjectPool = false /* Metadata: 0x00AF2F29 */) => default; // 0x0000000182AC14C0-0x0000000182AC1970
	[BlackList] // 0x0000000189BBE3D0-0x0000000189BBE410
	// [XID] // 0x0000000189BBE3D0-0x0000000189BBE410
	public virtual void AutoAllocTypeFields() {} // 0x0000000182AC0AE0-0x0000000182AC0B80
	[BlackList] // 0x0000000189BC9220-0x0000000189BC9260
	// [XID] // 0x0000000189BC9220-0x0000000189BC9260
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182AC0B80-0x0000000182AC0C90
	[BlackList] // 0x0000000189BD3A10-0x0000000189BD3A50
	// [XID] // 0x0000000189BD3A10-0x0000000189BD3A50
	public virtual void ReturnToObjectPool() {} // 0x0000000182AC1EE0-0x0000000182AC1F80
	[BlackList] // 0x0000000189BDE3A0-0x0000000189BDE3E0
	// [XID] // 0x0000000189BDE3A0-0x0000000189BDE3E0
	public virtual void OnPoolAllocated() {} // 0x0000000182AC1BC0-0x0000000182AC1C60
	[BlackList] // 0x00000001895EDD90-0x00000001895EDDD0
	// [XID] // 0x00000001895EDD90-0x00000001895EDDD0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182AC1B20-0x0000000182AC1BC0
}

