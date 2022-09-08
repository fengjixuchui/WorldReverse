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
public class FlightActivityExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15112
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 activity_idRawNum; // 0x14
	protected SimpleSafeUInt32 preview_reward_idRawNum; // 0x18
	protected SimpleSafeUInt32 start_quest_idRawNum; // 0x1C
	protected SimpleSafeUInt32 npc_idRawNum; // 0x20
	protected SimpleSafeUInt32[] _medal_id; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected FlightDailyPointFactor[] _daily_factor_vec; // 0x30

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189808920-0x0000000189808940 */ get => default; /* [XID] */ /* 0x0000000189810350-0x0000000189810370 */ protected set {} } // 0x00000001825121E0-0x00000001825122B0 0x0000000182511220-0x0000000182511300
	public uint activity_id { /* [XID] */ /* 0x00000001898179E0-0x0000000189817A00 */ get => default; /* [XID] */ /* 0x000000018981F320-0x000000018981F340 */ protected set {} } // 0x0000000182511CC0-0x0000000182511D90 0x00000001825102C0-0x00000001825103A0
	public uint preview_reward_id { /* [XID] */ /* 0x00000001898267D0-0x00000001898267F0 */ get => default; /* [XID] */ /* 0x000000018982DF00-0x000000018982DF20 */ protected set {} } // 0x0000000182511BF0-0x0000000182511CC0 0x0000000182511300-0x00000001825113E0
	public uint start_quest_id { /* [XID] */ /* 0x0000000189835510-0x0000000189835530 */ get => default; /* [XID] */ /* 0x000000018983CD30-0x000000018983CD50 */ protected set {} } // 0x0000000182511B20-0x0000000182511BF0 0x0000000182511FC0-0x00000001825120A0
	public uint npc_id { /* [XID] */ /* 0x00000001898443C0-0x00000001898443E0 */ get => default; /* [XID] */ /* 0x000000018984B810-0x000000018984B830 */ protected set {} } // 0x0000000182511D90-0x0000000182511E60 0x00000001825103A0-0x0000000182510480
	public SimpleSafeUInt32[] medal_id { /* [XID] */ /* 0x00000001898528A0-0x00000001898528C0 */ get => default; /* [XID] */ /* 0x000000018985A350-0x000000018985A370 */ protected set {} } // 0x0000000182510050-0x00000001825100F0 0x0000000182511F10-0x0000000182511FC0
	public FlightDailyPointFactor[] daily_factor_vec { /* [XID] */ /* 0x0000000189861530-0x0000000189861550 */ get => default; /* [XID] */ /* 0x0000000189868D50-0x0000000189868D70 */ protected set {} } // 0x00000001825113E0-0x0000000182511480 0x0000000182511E60-0x0000000182511F10

	// Constructors
	public FlightActivityExcelConfig() {} // 0x0000000182512350-0x00000001825123B0

	// Methods
	// [IDTag] // 0x0000000189870120-0x0000000189870160
	// [XID] // 0x0000000189870120-0x0000000189870160
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182510480-0x0000000182510BB0
	// [IDTag] // 0x000000018987AD50-0x000000018987AD90
	// [XID] // 0x000000018987AD50-0x000000018987AD90
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182510BB0-0x0000000182511220
	// [XID] // 0x0000000189884C90-0x0000000189884CB0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0125 */, bool useObjectPool = false /* Metadata: 0x00AF0129 */) => default; // 0x0000000182511480-0x0000000182511B20
	[BlackList] // 0x000000018988C2C0-0x000000018988C300
	// [XID] // 0x000000018988C2C0-0x000000018988C300
	public virtual void AutoAllocTypeFields() {} // 0x00000001825100F0-0x0000000182510190
	[BlackList] // 0x00000001898966A0-0x00000001898966E0
	// [XID] // 0x00000001898966A0-0x00000001898966E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182510190-0x00000001825102C0
	[BlackList] // 0x00000001898A09F0-0x00000001898A0A30
	// [XID] // 0x00000001898A09F0-0x00000001898A0A30
	public virtual void ReturnToObjectPool() {} // 0x00000001825122B0-0x0000000182512350
	[BlackList] // 0x00000001898AAFA0-0x00000001898AAFE0
	// [XID] // 0x00000001898AAFA0-0x00000001898AAFE0
	public virtual void OnPoolAllocated() {} // 0x0000000182512140-0x00000001825121E0
	[BlackList] // 0x00000001898B59F0-0x00000001898B5A30
	// [XID] // 0x00000001898B59F0-0x00000001898B5A30
	public virtual void OnBeforePoolRecycled() {} // 0x00000001825120A0-0x0000000182512140
}

