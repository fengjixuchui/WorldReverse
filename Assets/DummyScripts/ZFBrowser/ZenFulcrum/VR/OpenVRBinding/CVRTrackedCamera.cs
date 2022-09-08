/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public class CVRTrackedCamera // TypeDefIndex: 6466
	{
		// Fields
		private IVRTrackedCamera FnTable; // 0x10
	
		// Constructors
		public CVRTrackedCamera() {} // Dummy constructor
		internal CVRTrackedCamera(IntPtr pInterface) {} // 0x0000000186473350-0x0000000186475000
	
		// Methods
		public string GetCameraErrorNameFromEnum(EVRTrackedCameraError eCameraError) => default; // 0x0000000186472B70-0x0000000186472C20
		public EVRTrackedCameraError HasCamera(uint nDeviceIndex, ref bool pHasCamera) => default; // 0x0000000186473180-0x0000000186473220
		public EVRTrackedCameraError GetCameraFrameSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize) => default; // 0x0000000186472C20-0x0000000186472CE0
		public EVRTrackedCameraError GetCameraIntrinsics(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter) => default; // 0x0000000186472CE0-0x0000000186472D90
		public EVRTrackedCameraError GetCameraProjection(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, float flZNear, float flZFar, ref HmdMatrix44_t pProjection) => default; // 0x0000000186472D90-0x0000000186472E60
		public EVRTrackedCameraError AcquireVideoStreamingService(uint nDeviceIndex, ref ulong pHandle) => default; // 0x0000000186472AD0-0x0000000186472B70
		public EVRTrackedCameraError ReleaseVideoStreamingService(ulong hTrackedCamera) => default; // 0x00000001864732C0-0x0000000186473350
		public EVRTrackedCameraError GetVideoStreamFrameBuffer(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pFrameBuffer, uint nFrameBufferSize, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize) => default; // 0x0000000186472E60-0x0000000186472F30
		public EVRTrackedCameraError GetVideoStreamTextureSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight) => default; // 0x00000001864730C0-0x0000000186473180
		public EVRTrackedCameraError GetVideoStreamTextureD3D11(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize) => default; // 0x0000000186472F30-0x0000000186473000
		public EVRTrackedCameraError GetVideoStreamTextureGL(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize) => default; // 0x0000000186473000-0x00000001864730C0
		public EVRTrackedCameraError ReleaseVideoStreamTextureGL(ulong hTrackedCamera, uint glTextureId) => default; // 0x0000000186473220-0x00000001864732C0
	}
}
