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
public class EnableCrashDamage : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16547
{
	// Fields
	private bool _enable; // 0x68

	// Properties
	public bool enable { /* [XID] */ /* 0x00000001896DFC40-0x00000001896DFC60 */ get => default; /* [XID] */ /* 0x00000001896E6FC0-0x00000001896E6FE0 */ private set {} } // 0x0000000182EEA670-0x0000000182EEA710 0x0000000182EEB3B0-0x0000000182EEB460
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189771A70-0x0000000189771A90 */ get => default; } // 0x0000000182EEB460-0x0000000182EEB500 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001897791A0-0x00000001897791C0 */ get => default; } // 0x0000000182EEAA10-0x0000000182EEAAB0 

	// Constructors
	public EnableCrashDamage() {} // 0x0000000182EEBB20-0x0000000182EEBB80

	// Methods
	// [XID] // 0x00000001896EE530-0x00000001896EE550
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182EEB8F0-0x0000000182EEB9E0
	// [XID] // 0x00000001896F5E80-0x00000001896F5EA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182EEB560-0x0000000182EEB610
	// [XID] // 0x00000001896FD630-0x00000001896FD650
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3ED6 */) => default; // 0x0000000182EEB020-0x0000000182EEB100
	// [XID] // 0x0000000189704A70-0x0000000189704A90
	public override int GetHashNum() => default; // 0x0000000182EE9C40-0x0000000182EE9D10
	// [XID] // 0x000000018970C270-0x000000018970C290
	public override void InitEmpty() {} // 0x0000000182EEAAB0-0x0000000182EEAB50
	[BlackList] // 0x0000000189713C40-0x0000000189713C80
	// [XID] // 0x0000000189713C40-0x0000000189713C80
	public override bool FromJson(JSONNode node) => default; // 0x0000000182EEA2F0-0x0000000182EEA670
	// [XID] // 0x000000018971E260-0x000000018971E280
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182EE9490-0x0000000182EE9690
	[BlackList] // 0x00000001897257A0-0x00000001897257E0
	// [XID] // 0x00000001897257A0-0x00000001897257E0
	public static new EnableCrashDamage ParseFromJson(JSONNode node) => default; // 0x0000000182EEB160-0x0000000182EEB3B0
	// [XID] // 0x000000018972FFA0-0x000000018972FFC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3ED7 */, bool useObjectPool = false /* Metadata: 0x00AF3EDB */) => default; // 0x0000000182EEAD20-0x0000000182EEB020
	// [XID] // 0x0000000189737840-0x0000000189737860
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3EDC */, bool useObjectPool = false /* Metadata: 0x00AF3EE0 */) => default; // 0x0000000182EE9E60-0x0000000182EEA090
	// [XID] // 0x000000018973F380-0x000000018973F3A0
	public static new EnableCrashDamage ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3EE1 */, bool useObjectPool = false /* Metadata: 0x00AF3EE5 */) => default; // 0x0000000182EEA710-0x0000000182EEA930
	[BlackList] // 0x00000001897466C0-0x0000000189746700
	// [XID] // 0x00000001897466C0-0x0000000189746700
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182EE9690-0x0000000182EE9960
	// [XID] // 0x0000000189750D60-0x0000000189750D80
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182EEB6F0-0x0000000182EEB8F0
	[BlackList] // 0x00000001897581F0-0x0000000189758230
	// [XID] // 0x00000001897581F0-0x0000000189758230
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182EEAC30-0x0000000182EEAD20
	// [XID] // 0x0000000189762BF0-0x0000000189762C10
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000182EEB9E0-0x0000000182EEBA80
	// [XID] // 0x000000018976A230-0x000000018976A250
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182EEA090-0x0000000182EEA1F0
	[BlackList] // 0x0000000189780980-0x00000001897809C0
	// [XID] // 0x0000000189780980-0x00000001897809C0
	public override void AutoAllocTypeFields() {} // 0x0000000182EE9960-0x0000000182EE9A00
	[BlackList] // 0x000000018978B220-0x000000018978B260
	// [XID] // 0x000000018978B220-0x000000018978B260
	public override void AutoRecycleTypeFields() {} // 0x0000000182EE9A00-0x0000000182EE9AB0
	[BlackList] // 0x00000001897955A0-0x00000001897955E0
	// [XID] // 0x00000001897955A0-0x00000001897955E0
	public override void ReturnToObjectPool() {} // 0x0000000182EEBA80-0x0000000182EEBB20
}

