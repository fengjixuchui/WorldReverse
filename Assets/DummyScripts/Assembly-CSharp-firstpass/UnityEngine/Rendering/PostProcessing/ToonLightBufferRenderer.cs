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
	public sealed class ToonLightBufferRenderer : PostProcessEffectRenderer<ToonLightBuffer> // TypeDefIndex: 9542
	{
		// Fields
		private static readonly int tempBuffer1; // 0x00
		private static readonly int thresholdDebugBuffer; // 0x04
	
		// Constructors
		public ToonLightBufferRenderer() {} // 0x00000001862B3C60-0x00000001862B3CD0
		static ToonLightBufferRenderer() {} // 0x00000001862B3BC0-0x00000001862B3C60
	
		// Methods
		// [XID] // 0x00000001897BD540-0x00000001897BD560
		public override void Init() {} // 0x00000001862B3150-0x00000001862B31F0
		// [XID] // 0x0000000189AF0A40-0x0000000189AF0A60
		public override void Render(PostProcessRenderContext context) {} // 0x00000001862B32F0-0x00000001862B3AE0
		// [XID] // 0x0000000189AF8010-0x0000000189AF8030
		private void Blur(PostProcessRenderContext context, PropertySheet sheet, RenderTargetIdentifier src, RenderTargetIdentifier dst, RenderTargetIdentifier tmp, int w, int h, int gaussWidth) {} // 0x00000001862B2A90-0x00000001862B3150
		// [XID] // 0x0000000189ABC580-0x0000000189ABC5A0
		public override void Release(PostProcessRenderContext context) {} // 0x00000001862B31F0-0x00000001862B32F0
	}
}
