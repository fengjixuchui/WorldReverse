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

public sealed class SCameraModuleHomeWorld : SCameraModuleBase // TypeDefIndex: 32094
{
	// Fields
	private Vector3d _refAnchorSpherical; // 0x28
	public double _targetAnchorPosX; // 0x40
	public double _targetAnchorPosZ; // 0x48
	public double _targetSphericalY; // 0x50
	public double _totalAnimTime; // 0x58
	private double _curTotalTime; // 0x60
	private double _anchorPosXVelocity; // 0x68
	private double _anchorPosZVelocity; // 0x70
	private double _sphericalYVelocity; // 0x78
	private float _zoomFadeOutAnimTime; // 0x80
	private double _zoomVelocity; // 0x88
	private bool _isZoomFadeOut; // 0x90
	private Vector2d _zoomLimit; // 0x98
	private float _zoomSpeedRatioMin; // 0xA8
	private float _zoomSpeedRatioMax; // 0xAC
	private bool _isRotateFadeOut; // 0xB0
	private float _rotateFadeOutAnimTime; // 0xB4
	private bool _isMoveFadeOut; // 0xB8
	private float _moveFadeOutAnimTime; // 0xBC
	private Vector3d _moveVelocity; // 0xC0

	// Constructors
	public SCameraModuleHomeWorld() {} // 0x0000000183C1F330-0x0000000183C1F3F0

	// Methods
	// [XID] // 0x0000000189AA4D80-0x0000000189AA4DA0
	public override void Init(CameraProfile profile, SCameraBaseState state) {} // 0x0000000183C1E610-0x0000000183C1E6E0
	// [XID] // 0x0000000189AAC560-0x0000000189AAC580
	public override bool CheckEnable(ref CameraShareData data) => default; // 0x0000000183C1DE10-0x0000000183C1DEE0
	// [XID] // 0x000000018979A430-0x000000018979A450
	public void Reset() {} // 0x0000000183C1E180-0x0000000183C1E220
	// [XID] // 0x0000000189ABBB30-0x0000000189ABBB50
	public override void Collect(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x0000000183C1DC30-0x0000000183C1DE10
	// [XID] // 0x0000000189AC32A0-0x0000000189AC32C0
	public override void Tick(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000183C1E6E0-0x0000000183C1E850
	// [XID] // 0x0000000189ACA9A0-0x0000000189ACA9C0
	private void ComputeRefAnchorDuringRotating(double deltaTime, ref CameraShareData data) {} // 0x0000000183C1E2D0-0x0000000183C1E610
	// [XID] // 0x0000000189AD2440-0x0000000189AD2460
	private void ComputeOutputParam(ref CameraShareData data) {} // 0x0000000183C1D730-0x0000000183C1D930
	// [XID] // 0x0000000189AD9E90-0x0000000189AD9EB0
	public void InitParams(ref CameraShareData data) {} // 0x0000000183C1F050-0x0000000183C1F110
	// [XID] // 0x0000000189AE1830-0x0000000189AE1850
	private double SmoothDamp(double current, double target, ref double currentVelocity, double smoothTime, double deltaTime) => default; // 0x0000000183C1E850-0x0000000183C1EA40
	// [XID] // 0x0000000189AE9000-0x0000000189AE9020
	private void ComputeMovingAndRotatingVertically(double deltaTime, ref CameraShareData data) {} // 0x0000000183C1EC60-0x0000000183C1EED0
	// [XID] // 0x0000000189AF0D60-0x0000000189AF0D80
	public void HandleZoom(double velocity, Vector2d zoomLimit, ref CameraShareData data) {} // 0x0000000183C1EAE0-0x0000000183C1EC60
	// [XID] // 0x0000000189AF8290-0x0000000189AF82B0
	private void ComputeZoomFadeOut(double deltaTime, ref CameraShareData data) {} // 0x0000000183C1F190-0x0000000183C1F330
	// [XID] // 0x0000000189AFF940-0x0000000189AFF960
	public void HandleMoveCmd(Vector3d velocity, ref CameraShareData data) {} // 0x0000000183C1D930-0x0000000183C1DBA0
	// [XID] // 0x0000000189B06F30-0x0000000189B06F50
	public void ComputeMoveFadeOut(double deltaTime, ref CameraShareData data) {} // 0x0000000183C1DEE0-0x0000000183C1E180
	// [XID] // 0x0000000189B0E770-0x0000000189B0E790
	public void HandleRotateCmd(double deltaTime, ref CameraShareData data) {} // 0x0000000183C1EED0-0x0000000183C1F050
}

