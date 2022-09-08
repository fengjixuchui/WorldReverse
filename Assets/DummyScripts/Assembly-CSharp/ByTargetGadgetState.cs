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
public class ByTargetGadgetState : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17336
{
	// Fields
	private SimpleSafeUInt32 gadgetStateRawNum; // 0x18

	// Properties
	public uint gadgetState { /* [XID] */ /* 0x0000000189849B30-0x0000000189849B50 */ get => default; /* [XID] */ /* 0x00000001898512D0-0x00000001898512F0 */ private set {} } // 0x0000000183913DD0-0x0000000183913EA0 0x0000000183914CB0-0x0000000183914D90

	// Constructors
	public ByTargetGadgetState() {} // 0x0000000183914E30-0x0000000183914E90

	// Methods
	// [XID] // 0x00000001898587C0-0x00000001898587E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183914BC0-0x0000000183914CB0
	// [XID] // 0x000000018985F8B0-0x000000018985F8D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183914830-0x00000001839148E0
	// [XID] // 0x00000001898670B0-0x00000001898670D0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6ADF */) => default; // 0x0000000183914440-0x0000000183914520
	// [XID] // 0x000000018986E8D0-0x000000018986E8F0
	public override int GetHashNum() => default; // 0x0000000183913170-0x0000000183913240
	// [XID] // 0x0000000189875DA0-0x0000000189875DC0
	public override void InitEmpty() {} // 0x0000000183913EA0-0x0000000183913F70
	[BlackList] // 0x000000018987D920-0x000000018987D960
	// [XID] // 0x000000018987D920-0x000000018987D960
	public override bool FromJson(JSONNode node) => default; // 0x00000001839137C0-0x0000000183913B40
	// [XID] // 0x0000000189887940-0x0000000189887960
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001839129A0-0x0000000183912C00
	[BlackList] // 0x000000018988EC40-0x000000018988EC80
	// [XID] // 0x000000018988EC40-0x000000018988EC80
	public static new ByTargetGadgetState ParseFromJson(JSONNode node) => default; // 0x0000000183914580-0x00000001839147D0
	// [XID] // 0x0000000189899490-0x00000001898994B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6AE0 */, bool useObjectPool = false /* Metadata: 0x00AF6AE4 */) => default; // 0x0000000183914140-0x0000000183914440
	// [XID] // 0x00000001898A06B0-0x00000001898A06D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6AE5 */, bool useObjectPool = false /* Metadata: 0x00AF6AE9 */) => default; // 0x0000000183913320-0x0000000183913590
	// [XID] // 0x00000001898A7D70-0x00000001898A7D90
	public static new ByTargetGadgetState ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6AEA */, bool useObjectPool = false /* Metadata: 0x00AF6AEE */) => default; // 0x0000000183913B40-0x0000000183913D60
	[BlackList] // 0x00000001898AF830-0x00000001898AF870
	// [XID] // 0x00000001898AF830-0x00000001898AF870
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183912C00-0x0000000183912ED0
	// [XID] // 0x00000001898BA280-0x00000001898BA2A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183914990-0x0000000183914BC0
	[BlackList] // 0x00000001898C1640-0x00000001898C1680
	// [XID] // 0x00000001898C1640-0x00000001898C1680
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183914050-0x0000000183914140
	// [XID] // 0x00000001898CBD50-0x00000001898CBD70
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000183913590-0x00000001839136C0
	[BlackList] // 0x00000001898D3610-0x00000001898D3650
	// [XID] // 0x00000001898D3610-0x00000001898D3650
	public override void AutoAllocTypeFields() {} // 0x0000000183912ED0-0x0000000183912F70
	[BlackList] // 0x00000001898DE3E0-0x00000001898DE420
	// [XID] // 0x00000001898DE3E0-0x00000001898DE420
	public override void AutoRecycleTypeFields() {} // 0x0000000183912F70-0x0000000183913050
	[BlackList] // 0x00000001898E8DA0-0x00000001898E8DE0
	// [XID] // 0x00000001898E8DA0-0x00000001898E8DE0
	public override void ReturnToObjectPool() {} // 0x0000000183914D90-0x0000000183914E30
}

