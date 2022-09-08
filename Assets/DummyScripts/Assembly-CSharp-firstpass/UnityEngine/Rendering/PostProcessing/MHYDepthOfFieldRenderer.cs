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
	public sealed class MHYDepthOfFieldRenderer : PostProcessEffectRenderer<MHYDepthOfField> // TypeDefIndex: 9504
	{
		// Fields
		private RenderTexture m_HalfResCocRT; // 0x20
		private RenderTexture m_HalfResMaxCocRT; // 0x28
		private RenderTexture m_NearCocImmediateRT; // 0x30
		private RenderTexture m_NearCocRT; // 0x38
		private RenderTexture m_ForegroundCocRT0; // 0x40
		private RenderTexture m_BackgroundCocRT0; // 0x48
		private RenderTexture m_ForegroundCocRT1; // 0x50
		private RenderTexture m_BackgroundCocRT1; // 0x58
		private RenderTexture m_OutputColorImmediateRT; // 0x60
		private RenderTexture m_OutputFgdColorRT; // 0x68
		private RenderTexture m_OutputFgdOpacityRT; // 0x70
		private RenderTexture m_OutputBgdColorRT; // 0x78
		private readonly RenderTexture[] m_HistoryColor; // 0x80
		private readonly RenderTexture[] m_HistoryCoc; // 0x88
		private int m_HistoryPingPong; // 0x90
		private RenderTargetIdentifier m_HalfResColorID; // 0x98
		private RenderTargetIdentifier m_HalfResCocID; // 0xC8
		private RenderTargetIdentifier[] m_MRTLayers; // 0xF8
		private const int kCocTileSize = 8; // Metadata: 0x00AE5A3D
		private const int kDispatchGroupSize = 8; // Metadata: 0x00AE5A41
		private const int kMaxCocDilateRadius = 3; // Metadata: 0x00AE5A45
	
		// Nested types
		private enum Pass // TypeDefIndex: 9505
		{
			Setup = 0,
			SetupWithTemporalFilter = 1,
			FlattenCoc = 2,
			DilateCoc_1 = 3,
			DilateCoc_2 = 4,
			DilateCoc_3 = 5,
			GatherForeground = 6,
			GatherBackground = 7,
			PostFilterForeground = 8,
			PostFilterBackground = 9,
			Recombine = 10
		}
	
		private enum KernelName // TypeDefIndex: 9506
		{
			kCocMaxFilterHorizental_R_3 = 0,
			kCocMaxFilterHorizental_R_6 = 1,
			kCocMaxFilterVertical_R_3 = 2,
			kCocMaxFilterVertical_R_6 = 3,
			kCocBoxFilterHorizental_R_3 = 4,
			kCocBoxFilterHorizental_R_6 = 5,
			kCocBoxFilterVertical_R_3 = 6,
			kCocBoxFilterVertical_R_6 = 7,
			kFlattenCoc = 8,
			kFlattenCoc_OutwardBlurCoc = 9,
			kDilateCoc_1 = 10,
			kDilateCoc_2 = 11,
			kDilateCoc_3 = 12,
			kGather_Foreground_NoneHoleFilling = 13,
			kGather_Foreground_Mirror = 14,
			kGather_Foreground_OutwardBlurCoc = 15,
			kGather_Background = 16,
			kPostFilter_Foreground = 17,
			kPostFilter_Foreground_OutwardBlurCoc = 18,
			kPostFilter_Background = 19
		}
	
		private static class Uniforms // TypeDefIndex: 9507
		{
			// Fields
			internal static int m_HalfResParams; // 0x00
			internal static int m_TileGridResParams; // 0x04
			internal static int m_CocCalculateParams; // 0x08
			internal static int m_CocGeneralParams; // 0x0C
			internal static int m_TemporalFilterParams; // 0x10
			internal static int m_HalfResColorTex; // 0x14
			internal static int m_HalfResCocTex; // 0x18
			internal static int m_HalfResMaxCocTex; // 0x1C
			internal static int m_HistoryColorTex; // 0x20
			internal static int m_HistoryCocTex; // 0x24
			internal static int m_SceneColorTex; // 0x28
			internal static int m_InputFgdTex; // 0x2C
			internal static int m_InputFgdOpacityTex; // 0x30
			internal static int m_InputBgdTex; // 0x34
			internal static int m_MotionBlurAlphaTex; // 0x38
			internal static int m_OutputTex0; // 0x3C
			internal static int m_OutputTex1; // 0x40
			internal static int m_NearCocImmediateTex; // 0x44
			internal static int m_NearCocTex; // 0x48
			internal static int m_ForegroundCocTex0; // 0x4C
			internal static int m_BackgroundCocTex0; // 0x50
			internal static int m_ForegroundCocTex1; // 0x54
			internal static int m_BackgroundCocTex1; // 0x58
			internal static int m_OutputColorImmediateTex; // 0x5C
			internal static int m_OutputFgdColorTex; // 0x60
			internal static int m_OutputFgdOpacityTex; // 0x64
			internal static int m_OutputBgdColorTex; // 0x68
	
			// Constructors
			static Uniforms() {} // 0x0000000185C11520-0x0000000185C11910
		}
	
		private class Parameters // TypeDefIndex: 9508
		{
			// Fields
			public bool bUseDynamicScale; // 0x10
			public bool bUseComputeShader; // 0x11
			public bool bUseMaxCocForBlending; // 0x12
			public bool bEnableTAA; // 0x13
			public MHYDepthOfField.HoleFillMethod holeFillMethod; // 0x14
			public int dilateRadius; // 0x18
			public Vector2Int halfResolution; // 0x1C
			public Vector2Int tileGridResolution; // 0x24
			public Vector4 cocCalculateParams; // 0x2C
			public Vector4 cocGeneralParams; // 0x3C
			public Vector4 temporalFilterParams; // 0x4C
	
			// Constructors
			public Parameters() {} // 0x0000000185BFDB70-0x0000000185BFDBD0
		}
	
		// Constructors
		public MHYDepthOfFieldRenderer() {} // 0x0000000185BF5BB0-0x0000000185BF5CA0
	
		// Methods
		// [XID] // 0x0000000189AC69B0-0x0000000189AC69D0
		public override DepthTextureMode GetCameraFlags() => default; // 0x0000000185BF1330-0x0000000185BF1410
		// [XID] // 0x000000018976CC60-0x000000018976CC80
		private void CheckRT(ref RenderTexture rt, int width, int height, FilterMode filterMode, RenderTextureFormat format, bool enableRandomWrite, bool useDynamicScale, string name, ulong lifeTimeMask, bool forceReplace = false /* Metadata: 0x00AE5A3C */) {} // 0x0000000185BF1030-0x0000000185BF1330
		// [XID] // 0x00000001896746F0-0x0000000189674710
		private void ReleaseRT(ref RenderTexture rt) {} // 0x0000000185BF41D0-0x0000000185BF4290
		// [XID] // 0x0000000189729730-0x0000000189729750
		private RenderTexture CheckHistory(int id, int width, int height, bool bCoc, bool useDynamicScale) => default; // 0x0000000185BF0B90-0x0000000185BF1030
		// [XID] // 0x00000001898156D0-0x00000001898156F0
		public override void Render(PostProcessRenderContext context) {} // 0x0000000185BF4540-0x0000000185BF5AC0
		// [XID] // 0x0000000189B4CBD0-0x0000000189B4CBF0
		public override void Release(PostProcessRenderContext context) {} // 0x0000000185BF4290-0x0000000185BF4540
		// [XID] // 0x000000018978A840-0x000000018978A860
		private void InvokePS(PostProcessRenderContext context, PropertySheet sheet, Parameters parameters) {} // 0x0000000185BF3030-0x0000000185BF41D0
		// [XID] // 0x000000018981D200-0x000000018981D220
		private void InvokeCS(PostProcessRenderContext context, PropertySheet sheet, Parameters parameters) {} // 0x0000000185BF1410-0x0000000185BF3030
	}
}
