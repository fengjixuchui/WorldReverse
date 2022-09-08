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
	public sealed class WaveformMonitor : Monitor // TypeDefIndex: 9553
	{
		// Fields
		public float exposure; // 0x20
		public int height; // 0x24
		private ComputeBuffer m_Data; // 0x28
		private int m_ThreadGroupSize; // 0x30
		private int m_ThreadGroupSizeX; // 0x34
		private int m_ThreadGroupSizeY; // 0x38
	
		// Constructors
		public WaveformMonitor() {} // 0x00000001862BE970-0x00000001862BE9E0
	
		// Methods
		// [XID] // 0x0000000189634CA0-0x0000000189634CC0
		internal override void OnEnable() {} // 0x00000001862BDFC0-0x00000001862BE090
		// [XID] // 0x00000001899CC710-0x00000001899CC730
		internal override void OnDisable() {} // 0x00000001862BDF00-0x00000001862BDFC0
		// [XID] // 0x000000018985A7A0-0x000000018985A7C0
		internal override bool NeedsHalfRes() => default; // 0x00000001862BDE60-0x00000001862BDF00
		// [XID] // 0x00000001898D6E70-0x00000001898D6E90
		internal override void Render(PostProcessRenderContext context) {} // 0x00000001862BE090-0x00000001862BE840
	}
}
