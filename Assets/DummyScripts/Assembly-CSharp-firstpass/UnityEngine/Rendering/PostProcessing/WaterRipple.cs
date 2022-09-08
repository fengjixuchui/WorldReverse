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
	// [PostProcess] // 0x0000000189B06CE0-0x0000000189B06D50
	public sealed class WaterRipple : PostProcessEffectSettings // TypeDefIndex: 9543
	{
		// Fields
		// [Tooltip] // 0x0000000189B14180-0x0000000189B141B0
		public FloatParameter UpdateTime; // 0x30
		// [Tooltip] // 0x0000000189B1D150-0x0000000189B1D180
		public FloatParameter HitPointUpdateTimeScale; // 0x38
		// [Range] // 0x0000000189B26090-0x0000000189B260E0
		// [Tooltip] // 0x0000000189B26090-0x0000000189B260E0
		public FloatParameter SimGridSize; // 0x40
		// [Range] // 0x0000000189B31B00-0x0000000189B31B50
		// [Tooltip] // 0x0000000189B31B00-0x0000000189B31B50
		public FloatParameter RippleSize; // 0x48
		// [Range] // 0x0000000189B3D740-0x0000000189B3D790
		// [Tooltip] // 0x0000000189B3D740-0x0000000189B3D790
		public FloatParameter RippleSnapRange; // 0x50
		// [Range] // 0x0000000189B49D70-0x0000000189B49DD0
		// [Tooltip] // 0x0000000189B49D70-0x0000000189B49DD0
		public FloatParameter RippleStrength; // 0x58
	
		// Constructors
		public WaterRipple() {} // 0x00000001862BBB40-0x00000001862BBCE0
	
		// Methods
		// [XID] // 0x0000000189ACB3B0-0x0000000189ACB3D0
		public override bool IsEnabledAndSupported(PostProcessRenderContext context) => default; // 0x00000001862BB9D0-0x00000001862BBAC0
	}
}
