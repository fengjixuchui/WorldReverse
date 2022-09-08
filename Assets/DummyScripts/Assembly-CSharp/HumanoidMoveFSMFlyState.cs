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

public sealed class HumanoidMoveFSMFlyState : HumanoidMoveFSMAirState // TypeDefIndex: 14665
{
	// Fields
	private const float FLY_DOWN_SPEED_DEFAULT = -1.9f; // Metadata: 0x00AEBBAC
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _flyDownSpeed; // 0x188
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _flyDownSpeedMin; // 0x18C
	private const float FLY_FORWARD_SPEED_MAX_DEFAULT = 6f; // Metadata: 0x00AEBBB0
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _flyForwardSpeedMax; // 0x190
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _flyBackSpeedMax; // 0x194
	private const float FLY_BACK_SPEED_MAX_DEFAULT = 1.5f; // Metadata: 0x00AEBBB4
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _flyHorizontalSpeedMax; // 0x198
	private const float FLY_HORIZONTAL_SPEED_MAX_DEFAULT = 6f; // Metadata: 0x00AEBBB8
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _flyRotationAngularVelocity; // 0x19C
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _flyOverallSpeedRatio; // 0x1A0
	private const float FLY_ROATION_ANGULAR_VELOCITY_DEFAULT = 1.1868238f; // Metadata: 0x00AEBBBC
	private float _targetClimbVer; // 0x1A4
	private float _targetClimbHor; // 0x1A8
	private float _targetFlyPose; // 0x1AC
	private const float FLY_POSE_CHANGE_THRESHOLD = 0.4f; // Metadata: 0x00AEBBC0
	private const float TARGET_CLIMB_HOR_CHANGE_THRESHOLD = 0.1f; // Metadata: 0x00AEBBC4
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _posBlendHor; // 0x1B0
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _posBlendVer; // 0x1B4
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _posBlendMirror; // 0x1B8
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _posAmplificationFactorHor; // 0x1BC
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _posAmplificationFactorVer; // 0x1C0
	private Vector3 _targetDir; // 0x1C4
	private float _yVelocity; // 0x1D0
	private bool _isAirInVelocityForce; // 0x1D4
	private bool _lastIsInVelocityForce; // 0x1D5
	private FlyControlType _flyControlType; // 0x1D8
	private Vector3 _lockedForward; // 0x1DC
	private float _flyControlVelocityScale; // 0x1E8
	private float _flyControlBackVelocityScale; // 0x1EC
	private Vector3 _flyControlEularRawInput; // 0x1F0
	private const float FORCE_AIR_FLY_NO_LAND_TIME = 0.5f; // Metadata: 0x00AEBBC8
	private float _forceAirNoLandTime; // 0x1FC
	private bool _fixTargetMode; // 0x200
	private bool _aimMode; // 0x201
	private Vector3 _fixTargetModePosition; // 0x204
	private float _fixTargetModeVelocity; // 0x210
	private bool _ExitTargetModeThisFrame; // 0x214
	public float velocityChange; // 0x218
	public float velocityDampingRatio; // 0x21C
	public Vector3 _lastVelocity; // 0x220
	private float _pitchAngle; // 0x22C
	private float _lastY; // 0x230
	private bool _startCalcPitch; // 0x234
	public float pitchMax; // 0x238
	public float pitchMin; // 0x23C
	public float pitchDown; // 0x240
	public float pitchUp; // 0x244
	public float airResistanceConst; // 0x248
	public float deltaKineticEnergyAmplifyRatio; // 0x24C
	public float wasitedEnergeyStoreRatio; // 0x250
	public float countWasitedEnergeyAngle; // 0x254
	public float deltaKineticRatioWhenhasWasitedEnergey; // 0x258
	private float _wasitedEnergeyWhenReachMaxVelocity; // 0x25C
	private float _curTilt; // 0x260
	private float _syncTargetTilt; // 0x264
	private float _lastYaw; // 0x268
	private const float TILT_SPEED_COEFF = 160f; // Metadata: 0x00AEBBCC
	private const float TILT_UPDATE_SPEED = 30f; // Metadata: 0x00AEBBD0
	private const float START_TILT__YAW_DIFF = 45f; // Metadata: 0x00AEBBD4
	private const float STOP_TILT__YAW_DIFF = 15f; // Metadata: 0x00AEBBD8
	private bool _tilt; // 0x26C
	private const float MAX_TILT = 25f; // Metadata: 0x00AEBBDC
	private const float MAX_PITCH = 20f; // Metadata: 0x00AEBBE0
	private float _currentClimbVer; // 0x270
	private float _currentClimbHor; // 0x274
	private float _currentFlyPose; // 0x278
	private Vector3 _lastVelocityForce; // 0x27C
	private Vector3 _curVelocityForce; // 0x288

	// Nested types
	public enum FlyControlType // TypeDefIndex: 14666
	{
		Default = 0,
		LockForward = 1
	}

	// Constructors
	public HumanoidMoveFSMFlyState() {} // Dummy constructor
	public HumanoidMoveFSMFlyState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x000000018302E700-0x000000018302E900

	// Methods
	// [XID] // 0x0000000189712890-0x00000001897128B0
	public override void InitSyncWithCurrentTask(bool setPosition) {} // 0x000000018302B860-0x000000018302BC80
	// [XID] // 0x000000018971A170-0x000000018971A190
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x000000018302DA60-0x000000018302E220
	// [XID] // 0x0000000189728B00-0x0000000189728B20
	public void SetFlyControlType(FlyControlType type, Vector3 dir, Vector3 eularRawInput, float velocityScale, float backVelocityScale) {} // 0x000000018302E530-0x000000018302E700
	// [XID] // 0x0000000189730570-0x0000000189730590
	public override void LateTick() {} // 0x000000018302B050-0x000000018302B4E0
	// [XID] // 0x0000000189737CD0-0x0000000189737CF0
	private void CheckStartCalcPitch() {} // 0x0000000183026B60-0x0000000183026D10
	// [XID] // 0x000000018973F8C0-0x000000018973F8E0
	protected override void SetAnimAndVelocityForceMotion(bool groundNoStand, bool groundNoStandAndHorizontal) {} // 0x00000001830274E0-0x00000001830297C0
	// [XID] // 0x0000000189746DA0-0x0000000189746DC0
	public override void Exit(HumanoidMoveFSM.FSMStateID nextState) {} // 0x000000018302D500-0x000000018302D610
	// [XID] // 0x000000018974E630-0x000000018974E650
	public override bool CanDoJump() => default; // 0x000000018302AB90-0x000000018302ACC0
	// [XID] // 0x0000000189755CE0-0x0000000189755D00
	public override void DoJump() {} // 0x000000018302ADC0-0x000000018302B050
	// [XID] // 0x000000018975CF60-0x000000018975CF80
	private void FlyUpdateTilt() {} // 0x0000000183029AB0-0x000000018302A4F0
	// [XID] // 0x0000000189AA4B40-0x0000000189AA4B60
	public void GetCurrentFlyPose(out float roll, out float pitch) {
		roll = default;
		pitch = default;
	} // 0x0000000183027400-0x00000001830274E0
	// [XID] // 0x000000018976C1E0-0x000000018976C200
	public void EnterFlyFixTargetMode(Vector3 targetPosition, float velocity) {} // 0x000000018302A600-0x000000018302A700
	// [XID] // 0x000000018969F800-0x000000018969F820
	public void ExitFlyFixTargetMode() {} // 0x000000018302E390-0x000000018302E440
	// [XID] // 0x000000018977AD70-0x000000018977AD90
	protected override MotionState GetCurrentSyncMotionState() => default; // 0x0000000183026D10-0x0000000183026DD0
	// [XID] // 0x0000000189782900-0x0000000189782920
	public override void SyncFixedTick() {} // 0x000000018302D610-0x000000018302D6B0
	// [XID] // 0x0000000189789B70-0x0000000189789B90
	public override void SyncLateTick() {} // 0x000000018302BC80-0x000000018302D500
	// [XID] // 0x0000000189631940-0x0000000189631960
	public void SetAimMode(bool enabled) {} // 0x000000018302A4F0-0x000000018302A5A0
	// [XID] // 0x0000000189798B10-0x0000000189798B30
	protected override void CreateFirstSyncPacket() {} // 0x000000018302A7D0-0x000000018302AB90
	// [XID] // 0x00000001897A0930-0x00000001897A0950
	protected override void CreateSyncTaskByTimeIntervalDelayedInFix() {} // 0x000000018302D6B0-0x000000018302DA60
	// [XID] // 0x00000001897A7FA0-0x00000001897A7FC0
	public static void SetFlyStateParams(float flyBackSpeedMax = -1f /* Metadata: 0x00AEBB98 */, float flyHorizontalSpeedMax = -1f /* Metadata: 0x00AEBB9C */, float flyRotationAngularVelocity = -1f /* Metadata: 0x00AEBBA0 */, float flyDownSpeed = 1f /* Metadata: 0x00AEBBA4 */, float flyForwardSpeedMax = -1f /* Metadata: 0x00AEBBA8 */) {} // 0x000000018302B4E0-0x000000018302B5D0
	// [XID] // 0x00000001897AFA80-0x00000001897AFAA0
	public static void ResetFlyStateParams() {} // 0x0000000183029940-0x00000001830299D0
	// [XID] // 0x00000001897B7850-0x00000001897B7870
	public override void SetFlyBackSpeedMaxRatio(float ratio) {} // 0x0000000183027300-0x0000000183027400
	// [XID] // 0x00000001897BF760-0x00000001897BF780
	public override void SetFlyHorizontalSpeedMaxRatio(float ratio) {} // 0x0000000183026ED0-0x0000000183026FD0
	// [XID] // 0x00000001897C6EB0-0x00000001897C6ED0
	public override void SetFlyRotationAngularVelocityRatio(float ratio) {} // 0x0000000183026FD0-0x00000001830270D0
	// [XID] // 0x00000001897CE4C0-0x00000001897CE4E0
	public override void SetFlyDownSpeedRatio(float ratio) {} // 0x0000000183026DD0-0x0000000183026ED0
	// [XID] // 0x00000001897D5B70-0x00000001897D5B90
	public override void SetFlyForwardSpeedMaxRatio(float ratio) {} // 0x000000018302B5D0-0x000000018302B6D0
	// [XID] // 0x00000001897DD2F0-0x00000001897DD310
	public override void SetFlyOverallSpeedRatio(float ratio) {} // 0x000000018302E440-0x000000018302E530
	// [XID] // 0x00000001897E4B20-0x00000001897E4B40
	public override void ShiftWorld(bool isRemote, Vector3 deltaShift) {} // 0x000000018302B6D0-0x000000018302B860
}

