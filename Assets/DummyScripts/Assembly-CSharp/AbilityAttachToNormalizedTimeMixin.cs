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

public sealed class AbilityAttachToNormalizedTimeMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14476
{
	// Fields
	private AttachToNormalizedTimeMixin config; // 0x70
	private bool _isInState; // 0x78

	// Properties
	public bool isInState { /* [XID] */ /* 0x00000001898D0EC0-0x00000001898D0EE0 */ get => default; /* [XID] */ /* 0x00000001898D84A0-0x00000001898D84C0 */ private set {} } // 0x000000018175F150-0x000000018175F1F0 0x000000018175EAB0-0x000000018175ED00

	// Constructors
	public AbilityAttachToNormalizedTimeMixin() {} // 0x0000000181760160-0x00000001817601D0

	// Methods
	// [XID] // 0x00000001898E0300-0x00000001898E0320
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018175EF20-0x000000018175F060
	// [XID] // 0x00000001898E7E40-0x00000001898E7E60
	public override void LazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018175ED60-0x000000018175EE60
	// [XID] // 0x00000001898EF500-0x00000001898EF520
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018175E9A0-0x000000018175EAB0
	// [XID] // 0x00000001898F6DF0-0x00000001898F6E10
	private void ClearRedundantModifiers() {} // 0x000000018175F490-0x000000018175F670
	// [XID] // 0x00000001898FE520-0x00000001898FE540
	private void CheckNeedAddModifiers() {} // 0x000000018175F1F0-0x000000018175F370
	// [XID] // 0x0000000189905C60-0x0000000189905C80
	private bool IsInConfigTimeRange(float normalizedTime) => default; // 0x000000018175FCC0-0x000000018175FDC0
	// [XID] // 0x000000018990D660-0x000000018990D680
	public override void Clear() {} // 0x000000018175F3E0-0x000000018175F490
	// [XID] // 0x0000000189914D70-0x0000000189914D90
	protected override void AddEventListener() {} // 0x000000018175E890-0x000000018175E9A0
	// [XID] // 0x000000018991C9B0-0x000000018991C9D0
	protected override void RemoveEventListener() {} // 0x000000018175F6D0-0x000000018175F7F0
	// [XID] // 0x0000000189924210-0x0000000189924230
	public override void OnAdded(bool syncToServer) {} // 0x000000018175E5F0-0x000000018175E6B0
	// [XID] // 0x000000018992B6C0-0x000000018992B6E0
	private void OnAnimatorStateChanged(EvtAnimatorStateChanged evt) {} // 0x000000018175F850-0x000000018175FA20
	// [XID] // 0x0000000189932EA0-0x0000000189932EC0
	private void OnAnimatorNormalizedAction(int layerIndex, float normalizedTime) {} // 0x000000018175F060-0x000000018175F150
	// [XID] // 0x000000018993A760-0x000000018993A780
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x000000018175EE60-0x000000018175EF20
	// [XID] // 0x00000001899417F0-0x0000000189941810
	private void TryApplyModifier() {} // 0x000000018175FAB0-0x000000018175FC60
	// [XID] // 0x00000001899492D0-0x00000001899492F0
	private void TryRemoveModifier(RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB777 */) {} // 0x000000018175FF10-0x0000000181760040
	[BlackList] // 0x0000000189950B70-0x0000000189950BB0
	// [XID] // 0x0000000189950B70-0x0000000189950BB0
	public override void AutoAllocTypeFields() {} // 0x000000018175E740-0x000000018175E7E0
	[BlackList] // 0x000000018995B030-0x000000018995B070
	// [XID] // 0x000000018995B030-0x000000018995B070
	public override void AutoRecycleTypeFields() {} // 0x000000018175E7E0-0x000000018175E890
	[BlackList] // 0x0000000189965AA0-0x0000000189965AE0
	// [XID] // 0x0000000189965AA0-0x0000000189965AE0
	public override void ReturnToObjectPool() {} // 0x00000001817600C0-0x0000000181760160
}

