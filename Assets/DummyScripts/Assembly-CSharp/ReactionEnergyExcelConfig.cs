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
public class ReactionEnergyExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15563
{
	// Fields
	protected ElementReactionType _type; // 0x10
	protected SimpleSafeFloat minDurabilityRawNum; // 0x14
	protected SimpleSafeFloat maxDurabilityRawNum; // 0x18
	protected SimpleSafeFloat costRatioRawNum; // 0x1C
	protected SimpleSafeUInt32 configIDRawNum; // 0x20
	protected SimpleSafeFloat poolSizeRawNum; // 0x24
	protected SimpleSafeFloat poolRevivePeriodRawNum; // 0x28
	protected SimpleSafeFloat poolReviveEnergyRawNum; // 0x2C
	protected bool _isPersistent; // 0x30
	protected SimpleSafeFloat costPeriodRawNum; // 0x34
	protected SimpleSafeUInt32 dropProbRawNum; // 0x38

	// Properties
	public ElementReactionType type { /* [XID] */ /* 0x0000000189B466E0-0x0000000189B46700 */ get => default; /* [XID] */ /* 0x0000000189B4DC60-0x0000000189B4DC80 */ protected set {} } // 0x0000000182D22970-0x0000000182D22A10 0x0000000182D224E0-0x0000000182D22590
	public float minDurability { /* [XID] */ /* 0x0000000189B554B0-0x0000000189B554D0 */ get => default; /* [XID] */ /* 0x0000000189B5CDF0-0x0000000189B5CE10 */ protected set {} } // 0x0000000182D21690-0x0000000182D21770 0x0000000182D214D0-0x0000000182D215B0
	public float maxDurability { /* [XID] */ /* 0x0000000189B644D0-0x0000000189B644F0 */ get => default; /* [XID] */ /* 0x0000000189B6BA10-0x0000000189B6BA30 */ protected set {} } // 0x0000000182D22670-0x0000000182D22750 0x0000000182D22170-0x0000000182D22250
	public float costRatio { /* [XID] */ /* 0x0000000189B732F0-0x0000000189B73310 */ get => default; /* [XID] */ /* 0x0000000189B7A7F0-0x0000000189B7A810 */ protected set {} } // 0x0000000182D22750-0x0000000182D22830 0x0000000182D202B0-0x0000000182D20390
	public uint configID { /* [XID] */ /* 0x0000000189B81FF0-0x0000000189B82010 */ get => default; /* [XID] */ /* 0x0000000189B897F0-0x0000000189B89810 */ protected set {} } // 0x0000000182D20100-0x0000000182D201D0 0x0000000182D1FDF0-0x0000000182D1FED0
	public float poolSize { /* [XID] */ /* 0x0000000189B90D50-0x0000000189B90D70 */ get => default; /* [XID] */ /* 0x0000000189B980C0-0x0000000189B980E0 */ protected set {} } // 0x0000000182D22590-0x0000000182D22670 0x0000000182D21310-0x0000000182D213F0
	public float poolRevivePeriod { /* [XID] */ /* 0x0000000189B9F510-0x0000000189B9F530 */ get => default; /* [XID] */ /* 0x0000000189BA6D40-0x0000000189BA6D60 */ protected set {} } // 0x0000000182D213F0-0x0000000182D214D0 0x0000000182D21230-0x0000000182D21310
	public float poolReviveEnergy { /* [XID] */ /* 0x0000000189BADEE0-0x0000000189BADF00 */ get => default; /* [XID] */ /* 0x0000000189BB5770-0x0000000189BB5790 */ protected set {} } // 0x0000000182D22400-0x0000000182D224E0 0x0000000182D21150-0x0000000182D21230
	public bool isPersistent { /* [XID] */ /* 0x0000000189BBCE20-0x0000000189BBCE40 */ get => default; /* [XID] */ /* 0x0000000189BC4AE0-0x0000000189BC4B00 */ protected set {} } // 0x0000000182D210B0-0x0000000182D21150 0x0000000182D21770-0x0000000182D21820
	public float costPeriod { /* [XID] */ /* 0x0000000189BCC560-0x0000000189BCC580 */ get => default; /* [XID] */ /* 0x0000000189BD3C10-0x0000000189BD3C30 */ protected set {} } // 0x0000000182D22320-0x0000000182D22400 0x0000000182D215B0-0x0000000182D21690
	public uint dropProb { /* [XID] */ /* 0x0000000189BDB4C0-0x0000000189BDB4E0 */ get => default; /* [XID] */ /* 0x00000001895E7DD0-0x00000001895E7DF0 */ protected set {} } // 0x0000000182D22250-0x0000000182D22320 0x0000000182D201D0-0x0000000182D202B0

	// Constructors
	public ReactionEnergyExcelConfig() {} // 0x0000000182D22AB0-0x0000000182D22B10

	// Methods
	// [IDTag] // 0x00000001895EF740-0x00000001895EF780
	// [XID] // 0x00000001895EF740-0x00000001895EF780
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182D20390-0x0000000182D20A20
	// [IDTag] // 0x00000001895F9EA0-0x00000001895F9EE0
	// [XID] // 0x00000001895F9EA0-0x00000001895F9EE0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182D20A20-0x0000000182D210B0
	// [XID] // 0x0000000189604630-0x0000000189604650
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1F2F */, bool useObjectPool = false /* Metadata: 0x00AF1F33 */) => default; // 0x0000000182D21820-0x0000000182D22170
	[BlackList] // 0x000000018960BF20-0x000000018960BF60
	// [XID] // 0x000000018960BF20-0x000000018960BF60
	public virtual void AutoAllocTypeFields() {} // 0x0000000182D1FED0-0x0000000182D1FF70
	[BlackList] // 0x00000001896164A0-0x00000001896164E0
	// [XID] // 0x00000001896164A0-0x00000001896164E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182D1FF70-0x0000000182D20100
	[BlackList] // 0x0000000189620C20-0x0000000189620C60
	// [XID] // 0x0000000189620C20-0x0000000189620C60
	public virtual void ReturnToObjectPool() {} // 0x0000000182D22A10-0x0000000182D22AB0
	[BlackList] // 0x000000018962B300-0x000000018962B340
	// [XID] // 0x000000018962B300-0x000000018962B340
	public virtual void OnPoolAllocated() {} // 0x0000000182D228D0-0x0000000182D22970
	[BlackList] // 0x0000000189635F50-0x0000000189635F90
	// [XID] // 0x0000000189635F50-0x0000000189635F90
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182D22830-0x0000000182D228D0
}

