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
public sealed class ConfigGuideAvatarChangeCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18206
{
	// Fields
	private SimpleSafeUInt32 configIDRawNum; // 0x20
	private NotifyTypes[] _curNotifyList; // 0x28

	// Properties
	public uint configID { /* [XID] */ /* 0x0000000189B0AA40-0x0000000189B0AA60 */ get => default; /* [XID] */ /* 0x0000000189B120C0-0x0000000189B120E0 */ private set {} } // 0x0000000185150790-0x0000000185150860 0x0000000185150070-0x0000000185150150

	// Constructors
	public ConfigGuideAvatarChangeCondition() {} // 0x0000000185152350-0x0000000185152410

	// Methods
	// [XID] // 0x0000000189B19470-0x0000000189B19490
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001851521C0-0x00000001851522B0
	// [XID] // 0x0000000189B20B10-0x0000000189B20B30
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185151E60-0x0000000185151F10
	// [XID] // 0x0000000189B28230-0x0000000189B28250
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF9033 */) => default; // 0x0000000185151A90-0x0000000185151B80
	// [XID] // 0x0000000189B2F590-0x0000000189B2F5B0
	public override int GetHashNum() => default; // 0x00000001851506C0-0x0000000185150790
	// [XID] // 0x0000000189B36E10-0x0000000189B36E30
	public override void InitEmpty() {} // 0x00000001851514F0-0x00000001851515C0
	[BlackList] // 0x0000000189B3E6C0-0x0000000189B3E700
	// [XID] // 0x0000000189B3E6C0-0x0000000189B3E700
	public override bool FromJson(JSONNode node) => default; // 0x0000000185150D70-0x00000001851510F0
	// [XID] // 0x0000000189B49300-0x0000000189B49320
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018514FE10-0x0000000185150070
	[BlackList] // 0x0000000189B508E0-0x0000000189B50920
	// [XID] // 0x0000000189B508E0-0x0000000189B50920
	public static new ConfigGuideAvatarChangeCondition ParseFromJson(JSONNode node) => default; // 0x0000000185151BE0-0x0000000185151E00
	// [XID] // 0x0000000189B5B010-0x0000000189B5B030
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9034 */, bool useObjectPool = false /* Metadata: 0x00AF9038 */) => default; // 0x0000000185151790-0x0000000185151A90
	// [XID] // 0x0000000189B62490-0x0000000189B624B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9039 */, bool useObjectPool = false /* Metadata: 0x00AF903D */) => default; // 0x0000000185150940-0x0000000185150BB0
	// [XID] // 0x0000000189B6A0B0-0x0000000189B6A0D0
	public static new ConfigGuideAvatarChangeCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF903E */, bool useObjectPool = false /* Metadata: 0x00AF9042 */) => default; // 0x00000001851510F0-0x00000001851512E0
	[BlackList] // 0x0000000189B71790-0x0000000189B717D0
	// [XID] // 0x0000000189B71790-0x0000000189B717D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000185150150-0x0000000185150420
	// [XID] // 0x0000000189B7BAD0-0x0000000189B7BAF0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185151F90-0x00000001851521C0
	[BlackList] // 0x0000000189B833A0-0x0000000189B833E0
	// [XID] // 0x0000000189B833A0-0x0000000189B833E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001851516A0-0x0000000185151790
	// [XID] // 0x0000000189B8D650-0x0000000189B8D670
	protected override bool Prepare(GuideManager manager) => default; // 0x0000000185150CB0-0x0000000185150D70
	// [XID] // 0x0000000189B94BD0-0x0000000189B94BF0
	public override bool Ready(object body = null) => default; // 0x0000000185151350-0x0000000185151470
	[BlackList] // 0x0000000189B9C300-0x0000000189B9C340
	// [XID] // 0x0000000189B9C300-0x0000000189B9C340
	public override void AutoAllocTypeFields() {} // 0x0000000185150420-0x00000001851504C0
	[BlackList] // 0x0000000189BA6840-0x0000000189BA6880
	// [XID] // 0x0000000189BA6840-0x0000000189BA6880
	public override void AutoRecycleTypeFields() {} // 0x00000001851504C0-0x00000001851505A0
	[BlackList] // 0x0000000189BB0F10-0x0000000189BB0F50
	// [XID] // 0x0000000189BB0F10-0x0000000189BB0F50
	public override void ReturnToObjectPool() {} // 0x00000001851522B0-0x0000000185152350
}

