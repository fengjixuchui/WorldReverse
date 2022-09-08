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
	public sealed class ScreenSpaceReflectionsRenderer : PostProcessEffectRenderer<ScreenSpaceReflections> // TypeDefIndex: 9524
	{
		// Fields
		private RenderTexture m_Resolve; // 0x20
		private RenderTexture m_History; // 0x28
		private int[] m_MipIDs; // 0x30
		private readonly QualityPreset[] m_Presets; // 0x38
	
		// Nested types
		private class QualityPreset // TypeDefIndex: 9525
		{
			// Fields
			public int maximumIterationCount; // 0x10
			public float thickness; // 0x14
			public ScreenSpaceReflectionResolution downsampling; // 0x18
	
			// Constructors
			public QualityPreset() {} // 0x0000000185E0C7E0-0x0000000185E0C840
		}
	
		private enum Pass // TypeDefIndex: 9526
		{
			Test = 0,
			Resolve = 1,
			Reproject = 2,
			Composite = 3
		}
	
		// Constructors
		public ScreenSpaceReflectionsRenderer() {} // 0x0000000185E1AF30-0x0000000185E1B4C0
	
		// Methods
		// [XID] // 0x0000000189805E50-0x0000000189805E70
		public override DepthTextureMode GetCameraFlags() => default; // 0x0000000185E18B30-0x0000000185E18BD0
		// [XID] // 0x000000018980D5A0-0x000000018980D5C0
		internal void CheckRT(ref RenderTexture rt, int width, int height, RenderTextureFormat format, FilterMode filterMode, bool useMipMap) {} // 0x0000000185E188C0-0x0000000185E18B30
		// [XID] // 0x0000000189814C90-0x0000000189814CB0
		public override void Render(PostProcessRenderContext context) {} // 0x0000000185E18CA0-0x0000000185E1AE40
		// [XID] // 0x000000018981C7D0-0x000000018981C7F0
		public override void Release(PostProcessRenderContext context) {} // 0x0000000185E18BD0-0x0000000185E18CA0
	}
}
