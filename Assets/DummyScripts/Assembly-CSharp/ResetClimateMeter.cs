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
public class ResetClimateMeter : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16767
{
	// Fields
	private JsonClimateType _climateType; // 0x68

	// Properties
	public JsonClimateType climateType { /* [XID] */ /* 0x0000000189905780-0x00000001899057A0 */ get => default; /* [XID] */ /* 0x000000018990CF90-0x000000018990CFB0 */ private set {} } // 0x000000018465C650-0x000000018465C6F0 0x000000018465C6F0-0x000000018465C7A0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189990F90-0x0000000189990FB0 */ get => default; } // 0x000000018465D150-0x000000018465D1F0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189998A10-0x0000000189998A30 */ get => default; } // 0x000000018465C7A0-0x000000018465C840 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x00000001899A0350-0x00000001899A0370 */ get => default; } // 0x000000018465BA00-0x000000018465BAA0 

	// Constructors
	public ResetClimateMeter() {} // 0x000000018465D7E0-0x000000018465D840

	// Methods
	// [XID] // 0x0000000189914780-0x00000001899147A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018465D650-0x000000018465D740
	// [XID] // 0x000000018991C360-0x000000018991C380
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018465D2C0-0x000000018465D370
	// [XID] // 0x0000000189923A80-0x0000000189923AA0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF459E */) => default; // 0x000000018465CDC0-0x000000018465CEA0
	// [XID] // 0x000000018992B120-0x000000018992B140
	public override int GetHashNum() => default; // 0x000000018465B930-0x000000018465BA00
	// [XID] // 0x0000000189932780-0x00000001899327A0
	public override void InitEmpty() {} // 0x000000018465C840-0x000000018465C8E0
	[BlackList] // 0x000000018993A150-0x000000018993A190
	// [XID] // 0x000000018993A150-0x000000018993A190
	public override bool FromJson(JSONNode node) => default; // 0x000000018465C040-0x000000018465C3C0
	// [XID] // 0x0000000189944600-0x0000000189944620
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018465B160-0x000000018465B380
	[BlackList] // 0x000000018994BBE0-0x000000018994BC20
	// [XID] // 0x000000018994BBE0-0x000000018994BC20
	public static new ResetClimateMeter ParseFromJson(JSONNode node) => default; // 0x000000018465CF00-0x000000018465D150
	// [XID] // 0x0000000189956160-0x0000000189956180
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF459F */, bool useObjectPool = false /* Metadata: 0x00AF45A3 */) => default; // 0x000000018465CAC0-0x000000018465CDC0
	// [XID] // 0x000000018995DC90-0x000000018995DCB0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF45A4 */, bool useObjectPool = false /* Metadata: 0x00AF45A8 */) => default; // 0x000000018465BBF0-0x000000018465BE20
	// [XID] // 0x00000001899654D0-0x00000001899654F0
	public static new ResetClimateMeter ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF45A9 */, bool useObjectPool = false /* Metadata: 0x00AF45AD */) => default; // 0x000000018465C3C0-0x000000018465C5E0
	[BlackList] // 0x000000018996CAB0-0x000000018996CAF0
	// [XID] // 0x000000018996CAB0-0x000000018996CAF0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018465B380-0x000000018465B650
	// [XID] // 0x00000001899774A0-0x00000001899774C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018465D450-0x000000018465D650
	[BlackList] // 0x000000018997E7E0-0x000000018997E820
	// [XID] // 0x000000018997E7E0-0x000000018997E820
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018465C9C0-0x000000018465CAC0
	// [XID] // 0x00000001899896E0-0x0000000189989700
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018465BE20-0x000000018465BF40
	[BlackList] // 0x00000001899A7EE0-0x00000001899A7F20
	// [XID] // 0x00000001899A7EE0-0x00000001899A7F20
	public override void AutoAllocTypeFields() {} // 0x000000018465B650-0x000000018465B6F0
	[BlackList] // 0x00000001899B27D0-0x00000001899B2810
	// [XID] // 0x00000001899B27D0-0x00000001899B2810
	public override void AutoRecycleTypeFields() {} // 0x000000018465B6F0-0x000000018465B7A0
	[BlackList] // 0x00000001899BCBB0-0x00000001899BCBF0
	// [XID] // 0x00000001899BCBB0-0x00000001899BCBF0
	public override void ReturnToObjectPool() {} // 0x000000018465D740-0x000000018465D7E0
}

