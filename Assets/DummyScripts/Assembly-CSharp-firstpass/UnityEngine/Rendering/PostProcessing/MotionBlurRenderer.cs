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
	public sealed class MotionBlurRenderer : PostProcessEffectRenderer<MotionBlur> // TypeDefIndex: 9514
	{
		// Fields
		private readonly RenderTargetIdentifier[] m_MrtDofGather; // 0x20
		private readonly RenderTargetIdentifier[] m_MrtDofDownSample; // 0x28
		private readonly RenderTargetIdentifier[] m_MrtDofRecombine; // 0x30
		private static float[] s_pWeights; // 0x00
		private static Vector4[] s_vhBlurOffset; // 0x08
		private static Vector4[] s_gaussBlurWeights; // 0x10
	
		// Nested types
		private enum Pass // TypeDefIndex: 9515
		{
			DownSampleWithAlpha = 0,
			VelocityBlur = 1,
			DownSampleWithFarNear = 2,
			DofGather = 3,
			DownSampleDofOnly = 4,
			DofRecombine = 5,
			MotionVectorHBlur = 6,
			MotionVectorVBlur = 7
		}
	
		private static class RenderTextureNameIds // TypeDefIndex: 9516
		{
			// Fields
			public static readonly int rt; // 0x00
			public static readonly int temp0; // 0x04
			public static readonly int temp1; // 0x08
			public static readonly int halfMV; // 0x0C
			public static readonly int nearHalf; // 0x10
			public static readonly int farHalf; // 0x14
			public static readonly int nearHalfOut; // 0x18
			public static readonly int farHalfOut; // 0x1C
	
			// Constructors
			static RenderTextureNameIds() {} // 0x0000000185C113C0-0x0000000185C11520
		}
	
		// Constructors
		public MotionBlurRenderer() {} // 0x0000000185BFD470-0x0000000185BFD540
	
		// Methods
		// [XID] // 0x0000000189A2EBC0-0x0000000189A2EBE0
		public override DepthTextureMode GetCameraFlags() => default; // 0x0000000185BF8A20-0x0000000185BF8B00
		// [XID] // 0x000000018988D080-0x000000018988D0A0
		public override void OnEnable(PostProcessRenderContext context) {} // 0x0000000185BF8B00-0x0000000185BF8BE0
		// [XID] // 0x00000001896F1830-0x00000001896F1850
		public override void Release(PostProcessRenderContext context) {} // 0x0000000185BF8BE0-0x0000000185BF8CC0
		// [XID] // 0x000000018965A800-0x000000018965A820
		public override void Render(PostProcessRenderContext context) {} // 0x0000000185BF8CC0-0x0000000185BFD300
	}
}
