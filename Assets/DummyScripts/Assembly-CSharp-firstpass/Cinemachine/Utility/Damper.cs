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

namespace Cinemachine.Utility
{
	public static class Damper // TypeDefIndex: 6859
	{
		// Fields
		private const float Epsilon = 0.0001f; // Metadata: 0x00ADDF6C
		public const float kNegligibleResidual = 0.01f; // Metadata: 0x00ADDF70
	
		// Methods
		// [XID] // 0x000000018985D300-0x000000018985D320
		private static float DecayConstant(float time, float residual) => default; // 0x000000018669A970-0x000000018669AA60
		// [XID] // 0x0000000189864CF0-0x0000000189864D10
		private static float Decay(float initial, float decayConstant, float deltaTime) => default; // 0x000000018669AA60-0x000000018669AB60
		// [IDTag] // 0x000000018986C2A0-0x000000018986C2E0
		// [XID] // 0x000000018986C2A0-0x000000018986C2E0
		public static float Damp(float initial, float dampTime, float deltaTime) => default; // 0x000000018669A690-0x000000018669A800
		// [IDTag] // 0x0000000189876750-0x0000000189876790
		// [XID] // 0x0000000189876750-0x0000000189876790
		public static Vector3 Damp(Vector3 initial, Vector3 dampTime, float deltaTime) => default; // 0x000000018669A500-0x000000018669A690
		// [IDTag] // 0x0000000189880EB0-0x0000000189880EF0
		// [XID] // 0x0000000189880EB0-0x0000000189880EF0
		public static Vector3 Damp(Vector3 initial, float dampTime, float deltaTime) => default; // 0x000000018669A800-0x000000018669A970
	}
}
