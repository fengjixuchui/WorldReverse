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

public sealed class HumanoidMoveFSMCrouchState : HumanoidMoveFSMMoveState // TypeDefIndex: 14660
{
	// Fields
	private bool _crouchRollTriggered; // 0x1D8

	// Constructors
	public HumanoidMoveFSMCrouchState() {} // Dummy constructor
	public HumanoidMoveFSMCrouchState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x00000001810CB250-0x00000001810CB310

	// Methods
	// [XID] // 0x0000000189AFC140-0x0000000189AFC160
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x00000001810CAE70-0x00000001810CB1E0
	// [XID] // 0x0000000189B0B0C0-0x0000000189B0B0E0
	public override void LateTick() {} // 0x00000001810CA950-0x00000001810CACA0
	// [XID] // 0x0000000189B12990-0x0000000189B129B0
	protected override void DealMoveResult() {} // 0x00000001810CA220-0x00000001810CA470
	// [XID] // 0x0000000189B19C20-0x0000000189B19C40
	public override void Exit(HumanoidMoveFSM.FSMStateID nextState) {} // 0x00000001810CAD60-0x00000001810CAE70
	// [XID] // 0x0000000189B21250-0x0000000189B21270
	protected override void SetAnimIdle() {} // 0x00000001810CA4E0-0x00000001810CA5D0
	// [XID] // 0x0000000189B28AC0-0x0000000189B28AE0
	protected override void SetAnimMove() {} // 0x00000001810CA070-0x00000001810CA220
	// [XID] // 0x0000000189B2FED0-0x0000000189B2FEF0
	public override void DoJump() {} // 0x00000001810CA860-0x00000001810CA950
	// [XID] // 0x0000000189B37780-0x0000000189B377A0
	public override bool CanDoJump() => default; // 0x00000001810CA5D0-0x00000001810CA7E0
	// [XID] // 0x0000000189B3F070-0x0000000189B3F090
	public bool IsInCrouchRoll() => default; // 0x00000001810C9DA0-0x00000001810C9EE0
	// [XID] // 0x0000000189B46960-0x0000000189B46980
	protected override MotionState GetCurrentSyncMotionState() => default; // 0x00000001810C9CA0-0x00000001810C9DA0
}

