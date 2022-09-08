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

public sealed class HumanoidMoveFSMJumpUpWallForStandbyState : HumanoidMoveFSMClimbState // TypeDefIndex: 14673
{
	// Fields
	private bool _onJumpUpWallExit; // 0x270

	// Constructors
	public HumanoidMoveFSMJumpUpWallForStandbyState() {} // Dummy constructor
	public HumanoidMoveFSMJumpUpWallForStandbyState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x00000001820A6B40-0x00000001820A6BD0

	// Methods
	// [XID] // 0x000000018999D8E0-0x000000018999D900
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x00000001820A5B40-0x00000001820A60F0
	// [XID] // 0x00000001899ACC90-0x00000001899ACCB0
	public void OnJumpUpWallExit() {} // 0x00000001820A4D80-0x00000001820A4E60
	// [XID] // 0x00000001899B4430-0x00000001899B4450
	protected override void GetTargetDir() {} // 0x00000001820A4F70-0x00000001820A5050
	// [XID] // 0x00000001899BB8B0-0x00000001899BB8D0
	protected override void MovePositionAndRotationByCenter(Vector3 position, Vector3 forward, float dist) {} // 0x00000001820A63A0-0x00000001820A6990
	// [XID] // 0x00000001899C3510-0x00000001899C3530
	public override void TrySteer(bool isMoving, float joystickAngle) {} // 0x00000001820A69F0-0x00000001820A6AE0
	// [XID] // 0x00000001899CA9A0-0x00000001899CA9C0
	public override bool IsInMove() => default; // 0x00000001820A4CE0-0x00000001820A4D80
	// [XID] // 0x00000001899D1F90-0x00000001899D1FB0
	public override bool EnableClimbIK() => default; // 0x00000001820A5050-0x00000001820A50F0
	// [XID] // 0x00000001899D9690-0x00000001899D96B0
	protected override MotionState GetCurrentSyncMotionState() => default; // 0x00000001820A4C40-0x00000001820A4CE0
	// [XID] // 0x00000001899E0CD0-0x00000001899E0CF0
	public override void LateTick() {} // 0x00000001820A53E0-0x00000001820A55E0
	// [XID] // 0x00000001899E8900-0x00000001899E8920
	public override void SyncLateTick() {} // 0x00000001820A56B0-0x00000001820A5B40
	// [XID] // 0x00000001899EFF80-0x00000001899EFFA0
	public override void CreateSyncTaskByTimeInterval() {} // 0x00000001820A50F0-0x00000001820A5190
	// [XID] // 0x00000001899F75C0-0x00000001899F75E0
	protected override bool Transfer2StandbyCheckForward(Vector3 hitNormal, Vector3 hitPos) => default; // 0x00000001820A60F0-0x00000001820A6330
}

