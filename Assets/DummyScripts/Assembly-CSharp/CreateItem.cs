/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CreateItem : CreateEntity, IAutoAllocRecycle // TypeDefIndex: 19255
{
	// Properties
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001896C7AD0-0x00000001896C7AF0 */ get => default; } // 0x0000000182044210-0x00000001820442B0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001896CF490-0x00000001896CF4B0 */ get => default; } // 0x0000000182044110-0x00000001820441B0 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x00000001896D6680-0x00000001896D66A0 */ get => default; } // 0x0000000182043DD0-0x0000000182043E70 

	// Constructors
	public CreateItem() {} // 0x0000000182044720-0x0000000182044780

	// Methods
	// [XID] // 0x00000001896B1570-0x00000001896B1590
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001820445E0-0x0000000182044680
	// [XID] // 0x00000001896B9010-0x00000001896B9030
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182043F40-0x00000001820440A0
	// [XID] // 0x00000001896C0380-0x00000001896C03A0
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000182044460-0x00000001820445E0
	[BlackList] // 0x00000001896DDCC0-0x00000001896DDD00
	// [XID] // 0x00000001896DDCC0-0x00000001896DDD00
	public override void AutoAllocTypeFields() {} // 0x0000000182043C20-0x0000000182043CC0
	[BlackList] // 0x00000001896E8100-0x00000001896E8140
	// [XID] // 0x00000001896E8100-0x00000001896E8140
	public override void AutoRecycleTypeFields() {} // 0x0000000182043CC0-0x0000000182043D60
	[BlackList] // 0x00000001896F2530-0x00000001896F2570
	// [XID] // 0x00000001896F2530-0x00000001896F2570
	public override void ReturnToObjectPool() {} // 0x0000000182044680-0x0000000182044720
}

