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
	public struct IVRSystem // TypeDefIndex: 6158
	{
		// Fields
		internal _GetRecommendedRenderTargetSize GetRecommendedRenderTargetSize; // 0x00
		internal _GetProjectionMatrix GetProjectionMatrix; // 0x08
		internal _GetProjectionRaw GetProjectionRaw; // 0x10
		internal _ComputeDistortion ComputeDistortion; // 0x18
		internal _GetEyeToHeadTransform GetEyeToHeadTransform; // 0x20
		internal _GetTimeSinceLastVsync GetTimeSinceLastVsync; // 0x28
		internal _GetD3D9AdapterIndex GetD3D9AdapterIndex; // 0x30
		internal _GetDXGIOutputInfo GetDXGIOutputInfo; // 0x38
		internal _GetOutputDevice GetOutputDevice; // 0x40
		internal _IsDisplayOnDesktop IsDisplayOnDesktop; // 0x48
		internal _SetDisplayVisibility SetDisplayVisibility; // 0x50
		internal _GetDeviceToAbsoluteTrackingPose GetDeviceToAbsoluteTrackingPose; // 0x58
		internal _ResetSeatedZeroPose ResetSeatedZeroPose; // 0x60
		internal _GetSeatedZeroPoseToStandingAbsoluteTrackingPose GetSeatedZeroPoseToStandingAbsoluteTrackingPose; // 0x68
		internal _GetRawZeroPoseToStandingAbsoluteTrackingPose GetRawZeroPoseToStandingAbsoluteTrackingPose; // 0x70
		internal _GetSortedTrackedDeviceIndicesOfClass GetSortedTrackedDeviceIndicesOfClass; // 0x78
		internal _GetTrackedDeviceActivityLevel GetTrackedDeviceActivityLevel; // 0x80
		internal _ApplyTransform ApplyTransform; // 0x88
		internal _GetTrackedDeviceIndexForControllerRole GetTrackedDeviceIndexForControllerRole; // 0x90
		internal _GetControllerRoleForTrackedDeviceIndex GetControllerRoleForTrackedDeviceIndex; // 0x98
		internal _GetTrackedDeviceClass GetTrackedDeviceClass; // 0xA0
		internal _IsTrackedDeviceConnected IsTrackedDeviceConnected; // 0xA8
		internal _GetBoolTrackedDeviceProperty GetBoolTrackedDeviceProperty; // 0xB0
		internal _GetFloatTrackedDeviceProperty GetFloatTrackedDeviceProperty; // 0xB8
		internal _GetInt32TrackedDeviceProperty GetInt32TrackedDeviceProperty; // 0xC0
		internal _GetUint64TrackedDeviceProperty GetUint64TrackedDeviceProperty; // 0xC8
		internal _GetMatrix34TrackedDeviceProperty GetMatrix34TrackedDeviceProperty; // 0xD0
		internal _GetStringTrackedDeviceProperty GetStringTrackedDeviceProperty; // 0xD8
		internal _GetPropErrorNameFromEnum GetPropErrorNameFromEnum; // 0xE0
		internal _PollNextEvent PollNextEvent; // 0xE8
		internal _PollNextEventWithPose PollNextEventWithPose; // 0xF0
		internal _GetEventTypeNameFromEnum GetEventTypeNameFromEnum; // 0xF8
		internal _GetHiddenAreaMesh GetHiddenAreaMesh; // 0x100
		internal _GetControllerState GetControllerState; // 0x108
		internal _GetControllerStateWithPose GetControllerStateWithPose; // 0x110
		internal _TriggerHapticPulse TriggerHapticPulse; // 0x118
		internal _GetButtonIdNameFromEnum GetButtonIdNameFromEnum; // 0x120
		internal _GetControllerAxisTypeNameFromEnum GetControllerAxisTypeNameFromEnum; // 0x128
		internal _CaptureInputFocus CaptureInputFocus; // 0x130
		internal _ReleaseInputFocus ReleaseInputFocus; // 0x138
		internal _IsInputFocusCapturedByAnotherProcess IsInputFocusCapturedByAnotherProcess; // 0x140
		internal _DriverDebugRequest DriverDebugRequest; // 0x148
		internal _PerformFirmwareUpdate PerformFirmwareUpdate; // 0x150
		internal _AcknowledgeQuit_Exiting AcknowledgeQuit_Exiting; // 0x158
		internal _AcknowledgeQuit_UserPrompt AcknowledgeQuit_UserPrompt; // 0x160
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _GetRecommendedRenderTargetSize(ref uint pnWidth, ref uint pnHeight); // TypeDefIndex: 6159; 0x000000018832C870-0x000000018832CA30
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate HmdMatrix44_t _GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ); // TypeDefIndex: 6160; 0x000000018832B830-0x000000018832BAB0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom); // TypeDefIndex: 6161; 0x000000018832BD00-0x000000018832BF90
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _ComputeDistortion(EVREye eEye, float fU, float fV, ref DistortionCoordinates_t pDistortionCoordinates); // TypeDefIndex: 6162; 0x00000001883253B0-0x00000001883255D0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate HmdMatrix34_t _GetEyeToHeadTransform(EVREye eEye); // TypeDefIndex: 6163; 0x00000001883295D0-0x00000001883297E0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter); // TypeDefIndex: 6164; 0x000000018832FA10-0x000000018832FBD0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate int _GetD3D9AdapterIndex(); // TypeDefIndex: 6165; 0x0000000188328800-0x0000000188328970
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex); // TypeDefIndex: 6166; 0x0000000188328B30-0x0000000188328CC0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _GetOutputDevice(ref ulong pnDevice, ETextureType textureType, IntPtr pInstance); // TypeDefIndex: 6167; 0x000000018832B430-0x000000018832B610
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _IsDisplayOnDesktop(); // TypeDefIndex: 6168; 0x00000001883326E0-0x0000000188332850
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _SetDisplayVisibility(bool bIsVisibleOnDesktop); // TypeDefIndex: 6169; 0x0000000188337390-0x0000000188337530
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, [In, Out] TrackedDevicePose_t[] pTrackedDevicePoseArray, uint unTrackedDevicePoseArrayCount); // TypeDefIndex: 6170; 0x0000000188328EA0-0x00000001883290C0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _ResetSeatedZeroPose(); // TypeDefIndex: 6171; 0x0000000188336B40-0x0000000188336CA0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate HmdMatrix34_t _GetSeatedZeroPoseToStandingAbsoluteTrackingPose(); // TypeDefIndex: 6172; 0x000000018832E400-0x000000018832E5F0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate HmdMatrix34_t _GetRawZeroPoseToStandingAbsoluteTrackingPose(); // TypeDefIndex: 6173; 0x000000018832C490-0x000000018832C680
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass, [In, Out] uint[] punTrackedDeviceIndexArray, uint unTrackedDeviceIndexArrayCount, uint unRelativeToTrackedDeviceIndex); // TypeDefIndex: 6174; 0x000000018832EB30-0x000000018832ED70
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EDeviceActivityLevel _GetTrackedDeviceActivityLevel(uint unDeviceId); // TypeDefIndex: 6175; 0x000000018832FD80-0x000000018832FF10
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _ApplyTransform(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform); // TypeDefIndex: 6176; 0x0000000188324CA0-0x0000000188324E80
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType); // TypeDefIndex: 6177; 0x0000000188330400-0x0000000188330590
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate ETrackedControllerRole _GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex); // TypeDefIndex: 6178; 0x0000000188327C20-0x0000000188327DB0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate ETrackedDeviceClass _GetTrackedDeviceClass(uint unDeviceIndex); // TypeDefIndex: 6179; 0x00000001883300C0-0x0000000188330250
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _IsTrackedDeviceConnected(uint unDeviceIndex); // TypeDefIndex: 6180; 0x0000000188332D10-0x0000000188332EA0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetBoolTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // TypeDefIndex: 6181; 0x0000000188325C00-0x0000000188325DE0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate float _GetFloatTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // TypeDefIndex: 6182; 0x00000001883299F0-0x0000000188329BE0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate int _GetInt32TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // TypeDefIndex: 6183; 0x000000018832A700-0x000000018832A8E0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate ulong _GetUint64TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // TypeDefIndex: 6184; 0x0000000188330790-0x0000000188330970
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate HmdMatrix34_t _GetMatrix34TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // TypeDefIndex: 6185; 0x000000018832AFC0-0x000000018832B240
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetStringTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError); // TypeDefIndex: 6186; 0x000000018832EFA0-0x000000018832F220
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate IntPtr _GetPropErrorNameFromEnum(ETrackedPropertyError error); // TypeDefIndex: 6187; 0x000000018832C140-0x000000018832C2D0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _PollNextEvent(ref VREvent_t pEvent, uint uncbVREvent); // TypeDefIndex: 6188; 0x0000000188334C80-0x0000000188334E40
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _PollNextEventWithPose(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose); // TypeDefIndex: 6189; 0x0000000188334860-0x0000000188334AA0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate IntPtr _GetEventTypeNameFromEnum(EVREventType eType); // TypeDefIndex: 6190; 0x0000000188329270-0x0000000188329400
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate HiddenAreaMesh_t _GetHiddenAreaMesh(EVREye eEye, EHiddenAreaMeshType type); // TypeDefIndex: 6191; 0x000000018832A2B0-0x000000018832A500
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize); // TypeDefIndex: 6192; 0x0000000188328490-0x0000000188328660
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose); // TypeDefIndex: 6193; 0x0000000188328010-0x0000000188328290
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, char usDurationMicroSec); // TypeDefIndex: 6194; 0x0000000188339240-0x0000000188339420
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate IntPtr _GetButtonIdNameFromEnum(EVRButtonId eButtonId); // TypeDefIndex: 6195; 0x0000000188326450-0x00000001883265E0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate IntPtr _GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType); // TypeDefIndex: 6196; 0x00000001883278E0-0x0000000188327A70
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _CaptureInputFocus(); // TypeDefIndex: 6197; 0x0000000188325020-0x0000000188325190
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _ReleaseInputFocus(); // TypeDefIndex: 6198; 0x0000000188334FC0-0x0000000188335120
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _IsInputFocusCapturedByAnotherProcess(); // TypeDefIndex: 6199; 0x00000001883329F0-0x0000000188332B60
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _DriverDebugRequest(uint unDeviceIndex, string pchRequest, string pchResponseBuffer, uint unResponseBufferSize); // TypeDefIndex: 6200; 0x00000001883257C0-0x0000000188325A00
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRFirmwareError _PerformFirmwareUpdate(uint unDeviceIndex); // TypeDefIndex: 6201; 0x0000000188334490-0x0000000188334620
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _AcknowledgeQuit_Exiting(); // TypeDefIndex: 6202; 0x00000001883242B0-0x0000000188324410
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _AcknowledgeQuit_UserPrompt(); // TypeDefIndex: 6203; 0x0000000188324590-0x00000001883246F0
	}
}
