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
public class ByTargetAltitude : RelationalOperationPredicate, IAutoAllocRecycle // TypeDefIndex: 17274
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _value; // 0x20

	// Properties
	public DynamicFloat value { /* [XID] */ /* 0x00000001899F5750-0x00000001899F5770 */ get => default; /* [XID] */ /* 0x00000001899FCF10-0x00000001899FCF30 */ private set {} } // 0x00000001829C6840-0x00000001829C68E0 0x00000001829C6710-0x00000001829C67C0

	// Constructors
	public ByTargetAltitude() {} // 0x00000001829C7DC0-0x00000001829C7E20

	// Methods
	// [XID] // 0x0000000189A04350-0x0000000189A04370
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001829C7C40-0x00000001829C7D20
	// [XID] // 0x0000000189A0BAB0-0x0000000189A0BAD0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001829C7880-0x00000001829C7960
	// [XID] // 0x0000000189A13380-0x0000000189A133A0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF68FB */) => default; // 0x00000001829C7490-0x00000001829C7570
	// [XID] // 0x0000000189A1A530-0x0000000189A1A550
	public override int GetHashNum() => default; // 0x00000001829C6110-0x00000001829C61E0
	// [XID] // 0x0000000189A21CB0-0x0000000189A21CD0
	public override void InitEmpty() {} // 0x00000001829C6EF0-0x00000001829C6FC0
	[BlackList] // 0x0000000189A29200-0x0000000189A29240
	// [XID] // 0x0000000189A29200-0x0000000189A29240
	public override bool FromJson(JSONNode node) => default; // 0x00000001829C68E0-0x00000001829C6C60
	// [XID] // 0x0000000189A337E0-0x0000000189A33800
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001829C5910-0x00000001829C5B50
	[BlackList] // 0x0000000189A3AF60-0x0000000189A3AFA0
	// [XID] // 0x0000000189A3AF60-0x0000000189A3AFA0
	public static new ByTargetAltitude ParseFromJson(JSONNode node) => default; // 0x00000001829C75D0-0x00000001829C7820
	// [XID] // 0x0000000189A458C0-0x0000000189A458E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF68FC */, bool useObjectPool = false /* Metadata: 0x00AF6900 */) => default; // 0x00000001829C7190-0x00000001829C7490
	// [XID] // 0x0000000189A4CF00-0x0000000189A4CF20
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6901 */, bool useObjectPool = false /* Metadata: 0x00AF6905 */) => default; // 0x00000001829C62C0-0x00000001829C6560
	// [XID] // 0x0000000189A54650-0x0000000189A54670
	public static new ByTargetAltitude ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6906 */, bool useObjectPool = false /* Metadata: 0x00AF690A */) => default; // 0x00000001829C6C60-0x00000001829C6E80
	[BlackList] // 0x0000000189A5C140-0x0000000189A5C180
	// [XID] // 0x0000000189A5C140-0x0000000189A5C180
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001829C5B50-0x00000001829C5E20
	// [XID] // 0x0000000189A66980-0x0000000189A669A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001829C7A10-0x00000001829C7C40
	[BlackList] // 0x0000000189A6E1E0-0x0000000189A6E220
	// [XID] // 0x0000000189A6E1E0-0x0000000189A6E220
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001829C70A0-0x00000001829C7190
	// [XID] // 0x0000000189A78BE0-0x0000000189A78C00
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x00000001829C6560-0x00000001829C6690
	[BlackList] // 0x0000000189A80080-0x0000000189A800C0
	// [XID] // 0x0000000189A80080-0x0000000189A800C0
	public override void AutoAllocTypeFields() {} // 0x00000001829C5E20-0x00000001829C5EC0
	[BlackList] // 0x0000000189A8AD00-0x0000000189A8AD40
	// [XID] // 0x0000000189A8AD00-0x0000000189A8AD40
	public override void AutoRecycleTypeFields() {} // 0x00000001829C5EC0-0x00000001829C5FF0
	[BlackList] // 0x0000000189A95370-0x0000000189A953B0
	// [XID] // 0x0000000189A95370-0x0000000189A953B0
	public override void ReturnToObjectPool() {} // 0x00000001829C7D20-0x00000001829C7DC0
}

