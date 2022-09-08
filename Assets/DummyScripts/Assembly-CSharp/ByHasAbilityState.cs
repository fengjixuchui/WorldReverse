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
public class ByHasAbilityState : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17204
{
	// Fields
	private AbilityState _abilityState; // 0x18

	// Properties
	public AbilityState abilityState { /* [XID] */ /* 0x0000000189AD1650-0x0000000189AD1670 */ get => default; /* [XID] */ /* 0x0000000189AD9370-0x0000000189AD9390 */ private set {} } // 0x00000001818F4A40-0x00000001818F4AE0 0x00000001818F43B0-0x00000001818F4460

	// Constructors
	public ByHasAbilityState() {} // 0x00000001818F53C0-0x00000001818F5420

	// Methods
	// [XID] // 0x0000000189AE0E80-0x0000000189AE0EA0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001818F5230-0x00000001818F5320
	// [XID] // 0x0000000189AE8290-0x0000000189AE82B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001818F4ED0-0x00000001818F4F80
	// [XID] // 0x0000000189AF0190-0x0000000189AF01B0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6687 */) => default; // 0x00000001818F4AE0-0x00000001818F4BC0
	// [XID] // 0x0000000189AF7620-0x0000000189AF7640
	public override int GetHashNum() => default; // 0x00000001818F3800-0x00000001818F38D0
	// [XID] // 0x0000000189AFECF0-0x0000000189AFED10
	public override void InitEmpty() {} // 0x00000001818F44D0-0x00000001818F4570
	[BlackList] // 0x0000000189B064A0-0x0000000189B064E0
	// [XID] // 0x0000000189B064A0-0x0000000189B064E0
	public override bool FromJson(JSONNode node) => default; // 0x00000001818F3E10-0x00000001818F4190
	// [XID] // 0x0000000189B10D30-0x0000000189B10D50
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001818F30A0-0x00000001818F32C0
	[BlackList] // 0x0000000189B17F40-0x0000000189B17F80
	// [XID] // 0x0000000189B17F40-0x0000000189B17F80
	public static new ByHasAbilityState ParseFromJson(JSONNode node) => default; // 0x00000001818F4C20-0x00000001818F4E70
	// [XID] // 0x0000000189B225B0-0x0000000189B225D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6688 */, bool useObjectPool = false /* Metadata: 0x00AF668C */) => default; // 0x00000001818F4740-0x00000001818F4A40
	// [XID] // 0x0000000189B29B20-0x0000000189B29B40
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF668D */, bool useObjectPool = false /* Metadata: 0x00AF6691 */) => default; // 0x00000001818F39B0-0x00000001818F3BE0
	// [XID] // 0x0000000189B31110-0x0000000189B31130
	public static new ByHasAbilityState ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6692 */, bool useObjectPool = false /* Metadata: 0x00AF6696 */) => default; // 0x00000001818F4190-0x00000001818F43B0
	[BlackList] // 0x0000000189B387F0-0x0000000189B38830
	// [XID] // 0x0000000189B387F0-0x0000000189B38830
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001818F32C0-0x00000001818F3590
	// [XID] // 0x0000000189B431B0-0x0000000189B431D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001818F5030-0x00000001818F5230
	[BlackList] // 0x0000000189B4AA70-0x0000000189B4AAB0
	// [XID] // 0x0000000189B4AA70-0x0000000189B4AAB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001818F4650-0x00000001818F4740
	// [XID] // 0x0000000189B55110-0x0000000189B55130
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x00000001818F3BE0-0x00000001818F3D10
	[BlackList] // 0x0000000189B5CAF0-0x0000000189B5CB30
	// [XID] // 0x0000000189B5CAF0-0x0000000189B5CB30
	public override void AutoAllocTypeFields() {} // 0x00000001818F3590-0x00000001818F3630
	[BlackList] // 0x0000000189B67360-0x0000000189B673A0
	// [XID] // 0x0000000189B67360-0x0000000189B673A0
	public override void AutoRecycleTypeFields() {} // 0x00000001818F3630-0x00000001818F36E0
	[BlackList] // 0x0000000189B71990-0x0000000189B719D0
	// [XID] // 0x0000000189B71990-0x0000000189B719D0
	public override void ReturnToObjectPool() {} // 0x00000001818F5320-0x00000001818F53C0
}

