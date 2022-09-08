/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class VCBaseCombat : VCBase // TypeDefIndex: 11807
{
	// Fields
	[NonSerialized]
	public ConfigCombat configCombat; // 0x118
	public bool dieImmediately; // 0x120
	protected float _dieForceDisappearTime; // 0x124
	protected bool _startDieEnd; // 0x128
	protected float _dieEndTime; // 0x12C
	protected string _dieDisappearEffectName; // 0x130
	protected bool _muteAllShaderDieEff; // 0x138
	protected bool _hasAnimatorDie; // 0x139
	protected bool _fallWhenAirDie; // 0x13A
	protected float _dieShaderEnableDurationTime; // 0x13C
	protected float _dieShaderDisableDurationTime; // 0x140
	protected E_ShaderData _dieShaderData; // 0x144
	protected float _dieModelFadeDelay; // 0x148
	protected float _dieEffectDelay; // 0x14C
	protected float _dieEndRagdollDelay; // 0x150
	protected LCBaseCombat _lcCombat; // 0x158
	protected Coroutine _dieEndHandler; // 0x160
	protected uint _killerID; // 0x168
	protected Coroutine _dieRagdollHandler; // 0x170
	private bool _hasPreparedDieEnd; // 0x178
	private string _overrideBulletAimPointName; // 0x180

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B2E820-0x0000000189B2E840 */ get => default; } // 0x000000018404D110-0x000000018404D1B0 
	public bool stateCanDoSkill { /* [XID] */ /* 0x0000000189B35EB0-0x0000000189B35EF0 */ get; /* [XID] */ /* 0x0000000189B40930-0x0000000189B40970 */ set; } // 0x0000000184049E80-0x0000000184049EE0 0x000000018404C8D0-0x000000018404C940
	public int curState { /* [XID] */ /* 0x0000000189B4B080-0x0000000189B4B0C0 */ get; /* [XID] */ /* 0x0000000189B558C0-0x0000000189B55900 */ set; } // 0x0000000184049C20-0x0000000184049C80 0x00000001840499A0-0x0000000184049A10
	public bool canDoSkillByNormalizedTime { /* [XID] */ /* 0x0000000189B60390-0x0000000189B603D0 */ get; /* [XID] */ /* 0x0000000189B6A9D0-0x0000000189B6AA10 */ set; } // 0x000000018404BD90-0x000000018404BDF0 0x0000000184049E10-0x0000000184049E80
	public bool canDoSkill { /* [XID] */ /* 0x0000000189BD1210-0x0000000189BD1230 */ get => default; /* [XID] */ /* 0x00000001897BE1C0-0x00000001897BE1E0 */ set {} } // 0x000000018404AB30-0x000000018404AC70 0x0000000184049C80-0x0000000184049DB0
	public bool canJumpCancel { /* [XID] */ /* 0x0000000189B83EA0-0x0000000189B83EE0 */ get; /* [XID] */ /* 0x0000000189B8E040-0x0000000189B8E080 */ set; } // 0x000000018404A5D0-0x000000018404A630 0x0000000184049BB0-0x0000000184049C20
	public bool canSprintCancel { /* [XID] */ /* 0x0000000189B98570-0x0000000189B985B0 */ get; /* [XID] */ /* 0x0000000189BA2CF0-0x0000000189BA2D30 */ set; } // 0x0000000184049DB0-0x0000000184049E10 0x0000000184049930-0x00000001840499A0
	public bool canFlyCancel { /* [XID] */ /* 0x0000000189BACDE0-0x0000000189BACE20 */ get; /* [XID] */ /* 0x0000000189BB7320-0x0000000189BB7360 */ set; } // 0x000000018404CC10-0x000000018404CC70 0x000000018404BDF0-0x000000018404BE60

	// Constructors
	public VCBaseCombat() {} // 0x000000018404D040-0x000000018404D110

	// Methods
	// [XID] // 0x0000000189BC22A0-0x0000000189BC22C0
	public override void PreInit() {} // 0x000000018404CC70-0x000000018404CD30
	// [XID] // 0x0000000189941A90-0x0000000189941AB0
	public override void Init() {} // 0x000000018404B4E0-0x000000018404B640
	// [XID] // 0x00000001897D4560-0x00000001897D4580
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x000000018404CD30-0x000000018404CE00
	// [XID] // 0x0000000189BD8620-0x0000000189BD8640
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000184049EE0-0x0000000184049FB0
	// [XID] // 0x00000001897E3770-0x00000001897E3790
	public override void Destroy() {} // 0x000000018404A3A0-0x000000018404A450
	// [XID] // 0x00000001895ECBE0-0x00000001895ECC00
	protected void ClearDieEndHandler() {} // 0x000000018404C9F0-0x000000018404CB50
	// [XID] // 0x00000001897EAF00-0x00000001897EAF20
	public Transform GetWeaponTransform() => default; // 0x000000018404C0B0-0x000000018404C150
	// [XID] // 0x0000000189B694F0-0x0000000189B69510
	public virtual void DoCure(float addHP) {} // 0x000000018404C940-0x000000018404C9F0
	// [XID] // 0x00000001896031E0-0x0000000189603200
	public virtual void DoDamage(EvtBeingHit evtBeingHit) {} // 0x000000018404C770-0x000000018404C820
	// [XID] // 0x0000000189607960-0x0000000189607980
	public virtual void DoDamageResolved(EvtBeingHit evtBeingHit) {} // 0x0000000184049200-0x00000001840492B0
	// [XID] // 0x0000000189961600-0x0000000189961620
	public virtual void DoDamageResolvedReconcile(AttackResult attackResult) {} // 0x000000018404BED0-0x000000018404BF80
	// [XID] // 0x0000000189619B30-0x0000000189619B50
	public virtual void DoDamageResolvedRemote(EvtBeingHit evtBeingHit) {} // 0x0000000184049FB0-0x000000018404A060
	// [XID] // 0x0000000189845F90-0x0000000189845FB0
	public virtual void DoAttackLanded(EvtAttackLanded evtAttackLanded) {} // 0x000000018404AA80-0x000000018404AB30
	// [XID] // 0x00000001898D86E0-0x00000001898D8700
	public virtual void DoAttackEvent(string animEventID) {} // 0x000000018404C820-0x000000018404C8D0
	// [XID] // 0x0000000189B9CCE0-0x0000000189B9CD00
	public virtual void ChangeHP(float HP, float maxHP) {} // 0x000000018404CB50-0x000000018404CC10
	// [XID] // 0x0000000189637D20-0x0000000189637D40
	public virtual void ChangeLevel(int level, int lastLevel, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AEAC03 */) {} // 0x000000018404A060-0x000000018404A130
	// [XID] // 0x000000018963EF70-0x000000018963EF90
	public virtual void Die(uint killerID) {} // 0x000000018404B380-0x000000018404B4E0
	// [XID] // 0x00000001896468A0-0x00000001896468C0
	public virtual string GetDieDisappearEffectName() => default; // 0x000000018404A850-0x000000018404A900
	// [XID] // 0x000000018964E020-0x000000018964E040
	public virtual void StartDieEnd(bool immediately = false /* Metadata: 0x00AEAC07 */, DieStateFlag dieStateFlag = DieStateFlag.None /* Metadata: 0x00AEAC08 */) {} // 0x000000018404ADE0-0x000000018404B380
	[DebuggerHidden] // 0x00000001896558F0-0x0000000189655930
	// [XID] // 0x00000001896558F0-0x0000000189655930
	protected IEnumerator FadeOutModel(float startDelay, E_ShaderData shaderData, string dieEndEff, float effDelay, DieStateFlag flag) => default; // 0x0000000184049620-0x00000001840497B0
	// [XID] // 0x00000001898DB6D0-0x00000001898DB6F0
	protected virtual void PlayDieEffect(string dieEndEff) {} // 0x0000000184049310-0x0000000184049620
	// [XID] // 0x00000001896678E0-0x0000000189667900
	protected virtual void DieEnd() {} // 0x000000018404B8C0-0x000000018404B9E0
	// [XID] // 0x000000018966F0E0-0x000000018966F100
	protected virtual bool ShouldRemoveIfDieEnd() => default; // 0x000000018404A130-0x000000018404A1D0
	// [XID] // 0x0000000189676A50-0x0000000189676A70
	public void DeactiveBullet() {} // 0x0000000184049A10-0x0000000184049BB0
	// [XID] // 0x000000018967E2E0-0x000000018967E300
	public virtual ConfigAttackEvent GetAttackEventConfig(string animEventID) => default; // 0x000000018404A9B0-0x000000018404AA80
	// [XID] // 0x0000000189685A70-0x0000000189685A90
	public virtual void DoSkill(int skillID) {} // 0x000000018404A6B0-0x000000018404A850
	// [IDTag] // 0x000000018968D410-0x000000018968D450
	// [XID] // 0x000000018968D410-0x000000018968D450
	public virtual bool CanDoSkill(uint skillID) => default; // 0x000000018404A1D0-0x000000018404A290
	// [IDTag] // 0x0000000189698300-0x0000000189698340
	// [XID] // 0x0000000189698300-0x0000000189698340
	public virtual bool CanDoSkill(uint skillID, bool stateForceEnable) => default; // 0x000000018404A290-0x000000018404A3A0
	// [XID] // 0x0000000189772190-0x00000001897721B0
	protected void InitDieSetting() {} // 0x000000018404B9E0-0x000000018404BD90
	// [XID] // 0x00000001896A9AA0-0x00000001896A9AC0
	protected override void Tick(float inDeltaTime) {} // 0x000000018404CE00-0x000000018404D040
	// [XID] // 0x00000001896B0A60-0x00000001896B0A80
	private void PrepareDieEnd() {} // 0x000000018404AC70-0x000000018404ADE0
	// [XID] // 0x0000000189709B80-0x0000000189709BA0
	public virtual void TryDoTurnDirection(TurnMode turnMode, float faceToTargetAngleThreshold = 0f /* Metadata: 0x00AEAC0C */) {} // 0x000000018404BF80-0x000000018404C040
	// [XID] // 0x00000001896BF5E0-0x00000001896BF600
	public void OnHittingScene(Collider collider, Vector3 pos, Quaternion rot, ConfigHitScene hitScene, ElementType elementType, StrikeType strikeType) {} // 0x000000018404C150-0x000000018404C770
	// [XID] // 0x00000001896C7010-0x00000001896C7030
	public void DieEndFromRagDoll() {} // 0x000000018404B640-0x000000018404B750
	[DebuggerHidden] // 0x00000001896CE620-0x00000001896CE660
	// [XID] // 0x00000001896CE620-0x00000001896CE660
	private IEnumerator StartDieEndFromRagDoll() => default; // 0x0000000184049820-0x0000000184049930
	// [IDTag] // 0x00000001896D8A40-0x00000001896D8A80
	// [XID] // 0x00000001896D8A40-0x00000001896D8A80
	public virtual void UpdateCombatProp(PropType type, float value) {} // 0x000000018404A450-0x000000018404A510
	// [IDTag] // 0x00000001896E3120-0x00000001896E3160
	// [XID] // 0x00000001896E3120-0x00000001896E3160
	public virtual void UpdateCombatProp(FightPropType type, float value) {} // 0x000000018404A510-0x000000018404A5D0
	// [XID] // 0x000000018986F120-0x000000018986F140
	public void SetOverrideBulletAimPointName(string name = null) {} // 0x000000018404A900-0x000000018404A9B0
	// [XID] // 0x00000001896F4D20-0x00000001896F4D40
	public string GetOverrideBulletAimPointName() => default; // 0x000000018404B750-0x000000018404B800
}

