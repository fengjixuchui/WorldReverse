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
public sealed class ApplyModifier : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 14948
{
	// Fields
	private string _modifierName; // 0x68

	// Properties
	public string modifierName { /* [XID] */ /* 0x000000018998F8C0-0x000000018998F8E0 */ get => default; /* [XID] */ /* 0x00000001899972C0-0x00000001899972E0 */ private set {} } // 0x00000001814E0AF0-0x00000001814E0B90 0x00000001814DF7C0-0x00000001814DF870
	public override EntityTokenActionType entityTokenType { /* [XID] */ /* 0x0000000189A1A9D0-0x0000000189A1A9F0 */ get => default; } // 0x00000001814DF200-0x00000001814DF2A0 
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A30BB0-0x0000000189A30BD0 */ get => default; } // 0x00000001814E01A0-0x00000001814E0240 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A38610-0x0000000189A38630 */ get => default; } // 0x00000001814DF570-0x00000001814DF610 

	// Constructors
	public ApplyModifier(string modifierName, AbilityTargetting target) {} // 0x00000001814E0C90-0x00000001814E0D20
	public ApplyModifier() {} // 0x00000001814E0C30-0x00000001814E0C90

	// Methods
	// [XID] // 0x000000018999EED0-0x000000018999EEF0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001814E0960-0x00000001814E0A50
	// [XID] // 0x00000001899A67B0-0x00000001899A67D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001814E02A0-0x00000001814E0380
	// [XID] // 0x00000001899AE040-0x00000001899AE060
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AEFB78 */) => default; // 0x00000001814DFC60-0x00000001814DFD50
	// [XID] // 0x00000001899B57E0-0x00000001899B5800
	public override int GetHashNum() => default; // 0x00000001814DE720-0x00000001814DE7F0
	// [XID] // 0x00000001899BCF90-0x00000001899BCFB0
	public override void InitEmpty() {} // 0x00000001814DF610-0x00000001814DF6E0
	[BlackList] // 0x00000001899C4A20-0x00000001899C4A60
	// [XID] // 0x00000001899C4A20-0x00000001899C4A60
	public override bool FromJson(JSONNode node) => default; // 0x00000001814DEE10-0x00000001814DF190
	// [XID] // 0x00000001899CEFA0-0x00000001899CEFC0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001814DDF40-0x00000001814DE170
	[BlackList] // 0x00000001899D6550-0x00000001899D6590
	// [XID] // 0x00000001899D6550-0x00000001899D6590
	public static new ApplyModifier ParseFromJson(JSONNode node) => default; // 0x00000001814DFF80-0x00000001814E01A0
	// [XID] // 0x00000001899E0B00-0x00000001899E0B20
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB79 */, bool useObjectPool = false /* Metadata: 0x00AEFB7D */) => default; // 0x00000001814DF960-0x00000001814DFC60
	// [XID] // 0x00000001899E86A0-0x00000001899E86C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB7E */, bool useObjectPool = false /* Metadata: 0x00AEFB82 */) => default; // 0x00000001814DE940-0x00000001814DEBB0
	// [XID] // 0x00000001899EFD10-0x00000001899EFD30
	public static new ApplyModifier ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB83 */, bool useObjectPool = false /* Metadata: 0x00AEFB87 */) => default; // 0x00000001814DF2A0-0x00000001814DF490
	[BlackList] // 0x00000001899F73D0-0x00000001899F7410
	// [XID] // 0x00000001899F73D0-0x00000001899F7410
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001814DE170-0x00000001814DE440
	// [XID] // 0x0000000189A01650-0x0000000189A01670
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001814E0760-0x00000001814E0960
	[BlackList] // 0x0000000189A090B0-0x0000000189A090F0
	// [XID] // 0x0000000189A090B0-0x0000000189A090F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001814DF870-0x00000001814DF960
	// [XID] // 0x0000000189A138A0-0x0000000189A138C0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001814E0A50-0x00000001814E0AF0
	// [XID] // 0x0000000189A222F0-0x0000000189A22310
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001814DEBB0-0x00000001814DED10
	// [XID] // 0x0000000189A296C0-0x0000000189A296E0
	public override bool CanUseOtherTargetting() => default; // 0x00000001814E06C0-0x00000001814E0760
	// [XID] // 0x0000000189A3FD80-0x0000000189A3FDA0
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x00000001814E0540-0x00000001814E06C0
	// [XID] // 0x0000000189A47430-0x0000000189A47450
	public override void CallRemote(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, UnionAbilityInvokeEntry invokeEntry) {} // 0x00000001814DFDB0-0x00000001814DFF10
	[BlackList] // 0x0000000189A4EC90-0x0000000189A4ECD0
	// [XID] // 0x0000000189A4EC90-0x0000000189A4ECD0
	public override void AutoAllocTypeFields() {} // 0x00000001814DE440-0x00000001814DE4E0
	[BlackList] // 0x0000000189A593A0-0x0000000189A593E0
	// [XID] // 0x0000000189A593A0-0x0000000189A593E0
	public override void AutoRecycleTypeFields() {} // 0x00000001814DE4E0-0x00000001814DE590
	[BlackList] // 0x0000000189A63F10-0x0000000189A63F50
	// [XID] // 0x0000000189A63F10-0x0000000189A63F50
	public override void ReturnToObjectPool() {} // 0x00000001814E0B90-0x00000001814E0C30
}

