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

public sealed class HumanoidMoveFSMJumpState : HumanoidMoveFSMAirState // TypeDefIndex: 14671
{
	// Fields
	private bool _hasJumpEnd; // 0x188
	private JumpType _jumpType; // 0x18C
	private bool _stopAnimatorMove; // 0x190
	private float _jumpEnterY; // 0x194
	private float _headHitDetectDist; // 0x198
	private Vector3 _jumpEnterMoveScenePropVelocity; // 0x19C
	private bool _jumpEnterMoveSceneProp; // 0x1A8
	private bool _velocityUpSet; // 0x1A9
	private float _rocketJumpSettingXZMultiplier; // 0x1AC
	private float _rocketJumpSettingYMultiplier; // 0x1B0

	// Nested types
	public enum JumpType // TypeDefIndex: 14672
	{
		jump = 0,
		jumpForWalk = 1,
		jumpForRun = 2,
		jumpForSprint = 3
	}

	// Constructors
	public HumanoidMoveFSMJumpState() {} // Dummy constructor
	public HumanoidMoveFSMJumpState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x000000018240A500-0x000000018240A5E0

	// Methods
	// [XID] // 0x00000001898F0C80-0x00000001898F0CA0
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x00000001824097E0-0x0000000182409FB0
	// [XID] // 0x00000001898FFDA0-0x00000001898FFDC0
	protected override void InitAir(bool applyGravity, bool enableLand, bool enableClimb, HumanoidMoveFSM.FSMStateID formerStateId) {} // 0x0000000182408E70-0x00000001824096A0
	// [XID] // 0x0000000189907540-0x0000000189907560
	private void AuthorityCheckJumpTypeCombat() {} // 0x00000001824065A0-0x00000001824066A0
	// [XID] // 0x000000018990EE70-0x000000018990EE90
	private void AuthorityCheckJumpTypeNormal(HumanoidMoveFSM.FSMStateID formerStateId) {} // 0x00000001824083E0-0x0000000182408A50
	// [XID] // 0x0000000189916700-0x0000000189916720
	protected override bool DealAirJump() => default; // 0x00000001824072E0-0x0000000182407430
	// [XID] // 0x000000018991DEB0-0x000000018991DED0
	public override void LateTick() {} // 0x0000000182408B70-0x0000000182408E70
	// [XID] // 0x00000001899257A0-0x00000001899257C0
	public override void OnAnimatorMove() {} // 0x0000000182406DC0-0x0000000182407130
	// [XID] // 0x000000018992CC10-0x000000018992CC30
	private bool CheckHeadHitUp() => default; // 0x0000000182407F00-0x0000000182408150
	// [XID] // 0x0000000189934140-0x0000000189934160
	protected override void DealMoveResultForward(StepAndClimbInfo info) {} // 0x00000001824074F0-0x0000000182407E90
	// [XID] // 0x000000018993BE50-0x000000018993BE70
	public void OnJumpEnd() {} // 0x00000001824067B0-0x00000001824068B0
	// [XID] // 0x00000001899431B0-0x00000001899431D0
	public override void OnStopAnimatorMoveTime() {} // 0x000000018240A160-0x000000018240A230
	// [XID] // 0x000000018994A940-0x000000018994A960
	protected override bool GetAddJumpEnterMoveScenePropVelocity() => default; // 0x0000000182407430-0x00000001824074F0
	// [XID] // 0x0000000189952390-0x00000001899523B0
	protected override void DoAddJumpEnterMoveScenePropVelocity(ref Vector3 velocity) {} // 0x000000018240A020-0x000000018240A160
	// [XID] // 0x0000000189959870-0x0000000189959890
	protected override void DealRocketJump(ref Vector3 velocity) {} // 0x0000000182407130-0x0000000182407230
	// [XID] // 0x00000001899610D0-0x00000001899610F0
	protected override Ray GetGroundRay(Vector3 targetPos) => default; // 0x0000000182406BA0-0x0000000182406DC0
	// [XID] // 0x0000000189968870-0x0000000189968890
	protected override bool CheckDropUseStartSpeed() => default; // 0x0000000182406460-0x0000000182406500
	// [XID] // 0x000000018996FE40-0x000000018996FE60
	private void UpdateJump() {} // 0x000000018240A230-0x000000018240A2D0
	// [XID] // 0x0000000189977C10-0x0000000189977C30
	private bool CanTransfer2ClimbState() => default; // 0x0000000182408AD0-0x0000000182408B70
	// [XID] // 0x000000018997EE10-0x000000018997EE30
	public override void Exit(HumanoidMoveFSM.FSMStateID nextState) {} // 0x00000001824096A0-0x0000000182409780
	// [XID] // 0x0000000189986750-0x0000000189986770
	protected override void Reset() {} // 0x00000001824069D0-0x0000000182406B40
	// [XID] // 0x000000018998E330-0x000000018998E350
	protected override MotionState GetCurrentSyncMotionState() => default; // 0x0000000182406500-0x00000001824065A0
	// [XID] // 0x0000000189995E20-0x0000000189995E40
	protected override void CreateFirstSyncPacket() {} // 0x00000001824081C0-0x00000001824083E0
}

