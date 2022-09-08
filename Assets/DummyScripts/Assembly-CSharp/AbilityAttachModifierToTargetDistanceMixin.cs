/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityAttachModifierToTargetDistanceMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14467
{
	// Fields
	private AttachModifierToTargetDistanceMixin config; // 0x70
	private float[] _valueSteps; // 0x78
	private int _curModifierStepIx; // 0x80
	private float _blendDisMin; // 0x84
	private float _blendDisMax; // 0x88
	private float INTERVAL_TIME; // 0x8C
	private HashSet<SimpleSafeUInt32> _targetIDs; // 0x90
	private int _blendPramHash; // 0x98
	private BaseEntity _entity; // 0xA0
	private MonoEffectProxy _targetEff; // 0xA8
	private float _cur_interval; // 0xB0
	private List<MonoEffectProxy> _effectProxyListCache; // 0xB8

	// Constructors
	public AbilityAttachModifierToTargetDistanceMixin() {} // 0x000000018399B5B0-0x000000018399B640

	// Methods
	// [XID] // 0x0000000189A9A5C0-0x0000000189A9A5E0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000183999C30-0x000000018399A280
	// [XID] // 0x0000000189AA1620-0x0000000189AA1640
	public override void Tick(float inDeltaTime) {} // 0x000000018399B230-0x000000018399B430
	// [XID] // 0x0000000189AA8CD0-0x0000000189AA8CF0
	public override void Clear() {} // 0x000000018399A370-0x000000018399A440
	// [XID] // 0x0000000189AB0950-0x0000000189AB0970
	public override void OnBeforePoolRecycled() {} // 0x000000018399B010-0x000000018399B0B0
	// [XID] // 0x0000000189AB7EE0-0x0000000189AB7F00
	public override void OnAdded(bool syncToServer) {} // 0x0000000183999560-0x0000000183999640
	// [XID] // 0x0000000189ABF9A0-0x0000000189ABF9C0
	private void FindAttachEffect() {} // 0x000000018399AD30-0x000000018399B010
	// [XID] // 0x0000000189AC7570-0x0000000189AC7590
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000183999B60-0x0000000183999C30
	// [XID] // 0x0000000189ACEB30-0x0000000189ACEB50
	private float CalculateDistance() => default; // 0x000000018399A4A0-0x000000018399A910
	// [XID] // 0x0000000189AD6AB0-0x0000000189AD6AD0
	private void TickModifierByValue(float curValue) {} // 0x0000000183999930-0x0000000183999B60
	// [XID] // 0x0000000189ADE320-0x0000000189ADE340
	private int CalculateCurrentStep(float curValue) => default; // 0x000000018399A970-0x000000018399AB00
	// [XID] // 0x0000000189AE5DA0-0x0000000189AE5DC0
	private void RemoveAllStepModifier(RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB767 */) {} // 0x000000018399AB60-0x000000018399AD30
	// [XID] // 0x0000000189AED190-0x0000000189AED1B0
	public override string ToString() => default; // 0x000000018399B430-0x000000018399B5B0
	[BlackList] // 0x0000000189AF4C80-0x0000000189AF4CC0
	// [XID] // 0x0000000189AF4C80-0x0000000189AF4CC0
	public override void AutoAllocTypeFields() {} // 0x00000001839996D0-0x0000000183999770
	[BlackList] // 0x0000000189AFF2D0-0x0000000189AFF310
	// [XID] // 0x0000000189AFF2D0-0x0000000189AFF310
	public override void AutoRecycleTypeFields() {} // 0x0000000183999770-0x0000000183999860
	[BlackList] // 0x0000000189B099C0-0x0000000189B09A00
	// [XID] // 0x0000000189B099C0-0x0000000189B09A00
	public override void ReturnToObjectPool() {} // 0x000000018399B190-0x000000018399B230
}

