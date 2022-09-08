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
	[Serializable]
	public sealed class Spline // TypeDefIndex: 9620
	{
		// Fields
		public const int k_Precision = 128; // Metadata: 0x00AE5CB6
		public const float k_Step = 0.0078125f; // Metadata: 0x00AE5CBA
		public AnimationCurve curve; // 0x10
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_Loop; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_ZeroValue; // 0x1C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_Range; // 0x20
		private AnimationCurve m_InternalLoopingCurve; // 0x28
		private int frameCount; // 0x30
		internal float[] cachedData; // 0x38
	
		// Constructors
		public Spline() {} // Dummy constructor
		public Spline(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds) {} // 0x0000000185E1DF30-0x0000000185E1E000
	
		// Methods
		// [XID] // 0x0000000189718AA0-0x0000000189718AC0
		public void Cache(int frame) {} // 0x0000000185E1DA20-0x0000000185E1DCE0
		// [XID] // 0x000000018996A5A0-0x000000018996A5C0
		public float Evaluate(float t) => default; // 0x0000000185E1DCE0-0x0000000185E1DE00
		// [XID] // 0x0000000189727980-0x00000001897279A0
		public override int GetHashCode() => default; // 0x0000000185E1DE00-0x0000000185E1DEC0
	}
}
