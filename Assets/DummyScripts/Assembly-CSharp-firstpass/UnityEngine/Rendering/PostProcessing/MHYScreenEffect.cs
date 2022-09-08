/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	// [PostProcess] // 0x0000000189B632A0-0x0000000189B63310
	public sealed class MHYScreenEffect : PostProcessEffectSettings // TypeDefIndex: 9509
	{
		// Fields
		// [DisplayName] // 0x0000000189B709D0-0x0000000189B70A00
		public ColorParameter _BrightColor; // 0x30
		// [DisplayName] // 0x0000000189B79890-0x0000000189B798C0
		public ColorParameter _DarkColor; // 0x38
		// [DisplayName] // 0x0000000189B82750-0x0000000189B82780
		public FloatParameter _Brightness; // 0x40
		// [DisplayName] // 0x0000000189B8B000-0x0000000189B8B030
		public FloatParameter _LerpValue; // 0x48
		// [DisplayName] // 0x0000000189B94140-0x0000000189B94170
		public BoolParameter _Twinkle; // 0x50
		// [DisplayName] // 0x0000000189B9CCB0-0x0000000189B9CCE0
		public FloatParameter _TwinkleRange; // 0x58
		// [DisplayName] // 0x0000000189BA5D90-0x0000000189BA5DC0
		public FloatParameter _TwinkleSpeed; // 0x60
		// [DisplayName] // 0x0000000189BAE600-0x0000000189BAE630
		public TextureNoInterpParameter _MaskTex; // 0x68
		// [DisplayName] // 0x0000000189BB7480-0x0000000189BB74B0
		public FloatParameter _MaskScale; // 0x70
		// [DisplayName] // 0x0000000189BC0510-0x0000000189BC0540
		public TextureNoInterpParameter _DetailTex; // 0x78
		// [DisplayName] // 0x0000000189BC9A70-0x0000000189BC9AA0
		public Vector4Parameter _DetailTexTiling; // 0x80
		// [DisplayName] // 0x0000000189BD2A50-0x0000000189BD2A80
		public FloatParameter _DetailScale; // 0x88
		// [DisplayName] // 0x0000000189BDBBB0-0x0000000189BDBBE0
		public BoolParameter _FinalBlendMode; // 0x90
		// [DisplayName] // 0x00000001895E9D80-0x00000001895E9DB0
		public BoolParameter _MaskBlendMode; // 0x98
		// [DisplayName] // 0x00000001895F2AE0-0x00000001895F2B10
		public BoolParameter _DissolveMode; // 0xA0
		// [DisplayName] // 0x00000001895FBC60-0x00000001895FBC90
		public FloatParameter _DissolveThreshold; // 0xA8
		// [DisplayName] // 0x0000000189604C10-0x0000000189604C40
		public FloatParameter _NoiseScale; // 0xB0
		// [DisplayName] // 0x000000018960DD50-0x000000018960DD80
		public FloatParameter _EffectIntensity; // 0xB8
	
		// Constructors
		public MHYScreenEffect() {} // 0x0000000185BF7DC0-0x0000000185BF8220
	
		// Methods
		// [XID] // 0x0000000189615490-0x00000001896154B0
		public override bool IsEnabledAndSupported(PostProcessRenderContext context) => default; // 0x0000000185BF7C80-0x0000000185BF7D40
	}
}
