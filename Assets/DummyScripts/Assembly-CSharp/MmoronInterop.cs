/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class MmoronInterop // TypeDefIndex: 11207
{
	// Fields
	public const int WCHAR_SIZE = 2; // Metadata: 0x00AE948B
	private const string LIB_NAME = "Mmoron"; // Metadata: 0x00AE948F
	private const UnmanagedType STRING_MARSHAL_TYPE = UnmanagedType.LPWStr; // Metadata: 0x00AE9499
	public static readonly Encoding wcharEncoding; // 0x00

	// Constructors
	static MmoronInterop() {} // 0x000000018517AB00-0x000000018517AB90

	// Methods
	public static extern bool Initialize(IntPtr memSettings, IntPtr streamMgrSettings, IntPtr deviceSettings, IntPtr initSettings, IntPtr platformSettings, IntPtr musicSettings, IntPtr spatialSettings, IntPtr customSettings); // 0x0000000185174C70-0x0000000185174DC0
	public static extern int RenderAudio(); // 0x0000000185179440-0x0000000185179520
	public static extern void Terminate(); // 0x0000000185179280-0x0000000185179360
	public static extern int Suspend(); // 0x0000000185175940-0x0000000185175A20
	public static extern int Resume(); // 0x0000000185174DC0-0x0000000185174EA0
	public static extern int RegisterAuxDevices(string motionShareSetName, string controllerSpeakerShareSetName); // 0x00000001851789B0-0x0000000185178AC0
	public static extern int SetBasePath(string path); // 0x000000018517A070-0x000000018517A170
	public static extern int AddBasePath(string path); // 0x0000000185174FA0-0x00000001851750A0
	public static extern int SetCurrentLanguage(string language); // 0x00000001851734C0-0x00000001851735C0
	public static extern int LoadFilePackageSeries(string filePackageNameBase, string filePackageExt, byte countLg2); // 0x00000001851715D0-0x00000001851716F0
	public static extern int LoadFilePackageSeriesByLanguage(string filePackageNameBase, string filePackageExt, byte countLg2, [In, Out] uint[] packageIds); // 0x00000001851763C0-0x00000001851764F0
	public static extern int LoadFilePackage(string filePackageName, out uint packageId, int poolId); // 0x000000018516F8E0-0x000000018516FA00
	public static extern int UnloadFilePackage(uint packageId); // 0x00000001851701E0-0x00000001851702D0
	public static extern int UnloadAllFilePackages(); // 0x0000000185179360-0x0000000185179440
	public static extern int LocateSoundBankInPackage(uint bankId); // 0x0000000185176E30-0x0000000185176F20
	public static extern int LocateExternalFileInPackage(ulong fileId); // 0x000000018516E9C0-0x000000018516EAB0
	public static extern int LoadBankWithCallback(uint bankId, IntPtr pCookie); // 0x00000001851722E0-0x00000001851723E0
	public static extern int LoadBank(uint bankdId); // 0x000000018516FA00-0x000000018516FAF0
	public static extern int UnloadBankWithCallback(uint bankId, IntPtr pCookie); // 0x0000000185175FC0-0x00000001851760C0
	public static extern int UnloadBank(uint bankId); // 0x0000000185177D50-0x0000000185177E40
	public static extern int AddDefaultListener(ulong gameObjectId); // 0x0000000185170D30-0x0000000185170E20
	public static extern int RemoveDefaultListener(ulong gameObjectId); // 0x0000000185176A80-0x0000000185176B70
	public static extern int SetToUseListener(ulong emitterId, ulong listenerId); // 0x00000001851712E0-0x00000001851713E0
	public static extern int SetToUseDefaultListener(ulong gameObjectId); // 0x000000018516E8D0-0x000000018516E9C0
	public static extern int SetListenerVolumeOffset(ulong gameObjectId, float volumeOffset); // 0x0000000185171CF0-0x0000000185171DF0
	public static extern void StopPlayingId(uint playingId); // 0x0000000185175E00-0x0000000185175EE0
	public static extern void StopAllOnGameObject(ulong gameObjectId); // 0x0000000185179F80-0x000000018517A070
	public static extern void StopAllGlobally(); // 0x0000000185172DA0-0x0000000185172E80
	public static extern int SetErrorLevel(uint errorLevel); // 0x000000018517A720-0x000000018517A810
	public static extern int GetMonitorMessageCount(); // 0x000000018516FBF0-0x000000018516FCD0
	public static extern IntPtr PeekMonitorMessageQueue(out int errorCode, out int errorLevel, out uint playingId, out ulong gameObjectId); // 0x000000018516FDC0-0x000000018516FF00
	public static extern void RemoveFirstMonitorMessage(); // 0x0000000185173C50-0x0000000185173D30
	public static extern int RegisterGameObject(ulong gameObjectId); // 0x00000001851749A0-0x0000000185174A90
	public static extern int RegisterGameObjectWithName(ulong gameObjectId, string name); // 0x00000001851761C0-0x00000001851762D0
	public static extern int UnregisterGameObject(ulong gameObjectId); // 0x0000000185178200-0x00000001851782F0
	public static extern int SetPosition(ulong gameObjectId, float x, float y, float z, float fx, float fy, float fz, float ux, float uy, float uz); // 0x0000000185174440-0x00000001851745C0
	public static extern int SetMultiPositions(ulong gameObjectId, IntPtr pPositions, ushort numPositions, int multiPositionType); // 0x0000000185171FF0-0x0000000185172100
	public static extern int SetLocalRtpcValue(uint rtpcId, float value, ulong gameObjectId); // 0x0000000185173790-0x00000001851738A0
	public static extern int SetGlobalRtpcValue(uint rtpcId, float value); // 0x0000000185175A20-0x0000000185175B20
	public static extern int SetSwitch(uint switchGroup, uint switchState, ulong gameObjectId); // 0x0000000185178CB0-0x0000000185178DB0
	public static extern int SetState(uint stateGroup, uint state); // 0x00000001851716F0-0x00000001851717F0
	public static extern int SetObjectObstructionAndOcclusion(ulong emitterId, ulong listenerId, float obstruction, float occlusion); // 0x0000000185179080-0x00000001851791A0
	public static extern int PostTrigger(uint triggerId, ulong gameObjectId); // 0x00000001851726D0-0x00000001851727D0
	public static extern uint PostEvent(uint eventId, ulong gameObjectId, uint flags, IntPtr pCookie, uint cExternals, IntPtr pExternalSources, uint playingId, bool prependLanguage); // 0x00000001851740E0-0x0000000185174230
	public static extern bool GetBackgroundMusicMute(); // 0x0000000185175EE0-0x0000000185175FC0
	public static extern void MuteBackgroundMusic(bool in_bMute); // 0x0000000185175590-0x0000000185175680
	public static extern int SeekOnEvent(uint in_eventId, ulong in_gameObjectId, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID); // 0x0000000185174230-0x0000000185174350
	public static extern uint GetStashedEventCallbackStubCount(); // 0x0000000185176B70-0x0000000185176C50
	public static extern uint GetStashedBankCallbackStubCount(); // 0x000000018516EBA0-0x000000018516EC80
	public static extern IntPtr GetFirstStashedEventCallbackStub(); // 0x0000000185175860-0x0000000185175940
	public static extern IntPtr GetFirstStashedBankCallbackStub(); // 0x00000001851735C0-0x00000001851736A0
	public static extern void RemoveFirstStashedEventCallbackStub(); // 0x00000001851787D0-0x00000001851788B0
	public static extern void RemoveFirstStashedBankCallbackStub(); // 0x0000000185170890-0x0000000185170970
	public static extern int GetEventCallbackStubCallbackType(IntPtr ptr); // 0x0000000185173B60-0x0000000185173C50
	public static extern IntPtr GetEventCallbackStubInfoPtr(IntPtr ptr); // 0x0000000185179BB0-0x0000000185179CA0
	public static extern IntPtr GetCallbackInfoCookiePtr(IntPtr ptr); // 0x0000000185170C40-0x0000000185170D30
	public static extern ulong GetCallbackInfoGameObjectId(IntPtr ptr); // 0x0000000185175D10-0x0000000185175E00
	public static extern uint GetEventCallbackInfoPlayingId(IntPtr ptr); // 0x0000000185179520-0x0000000185179610
	public static extern uint GetEventCallbackInfoEventId(IntPtr ptr); // 0x0000000185177F40-0x0000000185178030
	public static extern uint GetMusicPlaylistCallbackInfoPlaylistId(IntPtr pInfo); // 0x000000018516FFF0-0x00000001851700E0
	public static extern uint GetMusicPlaylistCallbackInfoNumPlaylistItems(IntPtr pInfo); // 0x00000001851723E0-0x00000001851724D0
	public static extern uint GetMusicPlaylistCallbackInfoPlaylistSelection(IntPtr pInfo); // 0x00000001851766D0-0x00000001851767C0
	public static extern uint GetMusicPlaylistCallbackInfoPlaylistItemDone(IntPtr pInfo); // 0x00000001851786E0-0x00000001851787D0
	public static extern int GetMusicSyncCallbackInfoSegmentInfoCurrentPosition(IntPtr pInfo); // 0x000000018516F530-0x000000018516F620
	public static extern int GetMusicSyncCallbackInfoSegmentInfoPreEntryDuration(IntPtr pInfo); // 0x0000000185176D40-0x0000000185176E30
	public static extern int GetMusicSyncCallbackInfoSegmentInfoActiveDuration(IntPtr pInfo); // 0x0000000185179D90-0x0000000185179E80
	public static extern int GetMusicSyncCallbackInfoSegmentInfoPostExitDuration(IntPtr pInfo); // 0x0000000185178030-0x0000000185178120
	public static extern int GetMusicSyncCallbackInfoSegmentInfoRemainingLookAheadTime(IntPtr pInfo); // 0x0000000185177B70-0x0000000185177C60
	public static extern float GetMusicSyncCallbackInfoSegmentInfoBeatDuration(IntPtr pInfo); // 0x00000001851729D0-0x0000000185172AC0
	public static extern float GetMusicSyncCallbackInfoSegmentInfoBarDuration(IntPtr pInfo); // 0x00000001851707A0-0x0000000185170890
	public static extern float GetMusicSyncCallbackInfoSegmentInfoGridDuration(IntPtr pInfo); // 0x0000000185174A90-0x0000000185174B80
	public static extern float GetMusicSyncCallbackInfoSegmentInfoGridOffset(IntPtr pInfo); // 0x000000018516ED70-0x000000018516EE60
	public static extern uint GetMusicSyncCallbackInfoPlayingId(IntPtr pInfo); // 0x000000018517A910-0x000000018517AA00
	public static extern AkCallbackType GetMusicSyncCallbackInfoMusicSyncType(IntPtr pInfo); // 0x00000001851774E0-0x00000001851775D0
	public static extern IntPtr GetMusicSyncCallbackInfoUserCueName(IntPtr pInfo); // 0x00000001851745C0-0x00000001851746B0
	public static extern uint GetBankCallbackStubBankId(IntPtr ptr); // 0x00000001851719F0-0x0000000185171AE0
	public static extern int GetBankCallbackStubLoadResult(IntPtr ptr); // 0x00000001851711F0-0x00000001851712E0
	public static extern IntPtr GetBankCallbackStubCookiePtr(IntPtr ptr); // 0x00000001851783F0-0x00000001851784E0
	public static extern bool GetBankCallbackStubDidLoad(IntPtr ptr); // 0x00000001851721F0-0x00000001851722E0
	public static extern IntPtr CreateNewDefaultInitSettings(); // 0x0000000185172BD0-0x0000000185172CB0
	public static extern void DeleteInitSettings(IntPtr ptr); // 0x00000001851702D0-0x00000001851703C0
	public static extern void InitSettings_SetMaxNumPaths(IntPtr pSettings, uint value); // 0x00000001851776D0-0x00000001851777C0
	public static extern void InitSettings_SetDefaultPoolSize(IntPtr pSettings, uint value); // 0x000000018516F240-0x000000018516F330
	public static extern void InitSettings_SetDefaultPoolRatioThreshold(IntPtr pSettings, float value); // 0x00000001851788B0-0x00000001851789B0
	public static extern void InitSettings_SetCommandQueueSize(IntPtr pSettings, uint value); // 0x00000001851750A0-0x0000000185175190
	public static extern void InitSettings_SetPrepareEventMemoryPoolId(IntPtr pSettings, short value); // 0x0000000185171DF0-0x0000000185171EF0
	public static extern void InitSettings_SetEnableGameSyncPreparation(IntPtr pSettings, bool value); // 0x0000000185175490-0x0000000185175590
	public static extern void InitSettings_SetContinuousPlaybackLookAhead(IntPtr pSettings, uint value); // 0x00000001851764F0-0x00000001851765E0
	public static extern uint InitSettings_GetNumSamplesPerFrame(IntPtr pSettings); // 0x0000000185175190-0x0000000185175280
	public static extern void InitSettings_SetNumSamplesPerFrame(IntPtr pSettings, uint value); // 0x000000018516FF00-0x000000018516FFF0
	public static extern void InitSettings_SetMonitorPoolSize(IntPtr pSettings, uint value); // 0x0000000185172F70-0x0000000185173060
	public static extern void InitSettings_SetMonitorQueuePoolSize(IntPtr pSettings, uint value); // 0x0000000185177A80-0x0000000185177B70
	public static extern void InitSettings_SetMaxHardwareTimeoutMs(IntPtr pSettings, uint value); // 0x0000000185172CB0-0x0000000185172DA0
	public static extern void InitSettings_SetUseSoundBankMgrThread(IntPtr pSettings, bool value); // 0x00000001851775D0-0x00000001851776D0
	public static extern void InitSettings_SetUseLEngineThread(IntPtr pSettings, bool value); // 0x00000001851748A0-0x00000001851749A0
	public static extern void InitSettings_SetPluginDllPath(IntPtr pSettings, string value); // 0x000000018516FAF0-0x000000018516FBF0
	public static extern IntPtr CreateNewDefaultMemorySettings(); // 0x000000018516F710-0x000000018516F7F0
	public static extern void DeleteMemorySettings(IntPtr ptr); // 0x0000000185177C60-0x0000000185177D50
	public static extern void MemorySettings_SetMmaxNumPools(IntPtr pSettings, uint value); // 0x00000001851768B0-0x00000001851769A0
	public static extern void MemorySettings_SetDebugFlags(IntPtr pSettings, uint value); // 0x00000001851778B0-0x00000001851779A0
	public static extern IntPtr CreateNewDefaultDeviceSettings(); // 0x0000000185171110-0x00000001851711F0
	public static extern void DeleteDeviceSettings(IntPtr ptr); // 0x00000001851746B0-0x00000001851747A0
	public static extern void DeviceSettings_SetIoMemoryPtr(IntPtr pSettings, IntPtr ptr); // 0x000000018516F050-0x000000018516F150
	public static extern void DeviceSettings_SetIoMemorySize(IntPtr pSettings, uint size); // 0x00000001851767C0-0x00000001851768B0
	public static extern void DeviceSettings_SetIoMemoryAlignment(IntPtr pSettings, uint value); // 0x0000000185176C50-0x0000000185176D40
	public static extern void DeviceSettings_SetPoolAttributes(IntPtr pSettings, int attributes); // 0x0000000185175680-0x0000000185175770
	public static extern void DeviceSettings_SetGranularity(IntPtr pSettings, uint value); // 0x000000018516F7F0-0x000000018516F8E0
	public static extern void DeviceSettings_SetSchedulerTypeFlags(IntPtr pSettings, uint value); // 0x00000001851736A0-0x0000000185173790
	public static extern IntPtr DeviceSettings_GetThreadProperties(IntPtr pSettings); // 0x0000000185170B50-0x0000000185170C40
	public static extern void DeviceSettings_SetThreadProperties(IntPtr pSettings, IntPtr pProperties); // 0x000000018517A530-0x000000018517A630
	public static extern void DeviceSettings_SetTargetAutoStmBufferLength(IntPtr pSettings, float value); // 0x00000001851798D0-0x00000001851799D0
	public static extern void DeviceSettings_SetMaxConcurrentIo(IntPtr pSettings, uint value); // 0x000000018516F620-0x000000018516F710
	public static extern void DeviceSettings_SetUseStreamCache(IntPtr pSettings, bool value); // 0x0000000185173FE0-0x00000001851740E0
	public static extern void DeviceSettings_SetMaxCachePinnedBytes(IntPtr pSettings, uint value); // 0x0000000185174B80-0x0000000185174C70
	public static extern IntPtr CreateNewDefaultStreamMgrSettings(); // 0x0000000185178FA0-0x0000000185179080
	public static extern void DeleteStreamMgrSettings(IntPtr ptr); // 0x00000001851738A0-0x0000000185173990
	public static extern void StreamMgrSettings_SetMemorySize(IntPtr pSettings, uint value); // 0x0000000185172E80-0x0000000185172F70
	public static extern IntPtr CreateNewDefaultPlatformSettings(); // 0x00000001851791A0-0x0000000185179280
	public static extern void DeletePlatformSettings(IntPtr ptr); // 0x0000000185179CA0-0x0000000185179D90
	public static extern IntPtr PlatformSettings_GetLEngineThreadProperties(IntPtr pSettings); // 0x0000000185177100-0x00000001851771F0
	public static extern IntPtr PlatformSettings_GetBankManagerThreadProperties(IntPtr pSettings); // 0x000000018516EAB0-0x000000018516EBA0
	public static extern IntPtr PlatformSettings_GetMonitorThreadProperties(IntPtr pSettings); // 0x00000001851765E0-0x00000001851766D0
	public static extern IntPtr PlatformSettings_GetOutputThreadProperties(IntPtr pSettings); // 0x0000000185175B20-0x0000000185175C10
	public static extern void PlatformSettings_SetLEngineThreadProperties(IntPtr pSettings, IntPtr pProperties); // 0x0000000185171010-0x0000000185171110
	public static extern void PlatformSettings_SetBankManagerThreadProperties(IntPtr pSettings, IntPtr pProperties); // 0x0000000185176F20-0x0000000185177020
	public static extern void PlatformSettings_SetMonitorThreadProperties(IntPtr pSettings, IntPtr pProperties); // 0x0000000185171BF0-0x0000000185171CF0
	public static extern void PlatformSettings_SetOutputThreadProperties(IntPtr pSettings, IntPtr pProperties); // 0x00000001851771F0-0x00000001851772F0
	public static extern void PlatformSettings_SetLEngineDefaultPoolSize(IntPtr pSettings, uint value); // 0x0000000185173A70-0x0000000185173B60
	public static extern void PlatformSettings_SetLEngineDefaultPoolRatioThreashold(IntPtr pSettings, float value); // 0x0000000185170F10-0x0000000185171010
	public static extern ushort PlatformSettings_GetNumRefillInVoice(IntPtr pSettings); // 0x00000001851796F0-0x00000001851797E0
	public static extern void PlatformSettings_SetNumRefillInVoice(IntPtr pSettings, ushort value); // 0x00000001851718F0-0x00000001851719F0
	public static extern uint PlatformSettings_GetSampleRate(IntPtr pSettings); // 0x0000000185170E20-0x0000000185170F10
	public static extern void PlatformSettings_SetSampleRate(IntPtr pSettings, uint value); // 0x00000001851714E0-0x00000001851715D0
	public static extern void PlatformSettings_SetAudioAPI(IntPtr pSettings, int value); // 0x000000018517A440-0x000000018517A530
	public static extern IntPtr CreateNewDefaultMusicSettings(); // 0x00000001851779A0-0x0000000185177A80
	public static extern void DeleteMusicSettings(IntPtr ptr); // 0x0000000185173250-0x0000000185173340
	public static extern void MusicSettings_SetStreamingLookAheadRatio(IntPtr pSettings, float value); // 0x0000000185179E80-0x0000000185179F80
	public static extern IntPtr CreateNewThreadProperties(); // 0x0000000185178120-0x0000000185178200
	public static extern void DeleteThreadProperties(IntPtr ptr); // 0x000000018517A170-0x000000018517A260
	public static extern void ThreadProperties_SetPriority(IntPtr pProperties, int value); // 0x000000018517A630-0x000000018517A720
	public static extern void ThreadProperties_SetAffinityMask(IntPtr pProperties, uint value); // 0x0000000185173EF0-0x0000000185173FE0
	public static extern void ThreadProperties_SetStackSize(IntPtr pProperties, uint value); // 0x0000000185172100-0x00000001851721F0
	public static extern IntPtr CreateNewDefaultCustomSettings(); // 0x00000001851769A0-0x0000000185176A80
	public static extern void DeleteCustomSettings(IntPtr pSettings); // 0x00000001851777C0-0x00000001851778B0
	public static extern void CustomSettings_SetUseBankPoolForPackages(IntPtr pSettings, bool value); // 0x0000000185175C10-0x0000000185175D10
	public static extern void CustomSettings_SetBankPoolSize(IntPtr pSettings, uint size); // 0x0000000185170970-0x0000000185170A60
	public static extern void CustomSettings_SetProductName(IntPtr pSettings, string name); // 0x0000000185171AE0-0x0000000185171BF0
	public static extern IntPtr CreateNewExternalSourceInfoArray(int count); // 0x000000018516EF60-0x000000018516F050
	public static extern void DeleteExternalSourceInfoArray(IntPtr pInfo, int count); // 0x000000018517A260-0x000000018517A350
	public static extern void ExternalSourceInfoArray_SetExternalSourceCookie(IntPtr pInfo, uint value, int index); // 0x00000001851760C0-0x00000001851761C0
	public static extern void ExternalSourceInfoArray_SetCodec(IntPtr pInfo, uint codec, int index); // 0x000000018517AA00-0x000000018517AB00
	public static extern void ExternalSourceInfoArray_SetFilePath(IntPtr pInfo, string value, int index); // 0x0000000185175380-0x0000000185175490
	public static extern void ExternalSourceInfoArray_SetInMemoryPtr(IntPtr pInfo, IntPtr ptr, int index); // 0x00000001851700E0-0x00000001851701E0
	public static extern void ExternalSourceInfoArray_SetMemorySize(IntPtr pInfo, uint size, int index); // 0x00000001851772F0-0x00000001851773F0
	public static extern void ExternalSourceInfoArray_SetFileId(IntPtr pInfo, uint id, int index); // 0x00000001851727D0-0x00000001851728D0
	public static extern IntPtr CreateNewDefaultSpatialAudioSettings(); // 0x0000000185177020-0x0000000185177100
	public static extern void DeleteSpatialAudioSettings(IntPtr pSetting); // 0x00000001851705B0-0x00000001851706A0
	public static extern void SpatialAudioSettings_SetPoolSize(IntPtr pSetting, uint value); // 0x000000018516E7E0-0x000000018516E8D0
	public static extern void SpatialAudioSettings_SetMaxProagationDepth(IntPtr pSetting, uint value); // 0x000000018516FCD0-0x000000018516FDC0
	public static extern void SpatialAudioSettings_SetDiffractionFlags(IntPtr pSettings, uint value); // 0x00000001851797E0-0x00000001851798D0
	public static extern IntPtr CreateNewDefaultEmitterSettings(); // 0x0000000185173990-0x0000000185173A70
	public static extern void DeleteEmitterSettings(IntPtr pSettings); // 0x0000000185178AC0-0x0000000185178BB0
	public static extern void SpatialEmitterSettings_SetReflectAuxBusID(IntPtr pSettings, uint value); // 0x00000001851785F0-0x00000001851786E0
	public static extern void SpatialEmitterSettings_SetReflectionMaxPathLength(IntPtr pSettings, float value); // 0x00000001851713E0-0x00000001851714E0
	public static extern void SpatialEmitterSettings_SetReflectionsAuxBusGain(IntPtr pSettings, float value); // 0x0000000185174EA0-0x0000000185174FA0
	public static extern void SpatialEmitterSettings_SetReflectionsOrder(IntPtr pSettings, uint value); // 0x0000000185175770-0x0000000185175860
	public static extern void SpatialEmitterSettings_SetReflectorFilterMask(IntPtr pSettings, uint value); // 0x000000018516F440-0x000000018516F530
	public static extern void SpatialEmitterSettings_SetRoomReverbAuxBusGain(IntPtr pSettings, float value); // 0x00000001851728D0-0x00000001851729D0
	public static extern void SpatialEmitterSettings_SetDiffractionMaxEdges(IntPtr pSettings, uint value); // 0x00000001851799D0-0x0000000185179AC0
	public static extern void SpatialEmitterSettings_SetDiffractionMaxPaths(IntPtr pSettings, uint value); // 0x0000000185170A60-0x0000000185170B50
	public static extern void SpatialEmitterSettings_SetDiffractionMaxPathLength(IntPtr pSettings, float value); // 0x0000000185178BB0-0x0000000185178CB0
	public static extern void SpatialEmitterSettings_SetUseImageSources(IntPtr pSettings, byte value); // 0x00000001851704B0-0x00000001851705B0
	public static extern IntPtr CreateNewDefaultRoomParams(); // 0x0000000185173D30-0x0000000185173E10
	public static extern void DeleteRoomParams(IntPtr pParams); // 0x0000000185173160-0x0000000185173250
	public static extern void RoomParams_SetUp(IntPtr pParams, float x, float y, float z); // 0x00000001851784E0-0x00000001851785F0
	public static extern void RoomParams_SetFront(IntPtr pParams, float x, float y, float z); // 0x000000018516F330-0x000000018516F440
	public static extern void RoomParams_SetReverbAuxBus(IntPtr pParams, uint value); // 0x00000001851773F0-0x00000001851774E0
	public static extern void RoomParams_SetReverbLevel(IntPtr pParams, float value); // 0x000000018516EE60-0x000000018516EF60
	public static extern void RoomParams_SetWallOcclusion(IntPtr pParams, float value); // 0x00000001851725D0-0x00000001851726D0
	public static extern void RoomParams_SetStrName(IntPtr pParams, string value); // 0x00000001851782F0-0x00000001851783F0
	public static extern void RoomParams_SetRoomGameObj_AuxSendLevelToSelf(IntPtr pParams, float value); // 0x0000000185171EF0-0x0000000185171FF0
	public static extern void RoomParams_SetRoomGameObj_KeepRegistered(IntPtr pParams, bool value); // 0x00000001851747A0-0x00000001851748A0
	public static extern IntPtr CreateNewDefaultPortalParams(); // 0x0000000185179610-0x00000001851796F0
	public static extern void DeletePortalParams(IntPtr pParams); // 0x00000001851762D0-0x00000001851763C0
	public static extern void PortalParams_SetTransform(IntPtr pParams, float x, float y, float z, float fx, float fy, float fz, float tx, float ty, float tz); // 0x0000000185173340-0x00000001851734C0
	public static extern void PortalParams_SetExtent(IntPtr pParams, float x, float y, float z); // 0x0000000185172AC0-0x0000000185172BD0
	public static extern void PortalParams_SetEnabled(IntPtr pParams, bool value); // 0x0000000185178DB0-0x0000000185178EB0
	public static extern void PortalParams_SetName(IntPtr pParams, string value); // 0x0000000185175280-0x0000000185175380
	public static extern void PortalParams_SetFrontRoom(IntPtr pParams, ulong value); // 0x0000000185177E40-0x0000000185177F40
	public static extern void PortalParams_SetBackRoom(IntPtr pParams, ulong value); // 0x00000001851706A0-0x00000001851707A0
	public static extern int RegisterEmitter(ulong gameObjectId, IntPtr pParams); // 0x00000001851724D0-0x00000001851725D0
	public static extern int UnregisterEmitter(ulong gameObjectId); // 0x000000018516EC80-0x000000018516ED70
	public static extern int RegisterListener(ulong gameObjectId); // 0x0000000185179AC0-0x0000000185179BB0
	public static extern int UnregisterListener(ulong gameObjectId); // 0x00000001851703C0-0x00000001851704B0
	public static extern int SetRoom(ulong roomId, IntPtr pParams); // 0x00000001851717F0-0x00000001851718F0
	public static extern int RemoveRoom(ulong roomId); // 0x0000000185174350-0x0000000185174440
	public static extern int SetPortal(ulong portalId, IntPtr pParams); // 0x0000000185173060-0x0000000185173160
	public static extern int RemovePortal(ulong portalId); // 0x0000000185178EB0-0x0000000185178FA0
	public static extern int SetGameObjectInRoom(ulong gameObjectId, ulong roomId); // 0x000000018517A810-0x000000018517A910
	public static extern IntPtr MMAlloc(ulong size); // 0x000000018517A350-0x000000018517A440
	public static extern void MMFree(IntPtr ptr); // 0x000000018516F150-0x000000018516F240
	public static extern float GetCpuUsage(); // 0x0000000185173E10-0x0000000185173EF0
}

