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
public class SendEffectTrigger : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16575
{
	// Fields
	private string _parameter; // 0x68
	private AnimatorParamType _type; // 0x70
	private SimpleSafeInt32 valueRawNum; // 0x74
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicString _effectPattern; // 0x78

	// Properties
	public string parameter { /* [XID] */ /* 0x0000000189BD5090-0x0000000189BD50B0 */ get => default; /* [XID] */ /* 0x0000000189BDCBC0-0x0000000189BDCBE0 */ private set {} } // 0x0000000184A4CC90-0x0000000184A4CD30 0x0000000184A4BBE0-0x0000000184A4BC90
	public AnimatorParamType type { /* [XID] */ /* 0x00000001895E9370-0x00000001895E9390 */ get => default; /* [XID] */ /* 0x00000001895F0B40-0x00000001895F0B60 */ private set {} } // 0x0000000184A4E240-0x0000000184A4E2E0 0x0000000184A4DAD0-0x0000000184A4DB80
	public int value { /* [XID] */ /* 0x00000001895F8590-0x00000001895F85B0 */ get => default; /* [XID] */ /* 0x00000001895FFA50-0x00000001895FFA70 */ private set {} } // 0x0000000184A4C510-0x0000000184A4C5E0 0x0000000184A4C3B0-0x0000000184A4C490
	public DynamicString effectPattern { /* [XID] */ /* 0x00000001896071E0-0x0000000189607200 */ get => default; /* [XID] */ /* 0x000000018960EC40-0x000000018960EC60 */ private set {} } // 0x0000000184A4CFE0-0x0000000184A4D080 0x0000000184A4E380-0x0000000184A4E430
	public override EntityTokenActionType entityTokenType { /* [XID] */ /* 0x0000000189693460-0x0000000189693480 */ get => default; } // 0x0000000184A4C960-0x0000000184A4CA00 
	public override bool useActionToken { /* [XID] */ /* 0x000000018969A790-0x000000018969A7B0 */ get => default; } // 0x0000000184A4DC60-0x0000000184A4DD00 
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001896A9360-0x00000001896A9380 */ get => default; } // 0x0000000184A4D8D0-0x0000000184A4D970 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001896B04B0-0x00000001896B04D0 */ get => default; } // 0x0000000184A4CDA0-0x0000000184A4CE40 

	// Constructors
	public SendEffectTrigger() {} // 0x0000000184A4E4D0-0x0000000184A4E530

	// Methods
	// [XID] // 0x0000000189616280-0x00000001896162A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184A4E0E0-0x0000000184A4E240
	// [XID] // 0x000000018961DB10-0x000000018961DB30
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184A4D9D0-0x0000000184A4DAD0
	// [XID] // 0x0000000189624F70-0x0000000189624F90
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3FAA */) => default; // 0x0000000184A4D4D0-0x0000000184A4D5B0
	// [XID] // 0x000000018962C7D0-0x000000018962C7F0
	public override int GetHashNum() => default; // 0x0000000184A4BA40-0x0000000184A4BB10
	// [XID] // 0x0000000189634510-0x0000000189634530
	public override void InitEmpty() {} // 0x0000000184A4CE40-0x0000000184A4CF60
	[BlackList] // 0x000000018963BC00-0x000000018963BC40
	// [XID] // 0x000000018963BC00-0x000000018963BC40
	public override bool FromJson(JSONNode node) => default; // 0x0000000184A4C5E0-0x0000000184A4C960
	// [XID] // 0x0000000189646220-0x0000000189646240
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184A4AEC0-0x0000000184A4B3D0
	[BlackList] // 0x000000018964DA20-0x000000018964DA60
	// [XID] // 0x000000018964DA20-0x000000018964DA60
	public static new SendEffectTrigger ParseFromJson(JSONNode node) => default; // 0x0000000184A4D680-0x0000000184A4D8D0
	// [XID] // 0x0000000189658250-0x0000000189658270
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3FAB */, bool useObjectPool = false /* Metadata: 0x00AF3FAF */) => default; // 0x0000000184A4D1D0-0x0000000184A4D4D0
	// [XID] // 0x000000018965F7C0-0x000000018965F7E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3FB0 */, bool useObjectPool = false /* Metadata: 0x00AF3FB4 */) => default; // 0x0000000184A4BD10-0x0000000184A4C160
	// [XID] // 0x0000000189667250-0x0000000189667270
	public static new SendEffectTrigger ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3FB5 */, bool useObjectPool = false /* Metadata: 0x00AF3FB9 */) => default; // 0x0000000184A4CA00-0x0000000184A4CC20
	[BlackList] // 0x000000018966EA00-0x000000018966EA40
	// [XID] // 0x000000018966EA00-0x000000018966EA40
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184A4B3D0-0x0000000184A4B6A0
	// [XID] // 0x00000001896797D0-0x00000001896797F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184A4DD00-0x0000000184A4E0E0
	[BlackList] // 0x0000000189680F40-0x0000000189680F80
	// [XID] // 0x0000000189680F40-0x0000000189680F80
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184A4D0E0-0x0000000184A4D1D0
	// [XID] // 0x000000018968B8F0-0x000000018968B910
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184A4E2E0-0x0000000184A4E380
	// [XID] // 0x00000001896A2100-0x00000001896A2120
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184A4C160-0x0000000184A4C2C0
	[BlackList] // 0x00000001896B7ED0-0x00000001896B7F10
	// [XID] // 0x00000001896B7ED0-0x00000001896B7F10
	public override void AutoAllocTypeFields() {} // 0x0000000184A4B6A0-0x0000000184A4B740
	[BlackList] // 0x00000001896C1EA0-0x00000001896C1EE0
	// [XID] // 0x00000001896C1EA0-0x00000001896C1EE0
	public override void AutoRecycleTypeFields() {} // 0x0000000184A4B740-0x0000000184A4B8B0
	[BlackList] // 0x00000001896CC630-0x00000001896CC670
	// [XID] // 0x00000001896CC630-0x00000001896CC670
	public override void ReturnToObjectPool() {} // 0x0000000184A4E430-0x0000000184A4E4D0
}

