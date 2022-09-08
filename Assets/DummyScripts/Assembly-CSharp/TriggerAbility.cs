/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class TriggerAbility : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16464
{
	// Fields
	private string _abilityName; // 0x68
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, DynamicFloat> _abilitySpecials; // 0x70
	private bool _forceUseSelfCurrentAttackTarget; // 0x78

	// Properties
	public string abilityName { /* [XID] */ /* 0x0000000189670610-0x0000000189670630 */ get => default; /* [XID] */ /* 0x0000000189677E30-0x0000000189677E50 */ private set {} } // 0x0000000184D25390-0x0000000184D25430 0x0000000184D26400-0x0000000184D264B0
	public Dictionary<string, DynamicFloat> abilitySpecials { /* [XID] */ /* 0x000000018967F3C0-0x000000018967F3E0 */ get => default; /* [XID] */ /* 0x0000000189686BF0-0x0000000189686C10 */ private set {} } // 0x0000000184D23E00-0x0000000184D23EA0 0x0000000184D25430-0x0000000184D254E0
	public bool forceUseSelfCurrentAttackTarget { /* [XID] */ /* 0x000000018968EAF0-0x000000018968EB10 */ get => default; /* [XID] */ /* 0x0000000189696570-0x0000000189696590 */ private set {} } // 0x0000000184D23F00-0x0000000184D23FA0 0x0000000184D23640-0x0000000184D236F0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189735E60-0x0000000189735E80 */ get => default; } // 0x0000000184D259D0-0x0000000184D25A70 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018973D9B0-0x000000018973D9D0 */ get => default; } // 0x0000000184D24D30-0x0000000184D24DD0 

	// Constructors
	public TriggerAbility() {} // 0x0000000184D26720-0x0000000184D26780

	// Methods
	// [XID] // 0x000000018969DAB0-0x000000018969DAD0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184D264B0-0x0000000184D265E0
	// [XID] // 0x00000001896A4B60-0x00000001896A4B80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184D25AD0-0x0000000184D25BD0
	// [XID] // 0x00000001896AC350-0x00000001896AC370
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3C40 */) => default; // 0x0000000184D254E0-0x0000000184D255C0
	// [XID] // 0x00000001896B3650-0x00000001896B3670
	public override int GetHashNum() => default; // 0x0000000184D23CC0-0x0000000184D23D90
	// [XID] // 0x00000001896BAD90-0x00000001896BADB0
	public override void InitEmpty() {} // 0x0000000184D24DD0-0x0000000184D24EC0
	[BlackList] // 0x00000001896C1EE0-0x00000001896C1F20
	// [XID] // 0x00000001896C1EE0-0x00000001896C1F20
	public override bool FromJson(JSONNode node) => default; // 0x0000000184D24600-0x0000000184D24980
	// [XID] // 0x00000001896CC670-0x00000001896CC690
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184D23270-0x0000000184D23640
	[BlackList] // 0x00000001896D38E0-0x00000001896D3920
	// [XID] // 0x00000001896D38E0-0x00000001896D3920
	public static new TriggerAbility ParseFromJson(JSONNode node) => default; // 0x0000000184D25780-0x0000000184D259D0
	// [XID] // 0x00000001896DE2A0-0x00000001896DE2C0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C41 */, bool useObjectPool = false /* Metadata: 0x00AF3C45 */) => default; // 0x0000000184D25090-0x0000000184D25390
	// [XID] // 0x00000001896E57B0-0x00000001896E57D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C46 */, bool useObjectPool = false /* Metadata: 0x00AF3C4A */) => default; // 0x0000000184D24020-0x0000000184D243A0
	// [XID] // 0x00000001896ECE40-0x00000001896ECE60
	public static new TriggerAbility ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C4B */, bool useObjectPool = false /* Metadata: 0x00AF3C4F */) => default; // 0x0000000184D24A30-0x0000000184D24C50
	[BlackList] // 0x00000001896F4660-0x00000001896F46A0
	// [XID] // 0x00000001896F4660-0x00000001896F46A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184D236F0-0x0000000184D239C0
	// [XID] // 0x00000001896FEFB0-0x00000001896FEFD0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184D25F10-0x0000000184D26250
	[BlackList] // 0x0000000189706240-0x0000000189706280
	// [XID] // 0x0000000189706240-0x0000000189706280
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184D24FA0-0x0000000184D25090
	// [XID] // 0x0000000189710D50-0x0000000189710D70
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184D265E0-0x0000000184D26680
	// [XID] // 0x00000001897180B0-0x00000001897180D0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184D243A0-0x0000000184D24500
	// [XID] // 0x000000018971FA90-0x000000018971FAB0
	public override bool GetDebugOutput(ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref string output) => default; // 0x0000000184D26250-0x0000000184D26400
	// [XID] // 0x0000000189727120-0x0000000189727140
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000184D25D90-0x0000000184D25F10
	// [XID] // 0x000000018972E6F0-0x000000018972E710
	public override void CallRemote(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000184D25620-0x0000000184D25780
	[BlackList] // 0x0000000189744E30-0x0000000189744E70
	// [XID] // 0x0000000189744E30-0x0000000189744E70
	public override void AutoAllocTypeFields() {} // 0x0000000184D239C0-0x0000000184D23A60
	[BlackList] // 0x000000018974F7D0-0x000000018974F810
	// [XID] // 0x000000018974F7D0-0x000000018974F810
	public override void AutoRecycleTypeFields() {} // 0x0000000184D23A60-0x0000000184D23B30
	[BlackList] // 0x0000000189759A20-0x0000000189759A60
	// [XID] // 0x0000000189759A20-0x0000000189759A60
	public override void ReturnToObjectPool() {} // 0x0000000184D26680-0x0000000184D26720
}

