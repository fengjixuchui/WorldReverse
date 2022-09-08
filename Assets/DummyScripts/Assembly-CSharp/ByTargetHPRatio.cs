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
public class ByTargetHPRatio : RelationalOperationPredicate, IAutoAllocRecycle // TypeDefIndex: 17178
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _HPRatio; // 0x20

	// Properties
	public DynamicFloat HPRatio { /* [XID] */ /* 0x00000001897AC1C0-0x00000001897AC1E0 */ get => default; /* [XID] */ /* 0x00000001897B4130-0x00000001897B4150 */ private set {} } // 0x0000000180DDF0D0-0x0000000180DDF170 0x0000000180DDDCC0-0x0000000180DDDD70

	// Constructors
	public ByTargetHPRatio() {} // 0x0000000180DDF2F0-0x0000000180DDF350

	// Methods
	// [XID] // 0x00000001897BBDF0-0x00000001897BBE10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000180DDF170-0x0000000180DDF250
	// [XID] // 0x00000001897C3610-0x00000001897C3630
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000180DDED10-0x0000000180DDEDF0
	// [XID] // 0x00000001897CAE30-0x00000001897CAE50
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF65B7 */) => default; // 0x0000000180DDE920-0x0000000180DDEA00
	// [XID] // 0x00000001897D23F0-0x00000001897D2410
	public override int GetHashNum() => default; // 0x0000000180DDD640-0x0000000180DDD710
	// [XID] // 0x00000001897DA170-0x00000001897DA190
	public override void InitEmpty() {} // 0x0000000180DDE380-0x0000000180DDE450
	[BlackList] // 0x00000001897E1520-0x00000001897E1560
	// [XID] // 0x00000001897E1520-0x00000001897E1560
	public override bool FromJson(JSONNode node) => default; // 0x0000000180DDDD70-0x0000000180DDE0F0
	// [XID] // 0x00000001897EC0A0-0x00000001897EC0C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000180DDCE40-0x0000000180DDD080
	[BlackList] // 0x00000001897F3990-0x00000001897F39D0
	// [XID] // 0x00000001897F3990-0x00000001897F39D0
	public static new ByTargetHPRatio ParseFromJson(JSONNode node) => default; // 0x0000000180DDEA60-0x0000000180DDECB0
	// [XID] // 0x00000001897FDDC0-0x00000001897FDDE0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF65B8 */, bool useObjectPool = false /* Metadata: 0x00AF65BC */) => default; // 0x0000000180DDE620-0x0000000180DDE920
	// [XID] // 0x00000001898055B0-0x00000001898055D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF65BD */, bool useObjectPool = false /* Metadata: 0x00AF65C1 */) => default; // 0x0000000180DDD7F0-0x0000000180DDDA90
	// [XID] // 0x000000018980CAF0-0x000000018980CB10
	public static new ByTargetHPRatio ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF65C2 */, bool useObjectPool = false /* Metadata: 0x00AF65C6 */) => default; // 0x0000000180DDE0F0-0x0000000180DDE310
	[BlackList] // 0x0000000189814350-0x0000000189814390
	// [XID] // 0x0000000189814350-0x0000000189814390
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000180DDD080-0x0000000180DDD350
	// [XID] // 0x000000018981EF00-0x000000018981EF20
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000180DDEEA0-0x0000000180DDF0D0
	[BlackList] // 0x00000001898263D0-0x0000000189826410
	// [XID] // 0x00000001898263D0-0x0000000189826410
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000180DDE530-0x0000000180DDE620
	// [XID] // 0x0000000189830AC0-0x0000000189830AE0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DDDA90-0x0000000180DDDBC0
	[BlackList] // 0x00000001898380C0-0x0000000189838100
	// [XID] // 0x00000001898380C0-0x0000000189838100
	public override void AutoAllocTypeFields() {} // 0x0000000180DDD350-0x0000000180DDD3F0
	[BlackList] // 0x0000000189842860-0x00000001898428A0
	// [XID] // 0x0000000189842860-0x00000001898428A0
	public override void AutoRecycleTypeFields() {} // 0x0000000180DDD3F0-0x0000000180DDD520
	[BlackList] // 0x000000018984CC00-0x000000018984CC40
	// [XID] // 0x000000018984CC00-0x000000018984CC40
	public override void ReturnToObjectPool() {} // 0x0000000180DDF250-0x0000000180DDF2F0
}

