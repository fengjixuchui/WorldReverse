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
	public class CVROverlay // TypeDefIndex: 6471
	{
		// Fields
		private IVROverlay FnTable; // 0x10
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _PollNextOverlayEventPacked(ulong ulOverlayHandle, ref VREvent_t_Packed pEvent, uint uncbVREvent); // TypeDefIndex: 6472; 0x0000000186483760-0x0000000186483940
	
		private struct PollNextOverlayEventUnion // TypeDefIndex: 6473
		{
			// Fields
			public IVROverlay._PollNextOverlayEvent pPollNextOverlayEvent; // 0x00
			public _PollNextOverlayEventPacked pPollNextOverlayEventPacked; // 0x00
		}
	
		// Constructors
		public CVROverlay() {} // Dummy constructor
		internal CVROverlay(IntPtr pInterface) {} // 0x000000018646E7E0-0x000000018646E950
	
		// Methods
		public EVROverlayError FindOverlay(string pchOverlayKey, ref ulong pOverlayHandle) => default; // 0x000000018646B6F0-0x000000018646B790
		public EVROverlayError CreateOverlay(string pchOverlayKey, string pchOverlayName, ref ulong pOverlayHandle) => default; // 0x000000018646B5C0-0x000000018646B660
		public EVROverlayError DestroyOverlay(ulong ulOverlayHandle) => default; // 0x000000018646B660-0x000000018646B6F0
		public EVROverlayError SetHighQualityOverlay(ulong ulOverlayHandle) => default; // 0x000000018646D3A0-0x000000018646D430
		public ulong GetHighQualityOverlay() => default; // 0x000000018646B8B0-0x000000018646B930
		public uint GetOverlayKey(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError) => default; // 0x000000018646BF10-0x000000018646BFC0
		public uint GetOverlayName(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError) => default; // 0x000000018646C060-0x000000018646C110
		public EVROverlayError SetOverlayName(ulong ulOverlayHandle, string pchName) => default; // 0x000000018646DAA0-0x000000018646DB40
		public EVROverlayError GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight) => default; // 0x000000018646BDB0-0x000000018646BE70
		public string GetOverlayErrorNameFromEnum(EVROverlayError error) => default; // 0x000000018646BBC0-0x000000018646BC70
		public EVROverlayError SetOverlayRenderingPid(ulong ulOverlayHandle, uint unPID) => default; // 0x000000018646DD40-0x000000018646DDE0
		public uint GetOverlayRenderingPid(ulong ulOverlayHandle) => default; // 0x000000018646C1D0-0x000000018646C260
		public EVROverlayError SetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled) => default; // 0x000000018646D770-0x000000018646D810
		public EVROverlayError GetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled) => default; // 0x000000018646BC70-0x000000018646BD10
		public EVROverlayError SetOverlayColor(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue) => default; // 0x000000018646D6B0-0x000000018646D770
		public EVROverlayError GetOverlayColor(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue) => default; // 0x000000018646BB10-0x000000018646BBC0
		public EVROverlayError SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha) => default; // 0x000000018646D560-0x000000018646D600
		public EVROverlayError GetOverlayAlpha(ulong ulOverlayHandle, ref float pfAlpha) => default; // 0x000000018646B9D0-0x000000018646BA70
		public EVROverlayError SetOverlayTexelAspect(ulong ulOverlayHandle, float fTexelAspect) => default; // 0x000000018646DE80-0x000000018646DF20
		public EVROverlayError GetOverlayTexelAspect(ulong ulOverlayHandle, ref float pfTexelAspect) => default; // 0x000000018646C300-0x000000018646C3A0
		public EVROverlayError SetOverlaySortOrder(ulong ulOverlayHandle, uint unSortOrder) => default; // 0x000000018646DDE0-0x000000018646DE80
		public EVROverlayError GetOverlaySortOrder(ulong ulOverlayHandle, ref uint punSortOrder) => default; // 0x000000018646C260-0x000000018646C300
		public EVROverlayError SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters) => default; // 0x000000018646E380-0x000000018646E420
		public EVROverlayError GetOverlayWidthInMeters(ulong ulOverlayHandle, ref float pfWidthInMeters) => default; // 0x000000018646C9B0-0x000000018646CA50
		public EVROverlayError SetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, float fMinDistanceInMeters, float fMaxDistanceInMeters) => default; // 0x000000018646D600-0x000000018646D6B0
		public EVROverlayError GetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, ref float pfMinDistanceInMeters, ref float pfMaxDistanceInMeters) => default; // 0x000000018646BA70-0x000000018646BB10
		public EVROverlayError SetOverlayTextureColorSpace(ulong ulOverlayHandle, EColorSpace eTextureColorSpace) => default; // 0x000000018646DFC0-0x000000018646E060
		public EVROverlayError GetOverlayTextureColorSpace(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace) => default; // 0x000000018646C440-0x000000018646C4E0
		public EVROverlayError SetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds) => default; // 0x000000018646DF20-0x000000018646DFC0
		public EVROverlayError GetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds) => default; // 0x000000018646C3A0-0x000000018646C440
		public uint GetOverlayRenderModel(ulong ulOverlayHandle, string pchValue, uint unBufferSize, ref HmdColor_t pColor, ref EVROverlayError pError) => default; // 0x000000018646C110-0x000000018646C1D0
		public EVROverlayError SetOverlayRenderModel(ulong ulOverlayHandle, string pchRenderModel, ref HmdColor_t pColor) => default; // 0x000000018646DCA0-0x000000018646DD40
		public EVROverlayError GetOverlayTransformType(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType) => default; // 0x000000018646C910-0x000000018646C9B0
		public EVROverlayError SetOverlayTransformAbsolute(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform) => default; // 0x000000018646E100-0x000000018646E1A0
		public EVROverlayError GetOverlayTransformAbsolute(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform) => default; // 0x000000018646C680-0x000000018646C720
		public EVROverlayError SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform) => default; // 0x000000018646E2E0-0x000000018646E380
		public EVROverlayError GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform) => default; // 0x000000018646C870-0x000000018646C910
		public EVROverlayError SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, uint unDeviceIndex, string pchComponentName) => default; // 0x000000018646E240-0x000000018646E2E0
		public EVROverlayError GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, string pchComponentName, uint unComponentNameSize) => default; // 0x000000018646C7C0-0x000000018646C870
		public EVROverlayError GetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ref ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform) => default; // 0x000000018646C720-0x000000018646C7C0
		public EVROverlayError SetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform) => default; // 0x000000018646E1A0-0x000000018646E240
		public EVROverlayError ShowOverlay(ulong ulOverlayHandle) => default; // 0x000000018646E750-0x000000018646E7E0
		public EVROverlayError HideOverlay(ulong ulOverlayHandle) => default; // 0x000000018646CCA0-0x000000018646CD30
		public bool IsOverlayVisible(ulong ulOverlayHandle) => default; // 0x000000018646CED0-0x000000018646CF60
		public EVROverlayError GetTransformForOverlayCoordinates(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform) => default; // 0x000000018646CAD0-0x000000018646CB80
		public bool PollNextOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent) => default; // 0x000000018646D000-0x000000018646D1D0
		public EVROverlayError GetOverlayInputMethod(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod) => default; // 0x000000018646BE70-0x000000018646BF10
		public EVROverlayError SetOverlayInputMethod(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod) => default; // 0x000000018646D8B0-0x000000018646D950
		public EVROverlayError GetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale) => default; // 0x000000018646BFC0-0x000000018646C060
		public EVROverlayError SetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale) => default; // 0x000000018646DA00-0x000000018646DAA0
		public bool ComputeOverlayIntersection(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults) => default; // 0x000000018646B470-0x000000018646B510
		public bool HandleControllerOverlayInteractionAsMouse(ulong ulOverlayHandle, uint unControllerDeviceIndex) => default; // 0x000000018646CB80-0x000000018646CC20
		public bool IsHoverTargetOverlay(ulong ulOverlayHandle) => default; // 0x000000018646CE40-0x000000018646CED0
		public ulong GetGamepadFocusOverlay() => default; // 0x000000018646B830-0x000000018646B8B0
		public EVROverlayError SetGamepadFocusOverlay(ulong ulNewFocusOverlay) => default; // 0x000000018646D310-0x000000018646D3A0
		public EVROverlayError SetOverlayNeighbor(EOverlayDirection eDirection, ulong ulFrom, ulong ulTo) => default; // 0x000000018646DB40-0x000000018646DBE0
		public EVROverlayError MoveGamepadFocusToNeighbor(EOverlayDirection eDirection, ulong ulFrom) => default; // 0x000000018646CF60-0x000000018646D000
		public EVROverlayError SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture) => default; // 0x000000018646E060-0x000000018646E100
		public EVROverlayError ClearOverlayTexture(ulong ulOverlayHandle) => default; // 0x000000018646B360-0x000000018646B3F0
		public EVROverlayError SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unDepth) => default; // 0x000000018646DBE0-0x000000018646DCA0
		public EVROverlayError SetOverlayFromFile(ulong ulOverlayHandle, string pchFilePath) => default; // 0x000000018646D810-0x000000018646D8B0
		public EVROverlayError GetOverlayTexture(ulong ulOverlayHandle, ref IntPtr pNativeTextureHandle, IntPtr pNativeTextureRef, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref ETextureType pAPIType, ref EColorSpace pColorSpace, ref VRTextureBounds_t pTextureBounds) => default; // 0x000000018646C580-0x000000018646C680
		public EVROverlayError ReleaseNativeOverlayHandle(ulong ulOverlayHandle, IntPtr pNativeTextureHandle) => default; // 0x000000018646D1D0-0x000000018646D270
		public EVROverlayError GetOverlayTextureSize(ulong ulOverlayHandle, ref uint pWidth, ref uint pHeight) => default; // 0x000000018646C4E0-0x000000018646C580
		public EVROverlayError CreateDashboardOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle) => default; // 0x000000018646B510-0x000000018646B5C0
		public bool IsDashboardVisible() => default; // 0x000000018646CDC0-0x000000018646CE40
		public bool IsActiveDashboardOverlay(ulong ulOverlayHandle) => default; // 0x000000018646CD30-0x000000018646CDC0
		public EVROverlayError SetDashboardOverlaySceneProcess(ulong ulOverlayHandle, uint unProcessId) => default; // 0x000000018646D270-0x000000018646D310
		public EVROverlayError GetDashboardOverlaySceneProcess(ulong ulOverlayHandle, ref uint punProcessId) => default; // 0x000000018646B790-0x000000018646B830
		public void ShowDashboard(string pchOverlayToShow) {} // 0x000000018646E420-0x000000018646E4B0
		public uint GetPrimaryDashboardDevice() => default; // 0x000000018646CA50-0x000000018646CAD0
		public EVROverlayError ShowKeyboard(int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue) => default; // 0x000000018646E5A0-0x000000018646E680
		public EVROverlayError ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue) => default; // 0x000000018646E4B0-0x000000018646E5A0
		public uint GetKeyboardText(StringBuilder pchText, uint cchText) => default; // 0x000000018646B930-0x000000018646B9D0
		public void HideKeyboard() {} // 0x000000018646CC20-0x000000018646CCA0
		public void SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform) {} // 0x000000018646D4D0-0x000000018646D560
		public void SetKeyboardPositionForOverlay(ulong ulOverlayHandle, HmdRect2_t avoidRect) {} // 0x000000018646D430-0x000000018646D4D0
		public EVROverlayError SetOverlayIntersectionMask(ulong ulOverlayHandle, ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, uint unNumMaskPrimitives, uint unPrimitiveSize) => default; // 0x000000018646D950-0x000000018646DA00
		public EVROverlayError GetOverlayFlags(ulong ulOverlayHandle, ref uint pFlags) => default; // 0x000000018646BD10-0x000000018646BDB0
		public VRMessageOverlayResponse ShowMessageOverlay(string pchText, string pchCaption, string pchButton0Text, string pchButton1Text, string pchButton2Text, string pchButton3Text) => default; // 0x000000018646E680-0x000000018646E750
		public void CloseMessageOverlay() {} // 0x000000018646B3F0-0x000000018646B470
	}
}
