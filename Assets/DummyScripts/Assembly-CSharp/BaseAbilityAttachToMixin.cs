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

public class BaseAbilityAttachToMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14604
{
	// Properties
	protected virtual string modifierName { /* [XID] */ /* 0x000000018980D300-0x000000018980D340 */ get; /* [XID] */ /* 0x0000000189817C60-0x0000000189817CA0 */ set; } // 0x0000000185157660-0x00000001851576C0 0x00000001851570A0-0x0000000185157100

	// Constructors
	public BaseAbilityAttachToMixin() {} // 0x0000000185157760-0x00000001851577C0

	// Methods
	// [XID] // 0x00000001897C22D0-0x00000001897C22F0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000185156CD0-0x0000000185156DC0
	// [XID] // 0x00000001897C9B00-0x00000001897C9B20
	public override void OnAdded(bool syncToServer) {} // 0x0000000185156620-0x00000001851566E0
	// [XID] // 0x00000001897D1170-0x00000001897D1190
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000185156C10-0x0000000185156CD0
	// [XID] // 0x00000001897D9190-0x00000001897D91B0
	public override void LazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000185156B10-0x0000000185156C10
	// [XID] // 0x00000001897E0460-0x00000001897E0480
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001851569A0-0x0000000185156AB0
	// [XID] // 0x00000001897E7B30-0x00000001897E7B50
	private void ClearRedundantModifiers() {} // 0x0000000185156F00-0x0000000185157040
	// [XID] // 0x00000001897EF680-0x00000001897EF6A0
	private void CheckNeedAddModifiers(bool syncToServer) {} // 0x0000000185156DC0-0x0000000185156E90
	// [XID] // 0x00000001897F6D60-0x00000001897F6D80
	private void TryApplyModifier() {} // 0x0000000185157190-0x0000000185157330
	// [XID] // 0x00000001897FE3A0-0x00000001897FE3C0
	private void TryRemoveModifier(RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB961 */) {} // 0x0000000185157420-0x0000000185157540
	// [XID] // 0x0000000189805AD0-0x0000000189805AF0
	protected void OnConditionChanged() {} // 0x00000001851566E0-0x00000001851567B0
	// [XID] // 0x0000000189822550-0x0000000189822570
	protected virtual bool CheckCondition() => default; // 0x00000001851575C0-0x0000000185157660
	[BlackList] // 0x0000000189829B30-0x0000000189829B70
	// [XID] // 0x0000000189829B30-0x0000000189829B70
	public override void AutoAllocTypeFields() {} // 0x0000000185156840-0x00000001851568E0
	[BlackList] // 0x0000000189834220-0x0000000189834260
	// [XID] // 0x0000000189834220-0x0000000189834260
	public override void AutoRecycleTypeFields() {} // 0x00000001851568E0-0x00000001851569A0
	[BlackList] // 0x000000018983E650-0x000000018983E690
	// [XID] // 0x000000018983E650-0x000000018983E690
	public override void ReturnToObjectPool() {} // 0x00000001851576C0-0x0000000185157760
}

