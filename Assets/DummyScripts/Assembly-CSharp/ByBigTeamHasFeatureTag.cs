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
public class ByBigTeamHasFeatureTag : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17304
{
	// Fields
	private SimpleSafeUInt32 featureTagIDRawNum; // 0x18
	private SimpleSafeUInt32 numberRawNum; // 0x1C
	private RelationalOperator _logic; // 0x20

	// Properties
	public uint featureTagID { /* [XID] */ /* 0x000000018990FE70-0x000000018990FE90 */ get => default; /* [XID] */ /* 0x0000000189917A40-0x0000000189917A60 */ private set {} } // 0x0000000184561BB0-0x0000000184561C80 0x0000000184561AD0-0x0000000184561BB0
	public uint number { /* [XID] */ /* 0x000000018991EF80-0x000000018991EFA0 */ get => default; /* [XID] */ /* 0x00000001899269E0-0x0000000189926A00 */ private set {} } // 0x0000000184561D60-0x0000000184561E30 0x0000000184563590-0x0000000184563670
	public RelationalOperator logic { /* [XID] */ /* 0x000000018992DFF0-0x000000018992E010 */ get => default; /* [XID] */ /* 0x0000000189935350-0x0000000189935370 */ private set {} } // 0x0000000184563190-0x0000000184563230 0x0000000184562980-0x0000000184562A30

	// Constructors
	public ByBigTeamHasFeatureTag() {} // 0x0000000184563C60-0x0000000184563CC0

	// Methods
	// [XID] // 0x000000018993CEF0-0x000000018993CF10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184563A90-0x0000000184563BC0
	// [XID] // 0x0000000189944540-0x0000000189944560
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001845634E0-0x0000000184563590
	// [XID] // 0x000000018994BB00-0x000000018994BB20
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF69EB */) => default; // 0x0000000184563050-0x0000000184563130
	// [XID] // 0x0000000189953330-0x0000000189953350
	public override int GetHashNum() => default; // 0x0000000184561A00-0x0000000184561AD0
	// [XID] // 0x000000018995AA90-0x000000018995AAB0
	public override void InitEmpty() {} // 0x0000000184562AA0-0x0000000184562B80
	[BlackList] // 0x0000000189962630-0x0000000189962670
	// [XID] // 0x0000000189962630-0x0000000189962670
	public override bool FromJson(JSONNode node) => default; // 0x00000001845623E0-0x0000000184562760
	// [XID] // 0x000000018996C990-0x000000018996C9B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184561030-0x0000000184561480
	[BlackList] // 0x00000001899743F0-0x0000000189974430
	// [XID] // 0x00000001899743F0-0x0000000189974430
	public static new ByBigTeamHasFeatureTag ParseFromJson(JSONNode node) => default; // 0x0000000184563230-0x0000000184563480
	// [XID] // 0x000000018997E700-0x000000018997E720
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF69EC */, bool useObjectPool = false /* Metadata: 0x00AF69F0 */) => default; // 0x0000000184562D50-0x0000000184563050
	// [XID] // 0x0000000189986130-0x0000000189986150
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF69F1 */, bool useObjectPool = false /* Metadata: 0x00AF69F5 */) => default; // 0x0000000184561E30-0x00000001845621B0
	// [XID] // 0x000000018998DD80-0x000000018998DDA0
	public static new ByBigTeamHasFeatureTag ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF69F6 */, bool useObjectPool = false /* Metadata: 0x00AF69FA */) => default; // 0x0000000184562760-0x0000000184562980
	[BlackList] // 0x0000000189995890-0x00000001899958D0
	// [XID] // 0x0000000189995890-0x00000001899958D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184561480-0x0000000184561750
	// [XID] // 0x00000001899A0230-0x00000001899A0250
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184563720-0x0000000184563A90
	[BlackList] // 0x00000001899A7D40-0x00000001899A7D80
	// [XID] // 0x00000001899A7D40-0x00000001899A7D80
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184562C60-0x0000000184562D50
	// [XID] // 0x00000001899B2630-0x00000001899B2650
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x00000001845621B0-0x00000001845622E0
	[BlackList] // 0x00000001899B9910-0x00000001899B9950
	// [XID] // 0x00000001899B9910-0x00000001899B9950
	public override void AutoAllocTypeFields() {} // 0x0000000184561750-0x00000001845617F0
	[BlackList] // 0x00000001899C4500-0x00000001899C4540
	// [XID] // 0x00000001899C4500-0x00000001899C4540
	public override void AutoRecycleTypeFields() {} // 0x00000001845617F0-0x00000001845618E0
	[BlackList] // 0x00000001899CEA40-0x00000001899CEA80
	// [XID] // 0x00000001899CEA40-0x00000001899CEA80
	public override void ReturnToObjectPool() {} // 0x0000000184563BC0-0x0000000184563C60
}

