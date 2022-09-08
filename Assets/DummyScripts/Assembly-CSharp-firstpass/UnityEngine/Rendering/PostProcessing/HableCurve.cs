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
	public class HableCurve // TypeDefIndex: 9603
	{
		// Fields
		public readonly Segment[] segments; // 0x20
		public readonly Uniforms uniforms; // 0x28
	
		// Properties
		public float whitePoint { get; /* [XID] */ /* 0x00000001897CFFD0-0x00000001897D0010 */ private set; } // 0x000000018605ECA0-0x000000018605ED10 0x000000018605EE60-0x000000018605EED0
		public float inverseWhitePoint { /* [XID] */ /* 0x00000001897DAB10-0x00000001897DAB50 */ get; /* [XID] */ /* 0x00000001897E4EF0-0x00000001897E4F30 */ private set; } // 0x000000018605EC30-0x000000018605ECA0 0x000000018605EDF0-0x000000018605EE60
		public float x0 { /* [XID] */ /* 0x00000001897EFA70-0x00000001897EFAB0 */ get; /* [XID] */ /* 0x00000001897FA510-0x00000001897FA550 */ private set; } // 0x000000018605ED10-0x000000018605ED80 0x000000018605EED0-0x000000018605EF40
		public float x1 { /* [XID] */ /* 0x0000000189804800-0x0000000189804840 */ get; /* [XID] */ /* 0x000000018980EFF0-0x000000018980F030 */ private set; } // 0x000000018605ED80-0x000000018605EDF0 0x000000018605EF40-0x000000018605EFB0
	
		// Nested types
		public class Segment // TypeDefIndex: 9604
		{
			// Fields
			public float offsetX; // 0x10
			public float offsetY; // 0x14
			public float scaleX; // 0x18
			public float scaleY; // 0x1C
			public float lnA; // 0x20
			public float B; // 0x24
	
			// Constructors
			public Segment() {} // 0x0000000186074E40-0x0000000186074EA0
	
			// Methods
			// [XID] // 0x0000000189845F90-0x0000000189845FB0
			public float Eval(float x) => default; // 0x0000000186074D10-0x0000000186074E40
		}
	
		private struct DirectParams // TypeDefIndex: 9605
		{
			// Fields
			internal float x0; // 0x00
			internal float y0; // 0x04
			internal float x1; // 0x08
			internal float y1; // 0x0C
			internal float W; // 0x10
			internal float overshootX; // 0x14
			internal float overshootY; // 0x18
			internal float gamma; // 0x1C
		}
	
		public class Uniforms // TypeDefIndex: 9606
		{
			// Fields
			private HableCurve parent; // 0x10
	
			// Properties
			public Vector4 curve { /* [XID] */ /* 0x000000018984D670-0x000000018984D690 */ get => default; } // 0x00000001860763D0-0x0000000186076600 
			public Vector4 toeSegmentA { /* [XID] */ /* 0x0000000189854650-0x0000000189854670 */ get => default; } // 0x0000000186076B20-0x0000000186076C70 
			public Vector4 toeSegmentB { /* [XID] */ /* 0x000000018985C0A0-0x000000018985C0C0 */ get => default; } // 0x0000000186076C70-0x0000000186076DB0 
			public Vector4 midSegmentA { /* [XID] */ /* 0x00000001896F4D40-0x00000001896F4D60 */ get => default; } // 0x0000000186076600-0x0000000186076750 
			public Vector4 midSegmentB { /* [XID] */ /* 0x00000001896DEB30-0x00000001896DEB50 */ get => default; } // 0x0000000186076750-0x0000000186076890 
			public Vector4 shoSegmentA { /* [XID] */ /* 0x0000000189871F50-0x0000000189871F70 */ get => default; } // 0x0000000186076890-0x00000001860769E0 
			public Vector4 shoSegmentB { /* [XID] */ /* 0x00000001898797E0-0x0000000189879800 */ get => default; } // 0x00000001860769E0-0x0000000186076B20 
	
			// Constructors
			public Uniforms() {} // Dummy constructor
			internal Uniforms(HableCurve parent) {} // 0x0000000186076360-0x00000001860763D0
		}
	
		// Constructors
		public HableCurve() {} // 0x000000018605EA70-0x000000018605EC30
	
		// Methods
		// [XID] // 0x0000000189AB4590-0x0000000189AB45B0
		public float Eval(float x) => default; // 0x000000018605DCB0-0x000000018605DE50
		// [XID] // 0x0000000189821380-0x00000001898213A0
		public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma) {} // 0x000000018605E5E0-0x000000018605E910
		// [XID] // 0x000000018992FD70-0x000000018992FD90
		private void InitSegments(DirectParams srcParams) {} // 0x000000018605DE50-0x000000018605E5E0
		// [XID] // 0x000000018982FB50-0x000000018982FB70
		private void SolveAB(out float lnA, out float B, float x0, float y0, float m) {
			lnA = default;
			B = default;
		} // 0x000000018605E910-0x000000018605EA70
		// [XID] // 0x000000018964E020-0x000000018964E040
		private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1) {
			m = default;
			b = default;
		} // 0x000000018605DA20-0x000000018605DB70
		// [XID] // 0x00000001896678E0-0x0000000189667900
		private float EvalDerivativeLinearGamma(float m, float b, float g, float x) => default; // 0x000000018605DB70-0x000000018605DCB0
	}
}
