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

public sealed class AbilitySteerAttackMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14575
{
	// Fields
	private SteerAttackMixin config; // 0x70
	private CharacterEntity _self; // 0x78
	private BaseEntity _attackTarget; // 0x80
	private bool _hasTriggered; // 0x88
	private int _stateIDIdx; // 0x8C
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<int> steerStateIDs; // 0x90
	private LCAbilityState _actorAbilityState; // 0x98

	// Constructors
	public AbilitySteerAttackMixin() {} // 0x0000000181948780-0x00000001819487F0

	// Methods
	// [XID] // 0x000000018961C920-0x000000018961C940
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001819472B0-0x0000000181947560
	// [XID] // 0x0000000189623EA0-0x0000000189623EC0
	public override void Clear() {} // 0x0000000181947650-0x0000000181947730
	// [XID] // 0x000000018962B5F0-0x000000018962B610
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000181946ED0-0x0000000181946FD0
	// [XID] // 0x0000000189632E10-0x0000000189632E30
	protected override void AddEventListener() {} // 0x0000000181946D60-0x0000000181946ED0
	// [XID] // 0x000000018963A910-0x000000018963A930
	protected override void RemoveEventListener() {} // 0x0000000181947870-0x00000001819479E0
	// [XID] // 0x0000000189642030-0x0000000189642050
	public override void OnAdded(bool syncToServer) {} // 0x0000000181946A40-0x0000000181946B10
	// [XID] // 0x0000000189649860-0x0000000189649880
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001819471F0-0x00000001819472B0
	// [XID] // 0x0000000189650F60-0x0000000189650F80
	private void CheckState() {} // 0x0000000181947C10-0x0000000181947D70
	// [XID] // 0x00000001896586B0-0x00000001896586D0
	public override void Tick(float inDeltaTime) {} // 0x0000000181948280-0x0000000181948780
	// [XID] // 0x000000018965FCA0-0x000000018965FCC0
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000181947730-0x0000000181947810
	// [XID] // 0x0000000189667780-0x00000001896677A0
	public override bool ListenEvent(BaseEvent evt) => default; // 0x0000000181947A40-0x0000000181947B20
	// [XID] // 0x000000018966EFC0-0x000000018966EFE0
	private void OnAvatarChanged(EvtAvatarChanged evt) {} // 0x0000000181947030-0x0000000181947170
	// [XID] // 0x00000001896768F0-0x0000000189676910
	private void OnStateIDChanged(EvtStateIDChanged evt) {} // 0x0000000181947D70-0x0000000181947EB0
	// [XID] // 0x000000018967E140-0x000000018967E160
	private bool CheckCanSteer() => default; // 0x0000000181947F70-0x0000000181948160
	[BlackList] // 0x0000000189685930-0x0000000189685970
	// [XID] // 0x0000000189685930-0x0000000189685970
	public override void AutoAllocTypeFields() {} // 0x0000000181946BA0-0x0000000181946C80
	[BlackList] // 0x0000000189690900-0x0000000189690940
	// [XID] // 0x0000000189690900-0x0000000189690940
	public override void AutoRecycleTypeFields() {} // 0x0000000181946C80-0x0000000181946D60
	[BlackList] // 0x000000018969AC90-0x000000018969ACD0
	// [XID] // 0x000000018969AC90-0x000000018969ACD0
	public override void ReturnToObjectPool() {} // 0x00000001819481E0-0x0000000181948280
}

