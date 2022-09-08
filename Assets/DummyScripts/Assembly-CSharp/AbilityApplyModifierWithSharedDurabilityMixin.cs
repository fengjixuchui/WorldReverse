/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class AbilityApplyModifierWithSharedDurabilityMixin : BaseAbilityMixin // TypeDefIndex: 14461
{
	// Fields
	private ApplyModifierWithSharedDurabilityMixin _config; // 0x70
	private bool _debugSwitch; // 0x78

	// Constructors
	public AbilityApplyModifierWithSharedDurabilityMixin() {} // 0x00000001817391B0-0x0000000181739220

	// Methods
	// [XID] // 0x00000001897D5BD0-0x00000001897D5BF0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000181737F20-0x0000000181738060
	// [XID] // 0x00000001897DD350-0x00000001897DD370
	public override void Clear() {} // 0x0000000181738150-0x0000000181738200
	// [XID] // 0x00000001897E4BE0-0x00000001897E4C00
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000181738200-0x00000001817382E0
	// [XID] // 0x00000001897EC830-0x00000001897EC850
	public override bool ListenEvent(BaseEvent evt) => default; // 0x00000001817388F0-0x00000001817389F0
	// [XID] // 0x00000001897F4100-0x00000001897F4120
	protected override void AddEventListener() {} // 0x0000000181737AF0-0x0000000181737C00
	// [XID] // 0x00000001897FBB60-0x00000001897FBB80
	protected override void RemoveEventListener() {} // 0x00000001817387E0-0x00000001817388F0
	// [XID] // 0x0000000189803030-0x0000000189803050
	public override void OnAdded(bool syncToServer) {} // 0x0000000181737510-0x00000001817375E0
	// [XID] // 0x000000018980A4C0-0x000000018980A4E0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000181737E60-0x0000000181737F20
	// [XID] // 0x0000000189811BE0-0x0000000189811C00
	private bool OnAvatarChanged(EvtAvatarChanged evt) => default; // 0x0000000181737C00-0x0000000181737DE0
	// [XID] // 0x00000001898198D0-0x00000001898198F0
	private void ApplyModifierToAvatar(BaseEntity avatar = null, float? durability = default) {} // 0x0000000181737670-0x0000000181737A80
	// [XID] // 0x0000000189821010-0x0000000189821030
	private void RemoveModifierFromAvatar(BaseEntity avatar = null, RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB75B */) {} // 0x0000000181738480-0x00000001817387E0
	// [XID] // 0x0000000189828580-0x00000001898285A0
	public override void Tick(float inDeltaTime) {} // 0x0000000181738B30-0x0000000181739010
	// [XID] // 0x000000018982F830-0x000000018982F850
	private ActorModifier GetSharedModifier(BaseEntity avatar) => default; // 0x0000000181738340-0x0000000181738480
	// [XID] // 0x0000000189837130-0x0000000189837150
	public override string ToString() => default; // 0x0000000181739010-0x00000001817391B0
}

