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
public class ByCompareWithTarget : RelationalOperationPredicate, IAutoAllocRecycle // TypeDefIndex: 17322
{
	// Fields
	private bool _useOwner; // 0x20
	private CompareProperty _property; // 0x24

	// Properties
	public bool useOwner { /* [XID] */ /* 0x0000000189957AA0-0x0000000189957AC0 */ get => default; /* [XID] */ /* 0x000000018995F310-0x000000018995F330 */ private set {} } // 0x00000001828692A0-0x0000000182869340 0x00000001828685E0-0x0000000182868690
	public CompareProperty property { /* [XID] */ /* 0x0000000189966BF0-0x0000000189966C10 */ get => default; /* [XID] */ /* 0x000000018996DF60-0x000000018996DF80 */ private set {} } // 0x0000000182868CB0-0x0000000182868D50 0x0000000182868690-0x0000000182868740

	// Constructors
	public ByCompareWithTarget() {} // 0x0000000182869780-0x00000001828697E0

	// Methods
	// [XID] // 0x0000000189975B30-0x0000000189975B50
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001828695D0-0x00000001828696E0
	// [XID] // 0x000000018997CB10-0x000000018997CB30
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182869140-0x00000001828691F0
	// [XID] // 0x0000000189984910-0x0000000189984930
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6A6F */) => default; // 0x0000000182868D50-0x0000000182868E30
	// [XID] // 0x000000018998C3F0-0x000000018998C410
	public override int GetHashNum() => default; // 0x0000000182867950-0x0000000182867A20
	// [XID] // 0x0000000189994110-0x0000000189994130
	public override void InitEmpty() {} // 0x0000000182868740-0x00000001828687E0
	[BlackList] // 0x000000018999B980-0x000000018999B9C0
	// [XID] // 0x000000018999B980-0x000000018999B9C0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182867FD0-0x0000000182868350
	// [XID] // 0x00000001899A6530-0x00000001899A6550
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182867120-0x0000000182867410
	[BlackList] // 0x00000001899ADC00-0x00000001899ADC40
	// [XID] // 0x00000001899ADC00-0x00000001899ADC40
	public static new ByCompareWithTarget ParseFromJson(JSONNode node) => default; // 0x0000000182868E90-0x00000001828690E0
	// [XID] // 0x00000001899B8130-0x00000001899B8150
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A70 */, bool useObjectPool = false /* Metadata: 0x00AF6A74 */) => default; // 0x00000001828689B0-0x0000000182868CB0
	// [XID] // 0x00000001899BFC70-0x00000001899BFC90
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A75 */, bool useObjectPool = false /* Metadata: 0x00AF6A79 */) => default; // 0x0000000182867B00-0x0000000182867DA0
	// [XID] // 0x00000001899C7410-0x00000001899C7430
	public static new ByCompareWithTarget ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A7A */, bool useObjectPool = false /* Metadata: 0x00AF6A7E */) => default; // 0x0000000182868350-0x0000000182868570
	[BlackList] // 0x00000001899CEA00-0x00000001899CEA40
	// [XID] // 0x00000001899CEA00-0x00000001899CEA40
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182867410-0x00000001828676E0
	// [XID] // 0x00000001899D8F50-0x00000001899D8F70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182869340-0x00000001828695D0
	[BlackList] // 0x00000001899E0660-0x00000001899E06A0
	// [XID] // 0x00000001899E0660-0x00000001899E06A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001828688C0-0x00000001828689B0
	// [XID] // 0x00000001899EAC80-0x00000001899EACA0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000182867DA0-0x0000000182867ED0
	[BlackList] // 0x00000001899F28E0-0x00000001899F2920
	// [XID] // 0x00000001899F28E0-0x00000001899F2920
	public override void AutoAllocTypeFields() {} // 0x00000001828676E0-0x0000000182867780
	[BlackList] // 0x00000001899FCED0-0x00000001899FCF10
	// [XID] // 0x00000001899FCED0-0x00000001899FCF10
	public override void AutoRecycleTypeFields() {} // 0x0000000182867780-0x0000000182867830
	[BlackList] // 0x0000000189A074B0-0x0000000189A074F0
	// [XID] // 0x0000000189A074B0-0x0000000189A074F0
	public override void ReturnToObjectPool() {} // 0x00000001828696E0-0x0000000182869780
}

