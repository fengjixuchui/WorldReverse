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
	// [PostProcess] // 0x0000000189991890-0x0000000189991900
	public sealed class MHYColorGrading : PostProcessEffectSettings // TypeDefIndex: 9498
	{
		// Fields
		// [DisplayName] // 0x000000018999F250-0x000000018999F2B0
		// [Range] // 0x000000018999F250-0x000000018999F2B0
		public FloatParameter transitionRatio; // 0x30
		// [DisplayName] // 0x00000001899AB790-0x00000001899AB810
		// [Header] // 0x00000001899AB790-0x00000001899AB810
		// [Tooltip] // 0x00000001899AB790-0x00000001899AB810
		public BoolParameter destCustomized; // 0x38
		// [DisplayName] // 0x0000000189A1C6A0-0x0000000189A1C700
		// [Tooltip] // 0x0000000189A1C6A0-0x0000000189A1C700
		public TextureNoInterpParameter destForegroundLut; // 0x40
		// [DisplayName] // 0x00000001899CAC90-0x00000001899CACF0
		// [Range] // 0x00000001899CAC90-0x00000001899CACF0
		public FloatParameter destForegroundDistance; // 0x48
		// [DisplayName] // 0x00000001899D6A10-0x00000001899D6A70
		// [Tooltip] // 0x00000001899D6A10-0x00000001899D6A70
		public TextureNoInterpParameter destBackgroundLut; // 0x50
		// [DisplayName] // 0x00000001899E4140-0x00000001899E41A0
		// [Range] // 0x00000001899E4140-0x00000001899E41A0
		public FloatParameter destBackgroundDistance; // 0x58
		// [DisplayName] // 0x00000001899F02C0-0x00000001899F0340
		// [Range] // 0x00000001899F02C0-0x00000001899F0340
		// [Tooltip] // 0x00000001899F02C0-0x00000001899F0340
		public FloatParameter destColorgradingFade; // 0x60
		// [DisplayName] // 0x0000000189A00540-0x0000000189A005A0
		// [Tooltip] // 0x0000000189A00540-0x0000000189A005A0
		public TextureNoInterpParameter destCharacterLut; // 0x68
		// [DisplayName] // 0x0000000189A0DDE0-0x0000000189A0DE60
		// [Header] // 0x0000000189A0DDE0-0x0000000189A0DE60
		// [Tooltip] // 0x0000000189A0DDE0-0x0000000189A0DE60
		public BoolParameter sourceCustomized; // 0x70
		// [DisplayName] // 0x0000000189A1C6A0-0x0000000189A1C700
		// [Tooltip] // 0x0000000189A1C6A0-0x0000000189A1C700
		public TextureNoInterpParameter sourceForegroundLut; // 0x78
		// [DisplayName] // 0x0000000189A26BD0-0x0000000189A26C20
		// [Range] // 0x0000000189A26BD0-0x0000000189A26C20
		public FloatParameter sourceForegroundDistance; // 0x80
		// [DisplayName] // 0x0000000189A31040-0x0000000189A310A0
		// [Tooltip] // 0x0000000189A31040-0x0000000189A310A0
		public TextureNoInterpParameter sourceBackgroundLut; // 0x88
		// [DisplayName] // 0x0000000189A3B8B0-0x0000000189A3B900
		// [Range] // 0x0000000189A3B8B0-0x0000000189A3B900
		public FloatParameter sourceBackgroundDistance; // 0x90
		// [DisplayName] // 0x0000000189A46300-0x0000000189A46380
		// [Range] // 0x0000000189A46300-0x0000000189A46380
		// [Tooltip] // 0x0000000189A46300-0x0000000189A46380
		public FloatParameter sourceColorgradingFade; // 0x98
		// [DisplayName] // 0x0000000189A53890-0x0000000189A538F0
		// [Tooltip] // 0x0000000189A53890-0x0000000189A538F0
		public TextureNoInterpParameter sourceCharacterLut; // 0xA0
	
		// Constructors
		public MHYColorGrading() {} // 0x00000001860681D0-0x0000000186068770
	
		// Methods
		// [XID] // 0x0000000189A5E360-0x0000000189A5E380
		public override bool IsEnabledAndSupported(PostProcessRenderContext context) => default; // 0x0000000186068010-0x0000000186068150
	}
}
