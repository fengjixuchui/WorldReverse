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

public sealed class HumanoidMoveFSMSwimJumpState : HumanoidMoveFSMAirState // TypeDefIndex: 14682
{
	// Fields
	private bool _stopAnimatorMove; // 0x188
	private float _jumpEnterY; // 0x18C

	// Constructors
	public HumanoidMoveFSMSwimJumpState() {} // Dummy constructor
	public HumanoidMoveFSMSwimJumpState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x00000001831EBD80-0x00000001831EBE10

	// Methods
	// [XID] // 0x00000001899DF420-0x00000001899DF440
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x00000001831EB8E0-0x00000001831EBA50
	// [XID] // 0x00000001899EE3B0-0x00000001899EE3D0
	public override void Exit(HumanoidMoveFSM.FSMStateID nextState) {} // 0x00000001831EB7B0-0x00000001831EB880
	// [XID] // 0x00000001899F5D00-0x00000001899F5D20
	public override void LateTick() {} // 0x00000001831EA9E0-0x00000001831EB270
	// [XID] // 0x00000001899FD3F0-0x00000001899FD410
	public override void TrySteer(bool isMoving, float joystickAngle) {} // 0x00000001831EBBF0-0x00000001831EBD80
	// [XID] // 0x0000000189A04A80-0x0000000189A04AA0
	protected override void DoSteer() {} // 0x00000001831EB270-0x00000001831EB5E0
	// [XID] // 0x0000000189A0C130-0x0000000189A0C150
	public override void OnAnimatorMove() {} // 0x00000001831EA130-0x00000001831EA3B0
	// [XID] // 0x0000000189A13AF0-0x0000000189A13B10
	public override void OnStopAnimatorMoveTime() {} // 0x00000001831EBA50-0x00000001831EBB20
	// [XID] // 0x0000000189A1ACB0-0x0000000189A1ACD0
	public override bool CanDoJump() => default; // 0x00000001831EA770-0x00000001831EA8D0
	// [XID] // 0x0000000189A22590-0x0000000189A225B0
	protected override void Reset() {} // 0x00000001831E9F50-0x00000001831EA0D0
	// [XID] // 0x0000000189A298A0-0x0000000189A298C0
	private void FitWaterHeight() {} // 0x00000001831EA3B0-0x00000001831EA600
	// [XID] // 0x0000000189A30D60-0x0000000189A30D80
	protected override MotionState GetCurrentSyncMotionState() => default; // 0x00000001831E9D20-0x00000001831E9DC0
	// [XID] // 0x0000000189A38970-0x0000000189A38990
	public override void SyncLateTick() {} // 0x00000001831EB5E0-0x00000001831EB7B0
	// [XID] // 0x0000000189A40000-0x0000000189A40020
	public override void CreateSyncTaskByTimeInterval() {} // 0x00000001831EA670-0x00000001831EA710
}

