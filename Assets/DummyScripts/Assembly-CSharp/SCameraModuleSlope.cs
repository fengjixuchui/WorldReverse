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

public sealed class SCameraModuleSlope : SCameraModuleBase // TypeDefIndex: 32101
{
	// Fields
	private const double BACK_TO_IDEAL_FACTOR = 9.999999747378752E-05; // Metadata: 0x00B13E82
	private const double THRESHOLD_XZ_AVATAR_MOVE = 0.004999999888241291; // Metadata: 0x00B13E8A
	private const double THRESHOLD_Y_AVATAR_MOVE = 0.004999999888241291; // Metadata: 0x00B13E92
	private const double THRESHOLD_FOR_LASTSLOPE_IS_CONSISTENT_WITH_IDEALSSLOPE = 0.10000000149011612; // Metadata: 0x00B13E9A
	private const double STEOP_CHECK_COEFF_DURING_GLOCAL_SLOPE_IS_HIGH = 0.1745329238474369; // Metadata: 0x00B13EA2
	private const double BASE_RAY_CAST_ELEVATION_RAD = 0.3490658476948738; // Metadata: 0x00B13EAA
	private const double SPHERE_CAST_RADIUS = 0.20000000298023224; // Metadata: 0x00B13EB2
	private const double VIEW_SCOPE_DETECT_DISTANCE = 100; // Metadata: 0x00B13EBA
	private const double SLOPE_DEG_IF_FRONT_AND_BACK_ARE_DIFFERENT_WHEN_LOCKING = 4; // Metadata: 0x00B13EC2
	private Ray _ray; // 0x28
	private Ray _rayOrg; // 0x40
	private RaycastHit _outHitInfo; // 0x58
	private bool _isHitGround; // 0x98
	private int _layerMask; // 0x9C
	private Vector3d _footHitPoint; // 0xA0
	private Vector3d _lastFootHitPoint; // 0xB8
	private bool _isLastFootHitPointValid; // 0xD0
	private double _lastFrameSlope; // 0xD8
	private double _slopeChangeSpeed; // 0xE0
	private double _lastViewScope; // 0xE8
	private double _viewScope; // 0xF0
	private double _goodViewScopeElevationRad; // 0xF8
	private bool _isRecordingViewScope; // 0x100
	private const int NUM_FRONT_FAN_DETECT_IN_POLE = 0; // Metadata: 0x00B13ECA
	private const int NUM_FRONT_FAN_DETECT_IN_DEPTH = 2; // Metadata: 0x00B13ECE
	private bool[,] _frontHMapValid; // 0x108
	private Vector3d[,] _frontHMapPoint; // 0x110
	private Vector3d[,] _frontHMapNormal; // 0x118
	private const int NUM_BACK_FAN_DETECT_IN_POLE = 0; // Metadata: 0x00B13ED2
	private const int NUM_BACK_FAN_DETECT_IN_DEPTH = 2; // Metadata: 0x00B13ED6
	private bool[,] _backHMapValid; // 0x120
	private Vector3d[,] _backHMapPoint; // 0x128
	private Vector3d[,] _backHMapNormal; // 0x130

	// Properties
	public override CameraModuleType moduleType { /* [XID] */ /* 0x00000001897CE840-0x00000001897CE860 */ get => default; } // 0x0000000181CB9E40-0x0000000181CB9EE0 

	// Constructors
	public SCameraModuleSlope() {} // 0x0000000181CBCB80-0x0000000181CBCDE0

	// Methods
	// [XID] // 0x00000001897D6000-0x00000001897D6020
	public override void Init(CameraProfile profile, SCameraBaseState state) {} // 0x0000000181CBA420-0x0000000181CBA4F0
	// [XID] // 0x00000001897DD8E0-0x00000001897DD900
	private void InitSlopEnable(PipelineCameraGlobalConfig globalConfig) {} // 0x0000000181CB8900-0x0000000181CB89B0
	// [XID] // 0x00000001897E5210-0x00000001897E5230
	public override bool CheckEnable(ref CameraShareData data) => default; // 0x0000000181CB8D30-0x0000000181CB8E10
	// [XID] // 0x00000001897ECD60-0x00000001897ECD80
	public override void Tick(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181CBA4F0-0x0000000181CBAB20
	// [XID] // 0x00000001897F45D0-0x00000001897F45F0
	private void ClearSlopeData(ref CameraShareData data, bool resetCheckDelay = true /* Metadata: 0x00B13E6F */) {} // 0x0000000181CB89B0-0x0000000181CB8AB0
	// [XID] // 0x00000001897FC000-0x00000001897FC020
	private bool CheckFootPoint(ref CameraAvatarInfoData avatarInfoData) => default; // 0x0000000181CBC3F0-0x0000000181CBC6F0
	// [XID] // 0x0000000189803480-0x00000001898034A0
	private double FrontEstimateSlopeFan(Vector3d orgFootPos, Vector3d orgPos, double firstHeight, Vector3d dir, double stepPoleRad, double stepY, double elevRad, double downDetectHeight, double localToGlobalThresold, double normalValidThrehold = 0.5 /* Metadata: 0x00B13E70 */, bool debugFlag = false /* Metadata: 0x00B13E78 */) => default; // 0x0000000181CBAD50-0x0000000181CBBD80
	// [XID] // 0x000000018980AA20-0x000000018980AA40
	private double BackEstimateSlopeFan(Vector3d orgFootPos, Vector3d orgPos, double firstHeight, Vector3d dir, double stepPoleRad, double stepY, double elevRad, double downDetectHeight, double localToGlobalThresold, double normalValidThrehold = 0.5 /* Metadata: 0x00B13E79 */, bool debugFlag = false /* Metadata: 0x00B13E81 */) => default; // 0x0000000181CB8E10-0x0000000181CB9E40
	// [XID] // 0x0000000189812090-0x00000001898120B0
	private double RefineSlopeCondition(double frontSlope, double backSlope, bool isInMove, ref CameraShareData data) => default; // 0x0000000181CBC000-0x0000000181CBC3F0
	// [XID] // 0x0000000189819C40-0x0000000189819C60
	private double CombineAvatarFootSlopeAndGlobaSlope(Vector3d SlopeVector, ref CameraShareData data) => default; // 0x0000000181CBA1C0-0x0000000181CBA420
	// [XID] // 0x00000001898214B0-0x00000001898214D0
	private double DetectAvatarLocalSlopeUsingFrameChange(Vector3d oldFootPos, Vector3d curFootPos, Vector3d CameraGlobalSlope, Vector3d CameraDir, double thresholdXZ, double thresholdY, double stopGlobalThreshold) => default; // 0x0000000181CBC770-0x0000000181CBCB80
	// [XID] // 0x0000000189828AB0-0x0000000189828AD0
	private void AdjustSlopeChangeSpeed(double deltaTime, double ingoreSlope, double SlopeSpeedLerpRatio, double idealSlopeSpeed, ref double curSlopeSpeed, ref double curSlope, double lastSlope, ref CameraShareData data) {} // 0x0000000181CB8B40-0x0000000181CB8D30
	// [XID] // 0x000000018982FEC0-0x000000018982FEE0
	private void LerpCurrentSlope(double deltaTime, ref double curSlope, ref double lastSlope, double lerpSlopeSpeed) {} // 0x0000000181CBABC0-0x0000000181CBAD50
	// [XID] // 0x0000000189837600-0x0000000189837620
	private void SlopeViewControl(ref Vector3d SlopeVector, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181CB9EE0-0x0000000181CBA1C0
	// [XID] // 0x000000018983EC50-0x000000018983EC70
	private double GetCurrentCameraViewScope(Vector3d originPos, Vector3d direction) => default; // 0x0000000181CBBD80-0x0000000181CBBF90
	// [XID] // 0x00000001898462F0-0x0000000189846310
	private void ComputeOutputParam(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181CB85D0-0x0000000181CB8900
}

