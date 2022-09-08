/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace FftSharp
{
	public static class FftTransform // TypeDefIndex: 32209
	{
		// Methods
		public static void FFT(Complex[] buffer) {} // 0x0000000182168330-0x00000001821687A0
		public static void IFFT(Complex[] buffer) {} // 0x0000000182168E70-0x0000000182169100
		private static int BitReverse(int value, int maxValue) => default; // 0x0000000182168270-0x0000000182168330
		public static double[] FFTfreq(int sampleRate, int pointCount, bool oneSided = true /* Metadata: 0x00B142B5 */) => default; // 0x0000000182168940-0x0000000182168AE0
		public static double FFTfreqPeriod(int sampleRate, int pointCount) => default; // 0x00000001821688B0-0x0000000182168940
		public static bool IsPowerOfTwo(int x) => default; // 0x0000000182169100-0x0000000182169170
		public static Complex[] MakeComplex(double[] real) => default; // 0x0000000182169170-0x00000001821692F0
		public static Complex[] FFT(double[] input) => default; // 0x00000001821687A0-0x00000001821688B0
		public static Complex[] RFFT(double[] input) => default; // 0x0000000182169750-0x00000001821698C0
		public static double[] Absolute(Complex[] input) => default; // 0x0000000182168170-0x0000000182168270
		public static double[] FFTmagnitude(double[] input) => default; // 0x0000000182168AE0-0x0000000182168D00
		public static double[] FFTpower(double[] input) => default; // 0x0000000182168D00-0x0000000182168E70
		public static double MelToFreq(double mel) => default; // 0x00000001821696C0-0x0000000182169750
		public static double MelFromFreq(double frequencyHz) => default; // 0x00000001821692F0-0x0000000182169370
		public static double[] MelScale(double[] fft, int sampleRate, int melBinCount) => default; // 0x0000000182169370-0x00000001821696C0
	}
}
