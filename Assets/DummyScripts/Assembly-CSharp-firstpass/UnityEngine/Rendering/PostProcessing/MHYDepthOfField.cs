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
	// [PostProcess] // 0x0000000189A8B880-0x0000000189A8B8F0
	public sealed class MHYDepthOfField : PostProcessEffectSettings // TypeDefIndex: 9502
	{
		// Fields
		private const float sensorWidth = 50f; // Metadata: 0x00AE5A24
		private const float focalLength = 50f; // Metadata: 0x00AE5A28
		private const float minFocusdistance = 0.5f; // Metadata: 0x00AE5A2C
		// [Tooltip] // 0x0000000189A992A0-0x0000000189A992D0
		public MHYDepthOfFieldQualityParameter quality; // 0x30
		// [Range] // 0x0000000189AA1920-0x0000000189AA1970
		// [Tooltip] // 0x0000000189AA1920-0x0000000189AA1970
		public FloatParameter focusDistance; // 0x38
		// [Range] // 0x0000000189AADA20-0x0000000189AADA70
		// [Tooltip] // 0x0000000189AADA20-0x0000000189AADA70
		public FloatParameter fStop; // 0x40
		// [Range] // 0x0000000189AB9A20-0x0000000189AB9A70
		// [Tooltip] // 0x0000000189AB9A20-0x0000000189AB9A70
		public FloatParameter maxForegroundRadius; // 0x48
		// [Range] // 0x0000000189AC61C0-0x0000000189AC6210
		// [Tooltip] // 0x0000000189AC61C0-0x0000000189AC6210
		public FloatParameter maxBackgroundRadius; // 0x50
		public BoolParameter debugTestSomething; // 0x58
		public BoolParameter useMotionBlurParameters; // 0x60
		// [Range] // 0x0000000189AD2080-0x0000000189AD20D0
		// [Tooltip] // 0x0000000189AD2080-0x0000000189AD20D0
		public FloatParameter mbFocusRange; // 0x68
		// [Range] // 0x0000000189ADE630-0x0000000189ADE680
		// [Tooltip] // 0x0000000189ADE630-0x0000000189ADE680
		public FloatParameter mbDofBlurAmount; // 0x70
		// [Range] // 0x0000000189AEA630-0x0000000189AEA680
		// [Tooltip] // 0x0000000189AEA630-0x0000000189AEA680
		public FloatParameter mbNearFocalDistance; // 0x78
		// [Range] // 0x0000000189AF66E0-0x0000000189AF6730
		// [Tooltip] // 0x0000000189AF66E0-0x0000000189AF6730
		public FloatParameter mbNearFocalTransitionDistance; // 0x80
	
		// Nested types
		public enum HoleFillMethod // TypeDefIndex: 9503
		{
			None = 0,
			Mirror = 1,
			OutwardBlurCoc = 2
		}
	
		// Constructors
		public MHYDepthOfField() {} // 0x0000000185BF6270-0x0000000185BF6550
	
		// Methods
		// [XID] // 0x0000000189681480-0x00000001896814A0
		public static float GetClampedFocusDistance(float focusDistance) => default; // 0x0000000185BF5EA0-0x0000000185BF5F80
		// [XID] // 0x00000001898BC210-0x00000001898BC230
		public static float GetInfinityCocRadius(float halfWidth, float clampedFocusDistance, float fStop) => default; // 0x0000000185BF6160-0x0000000185BF6270
		// [XID] // 0x0000000189A0CC80-0x0000000189A0CCA0
		public static float GetCoCFromDepth(float depth, float clampedFocusDistance, float infinityCocRadius) => default; // 0x0000000185BF5F80-0x0000000185BF6080
		// [XID] // 0x000000018997CF70-0x000000018997CF90
		public static float GetDepthFromCoc(float coc, float clampedFocusDistance, float infinityCocRadius) => default; // 0x0000000185BF6080-0x0000000185BF6160
		// [XID] // 0x0000000189B1FFF0-0x0000000189B20010
		public static void ConvertToMotionBlurParameters(float halfWidth, float focusDistance, float fStop, out float mbFocusDistance, out float mbFocusRange, out float mbNearFocalDistance, out float mbNearFocalTransitionDistance, out float mbDOFBlurAmount) {
			mbFocusDistance = default;
			mbFocusRange = default;
			mbNearFocalDistance = default;
			mbNearFocalTransitionDistance = default;
			mbDOFBlurAmount = default;
		} // 0x0000000185BF5CA0-0x0000000185BF5EA0
	}
}
