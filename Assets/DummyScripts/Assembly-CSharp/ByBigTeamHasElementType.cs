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
public class ByBigTeamHasElementType : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17306
{
	// Fields
	private ElementType _elementType; // 0x18
	private SimpleSafeUInt32 numberRawNum; // 0x1C
	private RelationalOperator _logic; // 0x20

	// Properties
	public ElementType elementType { /* [XID] */ /* 0x00000001899E06A0-0x00000001899E06C0 */ get => default; /* [XID] */ /* 0x00000001899E81A0-0x00000001899E81C0 */ private set {} } // 0x00000001854A4EE0-0x00000001854A4F80 0x00000001854A5EC0-0x00000001854A5F70
	public uint number { /* [XID] */ /* 0x00000001899EF6B0-0x00000001899EF6D0 */ get => default; /* [XID] */ /* 0x00000001899F6F10-0x00000001899F6F30 */ private set {} } // 0x00000001854A4990-0x00000001854A4A60 0x00000001854A62D0-0x00000001854A63B0
	public RelationalOperator logic { /* [XID] */ /* 0x00000001899FE6F0-0x00000001899FE710 */ get => default; /* [XID] */ /* 0x0000000189A05F10-0x0000000189A05F30 */ private set {} } // 0x00000001854A5E20-0x00000001854A5EC0 0x00000001854A5620-0x00000001854A56D0

	// Constructors
	public ByBigTeamHasElementType() {} // 0x00000001854A6970-0x00000001854A69D0

	// Methods
	// [XID] // 0x0000000189A0D340-0x0000000189A0D360
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001854A67A0-0x00000001854A68D0
	// [XID] // 0x0000000189A14B60-0x0000000189A14B80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001854A6220-0x00000001854A62D0
	// [XID] // 0x0000000189A1BDF0-0x0000000189A1BE10
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF69FB */) => default; // 0x00000001854A5CE0-0x00000001854A5DC0
	// [XID] // 0x0000000189A23620-0x0000000189A23640
	public override int GetHashNum() => default; // 0x00000001854A47E0-0x00000001854A48B0
	// [XID] // 0x0000000189A2A9E0-0x0000000189A2AA00
	public override void InitEmpty() {} // 0x00000001854A5740-0x00000001854A5810
	[BlackList] // 0x0000000189A31F80-0x0000000189A31FC0
	// [XID] // 0x0000000189A31F80-0x0000000189A31FC0
	public override bool FromJson(JSONNode node) => default; // 0x00000001854A5080-0x00000001854A5400
	// [XID] // 0x0000000189A3C720-0x0000000189A3C740
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001854A3E50-0x00000001854A4270
	[BlackList] // 0x0000000189A441D0-0x0000000189A44210
	// [XID] // 0x0000000189A441D0-0x0000000189A44210
	public static new ByBigTeamHasElementType ParseFromJson(JSONNode node) => default; // 0x00000001854A5F70-0x00000001854A61C0
	// [XID] // 0x0000000189A4E950-0x0000000189A4E970
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF69FC */, bool useObjectPool = false /* Metadata: 0x00AF6A00 */) => default; // 0x00000001854A59E0-0x00000001854A5CE0
	// [XID] // 0x0000000189A56020-0x0000000189A56040
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A01 */, bool useObjectPool = false /* Metadata: 0x00AF6A05 */) => default; // 0x00000001854A4A60-0x00000001854A4DB0
	// [XID] // 0x0000000189A5DA80-0x0000000189A5DAA0
	public static new ByBigTeamHasElementType ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A06 */, bool useObjectPool = false /* Metadata: 0x00AF6A0A */) => default; // 0x00000001854A5400-0x00000001854A5620
	[BlackList] // 0x0000000189A651C0-0x0000000189A65200
	// [XID] // 0x0000000189A651C0-0x0000000189A65200
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001854A4270-0x00000001854A4540
	// [XID] // 0x0000000189A6F9E0-0x0000000189A6FA00
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001854A6460-0x00000001854A67A0
	[BlackList] // 0x0000000189A77150-0x0000000189A77190
	// [XID] // 0x0000000189A77150-0x0000000189A77190
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001854A58F0-0x00000001854A59E0
	// [XID] // 0x0000000189A81B50-0x0000000189A81B70
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x00000001854A4DB0-0x00000001854A4EE0
	[BlackList] // 0x0000000189A89630-0x0000000189A89670
	// [XID] // 0x0000000189A89630-0x0000000189A89670
	public override void AutoAllocTypeFields() {} // 0x00000001854A4540-0x00000001854A45E0
	[BlackList] // 0x0000000189A93990-0x0000000189A939D0
	// [XID] // 0x0000000189A93990-0x0000000189A939D0
	public override void AutoRecycleTypeFields() {} // 0x00000001854A45E0-0x00000001854A46C0
	[BlackList] // 0x0000000189A9DF90-0x0000000189A9DFD0
	// [XID] // 0x0000000189A9DF90-0x0000000189A9DFD0
	public override void ReturnToObjectPool() {} // 0x00000001854A68D0-0x00000001854A6970
}

