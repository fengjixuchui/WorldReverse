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
public class ActTimeSlow : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16461
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigTimeSlow _timeSlow; // 0x68
	private bool _isGlobal; // 0x70
	public MPTimeSlowType MPType; // 0x74

	// Properties
	public ConfigTimeSlow timeSlow { /* [XID] */ /* 0x0000000189B7D540-0x0000000189B7D560 */ get => default; /* [XID] */ /* 0x0000000189B85290-0x0000000189B852B0 */ private set {} } // 0x0000000183C1B740-0x0000000183C1B7E0 0x0000000183C1D470-0x0000000183C1D520
	public bool isGlobal { /* [XID] */ /* 0x0000000189B8C0A0-0x0000000189B8C0C0 */ get => default; /* [XID] */ /* 0x0000000189B938B0-0x0000000189B938D0 */ private set {} } // 0x0000000183C1CA30-0x0000000183C1CAD0 0x0000000183C1CF50-0x0000000183C1D000
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189632980-0x00000001896329A0 */ get => default; } // 0x0000000183C1C990-0x0000000183C1CA30 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018963A470-0x000000018963A490 */ get => default; } // 0x0000000183C1BE60-0x0000000183C1BF00 

	// Nested types
	public enum MPTimeSlowType // TypeDefIndex: 16462
	{
		Normal = 0,
		ForceLocal = 1,
		ForceSynced = 2
	}

	// Constructors
	public ActTimeSlow() {} // 0x0000000183C1D5C0-0x0000000183C1D630

	// Methods
	// [XID] // 0x0000000189B9AE40-0x0000000189B9AE60
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183C1D2B0-0x0000000183C1D3D0
	// [XID] // 0x0000000189BA26B0-0x0000000189BA26D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183C1CB30-0x0000000183C1CC10
	// [XID] // 0x0000000189BA9B00-0x0000000189BA9B20
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3C24 */) => default; // 0x0000000183C1C4A0-0x0000000183C1C580
	// [XID] // 0x0000000189BB1390-0x0000000189BB13B0
	public override int GetHashNum() => default; // 0x0000000183C1AFB0-0x0000000183C1B080
	// [XID] // 0x0000000189BB8420-0x0000000189BB8440
	public override void InitEmpty() {} // 0x0000000183C1BF00-0x0000000183C1BFD0
	[BlackList] // 0x0000000189BBFC70-0x0000000189BBFCB0
	// [XID] // 0x0000000189BBFC70-0x0000000189BBFCB0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183C1B7E0-0x0000000183C1BB60
	// [XID] // 0x0000000189BCABF0-0x0000000189BCAC10
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183C1A660-0x0000000183C1A970
	[BlackList] // 0x0000000189BD2220-0x0000000189BD2260
	// [XID] // 0x0000000189BD2220-0x0000000189BD2260
	public static new ActTimeSlow ParseFromJson(JSONNode node) => default; // 0x0000000183C1C740-0x0000000183C1C990
	// [XID] // 0x0000000189BDCC60-0x0000000189BDCC80
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C25 */, bool useObjectPool = false /* Metadata: 0x00AF3C29 */) => default; // 0x0000000183C1C1A0-0x0000000183C1C4A0
	// [XID] // 0x00000001895E9410-0x00000001895E9430
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C2A */, bool useObjectPool = false /* Metadata: 0x00AF3C2E */) => default; // 0x0000000183C1B1D0-0x0000000183C1B4E0
	// [XID] // 0x00000001895F0C20-0x00000001895F0C40
	public static new ActTimeSlow ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C2F */, bool useObjectPool = false /* Metadata: 0x00AF3C33 */) => default; // 0x0000000183C1BB60-0x0000000183C1BD80
	[BlackList] // 0x00000001895F85F0-0x00000001895F8630
	// [XID] // 0x00000001895F85F0-0x00000001895F8630
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183C1A970-0x0000000183C1AC40
	// [XID] // 0x0000000189602BD0-0x0000000189602BF0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183C1D000-0x0000000183C1D2B0
	[BlackList] // 0x000000018960A4F0-0x000000018960A530
	// [XID] // 0x000000018960A4F0-0x000000018960A530
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183C1C0B0-0x0000000183C1C1A0
	// [XID] // 0x0000000189614BE0-0x0000000189614C00
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183C1D3D0-0x0000000183C1D470
	// [XID] // 0x000000018961C4E0-0x000000018961C500
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183C1B4E0-0x0000000183C1B640
	// [XID] // 0x00000001896238C0-0x00000001896238E0
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000183C1CDD0-0x0000000183C1CF50
	// [XID] // 0x000000018962B1E0-0x000000018962B200
	public override void CallRemote(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000183C1C5E0-0x0000000183C1C740
	[BlackList] // 0x00000001896419A0-0x00000001896419E0
	// [XID] // 0x00000001896419A0-0x00000001896419E0
	public override void AutoAllocTypeFields() {} // 0x0000000183C1AC40-0x0000000183C1ACE0
	[BlackList] // 0x000000018964C350-0x000000018964C390
	// [XID] // 0x000000018964C350-0x000000018964C390
	public override void AutoRecycleTypeFields() {} // 0x0000000183C1ACE0-0x0000000183C1AE20
	[BlackList] // 0x0000000189656950-0x0000000189656990
	// [XID] // 0x0000000189656950-0x0000000189656990
	public override void ReturnToObjectPool() {} // 0x0000000183C1D520-0x0000000183C1D5C0
}

