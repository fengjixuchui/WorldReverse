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
	public class CVRSystem // TypeDefIndex: 6458
	{
		// Fields
		private IVRSystem FnTable; // 0x10
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _PollNextEventPacked(ref VREvent_t_Packed pEvent, uint uncbVREvent); // TypeDefIndex: 6459; 0x00000001864833A0-0x0000000186483560
	
		private struct PollNextEventUnion // TypeDefIndex: 6460
		{
			// Fields
			public IVRSystem._PollNextEvent pPollNextEvent; // 0x00
			public _PollNextEventPacked pPollNextEventPacked; // 0x00
		}
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetControllerStatePacked(uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize); // TypeDefIndex: 6461; 0x000000018647C800-0x000000018647C9D0
	
		private struct GetControllerStateUnion // TypeDefIndex: 6462
		{
			// Fields
			public IVRSystem._GetControllerState pGetControllerState; // 0x00
			public _GetControllerStatePacked pGetControllerStatePacked; // 0x00
		}
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetControllerStateWithPosePacked(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose); // TypeDefIndex: 6463; 0x000000018647CC30-0x000000018647CEB0
	
		private struct GetControllerStateWithPoseUnion // TypeDefIndex: 6464
		{
			// Fields
			public IVRSystem._GetControllerStateWithPose pGetControllerStateWithPose; // 0x00
			public _GetControllerStateWithPosePacked pGetControllerStateWithPosePacked; // 0x00
		}
	
		// Constructors
		public CVRSystem() {} // Dummy constructor
		internal CVRSystem(IntPtr pInterface) {} // 0x0000000186472920-0x0000000186472AD0
	
		// Methods
		public void GetRecommendedRenderTargetSize(ref uint pnWidth, ref uint pnHeight) {} // 0x0000000186471CC0-0x0000000186471D60
		public HmdMatrix44_t GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ) => default; // 0x00000001864719A0-0x0000000186471A90
		public void GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom) {} // 0x0000000186471A90-0x0000000186471B50
		public bool ComputeDistortion(EVREye eEye, float fU, float fV, ref DistortionCoordinates_t pDistortionCoordinates) => default; // 0x0000000186470A70-0x0000000186470B30
		public HmdMatrix34_t GetEyeToHeadTransform(EVREye eEye) => default; // 0x0000000186471580-0x0000000186471630
		public bool GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter) => default; // 0x0000000186471F70-0x0000000186472010
		public int GetD3D9AdapterIndex() => default; // 0x00000001864712F0-0x0000000186471370
		public void GetDXGIOutputInfo(ref int pnAdapterIndex) {} // 0x0000000186471370-0x0000000186471400
		public void GetOutputDevice(ref ulong pnDevice, ETextureType textureType, IntPtr pInstance) {} // 0x0000000186471900-0x00000001864719A0
		public bool IsDisplayOnDesktop() => default; // 0x0000000186472260-0x00000001864722E0
		public bool SetDisplayVisibility(bool bIsVisibleOnDesktop) => default; // 0x00000001864727E0-0x0000000186472870
		public void GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, TrackedDevicePose_t[] pTrackedDevicePoseArray) {} // 0x0000000186471400-0x00000001864714C0
		public void ResetSeatedZeroPose() {} // 0x0000000186472770-0x00000001864727E0
		public HmdMatrix34_t GetSeatedZeroPoseToStandingAbsoluteTrackingPose() => default; // 0x0000000186471D60-0x0000000186471E00
		public HmdMatrix34_t GetRawZeroPoseToStandingAbsoluteTrackingPose() => default; // 0x0000000186471C10-0x0000000186471CC0
		public uint GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass, uint[] punTrackedDeviceIndexArray, uint unRelativeToTrackedDeviceIndex) => default; // 0x0000000186471E00-0x0000000186471EB0
		public EDeviceActivityLevel GetTrackedDeviceActivityLevel(uint unDeviceId) => default; // 0x0000000186472010-0x00000001864720A0
		public void ApplyTransform(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform) {} // 0x0000000186470950-0x00000001864709F0
		public uint GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType) => default; // 0x0000000186472130-0x00000001864721C0
		public ETrackedControllerRole GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex) => default; // 0x0000000186470E00-0x0000000186470E90
		public ETrackedDeviceClass GetTrackedDeviceClass(uint unDeviceIndex) => default; // 0x00000001864720A0-0x0000000186472130
		public bool IsTrackedDeviceConnected(uint unDeviceIndex) => default; // 0x0000000186472360-0x00000001864723F0
		public bool GetBoolTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) => default; // 0x0000000186470BE0-0x0000000186470C80
		public float GetFloatTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) => default; // 0x0000000186471630-0x00000001864716E0
		public int GetInt32TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) => default; // 0x0000000186471790-0x0000000186471830
		public ulong GetUint64TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) => default; // 0x00000001864721C0-0x0000000186472260
		public HmdMatrix34_t GetMatrix34TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) => default; // 0x0000000186471830-0x0000000186471900
		public uint GetStringTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError) => default; // 0x0000000186471EB0-0x0000000186471F70
		public string GetPropErrorNameFromEnum(ETrackedPropertyError error) => default; // 0x0000000186471B50-0x0000000186471C10
		public bool PollNextEvent(ref VREvent_t pEvent, uint uncbVREvent) => default; // 0x0000000186472530-0x00000001864726F0
		public bool PollNextEventWithPose(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose) => default; // 0x0000000186472480-0x0000000186472530
		public string GetEventTypeNameFromEnum(EVREventType eType) => default; // 0x00000001864714C0-0x0000000186471580
		public HiddenAreaMesh_t GetHiddenAreaMesh(EVREye eEye, EHiddenAreaMeshType type) => default; // 0x00000001864716E0-0x0000000186471790
		public bool GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize) => default; // 0x00000001864710E0-0x00000001864712F0
		public bool GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose) => default; // 0x0000000186470E90-0x00000001864710E0
		public void TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, char usDurationMicroSec) {} // 0x0000000186472870-0x0000000186472920
		public string GetButtonIdNameFromEnum(EVRButtonId eButtonId) => default; // 0x0000000186470C80-0x0000000186470D40
		public string GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType) => default; // 0x0000000186470D40-0x0000000186470E00
		public bool CaptureInputFocus() => default; // 0x00000001864709F0-0x0000000186470A70
		public void ReleaseInputFocus() {} // 0x00000001864726F0-0x0000000186472770
		public bool IsInputFocusCapturedByAnotherProcess() => default; // 0x00000001864722E0-0x0000000186472360
		public uint DriverDebugRequest(uint unDeviceIndex, string pchRequest, string pchResponseBuffer, uint unResponseBufferSize) => default; // 0x0000000186470B30-0x0000000186470BE0
		public EVRFirmwareError PerformFirmwareUpdate(uint unDeviceIndex) => default; // 0x00000001864723F0-0x0000000186472480
		public void AcknowledgeQuit_Exiting() {} // 0x0000000186470850-0x00000001864708D0
		public void AcknowledgeQuit_UserPrompt() {} // 0x00000001864708D0-0x0000000186470950
	}
}
