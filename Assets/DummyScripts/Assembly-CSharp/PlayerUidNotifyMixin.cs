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
public class PlayerUidNotifyMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17100
{
	// Fields
	private string _opParam; // 0x30
	private SimpleSafeUInt32 opTypeRawNum; // 0x38
	private RelationalOperator _logic; // 0x3C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _actions; // 0x40

	// Properties
	public string opParam { /* [XID] */ /* 0x0000000189662640-0x0000000189662660 */ get => default; /* [XID] */ /* 0x000000018966A200-0x000000018966A220 */ private set {} } // 0x0000000182ED8280-0x0000000182ED8320 0x0000000182ED6B70-0x0000000182ED6C20
	public uint opType { /* [XID] */ /* 0x0000000189671E00-0x0000000189671E20 */ get => default; /* [XID] */ /* 0x00000001896795F0-0x0000000189679610 */ private set {} } // 0x0000000182ED64D0-0x0000000182ED65A0 0x0000000182ED8860-0x0000000182ED8940
	public RelationalOperator logic { /* [XID] */ /* 0x0000000189680CE0-0x0000000189680D00 */ get => default; /* [XID] */ /* 0x0000000189688780-0x00000001896887A0 */ private set {} } // 0x0000000182ED7D90-0x0000000182ED7E30 0x0000000182ED73D0-0x0000000182ED7480
	public ConfigAbilityAction[] actions { /* [XID] */ /* 0x0000000189690140-0x0000000189690160 */ get => default; /* [XID] */ /* 0x0000000189697AC0-0x0000000189697AE0 */ private set {} } // 0x0000000182ED81E0-0x0000000182ED8280 0x0000000182ED6300-0x0000000182ED63B0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189719B10-0x0000000189719B30 */ get => default; } // 0x0000000182ED6D20-0x0000000182ED6DC0 

	// Constructors
	public PlayerUidNotifyMixin() {} // 0x0000000182ED89E0-0x0000000182ED8A40

	// Methods
	// [XID] // 0x000000018969EE70-0x000000018969EE90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182ED8710-0x0000000182ED8860
	// [XID] // 0x00000001896A62F0-0x00000001896A6310
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182ED80E0-0x0000000182ED81E0
	// [XID] // 0x00000001896AD830-0x00000001896AD850
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6343 */) => default; // 0x0000000182ED7C50-0x0000000182ED7D30
	// [XID] // 0x00000001896B4F50-0x00000001896B4F70
	public override int GetHashNum() => default; // 0x0000000182ED65A0-0x0000000182ED6670
	// [XID] // 0x00000001896BC240-0x00000001896BC260
	public override void InitEmpty() {} // 0x0000000182ED7580-0x0000000182ED76A0
	[BlackList] // 0x00000001896C3620-0x00000001896C3660
	// [XID] // 0x00000001896C3620-0x00000001896C3660
	public override bool FromJson(JSONNode node) => default; // 0x0000000182ED6DC0-0x0000000182ED7140
	// [XID] // 0x00000001896CDD70-0x00000001896CDD90
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182ED59A0-0x0000000182ED5EA0
	[BlackList] // 0x00000001896D5340-0x00000001896D5380
	// [XID] // 0x00000001896D5340-0x00000001896D5380
	public static new PlayerUidNotifyMixin ParseFromJson(JSONNode node) => default; // 0x0000000182ED7E30-0x0000000182ED8080
	// [XID] // 0x00000001896DFB40-0x00000001896DFB60
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6344 */, bool useObjectPool = false /* Metadata: 0x00AF6348 */) => default; // 0x0000000182ED7870-0x0000000182ED7B70
	// [XID] // 0x00000001896E6EE0-0x00000001896E6F00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6349 */, bool useObjectPool = false /* Metadata: 0x00AF634D */) => default; // 0x0000000182ED6750-0x0000000182ED6B70
	// [XID] // 0x00000001896EE470-0x00000001896EE490
	public static new PlayerUidNotifyMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF634E */, bool useObjectPool = false /* Metadata: 0x00AF6352 */) => default; // 0x0000000182ED71B0-0x0000000182ED73D0
	[BlackList] // 0x00000001896F5D40-0x00000001896F5D80
	// [XID] // 0x00000001896F5D40-0x00000001896F5D80
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182ED5EA0-0x0000000182ED6170
	// [XID] // 0x00000001897001E0-0x0000000189700200
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182ED8320-0x0000000182ED8710
	[BlackList] // 0x00000001897079B0-0x00000001897079F0
	// [XID] // 0x00000001897079B0-0x00000001897079F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182ED7780-0x0000000182ED7870
	// [XID] // 0x0000000189712430-0x0000000189712450
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182ED7B70-0x0000000182ED7C50
	[BlackList] // 0x0000000189721070-0x00000001897210B0
	// [XID] // 0x0000000189721070-0x00000001897210B0
	public override void AutoAllocTypeFields() {} // 0x0000000182ED6170-0x0000000182ED6210
	[BlackList] // 0x000000018972B4D0-0x000000018972B510
	// [XID] // 0x000000018972B4D0-0x000000018972B510
	public override void AutoRecycleTypeFields() {} // 0x0000000182ED6210-0x0000000182ED6300
	[BlackList] // 0x0000000189735C60-0x0000000189735CA0
	// [XID] // 0x0000000189735C60-0x0000000189735CA0
	public override void ReturnToObjectPool() {} // 0x0000000182ED8940-0x0000000182ED89E0
}

