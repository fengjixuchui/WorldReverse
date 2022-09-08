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
public class SetCrashDamage : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16549
{
	// Fields
	private string _key; // 0x68

	// Properties
	public string key { /* [XID] */ /* 0x000000018990A700-0x000000018990A720 */ get => default; /* [XID] */ /* 0x00000001897AF4D0-0x00000001897AF4F0 */ private set {} } // 0x000000018100AD20-0x000000018100ADC0 0x000000018100C590-0x000000018100C640
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018983B180-0x000000018983B1A0 */ get => default; } // 0x000000018100C640-0x000000018100C6E0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189842A20-0x0000000189842A40 */ get => default; } // 0x000000018100BA60-0x000000018100BB00 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x0000000189849D30-0x0000000189849D50 */ get => default; } // 0x000000018100AC80-0x000000018100AD20 

	// Constructors
	public SetCrashDamage() {} // 0x000000018100D000-0x000000018100D060

	// Methods
	// [XID] // 0x00000001897B7390-0x00000001897B73B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018100CDD0-0x000000018100CEC0
	// [XID] // 0x00000001897BF270-0x00000001897BF290
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018100C7B0-0x000000018100C890
	// [XID] // 0x00000001897C6860-0x00000001897C6880
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3EE6 */) => default; // 0x000000018100C0A0-0x000000018100C180
	// [XID] // 0x00000001897CDFC0-0x00000001897CDFE0
	public override int GetHashNum() => default; // 0x000000018100ABB0-0x000000018100AC80
	// [XID] // 0x00000001897D5530-0x00000001897D5550
	public override void InitEmpty() {} // 0x000000018100BB00-0x000000018100BBD0
	[BlackList] // 0x00000001897DCCB0-0x00000001897DCCF0
	// [XID] // 0x00000001897DCCB0-0x00000001897DCCF0
	public override bool FromJson(JSONNode node) => default; // 0x000000018100B3E0-0x000000018100B760
	// [XID] // 0x00000001897E74F0-0x00000001897E7510
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018100A3D0-0x000000018100A600
	[BlackList] // 0x00000001897EF170-0x00000001897EF1B0
	// [XID] // 0x00000001897EF170-0x00000001897EF1B0
	public static new SetCrashDamage ParseFromJson(JSONNode node) => default; // 0x000000018100C340-0x000000018100C590
	// [XID] // 0x00000001897F9BE0-0x00000001897F9C00
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3EE7 */, bool useObjectPool = false /* Metadata: 0x00AF3EEB */) => default; // 0x000000018100BDA0-0x000000018100C0A0
	// [XID] // 0x00000001898011A0-0x00000001898011C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3EEC */, bool useObjectPool = false /* Metadata: 0x00AF3EF0 */) => default; // 0x000000018100AF10-0x000000018100B180
	// [XID] // 0x0000000189808560-0x0000000189808580
	public static new SetCrashDamage ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3EF1 */, bool useObjectPool = false /* Metadata: 0x00AF3EF5 */) => default; // 0x000000018100B760-0x000000018100B980
	[BlackList] // 0x0000000189810110-0x0000000189810150
	// [XID] // 0x0000000189810110-0x0000000189810150
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018100A600-0x000000018100A8D0
	// [XID] // 0x000000018981A820-0x000000018981A840
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018100CBD0-0x000000018100CDD0
	[BlackList] // 0x0000000189822050-0x0000000189822090
	// [XID] // 0x0000000189822050-0x0000000189822090
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018100BCB0-0x000000018100BDA0
	// [XID] // 0x000000018982C670-0x000000018982C690
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018100CEC0-0x000000018100CF60
	// [XID] // 0x0000000189833C40-0x0000000189833C60
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018100B180-0x000000018100B2E0
	// [XID] // 0x00000001898513D0-0x00000001898513F0
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x000000018100CA50-0x000000018100CBD0
	// [XID] // 0x0000000189858900-0x0000000189858920
	public override void CallRemote(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, UnionAbilityInvokeEntry invokeEntry) {} // 0x000000018100C1E0-0x000000018100C340
	[BlackList] // 0x000000018985FA10-0x000000018985FA50
	// [XID] // 0x000000018985FA10-0x000000018985FA50
	public override void AutoAllocTypeFields() {} // 0x000000018100A8D0-0x000000018100A970
	[BlackList] // 0x000000018986A220-0x000000018986A260
	// [XID] // 0x000000018986A220-0x000000018986A260
	public override void AutoRecycleTypeFields() {} // 0x000000018100A970-0x000000018100AA20
	[BlackList] // 0x00000001898743A0-0x00000001898743E0
	// [XID] // 0x00000001898743A0-0x00000001898743E0
	public override void ReturnToObjectPool() {} // 0x000000018100CF60-0x000000018100D000
}

