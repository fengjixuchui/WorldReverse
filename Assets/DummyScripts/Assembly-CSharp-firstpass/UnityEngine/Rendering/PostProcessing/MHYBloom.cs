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
	// [PostProcess] // 0x00000001898C66F0-0x00000001898C6760
	public sealed class MHYBloom : PostProcessEffectSettings // TypeDefIndex: 9494
	{
		// Fields
		// [Header] // 0x00000001898D3ED0-0x00000001898D3F50
		// [Range] // 0x00000001898D3ED0-0x00000001898D3F50
		// [Tooltip] // 0x00000001898D3ED0-0x00000001898D3F50
		public FloatParameter glareThreshold; // 0x30
		// [Range] // 0x00000001898E4B60-0x00000001898E4BB0
		// [Tooltip] // 0x00000001898E4B60-0x00000001898E4BB0
		public FloatParameter glareScaler; // 0x38
		// [Range] // 0x00000001898F0EC0-0x00000001898F0F20
		// [Tooltip] // 0x00000001898F0EC0-0x00000001898F0F20
		public FloatParameter glareIntensity; // 0x40
		// [Tooltip] // 0x00000001898FCED0-0x00000001898FCF00
		public Vector4Parameter blurLevelWeights; // 0x48
		// [Tooltip] // 0x0000000189905F60-0x0000000189905F90
		public Vector4Parameter blurLevelBufferHeights; // 0x50
		// [Header] // 0x000000018990F1D0-0x000000018990F200
		public BoolParameter tonemapping; // 0x58
		public BoolParameter filmicHDR; // 0x60
		// [Range] // 0x0000000189918110-0x0000000189918170
		// [Tooltip] // 0x0000000189918110-0x0000000189918170
		public FloatParameter exposure; // 0x68
		// [Range] // 0x00000001899245B0-0x0000000189924600
		// [Tooltip] // 0x00000001899245B0-0x0000000189924600
		public FloatParameter contrast; // 0x70
		// [Header] // 0x000000018992FE90-0x000000018992FEF0
		// [Tooltip] // 0x000000018992FE90-0x000000018992FEF0
		public MHYBloomQualityParameter quality; // 0x78
		// [Tooltip] // 0x000000018993D960-0x000000018993D990
		public MHYBloomHDRFormatParameter hdrFormat; // 0x80
		// [Header] // 0x0000000189AD9AF0-0x0000000189AD9B20
		public MHYBloomDebugParameter debug; // 0x88
		public const int BlurLevelCount = 4; // Metadata: 0x00AE59E0
		public const int MaxBlurSize = 20; // Metadata: 0x00AE59E4
		public const int PrevBlurSize = 10; // Metadata: 0x00AE59E8
		private static readonly float[] k_BloomTexScaler; // 0x00
		public static readonly int k_MaxBloomTexWidth; // 0x08
		public static readonly float[] k_RelGaussRaidus; // 0x10
		public static readonly int MaxDownsampleTimesToBloomTex; // 0x18
	
		// Properties
		public float bloomTexScaler { /* [XID] */ /* 0x0000000189B9B5F0-0x0000000189B9B610 */ get => default; } // 0x0000000186066680-0x0000000186066790 
	
		// Constructors
		public MHYBloom() {} // 0x0000000186066050-0x0000000186066680
		static MHYBloom() {} // 0x0000000186065F40-0x0000000186066050
	
		// Methods
		// [XID] // 0x00000001899553E0-0x0000000189955400
		public RenderTextureFormat TargetFormat(RenderTextureFormat srcFormat) => default; // 0x0000000186065E70-0x0000000186065F40
	}
}
