/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityAttachToStateIDMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14479
{
	// Fields
	private AttachToStateIDMixin config; // 0x70
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<ActorAbilityPlugin.AbilityAttackTarget> cacheTargets; // 0x78
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<int> configStateIDs; // 0x80
	private VCStateLayerController stateLayerCom; // 0x88

	// Constructors
	public AbilityAttachToStateIDMixin() {} // 0x0000000184056590-0x00000001840565F0

	// Methods
	// [XID] // 0x0000000189A5ACA0-0x0000000189A5ACC0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000184054FD0-0x00000001840551D0
	// [XID] // 0x0000000189A624A0-0x0000000189A624C0
	public override void Clear() {} // 0x00000001840555C0-0x00000001840558D0
	// [XID] // 0x0000000189A6A320-0x0000000189A6A340
	public override void LazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000184054E10-0x0000000184054F10
	// [XID] // 0x0000000189A71710-0x0000000189A71730
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000184054A50-0x0000000184054B60
	// [XID] // 0x0000000189A791F0-0x0000000189A79210
	private void InitCacheTargets() {} // 0x0000000184055F70-0x0000000184056180
	// [XID] // 0x0000000189A80880-0x0000000189A808A0
	private void ClearRedundantModifiers() {} // 0x00000001840558D0-0x0000000184055B60
	// [XID] // 0x0000000189A88360-0x0000000189A88380
	private void CheckNeedAddModifiers() {} // 0x0000000184055470-0x0000000184055550
	// [XID] // 0x0000000189A8FCF0-0x0000000189A8FD10
	protected override void AddEventListener() {} // 0x0000000184054940-0x0000000184054A50
	// [XID] // 0x0000000189A972F0-0x0000000189A97310
	protected override void RemoveEventListener() {} // 0x0000000184055BC0-0x0000000184055CD0
	// [XID] // 0x0000000189A9E690-0x0000000189A9E6B0
	public override void OnAdded(bool syncToServer) {} // 0x0000000184054340-0x0000000184054450
	// [XID] // 0x0000000189AA60A0-0x0000000189AA60C0
	private void OnStateIDChangedCallback(EvtStateIDChanged evt) {} // 0x00000001840544E0-0x0000000184054700
	// [XID] // 0x0000000189AAD680-0x0000000189AAD6A0
	private void AttachModifiers() {} // 0x0000000184055D30-0x0000000184055E80
	// [XID] // 0x0000000189AB4F40-0x0000000189AB4F60
	private void TryApplyModifiers() {} // 0x00000001840551D0-0x0000000184055470
	// [XID] // 0x0000000189ABCBC0-0x0000000189ABCBE0
	private void DettachModifiers(RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB77F */) {} // 0x0000000184054BC0-0x0000000184054E10
	// [XID] // 0x0000000189AC4550-0x0000000189AC4570
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000184054F10-0x0000000184054FD0
	// [XID] // 0x0000000189ACBB90-0x0000000189ACBBB0
	public override string ToString() => default; // 0x00000001840563F0-0x0000000184056590
	[BlackList] // 0x0000000189AD3570-0x0000000189AD35B0
	// [XID] // 0x0000000189AD3570-0x0000000189AD35B0
	public override void AutoAllocTypeFields() {} // 0x0000000184054700-0x00000001840547F0
	[BlackList] // 0x0000000189ADE2E0-0x0000000189ADE320
	// [XID] // 0x0000000189ADE2E0-0x0000000189ADE320
	public override void AutoRecycleTypeFields() {} // 0x00000001840547F0-0x00000001840548D0
	[BlackList] // 0x0000000189AE88D0-0x0000000189AE8910
	// [XID] // 0x0000000189AE88D0-0x0000000189AE8910
	public override void ReturnToObjectPool() {} // 0x0000000184056350-0x00000001840563F0
}

