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
public class ShopExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16109
{
	// Fields
	protected SimpleSafeUInt32 shopIdRawNum; // 0x10
	protected ShopType _shopType; // 0x14
	protected ShopRefreshType _refreshType; // 0x18
	protected SimpleSafeUInt32 refreshParamRawNum; // 0x1C
	protected OpenStateType _openStateType; // 0x20
	protected SimpleSafeUInt32 cityIdRawNum; // 0x24
	protected SimpleSafeUInt32 cityDiscountLevelRawNum; // 0x28
	protected SimpleSafeUInt32 scoinDiscountRateRawNum; // 0x2C
	protected SimpleSafeUInt32 vipFuncIDRawNum; // 0x30

	// Properties
	public uint shopId { /* [XID] */ /* 0x00000001896E2B80-0x00000001896E2BA0 */ get => default; /* [XID] */ /* 0x00000001896EA1E0-0x00000001896EA200 */ protected set {} } // 0x00000001827F0E40-0x00000001827F0F10 0x00000001827F24E0-0x00000001827F25C0
	public ShopType shopType { /* [XID] */ /* 0x00000001896F11E0-0x00000001896F1200 */ get => default; /* [XID] */ /* 0x00000001896F8AE0-0x00000001896F8B00 */ protected set {} } // 0x00000001827F2060-0x00000001827F2100 0x00000001827F12A0-0x00000001827F1350
	public ShopRefreshType refreshType { /* [XID] */ /* 0x00000001897002C0-0x00000001897002E0 */ get => default; /* [XID] */ /* 0x0000000189707B10-0x0000000189707B30 */ protected set {} } // 0x00000001827F2100-0x00000001827F21A0 0x00000001827F2430-0x00000001827F24E0
	public uint refreshParam { /* [XID] */ /* 0x000000018970F540-0x000000018970F560 */ get => default; /* [XID] */ /* 0x0000000189716920-0x0000000189716940 */ protected set {} } // 0x00000001827F2DA0-0x00000001827F2E70 0x00000001827F0FE0-0x00000001827F10C0
	public OpenStateType openStateType { /* [XID] */ /* 0x000000018971E360-0x000000018971E380 */ get => default; /* [XID] */ /* 0x00000001897258E0-0x0000000189725900 */ protected set {} } // 0x00000001827F1350-0x00000001827F13F0 0x00000001827F2E70-0x00000001827F2F20
	public uint cityId { /* [XID] */ /* 0x000000018972CDC0-0x000000018972CDE0 */ get => default; /* [XID] */ /* 0x0000000189734570-0x0000000189734590 */ protected set {} } // 0x00000001827F3000-0x00000001827F30D0 0x00000001827F21A0-0x00000001827F2280
	public uint cityDiscountLevel { /* [XID] */ /* 0x000000018973BF40-0x000000018973BF60 */ get => default; /* [XID] */ /* 0x0000000189743710-0x0000000189743730 */ protected set {} } // 0x00000001827F3210-0x00000001827F32E0 0x00000001827F2350-0x00000001827F2430
	public uint scoinDiscountRate { /* [XID] */ /* 0x000000018974B3A0-0x000000018974B3C0 */ get => default; /* [XID] */ /* 0x0000000189752530-0x0000000189752550 */ protected set {} } // 0x00000001827F0F10-0x00000001827F0FE0 0x00000001827F2F20-0x00000001827F3000
	public uint vipFuncID { /* [XID] */ /* 0x0000000189759AC0-0x0000000189759AE0 */ get => default; /* [XID] */ /* 0x0000000189761710-0x0000000189761730 */ protected set {} } // 0x00000001827F2280-0x00000001827F2350 0x00000001827F1F80-0x00000001827F2060

	// Constructors
	public ShopExcelConfig() {} // 0x00000001827F3380-0x00000001827F33E0

	// Methods
	// [IDTag] // 0x0000000189768AC0-0x0000000189768B00
	// [XID] // 0x0000000189768AC0-0x0000000189768B00
	public virtual bool ParseFromLine(string line) => default; // 0x00000001827F13F0-0x00000001827F19C0
	// [IDTag] // 0x0000000189773200-0x0000000189773240
	// [XID] // 0x0000000189773200-0x0000000189773240
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001827F19C0-0x00000001827F1F80
	// [XID] // 0x000000018977DAC0-0x000000018977DAE0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF316D */, bool useObjectPool = false /* Metadata: 0x00AF3171 */) => default; // 0x00000001827F25C0-0x00000001827F2DA0
	[BlackList] // 0x00000001897852A0-0x00000001897852E0
	// [XID] // 0x00000001897852A0-0x00000001897852E0
	public virtual void AutoAllocTypeFields() {} // 0x00000001827F10C0-0x00000001827F1160
	[BlackList] // 0x000000018978F6A0-0x000000018978F6E0
	// [XID] // 0x000000018978F6A0-0x000000018978F6E0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001827F1160-0x00000001827F12A0
	[BlackList] // 0x0000000189799D50-0x0000000189799D90
	// [XID] // 0x0000000189799D50-0x0000000189799D90
	public virtual void ReturnToObjectPool() {} // 0x00000001827F32E0-0x00000001827F3380
	[BlackList] // 0x00000001897A4E10-0x00000001897A4E50
	// [XID] // 0x00000001897A4E10-0x00000001897A4E50
	public virtual void OnPoolAllocated() {} // 0x00000001827F3170-0x00000001827F3210
	[BlackList] // 0x00000001897AF510-0x00000001897AF550
	// [XID] // 0x00000001897AF510-0x00000001897AF550
	public virtual void OnBeforePoolRecycled() {} // 0x00000001827F30D0-0x00000001827F3170
}

