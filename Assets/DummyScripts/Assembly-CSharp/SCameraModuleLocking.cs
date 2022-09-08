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

public sealed class SCameraModuleLocking : SCameraModuleBase // TypeDefIndex: 32097
{
	// Fields
	private const double DEFAULT_MULTI_ENEMY_MAX_RANGE = 40; // Metadata: 0x00B13DE7
	public const double STOP_LERP_THRESHOLD_RADIUS = 0.0010000000474974513; // Metadata: 0x00B13DEF
	private PipelineCameraModuleConfig _initConfig; // 0x28
	private int _LayerIndex; // 0x30
	private Ray _ray; // 0x34
	private RaycastHit _hitInfo; // 0x50
	private int _flagNum; // 0x90
	private Vector3d _avatarCenter; // 0x98
	private Vector3d _enemyPosition; // 0xB0
	private Vector3d _enemyLookAtPosition; // 0xC8
	private double _enemyYHeight; // 0xE0
	private double _elevWithHeightRatio; // 0xE8
	private Vector3d _dirCamera2Avatar; // 0xF0
	private Vector3d _dirCamera2Enemy; // 0x108
	private Vector3d _dirAvatar2Enemy; // 0x120
	private double _distanceAvatar2Enemy; // 0x138
	private double _heightAvatar2Enemy; // 0x140
	private double _bestPosAngle; // 0x148
	private double _bestNegAngle; // 0x150
	private double _minPosAngle; // 0x158
	private double _minNegAngle; // 0x160
	private double _minAgle; // 0x168
	private double _maxPosAngle; // 0x170
	private double _maxNegAngle; // 0x178
	private double _maxAgle; // 0x180
	private double _slopeRatio; // 0x188
	private double _currentTotalLocateRatio; // 0x190
	public RadialBasisNetwork camPosXNet; // 0x198
	public RadialBasisNetwork camPosYNet; // 0x1A0
	public RadialBasisNetwork camPosZNet; // 0x1A8
	public RadialBasisNetwork camTarXNet; // 0x1B0
	public RadialBasisNetwork camTarYNet; // 0x1B8
	public RadialBasisNetwork camPosXMAXNet; // 0x1C0
	public RadialBasisNetwork camPosZMAXNet; // 0x1C8
	public RadialBasisNetwork camPosXMINNet; // 0x1D0
	public RadialBasisNetwork camPosZMINNet; // 0x1D8
	private double[] NetworkInputs; // 0x1E0
	private Vector3d NetworkCamPos; // 0x1E8
	private Vector3d NetworkCamPosXZMAX; // 0x200
	private Vector3d NetworkCamPosXZMIN; // 0x218
	private Vector3d[] _baseLineNormalized; // 0x230
	private double _SlopCompenstateElevationAngle; // 0x238
	private double[] _inputNetXZ; // 0x240
	private double[] _inputNetY; // 0x248
	private double[] _outputNetX; // 0x250
	private double[] _outputNetY; // 0x258
	private double[] _outputNetZ; // 0x260
	private double[] _outputNetMaxX; // 0x268
	private double[] _outputNetMaxZ; // 0x270
	private double[] _outputNetMinX; // 0x278
	private double[] _outputNetMinZ; // 0x280
	private Vector3d _cameraIdealSpherical; // 0x288
	private Vector3d _oldCameraIdealSpherical; // 0x2A0
	public double _deltaForwardPoleAngle; // 0x2B8
	public double _deltaForwardElveAngle; // 0x2C0
	private const double MIN_HEIGHT_AVATAR_2_ENEMY = -14; // Metadata: 0x00B13DF7
	private const double MAX_HEIGHT_AVATAR_2_ENEMY = 14; // Metadata: 0x00B13DFF
	private const double NORMALIZED_HEIGHT_RATIO = 20; // Metadata: 0x00B13E07
	private const double BASELINE_LENGTH_XZ = 15; // Metadata: 0x00B13E0F
	private const double NORMALIED_BASE_Y_HEIGHT = 1.850000023841858; // Metadata: 0x00B13E17
	private const double HEIGHTY_LEVEL_1 = 0.5; // Metadata: 0x00B13E1F
	private const double HEIGHTY_LEVEL_2 = 1; // Metadata: 0x00B13E27
	private const double HEIGHTY_LEVEL_3 = 2; // Metadata: 0x00B13E2F
	private const double MAX_CHANGE_FOR_POLE_ANGLE_SPRING = 2.9670597054064274; // Metadata: 0x00B13E37
	private bool _selectSideJump; // 0x2C8
	private double _combatElevHeightRatio; // 0x2D0
	private bool _isKillingLastEnemty; // 0x2D8
	private bool _isHavingAttackTarget; // 0x2D9
	private uint _attackTargetRuntimeID; // 0x2DC
	private uint _currentKillingTargetRuntimeID; // 0x2E0
	private double _timerWaitEnemyLost; // 0x2E8
	private Vector3d _lockingEnemyPosition; // 0x2F0
	private double _lockingEnemyYHeight; // 0x308
	private Vector3d _lastEnemyPosition; // 0x310
	private bool _isAttacking; // 0x328
	private uint _trackDataHandler; // 0x32C
	private uint _trackDataReverseHandler; // 0x330
	private CameraTrackScriptData _trackData; // 0x338
	private CameraTrackScriptData _trackDataReverse; // 0x340
	private double _baseLineXZ; // 0x348
	private double _height; // 0x350
	private bool _useTrack; // 0x358
	public bool enterMinCircleFlag; // 0x359
	public bool isGoingToIdeal; // 0x35A
	public bool isGoingToIdealElev; // 0x35B
	public bool isGoingToIdealElevationFirstEnter; // 0x35C
	public bool isGoingToIdealElevationSlow; // 0x35D
	public bool radiusLock; // 0x35E
	public double radiusLockValue; // 0x360
	public bool needLerp; // 0x368
	private SCameraLockingState _lockingState; // 0x370
	private SCameraLockingData _lockingData; // 0x378

	// Properties
	public override CameraModuleType moduleType { /* [XID] */ /* 0x0000000189624410-0x0000000189624430 */ get => default; } // 0x0000000181878670-0x0000000181878710 

	// Constructors
	public SCameraModuleLocking() {} // 0x000000018187DFC0-0x000000018187E310

	// Methods
	// [XID] // 0x000000018962BA70-0x000000018962BA90
	public override void Dispose() {} // 0x000000018187D370-0x000000018187D460
	// [XID] // 0x0000000189633650-0x0000000189633670
	private void InitParam() {} // 0x000000018187B450-0x000000018187B5D0
	// [XID] // 0x000000018963AF30-0x000000018963AF50
	private void InitLegacyParam() {} // 0x000000018187C3E0-0x000000018187CB50
	// [XID] // 0x0000000189642600-0x0000000189642620
	public override void Init(CameraProfile profile, SCameraBaseState state) {} // 0x0000000181879610-0x0000000181879750
	// [XID] // 0x0000000189649CF0-0x0000000189649D10
	public override void Start(ref CameraShareData data) {} // 0x0000000181878970-0x0000000181878A40
	// [XID] // 0x00000001896513B0-0x00000001896513D0
	public override void Collect(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x0000000181878140-0x0000000181878260
	// [XID] // 0x0000000189658BF0-0x0000000189658C10
	private void PrepareLockingData() {} // 0x000000018187B100-0x000000018187B230
	// [XID] // 0x00000001896602E0-0x0000000189660300
	public void CombatSetting(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x000000018187BDC0-0x000000018187C3E0
	// [XID] // 0x0000000189667C40-0x0000000189667C60
	private void GetAttackTargetHeight(ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x00000001818798C0-0x0000000181879A60
	// [XID] // 0x000000018966F730-0x000000018966F750
	public override void Tick(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181879750-0x00000001818798C0
	// [XID] // 0x0000000189676FE0-0x0000000189677000
	public override bool ShiftWorld(Vector3d newShift, Vector3d oldShift) => default; // 0x000000018187CC40-0x000000018187CF80
	// [XID] // 0x000000018967E5B0-0x000000018967E5D0
	private void PreCalculate(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181879220-0x0000000181879610
	// [XID] // 0x0000000189685DD0-0x0000000189685DF0
	private void LimitAttackTargetOnTheGroundDuringHitAway(ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018187BA70-0x000000018187BDC0
	// [XID] // 0x000000018968DC50-0x000000018968DC70
	private void SmoothAttackingTarget(double deltaTime) {} // 0x0000000181878260-0x0000000181878450
	// [XID] // 0x00000001896955A0-0x00000001896955C0
	private void BattleInfoCollector(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018187AB40-0x000000018187AF30
	// [XID] // 0x000000018969CC10-0x000000018969CC30
	private void NetworkOutput(ref CameraShareData data) {} // 0x0000000181879B00-0x000000018187A2A0
	// [XID] // 0x00000001896A3F40-0x00000001896A3F60
	private void NetworkDeparse(ref CameraShareData data) {} // 0x000000018187D720-0x000000018187DFC0
	// [XID] // 0x00000001896AB4E0-0x00000001896AB500
	private void SelectBestSide(ref CameraShareData data) {} // 0x000000018187A3C0-0x000000018187A8C0
	// [XID] // 0x00000001896B2790-0x00000001896B27B0
	private double GetRayCastTravelDistance(Vector3d Origin, Vector3d Target) => default; // 0x000000018187B640-0x000000018187B950
	// [XID] // 0x00000001896B9E30-0x00000001896B9E50
	private void ComputeCameraRadiusUsingLocateRatio(ref CameraShareData data) {} // 0x000000018187D600-0x000000018187D720
	// [XID] // 0x00000001896C11B0-0x00000001896C11D0
	private void PostMotionAndProcess(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018187D0A0-0x000000018187D370
	// [XID] // 0x00000001896C87D0-0x00000001896C87F0
	private void CheckIfIsGoingToIdeal(ref CameraShareData data) {} // 0x0000000181878710-0x00000001818788B0
	// [XID] // 0x00000001896D0200-0x00000001896D0220
	private bool CheckAngleIsInRange(double angle1, double angle2, double angle, bool isDeg, ref double nearestAngle) => default; // 0x0000000181878A40-0x0000000181878C20
	// [XID] // 0x00000001896D7720-0x00000001896D7740
	private void LerpPoleAngle(double deltaTime, ref CameraShareData data) {} // 0x0000000181878450-0x0000000181878670
	// [XID] // 0x00000001896DEF40-0x00000001896DEF60
	private void GetSlopeCompensateAngle(ref CameraShareData data) {} // 0x000000018187B950-0x000000018187BA70
	// [XID] // 0x00000001896E63B0-0x00000001896E63D0
	private void CheckIfIsGoingToIdeaElevation(ref CameraShareData data) {} // 0x000000018187CF80-0x000000018187D0A0
	// [XID] // 0x00000001896ED8C0-0x00000001896ED8E0
	private void LerpElevAngle(double deltaTime, ref CameraShareData data) {} // 0x000000018187A8C0-0x000000018187AB40
	// [XID] // 0x00000001896F5040-0x00000001896F5060
	private void ComputeDeltaPoleAngle_UsingMinMax(ref CameraShareData data) {} // 0x0000000181877D50-0x0000000181878140
	// [XID] // 0x00000001896FC8C0-0x00000001896FC8E0
	private void LerpDeltaPoleAngle(double deltaTime, ref CameraShareData data) {} // 0x000000018187B330-0x000000018187B450
	// [XID] // 0x0000000189703D40-0x0000000189703D60
	private void LerpDeltaElevAngle(double deltaTime, ref CameraShareData data) {} // 0x000000018187D460-0x000000018187D580
	// [XID] // 0x000000018970B650-0x000000018970B670
	private void LerpRadius(double deltaTime, ref CameraShareData data) {} // 0x000000018187AF90-0x000000018187B100
	// [XID] // 0x0000000189712E70-0x0000000189712E90
	private void CheckIfStopGoingToIdeal() {} // 0x000000018187CB50-0x000000018187CC40
	// [XID] // 0x000000018971A750-0x000000018971A770
	private void CheckIfStopGoingToIdealElevation(ref CameraShareData data) {} // 0x000000018187A2A0-0x000000018187A3C0
	// [XID] // 0x0000000189721AD0-0x0000000189721AF0
	private void LerpRadiusLockRecover() {} // 0x000000018187B230-0x000000018187B330
	// [XID] // 0x0000000189729100-0x0000000189729120
	private void OutPutCameraParamByPos(Vector3d finalPosition, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181878CD0-0x0000000181879220
}

