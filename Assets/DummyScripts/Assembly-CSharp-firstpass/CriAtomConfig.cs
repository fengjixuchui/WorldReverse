/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

[Serializable]
public class CriAtomConfig // TypeDefIndex: 7197
{
	// Fields
	public string acfFileName; // 0x10
	public int maxVirtualVoices; // 0x18
	public int maxVoiceLimitGroups; // 0x1C
	public int maxCategories; // 0x20
	public int maxSequenceEventsPerFrame; // 0x24
	public int maxBeatSyncCallbacksPerFrame; // 0x28
	public StandardVoicePoolConfig standardVoicePoolConfig; // 0x30
	public HcaMxVoicePoolConfig hcaMxVoicePoolConfig; // 0x38
	public int outputSamplingRate; // 0x40
	public bool usesInGamePreview; // 0x44
	public InGamePreviewSwitchMode inGamePreviewMode; // 0x48
	public bool switchInitializeSocket; // 0x4C
	public float serverFrequency; // 0x50
	public int asrOutputChannels; // 0x54
	public bool useRandomSeedWithTime; // 0x58
	public int categoriesPerPlayback; // 0x5C
	public int maxBuses; // 0x60
	public int maxParameterBlocks; // 0x64
	public bool vrMode; // 0x68
	public bool keepPlayingSoundOnPause; // 0x69
	public int pcBufferingTime; // 0x6C
	public LinuxOutput linuxOutput; // 0x70
	public int linuxPulseLatencyUsec; // 0x74
	public int iosBufferingTime; // 0x78
	public bool iosOverrideIPodMusic; // 0x7C
	public int androidBufferingTime; // 0x80
	public int androidStartBufferingTime; // 0x84
	public AndroidLowLatencyStandardVoicePoolConfig androidLowLatencyStandardVoicePoolConfig; // 0x88
	public bool androidUsesAndroidFastMixer; // 0x90
	public bool androidForceToUseAsrForDefaultPlayback; // 0x91
	public bool androidUsesAAudio; // 0x92
	public VitaManaVoicePoolConfig vitaManaVoicePoolConfig; // 0x98
	public VitaAtrac9VoicePoolConfig vitaAtrac9VoicePoolConfig; // 0xA0
	public Ps4Atrac9VoicePoolConfig ps4Atrac9VoicePoolConfig; // 0xA8
	public SwitchOpusVoicePoolConfig switchOpusVoicePoolConfig; // 0xB0
	public Ps4Audio3dConfig ps4Audio3dConfig; // 0xB8
	public WebGLWebAudioVoicePoolConfig webglWebAudioVoicePoolConfig; // 0xC0

	// Nested types
	[Serializable]
	public class StandardVoicePoolConfig // TypeDefIndex: 7198
	{
		// Fields
		public int memoryVoices; // 0x10
		public int streamingVoices; // 0x14

		// Constructors
		public StandardVoicePoolConfig() {} // 0x0000000187779C10-0x0000000187779C80
	}

	[Serializable]
	public class HcaMxVoicePoolConfig // TypeDefIndex: 7199
	{
		// Fields
		public int memoryVoices; // 0x10
		public int streamingVoices; // 0x14

		// Constructors
		public HcaMxVoicePoolConfig() {} // 0x0000000187779240-0x00000001877792B0
	}

	[Serializable]
	public enum InGamePreviewSwitchMode // TypeDefIndex: 7200
	{
		Disable = 0,
		Enable = 1,
		FollowBuildSetting = 2,
		Default = 3
	}

	public enum LinuxOutput // TypeDefIndex: 7201
	{
		Default = 0,
		PulseAudio = 1,
		ALSA = 2
	}

	[Serializable]
	public class AndroidLowLatencyStandardVoicePoolConfig // TypeDefIndex: 7202
	{
		// Fields
		public int memoryVoices; // 0x10
		public int streamingVoices; // 0x14

		// Constructors
		public AndroidLowLatencyStandardVoicePoolConfig() {} // 0x000000018775F240-0x000000018775F340
	}

	[Serializable]
	public class VitaManaVoicePoolConfig // TypeDefIndex: 7203
	{
		// Fields
		public int numberOfManaDecoders; // 0x10

		// Constructors
		public VitaManaVoicePoolConfig() {} // 0x000000018777CDF0-0x000000018777CE60
	}

	[Serializable]
	public class VitaAtrac9VoicePoolConfig // TypeDefIndex: 7204
	{
		// Fields
		public int memoryVoices; // 0x10
		public int streamingVoices; // 0x14

		// Constructors
		public VitaAtrac9VoicePoolConfig() {} // 0x000000018777CD80-0x000000018777CDF0
	}

	[Serializable]
	public class Ps4Atrac9VoicePoolConfig // TypeDefIndex: 7205
	{
		// Fields
		public int memoryVoices; // 0x10
		public int streamingVoices; // 0x14

		// Constructors
		public Ps4Atrac9VoicePoolConfig() {} // 0x0000000187779460-0x00000001877794D0
	}

	[Serializable]
	public class SwitchOpusVoicePoolConfig // TypeDefIndex: 7206
	{
		// Fields
		public int memoryVoices; // 0x10
		public int streamingVoices; // 0x14

		// Constructors
		public SwitchOpusVoicePoolConfig() {} // 0x0000000187779C80-0x0000000187779CF0
	}

	[Serializable]
	public class Ps4Audio3dConfig // TypeDefIndex: 7207
	{
		// Fields
		public bool useAudio3D; // 0x10
		public VoicePoolConfig voicePoolConfig; // 0x18

		// Nested types
		[Serializable]
		public class VoicePoolConfig // TypeDefIndex: 7208
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14

			// Constructors
			public VoicePoolConfig() {} // 0x000000018777CE60-0x000000018777D070
		}

		// Constructors
		public Ps4Audio3dConfig() {} // 0x00000001877794D0-0x0000000187779710
	}

	[Serializable]
	public class WebGLWebAudioVoicePoolConfig // TypeDefIndex: 7209
	{
		// Fields
		public int voices; // 0x10

		// Constructors
		public WebGLWebAudioVoicePoolConfig() {} // 0x000000018777D180-0x000000018777D2A0
	}

	// Constructors
	public CriAtomConfig() {} // 0x000000018775FD30-0x0000000187760170
}

