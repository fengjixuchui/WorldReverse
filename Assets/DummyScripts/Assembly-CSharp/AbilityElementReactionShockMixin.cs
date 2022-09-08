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
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityElementReactionShockMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14526
{
	// Fields
	private ElementReactionShockMixin _config; // 0x70
	private float _timer; // 0x78
	private uint _camp; // 0x7C

	// Constructors
	public AbilityElementReactionShockMixin() {} // 0x0000000182ECF000-0x0000000182ECF070

	// Methods
	// [XID] // 0x00000001897EF6A0-0x00000001897EF6C0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182ECDBE0-0x0000000182ECDD20
	// [XID] // 0x00000001897F6D80-0x00000001897F6DA0
	public override void Clear() {} // 0x0000000182ECDDA0-0x0000000182ECDE50
	// [XID] // 0x00000001897FE3C0-0x00000001897FE3E0
	public override void OnAdded(bool syncToServer) {} // 0x0000000182ECD3F0-0x0000000182ECD580
	// [XID] // 0x0000000189805B30-0x0000000189805B50
	public override void OnRefresh() {} // 0x0000000182ECDA60-0x0000000182ECDBE0
	// [XID] // 0x000000018980D380-0x000000018980D3A0
	public override void Tick(float inDeltaTime) {} // 0x0000000182ECEE40-0x0000000182ECF000
	// [XID] // 0x0000000189814A10-0x0000000189814A30
	public void OnThinkInterval() {} // 0x0000000182ECE820-0x0000000182ECE970
	// [XID] // 0x000000018981C520-0x000000018981C540
	private void HandleDedicatedActionForShock(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier) {} // 0x0000000182ECE970-0x0000000182ECED20
	// [XID] // 0x0000000189823A60-0x0000000189823A80
	private void ResolveTargetForShock(ConfigAbilityAction actionConfig, out List<ActorAbilityPlugin.AbilityAttackTarget> outTargetLs) {
		outTargetLs = default;
	} // 0x0000000182ECD580-0x0000000182ECD820
	// [XID] // 0x000000018982B390-0x000000018982B3B0
	private void SelectShapeTargets(SelectTargetsByShape selectTargets, ActorAbility instancedAbility, ActorModifier instancedModifier, LCAbility self, BaseEntity other, out List<ActorAbilityPlugin.AbilityAttackTarget> outTargetLs, ref Vector3 logicCenter, ref BaseShape2d shape) {
		outTargetLs = default;
	} // 0x0000000182ECDF70-0x0000000182ECE7C0
	[BlackList] // 0x0000000189832790-0x00000001898327D0
	// [XID] // 0x0000000189832790-0x00000001898327D0
	public override void AutoAllocTypeFields() {} // 0x0000000182ECD8B0-0x0000000182ECD950
	[BlackList] // 0x000000018983CFA0-0x000000018983CFE0
	// [XID] // 0x000000018983CFA0-0x000000018983CFE0
	public override void AutoRecycleTypeFields() {} // 0x0000000182ECD950-0x0000000182ECDA00
	[BlackList] // 0x0000000189847400-0x0000000189847440
	// [XID] // 0x0000000189847400-0x0000000189847440
	public override void ReturnToObjectPool() {} // 0x0000000182ECEDA0-0x0000000182ECEE40
}

