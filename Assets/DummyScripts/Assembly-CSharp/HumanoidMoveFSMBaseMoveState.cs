/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using motion4hi;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class HumanoidMoveFSMBaseMoveState // TypeDefIndex: 14649
{
	// Fields
	protected MoveDebugTransform _transform; // 0x18
	protected MoveDebugRigidbody _rigidBody; // 0x20
	protected Animator _animator; // 0x28
	protected Transform _bip001; // 0x30
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected float _downwardRayDetectLength; // 0x38
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected float _groundRayDetectLength; // 0x3C
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected float _backwardRayDetectLength; // 0x40
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected float _backwardRayDetectOriginOffset; // 0x44
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected float _maxDetectThreshold; // 0x48
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected float _detectThreshold; // 0x4C
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected float _fitWaterHeightSpeed; // 0x50
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected float _checkCliffMinDiffAngle; // 0x54
	protected Transform _headTrans; // 0x58
	protected bool _applyAnimatorMove; // 0x60
	protected VCHumanoidMoveData _moveData; // 0x68
	protected VCHumanoidMoveConfig _moveConfig; // 0x70
	protected VCHumanoidMove _vcHumanoidMove; // 0x78
	protected HumanoidMoveFSM _humanoidMoveFSM; // 0x80
	protected int _layerMask; // 0x88
	protected int _layerMaskWater; // 0x8C
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected const float SLOW_ROTATE_RATIO = 0.02f; // Metadata: 0x00AEBA1D
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected const float RAPID_ROTATE_RATIO = 0.2f; // Metadata: 0x00AEBA21
	protected AnimatorController _animatorController; // 0x90
	protected HeightmapPlugin _heightmap; // 0x98
	protected VCMoveCollider _moveCollider; // 0xA0
	protected bool _behaviourSet; // 0xA8
	protected bool _syncFirstEnter; // 0xA9
	protected bool _syncFirstEnterNeedMove; // 0xAA
	private Vector3 _inertiaVelocity; // 0xAC
	protected const float BLINK_CHECK_DIST = 0.5f; // Metadata: 0x00AEBA25
	protected const float BLINK_CHECK_HEIGHT_RATIO = 0.6f; // Metadata: 0x00AEBA29
	private const float BLINK_GO_UP_SLOPE = 1.42f; // Metadata: 0x00AEBA2D
	private const float BLINK_GO_DOWN_SLOPE = 2.6f; // Metadata: 0x00AEBA31
	private const float BLINK_NORMAL_CHECK_SAME_SLOPE_DIST = 0.1f; // Metadata: 0x00AEBA35
	private const float BLINK_NORMAL_CHECK_SAME_SLOPE_ANGLE = 10f; // Metadata: 0x00AEBA39
	private const float BLINK_WATER_HEIGHT_RATIO = 0.65f; // Metadata: 0x00AEBA3D
	private float _remainBlinkDist; // 0xB8
	private float _remainForwardNoHitDist; // 0xBC
	private float _lastForwardRayHeight; // 0xC0
	private int _curWayPoint; // 0xC4
	private int _curSlopeCheckStartPoint; // 0xC8
	private bool _curSlopeCheckUp; // 0xCC
	private bool _enableBlinkUnderWatercheck; // 0xCD
	private Vector3[] _blinkDetectedWayPoints; // 0xD0
	private Vector3 _blinkResultPosition; // 0xD8
	protected Collider[] _tempColliders; // 0xE8
	protected RaycastHit[] _raycastHits; // 0xF0
	protected VCMoveData.MotionFlag _lastPacketMotion; // 0xF8
	protected Vector3 _lastPacketPos; // 0xFC
	protected VCMoveData.MotionFlag _lastNonIdleMotion; // 0x108
	protected HumanoidMoveFSM.FSMStateID _syncDelayedEnterFormerStateId; // 0x10C
	protected object[] _syncDelayedEnterValues; // 0x110
	protected bool _syncDelayedEnter; // 0x118
	protected float _syncDelayedEnterTime; // 0x11C
	protected const float WATER_LEAN_THRESHOLD_ANGLE = 5f; // Metadata: 0x00AEBA41
	protected const float WATER_FALL_THRESHOLD_ANGLE = 55f; // Metadata: 0x00AEBA45
	protected const float WATER_DROP_THRESHOLD_ANGLE = 35f; // Metadata: 0x00AEBA49
	protected const float WATER_SWIM_THRESHOLD_ANGLE = 25f; // Metadata: 0x00AEBA4D
	private const float CHECK_STEP_AND_CLIMB_RADIUS_FACTOR = 0.125f; // Metadata: 0x00AEBA51
	private const float TO_CLIMB_HAND_RAY_DISTANCE = 1f; // Metadata: 0x00AEBA55
	private const float LEFT_RIGHT_CHECK_DISTANCE_RATIO = 0.5f; // Metadata: 0x00AEBA59
	private const float SWIM_ABOVE_HEAD_CHECK_DISTANCE_RATIO = 0.125f; // Metadata: 0x00AEBA5D
	protected const float MIN_DOWN_DETECT_DIST = 0.08f; // Metadata: 0x00AEBA61
	private Vector3 _forceSlipCheckUpVector; // 0x120
	private const float FORCE_SLIP_START_RAY_DIST_NO_CLIMB = 0.45f; // Metadata: 0x00AEBA65
	private const float FORCE_SLIP_START_RAY_DIST_CLIMBABLE = 1.5f; // Metadata: 0x00AEBA69
	private const float FORCE_SLIP_STOP_RAY_DIST = 0.25f; // Metadata: 0x00AEBA6D
	private const float SWIM_JUMP_FORWARD_COLLISION_DETECT_DIST = 4f; // Metadata: 0x00AEBA71
	private const float SWIM_JUMP_DOWN_RAY_DETECT_MAX_FORWARD_DIST = 7f; // Metadata: 0x00AEBA75
	private const float SWIM_JUMP_DOWN_RAY_DETECT_MIN_FORWARD_DIST = 5f; // Metadata: 0x00AEBA79
	private const float SWIM_JUMP_DOWN_RAY_DETECT_MAX_DIST = 30f; // Metadata: 0x00AEBA7D
	private const float SWIM_JUMP_DOWN_RAY_DETECT_START_DIST = 1.8f; // Metadata: 0x00AEBA81
	private const float SWIM_JUMP_DOWN_RAY_DETECT_INTERVAL = 0.4f; // Metadata: 0x00AEBA85
	private const float SWIM_JUMP_MIN_HEIGHT_RATIO = 1.15f; // Metadata: 0x00AEBA89
	protected const float AFTER_FREEZE_RECOVER_POSE_TIME = 0.3f; // Metadata: 0x00AEBA8D
	private int stableStandbyHash; // 0x12C
	private int leftFootZoneHash; // 0x130
	private int rightFootZoneHash; // 0x134
	private int leftFootHillZoneHash; // 0x138
	private int rightFootHillZoneHash; // 0x13C

	// Properties
	public HumanoidMoveFSM.FSMStateID stateID { /* [XID] */ /* 0x00000001899A21D0-0x00000001899A2210 */ get; set; } // 0x0000000181F499C0-0x0000000181F49A20 0x0000000181F39EF0-0x0000000181F39F50

	// Nested types
	protected enum StepAndClimbResult // TypeDefIndex: 14650
	{
		None = 0,
		Climb = 1,
		Goupstair = 2,
		MoveStayInPlace = 3,
		Ladder = 4
	}

	protected enum GoUpstairHeight // TypeDefIndex: 14651
	{
		UnderKnee = 0,
		Knee2Waist = 1,
		Waist2Head = 2
	}

	protected struct StepAndClimbInfo // TypeDefIndex: 14652
	{
		// Fields
		public StepAndClimbResult result; // 0x00
		public Vector3 position; // 0x04
		public Vector3 normal; // 0x10
		public GoUpstairHeight UpstairHeight; // 0x1C
		public bool moveStayInPlaceWhenClimbFail; // 0x20
		public SceneObjTag targetTag; // 0x24
	}

	protected enum CheckStepAndClimbState // TypeDefIndex: 14653
	{
		Move = 0,
		Air = 1,
		Swim = 2,
		Slip = 3
	}

	public enum BeneathResult // TypeDefIndex: 14654
	{
		Move = 0,
		Slip = 1,
		Air = 2,
		NoStandGround = 3
	}

	// Constructors
	protected HumanoidMoveFSMBaseMoveState() {} // Dummy constructor
	public HumanoidMoveFSMBaseMoveState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x0000000181F4A040-0x0000000181F4A540

	// Methods
	// [XID] // 0x00000001899B4450-0x00000001899B4470
	public void SetInertiaVelocity(Vector3 velocity) {} // 0x0000000181F48290-0x0000000181F48360
	// [XID] // 0x00000001899BB8D0-0x00000001899BB8F0
	public Vector3 GetInertiaVelocity() => default; // 0x0000000181F41C30-0x0000000181F41D10
	// [XID] // 0x000000018972D670-0x000000018972D690
	public virtual void Exit(HumanoidMoveFSM.FSMStateID nextState) {} // 0x0000000181F47980-0x0000000181F47A30
	// [XID] // 0x00000001899CA9C0-0x00000001899CA9E0
	public virtual void Destroy() {} // 0x0000000181F394E0-0x0000000181F395B0
	// [XID] // 0x00000001899D1FB0-0x00000001899D1FD0
	protected virtual void Reset() {} // 0x0000000181F395B0-0x0000000181F39650
	// [XID] // 0x00000001899D96B0-0x00000001899D96D0
	public virtual void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x0000000181F48060-0x0000000181F48120
	// [XID] // 0x0000000189AD9A50-0x0000000189AD9A70
	public virtual void InitSyncWithCurrentTask(bool setPosition) {} // 0x0000000181F47830-0x0000000181F478E0
	// [XID] // 0x00000001899EFFA0-0x00000001899EFFC0
	public virtual void FixedTick() {} // 0x0000000181F402D0-0x0000000181F40370
	// [XID] // 0x00000001899F75E0-0x00000001899F7600
	public virtual void LateTick() {} // 0x0000000181F46690-0x0000000181F46730
	// [XID] // 0x00000001899FED00-0x00000001899FED20
	public virtual void SyncLateTick() {} // 0x0000000181F478E0-0x0000000181F47980
	// [XID] // 0x0000000189A06580-0x0000000189A065A0
	public virtual void SyncFixedTick() {} // 0x0000000181F47AD0-0x0000000181F47B70
	// [XID] // 0x0000000189A0DAC0-0x0000000189A0DAE0
	public virtual void DoJump() {} // 0x0000000181F46270-0x0000000181F46310
	// [XID] // 0x0000000189A15140-0x0000000189A15160
	public virtual bool CanDoJump() => default; // 0x0000000181F447E0-0x0000000181F44880
	// [XID] // 0x0000000189A1C2D0-0x0000000189A1C2F0
	public void DoBlinkAir() {} // 0x0000000181F43940-0x0000000181F443A0
	// [XID] // 0x0000000189A23C50-0x0000000189A23C70
	public void DoBlinkGround() {} // 0x0000000181F36190-0x0000000181F36340
	// [XID] // 0x0000000189A2AFC0-0x0000000189A2AFE0
	public void DoBlinkGroundImp() {} // 0x0000000181F35B40-0x0000000181F35DD0
	// [XID] // 0x0000000189A32670-0x0000000189A32690
	private void InitBlinkDirAndDist() {} // 0x0000000181F3FA20-0x0000000181F3FD20
	// [XID] // 0x0000000189A39F70-0x0000000189A39F90
	private bool GetNextWayPoint() => default; // 0x0000000181F3F1A0-0x0000000181F3F890
	// [XID] // 0x0000000189A41820-0x0000000189A41840
	private bool ForwardNoHitProcess() => default; // 0x0000000181F46CB0-0x0000000181F47330
	// [XID] // 0x0000000189A48E10-0x0000000189A48E30
	private void FinalCheckWayPoints() {} // 0x0000000181F40F10-0x0000000181F41670
	// [XID] // 0x0000000189A50780-0x0000000189A507A0
	private bool CheckBlinkPos(Vector3 pos) => default; // 0x0000000181F3EE00-0x0000000181F3F1A0
	// [XID] // 0x0000000189A57BE0-0x0000000189A57C00
	private bool CheckBlinkSlopeByNormal(Vector3 pos, Vector3 normal) => default; // 0x0000000181F37770-0x0000000181F38300
	// [XID] // 0x0000000189A5F890-0x0000000189A5F8B0
	protected virtual void CloseToGround() {} // 0x0000000181F49C00-0x0000000181F49CA0
	// [XID] // 0x0000000189A67170-0x0000000189A67190
	private bool CheckBlinkSlopebyHeight(Vector3 pos, SceneObjTag tag) => default; // 0x0000000181F42FB0-0x0000000181F43830
	// [XID] // 0x0000000189A6E800-0x0000000189A6E820
	private bool BlinkDownRaycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) {
		hitInfo = default;
		return default;
	} // 0x0000000181F49440-0x0000000181F49910
	// [IDTag] // 0x0000000189A76090-0x0000000189A760D0
	// [XID] // 0x0000000189A76090-0x0000000189A760D0
	public virtual void TrySteer(bool isMoving, float joystickAngle) {} // 0x0000000181F49B10-0x0000000181F49C00
	// [IDTag] // 0x0000000189A80820-0x0000000189A80860
	// [XID] // 0x0000000189A80820-0x0000000189A80860
	public virtual void TrySteer(Vector3 targetDir) {} // 0x0000000181F49A20-0x0000000181F49B10
	// [XID] // 0x0000000189A8B510-0x0000000189A8B530
	public virtual void TryStop() {} // 0x0000000181F34660-0x0000000181F34730
	// [XID] // 0x0000000189A92AE0-0x0000000189A92B00
	public virtual void DoStop() {} // 0x0000000181F48120-0x0000000181F481F0
	// [XID] // 0x0000000189A9A560-0x0000000189A9A580
	public virtual bool IsInSwimIdle() => default; // 0x0000000181F48610-0x0000000181F486B0
	// [XID] // 0x0000000189AA15C0-0x0000000189AA15E0
	public virtual bool IsInSwimDash() => default; // 0x0000000181F47A30-0x0000000181F47AD0
	// [XID] // 0x000000018977B030-0x000000018977B050
	public virtual bool IsInMove() => default; // 0x0000000181F373F0-0x0000000181F376C0
	// [XID] // 0x0000000189AB08F0-0x0000000189AB0910
	public virtual bool GetNextSyncOrder() => default; // 0x0000000181F39650-0x0000000181F397C0
	// [XID] // 0x0000000189AB7EC0-0x0000000189AB7EE0
	protected virtual void GetLastPacketMotion() {} // 0x0000000181F48570-0x0000000181F48610
	// [XID] // 0x0000000189A0DD80-0x0000000189A0DDA0
	public virtual void CalcExitClimbFromCombat() {} // 0x0000000181F3D9E0-0x0000000181F3DA80
	// [XID] // 0x0000000189AC7550-0x0000000189AC7570
	protected void CheckLongDelayMove() {} // 0x0000000181F43830-0x0000000181F43940
	// [XID] // 0x0000000189ACEAD0-0x0000000189ACEAF0
	public bool PeekNextSyncOrder(out MotionState motion, out Vector3 position) {
		motion = default;
		position = default;
		return default;
	} // 0x0000000181F41910-0x0000000181F41A00
	// [XID] // 0x0000000189AD6A70-0x0000000189AD6A90
	protected float GetSlope(Vector3 normal) => default; // 0x0000000181F41D10-0x0000000181F41E50
	// [XID] // 0x0000000189ADE2A0-0x0000000189ADE2C0
	public virtual void SetNonAnimatorMode(bool value) {} // 0x0000000181F44690-0x0000000181F447E0
	// [XID] // 0x0000000189AE5D60-0x0000000189AE5D80
	public virtual bool IsNonAnimatorMode() => default; // 0x0000000181F445E0-0x0000000181F44690
	// [XID] // 0x0000000189AED150-0x0000000189AED170
	protected virtual void CalcMoveState() {} // 0x0000000181F47B70-0x0000000181F47C10
	// [XID] // 0x0000000189AF4BE0-0x0000000189AF4C00
	protected virtual void DoMoveDownward(Vector3 hitPos, Vector3 hitNormal, Vector3 targetDir) {} // 0x0000000181F38C60-0x0000000181F38D70
	// [XID] // 0x0000000189AFC160-0x0000000189AFC180
	protected virtual void DoMoveBackward(Vector3 hitPos, Vector3 hitNormal) {} // 0x0000000181F44880-0x0000000181F44960
	// [XID] // 0x0000000189B03AB0-0x0000000189B03AD0
	protected virtual int CalcRaycastResult(Vector3 hitPos, Vector3 hitNormal) => default; // 0x0000000181F37300-0x0000000181F373F0
	// [XID] // 0x0000000189B0B0E0-0x0000000189B0B100
	protected virtual void DoSteer() {} // 0x0000000181F46730-0x0000000181F467D0
	// [XID] // 0x0000000189B129B0-0x0000000189B129D0
	protected virtual void SetTransformUp() {} // 0x0000000181F47C10-0x0000000181F47FC0
	// [XID] // 0x0000000189B19C40-0x0000000189B19C60
	public virtual void OnAnimatorMove() {} // 0x0000000181F39E00-0x0000000181F39EF0
	// [XID] // 0x0000000189B21270-0x0000000189B21290
	protected virtual void CalcCurrentGroundInfo() {} // 0x0000000181F48360-0x0000000181F48570
	// [XID] // 0x0000000189B28AE0-0x0000000189B28B00
	protected virtual void CalcCurrentCeilInfo() {} // 0x0000000181F443A0-0x0000000181F445E0
	// [XID] // 0x00000001898C8020-0x00000001898C8040
	protected void CalcCurrentWaterInfo() {} // 0x0000000181F41E50-0x0000000181F42850
	// [XID] // 0x0000000189B377A0-0x0000000189B377C0
	protected virtual bool CheckSwim() => default; // 0x0000000181F467D0-0x0000000181F46870
	// [XID] // 0x0000000189B3F090-0x0000000189B3F0B0
	protected virtual Ray GetDownwardRay(Vector3 targetPos) => default; // 0x0000000181F393B0-0x0000000181F394E0
	// [XID] // 0x0000000189B46980-0x0000000189B469A0
	protected virtual Ray GetGroundRay(Vector3 targetPos) => default; // 0x0000000181F39870-0x0000000181F399A0
	// [XID] // 0x0000000189B4E130-0x0000000189B4E150
	protected virtual void SetAnimIdle() {} // 0x0000000181F42F10-0x0000000181F42FB0
	// [XID] // 0x0000000189B557C0-0x0000000189B557E0
	protected virtual void SetAnimMove() {} // 0x0000000181F3D940-0x0000000181F3D9E0
	// [XID] // 0x0000000189B5D1D0-0x0000000189B5D1F0
	protected virtual bool GetGroundNormalAndPosUseCapsuleCast(out Vector3 normal, out Vector3 hitPoint, out float hitDistance) {
		normal = default;
		hitPoint = default;
		hitDistance = default;
		return default;
	} // 0x0000000181F3D800-0x0000000181F3D940
	// [XID] // 0x0000000189B648D0-0x0000000189B648F0
	public virtual void OnStopAnimatorMoveTime() {} // 0x0000000181F486B0-0x0000000181F48750
	// [IDTag] // 0x0000000189B6BD20-0x0000000189B6BD60
	// [XID] // 0x0000000189B6BD20-0x0000000189B6BD60
	protected virtual bool GetDownwardHitNormalAndPos(Vector3 targetPos, out Vector3 normal, out Vector3 hitPoint, Color color) {
		normal = default;
		hitPoint = default;
		return default;
	} // 0x0000000181F40710-0x0000000181F408C0
	// [IDTag] // 0x0000000189B764B0-0x0000000189B764F0
	// [XID] // 0x0000000189B764B0-0x0000000189B764F0
	protected virtual bool GetDownwardHitNormalAndPos(Vector3 targetPos, out Vector3 normal, out Vector3 hitPoint, out Collider collider, out int hitTriangleIndex, Color color) {
		normal = default;
		hitPoint = default;
		collider = default;
		hitTriangleIndex = default;
		return default;
	} // 0x0000000181F408C0-0x0000000181F40AA0
	// [XID] // 0x0000000189B80810-0x0000000189B80830
	protected virtual void MoveFollowReferenceSystem() {} // 0x0000000181F40670-0x0000000181F40710
	// [XID] // 0x0000000189B88460-0x0000000189B88480
	protected virtual void CheckGroundReferenceSystem() {} // 0x0000000181F47FC0-0x0000000181F48060
	// [XID] // 0x0000000189B8F660-0x0000000189B8F680
	protected bool GetGroundNormalAndPos(Vector3 targetPos, out Vector3 normal, out Vector3 hitPoint, out bool isTempCollider) {
		normal = default;
		hitPoint = default;
		isTempCollider = default;
		return default;
	} // 0x0000000181F42850-0x0000000181F42F10
	// [IDTag] // 0x0000000189B96B40-0x0000000189B96B80
	// [XID] // 0x0000000189B96B40-0x0000000189B96B80
	protected bool RaycastTest(Ray ray, float detectLength, out Vector3 normal, out Vector3 hitPoint, out float hitDistance, out Collider collider, out int hitTriangleIndex, Color color, bool drawLine = false /* Metadata: 0x00AEBA10 */) {
		normal = default;
		hitPoint = default;
		hitDistance = default;
		collider = default;
		hitTriangleIndex = default;
		return default;
	} // 0x0000000181F3FD20-0x0000000181F3FF40
	// [IDTag] // 0x0000000189BA1100-0x0000000189BA1140
	// [XID] // 0x0000000189BA1100-0x0000000189BA1140
	protected bool RaycastTest(Ray ray, float detectLength, out Vector3 normal, out Vector3 hitPoint, out float hitDistance, Color color, bool drawLine = false /* Metadata: 0x00AEBA11 */) {
		normal = default;
		hitPoint = default;
		hitDistance = default;
		return default;
	} // 0x0000000181F3FF40-0x0000000181F40150
	// [XID] // 0x0000000189BAB6F0-0x0000000189BAB710
	protected virtual void StayInPlace() {} // 0x0000000181F35FE0-0x0000000181F36190
	// [XID] // 0x0000000189BB2C70-0x0000000189BB2C90
	protected void LevelRigidbodyInterpolate(float height) {} // 0x0000000181F47590-0x0000000181F47830
	// [XID] // 0x0000000189BBA020-0x0000000189BBA040
	protected virtual void StayInPlaceImmediately() {} // 0x0000000181F49CA0-0x0000000181F49F60
	// [XID] // 0x0000000189BC2140-0x0000000189BC2160
	protected void ClearRawInput() {} // 0x0000000181F399A0-0x0000000181F39A50
	// [XID] // 0x0000000189BC9610-0x0000000189BC9630
	protected bool IsInClimbConcave(float slope) => default; // 0x0000000181F49F60-0x0000000181F4A040
	// [XID] // 0x0000000189BD0E70-0x0000000189BD0E90
	public virtual bool CanPlaySwimEffect() => default; // 0x0000000181F481F0-0x0000000181F48290
	// [XID] // 0x0000000189BD8440-0x0000000189BD8460
	protected bool GetRaycastNormalAndPos(Vector3 position, Vector3 direction, float length, float triangleSize, out Vector3 normal, out Vector3 hitPoint, out float hitDistance, Color color, bool drawLine = false /* Metadata: 0x00AEBA12 */) {
		normal = default;
		hitPoint = default;
		hitDistance = default;
		return default;
	} // 0x0000000181F40D20-0x0000000181F40F10
	// [XID] // 0x0000000189BDFDC0-0x0000000189BDFDE0
	protected void SetAnimClimbIdle() {} // 0x0000000181F41820-0x0000000181F41910
	// [XID] // 0x00000001895ECA80-0x00000001895ECAA0
	protected void SetAnimClimbMove() {} // 0x0000000181F488F0-0x0000000181F489E0
	// [XID] // 0x00000001895F40D0-0x00000001895F40F0
	protected void DoRotateForward(Vector3 targetWallNormal, float rotateRatio) {} // 0x0000000181F489E0-0x0000000181F49300
	// [XID] // 0x00000001895FB900-0x00000001895FB920
	protected void DoRotateForwardAroundFoot(Vector3 targetWallNormal, float rotateRatio) {} // 0x0000000181F383D0-0x0000000181F38C60
	// [XID] // 0x00000001896030A0-0x00000001896030C0
	protected void MoveRotation(Vector3 center, Quaternion rotation) {} // 0x0000000181F39A50-0x0000000181F39E00
	// [XID] // 0x000000018960AA80-0x000000018960AAA0
	protected void DoDrop() {} // 0x0000000181F37250-0x0000000181F37300
	// [XID] // 0x0000000189612030-0x0000000189612050
	protected virtual void SetToDropState(bool jumpOffWall) {} // 0x0000000181F47430-0x0000000181F47590
	// [XID] // 0x00000001896199F0-0x0000000189619A10
	public virtual bool IsInSit() => default; // 0x0000000181F41A00-0x0000000181F41AA0
	// [XID] // 0x0000000189620E90-0x0000000189620EB0
	protected virtual bool CheckDropUseStartSpeed() => default; // 0x0000000181F35AA0-0x0000000181F35B40
	// [IDTag] // 0x0000000189628600-0x0000000189628640
	// [XID] // 0x0000000189628600-0x0000000189628640
	protected bool CheckStepAndClimb(out StepAndClimbInfo info, CheckStepAndClimbState state) {
		info = default;
		return default;
	} // 0x0000000181F39F50-0x0000000181F3A070
	// [IDTag] // 0x0000000189632DD0-0x0000000189632E10
	// [XID] // 0x0000000189632DD0-0x0000000189632E10
	protected bool CheckStepAndClimb(out StepAndClimbInfo info, CheckStepAndClimbState state, Vector3 dir, float dist = 0f /* Metadata: 0x00AEBA13 */, bool tryAnotherDirUseCapsuleCast = true /* Metadata: 0x00AEBA17 */) {
		info = default;
		return default;
	} // 0x0000000181F3A070-0x0000000181F3D410
	// [IDTag] // 0x000000018963D970-0x000000018963D9B0
	// [XID] // 0x000000018963D970-0x000000018963D9B0
	protected SceneObjTag CheckColliderLayerAndTag(Collider col, int triangleIndex, out bool climbable) {
		climbable = default;
		return default;
	} // 0x0000000181F464C0-0x0000000181F46690
	// [IDTag] // 0x0000000189647EA0-0x0000000189647EE0
	// [XID] // 0x0000000189647EA0-0x0000000189647EE0
	protected SceneObjTag CheckColliderLayerAndTag(Collider col, int triangleIndex) => default; // 0x0000000181F46310-0x0000000181F464C0
	// [XID] // 0x0000000189652600-0x0000000189652620
	protected bool IsStayTag(SceneObjTag tag) => default; // 0x0000000181F46B40-0x0000000181F46C00
	// [XID] // 0x0000000189659DB0-0x0000000189659DD0
	private bool CheckLeftRightHandNormal(Vector3 hitPoint, ref Vector3 hitNormal, Vector3 dir) => default; // 0x0000000181F34730-0x0000000181F35AA0
	// [XID] // 0x0000000189661460-0x0000000189661480
	protected bool CheckLadder(Collider collider, int hitTriangleIndex, ref StepAndClimbInfo info, CheckStepAndClimbState state) => default; // 0x0000000181F40370-0x0000000181F40670
	// [XID] // 0x0000000189669030-0x0000000189669050
	protected virtual BeneathResult DeterminBeneathResult(BeneathResult last, float downVelocity = 0f /* Metadata: 0x00AEBA18 */, bool forceScanHeightMap = false /* Metadata: 0x00AEBA1C */) => default; // 0x0000000181F44960-0x0000000181F46270
	// [XID] // 0x00000001896709E0-0x0000000189670A00
	public bool InputDirWithinCertainAngleAndClimbNormalVaild(Vector3 dir, float angle) => default; // 0x0000000181F3D410-0x0000000181F3D800
	// [XID] // 0x0000000189678250-0x0000000189678270
	public bool InputDirWithinCertainAngle(Vector3 dir, float angle) => default; // 0x0000000181F41670-0x0000000181F41820
	// [XID] // 0x000000018967FB50-0x000000018967FB70
	public bool PointInCameraFrustum(Vector3 point) => default; // 0x0000000181F35DD0-0x0000000181F35FE0
	// [XID] // 0x0000000189687200-0x0000000189687220
	protected virtual bool CheckForceSlipByGroundNormal(BeneathResult last, out bool useGroundNormal) {
		useGroundNormal = default;
		return default;
	} // 0x0000000181F3DA80-0x0000000181F3E480
	// [XID] // 0x000000018968EFB0-0x000000018968EFD0
	protected bool CheckJumpForSwim(Vector3 dir) => default; // 0x0000000181F36480-0x0000000181F37250
	// [XID] // 0x0000000189696A70-0x0000000189696A90
	protected virtual void FrozenCharacterProcess() {} // 0x0000000181F36340-0x0000000181F363E0
	// [XID] // 0x000000018969DFC0-0x000000018969DFE0
	protected virtual void FreezeCharacter() {} // 0x0000000181F38300-0x0000000181F383D0
	// [XID] // 0x00000001896A4FF0-0x00000001896A5010
	protected virtual void UnFreezeCharacter() {} // 0x0000000181F46870-0x0000000181F46910
	// [XID] // 0x00000001896AC940-0x00000001896AC960
	public bool UpdateFreezeCharacter() => default; // 0x0000000181F49300-0x0000000181F49440
	// [XID] // 0x00000001896B3BD0-0x00000001896B3BF0
	public bool IsStableStandby() => default; // 0x0000000181F40150-0x0000000181F402D0
	// [XID] // 0x0000000189873630-0x0000000189873650
	public virtual bool EnableMoveIK(IKBodySide bodySide) => default; // 0x0000000181F48750-0x0000000181F488F0
	// [XID] // 0x00000001896C2460-0x00000001896C2480
	private bool GetInIKZone(int leftZoneHash, int rightZoneHash, IKBodySide bodySide) => default; // 0x0000000181F46910-0x0000000181F46B40
	// [XID] // 0x00000001896C99F0-0x00000001896C9A10
	public virtual bool EnableClimbIK() => default; // 0x0000000181F40C80-0x0000000181F40D20
	// [XID] // 0x00000001896D1220-0x00000001896D1240
	protected virtual MotionState GetCurrentSyncMotionState() => default; // 0x0000000181F363E0-0x0000000181F36480
	// [XID] // 0x0000000189AB3AB0-0x0000000189AB3AD0
	public virtual void CreateSyncTaskByTimeInterval() {} // 0x0000000181F41AA0-0x0000000181F41C30
	// [XID] // 0x00000001896E0110-0x00000001896E0130
	protected virtual bool CanDoSprint() => default; // 0x0000000181F40AA0-0x0000000181F40C80
	// [XID] // 0x00000001896E7440-0x00000001896E7460
	protected void NotifyStopSprint() {} // 0x0000000181F3E480-0x0000000181F3E530
	// [XID] // 0x00000001896EEA60-0x00000001896EEA80
	public virtual void OnStayInPlace() {} // 0x0000000181F3E530-0x0000000181F3E850
	// [XID] // 0x00000001896F64A0-0x00000001896F64C0
	public virtual void SetFlyBackSpeedMaxRatio(float ratio) {} // 0x0000000181F397C0-0x0000000181F39870
	// [XID] // 0x00000001896FDBD0-0x00000001896FDBF0
	public virtual void SetFlyHorizontalSpeedMaxRatio(float ratio) {} // 0x0000000181F39250-0x0000000181F39300
	// [XID] // 0x0000000189B31AC0-0x0000000189B31AE0
	public virtual void SetFlyRotationAngularVelocityRatio(float ratio) {} // 0x0000000181F39300-0x0000000181F393B0
	// [XID] // 0x000000018970C6E0-0x000000018970C700
	public virtual void SetFlyDownSpeedRatio(float ratio) {} // 0x0000000181F376C0-0x0000000181F37770
	// [XID] // 0x0000000189713FB0-0x0000000189713FD0
	public virtual void SetFlyForwardSpeedMaxRatio(float ratio) {} // 0x0000000181F46C00-0x0000000181F46CB0
	// [XID] // 0x000000018971B910-0x000000018971B930
	public virtual void SetFlyOverallSpeedRatio(float ratio) {} // 0x0000000181F49910-0x0000000181F499C0
	// [XID] // 0x00000001897BE1A0-0x00000001897BE1C0
	public virtual void ShiftWorld(bool isRemote, Vector3 deltaShift) {} // 0x0000000181F47330-0x0000000181F47430
	// [XID] // 0x00000001897C5810-0x00000001897C5830
	public virtual void ShiftSync(Vector3 deltaShift) {} // 0x0000000181F3F890-0x0000000181F3FA20
	// [XID] // 0x0000000189601CB0-0x0000000189601CD0
	public void TranslateSyncTaskPositionFromAbsoluteToRelative() {} // 0x0000000181F38D70-0x0000000181F39250
	// [XID] // 0x00000001897CCEA0-0x00000001897CCEC0
	protected void ShiftCurrentSyncTaskPosition(Vector3 deltaShift) {} // 0x0000000181F3E850-0x0000000181F3EE00
}

