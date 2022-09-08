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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class BlossomRefreshExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15269
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected string _icon; // 0x18
	protected uint _descTextMapHash; // 0x20
	protected SimpleSafeUInt32 cityIdRawNum; // 0x24
	protected BlossomRefreshType _refreshType; // 0x28
	protected SimpleSafeUInt32 refreshCountRawNum; // 0x2C
	protected string _refreshTime; // 0x30
	protected OpenStateType _openState; // 0x38
	protected SimpleSafeUInt32 openLevelRawNum; // 0x3C
	protected SimpleSafeUInt32 closeLevelRawNum; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected BlossomRefreshCond[] _refreshCondVec; // 0x48
	protected SimpleSafeUInt32 reviseLevelRawNum; // 0x50
	protected ItemLimitType _itemLimitType; // 0x54
	protected SimpleSafeUInt32 blossom_chest_idRawNum; // 0x58
	protected SimpleSafeUInt32 camp_update_need_countRawNum; // 0x5C
	protected SimpleSafeUInt32 roundMaxCountRawNum; // 0x60
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected BlossomRewardExcelConfig[] _dropVec; // 0x68
	protected BlossomShowType _clientShowType; // 0x70

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B92260-0x0000000189B92280 */ get => default; /* [XID] */ /* 0x0000000189B997E0-0x0000000189B99800 */ protected set {} } // 0x0000000183FE9ED0-0x0000000183FE9FA0 0x0000000183FE8470-0x0000000183FE8550
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189BA0DD0-0x0000000189BA0DF0 */ get => default; /* [XID] */ /* 0x0000000189BA8430-0x0000000189BA8450 */ protected set {} } // 0x0000000183FE5E30-0x0000000183FE5ED0 0x0000000183FE9920-0x0000000183FE99D0
	public string name { /* [XID] */ /* 0x0000000189BAF8C0-0x0000000189BAF8E0 */ get => default; } // 0x0000000183FEA040-0x0000000183FEA1C0 
	public string icon { /* [XID] */ /* 0x0000000189BB6ED0-0x0000000189BB6EF0 */ get => default; /* [XID] */ /* 0x0000000189BBE490-0x0000000189BBE4B0 */ protected set {} } // 0x0000000183FE5870-0x0000000183FE5910 0x0000000183FE99D0-0x0000000183FE9A80
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189BC6200-0x0000000189BC6220 */ get => default; /* [XID] */ /* 0x0000000189BCDDE0-0x0000000189BCDE00 */ protected set {} } // 0x0000000183FE97A0-0x0000000183FE9840 0x0000000183FE60E0-0x0000000183FE6190
	public string desc { /* [XID] */ /* 0x0000000189BD52D0-0x0000000189BD52F0 */ get => default; } // 0x0000000183FE82F0-0x0000000183FE8470 
	public uint cityId { /* [XID] */ /* 0x0000000189BDCE40-0x0000000189BDCE60 */ get => default; /* [XID] */ /* 0x00000001895E9710-0x00000001895E9730 */ protected set {} } // 0x0000000183FE9CC0-0x0000000183FE9D90 0x0000000183FE7EC0-0x0000000183FE7FA0
	public BlossomRefreshType refreshType { /* [XID] */ /* 0x00000001895F0EE0-0x00000001895F0F00 */ get => default; /* [XID] */ /* 0x00000001895F88F0-0x00000001895F8910 */ protected set {} } // 0x0000000183FE7E20-0x0000000183FE7EC0 0x0000000183FE8160-0x0000000183FE8210
	public uint refreshCount { /* [XID] */ /* 0x00000001895FFD50-0x00000001895FFD70 */ get => default; /* [XID] */ /* 0x0000000189607480-0x00000001896074A0 */ protected set {} } // 0x0000000183FE7BA0-0x0000000183FE7C70 0x0000000183FE9B30-0x0000000183FE9C10
	public string refreshTime { /* [XID] */ /* 0x000000018960EEE0-0x000000018960EF00 */ get => default; /* [XID] */ /* 0x0000000189616520-0x0000000189616540 */ protected set {} } // 0x0000000183FE5D90-0x0000000183FE5E30 0x0000000183FE9490-0x0000000183FE9540
	public OpenStateType openState { /* [XID] */ /* 0x000000018961DD90-0x000000018961DDB0 */ get => default; /* [XID] */ /* 0x00000001896251B0-0x00000001896251D0 */ protected set {} } // 0x0000000183FE6040-0x0000000183FE60E0 0x0000000183FE9A80-0x0000000183FE9B30
	public uint openLevel { /* [XID] */ /* 0x000000018962C9D0-0x000000018962C9F0 */ get => default; /* [XID] */ /* 0x0000000189634750-0x0000000189634770 */ protected set {} } // 0x0000000183FE5CC0-0x0000000183FE5D90 0x0000000183FE9840-0x0000000183FE9920
	public uint closeLevel { /* [XID] */ /* 0x000000018963BE80-0x000000018963BEA0 */ get => default; /* [XID] */ /* 0x0000000189643540-0x0000000189643560 */ protected set {} } // 0x0000000183FE8550-0x0000000183FE8620 0x0000000183FE7C70-0x0000000183FE7D50
	public BlossomRefreshCond[] refreshCondVec { /* [XID] */ /* 0x000000018964AB80-0x000000018964ABA0 */ get => default; /* [XID] */ /* 0x0000000189652340-0x0000000189652360 */ protected set {} } // 0x0000000183FE6190-0x0000000183FE6230 0x0000000183FE5910-0x0000000183FE59C0
	public uint reviseLevel { /* [XID] */ /* 0x0000000189659A30-0x0000000189659A50 */ get => default; /* [XID] */ /* 0x00000001896611B0-0x00000001896611D0 */ protected set {} } // 0x0000000183FE7D50-0x0000000183FE7E20 0x0000000183FE8080-0x0000000183FE8160
	public ItemLimitType itemLimitType { /* [XID] */ /* 0x0000000189668C40-0x0000000189668C60 */ get => default; /* [XID] */ /* 0x00000001896707B0-0x00000001896707D0 */ protected set {} } // 0x0000000183FE9FA0-0x0000000183FEA040 0x0000000183FE5C10-0x0000000183FE5CC0
	public uint blossom_chest_id { /* [XID] */ /* 0x0000000189677FD0-0x0000000189677FF0 */ get => default; /* [XID] */ /* 0x000000018967F6A0-0x000000018967F6C0 */ protected set {} } // 0x0000000183FE95F0-0x0000000183FE96C0 0x0000000183FE96C0-0x0000000183FE97A0
	public uint camp_update_need_count { /* [XID] */ /* 0x0000000189686F50-0x0000000189686F70 */ get => default; /* [XID] */ /* 0x000000018968ED50-0x000000018968ED70 */ protected set {} } // 0x0000000183FE5ED0-0x0000000183FE5FA0 0x0000000183FE7FA0-0x0000000183FE8080
	public uint roundMaxCount { /* [XID] */ /* 0x00000001896966B0-0x00000001896966D0 */ get => default; /* [XID] */ /* 0x000000018969DD30-0x000000018969DD50 */ protected set {} } // 0x0000000183FEA1C0-0x0000000183FEA290 0x0000000183FE8210-0x0000000183FE82F0
	public BlossomRewardExcelConfig[] dropVec { /* [XID] */ /* 0x00000001896A4D20-0x00000001896A4D40 */ get => default; /* [XID] */ /* 0x00000001896AC5D0-0x00000001896AC5F0 */ protected set {} } // 0x0000000183FE57D0-0x0000000183FE5870 0x0000000183FE9540-0x0000000183FE95F0
	public BlossomShowType clientShowType { /* [XID] */ /* 0x00000001896B3810-0x00000001896B3830 */ get => default; /* [XID] */ /* 0x00000001896BAF10-0x00000001896BAF30 */ protected set {} } // 0x0000000183FE5FA0-0x0000000183FE6040 0x0000000183FE9C10-0x0000000183FE9CC0

	// Constructors
	public BlossomRefreshExcelConfig() {} // 0x0000000183FEA330-0x0000000183FEA390

	// Methods
	// [IDTag] // 0x00000001896C20A0-0x00000001896C20E0
	// [XID] // 0x00000001896C20A0-0x00000001896C20E0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183FE6E50-0x0000000183FE7BA0
	// [IDTag] // 0x00000001896CC870-0x00000001896CC8B0
	// [XID] // 0x00000001896CC870-0x00000001896CC8B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183FE6230-0x0000000183FE6E50
	// [XID] // 0x00000001896D6D60-0x00000001896D6D80
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF05CD */, bool useObjectPool = false /* Metadata: 0x00AF05D1 */) => default; // 0x0000000183FE8620-0x0000000183FE9490
	[BlackList] // 0x00000001896DE4E0-0x00000001896DE520
	// [XID] // 0x00000001896DE4E0-0x00000001896DE520
	public virtual void AutoAllocTypeFields() {} // 0x0000000183FE59C0-0x0000000183FE5A60
	[BlackList] // 0x00000001896E8960-0x00000001896E89A0
	// [XID] // 0x00000001896E8960-0x00000001896E89A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183FE5A60-0x0000000183FE5C10
	[BlackList] // 0x00000001896F2EF0-0x00000001896F2F30
	// [XID] // 0x00000001896F2EF0-0x00000001896F2F30
	public virtual void ReturnToObjectPool() {} // 0x0000000183FEA290-0x0000000183FEA330
	[BlackList] // 0x00000001896FD890-0x00000001896FD8D0
	// [XID] // 0x00000001896FD890-0x00000001896FD8D0
	public virtual void OnPoolAllocated() {} // 0x0000000183FE9E30-0x0000000183FE9ED0
	[BlackList] // 0x0000000189707CD0-0x0000000189707D10
	// [XID] // 0x0000000189707CD0-0x0000000189707D10
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183FE9D90-0x0000000183FE9E30
}

