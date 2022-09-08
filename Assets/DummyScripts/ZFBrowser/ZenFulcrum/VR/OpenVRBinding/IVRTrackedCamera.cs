/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public struct IVRTrackedCamera // TypeDefIndex: 6208
	{
		// Fields
		internal _GetCameraErrorNameFromEnum GetCameraErrorNameFromEnum; // 0x00
		internal _HasCamera HasCamera; // 0x08
		internal _GetCameraFrameSize GetCameraFrameSize; // 0x10
		internal _GetCameraIntrinsics GetCameraIntrinsics; // 0x18
		internal _GetCameraProjection GetCameraProjection; // 0x20
		internal _AcquireVideoStreamingService AcquireVideoStreamingService; // 0x28
		internal _ReleaseVideoStreamingService ReleaseVideoStreamingService; // 0x30
		internal _GetVideoStreamFrameBuffer GetVideoStreamFrameBuffer; // 0x38
		internal _GetVideoStreamTextureSize GetVideoStreamTextureSize; // 0x40
		internal _GetVideoStreamTextureD3D11 GetVideoStreamTextureD3D11; // 0x48
		internal _GetVideoStreamTextureGL GetVideoStreamTextureGL; // 0x50
		internal _ReleaseVideoStreamTextureGL ReleaseVideoStreamTextureGL; // 0x58
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate IntPtr _GetCameraErrorNameFromEnum(EVRTrackedCameraError eCameraError); // TypeDefIndex: 6209; 0x0000000188326790-0x0000000188326920
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRTrackedCameraError _HasCamera(uint nDeviceIndex, ref bool pHasCamera); // TypeDefIndex: 6210; 0x0000000188331F10-0x00000001883320D0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRTrackedCameraError _GetCameraFrameSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize); // TypeDefIndex: 6211; 0x0000000188326B80-0x0000000188326E10
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRTrackedCameraError _GetCameraIntrinsics(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter); // TypeDefIndex: 6212; 0x0000000188327040-0x0000000188327280
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRTrackedCameraError _GetCameraProjection(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, float flZNear, float flZFar, ref HmdMatrix44_t pProjection); // TypeDefIndex: 6213; 0x00000001883274C0-0x0000000188327730
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRTrackedCameraError _AcquireVideoStreamingService(uint nDeviceIndex, ref ulong pHandle); // TypeDefIndex: 6214; 0x00000001883248D0-0x0000000188324A90
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRTrackedCameraError _ReleaseVideoStreamingService(ulong hTrackedCamera); // TypeDefIndex: 6215; 0x0000000188335660-0x00000001883357F0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRTrackedCameraError _GetVideoStreamFrameBuffer(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pFrameBuffer, uint nFrameBufferSize, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize); // TypeDefIndex: 6216; 0x0000000188330BA0-0x0000000188330E60
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight); // TypeDefIndex: 6217; 0x0000000188331AA0-0x0000000188331D30
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureD3D11(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize); // TypeDefIndex: 6218; 0x00000001883310A0-0x0000000188331370
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureGL(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize); // TypeDefIndex: 6219; 0x00000001883315C0-0x0000000188331840
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRTrackedCameraError _ReleaseVideoStreamTextureGL(ulong hTrackedCamera, uint glTextureId); // TypeDefIndex: 6220; 0x00000001883352F0-0x00000001883354B0
	}
}
