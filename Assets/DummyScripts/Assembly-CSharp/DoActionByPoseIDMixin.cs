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
public class DoActionByPoseIDMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17051
{
	// Fields
	private SimpleSafeInt32[] _poseIDs; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _enterPredicates; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _exitPredicates; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _enterActions; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _exitActions; // 0x50

	// Properties
	public SimpleSafeInt32[] poseIDs { /* [XID] */ /* 0x0000000189AF5ED0-0x0000000189AF5EF0 */ get => default; /* [XID] */ /* 0x0000000189AFD310-0x0000000189AFD330 */ private set {} } // 0x0000000182B2FA90-0x0000000182B2FB30 0x0000000182B32660-0x0000000182B32710
	public ConfigAbilityPredicate[] enterPredicates { /* [XID] */ /* 0x0000000189B04B20-0x0000000189B04B40 */ get => default; /* [XID] */ /* 0x0000000189B0C330-0x0000000189B0C350 */ private set {} } // 0x0000000182B316B0-0x0000000182B31750 0x0000000182B30450-0x0000000182B30500
	public ConfigAbilityPredicate[] exitPredicates { /* [XID] */ /* 0x0000000189B138D0-0x0000000189B138F0 */ get => default; /* [XID] */ /* 0x0000000189B1AF20-0x0000000189B1AF40 */ private set {} } // 0x0000000182B2FB30-0x0000000182B2FBD0 0x0000000182B32400-0x0000000182B324B0
	public ConfigAbilityAction[] enterActions { /* [XID] */ /* 0x0000000189B22670-0x0000000189B22690 */ get => default; /* [XID] */ /* 0x0000000189B29BC0-0x0000000189B29BE0 */ private set {} } // 0x0000000182B318F0-0x0000000182B31990 0x0000000182B32C20-0x0000000182B32CD0
	public ConfigAbilityAction[] exitActions { /* [XID] */ /* 0x0000000189B311B0-0x0000000189B311D0 */ get => default; /* [XID] */ /* 0x0000000189B38830-0x0000000189B38850 */ private set {} } // 0x0000000182B317E0-0x0000000182B31880 0x0000000182B31600-0x0000000182B316B0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189BBB450-0x0000000189BBB470 */ get => default; } // 0x0000000182B30F50-0x0000000182B30FF0 

	// Constructors
	public DoActionByPoseIDMixin() {} // 0x0000000182B32EE0-0x0000000182B32F40

	// Methods
	// [XID] // 0x0000000189B401A0-0x0000000189B401C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182B32CD0-0x0000000182B32E40
	// [XID] // 0x0000000189B47AE0-0x0000000189B47B00
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182B32510-0x0000000182B32660
	// [XID] // 0x0000000189B4F310-0x0000000189B4F330
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6193 */) => default; // 0x0000000182B32070-0x0000000182B32150
	// [XID] // 0x0000000189B56BF0-0x0000000189B56C10
	public override int GetHashNum() => default; // 0x0000000182B307A0-0x0000000182B30870
	// [XID] // 0x0000000189B5E520-0x0000000189B5E540
	public override void InitEmpty() {} // 0x0000000182B31990-0x0000000182B31AC0
	[BlackList] // 0x0000000189B65A20-0x0000000189B65A60
	// [XID] // 0x0000000189B65A20-0x0000000189B65A60
	public override bool FromJson(JSONNode node) => default; // 0x0000000182B30FF0-0x0000000182B31370
	// [XID] // 0x0000000189B700E0-0x0000000189B70100
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182B2FBD0-0x0000000182B30180
	[BlackList] // 0x0000000189B77450-0x0000000189B77490
	// [XID] // 0x0000000189B77450-0x0000000189B77490
	public static new DoActionByPoseIDMixin ParseFromJson(JSONNode node) => default; // 0x0000000182B321B0-0x0000000182B32400
	// [XID] // 0x0000000189B81D90-0x0000000189B81DB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6194 */, bool useObjectPool = false /* Metadata: 0x00AF6198 */) => default; // 0x0000000182B31C90-0x0000000182B31F90
	// [XID] // 0x0000000189B89470-0x0000000189B89490
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6199 */, bool useObjectPool = false /* Metadata: 0x00AF619D */) => default; // 0x0000000182B30950-0x0000000182B30E50
	// [XID] // 0x0000000189B90A70-0x0000000189B90A90
	public static new DoActionByPoseIDMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF619E */, bool useObjectPool = false /* Metadata: 0x00AF61A2 */) => default; // 0x0000000182B313E0-0x0000000182B31600
	[BlackList] // 0x0000000189B97E80-0x0000000189B97EC0
	// [XID] // 0x0000000189B97E80-0x0000000189B97EC0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182B30180-0x0000000182B30450
	// [XID] // 0x0000000189BA2530-0x0000000189BA2550
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182B32710-0x0000000182B32C20
	[BlackList] // 0x0000000189BA9A00-0x0000000189BA9A40
	// [XID] // 0x0000000189BA9A00-0x0000000189BA9A40
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182B31BA0-0x0000000182B31C90
	// [XID] // 0x0000000189BB3E70-0x0000000189BB3E90
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182B31F90-0x0000000182B32070
	[BlackList] // 0x0000000189BC32D0-0x0000000189BC3310
	// [XID] // 0x0000000189BC32D0-0x0000000189BC3310
	public override void AutoAllocTypeFields() {} // 0x0000000182B30500-0x0000000182B305A0
	[BlackList] // 0x0000000189BCDA60-0x0000000189BCDAA0
	// [XID] // 0x0000000189BCDA60-0x0000000189BCDAA0
	public override void AutoRecycleTypeFields() {} // 0x0000000182B305A0-0x0000000182B30680
	[BlackList] // 0x0000000189BD7DF0-0x0000000189BD7E30
	// [XID] // 0x0000000189BD7DF0-0x0000000189BD7E30
	public override void ReturnToObjectPool() {} // 0x0000000182B32E40-0x0000000182B32EE0
}

