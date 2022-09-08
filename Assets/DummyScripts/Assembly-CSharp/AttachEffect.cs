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
public class AttachEffect : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16385
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicString _effectPattern; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x70
	private SimpleSafeFloat scaleRawNum; // 0x78
	private SimpleSafeInt32 effectTempleteIDRawNum; // 0x7C

	// Properties
	public DynamicString effectPattern { /* [XID] */ /* 0x00000001897A6560-0x00000001897A6580 */ get => default; /* [XID] */ /* 0x00000001897ADAB0-0x00000001897ADAD0 */ private set {} } // 0x0000000183880020-0x00000001838800C0 0x00000001838818D0-0x0000000183881980
	public ConfigBornType born { /* [XID] */ /* 0x00000001897B5C10-0x00000001897B5C30 */ get => default; /* [XID] */ /* 0x00000001897BDA20-0x00000001897BDA40 */ private set {} } // 0x000000018387EC20-0x000000018387ECC0 0x00000001838816A0-0x0000000183881750
	public float scale { /* [XID] */ /* 0x00000001897C4DC0-0x00000001897C4DE0 */ get => default; /* [XID] */ /* 0x00000001897CC590-0x00000001897CC5B0 */ private set {} } // 0x000000018387FBF0-0x000000018387FCD0 0x0000000183881750-0x0000000183881830
	public int effectTempleteID { /* [XID] */ /* 0x00000001897D3EA0-0x00000001897D3EC0 */ get => default; /* [XID] */ /* 0x00000001897DB770-0x00000001897DB790 */ private set {} } // 0x000000018387EA00-0x000000018387EAD0 0x000000018387EAD0-0x000000018387EBB0
	public override EntityTokenActionType entityTokenType { /* [XID] */ /* 0x000000018985E010-0x000000018985E030 */ get => default; } // 0x000000018387F930-0x000000018387F9D0 
	public override bool useActionToken { /* [XID] */ /* 0x0000000189865AB0-0x0000000189865AD0 */ get => default; } // 0x0000000183881070-0x0000000183881110 
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189881B20-0x0000000189881B40 */ get => default; } // 0x0000000183880A70-0x0000000183880B10 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189889200-0x0000000189889220 */ get => default; } // 0x000000018387FDB0-0x000000018387FE50 

	// Constructors
	public AttachEffect() {} // 0x0000000183881A20-0x0000000183881AF0

	// Methods
	// [XID] // 0x00000001897E2F40-0x00000001897E2F60
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183881530-0x00000001838816A0
	// [XID] // 0x00000001897EA720-0x00000001897EA740
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183880B70-0x0000000183880C70
	// [XID] // 0x00000001897F2510-0x00000001897F2530
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF39CC */) => default; // 0x0000000183880510-0x00000001838805F0
	// [XID] // 0x00000001897F9C60-0x00000001897F9C80
	public override int GetHashNum() => default; // 0x000000018387E930-0x000000018387EA00
	// [XID] // 0x00000001898011E0-0x0000000189801200
	public override void InitEmpty() {} // 0x000000018387FE50-0x000000018387FFA0
	[BlackList] // 0x00000001898085A0-0x00000001898085E0
	// [XID] // 0x00000001898085A0-0x00000001898085E0
	public override bool FromJson(JSONNode node) => default; // 0x000000018387F5B0-0x000000018387F930
	// [XID] // 0x0000000189812CC0-0x0000000189812CE0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018387DD10-0x000000018387E220
	[BlackList] // 0x000000018981A8C0-0x000000018981A900
	// [XID] // 0x000000018981A8C0-0x000000018981A900
	public static new AttachEffect ParseFromJson(JSONNode node) => default; // 0x0000000183880820-0x0000000183880A70
	// [XID] // 0x0000000189824D20-0x0000000189824D40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF39CD */, bool useObjectPool = false /* Metadata: 0x00AF39D1 */) => default; // 0x0000000183880210-0x0000000183880510
	// [XID] // 0x000000018982C710-0x000000018982C730
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF39D2 */, bool useObjectPool = false /* Metadata: 0x00AF39D6 */) => default; // 0x000000018387EDA0-0x000000018387F1B0
	// [XID] // 0x0000000189833CA0-0x0000000189833CC0
	public static new AttachEffect ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF39D7 */, bool useObjectPool = false /* Metadata: 0x00AF39DB */) => default; // 0x000000018387F9D0-0x000000018387FBF0
	[BlackList] // 0x000000018983B220-0x000000018983B260
	// [XID] // 0x000000018983B220-0x000000018983B260
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018387E220-0x000000018387E4F0
	// [XID] // 0x0000000189845810-0x0000000189845830
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183881110-0x0000000183881530
	[BlackList] // 0x000000018984CD80-0x000000018984CDC0
	// [XID] // 0x000000018984CD80-0x000000018984CDC0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183880120-0x0000000183880210
	// [XID] // 0x0000000189856E60-0x0000000189856E80
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183881830-0x00000001838818D0
	// [IDTag] // 0x000000018986D010-0x000000018986D050
	// [XID] // 0x000000018986D010-0x000000018986D050
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018387F2E0-0x000000018387F440
	// [IDTag] // 0x0000000189877610-0x0000000189877650
	// [XID] // 0x0000000189877610-0x0000000189877650
	public override void Call(AbilityActionExecuter executer, ConfigAbilityAction actionConfig, IAbilityActionContainer instance, ActorAbilityPlugin.AbilityAttackTarget target) {} // 0x000000018387F1B0-0x000000018387F2E0
	// [XID] // 0x0000000189890680-0x00000001898906A0
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000183880EF0-0x0000000183881070
	// [XID] // 0x0000000189897BE0-0x0000000189897C00
	public override void CallRemote(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000183880650-0x00000001838807B0
	[BlackList] // 0x000000018989EFE0-0x000000018989F020
	// [XID] // 0x000000018989EFE0-0x000000018989F020
	public override void AutoAllocTypeFields() {} // 0x000000018387E4F0-0x000000018387E590
	[BlackList] // 0x00000001898A9830-0x00000001898A9870
	// [XID] // 0x00000001898A9830-0x00000001898A9870
	public override void AutoRecycleTypeFields() {} // 0x000000018387E590-0x000000018387E7A0
	[BlackList] // 0x00000001898B3D40-0x00000001898B3D80
	// [XID] // 0x00000001898B3D40-0x00000001898B3D80
	public override void ReturnToObjectPool() {} // 0x0000000183881980-0x0000000183881A20
}

