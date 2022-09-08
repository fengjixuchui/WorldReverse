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
	public sealed class BloomRenderer : PostProcessEffectRenderer<UnityEngine.Rendering.PostProcessing.Bloom> // TypeDefIndex: 9477
	{
		// Fields
		private Level[] m_Pyramid; // 0x20
		private const int k_MaxPyramidSize = 16; // Metadata: 0x00AE5984
	
		// Nested types
		private enum Pass // TypeDefIndex: 9478
		{
			Prefilter13 = 0,
			Prefilter4 = 1,
			Downsample13 = 2,
			Downsample4 = 3,
			UpsampleTent = 4,
			UpsampleBox = 5,
			DebugOverlayThreshold = 6,
			DebugOverlayTent = 7,
			DebugOverlayBox = 8
		}
	
		private struct Level // TypeDefIndex: 9479
		{
			// Fields
			internal int down; // 0x00
			internal int up; // 0x04
		}
	
		// Constructors
		public BloomRenderer() {} // 0x0000000186057340-0x00000001860573B0
	
		// Methods
		// [XID] // 0x00000001896CB4D0-0x00000001896CB4F0
		public override void Init() {} // 0x0000000186055FC0-0x0000000186056170
		// [XID] // 0x0000000189657120-0x0000000189657140
		public override void Render(PostProcessRenderContext context) {} // 0x0000000186056170-0x00000001860572E0
	}
}
