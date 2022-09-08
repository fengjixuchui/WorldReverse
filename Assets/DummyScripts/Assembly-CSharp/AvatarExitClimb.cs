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
public class AvatarExitClimb : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16361
{
	// Properties
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B0DD10-0x0000000189B0DD30 */ get => default; } // 0x0000000183769A60-0x0000000183769B00 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B150D0-0x0000000189B150F0 */ get => default; } // 0x00000001837690C0-0x0000000183769160 

	// Constructors
	public AvatarExitClimb() {} // 0x0000000183769FD0-0x000000018376A030

	// Methods
	// [XID] // 0x0000000189A89810-0x0000000189A89830
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183769DE0-0x0000000183769E90
	// [XID] // 0x0000000189A90EF0-0x0000000189A90F10
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183769B60-0x0000000183769C10
	// [XID] // 0x0000000189A98760-0x0000000189A98780
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3908 */) => default; // 0x00000001837696D0-0x00000001837697B0
	// [XID] // 0x0000000189A9FBF0-0x0000000189A9FC10
	public override int GetHashNum() => default; // 0x0000000183768490-0x0000000183768560
	// [XID] // 0x0000000189AA7340-0x0000000189AA7360
	public override void InitEmpty() {} // 0x0000000183769160-0x0000000183769200
	[BlackList] // 0x0000000189AAEA60-0x0000000189AAEAA0
	// [XID] // 0x0000000189AAEA60-0x0000000189AAEAA0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183768A40-0x0000000183768DC0
	// [XID] // 0x0000000189AB90D0-0x0000000189AB90F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183767E00-0x0000000183767EF0
	[BlackList] // 0x0000000189AC0C90-0x0000000189AC0CD0
	// [XID] // 0x0000000189AC0C90-0x0000000189AC0CD0
	public static new AvatarExitClimb ParseFromJson(JSONNode node) => default; // 0x0000000183769810-0x0000000183769A60
	// [XID] // 0x0000000189ACB6F0-0x0000000189ACB710
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3909 */, bool useObjectPool = false /* Metadata: 0x00AF390D */) => default; // 0x00000001837693D0-0x00000001837696D0
	// [XID] // 0x0000000189AD3120-0x0000000189AD3140
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF390E */, bool useObjectPool = false /* Metadata: 0x00AF3912 */) => default; // 0x00000001837686B0-0x00000001837687E0
	// [XID] // 0x0000000189ADAB20-0x0000000189ADAB40
	public static new AvatarExitClimb ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3913 */, bool useObjectPool = false /* Metadata: 0x00AF3917 */) => default; // 0x0000000183768DC0-0x0000000183768FE0
	[BlackList] // 0x0000000189AE2340-0x0000000189AE2380
	// [XID] // 0x0000000189AE2340-0x0000000189AE2380
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183767EF0-0x00000001837681C0
	// [XID] // 0x0000000189AECCA0-0x0000000189AECCC0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183769CF0-0x0000000183769DE0
	[BlackList] // 0x0000000189AF4670-0x0000000189AF46B0
	// [XID] // 0x0000000189AF4670-0x0000000189AF46B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001837692E0-0x00000001837693D0
	// [XID] // 0x0000000189AFEE70-0x0000000189AFEE90
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183769E90-0x0000000183769F30
	// [XID] // 0x0000000189B06660-0x0000000189B06680
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001837687E0-0x0000000183768940
	[BlackList] // 0x0000000189B1CAF0-0x0000000189B1CB30
	// [XID] // 0x0000000189B1CAF0-0x0000000189B1CB30
	public override void AutoAllocTypeFields() {} // 0x00000001837681C0-0x0000000183768260
	[BlackList] // 0x0000000189B27060-0x0000000189B270A0
	// [XID] // 0x0000000189B27060-0x0000000189B270A0
	public override void AutoRecycleTypeFields() {} // 0x0000000183768260-0x0000000183768300
	[BlackList] // 0x0000000189B31370-0x0000000189B313B0
	// [XID] // 0x0000000189B31370-0x0000000189B313B0
	public override void ReturnToObjectPool() {} // 0x0000000183769F30-0x0000000183769FD0
}

