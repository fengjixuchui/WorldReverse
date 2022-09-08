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
public class ByAttackNotHitScene : RelationalOperationPredicate, IAutoAllocRecycle // TypeDefIndex: 17270
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBaseAttackPattern _attackPattern; // 0x20
	private bool _checkWaterLayer; // 0x28

	// Properties
	public ConfigBaseAttackPattern attackPattern { /* [XID] */ /* 0x00000001898890A0-0x00000001898890C0 */ get => default; /* [XID] */ /* 0x0000000189890440-0x0000000189890460 */ private set {} } // 0x00000001811F33D0-0x00000001811F3470 0x00000001811F22A0-0x00000001811F2350
	public bool checkWaterLayer { /* [XID] */ /* 0x0000000189897A00-0x0000000189897A20 */ get => default; /* [XID] */ /* 0x000000018989EE20-0x000000018989EE40 */ private set {} } // 0x00000001811F1C30-0x00000001811F1CD0 0x00000001811F3900-0x00000001811F39B0

	// Constructors
	public ByAttackNotHitScene() {} // 0x00000001811F3A50-0x00000001811F3AB0

	// Methods
	// [XID] // 0x00000001898A68E0-0x00000001898A6900
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001811F37E0-0x00000001811F3900
	// [XID] // 0x00000001898AE050-0x00000001898AE070
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001811F32F0-0x00000001811F33D0
	// [XID] // 0x00000001898B55B0-0x00000001898B55D0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF68DB */) => default; // 0x00000001811F2F00-0x00000001811F2FE0
	// [XID] // 0x00000001898BCFC0-0x00000001898BCFE0
	public override int GetHashNum() => default; // 0x00000001811F1B60-0x00000001811F1C30
	// [XID] // 0x00000001898C47A0-0x00000001898C47C0
	public override void InitEmpty() {} // 0x00000001811F2960-0x00000001811F2A30
	[BlackList] // 0x00000001898CBD70-0x00000001898CBDB0
	// [XID] // 0x00000001898CBD70-0x00000001898CBDB0
	public override bool FromJson(JSONNode node) => default; // 0x00000001811F2350-0x00000001811F26D0
	// [XID] // 0x00000001898D67C0-0x00000001898D67E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001811F12C0-0x00000001811F1590
	[BlackList] // 0x00000001898DE440-0x00000001898DE480
	// [XID] // 0x00000001898DE440-0x00000001898DE480
	public static new ByAttackNotHitScene ParseFromJson(JSONNode node) => default; // 0x00000001811F3040-0x00000001811F3290
	// [XID] // 0x00000001898E8E20-0x00000001898E8E40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF68DC */, bool useObjectPool = false /* Metadata: 0x00AF68E0 */) => default; // 0x00000001811F2C00-0x00000001811F2F00
	// [XID] // 0x00000001898F0520-0x00000001898F0540
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF68E1 */, bool useObjectPool = false /* Metadata: 0x00AF68E5 */) => default; // 0x00000001811F1DB0-0x00000001811F2070
	// [XID] // 0x00000001898F7F90-0x00000001898F7FB0
	public static new ByAttackNotHitScene ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF68E6 */, bool useObjectPool = false /* Metadata: 0x00AF68EA */) => default; // 0x00000001811F26D0-0x00000001811F28F0
	[BlackList] // 0x00000001898FF610-0x00000001898FF650
	// [XID] // 0x00000001898FF610-0x00000001898FF650
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001811F1590-0x00000001811F1860
	// [XID] // 0x0000000189909D40-0x0000000189909D60
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001811F3520-0x00000001811F37E0
	[BlackList] // 0x0000000189911580-0x00000001899115C0
	// [XID] // 0x0000000189911580-0x00000001899115C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001811F2B10-0x00000001811F2C00
	// [XID] // 0x000000018991C240-0x000000018991C260
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x00000001811F2070-0x00000001811F21A0
	[BlackList] // 0x0000000189923940-0x0000000189923980
	// [XID] // 0x0000000189923940-0x0000000189923980
	public override void AutoAllocTypeFields() {} // 0x00000001811F1860-0x00000001811F1900
	[BlackList] // 0x000000018992E010-0x000000018992E050
	// [XID] // 0x000000018992E010-0x000000018992E050
	public override void AutoRecycleTypeFields() {} // 0x00000001811F1900-0x00000001811F1A40
	[BlackList] // 0x0000000189938390-0x00000001899383D0
	// [XID] // 0x0000000189938390-0x00000001899383D0
	public override void ReturnToObjectPool() {} // 0x00000001811F39B0-0x00000001811F3A50
}

