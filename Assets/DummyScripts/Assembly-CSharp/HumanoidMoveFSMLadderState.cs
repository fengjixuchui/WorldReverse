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

public sealed class HumanoidMoveFSMLadderState : HumanoidMoveFSMBaseMoveState // TypeDefIndex: 14675
{
	// Fields
	private const float UPDATE_TO_LADDER_VELOCITY = 3f; // Metadata: 0x00AEBC68
	private const float UPDATE_TO_LADDER_ROTATION_SPEED = 180f; // Metadata: 0x00AEBC6C
	private const float UPDATE_TO_LADDER_MIN_TIME = 0.2f; // Metadata: 0x00AEBC70
	private const float LADDER_SLIP_DOWN_SPEED = 1f; // Metadata: 0x00AEBC74
	private const float UP_STEER_ANGLE = 65f; // Metadata: 0x00AEBC78
	private const float DOWN_STEER_ANGLE = 115f; // Metadata: 0x00AEBC7C
	private const float WATER_TO_LADDER_GO_UP_STEP = 4f; // Metadata: 0x00AEBC80
	private bool _updateToLadder; // 0x140
	private bool _goUp; // 0x141
	private bool _tryGoUp; // 0x142
	private bool _isInLadderSlip; // 0x143
	private bool _isInLadderSlipStop; // 0x144
	private bool _forceIdleNormalizedTime; // 0x145
	private int _ladderMoveState; // 0x148
	private Vector3 _currentLadderPos; // 0x14C
	private Vector3 _ladderForward; // 0x158
	private MonoLadderConfigHelper _ladder; // 0x168
	private float _updateToLadderTime; // 0x170
	private float _updateToLadderAngle; // 0x174
	private float _updateToLadderCurTime; // 0x178
	private float _closeToLadderDist; // 0x17C
	private float _lastNormalizedtime; // 0x180
	private float _lastRawIsMoving; // 0x184
	private Vector3 _updateToLadderDir; // 0x188
	private int _ladderMove0StateHash; // 0x194
	private int _ladderMove1StateHash; // 0x198

	// Constructors
	public HumanoidMoveFSMLadderState() {} // Dummy constructor
	public HumanoidMoveFSMLadderState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x00000001823B7200-0x00000001823B72C0

	// Methods
	// [XID] // 0x0000000189A50760-0x0000000189A50780
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x00000001823B6720-0x00000001823B6DA0
	// [XID] // 0x0000000189A5F870-0x0000000189A5F890
	public override void TrySteer(bool isMoving, float joystickAngle) {} // 0x00000001823B70B0-0x00000001823B7200
	// [XID] // 0x0000000189A67150-0x0000000189A67170
	public override void LateTick() {} // 0x00000001823B5760-0x00000001823B5980
	// [XID] // 0x0000000189A6E7E0-0x0000000189A6E800
	private void SetPoseParamsToAnimator() {} // 0x00000001823B3700-0x00000001823B39C0
	// [XID] // 0x0000000189A76070-0x0000000189A76090
	private void UpdateToLadder() {} // 0x00000001823B3F60-0x00000001823B4710
	// [XID] // 0x0000000189A7DA60-0x0000000189A7DA80
	protected override void CalcMoveState() {} // 0x00000001823B5BE0-0x00000001823B6720
	// [XID] // 0x0000000189A85290-0x0000000189A852B0
	protected override void SetAnimIdle() {} // 0x00000001823B5000-0x00000001823B50F0
	// [XID] // 0x0000000189A8CD40-0x0000000189A8CD60
	private bool IsInLadderIdle() => default; // 0x00000001823B4D00-0x00000001823B4E20
	// [XID] // 0x0000000189A94030-0x0000000189A94050
	protected override void SetAnimMove() {} // 0x00000001823B4770-0x00000001823B4860
	// [XID] // 0x0000000189A9B9E0-0x0000000189A9BA00
	public override void Exit(HumanoidMoveFSM.FSMStateID nextState) {} // 0x00000001823B5A90-0x00000001823B5BE0
	// [XID] // 0x0000000189AA2EC0-0x0000000189AA2EE0
	public override void OnAnimatorMove() {} // 0x00000001823B3EC0-0x00000001823B3F60
	// [XID] // 0x0000000189AAA410-0x0000000189AAA430
	public override void DoJump() {} // 0x00000001823B5390-0x00000001823B5760
	// [XID] // 0x0000000189AB2230-0x0000000189AB2250
	public override bool CanDoJump() => default; // 0x00000001823B5150-0x00000001823B5220
	// [XID] // 0x0000000189AB9700-0x0000000189AB9720
	private void DoSlip() {} // 0x00000001823B3DC0-0x00000001823B3EC0
	// [XID] // 0x0000000189AC1290-0x0000000189AC12B0
	private void StopSlip() {} // 0x00000001823B6E10-0x00000001823B70B0
	// [XID] // 0x0000000189AC8BA0-0x0000000189AC8BC0
	private void UpdateLadderSlip() {} // 0x00000001823B4860-0x00000001823B4A70
	// [XID] // 0x0000000189AD0360-0x0000000189AD0380
	private bool CheckBottom() => default; // 0x00000001823B3AF0-0x00000001823B3D60
	// [XID] // 0x0000000189AD7FB0-0x0000000189AD7FD0
	private bool CheckTop() => default; // 0x00000001823B4A70-0x00000001823B4D00
	// [XID] // 0x0000000189ADFC80-0x0000000189ADFCA0
	private bool CheckClimbDownToSwim() => default; // 0x00000001823B4E90-0x00000001823B5000
	// [XID] // 0x0000000189AE7360-0x0000000189AE7380
	protected override MotionState GetCurrentSyncMotionState() => default; // 0x00000001823B3660-0x00000001823B3700
	// [XID] // 0x0000000189AEF050-0x0000000189AEF070
	public override void SyncLateTick() {} // 0x00000001823B59E0-0x00000001823B5A90
}

