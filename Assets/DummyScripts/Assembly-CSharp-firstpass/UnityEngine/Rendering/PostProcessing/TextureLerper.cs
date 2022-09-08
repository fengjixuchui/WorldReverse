/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	internal class TextureLerper // TypeDefIndex: 9623
	{
		// Fields
		private static TextureLerper m_Instance; // 0x00
		private CommandBuffer m_Command; // 0x10
		private PropertySheetFactory m_PropertySheets; // 0x18
		private PostProcessResources m_Resources; // 0x20
		private List<RenderTexture> m_Recycled; // 0x28
		private List<RenderTexture> m_Actives; // 0x30
	
		// Properties
		internal static TextureLerper instance { /* [XID] */ /* 0x0000000189752E30-0x0000000189752E50 */ get => default; } // 0x00000001862B2430-0x00000001862B2510 
	
		// Constructors
		private TextureLerper() {} // 0x00000001862B2380-0x00000001862B2430
	
		// Methods
		// [XID] // 0x000000018975A0E0-0x000000018975A100
		internal void BeginFrame(PostProcessRenderContext context) {} // 0x00000001862B1320-0x00000001862B1400
		// [XID] // 0x00000001897A45D0-0x00000001897A45F0
		internal void EndFrame() {} // 0x00000001862B1690-0x00000001862B1990
		// [XID] // 0x0000000189769290-0x00000001897692B0
		private RenderTexture Get(RenderTextureFormat format, int w, int h, int d = 1 /* Metadata: 0x00AE5CBE */, bool enableRandomWrite = false /* Metadata: 0x00AE5CC2 */) => default; // 0x00000001862B1990-0x00000001862B1CA0
		// [XID] // 0x00000001897709B0-0x00000001897709D0
		internal Texture Lerp(Texture from, Texture to, float t) => default; // 0x00000001862B1CA0-0x00000001862B2380
		// [XID] // 0x00000001897781B0-0x00000001897781D0
		internal void Clear() {} // 0x00000001862B1400-0x00000001862B1690
	}
}
