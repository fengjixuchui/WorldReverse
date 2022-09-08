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
public class SetAISkillCDMultiplier : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16715
{
	// Fields
	private SimpleSafeFloat multiplierRawNum; // 0x68

	// Properties
	public float multiplier { /* [XID] */ /* 0x0000000189AA4420-0x0000000189AA4440 */ get => default; /* [XID] */ /* 0x0000000189AAB910-0x0000000189AAB930 */ private set {} } // 0x00000001825B65F0-0x00000001825B66D0 0x00000001825B6B30-0x00000001825B6C10
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B37090-0x0000000189B370B0 */ get => default; } // 0x00000001825B6980-0x00000001825B6A20 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B3E9E0-0x0000000189B3EA00 */ get => default; } // 0x00000001825B5EB0-0x00000001825B5F50 

	// Constructors
	public SetAISkillCDMultiplier() {} // 0x00000001825B7130-0x00000001825B71D0

	// Methods
	// [XID] // 0x0000000189AB3280-0x0000000189AB32A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001825B6EF0-0x00000001825B6FF0
	// [XID] // 0x0000000189ABAFD0-0x0000000189ABAFF0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001825B6A80-0x00000001825B6B30
	// [XID] // 0x0000000189AC27A0-0x0000000189AC27C0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF43FE */) => default; // 0x00000001825B6510-0x00000001825B65F0
	// [XID] // 0x0000000189AC9D80-0x0000000189AC9DA0
	public override int GetHashNum() => default; // 0x00000001825B5180-0x00000001825B5250
	// [XID] // 0x0000000189AD16D0-0x0000000189AD16F0
	public override void InitEmpty() {} // 0x00000001825B5F50-0x00000001825B6030
	[BlackList] // 0x0000000189AD9410-0x0000000189AD9450
	// [XID] // 0x0000000189AD9410-0x0000000189AD9450
	public override bool FromJson(JSONNode node) => default; // 0x00000001825B5830-0x00000001825B5BB0
	// [XID] // 0x0000000189AE3DF0-0x0000000189AE3E10
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001825B4950-0x00000001825B4BA0
	[BlackList] // 0x0000000189AEB650-0x0000000189AEB690
	// [XID] // 0x0000000189AEB650-0x0000000189AEB690
	public static new SetAISkillCDMultiplier ParseFromJson(JSONNode node) => default; // 0x00000001825B6730-0x00000001825B6980
	// [XID] // 0x0000000189AF5F10-0x0000000189AF5F30
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF43FF */, bool useObjectPool = false /* Metadata: 0x00AF4403 */) => default; // 0x00000001825B6210-0x00000001825B6510
	// [XID] // 0x0000000189AFD390-0x0000000189AFD3B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4404 */, bool useObjectPool = false /* Metadata: 0x00AF4408 */) => default; // 0x00000001825B53A0-0x00000001825B55D0
	// [XID] // 0x0000000189B04C00-0x0000000189B04C20
	public static new SetAISkillCDMultiplier ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4409 */, bool useObjectPool = false /* Metadata: 0x00AF440D */) => default; // 0x00000001825B5BB0-0x00000001825B5DD0
	[BlackList] // 0x0000000189B0C3D0-0x0000000189B0C410
	// [XID] // 0x0000000189B0C3D0-0x0000000189B0C410
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001825B4BA0-0x00000001825B4E70
	// [XID] // 0x0000000189B16710-0x0000000189B16730
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001825B6CF0-0x00000001825B6EF0
	[BlackList] // 0x0000000189B1DDB0-0x0000000189B1DDF0
	// [XID] // 0x0000000189B1DDB0-0x0000000189B1DDF0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001825B6110-0x00000001825B6210
	// [XID] // 0x0000000189B28450-0x0000000189B28470
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001825B6FF0-0x00000001825B7090
	// [XID] // 0x0000000189B2F770-0x0000000189B2F790
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001825B55D0-0x00000001825B5730
	[BlackList] // 0x0000000189B46420-0x0000000189B46460
	// [XID] // 0x0000000189B46420-0x0000000189B46460
	public override void AutoAllocTypeFields() {} // 0x00000001825B4E70-0x00000001825B4F10
	[BlackList] // 0x0000000189B50CA0-0x0000000189B50CE0
	// [XID] // 0x0000000189B50CA0-0x0000000189B50CE0
	public override void AutoRecycleTypeFields() {} // 0x00000001825B4F10-0x00000001825B4FF0
	[BlackList] // 0x0000000189B5B390-0x0000000189B5B3D0
	// [XID] // 0x0000000189B5B390-0x0000000189B5B3D0
	public override void ReturnToObjectPool() {} // 0x00000001825B7090-0x00000001825B7130
}

