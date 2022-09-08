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
public class ResetAIThreatBroadcastRange : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16729
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _range; // 0x68

	// Properties
	public DynamicFloat range { /* [XID] */ /* 0x0000000189A6E2E0-0x0000000189A6E300 */ get => default; /* [XID] */ /* 0x0000000189A758F0-0x0000000189A75910 */ private set {} } // 0x00000001845B4370-0x00000001845B4410 0x00000001845B4740-0x00000001845B47F0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B01E70-0x0000000189B01E90 */ get => default; } // 0x00000001845B5DD0-0x00000001845B5E70 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B093D0-0x0000000189B093F0 */ get => default; } // 0x00000001845B53F0-0x00000001845B5490 

	// Constructors
	public ResetAIThreatBroadcastRange() {} // 0x00000001845B64E0-0x00000001845B6540

	// Methods
	// [XID] // 0x0000000189A7D550-0x0000000189A7D570
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001845B62C0-0x00000001845B63A0
	// [XID] // 0x0000000189A84CC0-0x0000000189A84CE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001845B5ED0-0x00000001845B5FB0
	// [XID] // 0x0000000189A8C690-0x0000000189A8C6B0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF446E */) => default; // 0x00000001845B5A40-0x00000001845B5B20
	// [XID] // 0x0000000189A93A50-0x0000000189A93A70
	public override int GetHashNum() => default; // 0x00000001845B45A0-0x00000001845B4670
	// [XID] // 0x0000000189A9B5C0-0x0000000189A9B5E0
	public override void InitEmpty() {} // 0x00000001845B5490-0x00000001845B5560
	[BlackList] // 0x0000000189AA2900-0x0000000189AA2940
	// [XID] // 0x0000000189AA2900-0x0000000189AA2940
	public override bool FromJson(JSONNode node) => default; // 0x00000001845B4D70-0x00000001845B50F0
	// [XID] // 0x0000000189AAD100-0x0000000189AAD120
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001845B3C90-0x00000001845B3ED0
	[BlackList] // 0x0000000189AB4AD0-0x0000000189AB4B10
	// [XID] // 0x0000000189AB4AD0-0x0000000189AB4B10
	public static new ResetAIThreatBroadcastRange ParseFromJson(JSONNode node) => default; // 0x00000001845B5B80-0x00000001845B5DD0
	// [XID] // 0x0000000189ABF430-0x0000000189ABF450
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF446F */, bool useObjectPool = false /* Metadata: 0x00AF4473 */) => default; // 0x00000001845B5740-0x00000001845B5A40
	// [XID] // 0x0000000189AC6EA0-0x0000000189AC6EC0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4474 */, bool useObjectPool = false /* Metadata: 0x00AF4478 */) => default; // 0x00000001845B4870-0x00000001845B4B10
	// [XID] // 0x0000000189ACE670-0x0000000189ACE690
	public static new ResetAIThreatBroadcastRange ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4479 */, bool useObjectPool = false /* Metadata: 0x00AF447D */) => default; // 0x00000001845B50F0-0x00000001845B5310
	[BlackList] // 0x0000000189AD64E0-0x0000000189AD6520
	// [XID] // 0x0000000189AD64E0-0x0000000189AD6520
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001845B3ED0-0x00000001845B41A0
	// [XID] // 0x0000000189AE0FA0-0x0000000189AE0FC0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001845B6090-0x00000001845B62C0
	[BlackList] // 0x0000000189AE8330-0x0000000189AE8370
	// [XID] // 0x0000000189AE8330-0x0000000189AE8370
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001845B5640-0x00000001845B5740
	// [XID] // 0x0000000189AF2FD0-0x0000000189AF2FF0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001845B63A0-0x00000001845B6440
	// [XID] // 0x0000000189AFA8A0-0x0000000189AFA8C0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001845B4B10-0x00000001845B4C70
	[BlackList] // 0x0000000189B10E10-0x0000000189B10E50
	// [XID] // 0x0000000189B10E10-0x0000000189B10E50
	public override void AutoAllocTypeFields() {} // 0x00000001845B41A0-0x00000001845B4240
	[BlackList] // 0x0000000189B1AFE0-0x0000000189B1B020
	// [XID] // 0x0000000189B1AFE0-0x0000000189B1B020
	public override void AutoRecycleTypeFields() {} // 0x00000001845B4240-0x00000001845B4370
	[BlackList] // 0x0000000189B25600-0x0000000189B25640
	// [XID] // 0x0000000189B25600-0x0000000189B25640
	public override void ReturnToObjectPool() {} // 0x00000001845B6440-0x00000001845B64E0
}

