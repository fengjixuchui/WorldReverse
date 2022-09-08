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
public class SetAnimatorTrigger : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16482
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicString _triggerID; // 0x68
	private bool _MPTriggerOnRemote; // 0x70

	// Properties
	public DynamicString triggerID { /* [XID] */ /* 0x00000001898D69E0-0x00000001898D6A00 */ get => default; /* [XID] */ /* 0x00000001898DE5A0-0x00000001898DE5C0 */ private set {} } // 0x00000001829725B0-0x0000000182972650 0x0000000182973C20-0x0000000182973CD0
	public bool MPTriggerOnRemote { /* [XID] */ /* 0x00000001898E5DC0-0x00000001898E5DE0 */ get => default; /* [XID] */ /* 0x00000001898ED6C0-0x00000001898ED6E0 */ private set {} } // 0x0000000182973600-0x00000001829736A0 0x0000000182973D70-0x0000000182973E20
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018998F660-0x000000018998F680 */ get => default; } // 0x00000001829730E0-0x0000000182973180 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189997080-0x00000001899970A0 */ get => default; } // 0x0000000182972510-0x00000001829725B0 

	// Constructors
	public SetAnimatorTrigger() {} // 0x0000000182973EC0-0x0000000182973F20

	// Methods
	// [XID] // 0x00000001898F4EE0-0x00000001898F4F00
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182973B00-0x0000000182973C20
	// [XID] // 0x00000001898FC610-0x00000001898FC630
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001829731E0-0x00000001829732C0
	// [XID] // 0x0000000189904090-0x00000001899040B0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3CD0 */) => default; // 0x0000000182972BF0-0x0000000182972CD0
	// [XID] // 0x000000018990B670-0x000000018990B690
	public override int GetHashNum() => default; // 0x0000000182971650-0x0000000182971720
	// [XID] // 0x0000000189913340-0x0000000189913360
	public override void InitEmpty() {} // 0x0000000182972650-0x0000000182972720
	[BlackList] // 0x000000018991AAF0-0x000000018991AB30
	// [XID] // 0x000000018991AAF0-0x000000018991AB30
	public override bool FromJson(JSONNode node) => default; // 0x0000000182971DE0-0x0000000182972160
	// [XID] // 0x0000000189925160-0x0000000189925180
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182970D10-0x0000000182971020
	[BlackList] // 0x000000018992C7A0-0x000000018992C7E0
	// [XID] // 0x000000018992C7A0-0x000000018992C7E0
	public static new SetAnimatorTrigger ParseFromJson(JSONNode node) => default; // 0x0000000182972E90-0x00000001829730E0
	// [XID] // 0x0000000189936C30-0x0000000189936C50
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3CD1 */, bool useObjectPool = false /* Metadata: 0x00AF3CD5 */) => default; // 0x00000001829728F0-0x0000000182972BF0
	// [XID] // 0x000000018993E810-0x000000018993E830
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3CD6 */, bool useObjectPool = false /* Metadata: 0x00AF3CDA */) => default; // 0x0000000182971870-0x0000000182971B80
	// [XID] // 0x0000000189945E00-0x0000000189945E20
	public static new SetAnimatorTrigger ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3CDB */, bool useObjectPool = false /* Metadata: 0x00AF3CDF */) => default; // 0x0000000182972210-0x0000000182972430
	[BlackList] // 0x000000018994D2F0-0x000000018994D330
	// [XID] // 0x000000018994D2F0-0x000000018994D330
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182971020-0x00000001829712F0
	// [XID] // 0x0000000189957C00-0x0000000189957C20
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001829736A0-0x0000000182973950
	[BlackList] // 0x000000018995F4B0-0x000000018995F4F0
	// [XID] // 0x000000018995F4B0-0x000000018995F4F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182972800-0x00000001829728F0
	// [XID] // 0x0000000189969B40-0x0000000189969B60
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000182973CD0-0x0000000182973D70
	// [XID] // 0x00000001899718E0-0x0000000189971900
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182971B80-0x0000000182971CE0
	// [XID] // 0x00000001899791B0-0x00000001899791D0
	public override bool GetDebugOutput(ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref string output) => default; // 0x0000000182973950-0x0000000182973B00
	// [XID] // 0x0000000189980260-0x0000000189980280
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000182973480-0x0000000182973600
	// [XID] // 0x0000000189987B10-0x0000000189987B30
	public override void CallRemote(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000182972D30-0x0000000182972E90
	[BlackList] // 0x000000018999EC70-0x000000018999ECB0
	// [XID] // 0x000000018999EC70-0x000000018999ECB0
	public override void AutoAllocTypeFields() {} // 0x00000001829712F0-0x0000000182971390
	[BlackList] // 0x00000001899A94A0-0x00000001899A94E0
	// [XID] // 0x00000001899A94A0-0x00000001899A94E0
	public override void AutoRecycleTypeFields() {} // 0x0000000182971390-0x00000001829714C0
	[BlackList] // 0x00000001899B3F20-0x00000001899B3F60
	// [XID] // 0x00000001899B3F20-0x00000001899B3F60
	public override void ReturnToObjectPool() {} // 0x0000000182973E20-0x0000000182973EC0
}

