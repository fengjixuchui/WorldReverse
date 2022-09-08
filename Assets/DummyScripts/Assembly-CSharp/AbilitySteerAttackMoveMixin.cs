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
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilitySteerAttackMoveMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14576
{
	// Fields
	private SteerAttackMoveMixin config; // 0x70
	private CharacterEntity _self; // 0x78
	private BaseEntity _attackTarget; // 0x80
	private ulong _lastSendTime; // 0x88
	private ulong _sendTimeInterval; // 0x90
	private Vector3 _syncDir; // 0x98
	private float _syncRatio; // 0xA4
	private bool _hasTriggered; // 0xA8
	private Vector3 _lastEvtPos; // 0xAC
	private Vector3 _lastEvtFaceDir; // 0xB8
	private float _lastEvtDist; // 0xC4
	private int _stateIDIdx; // 0xC8
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<int> steerStateIDs; // 0xD0
	private LCAbilityState _actorAbilityState; // 0xD8

	// Constructors
	public AbilitySteerAttackMoveMixin() {} // 0x0000000181276FB0-0x00000001812770D0

	// Methods
	// [XID] // 0x00000001896AC980-0x00000001896AC9A0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000181274FB0-0x0000000181275260
	// [XID] // 0x00000001896B3C50-0x00000001896B3C70
	public override void Clear() {} // 0x00000001812756C0-0x00000001812757A0
	// [XID] // 0x00000001896BB2E0-0x00000001896BB300
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000181274BD0-0x0000000181274CD0
	// [XID] // 0x00000001896C24A0-0x00000001896C24C0
	protected override void AddEventListener() {} // 0x0000000181274A10-0x0000000181274BD0
	// [XID] // 0x00000001896C9A30-0x00000001896C9A50
	protected override void RemoveEventListener() {} // 0x00000001812758E0-0x0000000181275AA0
	// [XID] // 0x00000001896D1260-0x00000001896D1280
	public override void OnAdded(bool syncToServer) {} // 0x0000000181274690-0x0000000181274760
	// [XID] // 0x00000001896D8940-0x00000001896D8960
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000181274EF0-0x0000000181274FB0
	// [XID] // 0x00000001896E0190-0x00000001896E01B0
	private void CheckState() {} // 0x0000000181275CD0-0x0000000181275E30
	// [XID] // 0x00000001896E74A0-0x00000001896E74C0
	public override void Tick(float inDeltaTime) {} // 0x0000000181276620-0x0000000181276FB0
	// [XID] // 0x00000001896EEA80-0x00000001896EEAA0
	private void OnStateIDChanged(EvtStateIDChanged evt) {} // 0x0000000181276110-0x0000000181276250
	// [XID] // 0x00000001896F64C0-0x00000001896F64E0
	private void AdjustMotionInfo(EvtMotionInfoDuringSteerAttack evt) {} // 0x0000000181275260-0x00000001812755D0
	// [XID] // 0x00000001896FDBF0-0x00000001896FDC10
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x00000001812757A0-0x0000000181275880
	// [XID] // 0x0000000189705050-0x0000000189705070
	public override bool ListenEvent(BaseEvent evt) => default; // 0x0000000181275B00-0x0000000181275BE0
	// [XID] // 0x000000018970C700-0x000000018970C720
	private void OnAvatarChanged(EvtAvatarChanged evt) {} // 0x0000000181274D30-0x0000000181274E70
	// [XID] // 0x0000000189713FD0-0x0000000189713FF0
	private bool CheckGoBackToNormalLine(Vector3 authorityPos, Vector3 authFaceDir, out float dist) {
		dist = default;
		return default;
	} // 0x0000000181275E30-0x0000000181276110
	// [XID] // 0x000000018971B950-0x000000018971B970
	private bool CheckCanSteer() => default; // 0x0000000181276310-0x0000000181276500
	[BlackList] // 0x0000000189722CF0-0x0000000189722D30
	// [XID] // 0x0000000189722CF0-0x0000000189722D30
	public override void AutoAllocTypeFields() {} // 0x00000001812747F0-0x00000001812748D0
	[BlackList] // 0x000000018972D330-0x000000018972D370
	// [XID] // 0x000000018972D330-0x000000018972D370
	public override void AutoRecycleTypeFields() {} // 0x00000001812748D0-0x0000000181274A10
	[BlackList] // 0x0000000189737D30-0x0000000189737D70
	// [XID] // 0x0000000189737D30-0x0000000189737D70
	public override void ReturnToObjectPool() {} // 0x0000000181276580-0x0000000181276620
}

