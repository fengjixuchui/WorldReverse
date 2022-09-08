/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using CriWare;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class CriAtomPlugin // TypeDefIndex: 6970
{
	// Fields
	private static int initializationCount; // 0x00
	private static List<IntPtr> effectInterfaceList; // 0x08
	private static bool isConfigured; // 0x10
	private static float timeSinceStartup; // 0x14
	private static Common.CpuUsage cpuUsage; // 0x18
	private static int CRIATOMUNITY_PARAMETER_ID_LOOP_COUNT; // 0x24
	private static ushort CRIATOMPARAMETER2_ID_INVALID; // 0x28
	private static ulong temporalStorage; // 0x30

	// Properties
	public static bool isInitialized { get; } // 0x00000001877C0B90-0x00000001877C0C20 

	// Nested types
	// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
	public delegate ulong CallbackFromNativeDelegate(IntPtr ptr1); // TypeDefIndex: 6971; 0x00000001877A2A10-0x00000001877A2BA0

	// Constructors
	static CriAtomPlugin() {} // 0x00000001877C0AC0-0x00000001877C0B90

	// Methods
	public static void Log(string log) {} // 0x00000001877C03B0-0x00000001877C0400
	public static bool GetAudioEffectInterfaceList(out List<IntPtr> effect_interface_list) {
		effect_interface_list = default;
		return default;
	} // 0x00000001877BF990-0x00000001877BFAF0
	private static IntPtr GetSpatializerCoreInterfaceFromAtomOculusAudioBridge() => default; // 0x00000001877BFE60-0x00000001877C0070
	public static void SetConfigParameters(int max_virtual_voices, int max_voice_limit_groups, int max_categories, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate, int num_asr_output_channels, bool uses_in_game_preview, float server_frequency, int max_parameter_blocks, int categories_per_playback, int num_buses, bool vr_mode) {} // 0x00000001877C0870-0x00000001877C0A30
	public static void SetConfigAdditionalParameters_PC(long buffering_time_pc) {} // 0x00000001877C06A0-0x00000001877C0730
	public static void SetConfigAdditionalParameters_LINUX(CriAtomConfig.LinuxOutput output, int pulse_latency_usec) {} // 0x00000001877C0610-0x00000001877C06A0
	public static void SetConfigAdditionalParameters_IOS(uint buffering_time_ios, bool override_ipod_music_ios) {} // 0x00000001877C0570-0x00000001877C0610
	public static void SetConfigAdditionalParameters_ANDROID(int num_low_delay_memory_voices, int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time, bool use_fast_mixer, bool use_aaudio) {} // 0x00000001877C04B0-0x00000001877C0570
	public static void SetConfigAdditionalParameters_VITA(int num_atrac9_memory_voices, int num_atrac9_streaming_voices, int num_mana_decoders) {} // 0x00000001877C07D0-0x00000001877C0820
	public static void SetConfigAdditionalParameters_PS4(int num_atrac9_memory_voices, int num_atrac9_streaming_voices, bool use_audio3d, int num_audio3d_memory_voices, int num_audio3d_streaming_voices) {} // 0x00000001877C0730-0x00000001877C0780
	public static void SetConfigAdditionalParameters_SWITCH(int num_opus_memory_voices, int num_opus_streaming_voices, bool init_socket) {} // 0x00000001877C0780-0x00000001877C07D0
	public static void SetConfigAdditionalParameters_WEBGL(int num_webaudio_voices) {} // 0x00000001877C0820-0x00000001877C0870
	public static void SetMaxSamplingRateForStandardVoicePool(int sampling_rate_for_memory, int sampling_rate_for_streaming) {} // 0x00000001877C0A30-0x00000001877C0AC0
	public static int GetRequiredMaxVirtualVoices(CriAtomConfig atomConfig) => default; // 0x00000001877BFDC0-0x00000001877BFE60
	public static void InitializeLibrary() {} // 0x00000001877C0070-0x00000001877C0330
	public static bool IsLibraryInitialized() => default; // 0x00000001877C0330-0x00000001877C03B0
	public static void FinalizeLibrary() {} // 0x00000001877BF730-0x00000001877BF990
	public static void Pause(bool pause) {} // 0x00000001877C0400-0x00000001877C04B0
	public static Common.CpuUsage GetCpuUsage() => default; // 0x00000001877BFAF0-0x00000001877BFCE0
	public static ushort GetLoopCountParameterId() => default; // 0x00000001877BFCE0-0x00000001877BFDC0
	public static void DecryptAcb(IntPtr acb_hn, ulong key, ulong nonce) {} // 0x00000001877BF570-0x00000001877BF730
	// [MonoPInvokeCallback] // 0x0000000189B6C2B0-0x0000000189B6C300
	private static ulong CallbackFromNative(IntPtr ptr1) => default; // 0x00000001877BF4E0-0x00000001877BF570
	private static extern void CRIWARE5C6445EA(int max_virtual_voices, int max_voice_limit_groups, int max_categories, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate, int num_asr_output_channels, bool uses_in_game_preview, float server_frequency, int max_parameter_blocks, int categories_per_playback, int num_buses, bool use_ambisonics, IntPtr spatializer_core_interface); // 0x00000001877BE8E0-0x00000001877BEAC0
	private static extern void CRIWARECBE1F916(long buffering_time_pc); // 0x00000001877BF220-0x00000001877BF310
	private static extern void CRIWARE5E9729B2(int output, int pulse_latency_usec); // 0x00000001877BEAC0-0x00000001877BEBB0
	private static extern void CRIWARE6E6C4A31(uint buffering_time_ios, bool override_ipod_music_ios); // 0x00000001877BECA0-0x00000001877BED90
	private static extern void CRIWARE4A98FA9C(int num_low_delay_memory_voices, int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time, bool apply_hw_property); // 0x00000001877BE7C0-0x00000001877BE8E0
	private static extern void CRIWARE044F4CBD(); // 0x00000001877BE150-0x00000001877BE230
	public static extern bool CRIWARE74F13712(); // 0x00000001877BEEA0-0x00000001877BEF80
	private static extern void CRIWARE0AC46773(); // 0x00000001877BE230-0x00000001877BE310
	private static extern void CRIWARED0B3D8F4(bool pause); // 0x00000001877BF310-0x00000001877BF400
	public static extern uint CRIWAREAEE74CFB(); // 0x00000001877BF140-0x00000001877BF220
	public static extern void CRIWARE7A85BD74(int code); // 0x00000001877BEF80-0x00000001877BF060
	public static extern void CRIWARE2D38DDC8(IntPtr cbfunc, string separator_string); // 0x00000001877BE310-0x00000001877BE420
	public static extern void CRIWAREDDEFE97E(); // 0x00000001877BF400-0x00000001877BF4E0
	public static extern void CRIWARE6388ABF2(IntPtr cbfunc); // 0x00000001877BEBB0-0x00000001877BECA0
	public static extern void CRIWARE34DD9B8F(); // 0x00000001877BE500-0x00000001877BE5E0
	private static extern void CRIWARE413373CC(int sampling_rate_for_memory, int sampling_rate_for_streaming); // 0x00000001877BE6D0-0x00000001877BE7C0
	public static extern void CRIWARE34BFBEA8(); // 0x00000001877BE420-0x00000001877BE500
	public static extern void CRIWAREA0ABAC50(); // 0x00000001877BF060-0x00000001877BF140
	public static extern void CRIWARE6E8A70F0(IntPtr acb_hn, CallbackFromNativeDelegate func, IntPtr obj); // 0x00000001877BED90-0x00000001877BEEA0
	public static extern ushort CRIWARE39B30E48(int id); // 0x00000001877BE5E0-0x00000001877BE6D0
}

