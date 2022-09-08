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

public sealed class AbilityFieldEntityCountChangeMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14538
{
	// Fields
	private FieldEntityCountChangeMixin _config; // 0x70
	private HashSet<uint> _curFieldEntities; // 0x78

	// Constructors
	public AbilityFieldEntityCountChangeMixin() {} // 0x00000001828C3D50-0x00000001828C3DB0

	// Methods
	// [XID] // 0x00000001896AF480-0x00000001896AF4A0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001828C33B0-0x00000001828C34B0
	// [XID] // 0x00000001896B6B00-0x00000001896B6B20
	public override bool OnEvent(BaseEvent evt) => default; // 0x00000001828C3B20-0x00000001828C3C30
	// [XID] // 0x00000001896BDD20-0x00000001896BDD40
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001828C3120-0x00000001828C3290
	// [XID] // 0x00000001896C55F0-0x00000001896C5610
	public override void HandleRecoverData(RepeatedField<uint> data) {} // 0x00000001828C2B70-0x00000001828C2CD0
	// [XID] // 0x00000001896CCC60-0x00000001896CCC80
	private void SyncToServer() {} // 0x00000001828C37F0-0x00000001828C3960
	// [XID] // 0x00000001896D3E80-0x00000001896D3EA0
	private void InitEntities() {} // 0x00000001828C2850-0x00000001828C2B70
	// [XID] // 0x00000001896DB820-0x00000001896DB840
	public override void Clear() {} // 0x00000001828C3300-0x00000001828C33B0
	// [XID] // 0x00000001896E2FC0-0x00000001896E2FE0
	public override void OnAdded(bool syncToServer) {} // 0x00000001828C2520-0x00000001828C2670
	// [XID] // 0x00000001896EA580-0x00000001896EA5A0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001828C3070-0x00000001828C3120
	// [XID] // 0x00000001896F1530-0x00000001896F1550
	private void OnFieldEnter(EvtFieldEnter evt) {} // 0x00000001828C2E20-0x00000001828C3070
	// [XID] // 0x00000001896F8F20-0x00000001896F8F40
	private void OnFieldExit(EvtFieldExit evt) {} // 0x00000001828C2D30-0x00000001828C2E20
	// [XID] // 0x0000000189700930-0x0000000189700950
	private void OnFieldEntityCountChange(int changeCount, bool forceTrigger = false /* Metadata: 0x00AEB7E6 */) {} // 0x00000001828C3510-0x00000001828C37F0
	[BlackList] // 0x0000000189707FA0-0x0000000189707FE0
	// [XID] // 0x0000000189707FA0-0x0000000189707FE0
	public override void AutoAllocTypeFields() {} // 0x00000001828C2700-0x00000001828C27A0
	[BlackList] // 0x00000001897128B0-0x00000001897128F0
	// [XID] // 0x00000001897128B0-0x00000001897128F0
	public override void AutoRecycleTypeFields() {} // 0x00000001828C27A0-0x00000001828C2850
	[BlackList] // 0x000000018971D050-0x000000018971D090
	// [XID] // 0x000000018971D050-0x000000018971D090
	public override void ReturnToObjectPool() {} // 0x00000001828C3CB0-0x00000001828C3D50
}

