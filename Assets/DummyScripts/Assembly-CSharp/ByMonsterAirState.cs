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
public class ByMonsterAirState : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17358
{
	// Fields
	private bool _IsAirMove; // 0x18

	// Properties
	public bool IsAirMove { /* [XID] */ /* 0x00000001899FCEB0-0x00000001899FCED0 */ get => default; /* [XID] */ /* 0x0000000189A04330-0x0000000189A04350 */ private set {} } // 0x0000000181CA5370-0x0000000181CA5410 0x0000000181CA6810-0x0000000181CA68C0

	// Constructors
	public ByMonsterAirState() {} // 0x0000000181CA71A0-0x0000000181CA7210

	// Methods
	// [XID] // 0x0000000189A0BA90-0x0000000189A0BAB0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181CA7010-0x0000000181CA7100
	// [XID] // 0x0000000189A13360-0x0000000189A13380
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181CA6CB0-0x0000000181CA6D60
	// [XID] // 0x0000000189A1A510-0x0000000189A1A530
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6B8F */) => default; // 0x0000000181CA68C0-0x0000000181CA69A0
	// [XID] // 0x0000000189A21C90-0x0000000189A21CB0
	public override int GetHashNum() => default; // 0x0000000181CA5680-0x0000000181CA5750
	// [XID] // 0x0000000189A291E0-0x0000000189A29200
	public override void InitEmpty() {} // 0x0000000181CA62A0-0x0000000181CA6340
	[BlackList] // 0x0000000189A307F0-0x0000000189A30830
	// [XID] // 0x0000000189A307F0-0x0000000189A30830
	public override bool FromJson(JSONNode node) => default; // 0x0000000181CA5C90-0x0000000181CA6010
	// [XID] // 0x0000000189A3AF40-0x0000000189A3AF60
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181CA4EA0-0x0000000181CA50A0
	[BlackList] // 0x0000000189A42830-0x0000000189A42870
	// [XID] // 0x0000000189A42830-0x0000000189A42870
	public static new ByMonsterAirState ParseFromJson(JSONNode node) => default; // 0x0000000181CA6A00-0x0000000181CA6C50
	// [XID] // 0x0000000189A4CEA0-0x0000000189A4CEC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B90 */, bool useObjectPool = false /* Metadata: 0x00AF6B94 */) => default; // 0x0000000181CA6510-0x0000000181CA6810
	// [XID] // 0x0000000189A54630-0x0000000189A54650
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B95 */, bool useObjectPool = false /* Metadata: 0x00AF6B99 */) => default; // 0x0000000181CA5830-0x0000000181CA5A60
	// [XID] // 0x0000000189A5C120-0x0000000189A5C140
	public static new ByMonsterAirState ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B9A */, bool useObjectPool = false /* Metadata: 0x00AF6B9E */) => default; // 0x0000000181CA6010-0x0000000181CA6230
	[BlackList] // 0x0000000189A63A70-0x0000000189A63AB0
	// [XID] // 0x0000000189A63A70-0x0000000189A63AB0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181CA50A0-0x0000000181CA5370
	// [XID] // 0x0000000189A6E1C0-0x0000000189A6E1E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181CA6E10-0x0000000181CA7010
	[BlackList] // 0x0000000189A75750-0x0000000189A75790
	// [XID] // 0x0000000189A75750-0x0000000189A75790
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181CA6420-0x0000000181CA6510
	// [XID] // 0x0000000189A80020-0x0000000189A80040
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000181CA5A60-0x0000000181CA5B90
	[BlackList] // 0x0000000189A87D40-0x0000000189A87D80
	// [XID] // 0x0000000189A87D40-0x0000000189A87D80
	public override void AutoAllocTypeFields() {} // 0x0000000181CA5410-0x0000000181CA54B0
	[BlackList] // 0x0000000189A92410-0x0000000189A92450
	// [XID] // 0x0000000189A92410-0x0000000189A92450
	public override void AutoRecycleTypeFields() {} // 0x0000000181CA54B0-0x0000000181CA5560
	[BlackList] // 0x0000000189A9CB30-0x0000000189A9CB70
	// [XID] // 0x0000000189A9CB30-0x0000000189A9CB70
	public override void ReturnToObjectPool() {} // 0x0000000181CA7100-0x0000000181CA71A0
}

