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

public class CameraDataAndFlags // TypeDefIndex: 32145
{
	// Fields
	public bool isAllDead; // 0x10
	public bool isDisableProtectGround; // 0x11
	private Dictionary<int, bool> _pipeEnableDic; // 0x18
	public Dictionary<int, bool> pipeEnableDicForDebug; // 0x20
	public Vector3d outCameraPosition; // 0x28
	public Vector3d outCameraForward; // 0x40
	public Vector3d outCameraUp; // 0x58
	public Vector3d cameraPosition; // 0x70
	public Vector3d cameraSpherical; // 0x88
	public Vector3d cameraForward; // 0xA0
	public Vector3d cameraUp; // 0xB8
	public Vector3d refAnchorPosition; // 0xD0
	public Vector3d cameraRecoverSpherical; // 0xE8
	public bool keepShotRotation; // 0x100
	public Vector3d lastCameraPosition; // 0x108
	public Vector3d lastCameraSpherical; // 0x120
	public Vector3d lastCameraForward; // 0x138
	public Vector3d lastCameraUp; // 0x150
	public Vector3d lastRefAnchorPosition; // 0x168
	public Vector3d lastFrameCameraPosition; // 0x180
	public Vector3d lastFrameCameraSpherical; // 0x198
	public Vector3d lastFrameCameraForward; // 0x1B0
	public Vector3d lastFrameCameraUp; // 0x1C8
	public Vector3d lastFrameRefAnchorPosition; // 0x1E0
	public double lastFrameCameraForwardPoleDeltaAngle; // 0x1F8
	public double lastFrameCameraForwardElevDeltaAngle; // 0x200
	public Vector3d lastFrameFilterLookAtPosition; // 0x208
	public Vector3d lastFrameLookAtPosition; // 0x220
	public Vector3d lastFrameTransformLookAtPosition; // 0x238
	public double idealCameraSphZoomRadius; // 0x250
	public double idealCameraSphElevation; // 0x258
	public double idealCameraRadiusAfterZoom; // 0x260
	public Vector3d idleCamPosition; // 0x268
	public Vector3d idleCamForward; // 0x280
	public Vector3d idleCamSpherical; // 0x298
	public Vector3d spCamPosition; // 0x2B0
	public Vector3d spCamForward; // 0x2C8
	public Vector3d spCamUp; // 0x2E0
	public Vector3d spCamSpherical; // 0x2F8
	public double spFov; // 0x310
	public double spDeltaPoleAngle; // 0x318
	public double spDeltaElveAngle; // 0x320
	public double currentManualLocateRatio; // 0x328
	public double currentWarningLocateRatio; // 0x330
	private double _defaultRadiusExtraRatio; // 0x338
	private double _maxRadiusExtraRatio; // 0x340
	private double _maxRadiusNormal; // 0x348
	private double _defaultLocateRatioNormal; // 0x350
	private double _maxRadiusCombat; // 0x358
	public bool usingDefaultLocateRatioCombat; // 0x360
	private double _minCameraRadius; // 0x368
	public double maxRadiusNormalInLerping; // 0x370
	public double maxRadiusCombatInLerping; // 0x378
	public double additionalRadius; // 0x380
	public double globalDefaultElevation; // 0x388
	public double globalMinElevation; // 0x390
	public double globalMaxElevation; // 0x398
	public bool isRotating; // 0x3A0
	public bool isZooming; // 0x3A1
	public bool lastIsRotating; // 0x3A2
	public bool lastIsZooming; // 0x3A3
	public bool isControl; // 0x3A4
	public bool isMuteControl; // 0x3A5
	public bool rotatedDuringCurrentMove; // 0x3A6
	public bool rotatedDuringCurrentIdle; // 0x3A7
	public Vector2d refAnchorAngularVelocity; // 0x3A8
	public double zoomVelocity; // 0x3B8
	public bool isMoving; // 0x3C0
	public bool isFlying; // 0x3C1
	public bool isDropping; // 0x3C2
	public bool isJumping; // 0x3C3
	public bool isBeingHit; // 0x3C4
	public bool isTransfering; // 0x3C5
	public bool lastIsMoving; // 0x3C6
	public bool lastIsFlying; // 0x3C7
	public bool shouldKeepZooming; // 0x3C8
	public bool shouldKeepElevationRotating; // 0x3C9
	public bool isRadiusSqueezing; // 0x3CA
	public bool isKeepElevation; // 0x3CB
	public bool paraKeepYaw; // 0x3CC
	public bool isInBackUpSlope; // 0x3CD
	public bool isInGrass; // 0x3CE
	public bool isSpecifyPoleClockwise; // 0x3CF
	public bool isCounterClockwise; // 0x3D0
	public bool isForcingBackWardFollow; // 0x3D1
	public double cameraForwardPoleDeltaAngle; // 0x3D8
	public double cameraForwardElevDeltaAngle; // 0x3E0
	public bool lastIsLockingOrReCover; // 0x3E8
	public bool isLockingOrRecover; // 0x3E9
	public bool isOnlyRecover; // 0x3EA
	private bool _isInCombatMove; // 0x3EB
	public bool isShootingFocus; // 0x3EC
	public bool isFastShootingFocus; // 0x3ED
	private bool _isNormalShooting; // 0x3EE
	private double _shootingLeftTime; // 0x3F0
	public bool isRecoverFromShooting; // 0x3F8
	private bool _isShootingCooldown; // 0x3F9
	private double _shootingCDLeftTime; // 0x400
	public uint attackTargetRuntimeID; // 0x408
	public Vector3d lockingEnemyPosition; // 0x410
	public double lockingEnemyYHeight; // 0x428
	public bool isHavingAttackTarget; // 0x430
	public double attackingTimer; // 0x438
	public bool isJustAttack; // 0x440
	public bool isAttacking; // 0x441
	public bool isKillingLastEnemy; // 0x442
	public double idealSlope; // 0x448
	public bool lockingUsingCombatMove; // 0x450
	public int lockingEnemyNearbyCount; // 0x454
	public double CameraDefaultHalfFov; // 0x458
	public double CameraHalfFov; // 0x460
	public double CameraAspect; // 0x468
	public double CameraNearClipPlane; // 0x470
	public double CameraFarClipPlane; // 0x478
	public CameraModuleState state; // 0x488
	public CameraModuleState lastFrameState; // 0x48C
	private double _anchorDistance; // 0x490
	public CameraShakeConfig cameraShakeConfig; // 0x498
	public bool isCameraShakeActing; // 0x4A0
	public bool muteCameraShake; // 0x4A1
	public double cameraShakeRatioForHitWall; // 0x4A8
	public Transform cameraTrans; // 0x4B0
	public double? shakeEnenrgy; // 0x4B8
	public Vector3d shakeOffSet; // 0x4C8
	public bool needFastGotoIdealDir; // 0x4E0
	public bool idealClimb2Move; // 0x4E1
	public LogicCamera logicStoryCamera; // 0x4E8
	public StoryCameraState storyState; // 0x4F0
	public StoryCameraLerpPattern storyLerpPatter; // 0x4F4
	public double storyTransitionDuration; // 0x4F8
	public double storyTransitionLerpRatio; // 0x500
	public Vector3d cameraStoryPosition; // 0x508
	public Vector3d cameraStoryForward; // 0x520
	public Vector3d cameraStoryUp; // 0x538
	public Vector3d cameraStoryStartPosition; // 0x550
	public Vector3d cameraStoryStartForward; // 0x568
	public Vector3d cameraStoryStartUp; // 0x580
	private bool _enableProtectDither; // 0x598
	public double storyTransitionTimer; // 0x5A0
	public bool storyDither; // 0x5A8
	public BaseInterAction interAction; // 0x5B0
	public Action onStoryFinish; // 0x5B8
	public double levelTimeScale; // 0x5C0
	public string targetMotionType; // 0x5C8
	public int lastAnimStateInd; // 0x5D0
	public int curAnimStateInd; // 0x5D4
	public bool setFilterAnimStateFlag; // 0x5D8
	public bool forceRecover; // 0x5D9
	public bool forceSrc; // 0x5DA
	public Vector3d forceSrcSph; // 0x5E0
	public Transform lockTarget; // 0x5F8
	public double defaultElevHeightRatio; // 0x600
	public bool forceDitherUpdate; // 0x608

	// Properties
	public double maxRadiusNormal { /* [XID] */ /* 0x00000001899EA190-0x00000001899EA1B0 */ get => default; /* [XID] */ /* 0x00000001899F1C20-0x00000001899F1C40 */ set {} } // 0x0000000181A5FB60-0x0000000181A5FC20 0x0000000181A5F830-0x0000000181A5F8E0
	public double maxRadiusNormalInternal { /* [XID] */ /* 0x00000001899F9400-0x00000001899F9420 */ get => default; } // 0x0000000181A5F780-0x0000000181A5F830 
	public double defaultLocateRatioNormal { /* [XID] */ /* 0x0000000189A006E0-0x0000000189A00700 */ get => default; /* [XID] */ /* 0x0000000189A08020-0x0000000189A08040 */ set {} } // 0x0000000181A5E8E0-0x0000000181A5E9A0 0x0000000181A5F6D0-0x0000000181A5F780
	public double maxRadiusCombat { /* [XID] */ /* 0x0000000189A0F420-0x0000000189A0F440 */ get => default; /* [XID] */ /* 0x0000000189A16B00-0x0000000189A16B20 */ set {} } // 0x0000000181A5F040-0x0000000181A5F100 0x0000000181A5F8E0-0x0000000181A5F990
	public double minCameraRadius { /* [XID] */ /* 0x0000000189A1E0C0-0x0000000189A1E0E0 */ get => default; /* [XID] */ /* 0x0000000189A25880-0x0000000189A258A0 */ set {} } // 0x0000000181A5F330-0x0000000181A5F3F0 0x0000000181A5FD60-0x0000000181A5FE10
	public bool isInCombatMove { /* [XID] */ /* 0x0000000189A2CC80-0x0000000189A2CCA0 */ set {} } // 0x0000000181A5EC20-0x0000000181A5ECD0
	public bool isCombat { /* [XID] */ /* 0x0000000189A4AB70-0x0000000189A4AB90 */ get => default; } // 0x0000000181A5F1C0-0x0000000181A5F280 
	public AvatarCameraData Avatar { /* [XID] */ /* 0x0000000189A59B40-0x0000000189A59B80 */ get; set; } // 0x0000000181A5FE10-0x0000000181A5FE70 0x0000000181A5EF00-0x0000000181A5EF70
	public double anchorDistance { /* [XID] */ /* 0x0000000189A6BEA0-0x0000000189A6BEC0 */ get => default; /* [XID] */ /* 0x0000000189A73560-0x0000000189A73580 */ set {} } // 0x0000000181A5F100-0x0000000181A5F1C0 0x0000000181A5F280-0x0000000181A5F330
	public bool enableProtectDither { /* [XID] */ /* 0x0000000189A7B140-0x0000000189A7B160 */ get => default; } // 0x0000000181A5F3F0-0x0000000181A5F4A0 

	// Constructors
	public CameraDataAndFlags() {} // 0x0000000181A5FF70-0x0000000181A604E0

	// Methods
	// [XID] // 0x00000001899C50E0-0x00000001899C5100
	public void InitExtraParam(PipelineCameraGlobalConfig globalConfig) {} // 0x0000000181A5F990-0x0000000181A5FB60
	// [XID] // 0x00000001899CC7B0-0x00000001899CC7D0
	public void DisableAllPipe() {} // 0x0000000181A5E9A0-0x0000000181A5EC20
	// [XID] // 0x00000001899D3E60-0x00000001899D3E80
	public void EnablePipe(CameraModuleType moduleType) {} // 0x0000000181A5EF70-0x0000000181A5F040
	// [XID] // 0x00000001899DB430-0x00000001899DB450
	public bool IsEnable(CameraModuleType moduleType) => default; // 0x0000000181A5FE70-0x0000000181A5FF70
	// [XID] // 0x00000001899E2B30-0x00000001899E2B50
	public void ToggleDebugEnableDic(CameraModuleType moduleType, bool toggle) {} // 0x0000000181A5F4A0-0x0000000181A5F580
	// [XID] // 0x0000000189A34610-0x0000000189A34630
	public void SetNormalShooting(double leftTime) {} // 0x0000000181A5EE40-0x0000000181A5EF00
	// [XID] // 0x0000000189A3BA10-0x0000000189A3BA30
	public void ClearNormalShooting() {} // 0x0000000181A5ECD0-0x0000000181A5ED80
	// [XID] // 0x0000000189A43680-0x0000000189A436A0
	public void SetShootingCD(double cd) {} // 0x0000000181A5ED80-0x0000000181A5EE40
	// [XID] // 0x0000000189A52180-0x0000000189A521A0
	public void UpdateCombatTimer() {} // 0x0000000181A5FC20-0x0000000181A5FD60
	// [XID] // 0x0000000189A82790-0x0000000189A827B0
	public void SetEnableProtectDither(bool value) {} // 0x0000000181A5F580-0x0000000181A5F6D0
}

