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
	// [PostProcess] // 0x0000000189BB4890-0x0000000189BB4900
	public sealed class AutoExposure : PostProcessEffectSettings // TypeDefIndex: 9474
	{
		// Fields
		// [DisplayName] // 0x0000000189BC2420-0x0000000189BC24A0
		// [MinMax] // 0x0000000189BC2420-0x0000000189BC24A0
		// [Tooltip] // 0x0000000189BC2420-0x0000000189BC24A0
		public Vector2Parameter filtering; // 0x30
		// [DisplayName] // 0x0000000189BD2A80-0x0000000189BD2B00
		// [Range] // 0x0000000189BD2A80-0x0000000189BD2B00
		// [Tooltip] // 0x0000000189BD2A80-0x0000000189BD2B00
		public FloatParameter minLuminance; // 0x38
		// [DisplayName] // 0x00000001895E8510-0x00000001895E8590
		// [Range] // 0x00000001895E8510-0x00000001895E8590
		// [Tooltip] // 0x00000001895E8510-0x00000001895E8590
		public FloatParameter maxLuminance; // 0x40
		// [Min] // 0x00000001895F8F90-0x00000001895F8FE0
		// [Tooltip] // 0x00000001895F8F90-0x00000001895F8FE0
		public FloatParameter keyValue; // 0x48
		// [DisplayName] // 0x0000000189604C40-0x0000000189604CA0
		// [Tooltip] // 0x0000000189604C40-0x0000000189604CA0
		public EyeAdaptationParameter eyeAdaptation; // 0x50
		// [Min] // 0x0000000189612370-0x00000001896123C0
		// [Tooltip] // 0x0000000189612370-0x00000001896123C0
		public FloatParameter speedUp; // 0x58
		// [Min] // 0x000000018961E400-0x000000018961E450
		// [Tooltip] // 0x000000018961E400-0x000000018961E450
		public FloatParameter speedDown; // 0x60
	
		// Constructors
		public AutoExposure() {} // 0x0000000186055C40-0x0000000186055FC0
	
		// Methods
		// [XID] // 0x000000018962A240-0x000000018962A260
		public override bool IsEnabledAndSupported(PostProcessRenderContext context) => default; // 0x0000000186055AD0-0x0000000186055BC0
	}
}
