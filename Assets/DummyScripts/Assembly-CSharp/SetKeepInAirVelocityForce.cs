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
public class SetKeepInAirVelocityForce : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16639
{
	// Fields
	private bool _setEnable; // 0x68

	// Properties
	public bool setEnable { /* [XID] */ /* 0x00000001899CEBA0-0x00000001899CEBC0 */ get => default; /* [XID] */ /* 0x00000001899D62B0-0x00000001899D62D0 */ private set {} } // 0x000000018466C9D0-0x000000018466CA70 0x000000018466D6B0-0x000000018466D760
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A609C0-0x0000000189A609E0 */ get => default; } // 0x000000018466D420-0x000000018466D4C0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A687F0-0x0000000189A68810 */ get => default; } // 0x000000018466CA70-0x000000018466CB10 

	// Constructors
	public SetKeepInAirVelocityForce() {} // 0x000000018466DB90-0x000000018466DBF0

	// Methods
	// [XID] // 0x00000001899DD740-0x00000001899DD760
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018466D960-0x000000018466DA50
	// [XID] // 0x00000001899E5480-0x00000001899E54A0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018466D520-0x000000018466D5D0
	// [XID] // 0x00000001899EC770-0x00000001899EC790
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF41AA */) => default; // 0x000000018466D090-0x000000018466D170
	// [XID] // 0x00000001899F4490-0x00000001899F44B0
	public override int GetHashNum() => default; // 0x000000018466BCA0-0x000000018466BD70
	// [XID] // 0x00000001899FBA90-0x00000001899FBAB0
	public override void InitEmpty() {} // 0x000000018466CB10-0x000000018466CBB0
	[BlackList] // 0x0000000189A02EB0-0x0000000189A02EF0
	// [XID] // 0x0000000189A02EB0-0x0000000189A02EF0
	public override bool FromJson(JSONNode node) => default; // 0x000000018466C350-0x000000018466C6D0
	// [XID] // 0x0000000189A0D4A0-0x0000000189A0D4C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018466B4F0-0x000000018466B6F0
	[BlackList] // 0x0000000189A14C80-0x0000000189A14CC0
	// [XID] // 0x0000000189A14C80-0x0000000189A14CC0
	public static new SetKeepInAirVelocityForce ParseFromJson(JSONNode node) => default; // 0x000000018466D1D0-0x000000018466D420
	// [XID] // 0x0000000189A1EE70-0x0000000189A1EE90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF41AB */, bool useObjectPool = false /* Metadata: 0x00AF41AF */) => default; // 0x000000018466CD90-0x000000018466D090
	// [XID] // 0x0000000189A264C0-0x0000000189A264E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF41B0 */, bool useObjectPool = false /* Metadata: 0x00AF41B4 */) => default; // 0x000000018466BEC0-0x000000018466C0F0
	// [XID] // 0x0000000189A2D7B0-0x0000000189A2D7D0
	public static new SetKeepInAirVelocityForce ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF41B5 */, bool useObjectPool = false /* Metadata: 0x00AF41B9 */) => default; // 0x000000018466C6D0-0x000000018466C8F0
	[BlackList] // 0x0000000189A35390-0x0000000189A353D0
	// [XID] // 0x0000000189A35390-0x0000000189A353D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018466B6F0-0x000000018466B9C0
	// [XID] // 0x0000000189A3FA40-0x0000000189A3FA60
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018466D760-0x000000018466D960
	[BlackList] // 0x0000000189A47150-0x0000000189A47190
	// [XID] // 0x0000000189A47150-0x0000000189A47190
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018466CC90-0x000000018466CD90
	// [XID] // 0x0000000189A51870-0x0000000189A51890
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018466DA50-0x000000018466DAF0
	// [XID] // 0x0000000189A590C0-0x0000000189A590E0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018466C0F0-0x000000018466C250
	[BlackList] // 0x0000000189A6FB40-0x0000000189A6FB80
	// [XID] // 0x0000000189A6FB40-0x0000000189A6FB80
	public override void AutoAllocTypeFields() {} // 0x000000018466B9C0-0x000000018466BA60
	[BlackList] // 0x0000000189A7A710-0x0000000189A7A750
	// [XID] // 0x0000000189A7A710-0x0000000189A7A750
	public override void AutoRecycleTypeFields() {} // 0x000000018466BA60-0x000000018466BB10
	[BlackList] // 0x0000000189A84CE0-0x0000000189A84D20
	// [XID] // 0x0000000189A84CE0-0x0000000189A84D20
	public override void ReturnToObjectPool() {} // 0x000000018466DAF0-0x000000018466DB90
}

