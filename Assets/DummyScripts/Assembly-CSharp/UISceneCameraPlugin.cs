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

public sealed class UISceneCameraPlugin : BaseUIScenePlugin // TypeDefIndex: 28553
{
	// Fields
	private const int CAMERA_EXCHANGE_MOD_NUM = 2; // Metadata: 0x00B0D902
	public const float AVATAR_CAMERA_FOV = 30f; // Metadata: 0x00B0D906
	private Camera _avatarCamera; // 0x18
	private Transform[] _virtualCameraArray; // 0x20
	private Transform[] _lookAtObjectArray; // 0x28
	private uint _moveCameraIndex; // 0x30
	private bool _canMoveCamera; // 0x34
	private CameraDataAndFlags _data; // 0x38
	private PipelineCameraModuleConfig _piplineConfig; // 0x40
	private Vector3 _refAnchorSpherical; // 0x48
	public CameraInputHelperZoom zoomSmoother; // 0x58
	private float _xRatio; // 0x60
	private float _yRatio; // 0x64
	private float _zoomRatio; // 0x68
	private float _minRotAngle; // 0x6C
	private float _zoomScaleMin; // 0x70
	private float _zoomScaleMax; // 0x74
	private float _zoomScaleMinAvtar; // 0x78
	private float _zoomScaleNow; // 0x7C
	private float _zoomDegree; // 0x80
	private bool _enableUpdateCamera; // 0x84
	private bool _enableUpdateZoom; // 0x85
	private bool _enableUpdatePosY; // 0x86
	public Func<Vector3, Vector3> getCameraRotateCenterFunc; // 0x88
	public Func<Vector3, float, Vector3> getCameraFinalPosFunc; // 0x90

	// Properties
	public bool canMoveCamera { /* [XID] */ /* 0x0000000189A96450-0x0000000189A96470 */ get => default; } // 0x0000000181F0CE40-0x0000000181F0CEE0 
	public Camera sceneCamera { /* [XID] */ /* 0x0000000189A9D9A0-0x0000000189A9D9C0 */ get => default; } // 0x0000000181F0DB90-0x0000000181F0DC30 
	public bool enableUpdateCamera { /* [XID] */ /* 0x0000000189AFFD00-0x0000000189AFFD20 */ set {} } // 0x0000000181F0F8C0-0x0000000181F0F970
	public bool enableUpdateZoom { /* [XID] */ /* 0x0000000189B072D0-0x0000000189B072F0 */ set {} } // 0x0000000181F0ED80-0x0000000181F0EE30
	public bool enableUpdatePosY { /* [XID] */ /* 0x0000000189B0EB30-0x0000000189B0EB50 */ set {} } // 0x0000000181F0EE30-0x0000000181F0EEE0
	public PipelineCameraModuleConfig piplineConfig { /* [XID] */ /* 0x0000000189B15E80-0x0000000189B15EA0 */ get => default; } // 0x0000000181F0F420-0x0000000181F0F4C0 
	public CameraDataAndFlags data { /* [XID] */ /* 0x0000000189B1D590-0x0000000189B1D5B0 */ get => default; } // 0x0000000181F0CEE0-0x0000000181F0CF80 

	// Constructors
	public UISceneCameraPlugin() {} // 0x0000000181F0F970-0x0000000181F0FA90

	// Methods
	// [XID] // 0x0000000189AA52B0-0x0000000189AA52D0
	protected override void Init() {} // 0x0000000181F0D890-0x0000000181F0DA80
	// [XID] // 0x0000000189AACA70-0x0000000189AACA90
	protected override void Tick() {} // 0x0000000181F0DA80-0x0000000181F0DB30
	// [XID] // 0x0000000189AB4370-0x0000000189AB4390
	protected override void OnEnable() {} // 0x0000000181F0D510-0x0000000181F0D5C0
	// [XID] // 0x0000000189ABC030-0x0000000189ABC050
	protected override void OnDisable() {} // 0x0000000181F0D0E0-0x0000000181F0D190
	// [XID] // 0x0000000189AC3860-0x0000000189AC3880
	public void MoveVirtualCameraByLocalPos(Vector3 tarLocalPos, Vector3 lookAtLocalPos, float? fov = default, bool canMove = false /* Metadata: 0x00B0D900 */) {} // 0x0000000181F0E980-0x0000000181F0EAE0
	// [XID] // 0x0000000189ACAE30-0x0000000189ACAE50
	public void MoveVirtualCameraByWorldPos(Vector3 tarWorldPos, Vector3 lookAtWorldPos, float? fov = default, bool canMove = false /* Metadata: 0x00B0D901 */) {} // 0x0000000181F0CF80-0x0000000181F0D0E0
	// [XID] // 0x0000000189AD28C0-0x0000000189AD28E0
	private void SetVirtualCameraAndLookPos(Vector3 tarPos, Vector3 lookAtPos, float? fov, bool canMove, bool isLocalPos) {} // 0x0000000181F0DE00-0x0000000181F0E280
	// [XID] // 0x0000000189ADA2F0-0x0000000189ADA310
	public Transform GetCurrentMoveCamera() => default; // 0x0000000181F0D190-0x0000000181F0D260
	// [XID] // 0x0000000189AE1BB0-0x0000000189AE1BD0
	public Transform GetCurrentLookAtObject() => default; // 0x0000000181F0E360-0x0000000181F0E430
	// [XID] // 0x0000000189AE93E0-0x0000000189AE9400
	public Transform GetUnuseLookAtObject() => default; // 0x0000000181F0ECB0-0x0000000181F0ED80
	// [XID] // 0x0000000189AF1170-0x0000000189AF1190
	public void SetVirtualCameraActiveFalse() {} // 0x0000000181F0D760-0x0000000181F0D890
	// [XID] // 0x0000000189AF86D0-0x0000000189AF86F0
	public void EnableSceneCamera(bool visible) {} // 0x0000000181F0EAE0-0x0000000181F0ECB0
	// [XID] // 0x0000000189B24E70-0x0000000189B24E90
	private void SetPipelineConfig() {} // 0x0000000181F0E430-0x0000000181F0E6D0
	// [XID] // 0x0000000189B2C380-0x0000000189B2C3A0
	private bool ComputeRefAnchorDuringRotating() => default; // 0x0000000181F0D2C0-0x0000000181F0D510
	// [XID] // 0x0000000189B33890-0x0000000189B338B0
	public void RotateCamera(float xDeltaDegree, float yDeltaDegree) {} // 0x0000000181F0E790-0x0000000181F0E980
	// [XID] // 0x0000000189B3B170-0x0000000189B3B190
	private float CheckCameraNearGround() => default; // 0x0000000181F0F4C0-0x0000000181F0F6B0
	// [XID] // 0x0000000189B42990-0x0000000189B429B0
	private void UpdateCameraPosAtNow() {} // 0x0000000181F0EEE0-0x0000000181F0F180
	// [XID] // 0x0000000189B4A4D0-0x0000000189B4A4F0
	private void UpdateCamera() {} // 0x0000000181F0D5C0-0x0000000181F0D700
	// [XID] // 0x0000000189B51C70-0x0000000189B51C90
	private void ReduceZoomVelocity() {} // 0x0000000181F0DC30-0x0000000181F0DE00
	// [XID] // 0x0000000189B59490-0x0000000189B594B0
	public void ZoomCamera(float deltaPinch) {} // 0x0000000181F0CD20-0x0000000181F0CDE0
	// [XID] // 0x0000000189B60CE0-0x0000000189B60D00
	private void SetCameraZoom(float deltaPinch) {} // 0x0000000181F0E280-0x0000000181F0E360
	// [XID] // 0x0000000189B683F0-0x0000000189B68410
	private void UpdateCameraZoom() {} // 0x0000000181F0F6B0-0x0000000181F0F8C0
	// [XID] // 0x0000000189B6F710-0x0000000189B6F730
	private void ResetMoveData(Vector3 targetPos) {} // 0x0000000181F0F180-0x0000000181F0F420
	// [XID] // 0x0000000189B76D90-0x0000000189B76DB0
	public void ResetAnchorAngularVelocity() {} // 0x0000000181F0E6D0-0x0000000181F0E790
}

