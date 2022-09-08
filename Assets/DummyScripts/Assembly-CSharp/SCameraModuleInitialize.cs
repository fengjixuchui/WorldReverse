/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SCameraModuleInitialize : SCameraModuleBase // TypeDefIndex: 32095
{
	// Fields
	public bool levelCinemachine; // 0x28
	private const double DEFAULT_MULTI_ENEMY_MAX_RANGE = 40; // Metadata: 0x00B13D43
	private const double VELOCITY_THRESHOLD_FROM_RIGIDBODY = 1; // Metadata: 0x00B13D4B
	private const double MOVEMENT_THRESHOLD_FROM_TRANSFORM = 0.009999999776482582; // Metadata: 0x00B13D53
	private const double SMALL_NUM = 9.999999747378752E-06; // Metadata: 0x00B13D5B
	private const double MIN_FRONT_DISTANCE_FOR_CHECK_AVATAR_STUCL = 0.5; // Metadata: 0x00B13D63
	private SimpleVector3Damper _skfilter; // 0x30
	private bool _isFilterInitialized; // 0x38
	private bool _isTrySmoothBetweenNormalAndClimb; // 0x39
	private double _smoothLerpSpeed; // 0x40
	private Vector3d _smoothingTransformLookAtPoint; // 0x48
	private SimpleKalmanFilter _dirKfilter; // 0x60
	private bool _isDirectionFilterInitialized; // 0x68
	private const int MAX_FACEDIRECTION_TRACE_BUFFER_NUMBER = 8; // Metadata: 0x00B13D6B
	private Vector3d[] _faceDirectionTrace; // 0x70
	private bool _isFaceDirectionTraceInitialized; // 0x78
	private Vector3d _lastFrameSmoothFaceDirection; // 0x80
	private const double MIN_ANGULAR_VELOCITY_THRESHOLD_FOR_STABLE_CLIMB = 8; // Metadata: 0x00B13D6F
	private const double VECTOR_LERP_RATIO_BLENDFACEDIR_SMOOTHFACEDIR = 4; // Metadata: 0x00B13D77
	private const double CAM_AND_WALL_ANGLE_THRESHOLD_FOR_SPECIFY_CLOCKINGWISE = 120; // Metadata: 0x00B13D7F
	private const double AVA_AND_WALL_ANGLE_THRESHOLD_FOR_SPECIFY_CLOCKINGWISE = 90; // Metadata: 0x00B13D87
	private const double MIN_ANGULAR_VELOCITY_THRESHOLD_FOR_SPECIFY_CLOCKINGWISEB = 40; // Metadata: 0x00B13D8F
	private bool _hasEnteredAvatarClimb; // 0x98
	private bool _hasBeenConsistent; // 0x99
	private const double THRESHOLD_FOR_BLENDFACEDIR_AND_SMOOTHFACEDIR_CONSISTENT = 1; // Metadata: 0x00B13D97
	private double _timerForWaitingFacingToWallNoraml; // 0xA0
	private const double MAX_WAITING_FOR_AVATAR_FACING_WALL = 0.8999999761581421; // Metadata: 0x00B13D9F
	private HumanoidMoveFSM.FSMStateID _curFSMState; // 0xA8
	private HumanoidMoveFSM.FSMStateID _lastFSMState; // 0xAC
	private Vector3d _climbWallNormal; // 0xB0
	private bool _climbWallNormalGetted; // 0xC8
	private int _LayerIndex; // 0xCC
	private int _SceneLayerIndex; // 0xD0
	private Ray _ray; // 0xD4
	private RaycastHit _hitInfo; // 0xF0
	private const double _rayHitTestHeight = 12; // Metadata: 0x00B13DA7
	private double _timerForDropping; // 0x130
	private const double MAX_WAIT_FOR_CANCEL_DROPING = 0.20000000298023224; // Metadata: 0x00B13DAF
	private bool _firstStartFlag; // 0x138
	private bool _isMoving; // 0x139
	private bool _isDropping; // 0x13A
	private bool _isCombatHitCamera; // 0x13B
	private bool _isInStandby2Climb; // 0x13C
	private bool _isWaterFall; // 0x13D
	private double _waterHeight; // 0x140
	private Vector3d _waterFallNormal; // 0x148
	private Vector3d _avatarVelocity; // 0x160
	private bool _isAvatarMoveFollowRefferenceSystem; // 0x178
	private const double FILTER_BLOCK_TIME = 0.5; // Metadata: 0x00B13DB7
	private const double _kRawInputDeadZone = 0.10000000149011612; // Metadata: 0x00B13DBF
	private double _inputMoveAngle; // 0x180
	private double _inputMoveMold; // 0x188
	private double _defaultCameraDistanceAdjust; // 0x190
	private Dictionary<Vector2, double> _animStateChangePair; // 0x198
	private Dictionary<Vector2, FilterKeepType> _animStateChangeType; // 0x1A0
	private Dictionary<Vector2, double> _animStateChangeTime; // 0x1A8
	private double _preNormalRadiusTarget; // 0x1B0
	private double _preNormalRadiusStart; // 0x1B8
	private double _deltaTimeNormal; // 0x1C0
	private bool _lerpingNormal; // 0x1C8
	private const int RAY_COUNT_FOR_CHECKING_JUMP_FROM_LOW_TO_HEIGHT = 4; // Metadata: 0x00B13DC7
	private const double JUMP_FORWARD_DISTANCE = 5; // Metadata: 0x00B13DCB
	private const double THRESHOLD_FOR_HIGH_MINUS_LOW = 1.2000000476837158; // Metadata: 0x00B13DD3
	private Vector3d heightAdjust; // 0x1D0
	private Vector3d heightAdjustMax; // 0x1E8
	private Vector3d currHeightAdjust; // 0x200

	// Properties
	public override CameraModuleType moduleType { /* [XID] */ /* 0x0000000189B15B10-0x0000000189B15B30 */ get => default; } // 0x000000018123C720-0x000000018123C7C0 

	// Nested types
	private enum FilterKeepType // TypeDefIndex: 32096
	{
		XYZ = 0,
		XZ = 1,
		Y = 2
	}

	// Constructors
	public SCameraModuleInitialize() {} // 0x0000000181241840-0x0000000181241B30

	// Methods
	// [XID] // 0x0000000189B1D290-0x0000000189B1D2B0
	public override void Collect(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x000000018123AD70-0x000000018123B070
	// [XID] // 0x0000000189B24AB0-0x0000000189B24AD0
	public override void Tick(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018123D760-0x000000018123D970
	// [XID] // 0x0000000189B2BF00-0x0000000189B2BF20
	private void CopyToLastFrame(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018123A220-0x000000018123A7E0
	// [XID] // 0x0000000189B33470-0x0000000189B33490
	private void GetCurrentFSMState(CameraAvatarPrepareData avatarPrepareData) {} // 0x00000001812411A0-0x00000001812412B0
	// [XID] // 0x0000000189B3AE30-0x0000000189B3AE50
	private void SetPredefAnimatorState(ref CameraShareData data, CameraAvatarPrepareData avatarPrepareData) {} // 0x000000018123DA10-0x000000018123EB30
	// [XID] // 0x0000000189B42570-0x0000000189B42590
	private void GetClimbWallNormalDuringClimb(ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x000000018123A7E0-0x000000018123A9D0
	// [XID] // 0x0000000189B4A030-0x0000000189B4A050
	private void CollectAvatarState(ref CameraShareData data, CameraAvatarPrepareData avatarPrepareData) {} // 0x000000018123A9D0-0x000000018123AD70
	// [XID] // 0x0000000189B51930-0x0000000189B51950
	public void ResetOnSpawn(ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018123F6B0-0x000000018123F780
	// [XID] // 0x0000000189B59110-0x0000000189B59130
	private bool ShouldResetHorizontalRecenteringTriggerTimer(ref CameraShareData data) => default; // 0x000000018123B7D0-0x000000018123B9B0
	// [XID] // 0x0000000189B60900-0x0000000189B60920
	private bool ShouldResetVerticalRencenteringTriggerTimer(ref CameraShareData data) => default; // 0x0000000181241070-0x00000001812411A0
	// [XID] // 0x0000000189B68070-0x0000000189B68090
	private void TickRecentering(double deltaTime, ref CameraShareData data) {} // 0x000000018123F780-0x000000018123FB60
	// [XID] // 0x0000000189B6F3F0-0x0000000189B6F410
	private void FirstStartSetCameraRadiusAndRatio(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018123BE10-0x000000018123C070
	// [XID] // 0x0000000189B76A30-0x0000000189B76A50
	private void SetCameraDefaultLocateRatioByDistance(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018123ED10-0x000000018123F2E0
	// [XID] // 0x0000000189B7DF80-0x0000000189B7DFA0
	private void CheckIfAvatarJumpFromLowToHigh(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018123C880-0x000000018123D0D0
	// [IDTag] // 0x0000000189B85BC0-0x0000000189B85C00
	// [XID] // 0x0000000189B85BC0-0x0000000189B85C00
	private void FilterAvatarFaceDirection(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181240940-0x0000000181240BF0
	// [IDTag] // 0x0000000189B8FDC0-0x0000000189B8FE00
	// [XID] // 0x0000000189B8FDC0-0x0000000189B8FE00
	private Vector3d FilterAvatarFaceDirection(double deltaTime, bool AciveFlag, Vector3d DirVector, Vector3d Velocity, double NOISE_Q, double NOISE_R, double Init_ERROR, double INIT_FRAME_RATE) => default; // 0x0000000181240570-0x0000000181240940
	// [XID] // 0x0000000189B99F80-0x0000000189B99FA0
	private void GetCameraControlFlag(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018123FB60-0x000000018123FED0
	// [XID] // 0x0000000189BA1680-0x0000000189BA16A0
	private void CheckAvatarClimbEnterState(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018123B070-0x000000018123B7D0
	// [XID] // 0x0000000189BA8AF0-0x0000000189BA8B10
	private void UpdateAvatarTransformLookAtPosition(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181240BF0-0x0000000181240EF0
	// [XID] // 0x0000000189BB0190-0x0000000189BB01B0
	private void SmoothLookAtPointBetweenMoveAndClimb(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018123C4E0-0x000000018123C720
	// [XID] // 0x0000000189BB7680-0x0000000189BB76A0
	private void ModifyLookAtPointUnderWaterFall(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018123C070-0x000000018123C4E0
	// [XID] // 0x0000000189BBED20-0x0000000189BBED40
	private void SetWarningLocateRatio(double deltaTime, ref CameraShareData data) {} // 0x000000018123F2E0-0x000000018123F640
	// [IDTag] // 0x0000000189BC6950-0x0000000189BC6990
	// [XID] // 0x0000000189BC6950-0x0000000189BC6990
	private void FilterAvatarLookAtPoint(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018123D5A0-0x000000018123D760
	// [XID] // 0x0000000189BD1500-0x0000000189BD1520
	private bool CheckIfAvatarIsStuck(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData, Vector3d Velocity) => default; // 0x000000018123BAD0-0x000000018123BE10
	// [IDTag] // 0x0000000189BD8B00-0x0000000189BD8B40
	// [XID] // 0x0000000189BD8B00-0x0000000189BD8B40
	private Vector3d FilterAvatarLookAtPoint(double deltaTime, bool AciveFlag, Vector3d Origin, Vector3d Velocity, double NOISE_Q, double NOISE_R, double Init_ERROR, double INIT_FRAME_RATE) => default; // 0x000000018123D2A0-0x000000018123D5A0
	// [XID] // 0x00000001895E8810-0x00000001895E8830
	private void DelayLookatPoint(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x00000001812412B0-0x0000000181241840
	// [XID] // 0x00000001895F00C0-0x00000001895F00E0
	private void LookatPointHeightAdjust(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181240170-0x0000000181240570
	// [XID] // 0x00000001895F7A80-0x00000001895F7AA0
	private void ModifyLookAtPointDuringUnderWater(ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181240090-0x0000000181240170
	// [XID] // 0x00000001895FEE50-0x00000001895FEE70
	private void BackupLookAtPosition(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018123B9B0-0x000000018123BAD0
	// [XID] // 0x0000000189606710-0x0000000189606730
	public override bool ShiftWorld(Vector3d newShift, Vector3d oldShift) => default; // 0x000000018123FED0-0x0000000181240090
	// [XID] // 0x000000018960E010-0x000000018960E030
	public void UpdateVec3Trace(Vector3d[] dirTrace, Vector3d dirVec) {} // 0x0000000181240EF0-0x0000000181241070
	// [XID] // 0x0000000189615680-0x00000001896156A0
	public void InitializeVec3Trace(Vector3d[] dirTrace, Vector3d dirVec) {} // 0x000000018123D180-0x000000018123D2A0
	// [XID] // 0x000000018961CE60-0x000000018961CE80
	private Vector3d AverageVec3Trace(Vector3d[] dirTrace, int K) => default; // 0x000000018123EB30-0x000000018123ED10
}

