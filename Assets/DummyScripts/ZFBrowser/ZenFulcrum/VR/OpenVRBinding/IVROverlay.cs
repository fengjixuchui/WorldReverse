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
	public struct IVROverlay // TypeDefIndex: 6327
	{
		// Fields
		internal _FindOverlay FindOverlay; // 0x00
		internal _CreateOverlay CreateOverlay; // 0x08
		internal _DestroyOverlay DestroyOverlay; // 0x10
		internal _SetHighQualityOverlay SetHighQualityOverlay; // 0x18
		internal _GetHighQualityOverlay GetHighQualityOverlay; // 0x20
		internal _GetOverlayKey GetOverlayKey; // 0x28
		internal _GetOverlayName GetOverlayName; // 0x30
		internal _SetOverlayName SetOverlayName; // 0x38
		internal _GetOverlayImageData GetOverlayImageData; // 0x40
		internal _GetOverlayErrorNameFromEnum GetOverlayErrorNameFromEnum; // 0x48
		internal _SetOverlayRenderingPid SetOverlayRenderingPid; // 0x50
		internal _GetOverlayRenderingPid GetOverlayRenderingPid; // 0x58
		internal _SetOverlayFlag SetOverlayFlag; // 0x60
		internal _GetOverlayFlag GetOverlayFlag; // 0x68
		internal _SetOverlayColor SetOverlayColor; // 0x70
		internal _GetOverlayColor GetOverlayColor; // 0x78
		internal _SetOverlayAlpha SetOverlayAlpha; // 0x80
		internal _GetOverlayAlpha GetOverlayAlpha; // 0x88
		internal _SetOverlayTexelAspect SetOverlayTexelAspect; // 0x90
		internal _GetOverlayTexelAspect GetOverlayTexelAspect; // 0x98
		internal _SetOverlaySortOrder SetOverlaySortOrder; // 0xA0
		internal _GetOverlaySortOrder GetOverlaySortOrder; // 0xA8
		internal _SetOverlayWidthInMeters SetOverlayWidthInMeters; // 0xB0
		internal _GetOverlayWidthInMeters GetOverlayWidthInMeters; // 0xB8
		internal _SetOverlayAutoCurveDistanceRangeInMeters SetOverlayAutoCurveDistanceRangeInMeters; // 0xC0
		internal _GetOverlayAutoCurveDistanceRangeInMeters GetOverlayAutoCurveDistanceRangeInMeters; // 0xC8
		internal _SetOverlayTextureColorSpace SetOverlayTextureColorSpace; // 0xD0
		internal _GetOverlayTextureColorSpace GetOverlayTextureColorSpace; // 0xD8
		internal _SetOverlayTextureBounds SetOverlayTextureBounds; // 0xE0
		internal _GetOverlayTextureBounds GetOverlayTextureBounds; // 0xE8
		internal _GetOverlayRenderModel GetOverlayRenderModel; // 0xF0
		internal _SetOverlayRenderModel SetOverlayRenderModel; // 0xF8
		internal _GetOverlayTransformType GetOverlayTransformType; // 0x100
		internal _SetOverlayTransformAbsolute SetOverlayTransformAbsolute; // 0x108
		internal _GetOverlayTransformAbsolute GetOverlayTransformAbsolute; // 0x110
		internal _SetOverlayTransformTrackedDeviceRelative SetOverlayTransformTrackedDeviceRelative; // 0x118
		internal _GetOverlayTransformTrackedDeviceRelative GetOverlayTransformTrackedDeviceRelative; // 0x120
		internal _SetOverlayTransformTrackedDeviceComponent SetOverlayTransformTrackedDeviceComponent; // 0x128
		internal _GetOverlayTransformTrackedDeviceComponent GetOverlayTransformTrackedDeviceComponent; // 0x130
		internal _GetOverlayTransformOverlayRelative GetOverlayTransformOverlayRelative; // 0x138
		internal _SetOverlayTransformOverlayRelative SetOverlayTransformOverlayRelative; // 0x140
		internal _ShowOverlay ShowOverlay; // 0x148
		internal _HideOverlay HideOverlay; // 0x150
		internal _IsOverlayVisible IsOverlayVisible; // 0x158
		internal _GetTransformForOverlayCoordinates GetTransformForOverlayCoordinates; // 0x160
		internal _PollNextOverlayEvent PollNextOverlayEvent; // 0x168
		internal _GetOverlayInputMethod GetOverlayInputMethod; // 0x170
		internal _SetOverlayInputMethod SetOverlayInputMethod; // 0x178
		internal _GetOverlayMouseScale GetOverlayMouseScale; // 0x180
		internal _SetOverlayMouseScale SetOverlayMouseScale; // 0x188
		internal _ComputeOverlayIntersection ComputeOverlayIntersection; // 0x190
		internal _HandleControllerOverlayInteractionAsMouse HandleControllerOverlayInteractionAsMouse; // 0x198
		internal _IsHoverTargetOverlay IsHoverTargetOverlay; // 0x1A0
		internal _GetGamepadFocusOverlay GetGamepadFocusOverlay; // 0x1A8
		internal _SetGamepadFocusOverlay SetGamepadFocusOverlay; // 0x1B0
		internal _SetOverlayNeighbor SetOverlayNeighbor; // 0x1B8
		internal _MoveGamepadFocusToNeighbor MoveGamepadFocusToNeighbor; // 0x1C0
		internal _SetOverlayTexture SetOverlayTexture; // 0x1C8
		internal _ClearOverlayTexture ClearOverlayTexture; // 0x1D0
		internal _SetOverlayRaw SetOverlayRaw; // 0x1D8
		internal _SetOverlayFromFile SetOverlayFromFile; // 0x1E0
		internal _GetOverlayTexture GetOverlayTexture; // 0x1E8
		internal _ReleaseNativeOverlayHandle ReleaseNativeOverlayHandle; // 0x1F0
		internal _GetOverlayTextureSize GetOverlayTextureSize; // 0x1F8
		internal _CreateDashboardOverlay CreateDashboardOverlay; // 0x200
		internal _IsDashboardVisible IsDashboardVisible; // 0x208
		internal _IsActiveDashboardOverlay IsActiveDashboardOverlay; // 0x210
		internal _SetDashboardOverlaySceneProcess SetDashboardOverlaySceneProcess; // 0x218
		internal _GetDashboardOverlaySceneProcess GetDashboardOverlaySceneProcess; // 0x220
		internal _ShowDashboard ShowDashboard; // 0x228
		internal _GetPrimaryDashboardDevice GetPrimaryDashboardDevice; // 0x230
		internal _ShowKeyboard ShowKeyboard; // 0x238
		internal _ShowKeyboardForOverlay ShowKeyboardForOverlay; // 0x240
		internal _GetKeyboardText GetKeyboardText; // 0x248
		internal _HideKeyboard HideKeyboard; // 0x250
		internal _SetKeyboardTransformAbsolute SetKeyboardTransformAbsolute; // 0x258
		internal _SetKeyboardPositionForOverlay SetKeyboardPositionForOverlay; // 0x260
		internal _SetOverlayIntersectionMask SetOverlayIntersectionMask; // 0x268
		internal _GetOverlayFlags GetOverlayFlags; // 0x270
		internal _ShowMessageOverlay ShowMessageOverlay; // 0x278
		internal _CloseMessageOverlay CloseMessageOverlay; // 0x280
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _FindOverlay(string pchOverlayKey, ref ulong pOverlayHandle); // TypeDefIndex: 6328; 0x0000000187BF17F0-0x0000000187BF1AA0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _CreateOverlay(string pchOverlayKey, string pchOverlayName, ref ulong pOverlayHandle); // TypeDefIndex: 6329; 0x0000000187BF0FF0-0x0000000187BF12E0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _DestroyOverlay(ulong ulOverlayHandle); // TypeDefIndex: 6330; 0x0000000187BF1490-0x0000000187BF1620
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetHighQualityOverlay(ulong ulOverlayHandle); // TypeDefIndex: 6331; 0x0000000187C057E0-0x0000000187C05970
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate ulong _GetHighQualityOverlay(); // TypeDefIndex: 6332; 0x0000000187BF7280-0x0000000187BF73F0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetOverlayKey(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError); // TypeDefIndex: 6333; 0x0000000187BFADC0-0x0000000187BFB000
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetOverlayName(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError); // TypeDefIndex: 6334; 0x0000000187BFB5B0-0x0000000187BFB7F0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayName(ulong ulOverlayHandle, string pchName); // TypeDefIndex: 6335; 0x0000000187C08180-0x0000000187C08340
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight); // TypeDefIndex: 6336; 0x0000000187BFA580-0x0000000187BFA810
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate IntPtr _GetOverlayErrorNameFromEnum(EVROverlayError error); // TypeDefIndex: 6337; 0x0000000187BF9A20-0x0000000187BF9BB0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayRenderingPid(ulong ulOverlayHandle, uint unPID); // TypeDefIndex: 6338; 0x0000000187C09150-0x0000000187C09310
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetOverlayRenderingPid(ulong ulOverlayHandle); // TypeDefIndex: 6339; 0x0000000187BFBE70-0x0000000187BFC000
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled); // TypeDefIndex: 6340; 0x0000000187C06EB0-0x0000000187C07090
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled); // TypeDefIndex: 6341; 0x0000000187BF9DB0-0x0000000187BF9F90
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayColor(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue); // TypeDefIndex: 6342; 0x0000000187C06A70-0x0000000187C06CC0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlayColor(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue); // TypeDefIndex: 6343; 0x0000000187BF9620-0x0000000187BF9870
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha); // TypeDefIndex: 6344; 0x0000000187C062B0-0x0000000187C06470
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlayAlpha(ulong ulOverlayHandle, ref float pfAlpha); // TypeDefIndex: 6345; 0x0000000187BF8E30-0x0000000187BF8FF0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayTexelAspect(ulong ulOverlayHandle, float fTexelAspect); // TypeDefIndex: 6346; 0x0000000187C09870-0x0000000187C09A30
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlayTexelAspect(ulong ulOverlayHandle, ref float pfTexelAspect); // TypeDefIndex: 6347; 0x0000000187BFC580-0x0000000187BFC740
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlaySortOrder(ulong ulOverlayHandle, uint unSortOrder); // TypeDefIndex: 6348; 0x0000000187C094E0-0x0000000187C096A0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlaySortOrder(ulong ulOverlayHandle, ref uint punSortOrder); // TypeDefIndex: 6349; 0x0000000187BFC1E0-0x0000000187BFC3A0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters); // TypeDefIndex: 6350; 0x0000000187C0B630-0x0000000187C0B7F0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlayWidthInMeters(ulong ulOverlayHandle, ref float pfWidthInMeters); // TypeDefIndex: 6351; 0x0000000187BFEEF0-0x0000000187BFF0B0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, float fMinDistanceInMeters, float fMaxDistanceInMeters); // TypeDefIndex: 6352; 0x0000000187C06660-0x0000000187C06860
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, ref float pfMinDistanceInMeters, ref float pfMaxDistanceInMeters); // TypeDefIndex: 6353; 0x0000000187BF9200-0x0000000187BF93E0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayTextureColorSpace(ulong ulOverlayHandle, EColorSpace eTextureColorSpace); // TypeDefIndex: 6354; 0x0000000187C09FA0-0x0000000187C0A160
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlayTextureColorSpace(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace); // TypeDefIndex: 6355; 0x0000000187BFCCC0-0x0000000187BFCE80
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds); // TypeDefIndex: 6356; 0x0000000187C09C10-0x0000000187C09DD0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds); // TypeDefIndex: 6357; 0x0000000187BFC920-0x0000000187BFCAE0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetOverlayRenderModel(ulong ulOverlayHandle, string pchValue, uint unBufferSize, ref HmdColor_t pColor, ref EVROverlayError pError); // TypeDefIndex: 6358; 0x0000000187BFBA30-0x0000000187BFBCC0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayRenderModel(ulong ulOverlayHandle, string pchRenderModel, ref HmdColor_t pColor); // TypeDefIndex: 6359; 0x0000000187C08DA0-0x0000000187C08F80
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlayTransformType(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType); // TypeDefIndex: 6360; 0x0000000187BFEB50-0x0000000187BFED10
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayTransformAbsolute(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform); // TypeDefIndex: 6361; 0x0000000187C0A700-0x0000000187C0A8E0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlayTransformAbsolute(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform); // TypeDefIndex: 6362; 0x0000000187BFDB50-0x0000000187BFDD30
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform); // TypeDefIndex: 6363; 0x0000000187C0B280-0x0000000187C0B460
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform); // TypeDefIndex: 6364; 0x0000000187BFE790-0x0000000187BFE970
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, uint unDeviceIndex, string pchComponentName); // TypeDefIndex: 6365; 0x0000000187C0AEA0-0x0000000187C0B080
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, string pchComponentName, uint unComponentNameSize); // TypeDefIndex: 6366; 0x0000000187BFE340-0x0000000187BFE580
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ref ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform); // TypeDefIndex: 6367; 0x0000000187BFDF40-0x0000000187BFE120
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform); // TypeDefIndex: 6368; 0x0000000187C0AAE0-0x0000000187C0ACC0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _ShowOverlay(ulong ulOverlayHandle); // TypeDefIndex: 6369; 0x0000000187C0DC70-0x0000000187C0DE00
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _HideOverlay(ulong ulOverlayHandle); // TypeDefIndex: 6370; 0x0000000187C01CD0-0x0000000187C01E60
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _IsOverlayVisible(ulong ulOverlayHandle); // TypeDefIndex: 6371; 0x0000000187C02FC0-0x0000000187C03150
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetTransformForOverlayCoordinates(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform); // TypeDefIndex: 6372; 0x0000000187C002F0-0x0000000187C00530
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _PollNextOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent); // TypeDefIndex: 6373; 0x0000000187C03A00-0x0000000187C03BE0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlayInputMethod(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod); // TypeDefIndex: 6374; 0x0000000187BFA9F0-0x0000000187BFABB0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayInputMethod(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod); // TypeDefIndex: 6375; 0x0000000187C075F0-0x0000000187C077B0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale); // TypeDefIndex: 6376; 0x0000000187BFB1E0-0x0000000187BFB3A0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale); // TypeDefIndex: 6377; 0x0000000187C07DF0-0x0000000187C07FB0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _ComputeOverlayIntersection(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults); // TypeDefIndex: 6378; 0x0000000187BF0170-0x0000000187BF0350
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _HandleControllerOverlayInteractionAsMouse(ulong ulOverlayHandle, uint unControllerDeviceIndex); // TypeDefIndex: 6379; 0x0000000187C013A0-0x0000000187C01560
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _IsHoverTargetOverlay(ulong ulOverlayHandle); // TypeDefIndex: 6380; 0x0000000187C02970-0x0000000187C02B00
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate ulong _GetGamepadFocusOverlay(); // TypeDefIndex: 6381; 0x0000000187BF6F70-0x0000000187BF70E0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetGamepadFocusOverlay(ulong ulNewFocusOverlay); // TypeDefIndex: 6382; 0x0000000187C054A0-0x0000000187C05630
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayNeighbor(EOverlayDirection eDirection, ulong ulFrom, ulong ulTo); // TypeDefIndex: 6383; 0x0000000187C08530-0x0000000187C08710
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _MoveGamepadFocusToNeighbor(EOverlayDirection eDirection, ulong ulFrom); // TypeDefIndex: 6384; 0x0000000187C03640-0x0000000187C03800
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture); // TypeDefIndex: 6385; 0x0000000187C0A340-0x0000000187C0A500
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _ClearOverlayTexture(ulong ulOverlayHandle); // TypeDefIndex: 6386; 0x0000000187BEFAE0-0x0000000187BEFC70
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unDepth); // TypeDefIndex: 6387; 0x0000000187C08940-0x0000000187C08BB0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayFromFile(ulong ulOverlayHandle, string pchFilePath); // TypeDefIndex: 6388; 0x0000000187C07260-0x0000000187C07420
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlayTexture(ulong ulOverlayHandle, ref IntPtr pNativeTextureHandle, IntPtr pNativeTextureRef, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref ETextureType pAPIType, ref EColorSpace pColorSpace, ref VRTextureBounds_t pTextureBounds); // TypeDefIndex: 6389; 0x0000000187BFD570-0x0000000187BFD940
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _ReleaseNativeOverlayHandle(ulong ulOverlayHandle, IntPtr pNativeTextureHandle); // TypeDefIndex: 6390; 0x0000000187C043B0-0x0000000187C04570
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlayTextureSize(ulong ulOverlayHandle, ref uint pWidth, ref uint pHeight); // TypeDefIndex: 6391; 0x0000000187BFD090-0x0000000187BFD270
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _CreateDashboardOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle); // TypeDefIndex: 6392; 0x0000000187BF0550-0x0000000187BF08B0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _IsDashboardVisible(); // TypeDefIndex: 6393; 0x0000000187C02340-0x0000000187C024B0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _IsActiveDashboardOverlay(ulong ulOverlayHandle); // TypeDefIndex: 6394; 0x0000000187C02010-0x0000000187C021A0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetDashboardOverlaySceneProcess(ulong ulOverlayHandle, uint unProcessId); // TypeDefIndex: 6395; 0x0000000187C04E10-0x0000000187C04FD0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetDashboardOverlaySceneProcess(ulong ulOverlayHandle, ref uint punProcessId); // TypeDefIndex: 6396; 0x0000000187BF5610-0x0000000187BF57D0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _ShowDashboard(string pchOverlayToShow); // TypeDefIndex: 6397; 0x0000000187C0C420-0x0000000187C0C680
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetPrimaryDashboardDevice(); // TypeDefIndex: 6398; 0x0000000187BFF250-0x0000000187BFF3C0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _ShowKeyboard(int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue); // TypeDefIndex: 6399; 0x0000000187C0CE40-0x0000000187C0D160
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue); // TypeDefIndex: 6400; 0x0000000187C0C8C0-0x0000000187C0CC30
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetKeyboardText(StringBuilder pchText, uint cchText); // TypeDefIndex: 6401; 0x0000000187BF75B0-0x0000000187BF7860
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _HideKeyboard(); // TypeDefIndex: 6402; 0x0000000187C016E0-0x0000000187C01840
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform); // TypeDefIndex: 6403; 0x0000000187C05F20-0x0000000187C060E0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _SetKeyboardPositionForOverlay(ulong ulOverlayHandle, HmdRect2_t avoidRect); // TypeDefIndex: 6404; 0x0000000187C05B20-0x0000000187C05D50
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _SetOverlayIntersectionMask(ulong ulOverlayHandle, ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, uint unNumMaskPrimitives, uint unPrimitiveSize); // TypeDefIndex: 6405; 0x0000000187C079D0-0x0000000187C07C10
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVROverlayError _GetOverlayFlags(ulong ulOverlayHandle, ref uint pFlags); // TypeDefIndex: 6406; 0x0000000187BFA170-0x0000000187BFA330
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate VRMessageOverlayResponse _ShowMessageOverlay(string pchText, string pchCaption, string pchButton0Text, string pchButton1Text, string pchButton2Text, string pchButton3Text); // TypeDefIndex: 6407; 0x0000000187C0D340-0x0000000187C0D7E0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _CloseMessageOverlay(); // TypeDefIndex: 6408; 0x0000000187BEFDF0-0x0000000187BEFF50
	}
}
