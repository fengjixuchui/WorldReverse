/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace FftSharp
{
	public static class Window // TypeDefIndex: 32211
	{
		// Methods
		public static double[] Apply(double[] window, double[] signal) => default; // 0x000000018216A1B0-0x000000018216A320
		public static void ApplyInPlace(double[] window, double[] signal) {} // 0x000000018216A090-0x000000018216A1B0
		private static void NormalizeInPlace(double[] window) {} // 0x000000018216B520-0x000000018216B600
		public static double[] Rectangular(int pointCount) => default; // 0x000000018216B600-0x000000018216B6D0
		public static double[] Hanning(int pointCount) => default; // 0x000000018216B3F0-0x000000018216B520
		public static double[] Hamming(int pointCount) => default; // 0x000000018216B2B0-0x000000018216B3F0
		public static double[] Blackman(int pointCount) => default; // 0x000000018216A770-0x000000018216A910
		public static double[] BlackmanExact(int pointCount) => default; // 0x000000018216A430-0x000000018216A5D0
		public static double[] BlackmanHarris(int pointCount) => default; // 0x000000018216A5D0-0x000000018216A770
		public static double[] FlatTop(int pointCount) => default; // 0x000000018216AA20-0x000000018216ABC0
		public static double[] Bartlett(int pointCount) => default; // 0x000000018216A320-0x000000018216A430
		public static double[] Cosine(int pointCount) => default; // 0x000000018216A910-0x000000018216AA20
		public static string[] GetWindowNames() => default; // 0x000000018216AFF0-0x000000018216B2B0
		public static double[] GetWindowByName(string windowName, int pointCount) => default; // 0x000000018216ABC0-0x000000018216AFF0
	}
}
