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
	public sealed class MHYBloomRenderer : PostProcessEffectRenderer<MHYBloom> // TypeDefIndex: 9495
	{
		// Fields
		private Level[] m_Pyramid; // 0x20
		private const int k_MaxPyramidSize = 4; // Metadata: 0x00AE59EC
		private int m_DownsampleSourceUtilBuffer; // 0x28
		private int m_DownsampleSourceUtil2Buffer; // 0x2C
		private int m_PackedDownBuffer; // 0x30
		private int m_PackedBlurredBuffer; // 0x34
		private int[] m_downsampleTempBuffers; // 0x38
		private RenderTextureWrapper m_BloomTex; // 0x40
	
		// Nested types
		private struct Level // TypeDefIndex: 9496
		{
			// Fields
			internal int down; // 0x00
			internal int temp; // 0x04
			internal int blurred; // 0x08
			internal int width; // 0x0C
			internal int height; // 0x10
			internal Vector4 rect; // 0x14
			internal int blurTexelRadius; // 0x24
		}
	
		public enum BloomShaderPass // TypeDefIndex: 9497
		{
			ExtractBrightness = 0,
			Downsample4Tap = 1,
			Downsample4TapAndExtractBrightness = 2,
			Downsample4x = 3,
			Downsample4xAndExtractBrightness = 4,
			Compose = 5,
			ComposeWithTransform = 6,
			DebugComposeBloom = 7,
			DebugComposeBloomAndTone = 8,
			DebugBlurredLevel = 9
		}
	
		// Constructors
		public MHYBloomRenderer() {} // 0x0000000186065D30-0x0000000186065E70
	
		// Methods
		// [XID] // 0x000000018995CB80-0x000000018995CBA0
		public override void Init() {} // 0x0000000186062B00-0x0000000186062E60
		// [XID] // 0x0000000189BB8960-0x0000000189BB8980
		private RenderTargetIdentifier DownsampleToBloomTexSize(PostProcessRenderContext context, PropertySheet sheet, float scaler, float scalerTolerance, RenderTextureFormat format, ref int candidateRT, out int targetWidth, out int targetHeight, out bool extractedBrightness) {
			targetWidth = default;
			targetHeight = default;
			extractedBrightness = default;
			return default;
		} // 0x0000000186061CD0-0x0000000186062900
		// [XID] // 0x0000000189ABEEB0-0x0000000189ABEED0
		public float GrainHalton(int Index, int Base) => default; // 0x0000000186062900-0x0000000186062A10
		// [XID] // 0x0000000189973630-0x0000000189973650
		public Vector2 GrainRandomFromFrame(int FrameNumber) => default; // 0x0000000186062A10-0x0000000186062B00
		// [XID] // 0x00000001897798A0-0x00000001897798C0
		public override void Render(PostProcessRenderContext context) {} // 0x0000000186062F20-0x0000000186065C50
		// [XID] // 0x00000001899827A0-0x00000001899827C0
		private void Blur(PostProcessRenderContext context, PropertySheet sheet, RenderTargetIdentifier src, RenderTargetIdentifier dst, RenderTargetIdentifier tmp, int w, int h, int gaussWidth) {} // 0x0000000186061510-0x0000000186061CD0
		// [XID] // 0x0000000189989FB0-0x0000000189989FD0
		public override void Release(PostProcessRenderContext context) {} // 0x0000000186062E60-0x0000000186062F20
	}
}
