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
public class ConfigGuideSceneIdCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18286
{
	// Fields
	private SimpleSafeUInt32 sceneIdRawNum; // 0x20
	private SimpleSafeUInt32[] _sceneIdList; // 0x28
	private bool _isScene; // 0x30

	// Properties
	public uint sceneId { /* [XID] */ /* 0x0000000189A861B0-0x0000000189A861D0 */ get => default; /* [XID] */ /* 0x0000000189A8DAD0-0x0000000189A8DAF0 */ private set {} } // 0x0000000181BE6FC0-0x0000000181BE7090 0x0000000181BE77C0-0x0000000181BE78A0
	public SimpleSafeUInt32[] sceneIdList { /* [XID] */ /* 0x0000000189A95070-0x0000000189A95090 */ get => default; /* [XID] */ /* 0x0000000189A9C970-0x0000000189A9C990 */ private set {} } // 0x0000000181BE7E80-0x0000000181BE7F20 0x0000000181BE5F70-0x0000000181BE6020
	public bool isScene { /* [XID] */ /* 0x0000000189AA4100-0x0000000189AA4120 */ get => default; /* [XID] */ /* 0x0000000189AAB5F0-0x0000000189AAB610 */ private set {} } // 0x0000000181BE74D0-0x0000000181BE7570 0x0000000181BE7A60-0x0000000181BE7B10

	// Constructors
	public ConfigGuideSceneIdCondition() {} // 0x0000000181BE80F0-0x0000000181BE8160

	// Methods
	// [XID] // 0x0000000189AB2F40-0x0000000189AB2F60
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181BE7F20-0x0000000181BE8050
	// [XID] // 0x0000000189ABAC30-0x0000000189ABAC50
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181BE7900-0x0000000181BE79E0
	// [XID] // 0x0000000189AC2400-0x0000000189AC2420
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF92DF */) => default; // 0x0000000181BE7390-0x0000000181BE7470
	// [XID] // 0x0000000189AC9B20-0x0000000189AC9B40
	public override int GetHashNum() => default; // 0x0000000181BE5E40-0x0000000181BE5F10
	// [XID] // 0x0000000189AD13B0-0x0000000189AD13D0
	public override void InitEmpty() {} // 0x0000000181BE6CE0-0x0000000181BE6DF0
	[BlackList] // 0x0000000189AD9190-0x0000000189AD91D0
	// [XID] // 0x0000000189AD9190-0x0000000189AD91D0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181BE6520-0x0000000181BE68A0
	// [XID] // 0x0000000189AE3AB0-0x0000000189AE3AD0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181BE54D0-0x0000000181BE58D0
	[BlackList] // 0x0000000189AEB310-0x0000000189AEB350
	// [XID] // 0x0000000189AEB310-0x0000000189AEB350
	public static new ConfigGuideSceneIdCondition ParseFromJson(JSONNode node) => default; // 0x0000000181BE7570-0x0000000181BE77C0
	// [XID] // 0x0000000189AF5B90-0x0000000189AF5BB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF92E0 */, bool useObjectPool = false /* Metadata: 0x00AF92E4 */) => default; // 0x0000000181BE7090-0x0000000181BE7390
	// [XID] // 0x0000000189AFD0B0-0x0000000189AFD0D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF92E5 */, bool useObjectPool = false /* Metadata: 0x00AF92E9 */) => default; // 0x0000000181BE60A0-0x0000000181BE6420
	// [XID] // 0x0000000189B048C0-0x0000000189B048E0
	public static new ConfigGuideSceneIdCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF92EA */, bool useObjectPool = false /* Metadata: 0x00AF92EE */) => default; // 0x0000000181BE68A0-0x0000000181BE6AC0
	[BlackList] // 0x0000000189B0C0B0-0x0000000189B0C0F0
	// [XID] // 0x0000000189B0C0B0-0x0000000189B0C0F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181BE58D0-0x0000000181BE5BA0
	// [XID] // 0x0000000189B163B0-0x0000000189B163D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181BE7B10-0x0000000181BE7E80
	[BlackList] // 0x0000000189B1DAD0-0x0000000189B1DB10
	// [XID] // 0x0000000189B1DAD0-0x0000000189B1DB10
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181BE6ED0-0x0000000181BE6FC0
	// [XID] // 0x0000000189B281D0-0x0000000189B281F0
	public override bool Ready(object body = null) => default; // 0x0000000181BE6B30-0x0000000181BE6CE0
	[BlackList] // 0x0000000189B2F550-0x0000000189B2F590
	// [XID] // 0x0000000189B2F550-0x0000000189B2F590
	public override void AutoAllocTypeFields() {} // 0x0000000181BE5BA0-0x0000000181BE5C40
	[BlackList] // 0x0000000189B39F30-0x0000000189B39F70
	// [XID] // 0x0000000189B39F30-0x0000000189B39F70
	public override void AutoRecycleTypeFields() {} // 0x0000000181BE5C40-0x0000000181BE5D20
	[BlackList] // 0x0000000189B44950-0x0000000189B44990
	// [XID] // 0x0000000189B44950-0x0000000189B44990
	public override void ReturnToObjectPool() {} // 0x0000000181BE8050-0x0000000181BE80F0
}

