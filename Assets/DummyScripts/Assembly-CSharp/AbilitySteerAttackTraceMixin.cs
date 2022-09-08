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

public sealed class AbilitySteerAttackTraceMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14577
{
	// Fields
	private SteerAttackTraceMixin config; // 0x70
	private CharacterEntity _self; // 0x78
	private BaseEntity _attackTarget; // 0x80
	private ulong _lastSendTime; // 0x88
	private ulong _sendTimeInterval; // 0x90
	private Vector3 _syncDir; // 0x98
	private float _syncRatio; // 0xA4
	private bool _hasTriggered; // 0xA8
	private int _stateIDIdx; // 0xAC
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<int> steerStateIDs; // 0xB0
	private LCAbilityState _actorAbilityState; // 0xB8

	// Constructors
	public AbilitySteerAttackTraceMixin() {} // 0x00000001811EAE20-0x00000001811EAEF0

	// Methods
	// [XID] // 0x0000000189749E30-0x0000000189749E50
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001811E9350-0x00000001811E9600
	// [XID] // 0x00000001897511B0-0x00000001897511D0
	public override void Clear() {} // 0x00000001811E9890-0x00000001811E9970
	// [XID] // 0x0000000189758650-0x0000000189758670
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001811E8F70-0x00000001811E9070
	// [XID] // 0x00000001897602D0-0x00000001897602F0
	protected override void AddEventListener() {} // 0x00000001811E8DB0-0x00000001811E8F70
	// [XID] // 0x0000000189767600-0x0000000189767620
	protected override void RemoveEventListener() {} // 0x00000001811E9AB0-0x00000001811E9C70
	// [XID] // 0x000000018976ED10-0x000000018976ED30
	public override void OnAdded(bool syncToServer) {} // 0x00000001811E8A60-0x00000001811E8B30
	// [XID] // 0x0000000189776900-0x0000000189776920
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001811E9290-0x00000001811E9350
	// [XID] // 0x000000018977DD50-0x000000018977DD70
	private void CheckState() {} // 0x00000001811E9EA0-0x00000001811EA000
	// [XID] // 0x00000001897856A0-0x00000001897856C0
	public override void Tick(float inDeltaTime) {} // 0x00000001811EA510-0x00000001811EAE20
	// [XID] // 0x000000018978CB40-0x000000018978CB60
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x00000001811E9970-0x00000001811E9A50
	// [XID] // 0x0000000189794000-0x0000000189794020
	public override bool ListenEvent(BaseEvent evt) => default; // 0x00000001811E9CD0-0x00000001811E9DB0
	// [XID] // 0x000000018979C450-0x000000018979C470
	private void OnStateIDChanged(EvtStateIDChanged evt) {} // 0x00000001811EA000-0x00000001811EA140
	// [XID] // 0x00000001897A3970-0x00000001897A3990
	private void OnAvatarChanged(EvtAvatarChanged evt) {} // 0x00000001811E90D0-0x00000001811E9210
	// [XID] // 0x00000001897AAD00-0x00000001897AAD20
	private void AdjustMotionInfo(EvtMotionInfoDuringSteerAttack evt) {} // 0x00000001811E9600-0x00000001811E97A0
	// [XID] // 0x00000001897B2970-0x00000001897B2990
	private bool CheckCanSteer() => default; // 0x00000001811EA200-0x00000001811EA3F0
	[BlackList] // 0x00000001897BA3B0-0x00000001897BA3F0
	// [XID] // 0x00000001897BA3B0-0x00000001897BA3F0
	public override void AutoAllocTypeFields() {} // 0x00000001811E8BC0-0x00000001811E8CA0
	[BlackList] // 0x00000001897C5520-0x00000001897C5560
	// [XID] // 0x00000001897C5520-0x00000001897C5560
	public override void AutoRecycleTypeFields() {} // 0x00000001811E8CA0-0x00000001811E8DB0
	[BlackList] // 0x00000001897CFC30-0x00000001897CFC70
	// [XID] // 0x00000001897CFC30-0x00000001897CFC70
	public override void ReturnToObjectPool() {} // 0x00000001811EA470-0x00000001811EA510
}

