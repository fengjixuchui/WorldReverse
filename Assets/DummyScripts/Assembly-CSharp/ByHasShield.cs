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
public class ByHasShield : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17342
{
	// Fields
	private HasShieldType _type; // 0x18
	private bool _usePotentShield; // 0x1C
	private ElementType _potentShieldType; // 0x20

	// Properties
	public HasShieldType type { /* [XID] */ /* 0x00000001899BCAD0-0x00000001899BCAF0 */ get => default; /* [XID] */ /* 0x00000001899C44E0-0x00000001899C4500 */ private set {} } // 0x000000018248FC60-0x000000018248FD00 0x000000018248F6C0-0x000000018248F770
	public bool usePotentShield { /* [XID] */ /* 0x00000001899CBD60-0x00000001899CBD80 */ get => default; /* [XID] */ /* 0x00000001899D3250-0x00000001899D3270 */ private set {} } // 0x000000018248FD00-0x000000018248FDA0 0x000000018248F610-0x000000018248F6C0
	public ElementType potentShieldType { /* [XID] */ /* 0x00000001899DA7C0-0x00000001899DA7E0 */ get => default; /* [XID] */ /* 0x00000001899E21E0-0x00000001899E2200 */ private set {} } // 0x000000018248DE60-0x000000018248DF00 0x000000018248E540-0x000000018248E5F0

	// Constructors
	public ByHasShield() {} // 0x000000018248FE40-0x000000018248FEB0

	// Methods
	// [XID] // 0x00000001899E96E0-0x00000001899E9700
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018248FB30-0x000000018248FC60
	// [XID] // 0x00000001899F0D70-0x00000001899F0D90
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018248F560-0x000000018248F610
	// [XID] // 0x00000001899F8630-0x00000001899F8650
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6B0F */) => default; // 0x000000018248F170-0x000000018248F250
	// [XID] // 0x00000001899FFBE0-0x00000001899FFC00
	public override int GetHashNum() => default; // 0x000000018248DD90-0x000000018248DE60
	// [XID] // 0x0000000189A07490-0x0000000189A074B0
	public override void InitEmpty() {} // 0x000000018248EC00-0x000000018248ECA0
	[BlackList] // 0x0000000189A0E950-0x0000000189A0E990
	// [XID] // 0x0000000189A0E950-0x0000000189A0E990
	public override bool FromJson(JSONNode node) => default; // 0x000000018248E5F0-0x000000018248E970
	// [XID] // 0x0000000189A18E70-0x0000000189A18E90
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018248D4A0-0x000000018248D850
	[BlackList] // 0x0000000189A205B0-0x0000000189A205F0
	// [XID] // 0x0000000189A205B0-0x0000000189A205F0
	public static new ByHasShield ParseFromJson(JSONNode node) => default; // 0x000000018248F2B0-0x000000018248F500
	// [XID] // 0x0000000189A2A9C0-0x0000000189A2A9E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B10 */, bool useObjectPool = false /* Metadata: 0x00AF6B14 */) => default; // 0x000000018248EE70-0x000000018248F170
	// [XID] // 0x0000000189A31F60-0x0000000189A31F80
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B15 */, bool useObjectPool = false /* Metadata: 0x00AF6B19 */) => default; // 0x000000018248DFE0-0x000000018248E310
	// [XID] // 0x0000000189A398F0-0x0000000189A39910
	public static new ByHasShield ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B1A */, bool useObjectPool = false /* Metadata: 0x00AF6B1E */) => default; // 0x000000018248E970-0x000000018248EB90
	[BlackList] // 0x0000000189A41110-0x0000000189A41150
	// [XID] // 0x0000000189A41110-0x0000000189A41150
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018248D850-0x000000018248DB20
	// [XID] // 0x0000000189A4B6C0-0x0000000189A4B6E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018248F820-0x000000018248FB30
	[BlackList] // 0x0000000189A52E20-0x0000000189A52E60
	// [XID] // 0x0000000189A52E20-0x0000000189A52E60
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018248ED80-0x000000018248EE70
	// [XID] // 0x0000000189A5DA60-0x0000000189A5DA80
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x000000018248E310-0x000000018248E440
	[BlackList] // 0x0000000189A65180-0x0000000189A651C0
	// [XID] // 0x0000000189A65180-0x0000000189A651C0
	public override void AutoAllocTypeFields() {} // 0x000000018248DB20-0x000000018248DBC0
	[BlackList] // 0x0000000189A6F9A0-0x0000000189A6F9E0
	// [XID] // 0x0000000189A6F9A0-0x0000000189A6F9E0
	public override void AutoRecycleTypeFields() {} // 0x000000018248DBC0-0x000000018248DC70
	[BlackList] // 0x0000000189A7A630-0x0000000189A7A670
	// [XID] // 0x0000000189A7A630-0x0000000189A7A670
	public override void ReturnToObjectPool() {} // 0x000000018248FDA0-0x000000018248FE40
}

