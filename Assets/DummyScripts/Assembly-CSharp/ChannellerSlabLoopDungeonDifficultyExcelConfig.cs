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
public class ChannellerSlabLoopDungeonDifficultyExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15049
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 dungeonIdRawNum; // 0x14
	protected SimpleSafeUInt32 stageIdRawNum; // 0x18
	protected ChannellerSlabDifficulty _difficulty; // 0x1C
	protected SimpleSafeUInt32 monsterLevelRawNum; // 0x20
	protected SimpleSafeFloat scoreRatioRawNum; // 0x24
	protected SimpleSafeUInt32 baseScoreRawNum; // 0x28

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B5B710-0x0000000189B5B730 */ get => default; /* [XID] */ /* 0x0000000189B62B00-0x0000000189B62B20 */ protected set {} } // 0x0000000182CC40A0-0x0000000182CC4170 0x0000000182CC3310-0x0000000182CC33F0
	public uint dungeonId { /* [XID] */ /* 0x0000000189B6A610-0x0000000189B6A630 */ get => default; /* [XID] */ /* 0x0000000189B71DB0-0x0000000189B71DD0 */ protected set {} } // 0x0000000182CC3B30-0x0000000182CC3C00 0x0000000182CC4220-0x0000000182CC4300
	public uint stageId { /* [XID] */ /* 0x0000000189B79140-0x0000000189B79160 */ get => default; /* [XID] */ /* 0x0000000189B805D0-0x0000000189B805F0 */ protected set {} } // 0x0000000182CC3080-0x0000000182CC3150 0x0000000182CC3CE0-0x0000000182CC3DC0
	public ChannellerSlabDifficulty difficulty { /* [XID] */ /* 0x0000000189B881A0-0x0000000189B881C0 */ get => default; /* [XID] */ /* 0x0000000189B8F470-0x0000000189B8F490 */ protected set {} } // 0x0000000182CC3A90-0x0000000182CC3B30 0x0000000182CC4170-0x0000000182CC4220
	public uint monsterLevel { /* [XID] */ /* 0x0000000189B96890-0x0000000189B968B0 */ get => default; /* [XID] */ /* 0x0000000189B9DDE0-0x0000000189B9DE00 */ protected set {} } // 0x0000000182CC3DC0-0x0000000182CC3E90 0x0000000182CC3C00-0x0000000182CC3CE0
	public float scoreRatio { /* [XID] */ /* 0x0000000189BA5770-0x0000000189BA5790 */ get => default; /* [XID] */ /* 0x0000000189BAC990-0x0000000189BAC9B0 */ protected set {} } // 0x0000000182CC2630-0x0000000182CC2710 0x0000000182CC3150-0x0000000182CC3230
	public uint baseScore { /* [XID] */ /* 0x0000000189BB4230-0x0000000189BB4250 */ get => default; /* [XID] */ /* 0x0000000189BBB890-0x0000000189BBB8B0 */ protected set {} } // 0x0000000182CC3E90-0x0000000182CC3F60 0x0000000182CC3230-0x0000000182CC3310

	// Constructors
	public ChannellerSlabLoopDungeonDifficultyExcelConfig() {} // 0x0000000182CC43A0-0x0000000182CC4400

	// Methods
	// [IDTag] // 0x0000000189BC3710-0x0000000189BC3750
	// [XID] // 0x0000000189BC3710-0x0000000189BC3750
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182CC2710-0x0000000182CC2BD0
	// [IDTag] // 0x0000000189BCDE80-0x0000000189BCDEC0
	// [XID] // 0x0000000189BCDE80-0x0000000189BCDEC0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182CC2BD0-0x0000000182CC3080
	// [XID] // 0x0000000189BD8130-0x0000000189BD8150
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFF64 */, bool useObjectPool = false /* Metadata: 0x00AEFF68 */) => default; // 0x0000000182CC33F0-0x0000000182CC3A90
	[BlackList] // 0x0000000189BDFC60-0x0000000189BDFCA0
	// [XID] // 0x0000000189BDFC60-0x0000000189BDFCA0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182CC2430-0x0000000182CC24D0
	[BlackList] // 0x00000001895EF880-0x00000001895EF8C0
	// [XID] // 0x00000001895EF880-0x00000001895EF8C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182CC24D0-0x0000000182CC2630
	[BlackList] // 0x00000001895F9FE0-0x00000001895FA020
	// [XID] // 0x00000001895F9FE0-0x00000001895FA020
	public virtual void ReturnToObjectPool() {} // 0x0000000182CC4300-0x0000000182CC43A0
	[BlackList] // 0x0000000189604750-0x0000000189604790
	// [XID] // 0x0000000189604750-0x0000000189604790
	public virtual void OnPoolAllocated() {} // 0x0000000182CC4000-0x0000000182CC40A0
	[BlackList] // 0x000000018960EF80-0x000000018960EFC0
	// [XID] // 0x000000018960EF80-0x000000018960EFC0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182CC3F60-0x0000000182CC4000
}

