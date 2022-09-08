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
public class AttachToGadgetStateMutexMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16890
{
	// Fields
	private SimpleSafeInt32[] _gadgetStates; // 0x30
	private string[][] _modifierNames; // 0x38

	// Properties
	public SimpleSafeInt32[] gadgetStates { /* [XID] */ /* 0x0000000189A8F690-0x0000000189A8F6B0 */ get => default; /* [XID] */ /* 0x0000000189A96C60-0x0000000189A96C80 */ private set {} } // 0x00000001849B76F0-0x00000001849B7790 0x00000001849B7120-0x00000001849B71D0
	public string[][] modifierNames { /* [XID] */ /* 0x0000000189A9E010-0x0000000189A9E030 */ get => default; /* [XID] */ /* 0x0000000189AA5A80-0x0000000189AA5AA0 */ private set {} } // 0x00000001849B6180-0x00000001849B6220 0x00000001849B5D30-0x00000001849B5DE0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189B29C40-0x0000000189B29C60 */ get => default; } // 0x00000001849B66B0-0x00000001849B6750 

	// Constructors
	public AttachToGadgetStateMutexMixin() {} // 0x00000001849B7FE0-0x00000001849B8040

	// Methods
	// [XID] // 0x0000000189AAD0C0-0x0000000189AAD0E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001849B7E30-0x00000001849B7F40
	// [XID] // 0x0000000189AB4A90-0x0000000189AB4AB0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001849B7A40-0x00000001849B7B40
	// [XID] // 0x0000000189ABC7C0-0x0000000189ABC7E0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5C99 */) => default; // 0x00000001849B75B0-0x00000001849B7690
	// [XID] // 0x0000000189AC40A0-0x0000000189AC40C0
	public override int GetHashNum() => default; // 0x00000001849B6050-0x00000001849B6120
	// [XID] // 0x0000000189ACB5F0-0x0000000189ACB610
	public override void InitEmpty() {} // 0x00000001849B6E60-0x00000001849B6F50
	[BlackList] // 0x0000000189AD3060-0x0000000189AD30A0
	// [XID] // 0x0000000189AD3060-0x0000000189AD30A0
	public override bool FromJson(JSONNode node) => default; // 0x00000001849B6750-0x00000001849B6AD0
	// [XID] // 0x0000000189ADDD40-0x0000000189ADDD60
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001849B5740-0x00000001849B5A60
	[BlackList] // 0x0000000189AE5780-0x0000000189AE57C0
	// [XID] // 0x0000000189AE5780-0x0000000189AE57C0
	public static new AttachToGadgetStateMutexMixin ParseFromJson(JSONNode node) => default; // 0x00000001849B7790-0x00000001849B79E0
	// [XID] // 0x0000000189AF0290-0x0000000189AF02B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C9A */, bool useObjectPool = false /* Metadata: 0x00AF5C9E */) => default; // 0x00000001849B71D0-0x00000001849B74D0
	// [XID] // 0x0000000189AF76E0-0x0000000189AF7700
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C9F */, bool useObjectPool = false /* Metadata: 0x00AF5CA3 */) => default; // 0x00000001849B62A0-0x00000001849B65B0
	// [XID] // 0x0000000189AFED70-0x0000000189AFED90
	public static new AttachToGadgetStateMutexMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5CA4 */, bool useObjectPool = false /* Metadata: 0x00AF5CA8 */) => default; // 0x00000001849B6B40-0x00000001849B6D60
	[BlackList] // 0x0000000189B06560-0x0000000189B065A0
	// [XID] // 0x0000000189B06560-0x0000000189B065A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001849B5A60-0x00000001849B5D30
	// [XID] // 0x0000000189B10DD0-0x0000000189B10DF0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001849B7B40-0x00000001849B7E30
	[BlackList] // 0x0000000189B18060-0x0000000189B180A0
	// [XID] // 0x0000000189B18060-0x0000000189B180A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001849B7030-0x00000001849B7120
	// [XID] // 0x0000000189B226B0-0x0000000189B226D0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001849B74D0-0x00000001849B75B0
	[BlackList] // 0x0000000189B311F0-0x0000000189B31230
	// [XID] // 0x0000000189B311F0-0x0000000189B31230
	public override void AutoAllocTypeFields() {} // 0x00000001849B5DE0-0x00000001849B5E80
	[BlackList] // 0x0000000189B3B870-0x0000000189B3B8B0
	// [XID] // 0x0000000189B3B870-0x0000000189B3B8B0
	public override void AutoRecycleTypeFields() {} // 0x00000001849B5E80-0x00000001849B5F30
	[BlackList] // 0x0000000189B463A0-0x0000000189B463E0
	// [XID] // 0x0000000189B463A0-0x0000000189B463E0
	public override void ReturnToObjectPool() {} // 0x00000001849B7F40-0x00000001849B7FE0
}

