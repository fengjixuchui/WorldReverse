/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoCamera;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SCameraPostModuleProtect : SCameraStatePostModule // TypeDefIndex: 32112
{
	// Fields
	private static double _orginMinDitherThreshold; // 0x00
	private static double _orginMaxDitherThreshold; // 0x08
	private static double _minDitherThreshold; // 0x10
	private static double _maxDitherThreshold; // 0x18
	private const double SMALL_NUM = 9.999999747378752E-06; // Metadata: 0x00B13F10
	private int _LayerIndex; // 0x18
	private Ray _ray; // 0x1C
	private RaycastHit _hitInfo; // 0x38
	private const double _rayHitTestHeight = 12; // Metadata: 0x00B13F18
	private Vector3d _avatarScreenSpeed; // 0x78
	private Vector3d _avatarWorldSpeed; // 0x90
	private Vector3d _avatarMoveDirBeforeNoMove; // 0xA8
	private ScreenMotion _avatarMotionType; // 0xC0
	private Vector2d _autoRotSpeed; // 0xC8
	private Vector2d _lastAutoRotSpeed; // 0xD8
	private bool _isAutoRot; // 0xE8
	private bool _isLastAutoRot; // 0xE9
	private CamState_L1 _camState_L1; // 0xEC
	private CamState_L2 _camState_L2; // 0xF0
	private Vector3d _baseSphericalKeepElev; // 0xF8
	private Vector3d _outputSphInLevel2; // 0x110
	private Vector3d _outputSphInLevel3; // 0x128
	private AutoRotateState _camRotState; // 0x140
	private CamAutoRotControlFlag _camAutoRotControl; // 0x148
	private CamState_L3 _camState_L3; // 0x150
	private double _timerManualPush; // 0x158
	private bool _isRadiusSqueezed; // 0x160
	private bool _isKeepingElevation; // 0x161
	private double _safeGoToCurCamPositionJumpDistance; // 0x168
	private bool _isNearPlaneHitWall_S2; // 0x170
	private CamState_L5 _camState_L5; // 0x174
	private CamState_L6 _camState_L6; // 0x178
	private bool _isSwingUpOrDown; // 0x17C
	private CameraNearPlaneCushion _camCushion; // 0x180
	private CameraNearPlaneCushion _keepForwardCamCushion; // 0x188
	private CameraNearPlaneCushion _swingCamCushion; // 0x190
	private const int ScopeColNum = 11; // Metadata: 0x00B13F20
	private const int ScopeRowNum = 5; // Metadata: 0x00B13F24
	private int _centerXInd; // 0x198
	private int _centerYInd; // 0x19C
	private double[,] _cameraScopeMatrix; // 0x1A0
	private int[,] _filterMatrix; // 0x1A8
	private double[] _deltaElevArray; // 0x1B0
	private double[] _deltaPoleArray; // 0x1B8
	private Vector3d[] _nearPlanePoints; // 0x1C0
	private Vector3d[] _nearPlaneCheckPoints; // 0x1C8
	private double _realPlaneToCheckPlaneDistance; // 0x1D0
	private bool[] _isOriginInWallArray; // 0x1D8
	private bool[] _isDoubleColliderArray; // 0x1E0
	private Vector3d[] _nearPlaneHitNormalArray; // 0x1E8
	private const int NON_ALLOC_COLLIDER_BUFFER_SIZE = 1; // Metadata: 0x00B13F28
	private int[] _collidersIdBuffer; // 0x1F0
	private const int NON_ALLOC_HIT_BUFFER_SIZE = 4; // Metadata: 0x00B13F2C
	private RaycastHit[] _hits; // 0x1F8
	private CameraScopePVR _camPVR; // 0x200
	private CameraScopePVR _camIdealRegion_In_PVR; // 0x208
	private const double PVR_SATURATION = 0.9200000166893005; // Metadata: 0x00B13F30
	private const double PVR_FILTER_DEPTH_TOLERANCE = 0.5; // Metadata: 0x00B13F38
	private CameraScopeBeltPatter XPatternLeft; // 0x210
	private CameraScopeBeltPatter XPatternRight; // 0x218
	private CameraScopeBeltPatter YPatternDown; // 0x220
	private CameraScopeBeltPatter YPatternUp; // 0x228
	private Vector2d _dragInnerFactor; // 0x230
	private Vector2d _reduceInnerFactor; // 0x240
	private Vector2d _reduceOuterFactor; // 0x250
	private const int AVATAR_TRACE_FRAME_RECORD_NUM = 15; // Metadata: 0x00B13F40
	private Vector3d[] _avatarScreenSpeedTrace; // 0x260
	private Vector3d[] _avatarWorldSpeedTrace; // 0x268
	private Vector3d _avatarMeanScreenSpeed; // 0x270
	private Vector3d _avatarMeanWorldSpeed; // 0x288
	private int _speedIndex; // 0x2A0
	private const double AVATAR_SCREEN_ACCUMLATED_SPEED_REDUCE_RATIO = 6; // Metadata: 0x00B13F44
	private Vector3d _avatarScreenCumSpeed; // 0x2A8
	private Vector3d _avatarWorldCumSpeed; // 0x2C0
	private AutoRotateState _recordCamRotBeforceReduce; // 0x2D8
	private const double MIN_SPEED_AVATAR_MOVING = 0.07999999821186066; // Metadata: 0x00B13F4C
	private const double MIN_SPEED_AVATAR_CLIMBING = 0.07999999821186066; // Metadata: 0x00B13F54
	private const double MIN_SPEED_AVATAR_MOVE_IN_Y = 0.1599999964237213; // Metadata: 0x00B13F5C
	private const double MIN_SPEED_AVATAR_MOVE_IN_X = 0.07999999821186066; // Metadata: 0x00B13F64
	private const double MIN_SPEED_AVATAR_MOVE_IN_Z = 0.1599999964237213; // Metadata: 0x00B13F6C
	private const double MIN_SPEED_AVATAR_MOVE_IN_X_2 = 1; // Metadata: 0x00B13F74
	private const double MIN_SPEED_AVATAR_MOVE_IN_Y_2 = 1; // Metadata: 0x00B13F7C
	private const double MOTION_RATIO_X_2_Y = 5; // Metadata: 0x00B13F84
	private const double MIN_SPEED_AVATAR_MOVE_IN_WORLD_Y = 1; // Metadata: 0x00B13F8C
	private const double ATTACHING_OVERLAP_RADIUS_THRESHOLD = 0.4000000059604645; // Metadata: 0x00B13F94
	private const double ATTACHING_OVERLAP_RADIUS_CLIMB_NOMOVE_THRESHOLD = 0.33000001311302185; // Metadata: 0x00B13F9C
	private const double BASELINE_FORWARD_CUT_THRESHOLD = 0.10000000149011612; // Metadata: 0x00B13FA4
	private const double BASELINE_BACKWARD_ATTACH_THRESHOLD = 0.4000000059604645; // Metadata: 0x00B13FAC
	private const double BASELINE_SPHERE_ATTACH_THRESHOLD = 0.5; // Metadata: 0x00B13FB4
	private const double ROTATE_VELOCITY_THRESHOLD_ALMOST_ZERO = 0.17499999701976776; // Metadata: 0x00B13FBC
	private const double SMALL_NUM_FOR_NEAR_CLIP_PLANE_THICKNESS = 0.0010000000474974513; // Metadata: 0x00B13FC4
	private double _yDirAutoRotationSpeedUpRatio; // 0x2E0
	private double _xDirAutoRotationSpeedUpRatio; // 0x2E8
	private const double Y_DIR_AUTO_ROTATION_SPEEDUP_RATIO_MOVING = 0.550000011920929; // Metadata: 0x00B13FCC
	private const double Y_DIR_AUTO_ROTATION_SPEEDUP_RATIO_DROPING_SLIPING_TOCLIMBING = 1; // Metadata: 0x00B13FD4
	private const double X_DIR_AUTO_ROTATION_SPEEDUP_RATIO_MOVING = 0.550000011920929; // Metadata: 0x00B13FDC
	private const double X_DIR_AUTO_ROTATION_SPEEDUP_RATIO_DROPING_SLIPING_TOCLIMBING = 2; // Metadata: 0x00B13FE4
	private double _min_Speed_Avatar_NoMove; // 0x2F0
	private double _min_Elevation_Angle; // 0x2F8
	private double _max_Elevation_Angle; // 0x300
	private double _attachingOverlapRadiusForNoHit; // 0x308
	private bool _isNearPlaneHasBeenModifed; // 0x310
	private double _initial_NearPlaneDistance; // 0x318
	private double _backwardDist; // 0x320
	private double _extremMinCameraRadius; // 0x328
	private bool _isInGrass; // 0x330
	private LevelSceneGrassPlugin _grassPlugin; // 0x338
	private double _nearCheckRatio; // 0x340
	private PipelineCameraGlobalConfig globalConfig; // 0x348
	private PipelineCameraModuleConfig config; // 0x350
	private Vector3d _lookAtPoint; // 0x358
	private bool _needProtect; // 0x370
	private const double ANGLE_PROTECT_MAX_ANGLE = 35; // Metadata: 0x00B13FEC
	private const double ANGLE_PROTECT_MIN_ANGLE = 20; // Metadata: 0x00B13FF4
	private const double ANGLE_PROTECT_ANGLE_OFFSET = 15; // Metadata: 0x00B13FFC
	private const double ANGLE_PROTECT_MIN_DITHER = 0.10000000149011612; // Metadata: 0x00B14004

	// Properties
	public static double minDitherThreshold { /* [XID] */ /* 0x00000001899F7C00-0x00000001899F7C20 */ get => default; } // 0x000000018270D560-0x000000018270D630 
	public static double maxDitherThreshold { /* [XID] */ /* 0x00000001899FF1B0-0x00000001899FF1D0 */ get => default; } // 0x00000001827142B0-0x0000000182714380 
	private double attachingOverlapRadiusForNoHit { /* [XID] */ /* 0x0000000189A15680-0x0000000189A156A0 */ get => default; } // 0x0000000182713F60-0x0000000182714010 

	// Nested types
	private enum ScreenMotion // TypeDefIndex: 32113
	{
		ToLeft = 0,
		ToRight = 1,
		ToDown = 2,
		ToUp = 3,
		ToLeftUp = 4,
		ToLeftDown = 5,
		ToRightUp = 6,
		ToRightDown = 7,
		ToStraightForward = 8,
		ToStraightBackward = 9,
		NoMove = 10
	}

	private enum CamState_L1 // TypeDefIndex: 32114
	{
		NoHit = 0,
		Avoid = 1
	}

	private enum CamState_L2 // TypeDefIndex: 32115
	{
		CandidSwing = 0,
		None = 1
	}

	private enum AutoRotateState // TypeDefIndex: 32116
	{
		AvoidX_ToLeft = 0,
		AvoidX_ToRight = 1,
		AvoidY_ToUp = 2,
		AvoidY_ToDown = 3,
		AvoidXY_FromeRightDown_ToLeftUp = 4,
		AvoidXY_FromeRightDown_ToLeft = 5,
		AvoidXY_FromeRightDown_ToUp = 6,
		AvoidXY_FromeRightUp_ToLeftDown = 7,
		AvoidXY_FromeRightUp_ToLeft = 8,
		AvoidXY_FromeRightUp_ToDown = 9,
		AvoidXY_FromeLeftDown_ToRightUp = 10,
		AvoidXY_FromeLeftDown_ToRight = 11,
		AvoidXY_FromeLeftDown_ToUp = 12,
		AvoidXY_FromeLeftUp_ToRightDown = 13,
		AvoidXY_FromeLeftUp_ToRight = 14,
		AvoidXY_FromeLeftUp_ToDown = 15,
		CatchX_ToLeft = 16,
		CatchX_ToRight = 17,
		GoToAvatarTrace = 18,
		Cut = 19,
		WhatTheFuck = 20,
		None = 21
	}

	private enum CamState_L3 // TypeDefIndex: 32117
	{
		None = 0,
		NormalPush = 1,
		ManualPush = 2,
		PredictPush = 3
	}

	private enum CamState_L4_S1 // TypeDefIndex: 32118
	{
		HoldOnLookAtPoint = 0,
		None = 1
	}

	private enum CamState_L4_S2 // TypeDefIndex: 32119
	{
		ReduceNear = 0,
		RecoverNear = 1,
		None = 2
	}

	private enum CamState_L5 // TypeDefIndex: 32120
	{
		SlowLerpingBack = 0,
		FastLerpingBack = 1,
		None = 2
	}

	private enum CamState_L6 // TypeDefIndex: 32121
	{
		None = 0,
		RecoverElevation = 1
	}

	// Constructors
	public SCameraPostModuleProtect() {} // 0x000000018271D700-0x000000018271DCB0
	static SCameraPostModuleProtect() {} // 0x000000018271D680-0x000000018271D700

	// Methods
	// [XID] // 0x000000018977F680-0x000000018977F6A0
	public static void SetUseDitherThresholds(double minThreshold, double maxThreshold) {} // 0x000000018271B360-0x000000018271B450
	// [XID] // 0x0000000189787040-0x0000000189787060
	public static void ResetUseDitherThresholds() {} // 0x000000018271A3A0-0x000000018271A470
	// [XID] // 0x0000000189A1CB80-0x0000000189A1CBA0
	public void SetProfile(CameraProfile profile) {} // 0x0000000182714010-0x00000001827142B0
	// [XID] // 0x0000000189A24120-0x0000000189A24140
	protected override void CollectInternal(double deltaTime, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x000000018270A6C0-0x000000018270A7B0
	// [XID] // 0x0000000189A2B570-0x0000000189A2B590
	protected override void TickInternal(double deltaTime, ref SCameraPostData data, ref CameraStateData retData, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x000000018270C8D0-0x000000018270CBF0
	// [XID] // 0x0000000189A32B30-0x0000000189A32B50
	private void CopyOutput(ref SCameraPostData data, ref CameraStateData retData, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000182712C40-0x0000000182712F10
	// [XID] // 0x0000000189A3A470-0x0000000189A3A490
	protected override void FlushInternal(double deltaTime, ref SCameraPostData data, ref CameraStateData retData, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x000000018271B590-0x000000018271B6A0
	// [XID] // 0x0000000189A41D50-0x0000000189A41D70
	private void InitGrassPlugin() {} // 0x000000018271A840-0x000000018271A930
	// [XID] // 0x0000000189A49360-0x0000000189A49380
	private void CheckThereIsGrass() {} // 0x0000000182710B00-0x0000000182710BC0
	// [XID] // 0x0000000189A50C40-0x0000000189A50C60
	private void PreProcessLastFrame(ref SCameraPostData data, ref CameraStateData retData, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000182716560-0x0000000182716770
	// [IDTag] // 0x0000000189A58160-0x0000000189A581A0
	// [XID] // 0x0000000189A58160-0x0000000189A581A0
	private void CheckAvatarMotionType(double deltaTime, Vector3d camForward, Vector3d camCommonUp, Vector3d lastFramePos, Vector3d curPos) {} // 0x000000018270B570-0x000000018270BE00
	// [IDTag] // 0x0000000189A62B90-0x0000000189A62BD0
	// [XID] // 0x0000000189A62B90-0x0000000189A62BD0
	private void CheckAvatarMotionType(Vector3d screenSpeed, Vector3d worldSpeed) {} // 0x000000018270B230-0x000000018270B570
	// [XID] // 0x0000000189A6D460-0x0000000189A6D480
	private void PreProcessForStateThreshold(ref SCameraPostData data) {} // 0x0000000182715240-0x0000000182715400
	// [XID] // 0x0000000189A74C20-0x0000000189A74C40
	private void Process_Level_1(ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x00000001827116F0-0x00000001827117C0
	// [XID] // 0x0000000189A7C840-0x0000000189A7C860
	private void CheckLevel_1_State(ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000182713CA0-0x0000000182713D90
	// [XID] // 0x0000000189A84110-0x0000000189A84130
	private bool Level_1_Check_CamIsHit(ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData) => default; // 0x000000018271B990-0x000000018271BCB0
	// [XID] // 0x0000000189A8BA70-0x0000000189A8BA90
	private double SphereProtectFroGrassRegion(ref SCameraPostData data, Vector3d origin, Vector3d camPos, double radius, int layerInd) => default; // 0x000000018271A470-0x000000018271A840
	// [XID] // 0x0000000189A93080-0x0000000189A930A0
	private void Process_Level_2(double deltaTime, ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018271D200-0x000000018271D2F0
	// [XID] // 0x0000000189A9AA90-0x0000000189A9AAB0
	private void PassThoughLevel2Data(double deltaTime, ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018271D3B0-0x000000018271D4C0
	// [XID] // 0x0000000189AA1D90-0x0000000189AA1DB0
	private void CheckLevel_2_SubState(double deltaTime, ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000182713D90-0x0000000182713F60
	// [XID] // 0x0000000189AA92B0-0x0000000189AA92D0
	private void OuterReduceAutoRotationSpeed(double deltaTime) {} // 0x0000000182709020-0x00000001827090E0
	// [XID] // 0x0000000189AB11B0-0x0000000189AB11D0
	private void ClearAutoRotStateToDefault() {} // 0x0000000182711230-0x00000001827113C0
	// [XID] // 0x0000000189AB8540-0x0000000189AB8560
	private void ReduceAutoRotationSpeed(double deltaTime) {} // 0x000000018271CDF0-0x000000018271CFB0
	// [XID] // 0x0000000189AC0140-0x0000000189AC0160
	private void StopAutoRotState_FromZeroSpeed() {} // 0x000000018271B450-0x000000018271B590
	// [XID] // 0x0000000189AC7BA0-0x0000000189AC7BC0
	private void RecordStateAndFlag() {} // 0x0000000182711640-0x00000001827116F0
	// [XID] // 0x0000000189ACF100-0x0000000189ACF120
	private double GetBaseLineHitDist(ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData, Vector3d baseLine) => default; // 0x00000001827175D0-0x0000000182717A80
	// [XID] // 0x0000000189AD6F50-0x0000000189AD6F70
	private void CamSwing_TransitionCondition(ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x00000001827173F0-0x00000001827175D0
	// [XID] // 0x0000000189ADE970-0x0000000189ADE990
	private void TransitionFromNone(ref AutoRotateState camRotType) {} // 0x000000018270D630-0x000000018270D780
	// [XID] // 0x0000000189AE62F0-0x0000000189AE6310
	private void CheckMoveXFromNone(ScreenMotion motionType, ref AutoRotateState camRotType) {} // 0x0000000182718190-0x0000000182718340
	// [XID] // 0x0000000189AEDA80-0x0000000189AEDAA0
	private void WhatIsXFromNone(int minX, int maxX, bool goToMax, int oppositeMaxInd, int currentMaxInd, ref AutoRotateState camRotType) {} // 0x000000018270CBF0-0x000000018270CDC0
	// [XID] // 0x0000000189AF52B0-0x0000000189AF52D0
	private void CheckMoveYFromNone(ScreenMotion motionType, ref AutoRotateState camRotType) {} // 0x0000000182713B00-0x0000000182713CA0
	// [XID] // 0x0000000189AFC850-0x0000000189AFC870
	private void WhatIsYFromNone(int minY, int maxY, bool goToMax, int oppositeMaxInd, ref AutoRotateState camRotType) {} // 0x000000018270C740-0x000000018270C8D0
	// [XID] // 0x0000000189B03F50-0x0000000189B03F70
	private void CheckMoveXYFromNone(ScreenMotion motionType, ref AutoRotateState camRotType) {} // 0x0000000182717DF0-0x0000000182717FE0
	// [XID] // 0x0000000189B0B7B0-0x0000000189B0B7D0
	private void WhatIsXYFromNone(int minX, int maxX, int minY, int maxY, bool goToMaxX, bool goToMaxY, int oppositeMaxIndY, int oppositeMaxIndX, int currentMaxIndx, ref AutoRotateState camRotType) {} // 0x0000000182713780-0x0000000182713B00
	// [XID] // 0x0000000189B12D20-0x0000000189B12D40
	private void CheckNomoveFromNone(ref AutoRotateState camRotType) {} // 0x0000000182709610-0x00000001827096C0
	// [XID] // 0x0000000189B1A3B0-0x0000000189B1A3D0
	private void CheckStraightFromNone(ref AutoRotateState camRotType) {} // 0x000000018270A230-0x000000018270A2E0
	// [XID] // 0x0000000189B21850-0x0000000189B21870
	private void ReTransitionFromWTF(ref AutoRotateState camRotType) {} // 0x000000018270FEB0-0x00000001827100B0
	// [XID] // 0x0000000189B29000-0x0000000189B29020
	private void TransitionFromAvoid(ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData, ref AutoRotateState camRotType) {} // 0x00000001827125D0-0x0000000182712C40
	// [XID] // 0x0000000189B30420-0x0000000189B30440
	private bool IsThereAlreadyPlentySpace(int oppositeMaxIndX, int currentMaxIndX, int oppositeMaxIndY, int currentMaxIndY, ref AutoRotateState camRotType) => default; // 0x0000000182719FB0-0x000000018271A3A0
	// [XID] // 0x0000000189B37D30-0x0000000189B37D50
	private bool IsTheOppositeSpaceHasBeenSqueezed(ref AutoRotateState camRotType) => default; // 0x0000000182708AD0-0x0000000182709020
	// [XID] // 0x0000000189B3F640-0x0000000189B3F660
	private bool IsAlmostGoToAvatarMotion(Vector3d curCamVec, ref double deltaAngle, bool removeY = false /* Metadata: 0x00B13F0E */) => default; // 0x0000000182717B20-0x0000000182717CF0
	// [XID] // 0x0000000189B47020-0x0000000189B47040
	private Vector3d GetAvatarMoitionVector() => default; // 0x000000018270B140-0x000000018270B230
	// [XID] // 0x0000000189B4E700-0x0000000189B4E720
	private void WillCurrentAvoidCrash(Vector3d curAvaPos, Vector3d avaSpeed, Vector3d curCamSph, Vector2d camRotSpeed, Vector2d camSpeedReduceRatio, Vector3d camCommonUp, AutoRotateState camRotType, ref double finalTime, ref double outElevTime, ref bool isCrash, ref bool isOverElevLimit, double nearPlaneDist, double halfFov, double aspect) {} // 0x0000000182715860-0x0000000182716560
	// [XID] // 0x0000000189B55F20-0x0000000189B55F40
	private void CurrentMotionIsOppositeWithCurrentAovid(ref AutoRotateState camRotType, ScreenMotion motionType, ref bool isHoriziontalConsistent, ref bool isVerticalConsistent) {} // 0x000000018271CFB0-0x000000018271D140
	// [XID] // 0x0000000189B5D800-0x0000000189B5D820
	private void TransitionFromCatch() {} // 0x0000000182717A80-0x0000000182717B20
	// [XID] // 0x0000000189B64DE0-0x0000000189B64E00
	private void TransitionFromGoToTrace() {} // 0x000000018270AED0-0x000000018270AF70
	// [XID] // 0x0000000189B6C3C0-0x0000000189B6C3E0
	private void CamSwing_ProcessingPerform(double deltaTime, ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData, AutoRotateState camRotType) {} // 0x0000000182710F30-0x0000000182711230
	// [XID] // 0x0000000189B73AD0-0x0000000189B73AF0
	private void GetDragPointBy_CamRotType_and_PVR(int MaxIndX, int MaxIndY, ref AutoRotateState camRotType, CameraScopePVR idealPVR, ref int goDirX, ref int goDirY) {} // 0x0000000182712F10-0x0000000182713780
	// [XID] // 0x0000000189B7B0E0-0x0000000189B7B100
	private void CreateRotationBy_DragPoint_Smooth_Reduce(double deltaTime, Vector3d orgPos, Vector3d refSph, CameraScopePVR idealPVR, int goDirX, int goDirY, Vector2d lastRotSpeed, Vector3d lastSph, Vector3d avatarSpeed, ref Vector3d outSph, ref Vector2d outRotSpeed, bool isStart = false /* Metadata: 0x00B13F0F */) {} // 0x00000001827096C0-0x000000018270A0C0
	// [XID] // 0x0000000189B82AB0-0x0000000189B82AD0
	private void CheckIfKeepElevation(ref SCameraPostData data) {} // 0x0000000182717CF0-0x0000000182717DF0
	// [XID] // 0x0000000189B8A0D0-0x0000000189B8A0F0
	private void Process_Level_3(double deltaTime, ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018270ADB0-0x000000018270AED0
	// [XID] // 0x0000000189B91720-0x0000000189B91740
	private void CheckLevel_3_State(double deltaTime, ref SCameraPostData data, ref CamState_L3 nextCamState_L3, CamState_L3 curCamState_L3) {} // 0x0000000182716850-0x0000000182716990
	// [XID] // 0x0000000189B98B80-0x0000000189B98BA0
	private void TransitionCamState_L3_From_None(ref SCameraPostData data, ref CamState_L3 nextCamState_L3) {} // 0x000000018270A7B0-0x000000018270A8B0
	// [XID] // 0x0000000189B9FEA0-0x0000000189B9FEC0
	private void TransitionCamState_L3_From_ManualPush(double deltaTime, ref SCameraPostData data, ref CamState_L3 nextCamState_L3) {} // 0x000000018270A2E0-0x000000018270A420
	// [XID] // 0x0000000189BA7720-0x0000000189BA7740
	private void TransitionCamState_L3_From_NormalPush(ref SCameraPostData data, ref CamState_L3 nextCamState_L3) {} // 0x0000000182710330-0x0000000182710430
	// [XID] // 0x0000000189BAE9F0-0x0000000189BAEA10
	private void PerformLevel_3_State(double deltaTime, ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018270A0C0-0x000000018270A230
	// [XID] // 0x0000000189BB6180-0x0000000189BB61A0
	private void CheckIfRadiusIsSqueezed(ref SCameraPostData data) {} // 0x000000018270CDC0-0x000000018270CE90
	// [XID] // 0x0000000189BBD7A0-0x0000000189BBD7C0
	private Vector3d ProcessManualPush(double deltaTime, ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData) => default; // 0x00000001827117C0-0x0000000182711F90
	// [XID] // 0x0000000189BC5510-0x0000000189BC5530
	private Vector3d ProcessNormalPush(ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData) => default; // 0x00000001827147A0-0x0000000182714E20
	// [XID] // 0x0000000189BCCF80-0x0000000189BCCFA0
	private void Process_Level_4(double deltaTime, ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x00000001827100B0-0x00000001827101A0
	// [XID] // 0x0000000189BD4520-0x0000000189BD4540
	private void CheckLevel_4_State_S2(double deltaTime, ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000182710BC0-0x0000000182710F30
	// [XID] // 0x0000000189BDBFF0-0x0000000189BDC010
	private void TryModifyNearPlaneOffset(double deltaTime, ref SCameraPostData data, Vector3d targetPosition, Vector3d camPosition, Vector3d camForward, double halfFov, double aspect, Vector3d camCommonUp) {} // 0x0000000182718DF0-0x0000000182719960
	// [XID] // 0x00000001895E87F0-0x00000001895E8810
	private void TryRecoverNearPlaneOffset(double deltaTime, ref SCameraPostData data, Vector3d camPosition) {} // 0x00000001827113C0-0x0000000182711640
	// [XID] // 0x00000001895F00A0-0x00000001895F00C0
	private void Process_Level_5(double deltaTime, ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018270A420-0x000000018270A540
	// [XID] // 0x00000001895F7A60-0x00000001895F7A80
	private void CheckLevel_5_State(ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData, ref CamState_L5 nextCamState_L5, CamState_L5 curCamState_L5) {} // 0x000000018270C1B0-0x000000018270C6A0
	// [XID] // 0x00000001895FEE30-0x00000001895FEE50
	private bool CheckIfStartLerpBack(ref SCameraPostData data, Vector3d outSph, Vector3d orgPos, Vector3d camUp, double safeBackDistThreshold, double safeBackSphereRadius, ref double backwardDist) => default; // 0x000000018271BDC0-0x000000018271C260
	// [XID] // 0x00000001896066F0-0x0000000189606710
	private bool CheckIfStopLerpBack(ref SCameraPostData data, Vector3d outSph, Vector3d orgPos, Vector3d camUp, double stopBackDistThreshold, double stopBackSphereRadius) => default; // 0x000000018270AF70-0x000000018270B140
	// [XID] // 0x000000018960DFF0-0x000000018960E010
	private void PerformLevel_5_State(double deltaTime, ref SCameraPostData data) {} // 0x0000000182719DF0-0x0000000182719FB0
	// [XID] // 0x0000000189615660-0x0000000189615680
	private void Process_Level_6(double deltaTime, ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018271C260-0x000000018271C380
	// [XID] // 0x000000018961CE40-0x000000018961CE60
	private void CheckLevel_6_State(ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData, ref CamState_L6 nextCamState_L6, CamState_L6 curCamState_L6) {} // 0x0000000182714380-0x00000001827144C0
	// [XID] // 0x00000001896243F0-0x0000000189624410
	private bool CheckIfStartRecoverElevation(ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData) => default; // 0x0000000182716770-0x0000000182716850
	// [XID] // 0x000000018962BA50-0x000000018962BA70
	private bool CheckIfStopRecoverElevation(ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData) => default; // 0x0000000182711F90-0x00000001827125D0
	// [XID] // 0x0000000189633630-0x0000000189633650
	private void PerformLevel_6_State(double deltaTime, ref SCameraPostData data) {} // 0x000000018270A540-0x000000018270A6C0
	// [XID] // 0x000000018963AF10-0x000000018963AF30
	private void OutPutCameraParameters(ref SCameraPostData data, ref CameraStateData retData, ref CameraAvatarInfoData avatarInfoData, Vector3d finalSpherical) {} // 0x000000018271AE40-0x000000018271B360
	// [XID] // 0x00000001896425E0-0x0000000189642600
	private void ReduceAccumulatedVariable(double deltaTime) {} // 0x000000018271D4C0-0x000000018271D680
	// [XID] // 0x0000000189649CD0-0x0000000189649CF0
	private Vector3d GetCamForward(Vector3d Sph, double dpole, double dElev) => default; // 0x000000018271B6A0-0x000000018271B990
	// [IDTag] // 0x0000000189651370-0x00000001896513B0
	// [XID] // 0x0000000189651370-0x00000001896513B0
	private bool CheckNearPlaneOverLap(ref SCameraPostData data, Vector3d camPos, Vector3d camForwawrd, Vector3d commonUp) => default; // 0x000000018270CE90-0x000000018270D1F0
	// [IDTag] // 0x000000018965BD30-0x000000018965BD70
	// [XID] // 0x000000018965BD30-0x000000018965BD70
	private bool CheckNearPlaneOverLap(ref SCameraPostData data, Vector3d camPos, Vector3d camForwawrd, Vector3d commonUp, double nearPlaneDist) => default; // 0x000000018270D1F0-0x000000018270D560
	// [XID] // 0x0000000189666180-0x00000001896661A0
	private bool CheckOverlapBox(Vector3d boxCenter, Vector3d boxExtents, Quaternion boxRotation) => default; // 0x000000018270BFD0-0x000000018270C1B0
	// [XID] // 0x000000018966D980-0x000000018966D9A0
	private bool NearPlaneConeHitTest(double nearPlaneDist, double halfFov, double aspect, int layerMask, Vector3d targetPosition, Vector3d camPosition, Vector3d camCommonUp) => default; // 0x000000018270A8B0-0x000000018270ADB0
	// [XID] // 0x00000001896757C0-0x00000001896757E0
	private void CamNearPlaneCushionDetect(double nearPlaneDist, double halfFov, double aspect, double hitTolerance, int layerMask, CameraNearPlaneCushion camCushion, Vector3d targetPosition, Vector3d camPosition, Vector3d camCommonUp) {} // 0x000000018271C380-0x000000018271CDF0
	// [XID] // 0x000000018967D090-0x000000018967D0B0
	private bool CameraNearClipPlaneHitTestPrecisely(Vector3d origin, Vector3d center, double hitThreshold, Vector3d halfExtents, Vector3d upWard, out double farPushDis, out double cushionMinDis, out double cushionMaxDis) {
		farPushDis = default;
		cushionMinDis = default;
		cushionMaxDis = default;
		return default;
	} // 0x000000018270D780-0x000000018270FEB0
	// [XID] // 0x0000000189684740-0x0000000189684760
	private void GetCamNearPlane(double nearPlaneDist, double halfFov, double aspect, Vector3d camPosition, Vector3d camForward, Vector3d camCommonUp) {} // 0x0000000182710430-0x0000000182710B00
	// [XID] // 0x000000018968C250-0x000000018968C270
	private bool CheckOverlapSphere(Vector3d orgPos, double radius) => default; // 0x0000000182717FE0-0x0000000182718190
	// [XID] // 0x0000000189693DC0-0x0000000189693DE0
	private bool SimpleCheckCamNearPlane(double nearPlaneDist, double halfFov, double aspect, double hitTolerance, int layerMask, out double farDistance, Vector3d targetPosition, Vector3d camPosition, Vector3d camCommonUp) {
		farDistance = default;
		return default;
	} // 0x00000001827144C0-0x00000001827147A0
	// [XID] // 0x000000018969B350-0x000000018969B370
	private bool NearPlane_Several_RayCast(Vector3d rayDirectionNormalized, double rayHeight, double threshold, int layerMask, out double farDistance) {
		farDistance = default;
		return default;
	} // 0x0000000182716990-0x00000001827173F0
	// [XID] // 0x00000001896A2AD0-0x00000001896A2AF0
	private bool IsCameraAttachingAWall(Vector3d pos, double radius) => default; // 0x000000018271BCB0-0x000000018271BDC0
	// [XID] // 0x00000001896A9F00-0x00000001896A9F20
	private void GetCamScope(Vector3d orgPos, Vector3d refSph) {} // 0x0000000182718340-0x0000000182718600
	// [XID] // 0x00000001896B0CD0-0x00000001896B0CF0
	private void CreateCameraMatrixPattern(int RowNum, int ColNum, ref int[,] CameraPatternMatrix) {} // 0x000000018270BE00-0x000000018270BFD0
	// [XID] // 0x00000001896B8900-0x00000001896B8920
	private void RayCastCameraMatrixScope(Vector3d orgPos, Vector3d refDir, double[] deltaElevArray, double[] deltaPoleArray, ref int[,] CameraPatternMatrix, ref double[,] CameraScopeMatrix, double detectDist) {} // 0x0000000182719960-0x0000000182719DF0
	// [XID] // 0x00000001896BFAE0-0x00000001896BFB00
	private void FixWholeCameraMatrixScope(int RowNum, int ColNum, int[,] CameraPatternMatrix, ref double[,] CameraScopeMatrix, double defaultNum) {} // 0x0000000182718A70-0x0000000182718DF0
	// [XID] // 0x00000001896C7430-0x00000001896C7450
	private void FilterScopeForSingleRegion(int RowNum, int ColNum, ref int[,] FilterMatrix, double[,] CameraScopeMatrix, double threshold) {} // 0x00000001827101A0-0x0000000182710330
	// [XID] // 0x00000001896CEB70-0x00000001896CEB90
	private void GetCameraScopePVR(int RowNum, int ColNum, ref int[,] FilterMatrix, double[,] CameraScopeMatrix, double thresholdSat, CameraScopePVR pvr) {} // 0x000000018271A930-0x000000018271AE40
	// [XID] // 0x00000001896D5FF0-0x00000001896D6010
	private void GetBeltPattern(int RowNum, int ColNum, bool alongX, ref int[,] FilterMatrix, CameraScopeBeltPatter PatternLower, CameraScopeBeltPatter PatternUpper, bool isNeedConcated) {} // 0x0000000182714E20-0x0000000182715240
	// [XID] // 0x00000001896DD570-0x00000001896DD590
	private void SetAvatarDitherAlphaValue(ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x00000001827090E0-0x0000000182709610
	// [XID] // 0x00000001896E4C60-0x00000001896E4C80
	private void HoldOnCameraPositionInLastFrame(ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000182718600-0x0000000182718A70
	// [XID] // 0x00000001896EC180-0x00000001896EC1A0
	private void HoldOnCameraSphericalInLastFrame(ref SCameraPostData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000182715400-0x0000000182715860
}

