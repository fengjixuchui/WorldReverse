/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Audio.Music.Miiha
{
	public sealed class StimulusHandler : TransitionPicker // TypeDefIndex: 11370
	{
		// Constructors
		public StimulusHandler() {} // 0x0000000182DDB140-0x0000000182DDB1E0
	
		// Methods
		public int HandleStimulus<T>(MusicStimulus stimulus, IStimulusParameter<T> parameter, GameParamStorage gameParamStorage, ConfigMusic music, ConfigSong song) => default;
		private bool GetMatchFromSong<T>(MusicStimulus stimulus, IStimulusParameter<T> parameter, ConfigSong song, out ConfigMusicTransitions transitions) {
			transitions = default;
			return default;
		}
		private bool GetTransitionsId<T>(MusicStimulus stimulus, IStimulusParameter<T> parameter, MusicStimulus quickStimuliMask, ConfigMusicStimulusHandler[] stimulusHandlers, ref ConfigMusicTransitions transitions) => default;
	}
}
