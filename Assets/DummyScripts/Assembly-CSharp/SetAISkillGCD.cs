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
public class SetAISkillGCD : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16611
{
	// Fields
	private SimpleSafeFloat valueRawNum; // 0x68

	// Properties
	public float value { /* [XID] */ /* 0x0000000189A5F170-0x0000000189A5F190 */ get => default; /* [XID] */ /* 0x0000000189A66A20-0x0000000189A66A40 */ private set {} } // 0x00000001824020F0-0x00000001824021D0 0x0000000182401F90-0x0000000182402070
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189AEB6F0-0x0000000189AEB710 */ get => default; } // 0x00000001824031B0-0x0000000182403250 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189AF3030-0x0000000189AF3050 */ get => default; } // 0x00000001824027E0-0x0000000182402880 

	// Constructors
	public SetAISkillGCD() {} // 0x00000001824037D0-0x0000000182403B80

	// Methods
	// [XID] // 0x0000000189A6E340-0x0000000189A6E360
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182403630-0x0000000182403730
	// [XID] // 0x0000000189A75950-0x0000000189A75970
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001824032B0-0x0000000182403360
	// [XID] // 0x0000000189A7D5F0-0x0000000189A7D610
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF40CA */) => default; // 0x0000000182402E20-0x0000000182402F00
	// [XID] // 0x0000000189A84D20-0x0000000189A84D40
	public override int GetHashNum() => default; // 0x0000000182401920-0x00000001824019F0
	// [XID] // 0x0000000189A8C6B0-0x0000000189A8C6D0
	public override void InitEmpty() {} // 0x0000000182402880-0x0000000182402950
	[BlackList] // 0x0000000189A93A90-0x0000000189A93AD0
	// [XID] // 0x0000000189A93A90-0x0000000189A93AD0
	public override bool FromJson(JSONNode node) => default; // 0x00000001824021D0-0x0000000182402550
	// [XID] // 0x0000000189A9E0B0-0x0000000189A9E0D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001824010D0-0x0000000182401340
	[BlackList] // 0x0000000189AA5AE0-0x0000000189AA5B20
	// [XID] // 0x0000000189AA5AE0-0x0000000189AA5B20
	public static new SetAISkillGCD ParseFromJson(JSONNode node) => default; // 0x0000000182402F60-0x00000001824031B0
	// [XID] // 0x0000000189AB0340-0x0000000189AB0360
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF40CB */, bool useObjectPool = false /* Metadata: 0x00AF40CF */) => default; // 0x0000000182402B20-0x0000000182402E20
	// [XID] // 0x0000000189AB7A00-0x0000000189AB7A20
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF40D0 */, bool useObjectPool = false /* Metadata: 0x00AF40D4 */) => default; // 0x0000000182401B40-0x0000000182401DB0
	// [XID] // 0x0000000189ABF450-0x0000000189ABF470
	public static new SetAISkillGCD ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF40D5 */, bool useObjectPool = false /* Metadata: 0x00AF40D9 */) => default; // 0x0000000182402550-0x0000000182402770
	[BlackList] // 0x0000000189AC6EE0-0x0000000189AC6F20
	// [XID] // 0x0000000189AC6EE0-0x0000000189AC6F20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182401340-0x0000000182401610
	// [XID] // 0x0000000189AD16F0-0x0000000189AD1710
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182403440-0x0000000182403630
	[BlackList] // 0x0000000189AD9450-0x0000000189AD9490
	// [XID] // 0x0000000189AD9450-0x0000000189AD9490
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182402A30-0x0000000182402B20
	// [XID] // 0x0000000189AE3E50-0x0000000189AE3E70
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182401DB0-0x0000000182401F10
	[BlackList] // 0x0000000189AFA900-0x0000000189AFA940
	// [XID] // 0x0000000189AFA900-0x0000000189AFA940
	public override void AutoAllocTypeFields() {} // 0x0000000182401610-0x00000001824016B0
	[BlackList] // 0x0000000189B04C20-0x0000000189B04C60
	// [XID] // 0x0000000189B04C20-0x0000000189B04C60
	public override void AutoRecycleTypeFields() {} // 0x00000001824016B0-0x0000000182401790
	[BlackList] // 0x0000000189B0F3F0-0x0000000189B0F430
	// [XID] // 0x0000000189B0F3F0-0x0000000189B0F430
	public override void ReturnToObjectPool() {} // 0x0000000182403730-0x00000001824037D0
}

