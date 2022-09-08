/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class Mmoron // TypeDefIndex: 11204
{
	// Methods
	// [XID] // 0x0000000189ACD6A0-0x0000000189ACD6C0
	public static bool Initialize(MmoronMemorySettings memorySettings, MmoronStreamingSettings streamingSettings, MmoronDeviceSettings deviceSettings, MmoronInitSettings initSettings, MmoronPlatformSettings platformSettings, MmoronMusicSettings musicSettings, MmoronSpatialAudioSettings spatialSettings, MmoronCustomSettings customSettings) => default; // 0x0000000184009D70-0x0000000184009FE0
	// [XID] // 0x0000000189B37A60-0x0000000189B37A80
	public static AkResult RenderAudio() => default; // 0x000000018400E130-0x000000018400E1F0
	// [XID] // 0x0000000189B3F3E0-0x0000000189B3F400
	public static void Terminate() {} // 0x000000018400DFB0-0x000000018400E070
	// [XID] // 0x0000000189AE4640-0x0000000189AE4660
	public static AkResult Suspend() => default; // 0x000000018400AAD0-0x000000018400AB90
	// [XID] // 0x0000000189AEBD90-0x0000000189AEBDB0
	public static AkResult Resume() => default; // 0x0000000184009FE0-0x000000018400A0A0
	// [XID] // 0x0000000189B46D80-0x0000000189B46DA0
	public static AkResult RegisterAuxDevices(string motionShareSetName, string controllerSpeakerShareSetName) => default; // 0x000000018400D600-0x000000018400D6E0
	// [XID] // 0x0000000189B4E5F0-0x0000000189B4E610
	public static AkResult SetBasePath(string path) => default; // 0x000000018400EBA0-0x000000018400EC70
	// [XID] // 0x0000000189B02640-0x0000000189B02660
	public static AkResult AddBasePath(string path) => default; // 0x000000018400A190-0x000000018400A260
	// [XID] // 0x0000000189B09C80-0x0000000189B09CA0
	public static AkResult SetCurrentLanguage(string language) => default; // 0x0000000184008580-0x0000000184008650
	// [XID] // 0x0000000189B64DA0-0x0000000189B64DC0
	public static AkResult LoadFilePackageSeries(string filePackageNameBase, string filePackageExt, byte countLg2) => default; // 0x0000000184006670-0x0000000184006770
	// [XID] // 0x0000000189B18810-0x0000000189B18830
	public static AkResult LoadFilePackageSeriesByLanguage(string filePackageNameBase, string filePackageExt, byte countLg2, uint[] packageIds) => default; // 0x000000018400B3A0-0x000000018400B4C0
	// [XID] // 0x00000001897FD310-0x00000001897FD330
	public static AkResult LoadFilePackage(string filePackageName, out uint packageId, int memPoolId) {
		packageId = default;
		return default;
	} // 0x0000000184004BC0-0x0000000184004CC0
	// [XID] // 0x0000000189AD5830-0x0000000189AD5850
	public static AkResult UnloadFilePackage(uint packageId) => default; // 0x0000000184005470-0x0000000184005530
	// [XID] // 0x0000000189B2E900-0x0000000189B2E920
	public static AkResult UnloadAllFilePackages() => default; // 0x000000018400E070-0x000000018400E130
	// [XID] // 0x0000000189B36050-0x0000000189B36070
	public static AkResult LocateSoundBankInPackage(uint bankId) => default; // 0x000000018400BD00-0x000000018400BDC0
	// [XID] // 0x0000000189B3D680-0x0000000189B3D6A0
	public static AkResult LocateExternalFileInPackage(ulong fileId) => default; // 0x0000000184003F30-0x0000000184004000
	// [XID] // 0x0000000189B455E0-0x0000000189B45600
	public static AkResult LoadBankWithCallback(uint bankId, int pCookie) => default; // 0x00000001840072C0-0x00000001840073A0
	// [XID] // 0x00000001898D5850-0x00000001898D5870
	public static AkResult LoadBank(uint bankId) => default; // 0x0000000184004CC0-0x0000000184004D80
	// [XID] // 0x0000000189BDBDC0-0x0000000189BDBDE0
	public static AkResult UnloadBankWithCallback(uint bankId, int pCookie) => default; // 0x000000018400B0D0-0x000000018400B1B0
	// [XID] // 0x0000000189B5BD60-0x0000000189B5BD80
	public static AkResult UnloadBank(uint bankId) => default; // 0x000000018400CB50-0x000000018400CC10
	// [XID] // 0x0000000189B63180-0x0000000189B631A0
	public static AkResult AddDefaultListener(ulong id) => default; // 0x0000000184005E30-0x0000000184005F00
	// [XID] // 0x0000000189B6AA70-0x0000000189B6AA90
	public static AkResult RemoveDefaultListener(ulong id) => default; // 0x000000018400BA80-0x000000018400BB50
	// [XID] // 0x0000000189B722A0-0x0000000189B722C0
	public static AkResult SetToUseListener(ulong emitterId, ulong listenerId) => default; // 0x00000001840063B0-0x0000000184006490
	// [XID] // 0x0000000189B796B0-0x0000000189B796D0
	public static AkResult SetToUseDefaultListener(ulong id) => default; // 0x0000000184003E60-0x0000000184003F30
	// [XID] // 0x00000001898F1140-0x00000001898F1160
	public static AkResult SetListenerVolumeOffset(ulong id, float offset) => default; // 0x0000000184006D00-0x0000000184006DE0
	// [XID] // 0x0000000189BB8CB0-0x0000000189BB8CD0
	public static void StopPlayingId(uint playingId) {} // 0x000000018400AF50-0x000000018400B010
	// [XID] // 0x0000000189B8F8A0-0x0000000189B8F8C0
	public static void StopAllOnGameObject(ulong gameObjectId) {} // 0x000000018400EAE0-0x000000018400EBA0
	// [XID] // 0x0000000189B96E00-0x0000000189B96E20
	public static void StopAllGlobally() {} // 0x0000000184007C50-0x0000000184007D10
	// [XID] // 0x0000000189B9E210-0x0000000189B9E230
	public static AkResult SetErrorLevel(AkMonitorErrorLevel errorLevel) => default; // 0x000000018400F300-0x000000018400F3C0
	// [XID] // 0x00000001895E8670-0x00000001895E8690
	public static int GetMonitorMessageCount() => default; // 0x0000000184004E70-0x0000000184004F30
	// [XID] // 0x0000000189BACEA0-0x0000000189BACEC0
	public static void PeekMonitorMessageQueue(out AkMonitorErrorCode errorCode, out AkMonitorErrorLevel errorLevel, out string error, out uint playingId, out ulong gameObjectId) {
		errorCode = default;
		errorLevel = default;
		error = default;
		playingId = default;
		gameObjectId = default;
	} // 0x0000000184005020-0x00000001840051A0
	// [XID] // 0x0000000189BB4790-0x0000000189BB47B0
	public static void RemoveFirstMonitorMessage() {} // 0x0000000184008D10-0x0000000184008DD0
	// [IDTag] // 0x0000000189BBBD30-0x0000000189BBBD70
	// [XID] // 0x0000000189BBBD30-0x0000000189BBBD70
	public static AkResult RegisterGameObject(ulong id) => default; // 0x0000000184009AD0-0x0000000184009BA0
	// [IDTag] // 0x0000000189BC6690-0x0000000189BC66D0
	// [XID] // 0x0000000189BC6690-0x0000000189BC66D0
	public static AkResult RegisterGameObject(ulong id, string name) => default; // 0x0000000184009BA0-0x0000000184009C80
	// [XID] // 0x0000000189BD10F0-0x0000000189BD1110
	public static AkResult UnregisterGameObject(ulong id) => default; // 0x000000018400CED0-0x000000018400CFA0
	// [XID] // 0x0000000189BD8770-0x0000000189BD8790
	public static AkResult SetPosition(ulong gameObjectId, float x, float y, float z, float fx, float fy, float fz, float ux, float uy, float uz) => default; // 0x00000001840094F0-0x00000001840096D0
	// [XID] // 0x0000000189BDFF20-0x0000000189BDFF40
	public static AkResult SetMultiPositions(ulong gameObjectId, AudioPositionArray positions, ushort numPositions, int multiPositionType) => default; // 0x0000000184006FC0-0x0000000184007100
	// [XID] // 0x00000001895ECD40-0x00000001895ECD60
	public static AkResult SetLocalRtpcValue(uint rtpcId, float value, ulong gameObjectId) => default; // 0x0000000184008870-0x0000000184008970
	// [XID] // 0x0000000189A69160-0x0000000189A69180
	public static AkResult SetGlobalRtpcValue(uint rtpcId, float value) => default; // 0x000000018400AB90-0x000000018400AC70
	// [XID] // 0x00000001895FBB80-0x00000001895FBBA0
	public static AkResult SetSwitch(uint switchGroup, uint switchState, ulong gameObjectId) => default; // 0x000000018400D8B0-0x000000018400D9B0
	// [XID] // 0x0000000189603340-0x0000000189603360
	public static AkResult SetState(uint stateGroup, uint state) => default; // 0x0000000184006770-0x0000000184006850
	// [XID] // 0x000000018960AD20-0x000000018960AD40
	public static AkResult SetObjectObstructionAndOcclusion(ulong emitterId, ulong listenerId, float obstruction, float occlusion) => default; // 0x000000018400DD90-0x000000018400DEB0
	// [XID] // 0x00000001896122B0-0x00000001896122D0
	public static AkResult PostTrigger(uint triggerId, ulong gameObjectId) => default; // 0x0000000184007650-0x0000000184007730
	// [XID] // 0x0000000189619C10-0x0000000189619C30
	public static uint PostEvent(uint eventId, ulong gameObjectId, uint flags, int pCookie, uint cExternals, IntPtr pExternalSources, uint playingId, bool prependLanguage) => default; // 0x0000000184009180-0x0000000184009300
	// [XID] // 0x00000001896065D0-0x00000001896065F0
	public static bool GetBackgroundMusicMute() => default; // 0x000000018400B010-0x000000018400B0D0
	// [XID] // 0x0000000189628800-0x0000000189628820
	public static void MuteBackgroundMusic(bool mute) {} // 0x000000018400A720-0x000000018400A7E0
	// [XID] // 0x0000000189630170-0x0000000189630190
	public static AkResult SeekOnEvent(uint eventId, ulong gameObjectId, int position, bool seekToNearestMarker, uint playingId) => default; // 0x0000000184009300-0x0000000184009420
	// [XID] // 0x000000018961CCC0-0x000000018961CCE0
	public static uint GetStashedEventCallbackStubCount() => default; // 0x000000018400BB50-0x000000018400BC10
	// [XID] // 0x000000018963F090-0x000000018963F0B0
	public static uint GetStashedBankCallbackStubCount() => default; // 0x0000000184004120-0x00000001840041E0
	// [XID] // 0x000000018962B9B0-0x000000018962B9D0
	public static bool GetFirstStashedEventCallbackStub(ref MmoronEventCallbackStub stub) => default; // 0x000000018400A9C0-0x000000018400AAD0
	// [XID] // 0x0000000189633480-0x00000001896334A0
	public static MmoronBankCallbackStub GetFirstStashedBankCallbackStub() => default; // 0x0000000184008650-0x0000000184008780
	// [XID] // 0x00000001896559D0-0x00000001896559F0
	public static void RemoveFirstStashedEventCallbackStub() {} // 0x000000018400D450-0x000000018400D510
	// [XID] // 0x000000018965D160-0x000000018965D180
	public static void RemoveFirstStashedBankCallbackStub() {} // 0x00000001840059A0-0x0000000184005A60
	// [XID] // 0x000000018998A0F0-0x000000018998A110
	public static AkCallbackType GetEventCallbackStubCallbackType(IntPtr ptr) => default; // 0x0000000184008C40-0x0000000184008D10
	// [XID] // 0x00000001897FE870-0x00000001897FE890
	public static IntPtr GetEventCallbackStubInfoPtr(IntPtr ptr) => default; // 0x000000018400E840-0x000000018400E910
	// [XID] // 0x0000000189673B60-0x0000000189673B80
	public static IntPtr GetCallbackInfoCookiePtr(IntPtr ptr) => default; // 0x0000000184005D60-0x0000000184005E30
	// [XID] // 0x000000018967B280-0x000000018967B2A0
	public static ulong GetCallbackInfoGameObjectId(IntPtr ptr) => default; // 0x000000018400AE80-0x000000018400AF50
	// [XID] // 0x00000001897EFB20-0x00000001897EFB40
	public static uint GetEventCallbackInfoPlayingId(IntPtr ptr) => default; // 0x000000018400E1F0-0x000000018400E2C0
	// [XID] // 0x000000018968A7C0-0x000000018968A7E0
	public static uint GetEventCallbackInfoEventId(IntPtr ptr) => default; // 0x000000018400CD00-0x000000018400CDD0
	// [XID] // 0x0000000189692450-0x0000000189692470
	public static uint GetMusicPlaylistCallbackInfoPlaylistId(IntPtr ptr) => default; // 0x0000000184005290-0x0000000184005360
	// [XID] // 0x0000000189699870-0x0000000189699890
	public static uint GetMusicPlaylistCallbackInfoNumPlaylistItems(IntPtr ptr) => default; // 0x00000001840073A0-0x0000000184007470
	// [XID] // 0x00000001896A0D20-0x00000001896A0D40
	public static uint GetMusicPlaylistCallbackInfoPlaylistSelection(IntPtr ptr) => default; // 0x000000018400B6D0-0x000000018400B7A0
	// [XID] // 0x00000001896A8250-0x00000001896A8270
	public static uint GetMusicPlaylistCallbackInfoPlaylistItemDone(IntPtr ptr) => default; // 0x000000018400D380-0x000000018400D450
	// [XID] // 0x0000000189991A90-0x0000000189991AB0
	public static uint GetMusicSyncCallbackInfoPlayingId(IntPtr ptr) => default; // 0x000000018400F4A0-0x000000018400F570
	// [XID] // 0x00000001896B6D40-0x00000001896B6D60
	public static MmoronSegmentInfo GetMusicSyncCallbackInfoSegmentInfo(IntPtr ptr) => default; // 0x000000018400EF30-0x000000018400F100
	// [XID] // 0x00000001896BDF40-0x00000001896BDF60
	public static AkCallbackType GetMusicSyncCallbackInfoMusicSyncType(IntPtr ptr) => default; // 0x000000018400C400-0x000000018400C4D0
	// [XID] // 0x00000001896C5810-0x00000001896C5830
	public static string GetMusicSyncCallbackInfoUserCueName(IntPtr ptr) => default; // 0x00000001840096D0-0x0000000184009810
	// [XID] // 0x0000000189B6C250-0x0000000189B6C270
	public static void CloneMusicSyncCallbackInfoUserCueName(IntPtr ptr, out IntPtr pClone, out int nByte) {
		pClone = default;
		nByte = default;
	} // 0x00000001840083A0-0x0000000184008580
	// [XID] // 0x00000001896D40E0-0x00000001896D4100
	public static string GetUserCueNameText(IntPtr ptr, int byteLength) => default; // 0x000000018400D9B0-0x000000018400DAD0
	// [XID] // 0x0000000189BAE820-0x0000000189BAE840
	public static uint GetBankCallbackStubBankId(IntPtr ptr) => default; // 0x0000000184006A30-0x0000000184006B00
	// [XID] // 0x00000001896E31E0-0x00000001896E3200
	public static AkResult GetBankCallbackStubLoadResult(IntPtr ptr) => default; // 0x00000001840062E0-0x00000001840063B0
	// [XID] // 0x0000000189BA7590-0x0000000189BA75B0
	public static IntPtr GetBankCallbackStubCookiePtr(IntPtr ptr) => default; // 0x000000018400D090-0x000000018400D160
	// [XID] // 0x00000001896F1710-0x00000001896F1730
	public static bool GetBankCallbackStubDidLoad(IntPtr ptr) => default; // 0x00000001840071F0-0x00000001840072C0
	// [XID] // 0x0000000189667B30-0x0000000189667B50
	public static MmoronInitSettings CreateNewDefaultInitSettings() => default; // 0x0000000184007A60-0x0000000184007B60
	// [XID] // 0x000000018966F360-0x000000018966F380
	public static void DeleteInitSettings(MmoronInitSettings initSettings) {} // 0x0000000184005530-0x0000000184005610
	// [XID] // 0x0000000189963040-0x0000000189963060
	public static void InitSettings_SetMaxNumPaths(MmoronInitSettings settings, uint value) {} // 0x000000018400C5C0-0x000000018400C6B0
	// [XID] // 0x000000018970FC50-0x000000018970FC70
	public static void InitSettings_SetDefaultPoolSize(MmoronInitSettings settings, uint value) {} // 0x00000001840045D0-0x00000001840046C0
	// [XID] // 0x0000000189716E30-0x0000000189716E50
	public static void InitSettings_SetDefaultPoolRatioThreshold(MmoronInitSettings settings, float value) {} // 0x000000018400D510-0x000000018400D600
	// [XID] // 0x000000018971E800-0x000000018971E820
	public static void InitSettings_SetCommandQueueSize(MmoronInitSettings settings, uint value) {} // 0x000000018400A260-0x000000018400A350
	// [XID] // 0x0000000189725FE0-0x0000000189726000
	public static void InitSettings_SetPrepareEventMemoryPoolId(MmoronInitSettings settings, short value) {} // 0x0000000184006DE0-0x0000000184006ED0
	// [XID] // 0x000000018972D570-0x000000018972D590
	public static void InitSettings_SetEnableGameSyncPreparation(MmoronInitSettings settings, bool value) {} // 0x000000018400A630-0x000000018400A720
	// [XID] // 0x0000000189734C90-0x0000000189734CB0
	public static void InitSettings_SetContinuousPlaybackLookAhead(MmoronInitSettings settings, uint value) {} // 0x000000018400B4C0-0x000000018400B5B0
	// [XID] // 0x000000018973C880-0x000000018973C8A0
	public static uint InitSettings_GetNumSamplesPerFrame(MmoronInitSettings settings) => default; // 0x000000018400A350-0x000000018400A430
	// [XID] // 0x0000000189743D00-0x0000000189743D20
	public static void InitSettings_SetNumSamplesPerFrame(MmoronInitSettings settings, uint value) {} // 0x00000001840051A0-0x0000000184005290
	// [XID] // 0x000000018974B930-0x000000018974B950
	public static void InitSettings_SetMonitorPoolSize(MmoronInitSettings settings, uint value) {} // 0x0000000184007E00-0x0000000184007EF0
	// [XID] // 0x0000000189752D10-0x0000000189752D30
	public static void InitSettings_SetMonitorQueuePoolSize(MmoronInitSettings settings, uint value) {} // 0x000000018400C980-0x000000018400CA70
	// [XID] // 0x0000000189759FC0-0x0000000189759FE0
	public static void InitSettings_SetMaxHardwareTimeoutMs(MmoronInitSettings settings, uint value) {} // 0x0000000184007B60-0x0000000184007C50
	// [XID] // 0x0000000189761DC0-0x0000000189761DE0
	public static void InitSettings_SetUseSoundBankMgrThread(MmoronInitSettings settings, bool value) {} // 0x000000018400C4D0-0x000000018400C5C0
	// [XID] // 0x0000000189769170-0x0000000189769190
	public static void InitSettings_SetUseLEngineThread(MmoronInitSettings settings, bool value) {} // 0x00000001840099E0-0x0000000184009AD0
	// [XID] // 0x0000000189AC62B0-0x0000000189AC62D0
	public static void InitSettings_SetPluginDllPath(MmoronInitSettings settings, string value) {} // 0x0000000184004D80-0x0000000184004E70
	// [XID] // 0x0000000189676E50-0x0000000189676E70
	public static MmoronMemorySettings CreateNewDefaultMemorySettings() => default; // 0x00000001840049D0-0x0000000184004AD0
	// [XID] // 0x000000018977F5E0-0x000000018977F600
	public static void DeleteMemorySettings(MmoronMemorySettings memorySettings) {} // 0x000000018400CA70-0x000000018400CB50
	// [XID] // 0x0000000189786FA0-0x0000000189786FC0
	public static void MemorySettings_SetMmaxNumPools(MmoronMemorySettings settings, uint value) {} // 0x000000018400B890-0x000000018400B980
	// [XID] // 0x000000018978E620-0x000000018978E640
	public static void MemorySettings_SetDebugFlags(MmoronMemorySettings settings, uint value) {} // 0x000000018400C790-0x000000018400C880
	// [XID] // 0x0000000189795D80-0x0000000189795DA0
	public static MmoronDeviceSettings CreateNewDefaultDeviceSettings() => default; // 0x00000001840061E0-0x00000001840062E0
	// [XID] // 0x000000018968D7A0-0x000000018968D7C0
	public static void DeleteDeviceSettings(MmoronDeviceSettings deviceSettings) {} // 0x0000000184009810-0x00000001840098F0
	// [XID] // 0x00000001897A54B0-0x00000001897A54D0
	public static void DeviceSettings_SetIoMemoryPtr(MmoronDeviceSettings settings, IntPtr ptr) {} // 0x00000001840044E0-0x00000001840045D0
	// [XID] // 0x00000001897ACB20-0x00000001897ACB40
	public static void DeviceSettings_SetIoMemorySize(MmoronDeviceSettings settings, uint size) {} // 0x000000018400B7A0-0x000000018400B890
	// [XID] // 0x0000000189AED650-0x0000000189AED670
	public static void DeviceSettings_SetIoMemoryAlignment(MmoronDeviceSettings settings, uint value) {} // 0x000000018400BC10-0x000000018400BD00
	// [XID] // 0x0000000189857790-0x00000001898577B0
	public static void DeviceSettings_SetPoolAttributes(MmoronDeviceSettings settings, AkMemPoolAttributes attributes) {} // 0x000000018400A7E0-0x000000018400A8D0
	// [XID] // 0x00000001897C3CB0-0x00000001897C3CD0
	public static void DeviceSettings_SetGranularity(MmoronDeviceSettings settings, uint value) {} // 0x0000000184004AD0-0x0000000184004BC0
	// [XID] // 0x00000001897CB580-0x00000001897CB5A0
	public static void DeviceSettings_SetSchedulerTypeFlags(MmoronDeviceSettings settings, uint value) {} // 0x0000000184008780-0x0000000184008870
	// [XID] // 0x00000001897D2CE0-0x00000001897D2D00
	public static MmoronThreadProperties DeviceSettings_GetThreadProperties(MmoronDeviceSettings settings) => default; // 0x0000000184005C40-0x0000000184005D60
	// [XID] // 0x0000000189B03CD0-0x0000000189B03CF0
	public static void DeviceSettings_SetThreadProperties(MmoronDeviceSettings settings, MmoronThreadProperties properties) {} // 0x000000018400F100-0x000000018400F210
	// [XID] // 0x00000001897E1E40-0x00000001897E1E60
	public static void DeviceSettings_SetTargetAutoStmBufferLength(MmoronDeviceSettings settings, float value) {} // 0x000000018400E590-0x000000018400E680
	// [XID] // 0x00000001897E95D0-0x00000001897E95F0
	public static void DeviceSettings_SetMaxConcurrentIo(MmoronDeviceSettings settings, uint value) {} // 0x00000001840048E0-0x00000001840049D0
	// [XID] // 0x00000001897F1220-0x00000001897F1240
	public static void DeviceSettings_SetUseStreamCache(MmoronDeviceSettings settings, bool value) {} // 0x0000000184009090-0x0000000184009180
	// [XID] // 0x0000000189B5BE00-0x0000000189B5BE20
	public static void DeviceSettings_SetMaxCachePinnedBytes(MmoronDeviceSettings settings, uint value) {} // 0x0000000184009C80-0x0000000184009D70
	// [XID] // 0x0000000189800160-0x0000000189800180
	public static MmoronStreamingSettings CreateNewDefaultStreamMgrSettings() => default; // 0x000000018400DC90-0x000000018400DD90
	// [XID] // 0x0000000189807800-0x0000000189807820
	public static void DeleteStreamMgrSettings(MmoronStreamingSettings streamingSettings) {} // 0x0000000184008970-0x0000000184008A50
	// [XID] // 0x000000018980EEA0-0x000000018980EEC0
	public static void StreamMgrSettings_SetMemorySize(MmoronStreamingSettings settings, uint value) {} // 0x0000000184007D10-0x0000000184007E00
	// [XID] // 0x00000001898165C0-0x00000001898165E0
	public static MmoronPlatformSettings CreateNewDefaultPlatformSettings() => default; // 0x000000018400DEB0-0x000000018400DFB0
	// [XID] // 0x00000001896BF8B0-0x00000001896BF8D0
	public static void DeletePlatformSettings(MmoronPlatformSettings platformSettings) {} // 0x000000018400E910-0x000000018400E9F0
	// [XID] // 0x0000000189825340-0x0000000189825360
	public static MmoronThreadProperties PlatformSettings_GetLEngineThreadProperties(MmoronPlatformSettings settings) => default; // 0x000000018400BFD0-0x000000018400C0F0
	// [XID] // 0x000000018982CCB0-0x000000018982CCD0
	public static MmoronThreadProperties PlatformSettings_GetBankManagerThreadProperties(MmoronPlatformSettings settings) => default; // 0x0000000184004000-0x0000000184004120
	// [XID] // 0x00000001898343E0-0x0000000189834400
	public static MmoronThreadProperties PlatformSettings_GetMonitorThreadProperties(MmoronPlatformSettings settings) => default; // 0x000000018400B5B0-0x000000018400B6D0
	// [XID] // 0x000000018983B770-0x000000018983B790
	public static MmoronThreadProperties PlatformSettings_GetOutputThreadProperties(MmoronPlatformSettings settings) => default; // 0x000000018400AC70-0x000000018400AD90
	// [XID] // 0x00000001899ED080-0x00000001899ED0A0
	public static void PlatformSettings_SetLEngineThreadProperties(MmoronPlatformSettings settings, MmoronThreadProperties properties) {} // 0x00000001840060D0-0x00000001840061E0
	// [XID] // 0x000000018984A3F0-0x000000018984A410
	public static void PlatformSettings_SetBankManagerThreadProperties(MmoronPlatformSettings settings, MmoronThreadProperties properties) {} // 0x000000018400BDC0-0x000000018400BED0
	// [XID] // 0x0000000189B302D0-0x0000000189B302F0
	public static void PlatformSettings_SetMonitorThreadProperties(MmoronPlatformSettings settings, MmoronThreadProperties properties) {} // 0x0000000184006BF0-0x0000000184006D00
	// [XID] // 0x0000000189A210A0-0x0000000189A210C0
	public static void PlatformSettings_SetOutputThreadProperties(MmoronPlatformSettings settings, MmoronThreadProperties properties) {} // 0x000000018400C0F0-0x000000018400C200
	// [XID] // 0x0000000189860350-0x0000000189860370
	public static void PlatformSettings_SetLEngineDefaultPoolSize(MmoronPlatformSettings settings, uint value) {} // 0x0000000184008B50-0x0000000184008C40
	// [XID] // 0x0000000189867950-0x0000000189867970
	public static void PlatformSettings_SetLEngineDefaultPoolRatioThreashold(MmoronPlatformSettings settings, float value) {} // 0x0000000184005FE0-0x00000001840060D0
	// [XID] // 0x0000000189A28410-0x0000000189A28430
	public static ushort PlatformSettings_GetNumRefillInVoice(MmoronPlatformSettings settings) => default; // 0x000000018400E3C0-0x000000018400E4A0
	// [XID] // 0x0000000189876570-0x0000000189876590
	public static void PlatformSettings_SetNumRefillInVoice(MmoronPlatformSettings settings, ushort value) {} // 0x0000000184006940-0x0000000184006A30
	// [XID] // 0x0000000189A49230-0x0000000189A49250
	public static uint PlatformSettings_GetSampleRate(MmoronPlatformSettings settings) => default; // 0x0000000184005F00-0x0000000184005FE0
	// [XID] // 0x0000000189885210-0x0000000189885230
	public static void PlatformSettings_SetSampleRate(MmoronPlatformSettings settings, uint value) {} // 0x0000000184006580-0x0000000184006670
	// [XID] // 0x000000018988C780-0x000000018988C7A0
	public static void PlatformSettings_SetAudioAPI(MmoronPlatformSettings settings, int value) {} // 0x000000018400EE40-0x000000018400EF30
	// [XID] // 0x0000000189893CD0-0x0000000189893CF0
	public static MmoronMusicSettings CreateNewDefaultMusicSettings() => default; // 0x000000018400C880-0x000000018400C980
	// [XID] // 0x00000001896DD310-0x00000001896DD330
	public static void DeleteMusicSettings(MmoronMusicSettings musicSettings) {} // 0x00000001840080C0-0x00000001840081A0
	// [XID] // 0x00000001898A28B0-0x00000001898A28D0
	public static void MusicSettings_SetStreamingLookAheadRatio(MmoronMusicSettings settings, float value) {} // 0x000000018400E9F0-0x000000018400EAE0
	// [XID] // 0x00000001898A9E20-0x00000001898A9E40
	public static MmoronThreadProperties CreateNewThreadProperties() => default; // 0x000000018400CDD0-0x000000018400CED0
	// [XID] // 0x000000018986AC60-0x000000018986AC80
	public static void DeleteThreadProperties(MmoronThreadProperties threadProperties) {} // 0x000000018400EC70-0x000000018400ED50
	// [XID] // 0x0000000189B03DD0-0x0000000189B03DF0
	public static void ThreadProperties_SetPriority(MmoronThreadProperties properties, int value) {} // 0x000000018400F210-0x000000018400F300
	// [XID] // 0x0000000189B12CE0-0x0000000189B12D00
	public static void ThreadProperties_SetAffinityMask(MmoronThreadProperties properties, uint value) {} // 0x0000000184008FA0-0x0000000184009090
	// [XID] // 0x0000000189B28E30-0x0000000189B28E50
	public static void ThreadProperties_SetStackSize(MmoronThreadProperties properties, uint value) {} // 0x0000000184007100-0x00000001840071F0
	// [XID] // 0x00000001898CF720-0x00000001898CF740
	public static MmoronCustomSettings CreateNewDefaultCustomSettings() => default; // 0x000000018400B980-0x000000018400BA80
	// [XID] // 0x00000001898D7030-0x00000001898D7050
	public static void DeleteCustomSettings(MmoronCustomSettings settings) {} // 0x000000018400C6B0-0x000000018400C790
	// [XID] // 0x00000001898DEE50-0x00000001898DEE70
	public static void CustomSettings_SetUseBankPoolForPackages(MmoronCustomSettings settings, bool value) {} // 0x000000018400AD90-0x000000018400AE80
	// [XID] // 0x0000000189823D60-0x0000000189823D80
	public static void CustomSettings_SetBankPoolSize(MmoronCustomSettings settings, uint size) {} // 0x0000000184005A60-0x0000000184005B50
	// [XID] // 0x000000018982B860-0x000000018982B880
	public static void CustomSettings_SetProductName(MmoronCustomSettings settings, string name) {} // 0x0000000184006B00-0x0000000184006BF0
	// [XID] // 0x00000001898F56B0-0x00000001898F56D0
	public static MmoronExternalSourceInfoArray CreateNewExternalSourceInfoArray(int count) => default; // 0x00000001840043A0-0x00000001840044E0
	// [XID] // 0x00000001898FCDC0-0x00000001898FCDE0
	public static void DeleteExternalSourceInfoArray(MmoronExternalSourceInfoArray info) {} // 0x000000018400ED50-0x000000018400EE40
	// [XID] // 0x0000000189B55C00-0x0000000189B55C20
	public static void ExternalSourceInfoArray_SetExternalSourceCookie(MmoronExternalSourceInfoArray info, uint value, int index) {} // 0x000000018400B1B0-0x000000018400B2C0
	// [XID] // 0x000000018990BF40-0x000000018990BF60
	public static void ExternalSourceInfoArray_SetCodec(MmoronExternalSourceInfoArray info, MmoronCodecId codec, int index) {} // 0x000000018400F570-0x000000018400F680
	// [XID] // 0x0000000189B46E00-0x0000000189B46E20
	public static void ExternalSourceInfoArray_SetFilePath(MmoronExternalSourceInfoArray info, string value, int index) {} // 0x000000018400A520-0x000000018400A630
	// [XID] // 0x000000018970CAD0-0x000000018970CAF0
	public static void ExternalSourceInfoArray_SetInMemoryPtr(MmoronExternalSourceInfoArray info, IntPtr ptr, int index) {} // 0x0000000184005360-0x0000000184005470
	// [XID] // 0x00000001898798C0-0x00000001898798E0
	public static void ExternalSourceInfoArray_SetMemorySize(MmoronExternalSourceInfoArray info, uint size, int index) {} // 0x000000018400C200-0x000000018400C310
	// [XID] // 0x000000018992A000-0x000000018992A020
	public static void ExternalSourceInfoArray_SetFileId(MmoronExternalSourceInfoArray info, uint id, int index) {} // 0x0000000184007730-0x0000000184007840
	// [XID] // 0x00000001899316D0-0x00000001899316F0
	public static MmoronSpatialAudioSettings CreateNewDefaultSpatialAudioSettings() => default; // 0x000000018400BED0-0x000000018400BFD0
	// [XID] // 0x000000018971BD20-0x000000018971BD40
	public static void DeleteSpatialAudioSettings(MmoronSpatialAudioSettings settings) {} // 0x00000001840057D0-0x00000001840058B0
	// [XID] // 0x00000001899405D0-0x00000001899405F0
	public static void SpatialAudioSettings_SetPoolSize(MmoronSpatialAudioSettings settings, uint value) {} // 0x0000000184003D70-0x0000000184003E60
	// [XID] // 0x0000000189947C30-0x0000000189947C50
	public static void SpatialAudioSettings_SetMaxProagationDepth(MmoronSpatialAudioSettings settings, uint value) {} // 0x0000000184004F30-0x0000000184005020
	// [XID] // 0x0000000189A6EBE0-0x0000000189A6EC00
	public static void SpatialAudioSettings_SetDiffractionFlags(MmoronSpatialAudioSettings settings, uint value) {} // 0x000000018400E4A0-0x000000018400E590
	// [XID] // 0x00000001899568C0-0x00000001899568E0
	public static MmoronEmitterSettings CreateNewDefaultEmitterSettings() => default; // 0x0000000184008A50-0x0000000184008B50
	// [XID] // 0x000000018995E370-0x000000018995E390
	public static void DeleteEmitterSettings(MmoronEmitterSettings settings) {} // 0x000000018400D6E0-0x000000018400D7C0
	// [XID] // 0x0000000189888230-0x0000000189888250
	public static void SpatialEmitterSettings_SetReflectAuxBusID(MmoronEmitterSettings settings, uint value) {} // 0x000000018400D290-0x000000018400D380
	// [XID] // 0x000000018996D270-0x000000018996D290
	public static void SpatialEmitterSettings_SetReflectionMaxPathLength(MmoronEmitterSettings settings, float value) {} // 0x0000000184006490-0x0000000184006580
	// [XID] // 0x0000000189974B30-0x0000000189974B50
	public static void SpatialEmitterSettings_SetReflectionsAuxBusGain(MmoronEmitterSettings settings, float value) {} // 0x000000018400A0A0-0x000000018400A190
	// [XID] // 0x000000018972A8C0-0x000000018972A8E0
	public static void SpatialEmitterSettings_SetReflectionsOrder(MmoronEmitterSettings settings, uint value) {} // 0x000000018400A8D0-0x000000018400A9C0
	// [XID] // 0x0000000189983C90-0x0000000189983CB0
	public static void SpatialEmitterSettings_SetReflectorFilterMask(MmoronEmitterSettings settings, uint value) {} // 0x00000001840047F0-0x00000001840048E0
	// [XID] // 0x0000000189731F80-0x0000000189731FA0
	public static void SpatialEmitterSettings_SetRoomReverbAuxBusGain(MmoronEmitterSettings settings, float value) {} // 0x0000000184007840-0x0000000184007930
	// [XID] // 0x0000000189993180-0x00000001899931A0
	public static void SpatialEmitterSettings_SetDiffractionMaxEdges(MmoronEmitterSettings settings, uint value) {} // 0x000000018400E680-0x000000018400E770
	// [XID] // 0x000000018999AC10-0x000000018999AC30
	public static void SpatialEmitterSettings_SetDiffractionMaxPaths(MmoronEmitterSettings settings, uint value) {} // 0x0000000184005B50-0x0000000184005C40
	// [XID] // 0x00000001898A5C90-0x00000001898A5CB0
	public static void SpatialEmitterSettings_SetDiffractionMaxPathLength(MmoronEmitterSettings settings, float value) {} // 0x000000018400D7C0-0x000000018400D8B0
	// [XID] // 0x0000000189741240-0x0000000189741260
	public static void SpatialEmitterSettings_SetUseImageSources(MmoronEmitterSettings settings, byte value) {} // 0x00000001840056E0-0x00000001840057D0
	// [XID] // 0x00000001899B1600-0x00000001899B1620
	public static MmoronRoomParams CreateNewDefaultRoomParams() => default; // 0x0000000184008DD0-0x0000000184008ED0
	// [XID] // 0x0000000189726100-0x0000000189726120
	public static void DeleteRoomParams(MmoronRoomParams @params) {} // 0x0000000184007FE0-0x00000001840080C0
	// [XID] // 0x00000001899C03D0-0x00000001899C03F0
	public static void RoomParams_SetUp(MmoronRoomParams @params, float x, float y, float z) {} // 0x000000018400D160-0x000000018400D290
	// [XID] // 0x00000001899C7C50-0x00000001899C7C70
	public static void RoomParams_SetFront(MmoronRoomParams @params, float x, float y, float z) {} // 0x00000001840046C0-0x00000001840047F0
	// [XID] // 0x00000001899CF430-0x00000001899CF450
	public static void RoomParams_SetReverbAuxBus(MmoronRoomParams @params, uint value) {} // 0x000000018400C310-0x000000018400C400
	// [XID] // 0x00000001899DC880-0x00000001899DC8A0
	public static void RoomParams_SetReverbLevel(MmoronRoomParams @params, float value) {} // 0x00000001840042B0-0x00000001840043A0
	// [XID] // 0x00000001899DDF50-0x00000001899DDF70
	public static void RoomParams_SetWallOcclusion(MmoronRoomParams @params, float value) {} // 0x0000000184007560-0x0000000184007650
	// [XID] // 0x0000000189A09690-0x0000000189A096B0
	public static void RoomParams_SetStrName(MmoronRoomParams @params, string value) {} // 0x000000018400CFA0-0x000000018400D090
	// [XID] // 0x00000001899ECDA0-0x00000001899ECDC0
	public static void RoomParams_SetRoomGameObj_AuxSendLevelToSelf(MmoronRoomParams @params, float value) {} // 0x0000000184006ED0-0x0000000184006FC0
	// [XID] // 0x00000001897B64A0-0x00000001897B64C0
	public static void RoomParams_SetRoomGameObj_KeepRegistered(MmoronRoomParams @params, bool value) {} // 0x00000001840098F0-0x00000001840099E0
	// [XID] // 0x0000000189A342B0-0x0000000189A342D0
	public static MmoronPortalParams CreateNewDefaultPortalParams() => default; // 0x000000018400E2C0-0x000000018400E3C0
	// [XID] // 0x0000000189B28E70-0x0000000189B28E90
	public static void DeletePortalParams(MmoronPortalParams @params) {} // 0x000000018400B2C0-0x000000018400B3A0
	// [XID] // 0x0000000189A0ABD0-0x0000000189A0ABF0
	public static void PortalParams_SetTransform(MmoronPortalParams @params, float x, float y, float z, float fx, float fy, float fz, float tx, float ty, float tz) {} // 0x00000001840081A0-0x00000001840083A0
	// [XID] // 0x0000000189A123E0-0x0000000189A12400
	public static void PortalParams_SetExtent(MmoronPortalParams @params, float x, float y, float z) {} // 0x0000000184007930-0x0000000184007A60
	// [XID] // 0x0000000189B0B5A0-0x0000000189B0B5C0
	public static void PortalParams_SetEnabled(MmoronPortalParams @params, bool value) {} // 0x000000018400DAD0-0x000000018400DBC0
	// [XID] // 0x0000000189B216A0-0x0000000189B216C0
	public static void PortalParams_SetName(MmoronPortalParams @params, string value) {} // 0x000000018400A430-0x000000018400A520
	// [XID] // 0x0000000189A28160-0x0000000189A28180
	public static void PortalParams_SetFrontRoom(MmoronPortalParams @params, ulong value) {} // 0x000000018400CC10-0x000000018400CD00
	// [XID] // 0x0000000189A2F970-0x0000000189A2F990
	public static void PortalParams_SetBackRoom(MmoronPortalParams @params, ulong value) {} // 0x00000001840058B0-0x00000001840059A0
	// [XID] // 0x0000000189AD8460-0x0000000189AD8480
	public static AkResult RegisterEmitter(ulong gameObjectId, MmoronEmitterSettings settings) => default; // 0x0000000184007470-0x0000000184007560
	// [XID] // 0x0000000189A3EA30-0x0000000189A3EA50
	public static AkResult UnregisterEmitter(ulong gameObjectId) => default; // 0x00000001840041E0-0x00000001840042B0
	// [XID] // 0x0000000189A460E0-0x0000000189A46100
	public static AkResult RegisterListener(ulong gameObjectId) => default; // 0x000000018400E770-0x000000018400E840
	// [XID] // 0x0000000189A4D870-0x0000000189A4D890
	public static AkResult UnregisterListener(ulong gameObjectId) => default; // 0x0000000184005610-0x00000001840056E0
	// [XID] // 0x0000000189A550B0-0x0000000189A550D0
	public static AkResult SetRoom(ulong roomId, MmoronRoomParams @params) => default; // 0x0000000184006850-0x0000000184006940
	// [XID] // 0x0000000189A5C9C0-0x0000000189A5C9E0
	public static AkResult RemoveRoom(ulong roomId) => default; // 0x0000000184009420-0x00000001840094F0
	// [XID] // 0x0000000189B37AA0-0x0000000189B37AC0
	public static AkResult SetPortal(ulong portalId, MmoronPortalParams @params) => default; // 0x0000000184007EF0-0x0000000184007FE0
	// [XID] // 0x0000000189A6BBE0-0x0000000189A6BC00
	public static AkResult RemovePortal(ulong portalId) => default; // 0x000000018400DBC0-0x000000018400DC90
	// [XID] // 0x0000000189A733A0-0x0000000189A733C0
	public static AkResult SetGameObjectInRoom(ulong gameObjectId, ulong roomId) => default; // 0x000000018400F3C0-0x000000018400F4A0
	// [XID] // 0x0000000189A7AE90-0x0000000189A7AEB0
	public static float GetCpuUsage() => default; // 0x0000000184008ED0-0x0000000184008FA0
}

