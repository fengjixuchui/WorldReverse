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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class AbilityWeightDetectRegionMixin : BaseAbilityMixin // TypeDefIndex: 14600
{
	// Fields
	private WeightDetectRegionMixin _config; // 0x70
	private float _totalWeight; // 0x78
	private const float CHECK_INTERVAL = 0.5f; // Metadata: 0x00AEB941
	private float _timer; // 0x7C
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<LCBaseCombat> _entities; // 0x80

	// Constructors
	public AbilityWeightDetectRegionMixin() {} // 0x0000000185424E60-0x0000000185424EC0

	// Methods
	// [XID] // 0x00000001895E9AA0-0x00000001895E9AC0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000185424290-0x00000001854243D0
	// [XID] // 0x00000001895F1140-0x00000001895F1160
	public override void OnAdded(bool syncToServer) {} // 0x0000000185423CC0-0x0000000185423DA0
	// [XID] // 0x00000001895F8CA0-0x00000001895F8CC0
	public override void Clear() {} // 0x0000000185424710-0x00000001854247E0
	// [XID] // 0x0000000189600050-0x0000000189600070
	public override void Tick(float inDeltaTime) {} // 0x0000000185424D80-0x0000000185424E60
	// [XID] // 0x0000000189607700-0x0000000189607720
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001854247E0-0x00000001854248E0
	// [XID] // 0x000000018960F290-0x000000018960F2B0
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000185424BD0-0x0000000185424D00
	// [XID] // 0x0000000189616830-0x0000000189616850
	private bool OnFieldEnter(EvtFieldEnter evt) => default; // 0x0000000185424060-0x0000000185424290
	// [XID] // 0x000000018961E120-0x000000018961E140
	private bool OnFieldExit(EvtFieldExit evt) => default; // 0x0000000185423E30-0x0000000185424060
	// [XID] // 0x00000001896255F0-0x0000000189625610
	private void CalculateTotalWeight() {} // 0x0000000185424450-0x0000000185424710
	// [XID] // 0x000000018962CE30-0x000000018962CE50
	private void OnWeightChanged() {} // 0x00000001854249C0-0x0000000185424BD0
}

