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
public class ByHasFeatureTag : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17282
{
	// Fields
	private SimpleSafeUInt32[] _featureTagIDs; // 0x18

	// Properties
	public SimpleSafeUInt32[] featureTagIDs { /* [XID] */ /* 0x00000001896C1D40-0x00000001896C1D60 */ get => default; /* [XID] */ /* 0x00000001896C9330-0x00000001896C9350 */ private set {} } // 0x0000000182E846D0-0x0000000182E84770 0x0000000182E84C90-0x0000000182E84D40

	// Constructors
	public ByHasFeatureTag() {} // 0x0000000182E86240-0x0000000182E862A0

	// Methods
	// [XID] // 0x00000001896D0BE0-0x00000001896D0C00
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182E860B0-0x0000000182E861A0
	// [XID] // 0x00000001896D8190-0x00000001896D81B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182E85CE0-0x0000000182E85DC0
	// [XID] // 0x00000001896DFB20-0x00000001896DFB40
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF693B */) => default; // 0x0000000182E858F0-0x0000000182E859D0
	// [XID] // 0x00000001896E6EA0-0x00000001896E6EC0
	public override int GetHashNum() => default; // 0x0000000182E845A0-0x0000000182E84670
	// [XID] // 0x00000001896EE3B0-0x00000001896EE3D0
	public override void InitEmpty() {} // 0x0000000182E85350-0x0000000182E85420
	[BlackList] // 0x00000001896F5CE0-0x00000001896F5D20
	// [XID] // 0x00000001896F5CE0-0x00000001896F5D20
	public override bool FromJson(JSONNode node) => default; // 0x0000000182E84D40-0x0000000182E850C0
	// [XID] // 0x00000001897001A0-0x00000001897001C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182E83E30-0x0000000182E84060
	[BlackList] // 0x0000000189707910-0x0000000189707950
	// [XID] // 0x0000000189707910-0x0000000189707950
	public static new ByHasFeatureTag ParseFromJson(JSONNode node) => default; // 0x0000000182E85A30-0x0000000182E85C80
	// [XID] // 0x00000001897123F0-0x0000000189712410
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF693C */, bool useObjectPool = false /* Metadata: 0x00AF6940 */) => default; // 0x0000000182E855F0-0x0000000182E858F0
	// [XID] // 0x0000000189719A90-0x0000000189719AB0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6941 */, bool useObjectPool = false /* Metadata: 0x00AF6945 */) => default; // 0x0000000182E847F0-0x0000000182E84A60
	// [XID] // 0x0000000189720FB0-0x0000000189720FD0
	public static new ByHasFeatureTag ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6946 */, bool useObjectPool = false /* Metadata: 0x00AF694A */) => default; // 0x0000000182E850C0-0x0000000182E852E0
	[BlackList] // 0x00000001897286B0-0x00000001897286F0
	// [XID] // 0x00000001897286B0-0x00000001897286F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182E84060-0x0000000182E84330
	// [XID] // 0x0000000189732CC0-0x0000000189732CE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182E85E70-0x0000000182E860B0
	[BlackList] // 0x000000018973A3B0-0x000000018973A3F0
	// [XID] // 0x000000018973A3B0-0x000000018973A3F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182E85500-0x0000000182E855F0
	// [XID] // 0x0000000189744C50-0x0000000189744C70
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000182E84A60-0x0000000182E84B90
	[BlackList] // 0x000000018974C8A0-0x000000018974C8E0
	// [XID] // 0x000000018974C8A0-0x000000018974C8E0
	public override void AutoAllocTypeFields() {} // 0x0000000182E84330-0x0000000182E843D0
	[BlackList] // 0x0000000189756C00-0x0000000189756C40
	// [XID] // 0x0000000189756C00-0x0000000189756C40
	public override void AutoRecycleTypeFields() {} // 0x0000000182E843D0-0x0000000182E84480
	[BlackList] // 0x00000001897614B0-0x00000001897614F0
	// [XID] // 0x00000001897614B0-0x00000001897614F0
	public override void ReturnToObjectPool() {} // 0x0000000182E861A0-0x0000000182E86240
}

