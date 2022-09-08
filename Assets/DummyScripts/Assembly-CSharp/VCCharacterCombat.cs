/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class VCCharacterCombat : VCHitableCombat // TypeDefIndex: 11842
{
	// Fields
	protected VCBaseMove _moveComponent; // 0x1C0
	private Vector3 _rushToPoint; // 0x1C8
	public RushMoveRemoteInfo rushMoveRemoteInfo; // 0x1D4

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018989CAC0-0x000000018989CAE0 */ get => default; } // 0x00000001828BD5A0-0x00000001828BD640 
	public virtual float cameraRadiusSpringRatio { /* [XID] */ /* 0x00000001898EF710-0x00000001898EF730 */ get => default; } // 0x00000001828BC2D0-0x00000001828BC380 
	public virtual float cameraCombatElevWithHeightRatio { /* [XID] */ /* 0x00000001898A41E0-0x00000001898A4200 */ get => default; } // 0x00000001828BCCA0-0x00000001828BCD50 
	public virtual float cameraForceRadius { /* [XID] */ /* 0x00000001898AB3C0-0x00000001898AB3E0 */ get => default; } // 0x00000001828B9140-0x00000001828B91F0 
	public virtual float cameraForceRadiusDuration { /* [XID] */ /* 0x00000001899A53E0-0x00000001899A5400 */ get => default; } // 0x00000001828BC220-0x00000001828BC2D0 
	public virtual bool cameraShouldKeepForceRadius { /* [XID] */ /* 0x00000001898C1D30-0x00000001898C1D50 */ get => default; } // 0x00000001828BA0B0-0x00000001828BA150 

	// Nested types
	public struct RushMoveRemoteInfo // TypeDefIndex: 11843
	{
		// Fields
		public Vector3 velocity; // 0x00
		public float timeRange; // 0x0C
		public int animatorStateNameHash; // 0x10
		public Vector3 rushStartForward; // 0x14
		public Vector3 rushStartPos; // 0x20
		public Vector3 rushAttackTargetPos; // 0x2C
		public Vector3 rushToPos; // 0x38
		public bool isRushMoveSet; // 0x44
	}

	// Constructors
	public VCCharacterCombat() {} // 0x00000001828BD4B0-0x00000001828BD5A0

	// Methods
	// [XID] // 0x00000001897CCD00-0x00000001897CCD20
	public override void Init() {} // 0x00000001828BB7F0-0x00000001828BB900
	// [XID] // 0x00000001897D4400-0x00000001897D4420
	public override void OnEntityReady() {} // 0x00000001828BCD50-0x00000001828BCE70
	// [XID] // 0x0000000189886B20-0x0000000189886B40
	public override void Destroy() {} // 0x00000001828BA380-0x00000001828BA420
	// [XID] // 0x00000001899EE6D0-0x00000001899EE6F0
	protected static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001828BAD10-0x00000001828BADF0
	// [XID] // 0x00000001897EADC0-0x00000001897EADE0
	protected override bool OnEvent(BaseEvent evt) => default; // 0x00000001828BCE70-0x00000001828BCF80
	// [XID] // 0x00000001897F2B10-0x00000001897F2B30
	public override void Die(uint killerID) {} // 0x00000001828BB040-0x00000001828BB7F0
	// [XID] // 0x00000001897FA330-0x00000001897FA350
	public override void TryDoTurnDirection(TurnMode turnMode, float faceToTargetAngleThreshold = 0f /* Metadata: 0x00AEACEE */) {} // 0x00000001828BCAF0-0x00000001828BCCA0
	// [XID] // 0x0000000189852C50-0x0000000189852C70
	public void TryToSteerToInput(float inDeltaTime) {} // 0x00000001828BBFE0-0x00000001828BC220
	// [XID] // 0x0000000189808D50-0x0000000189808D70
	public void TryToSteerToCamera() {} // 0x00000001828B9450-0x00000001828B9690
	// [XID] // 0x0000000189810640-0x0000000189810660
	public bool TryToSteerToAttackTarget(float faceToTargetAngleThreshold, Vector3 direction) => default; // 0x00000001828BB900-0x00000001828BBCB0
	// [XID] // 0x0000000189817DA0-0x0000000189817DC0
	public void TryToSteerToAttackTargetOrInput(float faceToTargetAngleThreshold) {} // 0x00000001828BA810-0x00000001828BA930
	// [XID] // 0x000000018981F6D0-0x000000018981F6F0
	public void TryToSteerToAttackTargetOrCamera(float faceToTargetAngleThreshold) {} // 0x00000001828B9E00-0x00000001828B9F40
	// [XID] // 0x0000000189A9BC60-0x0000000189A9BC80
	public void RushMoveByAnimatorEvt(AnimatorEventRushMove evtAnimation, AnimatorStateInfo processingStateInfo) {} // 0x00000001828BC5C0-0x00000001828BC9F0
	// [XID] // 0x00000001898B2D60-0x00000001898B2D80
	public void FixedMonsterRushMoveByAnimatorEvt(AnimatorEventFixedMonsterRushMove evtAnimation, AnimatorStateInfo processingStateInfo) {} // 0x00000001828BCF80-0x00000001828BD4B0
	// [XID] // 0x000000018997F030-0x000000018997F050
	public void RushMoveByAction(Vector3 direction, float time) {} // 0x00000001828B91F0-0x00000001828B92F0
	// [XID] // 0x000000018983D100-0x000000018983D120
	public void FixedMonsterRushMoveByAction(Vector3 direction, Vector3 targetPos, string overrideCollider, HashSet<int> animatorStateIDs, bool needSetIsInAir, bool checkAnimatorStateOnExitOnly) {} // 0x00000001828BA670-0x00000001828BA810
	// [XID] // 0x00000001898447F0-0x0000000189844810
	public void FixedAvatarRushMoveByAction(Vector3 direction, Vector3 targetPos, string overrideCollider, HashSet<int> animatorStateIDs, bool needSetIsInAir) {} // 0x00000001828B9F40-0x00000001828BA0B0
	// [XID] // 0x000000018984BD30-0x000000018984BD50
	public void RushMoveRemote(Vector3 rushStartPos, Vector3 forward, Vector3 rushAttackTargetPos, Vector3 rushToPos, float timeRange, Action rushUseLocal) {} // 0x00000001828B9690-0x00000001828B9E00
	// [XID] // 0x0000000189959AB0-0x0000000189959AD0
	private void RushMoveAuthority(Vector3 direction, float timeRange) {} // 0x00000001828BAA30-0x00000001828BAC90
	// [XID] // 0x000000018985A840-0x000000018985A860
	private void FixedMonsterRushMoveAuthority(Vector3 direction, Vector3 targetPos, string overrideCollider, HashSet<int> animatorStateIDs, bool needSetIsInAir, bool checkAnimatorStateOnExitOnly) {} // 0x00000001828BBCB0-0x00000001828BBEF0
	// [XID] // 0x0000000189861890-0x00000001898618B0
	private void FixedAvatarRushMoveAuthority(Vector3 direction, Vector3 targetPos, string overrideCollider, HashSet<int> animatorStateIDs, bool needSetIsInAir) {} // 0x00000001828BA150-0x00000001828BA380
	// [XID] // 0x00000001898691D0-0x00000001898691F0
	public Vector3 GetRushToPoint() => default; // 0x00000001828BC380-0x00000001828BC460
	// [XID] // 0x0000000189870490-0x00000001898704B0
	public void ClearSkillTrigger() {} // 0x00000001828B92F0-0x00000001828B9450
	// [XID] // 0x0000000189877BC0-0x0000000189877BE0
	protected override void DamgeRetreat(Vector3 retreatDir) {} // 0x00000001828BADF0-0x00000001828BAF60
	// [XID] // 0x000000018987F410-0x000000018987F430
	protected override void HitAir(Vector3 retreatDir) {} // 0x00000001828BA930-0x00000001828BAA30
	// [XID] // 0x00000001898692B0-0x00000001898692D0
	public virtual void SetCombatMove(MoveType moveType) {} // 0x00000001828BA420-0x00000001828BA5C0
	// [XID] // 0x00000001899E8B00-0x00000001899E8B20
	public virtual void SetStateCameraType(StateCameraType stateCameraType) {} // 0x00000001828BA5C0-0x00000001828BA670
	// [XID] // 0x00000001899F0240-0x00000001899F0260
	public virtual void SetStateCameraParam(ConfigStateCameraParam stateCameraParam) {} // 0x00000001828B9030-0x00000001828B90E0
	// [XID] // 0x00000001898B2CC0-0x00000001898B2CE0
	public virtual void ResetCameraForceRadius() {} // 0x00000001828BCA50-0x00000001828BCAF0
	// [XID] // 0x00000001898BAC00-0x00000001898BAC20
	protected bool CheckAndEnterMoveState(MoveType moveType) => default; // 0x00000001828BAF60-0x00000001828BB040
}

