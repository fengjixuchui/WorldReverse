/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAtomExMic : CriDisposable // TypeDefIndex: 7071
{
	// Fields
	private const string errorInvalidHandle = "[CRIWARE] Invalid native handle of CriAtomMic."; // Metadata: 0x00ADE34D
	private const string errorInvalidBufferLength = "[CRIWARE] Invalid buffer length for CriAtomMic.ReadData."; // Metadata: 0x00ADE37F
	private const string errorInvalidNumBuffers = "[CRIWARE] Number of buffers are not same with channels of CriAtomMic."; // Metadata: 0x00ADE3BB
	private const string errorAlreadyInitialized = "[CRIWARE] CriAtomMic module is already initialized."; // Metadata: 0x00ADE404
	private const string errorNotInitialized = "[CRIWARE] CriAtomMic module is not initialized."; // Metadata: 0x00ADE43B
	private IntPtr handle; // 0x20
	private CriAudioWriteStream outputWriteStream; // 0x28
	private IntPtr[] bufferPointers; // 0x30
	private GCHandle[] gcHandles; // 0x38
	private static int _initializationCount; // 0x04

	// Properties
	public static bool isInitialized { get; private set; } // 0x00000001877AB6F0-0x00000001877AB780 0x00000001877AB780-0x00000001877AB810

	// Nested types
	public struct DeviceInfo // TypeDefIndex: 7072
	{
		// Fields
		public string deviceId; // 0x00
		public string deviceName; // 0x08
		public uint deviceFlags; // 0x10
		public int maxChannels; // 0x14
		public int maxSamplingRate; // 0x18
	}

	public struct Config // TypeDefIndex: 7073
	{
		// Fields
		public string deviceId; // 0x00
		public uint flags; // 0x08
		public int numChannels; // 0x0C
		public int samplingRate; // 0x10
		public uint frameSize; // 0x14
		public uint bufferingTime; // 0x18
		public IntPtr context; // 0x20

		// Properties
		public static Config Default { get => default; } // 0x00000001877A2FE0-0x00000001877A3090 
	}

	public class Effect // TypeDefIndex: 7074
	{
		// Properties
		public IntPtr handle { get; private set; } // 0x00000001877C7AF0-0x00000001877C7B50 0x00000001877C7BB0-0x00000001877C7C10
		public IntPtr afxInstance { get; private set; } // 0x00000001877C7A90-0x00000001877C7AF0 0x00000001877C7B50-0x00000001877C7BB0

		// Constructors
		public Effect() {} // Dummy constructor
		public Effect(IntPtr handle, IntPtr afxInstance) {} // 0x00000001877C79B0-0x00000001877C7A90
	}

	// Constructors
	public CriAtomExMic() {} // Dummy constructor
	private CriAtomExMic(IntPtr handle) {} // 0x00000001877A9B80-0x00000001877A9C80
	static CriAtomExMic() {} // 0x00000001877A9B20-0x00000001877A9B80

	// Methods
	public static void InitializeModule() {} // 0x00000001877A8590-0x00000001877A86B0
	public static void FinalizeModule() {} // 0x00000001877A7B50-0x00000001877A7D00
	public static DeviceInfo[] GetDevices() => default; // 0x00000001877A7E90-0x00000001877A8010
	public static int GetNumDevices() => default; // 0x00000001877A8320-0x00000001877A83A0
	public static DeviceInfo? GetDefaultDevice() => default; // 0x00000001877A7D00-0x00000001877A7E90
	public static bool IsFormatSupported(Config config) => default; // 0x00000001877A8940-0x00000001877A89D0
	public static CriAtomExMic Create(Config? config = default) => default; // 0x00000001877A7720-0x00000001877A78E0
	public override void Dispose() {} // 0x00000001877A7A00-0x00000001877A7A70
	private void Dispose(bool disposing) {} // 0x00000001877A7A70-0x00000001877A7B50
	public void Start() {} // 0x00000001877A9840-0x00000001877A9920
	public void Stop() {} // 0x00000001877A9920-0x00000001877A9A00
	public int GetNumChannels() => default; // 0x00000001877A8240-0x00000001877A8320
	public int GetSamplingRate() => default; // 0x00000001877A84B0-0x00000001877A8590
	public uint GetNumBufferredSamples() => default; // 0x00000001877A8160-0x00000001877A8240
	public bool IsAvailable() => default; // 0x00000001877A8890-0x00000001877A8940
	public uint ReadData(float[] bufferMono) => default; // 0x00000001877A8E20-0x00000001877A8EB0
	public uint ReadData(float[] bufferMono, uint numToRead) => default; // 0x00000001877A8B80-0x00000001877A8D40
	public uint ReadData(float[] bufferL, float[] bufferR) => default; // 0x00000001877A8D40-0x00000001877A8E20
	public uint ReadData(float[] bufferL, float[] bufferR, uint numToRead) => default; // 0x00000001877A8EB0-0x00000001877A91B0
	public uint ReadData(float[][] buffers) => default; // 0x00000001877A89D0-0x00000001877A8B80
	public uint ReadData(float[][] buffers, uint numToRead) => default; // 0x00000001877A91B0-0x00000001877A9460
	public void SetOutputWriteStream(CriAudioWriteStream stream) {} // 0x00000001877A9700-0x00000001877A9840
	public CriAudioReadStream GetOutputReadStream() => default; // 0x00000001877A83A0-0x00000001877A84B0
	public Effect AttachEffect(IntPtr afxInterface, float[] configParameters) => default; // 0x00000001877A7590-0x00000001877A7720
	public void DetachEffect(Effect effect) {} // 0x00000001877A78E0-0x00000001877A7A00
	public void SetEffectParameter(Effect effect, int parameterIndex, float parameterValue) {} // 0x00000001877A95A0-0x00000001877A9700
	public float GetEffectParameter(Effect effect, int parameterIndex) => default; // 0x00000001877A8010-0x00000001877A8160
	public void SetEffectBypass(Effect effect, bool bypass) {} // 0x00000001877A9460-0x00000001877A95A0
	public void UpdateEffectParameters(Effect effect) {} // 0x00000001877A9A00-0x00000001877A9B20
	private uint InternalReadDataFromBufferPointers(uint numToRead) => default; // 0x00000001877A87E0-0x00000001877A8890
	private void InternalClearBuffers() {} // 0x00000001877A86B0-0x00000001877A87E0
	private static extern void criAtomMicUnity_Initialize(); // 0x00000001877A9D60-0x00000001877A9E40
	private static extern void criAtomMicUnity_Finalize(); // 0x00000001877A9C80-0x00000001877A9D60
	private static extern int criAtomMic_GetNumDevices(); // 0x00000001877AAB00-0x00000001877AABE0
	private static extern bool criAtomMic_GetDevice(int index, out DeviceInfo info); // 0x00000001877AA580-0x00000001877AA710
	private static extern bool criAtomMic_GetDefaultDevice(out DeviceInfo info); // 0x00000001877AA400-0x00000001877AA580
	private static extern bool criAtomMic_IsFormatSupported(in Config config); // 0x00000001877AAEA0-0x00000001877AAFF0
	private static extern IntPtr criAtomMic_Create(in Config config, IntPtr work, int work_size); // 0x00000001877AA0A0-0x00000001877AA210
	private static extern void criAtomMic_Destroy(IntPtr mic); // 0x00000001877AA210-0x00000001877AA300
	private static extern void criAtomMic_Start(IntPtr mic); // 0x00000001877AB410-0x00000001877AB500
	private static extern void criAtomMic_Stop(IntPtr mic); // 0x00000001877AB500-0x00000001877AB5F0
	private static extern int criAtomMic_GetNumChannels(IntPtr mic); // 0x00000001877AAA10-0x00000001877AAB00
	private static extern int criAtomMic_GetSamplingRate(IntPtr mic); // 0x00000001877AACC0-0x00000001877AADB0
	private static extern uint criAtomMic_GetNumBufferredSamples(IntPtr mic); // 0x00000001877AA920-0x00000001877AAA10
	private static extern bool criAtomMic_IsAvailable(IntPtr mic); // 0x00000001877AADB0-0x00000001877AAEA0
	private static extern uint criAtomMic_ReadData(IntPtr mic, IntPtr[] data, uint num_samples); // 0x00000001877AAFF0-0x00000001877AB100
	private static extern void criAtomMic_SetOutputWriteStream(IntPtr mic, IntPtr stream_cbfunc, IntPtr stream_ptr); // 0x00000001877AB310-0x00000001877AB410
	private static extern IntPtr criAtomMic_GetOutputReadStream(); // 0x00000001877AABE0-0x00000001877AACC0
	private static extern int criAtomMic_CalculateWorkSizeForEffect(IntPtr mic, IntPtr afx_interface, float[] config_parameters, uint num_config_parameters); // 0x00000001877A9F80-0x00000001877AA0A0
	private static extern IntPtr criAtomMic_AttachEffect(IntPtr mic, IntPtr afx_interface, float[] config_parameters, uint num_config_parameters, IntPtr work, int work_size); // 0x00000001877A9E40-0x00000001877A9F80
	private static extern void criAtomMic_DetachEffect(IntPtr mic, IntPtr effect); // 0x00000001877AA300-0x00000001877AA400
	private static extern IntPtr criAtomMic_GetEffectInstance(IntPtr mic, IntPtr effect); // 0x00000001877AA710-0x00000001877AA810
	private static extern void criAtomMic_SetEffectBypass(IntPtr mic, IntPtr effect, bool bypass); // 0x00000001877AB100-0x00000001877AB200
	private static extern void criAtomMic_SetEffectParameter(IntPtr mic, IntPtr effect, uint parameter_index, float parameter_value); // 0x00000001877AB200-0x00000001877AB310
	private static extern float criAtomMic_GetEffectParameter(IntPtr mic, IntPtr effect, uint parameter_index); // 0x00000001877AA810-0x00000001877AA920
	private static extern void criAtomMic_UpdateEffectParameters(IntPtr mic, IntPtr effect); // 0x00000001877AB5F0-0x00000001877AB6F0
}

