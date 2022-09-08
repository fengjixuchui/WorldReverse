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

public sealed class AbilityDoActionByStateIDMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14515
{
	// Fields
	private DoActionByStateIDMixin config; // 0x70
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<int> configStateIDs; // 0x78

	// Constructors
	public AbilityDoActionByStateIDMixin() {} // 0x00000001827CAD40-0x00000001827CADA0

	// Methods
	// [XID] // 0x00000001899E0D90-0x00000001899E0DB0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001827CA410-0x00000001827CA5D0
	// [XID] // 0x00000001899E8960-0x00000001899E8980
	public override void Clear() {} // 0x00000001827CA640-0x00000001827CA710
	// [XID] // 0x00000001899F0040-0x00000001899F0060
	protected override void AddEventListener() {} // 0x00000001827C9E30-0x00000001827C9F40
	// [XID] // 0x00000001899F7660-0x00000001899F7680
	protected override void RemoveEventListener() {} // 0x00000001827CA990-0x00000001827CAAA0
	// [XID] // 0x00000001899FED40-0x00000001899FED60
	public override void OnAdded(bool syncToServer) {} // 0x00000001827C9B50-0x00000001827C9C10
	// [XID] // 0x0000000189A065C0-0x0000000189A065E0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001827CA360-0x00000001827CA410
	// [XID] // 0x0000000189A0DB00-0x0000000189A0DB20
	private void StateIDChanged(EvtStateIDChanged evt) {} // 0x00000001827CA710-0x00000001827CA930
	// [XID] // 0x0000000189A151C0-0x0000000189A151E0
	private void EnterActions() {} // 0x00000001827C9FA0-0x00000001827CA180
	// [XID] // 0x0000000189A1C310-0x0000000189A1C330
	private void ExitActions() {} // 0x00000001827CA180-0x00000001827CA360
	[BlackList] // 0x0000000189A23CB0-0x0000000189A23CF0
	// [XID] // 0x0000000189A23CB0-0x0000000189A23CF0
	public override void AutoAllocTypeFields() {} // 0x00000001827C9CA0-0x00000001827C9D70
	[BlackList] // 0x0000000189A2DEE0-0x0000000189A2DF20
	// [XID] // 0x0000000189A2DEE0-0x0000000189A2DF20
	public override void AutoRecycleTypeFields() {} // 0x00000001827C9D70-0x00000001827C9E30
	[BlackList] // 0x0000000189A389B0-0x0000000189A389F0
	// [XID] // 0x0000000189A389B0-0x0000000189A389F0
	public override void ReturnToObjectPool() {} // 0x00000001827CACA0-0x00000001827CAD40
}

