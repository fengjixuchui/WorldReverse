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

public sealed class AbilityAnimatorRotationCompensateMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14459
{
	// Fields
	private AnimatorRotationCompensateMixin _config; // 0x70
	private VCAnimatorMove _vcAnimatorMove; // 0x78
	private LCBaseCombat _lcCombat; // 0x80

	// Constructors
	public AbilityAnimatorRotationCompensateMixin() {} // 0x0000000183FDB670-0x0000000183FDB6D0

	// Methods
	// [XID] // 0x000000018973C660-0x000000018973C680
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000183FDA850-0x0000000183FDAB50
	// [XID] // 0x0000000189743B60-0x0000000189743B80
	public override void Clear() {} // 0x0000000183FDABC0-0x0000000183FDAC70
	// [XID] // 0x000000018974B6B0-0x000000018974B6D0
	protected override void AddEventListener() {} // 0x0000000183FDA610-0x0000000183FDA720
	// [XID] // 0x0000000189752AF0-0x0000000189752B10
	protected override void RemoveEventListener() {} // 0x0000000183FDB0A0-0x0000000183FDB1B0
	// [XID] // 0x0000000189759E80-0x0000000189759EA0
	public override void OnAdded(bool syncToServer) {} // 0x0000000183FDA370-0x0000000183FDA430
	// [XID] // 0x0000000189761C00-0x0000000189761C20
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000183FDA780-0x0000000183FDA850
	// [XID] // 0x0000000189768F10-0x0000000189768F30
	private void CalcAngle() {} // 0x0000000183FDAC70-0x0000000183FDB040
	// [XID] // 0x00000001897706B0-0x00000001897706D0
	private void OnAnimatorStateChanged(EvtAnimatorStateChanged evt) {} // 0x0000000183FDB210-0x0000000183FDB430
	[BlackList] // 0x0000000189777E10-0x0000000189777E50
	// [XID] // 0x0000000189777E10-0x0000000189777E50
	public override void AutoAllocTypeFields() {} // 0x0000000183FDA4C0-0x0000000183FDA560
	[BlackList] // 0x00000001897829E0-0x0000000189782A20
	// [XID] // 0x00000001897829E0-0x0000000189782A20
	public override void AutoRecycleTypeFields() {} // 0x0000000183FDA560-0x0000000183FDA610
	[BlackList] // 0x000000018978CBC0-0x000000018978CC00
	// [XID] // 0x000000018978CBC0-0x000000018978CC00
	public override void ReturnToObjectPool() {} // 0x0000000183FDB5D0-0x0000000183FDB670
}

