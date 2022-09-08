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
	public sealed class AutoExposureRenderer : PostProcessEffectRenderer<AutoExposure> // TypeDefIndex: 9475
	{
		// Fields
		private readonly RenderTexture[] m_AutoExposurePool; // 0x20
		private int m_AutoExposurePingPong; // 0x28
		private Texture m_CurrentAutoExposure; // 0x30
		private Texture m_PreviousAutoExposure; // 0x38
	
		// Constructors
		public AutoExposureRenderer() {} // 0x0000000186055A40-0x0000000186055AD0
	
		// Methods
		// [XID] // 0x0000000189971E70-0x0000000189971E90
		public override void Render(PostProcessRenderContext context) {} // 0x0000000186054DA0-0x0000000186055940
		// [XID] // 0x0000000189693A70-0x0000000189693A90
		public override void OnEnable(PostProcessRenderContext context) {} // 0x0000000186054B10-0x0000000186054C00
		// [XID] // 0x0000000189648080-0x00000001896480A0
		public override void Release(PostProcessRenderContext context) {} // 0x0000000186054C00-0x0000000186054DA0
	}
}
