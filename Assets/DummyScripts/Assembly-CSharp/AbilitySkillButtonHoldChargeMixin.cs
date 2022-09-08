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

public sealed class AbilitySkillButtonHoldChargeMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14572
{
	// Fields
	private SkillButtonHoldChargeMixin config; // 0x70
	private AvatarEntity _avatar; // 0x78
	private State _state; // 0x80
	private int _loopIx; // 0x84
	private int _loopCount; // 0x88
	private float _chargeTimeRatio; // 0x8C
	private EntityTimer _chargeTimer; // 0x90
	private EntityTimer _chargeTimerOut; // 0x98
	private ControlData _controlData; // 0xA0
	private LCAvatarCombat.SkillInfo _skillInfo; // 0xA8
	private bool _isMultiCharge; // 0xB0
	private float _sumHoldTime; // 0xB4
	private float _touchDownTime; // 0xB8
	private bool _isHolding; // 0xBC
	private LCAbilityState _abilityState; // 0xC0
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<int> beforeStateIDs; // 0xC8
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<int> chargeLoopStateIDs; // 0xD0
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<int> afterStateIDs; // 0xD8
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<int> transientStateIDs; // 0xE0
	private VCStateLayerController stateLayerController; // 0xE8
	private int _lastFrom; // 0xF0

	// Nested types
	protected enum State // TypeDefIndex: 14573
	{
		Idle = 0,
		Before = 1,
		InLoop = 2,
		After = 3
	}

	// Constructors
	public AbilitySkillButtonHoldChargeMixin() {} // 0x000000018456BB50-0x000000018456BBD0

	// Methods
	// [XID] // 0x0000000189ABCBA0-0x0000000189ABCBC0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000184568800-0x0000000184568DB0
	// [XID] // 0x0000000189AC4530-0x0000000189AC4550
	public override void Clear() {} // 0x0000000184569600-0x00000001845697C0
	// [XID] // 0x0000000189ACBB70-0x0000000189ACBB90
	protected override void AddEventListener() {} // 0x0000000184567C50-0x0000000184567E70
	// [XID] // 0x0000000189AD3550-0x0000000189AD3570
	protected override void RemoveEventListener() {} // 0x0000000184569F20-0x000000018456A120
	// [XID] // 0x0000000189ADB050-0x0000000189ADB070
	public override void OnAdded(bool syncToServer) {} // 0x0000000184566A70-0x0000000184566CF0
	// [XID] // 0x0000000189AE26E0-0x0000000189AE2700
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000184568460-0x0000000184568510
	// [XID] // 0x0000000189AEA170-0x0000000189AEA190
	public override void OnPoolAllocated() {} // 0x000000018456AFF0-0x000000018456B0E0
	// [XID] // 0x0000000189AF1D10-0x0000000189AF1D30
	public override void OnBeforePoolRecycled() {} // 0x000000018456AEF0-0x000000018456AFF0
	// [XID] // 0x0000000189AF96C0-0x0000000189AF96E0
	private void OnAbilityStateChanged(AbilityState state, bool muteDisplayEffect) {} // 0x00000001845682F0-0x00000001845683E0
	// [XID] // 0x0000000189B00B10-0x0000000189B00B30
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000184569D80-0x0000000184569E60
	// [XID] // 0x0000000189B080F0-0x0000000189B08110
	public override bool ListenEvent(BaseEvent evt) => default; // 0x000000018456A790-0x000000018456A880
	// [XID] // 0x0000000189B0F930-0x0000000189B0F950
	private bool OnFlag(EvtFlag evt) => default; // 0x000000018456A8E0-0x000000018456AA00
	// [XID] // 0x0000000189B16BA0-0x0000000189B16BC0
	public override void Tick(float inDeltaTime) {} // 0x000000018456B5B0-0x000000018456BB50
	// [XID] // 0x0000000189B1E3C0-0x0000000189B1E3E0
	private void OnStateIDChangedCallback(EvtStateIDChanged evt) {} // 0x00000001845677A0-0x0000000184567910
	// [XID] // 0x0000000189B25CA0-0x0000000189B25CC0
	private bool IsControlHold() => default; // 0x00000001845697C0-0x0000000184569A90
	// [XID] // 0x0000000189B2CFD0-0x0000000189B2CFF0
	private void ResetTimer(bool bReset) {} // 0x0000000184567E70-0x0000000184567FB0
	// [XID] // 0x0000000189B344B0-0x0000000189B344D0
	private void StateIDChangedCallback(int from, int to) {} // 0x000000018456A2F0-0x000000018456A790
	// [XID] // 0x0000000189B3BD50-0x0000000189B3BD70
	private void UpdateInLoop(float deltaTime) {} // 0x000000018456A180-0x000000018456A2F0
	// [XID] // 0x0000000189B43900-0x0000000189B43920
	private bool ShouldMoveToNextLoop() => default; // 0x0000000184567B90-0x0000000184567C50
	// [XID] // 0x0000000189B4AF80-0x0000000189B4AFA0
	private void OnMoveingToNextLoop(bool endLoop) {} // 0x000000018456AE20-0x000000018456AEF0
	// [XID] // 0x0000000189B527C0-0x0000000189B527E0
	private void OnIdleToBefore() {} // 0x0000000184568DB0-0x0000000184569510
	// [XID] // 0x0000000189B5A140-0x0000000189B5A160
	private void OnBeforeToIdle() {} // 0x000000018456AA00-0x000000018456AD60
	// [XID] // 0x0000000189B61640-0x0000000189B61660
	private void OnBeforeToAfter() {} // 0x0000000184567440-0x00000001845677A0
	// [XID] // 0x0000000189B691F0-0x0000000189B69210
	private void OnBeforeToInLoop() {} // 0x0000000184566CF0-0x00000001845670D0
	// [XID] // 0x0000000189B70730-0x0000000189B70750
	private void OnInLoopToAfter() {} // 0x0000000184569A90-0x0000000184569D80
	// [XID] // 0x0000000189B77B60-0x0000000189B77B80
	private void OnInLoopToIdle() {} // 0x0000000184568510-0x0000000184568800
	// [XID] // 0x0000000189B7F220-0x0000000189B7F240
	private void OnEndInLoop() {} // 0x000000018456B1C0-0x000000018456B510
	// [XID] // 0x0000000189B86D90-0x0000000189B86DB0
	private void OnAfterToIdle() {} // 0x0000000184567160-0x0000000184567440
	// [XID] // 0x0000000189B8DF40-0x0000000189B8DF60
	private void OnAfterToBefore() {} // 0x0000000184567FB0-0x0000000184568290
	[BlackList] // 0x0000000189B953C0-0x0000000189B95400
	// [XID] // 0x0000000189B953C0-0x0000000189B95400
	public override void AutoAllocTypeFields() {} // 0x0000000184567910-0x0000000184567A30
	[BlackList] // 0x0000000189B9F8E0-0x0000000189B9F920
	// [XID] // 0x0000000189B9F8E0-0x0000000189B9F920
	public override void AutoRecycleTypeFields() {} // 0x0000000184567A30-0x0000000184567B90
	[BlackList] // 0x0000000189BAA020-0x0000000189BAA060
	// [XID] // 0x0000000189BAA020-0x0000000189BAA060
	public override void ReturnToObjectPool() {} // 0x000000018456B510-0x000000018456B5B0
}

