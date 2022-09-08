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
public class TornadoMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16941
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigTornadoZone[] _stageZone; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _predicates; // 0x38
	private TargetType _targetType; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _enviroWindStrength; // 0x50
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _enviroWindRadius; // 0x58

	// Properties
	public ConfigTornadoZone[] stageZone { /* [XID] */ /* 0x00000001899E5380-0x00000001899E53A0 */ get => default; /* [XID] */ /* 0x00000001899EC670-0x00000001899EC690 */ private set {} } // 0x00000001841B8910-0x00000001841B89B0 0x00000001841B85A0-0x00000001841B8650
	public ConfigAbilityPredicate[] predicates { /* [XID] */ /* 0x00000001899F43F0-0x00000001899F4410 */ get => default; /* [XID] */ /* 0x00000001899FB970-0x00000001899FB990 */ private set {} } // 0x00000001841BA660-0x00000001841BA700 0x00000001841BA0A0-0x00000001841BA150
	public TargetType targetType { /* [XID] */ /* 0x0000000189A02D70-0x0000000189A02D90 */ get => default; /* [XID] */ /* 0x0000000189A0A3A0-0x0000000189A0A3C0 */ private set {} } // 0x00000001841B97C0-0x00000001841B9860 0x00000001841B7740-0x00000001841B77F0
	public ConfigBornType born { /* [XID] */ /* 0x0000000189A11CE0-0x0000000189A11D00 */ get => default; /* [XID] */ /* 0x0000000189A18FB0-0x0000000189A18FD0 */ private set {} } // 0x00000001841B8650-0x00000001841B86F0 0x00000001841BAE20-0x00000001841BAED0
	public DynamicFloat enviroWindStrength { /* [XID] */ /* 0x0000000189A20710-0x0000000189A20730 */ get => default; /* [XID] */ /* 0x0000000189A27B60-0x0000000189A27B80 */ private set {} } // 0x00000001841B87F0-0x00000001841B8890 0x00000001841B9F10-0x00000001841B9FC0
	public DynamicFloat enviroWindRadius { /* [XID] */ /* 0x0000000189A2F1D0-0x0000000189A2F1F0 */ get => default; /* [XID] */ /* 0x0000000189A36B90-0x0000000189A36BB0 */ private set {} } // 0x00000001841B86F0-0x00000001841B8790 0x00000001841BA400-0x00000001841BA4B0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189ABAEF0-0x0000000189ABAF10 */ get => default; } // 0x00000001841B9010-0x00000001841B90B0 

	// Constructors
	public TornadoMixin() {} // 0x00000001841BAF70-0x00000001841BB010

	// Methods
	// [XID] // 0x0000000189A3E1F0-0x0000000189A3E210
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001841BAC70-0x00000001841BAE20
	// [XID] // 0x0000000189A45940-0x0000000189A45960
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001841BA510-0x00000001841BA660
	// [XID] // 0x0000000189A4CFC0-0x0000000189A4CFE0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5E37 */) => default; // 0x00000001841B9FC0-0x00000001841BA0A0
	// [XID] // 0x0000000189A546F0-0x0000000189A54710
	public override int GetHashNum() => default; // 0x00000001841B84D0-0x00000001841B85A0
	// [XID] // 0x0000000189A5C1E0-0x0000000189A5C200
	public override void InitEmpty() {} // 0x00000001841B9860-0x00000001841B9960
	[BlackList] // 0x0000000189A63B50-0x0000000189A63B90
	// [XID] // 0x0000000189A63B50-0x0000000189A63B90
	public override bool FromJson(JSONNode node) => default; // 0x00000001841B90B0-0x00000001841B9430
	// [XID] // 0x0000000189A6E2A0-0x0000000189A6E2C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001841B77F0-0x00000001841B7E10
	[BlackList] // 0x0000000189A75850-0x0000000189A75890
	// [XID] // 0x0000000189A75850-0x0000000189A75890
	public static new TornadoMixin ParseFromJson(JSONNode node) => default; // 0x00000001841BA1B0-0x00000001841BA400
	// [XID] // 0x0000000189A80120-0x0000000189A80140
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E38 */, bool useObjectPool = false /* Metadata: 0x00AF5E3C */) => default; // 0x00000001841B9B30-0x00000001841B9E30
	// [XID] // 0x0000000189A87E20-0x0000000189A87E40
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E3D */, bool useObjectPool = false /* Metadata: 0x00AF5E41 */) => default; // 0x00000001841B89B0-0x00000001841B8F10
	// [XID] // 0x0000000189A8F670-0x0000000189A8F690
	public static new TornadoMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E42 */, bool useObjectPool = false /* Metadata: 0x00AF5E46 */) => default; // 0x00000001841B94A0-0x00000001841B96C0
	[BlackList] // 0x0000000189A96C20-0x0000000189A96C60
	// [XID] // 0x0000000189A96C20-0x0000000189A96C60
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001841B7E10-0x00000001841B80E0
	// [XID] // 0x0000000189AA0F60-0x0000000189AA0F80
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001841BA700-0x00000001841BAC70
	[BlackList] // 0x0000000189AA85C0-0x0000000189AA8600
	// [XID] // 0x0000000189AA85C0-0x0000000189AA8600
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001841B9A40-0x00000001841B9B30
	// [XID] // 0x0000000189AB31C0-0x0000000189AB31E0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001841B9E30-0x00000001841B9F10
	[BlackList] // 0x0000000189AC2760-0x0000000189AC27A0
	// [XID] // 0x0000000189AC2760-0x0000000189AC27A0
	public override void AutoAllocTypeFields() {} // 0x00000001841B80E0-0x00000001841B8180
	[BlackList] // 0x0000000189ACCD40-0x0000000189ACCD80
	// [XID] // 0x0000000189ACCD40-0x0000000189ACCD80
	public override void AutoRecycleTypeFields() {} // 0x00000001841B8180-0x00000001841B83B0
	[BlackList] // 0x0000000189AD7B00-0x0000000189AD7B40
	// [XID] // 0x0000000189AD7B00-0x0000000189AD7B40
	public override void ReturnToObjectPool() {} // 0x00000001841BAED0-0x00000001841BAF70
}

