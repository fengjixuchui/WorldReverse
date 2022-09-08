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
public class TryFindBlinkPointByBorn : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16555
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x68
	private bool _hitSceneTest; // 0x70
	private BlinkHitSceneTestType _hitSceneType; // 0x74
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _limitY; // 0x78

	// Properties
	public ConfigBornType born { /* [XID] */ /* 0x00000001899B81D0-0x00000001899B81F0 */ get => default; /* [XID] */ /* 0x00000001899BFCF0-0x00000001899BFD10 */ private set {} } // 0x0000000184A3B1F0-0x0000000184A3B290 0x0000000184A3D740-0x0000000184A3D7F0
	public bool hitSceneTest { /* [XID] */ /* 0x00000001899C74F0-0x00000001899C7510 */ get => default; /* [XID] */ /* 0x00000001899CEBC0-0x00000001899CEBE0 */ private set {} } // 0x0000000184A3D890-0x0000000184A3D930 0x0000000184A3C710-0x0000000184A3C7C0
	public BlinkHitSceneTestType hitSceneType { /* [XID] */ /* 0x00000001899D62D0-0x00000001899D62F0 */ get => default; /* [XID] */ /* 0x00000001899DD780-0x00000001899DD7A0 */ private set {} } // 0x0000000184A3B8B0-0x0000000184A3B950 0x0000000184A3A7F0-0x0000000184A3A8A0
	public DynamicFloat limitY { /* [XID] */ /* 0x00000001899E54E0-0x00000001899E5500 */ get => default; /* [XID] */ /* 0x00000001899EC7D0-0x00000001899EC7F0 */ private set {} } // 0x0000000184A3B0E0-0x0000000184A3B180 0x0000000184A3B030-0x0000000184A3B0E0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A77330-0x0000000189A77350 */ get => default; } // 0x0000000184A3CCB0-0x0000000184A3CD50 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A7EC60-0x0000000189A7EC80 */ get => default; } // 0x0000000184A3C0D0-0x0000000184A3C170 

	// Constructors
	public TryFindBlinkPointByBorn() {} // 0x0000000184A3D9D0-0x0000000184A3DA70

	// Methods
	// [XID] // 0x00000001899F44B0-0x00000001899F44D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184A3D5D0-0x0000000184A3D740
	// [XID] // 0x00000001899FBAB0-0x00000001899FBAD0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184A3CDB0-0x0000000184A3CEB0
	// [XID] // 0x0000000189A02EF0-0x0000000189A02F10
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3F0E */) => default; // 0x0000000184A3C7C0-0x0000000184A3C8A0
	// [XID] // 0x0000000189A0A4C0-0x0000000189A0A4E0
	public override int GetHashNum() => default; // 0x0000000184A3AF60-0x0000000184A3B030
	// [XID] // 0x0000000189A11DE0-0x0000000189A11E00
	public override void InitEmpty() {} // 0x0000000184A3C170-0x0000000184A3C240
	[BlackList] // 0x0000000189A19070-0x0000000189A190B0
	// [XID] // 0x0000000189A19070-0x0000000189A190B0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184A3BA50-0x0000000184A3BDD0
	// [XID] // 0x0000000189A23700-0x0000000189A23720
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184A3A390-0x0000000184A3A7F0
	[BlackList] // 0x0000000189A2AB60-0x0000000189A2ABA0
	// [XID] // 0x0000000189A2AB60-0x0000000189A2ABA0
	public static new TryFindBlinkPointByBorn ParseFromJson(JSONNode node) => default; // 0x0000000184A3CA60-0x0000000184A3CCB0
	// [XID] // 0x0000000189A353F0-0x0000000189A35410
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F0F */, bool useObjectPool = false /* Metadata: 0x00AF3F13 */) => default; // 0x0000000184A3C410-0x0000000184A3C710
	// [XID] // 0x0000000189A3C900-0x0000000189A3C920
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F14 */, bool useObjectPool = false /* Metadata: 0x00AF3F18 */) => default; // 0x0000000184A3B370-0x0000000184A3B750
	// [XID] // 0x0000000189A44370-0x0000000189A44390
	public static new TryFindBlinkPointByBorn ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F19 */, bool useObjectPool = false /* Metadata: 0x00AF3F1D */) => default; // 0x0000000184A3BDD0-0x0000000184A3BFF0
	[BlackList] // 0x0000000189A4B940-0x0000000189A4B980
	// [XID] // 0x0000000189A4B940-0x0000000189A4B980
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184A3A8A0-0x0000000184A3AB70
	// [XID] // 0x0000000189A56120-0x0000000189A56140
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184A3D1F0-0x0000000184A3D5D0
	[BlackList] // 0x0000000189A5DC00-0x0000000189A5DC40
	// [XID] // 0x0000000189A5DC00-0x0000000189A5DC40
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184A3C320-0x0000000184A3C410
	// [XID] // 0x0000000189A68810-0x0000000189A68830
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184A3D7F0-0x0000000184A3D890
	// [XID] // 0x0000000189A6FB80-0x0000000189A6FBA0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184A3B750-0x0000000184A3B8B0
	// [XID] // 0x0000000189A86470-0x0000000189A86490
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000184A3D070-0x0000000184A3D1F0
	// [XID] // 0x0000000189A8DEF0-0x0000000189A8DF10
	public override void CallRemote(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000184A3C900-0x0000000184A3CA60
	[BlackList] // 0x0000000189A95470-0x0000000189A954B0
	// [XID] // 0x0000000189A95470-0x0000000189A954B0
	public override void AutoAllocTypeFields() {} // 0x0000000184A3AB70-0x0000000184A3AC10
	[BlackList] // 0x0000000189A9FB30-0x0000000189A9FB70
	// [XID] // 0x0000000189A9FB30-0x0000000189A9FB70
	public override void AutoRecycleTypeFields() {} // 0x0000000184A3AC10-0x0000000184A3ADD0
	[BlackList] // 0x0000000189AA9FA0-0x0000000189AA9FE0
	// [XID] // 0x0000000189AA9FA0-0x0000000189AA9FE0
	public override void ReturnToObjectPool() {} // 0x0000000184A3D930-0x0000000184A3D9D0
}

