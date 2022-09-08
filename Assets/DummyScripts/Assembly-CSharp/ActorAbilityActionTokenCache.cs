/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActorAbilityActionTokenCache : BaseActionTokenCache // TypeDefIndex: 14610
{
	// Fields
	private ActorAbilityPlugin _actorAbilityPlugin; // 0x38
	private ActorAbility _instancedAbility; // 0x40
	private ActorModifier _instancedModifier; // 0x48
	private ActorAbilityPlugin.AbilityAttackTarget _attackTarget; // 0x50
	private BaseEvent _evt; // 0x70
	private ConfigAbilityPredicate[] _predicatesForeach; // 0x78
	private bool _recoverFromServer; // 0x80
	private ConfigAbilityAction _abilityActionConfig; // 0x88
	private bool _callAuthority; // 0x90

	// Constructors
	public ActorAbilityActionTokenCache() {} // 0x00000001837FA3A0-0x00000001837FA420

	// Methods
	// [XID] // 0x00000001899ACF30-0x00000001899ACF50
	public static ActorAbilityActionTokenCache Create(ActorAbilityPlugin actorAbilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ConfigAbilityPredicate[] predicatesForeach, bool recoverFromServer, ActionTokenSourceType actionSrcType, bool callAuthority) => default; // 0x00000001837F9FA0-0x00000001837FA1B0
	// [XID] // 0x0000000189AC8BC0-0x0000000189AC8BE0
	public static void Release(ActorAbilityActionTokenCache cache) {} // 0x00000001837FA210-0x00000001837FA2D0
	// [XID] // 0x00000001899B4700-0x00000001899B4720
	public void Init(ActorAbilityPlugin actorAbilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ConfigAbilityPredicate[] predicatesForeach, bool recoverFromServer, ActionTokenSourceType actionSrcType, bool callAuthority) {} // 0x00000001837F9CF0-0x00000001837F9EE0
	// [XID] // 0x0000000189AD7FD0-0x0000000189AD7FF0
	public override bool HandleTokenCache() => default; // 0x00000001837F9AC0-0x00000001837F9CF0
	// [XID] // 0x0000000189ADFCA0-0x0000000189ADFCC0
	public override void Clear() {} // 0x00000001837F9EE0-0x00000001837F9FA0
	// [XID] // 0x0000000189AE7380-0x0000000189AE73A0
	public override void Destroy() {} // 0x00000001837F9A20-0x00000001837F9AC0
}

