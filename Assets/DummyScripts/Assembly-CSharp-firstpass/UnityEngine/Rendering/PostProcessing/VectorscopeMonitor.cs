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
	public sealed class VectorscopeMonitor : Monitor // TypeDefIndex: 9552
	{
		// Fields
		public int size; // 0x20
		public float exposure; // 0x24
		private ComputeBuffer m_Data; // 0x28
		private int m_ThreadGroupSizeX; // 0x30
		private int m_ThreadGroupSizeY; // 0x34
	
		// Constructors
		public VectorscopeMonitor() {} // 0x00000001862BB960-0x00000001862BB9D0
	
		// Methods
		// [XID] // 0x00000001896169F0-0x0000000189616A10
		internal override void OnEnable() {} // 0x00000001862BB110-0x00000001862BB1D0
		// [XID] // 0x00000001897E0560-0x00000001897E0580
		internal override void OnDisable() {} // 0x00000001862BB050-0x00000001862BB110
		// [XID] // 0x00000001899D3DB0-0x00000001899D3DD0
		internal override bool NeedsHalfRes() => default; // 0x00000001862BAFB0-0x00000001862BB050
		// [XID] // 0x000000018962D140-0x000000018962D160
		internal override void Render(PostProcessRenderContext context) {} // 0x00000001862BB1D0-0x00000001862BB830
	}
}
