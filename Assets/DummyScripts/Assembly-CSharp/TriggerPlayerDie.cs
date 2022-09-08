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
public class TriggerPlayerDie : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16655
{
	// Properties
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189AD6520-0x0000000189AD6540 */ get => default; } // 0x0000000181B48FE0-0x0000000181B49080 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189ADDD60-0x0000000189ADDD80 */ get => default; } // 0x0000000181B48630-0x0000000181B486D0 

	// Constructors
	public TriggerPlayerDie() {} // 0x0000000181B49550-0x0000000181B495B0

	// Methods
	// [XID] // 0x0000000189A51850-0x0000000189A51870
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181B49360-0x0000000181B49410
	// [XID] // 0x0000000189A590A0-0x0000000189A590C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181B490E0-0x0000000181B49190
	// [XID] // 0x0000000189A609A0-0x0000000189A609C0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF422A */) => default; // 0x0000000181B48C50-0x0000000181B48D30
	// [XID] // 0x0000000189A687D0-0x0000000189A687F0
	public override int GetHashNum() => default; // 0x0000000181B47A00-0x0000000181B47AD0
	// [XID] // 0x0000000189A6FB20-0x0000000189A6FB40
	public override void InitEmpty() {} // 0x0000000181B486D0-0x0000000181B48770
	[BlackList] // 0x0000000189A772F0-0x0000000189A77330
	// [XID] // 0x0000000189A772F0-0x0000000189A77330
	public override bool FromJson(JSONNode node) => default; // 0x0000000181B47FB0-0x0000000181B48330
	// [XID] // 0x0000000189A81C90-0x0000000189A81CB0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181B47370-0x0000000181B47460
	[BlackList] // 0x0000000189A89730-0x0000000189A89770
	// [XID] // 0x0000000189A89730-0x0000000189A89770
	public static new TriggerPlayerDie ParseFromJson(JSONNode node) => default; // 0x0000000181B48D90-0x0000000181B48FE0
	// [XID] // 0x0000000189A93A70-0x0000000189A93A90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF422B */, bool useObjectPool = false /* Metadata: 0x00AF422F */) => default; // 0x0000000181B48950-0x0000000181B48C50
	// [XID] // 0x0000000189A9B5E0-0x0000000189A9B600
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4230 */, bool useObjectPool = false /* Metadata: 0x00AF4234 */) => default; // 0x0000000181B47C20-0x0000000181B47D50
	// [XID] // 0x0000000189AA2940-0x0000000189AA2960
	public static new TriggerPlayerDie ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4235 */, bool useObjectPool = false /* Metadata: 0x00AF4239 */) => default; // 0x0000000181B48330-0x0000000181B48550
	[BlackList] // 0x0000000189AA9F60-0x0000000189AA9FA0
	// [XID] // 0x0000000189AA9F60-0x0000000189AA9FA0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181B47460-0x0000000181B47730
	// [XID] // 0x0000000189AB4B10-0x0000000189AB4B30
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181B49270-0x0000000181B49360
	[BlackList] // 0x0000000189ABC800-0x0000000189ABC840
	// [XID] // 0x0000000189ABC800-0x0000000189ABC840
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181B48850-0x0000000181B48950
	// [XID] // 0x0000000189AC6EC0-0x0000000189AC6EE0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000181B49410-0x0000000181B494B0
	// [XID] // 0x0000000189ACE690-0x0000000189ACE6B0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000181B47D50-0x0000000181B47EB0
	[BlackList] // 0x0000000189AE57C0-0x0000000189AE5800
	// [XID] // 0x0000000189AE57C0-0x0000000189AE5800
	public override void AutoAllocTypeFields() {} // 0x0000000181B47730-0x0000000181B477D0
	[BlackList] // 0x0000000189AF02D0-0x0000000189AF0310
	// [XID] // 0x0000000189AF02D0-0x0000000189AF0310
	public override void AutoRecycleTypeFields() {} // 0x0000000181B477D0-0x0000000181B47870
	[BlackList] // 0x0000000189AFA8C0-0x0000000189AFA900
	// [XID] // 0x0000000189AFA8C0-0x0000000189AFA900
	public override void ReturnToObjectPool() {} // 0x0000000181B494B0-0x0000000181B49550
}

