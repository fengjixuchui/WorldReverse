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
public class RushMove : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16701
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _toPos; // 0x68
	private SimpleSafeFloat minRangeRawNum; // 0x70
	private SimpleSafeFloat maxRangeRawNum; // 0x74
	private SimpleSafeFloat timeRangeRawNum; // 0x78

	// Properties
	public ConfigBornType toPos { /* [XID] */ /* 0x0000000189AE22C0-0x0000000189AE22E0 */ get => default; /* [XID] */ /* 0x0000000189AE9B90-0x0000000189AE9BB0 */ private set {} } // 0x00000001829B8F90-0x00000001829B9030 0x00000001829B7920-0x00000001829B79D0
	public float minRange { /* [XID] */ /* 0x0000000189AF1930-0x0000000189AF1950 */ get => default; /* [XID] */ /* 0x0000000189AF9090-0x0000000189AF90B0 */ private set {} } // 0x00000001829B8EB0-0x00000001829B8F90 0x00000001829B70C0-0x00000001829B71A0
	public float maxRange { /* [XID] */ /* 0x0000000189B00650-0x0000000189B00670 */ get => default; /* [XID] */ /* 0x0000000189B07AD0-0x0000000189B07AF0 */ private set {} } // 0x00000001829B6F70-0x00000001829B7050 0x00000001829B8060-0x00000001829B8140
	public float timeRange { /* [XID] */ /* 0x0000000189B0F3B0-0x0000000189B0F3D0 */ get => default; /* [XID] */ /* 0x0000000189B16730-0x0000000189B16750 */ private set {} } // 0x00000001829B8BF0-0x00000001829B8CD0 0x00000001829B7200-0x00000001829B72E0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189BA0B30-0x0000000189BA0B50 */ get => default; } // 0x00000001829B8CD0-0x00000001829B8D70 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189BA81D0-0x0000000189BA81F0 */ get => default; } // 0x00000001829B81B0-0x00000001829B8250 

	// Constructors
	public RushMove() {} // 0x00000001829B9790-0x00000001829B9840

	// Methods
	// [XID] // 0x0000000189B1DDF0-0x0000000189B1DE10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001829B94F0-0x00000001829B9650
	// [XID] // 0x0000000189B25640-0x0000000189B25660
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001829B8DD0-0x00000001829B8EB0
	// [XID] // 0x0000000189B2CB70-0x0000000189B2CB90
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF438E */) => default; // 0x00000001829B8860-0x00000001829B8940
	// [XID] // 0x0000000189B34020-0x0000000189B34040
	public override int GetHashNum() => default; // 0x00000001829B6EA0-0x00000001829B6F70
	// [XID] // 0x0000000189B3B910-0x0000000189B3B930
	public override void InitEmpty() {} // 0x00000001829B8250-0x00000001829B8380
	[BlackList] // 0x0000000189B432F0-0x0000000189B43330
	// [XID] // 0x0000000189B432F0-0x0000000189B43330
	public override bool FromJson(JSONNode node) => default; // 0x00000001829B7A50-0x00000001829B7DD0
	// [XID] // 0x0000000189B4D9C0-0x0000000189B4D9E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001829B62D0-0x00000001829B6810
	[BlackList] // 0x0000000189B55230-0x0000000189B55270
	// [XID] // 0x0000000189B55230-0x0000000189B55270
	public static new RushMove ParseFromJson(JSONNode node) => default; // 0x00000001829B89A0-0x00000001829B8BF0
	// [XID] // 0x0000000189B5FE40-0x0000000189B5FE60
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF438F */, bool useObjectPool = false /* Metadata: 0x00AF4393 */) => default; // 0x00000001829B8560-0x00000001829B8860
	// [XID] // 0x0000000189B674E0-0x0000000189B67500
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4394 */, bool useObjectPool = false /* Metadata: 0x00AF4398 */) => default; // 0x00000001829B7360-0x00000001829B7740
	// [XID] // 0x0000000189B6E780-0x0000000189B6E7A0
	public static new RushMove ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4399 */, bool useObjectPool = false /* Metadata: 0x00AF439D */) => default; // 0x00000001829B7DD0-0x00000001829B7FF0
	[BlackList] // 0x0000000189B75FB0-0x0000000189B75FF0
	// [XID] // 0x0000000189B75FB0-0x0000000189B75FF0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001829B6810-0x00000001829B6AE0
	// [XID] // 0x0000000189B803B0-0x0000000189B803D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001829B9110-0x00000001829B94F0
	[BlackList] // 0x0000000189B87E60-0x0000000189B87EA0
	// [XID] // 0x0000000189B87E60-0x0000000189B87EA0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001829B8460-0x00000001829B8560
	// [XID] // 0x0000000189B920C0-0x0000000189B920E0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001829B9650-0x00000001829B96F0
	// [XID] // 0x0000000189B995C0-0x0000000189B995E0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001829B7740-0x00000001829B78A0
	[BlackList] // 0x0000000189BAF680-0x0000000189BAF6C0
	// [XID] // 0x0000000189BAF680-0x0000000189BAF6C0
	public override void AutoAllocTypeFields() {} // 0x00000001829B6AE0-0x00000001829B6B80
	[BlackList] // 0x0000000189BB9B80-0x0000000189BB9BC0
	// [XID] // 0x0000000189BB9B80-0x0000000189BB9BC0
	public override void AutoRecycleTypeFields() {} // 0x00000001829B6B80-0x00000001829B6D10
	[BlackList] // 0x0000000189BC4880-0x0000000189BC48C0
	// [XID] // 0x0000000189BC4880-0x0000000189BC48C0
	public override void ReturnToObjectPool() {} // 0x00000001829B96F0-0x00000001829B9790
}

