/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityDoActionByEventMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14510
{
	// Fields
	private DoActionByEventMixin config; // 0x70
	private LCAbilityState _abilityState; // 0x78
	private Coroutine _curoutine; // 0x80

	// Constructors
	public AbilityDoActionByEventMixin() {} // 0x0000000182E64720-0x0000000182E64790

	// Methods
	// [XID] // 0x0000000189804620-0x0000000189804640
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182E62F90-0x0000000182E630D0
	// [XID] // 0x000000018980BA50-0x000000018980BA70
	public override void Clear() {} // 0x0000000182E632D0-0x0000000182E633E0
	// [XID] // 0x0000000189813200-0x0000000189813220
	private bool CanDoAction() => default; // 0x0000000182E630D0-0x0000000182E63260
	// [XID] // 0x000000018981AD90-0x000000018981ADB0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000182E634B0-0x0000000182E635B0
	// [XID] // 0x0000000189822590-0x00000001898225B0
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000182E64300-0x0000000182E64500
	// [XID] // 0x0000000189829B90-0x0000000189829BB0
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000182E633E0-0x0000000182E634B0
	// [XID] // 0x0000000189831060-0x0000000189831080
	public override bool ListenEvent(BaseEvent evt) => default; // 0x0000000182E63F60-0x0000000182E64160
	// [XID] // 0x0000000189838860-0x0000000189838880
	private void CheckDoAction() {} // 0x0000000182E62BB0-0x0000000182E62DA0
	// [XID] // 0x000000018983FD80-0x000000018983FDA0
	protected override void AddEventListener() {} // 0x0000000182E62810-0x0000000182E62BB0
	// [XID] // 0x0000000189847440-0x0000000189847460
	protected override void RemoveEventListener() {} // 0x0000000182E638B0-0x0000000182E63C20
	// [XID] // 0x000000018984EAC0-0x000000018984EAE0
	public override void OnAdded(bool syncToServer) {} // 0x0000000182E62570-0x0000000182E62630
	// [XID] // 0x0000000189855C70-0x0000000189855C90
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000182E62E80-0x0000000182E62F90
	// [XID] // 0x000000018985D000-0x000000018985D020
	private void OnAbilityStateAdded(AbilityState state, bool muteDisplayEffect) {} // 0x0000000182E635B0-0x0000000182E63850
	// [XID] // 0x00000001898649D0-0x00000001898649F0
	private void OnAbilityStateRemoved(AbilityState state) {} // 0x0000000182E63C80-0x0000000182E63F60
	// [XID] // 0x000000018986BF90-0x000000018986BFB0
	private bool CheckHPChangeEventNeeded(ChangHpReason reason) => default; // 0x0000000182E64580-0x0000000182E64680
	[BlackList] // 0x00000001898733F0-0x0000000189873430
	// [XID] // 0x00000001898733F0-0x0000000189873430
	public override void AutoAllocTypeFields() {} // 0x0000000182E626C0-0x0000000182E62760
	[BlackList] // 0x000000018987DF70-0x000000018987DFB0
	// [XID] // 0x000000018987DF70-0x000000018987DFB0
	public override void AutoRecycleTypeFields() {} // 0x0000000182E62760-0x0000000182E62810
	[BlackList] // 0x0000000189887F00-0x0000000189887F40
	// [XID] // 0x0000000189887F00-0x0000000189887F40
	public override void ReturnToObjectPool() {} // 0x0000000182E64680-0x0000000182E64720
}

