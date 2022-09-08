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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CommandThreadVoiceFunctionalities : CommandThreadFunctionalities<SharedVoiceFunctionalities>, IIntentionSubmitter // TypeDefIndex: 11449
{
	// Fields
	private const float MIN_POS_DELTA = 0.1f; // Metadata: 0x00AE98B7
	private readonly VoiceIdRegistration _idRegistration; // 0x20
	private readonly GlobalVoicePipeline _voicePipeline; // 0x28
	private readonly VoiceCallbackForwarder _callbackForwarder; // 0x30
	private readonly PlayerGenderDeductor _inLevelGenderTeller; // 0x38
	private readonly PlayerGenderDeductor _fallbackGenderTeller; // 0x40
	private readonly VoiceStubMonitor _gachaVoiceMonitor; // 0x48
	private readonly VoiceStubMonitor _joinTeamVocieMonitor; // 0x50
	private readonly TeamDifferentiater _teamDifferentiater; // 0x58
	private PlayerGenderDeductor _genderTeller; // 0x60
	private SyncTransform _fakeAvatarSync2d; // 0x68

	// Properties
	public VoiceIdRegistration idRegistration { /* [XID] */ /* 0x000000018990C150-0x000000018990C170 */ get => default; } // 0x00000001836632C0-0x0000000183663360 

	// Nested types
	private class VoiceCallbackForwarder : IExternalSourceVoiceStartResponder, IExternalSourceVoiceStopResponder // TypeDefIndex: 11450
	{
		// Fields
		private readonly Dictionary<ExternalSourceVoiceIntention, VoiceCallback> _startCallbackMap; // 0x10
		private readonly Dictionary<ExternalSourceVoiceIntention, VoiceCallback> _stopCallbackMap; // 0x18

		// Constructors
		public VoiceCallbackForwarder() {} // 0x0000000183644B90-0x0000000183644C40

		// Methods
		// [XID] // 0x00000001895E9BE0-0x00000001895E9C00
		public void RespondToExternalSourceVoiceStart(ExternalSourceVoiceIntention intention, int stub) {} // 0x0000000183644890-0x0000000183644970
		// [XID] // 0x00000001895F12C0-0x00000001895F12E0
		public void RespondToExternalSourceVoiceStop(ExternalSourceVoiceIntention intention, int stub) {} // 0x0000000183644AB0-0x0000000183644B90
		// [XID] // 0x00000001895F8E20-0x00000001895F8E40
		public void RegisterCallbacks(ExternalSourceVoiceIntention intention, VoiceCallback startCallback, VoiceCallback stopCallback) {} // 0x0000000183644970-0x0000000183644AB0
		// [XID] // 0x0000000189600150-0x0000000189600170
		private void TryInvokeCallback(ExternalSourceVoiceIntention intention, int stub, Dictionary<ExternalSourceVoiceIntention, VoiceCallback> callbackMap) {} // 0x0000000183644760-0x0000000183644890
	}

	private class VoiceStubMonitor // TypeDefIndex: 11451
	{
		// Fields
		private readonly CommandThreadVoiceFunctionalities _host; // 0x10
		private readonly VoiceCallback _startCallback; // 0x18
		private readonly VoiceCallback _stopCallback; // 0x20
		private int _stub; // 0x28

		// Properties
		public VoiceCallback startCallback { /* [XID] */ /* 0x0000000189607840-0x0000000189607860 */ get => default; } // 0x0000000183644C40-0x0000000183644CE0 
		public VoiceCallback stopCallback { /* [XID] */ /* 0x0000000189BB30A0-0x0000000189BB30C0 */ get => default; } // 0x0000000183644D90-0x0000000183644E30 

		// Constructors
		public VoiceStubMonitor() {} // Dummy constructor
		public VoiceStubMonitor(CommandThreadVoiceFunctionalities host) {} // 0x0000000183644FA0-0x0000000183645080

		// Methods
		// [XID] // 0x0000000189616950-0x0000000189616970
		public void StopCurrentPlaying() {} // 0x0000000183644EE0-0x0000000183644FA0
		// [XID] // 0x000000018961E200-0x000000018961E220
		private void OnVoiceStartPlaying(int stub) {} // 0x0000000183644CE0-0x0000000183644D90
		// [XID] // 0x0000000189625710-0x0000000189625730
		private void OnVoiceStopPlaying(int stub) {} // 0x0000000183644E30-0x0000000183644EE0
	}

	private class TeamDifferentiater // TypeDefIndex: 11452
	{
		// Fields
		private readonly List<ulong> _guidList; // 0x10
		private readonly List<AvatarExcelConfig> _confList; // 0x18

		// Constructors
		public TeamDifferentiater() {} // 0x00000001836457C0-0x0000000183645870

		// Methods
		// [XID] // 0x000000018960B060-0x000000018960B080
		public List<AvatarExcelConfig> SelectNewcommers(List<ulong> previousMembers, List<ulong> currentMembers) => default; // 0x00000001836451A0-0x00000001836452C0
		// [XID] // 0x0000000189634BA0-0x0000000189634BC0
		private void AddMemberIds(List<ulong> ids) {} // 0x0000000183645410-0x0000000183645530
		// [XID] // 0x0000000189BD89C0-0x0000000189BD89E0
		private void RemoveMemberIds(List<ulong> ids) {} // 0x00000001836456C0-0x00000001836457C0
		// [XID] // 0x0000000189B36260-0x0000000189B36280
		private void RemoveMemberId(ulong id) {} // 0x0000000183645530-0x00000001836456C0
		// [XID] // 0x000000018964AF60-0x000000018964AF80
		private void MapIdsToConfigs() {} // 0x0000000183645080-0x00000001836451A0
		// [XID] // 0x0000000189652720-0x0000000189652740
		private AvatarExcelConfig MapIdToConfig(ulong id) => default; // 0x00000001836452C0-0x0000000183645410
	}

	// Constructors
	public CommandThreadVoiceFunctionalities() {} // Dummy constructor
	public CommandThreadVoiceFunctionalities(CommandThreadContext context, SharedVoiceFunctionalities shared) {} // 0x0000000183663730-0x00000001836639A0

	// Methods
	// [XID] // 0x0000000189B0E430-0x0000000189B0E450
	public override void Init() {} // 0x0000000183662600-0x00000001836627A0
	// [XID] // 0x0000000189B155D0-0x0000000189B155F0
	public override void Tick(float deltaTime) {} // 0x00000001836627A0-0x0000000183662850
	// [XID] // 0x0000000189B1D050-0x0000000189B1D070
	public override void EnterHomeWorld(bool firstTime) {} // 0x0000000183662A50-0x0000000183662B00
	// [XID] // 0x00000001898CF8F0-0x00000001898CF910
	public override void ExitHomeWorld() {} // 0x0000000183662F10-0x0000000183662FB0
	// [XID] // 0x0000000189B2BAC0-0x0000000189B2BAE0
	public override void ExitGameWorld() {} // 0x0000000183662E70-0x0000000183662F10
	// [XID] // 0x0000000189B32F10-0x0000000189B32F30
	public override void CreateLevel() {} // 0x0000000183661D20-0x0000000183661DC0
	// [XID] // 0x00000001898C8140-0x00000001898C8160
	public override void EnterLevel() {} // 0x00000001836629B0-0x0000000183662A50
	// [XID] // 0x0000000189B42250-0x0000000189B42270
	public override void ExitLevel() {} // 0x0000000183662560-0x0000000183662600
	// [XID] // 0x00000001898B94A0-0x00000001898B94C0
	public override void DumpCriticalInfo(StringBuilder builder) {} // 0x00000001836631F0-0x00000001836632C0
	// [XID] // 0x0000000189867B90-0x0000000189867BB0
	public override void Destroy() {} // 0x0000000183662230-0x0000000183662350
	// [IDTag] // 0x0000000189B58D60-0x0000000189B58DA0
	// [XID] // 0x0000000189B58D60-0x0000000189B58DA0
	public VoicePickerParams GatherVoicePickerParams() => default; // 0x0000000183663060-0x0000000183663110
	// [IDTag] // 0x0000000189B63120-0x0000000189B63160
	// [XID] // 0x0000000189B63120-0x0000000189B63160
	public VoicePickerParams GatherVoicePickerParams(uint avatarSwitch) => default; // 0x0000000183663110-0x00000001836631F0
	// [XID] // 0x000000018986F270-0x000000018986F290
	public int PostFetterVoiceEvent(uint triggerId, uint avatarId, VoiceCallback playStopCallback) => default; // 0x0000000183661680-0x0000000183661780
	// [XID] // 0x0000000189B74E70-0x0000000189B74E90
	public void PostGachaVoiceEvent(uint avatarId) {} // 0x0000000183662850-0x00000001836629B0
	// [XID] // 0x0000000189B7C3D0-0x0000000189B7C3F0
	public void StopCurrentPlayingGachaEvent() {} // 0x0000000183662180-0x0000000183662230
	// [XID] // 0x0000000189BD12B0-0x0000000189BD12D0
	public void PostJoinTeamVoiceEvent(List<ulong> previousTeamMembers, List<ulong> currentTeamMembers) {} // 0x0000000183663410-0x00000001836635F0
	// [XID] // 0x0000000189B8AF60-0x0000000189B8AF80
	public int PostCodexVoiceEvent(uint multipurposeTriggerId, VoiceCallback playStartCallback, VoiceCallback playStopCallback) => default; // 0x00000001836635F0-0x0000000183663730
	// [XID] // 0x0000000189619DD0-0x0000000189619DF0
	public void StopCurrentPlayingJoinTeamEvent() {} // 0x0000000183663360-0x0000000183663410
	// [XID] // 0x00000001898854B0-0x00000001898854D0
	public int PostGlobalExternalVoiceEvent(AudioVoiceTrigger trigger, uint triggerId, uint avatarId, bool forceOutput2D, VoiceCallback playStartCallback, VoiceCallback playStopCallback) => default; // 0x0000000183661DC0-0x00000001836620B0
	// [XID] // 0x0000000189BA1300-0x0000000189BA1320
	public int SubmitGlobalVoiceIntention(IVoiceIntention intention) => default; // 0x00000001836620B0-0x0000000183662180
	// [XID] // 0x0000000189BA8900-0x0000000189BA8920
	public void StopVoiceEvent(int stub) {} // 0x0000000183662350-0x0000000183662440
	// [XID] // 0x0000000189BAFC20-0x0000000189BAFC40
	public void AddToPlayingVoiceIds(uint playingId) {} // 0x0000000183661C40-0x0000000183661D20
	// [XID] // 0x00000001895FBDD0-0x00000001895FBDF0
	public void RemoveFromPlayingVoiceIds(uint playingId) {} // 0x0000000183662B00-0x0000000183662BE0
	// [XID] // 0x0000000189BBE9B0-0x0000000189BBE9D0
	public void StopAllPlayingVoiceIds() {} // 0x0000000183662D90-0x0000000183662E70
	// [XID] // 0x0000000189BC6670-0x0000000189BC6690
	public void ReleaseAllVoiceIds() {} // 0x0000000183662FB0-0x0000000183663060
	// [XID] // 0x00000001898DEFF0-0x00000001898DF010
	private void TickFakeAvatarSyncPosition() {} // 0x0000000183661780-0x0000000183661C40
	// [XID] // 0x0000000189BD55F0-0x0000000189BD5610
	private VoicePickerParams GatherDefaultVoicePickerParams() => default; // 0x0000000183662440-0x0000000183662560
	// [XID] // 0x0000000189BDD1B0-0x0000000189BDD1D0
	private uint GetVoiceSwitchIdByAvatarId(uint avatarId) => default; // 0x0000000183662BE0-0x0000000183662D90
}

