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
public class ByCurTeamHasElementType : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17292
{
	// Fields
	private ElementType _elementType; // 0x18
	private SimpleSafeUInt32 numberRawNum; // 0x1C
	private RelationalOperator _logic; // 0x20

	// Properties
	public ElementType elementType { /* [XID] */ /* 0x0000000189A58F60-0x0000000189A58F80 */ get => default; /* [XID] */ /* 0x0000000189A60880-0x0000000189A608A0 */ private set {} } // 0x00000001818AAD30-0x00000001818AADD0 0x00000001818ABD10-0x00000001818ABDC0
	public uint number { /* [XID] */ /* 0x0000000189A68690-0x0000000189A686B0 */ get => default; /* [XID] */ /* 0x0000000189A6FA00-0x0000000189A6FA20 */ private set {} } // 0x00000001818AA7E0-0x00000001818AA8B0 0x00000001818AC120-0x00000001818AC200
	public RelationalOperator logic { /* [XID] */ /* 0x0000000189A77190-0x0000000189A771B0 */ get => default; /* [XID] */ /* 0x0000000189A7EB60-0x0000000189A7EB80 */ private set {} } // 0x00000001818ABC70-0x00000001818ABD10 0x00000001818AB470-0x00000001818AB520

	// Constructors
	public ByCurTeamHasElementType() {} // 0x00000001818AC7C0-0x00000001818AC820

	// Methods
	// [XID] // 0x0000000189A86370-0x0000000189A86390
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001818AC5F0-0x00000001818AC720
	// [XID] // 0x0000000189A8DD70-0x0000000189A8DD90
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001818AC070-0x00000001818AC120
	// [XID] // 0x0000000189A95350-0x0000000189A95370
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF698B */) => default; // 0x00000001818ABB30-0x00000001818ABC10
	// [XID] // 0x0000000189A9CB90-0x0000000189A9CBB0
	public override int GetHashNum() => default; // 0x00000001818AA630-0x00000001818AA700
	// [XID] // 0x0000000189AA4360-0x0000000189AA4380
	public override void InitEmpty() {} // 0x00000001818AB590-0x00000001818AB660
	[BlackList] // 0x0000000189AAB830-0x0000000189AAB870
	// [XID] // 0x0000000189AAB830-0x0000000189AAB870
	public override bool FromJson(JSONNode node) => default; // 0x00000001818AAED0-0x00000001818AB250
	// [XID] // 0x0000000189AB61C0-0x0000000189AB61E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001818A9CA0-0x00000001818AA0C0
	[BlackList] // 0x0000000189ABDC10-0x0000000189ABDC50
	// [XID] // 0x0000000189ABDC10-0x0000000189ABDC50
	public static new ByCurTeamHasElementType ParseFromJson(JSONNode node) => default; // 0x00000001818ABDC0-0x00000001818AC010
	// [XID] // 0x0000000189AC8590-0x0000000189AC85B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF698C */, bool useObjectPool = false /* Metadata: 0x00AF6990 */) => default; // 0x00000001818AB830-0x00000001818ABB30
	// [XID] // 0x0000000189ACFC90-0x0000000189ACFCB0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6991 */, bool useObjectPool = false /* Metadata: 0x00AF6995 */) => default; // 0x00000001818AA8B0-0x00000001818AAC00
	// [XID] // 0x0000000189AD7A40-0x0000000189AD7A60
	public static new ByCurTeamHasElementType ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6996 */, bool useObjectPool = false /* Metadata: 0x00AF699A */) => default; // 0x00000001818AB250-0x00000001818AB470
	[BlackList] // 0x0000000189ADF4D0-0x0000000189ADF510
	// [XID] // 0x0000000189ADF4D0-0x0000000189ADF510
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001818AA0C0-0x00000001818AA390
	// [XID] // 0x0000000189AE9AB0-0x0000000189AE9AD0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001818AC2B0-0x00000001818AC5F0
	[BlackList] // 0x0000000189AF17D0-0x0000000189AF1810
	// [XID] // 0x0000000189AF17D0-0x0000000189AF1810
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001818AB740-0x00000001818AB830
	// [XID] // 0x0000000189AFBC00-0x0000000189AFBC20
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x00000001818AAC00-0x00000001818AAD30
	[BlackList] // 0x0000000189B033B0-0x0000000189B033F0
	// [XID] // 0x0000000189B033B0-0x0000000189B033F0
	public override void AutoAllocTypeFields() {} // 0x00000001818AA390-0x00000001818AA430
	[BlackList] // 0x0000000189B0DB30-0x0000000189B0DB70
	// [XID] // 0x0000000189B0DB30-0x0000000189B0DB70
	public override void AutoRecycleTypeFields() {} // 0x00000001818AA430-0x00000001818AA510
	[BlackList] // 0x0000000189B17F00-0x0000000189B17F40
	// [XID] // 0x0000000189B17F00-0x0000000189B17F40
	public override void ReturnToObjectPool() {} // 0x00000001818AC720-0x00000001818AC7C0
}

