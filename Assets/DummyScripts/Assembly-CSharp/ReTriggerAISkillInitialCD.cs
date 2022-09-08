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
public class ReTriggerAISkillInitialCD : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16607
{
	// Fields
	private SimpleSafeUInt32[] _skillIDs; // 0x68

	// Properties
	public SimpleSafeUInt32[] skillIDs { /* [XID] */ /* 0x00000001898D5030-0x00000001898D5050 */ get => default; /* [XID] */ /* 0x00000001898DC950-0x00000001898DC970 */ private set {} } // 0x00000001840EA240-0x00000001840EA2E0 0x00000001840EA190-0x00000001840EA240
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001899683C0-0x00000001899683E0 */ get => default; } // 0x00000001840E9FB0-0x00000001840EA050 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018996F860-0x000000018996F880 */ get => default; } // 0x00000001840E95E0-0x00000001840E9680 

	// Constructors
	public ReTriggerAISkillInitialCD() {} // 0x00000001840EA830-0x00000001840EA890

	// Methods
	// [XID] // 0x00000001898E4400-0x00000001898E4420
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001840EA600-0x00000001840EA6F0
	// [XID] // 0x00000001898EBE30-0x00000001898EBE50
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001840EA0B0-0x00000001840EA190
	// [XID] // 0x00000001898F3700-0x00000001898F3720
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF40AA */) => default; // 0x00000001840E9C20-0x00000001840E9D00
	// [XID] // 0x00000001898FAD20-0x00000001898FAD40
	public override int GetHashNum() => default; // 0x00000001840E8870-0x00000001840E8940
	// [XID] // 0x0000000189902860-0x0000000189902880
	public override void InitEmpty() {} // 0x00000001840E9680-0x00000001840E9750
	[BlackList] // 0x0000000189909E40-0x0000000189909E80
	// [XID] // 0x0000000189909E40-0x0000000189909E80
	public override bool FromJson(JSONNode node) => default; // 0x00000001840E8F60-0x00000001840E92E0
	// [XID] // 0x00000001899147E0-0x0000000189914800
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001840E8090-0x00000001840E82C0
	[BlackList] // 0x000000018991C3C0-0x000000018991C400
	// [XID] // 0x000000018991C3C0-0x000000018991C400
	public static new ReTriggerAISkillInitialCD ParseFromJson(JSONNode node) => default; // 0x00000001840E9D60-0x00000001840E9FB0
	// [XID] // 0x0000000189926B20-0x0000000189926B40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF40AB */, bool useObjectPool = false /* Metadata: 0x00AF40AF */) => default; // 0x00000001840E9920-0x00000001840E9C20
	// [XID] // 0x000000018992E130-0x000000018992E150
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF40B0 */, bool useObjectPool = false /* Metadata: 0x00AF40B4 */) => default; // 0x00000001840E8A90-0x00000001840E8D00
	// [XID] // 0x00000001899354F0-0x0000000189935510
	public static new ReTriggerAISkillInitialCD ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF40B5 */, bool useObjectPool = false /* Metadata: 0x00AF40B9 */) => default; // 0x00000001840E92E0-0x00000001840E9500
	[BlackList] // 0x000000018993D070-0x000000018993D0B0
	// [XID] // 0x000000018993D070-0x000000018993D0B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001840E82C0-0x00000001840E8590
	// [XID] // 0x0000000189947500-0x0000000189947520
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001840EA3C0-0x00000001840EA600
	[BlackList] // 0x000000018994EC60-0x000000018994ECA0
	// [XID] // 0x000000018994EC60-0x000000018994ECA0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001840E9830-0x00000001840E9920
	// [XID] // 0x0000000189959370-0x0000000189959390
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001840EA6F0-0x00000001840EA790
	// [XID] // 0x0000000189960BE0-0x0000000189960C00
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001840E8D00-0x00000001840E8E60
	[BlackList] // 0x0000000189977560-0x00000001899775A0
	// [XID] // 0x0000000189977560-0x00000001899775A0
	public override void AutoAllocTypeFields() {} // 0x00000001840E8590-0x00000001840E8630
	[BlackList] // 0x0000000189981F00-0x0000000189981F40
	// [XID] // 0x0000000189981F00-0x0000000189981F40
	public override void AutoRecycleTypeFields() {} // 0x00000001840E8630-0x00000001840E86E0
	[BlackList] // 0x000000018998C590-0x000000018998C5D0
	// [XID] // 0x000000018998C590-0x000000018998C5D0
	public override void ReturnToObjectPool() {} // 0x00000001840EA790-0x00000001840EA830
}

