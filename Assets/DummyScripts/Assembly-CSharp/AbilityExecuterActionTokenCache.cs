/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityExecuterActionTokenCache : BaseActionTokenCache // TypeDefIndex: 20562
{
	// Fields
	private AbilityActionExecuter _abilityExecuter; // 0x38
	private IAbilityActionContainer _instancedContainer; // 0x40
	private ConfigAbilityAction _abilityActionConfig; // 0x48
	private ActorAbilityPlugin.AbilityAttackTarget _attackTarget; // 0x50

	// Constructors
	public AbilityExecuterActionTokenCache() {} // 0x00000001823DD040-0x00000001823DD0A0

	// Methods
	// [XID] // 0x000000018978D890-0x000000018978D8B0
	public static AbilityExecuterActionTokenCache Create(AbilityActionExecuter abilityActionExecuter, ConfigAbilityAction actionConfig, IAbilityActionContainer instancedContainer, ActorAbilityPlugin.AbilityAttackTarget target) => default; // 0x00000001823DCD00-0x00000001823DCE50
	// [XID] // 0x0000000189794D60-0x0000000189794D80
	public static void Release(AbilityExecuterActionTokenCache cache) {} // 0x00000001823DCEB0-0x00000001823DCF70
	// [XID] // 0x000000018979D2D0-0x000000018979D2F0
	public void Init(AbilityActionExecuter abilityActionExecuter, ConfigAbilityAction actionConfig, IAbilityActionContainer instancedContainer, ActorAbilityPlugin.AbilityAttackTarget target) {} // 0x00000001823DCB10-0x00000001823DCC50
	// [XID] // 0x00000001897A45B0-0x00000001897A45D0
	public override bool HandleTokenCache() => default; // 0x00000001823DC900-0x00000001823DCB10
	// [XID] // 0x00000001897ABAA0-0x00000001897ABAC0
	public override void Clear() {} // 0x00000001823DCC50-0x00000001823DCD00
	// [XID] // 0x00000001897B3A40-0x00000001897B3A60
	public override void Destroy() {} // 0x00000001823DC860-0x00000001823DC900
}

