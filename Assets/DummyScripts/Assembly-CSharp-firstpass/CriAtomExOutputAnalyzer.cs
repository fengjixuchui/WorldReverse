/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAtomExOutputAnalyzer : CriDisposable // TypeDefIndex: 7075
{
	// Fields
	public const int MaximumSpectrumBands = 512; // Metadata: 0x00ADE46E
	protected IntPtr handle; // 0x20
	protected CriAtomExPlayer player; // 0x28
	protected string busName; // 0x30
	protected int numBands; // 0x38
	protected int numCapturedPcmSamples; // 0x3C
	protected PcmCaptureCallback userPcmCaptureCallback; // 0x40
	protected float[] dataL; // 0x48
	protected float[] dataR; // 0x50
	protected const int pcmCapturerNumMaxData = 512; // Metadata: 0x00ADE472
	protected static IntPtr InternalCallbackFunctionPointer; // 0x00
	protected static InternalPcmCaptureCallback DelegateObject; // 0x08
	protected static float[] DataL; // 0x10
	protected static float[] DataR; // 0x18
	protected static PcmCaptureCallback UserPcmCaptureCallback; // 0x20

	// Properties
	public IntPtr nativeHandle { get => default; } // 0x00000001877AD510-0x00000001877AD570 

	// Nested types
	public delegate void PcmCaptureCallback(float[] dataL, float[] dataR, int numChannels, int numData); // TypeDefIndex: 7076; 0x00000001877C8570-0x00000001877C88C0

	public struct Config // TypeDefIndex: 7077
	{
		// Fields
		public bool enableLevelmeter; // 0x00
		public bool enableSpectrumAnalyzer; // 0x01
		public bool enablePcmCapture; // 0x02
		public bool enablePcmCaptureCallback; // 0x03
		public int numSpectrumAnalyzerBands; // 0x04
		public int numCapturedPcmSamples; // 0x08
	}

	// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
	protected delegate void InternalPcmCaptureCallback(IntPtr dataL, IntPtr dataR, int numChannels, int numData); // TypeDefIndex: 7078; 0x00000001877C8170-0x00000001877C83B0

	// Constructors
	public CriAtomExOutputAnalyzer(Config config) {} // 0x00000001877AC940-0x00000001877ACA20
	protected CriAtomExOutputAnalyzer() {} // 0x00000001877ACA20-0x00000001877ACAD0
	static CriAtomExOutputAnalyzer() {} // 0x00000001877AC8D0-0x00000001877AC940

	// Methods
	public override void Dispose() {} // 0x00000001877ABE40-0x00000001877ABEB0
	protected void Dispose(bool disposing) {} // 0x00000001877ABEB0-0x00000001877ABFC0
	public bool AttachExPlayer(CriAtomExPlayer player) => default; // 0x00000001877AB8F0-0x00000001877AB9F0
	public void DetachExPlayer() {} // 0x00000001877ABCE0-0x00000001877ABE40
	public bool AttachDspBus(string busName) => default; // 0x00000001877AB810-0x00000001877AB8F0
	public void DetachDspBus() {} // 0x00000001877ABC10-0x00000001877ABCE0
	public float GetRms(int channel) => default; // 0x00000001877AC4D0-0x00000001877AC5D0
	public void GetSpectrumLevels(ref float[] levels) {} // 0x00000001877AC5D0-0x00000001877AC730
	public void GetPcmData(ref float[] data, int ch) {} // 0x00000001877AC340-0x00000001877AC4D0
	public void SetPcmCaptureCallback(PcmCaptureCallback callback) {} // 0x00000001877AC870-0x00000001877AC8D0
	public void ExecutePcmCaptureCallback() {} // 0x00000001877AC040-0x00000001877AC290
	[Obsolete] // 0x0000000189955480-0x00000001899554B0
	public void ExecutePcmCaptureCallback(PcmCaptureCallback callback) {} // 0x00000001877ABFC0-0x00000001877AC040
	~CriAtomExOutputAnalyzer() {} // 0x00000001877AC290-0x00000001877AC340
	protected void InitializeWithConfig(Config config) {} // 0x00000001877AC730-0x00000001877AC870
	// [MonoPInvokeCallback] // 0x000000018995E5F0-0x000000018995E640
	private static void Callback(IntPtr ptrL, IntPtr ptrR, int numChannels, int numData) {} // 0x00000001877AB9F0-0x00000001877ABC10
	protected static extern IntPtr criAtomExOutputAnalyzer_Create(in Config config); // 0x00000001877ACCE0-0x00000001877ACE10
	protected static extern void criAtomExOutputAnalyzer_Destroy(IntPtr analyzer); // 0x00000001877ACE10-0x00000001877ACF00
	protected static extern void criAtomExOutputAnalyzer_AttachExPlayer(IntPtr analyzer, IntPtr player); // 0x00000001877ACBE0-0x00000001877ACCE0
	protected static extern void criAtomExOutputAnalyzer_DetachExPlayer(IntPtr analyzer, IntPtr player); // 0x00000001877AD010-0x00000001877AD110
	protected static extern void criAtomExOutputAnalyzer_AttachDspBusByName(IntPtr analyzer, string busName); // 0x00000001877ACAD0-0x00000001877ACBE0
	protected static extern void criAtomExOutputAnalyzer_DetachDspBusByName(IntPtr analyzer, string busName); // 0x00000001877ACF00-0x00000001877AD010
	protected static extern float criAtomExOutputAnalyzer_GetRms(IntPtr analyzer, int channel); // 0x00000001877AD310-0x00000001877AD420
	protected static extern IntPtr criAtomExOutputAnalyzer_GetSpectrumLevels(IntPtr analyzer); // 0x00000001877AD420-0x00000001877AD510
	protected static extern IntPtr criAtomExOutputAnalyzer_GetPcmData(IntPtr analyzer, int ch); // 0x00000001877AD210-0x00000001877AD310
	protected static extern void criAtomExOutputAnalyzer_ExecuteQueuedPcmCapturerCallbacks(IntPtr analyzer, IntPtr callback); // 0x00000001877AD110-0x00000001877AD210
}

