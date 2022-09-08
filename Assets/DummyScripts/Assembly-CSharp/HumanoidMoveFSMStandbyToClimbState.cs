/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HumanoidMoveFSMStandbyToClimbState : HumanoidMoveFSMClimbState // TypeDefIndex: 14681
{
	// Fields
	private const float PRE_MOVE_TIME = 0.1f; // Metadata: 0x00AEBD33
	private const float KEEP_SLIP_SPEED = 1f; // Metadata: 0x00AEBD37
	private const float CLIMB_HEAD_UP_DIST = 0.2f; // Metadata: 0x00AEBD3B
	private float _preMoveAngle; // 0x270
	private Vector3 _preMoveDir; // 0x274
	private float _preMoveTime; // 0x280
	private float _animCloseToGroundDist; // 0x284
	private bool _preMoveFinished; // 0x288
	private bool _startPartB; // 0x289
	private Quaternion _animationRotation; // 0x28C
	private Vector3 _climbCenterOriginalPosition; // 0x29C
	private Vector3 _headOriginalPosition; // 0x2A8
	private bool _originalPositionInitialized; // 0x2B4
	private bool _startCheckClimbDownFromFoot; // 0x2B5
	private const float START_CHECK_CLIMB_DOWN_FROM_FOOT_MIN_DIST = 0.5f; // Metadata: 0x00AEBD3F
	private float _sumMovedist; // 0x2B8
	private bool _centerReachPosition; // 0x2BC
	private float _centerMoveDist; // 0x2C0
	private Vector3 _centerMoveUpDir; // 0x2C4
	private int _standby2ClimbAStateHash; // 0x2D0
	private int _standby2ClimbBStateHash; // 0x2D4
	private bool _onStandby2ClimbEnd; // 0x2D8
	private float _animationRotationAngle; // 0x2DC

	// Constructors
	public HumanoidMoveFSMStandbyToClimbState() {} // Dummy constructor
	public HumanoidMoveFSMStandbyToClimbState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x000000018208E520-0x000000018208E600

	// Methods
	// [XID] // 0x000000018995FA10-0x000000018995FA30
	protected override void Reset() {} // 0x000000018208A940-0x000000018208AA60
	// [XID] // 0x00000001899672D0-0x00000001899672F0
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x000000018208D7C0-0x000000018208E230
	// [XID] // 0x0000000189976010-0x0000000189976030
	public override void LateTick() {} // 0x000000018208C040-0x000000018208CF20
	// [XID] // 0x000000018997D2E0-0x000000018997D300
	private void CalcTargetWhenEnter(Vector3 pos, Vector3 center, Vector3 hitnormal) {} // 0x000000018208B660-0x000000018208BCF0
	// [XID] // 0x0000000189984E80-0x0000000189984EA0
	protected override void CalcMoveState() {} // 0x000000018208D500-0x000000018208D7C0
	// [XID] // 0x000000018998CA80-0x000000018998CAA0
	protected override bool Transfer2StandbyCheckForward(Vector3 hitNormal, Vector3 hitPos) => default; // 0x000000018208E230-0x000000018208E330
	// [XID] // 0x0000000189994740-0x0000000189994760
	public override void OnAnimatorMove() {} // 0x000000018208AB70-0x000000018208B1D0
	// [XID] // 0x000000018999BFF0-0x000000018999C010
	protected override void GetTargetDir() {} // 0x000000018208B320-0x000000018208B400
	// [XID] // 0x00000001899A38A0-0x00000001899A38C0
	public override void TrySteer(bool isMoving, float joystickAngle) {} // 0x000000018208E400-0x000000018208E4C0
	// [XID] // 0x00000001899AB3D0-0x00000001899AB3F0
	public void OnStandby2ClimbEnd() {} // 0x000000018208B240-0x000000018208B320
	// [XID] // 0x00000001899B2E30-0x00000001899B2E50
	protected override bool IsUpHill() => default; // 0x000000018208BD50-0x000000018208BDF0
	// [XID] // 0x00000001899B9F30-0x00000001899B9F50
	protected override bool IsDownHill() => default; // 0x000000018208B5C0-0x000000018208B660
	// [XID] // 0x00000001899C1B20-0x00000001899C1B40
	public override bool EnableClimbIK() => default; // 0x000000018208B400-0x000000018208B520
	// [XID] // 0x00000001899C8F20-0x00000001899C8F40
	protected override MotionState GetCurrentSyncMotionState() => default; // 0x000000018208A7E0-0x000000018208A880
	// [XID] // 0x00000001899D0A20-0x00000001899D0A40
	public override void SyncLateTick() {} // 0x000000018208CF20-0x000000018208D500
	// [XID] // 0x00000001899D7E50-0x00000001899D7E70
	public override void CreateSyncTaskByTimeInterval() {} // 0x000000018208B520-0x000000018208B5C0
}

