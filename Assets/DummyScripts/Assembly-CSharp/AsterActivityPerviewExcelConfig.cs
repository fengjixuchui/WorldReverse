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
public class AsterActivityPerviewExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15023
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 activityIdRawNum; // 0x10
	protected uint _descTextMapHash; // 0x14
	protected SimpleSafeUInt32 unlockLevelRawNum; // 0x18
	protected SimpleSafeUInt32 rewardPreviewIdRawNum; // 0x1C
	protected SimpleSafeUInt32[] _watcherList; // 0x20
	protected SimpleSafeUInt32 specialRewardIdRawNum; // 0x28
	protected SimpleSafeUInt32 activityStayTimeRawNum; // 0x2C
	protected SimpleSafeUInt32 perfabChangeQuestIdRawNum; // 0x30

	// Properties
	public uint activityId { /* [XID] */ /* 0x00000001899E8660-0x00000001899E8680 */ get => default; /* [XID] */ /* 0x00000001899EFCD0-0x00000001899EFCF0 */ protected set {} } // 0x0000000184088250-0x0000000184088320 0x0000000184087590-0x0000000184087670
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x00000001899F7350-0x00000001899F7370 */ get => default; /* [XID] */ /* 0x00000001899FEAD0-0x00000001899FEAF0 */ protected set {} } // 0x0000000184088010-0x00000001840880B0 0x0000000184086230-0x00000001840862E0
	public string desc { /* [XID] */ /* 0x0000000189A062F0-0x0000000189A06310 */ get => default; } // 0x0000000184087410-0x0000000184087590 
	public uint unlockLevel { /* [XID] */ /* 0x0000000189A0D7E0-0x0000000189A0D800 */ get => default; /* [XID] */ /* 0x0000000189A14F20-0x0000000189A14F40 */ protected set {} } // 0x00000001840880B0-0x0000000184088180 0x0000000184086150-0x0000000184086230
	public uint rewardPreviewId { /* [XID] */ /* 0x0000000189A1C070-0x0000000189A1C090 */ get => default; /* [XID] */ /* 0x0000000189A23940-0x0000000189A23960 */ protected set {} } // 0x0000000184087260-0x0000000184087330 0x0000000184087330-0x0000000184087410
	public SimpleSafeUInt32[] watcherList { /* [XID] */ /* 0x0000000189A2AD80-0x0000000189A2ADA0 */ get => default; /* [XID] */ /* 0x0000000189A322C0-0x0000000189A322E0 */ protected set {} } // 0x0000000184087670-0x0000000184087710 0x00000001840870E0-0x0000000184087190
	public uint specialRewardId { /* [XID] */ /* 0x0000000189A39D50-0x0000000189A39D70 */ get => default; /* [XID] */ /* 0x0000000189A41590-0x0000000189A415B0 */ protected set {} } // 0x0000000184088180-0x0000000184088250 0x0000000184087F30-0x0000000184088010
	public uint activityStayTime { /* [XID] */ /* 0x0000000189A48C50-0x0000000189A48C70 */ get => default; /* [XID] */ /* 0x0000000189A50360-0x0000000189A50380 */ protected set {} } // 0x0000000184087190-0x0000000184087260 0x0000000184085E90-0x0000000184085F70
	public uint perfabChangeQuestId { /* [XID] */ /* 0x0000000189A57930-0x0000000189A57950 */ get => default; /* [XID] */ /* 0x0000000189A5F570-0x0000000189A5F590 */ protected set {} } // 0x0000000184088320-0x00000001840883F0 0x0000000184087E50-0x0000000184087F30

	// Constructors
	public AsterActivityPerviewExcelConfig() {} // 0x00000001840885D0-0x0000000184088630

	// Methods
	// [IDTag] // 0x0000000189A66EA0-0x0000000189A66EE0
	// [XID] // 0x0000000189A66EA0-0x0000000189A66EE0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001840862E0-0x00000001840869E0
	// [IDTag] // 0x0000000189A713E0-0x0000000189A71420
	// [XID] // 0x0000000189A713E0-0x0000000189A71420
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001840869E0-0x00000001840870E0
	// [XID] // 0x0000000189A7BEE0-0x0000000189A7BF00
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFEBC */, bool useObjectPool = false /* Metadata: 0x00AEFEC0 */) => default; // 0x0000000184087710-0x0000000184087E50
	[BlackList] // 0x0000000189A83960-0x0000000189A839A0
	// [XID] // 0x0000000189A83960-0x0000000189A839A0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184085F70-0x0000000184086010
	[BlackList] // 0x0000000189A8E210-0x0000000189A8E250
	// [XID] // 0x0000000189A8E210-0x0000000189A8E250
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184086010-0x0000000184086150
	[BlackList] // 0x0000000189A98AC0-0x0000000189A98B00
	// [XID] // 0x0000000189A98AC0-0x0000000189A98B00
	public virtual void ReturnToObjectPool() {} // 0x0000000184088530-0x00000001840885D0
	[BlackList] // 0x0000000189AA2C60-0x0000000189AA2CA0
	// [XID] // 0x0000000189AA2C60-0x0000000189AA2CA0
	public virtual void OnPoolAllocated() {} // 0x0000000184088490-0x0000000184088530
	[BlackList] // 0x0000000189AAD460-0x0000000189AAD4A0
	// [XID] // 0x0000000189AAD460-0x0000000189AAD4A0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001840883F0-0x0000000184088490
}

