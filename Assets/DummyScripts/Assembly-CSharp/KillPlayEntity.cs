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
public class KillPlayEntity : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16801
{
	// Properties
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001898C2E00-0x00000001898C2E20 */ get => default; } // 0x00000001821EAA40-0x00000001821EAAE0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001898CA740-0x00000001898CA760 */ get => default; } // 0x00000001821EA090-0x00000001821EA130 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x00000001898D1ED0-0x00000001898D1EF0 */ get => default; } // 0x00000001821E9540-0x00000001821E95E0 

	// Constructors
	public KillPlayEntity() {} // 0x00000001821EAF80-0x00000001821EAFE0

	// Methods
	// [XID] // 0x0000000189848300-0x0000000189848320
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001821EAE30-0x00000001821EAEE0
	// [XID] // 0x000000018984FA80-0x000000018984FAA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001821EABB0-0x00000001821EAC60
	// [XID] // 0x0000000189856E20-0x0000000189856E40
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF46BE */) => default; // 0x00000001821EA6B0-0x00000001821EA790
	// [XID] // 0x000000018985DF50-0x000000018985DF70
	public override int GetHashNum() => default; // 0x00000001821E9470-0x00000001821E9540
	// [XID] // 0x0000000189865990-0x00000001898659B0
	public override void InitEmpty() {} // 0x00000001821EA130-0x00000001821EA1D0
	[BlackList] // 0x000000018986CE70-0x000000018986CEB0
	// [XID] // 0x000000018986CE70-0x000000018986CEB0
	public override bool FromJson(JSONNode node) => default; // 0x00000001821E9A80-0x00000001821E9E00
	// [XID] // 0x0000000189877530-0x0000000189877550
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001821E8DE0-0x00000001821E8ED0
	[BlackList] // 0x000000018987EDA0-0x000000018987EDE0
	// [XID] // 0x000000018987EDA0-0x000000018987EDE0
	public static new KillPlayEntity ParseFromJson(JSONNode node) => default; // 0x00000001821EA7F0-0x00000001821EAA40
	// [XID] // 0x0000000189889180-0x00000001898891A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF46BF */, bool useObjectPool = false /* Metadata: 0x00AF46C3 */) => default; // 0x00000001821EA3B0-0x00000001821EA6B0
	// [XID] // 0x0000000189890560-0x0000000189890580
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF46C4 */, bool useObjectPool = false /* Metadata: 0x00AF46C8 */) => default; // 0x00000001821E9730-0x00000001821E9860
	// [XID] // 0x0000000189897A60-0x0000000189897A80
	public static new KillPlayEntity ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF46C9 */, bool useObjectPool = false /* Metadata: 0x00AF46CD */) => default; // 0x00000001821E9E00-0x00000001821EA020
	[BlackList] // 0x000000018989EEC0-0x000000018989EF00
	// [XID] // 0x000000018989EEC0-0x000000018989EF00
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001821E8ED0-0x00000001821E91A0
	// [XID] // 0x00000001898A9790-0x00000001898A97B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001821EAD40-0x00000001821EAE30
	[BlackList] // 0x00000001898B1000-0x00000001898B1040
	// [XID] // 0x00000001898B1000-0x00000001898B1040
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001821EA2B0-0x00000001821EA3B0
	// [XID] // 0x00000001898BB9F0-0x00000001898BBA10
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001821E9860-0x00000001821E9980
	[BlackList] // 0x00000001898D9750-0x00000001898D9790
	// [XID] // 0x00000001898D9750-0x00000001898D9790
	public override void AutoAllocTypeFields() {} // 0x00000001821E91A0-0x00000001821E9240
	[BlackList] // 0x00000001898E4380-0x00000001898E43C0
	// [XID] // 0x00000001898E4380-0x00000001898E43C0
	public override void AutoRecycleTypeFields() {} // 0x00000001821E9240-0x00000001821E92E0
	[BlackList] // 0x00000001898EEF00-0x00000001898EEF40
	// [XID] // 0x00000001898EEF00-0x00000001898EEF40
	public override void ReturnToObjectPool() {} // 0x00000001821EAEE0-0x00000001821EAF80
}

