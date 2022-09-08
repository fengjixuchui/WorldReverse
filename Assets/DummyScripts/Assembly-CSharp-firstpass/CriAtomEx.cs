/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class CriAtomEx // TypeDefIndex: 6991
{
	// Fields
	public const uint InvalidAisacControlId = 65535; // Metadata: 0x00ADE0AC

	// Nested types
	public enum CharacterEncoding // TypeDefIndex: 6992
	{
		Utf8 = 0,
		Sjis = 1
	}

	public enum SoundRendererType // TypeDefIndex: 6993
	{
		Default = 0,
		Native = 1,
		Hw1 = 1,
		Asr = 2,
		Hw2 = 9
	}

	public enum VoiceAllocationMethod // TypeDefIndex: 6994
	{
		Once = 0,
		Retry = 1
	}

	public enum BiquadFilterType // TypeDefIndex: 6995
	{
		Off = 0,
		LowPass = 1,
		HighPass = 2,
		Notch = 3,
		LowShelf = 4,
		HighShelf = 5,
		Peaking = 6
	}

	public enum ResumeMode // TypeDefIndex: 6996
	{
		AllPlayback = 0,
		PausedPlayback = 1,
		PreparedPlayback = 2
	}

	public enum PanType // TypeDefIndex: 6997
	{
		Unknown = -1,
		Pan3d = 0,
		Pos3d = 1,
		Auto = 2
	}

	public enum VoiceControlMethod // TypeDefIndex: 6998
	{
		PreferLast = 0,
		PreferFirst = 1
	}

	public enum Parameter // TypeDefIndex: 6999
	{
		Volume = 0,
		Pitch = 1,
		Pan3dAngle = 2,
		Pan3dDistance = 3,
		Pan3dVolume = 4,
		BusSendLevel0 = 9,
		BusSendLevel1 = 10,
		BusSendLevel2 = 11,
		BusSendLevel3 = 12,
		BusSendLevel4 = 13,
		BusSendLevel5 = 14,
		BusSendLevel6 = 15,
		BusSendLevel7 = 16,
		BandPassFilterCofLow = 17,
		BandPassFilterCofHigh = 18,
		BiquadFilterType = 19,
		BiquadFilterFreq = 20,
		BiquadFIlterQ = 21,
		BiquadFilterGain = 22,
		EnvelopeAttackTime = 23,
		EnvelopeHoldTime = 24,
		EnvelopeDecayTime = 25,
		EnvelopeReleaseTime = 26,
		EnvelopeSustainLevel = 27,
		StartTime = 28,
		Priority = 31
	}

	public enum Speaker // TypeDefIndex: 7000
	{
		FrontLeft = 0,
		FrontRight = 1,
		FrontCenter = 2,
		LowFrequency = 3,
		SurroundLeft = 4,
		SurroundRight = 5,
		SurroundBackLeft = 6,
		SurroundBackRight = 7
	}

	public enum Format : uint // TypeDefIndex: 7001
	{
		ADX = 1,
		HCA = 3,
		HCA_MX = 4,
		WAVE = 5,
		RAW_PCM = 6
	}

	public struct FormatInfo // TypeDefIndex: 7002
	{
		// Fields
		public Format format; // 0x00
		public int samplingRate; // 0x04
		public long numSamples; // 0x08
		public long loopOffset; // 0x10
		public long loopLength; // 0x18
		public int numChannels; // 0x20
		public uint reserved; // 0x24
	}

	public struct AisacControlInfo // TypeDefIndex: 7003
	{
		// Fields
		public readonly string name; // 0x00
		public uint id; // 0x08

		// Constructors
		public AisacControlInfo(byte[] data, int startIndex) {
			name = default;
			id = default;
		} // 0x000000018775ED70-0x000000018775EEF0
	}

	public struct CuePos3dInfo // TypeDefIndex: 7004
	{
		// Fields
		public float coneInsideAngle; // 0x00
		public float coneOutsideAngle; // 0x04
		public float minAttenuationDistance; // 0x08
		public float maxAttenuationDistance; // 0x0C
		public float sourceRadius; // 0x10
		public float interiorDistance; // 0x14
		public float dopplerFactor; // 0x18
		public ushort distanceAisacControl; // 0x1C
		public ushort listenerBaseAngleAisacControl; // 0x1E
		public ushort sourceBaseAngleAisacControl; // 0x20
		public ushort listenerBaseElevationAisacControl; // 0x22
		public ushort sourceBaseElevationAisacControl; // 0x24
		public ushort[] reserved; // 0x28

		// Constructors
		public CuePos3dInfo(byte[] data, int startIndex) {
			coneInsideAngle = default;
			coneOutsideAngle = default;
			minAttenuationDistance = default;
			maxAttenuationDistance = default;
			sourceRadius = default;
			interiorDistance = default;
			dopplerFactor = default;
			distanceAisacControl = default;
			listenerBaseAngleAisacControl = default;
			sourceBaseAngleAisacControl = default;
			listenerBaseElevationAisacControl = default;
			sourceBaseElevationAisacControl = default;
			reserved = default;
		} // 0x00000001877780D0-0x00000001877782F0
	}

	public struct GameVariableInfo // TypeDefIndex: 7005
	{
		// Fields
		public readonly string name; // 0x00
		public uint id; // 0x08
		public float gameValue; // 0x0C

		// Constructors
		public GameVariableInfo(byte[] data, int startIndex) {
			name = default;
			id = default;
			gameValue = default;
		} // 0x0000000187778C30-0x0000000187778D20
		public GameVariableInfo(string name, uint id, float gameValue) {
			this.name = default;
			this.id = default;
			this.gameValue = default;
		} // 0x0000000187778A70-0x0000000187778C30
	}

	public enum CueType // TypeDefIndex: 7006
	{
		Polyphonic = 0,
		Sequential = 1,
		Shuffle = 2,
		Random = 3,
		RandomNoRepeat = 4,
		SwitchGameVariable = 5,
		ComboSequential = 6,
		SwitchSelector = 7,
		TrackTransitionBySelector = 8
	}

	public struct CueInfo // TypeDefIndex: 7007
	{
		// Fields
		public int id; // 0x00
		public CueType type; // 0x04
		public readonly string name; // 0x08
		public readonly string userData; // 0x10
		public long length; // 0x18
		public ushort[] categories; // 0x20
		public short numLimits; // 0x28
		public ushort numBlocks; // 0x2A
		public ushort numTracks; // 0x2C
		public ushort numRelatedWaveForms; // 0x2E
		public byte priority; // 0x30
		public byte headerVisibility; // 0x31
		public byte ignore_player_parameter; // 0x32
		public byte probability; // 0x33
		public PanType panType; // 0x34
		public CuePos3dInfo pos3dInfo; // 0x38
		public GameVariableInfo gameVariableInfo; // 0x68

		// Constructors
		public CueInfo(byte[] data, int startIndex) {
			id = default;
			type = default;
			name = default;
			userData = default;
			length = default;
			categories = default;
			numLimits = default;
			numBlocks = default;
			numTracks = default;
			numRelatedWaveForms = default;
			priority = default;
			headerVisibility = default;
			ignore_player_parameter = default;
			probability = default;
			panType = default;
			pos3dInfo = default;
			gameVariableInfo = default;
		} // 0x00000001877779B0-0x00000001877780D0
	}

	public struct WaveformInfo // TypeDefIndex: 7008
	{
		// Fields
		public int waveId; // 0x00
		public uint format; // 0x04
		public int samplingRate; // 0x08
		public int numChannels; // 0x0C
		public long numSamples; // 0x10
		public bool streamingFlag; // 0x18
		public uint[] reserved; // 0x20

		// Constructors
		public WaveformInfo(byte[] data, int startIndex) {
			waveId = default;
			format = default;
			samplingRate = default;
			numChannels = default;
			numSamples = default;
			streamingFlag = default;
			reserved = default;
		} // 0x000000018777D070-0x000000018777D180
	}

	public struct AisacInfo // TypeDefIndex: 7009
	{
		// Fields
		public readonly string name; // 0x00
		public bool defaultControlFlag; // 0x08
		public float defaultControlValue; // 0x0C
		public uint controlId; // 0x10
		public readonly string controlName; // 0x18

		// Constructors
		public AisacInfo(byte[] data, int startIndex) {
			name = default;
			defaultControlFlag = default;
			defaultControlValue = default;
			controlId = default;
			controlName = default;
		} // 0x000000018775F160-0x000000018775F240
	}

	public struct PerformanceInfo // TypeDefIndex: 7010
	{
		// Fields
		public uint serverProcessCount; // 0x00
		public uint lastServerTime; // 0x04
		public uint maxServerTime; // 0x08
		public uint averageServerTime; // 0x0C
		public uint lastServerInterval; // 0x10
		public uint maxServerInterval; // 0x14
		public uint averageServerInterval; // 0x18
	}

	public struct ResourceUsage // TypeDefIndex: 7011
	{
		// Fields
		public uint useCount; // 0x00
		public uint limit; // 0x04
	}

	public struct NativeVector // TypeDefIndex: 7012
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08

		// Constructors
		public NativeVector(float x, float y, float z) {
			this.x = default;
			this.y = default;
			this.z = default;
		} // 0x0000000187779450-0x0000000187779460
		public NativeVector(Vector3 vector) {
			x = default;
			y = default;
			z = default;
		} // 0x0000000187779330-0x0000000187779450
	}

	// Methods
	public static void RegisterAcf(CriFsBinder binder, string acfPath) {} // 0x0000000187771FD0-0x0000000187772070
	public static void RegisterAcf(IntPtr acfData, int dataSize) {} // 0x00000001877720F0-0x0000000187772170
	[Obsolete] // 0x00000001898B2EF0-0x00000001898B2F20
	public static void RegisterAcf(byte[] acfData) {} // 0x0000000187772070-0x00000001877720F0
	public static void UnregisterAcf() {} // 0x0000000187772670-0x00000001877726D0
	public static void AttachDspBusSetting(string settingName) {} // 0x0000000187771890-0x0000000187771900
	public static void DetachDspBusSetting() {} // 0x0000000187771900-0x0000000187771960
	public static void ApplyDspBusSnapshot(string snapshot_name, int time_ms) {} // 0x0000000187771810-0x0000000187771890
	public static int GetNumGameVariables() => default; // 0x0000000187771D90-0x0000000187771DF0
	public static bool GetGameVariableInfo(ushort index, out GameVariableInfo info) {
		info = default;
		return default;
	} // 0x0000000187771AF0-0x0000000187771C40
	public static float GetGameVariable(uint game_variable_id) => default; // 0x0000000187771C40-0x0000000187771CB0
	public static float GetGameVariable(string game_variable_name) => default; // 0x0000000187771CB0-0x0000000187771D30
	public static void SetGameVariable(uint game_variable_id, float game_variable_value) {} // 0x0000000187772250-0x00000001877722D0
	public static void SetGameVariable(string game_variable_name, float game_variable_value) {} // 0x00000001877721D0-0x0000000187772250
	public static void SetRandomSeed(uint seed) {} // 0x00000001877725A0-0x0000000187772610
	public static void ResetPerformanceMonitor() {} // 0x0000000187772170-0x00000001877721D0
	public static void GetPerformanceInfo(out PerformanceInfo info) {
		info = default;
	} // 0x0000000187771DF0-0x0000000187771E60
	public static void SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index) {} // 0x00000001877722D0-0x0000000187772350
	public static void SetGlobalLabelToSelectorByName(string selector_name, string label_name) {} // 0x0000000187772350-0x00000001877723D0
	public static void Lock() {} // 0x0000000187771F70-0x0000000187771FD0
	public static void Unlock() {} // 0x0000000187772610-0x0000000187772670
	public static void SetOutputAudioDevice_PC(string deviceId) {} // 0x0000000187772450-0x0000000187772550
	public static bool LoadAudioDeviceList_PC() => default; // 0x0000000187771F00-0x0000000187771F70
	public static int GetNumAudioDevices_PC() => default; // 0x0000000187771D30-0x0000000187771D90
	public static string GetAudioDeviceName_PC(int index) => default; // 0x0000000187771960-0x0000000187771AF0
	public static void SetOutputAudioDevice_PC(int index) {} // 0x00000001877723D0-0x0000000187772450
	public static void SetOutputVolume_VITA(float volume) {} // 0x0000000187772550-0x00000001877725A0
	public static bool IsBgmPortAcquired_VITA() => default; // 0x0000000187771E60-0x0000000187771EB0
	public static bool IsSoundStopped_IOS() => default; // 0x0000000187771EB0-0x0000000187771F00
	private static extern bool criAtomEx_RegisterAcfFile(IntPtr binder, string path, IntPtr work, int workSize); // 0x00000001877732E0-0x0000000187773410
	private static extern void criAtomEx_RegisterAcfData(IntPtr acfData, int acfDataSize, IntPtr work, int workSize); // 0x00000001877730C0-0x00000001877731D0
	private static extern void criAtomEx_RegisterAcfData(byte[] acfData, int acfDataSize, IntPtr work, int workSize); // 0x00000001877731D0-0x00000001877732E0
	private static extern void criAtomEx_UnregisterAcf(); // 0x00000001877737D0-0x00000001877738B0
	private static extern void criAtomEx_AttachDspBusSetting(string settingName, IntPtr work, int workSize); // 0x0000000187772A00-0x0000000187772B20
	private static extern void criAtomEx_DetachDspBusSetting(); // 0x0000000187772B20-0x0000000187772C00
	private static extern void criAtomEx_ApplyDspBusSnapshot(string snapshot_name, int time_ms); // 0x00000001877728F0-0x0000000187772A00
	private static extern int criAtomEx_GetNumGameVariables(); // 0x0000000187772F00-0x0000000187772FE0
	private static extern bool criAtomEx_GetGameVariableInfo(ushort index, IntPtr game_variable_info); // 0x0000000187772E00-0x0000000187772F00
	private static extern float criAtomEx_GetGameVariableById(uint game_variable_id); // 0x0000000187772C00-0x0000000187772CF0
	private static extern float criAtomEx_GetGameVariableByName(string game_variable_name); // 0x0000000187772CF0-0x0000000187772E00
	private static extern void criAtomEx_SetGameVariableById(uint game_variable_id, float game_variable_value); // 0x0000000187773410-0x0000000187773500
	private static extern void criAtomEx_SetGameVariableByName(string game_variable_name, float game_variable_value); // 0x0000000187773500-0x0000000187773610
	private static extern void criAtomEx_SetRandomSeed(uint seed); // 0x0000000187773610-0x00000001877736F0
	private static extern void criAtomEx_Lock(); // 0x0000000187772FE0-0x00000001877730C0
	private static extern void criAtomEx_Unlock(); // 0x00000001877736F0-0x00000001877737D0
	private static extern void criAtom_ResetPerformanceMonitor(); // 0x0000000187773D70-0x0000000187773E50
	private static extern void criAtom_GetPerformanceInfo(out PerformanceInfo info); // 0x0000000187773C50-0x0000000187773D70
	private static extern void criAtomExAcf_SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index); // 0x00000001877726D0-0x00000001877727D0
	private static extern void criAtomExAcf_SetGlobalLabelToSelectorByName(string selector_name, string label_name); // 0x00000001877727D0-0x00000001877728F0
	private static extern void criAtom_SetDeviceId_WASAPI(SoundRendererType soundRendererType, string deviceId); // 0x0000000187773E50-0x0000000187773F50
	private static extern void criAtom_SetDeviceId_WASAPI(SoundRendererType type, IntPtr deviceId); // 0x0000000187773F50-0x0000000187774040
	private static extern bool criAtomUnity_LoadAudioDeviceList_PC(); // 0x0000000187773B70-0x0000000187773C50
	private static extern int criAtomUnity_GetNumAudioDevices_PC(); // 0x0000000187773A90-0x0000000187773B70
	private static extern IntPtr criAtomUnity_GetAudioDeviceName_PC(int index); // 0x00000001877739A0-0x0000000187773A90
	private static extern IntPtr criAtomUnity_GetAudioDeviceId_PC(int index); // 0x00000001877738B0-0x00000001877739A0
}

