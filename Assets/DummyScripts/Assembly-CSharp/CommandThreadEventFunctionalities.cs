/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CommandThreadEventFunctionalities : CommandThreadFunctionalities<SharedEventFunctionalities> // TypeDefIndex: 11287
{
	// Fields
	private readonly AudioMultiPositionEventTicker _mpEventTicker; // 0x20
	private readonly PeriodicMultiPositionEventTicker _periodicMpEventTicker; // 0x28
	private readonly UnsignedDumbAutoIncreaser _postIdDealer; // 0x30
	private readonly Dictionary<uint, uint> _postIdToPlayingIdLut; // 0x38
	private readonly Dictionary<uint, uint> _playingIdToPostIdLut; // 0x40
	private readonly Dictionary<uint, EventStartCallback> _pendingCallbacks; // 0x48

	// Properties
	public int workerTickInfoFrame { /* [XID] */ /* 0x0000000189899D90-0x0000000189899DD0 */ get; /* [XID] */ /* 0x00000001898A4220-0x00000001898A4260 */ private set; } // 0x00000001835D02F0-0x00000001835D0350 0x00000001835CEE90-0x00000001835CEEF0
	public int workerTickInfoSuccessCount { /* [XID] */ /* 0x00000001898AE9A0-0x00000001898AE9E0 */ get; /* [XID] */ /* 0x00000001898B91E0-0x00000001898B9220 */ private set; } // 0x00000001835D0350-0x00000001835D03B0 0x00000001835D0830-0x00000001835D0890
	public int workerTickInfoFailCount { /* [XID] */ /* 0x00000001898C35B0-0x00000001898C35F0 */ get; /* [XID] */ /* 0x00000001898CDC30-0x00000001898CDC70 */ private set; } // 0x00000001835CFBD0-0x00000001835CFC30 0x00000001835CFEF0-0x00000001835CFF50
	public int workerTickInfoWaitCount { /* [XID] */ /* 0x00000001898D8620-0x00000001898D8660 */ get; /* [XID] */ /* 0x00000001898E3180-0x00000001898E31C0 */ private set; } // 0x00000001835CEE30-0x00000001835CEE90 0x00000001835D0290-0x00000001835D02F0
	public int playingCount { /* [XID] */ /* 0x0000000189646AC0-0x0000000189646AE0 */ get => default; } // 0x00000001835CFD50-0x00000001835CFE10 

	// Constructors
	public CommandThreadEventFunctionalities() {} // Dummy constructor
	public CommandThreadEventFunctionalities(CommandThreadContext context, SharedEventFunctionalities shared) {} // 0x00000001835D0940-0x00000001835D0AB0

	// Methods
	// [XID] // 0x00000001896380A0-0x00000001896380C0
	public override void Init() {} // 0x00000001835CE910-0x00000001835CE9B0
	// [XID] // 0x000000018963F290-0x000000018963F2B0
	public override void Tick(float deltaTime) {} // 0x00000001835CE9B0-0x00000001835CEAA0
	// [XID] // 0x000000018999DC80-0x000000018999DCA0
	public override void EnterHomeWorld(bool firstTime) {} // 0x00000001835CF7A0-0x00000001835CF850
	// [XID] // 0x000000018990BF20-0x000000018990BF40
	public override void ExitHomeWorld() {} // 0x00000001835D03B0-0x00000001835D0450
	// [XID] // 0x0000000189913900-0x0000000189913920
	public override void ExitGameWorld() {} // 0x00000001835D01B0-0x00000001835D0290
	// [XID] // 0x000000018965BC90-0x000000018965BCB0
	public override void CreateLevel() {} // 0x00000001835CD4E0-0x00000001835CD580
	// [XID] // 0x0000000189922830-0x0000000189922850
	public override void EnterLevel() {} // 0x00000001835CEFD0-0x00000001835CF070
	// [XID] // 0x0000000189929FE0-0x000000018992A000
	public override void ExitLevel() {} // 0x00000001835CE830-0x00000001835CE910
	// [XID] // 0x000000018968A9C0-0x000000018968A9E0
	public override void DumpCriticalInfo(StringBuilder builder) {} // 0x00000001835D0890-0x00000001835D0940
	// [XID] // 0x0000000189938DC0-0x0000000189938DE0
	public override void Destroy() {} // 0x00000001835CE430-0x00000001835CE4D0
	// [XID] // 0x00000001899405B0-0x00000001899405D0
	public void Stop() {} // 0x00000001835CD2E0-0x00000001835CD3C0
	// [XID] // 0x0000000189947C10-0x0000000189947C30
	public AudioPostedEventStatus PostEventAsync(uint eventId, SyncId syncId) => default; // 0x00000001835CE5B0-0x00000001835CE740
	// [IDTag] // 0x000000018994F2F0-0x000000018994F330
	// [XID] // 0x000000018994F2F0-0x000000018994F330
	public AudioPostedEventStatus PostOneTimeEventAsync(OneTimeEventParams @params) => default; // 0x00000001835CD850-0x00000001835CD9A0
	// [IDTag] // 0x0000000189959A10-0x0000000189959A50
	// [XID] // 0x0000000189959A10-0x0000000189959A50
	public AudioPostedEventStatus PostOneTimeEventAsync(OneTimeEventParams @params, AudioCombinedSwitches switches) => default; // 0x00000001835CD9A0-0x00000001835CE430
	// [XID] // 0x000000018978E820-0x000000018978E840
	public void PostMultiPositionEvent(uint eventId) {} // 0x00000001835CFF50-0x00000001835D01B0
	// [IDTag] // 0x000000018996B950-0x000000018996B990
	// [XID] // 0x000000018996B950-0x000000018996B990
	public AudioPostedEventStatus PostEventWithCallbackAsync(object cookie, uint eventId, SyncId syncId, EventStartCallback startCallback, EventCallback callback, AkCallbackType callbackMask) => default; // 0x00000001835CF540-0x00000001835CF7A0
	// [IDTag] // 0x00000001899762D0-0x0000000189976310
	// [XID] // 0x00000001899762D0-0x0000000189976310
	public AudioPostedEventStatus PostEventWithCallbackAsync(object cookie, uint eventId, SyncId syncId, EventStartCallback startCallback, EventCallback callback, AkCallbackType callbackMask, string externalSourceName, uint externalSoundCookie) => default; // 0x00000001835CF2A0-0x00000001835CF540
	// [IDTag] // 0x0000000189980940-0x0000000189980980
	// [XID] // 0x0000000189980940-0x0000000189980980
	public AudioPostedEventStatus PostEventWithCallbackAsync(EventParams @params) => default; // 0x00000001835CF070-0x00000001835CF2A0
	// [XID] // 0x000000018980A990-0x000000018980A9B0
	public void AbortPendingEvent(uint postId) {} // 0x00000001835CE740-0x00000001835CE830
	// [XID] // 0x0000000189993160-0x0000000189993180
	public AudioPostedEventStatus QueryEventStatus(uint postId) => default; // 0x00000001835CD6A0-0x00000001835CD850
	// [XID] // 0x00000001896AF770-0x00000001896AF790
	public void PauseOrResumeInGameBuses(bool pause) {} // 0x00000001835CEC70-0x00000001835CED50
	// [XID] // 0x00000001899A23D0-0x00000001899A23F0
	public void PauseOrResuemeEventsOnSync(bool pause, SyncId syncId) {} // 0x00000001835CD580-0x00000001835CD6A0
	// [XID] // 0x00000001899A9BE0-0x00000001899A9C00
	public void AddToMultiPositionEventSources(Transform t, uint eventId, AkMultiPositionType multiPositionType) {} // 0x00000001835CFAA0-0x00000001835CFBD0
	// [XID] // 0x00000001899B15E0-0x00000001899B1600
	public void RemoveFromMultiPositionEventSources(Transform t, uint eventId) {} // 0x00000001835CFC30-0x00000001835CFD50
	// [XID] // 0x00000001899B8AE0-0x00000001899B8B00
	public void AddPeriodicMultiPositionEventSpot(uint startEventId, float duration, Vector3 position, uint endEventId, AkMultiPositionType multiPositionType) {} // 0x00000001835D05E0-0x00000001835D0730
	// [XID] // 0x0000000189795F50-0x0000000189795F70
	public void RemoveFromPending(uint postId, uint playingId) {} // 0x00000001835CF980-0x00000001835CFAA0
	// [XID] // 0x000000018975A200-0x000000018975A220
	public void StartPlaying(EventIdPair idPair) {} // 0x00000001835CF850-0x00000001835CF980
	// [XID] // 0x00000001899CF410-0x00000001899CF430
	public void FinishPlaying(uint playingId) {} // 0x00000001835CD3C0-0x00000001835CD4E0
	// [XID] // 0x00000001899D6950-0x00000001899D6970
	public void InvokeCallback(EventCallback callback, object cookie, AkCallbackType callbackType, MmoronCallbackInfo callbackInfo) {} // 0x00000001835D0450-0x00000001835D05E0
	// [XID] // 0x00000001899DDF30-0x00000001899DDF50
	public void AddRuleCullingNameContain(string pattern) {} // 0x00000001835CED50-0x00000001835CEE30
	// [XID] // 0x00000001899E5D00-0x00000001899E5D20
	public void AddRuleCullingNameNotContain(string pattern) {} // 0x00000001835CFE10-0x00000001835CFEF0
	// [XID] // 0x00000001899ECD80-0x00000001899ECDA0
	public void ReloadEventCulling() {} // 0x00000001835CE4D0-0x00000001835CE5B0
	// [XID] // 0x00000001899F4B20-0x00000001899F4B40
	public void ClearEventCullingRules() {} // 0x00000001835CEEF0-0x00000001835CEFD0
	// [XID] // 0x000000018961B4A0-0x000000018961B4C0
	public void UpdateWorkerPendingInfo(int frame, int success, int fail, int wait) {} // 0x00000001835CEAA0-0x00000001835CEC70
	// [Conditional] // 0x0000000189A03590-0x0000000189A035E0
	// [XID] // 0x0000000189A03590-0x0000000189A035E0
	private void SetEventNameAsSyncName(ref SyncId syncId, uint eventId) {} // 0x00000001835D0730-0x00000001835D0830
}

