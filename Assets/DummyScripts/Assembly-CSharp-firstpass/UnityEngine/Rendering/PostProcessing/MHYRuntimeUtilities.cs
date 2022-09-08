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
	public static class MHYRuntimeUtilities // TypeDefIndex: 9612
	{
		// Fields
		private static PostProcessResources s_Resources; // 0x00
		private static PropertySheet s_GaussFilterLowSheet; // 0x08
	
		// Properties
		public static PropertySheet gaussFilterLowSheet { /* [XID] */ /* 0x00000001898E3300-0x00000001898E3320 */ get; } // 0x0000000185BF6970-0x0000000185BF6B50 
	
		// Methods
		// [XID] // 0x0000000189A4E410-0x0000000189A4E430
		public static void Init(PostProcessResources resources) {} // 0x0000000185BF6620-0x0000000185BF66D0
		// [XID] // 0x00000001898DB6D0-0x00000001898DB6F0
		public static bool IsInit() => default; // 0x0000000185BF66D0-0x0000000185BF67B0
		// [XID] // 0x00000001898EAF20-0x00000001898EAF40
		public static void gaussianBlurLow(Texture source, RenderTexture destination, float aspectRatio, int level) {} // 0x0000000185BF67B0-0x0000000185BF6970
	}
}
