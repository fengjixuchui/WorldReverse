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
public class ReliquaryMainPropExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16017
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 prop_depot_idRawNum; // 0x14
	protected FightPropType _propType; // 0x18
	protected ReliquaryMainAffixName _affixName; // 0x1C
	protected SimpleSafeUInt32 weightRawNum; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B90CB0-0x0000000189B90CD0 */ get => default; /* [XID] */ /* 0x0000000189B97FA0-0x0000000189B97FC0 */ protected set {} } // 0x0000000183556B00-0x0000000183556BD0 0x0000000183556240-0x0000000183556320
	public uint prop_depot_id { /* [XID] */ /* 0x0000000189B9F410-0x0000000189B9F430 */ get => default; /* [XID] */ /* 0x0000000189BA6C60-0x0000000189BA6C80 */ protected set {} } // 0x0000000183555750-0x0000000183555820 0x0000000183556160-0x0000000183556240
	public FightPropType propType { /* [XID] */ /* 0x0000000189BADE00-0x0000000189BADE20 */ get => default; /* [XID] */ /* 0x0000000189BB55D0-0x0000000189BB55F0 */ protected set {} } // 0x0000000183556870-0x0000000183556910 0x0000000183555FD0-0x0000000183556080
	public ReliquaryMainAffixName affixName { /* [XID] */ /* 0x0000000189BBCD20-0x0000000189BBCD40 */ get => default; /* [XID] */ /* 0x0000000189BC4960-0x0000000189BC4980 */ protected set {} } // 0x00000001835556B0-0x0000000183555750 0x0000000183556910-0x00000001835569C0
	public uint weight { /* [XID] */ /* 0x0000000189BCC3C0-0x0000000189BCC3E0 */ get => default; /* [XID] */ /* 0x0000000189BD3A70-0x0000000189BD3A90 */ protected set {} } // 0x0000000183556BD0-0x0000000183556CA0 0x0000000183556080-0x0000000183556160

	// Constructors
	public ReliquaryMainPropExcelConfig() {} // 0x0000000183556D40-0x0000000183556DA0

	// Methods
	// [IDTag] // 0x0000000189BDB3A0-0x0000000189BDB3E0
	// [XID] // 0x0000000189BDB3A0-0x0000000189BDB3E0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183555820-0x0000000183555C10
	// [IDTag] // 0x00000001895EAED0-0x00000001895EAF10
	// [XID] // 0x00000001895EAED0-0x00000001895EAF10
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183555C10-0x0000000183555FD0
	// [XID] // 0x00000001895F55D0-0x00000001895F55F0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2DFF */, bool useObjectPool = false /* Metadata: 0x00AF2E03 */) => default; // 0x0000000183556320-0x0000000183556870
	[BlackList] // 0x00000001895FCB70-0x00000001895FCBB0
	// [XID] // 0x00000001895FCB70-0x00000001895FCBB0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183555510-0x00000001835555B0
	[BlackList] // 0x0000000189607300-0x0000000189607340
	// [XID] // 0x0000000189607300-0x0000000189607340
	public virtual void AutoRecycleTypeFields() {} // 0x00000001835555B0-0x00000001835556B0
	[BlackList] // 0x0000000189611DC0-0x0000000189611E00
	// [XID] // 0x0000000189611DC0-0x0000000189611E00
	public virtual void ReturnToObjectPool() {} // 0x0000000183556CA0-0x0000000183556D40
	[BlackList] // 0x000000018961C5A0-0x000000018961C5E0
	// [XID] // 0x000000018961C5A0-0x000000018961C5E0
	public virtual void OnPoolAllocated() {} // 0x0000000183556A60-0x0000000183556B00
	[BlackList] // 0x0000000189626980-0x00000001896269C0
	// [XID] // 0x0000000189626980-0x00000001896269C0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001835569C0-0x0000000183556A60
}

