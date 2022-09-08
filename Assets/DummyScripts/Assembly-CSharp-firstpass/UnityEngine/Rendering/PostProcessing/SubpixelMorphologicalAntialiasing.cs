/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	public sealed class SubpixelMorphologicalAntialiasing // TypeDefIndex: 9527
	{
		// Fields
		public SMAAGlobalSettings globalSettings; // 0x10
		public SMAAQualitySettings qualitySettings; // 0x1C
		public SMAAPredicationSettings predicationSettings; // 0x38
		public SMAATemporalSettings temporalSettings; // 0x48
		public Vector2 jitter; // 0x50
		private Matrix4x4 m_ProjectionMatrix; // 0x58
		private Matrix4x4 m_PreviousViewProjectionMatrix; // 0x98
		private Matrix4x4 m_CurViewProjectionMatrix; // 0xD8
		private float m_FlipFlop; // 0x118
		private int m_rtFlip; // 0x11C
		private readonly RenderTargetIdentifier[] m_MRT; // 0x120
		private RenderTexture[] m_Accumulation; // 0x128
		private RenderTexture[] m_LastFrame; // 0x130
		public bool m_IsHybrid; // 0x148
		public bool m_Dirty; // 0x149
		private const int k_SampleCount = 8; // Metadata: 0x00AE5B3D
		private int m_SampleIndex; // 0x14C
	
		// Properties
		public CameraEvent commandBufferEvent { /* [XID] */ /* 0x0000000189838B00-0x0000000189838B40 */ get; /* [XID] */ /* 0x0000000189843270-0x00000001898432B0 */ private set; } // 0x0000000185E21FC0-0x0000000185E22020 0x0000000185E22080-0x0000000185E220F0
		public CommandBuffer commandBuffer { /* [XID] */ /* 0x000000018984D690-0x000000018984D6D0 */ get; /* [XID] */ /* 0x0000000189857620-0x0000000189857660 */ private set; } // 0x0000000185E22020-0x0000000185E22080 0x0000000185E220F0-0x0000000185E22160
	
		// Nested types
		public enum SMAADebugPass // TypeDefIndex: 9528
		{
			Off = 0,
			Edges = 1,
			Weights = 2,
			Accumulation = 3
		}
	
		public enum SMAAQualityPreset // TypeDefIndex: 9529
		{
			Low = 0,
			Medium = 1,
			High = 2,
			Ultra = 3
		}
	
		public enum SMAAEdgeDetectionMethod // TypeDefIndex: 9530
		{
			Luma = 1,
			Color = 2,
			Depth = 3
		}
	
		[Serializable]
		public struct SMAAGlobalSettings // TypeDefIndex: 9531
		{
			// Fields
			// [Tooltip] // 0x00000001898953E0-0x0000000189895410
			public SMAADebugPass debugPass; // 0x00
			// [Tooltip] // 0x000000018989E0F0-0x000000018989E120
			public SMAAQualityPreset quality; // 0x04
			// [Tooltip] // 0x00000001898A7120-0x00000001898A7150
			public SMAAEdgeDetectionMethod edgeDetectionMethod; // 0x08
	
			// Properties
			public static SMAAGlobalSettings defaultSettings { /* [XID] */ /* 0x00000001898B01D0-0x00000001898B01F0 */ get => default; } // 0x0000000185E176D0-0x0000000185E177C0 
		}
	
		[Serializable]
		public struct SMAAQualitySettings // TypeDefIndex: 9532
		{
			// Fields
			// [Tooltip] // 0x00000001898B7790-0x00000001898B77C0
			public bool diagonalDetection; // 0x00
			// [Tooltip] // 0x00000001898C0860-0x00000001898C0890
			public bool cornerDetection; // 0x01
			// [Tooltip] // 0x00000001898C98B0-0x00000001898C98E0
			public bool mergedPass; // 0x02
			// [Range] // 0x00000001898D27F0-0x00000001898D2840
			// [Tooltip] // 0x00000001898D27F0-0x00000001898D2840
			public float threshold; // 0x04
			// [Min] // 0x00000001898DEF00-0x00000001898DEF50
			// [Tooltip] // 0x00000001898DEF00-0x00000001898DEF50
			public float depthThreshold; // 0x08
			// [Range] // 0x00000001898EAF40-0x00000001898EAFA0
			// [Tooltip] // 0x00000001898EAF40-0x00000001898EAFA0
			public int maxSearchSteps; // 0x0C
			// [Range] // 0x00000001898F70B0-0x00000001898F7100
			// [Tooltip] // 0x00000001898F70B0-0x00000001898F7100
			public int maxDiagonalSearchSteps; // 0x10
			// [Range] // 0x0000000189903030-0x0000000189903090
			// [Tooltip] // 0x0000000189903030-0x0000000189903090
			public int cornerRounding; // 0x14
			// [Min] // 0x000000018990F180-0x000000018990F1D0
			// [Tooltip] // 0x000000018990F180-0x000000018990F1D0
			public float localContrastAdaptationFactor; // 0x18
			public static SMAAQualitySettings[] presetQualitySettings; // 0x00
	
			// Constructors
			static SMAAQualitySettings() {
				presetQualitySettings = default;
			} // 0x0000000185E17940-0x0000000185E17CE0
		}
	
		[Serializable]
		public struct SMAATemporalSettings // TypeDefIndex: 9533
		{
			// Fields
			// [Tooltip] // 0x000000018991B420-0x000000018991B450
			public bool enabled; // 0x00
			// [Range] // 0x0000000189924550-0x00000001899245B0
			// [Tooltip] // 0x0000000189924550-0x00000001899245B0
			public float fuzzSize; // 0x04
	
			// Properties
			public static SMAATemporalSettings defaultSettings { /* [XID] */ /* 0x00000001897C9420-0x00000001897C9440 */ get => default; } // 0x0000000185E17CF0-0x0000000185E17DB0 
	
			// Methods
			// [XID] // 0x000000018992FE70-0x000000018992FE90
			public bool UseTemporal() => default; // 0x0000000185E17CE0-0x0000000185E17CF0
		}
	
		[Serializable]
		public struct SMAAPredicationSettings // TypeDefIndex: 9534
		{
			// Fields
			// [Tooltip] // 0x000000018993EF00-0x000000018993EF30
			public bool enabled; // 0x00
			// [Min] // 0x0000000189947DC0-0x0000000189947E10
			// [Tooltip] // 0x0000000189947DC0-0x0000000189947E10
			public float threshold; // 0x04
			// [Range] // 0x0000000189953AC0-0x0000000189953B10
			// [Tooltip] // 0x0000000189953AC0-0x0000000189953B10
			public float scale; // 0x08
			// [Range] // 0x000000018995FCB0-0x000000018995FD10
			// [Tooltip] // 0x000000018995FCB0-0x000000018995FD10
			public float strength; // 0x0C
	
			// Properties
			public static SMAAPredicationSettings defaultSettings { /* [XID] */ /* 0x000000018996BB20-0x000000018996BB40 */ get => default; } // 0x0000000185E17820-0x0000000185E17940 
		}
	
		private static class Uniforms // TypeDefIndex: 9535
		{
			// Fields
			internal static int m_AreaTex; // 0x00
			internal static int m_SearchTex; // 0x04
			internal static int m_Metrics; // 0x08
			internal static int m_Params1; // 0x0C
			internal static int m_Params2; // 0x10
			internal static int m_Params3; // 0x14
			internal static int m_ReprojectionMatrix; // 0x18
			internal static int m_SubsampleIndices; // 0x1C
			internal static int m_BlendTex; // 0x20
			internal static int m_AccumulationTex; // 0x24
			internal static int m_LastFrameTex; // 0x28
			internal static int m_Jitter; // 0x2C
	
			// Constructors
			static Uniforms() {} // 0x0000000185E27030-0x0000000185E27220
		}
	
		// Constructors
		public SubpixelMorphologicalAntialiasing() {} // 0x0000000185E21E10-0x0000000185E21FC0
	
		// Methods
		// [XID] // 0x0000000189861A50-0x0000000189861A70
		public void Init() {} // 0x0000000185E1E6F0-0x0000000185E1E850
		// [XID] // 0x0000000189869330-0x0000000189869350
		public bool IsSupported() => default; // 0x0000000185E1E850-0x0000000185E1E920
		// [XID] // 0x0000000189A25F90-0x0000000189A25FB0
		internal DepthTextureMode GetCameraFlags() => default; // 0x0000000185E1E630-0x0000000185E1E6F0
		// [XID] // 0x0000000189877DC0-0x0000000189877DE0
		private Vector2 GenerateRandomOffset() => default; // 0x0000000185E1E510-0x0000000185E1E630
		// [XID] // 0x00000001897D87B0-0x00000001897D87D0
		public void ConfigureJitteredProjectionMatrix(PostProcessRenderContext context) {} // 0x0000000185E1E000-0x0000000185E1E510
		// [XID] // 0x0000000189886BF0-0x0000000189886C10
		internal void Render(PostProcessRenderContext context) {} // 0x0000000185E1EBF0-0x0000000185E21E10
		// [XID] // 0x000000018988DCB0-0x000000018988DCD0
		internal void Release() {} // 0x0000000185E1E920-0x0000000185E1EBF0
	}
}
