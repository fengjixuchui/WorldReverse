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
public class ByDieStateFlag : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17338
{
	// Fields
	private DieStateFlag _dieStateFlag; // 0x18

	// Properties
	public DieStateFlag dieStateFlag { /* [XID] */ /* 0x00000001898FAB60-0x00000001898FAB80 */ get => default; /* [XID] */ /* 0x0000000189902740-0x0000000189902760 */ private set {} } // 0x00000001828B24B0-0x00000001828B2550 0x00000001828B2550-0x00000001828B2600

	// Constructors
	public ByDieStateFlag() {} // 0x00000001828B3F40-0x00000001828B3FA0

	// Methods
	// [XID] // 0x0000000189909D20-0x0000000189909D40
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001828B3DB0-0x00000001828B3EA0
	// [XID] // 0x0000000189911560-0x0000000189911580
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001828B3A50-0x00000001828B3B00
	// [XID] // 0x0000000189919140-0x0000000189919160
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6AEF */) => default; // 0x00000001828B3660-0x00000001828B3740
	// [XID] // 0x00000001899206D0-0x00000001899206F0
	public override int GetHashNum() => default; // 0x00000001828B2380-0x00000001828B2450
	// [XID] // 0x0000000189928030-0x0000000189928050
	public override void InitEmpty() {} // 0x00000001828B30F0-0x00000001828B3190
	[BlackList] // 0x000000018992F660-0x000000018992F6A0
	// [XID] // 0x000000018992F660-0x000000018992F6A0
	public override bool FromJson(JSONNode node) => default; // 0x00000001828B2AE0-0x00000001828B2E60
	// [XID] // 0x000000018993A010-0x000000018993A030
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001828B1C20-0x00000001828B1E40
	[BlackList] // 0x00000001899411E0-0x0000000189941220
	// [XID] // 0x00000001899411E0-0x0000000189941220
	public static new ByDieStateFlag ParseFromJson(JSONNode node) => default; // 0x00000001828B37A0-0x00000001828B39F0
	// [XID] // 0x000000018994BAE0-0x000000018994BB00
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6AF0 */, bool useObjectPool = false /* Metadata: 0x00AF6AF4 */) => default; // 0x00000001828B3360-0x00000001828B3660
	// [XID] // 0x0000000189953310-0x0000000189953330
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6AF5 */, bool useObjectPool = false /* Metadata: 0x00AF6AF9 */) => default; // 0x00000001828B2680-0x00000001828B28B0
	// [XID] // 0x000000018995AA70-0x000000018995AA90
	public static new ByDieStateFlag ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6AFA */, bool useObjectPool = false /* Metadata: 0x00AF6AFE */) => default; // 0x00000001828B2E60-0x00000001828B3080
	[BlackList] // 0x00000001899625F0-0x0000000189962630
	// [XID] // 0x00000001899625F0-0x0000000189962630
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001828B1E40-0x00000001828B2110
	// [XID] // 0x000000018996C970-0x000000018996C990
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001828B3BB0-0x00000001828B3DB0
	[BlackList] // 0x00000001899743B0-0x00000001899743F0
	// [XID] // 0x00000001899743B0-0x00000001899743F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001828B3270-0x00000001828B3360
	// [XID] // 0x000000018997E6E0-0x000000018997E700
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x00000001828B28B0-0x00000001828B29E0
	[BlackList] // 0x00000001899860F0-0x0000000189986130
	// [XID] // 0x00000001899860F0-0x0000000189986130
	public override void AutoAllocTypeFields() {} // 0x00000001828B2110-0x00000001828B21B0
	[BlackList] // 0x0000000189990E70-0x0000000189990EB0
	// [XID] // 0x0000000189990E70-0x0000000189990EB0
	public override void AutoRecycleTypeFields() {} // 0x00000001828B21B0-0x00000001828B2260
	[BlackList] // 0x000000018999B940-0x000000018999B980
	// [XID] // 0x000000018999B940-0x000000018999B980
	public override void ReturnToObjectPool() {} // 0x00000001828B3EA0-0x00000001828B3F40
}

