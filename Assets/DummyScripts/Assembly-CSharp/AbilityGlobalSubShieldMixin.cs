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

public sealed class AbilityGlobalSubShieldMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14542
{
	// Fields
	public AbilityGlobalMainShieldMixin mainShield; // 0x70

	// Constructors
	public AbilityGlobalSubShieldMixin() {} // 0x00000001830CC140-0x00000001830CC1A0

	// Methods
	// [XID] // 0x000000018984EAA0-0x000000018984EAC0
	public override void OnAdded(bool syncToServer) {} // 0x00000001830CB2D0-0x00000001830CB670
	// [XID] // 0x0000000189855C50-0x0000000189855C70
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001830CB8A0-0x00000001830CB960
	// [XID] // 0x000000018985CFE0-0x000000018985D000
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001830CB9D0-0x00000001830CBAB0
	// [XID] // 0x00000001898649B0-0x00000001898649D0
	public override bool OnEvent(BaseEvent evt) => default; // 0x00000001830CBF10-0x00000001830CC020
	// [XID] // 0x000000018986BF70-0x000000018986BF90
	private static new EventID[] GetSelfOnEventRemoteIDsExcludingBase() => default; // 0x00000001830CBAB0-0x00000001830CBB90
	// [XID] // 0x00000001898733D0-0x00000001898733F0
	public override bool OnEventRemote(BaseEvent evt) => default; // 0x00000001830CBE00-0x00000001830CBF10
	// [XID] // 0x000000018987AF80-0x000000018987AFA0
	private bool OnBeingHit(EvtBeingHit evt) => default; // 0x00000001830CBB90-0x00000001830CBCC0
	[BlackList] // 0x0000000189881F60-0x0000000189881FA0
	// [XID] // 0x0000000189881F60-0x0000000189881FA0
	public override void AutoAllocTypeFields() {} // 0x00000001830CB670-0x00000001830CB710
	[BlackList] // 0x000000018988C580-0x000000018988C5C0
	// [XID] // 0x000000018988C580-0x000000018988C5C0
	public override void AutoRecycleTypeFields() {} // 0x00000001830CB710-0x00000001830CB7C0
	[BlackList] // 0x0000000189896980-0x00000001898969C0
	// [XID] // 0x0000000189896980-0x00000001898969C0
	public override void ReturnToObjectPool() {} // 0x00000001830CC0A0-0x00000001830CC140
}

