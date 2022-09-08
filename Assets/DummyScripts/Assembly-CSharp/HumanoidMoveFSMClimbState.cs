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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class HumanoidMoveFSMClimbState : HumanoidMoveFSMBaseMoveState // TypeDefIndex: 14655
{
	// Fields
	protected Vector3 _targetPoint; // 0x140
	protected Vector3 _targetNormal; // 0x14C
	protected Vector3 _targetWallPoint; // 0x158
	protected Transform _climbCenterTrans; // 0x168
	private const int HEIGHT_MAP_POINT_NUMER = 25; // Metadata: 0x00AEBAD3
	private const int HEIGHT_MAP_MAX_ITERATION_TIME = 3; // Metadata: 0x00AEBAD7
	private const float HEIGHT_MAP_WIDTH = 0.8f; // Metadata: 0x00AEBADB
	private const float HEIGHT_MAP_DEPTH = 0.4f; // Metadata: 0x00AEBADF
	private HeightMapHalton _heightmapHalton; // 0x170
	protected bool _stateExit; // 0x178
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected float _moveTargetUnitDist; // 0x17C
	protected Vector3 _localDir; // 0x180
	protected float _MoveDistance; // 0x18C
	public float _maxRotateSpeed; // 0x190
	protected const float BACK_DETECT_DIST = 0.03f; // Metadata: 0x00AEBAE3
	protected const float CLLIMB_JUMP_CLAMP_SPEED = 9f; // Metadata: 0x00AEBAE7
	protected const float CLIMB_DOWN_GOUPSTAIR_THRESHOLD = 0.25f; // Metadata: 0x00AEBAEB
	protected const float CLIMB_DOWN_DETECT_DISTANCE = 0.1f; // Metadata: 0x00AEBAEF
	protected Vector3 _curFootGroundNormal; // 0x194
	private Vector3 _curDetectGroundNormal; // 0x1A0
	protected float _curDetectGroundDistance; // 0x1AC
	protected bool _climbEnableCloseToWall; // 0x1B0
	protected float _detectDistance; // 0x1B4
	protected bool _lastIsInClimbJump; // 0x1B8
	private bool _enterErrorDodrop; // 0x1B9
	private bool _calcTargetWhenEnterFirstCheck; // 0x1BA
	private bool _airEnterStayinplace; // 0x1BB
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private const float CLIMB_ROTATE_RATIO = 0.6f; // Metadata: 0x00AEBAF3
	private const float MOVE_FORWARD_FAST_ROTATE_RATIO = 15f; // Metadata: 0x00AEBAF7
	private const float ClIMB_DEFAULT_MOVE_SPEED = 0.5f; // Metadata: 0x00AEBAFB
	private const float CLIMB_JUMP_ROTATE_RATIO = 1.8f; // Metadata: 0x00AEBAFF
	private const float ROTATATION_MAX_ANGLE_NOT_JUMP = 120f; // Metadata: 0x00AEBB03
	private const float ROTATATION_MAX_ANGLE_JUMP = 100f; // Metadata: 0x00AEBB07
	private bool _jumpTriggered; // 0x1BC
	private float _jumpUpVelocity; // 0x1C0
	private Collider _currentRockGadgetCol; // 0x1C8
	protected bool _onRockGadget; // 0x1D0
	private const float FULL_DIR_MOLD_THRESHOLD = 0.8f; // Metadata: 0x00AEBB0B
	private const float EIGHT_DIR_MOLD_THRESHOLD = 0.5f; // Metadata: 0x00AEBB0F
	private const float FOUR_DIR_MOLD_THRESHOLD = 0.2f; // Metadata: 0x00AEBB13
	private const float MOLD_SMOOTH = 0.05f; // Metadata: 0x00AEBB17
	private float[] _smoothedThershold; // 0x1D8
	private ClimbInputMold _lastMold; // 0x1E0
	private const float DOWNWARD_MAXDISTANCE_THRESHOLD = 0.1f; // Metadata: 0x00AEBB1B
	private float _jumpRawJoystickAngle; // 0x1E4
	private bool _updateClimbJumpSub; // 0x1E8
	private float _climbJumpSub; // 0x1EC
	private const float CLIMB_JUMP_SUB_BLEND_SPEED = 15f; // Metadata: 0x00AEBB1F
	private const float MIN_CLIMB_JUMP_UPSTAIR_BLEND_SPEED = 0f; // Metadata: 0x00AEBB23
	private Vector3 lhsDir; // 0x1F0
	private Vector3 rhsDir; // 0x1FC
	private Vector3 crossNormal; // 0x208
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _blendSpeed; // 0x214
	private Vector2 _targetClimbPose; // 0x218
	private Vector2 _currentClimbPose; // 0x220
	private int _ClimbMoveState; // 0x228
	private int _climbMove0StateHash; // 0x22C
	private int _climbMove1StateHash; // 0x230
	private bool _reachClimbSyncTask; // 0x234
	private bool _syncWaitClimbJump; // 0x235
	private Vector3 _targetPointLast; // 0x238
	private Vector3 _targetWallPointLast; // 0x244
	private Vector3 _targetUpLast; // 0x250
	private Vector3 _targetUp; // 0x25C
	private float _syncTaskDist; // 0x268
	private float _syncCurrentDist; // 0x26C

	// Nested types
	private enum ClimbInputMold // TypeDefIndex: 14656
	{
		stayInPlace = 0,
		fourDir = 1,
		eightDir = 2,
		full = 3
	}

	// Constructors
	public HumanoidMoveFSMClimbState() {} // Dummy constructor
	public HumanoidMoveFSMClimbState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x0000000182FAA570-0x0000000182FAA710

	// Methods
	// [XID] // 0x00000001897572C0-0x00000001897572E0
	public override void InitSyncWithCurrentTask(bool setPosition) {} // 0x0000000182FA73B0-0x0000000182FA7600
	// [XID] // 0x000000018975EA90-0x000000018975EAB0
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x0000000182FA8940-0x0000000182FA9160
	// [IDTag] // 0x000000018976D7C0-0x000000018976D800
	// [XID] // 0x000000018976D7C0-0x000000018976D800
	protected void CalcTargetWhenEnter(Vector3 pos, Vector3 center) {} // 0x0000000182FA13D0-0x0000000182FA1F50
	// [IDTag] // 0x0000000189777D90-0x0000000189777DD0
	// [XID] // 0x0000000189777D90-0x0000000189777DD0
	protected virtual void CalcTargetWhenEnter(Vector3 pos) {} // 0x0000000182FA1F50-0x0000000182FA2070
	// [XID] // 0x0000000189782920-0x0000000189782940
	public override void Exit(HumanoidMoveFSM.FSMStateID nextState) {} // 0x0000000182FA82A0-0x0000000182FA85F0
	// [XID] // 0x0000000189789B90-0x0000000189789BB0
	public override void LateTick() {} // 0x0000000182FA45B0-0x0000000182FA4E90
	// [IDTag] // 0x0000000189791390-0x00000001897913D0
	// [XID] // 0x0000000189791390-0x00000001897913D0
	protected void MoveTarget() {} // 0x0000000182FA2260-0x0000000182FA24B0
	// [IDTag] // 0x000000018979C410-0x000000018979C450
	// [XID] // 0x000000018979C410-0x000000018979C450
	protected virtual void MoveTarget(float distance) {} // 0x0000000182FA24B0-0x0000000182FA3290
	// [XID] // 0x00000001897A6920-0x00000001897A6940
	protected virtual void MoveTowardsTarget() {} // 0x0000000182FA6C80-0x0000000182FA6FF0
	// [XID] // 0x00000001897AE060-0x00000001897AE080
	protected virtual void MovePositionAndRotationByCenter(Vector3 position, Vector3 forward, float dist) {} // 0x0000000182FA9930-0x0000000182FA9DE0
	// [XID] // 0x00000001897B60D0-0x00000001897B60F0
	protected void CheckRockGadget(Collider col) {} // 0x0000000182FA6FF0-0x0000000182FA70E0
	// [XID] // 0x00000001897BDF00-0x00000001897BDF20
	protected bool CheckRockGadgetDisapperDrop() => default; // 0x0000000182FAA400-0x0000000182FAA570
	// [IDTag] // 0x00000001897C54C0-0x00000001897C5500
	// [XID] // 0x00000001897C54C0-0x00000001897C5500
	public override void TrySteer(bool isMoving, float joystickAngle) {} // 0x0000000182FAA010-0x0000000182FAA400
	// [IDTag] // 0x00000001897CFBD0-0x00000001897CFC10
	// [XID] // 0x00000001897CFBD0-0x00000001897CFC10
	public override void TrySteer(Vector3 targetDir) {} // 0x0000000182FA9F20-0x0000000182FAA010
	// [XID] // 0x00000001897DA800-0x00000001897DA820
	public override bool CanDoJump() => default; // 0x0000000182FA3540-0x0000000182FA3620
	// [XID] // 0x00000001897E1C20-0x00000001897E1C40
	public virtual bool CanDoSlip() => default; // 0x0000000182FA0490-0x0000000182FA0540
	// [XID] // 0x00000001897E9410-0x00000001897E9430
	public override void DoJump() {} // 0x0000000182FA3BE0-0x0000000182FA3FF0
	// [XID] // 0x00000001897F0FE0-0x00000001897F1000
	public bool IsInClimbIdle() => default; // 0x0000000182FA05F0-0x0000000182FA0710
	// [XID] // 0x00000001897F8860-0x00000001897F8880
	public override bool IsInMove() => default; // 0x0000000182F99250-0x0000000182F993F0
	// [XID] // 0x00000001897FFF20-0x00000001897FFF40
	public bool IsInClimbMove() => default; // 0x0000000182FA2070-0x0000000182FA2160
	// [XID] // 0x0000000189807620-0x0000000189807640
	public void TriggerJumpOffWall() {} // 0x0000000182F9D620-0x0000000182F9D930
	// [XID] // 0x000000018980ECC0-0x000000018980ECE0
	public override bool EnableClimbIK() => default; // 0x0000000182FA0540-0x0000000182FA05F0
	// [XID] // 0x0000000189816330-0x0000000189816350
	protected virtual void GetTargetDir() {} // 0x0000000182FA02A0-0x0000000182FA0490
	// [XID] // 0x000000018981DCF0-0x000000018981DD10
	private void AngleToDir(out Vector3 dir, float angle) {
		dir = default;
	} // 0x0000000182F9D990-0x0000000182F9DAB0
	// [XID] // 0x00000001898250E0-0x0000000189825100
	protected override void CalcMoveState() {} // 0x0000000182FA8710-0x0000000182FA8940
	// [XID] // 0x000000018982CAD0-0x000000018982CAF0
	protected void CheckClimbDownToSwim() {} // 0x0000000182FA08C0-0x0000000182FA0FC0
	// [XID] // 0x0000000189834200-0x0000000189834220
	protected bool CheckClimbDownFromFoot() => default; // 0x0000000182F9BA10-0x0000000182F9C770
	// [XID] // 0x000000018983B590-0x000000018983B5B0
	protected override int CalcRaycastResult(Vector3 hitPos, Vector3 hitNormal) => default; // 0x0000000182F990F0-0x0000000182F99250
	// [XID] // 0x0000000189842F90-0x0000000189842FB0
	public override void OnAnimatorMove() {} // 0x0000000182F9D280-0x0000000182F9D570
	// [XID] // 0x000000018984A1B0-0x000000018984A1D0
	protected override void SetAnimIdle() {} // 0x0000000182FA2160-0x0000000182FA2200
	// [XID] // 0x0000000189851830-0x0000000189851850
	protected override void SetAnimMove() {} // 0x0000000182F9DAB0-0x0000000182F9DB50
	// [XID] // 0x0000000189858E90-0x0000000189858EB0
	protected override Ray GetDownwardRay(Vector3 targetPos) => default; // 0x0000000182F9AC80-0x0000000182F9AFF0
	// [XID] // 0x0000000189860050-0x0000000189860070
	protected override Ray GetGroundRay(Vector3 targetPos) => default; // 0x0000000182F9C9F0-0x0000000182F9CC20
	// [XID] // 0x0000000189867770-0x0000000189867790
	protected override bool CheckDropUseStartSpeed() => default; // 0x0000000182F97DC0-0x0000000182F97E70
	// [XID] // 0x000000018986EE00-0x000000018986EE20
	protected override void DoSteer() {} // 0x0000000182FA4E90-0x0000000182FA4F40
	// [XID] // 0x0000000189876330-0x0000000189876350
	protected override bool GetDownwardHitNormalAndPos(Vector3 targetPos, out Vector3 normal, out Vector3 hitPoint, Color color) {
		normal = default;
		hitPoint = default;
		return default;
	} // 0x0000000182F9FD60-0x0000000182FA0030
	// [XID] // 0x000000018987DED0-0x000000018987DEF0
	private bool GetDownwardHitNormalAndPosFromHead(out Vector3 normal, out Vector3 hitPoint, out float hitDistance) {
		normal = default;
		hitPoint = default;
		hitDistance = default;
		return default;
	} // 0x0000000182FA3620-0x0000000182FA38B0
	// [XID] // 0x0000000189884F40-0x0000000189884F60
	private bool GetDownwardHitNormalAndPosFromFoot(out Vector3 normal, out Vector3 hitPoint) {
		normal = default;
		hitPoint = default;
		return default;
	} // 0x0000000182F97B20-0x0000000182F97DC0
	// [XID] // 0x000000018988C540-0x000000018988C560
	private bool GetBackwardHitNormalAndPosFromHead(Vector3 backward, out Vector3 normal, out Vector3 hitPoint) {
		normal = default;
		hitPoint = default;
		return default;
	} // 0x0000000182F9F260-0x0000000182F9F410
	// [XID] // 0x0000000189893AD0-0x0000000189893AF0
	private Ray GetBackwardRayFromHead(Vector3 backward) => default; // 0x0000000182FA0030-0x0000000182FA02A0
	// [XID] // 0x000000018989B1D0-0x000000018989B1F0
	protected bool CheckAndDoTransfer2Standby() => default; // 0x0000000182F9A5A0-0x0000000182F9AC80
	// [XID] // 0x00000001898A25B0-0x00000001898A25D0
	protected virtual bool Transfer2StandbyCheckForward(Vector3 hitNormal, Vector3 hitPos) => default; // 0x0000000182FA9290-0x0000000182FA95A0
	// [XID] // 0x00000001898A9BA0-0x00000001898A9BC0
	protected bool CheckTransfer2StandbyPosValid(ref Vector3 hitNormal, ref Vector3 hitPos) => default; // 0x0000000182F99D70-0x0000000182F9A400
	// [XID] // 0x00000001898B1610-0x00000001898B1630
	protected void CalcExitClimb(bool jumpOffWall, bool climbdown = false /* Metadata: 0x00AEBAD1 */) {} // 0x0000000182FA50E0-0x0000000182FA6C80
	// [XID] // 0x00000001898B8F80-0x00000001898B8FA0
	public override void CalcExitClimbFromCombat() {} // 0x0000000182F9DB50-0x0000000182F9EEC0
	// [XID] // 0x00000001898C0520-0x00000001898C0540
	protected override void Reset() {} // 0x0000000182F9C830-0x0000000182F9C990
	// [XID] // 0x00000001898C7D40-0x00000001898C7D60
	protected void CheckSafePosition() {} // 0x0000000182F99810-0x0000000182F99D70
	// [XID] // 0x00000001898CF560-0x00000001898CF580
	protected void SetInitSafeExitClimbPosition() {} // 0x0000000182FA3390-0x0000000182FA3490
	// [XID] // 0x00000001898D6D90-0x00000001898D6DB0
	public bool IsInStandby2Climb() => default; // 0x0000000182FA3490-0x0000000182FA3540
	// [XID] // 0x00000001898DEB90-0x00000001898DEBB0
	private void SetAnimStandyBy2Climb() {} // 0x0000000182FA9DE0-0x0000000182FA9EC0
	// [XID] // 0x00000001898E6250-0x00000001898E6270
	protected bool IsInJumpUpWallForStandby() => default; // 0x0000000182F97E70-0x0000000182F97F20
	// [XID] // 0x00000001898EDB20-0x00000001898EDB40
	private bool IsInSlipLit() => default; // 0x0000000182FA0710-0x0000000182FA0850
	// [XID] // 0x00000001898F5430-0x00000001898F5450
	private void TriggerClimbJump() {} // 0x0000000182F9F410-0x0000000182F9FD60
	// [XID] // 0x00000001898FCB60-0x00000001898FCB80
	private void UpdateClimbJump() {} // 0x0000000182F993F0-0x0000000182F99810
	// [XID] // 0x0000000189904560-0x0000000189904580
	private void OnClimbJumpToClimbIdle(int nextState) {} // 0x0000000182F9D570-0x0000000182F9D620
	// [XID] // 0x000000018981F750-0x000000018981F770
	private bool IsInClimbJumpTag() => default; // 0x0000000182FA85F0-0x0000000182FA8710
	// [XID] // 0x0000000189913700-0x0000000189913720
	protected Vector3 GetReferenceForward(Vector3 origin, Vector3 direction, float dist, bool filter = false /* Metadata: 0x00AEBAD2 */) => default; // 0x0000000182F98590-0x0000000182F98AE0
	// [XID] // 0x000000018991B020-0x000000018991B040
	protected Vector3 GetReferenceForwardUseLinearRegression(Vector3 origin, Vector3 direction, float dist) => default; // 0x0000000182F9AFF0-0x0000000182F9B840
	// [XID] // 0x0000000189922650-0x0000000189922670
	private void CompareLHS(Vector3 direction) {} // 0x0000000182F9A400-0x0000000182F9A5A0
	// [XID] // 0x0000000189929DC0-0x0000000189929DE0
	private void CompareRHS(Vector3 direction) {} // 0x0000000182FA4F40-0x0000000182FA50E0
	// [XID] // 0x0000000189931510-0x0000000189931530
	protected virtual bool IsUpHill() => default; // 0x0000000182FA3290-0x0000000182FA3390
	// [XID] // 0x0000000189938BC0-0x0000000189938BE0
	protected virtual bool IsDownHill() => default; // 0x0000000182FA1250-0x0000000182FA1360
	// [XID] // 0x0000000189940390-0x00000001899403B0
	public bool CurrentIsInClimbIdleMove() => default; // 0x0000000182F9EF40-0x0000000182F9F0A0
	// [XID] // 0x0000000189817E80-0x0000000189817EA0
	public bool IsInClimbJump() => default; // 0x0000000182F98F80-0x0000000182F99040
	// [XID] // 0x000000018994F130-0x000000018994F150
	public Vector3 GetCurrentWallNormal() => default; // 0x0000000182FA7660-0x0000000182FA7740
	// [XID] // 0x0000000189956640-0x0000000189956660
	protected void ResetClimbPoseParameter() {} // 0x0000000182FA9160-0x0000000182FA9220
	// [XID] // 0x000000018995E150-0x000000018995E170
	protected void SetClimbPoseImmediately(float hor, float ver) {} // 0x0000000182F9F0A0-0x0000000182F9F190
	// [XID] // 0x0000000189965A80-0x0000000189965AA0
	private void HandleBlendClimbVerHor() {} // 0x0000000182FA3FF0-0x0000000182FA45B0
	// [XID] // 0x000000018996D0E0-0x000000018996D100
	private void SetPoseParamsToAnimator() {} // 0x0000000182F98B90-0x0000000182F98F80
	// [XID] // 0x00000001899749F0-0x0000000189974A10
	protected override MotionState GetCurrentSyncMotionState() => default; // 0x0000000182F98AE0-0x0000000182F98B90
	// [XID] // 0x000000018997BEE0-0x000000018997BF00
	public override void SyncLateTick() {} // 0x0000000182FA7740-0x0000000182FA82A0
	// [XID] // 0x0000000189983AF0-0x0000000189983B10
	protected void ProcessToOtherSyncState() {} // 0x0000000182F9CC20-0x0000000182F9D280
	// [XID] // 0x000000018998B3C0-0x000000018998B3E0
	private void CalculateCurrentSyncParams() {} // 0x0000000182FA95A0-0x0000000182FA97A0
	// [XID] // 0x0000000189992F80-0x0000000189992FA0
	protected void MovePositionAndRotationByCenterSync() {} // 0x0000000182F97F20-0x0000000182F98590
	// [XID] // 0x000000018999AA70-0x000000018999AA90
	public override void CreateSyncTaskByTimeInterval() {} // 0x0000000182FA0FC0-0x0000000182FA1250
	// [XID] // 0x00000001899A21B0-0x00000001899A21D0
	public override void ShiftWorld(bool isRemote, Vector3 deltaShift) {} // 0x0000000182FA70E0-0x0000000182FA73B0
		P1 = default;
		P2 = default;
		return default;
	} // 0x0000000182F9F190-0x0000000182F9F260
}

