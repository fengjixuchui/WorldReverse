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
public class HomeworldLevelExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15718
{
	// Fields
	protected SimpleSafeUInt32 levelRawNum; // 0x10
	protected SimpleSafeUInt32 expRawNum; // 0x14
	protected SimpleSafeUInt32 comfortPointLimitRawNum; // 0x18
	protected SimpleSafeUInt32 homeCoinStoreLimitRawNum; // 0x1C
	protected SimpleSafeUInt32 homeFetterExpStoreLimitRawNum; // 0x20
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x24
	protected SimpleSafeUInt32 furnitureMakeSlotCountRawNum; // 0x28
	protected SimpleSafeUInt32 outdoorUnlockBlockCountRawNum; // 0x2C
	protected SimpleSafeUInt32 freeUnlockModuleCountRawNum; // 0x30
	protected SimpleSafeUInt32 deployNpcCountRawNum; // 0x34
	protected SimpleSafeUInt32 djinnGadgetIdRawNum; // 0x38
	protected SimpleSafeUInt32 limitShopGoodsCountRawNum; // 0x3C
	protected SimpleSafeUInt32 limitShopGoodsExtraCountRawNum; // 0x40
	protected string[] _levelFuncs; // 0x48

	// Properties
	public uint level { /* [XID] */ /* 0x0000000189A27D40-0x0000000189A27D60 */ get => default; /* [XID] */ /* 0x0000000189A2F3D0-0x0000000189A2F3F0 */ protected set {} } // 0x000000018235D910-0x000000018235D9E0 0x000000018235D830-0x000000018235D910
	public uint exp { /* [XID] */ /* 0x0000000189A36E50-0x0000000189A36E70 */ get => default; /* [XID] */ /* 0x0000000189A3E4B0-0x0000000189A3E4D0 */ protected set {} } // 0x000000018235DC40-0x000000018235DD10 0x000000018235C730-0x000000018235C810
	public uint comfortPointLimit { /* [XID] */ /* 0x0000000189A45B00-0x0000000189A45B20 */ get => default; /* [XID] */ /* 0x0000000189A4D2C0-0x0000000189A4D2E0 */ protected set {} } // 0x000000018235DB70-0x000000018235DC40 0x000000018235AFA0-0x000000018235B080
	public uint homeCoinStoreLimit { /* [XID] */ /* 0x0000000189A54A10-0x0000000189A54A30 */ get => default; /* [XID] */ /* 0x0000000189A5C480-0x0000000189A5C4A0 */ protected set {} } // 0x000000018235E070-0x000000018235E140 0x000000018235C650-0x000000018235C730
	public uint homeFetterExpStoreLimit { /* [XID] */ /* 0x0000000189A63DB0-0x0000000189A63DD0 */ get => default; /* [XID] */ /* 0x0000000189A6B6B0-0x0000000189A6B6D0 */ protected set {} } // 0x000000018235AD60-0x000000018235AE30 0x000000018235DF90-0x000000018235E070
	public uint rewardId { /* [XID] */ /* 0x0000000189A72E00-0x0000000189A72E20 */ get => default; /* [XID] */ /* 0x0000000189A7A9D0-0x0000000189A7A9F0 */ protected set {} } // 0x000000018235D760-0x000000018235D830 0x000000018235A950-0x000000018235AA30
	public uint furnitureMakeSlotCount { /* [XID] */ /* 0x0000000189A81E70-0x0000000189A81E90 */ get => default; /* [XID] */ /* 0x0000000189A898F0-0x0000000189A89910 */ protected set {} } // 0x000000018235DEC0-0x000000018235DF90 0x000000018235C9C0-0x000000018235CAA0
	public uint outdoorUnlockBlockCount { /* [XID] */ /* 0x0000000189A90FF0-0x0000000189A91010 */ get => default; /* [XID] */ /* 0x0000000189A98940-0x0000000189A98960 */ protected set {} } // 0x000000018235C810-0x000000018235C8E0 0x000000018235CAA0-0x000000018235CB80
	public uint freeUnlockModuleCount { /* [XID] */ /* 0x0000000189A9FCF0-0x0000000189A9FD10 */ get => default; /* [XID] */ /* 0x0000000189AA7460-0x0000000189AA7480 */ protected set {} } // 0x000000018235AE30-0x000000018235AF00 0x000000018235C8E0-0x000000018235C9C0
	public uint deployNpcCount { /* [XID] */ /* 0x0000000189AAEB80-0x0000000189AAEBA0 */ get => default; /* [XID] */ /* 0x0000000189AB6500-0x0000000189AB6520 */ protected set {} } // 0x000000018235CB80-0x000000018235CC50 0x000000018235D9E0-0x000000018235DAC0
	public uint djinnGadgetId { /* [XID] */ /* 0x0000000189ABDFD0-0x0000000189ABDFF0 */ get => default; /* [XID] */ /* 0x0000000189AC5AF0-0x0000000189AC5B10 */ protected set {} } // 0x000000018235C3C0-0x000000018235C490 0x000000018235C570-0x000000018235C650
	public uint limitShopGoodsCount { /* [XID] */ /* 0x0000000189ACD080-0x0000000189ACD0A0 */ get => default; /* [XID] */ /* 0x0000000189AD4DE0-0x0000000189AD4E00 */ protected set {} } // 0x000000018235DD10-0x000000018235DDE0 0x000000018235DDE0-0x000000018235DEC0
	public uint limitShopGoodsExtraCount { /* [XID] */ /* 0x0000000189ADC6E0-0x0000000189ADC700 */ get => default; /* [XID] */ /* 0x0000000189AE4010-0x0000000189AE4030 */ protected set {} } // 0x000000018235AC90-0x000000018235AD60 0x000000018235C490-0x000000018235C570
	public string[] levelFuncs { /* [XID] */ /* 0x0000000189AEB8B0-0x0000000189AEB8D0 */ get => default; /* [XID] */ /* 0x0000000189AF3250-0x0000000189AF3270 */ protected set {} } // 0x000000018235AF00-0x000000018235AFA0 0x000000018235DAC0-0x000000018235DB70

	// Constructors
	public HomeworldLevelExcelConfig() {} // 0x000000018235E320-0x000000018235E380

	// Methods
	// [IDTag] // 0x0000000189AFAAA0-0x0000000189AFAAE0
	// [XID] // 0x0000000189AFAAA0-0x0000000189AFAAE0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018235B080-0x000000018235BA10
	// [IDTag] // 0x0000000189B04E00-0x0000000189B04E40
	// [XID] // 0x0000000189B04E00-0x0000000189B04E40
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018235BA10-0x000000018235C3C0
	// [XID] // 0x0000000189B0F5D0-0x0000000189B0F5F0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF241D */, bool useObjectPool = false /* Metadata: 0x00AF2421 */) => default; // 0x000000018235CC50-0x000000018235D760
	[BlackList] // 0x0000000189B168F0-0x0000000189B16930
	// [XID] // 0x0000000189B168F0-0x0000000189B16930
	public virtual void AutoAllocTypeFields() {} // 0x000000018235AA30-0x000000018235AAD0
	[BlackList] // 0x0000000189B20ED0-0x0000000189B20F10
	// [XID] // 0x0000000189B20ED0-0x0000000189B20F10
	public virtual void AutoRecycleTypeFields() {} // 0x000000018235AAD0-0x000000018235AC90
	[BlackList] // 0x0000000189B2B5B0-0x0000000189B2B5F0
	// [XID] // 0x0000000189B2B5B0-0x0000000189B2B5F0
	public virtual void ReturnToObjectPool() {} // 0x000000018235E280-0x000000018235E320
	[BlackList] // 0x0000000189B357E0-0x0000000189B35820
	// [XID] // 0x0000000189B357E0-0x0000000189B35820
	public virtual void OnPoolAllocated() {} // 0x000000018235E1E0-0x000000018235E280
	[BlackList] // 0x0000000189B40380-0x0000000189B403C0
	// [XID] // 0x0000000189B40380-0x0000000189B403C0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018235E140-0x000000018235E1E0
}

