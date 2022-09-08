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
public class FireEffect : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16341
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicString _effectPattern; // 0x68
	private string[] _othereffectPatterns; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x78
	private bool _ownedByLevel; // 0x80
	private bool _useY; // 0x81
	private SimpleSafeFloat scaleRawNum; // 0x84
	private SimpleSafeInt32 effectTempleteIDRawNum; // 0x88

	// Properties
	public DynamicString effectPattern { /* [XID] */ /* 0x0000000189BD0A90-0x0000000189BD0AB0 */ get => default; /* [XID] */ /* 0x0000000189BD7FB0-0x0000000189BD7FD0 */ private set {} } // 0x00000001840E0F80-0x00000001840E1020 0x00000001840E2BA0-0x00000001840E2C50
	public string[] othereffectPatterns { /* [XID] */ /* 0x0000000189BDFB20-0x0000000189BDFB40 */ get => default; /* [XID] */ /* 0x00000001895EC730-0x00000001895EC750 */ private set {} } // 0x00000001840E2B00-0x00000001840E2BA0 0x00000001840E0310-0x00000001840E03C0
	public ConfigBornType born { /* [XID] */ /* 0x00000001895F3BF0-0x00000001895F3C10 */ get => default; /* [XID] */ /* 0x00000001895FB4F0-0x00000001895FB510 */ private set {} } // 0x00000001840DF8E0-0x00000001840DF980 0x00000001840E28D0-0x00000001840E2980
	public bool ownedByLevel { /* [XID] */ /* 0x0000000189602C30-0x0000000189602C50 */ get => default; /* [XID] */ /* 0x000000018960A570-0x000000018960A590 */ private set {} } // 0x00000001840E1A80-0x00000001840E1B30 0x00000001840E0440-0x00000001840E04F0
	public bool useY { /* [XID] */ /* 0x0000000189611D00-0x0000000189611D20 */ get => default; /* [XID] */ /* 0x00000001896195C0-0x00000001896195E0 */ private set {} } // 0x00000001840E1470-0x00000001840E1520 0x00000001840E0010-0x00000001840E00C0
	public float scale { /* [XID] */ /* 0x0000000189620B60-0x0000000189620B80 */ get => default; /* [XID] */ /* 0x0000000189628190-0x00000001896281B0 */ private set {} } // 0x00000001840E0B30-0x00000001840E0C10 0x00000001840E2980-0x00000001840E2A60
	public int effectTempleteID { /* [XID] */ /* 0x000000018962F9C0-0x000000018962F9E0 */ get => default; /* [XID] */ /* 0x0000000189637540-0x0000000189637560 */ private set {} } // 0x00000001840DF6C0-0x00000001840DF790 0x00000001840DF790-0x00000001840DF870
	public override EntityTokenActionType entityTokenType { /* [XID] */ /* 0x00000001896BADF0-0x00000001896BAE10 */ get => default; } // 0x00000001840E0870-0x00000001840E0910 
	public override bool useActionToken { /* [XID] */ /* 0x00000001896C1F20-0x00000001896C1F40 */ get => default; } // 0x00000001840E2080-0x00000001840E2120 
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001896D0CE0-0x00000001896D0D00 */ get => default; } // 0x00000001840E1B30-0x00000001840E1BD0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001896D82D0-0x00000001896D82F0 */ get => default; } // 0x00000001840E0CF0-0x00000001840E0D90 

	// Constructors
	public FireEffect() {} // 0x00000001840E2CF0-0x00000001840E2DC0

	// Methods
	// [XID] // 0x000000018963EB40-0x000000018963EB60
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001840E2710-0x00000001840E28D0
	// [XID] // 0x0000000189646240-0x0000000189646260
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001840E1C30-0x00000001840E1D40
	// [XID] // 0x000000018964DA80-0x000000018964DAA0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3864 */) => default; // 0x00000001840E1520-0x00000001840E1600
	// [XID] // 0x0000000189655240-0x0000000189655260
	public override int GetHashNum() => default; // 0x00000001840DF5F0-0x00000001840DF6C0
	// [XID] // 0x000000018965CAA0-0x000000018965CAC0
	public override void InitEmpty() {} // 0x00000001840E0D90-0x00000001840E0F00
	[BlackList] // 0x0000000189663F40-0x0000000189663F80
	// [XID] // 0x0000000189663F40-0x0000000189663F80
	public override bool FromJson(JSONNode node) => default; // 0x00000001840E04F0-0x00000001840E0870
	// [XID] // 0x000000018966EA60-0x000000018966EA80
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001840DE770-0x00000001840DEED0
	[BlackList] // 0x00000001896764A0-0x00000001896764E0
	// [XID] // 0x00000001896764A0-0x00000001896764E0
	public static new FireEffect ParseFromJson(JSONNode node) => default; // 0x00000001840E1830-0x00000001840E1A80
	// [XID] // 0x0000000189680FA0-0x0000000189680FC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3865 */, bool useObjectPool = false /* Metadata: 0x00AF3869 */) => default; // 0x00000001840E1170-0x00000001840E1470
	// [XID] // 0x0000000189688980-0x00000001896889A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF386A */, bool useObjectPool = false /* Metadata: 0x00AF386E */) => default; // 0x00000001840DFA60-0x00000001840E0010
	// [XID] // 0x00000001896903C0-0x00000001896903E0
	public static new FireEffect ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF386F */, bool useObjectPool = false /* Metadata: 0x00AF3873 */) => default; // 0x00000001840E0910-0x00000001840E0B30
	[BlackList] // 0x0000000189697C80-0x0000000189697CC0
	// [XID] // 0x0000000189697C80-0x0000000189697CC0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001840DEED0-0x00000001840DF1A0
	// [XID] // 0x00000001896A2160-0x00000001896A2180
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001840E2120-0x00000001840E2710
	[BlackList] // 0x00000001896A93C0-0x00000001896A9400
	// [XID] // 0x00000001896A93C0-0x00000001896A9400
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001840E1080-0x00000001840E1170
	// [XID] // 0x00000001896B3670-0x00000001896B3690
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001840E2A60-0x00000001840E2B00
	// [XID] // 0x00000001896C9510-0x00000001896C9530
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001840E00C0-0x00000001840E0220
	// [XID] // 0x00000001896DFC60-0x00000001896DFC80
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x00000001840E1F00-0x00000001840E2080
	// [XID] // 0x00000001896E7000-0x00000001896E7020
	public override void CallRemote(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, UnionAbilityInvokeEntry invokeEntry) {} // 0x00000001840E1660-0x00000001840E17C0
	[BlackList] // 0x00000001896EE590-0x00000001896EE5D0
	// [XID] // 0x00000001896EE590-0x00000001896EE5D0
	public override void AutoAllocTypeFields() {} // 0x00000001840DF1A0-0x00000001840DF240
	[BlackList] // 0x00000001896F89C0-0x00000001896F8A00
	// [XID] // 0x00000001896F89C0-0x00000001896F8A00
	public override void AutoRecycleTypeFields() {} // 0x00000001840DF240-0x00000001840DF460
	[BlackList] // 0x00000001897033F0-0x0000000189703430
	// [XID] // 0x00000001897033F0-0x0000000189703430
	public override void ReturnToObjectPool() {} // 0x00000001840E2C50-0x00000001840E2CF0
}

