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

public sealed class AbilityAttachModifierToPredicateMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14465
{
	// Fields
	private AttachModifierToPredicateMixin config; // 0x70
	private LCAbilityState _abilityState; // 0x78

	// Constructors
	public AbilityAttachModifierToPredicateMixin() {} // 0x00000001826B2B30-0x00000001826B2BA0

	// Methods
	// [XID] // 0x000000018996B710-0x000000018996B730
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001826B16E0-0x00000001826B1820
	// [XID] // 0x00000001899732B0-0x00000001899732D0
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001826B1470-0x00000001826B1560
	// [XID] // 0x000000018997ABA0-0x000000018997ABC0
	public override void Clear() {} // 0x00000001826B1AA0-0x00000001826B1B50
	// [XID] // 0x00000001899824F0-0x0000000189982510
	private bool CanDoAction() => default; // 0x00000001826B1820-0x00000001826B19B0
	// [XID] // 0x0000000189989C50-0x0000000189989C70
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001826B1B50-0x00000001826B1C30
	// [XID] // 0x0000000189991570-0x0000000189991590
	public override bool OnEvent(BaseEvent evt) => default; // 0x00000001826B26A0-0x00000001826B27B0
	// [XID] // 0x0000000189999080-0x00000001899990A0
	public override void Tick(float inDeltaTime) {} // 0x00000001826B28D0-0x00000001826B29B0
	// [XID] // 0x00000001899A08B0-0x00000001899A08D0
	private void CheckDoAction() {} // 0x00000001826B1190-0x00000001826B1470
	// [XID] // 0x00000001899A8380-0x00000001899A83A0
	protected override void AddEventListener() {} // 0x00000001826B0F90-0x00000001826B1190
	// [XID] // 0x00000001899AFB90-0x00000001899AFBB0
	protected override void RemoveEventListener() {} // 0x00000001826B1F70-0x00000001826B2130
	// [XID] // 0x00000001899B7020-0x00000001899B7040
	public override void OnAdded(bool syncToServer) {} // 0x00000001826B0C80-0x00000001826B0D40
	// [XID] // 0x00000001899BEAA0-0x00000001899BEAC0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001826B15C0-0x00000001826B16E0
	// [XID] // 0x00000001899C6520-0x00000001899C6540
	private void OnAbilityStateAdded(AbilityState state, bool muteDisplayEffect) {} // 0x00000001826B1C30-0x00000001826B1F10
	// [XID] // 0x00000001899CDA40-0x00000001899CDA60
	private void OnAbilityStateRemoved(AbilityState state) {} // 0x00000001826B2190-0x00000001826B2470
	// [XID] // 0x00000001899D5000-0x00000001899D5020
	public override string ToString() => default; // 0x00000001826B29B0-0x00000001826B2B30
	[BlackList] // 0x00000001899DC580-0x00000001899DC5C0
	// [XID] // 0x00000001899DC580-0x00000001899DC5C0
	public override void AutoAllocTypeFields() {} // 0x00000001826B0DD0-0x00000001826B0E70
	[BlackList] // 0x00000001899E6FF0-0x00000001899E7030
	// [XID] // 0x00000001899E6FF0-0x00000001899E7030
	public override void AutoRecycleTypeFields() {} // 0x00000001826B0E70-0x00000001826B0F20
	[BlackList] // 0x00000001899F1450-0x00000001899F1490
	// [XID] // 0x00000001899F1450-0x00000001899F1490
	public override void ReturnToObjectPool() {} // 0x00000001826B2830-0x00000001826B28D0
}

