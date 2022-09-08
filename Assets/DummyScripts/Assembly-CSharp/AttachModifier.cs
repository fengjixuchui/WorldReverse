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
public class AttachModifier : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16337
{
	// Fields
	private string _modifierName; // 0x68

	// Properties
	public string modifierName { /* [XID] */ /* 0x0000000189A0BC70-0x0000000189A0BC90 */ get => default; /* [XID] */ /* 0x0000000189A13520-0x0000000189A13540 */ private set {} } // 0x00000001850C2740-0x00000001850C27E0 0x00000001850C1460-0x00000001850C1510
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189AA5BA0-0x0000000189AA5BC0 */ get => default; } // 0x00000001850C1DF0-0x00000001850C1E90 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189AAD1A0-0x0000000189AAD1C0 */ get => default; } // 0x00000001850C1210-0x00000001850C12B0 

	// Constructors
	public AttachModifier() {} // 0x00000001850C2880-0x00000001850C28E0

	// Methods
	// [XID] // 0x0000000189A1A650-0x0000000189A1A670
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001850C25B0-0x00000001850C26A0
	// [XID] // 0x0000000189A21F50-0x0000000189A21F70
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001850C1EF0-0x00000001850C1FD0
	// [XID] // 0x0000000189A29380-0x0000000189A293A0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3844 */) => default; // 0x00000001850C1900-0x00000001850C19E0
	// [XID] // 0x0000000189A30910-0x0000000189A30930
	public override int GetHashNum() => default; // 0x00000001850C0430-0x00000001850C0500
	// [XID] // 0x0000000189A38330-0x0000000189A38350
	public override void InitEmpty() {} // 0x00000001850C12B0-0x00000001850C1380
	[BlackList] // 0x0000000189A3FB20-0x0000000189A3FB60
	// [XID] // 0x0000000189A3FB20-0x0000000189A3FB60
	public override bool FromJson(JSONNode node) => default; // 0x00000001850C0B20-0x00000001850C0EA0
	// [XID] // 0x0000000189A49FC0-0x0000000189A49FE0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001850BFC50-0x00000001850BFE80
	[BlackList] // 0x0000000189A51910-0x0000000189A51950
	// [XID] // 0x0000000189A51910-0x0000000189A51950
	public static new AttachModifier ParseFromJson(JSONNode node) => default; // 0x00000001850C1BA0-0x00000001850C1DF0
	// [XID] // 0x0000000189A5C2C0-0x0000000189A5C2E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3845 */, bool useObjectPool = false /* Metadata: 0x00AF3849 */) => default; // 0x00000001850C1600-0x00000001850C1900
	// [XID] // 0x0000000189A63CB0-0x0000000189A63CD0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF384A */, bool useObjectPool = false /* Metadata: 0x00AF384E */) => default; // 0x00000001850C0650-0x00000001850C08C0
	// [XID] // 0x0000000189A6B4D0-0x0000000189A6B4F0
	public static new AttachModifier ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF384F */, bool useObjectPool = false /* Metadata: 0x00AF3853 */) => default; // 0x00000001850C0F10-0x00000001850C1130
	[BlackList] // 0x0000000189A72CA0-0x0000000189A72CE0
	// [XID] // 0x0000000189A72CA0-0x0000000189A72CE0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001850BFE80-0x00000001850C0150
	// [XID] // 0x0000000189A7D6B0-0x0000000189A7D6D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001850C23B0-0x00000001850C25B0
	[BlackList] // 0x0000000189A84E00-0x0000000189A84E40
	// [XID] // 0x0000000189A84E00-0x0000000189A84E40
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001850C1510-0x00000001850C1600
	// [XID] // 0x0000000189A8F7F0-0x0000000189A8F810
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001850C26A0-0x00000001850C2740
	// [XID] // 0x0000000189A96D60-0x0000000189A96D80
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001850C08C0-0x00000001850C0A20
	// [XID] // 0x0000000189A9E1D0-0x0000000189A9E1F0
	public override bool CanUseOtherTargetting() => default; // 0x00000001850C2310-0x00000001850C23B0
	// [XID] // 0x0000000189AB4B70-0x0000000189AB4B90
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x00000001850C2190-0x00000001850C2310
	// [XID] // 0x0000000189ABC8C0-0x0000000189ABC8E0
	public override void CallRemote(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, UnionAbilityInvokeEntry invokeEntry) {} // 0x00000001850C1A40-0x00000001850C1BA0
	[BlackList] // 0x0000000189AC4180-0x0000000189AC41C0
	// [XID] // 0x0000000189AC4180-0x0000000189AC41C0
	public override void AutoAllocTypeFields() {} // 0x00000001850C0150-0x00000001850C01F0
	[BlackList] // 0x0000000189ACE6D0-0x0000000189ACE710
	// [XID] // 0x0000000189ACE6D0-0x0000000189ACE710
	public override void AutoRecycleTypeFields() {} // 0x00000001850C01F0-0x00000001850C02A0
	[BlackList] // 0x0000000189AD94B0-0x0000000189AD94F0
	// [XID] // 0x0000000189AD94B0-0x0000000189AD94F0
	public override void ReturnToObjectPool() {} // 0x00000001850C27E0-0x00000001850C2880
}

