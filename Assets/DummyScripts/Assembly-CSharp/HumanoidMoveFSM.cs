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
using motion4hi;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HumanoidMoveFSM : BaseComponentPlugin // TypeDefIndex: 12050
{
	// Fields
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private HumanoidMoveFSMBaseMoveState _curState; // 0x58
	public int fallOnGroundFirstFrame; // 0x60
	public Dictionary<FSMStateID, HumanoidMoveFSMBaseMoveState> stateMapInfo; // 0x68
	private VCHumanoidMoveData _moveData; // 0x70
	private VCHumanoidMoveConfig _moveConfig; // 0x78
	private VCHumanoidMove _ownerMove; // 0x80
	private Animator _animator; // 0x88
	private Rigidbody _rigidbody; // 0x90
	private AnimatorController _animatorController; // 0x98
	public Action<HumanoidMoveFSMCallBackInfo> OnMoveUpdateCallback; // 0xA0
	public Action<HumanoidMoveFSMCallBackInfo> OnAirUpdateCallback; // 0xA8
	private bool _initSyncWithCurrentTask; // 0xB0
	private bool _behaviourSet; // 0xB1
	private float _sendCombatNotifyTime; // 0xB4
	private const float SEND_COMBAT_NOTIFY_INTERVAL = 1f; // Metadata: 0x00AEB3EC
	public bool enterSprintBS; // 0xB8
	private Transform _transform; // 0xC0
	public float climbGlobalRecovery; // 0xC8
	public const float CLIMB_GLOBAL_RECOVERY_TIME = 0.5f; // Metadata: 0x00AEB3F0
	public bool autoGoUpstair; // 0xCC
	public bool forceDoNotSyncWhenReset; // 0xCD
	public const float STOP_PRESSING_KEEP_SPRINT_TIME = 0.3f; // Metadata: 0x00AEB3F4
	public float inSprintTime; // 0xD0
	private int _lastCurrentStateHash; // 0xD4
	private int _lastNextStateHash; // 0xD8
	private bool _firstLatetick; // 0xDC
	private bool _lastInForbiddenToggleMoveState; // 0xDD
	private bool _disableMotion4hiUpdateCurrentFrame; // 0xDE
	public static int[] motionStateWorldShiftMap; // 0x00
	private static bool _motionStateWorldShiftMapInitialized; // 0x08
	public static List<MotionState>[] motionStateWorldShiftList; // 0x10
	private int _flyStateHash; // 0xE0
	private static int _standbyHash; // 0x18
	private static int _showUp; // 0x1C
	private static int _sitLoop; // 0x20
	private static int _sitBLoop; // 0x24
	private static int _standbyWeaponHash; // 0x28
	private static int _SkirtIKBlendParam; // 0x2C
	public static int idleHash; // 0x30
	public static int walkHash; // 0x34
	public static int runHash; // 0x38
	public static int sprintHash; // 0x3C
	public static int leftJumpHash; // 0x40
	public static int prepareClimbHash; // 0x44
	public static int toStopHash; // 0x48
	public static int climbIKHash; // 0x4C
	private VCMoveIKController _ikComp; // 0xE8
	private Transform _lCalf; // 0xF0
	private Transform _rCalf; // 0xF8
	private VCHumanoidMove.StandbyIKParams _weaponStandbyIKParams; // 0x100
	private VCHumanoidMove.StandbyIKParams _normalStandbyIKParams; // 0x114
	private VCHumanoidMove.StandbyIKParams _params; // 0x128
	private const int STANDBY_IK_LAYER = 3; // Metadata: 0x00AEB3F8
	private float _lastSkirtBlendParam; // 0x13C
	private float _idealSkirtBlendParam; // 0x140
	private float _lastIdealSkirtBlendParam; // 0x144
	private float _lastSkirtWeight; // 0x148
	private float _idealSkirtWeight; // 0x14C
	private float _lastSkirtPos; // 0x150
	private float _idealSkirtPos; // 0x154
	private const float LAYER_WEIGHT_CHANGE_SPEED = 10f; // Metadata: 0x00AEB3FC
	private const float LEFT_RIGHT_BLEND_PARAM_CHANGE_SPEED = 6f; // Metadata: 0x00AEB400
	private const float ANIM_POS_CHANGE_SPEED = 1f; // Metadata: 0x00AEB404
	private bool _isInSprintCheckInterval; // 0x158
	private bool _isInMuteSprintInterval; // 0x159
	private float _timeAfterLastSprint; // 0x15C

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001897EE080-0x00000001897EE0A0 */ get => default; } // 0x000000018153B870-0x000000018153B910 
	public bool positionRotationChanged { /* [XID] */ /* 0x00000001897F57C0-0x00000001897F5800 */ get; /* [XID] */ /* 0x0000000189800060-0x00000001898000A0 */ private set; } // 0x000000018152FD60-0x000000018152FDC0 0x0000000181535FC0-0x0000000181536030

	// Nested types
	public enum FSMStateID // TypeDefIndex: 12051
	{
		Move = 0,
		TurnDirection = 1,
		FallOnGround = 2,
		GoUpstairs = 3,
		JumpUpWallReady = 4,
		Climb = 5,
		JumpUpWallForStandby = 6,
		StandbyToClimb = 7,
		Jump = 8,
		Drop = 9,
		Fly = 10,
		CombatMove = 11,
		CombatFallOnGround = 12,
		CombatAir = 13,
		Swim = 14,
		SwimJump = 15,
		Ladder = 16,
		FlyGateLoading = 17,
		Crouch = 18,
		Perform = 19,
		Null = 20,
		FlyFollowRoute = 21
	}

	public class EnumComparer_FSMStateID : IEqualityComparer<FSMStateID> // TypeDefIndex: 12052
	{
		// Constructors
		public EnumComparer_FSMStateID() {} // 0x0000000184521BF0-0x0000000184521C50

		// Methods
		// [XID] // 0x0000000189B02500-0x0000000189B02520
		public bool Equals(FSMStateID x, FSMStateID y) => default; // 0x0000000184521A70-0x0000000184521B40
		// [XID] // 0x0000000189B09AE0-0x0000000189B09B00
		public int GetHashCode(FSMStateID x) => default; // 0x0000000184521B40-0x0000000184521BF0
	}

	// Constructors
	public HumanoidMoveFSM() {} // Dummy constructor
	public HumanoidMoveFSM(VCHumanoidMove vcHumanoidMove) {} // 0x000000018153B590-0x000000018153B870
	static HumanoidMoveFSM() {} // 0x000000018153B100-0x000000018153B590

	// Methods
	// [XID] // 0x000000018980A560-0x000000018980A580
	public void InitMotionStateWorldShiftMap() {} // 0x0000000181539830-0x0000000181539BA0
	// [XID] // 0x0000000189811CC0-0x0000000189811CE0
	private void BuildStateMap(VCHumanoidMove vcHumanoidMove) {} // 0x0000000181532BD0-0x0000000181533340
	// [XID] // 0x000000018970FE10-0x000000018970FE30
	public void ResetFSM(bool resetAnimator = true /* Metadata: 0x00AEB3E5 */, bool forceDoNotSync = true /* Metadata: 0x00AEB3E6 */, bool needPlayShowup = false /* Metadata: 0x00AEB3E7 */, int playSitDownId = 0 /* Metadata: 0x00AEB3E8 */) {} // 0x00000001815311E0-0x0000000181531B00
	// [XID] // 0x0000000189BA1360-0x0000000189BA1380
	public void ResetFSMEnterFlyGateLoadingState() {} // 0x0000000181532060-0x0000000181532410
	// [XID] // 0x0000000189828640-0x0000000189828660
	public void ResetFSMEnterFlyFollowRouteState() {} // 0x000000018152F140-0x000000018152F2E0
	// [XID] // 0x000000018976C3E0-0x000000018976C400
	public void ResetFSMKeepMajorAnimatorState() {} // 0x0000000181536100-0x0000000181536A60
	// [XID] // 0x0000000189A15360-0x0000000189A15380
	public void SetNextState(FSMStateID nextStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x0000000181538960-0x0000000181539220
	// [XID] // 0x0000000189AE1610-0x0000000189AE1630
	public bool CanInitFsmStateWithSyncTask(ref MoveSyncTask syncTask) => default; // 0x0000000181539D20-0x0000000181539EB0
	// [XID] // 0x000000018984D360-0x000000018984D380
	public bool InitFsmStateWithSyncTask(ref MoveSyncTask syncTask, bool setPosition) => default; // 0x0000000181532550-0x0000000181532820
	// [XID] // 0x0000000189854450-0x0000000189854470
	public void FixedTick() {} // 0x0000000181532820-0x0000000181532930
	// [XID] // 0x000000018985BDC0-0x000000018985BDE0
	private void initStandbySkirtIK(VCHumanoidMove owner) {} // 0x0000000181534D00-0x0000000181534F40
	// [XID] // 0x00000001898634A0-0x00000001898634C0
	private void CalcStandbySkirtIK(float deltaTime) {} // 0x0000000181534170-0x0000000181534AB0
	// [XID] // 0x000000018986A970-0x000000018986A990
	private void UpdateSkirtParamsAndSetAnimator(float deltaTime) {} // 0x0000000181530030-0x00000001815303D0
	// [XID] // 0x0000000189871D70-0x0000000189871D90
	public override void LateTick(float deltaTime) {} // 0x0000000181536A60-0x0000000181538960
	// [XID] // 0x0000000189879580-0x00000001898795A0
	public override void OnDisable() {} // 0x000000018153A650-0x000000018153A740
	// [XID] // 0x0000000189880C10-0x0000000189880C30
	public void DisableMotion4hiUpdateCurrentFrame() {} // 0x000000018152FCC0-0x000000018152FD60
	// [XID] // 0x0000000189AA19B0-0x0000000189AA19D0
	public void ResetBehaviour() {} // 0x0000000181530B50-0x0000000181530CE0
	// [XID] // 0x000000018988F540-0x000000018988F560
	public override void Destroy() {} // 0x0000000181530A70-0x0000000181530B50
	// [IDTag] // 0x0000000189896AC0-0x0000000189896B00
	// [XID] // 0x0000000189896AC0-0x0000000189896B00
	public void TrySteer(bool isMoving, float joystickAngle) {} // 0x000000018153AF50-0x000000018153B040
	// [IDTag] // 0x00000001898A0E50-0x00000001898A0E90
	// [XID] // 0x00000001898A0E50-0x00000001898A0E90
	public void TrySteer(Vector3 targetDir) {} // 0x000000018153AE60-0x000000018153AF50
	// [XID] // 0x00000001898AB360-0x00000001898AB380
	public void TryFreeze() {} // 0x0000000181531E60-0x0000000181531F40
	// [XID] // 0x00000001898B2C80-0x00000001898B2CA0
	public void TryUnfreeze() {} // 0x0000000181532A30-0x0000000181532B10
	// [XID] // 0x00000001896D73C0-0x00000001896D73E0
	public void TryStop() {} // 0x000000018152F2E0-0x000000018152F3A0
	// [XID] // 0x00000001896ED4C0-0x00000001896ED4E0
	public void DoStop() {} // 0x0000000181539BA0-0x0000000181539C80
	// [XID] // 0x00000001898C9700-0x00000001898C9720
	public void DoJump() {} // 0x0000000181535EE0-0x0000000181535FC0
	// [XID] // 0x00000001898D0FC0-0x00000001898D0FE0
	public void DoTurnDir(Vector3 turnTargetPos) {} // 0x000000018153AA90-0x000000018153ABE0
	// [XID] // 0x0000000189B422F0-0x0000000189B42310
	public void TryCrouch() {} // 0x0000000181533B00-0x0000000181533BE0
	// [XID] // 0x00000001896726B0-0x00000001896726D0
	public void EnterFlyFixTargetMode(Vector3 targetPosition, float velocity) {} // 0x00000001815339C0-0x0000000181533B00
	// [XID] // 0x00000001898E7F40-0x00000001898E7F60
	public void ExitFlyFixTargetMode() {} // 0x000000018153A740-0x000000018153A820
	// [XID] // 0x00000001895F76B0-0x00000001895F76D0
	public void ForceAirStateFly() {} // 0x0000000181531040-0x0000000181531120
	// [XID] // 0x00000001897648E0-0x0000000189764900
	public void SetMotionFlag(VCMoveData.MotionFlag moveState) {} // 0x000000018152FC00-0x000000018152FCC0
	// [XID] // 0x00000001898FE640-0x00000001898FE660
	public void SwitchMotionFlag() {} // 0x00000001815307B0-0x0000000181530900
	// [XID] // 0x0000000189905D60-0x0000000189905D80
	public bool IsInAirState() => default; // 0x0000000181531D20-0x0000000181531E60
	// [XID] // 0x000000018990D760-0x000000018990D780
	public bool IsInAirStateOrFallOnGroundFirstFrame() => default; // 0x0000000181535AC0-0x0000000181535C00
	// [XID] // 0x0000000189920FB0-0x0000000189920FD0
	public bool IsInFlyState() => default; // 0x0000000181533900-0x00000001815339C0
	// [XID] // 0x000000018991CAB0-0x000000018991CAD0
	public void SetFlyControlType(HumanoidMoveFSMFlyState.FlyControlType type, Vector3 dir, Vector3 eularRawInput, float velocityScale, float backVelocityScale) {} // 0x000000018153ABE0-0x000000018153ADB0
	// [XID] // 0x0000000189924370-0x0000000189924390
	public bool CanUseAirSkill() => default; // 0x0000000181530DE0-0x0000000181530F20
	// [XID] // 0x000000018992B7E0-0x000000018992B800
	public bool CanDoJump() => default; // 0x0000000181535C00-0x0000000181535CC0
	// [XID] // 0x0000000189BD5630-0x0000000189BD5650
	public bool IsInForbiddenToggleMoveState() => default; // 0x0000000181532410-0x0000000181532550
	// [XID] // 0x000000018993A860-0x000000018993A880
	public VCMoveData.MotionFlag GetMotionFlag() => default; // 0x0000000181532930-0x0000000181532A30
	// [XID] // 0x0000000189941910-0x0000000189941930
	private bool IsInMoveAndAirState(FSMStateID stateID) => default; // 0x0000000181536030-0x0000000181536100
	// [XID] // 0x00000001899493D0-0x00000001899493F0
	public bool IsInCombatMoveOnWater() => default; // 0x0000000181534AB0-0x0000000181534C20
	// [XID] // 0x000000018987E2D0-0x000000018987E2F0
	public void FitToDrownPosition() {} // 0x0000000181530550-0x00000001815307B0
	// [XID] // 0x0000000189958470-0x0000000189958490
	public bool IsInMoveState() => default; // 0x0000000181539F90-0x000000018153A0A0
	// [XID] // 0x000000018995FB30-0x000000018995FB50
	public bool IsInMove() => default; // 0x000000018152F9D0-0x000000018152FA90
	// [XID] // 0x0000000189967450-0x0000000189967470
	public bool IsInDrop() => default; // 0x0000000181532B10-0x0000000181532BD0
	// [XID] // 0x00000001897D4540-0x00000001897D4560
	public bool IsInSlip() => default; // 0x0000000181531F40-0x0000000181532060
	// [XID] // 0x0000000189976170-0x0000000189976190
	public bool IsInSprint() => default; // 0x000000018152FEF0-0x000000018152FFB0
	// [XID] // 0x000000018997D440-0x000000018997D460
	public bool IsInRunOrSprint() => default; // 0x0000000181533CA0-0x0000000181533E20
	// [XID] // 0x0000000189625810-0x0000000189625830
	public bool InZone(int zoneHash) => default; // 0x0000000181530F20-0x0000000181531040
	// [XID] // 0x00000001898A1010-0x00000001898A1030
	public bool IsInSprintBS() => default; // 0x00000001815357B0-0x0000000181535960
	// [XID] // 0x00000001897B63B0-0x00000001897B63D0
	public bool IsInCanTriggerPlatformState() => default; // 0x000000018153A2B0-0x000000018153A3B0
	// [XID] // 0x00000001898852B0-0x00000001898852D0
	public bool IsCurrentAnimationMirror() => default; // 0x000000018153A180-0x000000018153A2B0
	// [XID] // 0x00000001899A3A00-0x00000001899A3A20
	public bool IsInCrouch() => default; // 0x000000018152FB40-0x000000018152FC00
	// [XID] // 0x0000000189801A10-0x0000000189801A30
	public bool IsInClimb() => default; // 0x0000000181531C20-0x0000000181531D20
	// [XID] // 0x00000001899B2F90-0x00000001899B2FB0
	public bool IsInTag(int tagHash) => default; // 0x0000000181535E10-0x0000000181535EE0
	// [XID] // 0x00000001899BA110-0x00000001899BA130
	public bool IsInClimbJump() => default; // 0x000000018152F700-0x000000018152F800
	// [XID] // 0x00000001899C1C80-0x00000001899C1CA0
	public bool IsInSwim() => default; // 0x000000018152F440-0x000000018152F500
	// [XID] // 0x00000001899C90A0-0x00000001899C90C0
	public bool IsInSwimDash() => default; // 0x0000000181539750-0x0000000181539830
	// [XID] // 0x00000001899D0BE0-0x00000001899D0C00
	public bool IsInSwimJump() => default; // 0x0000000181533BE0-0x0000000181533CA0
	// [XID] // 0x00000001899D7F90-0x00000001899D7FB0
	public bool IsInClimbMove() => default; // 0x0000000181534C20-0x0000000181534D00
	// [XID] // 0x00000001899DF5C0-0x00000001899DF5E0
	public bool IsInClimbIdle() => default; // 0x0000000181533410-0x0000000181533570
	// [XID] // 0x000000018983D1A0-0x000000018983D1C0
	public bool IsInStandby2Climb() => default; // 0x00000001815359C0-0x0000000181535AC0
	// [XID] // 0x00000001899EE4F0-0x00000001899EE510
	public bool IsInPureMove() => default; // 0x0000000181530CE0-0x0000000181530DE0
	// [XID] // 0x00000001899F5E20-0x00000001899F5E40
	public bool IsInSteadyMove() => default; // 0x0000000181533340-0x0000000181533410
	// [XID] // 0x0000000189844990-0x00000001898449B0
	public bool IsInGoUpstairs() => default; // 0x0000000181539220-0x00000001815392E0
	// [XID] // 0x0000000189A04BA0-0x0000000189A04BC0
	public bool IsInRunningTurn() => default; // 0x0000000181531B60-0x0000000181531C20
	// [XID] // 0x0000000189A0C250-0x0000000189A0C270
	public bool IsInCombatMove() => default; // 0x000000018153B040-0x000000018153B100
	// [XID] // 0x0000000189A13BD0-0x0000000189A13BF0
	public bool IsInCombatFallOnGround() => default; // 0x0000000181531120-0x00000001815311E0
	// [XID] // 0x0000000189A1AD90-0x0000000189A1ADB0
	public bool IsInCombatCategory() => default; // 0x0000000181534090-0x0000000181534170
	// [IDTag] // 0x0000000189A22670-0x0000000189A226B0
	// [XID] // 0x0000000189A22670-0x0000000189A226B0
	public bool IsCombatCategory(FSMStateID stateID) => default; // 0x0000000181539460-0x0000000181539520
	// [IDTag] // 0x0000000189A2C840-0x0000000189A2C880
	// [XID] // 0x0000000189A2C840-0x0000000189A2C880
	public bool IsCombatCategory(MoveType moveType) => default; // 0x0000000181539520-0x00000001815395E0
	// [XID] // 0x0000000189A37220-0x0000000189A37240
	public bool IsInCombatAir() => default; // 0x000000018152F640-0x000000018152F700
	// [XID] // 0x0000000189A3E8D0-0x0000000189A3E8F0
	public bool IsCombatAir(MoveType moveType) => default; // 0x0000000181533750-0x0000000181533800
	// [XID] // 0x0000000189A45FC0-0x0000000189A45FE0
	public bool IsInPerform() => default; // 0x000000018153A820-0x000000018153A8E0
	// [XID] // 0x00000001897887A0-0x00000001897887C0
	public bool IsPerform(MoveType moveType) => default; // 0x000000018153ADB0-0x000000018153AE60
	// [XID] // 0x0000000189A54F70-0x0000000189A54F90
	public bool IsInSit() => default; // 0x0000000181533FD0-0x0000000181534090
	// [XID] // 0x0000000189A5C880-0x0000000189A5C8A0
	public void TrySlip() {} // 0x0000000181533670-0x0000000181533750
	// [XID] // 0x0000000189730730-0x0000000189730750
	public void TrySprintBS() {} // 0x000000018153A0A0-0x000000018153A180
	// [XID] // 0x0000000189737F30-0x0000000189737F50
	public void TryStopSprint() {} // 0x0000000181539EB0-0x0000000181539F90
	// [XID] // 0x0000000189A732C0-0x0000000189A732E0
	public void EnterClimbGlobalRecoveryTime() {} // 0x00000001815309C0-0x0000000181530A70
	// [XID] // 0x0000000189A7ADB0-0x0000000189A7ADD0
	public void EnterGoupstairsGlobalRecoveryTime() {} // 0x000000018152F3A0-0x000000018152F440
	// [XID] // 0x0000000189A82340-0x0000000189A82360
	public void ResetClimbGlobalRecoveryTime() {} // 0x000000018152FA90-0x000000018152FB40
	// [XID] // 0x0000000189A89C60-0x0000000189A89C80
	public HumanoidMoveFSMBaseMoveState GetCurrentState() => default; // 0x0000000181539C80-0x0000000181539D20
	// [XID] // 0x0000000189A91380-0x0000000189A913A0
	public Vector3 GetMoveVelocity() => default; // 0x0000000181533800-0x0000000181533900
	// [XID] // 0x0000000189A98F30-0x0000000189A98F50
	public void OnAnimatorMove() {} // 0x0000000181530900-0x00000001815309C0
	// [XID] // 0x0000000189AA00C0-0x0000000189AA00E0
	public void SprintBSCallBack() {} // 0x000000018153A8E0-0x000000018153AA90
	// [XID] // 0x0000000189AA78B0-0x0000000189AA78D0
	public bool CheckSprintCooldown() => default; // 0x0000000181533E20-0x0000000181533F00
	// [XID] // 0x0000000189AAF0F0-0x0000000189AAF110
	public void UpdateSprintCooldown(float deltaTime) {} // 0x0000000181535CC0-0x0000000181535E10
	// [XID] // 0x0000000189AB69B0-0x0000000189AB69D0
	public Vector3 GetCurrentWallNormal() => default; // 0x00000001815395E0-0x0000000181539750
	// [XID] // 0x000000018966F240-0x000000018966F260
	public void SetAimMode(bool enabled) {} // 0x0000000181533570-0x0000000181533670
	// [XID] // 0x0000000189AC5FF0-0x0000000189AC6010
	public float GetCurrentAnimSpeedScale() => default; // 0x000000018152FDC0-0x000000018152FEF0
	// [XID] // 0x0000000189ACD560-0x0000000189ACD580
	public void UpdateAnimatorStateInfo() {} // 0x00000001815303D0-0x0000000181530550
	// [XID] // 0x00000001898619B0-0x00000001898619D0
	public bool EnterMoveState(MoveType moveType) => default; // 0x000000018152F800-0x000000018152F9D0
	// [XID] // 0x0000000189A1C5D0-0x0000000189A1C5F0
	private void CheckPerformState() {} // 0x0000000181533F00-0x0000000181533FD0
	// [XID] // 0x0000000189A06880-0x0000000189A068A0
	private void CheckCombatState(MoveType moveType) {} // 0x000000018153A3B0-0x000000018153A650
	// [XID] // 0x00000001898FE7A0-0x00000001898FE7C0
	private void CheckNormalMoveState() {} // 0x0000000181534F40-0x00000001815357B0
	// [XID] // 0x0000000189797670-0x0000000189797690
	public bool IsShiftWorldSafe() => default; // 0x000000018152F500-0x000000018152F640
	// [XID] // 0x00000001897B6390-0x00000001897B63B0
	public void ShiftWorld(bool isRemote, Vector3 deltaShift) {} // 0x00000001815392E0-0x00000001815393F0
}

