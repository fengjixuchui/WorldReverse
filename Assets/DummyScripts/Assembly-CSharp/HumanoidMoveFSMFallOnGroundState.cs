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

public sealed class HumanoidMoveFSMFallOnGroundState : HumanoidMoveFSMMoveState // TypeDefIndex: 14662
{
	// Fields
	private bool _fallToGroundRun; // 0x1D8
	private const float FALL_LIT_SPEED = 0f; // Metadata: 0x00AEBB48
	private const float FALL_MIDDLE_SPEED = 0f; // Metadata: 0x00AEBB4C
	private const float FALL_HARD_SPEED = 0f; // Metadata: 0x00AEBB50
	private bool _updateTilt; // 0x1D9
	private Vector3 colTestUpPos; // 0x1DC
	private Vector3 colTestDownPos; // 0x1E8
	private int _fallSpeedLevel; // 0x1F4

	// Constructors
	public HumanoidMoveFSMFallOnGroundState() {} // Dummy constructor
	public HumanoidMoveFSMFallOnGroundState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x0000000181BF3D00-0x0000000181BF4010

	// Methods
	// [XID] // 0x0000000189BBD1D0-0x0000000189BBD1F0
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x0000000181BF2650-0x0000000181BF3C40
	// [XID] // 0x0000000189BCC920-0x0000000189BCC940
	public void OnStateFallOnGroundEnd() {} // 0x0000000181BF1DF0-0x0000000181BF1F00
	// [XID] // 0x0000000189BD3F70-0x0000000189BD3F90
	protected override void MoveUpdateTilt() {} // 0x0000000181BF3C40-0x0000000181BF3D00
	// [XID] // 0x0000000189BDB8D0-0x0000000189BDB8F0
	public override bool CanDoJump() => default; // 0x0000000181BF1F00-0x0000000181BF2390
	// [XID] // 0x00000001895E8190-0x00000001895E81B0
	public override void OnAnimatorMove() {} // 0x0000000181BF16D0-0x0000000181BF1B00
	// [XID] // 0x00000001895EFA60-0x00000001895EFA80
	protected override void Reset() {} // 0x0000000181BF1550-0x0000000181BF1670
	// [XID] // 0x00000001895F7490-0x00000001895F74B0
	public override void LateTick() {} // 0x0000000181BF2410-0x0000000181BF2580
	// [XID] // 0x00000001895FE7F0-0x00000001895FE810
	public override void Exit(HumanoidMoveFSM.FSMStateID nextState) {} // 0x0000000181BF2580-0x0000000181BF2650
	// [XID] // 0x00000001896061D0-0x00000001896061F0
	protected override MotionState GetRawCurrentSyncMotionState() => default; // 0x0000000181BF1B00-0x0000000181BF1D10
}

