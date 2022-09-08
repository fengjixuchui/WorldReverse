/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public struct IVRCompositor // TypeDefIndex: 6283
	{
		// Fields
		internal _SetTrackingSpace SetTrackingSpace; // 0x00
		internal _GetTrackingSpace GetTrackingSpace; // 0x08
		internal _WaitGetPoses WaitGetPoses; // 0x10
		internal _GetLastPoses GetLastPoses; // 0x18
		internal _GetLastPoseForTrackedDeviceIndex GetLastPoseForTrackedDeviceIndex; // 0x20
		internal _Submit Submit; // 0x28
		internal _ClearLastSubmittedFrame ClearLastSubmittedFrame; // 0x30
		internal _PostPresentHandoff PostPresentHandoff; // 0x38
		internal _GetFrameTiming GetFrameTiming; // 0x40
		internal _GetFrameTimings GetFrameTimings; // 0x48
		internal _GetFrameTimeRemaining GetFrameTimeRemaining; // 0x50
		internal _GetCumulativeStats GetCumulativeStats; // 0x58
		internal _FadeToColor FadeToColor; // 0x60
		internal _GetCurrentFadeColor GetCurrentFadeColor; // 0x68
		internal _FadeGrid FadeGrid; // 0x70
		internal _GetCurrentGridAlpha GetCurrentGridAlpha; // 0x78
		internal _SetSkyboxOverride SetSkyboxOverride; // 0x80
		internal _ClearSkyboxOverride ClearSkyboxOverride; // 0x88
		internal _CompositorBringToFront CompositorBringToFront; // 0x90
		internal _CompositorGoToBack CompositorGoToBack; // 0x98
		internal _CompositorQuit CompositorQuit; // 0xA0
		internal _IsFullscreen IsFullscreen; // 0xA8
		internal _GetCurrentSceneFocusProcess GetCurrentSceneFocusProcess; // 0xB0
		internal _GetLastFrameRenderer GetLastFrameRenderer; // 0xB8
		internal _CanRenderScene CanRenderScene; // 0xC0
		internal _ShowMirrorWindow ShowMirrorWindow; // 0xC8
		internal _HideMirrorWindow HideMirrorWindow; // 0xD0
		internal _IsMirrorWindowVisible IsMirrorWindowVisible; // 0xD8
		internal _CompositorDumpImages CompositorDumpImages; // 0xE0
		internal _ShouldAppRenderWithLowResources ShouldAppRenderWithLowResources; // 0xE8
		internal _ForceInterleavedReprojectionOn ForceInterleavedReprojectionOn; // 0xF0
		internal _ForceReconnectProcess ForceReconnectProcess; // 0xF8
		internal _SuspendRendering SuspendRendering; // 0x100
		internal _GetMirrorTextureD3D11 GetMirrorTextureD3D11; // 0x108
		internal _ReleaseMirrorTextureD3D11 ReleaseMirrorTextureD3D11; // 0x110
		internal _GetMirrorTextureGL GetMirrorTextureGL; // 0x118
		internal _ReleaseSharedGLTexture ReleaseSharedGLTexture; // 0x120
		internal _LockGLSharedTextureForAccess LockGLSharedTextureForAccess; // 0x128
		internal _UnlockGLSharedTextureForAccess UnlockGLSharedTextureForAccess; // 0x130
		internal _GetVulkanInstanceExtensionsRequired GetVulkanInstanceExtensionsRequired; // 0x138
		internal _GetVulkanDeviceExtensionsRequired GetVulkanDeviceExtensionsRequired; // 0x140
		internal _SetExplicitTimingMode SetExplicitTimingMode; // 0x148
		internal _SubmitExplicitTimingData SubmitExplicitTimingData; // 0x150
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _SetTrackingSpace(ETrackingUniverseOrigin eOrigin); // TypeDefIndex: 6284; 0x0000000187C0BDF0-0x0000000187C0BF80
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate ETrackingUniverseOrigin _GetTrackingSpace(); // TypeDefIndex: 6285; 0x0000000187BFFF60-0x0000000187C000D0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRCompositorError _WaitGetPoses([In, Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In, Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount); // TypeDefIndex: 6286; 0x0000000187C0EDA0-0x0000000187C0F0F0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRCompositorError _GetLastPoses([In, Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In, Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount); // TypeDefIndex: 6287; 0x0000000187BF8140-0x0000000187BF8490
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRCompositorError _GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose); // TypeDefIndex: 6288; 0x0000000187BF7D80-0x0000000187BF7F60
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRCompositorError _Submit(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags); // TypeDefIndex: 6289; 0x0000000187C0E340-0x0000000187C0E580
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _ClearLastSubmittedFrame(); // TypeDefIndex: 6290; 0x0000000186475FB0-0x0000000186476110
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _PostPresentHandoff(); // TypeDefIndex: 6291; 0x0000000187C03D60-0x0000000187C03EC0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetFrameTiming(ref Compositor_FrameTiming pTiming, uint unFramesAgo); // TypeDefIndex: 6292; 0x0000000187BF6870-0x0000000187BF6A30
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetFrameTimings(ref Compositor_FrameTiming pTiming, uint nFrames); // TypeDefIndex: 6293; 0x0000000187BF6C10-0x0000000187BF6DD0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate float _GetFrameTimeRemaining(); // TypeDefIndex: 6294; 0x0000000187BF6520-0x0000000187BF6690
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _GetCumulativeStats(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes); // TypeDefIndex: 6295; 0x0000000187BF44D0-0x0000000187BF4690
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground); // TypeDefIndex: 6296; 0x0000000186477CB0-0x0000000186477F60
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate HmdColor_t _GetCurrentFadeColor(bool bBackground); // TypeDefIndex: 6297; 0x0000000187BF4850-0x0000000187BF4A50
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _FadeGrid(float fSeconds, bool bFadeIn); // TypeDefIndex: 6298; 0x00000001864778E0-0x0000000186477AA0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate float _GetCurrentGridAlpha(); // TypeDefIndex: 6299; 0x0000000187BF4C00-0x0000000187BF4D70
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRCompositorError _SetSkyboxOverride([In, Out] Texture_t[] pTextures, uint unTextureCount); // TypeDefIndex: 6300; 0x0000000187C0B9B0-0x0000000187C0BC60
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _ClearSkyboxOverride(); // TypeDefIndex: 6301; 0x0000000186476290-0x00000001864763F0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _CompositorBringToFront(); // TypeDefIndex: 6302; 0x00000001864768B0-0x0000000186476A10
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _CompositorGoToBack(); // TypeDefIndex: 6303; 0x0000000186476E70-0x0000000186476FD0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _CompositorQuit(); // TypeDefIndex: 6304; 0x0000000186477150-0x00000001864772B0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _IsFullscreen(); // TypeDefIndex: 6305; 0x0000000187C02650-0x0000000187C027C0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetCurrentSceneFocusProcess(); // TypeDefIndex: 6306; 0x0000000187BF4F10-0x0000000187BF5080
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetLastFrameRenderer(); // TypeDefIndex: 6307; 0x0000000187BF7A00-0x0000000187BF7B70
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _CanRenderScene(); // TypeDefIndex: 6308; 0x00000001864758B0-0x0000000186475A20
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _ShowMirrorWindow(); // TypeDefIndex: 6309; 0x0000000187C0D960-0x0000000187C0DAC0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _HideMirrorWindow(); // TypeDefIndex: 6310; 0x0000000187C019C0-0x0000000187C01B20
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _IsMirrorWindowVisible(); // TypeDefIndex: 6311; 0x0000000187C02CA0-0x0000000187C02E10
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _CompositorDumpImages(); // TypeDefIndex: 6312; 0x0000000186476B90-0x0000000186476CF0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _ShouldAppRenderWithLowResources(); // TypeDefIndex: 6313; 0x0000000187C0C120-0x0000000187C0C290
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _ForceInterleavedReprojectionOn(bool bOverride); // TypeDefIndex: 6314; 0x0000000187BF1C30-0x0000000187BF1DC0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _ForceReconnectProcess(); // TypeDefIndex: 6315; 0x0000000187BF1F40-0x0000000187BF20A0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _SuspendRendering(bool bSuspend); // TypeDefIndex: 6316; 0x0000000187C0E710-0x0000000187C0E8A0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRCompositorError _GetMirrorTextureD3D11(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView); // TypeDefIndex: 6317; 0x0000000187BF8690-0x0000000187BF8870
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _ReleaseMirrorTextureD3D11(IntPtr pD3D11ShaderResourceView); // TypeDefIndex: 6318; 0x0000000187C04050-0x0000000187C041E0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRCompositorError _GetMirrorTextureGL(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle); // TypeDefIndex: 6319; 0x0000000187BF8A70-0x0000000187BF8C50
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _ReleaseSharedGLTexture(uint glTextureId, IntPtr glSharedTextureHandle); // TypeDefIndex: 6320; 0x0000000187C04740-0x0000000187C04900
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _LockGLSharedTextureForAccess(IntPtr glSharedTextureHandle); // TypeDefIndex: 6321; 0x0000000187C032E0-0x0000000187C03470
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _UnlockGLSharedTextureForAccess(IntPtr glSharedTextureHandle); // TypeDefIndex: 6322; 0x0000000187C0EA30-0x0000000187C0EBC0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetVulkanInstanceExtensionsRequired(StringBuilder pchValue, uint unBufferSize); // TypeDefIndex: 6323; 0x0000000187C00AB0-0x0000000187C00D60
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetVulkanDeviceExtensionsRequired(IntPtr pPhysicalDevice, StringBuilder pchValue, uint unBufferSize); // TypeDefIndex: 6324; 0x0000000187C00710-0x0000000187C008F0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _SetExplicitTimingMode(bool bExplicitTimingMode); // TypeDefIndex: 6325; 0x0000000187C05160-0x0000000187C052F0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRCompositorError _SubmitExplicitTimingData(); // TypeDefIndex: 6326; 0x0000000187C0DFA0-0x0000000187C0E110
	}
}
