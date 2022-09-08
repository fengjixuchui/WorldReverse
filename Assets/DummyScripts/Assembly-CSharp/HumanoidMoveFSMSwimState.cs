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

public sealed class HumanoidMoveFSMSwimState : HumanoidMoveFSMBaseMoveState // TypeDefIndex: 14683
{
	// Fields
	private const float BLEND_POSE_SPEED = 1f; // Metadata: 0x00AEBD43
	private float _swimPose; // 0x140
	private bool _enableFitWaterHeight; // 0x144
	private bool _updateToClimb; // 0x145
	private StepAndClimbInfo _scanInfo; // 0x148
	private bool _updateSwimJumpToWater; // 0x170
	private bool _updateDropToWater; // 0x171
	private bool _updateDropToWaterSecondPeriod; // 0x172
	private float _updateDropToWaterSecondPeriodVelocity; // 0x174
	private float _updateDropToWaterSecondPeriodAcceleration; // 0x178
	private bool _fireUpdateDropToWaterUpEffect; // 0x17C
	private bool _startCheckUpdateDropToWaterUpEffect; // 0x17D
	private const float UPDATA_DROP_TO_WATER_SECOND_PERIOD_TIME = 0.25f; // Metadata: 0x00AEBD47
	private const float UPDATA_DROP_TO_WATER_SECOND_PERIOD_HEIGHT_RATIO = 0.85f; // Metadata: 0x00AEBD4B
	private float _dropToWaterTargetY; // 0x180
	private float _dropToWaterAcceleration; // 0x184
	private float _dropToWaterVelocity; // 0x188
	public float UPDATE_DROP_TO_WATER_UP_ACCELERATION; // 0x18C
	private const float UPDATE_DROP_TO_WATER_VELOCITY_THRESHOLD = -3f; // Metadata: 0x00AEBD4F
	private const float UPDATE_DROP_TO_WATER_MAX_DEPTH_VELOCITY = -15f; // Metadata: 0x00AEBD53
	private const float DROP_TO_WATER_GO_DEEP_TIME = 0.5f; // Metadata: 0x00AEBD57
	public float PLAY_SPLASH_DEEPL_BUBBLE_RATIO; // 0x190
	private const float DROP_TO_WATER_MAX_DEPTH_RATIO = 0.6f; // Metadata: 0x00AEBD5B
	private const float DROP_TO_WATER_MIN_DEPTH_RATIO = 0.1f; // Metadata: 0x00AEBD5F
	private const float ROTATE_TO_CLIMB_SPEED = 10f; // Metadata: 0x00AEBD63
	private bool _lastIsInSwimDash; // 0x194
	private bool _inWaterAndTempColliderAboveHead; // 0x195
	private float _aboveCollderHeight; // 0x198
	private bool _swimDashMotionflag; // 0x19C
	private float _lastWaterHeight; // 0x1A0
	private Transform _headNub; // 0x1A8
	private const float SLOPE_WATER_VELOCITY_MAX = 2f; // Metadata: 0x00AEBD67
	private const float SLOPE_WATER_VELOCITY_ACC = 5f; // Metadata: 0x00AEBD6B
	public float _lastInSlopeWaterVelcity; // 0x1B0
	private bool _checkSwimJumpToWaterEffect; // 0x1B4
	private const float FROZEN_IN_WATER_GO_UP_AND_DOWN_SPEED = 0.05f; // Metadata: 0x00AEBD6F
	private const float FROZEN_IN_WATER_GO_UP_AND_DOWN_RANGE = 0.03f; // Metadata: 0x00AEBD73
	private bool _frozenMoveGoUp; // 0x1B5
	private bool _fitToWaterFrozen; // 0x1B6

	// Constructors
	public HumanoidMoveFSMSwimState() {} // Dummy constructor
	public HumanoidMoveFSMSwimState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x000000018342B610-0x000000018342B720

	// Methods
	// [XID] // 0x0000000189A47680-0x0000000189A476A0
	public override void InitSyncWithCurrentTask(bool setPosition) {} // 0x0000000183427140-0x0000000183427330
	// [XID] // 0x0000000189A4EE70-0x0000000189A4EE90
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x00000001834280A0-0x0000000183428B20
	// [XID] // 0x0000000189A5E0B0-0x0000000189A5E0D0
	public override void LateTick() {} // 0x0000000183425420-0x0000000183426660
	// [XID] // 0x0000000189A65860-0x0000000189A65880
	protected override bool CheckSwim() => default; // 0x0000000183426D10-0x0000000183426EA0
	// [XID] // 0x0000000189A6CF70-0x0000000189A6CF90
	private void UpdateToClimb() {} // 0x0000000183423FC0-0x00000001834246B0
	// [XID] // 0x0000000189A746A0-0x0000000189A746C0
	public override bool CanPlaySwimEffect() => default; // 0x0000000183429900-0x0000000183429A10
	// [XID] // 0x0000000189A7C1E0-0x0000000189A7C200
	private void CheckSwimJumpToWaterEffect() {} // 0x0000000183427390-0x00000001834276C0
	// [XID] // 0x0000000189A83B40-0x0000000189A83B60
	private void UpdateDropToWater() {} // 0x000000018342A730-0x000000018342B350
	// [XID] // 0x0000000189A8B4D0-0x0000000189A8B4F0
	protected override void DoSteer() {} // 0x0000000183426660-0x00000001834269E0
	// [XID] // 0x0000000189A92AA0-0x0000000189A92AC0
	private void UpdateSwimPose() {} // 0x00000001834269E0-0x0000000183426D10
	// [IDTag] // 0x0000000189A9A500-0x0000000189A9A540
	// [XID] // 0x0000000189A9A500-0x0000000189A9A540
	public override void TrySteer(bool isMoving, float joystickAngle) {} // 0x000000018342B480-0x000000018342B610
	// [IDTag] // 0x0000000189AA48C0-0x0000000189AA4900
	// [XID] // 0x0000000189AA48C0-0x0000000189AA4900
	public override void TrySteer(Vector3 targetDir) {} // 0x000000018342B350-0x000000018342B480
	// [XID] // 0x0000000189AAEFB0-0x0000000189AAEFD0
	public override void OnAnimatorMove() {} // 0x0000000183423A00-0x0000000183423FC0
	// [XID] // 0x0000000189AB6890-0x0000000189AB68B0
	protected override void SetAnimIdle() {} // 0x0000000183424FF0-0x0000000183425220
	// [XID] // 0x0000000189ABE380-0x0000000189ABE3A0
	protected override void SetAnimMove() {} // 0x0000000183424860-0x0000000183424C00
	// [XID] // 0x0000000189AC5ED0-0x0000000189AC5EF0
	private void CheckWaterHeightChange() {} // 0x0000000183422E70-0x0000000183423140
	// [XID] // 0x0000000189ACD3A0-0x0000000189ACD3C0
	private void FitWaterHeight() {} // 0x0000000183424C80-0x0000000183424F80
	// [XID] // 0x0000000189AD51C0-0x0000000189AD51E0
	protected override void CalcCurrentGroundInfo() {} // 0x0000000183429A10-0x0000000183429E80
	// [XID] // 0x0000000189ADCB70-0x0000000189ADCB90
	public override bool IsInSwimIdle() => default; // 0x0000000183429F70-0x000000018342A090
	// [XID] // 0x0000000189AE43C0-0x0000000189AE43E0
	public override bool IsInSwimDash() => default; // 0x0000000183427B30-0x0000000183427CB0
	// [XID] // 0x0000000189AEBBB0-0x0000000189AEBBD0
	public override void Exit(HumanoidMoveFSM.FSMStateID nextState) {} // 0x0000000183427A70-0x0000000183427B30
	// [XID] // 0x0000000189AF35A0-0x0000000189AF35C0
	protected override void Reset() {} // 0x00000001834237D0-0x0000000183423940
	// [XID] // 0x0000000189AFAE20-0x0000000189AFAE40
	public void DealWithSuddenNoWater() {} // 0x0000000183423370-0x0000000183423530
	// [XID] // 0x0000000189B023E0-0x0000000189B02400
	private void UpdateFrozenInWater() {} // 0x0000000183427CB0-0x0000000183428040
	// [XID] // 0x0000000189B09960-0x0000000189B09980
	protected override void FrozenCharacterProcess() {} // 0x0000000183422BA0-0x0000000183422D70
	// [XID] // 0x0000000189B113E0-0x0000000189B11400
	protected override void UnFreezeCharacter() {} // 0x0000000183426EA0-0x0000000183427010
	// [XID] // 0x0000000189B18630-0x0000000189B18650
	protected override void FreezeCharacter() {} // 0x0000000183423530-0x00000001834235D0
	// [XID] // 0x0000000189B1FCF0-0x0000000189B1FD10
	public override void SyncLateTick() {} // 0x00000001834276C0-0x0000000183427A70
	// [XID] // 0x0000000189B27420-0x0000000189B27440
	private void ProcessCurrentMoveTask() {} // 0x0000000183428B80-0x0000000183429900
	// [XID] // 0x0000000189B2E5E0-0x0000000189B2E600
	private void TransferToOtherSyncState() {} // 0x000000018342A090-0x000000018342A650
	// [XID] // 0x0000000189B35C90-0x0000000189B35CB0
	protected override MotionState GetCurrentSyncMotionState() => default; // 0x0000000183422D70-0x0000000183422E70
	// [IDTag] // 0x0000000189B3D380-0x0000000189B3D3C0
	// [XID] // 0x0000000189B3D380-0x0000000189B3D3C0
	private void SetAnimSync(VCMoveData.MotionFlag motionFlag) {} // 0x0000000183423270-0x0000000183423370
	// [IDTag] // 0x0000000189B480F0-0x0000000189B48130
	// [XID] // 0x0000000189B480F0-0x0000000189B48130
	private void SetAnimSync(MotionState motionState) {} // 0x0000000183423140-0x0000000183423270
	// [XID] // 0x0000000189B52760-0x0000000189B52780
	private void SyncCheckStopUpdateDropToWater() {} // 0x0000000183422AE0-0x0000000183422BA0
	// [XID] // 0x0000000189B5A0E0-0x0000000189B5A100
	private void SwimSyncStayInplace() {} // 0x00000001834246B0-0x0000000183424800
	// [XID] // 0x0000000189B61620-0x0000000189B61640
	protected override void GetLastPacketMotion() {} // 0x0000000183429E80-0x0000000183429F70
}

