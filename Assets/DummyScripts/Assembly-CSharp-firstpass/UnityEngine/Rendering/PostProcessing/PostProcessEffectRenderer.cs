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
	public abstract class PostProcessEffectRenderer // TypeDefIndex: 9575
	{
		// Fields
		public bool needToUpdateNextFrame; // 0x10
		protected bool m_ResetHistory; // 0x11
	
		// Constructors
		protected PostProcessEffectRenderer() {} // 0x0000000185C022E0-0x0000000185C02350
	
		// Methods
		// [XID] // 0x0000000189AE1D70-0x0000000189AE1D90
		public virtual void Init() {} // 0x0000000185C02030-0x0000000185C020D0
		// [XID] // 0x00000001898DD110-0x00000001898DD130
		public virtual DepthTextureMode GetCameraFlags() => default; // 0x0000000185C01F90-0x0000000185C02030
		// [XID] // 0x00000001898E4B40-0x00000001898E4B60
		public virtual void ResetHistory() {} // 0x0000000185C02240-0x0000000185C022E0
		// [XID] // 0x0000000189688F80-0x0000000189688FA0
		public virtual void Release(PostProcessRenderContext context) {} // 0x0000000185C02180-0x0000000185C02240
		// [XID] // 0x00000001897455F0-0x0000000189745610
		public virtual void OnEnable(PostProcessRenderContext context) {} // 0x0000000185C020D0-0x0000000185C02180
		public abstract void Render(PostProcessRenderContext context);
		internal abstract void SetSettings(PostProcessEffectSettings settings);
	}
}
