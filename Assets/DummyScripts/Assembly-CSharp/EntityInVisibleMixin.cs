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
public class EntityInVisibleMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17159
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _predicates; // 0x30
	private AbilityEntityVisibleReason _reason; // 0x38

	// Properties
	public ConfigAbilityPredicate[] predicates { /* [XID] */ /* 0x0000000189AA28A0-0x0000000189AA28C0 */ get => default; /* [XID] */ /* 0x0000000189AA9F20-0x0000000189AA9F40 */ private set {} } // 0x00000001829CA190-0x00000001829CA230 0x00000001829C9CF0-0x00000001829C9DA0
	public AbilityEntityVisibleReason reason { /* [XID] */ /* 0x0000000189AB1D40-0x0000000189AB1D60 */ get => default; /* [XID] */ /* 0x0000000189AB9050-0x0000000189AB9070 */ private set {} } // 0x00000001829C87D0-0x00000001829C8870 0x00000001829C8C30-0x00000001829C8CE0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189B3CE40-0x0000000189B3CE60 */ get => default; } // 0x00000001829C8DE0-0x00000001829C8E80 

	// Constructors
	public EntityInVisibleMixin() {} // 0x00000001829CA6A0-0x00000001829CA700

	// Methods
	// [XID] // 0x0000000189AC0B90-0x0000000189AC0BB0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001829CA4F0-0x00000001829CA600
	// [XID] // 0x0000000189AC85D0-0x0000000189AC85F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001829CA0B0-0x00000001829CA190
	// [XID] // 0x0000000189ACFD10-0x0000000189ACFD30
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6501 */) => default; // 0x00000001829C9C10-0x00000001829C9CF0
	// [XID] // 0x0000000189AD7AA0-0x0000000189AD7AC0
	public override int GetHashNum() => default; // 0x00000001829C8700-0x00000001829C87D0
	// [XID] // 0x0000000189ADF570-0x0000000189ADF590
	public override void InitEmpty() {} // 0x00000001829C9590-0x00000001829C9660
	[BlackList] // 0x0000000189AE6D30-0x0000000189AE6D70
	// [XID] // 0x0000000189AE6D30-0x0000000189AE6D70
	public override bool FromJson(JSONNode node) => default; // 0x00000001829C8E80-0x00000001829C9200
	// [XID] // 0x0000000189AF1850-0x0000000189AF1870
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001829C7EA0-0x00000001829C81B0
	[BlackList] // 0x0000000189AF8FB0-0x0000000189AF8FF0
	// [XID] // 0x0000000189AF8FB0-0x0000000189AF8FF0
	public static new EntityInVisibleMixin ParseFromJson(JSONNode node) => default; // 0x00000001829C9E00-0x00000001829CA050
	// [XID] // 0x0000000189B033F0-0x0000000189B03410
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6502 */, bool useObjectPool = false /* Metadata: 0x00AF6506 */) => default; // 0x00000001829C9830-0x00000001829C9B30
	// [XID] // 0x0000000189B0AC40-0x0000000189B0AC60
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6507 */, bool useObjectPool = false /* Metadata: 0x00AF650B */) => default; // 0x00000001829C8950-0x00000001829C8C30
	// [XID] // 0x0000000189B12360-0x0000000189B12380
	public static new EntityInVisibleMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF650C */, bool useObjectPool = false /* Metadata: 0x00AF6510 */) => default; // 0x00000001829C9270-0x00000001829C9490
	[BlackList] // 0x0000000189B19650-0x0000000189B19690
	// [XID] // 0x0000000189B19650-0x0000000189B19690
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001829C81B0-0x00000001829C8480
	// [XID] // 0x0000000189B23F80-0x0000000189B23FA0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001829CA230-0x00000001829CA4F0
	[BlackList] // 0x0000000189B2B370-0x0000000189B2B3B0
	// [XID] // 0x0000000189B2B370-0x0000000189B2B3B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001829C9740-0x00000001829C9830
	// [XID] // 0x0000000189B35580-0x0000000189B355A0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001829C9B30-0x00000001829C9C10
	[BlackList] // 0x0000000189B44B90-0x0000000189B44BD0
	// [XID] // 0x0000000189B44B90-0x0000000189B44BD0
	public override void AutoAllocTypeFields() {} // 0x00000001829C8480-0x00000001829C8520
	[BlackList] // 0x0000000189B4F2D0-0x0000000189B4F310
	// [XID] // 0x0000000189B4F2D0-0x0000000189B4F310
	public override void AutoRecycleTypeFields() {} // 0x00000001829C8520-0x00000001829C85E0
	[BlackList] // 0x0000000189B59AC0-0x0000000189B59B00
	// [XID] // 0x0000000189B59AC0-0x0000000189B59B00
	public override void ReturnToObjectPool() {} // 0x00000001829CA600-0x00000001829CA6A0
}

