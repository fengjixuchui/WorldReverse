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
	public sealed class SyncTransitionPicker : TransitionPicker // TypeDefIndex: 11372
	{
		// Fields
		public const AkCallbackType SYNC_CALLBACK_TYPES = (AkCallbackType) 15232; // Metadata: 0x00AE97EB
	
		// Constructors
		public SyncTransitionPicker() {} // 0x0000000182DDBA90-0x0000000182DDBB30
	
		// Methods
		// [XID] // 0x0000000189696DD0-0x0000000189696DF0
		public int TryPickTransitionOnSyncCallback(ConfigMusic music, ConfigSong song, AkCallbackType callbackType, GameParamStorage gameParamStorage) => default; // 0x0000000182DDB920-0x0000000182DDBA90
		// [XID] // 0x0000000189743CA0-0x0000000189743CC0
		private int CheckStartTransitions(ConfigMusic music, GameParamStorage gameParamStorage) => default; // 0x0000000182DDB310-0x0000000182DDB410
		// [XID] // 0x000000018974B8B0-0x000000018974B8D0
		private int CheckSyncTransitions(ConfigMusic music, ConfigSong song, AkCallbackType callbackType, GameParamStorage gameParamStorage) => default; // 0x0000000182DDB410-0x0000000182DDB570
		// [XID] // 0x0000000189752CB0-0x0000000189752CD0
		private ConfigMusicTransitions GetGlobalTransitions(ConfigMusic music, AkCallbackType callbackType) => default; // 0x0000000182DDB570-0x0000000182DDB730
		// [XID] // 0x0000000189759FA0-0x0000000189759FC0
		private void GetTransitionsFromSongData(ConfigSong song, AkCallbackType callbackType, out ConfigMusicTransitions transitions, out bool inherit) {
			transitions = default;
			inherit = default;
		} // 0x0000000182DDB730-0x0000000182DDB920
	}
}
