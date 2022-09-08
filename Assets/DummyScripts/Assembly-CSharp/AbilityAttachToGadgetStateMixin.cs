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

public sealed class AbilityAttachToGadgetStateMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14473
{
	// Fields
	private AttachToGadgetStateMixin config; // 0x70
	private GadgetState curGadgetState; // 0x78

	// Constructors
	public AbilityAttachToGadgetStateMixin() {} // 0x0000000182976210-0x0000000182976270

	// Methods
	// [XID] // 0x0000000189748710-0x0000000189748730
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182975290-0x00000001829753D0
	// [XID] // 0x000000018974FCB0-0x000000018974FCD0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000182975630-0x0000000182975710
	// [XID] // 0x0000000189757380-0x00000001897573A0
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000182975E40-0x0000000182975F40
	// [XID] // 0x000000018975EAD0-0x000000018975EAF0
	public override void LazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182974FA0-0x00000001829750A0
	// [XID] // 0x0000000189765FB0-0x0000000189765FD0
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182974E30-0x0000000182974F40
	// [XID] // 0x000000018976D800-0x000000018976D820
	private void ClearRedundantModifiers() {} // 0x0000000182975710-0x00000001829758C0
	// [XID] // 0x0000000189774BE0-0x0000000189774C00
	private void CheckNeedAddModifiers() {} // 0x00000001829753D0-0x0000000182975510
	// [XID] // 0x000000018977C4C0-0x000000018977C4E0
	public override void Clear() {} // 0x0000000182975580-0x0000000182975630
	// [XID] // 0x0000000189783FC0-0x0000000189783FE0
	public override void OnAdded(bool syncToServer) {} // 0x0000000182974AA0-0x0000000182974BE0
	// [XID] // 0x000000018978B730-0x000000018978B750
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000182975170-0x0000000182975290
	// [XID] // 0x0000000189792B30-0x0000000189792B50
	private void OnStateChanged(EvtGadgetState evt) {} // 0x00000001829750A0-0x0000000182975170
	// [XID] // 0x000000018979A200-0x000000018979A220
	private void UpdateModifier(int gadgetState) {} // 0x0000000182975920-0x0000000182975A50
	// [XID] // 0x00000001897A21A0-0x00000001897A21C0
	private void TryApplyModifier() {} // 0x0000000182975AE0-0x0000000182975C70
	// [XID] // 0x00000001897A9860-0x00000001897A9880
	public override string ToString() => default; // 0x0000000182976060-0x0000000182976210
	[BlackList] // 0x00000001897B10C0-0x00000001897B1100
	// [XID] // 0x00000001897B10C0-0x00000001897B1100
	public override void AutoAllocTypeFields() {} // 0x0000000182974C70-0x0000000182974D10
	[BlackList] // 0x00000001897BC610-0x00000001897BC650
	// [XID] // 0x00000001897BC610-0x00000001897BC650
	public override void AutoRecycleTypeFields() {} // 0x0000000182974D10-0x0000000182974DC0
	[BlackList] // 0x00000001897C6F10-0x00000001897C6F50
	// [XID] // 0x00000001897C6F10-0x00000001897C6F50
	public override void ReturnToObjectPool() {} // 0x0000000182975FC0-0x0000000182976060
}

