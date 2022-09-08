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
public class ByHasComponentTag : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17280
{
	// Fields
	private ComponentTag[] _tags; // 0x18

	// Properties
	public ComponentTag[] tags { /* [XID] */ /* 0x0000000189610470-0x0000000189610490 */ get => default; /* [XID] */ /* 0x0000000189617750-0x0000000189617770 */ private set {} } // 0x0000000182D123D0-0x0000000182D12470 0x0000000182D11800-0x0000000182D118B0

	// Constructors
	public ByHasComponentTag() {} // 0x0000000182D133D0-0x0000000182D13430

	// Methods
	// [XID] // 0x000000018961F360-0x000000018961F380
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182D13240-0x0000000182D13330
	// [XID] // 0x0000000189626720-0x0000000189626740
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182D12E70-0x0000000182D12F50
	// [XID] // 0x000000018962DFB0-0x000000018962DFD0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF692B */) => default; // 0x0000000182D12A80-0x0000000182D12B60
	// [XID] // 0x0000000189635CB0-0x0000000189635CD0
	public override int GetHashNum() => default; // 0x0000000182D11730-0x0000000182D11800
	// [XID] // 0x000000018963D430-0x000000018963D450
	public override void InitEmpty() {} // 0x0000000182D124E0-0x0000000182D125B0
	[BlackList] // 0x0000000189644910-0x0000000189644950
	// [XID] // 0x0000000189644910-0x0000000189644950
	public override bool FromJson(JSONNode node) => default; // 0x0000000182D11E30-0x0000000182D121B0
	// [XID] // 0x000000018964EF20-0x000000018964EF40
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182D10FC0-0x0000000182D111F0
	[BlackList] // 0x0000000189656750-0x0000000189656790
	// [XID] // 0x0000000189656750-0x0000000189656790
	public static new ByHasComponentTag ParseFromJson(JSONNode node) => default; // 0x0000000182D12BC0-0x0000000182D12E10
	// [XID] // 0x0000000189660EF0-0x0000000189660F10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF692C */, bool useObjectPool = false /* Metadata: 0x00AF6930 */) => default; // 0x0000000182D12780-0x0000000182D12A80
	// [XID] // 0x0000000189668840-0x0000000189668860
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6931 */, bool useObjectPool = false /* Metadata: 0x00AF6935 */) => default; // 0x0000000182D11990-0x0000000182D11C00
	// [XID] // 0x0000000189670430-0x0000000189670450
	public static new ByHasComponentTag ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6936 */, bool useObjectPool = false /* Metadata: 0x00AF693A */) => default; // 0x0000000182D121B0-0x0000000182D123D0
	[BlackList] // 0x0000000189677C50-0x0000000189677C90
	// [XID] // 0x0000000189677C50-0x0000000189677C90
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182D111F0-0x0000000182D114C0
	// [XID] // 0x0000000189682350-0x0000000189682370
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182D13000-0x0000000182D13240
	[BlackList] // 0x0000000189689D30-0x0000000189689D70
	// [XID] // 0x0000000189689D30-0x0000000189689D70
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182D12690-0x0000000182D12780
	// [XID] // 0x0000000189694880-0x00000001896948A0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000182D11C00-0x0000000182D11D30
	[BlackList] // 0x000000018969BF60-0x000000018969BFA0
	// [XID] // 0x000000018969BF60-0x000000018969BFA0
	public override void AutoAllocTypeFields() {} // 0x0000000182D114C0-0x0000000182D11560
	[BlackList] // 0x00000001896A6250-0x00000001896A6290
	// [XID] // 0x00000001896A6250-0x00000001896A6290
	public override void AutoRecycleTypeFields() {} // 0x0000000182D11560-0x0000000182D11610
	[BlackList] // 0x00000001896B03F0-0x00000001896B0430
	// [XID] // 0x00000001896B03F0-0x00000001896B0430
	public override void ReturnToObjectPool() {} // 0x0000000182D13330-0x0000000182D133D0
}

