/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class WwiseInterface // TypeDefIndex: 11545
{
	// Fields
	private readonly Dictionary<int, EventCallbackPackage> _eventCookieMap; // 0x10
	private readonly Dictionary<int, BankCallbackPackage> _loadBankCookieMap; // 0x18
	private readonly Dictionary<int, BankCallbackPackage> _unloadBankCookieMap; // 0x20
	private bool _isEngineInitialized; // 0x28

	// Properties
	public bool isEngineInitialized { /* [XID] */ /* 0x00000001896A6C80-0x00000001896A6CA0 */ get => default; } // 0x0000000183B4E1D0-0x0000000183B4E280 
	public bool asyncBankHandling { /* [XID] */ /* 0x0000000189986910-0x0000000189986950 */ get; /* [XID] */ /* 0x0000000189991750-0x0000000189991790 */ set; } // 0x0000000183B4AAE0-0x0000000183B4AB40 0x0000000183B4D7A0-0x0000000183B4D800

	// Constructors
	public WwiseInterface() {} // 0x0000000183B4E900-0x0000000183B4EA10

	// Methods
	// [XID] // 0x000000018999C170-0x000000018999C190
	public bool Initialize(MmoronMemorySettings memorySettings, MmoronStreamingSettings streamingSettings, MmoronDeviceSettings deviceSettings, MmoronInitSettings initSettings, MmoronPlatformSettings platformSettings, MmoronMusicSettings musicSettings, MmoronSpatialAudioSettings spatialSettings, MmoronCustomSettings customSettings) => default; // 0x0000000183B4D0D0-0x0000000183B4D270
	// [XID] // 0x00000001899A3AA0-0x00000001899A3AC0
	public void SetBasePath(string path) {} // 0x0000000183B4E750-0x0000000183B4E810
	// [XID] // 0x0000000189A491D0-0x0000000189A491F0
	public void AddBasePath(string path) {} // 0x0000000183B4D330-0x0000000183B4D3F0
	// [XID] // 0x000000018982FCB0-0x000000018982FCD0
	public void SetCurrentLanguage(string language) {} // 0x0000000183B4C4D0-0x0000000183B4C590
	// [XID] // 0x00000001899BA190-0x00000001899BA1B0
	public void RenderAudio() {} // 0x0000000183B4E6B0-0x0000000183B4E750
	// [XID] // 0x00000001899C1CE0-0x00000001899C1D00
	public void Terminate() {} // 0x0000000183B4E530-0x0000000183B4E5E0
	// [XID] // 0x00000001899C90E0-0x00000001899C9100
	public void Suspend() {} // 0x0000000183B4D800-0x0000000183B4D8C0
	// [XID] // 0x00000001899D0C80-0x00000001899D0CA0
	public void Resume() {} // 0x0000000183B4D270-0x0000000183B4D330
	// [XID] // 0x00000001899D8010-0x00000001899D8030
	public void RegisterAuxDevices(string motionShareSetName, string controllerSpeakerShareSetName) {} // 0x0000000183B4E0E0-0x0000000183B4E1D0
	// [IDTag] // 0x00000001899DF620-0x00000001899DF660
	// [XID] // 0x00000001899DF620-0x00000001899DF660
	public void RegisterGameObject(ulong gameObjectId) {} // 0x0000000183B4CFF0-0x0000000183B4D0D0
	// [IDTag] // 0x00000001899E9DB0-0x00000001899E9DF0
	// [XID] // 0x00000001899E9DB0-0x00000001899E9DF0
	public void RegisterGameObject(ulong gameObjectId, string name) {} // 0x0000000183B4CF00-0x0000000183B4CFF0
	// [XID] // 0x00000001899F4B00-0x00000001899F4B20
	public void UnregisterGameObject(ulong gameObjectId) {} // 0x0000000183B4DCF0-0x0000000183B4DDD0
	// [XID] // 0x00000001899FC0E0-0x00000001899FC100
	public void AddDefaultListener(ulong gameObjectId) {} // 0x0000000183B4B560-0x0000000183B4B640
	// [XID] // 0x0000000189A03510-0x0000000189A03530
	public void RemoveDefaultListener(ulong gameObjectId) {} // 0x0000000183B4DA50-0x0000000183B4DB30
	// [XID] // 0x000000018991E320-0x000000018991E340
	public void SetToUseListener(ulong emitterId, ulong listenerId) {} // 0x0000000183B4B640-0x0000000183B4B730
	// [XID] // 0x0000000189A12380-0x0000000189A123A0
	public void SetToUseDefaultListener(ulong emitterId) {} // 0x0000000183B4A860-0x0000000183B4A940
	// [XID] // 0x00000001898E9BC0-0x00000001898E9BE0
	public void SetListenerVolumeOffset(ulong listenerId, float offset) {} // 0x0000000183B4BA30-0x0000000183B4BB20
	// [XID] // 0x0000000189A20E50-0x0000000189A20E70
	public void UpdateGameObjectTransform(ulong gameObjectId, Vector3 position, Quaternion rotation) {} // 0x0000000183B4B210-0x0000000183B4B490
	// [XID] // 0x0000000189A28140-0x0000000189A28160
	public void SetMultiPositions(ulong gameObjectId, AudioPositionArray positionArray, AkMultiPositionType multiPositionType) {} // 0x0000000183B4BB20-0x0000000183B4BC70
	// [IDTag] // 0x0000000189A2F8F0-0x0000000189A2F930
	// [XID] // 0x0000000189A2F8F0-0x0000000189A2F930
	public void SetRtpcValue(uint hashId, float value, ulong gameObjectId) {} // 0x0000000183B4C0D0-0x0000000183B4C1E0
	// [IDTag] // 0x0000000189A3A110-0x0000000189A3A150
	// [XID] // 0x0000000189A3A110-0x0000000189A3A150
	public void SetRtpcValue(uint hashId, float value) {} // 0x0000000183B4BFD0-0x0000000183B4C0D0
	// [XID] // 0x0000000189A44890-0x0000000189A448B0
	public void SetSwitch(uint nameId, uint valueId, ulong gameObjectId) {} // 0x0000000183B4E280-0x0000000183B4E390
	// [XID] // 0x0000000189A703F0-0x0000000189A70410
	public void SetState(uint nameId, uint valueId) {} // 0x0000000183B4B840-0x0000000183B4B940
	// [XID] // 0x0000000189A536D0-0x0000000189A536F0
	public void PostTrigger(uint nameId, ulong gameObjectId) {} // 0x0000000183B4BED0-0x0000000183B4BFD0
	// [XID] // 0x00000001897C8B40-0x00000001897C8B60
	public void SetObstructionOcclusion(ulong sourceId, ulong listenerId, float obstruction, float occlusion) {} // 0x0000000183B4C3A0-0x0000000183B4C4D0
	// [XID] // 0x0000000189A626C0-0x0000000189A626E0
	public uint PostGlobalEvent(uint eventId) => default; // 0x0000000183B4D3F0-0x0000000183B4D4E0
	// [IDTag] // 0x0000000189A6A480-0x0000000189A6A4C0
	// [XID] // 0x0000000189A6A480-0x0000000189A6A4C0
	public uint PostEvent(uint eventId, ulong gameObjectId) => default; // 0x0000000183B4C9A0-0x0000000183B4CAA0
	// [IDTag] // 0x0000000189A74800-0x0000000189A74840
	// [XID] // 0x0000000189A74800-0x0000000189A74840
	public uint PostEvent(uint eventId, ulong gameObjectId, uint flags, LowLevelEventCallback callback, int cookie, MmoronExternalSourceInfoArray externalSources, uint playingId, bool prependLanguage) => default; // 0x0000000183B4CAA0-0x0000000183B4CCF0
	// [XID] // 0x0000000189BB1B60-0x0000000189BB1B80
	public void StopPlayingId(uint playingId) {} // 0x0000000183B4D8C0-0x0000000183B4D990
	// [IDTag] // 0x0000000189A86A60-0x0000000189A86AA0
	// [XID] // 0x0000000189A86A60-0x0000000189A86AA0
	public void StopAll(ulong gameObjectId) {} // 0x0000000183B4BE10-0x0000000183B4BED0
	// [IDTag] // 0x0000000189A914E0-0x0000000189A91520
	// [XID] // 0x0000000189A914E0-0x0000000189A91520
	public void StopAll() {} // 0x0000000183B4BD60-0x0000000183B4BE10
	// [XID] // 0x0000000189A9BBA0-0x0000000189A9BBC0
	public bool GetBackgroundMusicMute() => default; // 0x0000000183B4D990-0x0000000183B4DA50
	// [XID] // 0x0000000189AA30A0-0x0000000189AA30C0
	public void MuteBackgroundMusic(bool mute) {} // 0x0000000183B4D4E0-0x0000000183B4D5B0
	// [XID] // 0x0000000189AAA550-0x0000000189AAA570
	public void SeekOnEvent(uint eventId, ulong gameObjectId, int position, bool seekToNearestMarker, uint playingId) {} // 0x0000000183B4CCF0-0x0000000183B4CE30
	// [XID] // 0x0000000189AB2410-0x0000000189AB2430
	public void LoadFilePackageSeries(string filePackageNameBase, string filePackageExt, byte countLg2) {} // 0x0000000183B4B730-0x0000000183B4B840
	// [XID] // 0x0000000189AB9860-0x0000000189AB9880
	public void LoadFilePackage(string filePackageName, out uint packageId) {
		packageId = default;
	} // 0x0000000183B4AB40-0x0000000183B4AC50
	// [XID] // 0x0000000189AC1430-0x0000000189AC1450
	public void UnloadFilePackage(uint packageId) {} // 0x0000000183B4B130-0x0000000183B4B210
	// [XID] // 0x0000000189AC8D00-0x0000000189AC8D20
	public void UnloadAllFilePackages() {} // 0x0000000183B4E5E0-0x0000000183B4E6B0
	// [XID] // 0x0000000189AD04A0-0x0000000189AD04C0
	public bool CheckBankExistence(uint bankId) => default; // 0x0000000183B4C1E0-0x0000000183B4C2B0
	// [XID] // 0x0000000189AD8190-0x0000000189AD81B0
	public bool CheckExternalFileExistence(ulong fileId) => default; // 0x0000000183B4AA10-0x0000000183B4AAE0
	// [IDTag] // 0x0000000189ADFE40-0x0000000189ADFE80
	// [XID] // 0x0000000189ADFE40-0x0000000189ADFE80
	public void LoadSoundBank(uint bankId, BankCallback callback, object cookie) {} // 0x0000000183B4DDD0-0x0000000183B4DF40
	// [IDTag] // 0x0000000189AEA3B0-0x0000000189AEA3F0
	// [XID] // 0x0000000189AEA3B0-0x0000000189AEA3F0
	public void LoadSoundBank(uint bankId) {} // 0x0000000183B4DF40-0x0000000183B4E020
	// [IDTag] // 0x00000001898E6600-0x00000001898E6640
	// [XID] // 0x00000001898E6600-0x00000001898E6640
	public void UnloadSoundBank(uint bankId, BankCallback callback, object cookie) {} // 0x0000000183B4AD20-0x0000000183B4AE90
	// [IDTag] // 0x0000000189AFF470-0x0000000189AFF4B0
	// [XID] // 0x0000000189AFF470-0x0000000189AFF4B0
	public void UnloadSoundBank(uint bankId) {} // 0x0000000183B4AC50-0x0000000183B4AD20
	// [XID] // 0x0000000189B09C00-0x0000000189B09C20
	public void SetMonitoringLevel(AkMonitorErrorLevel errorLevel) {} // 0x0000000183B4E020-0x0000000183B4E0E0
	// [XID] // 0x0000000189B11680-0x0000000189B116A0
	public void PostEventCallbacks() {} // 0x0000000183B4C640-0x0000000183B4C9A0
	// [XID] // 0x0000000189B187D0-0x0000000189B187F0
	public void PostBankCallbacks() {} // 0x0000000183B4AE90-0x0000000183B4B130
	// [XID] // 0x0000000189B1FEF0-0x0000000189B1FF10
	public void HandleMonitorMessages(IMmoronMonitorMessageHandler handler) {} // 0x0000000183B4DB30-0x0000000183B4DCF0
	// [XID] // 0x0000000189B27600-0x0000000189B27620
	public void RegisterEmitter(ulong gameObjectId, MmoronEmitterSettings settings) {} // 0x0000000183B4BC70-0x0000000183B4BD60
	// [XID] // 0x0000000189B2E8A0-0x0000000189B2E8C0
	public void UnregisterEmitter(ulong gameObjectId) {} // 0x0000000183B4A940-0x0000000183B4AA10
	// [XID] // 0x0000000189B35F70-0x0000000189B35F90
	public void RegisterSpatialListener(ulong gameObjectId) {} // 0x0000000183B4B490-0x0000000183B4B560
	// [XID] // 0x0000000189B3D620-0x0000000189B3D640
	public void UnregisterSpatialListener(ulong gameObjectId) {} // 0x0000000183B4E390-0x0000000183B4E460
	// [XID] // 0x0000000189B455A0-0x0000000189B455C0
	public void SetRoom(ulong roomId, MmoronRoomParams @params) {} // 0x0000000183B4B940-0x0000000183B4BA30
	// [XID] // 0x0000000189B4CAD0-0x0000000189B4CAF0
	public void RemoveRoom(ulong roomId) {} // 0x0000000183B4CE30-0x0000000183B4CF00
	// [XID] // 0x0000000189B302F0-0x0000000189B30310
	public void SetPortal(ulong portalId, MmoronPortalParams @params) {} // 0x0000000183B4C2B0-0x0000000183B4C3A0
	// [XID] // 0x0000000189B5BCA0-0x0000000189B5BCC0
	public void RemovePortal(ulong portalId) {} // 0x0000000183B4E460-0x0000000183B4E530
	// [XID] // 0x000000018964E3E0-0x000000018964E400
	public void SetGameObjectInRoom(ulong gameObjectId, ulong roomId) {} // 0x0000000183B4E810-0x0000000183B4E900
	// [XID] // 0x0000000189B6AA30-0x0000000189B6AA50
	public float GetCpuUsage() => default; // 0x0000000183B4C590-0x0000000183B4C640
	private int AddCallbackCookie<TC, TK, TP>(TC callback, TK cookie, Dictionary<int, TP> jar)
		where TC : class
		where TP : CallbackPackage<TC, TK>, new() => default;
	// [XID] // 0x0000000189B72240-0x0000000189B72260
	private void WatchResult(AkResult r) {} // 0x0000000183B4D5B0-0x0000000183B4D7A0
}

