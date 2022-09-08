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
	// [PostProcess] // 0x00000001896332B0-0x0000000189633320
	public sealed class MotionBlur : PostProcessEffectSettings // TypeDefIndex: 9511
	{
		// Fields
		// [Range] // 0x00000001896409A0-0x0000000189640A00
		// [Tooltip] // 0x00000001896409A0-0x0000000189640A00
		public FloatParameter shutterSpeed; // 0x30
		// [Tooltip] // 0x000000018964CDA0-0x000000018964CDD0
		public BoolParameter motionBlurEnabled; // 0x38
		// [Tooltip] // 0x0000000189655B20-0x0000000189655B50
		public MBQualityParameter quality; // 0x40
		// [Tooltip] // 0x000000018965E8F0-0x000000018965E920
		public BoolParameter separateObjFromCamera; // 0x48
		// [Tooltip] // 0x0000000189667A40-0x0000000189667A70
		public BoolParameter dofEnabled; // 0x50
		public DofQualityParameter dofQuality; // 0x58
		// [Range] // 0x0000000189670DD0-0x0000000189670E30
		// [Tooltip] // 0x0000000189670DD0-0x0000000189670E30
		public FloatParameter focusDistance; // 0x60
		// [Range] // 0x0000000189AD2080-0x0000000189AD20D0
		// [Tooltip] // 0x0000000189AD2080-0x0000000189AD20D0
		public FloatParameter focusRange; // 0x68
		// [Range] // 0x0000000189687440-0x00000001896874A0
		// [Tooltip] // 0x0000000189687440-0x00000001896874A0
		public FloatParameter dofBlurAmount; // 0x70
		// [Range] // 0x0000000189AEA630-0x0000000189AEA680
		// [Tooltip] // 0x0000000189AEA630-0x0000000189AEA680
		public FloatParameter nearFocalDistance; // 0x78
		// [Range] // 0x0000000189AF66E0-0x0000000189AF6730
		// [Tooltip] // 0x0000000189AF66E0-0x0000000189AF6730
		public FloatParameter nearFocalTransitionDistance; // 0x80
		// [Tooltip] // 0x00000001896A6A80-0x00000001896A6AB0
		public BoolParameter radialBlurEnabled; // 0x88
		// [Tooltip] // 0x00000001896AF6C0-0x00000001896AF6F0
		public Vector2Parameter radialCenter; // 0x90
		// [Range] // 0x00000001896B86F0-0x00000001896B8750
		// [Tooltip] // 0x00000001896B86F0-0x00000001896B8750
		public FloatParameter radialRadius; // 0x98
		// [Range] // 0x00000001896C4080-0x00000001896C40E0
		// [Tooltip] // 0x00000001896C4080-0x00000001896C40E0
		public FloatParameter radialAmount; // 0xA0
		// [Range] // 0x00000001896CFFD0-0x00000001896D0030
		// [Tooltip] // 0x00000001896CFFD0-0x00000001896D0030
		public FloatParameter blurFallOffRange; // 0xA8
	
		// Nested types
		public enum MotionBlurQuality // TypeDefIndex: 9512
		{
			Low = 0,
			High = 1,
			VeryHigh = 2
		}
	
		public enum DofQuality // TypeDefIndex: 9513
		{
			LowCircle = 0,
			MediumCircleQuater = 1,
			HighCircleQuater = 2,
			HighestCircleHalf = 3
		}
	
		// Constructors
		public MotionBlur() {} // 0x0000000185BFD6D0-0x0000000185BFDA90
	
		// Methods
		// [XID] // 0x00000001896DBBE0-0x00000001896DBC00
		public override bool IsEnabledAndSupported(PostProcessRenderContext context) => default; // 0x0000000185BFD540-0x0000000185BFD650
	}
}
