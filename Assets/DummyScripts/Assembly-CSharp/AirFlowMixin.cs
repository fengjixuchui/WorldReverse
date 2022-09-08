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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class AirFlowMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16943
{
	// Fields
	private SimpleSafeUInt32 gadgetIDRawNum; // 0x30
	private SimpleSafeUInt32 campIDRawNum; // 0x34
	private TargetType _campTargetType; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x40

	// Properties
	public uint gadgetID { /* [XID] */ /* 0x0000000189AF18F0-0x0000000189AF1910 */ get => default; /* [XID] */ /* 0x0000000189AF9030-0x0000000189AF9050 */ private set {} } // 0x00000001851F5390-0x00000001851F5460 0x00000001851F4DB0-0x00000001851F4E90
	public uint campID { /* [XID] */ /* 0x0000000189B005F0-0x0000000189B00610 */ get => default; /* [XID] */ /* 0x0000000189B07A70-0x0000000189B07A90 */ private set {} } // 0x00000001851F50E0-0x00000001851F51B0 0x00000001851F3680-0x00000001851F3760
	public TargetType campTargetType { /* [XID] */ /* 0x0000000189B0F350-0x0000000189B0F370 */ get => default; /* [XID] */ /* 0x0000000189B16670-0x0000000189B16690 */ private set {} } // 0x00000001851F51B0-0x00000001851F5250 0x00000001851F5A90-0x00000001851F5B40
	public ConfigBornType born { /* [XID] */ /* 0x0000000189B1DD30-0x0000000189B1DD50 */ get => default; /* [XID] */ /* 0x0000000189B25560-0x0000000189B25580 */ private set {} } // 0x00000001851F3760-0x00000001851F3800 0x00000001851F59E0-0x00000001851F5A90
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189BA8130-0x0000000189BA8150 */ get => default; } // 0x00000001851F3DF0-0x00000001851F3E90 

	// Constructors
	public AirFlowMixin() {} // 0x00000001851F5BE0-0x00000001851F5C40

	// Methods
	// [XID] // 0x0000000189B2CAB0-0x0000000189B2CAD0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001851F5880-0x00000001851F59E0
	// [XID] // 0x0000000189B33F40-0x0000000189B33F60
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001851F52B0-0x00000001851F5390
	// [XID] // 0x0000000189B3B830-0x0000000189B3B850
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5E47 */) => default; // 0x00000001851F4C70-0x00000001851F4D50
	// [XID] // 0x0000000189B43230-0x0000000189B43250
	public override int GetHashNum() => default; // 0x00000001851F35B0-0x00000001851F3680
	// [XID] // 0x0000000189B4AAF0-0x0000000189B4AB10
	public override void InitEmpty() {} // 0x00000001851F45A0-0x00000001851F46C0
	[BlackList] // 0x0000000189B52120-0x0000000189B52160
	// [XID] // 0x0000000189B52120-0x0000000189B52160
	public override bool FromJson(JSONNode node) => default; // 0x00000001851F3E90-0x00000001851F4210
	// [XID] // 0x0000000189B5CB90-0x0000000189B5CBB0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001851F2A60-0x00000001851F2FA0
	[BlackList] // 0x0000000189B641B0-0x0000000189B641F0
	// [XID] // 0x0000000189B641B0-0x0000000189B641F0
	public static new AirFlowMixin ParseFromJson(JSONNode node) => default; // 0x00000001851F4E90-0x00000001851F50E0
	// [XID] // 0x0000000189B6E680-0x0000000189B6E6A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E48 */, bool useObjectPool = false /* Metadata: 0x00AF5E4C */) => default; // 0x00000001851F4890-0x00000001851F4B90
	// [XID] // 0x0000000189B75EB0-0x0000000189B75ED0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E4D */, bool useObjectPool = false /* Metadata: 0x00AF5E51 */) => default; // 0x00000001851F38E0-0x00000001851F3CF0
	// [XID] // 0x0000000189B7D3C0-0x0000000189B7D3E0
	public static new AirFlowMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E52 */, bool useObjectPool = false /* Metadata: 0x00AF5E56 */) => default; // 0x00000001851F4280-0x00000001851F44A0
	[BlackList] // 0x0000000189B85130-0x0000000189B85170
	// [XID] // 0x0000000189B85130-0x0000000189B85170
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001851F2FA0-0x00000001851F3270
	// [XID] // 0x0000000189B8EFF0-0x0000000189B8F010
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001851F5460-0x00000001851F5880
	[BlackList] // 0x0000000189B96460-0x0000000189B964A0
	// [XID] // 0x0000000189B96460-0x0000000189B964A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001851F47A0-0x00000001851F4890
	// [XID] // 0x0000000189BA0A70-0x0000000189BA0A90
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001851F4B90-0x00000001851F4C70
	[BlackList] // 0x0000000189BAF5C0-0x0000000189BAF600
	// [XID] // 0x0000000189BAF5C0-0x0000000189BAF600
	public override void AutoAllocTypeFields() {} // 0x00000001851F3270-0x00000001851F3310
	[BlackList] // 0x0000000189BB9AA0-0x0000000189BB9AE0
	// [XID] // 0x0000000189BB9AA0-0x0000000189BB9AE0
	public override void AutoRecycleTypeFields() {} // 0x00000001851F3310-0x00000001851F3490
	[BlackList] // 0x0000000189BC4820-0x0000000189BC4860
	// [XID] // 0x0000000189BC4820-0x0000000189BC4860
	public override void ReturnToObjectPool() {} // 0x00000001851F5B40-0x00000001851F5BE0
}

