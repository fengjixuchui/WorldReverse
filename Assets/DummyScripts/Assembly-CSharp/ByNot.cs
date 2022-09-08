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
public class ByNot : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17206
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _predicates; // 0x18

	// Properties
	public ConfigAbilityPredicate[] predicates { /* [XID] */ /* 0x0000000189901900-0x0000000189901920 */ get => default; /* [XID] */ /* 0x0000000189B91FE0-0x0000000189B92000 */ private set {} } // 0x00000001842D6700-0x00000001842D67A0 0x00000001842D6260-0x00000001842D6310

	// Constructors
	public ByNot() {} // 0x00000001842D6C20-0x00000001842D6C80

	// Methods
	// [XID] // 0x0000000189B994E0-0x0000000189B99500
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001842D6A90-0x00000001842D6B80
	// [XID] // 0x0000000189BA09D0-0x0000000189BA09F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001842D6620-0x00000001842D6700
	// [XID] // 0x0000000189BA80D0-0x0000000189BA80F0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6697 */) => default; // 0x00000001842D6180-0x00000001842D6260
	// [XID] // 0x0000000189BAF560-0x0000000189BAF580
	public override int GetHashNum() => default; // 0x00000001842D4F80-0x00000001842D5050
	// [XID] // 0x0000000189BB6C10-0x0000000189BB6C30
	public override void InitEmpty() {} // 0x00000001842D5BE0-0x00000001842D5CB0
	[BlackList] // 0x0000000189BBE290-0x0000000189BBE2D0
	// [XID] // 0x0000000189BBE290-0x0000000189BBE2D0
	public override bool FromJson(JSONNode node) => default; // 0x00000001842D55D0-0x00000001842D5950
	// [XID] // 0x0000000189BC9000-0x0000000189BC9020
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001842D4810-0x00000001842D4A40
	[BlackList] // 0x0000000189BD08B0-0x0000000189BD08F0
	// [XID] // 0x0000000189BD08B0-0x0000000189BD08F0
	public static new ByNot ParseFromJson(JSONNode node) => default; // 0x00000001842D6370-0x00000001842D65C0
	// [XID] // 0x0000000189BDB100-0x0000000189BDB120
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6698 */, bool useObjectPool = false /* Metadata: 0x00AF669C */) => default; // 0x00000001842D5E80-0x00000001842D6180
	// [XID] // 0x00000001895E7A10-0x00000001895E7A30
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF669D */, bool useObjectPool = false /* Metadata: 0x00AF66A1 */) => default; // 0x00000001842D5130-0x00000001842D53A0
	// [XID] // 0x00000001895EF360-0x00000001895EF380
	public static new ByNot ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF66A2 */, bool useObjectPool = false /* Metadata: 0x00AF66A6 */) => default; // 0x00000001842D5950-0x00000001842D5B70
	[BlackList] // 0x00000001895F6D80-0x00000001895F6DC0
	// [XID] // 0x00000001895F6D80-0x00000001895F6DC0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001842D4A40-0x00000001842D4D10
	// [XID] // 0x00000001896012E0-0x0000000189601300
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001842D6850-0x00000001842D6A90
	[BlackList] // 0x0000000189608CB0-0x0000000189608CF0
	// [XID] // 0x0000000189608CB0-0x0000000189608CF0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001842D5D90-0x00000001842D5E80
	// [XID] // 0x00000001896131A0-0x00000001896131C0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x00000001842D53A0-0x00000001842D54D0
	[BlackList] // 0x000000018961A9E0-0x000000018961AA20
	// [XID] // 0x000000018961A9E0-0x000000018961AA20
	public override void AutoAllocTypeFields() {} // 0x00000001842D4D10-0x00000001842D4DB0
	[BlackList] // 0x0000000189624DF0-0x0000000189624E30
	// [XID] // 0x0000000189624DF0-0x0000000189624E30
	public override void AutoRecycleTypeFields() {} // 0x00000001842D4DB0-0x00000001842D4E60
	[BlackList] // 0x000000018962F860-0x000000018962F8A0
	// [XID] // 0x000000018962F860-0x000000018962F8A0
	public override void ReturnToObjectPool() {} // 0x00000001842D6B80-0x00000001842D6C20
}

