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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class TriggerAttackEvent : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16490
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAttackEvent _attackEvent; // 0x68
	private TargetType _targetType; // 0x70

	// Properties
	public ConfigAttackEvent attackEvent { /* [XID] */ /* 0x00000001896A3620-0x00000001896A3640 */ get => default; /* [XID] */ /* 0x00000001896AAAF0-0x00000001896AAB10 */ private set {} } // 0x0000000182412D40-0x0000000182412DE0 0x00000001824126F0-0x00000001824127A0
	public TargetType targetType { /* [XID] */ /* 0x00000001896B1A30-0x00000001896B1A50 */ get => default; /* [XID] */ /* 0x00000001896B9450-0x00000001896B9470 */ private set {} } // 0x00000001824125B0-0x0000000182412650 0x0000000182410CF0-0x0000000182410DA0
	public override EntityTokenActionType entityTokenType { /* [XID] */ /* 0x000000018973BE60-0x000000018973BE80 */ get => default; } // 0x0000000182412210-0x00000001824122B0 
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018974B340-0x000000018974B360 */ get => default; } // 0x00000001824131E0-0x0000000182413280 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189752450-0x0000000189752470 */ get => default; } // 0x0000000182412650-0x00000001824126F0 

	// Constructors
	public TriggerAttackEvent() {} // 0x00000001824139B0-0x0000000182413A10

	// Methods
	// [XID] // 0x00000001896C0820-0x00000001896C0840
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182413750-0x0000000182413870
	// [XID] // 0x00000001896C7F90-0x00000001896C7FB0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001824132E0-0x00000001824133C0
	// [XID] // 0x00000001896CF8D0-0x00000001896CF8F0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3D10 */) => default; // 0x0000000182412DE0-0x0000000182412EC0
	// [XID] // 0x00000001896D6BA0-0x00000001896D6BC0
	public override int GetHashNum() => default; // 0x0000000182411700-0x00000001824117D0
	// [XID] // 0x00000001896DE260-0x00000001896DE280
	public override void InitEmpty() {} // 0x00000001824127A0-0x0000000182412870
	[BlackList] // 0x00000001896E5750-0x00000001896E5790
	// [XID] // 0x00000001896E5750-0x00000001896E5790
	public override bool FromJson(JSONNode node) => default; // 0x0000000182411E90-0x0000000182412210
	// [XID] // 0x00000001896EFBA0-0x00000001896EFBC0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182410DA0-0x00000001824110C0
	[BlackList] // 0x00000001896F75B0-0x00000001896F75F0
	// [XID] // 0x00000001896F75B0-0x00000001896F75F0
	public static new TriggerAttackEvent ParseFromJson(JSONNode node) => default; // 0x0000000182412F90-0x00000001824131E0
	// [XID] // 0x0000000189701BC0-0x0000000189701BE0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D11 */, bool useObjectPool = false /* Metadata: 0x00AF3D15 */) => default; // 0x0000000182412A40-0x0000000182412D40
	// [XID] // 0x0000000189709500-0x0000000189709520
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D16 */, bool useObjectPool = false /* Metadata: 0x00AF3D1A */) => default; // 0x0000000182411920-0x0000000182411C30
	// [XID] // 0x0000000189710D30-0x0000000189710D50
	public static new TriggerAttackEvent ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D1B */, bool useObjectPool = false /* Metadata: 0x00AF3D1F */) => default; // 0x00000001824122B0-0x00000001824124D0
	[BlackList] // 0x0000000189718070-0x00000001897180B0
	// [XID] // 0x0000000189718070-0x00000001897180B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001824110C0-0x0000000182411390
	// [XID] // 0x00000001897226C0-0x00000001897226E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001824134A0-0x0000000182413750
	[BlackList] // 0x0000000189729E20-0x0000000189729E60
	// [XID] // 0x0000000189729E20-0x0000000189729E60
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182412950-0x0000000182412A40
	// [XID] // 0x00000001897344D0-0x00000001897344F0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000182413870-0x0000000182413910
	// [XID] // 0x00000001897436B0-0x00000001897436D0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182411C30-0x0000000182411D90
	[BlackList] // 0x00000001897599C0-0x0000000189759A00
	// [XID] // 0x00000001897599C0-0x0000000189759A00
	public override void AutoAllocTypeFields() {} // 0x0000000182411390-0x0000000182411430
	[BlackList] // 0x0000000189764300-0x0000000189764340
	// [XID] // 0x0000000189764300-0x0000000189764340
	public override void AutoRecycleTypeFields() {} // 0x0000000182411430-0x0000000182411570
	[BlackList] // 0x000000018976E8E0-0x000000018976E920
	// [XID] // 0x000000018976E8E0-0x000000018976E920
	public override void ReturnToObjectPool() {} // 0x0000000182413910-0x00000001824139B0
}

