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

public sealed class AbilityDoActionByCreateGadgetMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14507
{
	// Fields
	private DoActionByCreateGadgetMixin config; // 0x70

	// Constructors
	public AbilityDoActionByCreateGadgetMixin() {} // 0x000000018191AE40-0x000000018191AEA0

	// Methods
	// [XID] // 0x00000001896F8F40-0x00000001896F8F60
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018191A3F0-0x000000018191A530
	// [XID] // 0x0000000189700950-0x0000000189700970
	public override void Clear() {} // 0x000000018191A5A0-0x000000018191A650
	// [XID] // 0x0000000189707FE0-0x0000000189708000
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x000000018191A650-0x000000018191A730
	// [XID] // 0x000000018970FA90-0x000000018970FAB0
	public override bool ListenEvent(BaseEvent evt) => default; // 0x000000018191A920-0x000000018191AA20
	// [XID] // 0x0000000189716C50-0x0000000189716C70
	public bool OnEvtEntityCreated(EvtEntityReady evt) => default; // 0x000000018191AA20-0x000000018191AC00
	// [XID] // 0x000000018971E6A0-0x000000018971E6C0
	protected override void AddEventListener() {} // 0x000000018191A130-0x000000018191A260
	// [XID] // 0x0000000189725E40-0x0000000189725E60
	protected override void RemoveEventListener() {} // 0x000000018191A790-0x000000018191A8C0
	// [XID] // 0x000000018972D370-0x000000018972D390
	public override void OnAdded(bool syncToServer) {} // 0x0000000181919E90-0x0000000181919F50
	// [XID] // 0x0000000189734A70-0x0000000189734A90
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x000000018191A340-0x000000018191A3F0
	[BlackList] // 0x000000018973C620-0x000000018973C660
	// [XID] // 0x000000018973C620-0x000000018973C660
	public override void AutoAllocTypeFields() {} // 0x0000000181919FE0-0x000000018191A080
	[BlackList] // 0x0000000189746DC0-0x0000000189746E00
	// [XID] // 0x0000000189746DC0-0x0000000189746E00
	public override void AutoRecycleTypeFields() {} // 0x000000018191A080-0x000000018191A130
	[BlackList] // 0x00000001897511D0-0x0000000189751210
	// [XID] // 0x00000001897511D0-0x0000000189751210
	public override void ReturnToObjectPool() {} // 0x000000018191ADA0-0x000000018191AE40
}

