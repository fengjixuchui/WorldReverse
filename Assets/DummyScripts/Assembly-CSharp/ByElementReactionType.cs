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
public class ByElementReactionType : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17330
{
	// Fields
	private ElementReactionType _reactionType; // 0x18

	// Properties
	public ElementReactionType reactionType { /* [XID] */ /* 0x0000000189643160-0x0000000189643180 */ get => default; /* [XID] */ /* 0x000000018964A7C0-0x000000018964A7E0 */ private set {} } // 0x0000000185127620-0x00000001851276C0 0x0000000185127270-0x0000000185127320

	// Constructors
	public ByElementReactionType() {} // 0x0000000185127FA0-0x0000000185128000

	// Methods
	// [XID] // 0x00000001896520C0-0x00000001896520E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185127E10-0x0000000185127F00
	// [XID] // 0x0000000189659750-0x0000000189659770
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185127AB0-0x0000000185127B60
	// [XID] // 0x0000000189660ED0-0x0000000189660EF0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6AAF */) => default; // 0x00000001851276C0-0x00000001851277A0
	// [XID] // 0x0000000189668820-0x0000000189668840
	public override int GetHashNum() => default; // 0x00000001851263E0-0x00000001851264B0
	// [XID] // 0x0000000189670410-0x0000000189670430
	public override void InitEmpty() {} // 0x0000000185127000-0x00000001851270A0
	[BlackList] // 0x0000000189677C10-0x0000000189677C50
	// [XID] // 0x0000000189677C10-0x0000000189677C50
	public override bool FromJson(JSONNode node) => default; // 0x00000001851269F0-0x0000000185126D70
	// [XID] // 0x0000000189682310-0x0000000189682330
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000185125C80-0x0000000185125EA0
	[BlackList] // 0x0000000189689CB0-0x0000000189689CF0
	// [XID] // 0x0000000189689CB0-0x0000000189689CF0
	public static new ByElementReactionType ParseFromJson(JSONNode node) => default; // 0x0000000185127800-0x0000000185127A50
	// [XID] // 0x0000000189694840-0x0000000189694860
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6AB0 */, bool useObjectPool = false /* Metadata: 0x00AF6AB4 */) => default; // 0x0000000185127320-0x0000000185127620
	// [XID] // 0x000000018969BF00-0x000000018969BF20
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6AB5 */, bool useObjectPool = false /* Metadata: 0x00AF6AB9 */) => default; // 0x0000000185126590-0x00000001851267C0
	// [XID] // 0x00000001896A3400-0x00000001896A3420
	public static new ByElementReactionType ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6ABA */, bool useObjectPool = false /* Metadata: 0x00AF6ABE */) => default; // 0x0000000185126D70-0x0000000185126F90
	[BlackList] // 0x00000001896AA8F0-0x00000001896AA930
	// [XID] // 0x00000001896AA8F0-0x00000001896AA930
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000185125EA0-0x0000000185126170
	// [XID] // 0x00000001896B4E90-0x00000001896B4EB0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185127C10-0x0000000185127E10
	[BlackList] // 0x00000001896BC180-0x00000001896BC1C0
	// [XID] // 0x00000001896BC180-0x00000001896BC1C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000185127180-0x0000000185127270
	// [XID] // 0x00000001896C6730-0x00000001896C6750
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x00000001851267C0-0x00000001851268F0
	[BlackList] // 0x00000001896CDC90-0x00000001896CDCD0
	// [XID] // 0x00000001896CDC90-0x00000001896CDCD0
	public override void AutoAllocTypeFields() {} // 0x0000000185126170-0x0000000185126210
	[BlackList] // 0x00000001896D8130-0x00000001896D8170
	// [XID] // 0x00000001896D8130-0x00000001896D8170
	public override void AutoRecycleTypeFields() {} // 0x0000000185126210-0x00000001851262C0
	[BlackList] // 0x00000001896E29A0-0x00000001896E29E0
	// [XID] // 0x00000001896E29A0-0x00000001896E29E0
	public override void ReturnToObjectPool() {} // 0x0000000185127F00-0x0000000185127FA0
}

