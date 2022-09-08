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
public class AttachToMonsterAirStateMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16880
{
	// Fields
	private string _modifierName; // 0x30
	private bool _IsAirMove; // 0x38

	// Properties
	public string modifierName { /* [XID] */ /* 0x0000000189680E00-0x0000000189680E20 */ get => default; /* [XID] */ /* 0x0000000189688820-0x0000000189688840 */ private set {} } // 0x000000018327DB90-0x000000018327DC30 0x000000018327CCF0-0x000000018327CDA0
	public bool IsAirMove { /* [XID] */ /* 0x0000000189690200-0x0000000189690220 */ get => default; /* [XID] */ /* 0x0000000189697B80-0x0000000189697BA0 */ private set {} } // 0x000000018327BAF0-0x000000018327BB90 0x000000018327D270-0x000000018327D320
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189719B50-0x0000000189719B70 */ get => default; } // 0x000000018327C390-0x000000018327C430 

	// Constructors
	public AttachToMonsterAirStateMixin() {} // 0x000000018327DCD0-0x000000018327DD40

	// Methods
	// [XID] // 0x000000018969EEF0-0x000000018969EF10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018327DA80-0x000000018327DB90
	// [XID] // 0x00000001896A6390-0x00000001896A63B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018327D710-0x000000018327D7F0
	// [XID] // 0x00000001896AD910-0x00000001896AD930
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5C49 */) => default; // 0x000000018327D320-0x000000018327D400
	// [XID] // 0x00000001896B5050-0x00000001896B5070
	public override int GetHashNum() => default; // 0x000000018327BE00-0x000000018327BED0
	// [XID] // 0x00000001896BC2E0-0x00000001896BC300
	public override void InitEmpty() {} // 0x000000018327CB40-0x000000018327CC10
	[BlackList] // 0x00000001896C3760-0x00000001896C37A0
	// [XID] // 0x00000001896C3760-0x00000001896C37A0
	public override bool FromJson(JSONNode node) => default; // 0x000000018327C430-0x000000018327C7B0
	// [XID] // 0x00000001896CDE70-0x00000001896CDE90
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018327B530-0x000000018327B820
	[BlackList] // 0x00000001896D53A0-0x00000001896D53E0
	// [XID] // 0x00000001896D53A0-0x00000001896D53E0
	public static new AttachToMonsterAirStateMixin ParseFromJson(JSONNode node) => default; // 0x000000018327D460-0x000000018327D6B0
	// [XID] // 0x00000001896DFBE0-0x00000001896DFC00
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C4A */, bool useObjectPool = false /* Metadata: 0x00AF5C4E */) => default; // 0x000000018327CE90-0x000000018327D190
	// [XID] // 0x00000001896E6F80-0x00000001896E6FA0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C4F */, bool useObjectPool = false /* Metadata: 0x00AF5C53 */) => default; // 0x000000018327BFB0-0x000000018327C290
	// [XID] // 0x00000001896EE4F0-0x00000001896EE510
	public static new AttachToMonsterAirStateMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C54 */, bool useObjectPool = false /* Metadata: 0x00AF5C58 */) => default; // 0x000000018327C820-0x000000018327CA40
	[BlackList] // 0x00000001896F5DE0-0x00000001896F5E20
	// [XID] // 0x00000001896F5DE0-0x00000001896F5E20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018327B820-0x000000018327BAF0
	// [XID] // 0x0000000189700200-0x0000000189700220
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018327D7F0-0x000000018327DA80
	[BlackList] // 0x00000001897079F0-0x0000000189707A30
	// [XID] // 0x00000001897079F0-0x0000000189707A30
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018327CDA0-0x000000018327CE90
	// [XID] // 0x0000000189712450-0x0000000189712470
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x000000018327D190-0x000000018327D270
	[BlackList] // 0x00000001897210F0-0x0000000189721130
	// [XID] // 0x00000001897210F0-0x0000000189721130
	public override void AutoAllocTypeFields() {} // 0x000000018327BB90-0x000000018327BC30
	[BlackList] // 0x000000018972B550-0x000000018972B590
	// [XID] // 0x000000018972B550-0x000000018972B590
	public override void AutoRecycleTypeFields() {} // 0x000000018327BC30-0x000000018327BCE0
	[BlackList] // 0x0000000189735CE0-0x0000000189735D20
	// [XID] // 0x0000000189735CE0-0x0000000189735D20
	public override void ReturnToObjectPool() {} // 0x000000018327DC30-0x000000018327DCD0
}

