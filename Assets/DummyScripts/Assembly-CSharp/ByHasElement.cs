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
public class ByHasElement : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17202
{
	// Fields
	private ElementType _element; // 0x18

	// Properties
	public ElementType element { /* [XID] */ /* 0x0000000189A1ED70-0x0000000189A1ED90 */ get => default; /* [XID] */ /* 0x0000000189A263E0-0x0000000189A26400 */ private set {} } // 0x0000000180F21120-0x0000000180F211C0 0x0000000180F21C80-0x0000000180F21D30

	// Constructors
	public ByHasElement() {} // 0x0000000180F220C0-0x0000000180F22120

	// Methods
	// [XID] // 0x0000000189A2D6B0-0x0000000189A2D6D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000180F21F30-0x0000000180F22020
	// [XID] // 0x0000000189A351F0-0x0000000189A35210
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000180F21B20-0x0000000180F21BD0
	// [XID] // 0x0000000189A3C780-0x0000000189A3C7A0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6677 */) => default; // 0x0000000180F21730-0x0000000180F21810
	// [XID] // 0x0000000189A44210-0x0000000189A44230
	public override int GetHashNum() => default; // 0x0000000180F20500-0x0000000180F205D0
	// [XID] // 0x0000000189A4B720-0x0000000189A4B740
	public override void InitEmpty() {} // 0x0000000180F211C0-0x0000000180F21260
	[BlackList] // 0x0000000189A52E80-0x0000000189A52EC0
	// [XID] // 0x0000000189A52E80-0x0000000189A52EC0
	public override bool FromJson(JSONNode node) => default; // 0x0000000180F20B10-0x0000000180F20E90
	// [XID] // 0x0000000189A5DAA0-0x0000000189A5DAC0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000180F1FDA0-0x0000000180F1FFC0
	[BlackList] // 0x0000000189A65240-0x0000000189A65280
	// [XID] // 0x0000000189A65240-0x0000000189A65280
	public static new ByHasElement ParseFromJson(JSONNode node) => default; // 0x0000000180F21870-0x0000000180F21AC0
	// [XID] // 0x0000000189A6FA20-0x0000000189A6FA40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6678 */, bool useObjectPool = false /* Metadata: 0x00AF667C */) => default; // 0x0000000180F21430-0x0000000180F21730
	// [XID] // 0x0000000189A771F0-0x0000000189A77210
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF667D */, bool useObjectPool = false /* Metadata: 0x00AF6681 */) => default; // 0x0000000180F206B0-0x0000000180F208E0
	// [XID] // 0x0000000189A7EB80-0x0000000189A7EBA0
	public static new ByHasElement ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6682 */, bool useObjectPool = false /* Metadata: 0x00AF6686 */) => default; // 0x0000000180F20E90-0x0000000180F210B0
	[BlackList] // 0x0000000189A86390-0x0000000189A863D0
	// [XID] // 0x0000000189A86390-0x0000000189A863D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000180F1FFC0-0x0000000180F20290
	// [XID] // 0x0000000189A90DF0-0x0000000189A90E10
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000180F21D30-0x0000000180F21F30
	[BlackList] // 0x0000000189A985C0-0x0000000189A98600
	// [XID] // 0x0000000189A985C0-0x0000000189A98600
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000180F21340-0x0000000180F21430
	// [XID] // 0x0000000189AA2880-0x0000000189AA28A0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180F208E0-0x0000000180F20A10
	[BlackList] // 0x0000000189AA9EE0-0x0000000189AA9F20
	// [XID] // 0x0000000189AA9EE0-0x0000000189AA9F20
	public override void AutoAllocTypeFields() {} // 0x0000000180F20290-0x0000000180F20330
	[BlackList] // 0x0000000189AB49F0-0x0000000189AB4A30
	// [XID] // 0x0000000189AB49F0-0x0000000189AB4A30
	public override void AutoRecycleTypeFields() {} // 0x0000000180F20330-0x0000000180F203E0
	[BlackList] // 0x0000000189ABF3D0-0x0000000189ABF410
	// [XID] // 0x0000000189ABF3D0-0x0000000189ABF410
	public override void ReturnToObjectPool() {} // 0x0000000180F22020-0x0000000180F220C0
}

