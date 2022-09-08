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

namespace MoleMole.Audio.Music.Miiha
{
	public sealed class TimeTransitionPicker : TransitionPicker // TypeDefIndex: 11373
	{
		// Fields
		private readonly DomainTransitions _globalDomainTransitions; // 0x10
		private readonly DomainTransitions _localDomainTransitions; // 0x18
	
		// Nested types
		private class DomainTransitions // TypeDefIndex: 11374
		{
			// Fields
			private static TimeSpan _elapsedSinceSongStart; // 0x00
			private readonly List<TimedTransitions> _fixedTimeTransitions; // 0x10
			private ConfigMusicTransitions _repetitiveTransitions; // 0x18
			private TimeSpan _repetitionInterval; // 0x20
			private TimeSpan _elapsedSinceLastCycle; // 0x28
			private bool _hasValidRepetitiveTransitions; // 0x30
			private bool _hasValidFixedTimeTransitions; // 0x31
	
			// Nested types
			private struct TimedTransitions // TypeDefIndex: 11375
			{
				// Properties
				public ConfigMusicTransitions transitions { /* [XID] */ /* 0x00000001897E05E0-0x00000001897E0620 */ get; /* [XID] */ /* 0x00000001897EAE40-0x00000001897EAE80 */ set; } // 0x0000000182DDBFB0-0x0000000182DDC010 0x0000000182DDC070-0x0000000182DDC0F0
				public TimeSpan fixedTime { /* [XID] */ /* 0x00000001897F5860-0x00000001897F58A0 */ get; /* [XID] */ /* 0x0000000189800100-0x0000000189800140 */ set; } // 0x0000000182DDBF50-0x0000000182DDBFB0 0x0000000182DDC010-0x0000000182DDC070
			}
	
			private struct ReverseIdComparer : IComparer<TimedTransitions> // TypeDefIndex: 11376
			{
				// Methods
				// [XID] // 0x000000018980A680-0x000000018980A6A0
				public int Compare(TimedTransitions x, TimedTransitions y) => default; // 0x0000000182DDAE70-0x0000000182DDAEA0
			}
	
			// Constructors
			public DomainTransitions() {} // 0x0000000182DD9430-0x0000000182DD94C0
	
			// Methods
			// [XID] // 0x0000000189903150-0x0000000189903170
			public static int Tick(TimeSpan deltaTime, GameParamStorage gameParamStorage, DomainTransitions global, DomainTransitions local) => default; // 0x0000000182DD8A30-0x0000000182DD8BE0
			// [XID] // 0x0000000189754A40-0x0000000189754A60
			public static void ResetTimer() {} // 0x0000000182DD85D0-0x0000000182DD86A0
			// [XID] // 0x00000001897458D0-0x00000001897458F0
			public void Schedule(ConfigMusicTimeTransitions timeTransitions) {} // 0x0000000182DD86A0-0x0000000182DD8A30
			// [XID] // 0x0000000189736810-0x0000000189736830
			public void Clear() {} // 0x0000000182DD8340-0x0000000182DD8450
			// [XID] // 0x0000000189795D40-0x0000000189795D60
			private static int PickTransition(GameParamStorage gameParamStorage, DomainTransitions global, DomainTransitions local) => default; // 0x0000000182DD8450-0x0000000182DD85D0
			// [XID] // 0x00000001899466E0-0x0000000189946700
			private static int TryNextLocalFixedTime(TimeSpan songElapsed, GameParamStorage gameParamStorage, DomainTransitions local) => default; // 0x0000000182DD8FB0-0x0000000182DD9120
			// [XID] // 0x00000001897A5450-0x00000001897A5470
			private static int TryNextGlobalFixedTime(TimeSpan songElapsed, GameParamStorage gameParamStorage, DomainTransitions global) => default; // 0x0000000182DD8E40-0x0000000182DD8FB0
			// [XID] // 0x00000001897ACAE0-0x00000001897ACB00
			private static int TryLocalRepetitive(GameParamStorage gameParamStorage, DomainTransitions local) => default; // 0x0000000182DD8D10-0x0000000182DD8E40
			// [XID] // 0x00000001897B48E0-0x00000001897B4900
			private static int TryGlobalRepetitive(GameParamStorage gameParamStorage, DomainTransitions global) => default; // 0x0000000182DD8BE0-0x0000000182DD8D10
			// [XID] // 0x00000001897BC7F0-0x00000001897BC810
			private bool TryReapLastFixed(TimeSpan elapsed, out TimedTransitions timedTransitions) {
				timedTransitions = default;
				return default;
			} // 0x0000000182DD9120-0x0000000182DD9310
			// [XID] // 0x00000001897C3C90-0x00000001897C3CB0
			private void WrapTimer() {} // 0x0000000182DD9310-0x0000000182DD9430
		}
	
		// Constructors
		public TimeTransitionPicker() {} // 0x0000000182DDBE60-0x0000000182DDBF50
	
		// Methods
		// [XID] // 0x0000000189761D80-0x0000000189761DA0
		public void SwitchToNextSong(ConfigMusic music, ConfigSong song) {} // 0x0000000182DDBCB0-0x0000000182DDBD80
		// [XID] // 0x0000000189769130-0x0000000189769150
		public int Tick(TimeSpan deltaTime, GameParamStorage gameParamStorage) => default; // 0x0000000182DDBD80-0x0000000182DDBE60
		// [XID] // 0x0000000189770850-0x0000000189770870
		private void ScheduleTransitions(ConfigMusic music, ConfigSong song) {} // 0x0000000182DDBB30-0x0000000182DDBCB0
	}
}
