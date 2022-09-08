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
public class Repeated : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16737
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicInt _repeatTimes; // 0x68
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _actions; // 0x70

	// Properties
	public DynamicInt repeatTimes { /* [XID] */ /* 0x00000001897B2370-0x00000001897B2390 */ get => default; /* [XID] */ /* 0x00000001897B9D50-0x00000001897B9D70 */ private set {} } // 0x0000000182B8DBF0-0x0000000182B8DC90 0x0000000182B8C0A0-0x0000000182B8C150
	public ConfigAbilityAction[] actions { /* [XID] */ /* 0x00000001897C1E30-0x00000001897C1E50 */ get => default; /* [XID] */ /* 0x00000001897C9780-0x00000001897C97A0 */ private set {} } // 0x0000000182B8DA70-0x0000000182B8DB10 0x0000000182B8BD90-0x0000000182B8BE40
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189853CE0-0x0000000189853D00 */ get => default; } // 0x0000000182B8D870-0x0000000182B8D910 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018985B830-0x000000018985B850 */ get => default; } // 0x0000000182B8CE90-0x0000000182B8CF30 

	// Constructors
	public Repeated() {} // 0x0000000182B8E1D0-0x0000000182B8E260

	// Methods
	// [XID] // 0x00000001897D0D70-0x00000001897D0D90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182B8DF70-0x0000000182B8E090
	// [XID] // 0x00000001897D8C30-0x00000001897D8C50
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182B8D970-0x0000000182B8DA70
	// [XID] // 0x00000001897DFE30-0x00000001897DFE50
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF44AE */) => default; // 0x0000000182B8D4E0-0x0000000182B8D5C0
	// [XID] // 0x00000001897E7470-0x00000001897E7490
	public override int GetHashNum() => default; // 0x0000000182B8BFD0-0x0000000182B8C0A0
	// [XID] // 0x00000001897EF0F0-0x00000001897EF110
	public override void InitEmpty() {} // 0x0000000182B8CF30-0x0000000182B8D000
	[BlackList] // 0x00000001897F6760-0x00000001897F67A0
	// [XID] // 0x00000001897F6760-0x00000001897F67A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182B8C810-0x0000000182B8CB90
	// [XID] // 0x0000000189801100-0x0000000189801120
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182B8B5E0-0x0000000182B8B8E0
	[BlackList] // 0x00000001898084A0-0x00000001898084E0
	// [XID] // 0x00000001898084A0-0x00000001898084E0
	public static new Repeated ParseFromJson(JSONNode node) => default; // 0x0000000182B8D620-0x0000000182B8D870
	// [XID] // 0x0000000189812C40-0x0000000189812C60
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF44AF */, bool useObjectPool = false /* Metadata: 0x00AF44B3 */) => default; // 0x0000000182B8D1E0-0x0000000182B8D4E0
	// [XID] // 0x000000018981A800-0x000000018981A820
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF44B4 */, bool useObjectPool = false /* Metadata: 0x00AF44B8 */) => default; // 0x0000000182B8C2A0-0x0000000182B8C5B0
	// [XID] // 0x0000000189821FD0-0x0000000189821FF0
	public static new Repeated ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF44B9 */, bool useObjectPool = false /* Metadata: 0x00AF44BD */) => default; // 0x0000000182B8CB90-0x0000000182B8CDB0
	[BlackList] // 0x00000001898294F0-0x0000000189829530
	// [XID] // 0x00000001898294F0-0x0000000189829530
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182B8B8E0-0x0000000182B8BBB0
	// [XID] // 0x0000000189833BC0-0x0000000189833BE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182B8DC90-0x0000000182B8DF70
	[BlackList] // 0x000000018983B0E0-0x000000018983B120
	// [XID] // 0x000000018983B0E0-0x000000018983B120
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182B8D0E0-0x0000000182B8D1E0
	// [XID] // 0x0000000189845790-0x00000001898457B0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000182B8E090-0x0000000182B8E130
	// [XID] // 0x000000018984CCA0-0x000000018984CCC0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182B8C5B0-0x0000000182B8C710
	[BlackList] // 0x0000000189862D90-0x0000000189862DD0
	// [XID] // 0x0000000189862D90-0x0000000189862DD0
	public override void AutoAllocTypeFields() {} // 0x0000000182B8BBB0-0x0000000182B8BC50
	[BlackList] // 0x000000018986CED0-0x000000018986CF10
	// [XID] // 0x000000018986CED0-0x000000018986CF10
	public override void AutoRecycleTypeFields() {} // 0x0000000182B8BC50-0x0000000182B8BD90
	[BlackList] // 0x0000000189877550-0x0000000189877590
	// [XID] // 0x0000000189877550-0x0000000189877590
	public override void ReturnToObjectPool() {} // 0x0000000182B8E130-0x0000000182B8E1D0
}

