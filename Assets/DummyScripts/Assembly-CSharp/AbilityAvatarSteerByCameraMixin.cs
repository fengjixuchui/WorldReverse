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

public sealed class AbilityAvatarSteerByCameraMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14486
{
	// Fields
	private AvatarSteerByCameraMixin config; // 0x70
	private AvatarEntity _avatar; // 0x78
	private bool _isInSteerState; // 0x80
	private float _syncToRemoteLastTime; // 0x84
	private const float SYNC_INTERVAL = 0.1f; // Metadata: 0x00AEB783
	private const float REVISE_MIN_DISTANCE = 1f; // Metadata: 0x00AEB787
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<int> configStateIDs; // 0x88

	// Constructors
	public AbilityAvatarSteerByCameraMixin() {} // 0x0000000181E046A0-0x0000000181E04710

	// Methods
	// [XID] // 0x00000001896D7140-0x00000001896D7160
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000181E03770-0x0000000181E039E0
	// [XID] // 0x00000001896DE9F0-0x00000001896DEA10
	public override void Clear() {} // 0x0000000181E03AD0-0x0000000181E03BA0
	// [XID] // 0x00000001896E5CE0-0x00000001896E5D00
	protected override void AddEventListener() {} // 0x0000000181E03140-0x0000000181E03240
	// [XID] // 0x00000001896ED2B0-0x00000001896ED2D0
	protected override void RemoveEventListener() {} // 0x0000000181E03C00-0x0000000181E03D00
	// [XID] // 0x00000001896F4BE0-0x00000001896F4C00
	public override void OnAdded(bool syncToServer) {} // 0x0000000181E02E40-0x0000000181E02F00
	// [XID] // 0x00000001896FC310-0x00000001896FC330
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000181E036B0-0x0000000181E03770
	// [XID] // 0x0000000189703880-0x00000001897038A0
	public override void Tick(float inDeltaTime) {} // 0x0000000181E04110-0x0000000181E046A0
	// [XID] // 0x000000018970B0B0-0x000000018970B0D0
	public override void HandleMixinInvokeEntry(UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000181E032A0-0x0000000181E036B0
	// [XID] // 0x00000001897128F0-0x0000000189712910
	private void OnStateIDChanged(EvtStateIDChanged evt) {} // 0x0000000181E03DC0-0x0000000181E03EB0
	[BlackList] // 0x000000018971A190-0x000000018971A1D0
	// [XID] // 0x000000018971A190-0x000000018971A1D0
	public override void AutoAllocTypeFields() {} // 0x0000000181E02F90-0x0000000181E03070
	[BlackList] // 0x0000000189724430-0x0000000189724470
	// [XID] // 0x0000000189724430-0x0000000189724470
	public override void AutoRecycleTypeFields() {} // 0x0000000181E03070-0x0000000181E03140
	[BlackList] // 0x000000018972EBB0-0x000000018972EBF0
	// [XID] // 0x000000018972EBB0-0x000000018972EBF0
	public override void ReturnToObjectPool() {} // 0x0000000181E04070-0x0000000181E04110
}

