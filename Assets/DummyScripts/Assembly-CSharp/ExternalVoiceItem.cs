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

public class ExternalVoiceItem // TypeDefIndex: 19375
{
	// Fields
	private static readonly HashSet<uint> _ecoInferiorSet; // 0x00
	private static readonly List<ExternalVoiceSound> _ecoSoundList; // 0x08
	private VoicePlaylist _playlist; // 0x10

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B86320-0x0000000189B86360 */ get; /* [XID] */ /* 0x0000000189B90520-0x0000000189B90560 */ set; } // 0x0000000182873EA0-0x0000000182873F00 0x0000000182872F50-0x0000000182872FB0
	public float triggerRatio { /* [XID] */ /* 0x0000000189B9A8C0-0x0000000189B9A900 */ get; /* [XID] */ /* 0x0000000189BA50F0-0x0000000189BA5130 */ set; } // 0x00000001828723D0-0x0000000182872440 0x0000000182873600-0x0000000182873670
	public uint[] inferiors { /* [XID] */ /* 0x0000000189BAF1C0-0x0000000189BAF200 */ get; /* [XID] */ /* 0x0000000189BB96E0-0x0000000189BB9720 */ set; } // 0x0000000182873670-0x00000001828736D0 0x0000000182873190-0x00000001828731F0
	public VoiceQueueBehaviour queueBehaviour { /* [XID] */ /* 0x0000000189BC44A0-0x0000000189BC44E0 */ get; /* [XID] */ /* 0x0000000189BCEF70-0x0000000189BCEFB0 */ set; } // 0x0000000182872E30-0x0000000182872E90 0x00000001828729B0-0x0000000182872A10
	public AudioVoiceTrigger trigger { /* [XID] */ /* 0x0000000189BD9400-0x0000000189BD9440 */ get; /* [XID] */ /* 0x00000001895E8F50-0x00000001895E8F90 */ set; } // 0x0000000182872950-0x00000001828729B0 0x00000001828730D0-0x0000000182873130
	public uint triggerParam { /* [XID] */ /* 0x00000001895F35B0-0x00000001895F35F0 */ get; /* [XID] */ /* 0x00000001895FDCE0-0x00000001895FDD20 */ set; } // 0x0000000182872790-0x00000001828727F0 0x0000000182872A10-0x0000000182872A70
	public VoicePersonality personality { /* [XID] */ /* 0x0000000189608910-0x0000000189608950 */ get; /* [XID] */ /* 0x0000000189612F20-0x0000000189612F60 */ set; } // 0x0000000182872FB0-0x0000000182873010 0x0000000182872730-0x0000000182872790
	public VoicePositioning positioning { /* [XID] */ /* 0x000000018961D690-0x000000018961D6D0 */ get; /* [XID] */ /* 0x0000000189627B50-0x0000000189627B90 */ set; } // 0x00000001828731F0-0x0000000182873250 0x0000000182873F60-0x0000000182873FC0
	public bool clearQueue { /* [XID] */ /* 0x00000001896323C0-0x0000000189632400 */ get; /* [XID] */ /* 0x0000000189BAFEC0-0x0000000189BAFF00 */ set; } // 0x00000001828727F0-0x0000000182872850 0x0000000182872EF0-0x0000000182872F50
	public bool isExclusive { /* [XID] */ /* 0x00000001896475B0-0x00000001896475F0 */ get; /* [XID] */ /* 0x0000000189651C80-0x0000000189651CC0 */ set; } // 0x0000000182873130-0x0000000182873190 0x0000000182873010-0x0000000182873070
	public bool playOnTeam { /* [XID] */ /* 0x000000018965C4E0-0x000000018965C520 */ get; /* [XID] */ /* 0x0000000189648400-0x0000000189648440 */ set; } // 0x0000000182873070-0x00000001828730D0 0x0000000182873BB0-0x0000000182873C10
	public int avoidRepeat { /* [XID] */ /* 0x0000000189671A20-0x0000000189671A60 */ get; /* [XID] */ /* 0x000000018967C160-0x000000018967C1A0 */ set; } // 0x0000000182873D70-0x0000000182873DD0 0x0000000182872850-0x00000001828728B0
	public List<ExternalVoiceItem> children { /* [XID] */ /* 0x0000000189686730-0x0000000189686770 */ get; /* [XID] */ /* 0x00000001896917A0-0x00000001896917E0 */ private set; } // 0x0000000182873F00-0x0000000182873F60 0x0000000182872A70-0x0000000182872AD0
	public ExternalVoiceItem parent { /* [XID] */ /* 0x000000018969BB80-0x000000018969BBC0 */ get; /* [XID] */ /* 0x00000001896A5E50-0x00000001896A5E90 */ private set; } // 0x0000000182872E90-0x0000000182872EF0 0x0000000182872440-0x00000001828724A0
	private ExternalVoiceIdentity voiceId { /* [XID] */ /* 0x00000001896B00D0-0x00000001896B00F0 */ get => default; } // 0x0000000182873A60-0x0000000182873BB0 

	// Nested types
	public struct TemporarySoundList : IDisposable // TypeDefIndex: 19376
	{
		// Fields
		private readonly IList<ExternalVoiceSound> _reusedList; // 0x00

		// Properties
		public IList<ExternalVoiceSound> sounds { /* [XID] */ /* 0x00000001896FFFA0-0x00000001896FFFC0 */ get => default; } // 0x0000000182856030-0x0000000182856100 

		// Constructors
		public TemporarySoundList(IList<ExternalVoiceSound> reusedList) : this() {
			_reusedList = default;
		} // 0x0000000182856110-0x0000000182856190

		// Methods
		// [XID] // 0x0000000189707670-0x0000000189707690
		public void Dispose() {} // 0x0000000182856100-0x0000000182856110
	}

	private static class SoundGroupper // TypeDefIndex: 19377
	{
		// Fields
		private static readonly Dictionary<uint, List<ExternalVoiceSound>> _groups; // 0x00
		private static readonly Stack<List<ExternalVoiceSound>> _listPool; // 0x08

		// Constructors
		static SoundGroupper() {} // 0x0000000182875F00-0x0000000182875FC0

		// Methods
		// [XID] // 0x000000018970F080-0x000000018970F0A0
		public static Dictionary<uint, List<ExternalVoiceSound>> GroupBySwitch(List<ExternalVoiceSound> sounds) => default; // 0x0000000182875B00-0x0000000182875F00
		// [XID] // 0x00000001897E6940-0x00000001897E6960
		public static void Reset() {} // 0x0000000182875880-0x0000000182875B00
	}

	// Constructors
	static ExternalVoiceItem() {} // 0x0000000182873FC0-0x0000000182874080
	public ExternalVoiceItem() {} // 0x0000000182874080-0x00000001828740E0

	// Methods
	// [XID] // 0x00000001896B7950-0x00000001896B7970
	public void AddChild(ExternalVoiceItem child) {} // 0x00000001828736D0-0x0000000182873860
	// [XID] // 0x0000000189829EB0-0x0000000189829ED0
	public void SetSounds(List<ExternalVoiceSound> sounds) {} // 0x0000000182873250-0x0000000182873600
	// [XID] // 0x00000001896A2920-0x00000001896A2940
	public bool Roll() => default; // 0x0000000182873C10-0x0000000182873D70
	// [IDTag] // 0x00000001896CD9D0-0x00000001896CDA10
	// [XID] // 0x00000001896CD9D0-0x00000001896CDA10
	public string Pick(VoicePickerParams @params) => default; // 0x00000001828724A0-0x00000001828725C0
	// [IDTag] // 0x00000001896D7ED0-0x00000001896D7F10
	// [XID] // 0x00000001896D7ED0-0x00000001896D7F10
	public bool Pick(VoicePickerParams @params, out ExternalVoiceSound voice) {
		voice = default;
		return default;
	} // 0x00000001828725C0-0x0000000182872730
	// [XID] // 0x00000001896E2740-0x00000001896E2760
	public bool HasChildWithSwitch(uint avatarSwitch) => default; // 0x0000000182873DD0-0x0000000182873EA0
	// [XID] // 0x00000001896E9C40-0x00000001896E9C60
	public bool IsSuperiorThan(ExternalVoiceItem counterpart) => default; // 0x0000000182872AD0-0x0000000182872E30
	// [XID] // 0x000000018988F6E0-0x000000018988F700
	public TemporarySoundList GetTemporarySoundList() => default; // 0x0000000182873860-0x0000000182873A60
	// [XID] // 0x00000001896F8660-0x00000001896F8680
	public void Clear() {} // 0x00000001828728B0-0x0000000182872950
}

