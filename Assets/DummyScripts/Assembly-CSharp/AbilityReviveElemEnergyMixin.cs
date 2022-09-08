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

public sealed class AbilityReviveElemEnergyMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14562
{
	// Fields
	private ReviveElemEnergyMixin config; // 0x70
	private EntityTimer _timer; // 0x78

	// Constructors
	public AbilityReviveElemEnergyMixin() {} // 0x000000018464A1C0-0x000000018464A220

	// Methods
	// [XID] // 0x000000018981AD70-0x000000018981AD90
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000184649700-0x00000001846498F0
	// [XID] // 0x0000000189822570-0x0000000189822590
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000184649AD0-0x0000000184649BB0
	// [XID] // 0x0000000189829B70-0x0000000189829B90
	public override bool ListenEvent(BaseEvent evt) => default; // 0x0000000184649DA0-0x0000000184649E80
	// [XID] // 0x0000000189831040-0x0000000189831060
	public override void Clear() {} // 0x00000001846499E0-0x0000000184649AD0
	// [XID] // 0x0000000189838840-0x0000000189838860
	protected override void AddEventListener() {} // 0x0000000184649070-0x00000001846491A0
	// [XID] // 0x000000018983FD60-0x000000018983FD80
	protected override void RemoveEventListener() {} // 0x0000000184649C10-0x0000000184649D40
	// [XID] // 0x00000001898473E0-0x0000000189847400
	public override void OnAdded(bool syncToServer) {} // 0x0000000184648DD0-0x0000000184648E90
	// [XID] // 0x000000018984EA80-0x000000018984EAA0
	private void RefreshMixin() {} // 0x00000001846493D0-0x00000001846495B0
	// [XID] // 0x0000000189855C30-0x0000000189855C50
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000184649630-0x0000000184649700
	// [XID] // 0x000000018985CFC0-0x000000018985CFE0
	private void AddEnergy() {} // 0x00000001846491A0-0x0000000184649370
	// [XID] // 0x0000000189864990-0x00000001898649B0
	public override void Tick(float inDeltaTime) {} // 0x000000018464A0C0-0x000000018464A1C0
	[BlackList] // 0x000000018986BF30-0x000000018986BF70
	// [XID] // 0x000000018986BF30-0x000000018986BF70
	public override void AutoAllocTypeFields() {} // 0x0000000184648F20-0x0000000184648FC0
	[BlackList] // 0x0000000189876370-0x00000001898763B0
	// [XID] // 0x0000000189876370-0x00000001898763B0
	public override void AutoRecycleTypeFields() {} // 0x0000000184648FC0-0x0000000184649070
	[BlackList] // 0x0000000189880B10-0x0000000189880B50
	// [XID] // 0x0000000189880B10-0x0000000189880B50
	public override void ReturnToObjectPool() {} // 0x000000018464A020-0x000000018464A0C0
}

