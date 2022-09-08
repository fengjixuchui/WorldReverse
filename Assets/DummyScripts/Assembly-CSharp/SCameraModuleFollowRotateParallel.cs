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

public sealed class SCameraModuleFollowRotateParallel : SCameraModuleBase // TypeDefIndex: 32093
{
	// Fields
	private int _LayerIndex; // 0x28
	private Ray _ray; // 0x2C
	private RaycastHit _hitInfo; // 0x48
	private const double _rayHitTestHeight = 12; // Metadata: 0x00B13CBF
	private Vector3d _refAnchorSpherical; // 0x88
	private Vector3d _backward; // 0xA0
	private double _lastFrameIdealYaw; // 0xB8
	private bool _isReachingIdeal; // 0xC0
	private double _idealElevation; // 0xC8
	private double _idealPole; // 0xD0
	private int _YLookUpOrDownFrameCount; // 0xD8
	private Vector3d _hitLeftPos; // 0xE0
	private Vector3d _hitRightPos; // 0xF8
	private Vector3d _hitTopPos; // 0x110
	private Vector3d _hitTopNorm; // 0x128
	private double _TimerForOutAI; // 0x140
	private bool _FlagGoToAIFromTimer; // 0x148
	private Vector2 _lastGoToDir; // 0x14C
	private const double SMALL_NUM = 9.999999747378752E-05; // Metadata: 0x00B13CC7
	public const double ANGULAR_VELOCITY_ACCURACY = 0.009999999776482582; // Metadata: 0x00B13CCF
	private const double IGNORE_TOP_HIT_NORM_Y_THRESHOLD = 0.6000000238418579; // Metadata: 0x00B13CD7
	private const double UPPER_ANGLE_DEG_START_FAST_X_ROTATION = 110; // Metadata: 0x00B13CDF
	private const double LOWER_ANGLE_DEG_START_FAST_X_ROTATION = 55; // Metadata: 0x00B13CE7
	private const double UPPER_ANGLE_DEG_START_FAST_Y_ROTATION = 130; // Metadata: 0x00B13CEF
	private const double RING_DETECT_STEP_X = 0.5235987715423107; // Metadata: 0x00B13CF7
	private const double RING_DETECT_STEP_Y = 0.5235987715423107; // Metadata: 0x00B13CFF
	private const double RING_DETECT_POLE_MAX = 3.1415926292538643; // Metadata: 0x00B13D07
	private const double RING_DETECT_UP_MAX = 3.1415926292538643; // Metadata: 0x00B13D0F
	private const double LIMIT_POLE_ANGLE_IN_OPPSITE_DIRECTION = 10; // Metadata: 0x00B13D17
	private const double Y_SPEED_LOWER = 0.699999988079071; // Metadata: 0x00B13D1F
	private const double Y_FACTOR_LOWER = 1; // Metadata: 0x00B13D27
	private const double X_SPEED_LOWER = 0.5; // Metadata: 0x00B13D2F
	private const double X_FACTOR_LOWER = 1; // Metadata: 0x00B13D37
	private const int Y_LOOK_UP_DOWN_MIN_FRAME_COUNT = 15; // Metadata: 0x00B13D3F

	// Properties
	public override CameraModuleType moduleType { /* [XID] */ /* 0x0000000189A0F440-0x0000000189A0F460 */ get => default; } // 0x0000000181B18B80-0x0000000181B18C20 

	// Constructors
	public SCameraModuleFollowRotateParallel() {} // 0x0000000181B1BC50-0x0000000181B1BD90

	// Methods
	// [XID] // 0x0000000189A16B20-0x0000000189A16B40
	public override bool CheckEnable(ref CameraShareData data) => default; // 0x0000000181B18390-0x0000000181B18460
	// [XID] // 0x0000000189A1E0E0-0x0000000189A1E100
	public override void Tick(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181B18E00-0x0000000181B19540
	// [XID] // 0x0000000189A258A0-0x0000000189A258C0
	private bool CheckBackWardDistance(Vector3d Origin, Vector3d Direction) => default; // 0x0000000181B19DD0-0x0000000181B1A060
	// [XID] // 0x0000000189A2CCA0-0x0000000189A2CCC0
	private bool CheckUpwardDistance(Vector3d Origin, Vector3d Direction) => default; // 0x0000000181B199B0-0x0000000181B19C40
	// [XID] // 0x0000000189A34630-0x0000000189A34650
	private void RingCast(Vector3d orgPos, Vector3d refDir, double radiusX, double radiusY, double stepX, double stepY, double LeftMax, double RightMax, double TopMax) {} // 0x0000000181B1A8A0-0x0000000181B1ACC0
	// [XID] // 0x0000000189A3BA30-0x0000000189A3BA50
	private bool SingleRingCast(Vector3d center, Vector3d startDir, Vector3d dir, double Step, double Max, out Vector3d hitPos, out Vector3d hitNorm, bool drawFlag = false /* Metadata: 0x00B13CAE */) {
		hitPos = default;
		hitNorm = default;
		return default;
	} // 0x0000000181B1A0D0-0x0000000181B1A7A0
	// [XID] // 0x0000000189A436A0-0x0000000189A436C0
	private void AdjustElevationDuringClimb(double deltaTime, Vector3d ideal, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181B18460-0x0000000181B188D0
	// [XID] // 0x0000000189A4AB90-0x0000000189A4ABB0
	private void RecalculateUpAngle(Vector3d center, Vector3d idealXZ, double curIdealElevation, ref double candidUpTarget, ref double lerpRatioUp) {} // 0x0000000181B19760-0x0000000181B199B0
	// [XID] // 0x0000000189A521A0-0x0000000189A521C0
	private double GenerateFactorAccordingYawSpeed(double speed) => default; // 0x0000000181B1BB30-0x0000000181B1BC50
	// [XID] // 0x0000000189A59B80-0x0000000189A59BA0
	private double LinearLerpYawAngle(double fromAngle, double toAngle, double lerpRatio, double deltaT, double maxlerpSpeed = 100000 /* Metadata: 0x00B13CAF */) => default; // 0x0000000181B19540-0x0000000181B196C0
	// [XID] // 0x0000000189A61360-0x0000000189A61380
	private void AdjustPoleDuringClimb(double deltaTime, Vector3d ideal, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181B1B340-0x0000000181B1BB30
	// [XID] // 0x0000000189A69210-0x0000000189A69230
	private void RecalculateLeftAndRightTargetAngle(Vector3d center, Vector3d idealXZ, double curIdealPole, ref double candidLeftConst, ref double candidRightConst, ref double candidLeftTarget, ref double candidRightTarget, out double lerpRatioRight, out double lerpRatioLeft) {
		lerpRatioRight = default;
		lerpRatioLeft = default;
	} // 0x0000000181B1AD40-0x0000000181B1B340
	// [XID] // 0x0000000189A705E0-0x0000000189A70600
	private double GenerateFactorAccordingPoleSpeed(double speed) => default; // 0x0000000181B18020-0x0000000181B18140
	// [XID] // 0x0000000189A77E50-0x0000000189A77E70
	private double LinearLerpPoleAngle(double fromAngle, double toAngle, double lerpRatio, double deltaT, double maxlerpSpeed = 100000 /* Metadata: 0x00B13CB7 */) => default; // 0x0000000181B188D0-0x0000000181B18B80
	// [XID] // 0x0000000189A7F450-0x0000000189A7F470
	private bool CheckAngleIsInRange(double angle1, double angle2, double angle, bool isDeg, ref double nearestAngle) => default; // 0x0000000181B18C20-0x0000000181B18E00
	// [XID] // 0x0000000189A871C0-0x0000000189A871E0
	private void LimitPoleAngleInRange(double refAngle, double min, double max, ref double curAngle) {} // 0x0000000181B19C40-0x0000000181B19DD0
	// [XID] // 0x0000000189A8EA00-0x0000000189A8EA20
	private void AutoRecoverDuringClimb(double deltaTime, Vector3d ideal, ref CameraShareData data) {} // 0x0000000181B18140-0x0000000181B18390
	// [XID] // 0x0000000189A95FD0-0x0000000189A95FF0
	private void TryReduceAnchorAngularVelocity(double deltaTime, ref CameraShareData data) {} // 0x0000000181B1A7A0-0x0000000181B1A8A0
	// [XID] // 0x0000000189A9D550-0x0000000189A9D570
	private void ComputeOutputParam(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181B17D70-0x0000000181B18020
}

