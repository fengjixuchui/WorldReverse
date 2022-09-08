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
	public sealed class LogHistogram // TypeDefIndex: 9608
	{
		// Fields
		public const int rangeMin = -9; // Metadata: 0x00AE5C71
		public const int rangeMax = 9; // Metadata: 0x00AE5C75
		private const int k_Bins = 128; // Metadata: 0x00AE5C79
		private int m_ThreadX; // 0x10
		private int m_ThreadY; // 0x14
	
		// Properties
		public ComputeBuffer data { /* [XID] */ /* 0x00000001898923A0-0x00000001898923E0 */ get; /* [XID] */ /* 0x000000018989CB00-0x000000018989CB40 */ private set; } // 0x0000000186060F20-0x0000000186060F80 0x0000000186060F80-0x0000000186060FE0
	
		// Constructors
		public LogHistogram() {} // 0x0000000186060EC0-0x0000000186060F20
	
		// Methods
		// [XID] // 0x00000001896BDE40-0x00000001896BDE60
		public void Generate(PostProcessRenderContext context) {} // 0x00000001860605D0-0x0000000186060B60
		// [XID] // 0x00000001898AEB90-0x00000001898AEBB0
		public Vector4 GetHistogramScaleOffsetRes(PostProcessRenderContext context) => default; // 0x0000000186060B60-0x0000000186060D40
		// [XID] // 0x00000001899F0BD0-0x00000001899F0BF0
		public void Release() {} // 0x0000000186060D40-0x0000000186060EC0
	}
}
