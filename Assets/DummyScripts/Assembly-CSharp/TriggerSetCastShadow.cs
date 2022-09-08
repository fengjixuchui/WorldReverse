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
public class TriggerSetCastShadow : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16525
{
	// Fields
	private bool _castShadow; // 0x68

	// Properties
	public bool castShadow { /* [XID] */ /* 0x00000001899E8260-0x00000001899E8280 */ get => default; /* [XID] */ /* 0x00000001899EF7D0-0x00000001899EF7F0 */ private set {} } // 0x000000018334C5D0-0x000000018334C670 0x000000018334A9D0-0x000000018334AA80
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A7A770-0x0000000189A7A790 */ get => default; } // 0x000000018334BFB0-0x000000018334C050 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A81CD0-0x0000000189A81CF0 */ get => default; } // 0x000000018334B610-0x000000018334B6B0 

	// Constructors
	public TriggerSetCastShadow() {} // 0x000000018334C710-0x000000018334C770

	// Methods
	// [XID] // 0x00000001899F7050-0x00000001899F7070
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018334C440-0x000000018334C530
	// [XID] // 0x00000001899FE790-0x00000001899FE7B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018334C0B0-0x000000018334C160
	// [XID] // 0x0000000189A06030-0x0000000189A06050
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3E26 */) => default; // 0x000000018334BC20-0x000000018334BD00
	// [XID] // 0x0000000189A0D500-0x0000000189A0D520
	public override int GetHashNum() => default; // 0x000000018334A830-0x000000018334A900
	// [XID] // 0x0000000189A14CC0-0x0000000189A14CE0
	public override void InitEmpty() {} // 0x000000018334B6B0-0x000000018334B750
	[BlackList] // 0x0000000189A1BEB0-0x0000000189A1BEF0
	// [XID] // 0x0000000189A1BEB0-0x0000000189A1BEF0
	public override bool FromJson(JSONNode node) => default; // 0x000000018334AF90-0x000000018334B310
	// [XID] // 0x0000000189A26520-0x0000000189A26540
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018334A080-0x000000018334A280
	[BlackList] // 0x0000000189A2D810-0x0000000189A2D850
	// [XID] // 0x0000000189A2D810-0x0000000189A2D850
	public static new TriggerSetCastShadow ParseFromJson(JSONNode node) => default; // 0x000000018334BD60-0x000000018334BFB0
	// [XID] // 0x0000000189A38290-0x0000000189A382B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E27 */, bool useObjectPool = false /* Metadata: 0x00AF3E2B */) => default; // 0x000000018334B920-0x000000018334BC20
	// [XID] // 0x0000000189A3FAA0-0x0000000189A3FAC0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E2C */, bool useObjectPool = false /* Metadata: 0x00AF3E30 */) => default; // 0x000000018334AB00-0x000000018334AD30
	// [XID] // 0x0000000189A47190-0x0000000189A471B0
	public static new TriggerSetCastShadow ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E31 */, bool useObjectPool = false /* Metadata: 0x00AF3E35 */) => default; // 0x000000018334B310-0x000000018334B530
	[BlackList] // 0x0000000189A4EA90-0x0000000189A4EAD0
	// [XID] // 0x0000000189A4EA90-0x0000000189A4EAD0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018334A280-0x000000018334A550
	// [XID] // 0x0000000189A590E0-0x0000000189A59100
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018334C240-0x000000018334C440
	[BlackList] // 0x0000000189A609E0-0x0000000189A60A20
	// [XID] // 0x0000000189A609E0-0x0000000189A60A20
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018334B830-0x000000018334B920
	// [XID] // 0x0000000189A6B3F0-0x0000000189A6B410
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018334C530-0x000000018334C5D0
	// [XID] // 0x0000000189A72C60-0x0000000189A72C80
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018334AD30-0x000000018334AE90
	[BlackList] // 0x0000000189A89790-0x0000000189A897D0
	// [XID] // 0x0000000189A89790-0x0000000189A897D0
	public override void AutoAllocTypeFields() {} // 0x000000018334A550-0x000000018334A5F0
	[BlackList] // 0x0000000189A93AD0-0x0000000189A93B10
	// [XID] // 0x0000000189A93AD0-0x0000000189A93B10
	public override void AutoRecycleTypeFields() {} // 0x000000018334A5F0-0x000000018334A6A0
	[BlackList] // 0x0000000189A9E0D0-0x0000000189A9E110
	// [XID] // 0x0000000189A9E0D0-0x0000000189A9E110
	public override void ReturnToObjectPool() {} // 0x000000018334C670-0x000000018334C710
}

