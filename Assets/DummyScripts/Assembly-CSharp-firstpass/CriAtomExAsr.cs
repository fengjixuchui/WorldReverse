/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAtomExAsr // TypeDefIndex: 7031
{
	// Nested types
	private struct BusAnalyzerConfig // TypeDefIndex: 7032
	{
		// Fields
		public int interval; // 0x00
		public int peakHoldTime; // 0x04
	}

	public struct BusAnalyzerInfo // TypeDefIndex: 7033
	{
		// Fields
		public int numChannels; // 0x00
		public float[] rmsLevels; // 0x08
		public float[] peakLevels; // 0x10
		public float[] peakHoldLevels; // 0x18

		// Constructors
		public BusAnalyzerInfo(byte[] data) {
			numChannels = default;
			rmsLevels = default;
			peakLevels = default;
			peakHoldLevels = default;
		} // 0x00000001877A25B0-0x00000001877A28E0
	}

	// Constructors
	public CriAtomExAsr() {} // 0x00000001877704A0-0x0000000187770500

	// Methods
	public static void AttachBusAnalyzer(string busName, int interval, int peakHoldTime) {} // 0x000000018776F860-0x000000018776F900
	public static void AttachBusAnalyzer(int interval, int peakHoldTime) {} // 0x000000018776F900-0x000000018776FA60
	public static void DetachBusAnalyzer(string busName) {} // 0x000000018776FA60-0x000000018776FAD0
	public static void DetachBusAnalyzer() {} // 0x000000018776FAD0-0x000000018776FC20
	public static void GetBusAnalyzerInfo(string busName, out BusAnalyzerInfo info) {
		info = default;
	} // 0x000000018776FD50-0x000000018776FE80
	[Obsolete] // 0x00000001898DB880-0x00000001898DB8B0
	public static void GetBusAnalyzerInfo(int busId, out BusAnalyzerInfo info) {
		info = default;
	} // 0x000000018776FC20-0x000000018776FD50
	public static void SetBusVolume(string busName, float volume) {} // 0x0000000187770270-0x00000001877702F0
	[Obsolete] // 0x00000001898E4D10-0x00000001898E4D40
	public static void SetBusVolume(int busId, float volume) {} // 0x00000001877701F0-0x0000000187770270
	public static void SetBusSendLevel(string busName, string sendTo, float level) {} // 0x00000001877700D0-0x0000000187770160
	[Obsolete] // 0x00000001898EDFD0-0x00000001898EE000
	public static void SetBusSendLevel(int busId, int sendTo, float level) {} // 0x0000000187770160-0x00000001877701F0
	public static void SetBusMatrix(string busName, int inputChannels, int outputChannels, float[] matrix) {} // 0x0000000187770030-0x00000001877700D0
	[Obsolete] // 0x00000001898F71E0-0x00000001898F7210
	public static void SetBusMatrix(int busId, int inputChannels, int outputChannels, float[] matrix) {} // 0x000000018776FF90-0x0000000187770030
	public static void SetEffectBypass(string busName, string effectName, bool bypass) {} // 0x00000001877702F0-0x0000000187770380
	public static void SetEffectParameter(string busName, string effectName, uint parameterIndex, float parameterValue) {} // 0x0000000187770380-0x0000000187770430
	public static float GetEffectParameter(string busName, string effectName, uint parameterIndex) => default; // 0x000000018776FE80-0x000000018776FF20
	public static bool RegisterEffectInterface(IntPtr afx_interface) => default; // 0x000000018776FF20-0x000000018776FF90
	public static void UnregisterEffectInterface(IntPtr afx_interface) {} // 0x0000000187770430-0x00000001877704A0
	private static extern void criAtomExAsr_AttachBusAnalyzerByName(string busName, ref BusAnalyzerConfig config); // 0x0000000187770500-0x0000000187770610
	private static extern void criAtomExAsr_AttachBusAnalyzer(int busNo, ref BusAnalyzerConfig config); // 0x0000000187770610-0x0000000187770700
	private static extern void criAtomExAsr_DetachBusAnalyzerByName(string busName); // 0x0000000187770700-0x0000000187770800
	private static extern void criAtomExAsr_DetachBusAnalyzer(int busNo); // 0x0000000187770800-0x00000001877708E0
	private static extern void criAtomExAsr_GetBusAnalyzerInfoByName(string busName, IntPtr info); // 0x00000001877708E0-0x00000001877709F0
	private static extern void criAtomExAsr_GetBusAnalyzerInfo(int busNo, IntPtr info); // 0x00000001877709F0-0x0000000187770AE0
	private static extern void criAtomExAsr_SetBusVolumeByName(string busName, float volume); // 0x00000001877711A0-0x00000001877712B0
	private static extern void criAtomExAsr_SetBusVolume(int busNo, float volume); // 0x00000001877712B0-0x00000001877713A0
	private static extern void criAtomExAsr_SetBusSendLevelByName(string busName, string sendtoName, float level); // 0x0000000187770F60-0x0000000187771090
	private static extern void criAtomExAsr_SetBusSendLevel(int busNo, int sendtoNo, float level); // 0x0000000187771090-0x00000001877711A0
	private static extern void criAtomExAsr_SetBusMatrixByName(string busName, int inputChannels, int outputChannels, float[] matrix); // 0x0000000187770D10-0x0000000187770E40
	private static extern void criAtomExAsr_SetBusMatrix(int busNo, int inputChannels, int outputChannels, float[] matrix); // 0x0000000187770E40-0x0000000187770F60
	private static extern void criAtomExAsr_SetEffectBypass(string busName, string effectName, bool bypass); // 0x00000001877713A0-0x00000001877714D0
	private static extern void criAtomExAsr_UpdateEffectParameters(string busName, string effectName); // 0x00000001877716F0-0x0000000187771810
	private static extern void criAtomExAsr_SetEffectParameter(string busName, string effectName, uint parameterIndex, float parameterValue); // 0x00000001877714D0-0x0000000187771600
	private static extern float criAtomExAsr_GetEffectParameter(string busName, string effectName, uint parameterIndex); // 0x0000000187770AE0-0x0000000187770C20
	private static extern bool criAtomExAsr_RegisterEffectInterface(IntPtr afx_interface); // 0x0000000187770C20-0x0000000187770D10
	private static extern void criAtomExAsr_UnregisterEffectInterface(IntPtr afx_interface); // 0x0000000187771600-0x00000001877716F0
}

