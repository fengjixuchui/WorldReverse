/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public class CVRCompositor // TypeDefIndex: 6470
	{
		// Fields
		private IVRCompositor FnTable; // 0x10
	
		// Constructors
		public CVRCompositor() {} // Dummy constructor
		internal CVRCompositor(IntPtr pInterface) {} // 0x000000018646A9C0-0x000000018646AB70
	
		// Methods
		public void SetTrackingSpace(ETrackingUniverseOrigin eOrigin) {} // 0x000000018646A530-0x000000018646A5B0
		public ETrackingUniverseOrigin GetTrackingSpace() => default; // 0x0000000186469E90-0x0000000186469F10
		public EVRCompositorError WaitGetPoses(TrackedDevicePose_t[] pRenderPoseArray, TrackedDevicePose_t[] pGamePoseArray) => default; // 0x000000018646A900-0x000000018646A9C0
		public EVRCompositorError GetLastPoses(TrackedDevicePose_t[] pRenderPoseArray, TrackedDevicePose_t[] pGamePoseArray) => default; // 0x0000000186469C90-0x0000000186469D50
		public EVRCompositorError GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose) => default; // 0x0000000186469BF0-0x0000000186469C90
		public EVRCompositorError Submit(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags) => default; // 0x000000018646A730-0x000000018646A7E0
		public void ClearLastSubmittedFrame() {} // 0x0000000186469200-0x0000000186469270
		public void PostPresentHandoff() {} // 0x000000018646A260-0x000000018646A2D0
		public bool GetFrameTiming(ref Compositor_FrameTiming pTiming, uint unFramesAgo) => default; // 0x0000000186469A30-0x0000000186469AD0
		public uint GetFrameTimings(ref Compositor_FrameTiming pTiming, uint nFrames) => default; // 0x0000000186469AD0-0x0000000186469B70
		public float GetFrameTimeRemaining() => default; // 0x00000001864699B0-0x0000000186469A30
		public void GetCumulativeStats(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes) {} // 0x0000000186469780-0x0000000186469810
		public void FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground) {} // 0x0000000186469590-0x0000000186469670
		public HmdColor_t GetCurrentFadeColor(bool bBackground) => default; // 0x0000000186469810-0x00000001864698B0
		public void FadeGrid(float fSeconds, bool bFadeIn) {} // 0x00000001864694F0-0x0000000186469590
		public float GetCurrentGridAlpha() => default; // 0x00000001864698B0-0x0000000186469930
		public EVRCompositorError SetSkyboxOverride(Texture_t[] pTextures) => default; // 0x000000018646A490-0x000000018646A530
		public void ClearSkyboxOverride() {} // 0x0000000186469270-0x00000001864692F0
		public void CompositorBringToFront() {} // 0x00000001864692F0-0x0000000186469370
		public void CompositorGoToBack() {} // 0x00000001864693F0-0x0000000186469470
		public void CompositorQuit() {} // 0x0000000186469470-0x00000001864694F0
		public bool IsFullscreen() => default; // 0x000000018646A0D0-0x000000018646A150
		public uint GetCurrentSceneFocusProcess() => default; // 0x0000000186469930-0x00000001864699B0
		public uint GetLastFrameRenderer() => default; // 0x0000000186469B70-0x0000000186469BF0
		public bool CanRenderScene() => default; // 0x0000000186469180-0x0000000186469200
		public void ShowMirrorWindow() {} // 0x000000018646A630-0x000000018646A6B0
		public void HideMirrorWindow() {} // 0x000000018646A050-0x000000018646A0D0
		public bool IsMirrorWindowVisible() => default; // 0x000000018646A150-0x000000018646A1D0
		public void CompositorDumpImages() {} // 0x0000000186469370-0x00000001864693F0
		public bool ShouldAppRenderWithLowResources() => default; // 0x000000018646A5B0-0x000000018646A630
		public void ForceInterleavedReprojectionOn(bool bOverride) {} // 0x0000000186469670-0x0000000186469700
		public void ForceReconnectProcess() {} // 0x0000000186469700-0x0000000186469780
		public void SuspendRendering(bool bSuspend) {} // 0x000000018646A7E0-0x000000018646A870
		public EVRCompositorError GetMirrorTextureD3D11(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView) => default; // 0x0000000186469D50-0x0000000186469DF0
		public void ReleaseMirrorTextureD3D11(IntPtr pD3D11ShaderResourceView) {} // 0x000000018646A2D0-0x000000018646A360
		public EVRCompositorError GetMirrorTextureGL(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle) => default; // 0x0000000186469DF0-0x0000000186469E90
		public bool ReleaseSharedGLTexture(uint glTextureId, IntPtr glSharedTextureHandle) => default; // 0x000000018646A360-0x000000018646A400
		public void LockGLSharedTextureForAccess(IntPtr glSharedTextureHandle) {} // 0x000000018646A1D0-0x000000018646A260
		public void UnlockGLSharedTextureForAccess(IntPtr glSharedTextureHandle) {} // 0x000000018646A870-0x000000018646A900
		public uint GetVulkanInstanceExtensionsRequired(StringBuilder pchValue, uint unBufferSize) => default; // 0x0000000186469FB0-0x000000018646A050
		public uint GetVulkanDeviceExtensionsRequired(IntPtr pPhysicalDevice, StringBuilder pchValue, uint unBufferSize) => default; // 0x0000000186469F10-0x0000000186469FB0
		public void SetExplicitTimingMode(bool bExplicitTimingMode) {} // 0x000000018646A400-0x000000018646A490
		public EVRCompositorError SubmitExplicitTimingData() => default; // 0x000000018646A6B0-0x000000018646A730
	}
}
