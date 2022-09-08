/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct SCameraPostData // TypeDefIndex: 32123
{
	// Fields
	public Vector3d outCameraPosition; // 0x00
	public Vector3d outCameraSpherical; // 0x18
	public Vector3d outCameraForward; // 0x30
	public Vector3d outCameraUp; // 0x48
	public Vector3d cameraPosition; // 0x60
	public Vector3d cameraSpherical; // 0x78
	public Vector3d cameraForward; // 0x90
	public Vector3d cameraUp; // 0xA8
	public Vector3d refAnchorPosition; // 0xC0
	public Vector3d lastCameraPosition; // 0xD8
	public Vector3d lastCameraSpherical; // 0xF0
	public Vector3d lastCameraForward; // 0x108
	public Vector3d lastCameraUp; // 0x120
	public Vector3d lastRefAnchorPosition; // 0x138
	public Vector3d lastFrameCameraPosition; // 0x150
	public Vector3d lastFrameCameraSpherical; // 0x168
	public Vector3d lastFrameCameraForward; // 0x180
	public Vector3d lastFrameCameraUp; // 0x198
	public Vector3d lastFrameRefAnchorPosition; // 0x1B0
	public Vector3d lastFrameLookAtPosition; // 0x1C8
	public bool isRadiusSqueezing; // 0x1E0
	public bool isKeepElevation; // 0x1E1
	public bool isRotating; // 0x1E2
	public bool isMoving; // 0x1E3
	public bool isDropping; // 0x1E4
	public double globalMinElevation; // 0x1E8
	public double globalMaxElevation; // 0x1F0
	public CameraModuleState state; // 0x1F8
	public double anchorDistance; // 0x200
	public double CameraNearClipPlane; // 0x208
	public double CameraHalfFov; // 0x210
	public double CameraAspect; // 0x218
	public bool paraKeepYaw; // 0x220
	public bool rotatedDuringCurrentMove; // 0x221
	public double cameraForwardPoleDeltaAngle; // 0x228
	public double cameraForwardElevDeltaAngle; // 0x230
	public double idealCameraSphZoomRadius; // 0x238
	public double idealCameraSphElevation; // 0x240
	public bool isInBackUpSlope; // 0x248
	public bool disableProtect; // 0x249
}

