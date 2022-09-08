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
	// [PostProcess] // 0x00000001896482B0-0x0000000189648320
	public sealed class Bloom : PostProcessEffectSettings // TypeDefIndex: 9476
	{
		// Fields
		// [Min] // 0x0000000189655B50-0x0000000189655BA0
		// [Tooltip] // 0x0000000189655B50-0x0000000189655BA0
		public FloatParameter intensity; // 0x30
		// [Min] // 0x0000000189661790-0x00000001896617E0
		// [Tooltip] // 0x0000000189661790-0x00000001896617E0
		public FloatParameter threshold; // 0x38
		// [Range] // 0x000000018966D760-0x000000018966D7B0
		// [Tooltip] // 0x000000018966D760-0x000000018966D7B0
		public FloatParameter softKnee; // 0x40
		// [Range] // 0x0000000189679F60-0x0000000189679FC0
		// [Tooltip] // 0x0000000189679F60-0x0000000189679FC0
		public FloatParameter diffusion; // 0x48
		// [Range] // 0x0000000189685C30-0x0000000189685C90
		// [Tooltip] // 0x0000000189685C30-0x0000000189685C90
		public FloatParameter anamorphicRatio; // 0x50
		// [ColorUsage] // 0x0000000189692600-0x0000000189692680
		// [Tooltip] // 0x0000000189692600-0x0000000189692680
		public ColorParameter color; // 0x58
		// [Tooltip] // 0x000000018985A960-0x000000018985A990
		public BoolParameter mobileOptimized; // 0x60
		// [DisplayName] // 0x00000001896A6AB0-0x00000001896A6B10
		// [Tooltip] // 0x00000001896A6AB0-0x00000001896A6B10
		public TextureParameter dirtTexture; // 0x68
		// [DisplayName] // 0x00000001896B3F30-0x00000001896B3FA0
		// [Min] // 0x00000001896B3F30-0x00000001896B3FA0
		// [Tooltip] // 0x00000001896B3F30-0x00000001896B3FA0
		public FloatParameter dirtIntensity; // 0x70
	
		// Constructors
		public Bloom() {} // 0x0000000186057520-0x0000000186057960
	
		// Methods
		// [XID] // 0x0000000189718960-0x0000000189718980
		public override bool IsEnabledAndSupported(PostProcessRenderContext context) => default; // 0x00000001860573B0-0x00000001860574A0
	}
}
