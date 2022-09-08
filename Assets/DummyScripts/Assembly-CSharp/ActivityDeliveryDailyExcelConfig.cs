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
public class ActivityDeliveryDailyExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15057
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 dailyConfigIdRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected DeliveryQuestConfig[] _deliveryQuestConfig; // 0x18
	protected uint[] _taskDesc; // 0x20
	protected SimpleSafeUInt32 dailyRewardIdRawNum; // 0x28

	// Properties
	public uint dailyConfigId { /* [XID] */ /* 0x0000000189A83900-0x0000000189A83920 */ get => default; /* [XID] */ /* 0x0000000189A8B100-0x0000000189A8B120 */ protected set {} } // 0x00000001820B4000-0x00000001820B40D0 0x00000001820B2720-0x00000001820B2800
	public DeliveryQuestConfig[] deliveryQuestConfig { /* [XID] */ /* 0x0000000189A92910-0x0000000189A92930 */ get => default; /* [XID] */ /* 0x0000000189A9A280-0x0000000189A9A2A0 */ protected set {} } // 0x00000001820B3310-0x00000001820B33B0 0x00000001820B2800-0x00000001820B28B0
	public uint[] taskDesc { /* [XID] */ /* 0x0000000189AA1380-0x0000000189AA13A0 */ get => default; /* [XID] */ /* 0x0000000189AA8AC0-0x0000000189AA8AE0 */ protected set {} } // 0x00000001820B39E0-0x00000001820B3A80 0x00000001820B33B0-0x00000001820B3460
	public string[] taskDescLocalized { /* [XID] */ /* 0x0000000189AB06A0-0x0000000189AB06C0 */ get => default; } // 0x00000001820B3B60-0x00000001820B3EC0 
	public uint dailyRewardId { /* [XID] */ /* 0x0000000189AB7D00-0x0000000189AB7D20 */ get => default; /* [XID] */ /* 0x0000000189ABF790-0x0000000189ABF7B0 */ protected set {} } // 0x00000001820B3460-0x00000001820B3530 0x00000001820B3A80-0x00000001820B3B60

	// Constructors
	public ActivityDeliveryDailyExcelConfig() {} // 0x00000001820B4170-0x00000001820B41D0

	// Methods
	// [IDTag] // 0x0000000189AC7160-0x0000000189AC71A0
	// [XID] // 0x0000000189AC7160-0x0000000189AC71A0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001820B28B0-0x00000001820B2E30
	// [IDTag] // 0x0000000189AD19B0-0x0000000189AD19F0
	// [XID] // 0x0000000189AD19B0-0x0000000189AD19F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001820B2E30-0x00000001820B3310
	// [XID] // 0x0000000189ADC800-0x0000000189ADC820
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFF9B */, bool useObjectPool = false /* Metadata: 0x00AEFF9F */) => default; // 0x00000001820B3530-0x00000001820B39E0
	[BlackList] // 0x0000000189AE4150-0x0000000189AE4190
	// [XID] // 0x0000000189AE4150-0x0000000189AE4190
	public virtual void AutoAllocTypeFields() {} // 0x00000001820B2590-0x00000001820B2630
	[BlackList] // 0x0000000189AEEC80-0x0000000189AEECC0
	// [XID] // 0x0000000189AEEC80-0x0000000189AEECC0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001820B2630-0x00000001820B2720
	[BlackList] // 0x0000000189AF93F0-0x0000000189AF9430
	// [XID] // 0x0000000189AF93F0-0x0000000189AF9430
	public virtual void ReturnToObjectPool() {} // 0x00000001820B40D0-0x00000001820B4170
	[BlackList] // 0x0000000189B03770-0x0000000189B037B0
	// [XID] // 0x0000000189B03770-0x0000000189B037B0
	public virtual void OnPoolAllocated() {} // 0x00000001820B3F60-0x00000001820B4000
	[BlackList] // 0x0000000189B0DF30-0x0000000189B0DF70
	// [XID] // 0x0000000189B0DF30-0x0000000189B0DF70
	public virtual void OnBeforePoolRecycled() {} // 0x00000001820B3EC0-0x00000001820B3F60
}

