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
	public sealed class HistogramMonitor : Monitor // TypeDefIndex: 9547
	{
		// Fields
		public int width; // 0x20
		public int height; // 0x24
		public Channel channel; // 0x28
		private ComputeBuffer m_Data; // 0x30
		private int m_NumBins; // 0x38
		private int m_ThreadGroupSizeX; // 0x3C
		private int m_ThreadGroupSizeY; // 0x40
	
		// Nested types
		public enum Channel // TypeDefIndex: 9548
		{
			Red = 0,
			Green = 1,
			Blue = 2,
			Master = 3
		}
	
		// Constructors
		public HistogramMonitor() {} // 0x000000018605FA00-0x000000018605FA80
	
		// Methods
		// [XID] // 0x0000000189BA74F0-0x0000000189BA7510
		internal override void OnEnable() {} // 0x000000018605F200-0x000000018605F2D0
		// [XID] // 0x0000000189BAE5E0-0x0000000189BAE600
		internal override void OnDisable() {} // 0x000000018605F140-0x000000018605F200
		// [XID] // 0x0000000189BB5E50-0x0000000189BB5E70
		internal override bool NeedsHalfRes() => default; // 0x000000018605F0A0-0x000000018605F140
		// [XID] // 0x0000000189BBD490-0x0000000189BBD4B0
		internal override void Render(PostProcessRenderContext context) {} // 0x000000018605F2D0-0x000000018605F8D0
	}
}
