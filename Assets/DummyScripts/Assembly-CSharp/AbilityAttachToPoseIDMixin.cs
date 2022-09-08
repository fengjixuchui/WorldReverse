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

public sealed class AbilityAttachToPoseIDMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14478
{
	// Fields
	private AttachToPoseIDMixin config; // 0x70

	// Constructors
	public AbilityAttachToPoseIDMixin() {} // 0x0000000184757360-0x00000001847573C0

	// Methods
	// [XID] // 0x00000001899C4BF0-0x00000001899C4C10
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001847561E0-0x0000000184756320
	// [XID] // 0x00000001899CC270-0x00000001899CC290
	public override void LazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000184756020-0x0000000184756120
	// [XID] // 0x00000001899D3940-0x00000001899D3960
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000184755EB0-0x0000000184755FC0
	// [XID] // 0x00000001899DAEE0-0x00000001899DAF00
	private void ClearRedundantModifiers() {} // 0x00000001847565C0-0x0000000184756790
	// [XID] // 0x00000001899E26C0-0x00000001899E26E0
	private void CheckNeedAddModifiers() {} // 0x0000000184756320-0x00000001847564A0
	// [XID] // 0x00000001899E9C10-0x00000001899E9C30
	public override void Clear() {} // 0x0000000184756510-0x00000001847565C0
	// [XID] // 0x00000001899F1430-0x00000001899F1450
	protected override void AddEventListener() {} // 0x0000000184755D20-0x0000000184755EB0
	// [XID] // 0x00000001899F8C90-0x00000001899F8CB0
	protected override void RemoveEventListener() {} // 0x00000001847567F0-0x0000000184756980
	// [XID] // 0x0000000189A002F0-0x0000000189A00310
	public override void OnAdded(bool syncToServer) {} // 0x0000000184755900-0x0000000184755AD0
	// [XID] // 0x0000000189A079C0-0x0000000189A079E0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000184756120-0x00000001847561E0
	// [XID] // 0x0000000189A0EFE0-0x0000000189A0F000
	private void OnPoseIDChanged(int fromPoseID, int toPoseID) {} // 0x0000000184756980-0x0000000184756B60
	// [XID] // 0x0000000189A166C0-0x0000000189A166E0
	private void TryRemoveModifier(RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB77B */) {} // 0x0000000184756F90-0x00000001847570A0
	// [XID] // 0x0000000189A1DBA0-0x0000000189A1DBC0
	private void TryApplyModifier() {} // 0x0000000184756C50-0x0000000184756DE0
	// [XID] // 0x0000000189A251B0-0x0000000189A251D0
	public override string ToString() => default; // 0x00000001847571C0-0x0000000184757360
	[BlackList] // 0x0000000189A2C780-0x0000000189A2C7C0
	// [XID] // 0x0000000189A2C780-0x0000000189A2C7C0
	public override void AutoAllocTypeFields() {} // 0x0000000184755B60-0x0000000184755C00
	[BlackList] // 0x0000000189A370E0-0x0000000189A37120
	// [XID] // 0x0000000189A370E0-0x0000000189A37120
	public override void AutoRecycleTypeFields() {} // 0x0000000184755C00-0x0000000184755CB0
	[BlackList] // 0x0000000189A41860-0x0000000189A418A0
	// [XID] // 0x0000000189A41860-0x0000000189A418A0
	public override void ReturnToObjectPool() {} // 0x0000000184757120-0x00000001847571C0
}

