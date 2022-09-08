/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAtomExPlayer : CriDisposable // TypeDefIndex: 7082
{
	// Fields
	private bool hasExistingNativeHandle; // 0x20
	private IntPtr entryPoolHandle; // 0x28
	private int _entryPoolCapacity; // 0x30
	private int max_path; // 0x34
	private IntPtr handle; // 0x38

	// Properties
	public IntPtr nativeHandle { get => default; } // 0x00000001877B9C40-0x00000001877B9CA0 
	public bool isAvailable { get => default; } // 0x00000001877B9BD0-0x00000001877B9C40 
	public int entryPoolCapacity { get => default; } // 0x00000001877B9B70-0x00000001877B9BD0 

	// Nested types
	public enum Status // TypeDefIndex: 7083
	{
		Stop = 0,
		Prep = 1,
		Playing = 2,
		PlayEnd = 3,
		Error = 4
	}

	private struct Config // TypeDefIndex: 7084
	{
		// Fields
		public CriAtomEx.VoiceAllocationMethod voiceAllocationMethod; // 0x00
		public int maxPathStrings; // 0x04
		public int maxPath; // 0x08
		public int maxAisacs; // 0x0C
		public bool updatesTime; // 0x10
		public bool enableAudioSyncedTimer; // 0x11
	}

	public enum TimeStretchParameterId // TypeDefIndex: 7085
	{
		Ratio = 0,
		FrameTime = 1,
		Quality = 2
	}

	public enum PitchShifterParameterId // TypeDefIndex: 7086
	{
		Pitch = 0,
		Formant = 1,
		Mode = 2
	}

	// Constructors
	public CriAtomExPlayer() {} // 0x00000001877B4480-0x00000001877B4500
	public CriAtomExPlayer(int maxPath, int maxPathStrings) {} // 0x00000001877B4500-0x00000001877B4590
	public CriAtomExPlayer(bool enableAudioSyncedTimer) {} // 0x00000001877B4620-0x00000001877B46A0
	public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer) {} // 0x00000001877B43E0-0x00000001877B4480
	public CriAtomExPlayer(IntPtr existingNativeHandle) {} // 0x00000001877B4590-0x00000001877B4620
	public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer, IntPtr existingNativeHandle) {} // 0x00000001877B4230-0x00000001877B43E0

	// Methods
	public override void Dispose() {} // 0x00000001877B0E70-0x00000001877B0F70
	public void SetCue(CriAtomExAcb acb, string name) {} // 0x00000001877B2940-0x00000001877B29E0
	public void SetCue(CriAtomExAcb acb, int id) {} // 0x00000001877B28A0-0x00000001877B2940
	public void SetCueIndex(CriAtomExAcb acb, int index) {} // 0x00000001877B2780-0x00000001877B2820
	public void SetContentId(CriFsBinder binder, int contentId) {} // 0x00000001877B26E0-0x00000001877B2780
	public void SetFile(CriFsBinder binder, string path) {} // 0x00000001877B3120-0x00000001877B31C0
	public void SetData(byte[] buffer, int size) {} // 0x00000001877B2A70-0x00000001877B2B00
	public void SetData(IntPtr buffer, int size) {} // 0x00000001877B29E0-0x00000001877B2A70
	public void SetFormat(CriAtomEx.Format format) {} // 0x00000001877B3240-0x00000001877B32C0
	public void SetNumChannels(int numChannels) {} // 0x00000001877B3340-0x00000001877B33C0
	public void SetSamplingRate(int samplingRate) {} // 0x00000001877B37C0-0x00000001877B3840
	public void PrepareEntryPool(int capacity, bool stopOnEmpty) {} // 0x00000001877B1B50-0x00000001877B1C30
	public int GetNumEntries() => default; // 0x00000001877B15C0-0x00000001877B1640
	public bool EntryFile(CriFsBinder binder, string path, bool repeat) => default; // 0x00000001877B12B0-0x00000001877B1390
	public bool EntryContentId(CriFsBinder binder, int contentId, bool repeat) => default; // 0x00000001877B0F70-0x00000001877B1050
	public bool EntryData(byte[] buffer, int size, bool repeat) => default; // 0x00000001877B11F0-0x00000001877B12B0
	public bool EntryData(IntPtr buffer, int size, bool repeat) => default; // 0x00000001877B1130-0x00000001877B11F0
	public bool EntryCue(CriAtomExAcb acb, string name, bool repeat) => default; // 0x00000001877B1050-0x00000001877B1130
	public CriAtomExPlayback Start() => default; // 0x00000001877B3CF0-0x00000001877B3DD0
	public CriAtomExPlayback Prepare() => default; // 0x00000001877B1C30-0x00000001877B1D10
	public void Stop(bool ignoresReleaseTime) {} // 0x00000001877B3F90-0x00000001877B4090
	public void Pause() {} // 0x00000001877B1A60-0x00000001877B1AD0
	public void Resume(CriAtomEx.ResumeMode mode) {} // 0x00000001877B1DF0-0x00000001877B1E70
	public bool IsPaused() => default; // 0x00000001877B1920-0x00000001877B1990
	public void SetVolume(float volume) {} // 0x00000001877B3C70-0x00000001877B3CF0
	public void SetPitch(float pitch) {} // 0x00000001877B35C0-0x00000001877B3640
	public void SetPlaybackRatio(float ratio) {} // 0x00000001877B3640-0x00000001877B36C0
	public void SetPan3dAngle(float angle) {} // 0x00000001877B33C0-0x00000001877B3440
	public void SetPan3dInteriorDistance(float distance) {} // 0x00000001877B3440-0x00000001877B34C0
	public void SetPan3dVolume(float volume) {} // 0x00000001877B34C0-0x00000001877B3540
	public void SetPanType(CriAtomEx.PanType panType) {} // 0x00000001877B3540-0x00000001877B35C0
	public void SetSendLevel(int channel, CriAtomEx.Speaker id, float level) {} // 0x00000001877B38D0-0x00000001877B3970
	public void SetBiquadFilterParameters(CriAtomEx.BiquadFilterType type, float frequency, float gain, float q) {} // 0x00000001877B22E0-0x00000001877B23A0
	public void SetBandpassFilterParameters(float cofLow, float cofHigh) {} // 0x00000001877B2250-0x00000001877B22E0
	public void SetBusSendLevel(string busName, float level) {} // 0x00000001877B24C0-0x00000001877B2550
	[Obsolete] // 0x000000018998B880-0x000000018998B8B0
	public void SetBusSendLevel(int busId, float level) {} // 0x00000001877B2550-0x00000001877B25E0
	public void SetBusSendLevelOffset(string busName, float levelOffset) {} // 0x00000001877B2430-0x00000001877B24C0
	[Obsolete] // 0x0000000189994C60-0x0000000189994C90
	public void SetBusSendLevelOffset(int busId, float levelOffset) {} // 0x00000001877B23A0-0x00000001877B2430
	public void AttachAisac(string globalAisacName) {} // 0x00000001877AFF90-0x00000001877B0010
	public void DetachAisac(string globalAisacName) {} // 0x00000001877B0C50-0x00000001877B0CD0
	public void SetAisacControl(string controlName, float value) {} // 0x00000001877B1F90-0x00000001877B2020
	[Obsolete] // 0x000000018999DD40-0x000000018999DD70
	public void SetAisac(string controlName, float value) {} // 0x00000001877B20B0-0x00000001877B2140
	public void SetAisacControl(uint controlId, float value) {} // 0x00000001877B2020-0x00000001877B20B0
	[Obsolete] // 0x00000001899A6E30-0x00000001899A6E60
	public void SetAisac(uint controlId, float value) {} // 0x00000001877B2140-0x00000001877B21D0
	public bool GetAttachedAisacInfo(int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo) {
		aisacInfo = default;
		return default;
	} // 0x00000001877B1440-0x00000001877B15C0
	public void Set3dSource(CriAtomEx3dSource source) {} // 0x00000001877B1F00-0x00000001877B1F90
	public void Set3dListener(CriAtomEx3dListener listener) {} // 0x00000001877B1E70-0x00000001877B1F00
	public void SetStartTime(long startTimeMs) {} // 0x00000001877B3A70-0x00000001877B3AF0
	public void SetFirstBlockIndex(int index) {} // 0x00000001877B31C0-0x00000001877B3240
	public void SetSelectorLabel(string selector, string label) {} // 0x00000001877B3840-0x00000001877B38D0
	public void ClearSelectorLabels() {} // 0x00000001877B0BE0-0x00000001877B0C50
	public void SetCategory(int categoryId) {} // 0x00000001877B25E0-0x00000001877B2660
	public void SetCategory(string categoryName) {} // 0x00000001877B2660-0x00000001877B26E0
	public void UnsetCategory() {} // 0x00000001877B4090-0x00000001877B4100
	public void SetCuePriority(int priority) {} // 0x00000001877B2820-0x00000001877B28A0
	public void SetVoicePriority(int priority) {} // 0x00000001877B3BF0-0x00000001877B3C70
	public void SetVoiceControlMethod(CriAtomEx.VoiceControlMethod method) {} // 0x00000001877B3AF0-0x00000001877B3B70
	public void SetPreDelayTime(float time) {} // 0x00000001877B36C0-0x00000001877B3740
	public void SetEnvelopeAttackTime(float time) {} // 0x00000001877B2CA0-0x00000001877B2D20
	public void SetEnvelopeHoldTime(float time) {} // 0x00000001877B2DA0-0x00000001877B2E20
	public void SetEnvelopeDecayTime(float time) {} // 0x00000001877B2D20-0x00000001877B2DA0
	public void SetEnvelopeReleaseTime(float time) {} // 0x00000001877B2E20-0x00000001877B2EA0
	public void SetEnvelopeSustainLevel(float level) {} // 0x00000001877B2EA0-0x00000001877B2F20
	public void AttachFader() {} // 0x00000001877B0010-0x00000001877B0090
	public void DetachFader() {} // 0x00000001877B0CD0-0x00000001877B0D40
	public void SetFadeOutTime(int ms) {} // 0x00000001877B30A0-0x00000001877B3120
	public void SetFadeInTime(int ms) {} // 0x00000001877B2FA0-0x00000001877B3020
	public void SetFadeInStartOffset(int ms) {} // 0x00000001877B2F20-0x00000001877B2FA0
	public void SetFadeOutEndDelay(int ms) {} // 0x00000001877B3020-0x00000001877B30A0
	public bool IsFading() => default; // 0x00000001877B18B0-0x00000001877B1920
	public void ResetFaderParameters() {} // 0x00000001877B1D10-0x00000001877B1D80
	public void SetGroupNumber(int group_no) {} // 0x00000001877B32C0-0x00000001877B3340
	public void Update(CriAtomExPlayback playback) {} // 0x00000001877B4170-0x00000001877B4230
	public void UpdateAll() {} // 0x00000001877B4100-0x00000001877B4170
	public void ResetParameters() {} // 0x00000001877B1D80-0x00000001877B1DF0
	public long GetTime() => default; // 0x00000001877B1840-0x00000001877B18B0
	public Status GetStatus() => default; // 0x00000001877B17D0-0x00000001877B1840
	public float GetParameterFloat32(CriAtomEx.Parameter id) => default; // 0x00000001877B1640-0x00000001877B16D0
	public uint GetParameterUint32(CriAtomEx.Parameter id) => default; // 0x00000001877B1750-0x00000001877B17D0
	public int GetParameterSint32(CriAtomEx.Parameter id) => default; // 0x00000001877B16D0-0x00000001877B1750
	public void SetSoundRendererType(CriAtomEx.SoundRendererType type) {} // 0x00000001877B39F0-0x00000001877B3A70
	public void SetRandomSeed(uint seed) {} // 0x00000001877B3740-0x00000001877B37C0
	public void Loop(bool sw) {} // 0x00000001877B1990-0x00000001877B1A60
	public void SetAsrRackId(int asr_rack_id) {} // 0x00000001877B21D0-0x00000001877B2250
	public void SetVoicePoolIdentifier(uint identifier) {} // 0x00000001877B3B70-0x00000001877B3BF0
	public void SetDspTimeStretchRatio(float ratio) {} // 0x00000001877B2C20-0x00000001877B2CA0
	public void SetDspPitchShifterPitch(float pitch) {} // 0x00000001877B2B90-0x00000001877B2C20
	public void SetDspParameter(int id, float value) {} // 0x00000001877B2B00-0x00000001877B2B90
	public void SetSequencePrepareTime(uint ms) {} // 0x00000001877B3970-0x00000001877B39F0
	public void AttachTween(CriAtomExTween tween) {} // 0x00000001877B0090-0x00000001877B0150
	public void DetachTween(CriAtomExTween tween) {} // 0x00000001877B0DB0-0x00000001877B0E70
	public void DetachTweenAll() {} // 0x00000001877B0D40-0x00000001877B0DB0
	public void Stop() {} // 0x00000001877B3EB0-0x00000001877B3F90
	public void StopWithoutReleaseTime() {} // 0x00000001877B3DD0-0x00000001877B3EB0
	public void Pause(bool sw) {} // 0x00000001877B1AD0-0x00000001877B1B50
	~CriAtomExPlayer() {} // 0x00000001877B1390-0x00000001877B1440
	private static extern IntPtr criAtomExPlayer_Create(ref Config config, IntPtr work, int work_size); // 0x00000001877B4BB0-0x00000001877B4D30
	private static extern void criAtomExPlayer_Destroy(IntPtr player); // 0x00000001877B4D30-0x00000001877B4E20
	private static extern void criAtomExPlayer_SetCueId(IntPtr player, IntPtr acb_hn, int id); // 0x00000001877B6F40-0x00000001877B7040
	private static extern void criAtomExPlayer_SetCueName(IntPtr player, IntPtr acb_hn, string cue_name); // 0x00000001877B7140-0x00000001877B7260
	private static extern void criAtomExPlayer_SetCueIndex(IntPtr player, IntPtr acb_hn, int index); // 0x00000001877B7040-0x00000001877B7140
	private static extern void criAtomExPlayer_SetFile(IntPtr player, IntPtr binder, string path); // 0x00000001877B7F30-0x00000001877B8050
	private static extern void criAtomExPlayer_SetData(IntPtr player, byte[] buffer, int size); // 0x00000001877B7450-0x00000001877B7560
	private static extern void criAtomExPlayer_SetData(IntPtr player, IntPtr buffer, int size); // 0x00000001877B7350-0x00000001877B7450
	private static extern void criAtomExPlayer_SetContentId(IntPtr player, IntPtr binder, int id); // 0x00000001877B6E40-0x00000001877B6F40
	private static extern void criAtomExPlayer_SetVoicePoolIdentifier(IntPtr player, uint identifier); // 0x00000001877B92F0-0x00000001877B93E0
	private static extern uint criAtomExPlayer_Start(IntPtr player); // 0x00000001877B95D0-0x00000001877B96C0
	private static extern uint criAtomExPlayer_Prepare(IntPtr player); // 0x00000001877B5CD0-0x00000001877B5DC0
	private static extern void criAtomExPlayer_Stop(IntPtr player); // 0x00000001877B97B0-0x00000001877B98A0
	private static extern void criAtomExPlayer_StopWithoutReleaseTime(IntPtr player); // 0x00000001877B96C0-0x00000001877B97B0
	private static extern void criAtomExPlayer_Pause(IntPtr player, bool sw); // 0x00000001877B5BD0-0x00000001877B5CD0
	private static extern void criAtomExPlayer_Resume(IntPtr player, CriAtomEx.ResumeMode mode); // 0x00000001877B5FA0-0x00000001877B6090
	private static extern bool criAtomExPlayer_IsPaused(IntPtr player); // 0x00000001877B59F0-0x00000001877B5AE0
	private static extern Status criAtomExPlayer_GetStatus(IntPtr player); // 0x00000001877B5720-0x00000001877B5810
	private static extern long criAtomExPlayer_GetTime(IntPtr player); // 0x00000001877B5810-0x00000001877B5900
	private static extern void criAtomExPlayer_SetFormat(IntPtr player, CriAtomEx.Format format); // 0x00000001877B8140-0x00000001877B8230
	private static extern void criAtomExPlayer_SetNumChannels(IntPtr player, int num_channels); // 0x00000001877B8320-0x00000001877B8410
	private static extern void criAtomExPlayer_SetSamplingRate(IntPtr player, int sampling_rate); // 0x00000001877B8BF0-0x00000001877B8CE0
	private static extern IntPtr CRIWAREC8FAAC28(IntPtr player, int capacity, int max_path, bool stopOnEmpty); // 0x00000001877B07B0-0x00000001877B08C0
	private static extern void CRIWARE6AFC0850(IntPtr pool); // 0x00000001877B0580-0x00000001877B0670
	private static extern int CRIWAREEE689E04(IntPtr pool); // 0x00000001877B0AF0-0x00000001877B0BE0
	private static extern bool CRIWARE7DDABDA6(IntPtr pool, IntPtr binder, string path, bool repeat, int max_path); // 0x00000001877B0670-0x00000001877B07B0
	private static extern bool CRIWARE605CC5D9(IntPtr pool, IntPtr binder, int id, bool repeat); // 0x00000001877B0380-0x00000001877B0490
	private static extern bool CRIWAREEA68FF0A(IntPtr pool, byte[] buffer, int size, bool repeat); // 0x00000001877B09D0-0x00000001877B0AF0
	private static extern bool CRIWAREEA68FF0A(IntPtr pool, IntPtr buffer, int size, bool repeat); // 0x00000001877B08C0-0x00000001877B09D0
	private static extern bool CRIWARE46F72CF1(IntPtr pool, IntPtr acbhn, string name, bool repeat); // 0x00000001877B0250-0x00000001877B0380
	private static extern void CRIWARE6119A54B(IntPtr pool); // 0x00000001877B0490-0x00000001877B0580
	private static extern void criAtomExPlayer_SetStartTime(IntPtr player, long start_time_ms); // 0x00000001877B9100-0x00000001877B9200
	private static extern void criAtomExPlayer_SetSequencePrepareTime(IntPtr player, uint seq_prep_time_ms); // 0x00000001877B8F20-0x00000001877B9010
	private static extern void criAtomExPlayer_LimitLoopCount(IntPtr player, int count); // 0x00000001877B5AE0-0x00000001877B5BD0
	private static extern void criAtomExPlayer_Update(IntPtr player, uint id); // 0x00000001877B9A80-0x00000001877B9B70
	private static extern void criAtomExPlayer_UpdateAll(IntPtr player); // 0x00000001877B9990-0x00000001877B9A80
	private static extern void criAtomExPlayer_ResetParameters(IntPtr player); // 0x00000001877B5EB0-0x00000001877B5FA0
	private static extern float criAtomExPlayer_GetParameterFloat32(IntPtr player, CriAtomEx.Parameter id); // 0x00000001877B5320-0x00000001877B5430
	private static extern uint criAtomExPlayer_GetParameterUint32(IntPtr player, CriAtomEx.Parameter id); // 0x00000001877B5530-0x00000001877B5630
	private static extern int criAtomExPlayer_GetParameterSint32(IntPtr player, CriAtomEx.Parameter id); // 0x00000001877B5430-0x00000001877B5530
	private static extern IntPtr criAtomExPlayer_GetPlayerParameter(IntPtr player); // 0x00000001877B5630-0x00000001877B5720
	private static extern void criAtomExPlayerParameter_RemoveParameter(IntPtr player_parameter, ushort id); // 0x00000001877B46A0-0x00000001877B47A0
	private static extern void criAtomExPlayer_SetVolume(IntPtr player, float volume); // 0x00000001877B94D0-0x00000001877B95D0
	private static extern void criAtomExPlayer_SetPitch(IntPtr player, float pitch); // 0x00000001877B8800-0x00000001877B8900
	private static extern void criAtomExPlayer_SetPlaybackRatio(IntPtr player, float playback_ratio); // 0x00000001877B8900-0x00000001877B8A00
	private static extern void criAtomExPlayer_SetPan3dAngle(IntPtr player, float pan3d_angle); // 0x00000001877B8410-0x00000001877B8510
	private static extern void criAtomExPlayer_SetPan3dInteriorDistance(IntPtr player, float pan3d_interior_distance); // 0x00000001877B8510-0x00000001877B8610
	private static extern void criAtomExPlayer_SetPan3dVolume(IntPtr player, float pan3d_volume); // 0x00000001877B8610-0x00000001877B8710
	private static extern void criAtomExPlayer_SetPanType(IntPtr player, CriAtomEx.PanType panType); // 0x00000001877B8710-0x00000001877B8800
	private static extern void criAtomExPlayer_SetSendLevel(IntPtr player, int channel, CriAtomEx.Speaker id, float level); // 0x00000001877B8E10-0x00000001877B8F20
	private static extern void criAtomExPlayer_SetBusSendLevel(IntPtr player, int bus_id, float level); // 0x00000001877B6B30-0x00000001877B6C40
	private static extern void criAtomExPlayer_SetBusSendLevelByName(IntPtr player, string bus_name, float level); // 0x00000001877B67E0-0x00000001877B6900
	private static extern void criAtomExPlayer_SetBusSendLevelOffset(IntPtr player, int bus_id, float level_offset); // 0x00000001877B6A20-0x00000001877B6B30
	private static extern void criAtomExPlayer_SetBusSendLevelOffsetByName(IntPtr player, string bus_name, float level_offset); // 0x00000001877B6900-0x00000001877B6A20
	private static extern void criAtomExPlayer_SetBandpassFilterParameters(IntPtr player, float cof_low, float cof_high); // 0x00000001877B65B0-0x00000001877B66C0
	private static extern void criAtomExPlayer_SetBiquadFilterParameters(IntPtr player, CriAtomEx.BiquadFilterType type, float frequency, float gain, float q); // 0x00000001877B66C0-0x00000001877B67E0
	private static extern void criAtomExPlayer_SetVoicePriority(IntPtr player, int priority); // 0x00000001877B93E0-0x00000001877B94D0
	private static extern void criAtomExPlayer_SetVoiceControlMethod(IntPtr player, CriAtomEx.VoiceControlMethod method); // 0x00000001877B9200-0x00000001877B92F0
	private static extern void criAtomExPlayer_SetAisacControlById(IntPtr player, ushort control_id, float control_value); // 0x00000001877B6290-0x00000001877B63A0
	private static extern void criAtomExPlayer_SetAisacControlByName(IntPtr player, string control_name, float control_value); // 0x00000001877B63A0-0x00000001877B64C0
	private static extern void criAtomExPlayer_Set3dSourceHn(IntPtr player, IntPtr source); // 0x00000001877B6190-0x00000001877B6290
	private static extern void criAtomExPlayer_Set3dListenerHn(IntPtr player, IntPtr listener); // 0x00000001877B6090-0x00000001877B6190
	private static extern void criAtomExPlayer_SetCategoryById(IntPtr player, uint category_id); // 0x00000001877B6C40-0x00000001877B6D30
	private static extern void criAtomExPlayer_SetCategoryByName(IntPtr player, string category_name); // 0x00000001877B6D30-0x00000001877B6E40
	private static extern void criAtomExPlayer_UnsetCategory(IntPtr player); // 0x00000001877B98A0-0x00000001877B9990
	private static extern void criAtomExPlayer_SetCuePriority(IntPtr player, int cue_priority); // 0x00000001877B7260-0x00000001877B7350
	private static extern void criAtomExPlayer_SetPreDelayTime(IntPtr player, float predelay_time_ms); // 0x00000001877B8A00-0x00000001877B8B00
	private static extern void criAtomExPlayer_SetEnvelopeAttackTime(IntPtr player, float attack_time_ms); // 0x00000001877B7670-0x00000001877B7770
	private static extern void criAtomExPlayer_SetEnvelopeHoldTime(IntPtr player, float hold_time_ms); // 0x00000001877B7870-0x00000001877B7970
	private static extern void criAtomExPlayer_SetEnvelopeDecayTime(IntPtr player, float decay_time_ms); // 0x00000001877B7770-0x00000001877B7870
	private static extern void criAtomExPlayer_SetEnvelopeReleaseTime(IntPtr player, float release_time_ms); // 0x00000001877B7970-0x00000001877B7A70
	private static extern void criAtomExPlayer_SetEnvelopeSustainLevel(IntPtr player, float susutain_level); // 0x00000001877B7A70-0x00000001877B7B70
	private static extern void criAtomExPlayer_AttachFader(IntPtr player, IntPtr config, IntPtr work, int work_size); // 0x00000001877B48B0-0x00000001877B49C0
	private static extern void criAtomExPlayer_AttachAisac(IntPtr player, string globalAisacName); // 0x00000001877B47A0-0x00000001877B48B0
	private static extern void criAtomExPlayer_DetachAisac(IntPtr player, string globalAisacName); // 0x00000001877B4E20-0x00000001877B4F30
	private static extern void criAtomExPlayer_DetachFader(IntPtr player); // 0x00000001877B4F30-0x00000001877B5020
	private static extern void criAtomExPlayer_SetFadeOutTime(IntPtr player, int ms); // 0x00000001877B7E40-0x00000001877B7F30
	private static extern void criAtomExPlayer_SetFadeInTime(IntPtr player, int ms); // 0x00000001877B7C60-0x00000001877B7D50
	private static extern void criAtomExPlayer_SetFadeInStartOffset(IntPtr player, int ms); // 0x00000001877B7B70-0x00000001877B7C60
	private static extern void criAtomExPlayer_SetFadeOutEndDelay(IntPtr player, int ms); // 0x00000001877B7D50-0x00000001877B7E40
	private static extern bool criAtomExPlayer_IsFading(IntPtr player); // 0x00000001877B5900-0x00000001877B59F0
	private static extern void criAtomExPlayer_ResetFaderParameters(IntPtr player); // 0x00000001877B5DC0-0x00000001877B5EB0
	private static extern void criAtomExPlayer_SetGroupNumber(IntPtr player, int group_no); // 0x00000001877B8230-0x00000001877B8320
	private static extern bool criAtomExPlayer_GetAttachedAisacInfo(IntPtr player, int aisac_attached_index, IntPtr aisac_info); // 0x00000001877B5210-0x00000001877B5320
	private static extern void criAtomExPlayer_SetFirstBlockIndex(IntPtr player, int index); // 0x00000001877B8050-0x00000001877B8140
	private static extern void criAtomExPlayer_SetSelectorLabel(IntPtr player, string selector, string label); // 0x00000001877B8CE0-0x00000001877B8E10
	private static extern void criAtomExPlayer_ClearSelectorLabels(IntPtr player); // 0x00000001877B4AC0-0x00000001877B4BB0
	private static extern void criAtomExPlayer_SetSoundRendererType(IntPtr player, CriAtomEx.SoundRendererType type); // 0x00000001877B9010-0x00000001877B9100
	private static extern void criAtomExPlayer_SetRandomSeed(IntPtr player, uint seed); // 0x00000001877B8B00-0x00000001877B8BF0
	private static extern void CRIWARE23C7E305(IntPtr player, bool sw); // 0x00000001877B0150-0x00000001877B0250
	private static extern void criAtomExPlayer_SetAsrRackId(IntPtr player, int asr_rack_id); // 0x00000001877B64C0-0x00000001877B65B0
	private static extern void criAtomExPlayer_SetDspParameter(IntPtr player, int id, float value); // 0x00000001877B7560-0x00000001877B7670
	private static extern void criAtomExPlayer_AttachTween(IntPtr player, IntPtr tween); // 0x00000001877B49C0-0x00000001877B4AC0
	private static extern void criAtomExPlayer_DetachTween(IntPtr player, IntPtr tween); // 0x00000001877B5110-0x00000001877B5210
	private static extern void criAtomExPlayer_DetachTweenAll(IntPtr player); // 0x00000001877B5020-0x00000001877B5110
}

