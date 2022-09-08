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
public class ByCurTeamHasFeatureTag : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17290
{
	// Fields
	private SimpleSafeUInt32 featureTagIDRawNum; // 0x18
	private SimpleSafeUInt32 numberRawNum; // 0x1C
	private RelationalOperator _logic; // 0x20

	// Properties
	public uint featureTagID { /* [XID] */ /* 0x0000000189989600-0x0000000189989620 */ get => default; /* [XID] */ /* 0x0000000189990EB0-0x0000000189990ED0 */ private set {} } // 0x00000001821734B0-0x0000000182173580 0x00000001821733D0-0x00000001821734B0
	public uint number { /* [XID] */ /* 0x00000001899988B0-0x00000001899988D0 */ get => default; /* [XID] */ /* 0x00000001899A0250-0x00000001899A0270 */ private set {} } // 0x0000000182173660-0x0000000182173730 0x0000000182174E90-0x0000000182174F70
	public RelationalOperator logic { /* [XID] */ /* 0x00000001899A7D80-0x00000001899A7DA0 */ get => default; /* [XID] */ /* 0x00000001899AF510-0x00000001899AF530 */ private set {} } // 0x0000000182174A90-0x0000000182174B30 0x0000000182174280-0x0000000182174330

	// Constructors
	public ByCurTeamHasFeatureTag() {} // 0x0000000182175560-0x00000001821755C0

	// Methods
	// [XID] // 0x00000001899B69F0-0x00000001899B6A10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182175390-0x00000001821754C0
	// [XID] // 0x00000001899BE4B0-0x00000001899BE4D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182174DE0-0x0000000182174E90
	// [XID] // 0x00000001899C5C70-0x00000001899C5C90
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF697B */) => default; // 0x0000000182174950-0x0000000182174A30
	// [XID] // 0x00000001899CD430-0x00000001899CD450
	public override int GetHashNum() => default; // 0x0000000182173300-0x00000001821733D0
	// [XID] // 0x00000001899D4870-0x00000001899D4890
	public override void InitEmpty() {} // 0x00000001821743A0-0x0000000182174480
	[BlackList] // 0x00000001899DBF10-0x00000001899DBF50
	// [XID] // 0x00000001899DBF10-0x00000001899DBF50
	public override bool FromJson(JSONNode node) => default; // 0x0000000182173CE0-0x0000000182174060
	// [XID] // 0x00000001899E68B0-0x00000001899E68D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182172930-0x0000000182172D80
	[BlackList] // 0x00000001899EDEE0-0x00000001899EDF20
	// [XID] // 0x00000001899EDEE0-0x00000001899EDF20
	public static new ByCurTeamHasFeatureTag ParseFromJson(JSONNode node) => default; // 0x0000000182174B30-0x0000000182174D80
	// [XID] // 0x00000001899F8650-0x00000001899F8670
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF697C */, bool useObjectPool = false /* Metadata: 0x00AF6980 */) => default; // 0x0000000182174650-0x0000000182174950
	// [XID] // 0x00000001899FFC00-0x00000001899FFC20
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6981 */, bool useObjectPool = false /* Metadata: 0x00AF6985 */) => default; // 0x0000000182173730-0x0000000182173AB0
	// [XID] // 0x0000000189A074F0-0x0000000189A07510
	public static new ByCurTeamHasFeatureTag ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6986 */, bool useObjectPool = false /* Metadata: 0x00AF698A */) => default; // 0x0000000182174060-0x0000000182174280
	[BlackList] // 0x0000000189A0E990-0x0000000189A0E9D0
	// [XID] // 0x0000000189A0E990-0x0000000189A0E9D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182172D80-0x0000000182173050
	// [XID] // 0x0000000189A18EB0-0x0000000189A18ED0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182175020-0x0000000182175390
	[BlackList] // 0x0000000189A20610-0x0000000189A20650
	// [XID] // 0x0000000189A20610-0x0000000189A20650
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182174560-0x0000000182174650
	// [XID] // 0x0000000189A2AA00-0x0000000189A2AA20
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000182173AB0-0x0000000182173BE0
	[BlackList] // 0x0000000189A31FC0-0x0000000189A32000
	// [XID] // 0x0000000189A31FC0-0x0000000189A32000
	public override void AutoAllocTypeFields() {} // 0x0000000182173050-0x00000001821730F0
	[BlackList] // 0x0000000189A3C740-0x0000000189A3C780
	// [XID] // 0x0000000189A3C740-0x0000000189A3C780
	public override void AutoRecycleTypeFields() {} // 0x00000001821730F0-0x00000001821731E0
	[BlackList] // 0x0000000189A47030-0x0000000189A47070
	// [XID] // 0x0000000189A47030-0x0000000189A47070
	public override void ReturnToObjectPool() {} // 0x00000001821754C0-0x0000000182175560
}

