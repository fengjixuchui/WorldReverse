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

public sealed class AbilityAttachToMonsterAirStateMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14475
{
	// Fields
	private AttachToMonsterAirStateMixin config; // 0x70
	private VCAnimatorMove vcMove; // 0x78

	// Constructors
	public AbilityAttachToMonsterAirStateMixin() {} // 0x000000018120FB80-0x000000018120FBE0

	// Methods
	// [XID] // 0x0000000189858EF0-0x0000000189858F10
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018120ED80-0x000000018120EEC0
	// [XID] // 0x00000001898600F0-0x0000000189860110
	public override void Clear() {} // 0x000000018120F0D0-0x000000018120F180
	// [XID] // 0x00000001898677B0-0x00000001898677D0
	public override void LazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018120EBC0-0x000000018120ECC0
	// [XID] // 0x000000018986EEA0-0x000000018986EEC0
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018120EA50-0x000000018120EB60
	// [XID] // 0x00000001898763D0-0x00000001898763F0
	private void ClearRedundantModifiers() {} // 0x000000018120F180-0x000000018120F2A0
	// [XID] // 0x000000018987DFB0-0x000000018987DFD0
	private void CheckNeedAddModifiers() {} // 0x000000018120EEC0-0x000000018120EFE0
	// [XID] // 0x0000000189885000-0x0000000189885020
	private void TryRemoveModifier(RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB773 */) {} // 0x000000018120F670-0x000000018120F780
	// [XID] // 0x000000018988C5E0-0x000000018988C600
	private void TryApplyModifier() {} // 0x000000018120F390-0x000000018120F520
	// [XID] // 0x0000000189893B30-0x0000000189893B50
	public override void OnAdded(bool syncToServer) {} // 0x000000018120E6B0-0x000000018120E800
	// [XID] // 0x000000018989B230-0x000000018989B250
	public override void Tick(float inDeltaTime) {} // 0x000000018120F8A0-0x000000018120F9E0
	// [XID] // 0x00000001898A2650-0x00000001898A2670
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x000000018120ECC0-0x000000018120ED80
	// [XID] // 0x00000001898A9C00-0x00000001898A9C20
	public override string ToString() => default; // 0x000000018120F9E0-0x000000018120FB80
	[BlackList] // 0x00000001898B16B0-0x00000001898B16F0
	// [XID] // 0x00000001898B16B0-0x00000001898B16F0
	public override void AutoAllocTypeFields() {} // 0x000000018120E890-0x000000018120E930
	[BlackList] // 0x00000001898BC090-0x00000001898BC0D0
	// [XID] // 0x00000001898BC090-0x00000001898BC0D0
	public override void AutoRecycleTypeFields() {} // 0x000000018120E930-0x000000018120E9E0
	[BlackList] // 0x00000001898C6400-0x00000001898C6440
	// [XID] // 0x00000001898C6400-0x00000001898C6440
	public override void ReturnToObjectPool() {} // 0x000000018120F800-0x000000018120F8A0
}

