/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HumanoidMoveFSMTurnDirectionState : HumanoidMoveFSMMoveState // TypeDefIndex: 14684
{
	// Fields
	private bool _turnLeft; // 0x1D8
	private bool _fixDir; // 0x1D9
	private float _turnAngle; // 0x1DC
	private float _turnRatio; // 0x1E0
	private int _dirParamHash; // 0x1E4
	private int _turnTagHash; // 0x1E8
	private int _standbyTagHash; // 0x1EC
	private int _standbyHash; // 0x1F0
	private const float STOP_TURNING_NORMALIZED_TIME = 0.8f; // Metadata: 0x00AEBD77
	private const float MIN_PERFORM_TURN_ANGLE = 15f; // Metadata: 0x00AEBD7B
	private bool _stopped; // 0x1F4

	// Constructors
	public HumanoidMoveFSMTurnDirectionState() {} // Dummy constructor
	public HumanoidMoveFSMTurnDirectionState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x00000001820F7FA0-0x00000001820F80D0

	// Methods
	// [XID] // 0x0000000189B691D0-0x0000000189B691F0
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x00000001820F7DF0-0x00000001820F7F00
	// [XID] // 0x0000000189B77B40-0x0000000189B77B60
	private void EnterTurn() {} // 0x00000001820F6CB0-0x00000001820F7160
	// [XID] // 0x0000000189B7F1C0-0x0000000189B7F1E0
	private bool CheckStopped() => default; // 0x00000001820F71D0-0x00000001820F72F0
	// [XID] // 0x0000000189B86D70-0x0000000189B86D90
	protected override void MoveUpdateTilt() {} // 0x00000001820F7F00-0x00000001820F7FA0
	// [XID] // 0x0000000189B8DF20-0x0000000189B8DF40
	public override bool CanDoJump() => default; // 0x00000001820F7360-0x00000001820F7400
	// [XID] // 0x0000000189B95380-0x0000000189B953A0
	public override void OnAnimatorMove() {} // 0x00000001820F69F0-0x00000001820F6AA0
	// [XID] // 0x0000000189B9CA30-0x0000000189B9CA50
	public override void LateTick() {} // 0x00000001820F7480-0x00000001820F7D40
	// [XID] // 0x0000000189BA40E0-0x0000000189BA4100
	public override void Exit(HumanoidMoveFSM.FSMStateID nextState) {} // 0x00000001820F7D40-0x00000001820F7DF0
	// [XID] // 0x0000000189BAB6D0-0x0000000189BAB6F0
	protected override MotionState GetRawCurrentSyncMotionState() => default; // 0x00000001820F6AA0-0x00000001820F6CB0
}

