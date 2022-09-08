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
public class RemoveModifier : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16466
{
	// Fields
	private string _modifierName; // 0x68

	// Properties
	public string modifierName { /* [XID] */ /* 0x000000018976BC00-0x000000018976BC20 */ get => default; /* [XID] */ /* 0x0000000189773100-0x0000000189773120 */ private set {} } // 0x00000001820EEB40-0x00000001820EEBE0 0x00000001820ED900-0x00000001820ED9B0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001897FFA90-0x00000001897FFAB0 */ get => default; } // 0x00000001820EE290-0x00000001820EE330 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189807130-0x0000000189807150 */ get => default; } // 0x00000001820ED6B0-0x00000001820ED750 

	// Constructors
	public RemoveModifier() {} // 0x00000001820EEC80-0x00000001820EECE0

	// Methods
	// [XID] // 0x000000018977A700-0x000000018977A720
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001820EE9B0-0x00000001820EEAA0
	// [XID] // 0x0000000189782360-0x0000000189782380
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001820EE390-0x00000001820EE470
	// [XID] // 0x00000001897896C0-0x00000001897896E0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3C50 */) => default; // 0x00000001820EDDA0-0x00000001820EDE80
	// [XID] // 0x0000000189790E30-0x0000000189790E50
	public override int GetHashNum() => default; // 0x00000001820EC940-0x00000001820ECA10
	// [XID] // 0x0000000189798600-0x0000000189798620
	public override void InitEmpty() {} // 0x00000001820ED750-0x00000001820ED820
	[BlackList] // 0x00000001897A0450-0x00000001897A0490
	// [XID] // 0x00000001897A0450-0x00000001897A0490
	public override bool FromJson(JSONNode node) => default; // 0x00000001820ED030-0x00000001820ED3B0
	// [XID] // 0x00000001897AA8E0-0x00000001897AA900
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001820EC160-0x00000001820EC390
	[BlackList] // 0x00000001897B2490-0x00000001897B24D0
	// [XID] // 0x00000001897B2490-0x00000001897B24D0
	public static new RemoveModifier ParseFromJson(JSONNode node) => default; // 0x00000001820EE040-0x00000001820EE290
	// [XID] // 0x00000001897BDA00-0x00000001897BDA20
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C51 */, bool useObjectPool = false /* Metadata: 0x00AF3C55 */) => default; // 0x00000001820EDAA0-0x00000001820EDDA0
	// [XID] // 0x00000001897C4DA0-0x00000001897C4DC0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C56 */, bool useObjectPool = false /* Metadata: 0x00AF3C5A */) => default; // 0x00000001820ECB60-0x00000001820ECDD0
	// [XID] // 0x00000001897CC550-0x00000001897CC570
	public static new RemoveModifier ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C5B */, bool useObjectPool = false /* Metadata: 0x00AF3C5F */) => default; // 0x00000001820ED3B0-0x00000001820ED5D0
	[BlackList] // 0x00000001897D3E20-0x00000001897D3E60
	// [XID] // 0x00000001897D3E20-0x00000001897D3E60
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001820EC390-0x00000001820EC660
	// [XID] // 0x00000001897DE550-0x00000001897DE570
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001820EE7B0-0x00000001820EE9B0
	[BlackList] // 0x00000001897E6050-0x00000001897E6090
	// [XID] // 0x00000001897E6050-0x00000001897E6090
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001820ED9B0-0x00000001820EDAA0
	// [XID] // 0x00000001897F0BA0-0x00000001897F0BC0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001820EEAA0-0x00000001820EEB40
	// [XID] // 0x00000001897F8380-0x00000001897F83A0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001820ECDD0-0x00000001820ECF30
	// [XID] // 0x000000018980E730-0x000000018980E750
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x00000001820EE630-0x00000001820EE7B0
	// [XID] // 0x0000000189815ED0-0x0000000189815EF0
	public override void CallRemote(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, UnionAbilityInvokeEntry invokeEntry) {} // 0x00000001820EDEE0-0x00000001820EE040
	[BlackList] // 0x000000018981D810-0x000000018981D850
	// [XID] // 0x000000018981D810-0x000000018981D850
	public override void AutoAllocTypeFields() {} // 0x00000001820EC660-0x00000001820EC700
	[BlackList] // 0x0000000189827FA0-0x0000000189827FE0
	// [XID] // 0x0000000189827FA0-0x0000000189827FE0
	public override void AutoRecycleTypeFields() {} // 0x00000001820EC700-0x00000001820EC7B0
	[BlackList] // 0x0000000189832350-0x0000000189832390
	// [XID] // 0x0000000189832350-0x0000000189832390
	public override void ReturnToObjectPool() {} // 0x00000001820EEBE0-0x00000001820EEC80
}

