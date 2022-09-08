/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AudioWeatherPlugin : AudioComponentPlugin, IIntentionSubmitter // TypeDefIndex: 12032
{
	// Fields
	private const ulong AUDIO_THUNDER_VO_AVOID_TIMEOUT = 300; // Metadata: 0x00AEB36C
	private ConfigAudioWeather _config; // 0x60
	private WeatherSoundEffectWorkSet _workSetCurrent; // 0x68
	private WeatherSoundEffectWorkSet _workSetNext; // 0x70
	private ConfigWeatherType _weatherTypeChangeTarget; // 0x78
	private ConfigWeatherType _weatherTypeChangePrevious; // 0x7C
	private uint _timeOfDayRtpcKeyId; // 0x80
	private string _weatherChangePrevious; // 0x88
	private string _weatherChangeTarget; // 0x90
	private bool _isWeatherChangeOngoing; // 0x98
	private bool _isBlackScreen; // 0x99
	private ulong _lastThunderVoTime; // 0xA0
	private bool _blind; // 0xA8

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001897C5660-0x00000001897C5680 */ get => default; } // 0x0000000184268B60-0x0000000184268C00 
	public uint weatherSwitchKey { /* [XID] */ /* 0x00000001897CCCC0-0x00000001897CCCE0 */ get => default; } // 0x0000000184266A40-0x0000000184266B00 
	public uint weatherSwitchValue { /* [XID] */ /* 0x00000001897D43C0-0x00000001897D43E0 */ get => default; } // 0x0000000184265F80-0x0000000184266050 
	public bool isBlackScreen { /* [XID] */ /* 0x00000001896F7AD0-0x00000001896F7AF0 */ set {} } // 0x0000000184267400-0x00000001842674B0

	// Nested types
	private class WeatherSoundEffectWorkSet // TypeDefIndex: 12033
	{
		// Properties
		public uint stateGroupId { /* [XID] */ /* 0x00000001898F2580-0x00000001898F25C0 */ get; /* [XID] */ /* 0x00000001898FCCA0-0x00000001898FCCE0 */ private set; } // 0x0000000184279AF0-0x0000000184279B50 0x0000000184279110-0x0000000184279170
		public uint activenessRtpcId { /* [XID] */ /* 0x0000000189907640-0x0000000189907680 */ get; /* [XID] */ /* 0x0000000189911E50-0x0000000189911E90 */ private set; } // 0x00000001842799D0-0x0000000184279A30 0x0000000184279A30-0x0000000184279A90
		public uint workSetSwitchHash { get; /* [XID] */ /* 0x0000000189924390-0x00000001899243D0 */ private set; } // 0x0000000184279470-0x00000001842794D0 0x00000001842797B0-0x0000000184279810
		public float activeness { /* [XID] */ /* 0x000000018992E870-0x000000018992E8B0 */ get; /* [XID] */ /* 0x0000000189938D00-0x0000000189938D40 */ private set; } // 0x0000000184279610-0x0000000184279680 0x0000000184279680-0x00000001842796F0
		public float activenessAtStart { /* [XID] */ /* 0x0000000189943370-0x00000001899433B0 */ get; /* [XID] */ /* 0x000000018994DAC0-0x000000018994DB00 */ private set; } // 0x00000001842794D0-0x0000000184279540 0x0000000184279540-0x00000001842795B0
		public bool upTurning { /* [XID] */ /* 0x0000000189958490-0x00000001899584D0 */ get; /* [XID] */ /* 0x0000000189962DD0-0x0000000189962E10 */ private set; } // 0x00000001842795B0-0x0000000184279610 0x0000000184279A90-0x0000000184279AF0

		// Constructors
		public WeatherSoundEffectWorkSet() {} // 0x0000000184279B50-0x0000000184279BB0

		// Methods
		// [XID] // 0x000000018996D1F0-0x000000018996D210
		public void SetupWithConfig(AudioWeatherWorkSet config) {} // 0x0000000184279810-0x00000001842799D0
		// [XID] // 0x0000000189974AB0-0x0000000189974AD0
		public void SetupUpTurning(float startValue) {} // 0x0000000184279050-0x0000000184279110
		// [XID] // 0x000000018997BFC0-0x000000018997BFE0
		public void SetupDownTurning(float startValue) {} // 0x00000001842796F0-0x00000001842797B0
		// [XID] // 0x0000000189983C10-0x0000000189983C30
		public void UpdateActiveness(float delta) {} // 0x00000001842792F0-0x0000000184279470
		// [XID] // 0x000000018998B4E0-0x000000018998B500
		private void Setup(float startValue, bool goingUp) {} // 0x0000000184279170-0x00000001842792F0
	}

	// Constructors
	public AudioWeatherPlugin() {} // Dummy constructor
	public AudioWeatherPlugin(VCBaseAudio component) {} // 0x0000000184268AE0-0x0000000184268B60

	// Methods
	// [XID] // 0x00000001897E35A0-0x00000001897E35C0
	public override void Init() {} // 0x00000001842675B0-0x00000001842676A0
	// [XID] // 0x00000001897EAD80-0x00000001897EADA0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000184268900-0x0000000184268A00
	// [XID] // 0x00000001897F2AD0-0x00000001897F2AF0
	public override void Tick(float inDeltaTime) {} // 0x0000000184268A00-0x0000000184268AE0
	// [XID] // 0x00000001897FA2B0-0x00000001897FA2D0
	public override bool OnEvent(BaseEvent e) => default; // 0x0000000184268460-0x0000000184268580
	// [XID] // 0x00000001898018B0-0x00000001898018D0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000184266BB0-0x0000000184266CB0
	// [XID] // 0x0000000189808D10-0x0000000189808D30
	private void InitWithConfig(ConfigAudioWeather config) {} // 0x0000000184267B00-0x0000000184267CA0
	// [XID] // 0x0000000189810600-0x0000000189810620
	private void TickBlindness() {} // 0x0000000184266220-0x00000001842664D0
	// [XID] // 0x0000000189817D60-0x0000000189817D80
	private void TickTimeOfDay() {} // 0x0000000184266050-0x0000000184266170
	// [XID] // 0x000000018981F650-0x000000018981F670
	private void TickWeatherTransition() {} // 0x00000001842664D0-0x0000000184266730
	// [XID] // 0x0000000189826C10-0x0000000189826C30
	private void TickWindSpeed() {} // 0x0000000184267870-0x0000000184267A20
	// [XID] // 0x000000018982E2C0-0x000000018982E2E0
	private bool HandleEvtWeatherChange(EvtWeatherChange evt) => default; // 0x0000000184266F40-0x00000001842670B0
	// [XID] // 0x00000001898359D0-0x00000001898359F0
	private bool HandleEvtThunder(EvtThunder evt) => default; // 0x0000000184265CF0-0x0000000184265F80
	// [XID] // 0x000000018983D0C0-0x000000018983D0E0
	private AudioWeatherProperties GetWeatherPropertiesConfig(string name) => default; // 0x00000001842676A0-0x0000000184267870
	// [XID] // 0x00000001898447D0-0x00000001898447F0
	private void SetupWorkSetTransition() {} // 0x00000001842667B0-0x0000000184266A40
	// [XID] // 0x000000018984BCF0-0x000000018984BD10
	private void UpdateWorkSetActiveness(WeatherSoundEffectWorkSet workSet, float delta) {} // 0x0000000184266CB0-0x0000000184266E10
	// [XID] // 0x0000000189852BD0-0x0000000189852BF0
	private void EndWeatherTransition() {} // 0x0000000184267A20-0x0000000184267B00
	// [XID] // 0x000000018985A800-0x000000018985A820
	private void SetNextDominantWeather() {} // 0x0000000184266B00-0x0000000184266BB0
	// [XID] // 0x0000000189861870-0x0000000189861890
	private void SetNextDominantWeatherWithoutDelay() {} // 0x0000000184266170-0x0000000184266220
	// [XID] // 0x00000001898691B0-0x00000001898691D0
	private void SetAvatarWeatherSwitch() {} // 0x00000001842682E0-0x0000000184268460
	// [XID] // 0x0000000189870470-0x0000000189870490
	private void PostAvatarSpeechEvent() {} // 0x0000000184267F40-0x00000001842682E0
	// [XID] // 0x0000000189877B80-0x0000000189877BA0
	private void PostAvatarThunderSpeech() {} // 0x00000001842670B0-0x0000000184267400
	// [XID] // 0x000000018987F3D0-0x000000018987F3F0
	private void SetSurfaceOverrideValue() {} // 0x0000000184265960-0x0000000184265A70
	// [XID] // 0x0000000189886A00-0x0000000189886A20
	private void PostMusicStimulus() {} // 0x0000000184266E10-0x0000000184266F40
	// [XID] // 0x000000018988DB90-0x000000018988DBB0
	private VCAvatarAudio GetLocalAvatarAudio() => default; // 0x00000001842674B0-0x00000001842675B0
	// [XID] // 0x00000001896CB3F0-0x00000001896CB410
	private string GetCurrentWeatherName() => default; // 0x0000000184268580-0x0000000184268760
	// [XID] // 0x000000018989C930-0x000000018989C950
	private ConfigWeatherType GetCurrentWeatherType() => default; // 0x0000000184268760-0x0000000184268900
	// [XID] // 0x00000001898A41A0-0x00000001898A41C0
	private void SetDominantWeather(string weatherName) {} // 0x0000000184265B40-0x0000000184265CF0
	// [XID] // 0x00000001898AB380-0x00000001898AB3A0
	private void SetDominantWeatherWithoutDelay(string weatherName) {} // 0x0000000184267D90-0x0000000184267F40
}

