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
public class SetEntityScale : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16739
{
	// Fields
	private SimpleSafeFloat scaleRawNum; // 0x68

	// Properties
	public float scale { /* [XID] */ /* 0x00000001898891A0-0x00000001898891C0 */ get => default; /* [XID] */ /* 0x00000001898905C0-0x00000001898905E0 */ private set {} } // 0x000000018358F020-0x000000018358F100 0x0000000183590160-0x0000000183590240
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018991C380-0x000000018991C3A0 */ get => default; } // 0x000000018358FBD0-0x000000018358FC70 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189923AA0-0x0000000189923AC0 */ get => default; } // 0x000000018358F1E0-0x000000018358F280 

	// Constructors
	public SetEntityScale() {} // 0x0000000183590380-0x0000000183590420

	// Methods
	// [XID] // 0x0000000189897A80-0x0000000189897AA0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183590060-0x0000000183590160
	// [XID] // 0x000000018989EF00-0x000000018989EF20
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018358FCD0-0x000000018358FD80
	// [XID] // 0x00000001898A69C0-0x00000001898A69E0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF44BE */) => default; // 0x000000018358F840-0x000000018358F920
	// [XID] // 0x00000001898AE110-0x00000001898AE130
	public override int GetHashNum() => default; // 0x000000018358E3D0-0x000000018358E4A0
	// [XID] // 0x00000001898B56B0-0x00000001898B56D0
	public override void InitEmpty() {} // 0x000000018358F280-0x000000018358F360
	[BlackList] // 0x00000001898BD0C0-0x00000001898BD100
	// [XID] // 0x00000001898BD0C0-0x00000001898BD100
	public override bool FromJson(JSONNode node) => default; // 0x000000018358EA80-0x000000018358EE00
	// [XID] // 0x00000001898C7820-0x00000001898C7840
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018358DBA0-0x000000018358DDF0
	[BlackList] // 0x00000001898CEEB0-0x00000001898CEEF0
	// [XID] // 0x00000001898CEEB0-0x00000001898CEEF0
	public static new SetEntityScale ParseFromJson(JSONNode node) => default; // 0x000000018358F980-0x000000018358FBD0
	// [XID] // 0x00000001898D9790-0x00000001898D97B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF44BF */, bool useObjectPool = false /* Metadata: 0x00AF44C3 */) => default; // 0x000000018358F540-0x000000018358F840
	// [XID] // 0x00000001898E14F0-0x00000001898E1510
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF44C4 */, bool useObjectPool = false /* Metadata: 0x00AF44C8 */) => default; // 0x000000018358E5F0-0x000000018358E820
	// [XID] // 0x00000001898E8F60-0x00000001898E8F80
	public static new SetEntityScale ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF44C9 */, bool useObjectPool = false /* Metadata: 0x00AF44CD */) => default; // 0x000000018358EE00-0x000000018358F020
	[BlackList] // 0x00000001898F06A0-0x00000001898F06E0
	// [XID] // 0x00000001898F06A0-0x00000001898F06E0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018358DDF0-0x000000018358E0C0
	// [XID] // 0x00000001898FACC0-0x00000001898FACE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018358FE60-0x0000000183590060
	[BlackList] // 0x0000000189902820-0x0000000189902860
	// [XID] // 0x0000000189902820-0x0000000189902860
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018358F440-0x000000018358F540
	// [XID] // 0x000000018990CFB0-0x000000018990CFD0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183590240-0x00000001835902E0
	// [XID] // 0x00000001899147A0-0x00000001899147C0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018358E820-0x000000018358E980
	[BlackList] // 0x000000018992B140-0x000000018992B180
	// [XID] // 0x000000018992B140-0x000000018992B180
	public override void AutoAllocTypeFields() {} // 0x000000018358E0C0-0x000000018358E160
	[BlackList] // 0x00000001899354B0-0x00000001899354F0
	// [XID] // 0x00000001899354B0-0x00000001899354F0
	public override void AutoRecycleTypeFields() {} // 0x000000018358E160-0x000000018358E240
	[BlackList] // 0x000000018993FDE0-0x000000018993FE20
	// [XID] // 0x000000018993FDE0-0x000000018993FE20
	public override void ReturnToObjectPool() {} // 0x00000001835902E0-0x0000000183590380
}

