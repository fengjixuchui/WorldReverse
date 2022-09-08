/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public class OpenVR // TypeDefIndex: 6596
	{
		// Fields
		public const uint k_nDriverNone = 4294967295; // Metadata: 0x00ADC677
		public const uint k_unMaxDriverDebugResponseSize = 32768; // Metadata: 0x00ADC67B
		public const uint k_unTrackedDeviceIndex_Hmd = 0; // Metadata: 0x00ADC67F
		public const uint k_unMaxTrackedDeviceCount = 16; // Metadata: 0x00ADC683
		public const uint k_unTrackedDeviceIndexOther = 4294967294; // Metadata: 0x00ADC687
		public const uint k_unTrackedDeviceIndexInvalid = 4294967295; // Metadata: 0x00ADC68B
		public const ulong k_ulInvalidPropertyContainer = 0; // Metadata: 0x00ADC68F
		public const uint k_unInvalidPropertyTag = 0; // Metadata: 0x00ADC697
		public const uint k_unFloatPropertyTag = 1; // Metadata: 0x00ADC69B
		public const uint k_unInt32PropertyTag = 2; // Metadata: 0x00ADC69F
		public const uint k_unUint64PropertyTag = 3; // Metadata: 0x00ADC6A3
		public const uint k_unBoolPropertyTag = 4; // Metadata: 0x00ADC6A7
		public const uint k_unStringPropertyTag = 5; // Metadata: 0x00ADC6AB
		public const uint k_unHmdMatrix34PropertyTag = 20; // Metadata: 0x00ADC6AF
		public const uint k_unHmdMatrix44PropertyTag = 21; // Metadata: 0x00ADC6B3
		public const uint k_unHmdVector3PropertyTag = 22; // Metadata: 0x00ADC6B7
		public const uint k_unHmdVector4PropertyTag = 23; // Metadata: 0x00ADC6BB
		public const uint k_unHiddenAreaPropertyTag = 30; // Metadata: 0x00ADC6BF
		public const uint k_unOpenVRInternalReserved_Start = 1000; // Metadata: 0x00ADC6C3
		public const uint k_unOpenVRInternalReserved_End = 10000; // Metadata: 0x00ADC6C7
		public const uint k_unMaxPropertyStringSize = 32768; // Metadata: 0x00ADC6CB
		public const uint k_unControllerStateAxisCount = 5; // Metadata: 0x00ADC6CF
		public const ulong k_ulOverlayHandleInvalid = 0; // Metadata: 0x00ADC6D3
		public const uint k_unScreenshotHandleInvalid = 0; // Metadata: 0x00ADC6DB
		public const string IVRSystem_Version = "IVRSystem_017"; // Metadata: 0x00ADC6DF
		public const string IVRExtendedDisplay_Version = "IVRExtendedDisplay_001"; // Metadata: 0x00ADC6F0
		public const string IVRTrackedCamera_Version = "IVRTrackedCamera_003"; // Metadata: 0x00ADC70A
		public const uint k_unMaxApplicationKeyLength = 128; // Metadata: 0x00ADC722
		public const string k_pch_MimeType_HomeApp = "vr/home"; // Metadata: 0x00ADC726
		public const string k_pch_MimeType_GameTheater = "vr/game_theater"; // Metadata: 0x00ADC731
		public const string IVRApplications_Version = "IVRApplications_006"; // Metadata: 0x00ADC744
		public const string IVRChaperone_Version = "IVRChaperone_003"; // Metadata: 0x00ADC75B
		public const string IVRChaperoneSetup_Version = "IVRChaperoneSetup_005"; // Metadata: 0x00ADC76F
		public const string IVRCompositor_Version = "IVRCompositor_021"; // Metadata: 0x00ADC788
		public const uint k_unVROverlayMaxKeyLength = 128; // Metadata: 0x00ADC79D
		public const uint k_unVROverlayMaxNameLength = 128; // Metadata: 0x00ADC7A1
		public const uint k_unMaxOverlayCount = 64; // Metadata: 0x00ADC7A5
		public const uint k_unMaxOverlayIntersectionMaskPrimitivesCount = 32; // Metadata: 0x00ADC7A9
		public const string IVROverlay_Version = "IVROverlay_016"; // Metadata: 0x00ADC7AD
		public const string k_pch_Controller_Component_GDC2015 = "gdc2015"; // Metadata: 0x00ADC7BF
		public const string k_pch_Controller_Component_Base = "base"; // Metadata: 0x00ADC7CA
		public const string k_pch_Controller_Component_Tip = "tip"; // Metadata: 0x00ADC7D2
		public const string k_pch_Controller_Component_HandGrip = "handgrip"; // Metadata: 0x00ADC7D9
		public const string k_pch_Controller_Component_Status = "status"; // Metadata: 0x00ADC7E5
		public const string IVRRenderModels_Version = "IVRRenderModels_005"; // Metadata: 0x00ADC7EF
		public const uint k_unNotificationTextMaxSize = 256; // Metadata: 0x00ADC806
		public const string IVRNotifications_Version = "IVRNotifications_002"; // Metadata: 0x00ADC80A
		public const uint k_unMaxSettingsKeyLength = 128; // Metadata: 0x00ADC822
		public const string IVRSettings_Version = "IVRSettings_002"; // Metadata: 0x00ADC826
		public const string k_pch_SteamVR_Section = "steamvr"; // Metadata: 0x00ADC839
		public const string k_pch_SteamVR_RequireHmd_String = "requireHmd"; // Metadata: 0x00ADC844
		public const string k_pch_SteamVR_ForcedDriverKey_String = "forcedDriver"; // Metadata: 0x00ADC852
		public const string k_pch_SteamVR_ForcedHmdKey_String = "forcedHmd"; // Metadata: 0x00ADC862
		public const string k_pch_SteamVR_DisplayDebug_Bool = "displayDebug"; // Metadata: 0x00ADC86F
		public const string k_pch_SteamVR_DebugProcessPipe_String = "debugProcessPipe"; // Metadata: 0x00ADC87F
		public const string k_pch_SteamVR_DisplayDebugX_Int32 = "displayDebugX"; // Metadata: 0x00ADC893
		public const string k_pch_SteamVR_DisplayDebugY_Int32 = "displayDebugY"; // Metadata: 0x00ADC8A4
		public const string k_pch_SteamVR_SendSystemButtonToAllApps_Bool = "sendSystemButtonToAllApps"; // Metadata: 0x00ADC8B5
		public const string k_pch_SteamVR_LogLevel_Int32 = "loglevel"; // Metadata: 0x00ADC8D2
		public const string k_pch_SteamVR_IPD_Float = "ipd"; // Metadata: 0x00ADC8DE
		public const string k_pch_SteamVR_Background_String = "background"; // Metadata: 0x00ADC8E5
		public const string k_pch_SteamVR_BackgroundUseDomeProjection_Bool = "backgroundUseDomeProjection"; // Metadata: 0x00ADC8F3
		public const string k_pch_SteamVR_BackgroundCameraHeight_Float = "backgroundCameraHeight"; // Metadata: 0x00ADC912
		public const string k_pch_SteamVR_BackgroundDomeRadius_Float = "backgroundDomeRadius"; // Metadata: 0x00ADC92C
		public const string k_pch_SteamVR_GridColor_String = "gridColor"; // Metadata: 0x00ADC944
		public const string k_pch_SteamVR_PlayAreaColor_String = "playAreaColor"; // Metadata: 0x00ADC951
		public const string k_pch_SteamVR_ShowStage_Bool = "showStage"; // Metadata: 0x00ADC962
		public const string k_pch_SteamVR_ActivateMultipleDrivers_Bool = "activateMultipleDrivers"; // Metadata: 0x00ADC96F
		public const string k_pch_SteamVR_DirectMode_Bool = "directMode"; // Metadata: 0x00ADC98A
		public const string k_pch_SteamVR_DirectModeEdidVid_Int32 = "directModeEdidVid"; // Metadata: 0x00ADC998
		public const string k_pch_SteamVR_DirectModeEdidPid_Int32 = "directModeEdidPid"; // Metadata: 0x00ADC9AD
		public const string k_pch_SteamVR_UsingSpeakers_Bool = "usingSpeakers"; // Metadata: 0x00ADC9C2
		public const string k_pch_SteamVR_SpeakersForwardYawOffsetDegrees_Float = "speakersForwardYawOffsetDegrees"; // Metadata: 0x00ADC9D3
		public const string k_pch_SteamVR_BaseStationPowerManagement_Bool = "basestationPowerManagement"; // Metadata: 0x00ADC9F6
		public const string k_pch_SteamVR_NeverKillProcesses_Bool = "neverKillProcesses"; // Metadata: 0x00ADCA14
		public const string k_pch_SteamVR_SupersampleScale_Float = "supersampleScale"; // Metadata: 0x00ADCA2A
		public const string k_pch_SteamVR_AllowAsyncReprojection_Bool = "allowAsyncReprojection"; // Metadata: 0x00ADCA3E
		public const string k_pch_SteamVR_AllowReprojection_Bool = "allowInterleavedReprojection"; // Metadata: 0x00ADCA58
		public const string k_pch_SteamVR_ForceReprojection_Bool = "forceReprojection"; // Metadata: 0x00ADCA78
		public const string k_pch_SteamVR_ForceFadeOnBadTracking_Bool = "forceFadeOnBadTracking"; // Metadata: 0x00ADCA8D
		public const string k_pch_SteamVR_DefaultMirrorView_Int32 = "defaultMirrorView"; // Metadata: 0x00ADCAA7
		public const string k_pch_SteamVR_ShowMirrorView_Bool = "showMirrorView"; // Metadata: 0x00ADCABC
		public const string k_pch_SteamVR_MirrorViewGeometry_String = "mirrorViewGeometry"; // Metadata: 0x00ADCACE
		public const string k_pch_SteamVR_StartMonitorFromAppLaunch = "startMonitorFromAppLaunch"; // Metadata: 0x00ADCAE4
		public const string k_pch_SteamVR_StartCompositorFromAppLaunch_Bool = "startCompositorFromAppLaunch"; // Metadata: 0x00ADCB01
		public const string k_pch_SteamVR_StartDashboardFromAppLaunch_Bool = "startDashboardFromAppLaunch"; // Metadata: 0x00ADCB21
		public const string k_pch_SteamVR_StartOverlayAppsFromDashboard_Bool = "startOverlayAppsFromDashboard"; // Metadata: 0x00ADCB40
		public const string k_pch_SteamVR_EnableHomeApp = "enableHomeApp"; // Metadata: 0x00ADCB61
		public const string k_pch_SteamVR_CycleBackgroundImageTimeSec_Int32 = "CycleBackgroundImageTimeSec"; // Metadata: 0x00ADCB72
		public const string k_pch_SteamVR_RetailDemo_Bool = "retailDemo"; // Metadata: 0x00ADCB91
		public const string k_pch_SteamVR_IpdOffset_Float = "ipdOffset"; // Metadata: 0x00ADCB9F
		public const string k_pch_SteamVR_AllowSupersampleFiltering_Bool = "allowSupersampleFiltering"; // Metadata: 0x00ADCBAC
		public const string k_pch_SteamVR_EnableLinuxVulkanAsync_Bool = "enableLinuxVulkanAsync"; // Metadata: 0x00ADCBC9
		public const string k_pch_Lighthouse_Section = "driver_lighthouse"; // Metadata: 0x00ADCBE3
		public const string k_pch_Lighthouse_DisableIMU_Bool = "disableimu"; // Metadata: 0x00ADCBF8
		public const string k_pch_Lighthouse_UseDisambiguation_String = "usedisambiguation"; // Metadata: 0x00ADCC06
		public const string k_pch_Lighthouse_DisambiguationDebug_Int32 = "disambiguationdebug"; // Metadata: 0x00ADCC1B
		public const string k_pch_Lighthouse_PrimaryBasestation_Int32 = "primarybasestation"; // Metadata: 0x00ADCC32
		public const string k_pch_Lighthouse_DBHistory_Bool = "dbhistory"; // Metadata: 0x00ADCC48
		public const string k_pch_Null_Section = "driver_null"; // Metadata: 0x00ADCC55
		public const string k_pch_Null_SerialNumber_String = "serialNumber"; // Metadata: 0x00ADCC64
		public const string k_pch_Null_ModelNumber_String = "modelNumber"; // Metadata: 0x00ADCC74
		public const string k_pch_Null_WindowX_Int32 = "windowX"; // Metadata: 0x00ADCC83
		public const string k_pch_Null_WindowY_Int32 = "windowY"; // Metadata: 0x00ADCC8E
		public const string k_pch_Null_WindowWidth_Int32 = "windowWidth"; // Metadata: 0x00ADCC99
		public const string k_pch_Null_WindowHeight_Int32 = "windowHeight"; // Metadata: 0x00ADCCA8
		public const string k_pch_Null_RenderWidth_Int32 = "renderWidth"; // Metadata: 0x00ADCCB8
		public const string k_pch_Null_RenderHeight_Int32 = "renderHeight"; // Metadata: 0x00ADCCC7
		public const string k_pch_Null_SecondsFromVsyncToPhotons_Float = "secondsFromVsyncToPhotons"; // Metadata: 0x00ADCCD7
		public const string k_pch_Null_DisplayFrequency_Float = "displayFrequency"; // Metadata: 0x00ADCCF4
		public const string k_pch_UserInterface_Section = "userinterface"; // Metadata: 0x00ADCD08
		public const string k_pch_UserInterface_StatusAlwaysOnTop_Bool = "StatusAlwaysOnTop"; // Metadata: 0x00ADCD19
		public const string k_pch_UserInterface_MinimizeToTray_Bool = "MinimizeToTray"; // Metadata: 0x00ADCD2E
		public const string k_pch_UserInterface_Screenshots_Bool = "screenshots"; // Metadata: 0x00ADCD40
		public const string k_pch_UserInterface_ScreenshotType_Int = "screenshotType"; // Metadata: 0x00ADCD4F
		public const string k_pch_Notifications_Section = "notifications"; // Metadata: 0x00ADCD61
		public const string k_pch_Notifications_DoNotDisturb_Bool = "DoNotDisturb"; // Metadata: 0x00ADCD72
		public const string k_pch_Keyboard_Section = "keyboard"; // Metadata: 0x00ADCD82
		public const string k_pch_Keyboard_TutorialCompletions = "TutorialCompletions"; // Metadata: 0x00ADCD8E
		public const string k_pch_Keyboard_ScaleX = "ScaleX"; // Metadata: 0x00ADCDA5
		public const string k_pch_Keyboard_ScaleY = "ScaleY"; // Metadata: 0x00ADCDAF
		public const string k_pch_Keyboard_OffsetLeftX = "OffsetLeftX"; // Metadata: 0x00ADCDB9
		public const string k_pch_Keyboard_OffsetRightX = "OffsetRightX"; // Metadata: 0x00ADCDC8
		public const string k_pch_Keyboard_OffsetY = "OffsetY"; // Metadata: 0x00ADCDD8
		public const string k_pch_Keyboard_Smoothing = "Smoothing"; // Metadata: 0x00ADCDE3
		public const string k_pch_Perf_Section = "perfcheck"; // Metadata: 0x00ADCDF0
		public const string k_pch_Perf_HeuristicActive_Bool = "heuristicActive"; // Metadata: 0x00ADCDFD
		public const string k_pch_Perf_NotifyInHMD_Bool = "warnInHMD"; // Metadata: 0x00ADCE10
		public const string k_pch_Perf_NotifyOnlyOnce_Bool = "warnOnlyOnce"; // Metadata: 0x00ADCE1D
		public const string k_pch_Perf_AllowTimingStore_Bool = "allowTimingStore"; // Metadata: 0x00ADCE2D
		public const string k_pch_Perf_SaveTimingsOnExit_Bool = "saveTimingsOnExit"; // Metadata: 0x00ADCE41
		public const string k_pch_Perf_TestData_Float = "perfTestData"; // Metadata: 0x00ADCE56
		public const string k_pch_Perf_LinuxGPUProfiling_Bool = "linuxGPUProfiling"; // Metadata: 0x00ADCE66
		public const string k_pch_CollisionBounds_Section = "collisionBounds"; // Metadata: 0x00ADCE7B
		public const string k_pch_CollisionBounds_Style_Int32 = "CollisionBoundsStyle"; // Metadata: 0x00ADCE8E
		public const string k_pch_CollisionBounds_GroundPerimeterOn_Bool = "CollisionBoundsGroundPerimeterOn"; // Metadata: 0x00ADCEA6
		public const string k_pch_CollisionBounds_CenterMarkerOn_Bool = "CollisionBoundsCenterMarkerOn"; // Metadata: 0x00ADCECA
		public const string k_pch_CollisionBounds_PlaySpaceOn_Bool = "CollisionBoundsPlaySpaceOn"; // Metadata: 0x00ADCEEB
		public const string k_pch_CollisionBounds_FadeDistance_Float = "CollisionBoundsFadeDistance"; // Metadata: 0x00ADCF09
		public const string k_pch_CollisionBounds_ColorGammaR_Int32 = "CollisionBoundsColorGammaR"; // Metadata: 0x00ADCF28
		public const string k_pch_CollisionBounds_ColorGammaG_Int32 = "CollisionBoundsColorGammaG"; // Metadata: 0x00ADCF46
		public const string k_pch_CollisionBounds_ColorGammaB_Int32 = "CollisionBoundsColorGammaB"; // Metadata: 0x00ADCF64
		public const string k_pch_CollisionBounds_ColorGammaA_Int32 = "CollisionBoundsColorGammaA"; // Metadata: 0x00ADCF82
		public const string k_pch_Camera_Section = "camera"; // Metadata: 0x00ADCFA0
		public const string k_pch_Camera_EnableCamera_Bool = "enableCamera"; // Metadata: 0x00ADCFAA
		public const string k_pch_Camera_EnableCameraInDashboard_Bool = "enableCameraInDashboard"; // Metadata: 0x00ADCFBA
		public const string k_pch_Camera_EnableCameraForCollisionBounds_Bool = "enableCameraForCollisionBounds"; // Metadata: 0x00ADCFD5
		public const string k_pch_Camera_EnableCameraForRoomView_Bool = "enableCameraForRoomView"; // Metadata: 0x00ADCFF7
		public const string k_pch_Camera_BoundsColorGammaR_Int32 = "cameraBoundsColorGammaR"; // Metadata: 0x00ADD012
		public const string k_pch_Camera_BoundsColorGammaG_Int32 = "cameraBoundsColorGammaG"; // Metadata: 0x00ADD02D
		public const string k_pch_Camera_BoundsColorGammaB_Int32 = "cameraBoundsColorGammaB"; // Metadata: 0x00ADD048
		public const string k_pch_Camera_BoundsColorGammaA_Int32 = "cameraBoundsColorGammaA"; // Metadata: 0x00ADD063
		public const string k_pch_Camera_BoundsStrength_Int32 = "cameraBoundsStrength"; // Metadata: 0x00ADD07E
		public const string k_pch_audio_Section = "audio"; // Metadata: 0x00ADD096
		public const string k_pch_audio_OnPlaybackDevice_String = "onPlaybackDevice"; // Metadata: 0x00ADD09F
		public const string k_pch_audio_OnRecordDevice_String = "onRecordDevice"; // Metadata: 0x00ADD0B3
		public const string k_pch_audio_OnPlaybackMirrorDevice_String = "onPlaybackMirrorDevice"; // Metadata: 0x00ADD0C5
		public const string k_pch_audio_OffPlaybackDevice_String = "offPlaybackDevice"; // Metadata: 0x00ADD0DF
		public const string k_pch_audio_OffRecordDevice_String = "offRecordDevice"; // Metadata: 0x00ADD0F4
		public const string k_pch_audio_VIVEHDMIGain = "viveHDMIGain"; // Metadata: 0x00ADD107
		public const string k_pch_Power_Section = "power"; // Metadata: 0x00ADD117
		public const string k_pch_Power_PowerOffOnExit_Bool = "powerOffOnExit"; // Metadata: 0x00ADD120
		public const string k_pch_Power_TurnOffScreensTimeout_Float = "turnOffScreensTimeout"; // Metadata: 0x00ADD132
		public const string k_pch_Power_TurnOffControllersTimeout_Float = "turnOffControllersTimeout"; // Metadata: 0x00ADD14B
		public const string k_pch_Power_ReturnToWatchdogTimeout_Float = "returnToWatchdogTimeout"; // Metadata: 0x00ADD168
		public const string k_pch_Power_AutoLaunchSteamVROnButtonPress = "autoLaunchSteamVROnButtonPress"; // Metadata: 0x00ADD183
		public const string k_pch_Power_PauseCompositorOnStandby_Bool = "pauseCompositorOnStandby"; // Metadata: 0x00ADD1A5
		public const string k_pch_Dashboard_Section = "dashboard"; // Metadata: 0x00ADD1C1
		public const string k_pch_Dashboard_EnableDashboard_Bool = "enableDashboard"; // Metadata: 0x00ADD1CE
		public const string k_pch_Dashboard_ArcadeMode_Bool = "arcadeMode"; // Metadata: 0x00ADD1E1
		public const string k_pch_modelskin_Section = "modelskins"; // Metadata: 0x00ADD1EF
		public const string k_pch_Driver_Enable_Bool = "enable"; // Metadata: 0x00ADD1FD
		public const string IVRScreenshots_Version = "IVRScreenshots_001"; // Metadata: 0x00ADD207
		public const string IVRResources_Version = "IVRResources_001"; // Metadata: 0x00ADD21D
		public const string IVRDriverManager_Version = "IVRDriverManager_001"; // Metadata: 0x00ADD231
		private const string FnTable_Prefix = "FnTable:"; // Metadata: 0x00ADD249
		private static COpenVRContext _OpenVRInternal_ModuleContext; // 0x08
	
		// Properties
		private static uint VRToken { get; set; } // 0x0000000188323A50-0x0000000188323AE0 0x0000000188323AE0-0x0000000188323BF0
		private static COpenVRContext OpenVRInternal_ModuleContext { get => default; } // 0x0000000188323540-0x0000000188323690 
		public static CVRSystem System { get => default; } // 0x0000000188323910-0x00000001883239B0 
		public static CVRChaperone Chaperone { get => default; } // 0x0000000188323360-0x0000000188323400 
		public static CVRChaperoneSetup ChaperoneSetup { get => default; } // 0x00000001883232C0-0x0000000188323360 
		public static CVRCompositor Compositor { get => default; } // 0x0000000188323400-0x00000001883234A0 
		public static CVROverlay Overlay { get => default; } // 0x0000000188323690-0x0000000188323730 
		public static CVRRenderModels RenderModels { get => default; } // 0x0000000188323730-0x00000001883237D0 
		public static CVRExtendedDisplay ExtendedDisplay { get => default; } // 0x00000001883234A0-0x0000000188323540 
		public static CVRSettings Settings { get => default; } // 0x0000000188323870-0x0000000188323910 
		public static CVRApplications Applications { get => default; } // 0x0000000188323220-0x00000001883232C0 
		public static CVRScreenshots Screenshots { get => default; } // 0x00000001883237D0-0x0000000188323870 
		public static CVRTrackedCamera TrackedCamera { get => default; } // 0x00000001883239B0-0x0000000188323A50 
	
		// Nested types
		private class COpenVRContext // TypeDefIndex: 6597
		{
			// Fields
			private CVRSystem m_pVRSystem; // 0x10
			private CVRChaperone m_pVRChaperone; // 0x18
			private CVRChaperoneSetup m_pVRChaperoneSetup; // 0x20
			private CVRCompositor m_pVRCompositor; // 0x28
			private CVROverlay m_pVROverlay; // 0x30
			private CVRRenderModels m_pVRRenderModels; // 0x38
			private CVRExtendedDisplay m_pVRExtendedDisplay; // 0x40
			private CVRSettings m_pVRSettings; // 0x48
			private CVRApplications m_pVRApplications; // 0x50
			private CVRScreenshots m_pVRScreenshots; // 0x58
			private CVRTrackedCamera m_pVRTrackedCamera; // 0x60
	
			// Constructors
			public COpenVRContext() {} // 0x0000000188320820-0x00000001883222E0
	
			// Methods
			public void Clear() {} // 0x000000018831FEB0-0x000000018831FF30
			private void CheckClear() {} // 0x000000018831FD50-0x000000018831FEB0
			public CVRSystem VRSystem() => default; // 0x0000000188320680-0x0000000188320750
			public CVRChaperone VRChaperone() => default; // 0x00000001883200D0-0x00000001883201A0
			public CVRChaperoneSetup VRChaperoneSetup() => default; // 0x0000000188320000-0x00000001883200D0
			public CVRCompositor VRCompositor() => default; // 0x00000001883201A0-0x0000000188320270
			public CVROverlay VROverlay() => default; // 0x0000000188320340-0x0000000188320410
			public CVRRenderModels VRRenderModels() => default; // 0x0000000188320410-0x00000001883204E0
			public CVRExtendedDisplay VRExtendedDisplay() => default; // 0x0000000188320270-0x0000000188320340
			public CVRSettings VRSettings() => default; // 0x00000001883205B0-0x0000000188320680
			public CVRApplications VRApplications() => default; // 0x000000018831FF30-0x0000000188320000
			public CVRScreenshots VRScreenshots() => default; // 0x00000001883204E0-0x00000001883205B0
			public CVRTrackedCamera VRTrackedCamera() => default; // 0x0000000188320750-0x0000000188320820
		}
	
		// Constructors
		public OpenVR() {} // 0x00000001883231C0-0x0000000188323220
		static OpenVR() {} // 0x0000000188323160-0x00000001883231C0
	
		// Methods
		public static uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType) => default; // 0x0000000188322C50-0x0000000188322CD0
		public static void ShutdownInternal() {} // 0x0000000188323040-0x00000001883230A0
		public static bool IsHmdPresent() => default; // 0x0000000188322EF0-0x0000000188322F60
		public static bool IsRuntimeInstalled() => default; // 0x0000000188322FD0-0x0000000188323040
		public static string GetStringForHmdError(EVRInitError error) => default; // 0x0000000188322BB0-0x0000000188322C50
		public static IntPtr GetGenericInterface(string pchInterfaceVersion, ref EVRInitError peError) => default; // 0x0000000188322AD0-0x0000000188322B50
		public static bool IsInterfaceVersionValid(string pchInterfaceVersion) => default; // 0x0000000188322F60-0x0000000188322FD0
		public static uint GetInitToken() => default; // 0x0000000188322B50-0x0000000188322BB0
		public static CVRSystem Init(ref EVRInitError peError, EVRApplicationType eApplicationType = EVRApplicationType.VRApplication_Scene /* Metadata: 0x00ADC673 */) => default; // 0x0000000188322CD0-0x0000000188322EF0
		public static void Shutdown() {} // 0x00000001883230A0-0x0000000188323160
	}
}
