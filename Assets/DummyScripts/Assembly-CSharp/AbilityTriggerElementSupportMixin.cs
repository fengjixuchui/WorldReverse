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

public sealed class AbilityTriggerElementSupportMixin : AbilityTriggerTypeSupportMixin, IAutoAllocRecycle // TypeDefIndex: 14589
{
	// Fields
	private TriggerElementSupportMixin config; // 0x98

	// Constructors
	public AbilityTriggerElementSupportMixin() {} // 0x00000001849E8310-0x00000001849E8370

	// Methods
	// [XID] // 0x000000018975CF80-0x000000018975CFA0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001849E78C0-0x00000001849E7A00
	// [XID] // 0x0000000189764780-0x00000001897647A0
	public override void Clear() {} // 0x00000001849E7C60-0x00000001849E7D10
	// [XID] // 0x000000018976C200-0x000000018976C220
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x00000001849E7D10-0x00000001849E7DF0
	// [XID] // 0x00000001897735A0-0x00000001897735C0
	public override bool ListenEvent(BaseEvent evt) => default; // 0x00000001849E7FC0-0x00000001849E80D0
	// [XID] // 0x000000018977AD90-0x000000018977ADB0
	private bool OnApplyModifier(EvtApplyModifier evt) => default; // 0x00000001849E7A00-0x00000001849E7BF0
	// [XID] // 0x0000000189782940-0x0000000189782960
	protected override void AddEventListener() {} // 0x00000001849E7620-0x00000001849E7730
	// [XID] // 0x0000000189789BB0-0x0000000189789BD0
	protected override void RemoveEventListener() {} // 0x00000001849E7E50-0x00000001849E7F60
	// [XID] // 0x00000001897913D0-0x00000001897913F0
	public override void OnAdded(bool syncToServer) {} // 0x00000001849E7380-0x00000001849E7440
	// [XID] // 0x0000000189798B30-0x0000000189798B50
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001849E7810-0x00000001849E78C0
	[BlackList] // 0x00000001897A0950-0x00000001897A0990
	// [XID] // 0x00000001897A0950-0x00000001897A0990
	public override void AutoAllocTypeFields() {} // 0x00000001849E74D0-0x00000001849E7570
	[BlackList] // 0x00000001897AACC0-0x00000001897AAD00
	// [XID] // 0x00000001897AACC0-0x00000001897AAD00
	public override void AutoRecycleTypeFields() {} // 0x00000001849E7570-0x00000001849E7620
	[BlackList] // 0x00000001897B6130-0x00000001897B6170
	// [XID] // 0x00000001897B6130-0x00000001897B6170
	public override void ReturnToObjectPool() {} // 0x00000001849E8270-0x00000001849E8310
}

