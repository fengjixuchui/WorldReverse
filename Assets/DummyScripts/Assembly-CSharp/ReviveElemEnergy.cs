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
public class ReviveElemEnergy : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16763
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _value; // 0x68

	// Properties
	public DynamicFloat value { /* [XID] */ /* 0x000000018975E270-0x000000018975E290 */ get => default; /* [XID] */ /* 0x0000000189765950-0x0000000189765970 */ private set {} } // 0x00000001820841F0-0x0000000182084290 0x00000001820840C0-0x0000000182084170
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001897EA6A0-0x00000001897EA6C0 */ get => default; } // 0x0000000182085280-0x0000000182085320 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001897F2430-0x00000001897F2450 */ get => default; } // 0x00000001820848A0-0x0000000182084940 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x00000001897F9B60-0x00000001897F9B80 */ get => default; } // 0x0000000182083A90-0x0000000182083B30 

	// Constructors
	public ReviveElemEnergy() {} // 0x0000000182085960-0x00000001820859C0

	// Methods
	// [XID] // 0x000000018976D200-0x000000018976D220
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001820857E0-0x00000001820858C0
	// [XID] // 0x0000000189774650-0x0000000189774670
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001820853F0-0x00000001820854D0
	// [XID] // 0x000000018977C060-0x000000018977C080
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF457E */) => default; // 0x0000000182084EF0-0x0000000182084FD0
	// [XID] // 0x0000000189783970-0x0000000189783990
	public override int GetHashNum() => default; // 0x00000001820839C0-0x0000000182083A90
	// [XID] // 0x000000018978B160-0x000000018978B180
	public override void InitEmpty() {} // 0x0000000182084940-0x0000000182084A10
	[BlackList] // 0x00000001897926E0-0x0000000189792720
	// [XID] // 0x00000001897926E0-0x0000000189792720
	public override bool FromJson(JSONNode node) => default; // 0x0000000182084290-0x0000000182084610
	// [XID] // 0x000000018979D9B0-0x000000018979D9D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182083150-0x0000000182083390
	[BlackList] // 0x00000001897A4C90-0x00000001897A4CD0
	// [XID] // 0x00000001897A4C90-0x00000001897A4CD0
	public static new ReviveElemEnergy ParseFromJson(JSONNode node) => default; // 0x0000000182085030-0x0000000182085280
	// [XID] // 0x00000001897AF4B0-0x00000001897AF4D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF457F */, bool useObjectPool = false /* Metadata: 0x00AF4583 */) => default; // 0x0000000182084BF0-0x0000000182084EF0
	// [XID] // 0x00000001897B7330-0x00000001897B7350
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4584 */, bool useObjectPool = false /* Metadata: 0x00AF4588 */) => default; // 0x0000000182083C80-0x0000000182083F20
	// [XID] // 0x00000001897BF210-0x00000001897BF230
	public static new ReviveElemEnergy ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4589 */, bool useObjectPool = false /* Metadata: 0x00AF458D */) => default; // 0x0000000182084610-0x0000000182084830
	[BlackList] // 0x00000001897C6820-0x00000001897C6860
	// [XID] // 0x00000001897C6820-0x00000001897C6860
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182083390-0x0000000182083660
	// [XID] // 0x00000001897D0D50-0x00000001897D0D70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001820855B0-0x00000001820857E0
	[BlackList] // 0x00000001897D8BF0-0x00000001897D8C30
	// [XID] // 0x00000001897D8BF0-0x00000001897D8C30
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182084AF0-0x0000000182084BF0
	// [XID] // 0x00000001897E2E80-0x00000001897E2EA0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182083F20-0x0000000182084040
	[BlackList] // 0x00000001898010C0-0x0000000189801100
	// [XID] // 0x00000001898010C0-0x0000000189801100
	public override void AutoAllocTypeFields() {} // 0x0000000182083660-0x0000000182083700
	[BlackList] // 0x000000018980B560-0x000000018980B5A0
	// [XID] // 0x000000018980B560-0x000000018980B5A0
	public override void AutoRecycleTypeFields() {} // 0x0000000182083700-0x0000000182083830
	[BlackList] // 0x0000000189815DF0-0x0000000189815E30
	// [XID] // 0x0000000189815DF0-0x0000000189815E30
	public override void ReturnToObjectPool() {} // 0x00000001820858C0-0x0000000182085960
}

