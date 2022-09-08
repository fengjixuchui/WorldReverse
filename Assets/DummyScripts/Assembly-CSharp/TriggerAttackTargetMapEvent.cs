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
public class TriggerAttackTargetMapEvent : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16492
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAttackTargetMapEvent _attackTargetMapEvent; // 0x68

	// Properties
	public ConfigAttackTargetMapEvent attackTargetMapEvent { /* [XID] */ /* 0x0000000189A2CA00-0x0000000189A2CA20 */ get => default; /* [XID] */ /* 0x000000018978F620-0x000000018978F640 */ private set {} } // 0x000000018124D360-0x000000018124D400 0x000000018124E100-0x000000018124E1B0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189814510-0x0000000189814530 */ get => default; } // 0x000000018124EAE0-0x000000018124EB80 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018981BFE0-0x000000018981C000 */ get => default; } // 0x000000018124E060-0x000000018124E100 

	// Constructors
	public TriggerAttackTargetMapEvent() {} // 0x000000018124F150-0x000000018124F1B0

	// Methods
	// [XID] // 0x0000000189796E30-0x0000000189796E50
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018124EFD0-0x000000018124F0B0
	// [XID] // 0x000000018979EEF0-0x000000018979EF10
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018124EBE0-0x000000018124ECC0
	// [XID] // 0x00000001897A6540-0x00000001897A6560
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3D20 */) => default; // 0x000000018124E750-0x000000018124E830
	// [XID] // 0x00000001897ADA50-0x00000001897ADA70
	public override int GetHashNum() => default; // 0x000000018124D290-0x000000018124D360
	// [XID] // 0x00000001897B5B90-0x00000001897B5BB0
	public override void InitEmpty() {} // 0x000000018124E1B0-0x000000018124E280
	[BlackList] // 0x00000001897BD9A0-0x00000001897BD9E0
	// [XID] // 0x00000001897BD9A0-0x00000001897BD9E0
	public override bool FromJson(JSONNode node) => default; // 0x000000018124DA50-0x000000018124DDD0
	// [XID] // 0x00000001897C82B0-0x00000001897C82D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018124CA20-0x000000018124CC60
	[BlackList] // 0x00000001897CF670-0x00000001897CF6B0
	// [XID] // 0x00000001897CF670-0x00000001897CF6B0
	public static new TriggerAttackTargetMapEvent ParseFromJson(JSONNode node) => default; // 0x000000018124E890-0x000000018124EAE0
	// [XID] // 0x00000001897DA2F0-0x00000001897DA310
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D21 */, bool useObjectPool = false /* Metadata: 0x00AF3D25 */) => default; // 0x000000018124E450-0x000000018124E750
	// [XID] // 0x00000001897E1760-0x00000001897E1780
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D26 */, bool useObjectPool = false /* Metadata: 0x00AF3D2A */) => default; // 0x000000018124D550-0x000000018124D7F0
	// [XID] // 0x00000001897E8F90-0x00000001897E8FB0
	public static new TriggerAttackTargetMapEvent ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D2B */, bool useObjectPool = false /* Metadata: 0x00AF3D2F */) => default; // 0x000000018124DDD0-0x000000018124DFF0
	[BlackList] // 0x00000001897F0B60-0x00000001897F0BA0
	// [XID] // 0x00000001897F0B60-0x00000001897F0BA0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018124CC60-0x000000018124CF30
	// [XID] // 0x00000001897FB550-0x00000001897FB570
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018124EDA0-0x000000018124EFD0
	[BlackList] // 0x0000000189802A00-0x0000000189802A40
	// [XID] // 0x0000000189802A00-0x0000000189802A40
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018124E360-0x000000018124E450
	// [XID] // 0x000000018980CC50-0x000000018980CC70
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018124D7F0-0x000000018124D950
	[BlackList] // 0x0000000189823410-0x0000000189823450
	// [XID] // 0x0000000189823410-0x0000000189823450
	public override void AutoAllocTypeFields() {} // 0x000000018124CF30-0x000000018124CFD0
	[BlackList] // 0x000000018982DC00-0x000000018982DC40
	// [XID] // 0x000000018982DC00-0x000000018982DC40
	public override void AutoRecycleTypeFields() {} // 0x000000018124CFD0-0x000000018124D100
	[BlackList] // 0x00000001898382C0-0x0000000189838300
	// [XID] // 0x00000001898382C0-0x0000000189838300
	public override void ReturnToObjectPool() {} // 0x000000018124F0B0-0x000000018124F150
}

