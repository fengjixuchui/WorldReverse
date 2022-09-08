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
public class LampPhaseExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15176
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 phaseIdRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected SimpleSafeUInt32 endProgressRawNum; // 0x18
	protected SimpleSafeUInt32[] _materialVec; // 0x20
	protected SimpleSafeUInt32 GivingIdRawNum; // 0x28
	protected SimpleSafeUInt32 contributionRawNum; // 0x2C
	protected SimpleSafeUInt32 addProgressRawNum; // 0x30
	protected bool _isDisplay; // 0x34
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x38
	protected SimpleSafeUInt32 notifyGroupIdRawNum; // 0x3C
	protected SimpleSafeUInt32 gadgetIdRawNum; // 0x40

	// Properties
	public uint phaseId { /* [XID] */ /* 0x00000001896BF230-0x00000001896BF250 */ get => default; /* [XID] */ /* 0x00000001896C6AB0-0x00000001896C6AD0 */ protected set {} } // 0x0000000182AF77E0-0x0000000182AF78B0 0x0000000182AF7700-0x0000000182AF77E0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x00000001896CE230-0x00000001896CE250 */ get => default; /* [XID] */ /* 0x00000001896D57E0-0x00000001896D5800 */ protected set {} } // 0x0000000182AF5170-0x0000000182AF5210 0x0000000182AF78B0-0x0000000182AF7960
	public string name { /* [XID] */ /* 0x00000001896DCC00-0x00000001896DCC20 */ get => default; } // 0x0000000182AF7C50-0x0000000182AF7DD0 
	public uint endProgress { /* [XID] */ /* 0x00000001896E45D0-0x00000001896E45F0 */ get => default; /* [XID] */ /* 0x00000001896EB9C0-0x00000001896EB9E0 */ protected set {} } // 0x0000000182AF6480-0x0000000182AF6550 0x0000000182AF66D0-0x0000000182AF67B0
	public SimpleSafeUInt32[] materialVec { /* [XID] */ /* 0x00000001896F2F30-0x00000001896F2F50 */ get => default; /* [XID] */ /* 0x00000001896FA750-0x00000001896FA770 */ protected set {} } // 0x0000000182AF6B90-0x0000000182AF6C30 0x0000000182AF67B0-0x0000000182AF6860
	public uint GivingId { /* [XID] */ /* 0x0000000189701DE0-0x0000000189701E00 */ get => default; /* [XID] */ /* 0x00000001897096C0-0x00000001897096E0 */ protected set {} } // 0x0000000182AF6AC0-0x0000000182AF6B90 0x0000000182AF6550-0x0000000182AF6630
	public uint contribution { /* [XID] */ /* 0x0000000189710F70-0x0000000189710F90 */ get => default; /* [XID] */ /* 0x0000000189718350-0x0000000189718370 */ protected set {} } // 0x0000000182AF50A0-0x0000000182AF5170 0x0000000182AF6C30-0x0000000182AF6D10
	public uint addProgress { /* [XID] */ /* 0x000000018971FCB0-0x000000018971FCD0 */ get => default; /* [XID] */ /* 0x0000000189727340-0x0000000189727360 */ protected set {} } // 0x0000000182AF7960-0x0000000182AF7A30 0x0000000182AF5210-0x0000000182AF52F0
	public bool isDisplay { /* [XID] */ /* 0x000000018972E8F0-0x000000018972E910 */ get => default; /* [XID] */ /* 0x0000000189736060-0x0000000189736080 */ protected set {} } // 0x0000000182AF6630-0x0000000182AF66D0 0x0000000182AF6940-0x0000000182AF69F0
	public uint rewardId { /* [XID] */ /* 0x000000018973DD30-0x000000018973DD50 */ get => default; /* [XID] */ /* 0x0000000189745170-0x0000000189745190 */ protected set {} } // 0x0000000182AF7630-0x0000000182AF7700 0x0000000182AF4DC0-0x0000000182AF4EA0
	public uint notifyGroupId { /* [XID] */ /* 0x000000018974CC20-0x000000018974CC40 */ get => default; /* [XID] */ /* 0x0000000189753FE0-0x0000000189754000 */ protected set {} } // 0x0000000182AF63B0-0x0000000182AF6480 0x0000000182AF7A30-0x0000000182AF7B10
	public uint gadgetId { /* [XID] */ /* 0x000000018975B4A0-0x000000018975B4C0 */ get => default; /* [XID] */ /* 0x0000000189762ED0-0x0000000189762EF0 */ protected set {} } // 0x0000000182AF69F0-0x0000000182AF6AC0 0x0000000182AF6860-0x0000000182AF6940

	// Constructors
	public LampPhaseExcelConfig() {} // 0x0000000182AF7E70-0x0000000182AF7ED0

	// Methods
	// [IDTag] // 0x000000018976A510-0x000000018976A550
	// [XID] // 0x000000018976A510-0x000000018976A550
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182AF52F0-0x0000000182AF5B40
	// [IDTag] // 0x00000001897748F0-0x0000000189774930
	// [XID] // 0x00000001897748F0-0x0000000189774930
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182AF5B40-0x0000000182AF63B0
	// [XID] // 0x000000018977F120-0x000000018977F140
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF02F4 */, bool useObjectPool = false /* Metadata: 0x00AF02F8 */) => default; // 0x0000000182AF6D10-0x0000000182AF7630
	[BlackList] // 0x0000000189786B00-0x0000000189786B40
	// [XID] // 0x0000000189786B00-0x0000000189786B40
	public virtual void AutoAllocTypeFields() {} // 0x0000000182AF4EA0-0x0000000182AF4F40
	[BlackList] // 0x0000000189791050-0x0000000189791090
	// [XID] // 0x0000000189791050-0x0000000189791090
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182AF4F40-0x0000000182AF50A0
	[BlackList] // 0x000000018979C0D0-0x000000018979C110
	// [XID] // 0x000000018979C0D0-0x000000018979C110
	public virtual void ReturnToObjectPool() {} // 0x0000000182AF7DD0-0x0000000182AF7E70
	[BlackList] // 0x00000001897A6660-0x00000001897A66A0
	// [XID] // 0x00000001897A6660-0x00000001897A66A0
	public virtual void OnPoolAllocated() {} // 0x0000000182AF7BB0-0x0000000182AF7C50
	[BlackList] // 0x00000001897B0DC0-0x00000001897B0E00
	// [XID] // 0x00000001897B0DC0-0x00000001897B0E00
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182AF7B10-0x0000000182AF7BB0
}

