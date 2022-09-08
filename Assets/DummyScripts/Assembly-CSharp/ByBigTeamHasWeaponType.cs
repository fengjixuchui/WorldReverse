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
public class ByBigTeamHasWeaponType : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17310
{
	// Fields
	private string _weaponType; // 0x18
	private SimpleSafeUInt32 numberRawNum; // 0x20
	private RelationalOperator _logic; // 0x24

	// Properties
	public string weaponType { /* [XID] */ /* 0x0000000189B71930-0x0000000189B71950 */ get => default; /* [XID] */ /* 0x0000000189B78DA0-0x0000000189B78DC0 */ private set {} } // 0x00000001821C2290-0x00000001821C2330 0x00000001821C2170-0x00000001821C2220
	public uint number { /* [XID] */ /* 0x0000000189B802B0-0x0000000189B802D0 */ get => default; /* [XID] */ /* 0x0000000189B87D80-0x0000000189B87DA0 */ private set {} } // 0x00000001821C14A0-0x00000001821C1570 0x00000001821C2E80-0x00000001821C2F60
	public RelationalOperator logic { /* [XID] */ /* 0x0000000189B8EF90-0x0000000189B8EFB0 */ get => default; /* [XID] */ /* 0x0000000189B96440-0x0000000189B96460 */ private set {} } // 0x00000001821C2A50-0x00000001821C2AF0 0x00000001821C20C0-0x00000001821C2170

	// Constructors
	public ByBigTeamHasWeaponType() {} // 0x00000001821C3520-0x00000001821C3580

	// Methods
	// [XID] // 0x0000000189B9D9C0-0x0000000189B9D9E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001821C3350-0x00000001821C3480
	// [XID] // 0x0000000189BA53D0-0x0000000189BA53F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001821C2DA0-0x00000001821C2E80
	// [XID] // 0x0000000189BAC550-0x0000000189BAC570
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6A1B */) => default; // 0x00000001821C2910-0x00000001821C29F0
	// [XID] // 0x0000000189BB3E30-0x0000000189BB3E50
	public override int GetHashNum() => default; // 0x00000001821C12F0-0x00000001821C13C0
	// [XID] // 0x0000000189BBB3F0-0x0000000189BBB410
	public override void InitEmpty() {} // 0x00000001821C2330-0x00000001821C2440
	[BlackList] // 0x0000000189BC3210-0x0000000189BC3250
	// [XID] // 0x0000000189BC3210-0x0000000189BC3250
	public override bool FromJson(JSONNode node) => default; // 0x00000001821C1B20-0x00000001821C1EA0
	// [XID] // 0x0000000189BCD9C0-0x0000000189BCD9E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001821C0950-0x00000001821C0D80
	[BlackList] // 0x0000000189BD4E90-0x0000000189BD4ED0
	// [XID] // 0x0000000189BD4E90-0x0000000189BD4ED0
	public static new ByBigTeamHasWeaponType ParseFromJson(JSONNode node) => default; // 0x00000001821C2AF0-0x00000001821C2D40
	// [XID] // 0x0000000189BDF9E0-0x0000000189BDFA00
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A1C */, bool useObjectPool = false /* Metadata: 0x00AF6A20 */) => default; // 0x00000001821C2610-0x00000001821C2910
	// [XID] // 0x00000001895EC530-0x00000001895EC550
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A21 */, bool useObjectPool = false /* Metadata: 0x00AF6A25 */) => default; // 0x00000001821C1570-0x00000001821C18F0
	// [XID] // 0x00000001895F39D0-0x00000001895F39F0
	public static new ByBigTeamHasWeaponType ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A26 */, bool useObjectPool = false /* Metadata: 0x00AF6A2A */) => default; // 0x00000001821C1EA0-0x00000001821C20C0
	[BlackList] // 0x00000001895FB2F0-0x00000001895FB330
	// [XID] // 0x00000001895FB2F0-0x00000001895FB330
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001821C0D80-0x00000001821C1050
	// [XID] // 0x0000000189605990-0x00000001896059B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001821C3010-0x00000001821C3350
	[BlackList] // 0x000000018960D280-0x000000018960D2C0
	// [XID] // 0x000000018960D280-0x000000018960D2C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001821C2520-0x00000001821C2610
	// [XID] // 0x0000000189617730-0x0000000189617750
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x00000001821C18F0-0x00000001821C1A20
	[BlackList] // 0x000000018961F320-0x000000018961F360
	// [XID] // 0x000000018961F320-0x000000018961F360
	public override void AutoAllocTypeFields() {} // 0x00000001821C1050-0x00000001821C10F0
	[BlackList] // 0x00000001896299D0-0x0000000189629A10
	// [XID] // 0x00000001896299D0-0x0000000189629A10
	public override void AutoRecycleTypeFields() {} // 0x00000001821C10F0-0x00000001821C11D0
	[BlackList] // 0x0000000189634250-0x0000000189634290
	// [XID] // 0x0000000189634250-0x0000000189634290
	public override void ReturnToObjectPool() {} // 0x00000001821C3480-0x00000001821C3520
}

