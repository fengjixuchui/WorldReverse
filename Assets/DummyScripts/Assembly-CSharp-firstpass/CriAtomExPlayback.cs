/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public struct CriAtomExPlayback // TypeDefIndex: 7079
{
	// Fields
	public const uint invalidId = 4294967295; // Metadata: 0x00ADE476

	// Properties
	public uint id { get; private set; } // 0x00000001877AFBD0-0x00000001877AFC30 0x00000001877AFD80-0x00000001877AFDE0
	public Status status { get => default; } // 0x00000001877AFC30-0x00000001877AFCA0 
	public long time { get => default; } // 0x00000001877AFD10-0x00000001877AFD80 
	public long timeSyncedWithAudio { get => default; } // 0x00000001877AFCA0-0x00000001877AFD10 

	// Nested types
	public enum Status // TypeDefIndex: 7080
	{
		Prep = 1,
		Playing = 2,
		Removed = 3
	}

	public struct TrackInfo // TypeDefIndex: 7081
	{
		// Fields
		public uint id; // 0x00
		public CriAtomEx.CueType sequenceType; // 0x04
		public IntPtr playerHn; // 0x08
		public ushort trackNo; // 0x10
		public ushort reserved; // 0x12
	}

	// Constructors
	public CriAtomExPlayback(uint id) : this() {

	} // 0x00000001877AECC0-0x00000001877AECD0

	// Methods
	public void Stop(bool ignoresReleaseTime) {} // 0x00000001877AEC10-0x00000001877AECC0
	public void Pause() {} // 0x00000001877AE6D0-0x00000001877AE790
	public void Resume(CriAtomEx.ResumeMode mode) {} // 0x00000001877AE850-0x00000001877AE910
	public bool IsPaused() => default; // 0x00000001877AE620-0x00000001877AE6D0
	public bool GetFormatInfo(out CriAtomEx.FormatInfo info) {
		info = default;
		return default;
	} // 0x00000001877AE120-0x00000001877AE1F0
	public Status GetStatus() => default; // 0x00000001877AE350-0x00000001877AE400
	public long GetTime() => default; // 0x00000001877AE4B0-0x00000001877AE570
	public long GetTimeSyncedWithAudio() => default; // 0x00000001877AE400-0x00000001877AE4B0
	public bool GetNumPlayedSamples(out long numSamples, out int samplingRate) {
		numSamples = default;
		samplingRate = default;
		return default;
	} // 0x00000001877AE1F0-0x00000001877AE2A0
	public long GetSequencePosition() => default; // 0x00000001877AE2A0-0x00000001877AE350
	public int GetCurrentBlockIndex() => default; // 0x00000001877AE060-0x00000001877AE120
	public bool GetTrackInfo(out TrackInfo info) {
		info = default;
		return default;
	} // 0x00000001877AE570-0x00000001877AE620
	public bool GetBeatSyncInfo(out CriAtomExBeatSync.Info info) {
		info = default;
		return default;
	} // 0x00000001877ADFB0-0x00000001877AE060
	public void SetNextBlockIndex(int index) {} // 0x00000001877AE910-0x00000001877AE9F0
	public void Stop() {} // 0x00000001877AEAD0-0x00000001877AEC10
	public void StopWithoutReleaseTime() {} // 0x00000001877AE9F0-0x00000001877AEAD0
	public void Pause(bool sw) {} // 0x00000001877AE790-0x00000001877AE850
	private static extern void criAtomExPlayback_Stop(uint id); // 0x00000001877AFAF0-0x00000001877AFBD0
	private static extern void criAtomExPlayback_StopWithoutReleaseTime(uint id); // 0x00000001877AFA10-0x00000001877AFAF0
	private static extern void criAtomExPlayback_Pause(uint id, bool sw); // 0x00000001877AF740-0x00000001877AF830
	private static extern void criAtomExPlayback_Resume(uint id, CriAtomEx.ResumeMode mode); // 0x00000001877AF830-0x00000001877AF920
	private static extern bool criAtomExPlayback_IsPaused(uint id); // 0x00000001877AF650-0x00000001877AF740
	private static extern Status criAtomExPlayback_GetStatus(uint id); // 0x00000001877AF380-0x00000001877AF470
	private static extern bool criAtomExPlayback_GetFormatInfo(uint id, out CriAtomEx.FormatInfo info); // 0x00000001877AEEF0-0x00000001877AF030
	private static extern long criAtomExPlayback_GetTime(uint id); // 0x00000001877AF560-0x00000001877AF650
	private static extern long criAtomExPlayback_GetTimeSyncedWithAudio(uint id); // 0x00000001877AF470-0x00000001877AF560
	private static extern bool criAtomExPlayback_GetNumPlayedSamples(uint id, out long num_samples, out int sampling_rate); // 0x00000001877AF030-0x00000001877AF160
	private static extern long criAtomExPlayback_GetSequencePosition(uint id); // 0x00000001877AF290-0x00000001877AF380
	private static extern void criAtomExPlayback_SetNextBlockIndex(uint id, int index); // 0x00000001877AF920-0x00000001877AFA10
	private static extern int criAtomExPlayback_GetCurrentBlockIndex(uint id); // 0x00000001877AEE00-0x00000001877AEEF0
	private static extern bool criAtomExPlayback_GetPlaybackTrackInfo(uint id, out TrackInfo info); // 0x00000001877AF160-0x00000001877AF290
	private static extern bool criAtomExPlayback_GetBeatSyncInfo(uint id, out CriAtomExBeatSync.Info info); // 0x00000001877AECD0-0x00000001877AEE00
}

