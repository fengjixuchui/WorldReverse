/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class HumanoidMoveFSMMoveState : HumanoidMoveFSMBaseMoveState // TypeDefIndex: 14676
{
	// Fields
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected bool _enableAdjustAlongSlope; // 0x140
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected float _detectAdditiveFootRayLength; // 0x144
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected float _sprintAnimVelChangeClime; // 0x148
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected float _sprintAnimVelCoeff; // 0x14C
	private const float SLIP_ANGULAR_SPEED = 80f; // Metadata: 0x00AEBC87
	private const float ATTENUATION_TITLT = 2f; // Metadata: 0x00AEBC8B
	private bool _goupstairsEnterRun; // 0x150
	protected Vector3[] _resultParams; // 0x158
	protected MoveResult _moveResult; // 0x160
	protected bool _slipping; // 0x164
	protected const float SLIP_CLINE_CHANGE_SPEED = 2.5f; // Metadata: 0x00AEBC8F
	private bool _isJumpStroke; // 0x165
	private float _lastTimeTitlt; // 0x168
	private Transform _cameraLook; // 0x170
	protected bool _climbDownToGround; // 0x178
	protected bool _climbDownTogroundEntered; // 0x179
	public float SLIP_ANGLE_DAMP_TEST; // 0x17C
	private static Collider[] _overlapColliders; // 0x00
	protected VCAvatarHeadController _headController; // 0x180
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private bool _useTilt; // 0x188
	protected const float HARD_TRUN_ANGLE = 120f; // Metadata: 0x00AEBC93
	private const float MAX_TILT = 20f; // Metadata: 0x00AEBC97
	private const float TILT_SPEED_COEFF = 2f; // Metadata: 0x00AEBC9B
	private const float RECOVER_SPEED = 90f; // Metadata: 0x00AEBC9F
	private const float MAX_RUN_TILT_COEFF = 1f; // Metadata: 0x00AEBCA3
	private const float MAX_SPRINT_TILT_COEFF = 1.5f; // Metadata: 0x00AEBCA7
	protected float _currTilt; // 0x18C
	private const float MIN_YAW_SPEED = 30f; // Metadata: 0x00AEBCAB
	private const float YAW_OFFSET_TO_SPEED_RATIO = 5f; // Metadata: 0x00AEBCAF
	private const float YAW_SPEED_VELOCITY_MAGNITITUDE = 5.8f; // Metadata: 0x00AEBCB3
	private const float MAX_EVALUATE_SPEED = 5.8f; // Metadata: 0x00AEBCB7
	private const float MIN_EVALUATE_SPEED = 1.5f; // Metadata: 0x00AEBCBB
	private const float YAW_SPEED_MAX_SCALE = 1.5f; // Metadata: 0x00AEBCBF
	private const float HARD_HOR_MOVE_THRESHOLD = 0.3f; // Metadata: 0x00AEBCC3
	private Plane _regressionPlane; // 0x190
	private const float FIVE_DEGREE_CLINE = 0.08f; // Metadata: 0x00AEBCC7
	private const float FIVE_DEGREE_CLINE_MULTIPLIER = 4f; // Metadata: 0x00AEBCCB
	private const float CLINE_ANIM_ANGLE_RANGE = 60f; // Metadata: 0x00AEBCCF
	private float _clineDampVelcity; // 0x1A0
	public float _clineDampTime; // 0x1A4
	private const float SLIP_INPUT_DECELERATE_ANGLE = 50f; // Metadata: 0x00AEBCD3
	private const float NON_AUTHORITY_MIN_SLIP_VELOCITY = 0.2f; // Metadata: 0x00AEBCD7
	private bool _faceWall; // 0x1A8
	private Vector3 _lastSlopeNormal; // 0x1AC
	private Vector3 _lastSlopeDownDir; // 0x1B8
	private const float CLOSE_TO_GROUND_SPRINT_KD_HEIGH = 30f; // Metadata: 0x00AEBCDB
	private const float CLOSE_TO_GROUND_SPRINT_KD_LOW = 10f; // Metadata: 0x00AEBCDF
	private const float CLOSE_TO_GROUND_SPRINT_KD_HEIGH_THRESHOLD = 0.4f; // Metadata: 0x00AEBCE3
	private const float CLOSE_TO_GROUND_SPRINT_KD_LOW_THRESHOLD = 0.05f; // Metadata: 0x00AEBCE7
	private const float CLOSE_TO_GROUND_SPRINT_NOT_MOVING_KD_MULTIPLIER = 2f; // Metadata: 0x00AEBCEB
	private bool _closeToGroundHighKDMode; // 0x1C4
	protected float _curCloseToGroundVelocity; // 0x1C8
	protected bool _syncLastStayInPlace; // 0x1CC
	protected bool _syncLastMotionIdle; // 0x1CD
	protected bool _sendFirstReliable; // 0x1CE
	protected uint _syncLastRefSys; // 0x1D0
	protected const float TO_IDLE_USE_ANIM_MOVE_MAX_TOLERATE_DIST = 0.25f; // Metadata: 0x00AEBCEF

	// Nested types
	protected enum MoveResult // TypeDefIndex: 14677
	{
		StayInPlace = 0,
		DropForNoGroundBeneath = 1,
		StandbyToClimb = 2,
		JumpUpWallReady = 3,
		MoveAlongSurface = 4,
		StartSlip = 5,
		StopSlip = 6,
		GoUpstairs = 7,
		Climb = 8,
		Swim = 9,
		Ladder = 10
	}

	private sealed class HitResultComparer : IComparer<RaycastHit> // TypeDefIndex: 14678
	{
		// Fields
		private static HitResultComparer instance; // 0x00

		// Properties
		public static HitResultComparer Instance { /* [XID] */ /* 0x00000001898F6D30-0x00000001898F6D50 */ get => default; } // 0x000000018416DB50-0x000000018416DC30 

		// Constructors
		public HitResultComparer() {} // 0x000000018416DC30-0x000000018416DC90

		// Methods
		// [XID] // 0x00000001898FE4A0-0x00000001898FE4C0
		public int Compare(RaycastHit x, RaycastHit y) => default; // 0x000000018416D9E0-0x000000018416DB50
	}

	protected enum DevolutedCastMethod // TypeDefIndex: 14679
	{
		Undefined = 0,
		Capsule = 1,
		Sphere = 2,
		Ray = 3
	}

	// Constructors
	public HumanoidMoveFSMMoveState() {} // Dummy constructor
	public HumanoidMoveFSMMoveState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x000000018410A3F0-0x000000018410A5A0
	static HumanoidMoveFSMMoveState() {} // 0x000000018410A370-0x000000018410A3F0

	// Methods
	// [XID] // 0x0000000189B1B6F0-0x0000000189B1B710
	protected bool ShallStopSlip() => default; // 0x00000001840F8CD0-0x00000001840F8F30
	// [XID] // 0x0000000189B22CF0-0x0000000189B22D10
	public override void InitSyncWithCurrentTask(bool setPosition) {} // 0x0000000184101B20-0x0000000184101C80
	// [XID] // 0x0000000189B2A320-0x0000000189B2A340
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x0000000184103520-0x0000000184104310
	// [XID] // 0x0000000189B38D10-0x0000000189B38D30
	public override void Exit(HumanoidMoveFSM.FSMStateID nextState) {} // 0x00000001841027B0-0x0000000184102890
	// [XID] // 0x0000000189B40830-0x0000000189B40850
	public override void LateTick() {} // 0x00000001840FF7B0-0x00000001840FFD00
	// [IDTag] // 0x0000000189B48130-0x0000000189B48170
	// [XID] // 0x0000000189B48130-0x0000000189B48170
	public override void TrySteer(bool isMoving, float joystickAngle) {} // 0x0000000184108E90-0x0000000184109020
	// [IDTag] // 0x0000000189B52780-0x0000000189B527C0
	// [XID] // 0x0000000189B52780-0x0000000189B527C0
	public override void TrySteer(Vector3 targetDir) {} // 0x0000000184109020-0x0000000184109140
	// [XID] // 0x0000000189B5D1B0-0x0000000189B5D1D0
	public override bool CanDoJump() => default; // 0x00000001840FDF40-0x00000001840FE010
	// [XID] // 0x0000000189B64890-0x0000000189B648B0
	protected bool CheckMoveJumpHeight() => default; // 0x00000001840F1140-0x00000001840F1240
	// [XID] // 0x0000000189B6BCE0-0x0000000189B6BD00
	public virtual bool CanDoBlink() => default; // 0x0000000184101EF0-0x0000000184101FC0
	// [XID] // 0x0000000189B73610-0x0000000189B73630
	public override void DoJump() {} // 0x00000001840FEE60-0x00000001840FF400
	// [XID] // 0x0000000189B7AAB0-0x0000000189B7AAD0
	public virtual bool IsInSlip() => default; // 0x00000001840F8020-0x00000001840F80D0
	// [XID] // 0x0000000189B822F0-0x0000000189B82310
	protected void UpdateClimbDownToGround() {} // 0x00000001840F7AD0-0x00000001840F7C70
	// [XID] // 0x0000000189B89B70-0x0000000189B89B90
	protected virtual void GetTargetDirAndPos(out Vector3 targetDir, out Vector3 targetPos) {
		targetDir = default;
		targetPos = default;
	} // 0x00000001841045A0-0x00000001841047B0
	// [XID] // 0x0000000189B91100-0x0000000189B91120
	protected void StartSlip() {} // 0x00000001840F6720-0x00000001840F6A10
	// [XID] // 0x0000000189B98370-0x0000000189B98390
	protected virtual void DealMoveResult() {} // 0x00000001840F9E30-0x00000001840FAEF0
	// [XID] // 0x0000000189B9F880-0x0000000189B9F8A0
	protected override bool CanDoSprint() => default; // 0x00000001840FB950-0x00000001840FBA50
	// [XID] // 0x0000000189BA7130-0x0000000189BA7150
	protected virtual void DealSprintBS() {} // 0x00000001840FC7D0-0x00000001840FC990
	// [XID] // 0x0000000189BAE260-0x0000000189BAE280
	protected override void CalcMoveState() {} // 0x0000000184102C60-0x0000000184103020
	// [XID] // 0x0000000189BB5BB0-0x0000000189BB5BD0
	protected void StopSlip(bool sendSyncPac, bool drop) {} // 0x0000000184107EE0-0x00000001841081A0
	// [XID] // 0x0000000189BBD1B0-0x0000000189BBD1D0
	protected void SlipAdjustProcess(bool climbBack) {} // 0x00000001840F2640-0x00000001840F2B00
	// [XID] // 0x0000000189BC4DA0-0x0000000189BC4DC0
	protected virtual void CalcMoveStateAfterFixedDir() {} // 0x00000001841005E0-0x0000000184100DF0
	// [XID] // 0x0000000189BCC900-0x0000000189BCC920
	protected bool TryMoveForward(Vector3 targetPos, Vector3 forward) => default; // 0x00000001840FE3F0-0x00000001840FEC00
	// [XID] // 0x0000000189BD3F50-0x0000000189BD3F70
	protected bool AnimatorSlipping() => default; // 0x0000000184107B60-0x0000000184107DB0
	// [XID] // 0x0000000189BDB8B0-0x0000000189BDB8D0
	protected bool TryMoveDownward(Vector3 targetPos, Vector3 targetDir) => default; // 0x00000001840FCA80-0x00000001840FCC90
	// [XID] // 0x00000001895E8170-0x00000001895E8190
	protected override void DoMoveDownward(Vector3 hitPos, Vector3 hitNormal, Vector3 targetDir) {} // 0x00000001840F15F0-0x00000001840F1780
	// [XID] // 0x00000001895EFA40-0x00000001895EFA60
	protected override void DoMoveBackward(Vector3 hitPos, Vector3 hitNormal) {} // 0x00000001840FE0F0-0x00000001840FE250
	// [XID] // 0x00000001895F7470-0x00000001895F7490
	protected override int CalcRaycastResult(Vector3 hitPos, Vector3 hitNormal) => default; // 0x00000001840F0FF0-0x00000001840F1140
	// [XID] // 0x00000001895FE7D0-0x00000001895FE7F0
	protected override Ray GetDownwardRay(Vector3 targetPos) => default; // 0x00000001840F1B90-0x00000001840F1DD0
	// [XID] // 0x00000001896061B0-0x00000001896061D0
	protected override Ray GetGroundRay(Vector3 targetPos) => default; // 0x00000001840F35B0-0x00000001840F37D0
	// [XID] // 0x000000018960DA10-0x000000018960DA30
	public override void DoStop() {} // 0x00000001841047B0-0x0000000184104860
	// [XID] // 0x0000000189615210-0x0000000189615230
	protected override void DoSteer() {} // 0x00000001840FFD00-0x00000001840FFDB0
	// [XID] // 0x000000018961C8E0-0x000000018961C900
	protected override void SetAnimIdle() {} // 0x00000001840FCE20-0x00000001840FD160
	// [XID] // 0x0000000189623E60-0x0000000189623E80
	protected override void SetAnimMove() {} // 0x00000001840F73D0-0x00000001840F78C0
	// [XID] // 0x000000018962B5D0-0x000000018962B5F0
	protected void SetAnimIdleDoNotSendPacket() {} // 0x0000000184106C20-0x0000000184106D30
	// [XID] // 0x0000000189632D90-0x0000000189632DB0
	protected void SetAnimMoveDoNotSendPacket() {} // 0x00000001840FD1C0-0x00000001840FD5A0
	// [XID] // 0x000000018963A8D0-0x000000018963A8F0
	public override void OnAnimatorMove() {} // 0x00000001840F52B0-0x00000001840F61C0
	// [XID] // 0x0000000189641FB0-0x0000000189641FD0
	protected float GetAnimVelocityCoeff() => default; // 0x00000001840F7EA0-0x00000001840F7FA0
	// [XID] // 0x0000000189649820-0x0000000189649840
	protected override bool CheckDropUseStartSpeed() => default; // 0x00000001840F01A0-0x00000001840F0250
	// [XID] // 0x0000000189650F20-0x0000000189650F40
	protected override bool GetGroundNormalAndPosUseCapsuleCast(out Vector3 normal, out Vector3 hitPoint, out float hitDistance) {
		normal = default;
		hitPoint = default;
		hitDistance = default;
		return default;
	} // 0x00000001840F6B60-0x00000001840F6FB0
	// [XID] // 0x0000000189658670-0x0000000189658690
	protected virtual bool GetForwardHitNormalAndPos(Vector3 forward, float detectLength, out Vector3 normal, out Vector3 hitPoint) {
		normal = default;
		hitPoint = default;
		return default;
	} // 0x00000001840F2B00-0x00000001840F2FA0
	// [XID] // 0x000000018965FC60-0x000000018965FC80
	protected virtual Ray GetForwardRay(Vector3 forward) => default; // 0x00000001840F7C70-0x00000001840F7EA0
	// [XID] // 0x0000000189667740-0x0000000189667760
	protected Ray GetForwardRayFromHead(Vector3 forward) => default; // 0x0000000184102AF0-0x0000000184102C60
	// [XID] // 0x000000018966EF80-0x000000018966EFA0
	protected override void CalcCurrentGroundInfo() {} // 0x00000001841061F0-0x00000001841066A0
	// [XID] // 0x00000001896768B0-0x00000001896768D0
	protected override void MoveFollowReferenceSystem() {} // 0x00000001840FAEF0-0x00000001840FB570
	// [XID] // 0x000000018967E100-0x000000018967E120
	public void initFollowReferenceSystem() {} // 0x00000001840EFCB0-0x00000001840EFD70
	// [XID] // 0x00000001896858F0-0x0000000189685910
	protected override void CheckGroundReferenceSystem() {} // 0x0000000184103020-0x00000001841032B0
	// [XID] // 0x000000018968D270-0x000000018968D290
	protected bool CapsuleOverlaps(Vector3 p1, Vector3 p2, float radius) => default; // 0x00000001840EFFE0-0x00000001840F01A0
	// [XID] // 0x0000000189694EA0-0x0000000189694EC0
	protected bool SphereOverlaps(Vector3 center, float radius) => default; // 0x00000001840FDDC0-0x00000001840FDF40
	// [XID] // 0x000000018969C5D0-0x000000018969C5F0
	protected bool FindGroundByCombinedMethods(Vector3 capsuleP1, Vector3 capsuleP2, Vector3 sphereCenter, Vector3 rayStart, Vector3 direction, float radius, float length, out RaycastHit hit) {
		hit = default;
		return default;
	} // 0x00000001840F8370-0x00000001840F8B70
	// [XID] // 0x00000001896A3B70-0x00000001896A3B90
	private DevolutedCastMethod DeterminCastMethod(Vector3 capsuleP1, Vector3 capsuleP2, Vector3 sphereCenter, float radius) => default; // 0x0000000184108BF0-0x0000000184108D80
	// [XID] // 0x00000001896AAF00-0x00000001896AAF20
	protected virtual void MoveAlongSurface(Vector3 targetPos, Vector3 targetNormal, bool useTNorm = false /* Metadata: 0x00AEBC84 */) {} // 0x00000001840FC5C0-0x00000001840FC720
	// [XID] // 0x00000001896B2010-0x00000001896B2030
	private void UpdateCurrentMoveState(Vector3 targetPos, Vector3 targetNormal) {} // 0x00000001840FBE90-0x00000001840FC5C0
	// [XID] // 0x00000001896B9A80-0x00000001896B9AA0
	protected bool GetForwardHitNormalAndPosFromHead(Vector3 forward, float detectLength, out Vector3 normal, out Vector3 hitPoint, out float hitDistance) {
		normal = default;
		hitPoint = default;
		hitDistance = default;
		return default;
	} // 0x00000001840FB6F0-0x00000001840FB950
	// [XID] // 0x00000001896C0E60-0x00000001896C0E80
	private bool GetForwardHitNormalAndPosFromKnee(Vector3 forward, float detectLength, out Vector3 normal, out Vector3 hitPoint, out float hitDistance) {
		normal = default;
		hitPoint = default;
		hitDistance = default;
		return default;
	} // 0x00000001840F61C0-0x00000001840F6490
	// [XID] // 0x00000001896C8400-0x00000001896C8420
	protected bool GetForwardHitNormalAndPosFromWaist(Vector3 forward, float detectLength, out Vector3 normal, out Vector3 hitPoint, out float hitDistance) {
		normal = default;
		hitPoint = default;
		hitDistance = default;
		return default;
	} // 0x0000000184106790-0x0000000184106A90
	// [XID] // 0x00000001896CFDB0-0x00000001896CFDD0
	private bool GetForwardHitNormalAndPosFromFoot(Vector3 forward, float detectLength, out Vector3 normal, out Vector3 hitPoint, out float hitDistance) {
		normal = default;
		hitPoint = default;
		hitDistance = default;
		return default;
	} // 0x0000000184100DF0-0x0000000184101060
	// [XID] // 0x00000001896D7120-0x00000001896D7140
	private void ForceAnimIdle() {} // 0x00000001840F6490-0x00000001840F65D0
	// [XID] // 0x00000001896DE9D0-0x00000001896DE9F0
	protected void MoveAlongSlope() {} // 0x00000001840FC720-0x00000001840FC7D0
	// [XID] // 0x00000001896E5C80-0x00000001896E5CA0
	protected void GetTargetPosKeepAwayBody(Vector3 dir, out Vector3 targetPos) {
		targetPos = default;
	} // 0x00000001840FED20-0x00000001840FEE60
	// [XID] // 0x00000001896ED290-0x00000001896ED2B0
	protected Vector3 GetTargetPosByDirDist(Vector3 dir, float dist) => default; // 0x0000000184105CE0-0x00000001841061F0
	// [XID] // 0x00000001896F4B80-0x00000001896F4BA0
	protected bool IsUpHill(Vector3 targetPos) => default; // 0x00000001840FDC50-0x00000001840FDD30
	// [XID] // 0x00000001896FC2B0-0x00000001896FC2D0
	protected void TriggerDoDrop() {} // 0x00000001840F9440-0x00000001840F9500
	// [XID] // 0x0000000189703820-0x0000000189703840
	protected bool CheckCanMoveForward(Vector3 targetDir, Vector3 targetPos) => default; // 0x00000001840F6630-0x00000001840F6720
	// [XID] // 0x000000018970B090-0x000000018970B0B0
	protected override void Reset() {} // 0x00000001840F3390-0x00000001840F3550
	// [XID] // 0x0000000189712870-0x0000000189712890
	private float CalcTiltByYawDelta(float yawSpeed, float toDesiredYaw, float tiltCoeff) => default; // 0x00000001840FFDB0-0x00000001840FFFE0
	// [XID] // 0x000000018971A150-0x000000018971A170
	protected virtual void MoveUpdateTilt() {} // 0x0000000184108580-0x0000000184108BF0
	// [XID] // 0x00000001897214E0-0x0000000189721500
	private float AttenuationTitlt(bool inAttenuation, float titlt) => default; // 0x00000001840F0300-0x00000001840F0530
	// [XID] // 0x0000000189728AE0-0x0000000189728B00
	private float GetTitltCoeff() => default; // 0x00000001840FE010-0x00000001840FE0F0
	// [XID] // 0x0000000189730550-0x0000000189730570
	protected void UpdateHeadControl() {} // 0x00000001840FB570-0x00000001840FB6F0
	// [XID] // 0x0000000189737CB0-0x0000000189737CD0
	protected void ResetCline(HumanoidMoveFSM.FSMStateID nextState) {} // 0x0000000184106A90-0x0000000184106C20
	// [XID] // 0x000000018973F8A0-0x000000018973F8C0
	private void ClineOnSlope(Vector3 tPos, Vector3 tNorm) {} // 0x00000001840FD670-0x00000001840FD9A0
	// [XID] // 0x0000000189746D80-0x0000000189746DA0
	protected void SetAnimatorState(bool faceWall) {} // 0x00000001840F2FA0-0x00000001840F30D0
	// [XID] // 0x000000018974E610-0x000000018974E630
	protected void AdjustDirWhenSlip() {} // 0x00000001840F1DD0-0x00000001840F2240
	// [XID] // 0x0000000189755CC0-0x0000000189755CE0
	protected virtual bool CheckSlipToClimbUpstairBack(MoveSlope slope, out MoveResult _result) {
		_result = default;
		return default;
	} // 0x0000000184101450-0x0000000184101A10
	// [XID] // 0x000000018975CF40-0x000000018975CF60
	private void AdjustVelocity(bool climbBack) {} // 0x00000001841032B0-0x00000001841034C0
	// [XID] // 0x0000000189764760-0x0000000189764780
	private bool ShouldAccelerate() => default; // 0x0000000184101CE0-0x0000000184101EF0
	// [XID] // 0x000000018976C1C0-0x000000018976C1E0
	private bool ShouldDecelerate() => default; // 0x0000000184102890-0x0000000184102AF0
	// [XID] // 0x0000000189773580-0x00000001897735A0
	private void DoAccelerate() {} // 0x0000000184102150-0x0000000184102440
	// [XID] // 0x000000018977AD50-0x000000018977AD70
	private void DoDecelerate() {} // 0x00000001840F22A0-0x00000001840F2640
	// [XID] // 0x00000001897828E0-0x0000000189782900
	private void RemoveOffSurfaceVelocity(Vector3 alongSlopeVelocity) {} // 0x0000000184101060-0x0000000184101450
	// [XID] // 0x0000000189789B50-0x0000000189789B70
	private void SetCline(float slope, float speed) {} // 0x00000001841078F0-0x0000000184107B60
	// [XID] // 0x0000000189791370-0x0000000189791390
	public bool IsInGoUpstairs() => default; // 0x0000000184101A70-0x0000000184101B20
	// [XID] // 0x0000000189798AF0-0x0000000189798B10
	protected virtual void TriggerGoUpstairs(Vector3 hitPoint, Vector3 hitNormal) {} // 0x00000001840F9500-0x00000001840F9720
	// [XID] // 0x00000001897A0910-0x00000001897A0930
	protected bool CheckIsStep(Vector3 targetPos, Vector3 forward, out bool isStepHit, out Vector3 stepHitNormal, out Vector3 stepHitPos, out bool isFootHit, out Vector3 footHitNormal, out Vector3 footHitPos, out bool isHeadHit, out Vector3 headHitNormal, out bool isBodyHit, out Vector3 bodyHitNormal, out Vector3 bodyHitPos, bool fromDrop) {
		isStepHit = default;
		stepHitNormal = default;
		stepHitPos = default;
		isFootHit = default;
		footHitNormal = default;
		footHitPos = default;
		isHeadHit = default;
		headHitNormal = default;
		isBodyHit = default;
		bodyHitNormal = default;
		bodyHitPos = default;
		return default;
	} // 0x0000000184109380-0x000000018410A370
	// [XID] // 0x00000001897A7F80-0x00000001897A7FA0
	protected bool IsInJumpUpWallForStandby() => default; // 0x00000001840F0250-0x00000001840F0300
	// [XID] // 0x00000001897AFA60-0x00000001897AFA80
	private void PromptTransfer2Climb(Vector3 hitPos, Vector3 cliffPos, Vector3 hitNormal) {} // 0x00000001840F18D0-0x00000001840F1B90
	// [XID] // 0x00000001897B7830-0x00000001897B7850
	protected override void CloseToGround() {} // 0x0000000184109140-0x0000000184109380
	// [XID] // 0x00000001897BF740-0x00000001897BF760
	protected void CloseToGroundSync() {} // 0x00000001841081A0-0x0000000184108580
	// [XID] // 0x00000001897C6E90-0x00000001897C6EB0
	protected float SpringSystem1D_Accurate(float fromP, float toP, float deltaT) => default; // 0x00000001840FBB40-0x00000001840FBD40
	// [XID] // 0x00000001897CE4A0-0x00000001897CE4C0
	protected bool CheckIsCliffKeepAwayBody(Vector3 targetDir, out Vector3 hitNormal, out Vector3 hitPos, out Vector3 cliffPos) {
		hitNormal = default;
		hitPos = default;
		cliffPos = default;
		return default;
	} // 0x0000000184104420-0x00000001841045A0
	// [XID] // 0x00000001897D5B50-0x00000001897D5B70
	protected bool CheckIsCliff(Vector3 targetDir, Vector3 targetPos, out Vector3 hitNormal, out Vector3 hitPos, out Vector3 cliffPos) {
		hitNormal = default;
		hitPos = default;
		cliffPos = default;
		return default;
	} // 0x0000000184101FC0-0x0000000184102150
	// [XID] // 0x00000001897DD2D0-0x00000001897DD2F0
	protected virtual bool CheckIsCliffImp(Vector3 targetDir, Vector3 targetPos, out Vector3 hitNormal, out Vector3 hitPos, out Vector3 cliffPos, bool modifyDir) {
		hitNormal = default;
		hitPos = default;
		cliffPos = default;
		return default;
	} // 0x00000001840F3830-0x00000001840F4E50
	// [XID] // 0x00000001897E4B00-0x00000001897E4B20
	private bool IsInRun2Idle() => default; // 0x00000001840F8280-0x00000001840F8370
	// [XID] // 0x00000001897EC7B0-0x00000001897EC7D0
	private bool IsInRun2Walk() => default; // 0x00000001840FC990-0x00000001840FCA80
	// [XID] // 0x00000001897F40A0-0x00000001897F40C0
	public bool IsInIdleTag() => default; // 0x00000001840F80D0-0x00000001840F81C0
	// [XID] // 0x00000001897FBAC0-0x00000001897FBAE0
	public bool IsInRunTag() => default; // 0x00000001840FDA00-0x00000001840FDC50
	// [XID] // 0x0000000189802F90-0x0000000189802FB0
	protected bool IsInSprintTag() => default; // 0x00000001840F0DA0-0x00000001840F0FF0
	// [XID] // 0x000000018980A420-0x000000018980A440
	private bool IsInSprint2Idle() => default; // 0x0000000184105BF0-0x0000000184105CE0
	// [XID] // 0x0000000189811B80-0x0000000189811BA0
	private bool IsInRunZone() => default; // 0x00000001840FBA50-0x00000001840FBB40
	// [XID] // 0x0000000189819870-0x0000000189819890
	public bool IsInSprintZone() => default; // 0x00000001840F8BE0-0x00000001840F8CD0
	// [XID] // 0x0000000189820F70-0x0000000189820F90
	private bool IsInRunOrSprintZone() => default; // 0x00000001840F30D0-0x00000001840F31A0
	// [XID] // 0x0000000189828520-0x0000000189828540
	private bool IsWalkZone() => default; // 0x00000001840F1780-0x00000001840F1870
	// [XID] // 0x000000018982F7B0-0x000000018982F7D0
	protected bool IsInFalltoGroundRun() => default; // 0x00000001840F06E0-0x00000001840F0930
	// [XID] // 0x00000001898370F0-0x0000000189837110
	protected bool TriggerDropForNoGroundBeneath() => default; // 0x00000001840F9910-0x00000001840F9E30
	// [XID] // 0x000000018983E610-0x000000018983E630
	protected void TriggerDropForCliffInFront(Vector3 targetDir, Vector3 targetPos) {} // 0x00000001840FF400-0x00000001840FF7B0
	// [XID] // 0x0000000189845CD0-0x0000000189845CF0
	protected override bool CheckSwim() => default; // 0x00000001840FFFE0-0x0000000184100170
	// [XID] // 0x000000018984D260-0x000000018984D280
	public bool IsMoveOnWater() => default; // 0x0000000184104370-0x0000000184104420
	// [XID] // 0x0000000189854330-0x0000000189854350
	protected override void FrozenCharacterProcess() {} // 0x00000001840F0930-0x00000001840F0BB0
	// [XID] // 0x000000018985BCE0-0x000000018985BD00
	protected override void FreezeCharacter() {} // 0x00000001840F1480-0x00000001840F15F0
	// [XID] // 0x00000001898633E0-0x0000000189863400
	protected override void UnFreezeCharacter() {} // 0x0000000184100170-0x0000000184100580
	// [XID] // 0x000000018986A830-0x000000018986A850
	protected void MoveFollowReferenceSystemSync() {} // 0x00000001840F9720-0x00000001840F9910
	// [XID] // 0x0000000189871CB0-0x0000000189871CD0
	public override void SyncLateTick() {} // 0x0000000184102520-0x00000001841027B0
	// [XID] // 0x0000000189879480-0x00000001898794A0
	protected void ProcessCurrentMoveTask() {} // 0x00000001841048D0-0x0000000184105BF0
	// [XID] // 0x0000000189880AD0-0x0000000189880AF0
	protected void MoveAcrossDifferentRefferenceSystem(bool SetPositionWhenNochange = false /* Metadata: 0x00AEBC85 */, bool SetRotationWhenNochange = false /* Metadata: 0x00AEBC86 */) {} // 0x00000001840F8F30-0x00000001840F9440
	// [XID] // 0x0000000189887EC0-0x0000000189887EE0
	protected override void StayInPlace() {} // 0x00000001840F0530-0x00000001840F06E0
	// [XID] // 0x000000018988F400-0x000000018988F420
	protected virtual void DealMoveResultSync() {} // 0x00000001840EFD70-0x00000001840EFFE0
	// [XID] // 0x0000000189896940-0x0000000189896960
	protected void ProcessToOtherSyncState(Vector3 syncTargetDir) {} // 0x00000001840F4E50-0x00000001840F52B0
	// [XID] // 0x000000018989DE10-0x000000018989DE30
	protected virtual void TransferToOtherSyncState() {} // 0x0000000184106D30-0x00000001841078F0
	// [IDTag] // 0x00000001898A5790-0x00000001898A57D0
	// [XID] // 0x00000001898A5790-0x00000001898A57D0
	protected void SetAnimSync(MotionState motionState) {} // 0x00000001840F1340-0x00000001840F1480
	// [IDTag] // 0x00000001898AFEB0-0x00000001898AFEF0
	// [XID] // 0x00000001898AFEB0-0x00000001898AFEF0
	protected void SetAnimSync(VCMoveData.MotionFlag motionFlag) {} // 0x00000001840F1240-0x00000001840F1340
	// [XID] // 0x00000001898BAA20-0x00000001898BAA40
	protected void CheckSetTriggerForSyncDashMotionFlag(VCMoveData.MotionFlag motionFlag) {} // 0x00000001840F78C0-0x00000001840F7AD0
	// [XID] // 0x00000001898C1BD0-0x00000001898C1BF0
	protected override MotionState GetCurrentSyncMotionState() => default; // 0x00000001840F0BB0-0x00000001840F0CF0
	// [XID] // 0x00000001898C9580-0x00000001898C95A0
	private MotionState GetCurrentSyncMotionStateForceIce() => default; // 0x00000001840FBD40-0x00000001840FBE20
	// [XID] // 0x00000001898D0E40-0x00000001898D0E60
	protected virtual MotionState GetRawCurrentSyncMotionState() => default; // 0x00000001840F6A10-0x00000001840F6B60
	// [XID] // 0x00000001898D83A0-0x00000001898D83C0
	protected VCMoveData.MotionFlag ProtoMotion2MotionFlag(MotionState motionState) => default; // 0x0000000184102440-0x0000000184102520
	// [XID] // 0x00000001898E0260-0x00000001898E0280
	protected override void GetLastPacketMotion() {} // 0x00000001841066A0-0x0000000184106790
	// [XID] // 0x00000001898E7D80-0x00000001898E7DA0
	protected virtual void CalcMoveStateSync() {} // 0x00000001840F7020-0x00000001840F73D0
	// [XID] // 0x00000001898EF4A0-0x00000001898EF4C0
	public override void CreateSyncTaskByTimeInterval() {} // 0x00000001840FCC90-0x00000001840FCE20
		P0 = default;
		P1 = default;
		P2 = default;
		return default;
	} // 0x00000001840FDD30-0x00000001840FDDC0
}

