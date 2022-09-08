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
	// [PostProcess] // 0x00000001897A5650-0x00000001897A56C0
	public sealed class ScreenSpaceReflections : PostProcessEffectSettings // TypeDefIndex: 9523
	{
		// Fields
		// [Tooltip] // 0x00000001897B2D20-0x00000001897B2D50
		public ScreenSpaceReflectionPresetParameter preset; // 0x30
		// [Range] // 0x00000001897BC8D0-0x00000001897BC920
		// [Tooltip] // 0x00000001897BC8D0-0x00000001897BC920
		public IntParameter maximumIterationCount; // 0x38
		// [Tooltip] // 0x00000001897C8910-0x00000001897C8940
		public ScreenSpaceReflectionResolutionParameter resolution; // 0x40
		// [Range] // 0x00000001897D1460-0x00000001897D14C0
		// [Tooltip] // 0x00000001897D1460-0x00000001897D14C0
		public FloatParameter thickness; // 0x48
		// [Tooltip] // 0x00000001897DD550-0x00000001897DD580
		public FloatParameter maximumMarchDistance; // 0x50
		// [Range] // 0x00000001897E6810-0x00000001897E6870
		// [Tooltip] // 0x00000001897E6810-0x00000001897E6870
		public FloatParameter distanceFade; // 0x58
		// [Range] // 0x00000001897F2BF0-0x00000001897F2C40
		// [Tooltip] // 0x00000001897F2BF0-0x00000001897F2C40
		public FloatParameter attenuation; // 0x60
	
		// Constructors
		public ScreenSpaceReflections() {} // 0x0000000185E1B660-0x0000000185E1B8B0
	
		// Methods
		// [XID] // 0x000000018970F0A0-0x000000018970F0C0
		public override bool IsEnabledAndSupported(PostProcessRenderContext context) => default; // 0x0000000185E1B4C0-0x0000000185E1B5E0
	}
}
