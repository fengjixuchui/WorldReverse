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

public class HumanoidMoveFSMCombatMoveState : HumanoidMoveFSMMoveState // TypeDefIndex: 14659
{
	// Fields
	private bool _enableControl; // 0x1D8
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _followAttackMaxSlope; // 0x1DC
	private bool _canMoveOnSwim; // 0x1E0
	private VCAvatarCombat _vcCombat; // 0x1E8
	protected Vector3 _lastFramePosition; // 0x1F0
	private const float COMBAT_DOWN_RAY_DETECTE_DIST = 1.5f; // Metadata: 0x00AEBB40
	private const float COMBAT_DOWN_RAY_DETECTE_INTERVAL = 0.5f; // Metadata: 0x00AEBB44

	// Properties
	public bool movingOnWater { /* [XID] */ /* 0x0000000189A23C10-0x0000000189A23C50 */ get; /* [XID] */ /* 0x0000000189A2DE40-0x0000000189A2DE80 */ private set; } // 0x0000000182A4FD60-0x0000000182A4FDC0 0x0000000182A4FEE0-0x0000000182A4FF50

	// Constructors
	public HumanoidMoveFSMCombatMoveState() {} // Dummy constructor
	public HumanoidMoveFSMCombatMoveState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x0000000182A52620-0x0000000182A52700

	// Methods
	// [XID] // 0x0000000189A38990-0x0000000189A389B0
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x0000000182A51B50-0x0000000182A51DC0
	// [XID] // 0x0000000189A476A0-0x0000000189A476C0
	public override void Exit(HumanoidMoveFSM.FSMStateID nextState) {} // 0x0000000182A519E0-0x0000000182A51B50
	// [XID] // 0x0000000189A4EE90-0x0000000189A4EEB0
	protected bool GetDownwardHitNormalAndPosWithWater(Vector3 targetPos, float dist, out Vector3 normal, out Vector3 hitPoint, Color color) {
		normal = default;
		hitPoint = default;
		return default;
	} // 0x0000000182A51E20-0x0000000182A52110
	// [XID] // 0x0000000189A56500-0x0000000189A56520
	protected bool GetDownwardHitNormalAndPos(Vector3 targetPos, float dist, out Vector3 normal, out Vector3 hitPoint, Color color) {
		normal = default;
		hitPoint = default;
		return default;
	} // 0x0000000182A4FAE0-0x0000000182A4FD60
	// [XID] // 0x0000000189A5E0D0-0x0000000189A5E0F0
	protected override bool CheckIsCliffImp(Vector3 targetDir, Vector3 targetPos, out Vector3 hitNormal, out Vector3 hitPos, out Vector3 cliffPos, bool modifyDir) {
		hitNormal = default;
		hitPos = default;
		cliffPos = default;
		return default;
	} // 0x0000000182A4E010-0x0000000182A4E890
	// [XID] // 0x0000000189A65880-0x0000000189A658A0
	protected override void CalcMoveStateAfterFixedDir() {} // 0x0000000182A510C0-0x0000000182A51490
	// [XID] // 0x0000000189A6CF90-0x0000000189A6CFB0
	public override void LateTick() {} // 0x0000000182A50CF0-0x0000000182A50E60
	// [XID] // 0x0000000189A746C0-0x0000000189A746E0
	protected override bool CanDoSprint() => default; // 0x0000000182A4FDC0-0x0000000182A4FE80
	// [XID] // 0x0000000189A7C200-0x0000000189A7C220
	protected override void DealSprintBS() {} // 0x0000000182A50660-0x0000000182A507A0
	// [XID] // 0x0000000189A83B60-0x0000000189A83B80
	protected override void DealMoveResult() {} // 0x0000000182A4EFD0-0x0000000182A4F880
	// [XID] // 0x0000000189A8B4F0-0x0000000189A8B510
	protected override void SetAnimIdle() {} // 0x0000000182A50840-0x0000000182A509F0
	// [XID] // 0x0000000189A92AC0-0x0000000189A92AE0
	protected override void SetAnimMove() {} // 0x0000000182A4EB10-0x0000000182A4EEC0
	// [XID] // 0x0000000189A9A540-0x0000000189A9A560
	public override bool CanDoJump() => default; // 0x0000000182A50AB0-0x0000000182A50B70
	// [XID] // 0x0000000189AA15A0-0x0000000189AA15C0
	public override void DoJump() {} // 0x0000000182A50BF0-0x0000000182A50CF0
	// [XID] // 0x0000000189AA8CB0-0x0000000189AA8CD0
	protected override void MoveAlongSurface(Vector3 targetPos, Vector3 targetNormal, bool useTNorm = false /* Metadata: 0x00AEBB3F */) {} // 0x0000000182A500B0-0x0000000182A50660
	// [XID] // 0x0000000189AB08D0-0x0000000189AB08F0
	protected void FitWaterHeight() {} // 0x0000000182A4EEC0-0x0000000182A4EF60
	// [XID] // 0x0000000189AB7EA0-0x0000000189AB7EC0
	protected override void CloseToGround() {} // 0x0000000182A521E0-0x0000000182A52560
	// [XID] // 0x0000000189ABF980-0x0000000189ABF9A0
	protected override bool CheckSwim() => default; // 0x0000000182A50F00-0x0000000182A510C0
	// [XID] // 0x0000000189AC7530-0x0000000189AC7550
	protected override void DoSteer() {} // 0x0000000182A50E60-0x0000000182A50F00
	// [XID] // 0x0000000189ACEAB0-0x0000000189ACEAD0
	public override void OnAnimatorMove() {} // 0x0000000182A4E890-0x0000000182A4EA40
	// [XID] // 0x0000000189AD6A50-0x0000000189AD6A70
	public override void SyncLateTick() {} // 0x0000000182A516E0-0x0000000182A519E0
	// [XID] // 0x0000000189ADE280-0x0000000189ADE2A0
	public override void CreateSyncTaskByTimeInterval() {} // 0x0000000182A507A0-0x0000000182A50840
	// [XID] // 0x0000000189AE5D40-0x0000000189AE5D60
	public override void ShiftWorld(bool isRemote, Vector3 deltaShift) {} // 0x0000000182A51490-0x0000000182A51620
	// [XID] // 0x0000000189AED130-0x0000000189AED150
	protected override void MoveFollowReferenceSystem() {} // 0x0000000182A4F880-0x0000000182A4FAE0
	// [XID] // 0x0000000189AF4BC0-0x0000000189AF4BE0
	protected override MotionState GetCurrentSyncMotionState() => default; // 0x0000000182A4DC80-0x0000000182A4DD20
		P2 = default;
		P3 = default;
		P4 = default;
		return default;
	} // 0x0000000182A4FF50-0x0000000182A50040
}

