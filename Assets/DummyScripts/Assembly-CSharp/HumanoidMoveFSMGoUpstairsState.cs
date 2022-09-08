/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HumanoidMoveFSMGoUpstairsState : HumanoidMoveFSMMoveState // TypeDefIndex: 14667
{
	// Fields
	private Dictionary<int, PoseParameter> _upstairPoses; // 0x1D8
	private bool _needCloseToGroundWhenGoUpstairs; // 0x1E0
	private bool _closeToGroundWaitNextFrame; // 0x1E1
	private bool _needRotateWhenGoUpstairs; // 0x1E2
	private const float GO_UPSTARIS_ROTATE_RATIO = 0.17453292f; // Metadata: 0x00AEBBEC
	private const float FORM_CLIMB_UPSTAIR_ACCURACY = 0.02f; // Metadata: 0x00AEBBF0
	private const float FORM_CLIMB_UPSTAIR_ADDITIONAL_FROWARD = 0.05f; // Metadata: 0x00AEBBF4
	private const float TARGET_POINT_SPHERE_CAST_TEST_MAX_VARIATION = 0.4f; // Metadata: 0x00AEBBF8
	private const float JUMP_UP_STAIRS_EXTRA_TIME_RATIO = 0.5f; // Metadata: 0x00AEBBFC
	private bool _activateBlendSpeed; // 0x1E3
	private float _activateBlendStartGoUpTime; // 0x1E4
	private float _animatorDistUp; // 0x1E8
	private float _animatorDistForward; // 0x1EC
	private Quaternion _animatorDeltaRotation; // 0x1F0
	private Vector3 _animatorDeltaPosition; // 0x200
	private const float LONG_MOVE_RATIO = 0.6f; // Metadata: 0x00AEBC00
	private const float MID_MOVE_RATIO = 0.3f; // Metadata: 0x00AEBC04
	private const float REACH_UP_EXTRA_DIST = 0.1875f; // Metadata: 0x00AEBC08
	private const float JUMP_UPSTAIR_LIGHT_REACH_UP_EXTRA_DIST = 0.3f; // Metadata: 0x00AEBC0C
	private const float BLEND_ANGLE_MAX_VALUE = 40f; // Metadata: 0x00AEBC10
	private const float MIN_GO_FORWARD_TIME = 0.02f; // Metadata: 0x00AEBC14
	private const float FORCE_GO_FORWARD_TIME = 0.07f; // Metadata: 0x00AEBC18
	private const float HEIGHT_MAP_HEIGHT_MAX_DIFF = 0.2f; // Metadata: 0x00AEBC1C
	private Vector3 _targetPosition; // 0x20C
	private Vector3 _targetPositionWithLROffset; // 0x218
	private Vector3 _forward; // 0x224
	private Vector3 _up; // 0x230
	private bool _distanceSet; // 0x23C
	private bool _closeToGround; // 0x23D
	private bool _enableMove; // 0x23E
	private bool _reachUp; // 0x23F
	private float _upDist; // 0x240
	private float _remainDistanceUp; // 0x244
	private float _remainDistanceForward; // 0x248
	private float _goForwardTime; // 0x24C
	private UpstairPose _pose; // 0x250
	private float _jumpUpVelocity; // 0x254
	private float _jumpUpAcceleration; // 0x258
	private float _forwardAnimatorMoveRatio; // 0x25C
	private float _upAnimatorMoveRatio; // 0x260
	private float _lastTime; // 0x264
	private float _RotationAngle; // 0x268
	private float _Rotated; // 0x26C
	private float _DeltaAngle; // 0x270
	private float _pose2; // 0x274
	private float _jumpUpstairsLastUpDist; // 0x278
	private float _jumpUpstairsLastForwardDist; // 0x27C
	private float _jumpUpstairsExtraTime; // 0x280
	private Vector3 _GoUpstairsOffsetVector; // 0x284
	private Vector3 _GoLROffsetVector; // 0x290
	private float _50BlendPose; // 0x29C
	private bool _leftIK; // 0x2A0
	private bool _rightIK; // 0x2A1
	private bool _mirrorIK; // 0x2A2
	private Vector3 _preMoveDir; // 0x2A4
	private float _preMoveDist; // 0x2B0
	private float _preMoveDistMoved; // 0x2B4
	private float _preMoveVelocity; // 0x2B8
	private PreviousPose _previousPose; // 0x2BC
	private const float JUMP_UP_STAIRS_EXTRA_UP_MOVE_TIME_RATIO = 0.3f; // Metadata: 0x00AEBC20
	private int runZoneName; // 0x2C0
	private int goupstairsMirrorZoneName; // 0x2C4
	private int mirrorParam; // 0x2C8
	public float testThreshold; // 0x2CC
	private bool _reachFirstDifferentSyncMotion; // 0x2D0
	private bool _waitingGoupstairsSyncMotition; // 0x2D1

	// Nested types
	public enum PreviousPose // TypeDefIndex: 14668
	{
		Move = 0,
		Climb = 1,
		Air = 2,
		Swim = 3,
		Ladder = 4,
		ClimbDown = 5
	}

	public enum UpstairPose // TypeDefIndex: 14669
	{
		ClimbToStandbyLight = 0,
		JumpUpstairs = 1,
		ClimbToStandbyMiddle = 2,
		ClimbToStandby50Middle = 3,
		ClimbToStandbyHard = 4,
		ClimbToStandby50Hard = 5,
		ClimbtoStandbyGentle = 6
	}

	[Serializable]
	public struct PoseParameter // TypeDefIndex: 14670
	{
		// Fields
		public float length; // 0x00
		public float startRotate; // 0x04
		public float endRotate; // 0x08
		public float closeToGround; // 0x0C
		public float enableMove; // 0x10
		public float enableLeftFootIK; // 0x14
		public float enableRightFootIK; // 0x18
		public float animatorPose; // 0x1C
		public float distUp; // 0x20
		public float distForward; // 0x24
		public bool enable50Blend; // 0x28

		// Methods
		// [XID] // 0x00000001898E96B0-0x00000001898E96D0
		public void init() {} // 0x0000000183144A60-0x0000000183144B10
	}

	// Constructors
	public HumanoidMoveFSMGoUpstairsState() {} // Dummy constructor
	public HumanoidMoveFSMGoUpstairsState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x00000001834A91A0-0x00000001834A9580

	// Methods
	// [XID] // 0x00000001897EC7D0-0x00000001897EC7F0
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x00000001834A46F0-0x00000001834A7B70
	// [XID] // 0x00000001897FBAE0-0x00000001897FBB00
	private void DoPreMove(float time) {} // 0x00000001834A36D0-0x00000001834A39F0
	// [XID] // 0x0000000189802FB0-0x0000000189802FD0
	public void OnGoUpstairsEnd() {} // 0x000000018349FA60-0x000000018349FBD0
	// [XID] // 0x000000018980A440-0x000000018980A460
	private bool IsInGoUpstairsTag() => default; // 0x000000018349EC60-0x000000018349EDC0
	// [XID] // 0x0000000189811BA0-0x0000000189811BC0
	public override void TrySteer(bool isMoving, float joystickAngle) {} // 0x00000001834A8E60-0x00000001834A9030
	// [XID] // 0x0000000189819890-0x00000001898198B0
	public void BeginCloseToGroundWhenGoUpstairs() {} // 0x00000001834A1BA0-0x00000001834A1C40
	// [XID] // 0x0000000189820F90-0x0000000189820FB0
	public void BeginRotateWhenGoUpstairs() {} // 0x00000001834A0770-0x00000001834A0810
	// [XID] // 0x0000000189828540-0x0000000189828560
	public override void OnAnimatorMove() {} // 0x000000018349F680-0x000000018349FA60
	// [XID] // 0x000000018982F7D0-0x000000018982F7F0
	public override void LateTick() {} // 0x00000001834A3220-0x00000001834A36D0
	// [XID] // 0x0000000189837110-0x0000000189837130
	private void CalcGoUpstairsMoveFadeDown(float normalizedTime) {} // 0x00000001834A1C40-0x00000001834A2650
	// [XID] // 0x000000018983E630-0x000000018983E650
	private void EnableMove() {} // 0x00000001834A26F0-0x00000001834A2870
	// [XID] // 0x0000000189845CF0-0x0000000189845D10
	private void CalcGoUpstairsMoveFaceUp(float normalizedTime) {} // 0x000000018349FBD0-0x00000001834A0770
	// [XID] // 0x000000018984D280-0x000000018984D2A0
	private float GetJumpUpstairsSimulatedTime(float normalizedTime) => default; // 0x00000001834A2930-0x00000001834A2B20
	// [XID] // 0x0000000189854350-0x0000000189854370
	private void CalcGoUpstairsMoveJumpUpstairs(float normalizedTime) {} // 0x00000001834A0810-0x00000001834A14E0
	// [XID] // 0x000000018985BD00-0x000000018985BD20
	private void CalcGoUpstairsMove(float normalizedTime) {} // 0x000000018349EFD0-0x000000018349F300
	// [XID] // 0x0000000189863400-0x0000000189863420
	protected override void CloseToGround() {} // 0x00000001834A9030-0x00000001834A91A0
	// [XID] // 0x000000018986A850-0x000000018986A870
	protected override void Reset() {} // 0x000000018349F490-0x000000018349F5C0
	// [XID] // 0x0000000189871CD0-0x0000000189871CF0
	private void SetPose(Animator animator) {} // 0x00000001834A8610-0x00000001834A8D90
	// [XID] // 0x00000001898794A0-0x00000001898794C0
	private float CalDistance() => default; // 0x00000001834A14E0-0x00000001834A1980
	// [XID] // 0x0000000189880AF0-0x0000000189880B10
	private void SetDistanceJumpUpstairs() {} // 0x00000001834A3B40-0x00000001834A3CA0
	// [XID] // 0x0000000189887EE0-0x0000000189887F00
	private void CheckLeftRightDist() {} // 0x00000001834A2B20-0x00000001834A3110
	// [XID] // 0x000000018988F420-0x000000018988F440
	private void SetDistance() {} // 0x00000001834A7E70-0x00000001834A8540
	// [XID] // 0x0000000189896960-0x0000000189896980
	private void SetDistanceWhenActivateBlend() {} // 0x00000001834A3CA0-0x00000001834A3FE0
	// [XID] // 0x000000018989DE30-0x000000018989DE50
	protected override void MoveFollowReferenceSystem() {} // 0x00000001834A1980-0x00000001834A1BA0
	// [XID] // 0x00000001898A57D0-0x00000001898A57F0
	public override bool EnableMoveIK(IKBodySide bodySide) => default; // 0x00000001834A8540-0x00000001834A8610
	// [XID] // 0x00000001898ACCE0-0x00000001898ACD00
	private bool CheckOutToMoveState() => default; // 0x00000001834A7B70-0x00000001834A7DF0
	// [XID] // 0x00000001898B4270-0x00000001898B4290
	public override void Exit(HumanoidMoveFSM.FSMStateID nextState) {} // 0x00000001834A45C0-0x00000001834A4690
	// [XID] // 0x00000001898BC030-0x00000001898BC050
	private void RotateAvatar(float angle) {} // 0x00000001834A39F0-0x00000001834A3B40
	// [XID] // 0x00000001898C3410-0x00000001898C3430
	protected override void FrozenCharacterProcess() {} // 0x000000018349EDC0-0x000000018349EE60
	// [XID] // 0x00000001898CAD90-0x00000001898CADB0
	protected override void FreezeCharacter() {} // 0x000000018349EF00-0x000000018349EFD0
	// [XID] // 0x00000001898D24B0-0x00000001898D24D0
	public override void SyncLateTick() {} // 0x00000001834A3FE0-0x00000001834A45C0
	// [XID] // 0x00000001898D9DF0-0x00000001898D9E10
	protected override MotionState GetCurrentSyncMotionState() => default; // 0x000000018349EE60-0x000000018349EF00
	// [XID] // 0x00000001898E1980-0x00000001898E19A0
	public override void CreateSyncTaskByTimeInterval() {} // 0x00000001834A2650-0x00000001834A26F0
}

