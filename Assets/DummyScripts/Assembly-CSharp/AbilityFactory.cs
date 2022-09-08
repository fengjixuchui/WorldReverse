/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class AbilityFactory // TypeDefIndex: 20578
{
	// Methods
	// [XID] // 0x00000001897870D0-0x00000001897870F0
	public static AbilityContextCommand MakeBeingHitCommand(uint attackerId, uint targetId, AttackResult attackResult, BaseEntity targetEntity) => default; // 0x00000001831EEBB0-0x00000001831EECD0
	// [XID] // 0x0000000189636EC0-0x0000000189636EE0
	public static AbilityContextCommand MakeEventCommand(AbilityTaskEvent evt) => default; // 0x00000001831EEFB0-0x00000001831EF080
	// [XID] // 0x00000001898F0F80-0x00000001898F0FA0
	public static void ReleaseContextCommand(AbilityContextCommand cmd) {} // 0x00000001831EEEF0-0x00000001831EEFB0
	// [XID] // 0x000000018960DE90-0x000000018960DEB0
	public static AbilityTask MakeTask(ConfigAbilityTask config, AbilityInstance instance, AbilityComponentProxy proxy) => default; // 0x00000001831EE9D0-0x00000001831EEAF0
	// [XID] // 0x000000018964D4C0-0x000000018964D4E0
	public static void ReleaseTask(AbilityTask task, AbilityInstance instance, AbilityComponentProxy proxy) {} // 0x00000001831EE820-0x00000001831EE910
	// [XID] // 0x0000000189654D60-0x0000000189654D80
	public static Ability MakeAbility(ConfigAbilitySystem config) => default; // 0x00000001831EE740-0x00000001831EE820
	// [XID] // 0x000000018965C2F0-0x000000018965C310
	public static void ReleaseAbility(Ability ability) {} // 0x00000001831EEAF0-0x00000001831EEBB0
	// [XID] // 0x00000001896064D0-0x00000001896064F0
	public static AbilityContext MakeContext(Ability ability, AbilityComponentProxy proxy, BaseEntity owner, BaseEntity instigator) => default; // 0x00000001831EEDC0-0x00000001831EEEF0
	// [XID] // 0x000000018966B300-0x000000018966B320
	public static void ReleaseContext(AbilityContext context) {} // 0x00000001831EF080-0x00000001831EF140
	// [XID] // 0x0000000189673000-0x0000000189673020
	public static AbilityInstance MakeInstance(AbilityComponentProxy proxy, AbilityContext context) => default; // 0x00000001831EECD0-0x00000001831EEDC0
	// [XID] // 0x000000018967A5F0-0x000000018967A610
	public static void ReleaseInstance(AbilityInstance instance) {} // 0x00000001831EE910-0x00000001831EE9D0
}

