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

public sealed class AbilityButtonHoldChargeMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14493
{
	// Fields
	private ButtonHoldChargeMixin config; // 0x70
	private State _state; // 0x78
	private AvatarEntity _avatar; // 0x80
	private EntityTimer _chargeTimer; // 0x88
	private ControlData _controlData; // 0x90
	private LCAvatarCombat.SkillInfo _skillInfo; // 0x98
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<int> chargeStateIDs; // 0xA0

	// Nested types
	private enum State // TypeDefIndex: 14494
	{
		Idle = 0,
		Uncharged = 1,
		Charged = 2,
		SecondCharged = 3
	}

	// Constructors
	public AbilityButtonHoldChargeMixin() {} // 0x00000001825BFD00-0x00000001825BFD60

	// Methods
	// [XID] // 0x0000000189911DB0-0x0000000189911DD0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001825BE2C0-0x00000001825BE570
	// [XID] // 0x0000000189919860-0x0000000189919880
	public override void Clear() {} // 0x00000001825BE820-0x00000001825BE930
	// [XID] // 0x0000000189920DB0-0x0000000189920DD0
	protected override void AddEventListener() {} // 0x00000001825BDA70-0x00000001825BDC00
	// [XID] // 0x00000001899287F0-0x0000000189928810
	protected override void RemoveEventListener() {} // 0x00000001825BEEA0-0x00000001825BF010
	// [XID] // 0x000000018992FC70-0x000000018992FC90
	public override void OnAdded(bool syncToServer) {} // 0x00000001825BD560-0x00000001825BD640
	// [XID] // 0x0000000189937190-0x00000001899371B0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001825BE210-0x00000001825BE2C0
	// [XID] // 0x000000018993EC80-0x000000018993ECA0
	public override void OnPoolAllocated() {} // 0x00000001825BF6C0-0x00000001825BF7A0
	// [XID] // 0x0000000189946350-0x0000000189946370
	public override void OnBeforePoolRecycled() {} // 0x00000001825BF5E0-0x00000001825BF6C0
	// [XID] // 0x000000018994D9E0-0x000000018994DA00
	public override void OnAbilityTriggered(EvtAbilityStart evt) {} // 0x00000001825BF070-0x00000001825BF120
	// [XID] // 0x0000000189955020-0x0000000189955040
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x00000001825BEBA0-0x00000001825BEC80
	// [XID] // 0x000000018995C8C0-0x000000018995C8E0
	public override bool ListenEvent(BaseEvent evt) => default; // 0x00000001825BF120-0x00000001825BF210
	// [XID] // 0x0000000189964150-0x0000000189964170
	private bool OnLocalAvatarChange(EvtAvatarChanged evt) => default; // 0x00000001825BDF80-0x00000001825BE030
	// [XID] // 0x000000018996B6F0-0x000000018996B710
	private void OnStateIDChangedCallback(EvtStateIDChanged evt) {} // 0x00000001825BD780-0x00000001825BD8A0
	// [XID] // 0x0000000189973290-0x00000001899732B0
	public override void Tick(float inDeltaTime) {} // 0x00000001825BF920-0x00000001825BFD00
	// [XID] // 0x000000018997AB80-0x000000018997ABA0
	private bool IsControlAvaliable() => default; // 0x00000001825BEAF0-0x00000001825BEBA0
	// [XID] // 0x00000001899824D0-0x00000001899824F0
	private bool IsControlHold() => default; // 0x00000001825BE9B0-0x00000001825BEAF0
	// [XID] // 0x0000000189989C30-0x0000000189989C50
	private void BeginUncharged() {} // 0x00000001825BDD20-0x00000001825BDF20
	// [XID] // 0x0000000189991550-0x0000000189991570
	private void ReleaseUncharged() {} // 0x00000001825BED40-0x00000001825BEEA0
	// [XID] // 0x0000000189999060-0x0000000189999080
	private void BeginCharged() {} // 0x00000001825BE570-0x00000001825BE730
	// [XID] // 0x00000001899A0890-0x00000001899A08B0
	private void ReleaseCharged() {} // 0x00000001825BF480-0x00000001825BF5E0
	// [XID] // 0x00000001899A8360-0x00000001899A8380
	private void BeginSecondCharged() {} // 0x00000001825BF330-0x00000001825BF480
	// [XID] // 0x00000001899AFB30-0x00000001899AFB50
	private void ReleaseSecondCharged() {} // 0x00000001825BE030-0x00000001825BE190
	// [XID] // 0x00000001899B7000-0x00000001899B7020
	private void CancelCharged() {} // 0x00000001825BD640-0x00000001825BD6F0
	// [XID] // 0x00000001899BEA80-0x00000001899BEAA0
	private void ResetTimer(bool bReset) {} // 0x00000001825BDC00-0x00000001825BDD20
	[BlackList] // 0x00000001899C64E0-0x00000001899C6520
	// [XID] // 0x00000001899C64E0-0x00000001899C6520
	public override void AutoAllocTypeFields() {} // 0x00000001825BD8A0-0x00000001825BD980
	[BlackList] // 0x00000001899D0A60-0x00000001899D0AA0
	// [XID] // 0x00000001899D0A60-0x00000001899D0AA0
	public override void AutoRecycleTypeFields() {} // 0x00000001825BD980-0x00000001825BDA70
	[BlackList] // 0x00000001899DAEA0-0x00000001899DAEE0
	// [XID] // 0x00000001899DAEA0-0x00000001899DAEE0
	public override void ReturnToObjectPool() {} // 0x00000001825BF880-0x00000001825BF920
}

