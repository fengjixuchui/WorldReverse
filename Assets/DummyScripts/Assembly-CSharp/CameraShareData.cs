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

public struct CameraShareData // TypeDefIndex: 32066
{
	// Fields
	public bool isBackground; // 0x00
	public bool isBlending; // 0x01
	public bool disableProtect; // 0x02
	public CameraModuleState state; // 0x04
	public CameraModuleState lastFrameState; // 0x08
	public double anchorDistance; // 0x10
	public double defaultHalfFov; // 0x18
	public double CameraNearClipPlane; // 0x20
	public double CameraHalfFov; // 0x28
	public double CameraAspect; // 0x30
	public Vector3d outCameraPosition; // 0x38
	public Vector3d outCameraSpherical; // 0x50
	public Vector3d outCameraForward; // 0x68
	public Vector3d outCameraUp; // 0x80
	public Vector3d cameraPosition; // 0x98
	public Vector3d cameraSpherical; // 0xB0
	public Vector3d cameraForward; // 0xC8
	public Vector3d cameraUp; // 0xE0
	public Vector3d refAnchorPosition; // 0xF8
	public Vector3d lastCameraPosition; // 0x110
	public Vector3d lastCameraSpherical; // 0x128
	public Vector3d lastCameraForward; // 0x140
	public Vector3d lastCameraUp; // 0x158
	public Vector3d lastRefAnchorPosition; // 0x170
	public Vector3d lastFrameCameraPosition; // 0x188
	public Vector3d lastFrameCameraSpherical; // 0x1A0
	public Vector3d lastFrameCameraForward; // 0x1B8
	public Vector3d lastFrameCameraUp; // 0x1D0
	public Vector3d lastFrameRefAnchorPosition; // 0x1E8
	public double cameraForwardPoleDeltaAngle; // 0x200
	public double cameraForwardElevDeltaAngle; // 0x208
	public double lastFrameCameraForwardPoleDeltaAngle; // 0x210
	public double lastFrameCameraForwardElevDeltaAngle; // 0x218
	public Vector3d lastFrameFilterLookAtPosition; // 0x220
	public Vector3d lastFrameLookAtPosition; // 0x238
	public Vector3d lastFrameTransformLookAtPosition; // 0x250
	public double additionalRadius; // 0x268
	public double globalDefaultCameraLocateRatio; // 0x270
	public double currentManualLocateRatio; // 0x278
	public double currentHeightAdjustRatio; // 0x280
	public double currentWarningLocateRatio; // 0x288
	public double maxRadiusAjustRatio; // 0x290
	private double _defaultRadiusExtraRatio; // 0x298
	private double _maxRadiusExtraRatio; // 0x2A0
	private double _maxRadiusNormal; // 0x2A8
	private double _defaultLocateRatioNormal; // 0x2B0
	private double _maxRadiusCombat; // 0x2B8
	private double _minCameraRadius; // 0x2C0
	public double maxRadiusNormalInLerping; // 0x2C8
	public double maxRadiusCombatInLerping; // 0x2D0
	public double globalDefaultElevation; // 0x2D8
	public double globalMinElevation; // 0x2E0
	public double globalMaxElevation; // 0x2E8
	public bool isAvatarFocusing; // 0x2F0
	public bool isRotating; // 0xFFFFFFF0
	public bool isManuallyRotating; // 0xFFFFFFF0
	public bool isZooming; // 0xFFFFFFF0
	public bool isMoving; // 0xFFFFFFF0
	public bool isFlying; // 0xFFFFFFF0
	public bool isDropping; // 0xFFFFFFF0
	public bool isJumping; // 0xFFFFFFF0
	public bool isBeingHit; // 0xFFFFFFF0
	public bool isTransfering; // 0xFFFFFFF0
	public bool isKeepShotRotation; // 0xFFFFFFF0
	public bool isMovingRotatingVertically; // 0xFFFFFFF0
	public bool lastIsRotating; // 0xFFFFFFF0
	public bool lastIsZooming; // 0xFFFFFFF0
	public bool lastIsMoving; // 0xFFFFFFF0
	public bool lastIsFlying; // 0xFFFFFFF0
	public bool rotatedDuringCurrentMove; // 0xFFFFFFF0
	public bool rotatedDuringCurrentIdle; // 0xFFFFFFF0
	public int lastAnimStateInd; // 0xFFFFFFF0
	public int curAnimStateInd; // 0xFFFFFFF0
	public bool setFilterAnimStateFlag; // 0xFFFFFFF0
	public Vector2 refAnchorAngularVelocity; // 0xFFFFFFF0
	public double zoomVelocity; // 0xFFFFFFF0
	public bool needFastGotoIdealDir; // 0xFFFFFFF0
	public bool idealClimb2Move; // 0xFFFFFFF0
	public bool isSpecifyPoleClockwise; // 0xFFFFFFF0
	public bool isCounterClockwise; // 0xFFFFFFF0
	public int lockingEnemyNearbyCount; // 0xFFFFFFF0
	public double lockingEnemyHeight; // 0xFFFFFFF0
	public bool paraKeepYaw; // 0xFFFFFFF0
	public bool shouldKeepElevationRotating; // 0xFFFFFFF0
	public bool isInBackUpSlope; // 0xFFFFFFF0
	public double idealSlope; // 0xFFFFFFF0
	public bool isKeepElevation; // 0xFFFFFFF0
	public bool shouldKeepZooming; // 0xFFFFFFF0
	public bool isRadiusSqueezing; // 0xFFFFFFF0
	public double idealCameraSphZoomRadius; // 0xFFFFFFF0
	public double idealCameraSphElevation; // 0xFFFFFFF0
	public double radiusBeforeMotion; // 0xFFFFFFF0
	public bool isCombatCamera; // 0xFFFFFFF0
	public bool isInCombat; // 0xFFFFFFF0
	public bool isKeepRotation; // 0xFFFFFFF0
	public double? horizontalRecenteringKeepRotationTriggerTimer; // 0xFFFFFFF0
	public double? verticalRecenteringKeepRotationTriggerTimer; // 0xFFFFFFF0
	public double horizontalRecenteringTriggerTimer; // 0xFFFFFFF0
	public double verticalRecenteringTriggerTimer; // 0xFFFFFFF0
	public bool isCombatPulling; // 0xFFFFFFF0
	public double combatPullingTime; // 0xFFFFFFF0

	// Properties
	public double maxRadiusNormal { /* [XID] */ /* 0x0000000189A50C60-0x0000000189A50C80 */ get => default; /* [XID] */ /* 0x0000000189A581A0-0x0000000189A581C0 */ set {} } // 0x0000000181CE9180-0x0000000181CE9240 0x0000000181CE8E90-0x0000000181CE8F50
	public double maxRadiusNormalInternal { /* [XID] */ /* 0x0000000189A5FCE0-0x0000000189A5FD00 */ get => default; } // 0x0000000181CE8DD0-0x0000000181CE8E90 
	public double defaultLocateRatioNormal { /* [XID] */ /* 0x0000000189A67900-0x0000000189A67920 */ get => default; /* [XID] */ /* 0x0000000189A6ED70-0x0000000189A6ED90 */ set {} } // 0x0000000181CE7F00-0x0000000181CE7FE0 0x0000000181CE8B00-0x0000000181CE8D10
	public double maxRadiusCombat { /* [XID] */ /* 0x0000000189A76520-0x0000000189A76540 */ get => default; /* [XID] */ /* 0x0000000189A7DEA0-0x0000000189A7DEC0 */ set {} } // 0x0000000181CE7FE0-0x0000000181CE80A0 0x0000000181CE8F50-0x0000000181CE90A0
	public double minCameraRadius { /* [XID] */ /* 0x0000000189A85860-0x0000000189A85880 */ get => default; /* [XID] */ /* 0x0000000189A8D0B0-0x0000000189A8D0D0 */ set {} } // 0x0000000181CE81B0-0x0000000181CE82B0 0x0000000181CE9240-0x0000000181CE9270
	public bool isCombat { /* [XID] */ /* 0x0000000189A94650-0x0000000189A94670 */ get => default; } // 0x0000000181CE80A0-0x0000000181CE81B0 
	public RecenteringState horizontalRecenteringState { /* [XID] */ /* 0x0000000189A9BF40-0x0000000189A9BF60 */ get => default; } // 0x0000000181CE8730-0x0000000181CE8810 
	public RecenteringState verticalRecenteringState { /* [XID] */ /* 0x0000000189AA35E0-0x0000000189AA3600 */ get => default; } // 0x0000000181CE88E0-0x0000000181CE8A40 

	// Nested types
	public enum RecenteringState // TypeDefIndex: 32067
	{
		Off = 0,
		On = 1
	}

	// Methods
	// [XID] // 0x0000000189A24140-0x0000000189A24160
	public static CameraShareData Create() => default; // 0x0000000181CE8390-0x0000000181CE8730
	// [XID] // 0x0000000189A2B590-0x0000000189A2B5B0
	public void UpdateByPostData(ref SCameraPostData postData) {} // 0x0000000181CE8D10-0x0000000181CE8DD0
	// [XID] // 0x0000000189A32B50-0x0000000189A32B70
	public void Init() {} // 0x0000000181CE82B0-0x0000000181CE8380
	// [XID] // 0x00000001895FD2B0-0x00000001895FD2D0
	public void InitExtraParam(PipelineCameraGlobalConfig globalConfig) {} // 0x0000000181CE90A0-0x0000000181CE9180
	// [XID] // 0x0000000189A41D70-0x0000000189A41D90
	public void UpdateCurrentManualLocateRatio() {} // 0x0000000181CE8810-0x0000000181CE88E0
	// [XID] // 0x0000000189A49380-0x0000000189A493A0
	public double GetManualLocateRatio() => default; // 0x0000000181CE8A40-0x0000000181CE8B00
	// [XID] // 0x0000000189AAAC30-0x0000000189AAAC50
	public void CombatPull(bool start) {} // 0x0000000181CE8380-0x0000000181CE8390
}

