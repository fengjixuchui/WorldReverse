/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	public sealed class PostProcessResources : ScriptableObject // TypeDefIndex: 9596
	{
		// Fields
		public Texture2D[] blueNoise64; // 0x18
		public Texture2D[] blueNoise256; // 0x20
		public SMAALuts smaaLuts; // 0x28
		public Shaders shaders; // 0x30
		public MiHoYoShaders miHoYoShaders; // 0x38
		public ComputeShaders computeShaders; // 0x40
	
		// Nested types
		[Serializable]
		public sealed class Shaders // TypeDefIndex: 9597
		{
			// Fields
			public Shader autoExposure; // 0x10
			public Shader bloom; // 0x18
			public Shader copy; // 0x20
			public Shader copyStd; // 0x28
			public Shader discardAlpha; // 0x30
			public Shader depthOfField; // 0x38
			public Shader finalPass; // 0x40
			public Shader grainBaker; // 0x48
			public Shader motionBlur; // 0x50
			public Shader temporalAntialiasing; // 0x58
			public Shader subpixelMorphologicalAntialiasing; // 0x60
			public Shader texture2dLerp; // 0x68
			public Shader uber; // 0x70
			public Shader lut2DBaker; // 0x78
			public Shader lightMeter; // 0x80
			public Shader gammaHistogram; // 0x88
			public Shader waveform; // 0x90
			public Shader vectorscope; // 0x98
			public Shader debugOverlays; // 0xA0
			public Shader deferredFog; // 0xA8
			public Shader scalableAO; // 0xB0
			public Shader multiScaleAO; // 0xB8
			public Shader screenSpaceReflections; // 0xC0
	
			// Constructors
			public Shaders() {} // 0x0000000185E1D780-0x0000000185E1D7E0
		}
	
		[Serializable]
		public sealed class MiHoYoShaders // TypeDefIndex: 9598
		{
			// Fields
			public Shader bloom; // 0x10
			public Shader downSample; // 0x18
			public Shader downSample4X; // 0x20
			public Shader gaussFilterLow; // 0x28
			public Shader gaussFilterMedium; // 0x30
			public Shader gaussFilterHigh; // 0x38
			public Shader gaussFilters; // 0x40
			public Shader hexBlur; // 0x48
			public Shader radialBlur; // 0x50
			public Shader renderWaterRipple; // 0x58
			public Shader rainingFlow; // 0x60
			public Shader toonLightBuffer; // 0x68
			public Shader utilBlur; // 0x70
			public Shader frameTransition; // 0x78
			public Shader elementView; // 0x80
			public Shader hdr2sdr; // 0x88
	
			// Constructors
			public MiHoYoShaders() {} // 0x0000000185E01EE0-0x0000000185E01F40
		}
	
		[Serializable]
		public sealed class ComputeShaders // TypeDefIndex: 9599
		{
			// Fields
			public ComputeShader exposureHistogram; // 0x10
			public ComputeShader lut3DBaker; // 0x18
			public ComputeShader texture3dLerp; // 0x20
			public ComputeShader gammaHistogram; // 0x28
			public ComputeShader waveform; // 0x30
			public ComputeShader vectorscope; // 0x38
			public ComputeShader multiScaleAODownsample1; // 0x40
			public ComputeShader multiScaleAODownsample2; // 0x48
			public ComputeShader multiScaleAORender; // 0x50
			public ComputeShader multiScaleAOUpsample; // 0x58
			public ComputeShader gaussianDownsample; // 0x60
			public ComputeShader depthOfField; // 0x68
	
			// Constructors
			public ComputeShaders() {} // 0x0000000185E00E70-0x0000000185E00ED0
		}
	
		[Serializable]
		public sealed class SMAALuts // TypeDefIndex: 9600
		{
			// Fields
			public Texture2D area; // 0x10
			public Texture2D search; // 0x18
	
			// Constructors
			public SMAALuts() {} // 0x0000000185E177C0-0x0000000185E17820
		}
	
		// Constructors
		public PostProcessResources() {} // 0x0000000185E0AA20-0x0000000185E0AA80
	}
}
