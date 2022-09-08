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
public class CoopRewardExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15461
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected CoopCondConfig[] _rewardCond; // 0x18
	protected SimpleSafeUInt32 chapterIdRawNum; // 0x20
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x24
	protected SimpleSafeUInt32 sortIdRawNum; // 0x28
	protected uint _condTipTextMapHash; // 0x2C
	protected uint _condTipDesTextMapHash; // 0x30

	// Properties
	public uint id { /* [XID] */ /* 0x00000001898F82F0-0x00000001898F8310 */ get => default; /* [XID] */ /* 0x00000001898FF970-0x00000001898FF990 */ protected set {} } // 0x00000001845D22B0-0x00000001845D2380 0x00000001845D1510-0x00000001845D15F0
	public CoopCondConfig[] rewardCond { /* [XID] */ /* 0x0000000189907210-0x0000000189907230 */ get => default; /* [XID] */ /* 0x000000018990EB90-0x000000018990EBB0 */ protected set {} } // 0x00000001845D1F80-0x00000001845D2020 0x00000001845D1D50-0x00000001845D1E00
	public uint chapterId { /* [XID] */ /* 0x0000000189916300-0x0000000189916320 */ get => default; /* [XID] */ /* 0x000000018991DC30-0x000000018991DC50 */ protected set {} } // 0x00000001845D11F0-0x00000001845D12C0 0x00000001845D0590-0x00000001845D0670
	public uint rewardId { /* [XID] */ /* 0x00000001899253E0-0x0000000189925400 */ get => default; /* [XID] */ /* 0x000000018992C980-0x000000018992C9A0 */ protected set {} } // 0x00000001845D1C80-0x00000001845D1D50 0x00000001845D0170-0x00000001845D0250
	public uint sortId { /* [XID] */ /* 0x0000000189933FA0-0x0000000189933FC0 */ get => default; /* [XID] */ /* 0x000000018993BBD0-0x000000018993BBF0 */ protected set {} } // 0x00000001845D13A0-0x00000001845D1470 0x00000001845D12C0-0x00000001845D13A0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint condTipTextMapHash { /* [XID] */ /* 0x0000000189942D30-0x0000000189942D50 */ get => default; /* [XID] */ /* 0x000000018994A5C0-0x000000018994A5E0 */ protected set {} } // 0x00000001845D20D0-0x00000001845D2170 0x00000001845D2020-0x00000001845D20D0
	public string condTip { /* [XID] */ /* 0x0000000189952010-0x0000000189952030 */ get => default; } // 0x00000001845D1E00-0x00000001845D1F80 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint condTipDesTextMapHash { /* [XID] */ /* 0x0000000189959570-0x0000000189959590 */ get => default; /* [XID] */ /* 0x0000000189960E40-0x0000000189960E60 */ protected set {} } // 0x00000001845D1470-0x00000001845D1510 0x00000001845D00C0-0x00000001845D0170
	public string condTipDes { /* [XID] */ /* 0x0000000189968580-0x00000001899685A0 */ get => default; } // 0x00000001845D0250-0x00000001845D03D0 

	// Constructors
	public CoopRewardExcelConfig() {} // 0x00000001845D2420-0x00000001845D2480

	// Methods
	// [IDTag] // 0x000000018996FA60-0x000000018996FAA0
	// [XID] // 0x000000018996FA60-0x000000018996FAA0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001845D0670-0x00000001845D0C90
	// [IDTag] // 0x000000018997A7B0-0x000000018997A7F0
	// [XID] // 0x000000018997A7B0-0x000000018997A7F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001845D0C90-0x00000001845D11F0
	// [XID] // 0x0000000189984BD0-0x0000000189984BF0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1B27 */, bool useObjectPool = false /* Metadata: 0x00AF1B2B */) => default; // 0x00000001845D15F0-0x00000001845D1C80
	[BlackList] // 0x000000018998C7D0-0x000000018998C810
	// [XID] // 0x000000018998C7D0-0x000000018998C810
	public virtual void AutoAllocTypeFields() {} // 0x00000001845D03D0-0x00000001845D0470
	[BlackList] // 0x0000000189997200-0x0000000189997240
	// [XID] // 0x0000000189997200-0x0000000189997240
	public virtual void AutoRecycleTypeFields() {} // 0x00000001845D0470-0x00000001845D0590
	[BlackList] // 0x00000001899A1E50-0x00000001899A1E90
	// [XID] // 0x00000001899A1E50-0x00000001899A1E90
	public virtual void ReturnToObjectPool() {} // 0x00000001845D2380-0x00000001845D2420
	[BlackList] // 0x00000001899AC9B0-0x00000001899AC9F0
	// [XID] // 0x00000001899AC9B0-0x00000001899AC9F0
	public virtual void OnPoolAllocated() {} // 0x00000001845D2210-0x00000001845D22B0
	[BlackList] // 0x00000001899B6C30-0x00000001899B6C70
	// [XID] // 0x00000001899B6C30-0x00000001899B6C70
	public virtual void OnBeforePoolRecycled() {} // 0x00000001845D2170-0x00000001845D2210
}

