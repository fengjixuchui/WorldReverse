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
public class DamageByAttackValue : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16438
{
	// Fields
	private DamageAttacker _attacker; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAttackInfo _attackInfo; // 0x78

	// Properties
	public DamageAttacker attacker { /* [XID] */ /* 0x00000001896E1410-0x00000001896E1430 */ get => default; /* [XID] */ /* 0x00000001896E86A0-0x00000001896E86C0 */ private set {} } // 0x000000018499F320-0x000000018499F3C0 0x000000018499F760-0x000000018499F810
	public ConfigBornType born { /* [XID] */ /* 0x00000001896EFC00-0x00000001896EFC20 */ get => default; /* [XID] */ /* 0x00000001896F75F0-0x00000001896F7610 */ private set {} } // 0x000000018499E820-0x000000018499E8C0 0x00000001849A0990-0x00000001849A0A40
	public ConfigAttackInfo attackInfo { /* [XID] */ /* 0x000000018966D740-0x000000018966D760 */ get => default; /* [XID] */ /* 0x0000000189706280-0x00000001897062A0 */ private set {} } // 0x000000018499FDD0-0x000000018499FE70 0x000000018499DBA0-0x000000018499DC50
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189790E50-0x0000000189790E70 */ get => default; } // 0x00000001849A0200-0x00000001849A02A0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189798620-0x0000000189798640 */ get => default; } // 0x000000018499F6C0-0x000000018499F760 

	// Constructors
	public DamageByAttackValue() {} // 0x00000001849A0B80-0x00000001849A0BE0

	// Methods
	// [XID] // 0x000000018970DB70-0x000000018970DB90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001849A0840-0x00000001849A0990
	// [XID] // 0x0000000189714F70-0x0000000189714F90
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001849A0300-0x00000001849A0400
	// [XID] // 0x000000018971CA40-0x000000018971CA60
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3B6A */) => default; // 0x000000018499FE70-0x000000018499FF50
	// [XID] // 0x0000000189723E30-0x0000000189723E50
	public override int GetHashNum() => default; // 0x000000018499E6E0-0x000000018499E7B0
	// [XID] // 0x000000018972B670-0x000000018972B690
	public override void InitEmpty() {} // 0x000000018499F810-0x000000018499F900
	[BlackList] // 0x0000000189732E00-0x0000000189732E40
	// [XID] // 0x0000000189732E00-0x0000000189732E40
	public override bool FromJson(JSONNode node) => default; // 0x000000018499EFA0-0x000000018499F320
	// [XID] // 0x000000018973D9D0-0x000000018973D9F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018499DC50-0x000000018499E030
	[BlackList] // 0x0000000189744E70-0x0000000189744EB0
	// [XID] // 0x0000000189744E70-0x0000000189744EB0
	public static new DamageByAttackValue ParseFromJson(JSONNode node) => default; // 0x000000018499FFB0-0x00000001849A0200
	// [XID] // 0x000000018974F810-0x000000018974F830
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B6B */, bool useObjectPool = false /* Metadata: 0x00AF3B6F */) => default; // 0x000000018499FAD0-0x000000018499FDD0
	// [XID] // 0x0000000189756EA0-0x0000000189756EC0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B70 */, bool useObjectPool = false /* Metadata: 0x00AF3B74 */) => default; // 0x000000018499E9A0-0x000000018499ED40
	// [XID] // 0x000000018975E350-0x000000018975E370
	public static new DamageByAttackValue ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B75 */, bool useObjectPool = false /* Metadata: 0x00AF3B79 */) => default; // 0x000000018499F3C0-0x000000018499F5E0
	[BlackList] // 0x00000001897659D0-0x0000000189765A10
	// [XID] // 0x00000001897659D0-0x0000000189765A10
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018499E030-0x000000018499E300
	// [XID] // 0x0000000189770090-0x00000001897700B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001849A04E0-0x00000001849A0840
	[BlackList] // 0x0000000189777810-0x0000000189777850
	// [XID] // 0x0000000189777810-0x0000000189777850
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018499F9E0-0x000000018499FAD0
	// [XID] // 0x0000000189782380-0x00000001897823A0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001849A0A40-0x00000001849A0AE0
	// [XID] // 0x00000001897896E0-0x0000000189789700
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018499ED40-0x000000018499EEA0
	[BlackList] // 0x00000001897A0490-0x00000001897A04D0
	// [XID] // 0x00000001897A0490-0x00000001897A04D0
	public override void AutoAllocTypeFields() {} // 0x000000018499E300-0x000000018499E3A0
	[BlackList] // 0x00000001897AA920-0x00000001897AA960
	// [XID] // 0x00000001897AA920-0x00000001897AA960
	public override void AutoRecycleTypeFields() {} // 0x000000018499E3A0-0x000000018499E550
	[BlackList] // 0x00000001897B5BD0-0x00000001897B5C10
	// [XID] // 0x00000001897B5BD0-0x00000001897B5C10
	public override void ReturnToObjectPool() {} // 0x00000001849A0AE0-0x00000001849A0B80
}

