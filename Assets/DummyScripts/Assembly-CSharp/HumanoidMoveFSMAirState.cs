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

public class HumanoidMoveFSMAirState : HumanoidMoveFSMBaseMoveState // TypeDefIndex: 14643
{
	// Fields
	protected const float PUSH_VECTOR_RATIO = 0.03f; // Metadata: 0x00AEB9E0
	protected AnimatorMoveInfo _animatorMoveInfo; // 0x140
	protected AirRigidbody _airRigidbody; // 0x148
	protected bool _applyGravity; // 0x150
	protected bool _enableLand; // 0x151
	protected bool _enableClimb; // 0x152
	protected bool _resultLand; // 0x153
	protected bool _stateExit; // 0x154
	protected const float FLY_MIN_HEIGHT = 1.5f; // Metadata: 0x00AEB9E4
	protected const float MAX_AIR_TO_CLIMB_INPUT_ANGLE = 75f; // Metadata: 0x00AEB9E8
	protected object[] _resultParams; // 0x158
	protected bool _flyGroundDistCheckFail; // 0x160
	protected int _flyGroundDistCheckframe; // 0x164
	protected float _jamTime; // 0x168
	protected Vector3 _jamPos; // 0x16C
	protected const float JAM_RESET_TIME = 5f; // Metadata: 0x00AEB9EC
	protected uint _enterSyncTimeStamp; // 0x178
	protected uint _enterPacketTimeStamp; // 0x17C
	protected bool _needSendSyncTask; // 0x180
	protected bool _waitSetFixTick; // 0x181

	// Properties
	protected Vector3 _courseForward { /* [XID] */ /* 0x0000000189745430-0x0000000189745450 */ get => default; } // 0x00000001812C38C0-0x00000001812C3AB0 

	// Nested types
	protected enum LandSpeedLevel // TypeDefIndex: 14644
	{
		Low = 0,
		Middle = 1,
		High = 2,
		ByVelocity = 3
	}

	protected class AnimatorMoveInfo // TypeDefIndex: 14645
	{
		// Fields
		public Vector3 deltaPostion; // 0x10
		public Quaternion deltaRotation; // 0x1C
		public Vector3 velocity; // 0x2C
		public Vector3 angularVelocity; // 0x38

		// Constructors
		public AnimatorMoveInfo() {} // 0x00000001812E7E20-0x00000001812E7E90

		// Methods
		// [XID] // 0x00000001897D42C0-0x00000001897D42E0
		public void Clean() {} // 0x00000001812E7CD0-0x00000001812E7E20
	}

	// Constructors
	public HumanoidMoveFSMAirState() {} // Dummy constructor
	public HumanoidMoveFSMAirState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x00000001812C7D40-0x00000001812C7E70

	// Methods
	// [XID] // 0x00000001896B08E0-0x00000001896B0900
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x00000001812C74C0-0x00000001812C75C0
	// [XID] // 0x00000001896BF460-0x00000001896BF480
	protected virtual void InitAir(bool applyGravity, bool enableLand, bool enableClimb, HumanoidMoveFSM.FSMStateID formerStateId) {} // 0x00000001812C63C0-0x00000001812C6800
	// [XID] // 0x00000001896C6DD0-0x00000001896C6DF0
	protected virtual bool DealAirJump() => default; // 0x00000001812C33D0-0x00000001812C34C0
	// [XID] // 0x00000001896CE4A0-0x00000001896CE4C0
	public override void LateTick() {} // 0x00000001812C5E10-0x00000001812C6280
	// [XID] // 0x00000001896D5990-0x00000001896D59B0
	protected override void CalcCurrentGroundInfo() {} // 0x00000001812C76D0-0x00000001812C7AF0
	// [XID] // 0x00000001896DCE70-0x00000001896DCE90
	protected virtual void Land(LandSpeedLevel landSpeedLevel) {} // 0x00000001812C4A80-0x00000001812C5180
	// [XID] // 0x00000001896E4830-0x00000001896E4850
	protected virtual void DealMoveResultForward(StepAndClimbInfo info) {} // 0x00000001812C3AB0-0x00000001812C4480
	// [XID] // 0x00000001896EBCD0-0x00000001896EBCF0
	protected virtual void SetAirMotionflag() {} // 0x00000001812C31B0-0x00000001812C3370
	// [XID] // 0x00000001896F3350-0x00000001896F3370
	protected void DetermineMoveResultForward() {} // 0x00000001812C5180-0x00000001812C5220
	// [XID] // 0x00000001896FAAB0-0x00000001896FAAD0
	protected bool CheckAirToSwim() => default; // 0x00000001812C5220-0x00000001812C5410
	// [XID] // 0x0000000189702100-0x0000000189702120
	protected bool CheckFlyToDropForWater() => default; // 0x00000001812C7B90-0x00000001812C7CE0
	// [XID] // 0x0000000189709820-0x0000000189709840
	public override void FixedTick() {} // 0x00000001812C35C0-0x00000001812C38C0
	// [XID] // 0x0000000189711230-0x0000000189711250
	public override void OnAnimatorMove() {} // 0x00000001812C2410-0x00000001812C2680
	// [XID] // 0x00000001897187A0-0x00000001897187C0
	public override void Exit(HumanoidMoveFSM.FSMStateID nextState) {} // 0x00000001812C6EF0-0x00000001812C6FE0
	// [XID] // 0x000000018971FF00-0x000000018971FF20
	protected override void Reset() {} // 0x00000001812C21D0-0x00000001812C2270
	// [XID] // 0x0000000189727660-0x0000000189727680
	protected bool flyGroundDistCheckFail() => default; // 0x00000001812C1680-0x00000001812C18B0
	// [XID] // 0x000000018972EB10-0x000000018972EB30
	public override bool CanDoJump() => default; // 0x00000001812C5410-0x00000001812C57F0
	// [XID] // 0x0000000189736280-0x00000001897362A0
	public override void DoJump() {} // 0x00000001812C5D30-0x00000001812C5E10
	// [XID] // 0x000000018973E100-0x000000018973E120
	public virtual void DoSwim() {} // 0x00000001812C1F60-0x00000001812C2040
	// [XID] // 0x000000018974CED0-0x000000018974CEF0
	protected override void FrozenCharacterProcess() {} // 0x00000001812C19F0-0x00000001812C1B80
	// [XID] // 0x0000000189754490-0x00000001897544B0
	protected override BeneathResult DeterminBeneathResult(BeneathResult last, float downVelocity = 0f /* Metadata: 0x00AEB9DB */, bool forceScanHeightMap = false /* Metadata: 0x00AEB9DF */) => default; // 0x00000001812C5870-0x00000001812C5D30
	// [XID] // 0x000000018975B6F0-0x000000018975B710
	protected override void FreezeCharacter() {} // 0x00000001812C1DD0-0x00000001812C1F60
	// [XID] // 0x0000000189763100-0x0000000189763120
	protected override void UnFreezeCharacter() {} // 0x00000001812C6280-0x00000001812C6360
	// [XID] // 0x000000018976A8D0-0x000000018976A8F0
	protected virtual void SetUpJamProtection() {} // 0x00000001812C30E0-0x00000001812C31B0
	// [XID] // 0x0000000189771E90-0x0000000189771EB0
	protected override void StayInPlace() {} // 0x00000001812C18B0-0x00000001812C19F0
	// [XID] // 0x00000001897796E0-0x0000000189779700
	public override void SyncLateTick() {} // 0x00000001812C6800-0x00000001812C6EF0
	// [XID] // 0x0000000189781040-0x0000000189781060
	public override void SyncFixedTick() {} // 0x00000001812C6FE0-0x00000001812C72D0
	// [XID] // 0x0000000189788500-0x0000000189788520
	public override bool GetNextSyncOrder() => default; // 0x00000001812C2270-0x00000001812C2350
	// [XID] // 0x000000018978FBC0-0x000000018978FBE0
	public override void CreateSyncTaskByTimeInterval() {} // 0x00000001812C4550-0x00000001812C45F0
	// [XID] // 0x0000000189797390-0x00000001897973B0
	protected virtual void SetAnimAndVelocityForceMotion(bool groundNoStand, bool groundNoStandAndHorizontal) {} // 0x00000001812C2730-0x00000001812C30E0
	// [XID] // 0x000000018979F2F0-0x000000018979F310
	private Vector3 DropDecreaseVelocity(Vector3 v) => default; // 0x00000001812C1B80-0x00000001812C1DD0
	// [XID] // 0x00000001897A6940-0x00000001897A6960
	protected virtual bool GetAddJumpEnterMoveScenePropVelocity() => default; // 0x00000001812C34C0-0x00000001812C3560
	// [XID] // 0x00000001897AE080-0x00000001897AE0A0
	protected virtual void DoAddJumpEnterMoveScenePropVelocity(ref Vector3 velocity) {} // 0x00000001812C7620-0x00000001812C76D0
	// [XID] // 0x00000001897B60F0-0x00000001897B6110
	protected virtual void DealRocketJump(ref Vector3 velocity) {} // 0x00000001812C2680-0x00000001812C2730
	// [XID] // 0x00000001897BDF20-0x00000001897BDF40
	protected virtual void CreateSyncTaskByTimeIntervalDelayedInFix() {} // 0x00000001812C72D0-0x00000001812C7460
	// [XID] // 0x00000001897C5500-0x00000001897C5520
	protected virtual void CreateFirstSyncPacket() {} // 0x00000001812C48F0-0x00000001812C4A80
	// [XID] // 0x00000001897CCB20-0x00000001897CCB40
	protected bool AirSyncReachCurrentMotion() => default; // 0x00000001812C45F0-0x00000001812C4820
}

