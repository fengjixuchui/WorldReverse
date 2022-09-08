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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigWidgetBonfire : ConfigBaseWidget, IAutoAllocRecycle // TypeDefIndex: 19128
{
	// Fields
	private SimpleSafeUInt32 lastingTimeRawNum; // 0x30
	private SimpleSafeUInt32 maxCountInSceneRawNum; // 0x34
	private SimpleSafeUInt32 maxCountByPlayerRawNum; // 0x38
	private SimpleSafeUInt32 gadgetIdRawNum; // 0x3C
	private SimpleSafeFloat distanceToAvatarRawNum; // 0x40
	private SimpleSafeFloat radiusRawNum; // 0x44
	private SimpleSafeFloat combatDestroyDistanceRawNum; // 0x48

	// Properties
	public uint lastingTime { /* [XID] */ /* 0x0000000189A233A0-0x0000000189A233C0 */ get => default; /* [XID] */ /* 0x0000000189A2A640-0x0000000189A2A660 */ private set {} } // 0x0000000180F8B2A0-0x0000000180F8B370 0x0000000180F8C100-0x0000000180F8C1E0
	public uint maxCountInScene { /* [XID] */ /* 0x0000000189A31C00-0x0000000189A31C20 */ get => default; /* [XID] */ /* 0x0000000189A39630-0x0000000189A39650 */ private set {} } // 0x0000000180F8D2C0-0x0000000180F8D390 0x0000000180F8A9C0-0x0000000180F8AAA0
	public uint maxCountByPlayer { /* [XID] */ /* 0x0000000189A40D90-0x0000000189A40DB0 */ get => default; /* [XID] */ /* 0x0000000189A48430-0x0000000189A48450 */ private set {} } // 0x0000000180F8B550-0x0000000180F8B620 0x0000000180F8B3F0-0x0000000180F8B4D0
	public uint gadgetId { /* [XID] */ /* 0x0000000189A4FD40-0x0000000189A4FD60 */ get => default; /* [XID] */ /* 0x0000000189A57230-0x0000000189A57250 */ private set {} } // 0x0000000180F8BD10-0x0000000180F8BDE0 0x0000000180F8BBC0-0x0000000180F8BCA0
	public float distanceToAvatar { /* [XID] */ /* 0x0000000189A5ED90-0x0000000189A5EDB0 */ get => default; /* [XID] */ /* 0x0000000189A66660-0x0000000189A66680 */ private set {} } // 0x0000000180F8D1E0-0x0000000180F8D2C0 0x0000000180F8D470-0x0000000180F8D550
	public float radius { /* [XID] */ /* 0x0000000189A6DE80-0x0000000189A6DEA0 */ get => default; /* [XID] */ /* 0x0000000189A753B0-0x0000000189A753D0 */ private set {} } // 0x0000000180F8C980-0x0000000180F8CA60 0x0000000180F8D550-0x0000000180F8D630
	public float combatDestroyDistance { /* [XID] */ /* 0x0000000189A7D110-0x0000000189A7D130 */ get => default; /* [XID] */ /* 0x0000000189A84960-0x0000000189A84980 */ private set {} } // 0x0000000180F8B1C0-0x0000000180F8B2A0 0x0000000180F8D390-0x0000000180F8D470

	// Constructors
	public ConfigWidgetBonfire() {} // 0x0000000180F8D6D0-0x0000000180F8D730

	// Methods
	// [XID] // 0x0000000189A8C1D0-0x0000000189A8C1F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000180F8D050-0x0000000180F8D1E0
	// [XID] // 0x0000000189A93690-0x0000000189A936B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000180F8C8D0-0x0000000180F8C980
	// [XID] // 0x0000000189A9B2A0-0x0000000189A9B2C0
	public override ConfigBaseWidget Clone(bool useObjectPool = false /* Metadata: 0x00AFC2C3 */) => default; // 0x0000000180F8C4E0-0x0000000180F8C5C0
	// [XID] // 0x0000000189AA2560-0x0000000189AA2580
	public override int GetHashNum() => default; // 0x0000000180F8A8F0-0x0000000180F8A9C0
	// [XID] // 0x0000000189AA9AA0-0x0000000189AA9AC0
	public override void InitEmpty() {} // 0x0000000180F8BDE0-0x0000000180F8BF30
	[BlackList] // 0x0000000189AB1960-0x0000000189AB19A0
	// [XID] // 0x0000000189AB1960-0x0000000189AB19A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000180F8B620-0x0000000180F8B9A0
	// [XID] // 0x0000000189ABC460-0x0000000189ABC480
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000180F89A10-0x0000000180F8A2F0
	[BlackList] // 0x0000000189AC3DA0-0x0000000189AC3DE0
	// [XID] // 0x0000000189AC3DA0-0x0000000189AC3DE0
	public static new ConfigWidgetBonfire ParseFromJson(JSONNode node) => default; // 0x0000000180F8C620-0x0000000180F8C870
	// [XID] // 0x0000000189ACE350-0x0000000189ACE370
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC2C4 */, bool useObjectPool = false /* Metadata: 0x00AFC2C8 */) => default; // 0x0000000180F8C1E0-0x0000000180F8C4E0
	// [XID] // 0x0000000189AD60E0-0x0000000189AD6100
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC2C9 */, bool useObjectPool = false /* Metadata: 0x00AFC2CD */) => default; // 0x0000000180F8AB80-0x0000000180F8B1C0
	// [XID] // 0x0000000189ADD9F0-0x0000000189ADDA10
	public static new ConfigWidgetBonfire ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC2CE */, bool useObjectPool = false /* Metadata: 0x00AFC2D2 */) => default; // 0x0000000180F8B9A0-0x0000000180F8BBC0
	[BlackList] // 0x0000000189AE52E0-0x0000000189AE5320
	// [XID] // 0x0000000189AE52E0-0x0000000189AE5320
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000180F8A2F0-0x0000000180F8A5C0
	// [XID] // 0x0000000189AEFD80-0x0000000189AEFDA0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000180F8CA60-0x0000000180F8D050
	[BlackList] // 0x0000000189AF72A0-0x0000000189AF72E0
	// [XID] // 0x0000000189AF72A0-0x0000000189AF72E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000180F8C010-0x0000000180F8C100
	[BlackList] // 0x0000000189B019A0-0x0000000189B019E0
	// [XID] // 0x0000000189B019A0-0x0000000189B019E0
	public override void AutoAllocTypeFields() {} // 0x0000000180F8A5C0-0x0000000180F8A660
	[BlackList] // 0x0000000189B0BF10-0x0000000189B0BF50
	// [XID] // 0x0000000189B0BF10-0x0000000189B0BF50
	public override void AutoRecycleTypeFields() {} // 0x0000000180F8A660-0x0000000180F8A7D0
	[BlackList] // 0x0000000189B161B0-0x0000000189B161F0
	// [XID] // 0x0000000189B161B0-0x0000000189B161F0
	public override void ReturnToObjectPool() {} // 0x0000000180F8D630-0x0000000180F8D6D0
}

