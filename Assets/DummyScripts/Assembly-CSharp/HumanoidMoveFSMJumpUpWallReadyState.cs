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

public sealed class HumanoidMoveFSMJumpUpWallReadyState : HumanoidMoveFSMMoveState // TypeDefIndex: 14674
{
	// Fields
	private bool _onJumpUpWallReadyOver; // 0x1D8
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _faceWallAngularSpeed; // 0x1DC
	private Vector3 _jumpUpWallHitNormal; // 0x1E0
	private Vector3 _jumpUpWallHitPos; // 0x1EC
	private bool _isLadder; // 0x1F8
	private StateJumpUpWallReady _stateJumpUpWallReady; // 0x200

	// Constructors
	public HumanoidMoveFSMJumpUpWallReadyState() {} // Dummy constructor
	public HumanoidMoveFSMJumpUpWallReadyState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x00000001814D8E90-0x00000001814D8F40

	// Methods
	// [XID] // 0x0000000189A06560-0x0000000189A06580
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x00000001814D8850-0x00000001814D8B20
	// [XID] // 0x0000000189A15120-0x0000000189A15140
	public void OnJumpUpWallReadyOver() {} // 0x00000001814D8770-0x00000001814D8850
	// [XID] // 0x0000000189A1C2B0-0x0000000189A1C2D0
	public override void OnAnimatorMove() {} // 0x00000001814D7C70-0x00000001814D7D10
	// [XID] // 0x0000000189A23BF0-0x0000000189A23C10
	public override void LateTick() {} // 0x00000001814D7F10-0x00000001814D8770
	// [XID] // 0x0000000189A2AFA0-0x0000000189A2AFC0
	private bool IsInJumpUpWallForStandbyInterruptZone() => default; // 0x00000001814D8B20-0x00000001814D8C10
	// [XID] // 0x0000000189A32650-0x0000000189A32670
	public override void TrySteer(bool isMoving, float joystickAngle) {} // 0x00000001814D8C80-0x00000001814D8E90
	// [XID] // 0x0000000189A39F50-0x0000000189A39F70
	private bool IsInJumpUpWallForStandbyTag() => default; // 0x00000001814D7D10-0x00000001814D7E00
	// [XID] // 0x0000000189A41800-0x0000000189A41820
	protected override void Reset() {} // 0x00000001814D7B20-0x00000001814D7C10
	// [XID] // 0x0000000189A48DF0-0x0000000189A48E10
	protected override MotionState GetCurrentSyncMotionState() => default; // 0x00000001814D79C0-0x00000001814D7A60
}

