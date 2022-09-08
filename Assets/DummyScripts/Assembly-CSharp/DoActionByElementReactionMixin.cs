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
public class DoActionByElementReactionMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17063
{
	// Fields
	private SimpleSafeFloat rangeRawNum; // 0x30
	private EntityType[] _entityTypes; // 0x38
	private ElementReactionType[] _reactionTypes; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _actions; // 0x48

	// Properties
	public float range { /* [XID] */ /* 0x0000000189ACFD30-0x0000000189ACFD50 */ get => default; /* [XID] */ /* 0x0000000189AD7AC0-0x0000000189AD7AE0 */ private set {} } // 0x0000000180DE4CF0-0x0000000180DE4DD0 0x0000000180DE50D0-0x0000000180DE51B0
	public EntityType[] entityTypes { /* [XID] */ /* 0x0000000189ADF590-0x0000000189ADF5B0 */ get => default; /* [XID] */ /* 0x0000000189AE6DB0-0x0000000189AE6DD0 */ private set {} } // 0x0000000180DE5E10-0x0000000180DE5EB0 0x0000000180DE6BA0-0x0000000180DE6C50
	public ElementReactionType[] reactionTypes { /* [XID] */ /* 0x0000000189AEE8C0-0x0000000189AEE8E0 */ get => default; /* [XID] */ /* 0x0000000189AF5EB0-0x0000000189AF5ED0 */ private set {} } // 0x0000000180DE7320-0x0000000180DE73C0 0x0000000180DE7270-0x0000000180DE7320
	public ConfigAbilityAction[] actions { /* [XID] */ /* 0x0000000189AFD2F0-0x0000000189AFD310 */ get => default; /* [XID] */ /* 0x0000000189B04B00-0x0000000189B04B20 */ private set {} } // 0x0000000180DE6C50-0x0000000180DE6CF0 0x0000000180DE4DD0-0x0000000180DE4E80
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189B87DA0-0x0000000189B87DC0 */ get => default; } // 0x0000000180DE5760-0x0000000180DE5800 

	// Constructors
	public DoActionByElementReactionMixin() {} // 0x0000000180DE7460-0x0000000180DE7500

	// Methods
	// [XID] // 0x0000000189B0C310-0x0000000189B0C330
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000180DE7120-0x0000000180DE7270
	// [XID] // 0x0000000189B138B0-0x0000000189B138D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000180DE6A90-0x0000000180DE6BA0
	// [XID] // 0x0000000189B1AF00-0x0000000189B1AF20
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF61F3 */) => default; // 0x0000000180DE66A0-0x0000000180DE6780
	// [XID] // 0x0000000189B22650-0x0000000189B22670
	public override int GetHashNum() => default; // 0x0000000180DE4FA0-0x0000000180DE5070
	// [XID] // 0x0000000189B29BA0-0x0000000189B29BC0
	public override void InitEmpty() {} // 0x0000000180DE5FB0-0x0000000180DE60F0
	[BlackList] // 0x0000000189B31170-0x0000000189B311B0
	// [XID] // 0x0000000189B31170-0x0000000189B311B0
	public override bool FromJson(JSONNode node) => default; // 0x0000000180DE5800-0x0000000180DE5B80
	// [XID] // 0x0000000189B3B7D0-0x0000000189B3B7F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000180DE43A0-0x0000000180DE4890
	[BlackList] // 0x0000000189B431F0-0x0000000189B43230
	// [XID] // 0x0000000189B431F0-0x0000000189B43230
	public static new DoActionByElementReactionMixin ParseFromJson(JSONNode node) => default; // 0x0000000180DE67E0-0x0000000180DE6A30
	// [XID] // 0x0000000189B4D8C0-0x0000000189B4D8E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF61F4 */, bool useObjectPool = false /* Metadata: 0x00AF61F8 */) => default; // 0x0000000180DE62C0-0x0000000180DE65C0
	// [XID] // 0x0000000189B55190-0x0000000189B551B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF61F9 */, bool useObjectPool = false /* Metadata: 0x00AF61FD */) => default; // 0x0000000180DE5230-0x0000000180DE5660
	// [XID] // 0x0000000189B5CB70-0x0000000189B5CB90
	public static new DoActionByElementReactionMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF61FE */, bool useObjectPool = false /* Metadata: 0x00AF6202 */) => default; // 0x0000000180DE5BF0-0x0000000180DE5E10
	[BlackList] // 0x0000000189B64170-0x0000000189B641B0
	// [XID] // 0x0000000189B64170-0x0000000189B641B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000180DE4890-0x0000000180DE4B60
	// [XID] // 0x0000000189B6E660-0x0000000189B6E680
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000180DE6CF0-0x0000000180DE7120
	[BlackList] // 0x0000000189B75E70-0x0000000189B75EB0
	// [XID] // 0x0000000189B75E70-0x0000000189B75EB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000180DE61D0-0x0000000180DE62C0
	// [XID] // 0x0000000189B80350-0x0000000189B80370
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000180DE65C0-0x0000000180DE66A0
	[BlackList] // 0x0000000189B8EFB0-0x0000000189B8EFF0
	// [XID] // 0x0000000189B8EFB0-0x0000000189B8EFF0
	public override void AutoAllocTypeFields() {} // 0x0000000180DE4B60-0x0000000180DE4C00
	[BlackList] // 0x0000000189B99540-0x0000000189B99580
	// [XID] // 0x0000000189B99540-0x0000000189B99580
	public override void AutoRecycleTypeFields() {} // 0x0000000180DE4C00-0x0000000180DE4CF0
	[BlackList] // 0x0000000189BA3BB0-0x0000000189BA3BF0
	// [XID] // 0x0000000189BA3BB0-0x0000000189BA3BF0
	public override void ReturnToObjectPool() {} // 0x0000000180DE73C0-0x0000000180DE7460
}

