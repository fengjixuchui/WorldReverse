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
public class FireUIEffect : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16809
{
	// Fields
	private string _effectPattern; // 0x68
	private ActionPanelEffectSlot _effectSlot; // 0x70

	// Properties
	public string effectPattern { /* [XID] */ /* 0x0000000189A8ADA0-0x0000000189A8ADC0 */ get => default; /* [XID] */ /* 0x0000000189A92530-0x0000000189A92550 */ private set {} } // 0x000000018180AA00-0x000000018180AAA0 0x000000018180BA40-0x000000018180BAF0
	public ActionPanelEffectSlot effectSlot { /* [XID] */ /* 0x0000000189A99FC0-0x0000000189A99FE0 */ get => default; /* [XID] */ /* 0x0000000189AA0F80-0x0000000189AA0FA0 */ private set {} } // 0x000000018180B520-0x000000018180B5C0 0x000000018180B040-0x000000018180B0F0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B255C0-0x0000000189B255E0 */ get => default; } // 0x000000018180B340-0x000000018180B3E0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B2CB30-0x0000000189B2CB50 */ get => default; } // 0x000000018180A810-0x000000018180A8B0 

	// Constructors
	public FireUIEffect() {} // 0x000000018180BB90-0x000000018180BBF0

	// Methods
	// [XID] // 0x0000000189AA8600-0x0000000189AA8620
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018180B930-0x000000018180BA40
	// [XID] // 0x0000000189AB02C0-0x0000000189AB02E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018180B440-0x000000018180B520
	// [XID] // 0x0000000189AB79A0-0x0000000189AB79C0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF46F6 */) => default; // 0x000000018180AF00-0x000000018180AFE0
	// [XID] // 0x0000000189ABF410-0x0000000189ABF430
	public override int GetHashNum() => default; // 0x0000000181809AA0-0x0000000181809B70
	// [XID] // 0x0000000189AC6E80-0x0000000189AC6EA0
	public override void InitEmpty() {} // 0x000000018180A8B0-0x000000018180A980
	[BlackList] // 0x0000000189ACE610-0x0000000189ACE650
	// [XID] // 0x0000000189ACE610-0x0000000189ACE650
	public override bool FromJson(JSONNode node) => default; // 0x000000018180A200-0x000000018180A580
	// [XID] // 0x0000000189AD93F0-0x0000000189AD9410
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001818091E0-0x00000001818094F0
	[BlackList] // 0x0000000189AE0F40-0x0000000189AE0F80
	// [XID] // 0x0000000189AE0F40-0x0000000189AE0F80
	public static new FireUIEffect ParseFromJson(JSONNode node) => default; // 0x000000018180B0F0-0x000000018180B340
	// [XID] // 0x0000000189AEB610-0x0000000189AEB630
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF46F7 */, bool useObjectPool = false /* Metadata: 0x00AF46FB */) => default; // 0x000000018180AC00-0x000000018180AF00
	// [XID] // 0x0000000189AF2F90-0x0000000189AF2FB0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF46FC */, bool useObjectPool = false /* Metadata: 0x00AF4700 */) => default; // 0x0000000181809CC0-0x0000000181809FA0
	// [XID] // 0x0000000189AFA860-0x0000000189AFA880
	public static new FireUIEffect ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4701 */, bool useObjectPool = false /* Metadata: 0x00AF4705 */) => default; // 0x000000018180A580-0x000000018180A7A0
	[BlackList] // 0x0000000189B01DF0-0x0000000189B01E30
	// [XID] // 0x0000000189B01DF0-0x0000000189B01E30
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001818094F0-0x00000001818097C0
	// [XID] // 0x0000000189B0C390-0x0000000189B0C3B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018180B6A0-0x000000018180B930
	[BlackList] // 0x0000000189B13910-0x0000000189B13950
	// [XID] // 0x0000000189B13910-0x0000000189B13950
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018180AB00-0x000000018180AC00
	// [XID] // 0x0000000189B1DD90-0x0000000189B1DDB0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000181809FA0-0x000000018180A100
	[BlackList] // 0x0000000189B33F80-0x0000000189B33FC0
	// [XID] // 0x0000000189B33F80-0x0000000189B33FC0
	public override void AutoAllocTypeFields() {} // 0x00000001818097C0-0x0000000181809860
	[BlackList] // 0x0000000189B3E940-0x0000000189B3E980
	// [XID] // 0x0000000189B3E940-0x0000000189B3E980
	public override void AutoRecycleTypeFields() {} // 0x0000000181809860-0x0000000181809910
	[BlackList] // 0x0000000189B49600-0x0000000189B49640
	// [XID] // 0x0000000189B49600-0x0000000189B49640
	public override void ReturnToObjectPool() {} // 0x000000018180BAF0-0x000000018180BB90
}

