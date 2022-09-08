/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public abstract class CriAtomExVoicePool : CriDisposable // TypeDefIndex: 7096
{
	// Fields
	public const int StandardMemoryAsrVoicePoolId = 0; // Metadata: 0x00ADE4DA
	public const int StandardStreamingAsrVoicePoolId = 1; // Metadata: 0x00ADE4DE
	public const int StandardMemoryNsrVoicePoolId = 2; // Metadata: 0x00ADE4E2
	public const int StandardStreamingNsrVoicePoolId = 3; // Metadata: 0x00ADE4E6
	protected IntPtr _handle; // 0x20
	protected uint _identifier; // 0x28
	protected int _numVoices; // 0x2C
	protected int _maxChannels; // 0x30
	protected int _maxSamplingRate; // 0x34

	// Properties
	public IntPtr nativeHandle { get; } // 0x00000001877BC9C0-0x00000001877BCA20 
	public uint identifier { get; } // 0x00000001877BC8A0-0x00000001877BC900 
	public int numVoices { get; } // 0x00000001877BCA20-0x00000001877BCA80 
	public int maxChannels { get; } // 0x00000001877BC900-0x00000001877BC960 
	public int maxSamplingRate { get; } // 0x00000001877BC960-0x00000001877BC9C0 

	// Nested types
	public enum VoicePoolId // TypeDefIndex: 7097
	{
		StandardMemory = 0,
		StandardStreaming = 1,
		HcaMxMemory = 4,
		HcaMxStreaming = 5
	}

	public enum PitchShifterMode // TypeDefIndex: 7098
	{
		Music = 0,
		Vocal = 1,
		SoundEffect = 2,
		Speech = 3
	}

	public struct UsedVoicesInfo // TypeDefIndex: 7099
	{
		// Fields
		public int numUsedVoices; // 0x00
		public int numPoolVoices; // 0x04
	}

	protected struct PlayerConfig // TypeDefIndex: 7100
	{
		// Fields
		public int maxChannels; // 0x00
		public int maxSamplingRate; // 0x04
		public bool streamingFlag; // 0x08
		public int soundRendererType; // 0x0C
		public int decodeLatency; // 0x10
	}

	protected struct VoicePoolConfig // TypeDefIndex: 7101
	{
		// Fields
		public uint identifier; // 0x00
		public int numVoices; // 0x04
		public PlayerConfig playerConfig; // 0x08
	}

	private struct PitchShifterConfig // TypeDefIndex: 7102
	{
		// Fields
		public int mode; // 0x00
		public int windowSize; // 0x04
		public int overlapTimes; // 0x08
	}

	private struct ExPitchShifterConfig // TypeDefIndex: 7103
	{
		// Fields
		public int numDsp; // 0x00
		public int maxChannels; // 0x04
		public int maxSamplingRate; // 0x08
		public PitchShifterConfig config; // 0x0C
	}

	private struct TimeStretchConfig // TypeDefIndex: 7104
	{
		// Fields
		public int reserved; // 0x00
	}

	private struct ExTimeStretchConfig // TypeDefIndex: 7105
	{
		// Fields
		public int numDsp; // 0x00
		public int maxChannels; // 0x04
		public int maxSamplingRate; // 0x08
		public TimeStretchConfig config; // 0x0C
	}

	// Constructors
	protected CriAtomExVoicePool() {} // 0x00000001877BC310-0x00000001877BC380

	// Methods
	public static UsedVoicesInfo GetNumUsedVoices(VoicePoolId voicePoolId) => default; // 0x00000001877BC290-0x00000001877BC310
	public override void Dispose() {} // 0x00000001877BC080-0x00000001877BC140
	public UsedVoicesInfo GetNumUsedVoices() => default; // 0x00000001877BC1F0-0x00000001877BC290
	public void AttachDspTimeStretch() {} // 0x00000001877BBE30-0x00000001877BBEE0
	public void AttachDspPitchShifter(PitchShifterMode mode = PitchShifterMode.Music /* Metadata: 0x00ADE4CE */, int windosSize = 1024 /* Metadata: 0x00ADE4D2 */, int overlapTimes = 4 /* Metadata: 0x00ADE4D6 */) {} // 0x00000001877BBD50-0x00000001877BBE30
	public void DetachDsp() {} // 0x00000001877BC000-0x00000001877BC080
	~CriAtomExVoicePool() {} // 0x00000001877BC140-0x00000001877BC1F0
	private static extern void CRIWARE5353B792(int voice_pool_id, out int num_used_voices, out int num_pool_voices); // 0x00000001877BBEE0-0x00000001877BC000
	private static extern void criAtomExVoicePool_GetNumUsedVoices(IntPtr pool, out int num_used_voices, out int num_pool_voices); // 0x00000001877BC780-0x00000001877BC8A0
	public static extern void criAtomExVoicePool_Free(IntPtr pool); // 0x00000001877BC690-0x00000001877BC780
	private static extern void criAtomExVoicePool_AttachDspTimeStretch(IntPtr pool, ref ExTimeStretchConfig config, IntPtr work, int work_size); // 0x00000001877BC490-0x00000001877BC5A0
	private static extern void criAtomExVoicePool_AttachDspPitchShifter(IntPtr pool, ref ExPitchShifterConfig config, IntPtr work, int work_size); // 0x00000001877BC380-0x00000001877BC490
	private static extern void criAtomExVoicePool_DetachDsp(IntPtr pool); // 0x00000001877BC5A0-0x00000001877BC690
}

