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
public class AttachToPlayStageMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17102
{
	// Fields
	private SimpleSafeUInt32 stageRawNum; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _actions; // 0x38

	// Properties
	public uint stage { /* [XID] */ /* 0x000000018974F630-0x000000018974F650 */ get => default; /* [XID] */ /* 0x0000000189756C60-0x0000000189756C80 */ private set {} } // 0x00000001822B8F90-0x00000001822B9060 0x00000001822B85B0-0x00000001822B8690
	public ConfigAbilityAction[] actions { /* [XID] */ /* 0x000000018975E130-0x000000018975E150 */ get => default; /* [XID] */ /* 0x00000001897658B0-0x00000001897658D0 */ private set {} } // 0x00000001822B9F80-0x00000001822BA020 0x00000001822B8310-0x00000001822B83C0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001897EA660-0x00000001897EA680 */ get => default; } // 0x00000001822B8B70-0x00000001822B8C10 

	// Constructors
	public AttachToPlayStageMixin() {} // 0x00000001822BA4C0-0x00000001822BA520

	// Methods
	// [XID] // 0x000000018976D140-0x000000018976D160
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001822BA310-0x00000001822BA420
	// [XID] // 0x0000000189774590-0x00000001897745B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001822B9EA0-0x00000001822B9F80
	// [XID] // 0x000000018977BFA0-0x000000018977BFC0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6353 */) => default; // 0x00000001822B9AB0-0x00000001822B9B90
	// [XID] // 0x0000000189783870-0x0000000189783890
	public override int GetHashNum() => default; // 0x00000001822B84E0-0x00000001822B85B0
	// [XID] // 0x000000018978B080-0x000000018978B0A0
	public override void InitEmpty() {} // 0x00000001822B93F0-0x00000001822B9500
	[BlackList] // 0x00000001897925A0-0x00000001897925E0
	// [XID] // 0x00000001897925A0-0x00000001897925E0
	public override bool FromJson(JSONNode node) => default; // 0x00000001822B8C10-0x00000001822B8F90
	// [XID] // 0x000000018979D8D0-0x000000018979D8F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001822B7B60-0x00000001822B7EB0
	[BlackList] // 0x00000001897A4B50-0x00000001897A4B90
	// [XID] // 0x00000001897A4B50-0x00000001897A4B90
	public static new AttachToPlayStageMixin ParseFromJson(JSONNode node) => default; // 0x00000001822B9BF0-0x00000001822B9E40
	// [XID] // 0x00000001897AF430-0x00000001897AF450
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6354 */, bool useObjectPool = false /* Metadata: 0x00AF6358 */) => default; // 0x00000001822B96D0-0x00000001822B99D0
	// [XID] // 0x00000001897B7290-0x00000001897B72B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6359 */, bool useObjectPool = false /* Metadata: 0x00AF635D */) => default; // 0x00000001822B8770-0x00000001822B8A70
	// [XID] // 0x00000001897BF170-0x00000001897BF190
	public static new AttachToPlayStageMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF635E */, bool useObjectPool = false /* Metadata: 0x00AF6362 */) => default; // 0x00000001822B90D0-0x00000001822B92F0
	[BlackList] // 0x00000001897C6720-0x00000001897C6760
	// [XID] // 0x00000001897C6720-0x00000001897C6760
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001822B7EB0-0x00000001822B8180
	// [XID] // 0x00000001897D0CD0-0x00000001897D0CF0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001822BA020-0x00000001822BA310
	[BlackList] // 0x00000001897D8B70-0x00000001897D8BB0
	// [XID] // 0x00000001897D8B70-0x00000001897D8BB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001822B95E0-0x00000001822B96D0
	// [XID] // 0x00000001897E2E40-0x00000001897E2E60
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001822B99D0-0x00000001822B9AB0
	[BlackList] // 0x00000001897F23B0-0x00000001897F23F0
	// [XID] // 0x00000001897F23B0-0x00000001897F23F0
	public override void AutoAllocTypeFields() {} // 0x00000001822B8180-0x00000001822B8220
	[BlackList] // 0x00000001897FCB80-0x00000001897FCBC0
	// [XID] // 0x00000001897FCB80-0x00000001897FCBC0
	public override void AutoRecycleTypeFields() {} // 0x00000001822B8220-0x00000001822B8310
	[BlackList] // 0x0000000189806FB0-0x0000000189806FF0
	// [XID] // 0x0000000189806FB0-0x0000000189806FF0
	public override void ReturnToObjectPool() {} // 0x00000001822BA420-0x00000001822BA4C0
}

