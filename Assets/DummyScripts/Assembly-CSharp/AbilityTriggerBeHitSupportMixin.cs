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

public sealed class AbilityTriggerBeHitSupportMixin : AbilityTriggerTypeSupportMixin, IAutoAllocRecycle // TypeDefIndex: 14588
{
	// Fields
	private TriggerBeHitSupportMixin config; // 0x98

	// Constructors
	public AbilityTriggerBeHitSupportMixin() {} // 0x00000001836E7610-0x00000001836E7670

	// Methods
	// [XID] // 0x00000001896FAAD0-0x00000001896FAAF0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001836E6BB0-0x00000001836E6CF0
	// [XID] // 0x0000000189702120-0x0000000189702140
	public override void Clear() {} // 0x00000001836E6D60-0x00000001836E6E10
	// [XID] // 0x0000000189709840-0x0000000189709860
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x00000001836E6E10-0x00000001836E6EF0
	// [XID] // 0x00000001897112B0-0x00000001897112D0
	public override bool ListenEvent(BaseEvent evt) => default; // 0x00000001836E72C0-0x00000001836E73D0
	// [XID] // 0x00000001897187E0-0x0000000189718800
	private bool OnBeingHit(EvtBeingHit evt) => default; // 0x00000001836E6F50-0x00000001836E7150
	// [XID] // 0x000000018971FF40-0x000000018971FF60
	protected override void AddEventListener() {} // 0x00000001836E6910-0x00000001836E6A20
	// [XID] // 0x00000001897276A0-0x00000001897276C0
	protected override void RemoveEventListener() {} // 0x00000001836E7150-0x00000001836E7260
	// [XID] // 0x000000018972EB50-0x000000018972EB70
	public override void OnAdded(bool syncToServer) {} // 0x00000001836E6670-0x00000001836E6730
	// [XID] // 0x00000001897362C0-0x00000001897362E0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001836E6B00-0x00000001836E6BB0
	[BlackList] // 0x000000018973E140-0x000000018973E180
	// [XID] // 0x000000018973E140-0x000000018973E180
	public override void AutoAllocTypeFields() {} // 0x00000001836E67C0-0x00000001836E6860
	[BlackList] // 0x0000000189748670-0x00000001897486B0
	// [XID] // 0x0000000189748670-0x00000001897486B0
	public override void AutoRecycleTypeFields() {} // 0x00000001836E6860-0x00000001836E6910
	[BlackList] // 0x0000000189752A70-0x0000000189752AB0
	// [XID] // 0x0000000189752A70-0x0000000189752AB0
	public override void ReturnToObjectPool() {} // 0x00000001836E7570-0x00000001836E7610
}

