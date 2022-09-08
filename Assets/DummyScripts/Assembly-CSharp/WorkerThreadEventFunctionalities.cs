/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorkerThreadEventFunctionalities : WorkerThreadFunctionalities<SharedEventFunctionalities> // TypeDefIndex: 11313
{
	// Fields
	private readonly AudioOngoingEventCollection _ongoingEvents; // 0x20
	private readonly AudioSyncInfluencer _syncInfluencer; // 0x28
	private readonly EventCulling _eventCulling; // 0x30
	private readonly RecycledLinkedList<PendingEvent> _eventQueue; // 0x38
	private readonly LowLevelEventCallback _eventCallback; // 0x40
	private readonly PostEventCallback _postEventCallback; // 0x48
	private readonly List<EventInstance> _reusedEventList; // 0x50
	private readonly List<uint> _reusedBankIdList; // 0x58
	private MmoronCodecId _externalSourceCodecId; // 0x60
	private int _currentFrameSuccessCount; // 0x64
	private int _currentFrameFailCount; // 0x68
	private int _currentFrameWaitCount; // 0x6C

	// Nested types
	private enum PendingEventOutcome // TypeDefIndex: 11314
	{
		Success = 0,
		Wait = 1,
		Failure = 2
	}

	private struct PostEventResult // TypeDefIndex: 11315
	{
		// Fields
		private static readonly PostEventResult _wait; // 0x00
		private static readonly PostEventResult _failure; // 0x08

		// Properties
		public static PostEventResult wait { /* [XID] */ /* 0x0000000189A67370-0x0000000189A67390 */ get => default; } // 0x0000000184986C70-0x0000000184986D40 
		public static PostEventResult failure { /* [XID] */ /* 0x0000000189A6E9C0-0x0000000189A6E9E0 */ get => default; } // 0x0000000184986D40-0x0000000184986E10 
		public PendingEventOutcome outcome { /* [XID] */ /* 0x0000000189A76290-0x0000000189A762D0 */ get; /* [XID] */ /* 0x0000000189A80A40-0x0000000189A80A80 */ set; } // 0x0000000184986BB0-0x0000000184986C10 0x0000000184986A20-0x0000000184986A80
		public uint playingId { /* [XID] */ /* 0x0000000189A8B690-0x0000000189A8B6D0 */ get; /* [XID] */ /* 0x0000000189A95AB0-0x0000000189A95AF0 */ set; } // 0x0000000184986C10-0x0000000184986C70 0x0000000184986E10-0x0000000184986E70

		// Constructors
		static PostEventResult() {
			_wait = default;
			_failure = default;
		} // 0x0000000184986E70-0x0000000184987000

		// Methods
		// [XID] // 0x0000000189B98970-0x0000000189B98990
		public static PostEventResult NewSuccessful(uint playingId) => default; // 0x0000000184986A80-0x0000000184986BB0
	}

	private static class DumbAutoIncreaser // TypeDefIndex: 11316
	{
		// Fields
		private static int _ai; // 0x00

		// Constructors
		static DumbAutoIncreaser() {} // 0x00000001849A9060-0x00000001849A90C0

		// Methods
		// [XID] // 0x0000000189AA7A10-0x0000000189AA7A30
		public static int Next() => default; // 0x00000001849A8F90-0x00000001849A9060
	}

	// Constructors
	public WorkerThreadEventFunctionalities() {} // Dummy constructor
	public WorkerThreadEventFunctionalities(WorkerThreadContext context, SharedEventFunctionalities shared) {} // 0x000000018499D960-0x000000018499DB20

	// Methods
	// [XID] // 0x0000000189613C40-0x0000000189613C60
	public override void Init() {} // 0x000000018499B790-0x000000018499B870
	// [XID] // 0x0000000189982690-0x00000001899826B0
	public override void Tick(TimeSpan deltaTime) {} // 0x000000018499B870-0x000000018499B940
	// [XID] // 0x0000000189A629A0-0x0000000189A629C0
	public override void Destroy() {} // 0x000000018499AD60-0x000000018499AE00
	// [XID] // 0x00000001899917D0-0x00000001899917F0
	public void AbortPendingEvent(uint postId) {} // 0x000000018499B3E0-0x000000018499B650
	// [XID] // 0x0000000189999220-0x0000000189999240
	public void DropPendingEvents() {} // 0x000000018499ABB0-0x000000018499AD60
	// [IDTag] // 0x00000001899A0B50-0x00000001899A0B90
	// [XID] // 0x00000001899A0B50-0x00000001899A0B90
	public void PostEventWithCallback(EventParams @params, uint postId) {} // 0x000000018499C740-0x000000018499C900
	// [IDTag] // 0x00000001899AB610-0x00000001899AB650
	// [XID] // 0x00000001899AB610-0x00000001899AB650
	public void PostEventWithCallback(EventParams @params, PostEventCallback callback) {} // 0x000000018499C900-0x000000018499CAB0
	// [XID] // 0x000000018983D3B0-0x000000018983D3D0
	public void RespondToSwitchChange(uint switchId, SyncId syncId) {} // 0x000000018499B650-0x000000018499B790
	// [XID] // 0x0000000189A94470-0x0000000189A94490
	public void RespondToStateChange(uint stateId) {} // 0x000000018499AE00-0x000000018499AEF0
	// [XID] // 0x00000001899C4D10-0x00000001899C4D30
	public void PauseOrResumeInGameBuses(bool pause) {} // 0x000000018499B940-0x000000018499BA80
	// [XID] // 0x000000018972D7B0-0x000000018972D7D0
	public void PauseOrResumeEventsOnSync(bool pause, SyncId syncId) {} // 0x000000018499CCD0-0x000000018499CEA0
	// [XID] // 0x00000001899D3A80-0x00000001899D3AA0
	public void AddRuleCullingNameContain(string pattern) {} // 0x000000018499BA80-0x000000018499BB40
	// [XID] // 0x00000001896F9390-0x00000001896F93B0
	public void AddRuleCullingNameNotContain(string pattern) {} // 0x000000018499BD20-0x000000018499BDE0
	// [XID] // 0x0000000189907AB0-0x0000000189907AD0
	public void ReloadEventCulling() {} // 0x000000018499AEF0-0x000000018499AFA0
	// [XID] // 0x0000000189761FA0-0x0000000189761FC0
	public void ClearEventCullingRules() {} // 0x000000018499BC70-0x000000018499BD20
	// [XID] // 0x0000000189A95E20-0x0000000189A95E40
	private void PostOrQueue(PendingEvent pendingEvent) {} // 0x000000018499C150-0x000000018499C500
	// [XID] // 0x00000001899F8E10-0x00000001899F8E30
	private void TickPostPendingEvents() {} // 0x000000018499A250-0x000000018499A720
	// [XID] // 0x0000000189AC30B0-0x0000000189AC30D0
	private PostEventResult TickPostPendingEvent(PendingEvent pending) => default; // 0x000000018499CEA0-0x000000018499D960
	// [XID] // 0x00000001896BB5E0-0x00000001896BB600
	private void InvokePostEventCallback(PendingEvent pendingEvent, uint playingId) {} // 0x000000018499C500-0x000000018499C740
	// [XID] // 0x0000000189A0F1A0-0x0000000189A0F1C0
	private void PostEventCallback(uint eventId, SyncId syncId, uint playingId, uint postId) {} // 0x000000018499B2C0-0x000000018499B3E0
	// [XID] // 0x0000000189B73930-0x0000000189B73950
	private void EventCallback(int cookie, AkCallbackType type, MmoronCallbackInfo info) {} // 0x000000018499AFA0-0x000000018499B2C0
	// [XID] // 0x0000000189A1DCA0-0x0000000189A1DCC0
	private AudioOngoingEvent StartOngoingEvent(EventParams @params, List<uint> soundBanks) => default; // 0x000000018499A720-0x000000018499AAB0
	// [XID] // 0x0000000189A25330-0x0000000189A25350
	private void EndOngoingEvent(AudioOngoingEvent ongoingEvent) {} // 0x000000018499BF50-0x000000018499C150
	// [XID] // 0x0000000189A2C960-0x0000000189A2C980
	private void ReportRemovePendingPostId(uint postId, uint playingId) {} // 0x000000018499AAB0-0x000000018499ABB0
	// [XID] // 0x0000000189A34000-0x0000000189A34020
	private void ReportStartPlaying(uint postId, uint playingId) {} // 0x000000018499BB40-0x000000018499BC70
	// [XID] // 0x000000018967FEF0-0x000000018967FF10
	private void ReportFinishPlaying(uint playingId) {} // 0x000000018499CAB0-0x000000018499CB90
	// [XID] // 0x0000000189A432C0-0x0000000189A432E0
	private void ReportTickPendingEventInfo(int success, int fail, int wait) {} // 0x000000018499CB90-0x000000018499CCD0
	// [XID] // 0x0000000189A4A790-0x0000000189A4A7B0
	private void CheckForAdditionalSoundBanks(List<EventInstance> eventInstances) {} // 0x000000018499BDE0-0x000000018499BF50
}

