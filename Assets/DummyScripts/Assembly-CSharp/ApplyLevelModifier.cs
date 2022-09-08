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
public class ApplyLevelModifier : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16335
{
	// Fields
	private string _modifierName; // 0x68

	// Properties
	public string modifierName { /* [XID] */ /* 0x0000000189925220-0x0000000189925240 */ get => default; /* [XID] */ /* 0x000000018992C860-0x000000018992C880 */ private set {} } // 0x0000000185419ED0-0x0000000185419F70 0x0000000185418B80-0x0000000185418C30
	public override EntityTokenActionType entityTokenType { /* [XID] */ /* 0x00000001899B1070-0x00000001899B1090 */ get => default; } // 0x0000000185418590-0x0000000185418630 
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001899C7550-0x00000001899C7570 */ get => default; } // 0x0000000185419580-0x0000000185419620 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001899CEBE0-0x00000001899CEC00 */ get => default; } // 0x0000000185418930-0x00000001854189D0 

	// Constructors
	public ApplyLevelModifier() {} // 0x000000018541A010-0x000000018541A070

	// Methods
	// [XID] // 0x0000000189933EE0-0x0000000189933F00
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185419D40-0x0000000185419E30
	// [XID] // 0x000000018993BA30-0x000000018993BA50
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185419680-0x0000000185419760
	// [XID] // 0x0000000189942B70-0x0000000189942B90
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3834 */) => default; // 0x0000000185419020-0x0000000185419100
	// [XID] // 0x000000018994A380-0x000000018994A3A0
	public override int GetHashNum() => default; // 0x0000000185417AB0-0x0000000185417B80
	// [XID] // 0x0000000189951E50-0x0000000189951E70
	public override void InitEmpty() {} // 0x00000001854189D0-0x0000000185418AA0
	[BlackList] // 0x00000001899593D0-0x0000000189959410
	// [XID] // 0x00000001899593D0-0x0000000189959410
	public override bool FromJson(JSONNode node) => default; // 0x00000001854181A0-0x0000000185418520
	// [XID] // 0x0000000189963CA0-0x0000000189963CC0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001854172D0-0x0000000185417500
	[BlackList] // 0x000000018996B270-0x000000018996B2B0
	// [XID] // 0x000000018996B270-0x000000018996B2B0
	public static new ApplyLevelModifier ParseFromJson(JSONNode node) => default; // 0x0000000185419330-0x0000000185419580
	// [XID] // 0x0000000189975CD0-0x0000000189975CF0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3835 */, bool useObjectPool = false /* Metadata: 0x00AF3839 */) => default; // 0x0000000185418D20-0x0000000185419020
	// [XID] // 0x000000018997CDD0-0x000000018997CDF0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF383A */, bool useObjectPool = false /* Metadata: 0x00AF383E */) => default; // 0x0000000185417CD0-0x0000000185417F40
	// [XID] // 0x0000000189984A50-0x0000000189984A70
	public static new ApplyLevelModifier ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF383F */, bool useObjectPool = false /* Metadata: 0x00AF3843 */) => default; // 0x0000000185418630-0x0000000185418850
	[BlackList] // 0x000000018998C610-0x000000018998C650
	// [XID] // 0x000000018998C610-0x000000018998C650
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000185417500-0x00000001854177D0
	// [XID] // 0x00000001899970E0-0x0000000189997100
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185419B40-0x0000000185419D40
	[BlackList] // 0x000000018999ECD0-0x000000018999ED10
	// [XID] // 0x000000018999ECD0-0x000000018999ED10
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000185418C30-0x0000000185418D20
	// [XID] // 0x00000001899A9560-0x00000001899A9580
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000185419E30-0x0000000185419ED0
	// [XID] // 0x00000001899B8250-0x00000001899B8270
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000185417F40-0x00000001854180A0
	// [XID] // 0x00000001899BFD30-0x00000001899BFD50
	public override bool CanUseOtherTargetting() => default; // 0x0000000185419AA0-0x0000000185419B40
	// [XID] // 0x00000001899D6350-0x00000001899D6370
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000185419920-0x0000000185419AA0
	// [XID] // 0x00000001899DD7C0-0x00000001899DD7E0
	public override void CallRemote(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000185419160-0x00000001854192C0
	[BlackList] // 0x00000001899E5580-0x00000001899E55C0
	// [XID] // 0x00000001899E5580-0x00000001899E55C0
	public override void AutoAllocTypeFields() {} // 0x00000001854177D0-0x0000000185417870
	[BlackList] // 0x00000001899EF830-0x00000001899EF870
	// [XID] // 0x00000001899EF830-0x00000001899EF870
	public override void AutoRecycleTypeFields() {} // 0x0000000185417870-0x0000000185417920
	[BlackList] // 0x00000001899F9F90-0x00000001899F9FD0
	// [XID] // 0x00000001899F9F90-0x00000001899F9FD0
	public override void ReturnToObjectPool() {} // 0x0000000185419F70-0x000000018541A010
}

