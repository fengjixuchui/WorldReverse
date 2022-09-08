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

public sealed class VCLevelAudio : VCBaseAudio // TypeDefIndex: 11888
{
	// Fields
	private readonly Action<EvtEntityTimeScaleChange> _onTimeScaleChange; // 0x140
	private readonly StageLifeCycle _stageLifeCycle; // 0x148
	private readonly Dictionary<string, uint> _dungeonEventPostResults; // 0x150
	private readonly AudioSurfaceWalker _surfaceWalker; // 0x158
	private bool _isPaused; // 0x160

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899CAB00-0x00000001899CAB20 */ get => default; } // 0x0000000181D1FE50-0x0000000181D1FEF0 
	protected override bool isStatic { /* [XID] */ /* 0x00000001899D2130-0x00000001899D2150 */ get => default; } // 0x0000000181D1D1D0-0x0000000181D1D270 
	protected override bool isOccEnabled { /* [XID] */ /* 0x00000001899D9820-0x00000001899D9840 */ get => default; } // 0x0000000181D1F2F0-0x0000000181D1F390 

	// Nested types
	private class StageLifeCycle // TypeDefIndex: 11889
	{
		// Fields
		private readonly VCLevelAudio _levelAudio; // 0x10
		private ConfigAudioStageEvents _config; // 0x18
		private StagePhase _target; // 0x20
		private StagePhase _actual; // 0x24
		private int _matureCounter; // 0x28
		private float _progress; // 0x2C
		private bool _virginStage; // 0x30

		// Nested types
		private enum StagePhase // TypeDefIndex: 11890
		{
			Bare = 0,
			Create = 1,
			Ready = 2,
			Mature = 3
		}

		// Constructors
		public StageLifeCycle() {} // Dummy constructor
		public StageLifeCycle(VCLevelAudio levelAudio) {} // 0x0000000181D2A2B0-0x0000000181D2A330

		// Methods
		// [XID] // 0x0000000189B0B260-0x0000000189B0B280
		public void OnWillCreateStage() {} // 0x0000000181D29C00-0x0000000181D29CC0
		// [XID] // 0x0000000189B12AF0-0x0000000189B12B10
		public void OnStageProgress(float progress, BaseLevel.LoadState levelState) {} // 0x0000000181D299B0-0x0000000181D29A90
		// [XID] // 0x0000000189B19D80-0x0000000189B19DA0
		public void OnStageReady() {} // 0x0000000181D29110-0x0000000181D291D0
		// [XID] // 0x0000000189B21370-0x0000000189B21390
		public void OnStageExit() {} // 0x0000000181D29A90-0x0000000181D29B30
		// [XID] // 0x0000000189B28BC0-0x0000000189B28BE0
		public void Tick() {} // 0x0000000181D29030-0x0000000181D29110
		// [XID] // 0x0000000189B30070-0x0000000189B30090
		public void Reset() {} // 0x0000000181D28F90-0x0000000181D29030
		// [XID] // 0x0000000189B604B0-0x0000000189B604D0
		private void TickMature() {} // 0x0000000181D28DD0-0x0000000181D28EC0
		// [XID] // 0x0000000189B67CB0-0x0000000189B67CD0
		private void ProcessStageCreateSignal() {} // 0x0000000181D2A080-0x0000000181D2A140
		// [XID] // 0x0000000189B46A60-0x0000000189B46A80
		private void ProcessStageReadySignal() {} // 0x0000000181D296D0-0x0000000181D29780
		// [XID] // 0x0000000189B7DC60-0x0000000189B7DC80
		private void ProcessStageMatureSignal() {} // 0x0000000181D2A140-0x0000000181D2A1F0
		// [XID] // 0x0000000189B55880-0x0000000189B558A0
		private void PostStageCreateEvents() {} // 0x0000000181D29B30-0x0000000181D29C00
		// [XID] // 0x0000000189B5D2D0-0x0000000189B5D2F0
		private void PostStageProgressEvents(float progress) {} // 0x0000000181D29CC0-0x0000000181D29E60
		// [XID] // 0x0000000189B6EF10-0x0000000189B6EF30
		private void PostStageReadyEvents() {} // 0x0000000181D28EC0-0x0000000181D28F90
		// [XID] // 0x0000000189B6BEA0-0x0000000189B6BEC0
		private void PostStageMatureEvents() {} // 0x0000000181D2A1F0-0x0000000181D2A2B0
		// [XID] // 0x0000000189A2FA10-0x0000000189A2FA30
		private void PostStageExitEvents() {} // 0x0000000181D29780-0x0000000181D29850
		// [XID] // 0x0000000189B7ABF0-0x0000000189B7AC10
		private void SetLevelStateGroupValue() {} // 0x0000000181D291D0-0x0000000181D293D0
		// [XID] // 0x0000000189B824B0-0x0000000189B824D0
		private ConfigAudioStageEvents FindCurrentLevelData() => default; // 0x0000000181D29850-0x0000000181D299B0
		// [XID] // 0x0000000189B89D10-0x0000000189B89D30
		private void PostEvents(string[] eventNames) {} // 0x0000000181D29E60-0x0000000181D2A080
		// [XID] // 0x0000000189A3EAD0-0x0000000189A3EAF0
		private void PostMusicStimulus(MusicStimulus stimulus) {} // 0x0000000181D294C0-0x0000000181D295C0
		// [XID] // 0x0000000189B98530-0x0000000189B98550
		private bool DecideWetherIsVirginEntrance() => default; // 0x0000000181D293D0-0x0000000181D294C0
		// [XID] // 0x0000000189B9FA60-0x0000000189B9FA80
		private bool CheckEventAppliesOnMusic(string eventName) => default; // 0x0000000181D295C0-0x0000000181D296D0
	}

	// Constructors
	public VCLevelAudio() {} // 0x0000000181D1FD10-0x0000000181D1FE50

	// Methods
	// [XID] // 0x00000001899E0E50-0x00000001899E0E70
	public override void Init() {} // 0x0000000181D1E740-0x0000000181D1E8A0
	// [XID] // 0x00000001899E8A40-0x00000001899E8A60
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000181D1FB40-0x0000000181D1FC30
	// [XID] // 0x00000001899C6720-0x00000001899C6740
	public override void Destroy() {} // 0x0000000181D1CE50-0x0000000181D1CF20
	// [XID] // 0x00000001899F7740-0x00000001899F7760
	public void ToggleElementView(bool enabled) {} // 0x0000000181D1D6D0-0x0000000181D1D790
	// [XID] // 0x00000001899FEE40-0x00000001899FEE60
	public void PlayDungeonAudioEvent(string eventName, Vector3 position) {} // 0x0000000181D1EA20-0x0000000181D1ECB0
	// [IDTag] // 0x0000000189A06680-0x0000000189A066C0
	// [XID] // 0x0000000189A06680-0x0000000189A066C0
	public void StopDungeonAudioEvent(string eventName) {} // 0x0000000181D1DCB0-0x0000000181D1DF20
	// [IDTag] // 0x0000000189A108E0-0x0000000189A10920
	// [XID] // 0x0000000189A108E0-0x0000000189A10920
	public void StopDungeonAudioEvent(uint playingId) {} // 0x0000000181D1DF20-0x0000000181D1E020
	// [XID] // 0x0000000189A1ADF0-0x0000000189A1AE10
	public void RegisterAvatarAudio(VCAvatarAudio avatarAudio) {} // 0x0000000181D1D530-0x0000000181D1D600
	// [XID] // 0x0000000189A22730-0x0000000189A22750
	public void UnregisterAvatarAudio(VCAvatarAudio avatarAudio) {} // 0x0000000181D1D600-0x0000000181D1D6D0
	// [XID] // 0x0000000189A29A00-0x0000000189A29A20
	public void SetWeatherSurfaceOverride(string value) {} // 0x0000000181D1D3E0-0x0000000181D1D4B0
	// [XID] // 0x0000000189B58E60-0x0000000189B58E80
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000181D1DAE0-0x0000000181D1DBB0
	// [XID] // 0x0000000189A38AF0-0x0000000189A38B10
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000181D1D9E0-0x0000000181D1DAE0
	// [XID] // 0x0000000189A400E0-0x0000000189A40100
	protected override void Tick(float inDeltaTime) {} // 0x0000000181D1FC30-0x0000000181D1FD10
	// [XID] // 0x0000000189A47780-0x0000000189A477A0
	protected override bool OnEvent(BaseEvent e) => default; // 0x0000000181D1F9F0-0x0000000181D1FB40
	// [XID] // 0x0000000189688FE0-0x0000000189689000
	protected override bool ListenEvent(BaseEvent e) => default; // 0x0000000181D1F0E0-0x0000000181D1F200
	// [XID] // 0x0000000189A565E0-0x0000000189A56600
	protected override void InitInternal() {} // 0x0000000181D1E2B0-0x0000000181D1E500
	// [XID] // 0x0000000189A5E1F0-0x0000000189A5E210
	protected override void ClearInternal() {} // 0x0000000181D1CF20-0x0000000181D1D150
	// [XID] // 0x00000001896BCA20-0x00000001896BCA40
	protected override bool HandleEvtAudio(EvtAudio evt) => default; // 0x0000000181D1DBB0-0x0000000181D1DCB0
	// [XID] // 0x00000001899C4D90-0x00000001899C4DB0
	private static uint GetCurrentSceneId() => default; // 0x0000000181D1F010-0x0000000181D1F0E0
	// [XID] // 0x00000001895E8410-0x00000001895E8430
	private bool HandleEvtWillCreateStage(EvtWillCreateStage evt) => default; // 0x0000000181D1E140-0x0000000181D1E2B0
	// [XID] // 0x000000018969F780-0x000000018969F7A0
	private bool HandleEvtStageProgress(EvtStageProgress evt) => default; // 0x0000000181D1D790-0x0000000181D1D870
	// [XID] // 0x0000000189A83CA0-0x0000000189A83CC0
	private bool HandleEvtStageReady(EvtStageReady evt) => default; // 0x0000000181D1E020-0x0000000181D1E140
	// [XID] // 0x0000000189A8B5F0-0x0000000189A8B610
	private bool HandleEvtStageDestroying(EvtStageDestroying evt) => default; // 0x0000000181D1ED10-0x0000000181D1EDE0
	// [XID] // 0x0000000189A92BE0-0x0000000189A92C00
	private bool HandleEvtAvatarChanged(EvtAvatarChanged evt) => default; // 0x0000000181D1CA30-0x0000000181D1CB00
	// [XID] // 0x0000000189A9A6A0-0x0000000189A9A6C0
	private void HandleTeleport(int phase) {} // 0x0000000181D1CBF0-0x0000000181D1CCD0
	// [XID] // 0x00000001896FF610-0x00000001896FF630
	private void HandleToggleFeature(bool enable, AudioFeatureBitmask featureMask) {} // 0x0000000181D1D8D0-0x0000000181D1D9E0
	// [XID] // 0x0000000189AA8D90-0x0000000189AA8DB0
	private void PostTeleportMusicStimuli(int phase) {} // 0x0000000181D1E500-0x0000000181D1E630
	// [XID] // 0x00000001896CB3D0-0x00000001896CB3F0
	private void PostTeleportEvent(int phase) {} // 0x0000000181D1F6B0-0x0000000181D1F830
	// [XID] // 0x0000000189AB8000-0x0000000189AB8020
	private void MuteAvatarsInBlack(int teleportPhase) {} // 0x0000000181D1EF40-0x0000000181D1F010
	// [XID] // 0x0000000189ABFA60-0x0000000189ABFA80
	private void PauseWeatherPluginInBlack(int teleportPhase) {} // 0x0000000181D1F8F0-0x0000000181D1F9F0
	// [XID] // 0x0000000189AC76B0-0x0000000189AC76D0
	private void MuteAvatars(bool mute) {} // 0x0000000181D1CCD0-0x0000000181D1CE50
	// [XID] // 0x0000000189ACEC10-0x0000000189ACEC30
	private void RegisterListenEvtAvatarChanged() {} // 0x0000000181D1F400-0x0000000181D1F4C0
	// [XID] // 0x0000000189AD6B90-0x0000000189AD6BB0
	private void UnregisterListenEvtAvatarChanged() {} // 0x0000000181D1F830-0x0000000181D1F8F0
	private void ChangeListenEvent<T>(bool register)
		where T : BaseEvent {}
	// [XID] // 0x0000000189ADE400-0x0000000189ADE420
	private void ResetGameViewState() {} // 0x0000000181D1F5C0-0x0000000181D1F6B0
	// [XID] // 0x0000000189AE5E80-0x0000000189AE5EA0
	private void NotifyAvatarChange() {} // 0x0000000181D1EE50-0x0000000181D1EF40
	// [XID] // 0x0000000189698420-0x0000000189698440
	private void StopCurrentAvatar(uint avatarEntityId) {} // 0x0000000181D1E630-0x0000000181D1E740
	// [XID] // 0x0000000189AF4D60-0x0000000189AF4D80
	private void PostElementViewEvent(bool enabled) {} // 0x0000000181D1E8A0-0x0000000181D1EA20
	// [XID] // 0x0000000189AFC2A0-0x0000000189AFC2C0
	private void SetElementViewState(bool enabled) {} // 0x0000000181D1F4C0-0x0000000181D1F5C0
	// [XID] // 0x0000000189B03BF0-0x0000000189B03C10
	private void HandleEvtTimeScaleChanged(EvtEntityTimeScaleChange evt) {} // 0x0000000181D1D270-0x0000000181D1D3E0
}

