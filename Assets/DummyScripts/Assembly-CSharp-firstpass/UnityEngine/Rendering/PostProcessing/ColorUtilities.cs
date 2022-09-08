/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	public static class ColorUtilities // TypeDefIndex: 9602
	{
		// Fields
		private const float logC_cut = 0.011361f; // Metadata: 0x00AE5C55
		private const float logC_a = 5.555556f; // Metadata: 0x00AE5C59
		private const float logC_b = 0.047996f; // Metadata: 0x00AE5C5D
		private const float logC_c = 0.244161f; // Metadata: 0x00AE5C61
		private const float logC_d = 0.386036f; // Metadata: 0x00AE5C65
		private const float logC_e = 5.301883f; // Metadata: 0x00AE5C69
		private const float logC_f = 0.092819f; // Metadata: 0x00AE5C6D
	
		// Methods
		// [XID] // 0x0000000189681F10-0x0000000189681F30
		public static float StandardIlluminantY(float x) => default; // 0x0000000186058880-0x0000000186058960
		// [XID] // 0x000000018975A100-0x000000018975A120
		public static Vector3 CIExyToLMS(float x, float y) => default; // 0x0000000186057D30-0x0000000186057EC0
		// [XID] // 0x00000001897D9DF0-0x00000001897D9E10
		public static Vector3 ComputeColorBalance(float temperature, float tint) => default; // 0x0000000186058470-0x0000000186058660
		// [XID] // 0x00000001898EC350-0x00000001898EC370
		public static Vector3 ColorToLift(Vector4 color) => default; // 0x00000001860582C0-0x0000000186058470
		// [XID] // 0x0000000189A3C100-0x0000000189A3C120
		public static Vector3 ColorToInverseGamma(Vector4 color) => default; // 0x0000000186058070-0x00000001860582C0
		// [XID] // 0x00000001898F3D60-0x00000001898F3D80
		public static Vector3 ColorToGain(Vector4 color) => default; // 0x0000000186057EC0-0x0000000186058070
		// [XID] // 0x000000018977F6D0-0x000000018977F6F0
		public static float LogCToLinear(float x) => default; // 0x0000000186058770-0x0000000186058880
		// [XID] // 0x00000001897870D0-0x00000001897870F0
		public static float LinearToLogC(float x) => default; // 0x0000000186058660-0x0000000186058770
		// [XID] // 0x000000018978E740-0x000000018978E760
		public static uint ToHex(Color c) => default; // 0x0000000186058960-0x0000000186058A50
		// [XID] // 0x0000000189795E10-0x0000000189795E30
		public static Color ToRGBA(uint hex) => default; // 0x0000000186058A50-0x0000000186058BA0
	}
}
