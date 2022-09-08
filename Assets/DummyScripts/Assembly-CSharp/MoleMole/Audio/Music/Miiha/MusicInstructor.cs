/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Audio.Music.Miiha
{
	public class MusicInstructor // TypeDefIndex: 11368
	{
		// Fields
		private readonly SongPlayer _player; // 0x10
		private readonly GameParamStorage _gameParamStorage; // 0x18
		private readonly StimulusHandler _stimulusHandler; // 0x20
		private readonly SyncTransitionPicker _syncTransitionPicker; // 0x28
		private readonly TimeTransitionPicker _timeTransitionPicker; // 0x30
		private readonly EventCallback _nativeCallback; // 0x38
		private readonly FixedTimePulse _tickPulse; // 0x40
	
		// Constructors
		public MusicInstructor() {} // Dummy constructor
		public MusicInstructor(WorkerThreadContext context) {} // 0x000000018672B8B0-0x000000018672BA40
	
		// Methods
		// [XID] // 0x000000018961CB60-0x000000018961CB80
		public void SetSyncId(SyncId syncId) {} // 0x000000018672B4C0-0x000000018672B600
		// [XID] // 0x00000001898E4CF0-0x00000001898E4D10
		public void Tick(TimeSpan deltaTime) {} // 0x000000018672B7A0-0x000000018672B8B0
		// [XID] // 0x000000018962B7F0-0x000000018962B810
		public void Play(ConfigMusic music) {} // 0x000000018672B320-0x000000018672B410
		// [XID] // 0x0000000189632FF0-0x0000000189633010
		public void Stop() {} // 0x000000018672B600-0x000000018672B6D0
		// [XID] // 0x0000000189670F30-0x0000000189670F50
		public void Pause() {} // 0x000000018672B270-0x000000018672B320
		// [XID] // 0x0000000189687540-0x0000000189687560
		public void Resume() {} // 0x000000018672B410-0x000000018672B4C0
		public void UpdateGameParamValue<TValue>(MusicGameParam gameParam, TValue value) {}
		public void AddGameParamValue<TValue>(MusicGameParam gameParam, TValue value)
			where TValue : struct {}
		public void RemoveGameParamValue<TValue>(MusicGameParam gameParam, TValue value)
			where TValue : struct {}
		public void HandleStimulus<T>(MusicStimulus stimulus, IStimulusParameter<T> parameter) {}
		// [XID] // 0x00000001896499E0-0x0000000189649A00
		private void EventCallback(object cookie, AkCallbackType type, MmoronCallbackInfo info) {} // 0x000000018672B040-0x000000018672B270
		// [XID] // 0x00000001899E8BF0-0x00000001899E8C10
		private void SwitchToNextSong(int targetSongId) {} // 0x000000018672B6D0-0x000000018672B7A0
		// [XID] // 0x000000018965A170-0x000000018965A190
		private void ChangeCurrentSong() {} // 0x000000018672AE90-0x000000018672B040
		private StimulusReaction DeduceStimulusReaction<T>(MusicStimulus stimulus, IStimulusParameter<T> parameter, out int targetSongId) {
			targetSongId = default;
			return default;
		}
	}
}
