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
public class ByTargetWeight : RelationalOperationPredicate, IAutoAllocRecycle // TypeDefIndex: 17218
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _weight; // 0x20

	// Properties
	public DynamicFloat weight { /* [XID] */ /* 0x00000001899AC690-0x00000001899AC6B0 */ get => default; /* [XID] */ /* 0x00000001899B3DE0-0x00000001899B3E00 */ private set {} } // 0x000000018412E580-0x000000018412E620 0x000000018412D410-0x000000018412D4C0

	// Constructors
	public ByTargetWeight() {} // 0x000000018412E6C0-0x000000018412E720

	// Methods
	// [XID] // 0x00000001899BB250-0x00000001899BB270
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018412E4A0-0x000000018412E580
	// [XID] // 0x00000001899C2D40-0x00000001899C2D60
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018412E0E0-0x000000018412E1C0
	// [XID] // 0x00000001899CA1C0-0x00000001899CA1E0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF66F7 */) => default; // 0x000000018412DCF0-0x000000018412DDD0
	// [XID] // 0x00000001899D1A60-0x00000001899D1A80
	public override int GetHashNum() => default; // 0x000000018412CA10-0x000000018412CAE0
	// [XID] // 0x00000001899D8F70-0x00000001899D8F90
	public override void InitEmpty() {} // 0x000000018412D750-0x000000018412D820
	[BlackList] // 0x00000001899E06C0-0x00000001899E0700
	// [XID] // 0x00000001899E06C0-0x00000001899E0700
	public override bool FromJson(JSONNode node) => default; // 0x000000018412D090-0x000000018412D410
	// [XID] // 0x00000001899EACA0-0x00000001899EACC0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018412C210-0x000000018412C450
	[BlackList] // 0x00000001899F2920-0x00000001899F2960
	// [XID] // 0x00000001899F2920-0x00000001899F2960
	public static new ByTargetWeight ParseFromJson(JSONNode node) => default; // 0x000000018412DE30-0x000000018412E080
	// [XID] // 0x00000001899FCF30-0x00000001899FCF50
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF66F8 */, bool useObjectPool = false /* Metadata: 0x00AF66FC */) => default; // 0x000000018412D9F0-0x000000018412DCF0
	// [XID] // 0x0000000189A04370-0x0000000189A04390
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF66FD */, bool useObjectPool = false /* Metadata: 0x00AF6701 */) => default; // 0x000000018412CBC0-0x000000018412CE60
	// [XID] // 0x0000000189A0BAD0-0x0000000189A0BAF0
	public static new ByTargetWeight ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6702 */, bool useObjectPool = false /* Metadata: 0x00AF6706 */) => default; // 0x000000018412D4C0-0x000000018412D6E0
	[BlackList] // 0x0000000189A133E0-0x0000000189A13420
	// [XID] // 0x0000000189A133E0-0x0000000189A13420
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018412C450-0x000000018412C720
	// [XID] // 0x0000000189A1D680-0x0000000189A1D6A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018412E270-0x000000018412E4A0
	[BlackList] // 0x0000000189A24A70-0x0000000189A24AB0
	// [XID] // 0x0000000189A24A70-0x0000000189A24AB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018412D900-0x000000018412D9F0
	// [XID] // 0x0000000189A2F150-0x0000000189A2F170
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x000000018412CE60-0x000000018412CF90
	[BlackList] // 0x0000000189A36B10-0x0000000189A36B50
	// [XID] // 0x0000000189A36B10-0x0000000189A36B50
	public override void AutoAllocTypeFields() {} // 0x000000018412C720-0x000000018412C7C0
	[BlackList] // 0x0000000189A41170-0x0000000189A411B0
	// [XID] // 0x0000000189A41170-0x0000000189A411B0
	public override void AutoRecycleTypeFields() {} // 0x000000018412C7C0-0x000000018412C8F0
	[BlackList] // 0x0000000189A4B6E0-0x0000000189A4B720
	// [XID] // 0x0000000189A4B6E0-0x0000000189A4B720
	public override void ReturnToObjectPool() {} // 0x000000018412E620-0x000000018412E6C0
}

