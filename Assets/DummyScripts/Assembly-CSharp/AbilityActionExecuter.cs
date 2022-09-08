/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AbilityActionExecuter : IAbilityActionExecuter // TypeDefIndex: 20564
{
	// Constructors
	public AbilityActionExecuter() {} // 0x0000000181D17670-0x0000000181D176D0

	// Methods
	// [XID] // 0x00000001897BB810-0x00000001897BB830
	public virtual void HandleAction(ConfigAbilityAction actionConfig, IAbilityActionContainer instance, ActorAbilityPlugin.AbilityAttackTarget target) {} // 0x0000000181D16E50-0x0000000181D16F60
	// [XID] // 0x00000001897C30B0-0x00000001897C30D0
	public void HandleActionExternal(ConfigAbilityAction actionConfig, IAbilityActionContainer instance, ActorAbilityPlugin.AbilityAttackTarget target) {} // 0x0000000181D17560-0x0000000181D17670
	// [XID] // 0x00000001897CA930-0x00000001897CA950
	protected void HandleActionInternal(ConfigAbilityAction actionConfig, IAbilityActionContainer instance, ActorAbilityPlugin.AbilityAttackTarget target) {} // 0x0000000181D16C80-0x0000000181D16E50
	// [XID] // 0x00000001897D1F30-0x00000001897D1F50
	public virtual BaseEntity GetEntity() => default; // 0x0000000181D16BE0-0x0000000181D16C80
	// [XID] // 0x00000001897D9D50-0x00000001897D9D70
	public void AttachEffectHandler(ConfigAbilityAction actionConfig, IAbilityActionContainer instance, BaseEntity target) {} // 0x0000000181D16F60-0x0000000181D17180
	// [XID] // 0x00000001897E10A0-0x00000001897E10C0
	protected void AttachEffectByBornPosRot(AttachEffect config, IAbilityActionContainer instance, BaseEntity target, Vector3 bornPos, Quaternion bornRot, BaseEvent evt) {} // 0x0000000181D172B0-0x0000000181D17560
	// [XID] // 0x00000001897E87F0-0x00000001897E8810
	private void PostAttachHandler(int effectIndex, AttachEffect config) {} // 0x0000000181D17180-0x0000000181D172B0
}

