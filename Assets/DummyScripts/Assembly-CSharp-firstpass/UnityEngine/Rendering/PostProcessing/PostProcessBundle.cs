/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine.Rendering;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	public sealed class PostProcessBundle // TypeDefIndex: 9568
	{
		// Fields
		public bool lastActive; // 0x33
		private CachedContextParams m_cachedContextParams; // 0x38
		private PostProcessEffectRenderer m_Renderer; // 0x40
	
		// Properties
		public PostProcessAttribute attribute { /* [XID] */ /* 0x0000000189728D80-0x0000000189728DC0 */ get; private set; } // 0x0000000185BFE820-0x0000000185BFE880 0x0000000185BFECD0-0x0000000185BFED30
		public PostProcessEffectSettings settings { /* [XID] */ /* 0x000000018973AD70-0x000000018973ADB0 */ get; private set; } // 0x0000000185BFEB50-0x0000000185BFEBB0 0x0000000185BFEDF0-0x0000000185BFEE50
		public CameraEvent commandBufferEvent { /* [XID] */ /* 0x000000018974D270-0x000000018974D2B0 */ get; private set; } // 0x0000000185BFE880-0x0000000185BFE8E0 0x0000000185BFED30-0x0000000185BFED90
		public CommandBuffer commandBuffer { /* [XID] */ /* 0x000000018975EE30-0x000000018975EE70 */ get; private set; } // 0x0000000185BFE8E0-0x0000000185BFE940 0x0000000185BFED90-0x0000000185BFEDF0
		public bool NeedToUpdate { get; /* [XID] */ /* 0x00000001897781D0-0x0000000189778210 */ set; } // 0x0000000185BFE7C0-0x0000000185BFE820 0x0000000185BFEC70-0x0000000185BFECD0
		public bool NeedOnEnable { get; set; } // 0x0000000185BFE760-0x0000000185BFE7C0 0x0000000185BFEC10-0x0000000185BFEC70
		public bool IsReleased { /* [XID] */ /* 0x00000001897916C0-0x0000000189791700 */ get; /* [XID] */ /* 0x000000018979C740-0x000000018979C780 */ set; } // 0x0000000185BFE700-0x0000000185BFE760 0x0000000185BFEBB0-0x0000000185BFEC10
		internal PostProcessEffectRenderer renderer { /* [XID] */ /* 0x00000001897A6C00-0x00000001897A6C20 */ get => default; } // 0x0000000185BFE940-0x0000000185BFEB50 
	
		// Nested types
		private class CachedContextParams // TypeDefIndex: 9569
		{
			// Fields
			public RenderTextureWrapper source; // 0x10
			public RenderTextureWrapper destination; // 0x80
	
			// Constructors
			public CachedContextParams() {} // 0x0000000185BF0A00-0x0000000185BF0B20
		}
	
		// Constructors
		public PostProcessBundle() {} // Dummy constructor
		internal PostProcessBundle(PostProcessEffectSettings settings) {} // 0x0000000185BFE400-0x0000000185BFE700
	
		// Methods
		// [XID] // 0x0000000189869190-0x00000001898691B0
		internal void Release(PostProcessRenderContext context) {} // 0x0000000185BFE240-0x0000000185BFE350
		// [XID] // 0x00000001897B64A0-0x00000001897B64C0
		internal void ResetHistory() {} // 0x0000000185BFE350-0x0000000185BFE400
		internal T CastSettings<T>()
			where T : PostProcessEffectSettings => default;
		internal T CastRenderer<T>()
			where T : PostProcessEffectRenderer => default;
		// [XID] // 0x00000001897BE220-0x00000001897BE240
		public void CacheContextParams(PostProcessRenderContext context) {} // 0x0000000185BFDCF0-0x0000000185BFDE90
		// [XID] // 0x00000001898FB800-0x00000001898FB820
		public bool IsContextParamsChange(PostProcessRenderContext context) => default; // 0x0000000185BFDE90-0x0000000185BFE240
	}
}
