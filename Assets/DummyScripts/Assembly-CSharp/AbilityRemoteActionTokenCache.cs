/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityRemoteActionTokenCache : BaseActionTokenCache // TypeDefIndex: 21692
{
	// Fields
	private MPActorAbilityPlugin _actorAbilityPlugin; // 0x38
	private ActorAbility _instancedAbility; // 0x40
	private ActorModifier _instancedModifier; // 0x48
	private ActorAbilityPlugin.AbilityAttackTarget _attackTarget; // 0x50
	private UnionAbilityInvokeEntry _invokeEntry; // 0x70
	private ConfigAbilityAction _abilityActionConfig; // 0x78

	// Constructors
	public AbilityRemoteActionTokenCache() {} // 0x0000000181ECFCF0-0x0000000181ECFD70

	// Methods
	// [XID] // 0x0000000189918950-0x0000000189918970
	public static AbilityRemoteActionTokenCache Create(MPActorAbilityPlugin actorAbilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, UnionAbilityInvokeEntry invokeEntry) => default; // 0x0000000181ECF980-0x0000000181ECFB00
	// [XID] // 0x00000001899200F0-0x0000000189920110
	public static void Release(AbilityRemoteActionTokenCache cache) {} // 0x0000000181ECFB60-0x0000000181ECFC20
	// [XID] // 0x0000000189927990-0x00000001899279B0
	public void Init(MPActorAbilityPlugin actorAbilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000181ECF6F0-0x0000000181ECF880
	// [XID] // 0x000000018992F0E0-0x000000018992F100
	public override bool HandleTokenCache() => default; // 0x0000000181ECF4E0-0x0000000181ECF6F0
	// [XID] // 0x0000000189936510-0x0000000189936530
	public override void Clear() {} // 0x0000000181ECF880-0x0000000181ECF980
	// [XID] // 0x000000018993DF70-0x000000018993DF90
	public override void Destroy() {} // 0x0000000181ECF440-0x0000000181ECF4E0
}

