/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAtomExAuxIn : CriDisposable // TypeDefIndex: 7069
{
	// Fields
	private const string errorInvalidHandle = "[CRIWARE] Invalid native handle of CriAtomExAuxIn."; // Metadata: 0x00ADE317
	private IntPtr handle; // 0x20
	private CriAudioReadStream inputReadStream; // 0x28

	// Nested types
	public struct Config // TypeDefIndex: 7070
	{
		// Fields
		public int maxChannels; // 0x00
		public int maxSamplingRate; // 0x04
		public CriAtomEx.SoundRendererType soundRendererType; // 0x08

		// Properties
		public static Config Default { get => default; } // 0x00000001877A3090-0x00000001877A3280 
	}

	// Constructors
	public CriAtomExAuxIn() {} // Dummy constructor
	public CriAtomExAuxIn(Config? config = default) {} // 0x00000001877A4180-0x00000001877A42E0

	// Methods
	public override void Dispose() {} // 0x00000001877A3BD0-0x00000001877A3C90
	public void Start() {} // 0x00000001877A4000-0x00000001877A40C0
	public void Stop() {} // 0x00000001877A40C0-0x00000001877A4180
	public void SetFormat(int numChannels, int samplingRate) {} // 0x00000001877A3DB0-0x00000001877A3E40
	public void GetFormat(out int numChannels, out int samplingRate) {
		numChannels = default;
		samplingRate = default;
	} // 0x00000001877A3C90-0x00000001877A3D20
	public void SetVolume(float volume) {} // 0x00000001877A3F80-0x00000001877A4000
	public void SetFrequencyRatio(float frequencyRatio) {} // 0x00000001877A3E40-0x00000001877A3EC0
	public void SetBusSendLevel(string busName, float level) {} // 0x00000001877A3D20-0x00000001877A3DB0
	public void SetInputReadStream(CriAudioReadStream stream) {} // 0x00000001877A3EC0-0x00000001877A3F80
	private static extern IntPtr criAtomAuxIn_Create(in Config config, IntPtr work, int work_size); // 0x00000001877A42E0-0x00000001877A43F0
	private static extern void criAtomAuxIn_Destroy(IntPtr aux_in); // 0x00000001877A43F0-0x00000001877A44E0
	private static extern void criAtomAuxIn_Start(IntPtr aux_in); // 0x00000001877A4B20-0x00000001877A4C10
	private static extern void criAtomAuxIn_Stop(IntPtr aux_in); // 0x00000001877A4C10-0x00000001877A4D00
	private static extern void criAtomAuxIn_SetVolume(IntPtr aux_in, float volume); // 0x00000001877A4A20-0x00000001877A4B20
	private static extern void criAtomAuxIn_SetFrequencyRatio(IntPtr aux_in, float ratio); // 0x00000001877A4820-0x00000001877A4920
	private static extern void criAtomAuxIn_SetBusSendLevelByName(IntPtr aux_in, string bus_name, float level); // 0x00000001877A4600-0x00000001877A4720
	private static extern void criAtomAuxIn_SetFormat(IntPtr aux_in, int num_channels, int sampling_rate); // 0x00000001877A4720-0x00000001877A4820
	private static extern void criAtomAuxIn_GetFormat(IntPtr aux_in, out int num_channels, out int sampling_rate); // 0x00000001877A44E0-0x00000001877A4600
	private static extern void criAtomAuxIn_SetInputReadStream(IntPtr aux_in, IntPtr stream_cbfunc, IntPtr stream_ptr); // 0x00000001877A4920-0x00000001877A4A20
}

