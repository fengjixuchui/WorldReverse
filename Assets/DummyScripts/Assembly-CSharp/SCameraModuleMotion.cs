/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SCameraModuleMotion : SCameraModuleBase // TypeDefIndex: 32098
{
	// Fields
	private double _cameraElevationVelocity; // 0x28
	private double _cameraRadiusVelocity; // 0x30
	private double _currentRadiusSpringKd; // 0x38
	private double _lastFrameCameraToCurrentAvatarDistance; // 0x40
	private const double ELEVATION_SPRING_OVER_SHOOT_THRESHOLD = 0.0017453292644818014; // Metadata: 0x00B13E4F
	private const double CAM_AND_WALL_ANGLE_THRESHOLD_FOR_SPECIFY_CLOCKINGWISE = 120; // Metadata: 0x00B13E57
	private const double ANGULAR_ACCURACY = 0.0010000000474974513; // Metadata: 0x00B13E5F
	private const double DISTANCE_ACCURACY = 0.0010000000474974513; // Metadata: 0x00B13E67
	private Vector3d _logicCameraSpherical; // 0x48
	private double _cameraRadiusSpringRatio; // 0x60

	// Properties
	public override CameraModuleType moduleType { /* [XID] */ /* 0x0000000189730900-0x0000000189730920 */ get => default; } // 0x000000018408B3D0-0x000000018408B470 

	// Constructors
	public SCameraModuleMotion() {} // 0x000000018408CE50-0x000000018408CEC0

	// Methods
	// [XID] // 0x0000000189738290-0x00000001897382B0
	public override void Init(CameraProfile profile, SCameraBaseState state) {} // 0x000000018408BE10-0x000000018408BF50
	// [XID] // 0x000000018973FFA0-0x000000018973FFC0
	public override void Collect(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x000000018408B0F0-0x000000018408B220
	// [XID] // 0x0000000189747400-0x0000000189747420
	public override void Tick(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018408BF50-0x000000018408C0B0
	// [XID] // 0x000000018974EB70-0x000000018974EB90
	private void CheckLogicCameraPosition(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018408C850-0x000000018408CA60
	// [XID] // 0x0000000189756200-0x0000000189756220
	private void ProcessPoleAngleMotion(double deltaTime, ref CameraShareData data) {} // 0x000000018408C240-0x000000018408C540
	// [XID] // 0x000000018975D5A0-0x000000018975D5C0
	private void ProcessElevAngleMotion(double deltaTime, ref CameraShareData data) {} // 0x000000018408C540-0x000000018408C7E0
	// [XID] // 0x0000000189764C10-0x0000000189764C30
	private void ProcessRadiusMotion(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018408B470-0x000000018408B700
	// [XID] // 0x000000018976C660-0x000000018976C680
	private void ProtectCameraRadius(ref CameraShareData data) {} // 0x000000018408C150-0x000000018408C240
	// [XID] // 0x0000000189773B90-0x0000000189773BB0
	private void ComputeOutputParam(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018408ABD0-0x000000018408B060
	// [XID] // 0x000000018977B1F0-0x000000018977B210
	private double LinearLerpPoleAngleAttenuationMaxSpeedAndClockWise(double fromAngle, double toAngle, double lerpRatio, double deltaT, double ThresholdAngle, double minAttenuationRatio, bool usingClockwise, bool isCounterClockwise, double thresholdForUsingClockwise, double maxlerpSpeed = 100000 /* Metadata: 0x00B13E3F */) => default; // 0x000000018408B910-0x000000018408BE10
	// [XID] // 0x0000000189782D30-0x0000000189782D50
	private double LinearLerpPoleAngleAttenuationNormalLerp(double fromAngle, double toAngle, double lerpRatio, double deltaT, double ThresholdAngle, double minAttenuationRatio = 0.10000000149011612 /* Metadata: 0x00B13E47 */) => default; // 0x000000018408CC10-0x000000018408CE50
	// [XID] // 0x000000018978A250-0x000000018978A270
	private double LinearLerpPoleAngle(double fromAngle, double toAngle, double lerpRatio, double deltaT) => default; // 0x000000018408B220-0x000000018408B3D0
	// [XID] // 0x0000000189791A70-0x0000000189791A90
	private double PreventSpringOverShoot(double fromX, double toX, double curX, double threshold, ref double velocity) => default; // 0x000000018408B7B0-0x000000018408B910
	// [XID] // 0x0000000189799070-0x0000000189799090
	private void AdjustRadiusSpringKdForStatus(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x000000018408CA60-0x000000018408CC10
}

