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

public sealed class AudioMusicStatePlugin : AudioComponentPlugin // TypeDefIndex: 12021
{
	// Fields
	private const int TICK_INTERVAL = 15; // Metadata: 0x00AEB368
	private readonly AliveAvatarCounter _aliveAvatarCounter; // 0x60
	private LCAIManager _aiManager; // 0x68
	private EntityManager _entityManager; // 0x70
	private uint _previousLevel1AreaId; // 0x78
	private uint _previousLevel2AreaId; // 0x7C
	private uint _previousLevel1AreaIdSetter; // 0x80
	private uint _previousLevel2AreaIdSetter; // 0x84
	private int _tickIntervalCounter; // 0x88

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B721C0-0x0000000189B721E0 */ get => default; } // 0x000000018133ABB0-0x000000018133AC50 

	// Nested types
	private class AliveAvatarCounter // TypeDefIndex: 12022
	{
		// Fields
		private readonly AudioMusicStatePlugin _musicPlugin; // 0x10
		private readonly List<BaseEntity> _avatarList; // 0x18

		// Constructors
		public AliveAvatarCounter() {} // Dummy constructor
		public AliveAvatarCounter(AudioMusicStatePlugin musicPlugin) {} // 0x0000000181338570-0x0000000181338610

		// Methods
		// [XID] // 0x000000018962A0E0-0x000000018962A100
		public int Count() => default; // 0x0000000181338410-0x0000000181338570
	}

	// Constructors
	public AudioMusicStatePlugin() {} // Dummy constructor
	public AudioMusicStatePlugin(VCBaseAudio component) {} // 0x000000018133AB10-0x000000018133ABB0

	// Methods
	// [XID] // 0x0000000189B79570-0x0000000189B79590
	public override void Init() {} // 0x00000001813395B0-0x0000000181339650
	// [XID] // 0x0000000189B80950-0x0000000189B80970
	public override void Tick(float inDeltaTime) {} // 0x000000018133AA40-0x000000018133AB10
	// [XID] // 0x0000000189B885A0-0x0000000189B885C0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001813391B0-0x0000000181339280
	// [XID] // 0x0000000189B8F7C0-0x0000000189B8F7E0
	public override bool OnEvent(BaseEvent evt) => default; // 0x000000018133A8F0-0x000000018133AA40
	// [XID] // 0x0000000189B96D20-0x0000000189B96D40
	public override void OnDisable() {} // 0x000000018133A840-0x000000018133A8F0
	// [XID] // 0x0000000189B9E190-0x0000000189B9E1B0
	public override void Destroy() {} // 0x0000000181338CC0-0x0000000181338DB0
	// [XID] // 0x0000000189BA5A90-0x0000000189BA5AB0
	private void TickEnemyStatus() {} // 0x0000000181339490-0x00000001813395B0
	// [XID] // 0x0000000189BACDA0-0x0000000189BACDC0
	private bool HandleEvtBoundInCity(EvtBoundInCity evt) => default; // 0x0000000181339280-0x00000001813393A0
	// [XID] // 0x0000000189BB4690-0x0000000189BB46B0
	private bool HandleEvtAudio(EvtAudio evt) => default; // 0x00000001813393A0-0x0000000181339490
	// [XID] // 0x0000000189BBBC70-0x0000000189BBBC90
	private bool HandleEvtDieEnd(EvtAvatarDieEnd evt) => default; // 0x0000000181338BC0-0x0000000181338CC0
	// [XID] // 0x0000000189BC3B30-0x0000000189BC3B50
	private void InputBlackScreenStimulus(int blackScreenState) {} // 0x000000018133A730-0x000000018133A840
	// [XID] // 0x0000000189BCB2C0-0x0000000189BCB2E0
	private void HandleAreaChange(WorldAreaConfig areaConfig) {} // 0x00000001813398A0-0x0000000181339AF0
	// [XID] // 0x0000000189BD28B0-0x0000000189BD28D0
	private void SubmitAreaChangeStateInput(uint areaId, ConfigAudioMapArea audioConfig, AudioManager audioManager) {} // 0x000000018133A4A0-0x000000018133A610
	// [XID] // 0x0000000189BD9E30-0x0000000189BD9E50
	private void PostAreaBoundaryEvents(WorldAreaConfig areaConfig, ConfigAudioMapArea audioConfig, AudioManager audioManager) {} // 0x0000000181339AF0-0x0000000181339D50
	// [XID] // 0x00000001895E6930-0x00000001895E6950
	private bool ShallPostExitAreaEvent(uint areaId, uint areaLevelId, ref uint previousAreaLevelId, ref uint previousAreaLevelIdSetter, out ConfigWwiseString[] events) {
		events = default;
		return default;
	} // 0x000000018133A310-0x000000018133A4A0
	// [XID] // 0x00000001895EE450-0x00000001895EE470
	private void PostAreaChangeStimulus(uint areaId, AudioManager audioManager) {} // 0x000000018133A610-0x000000018133A730
	// [XID] // 0x00000001895F5BF0-0x00000001895F5C10
	private void Input(Input input) {} // 0x0000000181338E10-0x0000000181338F10
	// [XID] // 0x00000001895FD0F0-0x00000001895FD110
	private void UpdateEnemyStatusParameters(EnemyStatusParameters parameters) {} // 0x0000000181338A60-0x0000000181338BC0
	// [XID] // 0x0000000189604AD0-0x0000000189604AF0
	private EnemyStatusParameters DetermineEnemyStatusParameters() => default; // 0x0000000181339E40-0x000000018133A310
	// [XID] // 0x000000018960C360-0x000000018960C380
	private LCAIManager FindAiManager() => default; // 0x0000000181339730-0x0000000181339840
	// [XID] // 0x00000001896139A0-0x00000001896139C0
	private void GetTeamAvatars(List<BaseEntity> list) {} // 0x0000000181338F10-0x0000000181339130
	// [XID] // 0x000000018961B270-0x000000018961B290
	private void PostPersistentStageEvents(CommandThreadAmbienceFunctionalities ambience, ConfigWwiseString[] events) {} // 0x0000000181338920-0x0000000181338A60
	// [XID] // 0x0000000189622760-0x0000000189622780
	private uint GetLocalAvatarEntityId() => default; // 0x0000000181339650-0x0000000181339730
}

