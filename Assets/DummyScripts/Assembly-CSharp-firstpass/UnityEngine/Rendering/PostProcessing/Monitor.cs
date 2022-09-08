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
	public abstract class Monitor // TypeDefIndex: 9551
	{
		// Fields
		internal bool requested; // 0x18
	
		// Properties
		public RenderTexture output { /* [XID] */ /* 0x0000000189BD6EF0-0x0000000189BD6F30 */ get; /* [XID] */ /* 0x00000001895E6A90-0x00000001895E6AD0 */ protected set; } // 0x0000000185BF8960-0x0000000185BF89C0 0x0000000185BF89C0-0x0000000185BF8A20
	
		// Constructors
		protected Monitor() {} // 0x0000000185BF88F0-0x0000000185BF8960
	
		// Methods
		// [XID] // 0x00000001899A6090-0x00000001899A60B0
		public bool IsRequestedAndSupported() => default; // 0x0000000185BF8610-0x0000000185BF86D0
		// [XID] // 0x0000000189AC8070-0x0000000189AC8090
		internal virtual bool NeedsHalfRes() => default; // 0x0000000185BF86D0-0x0000000185BF8770
		// [XID] // 0x0000000189AF7480-0x0000000189AF74A0
		protected void CheckOutput(int width, int height) {} // 0x0000000185BF8330-0x0000000185BF8610
		// [XID] // 0x0000000189ACF730-0x0000000189ACF750
		internal virtual void OnEnable() {} // 0x0000000185BF8850-0x0000000185BF88F0
		// [XID] // 0x000000018960F450-0x000000018960F470
		internal virtual void OnDisable() {} // 0x0000000185BF8770-0x0000000185BF8850
		internal abstract void Render(PostProcessRenderContext context);
	}
}
