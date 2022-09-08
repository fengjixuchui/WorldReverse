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

public sealed class AbilityAttachToAIAlertnessMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14469
{
	// Fields
	private AttachToAIAlertnessMixin config; // 0x70

	// Constructors
	public AbilityAttachToAIAlertnessMixin() {} // 0x00000001815152F0-0x0000000181515350

	// Methods
	// [XID] // 0x0000000189B6ED50-0x0000000189B6ED70
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000181514080-0x00000001815141C0
	// [XID] // 0x0000000189B76530-0x0000000189B76550
	public override void LazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000181513EC0-0x0000000181513FC0
	// [XID] // 0x0000000189B7DAE0-0x0000000189B7DB00
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000181513D50-0x0000000181513E60
	// [XID] // 0x0000000189B85760-0x0000000189B85780
	private void ClearRedundantModifiers() {} // 0x0000000181514480-0x0000000181514660
	// [XID] // 0x0000000189B8C550-0x0000000189B8C570
	private void CheckNeedAddModifiers() {} // 0x00000001815141C0-0x0000000181514360
	// [XID] // 0x0000000189B93F10-0x0000000189B93F30
	public override void Clear() {} // 0x00000001815143D0-0x0000000181514480
	// [XID] // 0x0000000189B9B4D0-0x0000000189B9B4F0
	protected override void AddEventListener() {} // 0x0000000181513BE0-0x0000000181513D50
	// [XID] // 0x0000000189BA2BF0-0x0000000189BA2C10
	protected override void RemoveEventListener() {} // 0x00000001815146C0-0x0000000181514830
	// [XID] // 0x0000000189BAA060-0x0000000189BAA080
	public override void OnAdded(bool syncToServer) {} // 0x00000001815137C0-0x0000000181513990
	// [XID] // 0x0000000189BB1880-0x0000000189BB18A0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000181513FC0-0x0000000181514080
	// [XID] // 0x0000000189BB88A0-0x0000000189BB88C0
	private void OnThreatLevelChange(ThreatLevel from, ThreatLevel to) {} // 0x0000000181514890-0x0000000181514A70
	// [XID] // 0x0000000189BC0240-0x0000000189BC0260
	private void TryRemoveModifier(RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB76B */) {} // 0x0000000181514E40-0x0000000181514F50
	// [XID] // 0x0000000189BC7C60-0x0000000189BC7C80
	private void TryApplyModifier() {} // 0x0000000181514B00-0x0000000181514C90
	// [XID] // 0x0000000189BCF7B0-0x0000000189BCF7D0
	public override string ToString() => default; // 0x0000000181515070-0x00000001815152F0
	[BlackList] // 0x0000000189BD6C20-0x0000000189BD6C60
	// [XID] // 0x0000000189BD6C20-0x0000000189BD6C60
	public override void AutoAllocTypeFields() {} // 0x0000000181513A20-0x0000000181513AC0
	[BlackList] // 0x00000001895E67F0-0x00000001895E6830
	// [XID] // 0x00000001895E67F0-0x00000001895E6830
	public override void AutoRecycleTypeFields() {} // 0x0000000181513AC0-0x0000000181513B70
	[BlackList] // 0x00000001895F1180-0x00000001895F11C0
	// [XID] // 0x00000001895F1180-0x00000001895F11C0
	public override void ReturnToObjectPool() {} // 0x0000000181514FD0-0x0000000181515070
}

