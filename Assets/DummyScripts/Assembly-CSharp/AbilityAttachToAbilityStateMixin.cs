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
using UniRx;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityAttachToAbilityStateMixin : BaseAbilityAttachToMixin, IAutoAllocRecycle // TypeDefIndex: 14468
{
	// Fields
	private AttachToAbilityStateMixin _config; // 0x78
	private LCAbilityState _abilityState; // 0x80

	// Properties
	protected override string modifierName { /* [XID] */ /* 0x0000000189B22D10-0x0000000189B22D30 */ get => default; } // 0x0000000183E78E90-0x0000000183E78F40 

	// Constructors
	public AbilityAttachToAbilityStateMixin() {} // 0x0000000183E79210-0x0000000183E79270

	// Methods
	// [XID] // 0x0000000189B13EE0-0x0000000189B13F00
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000183E78730-0x0000000183E788A0
	// [XID] // 0x0000000189B1B710-0x0000000189B1B730
	public override void Clear() {} // 0x0000000183E788A0-0x0000000183E78950
	// [XID] // 0x0000000189B2A340-0x0000000189B2A360
	protected override void AddEventListener() {} // 0x0000000183E784E0-0x0000000183E78620
	// [XID] // 0x0000000189B318A0-0x0000000189B318C0
	protected override void RemoveEventListener() {} // 0x0000000183E789B0-0x0000000183E78AF0
	// [XID] // 0x0000000189B38D30-0x0000000189B38D50
	private void OnAbilityStateChanged(List<Tuple<bool, AbilityState, uint>> abilityStatesChanged) {} // 0x0000000183E78680-0x0000000183E78730
	// [XID] // 0x0000000189B40850-0x0000000189B40870
	protected override bool CheckCondition() => default; // 0x0000000183E78D50-0x0000000183E78E90
	// [XID] // 0x0000000189B481D0-0x0000000189B481F0
	public override string ToString() => default; // 0x0000000183E78FE0-0x0000000183E79210
	[BlackList] // 0x0000000189B4F9B0-0x0000000189B4F9F0
	// [XID] // 0x0000000189B4F9B0-0x0000000189B4F9F0
	public override void AutoAllocTypeFields() {} // 0x0000000183E78320-0x0000000183E783C0
	[BlackList] // 0x0000000189B5A1A0-0x0000000189B5A1E0
	// [XID] // 0x0000000189B5A1A0-0x0000000189B5A1E0
	public override void AutoRecycleTypeFields() {} // 0x0000000183E783C0-0x0000000183E78470
	[BlackList] // 0x0000000189B64990-0x0000000189B649D0
	// [XID] // 0x0000000189B64990-0x0000000189B649D0
	public override void ReturnToObjectPool() {} // 0x0000000183E78F40-0x0000000183E78FE0
}

