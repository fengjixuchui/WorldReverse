/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	// [PostProcess] // 0x000000018986AB90-0x000000018986AC00
	public sealed class FrameTransition : PostProcessEffectSettings // TypeDefIndex: 9485
	{
		// Fields
		// [Range] // 0x0000000189877DE0-0x0000000189877E30
		// [Tooltip] // 0x0000000189877DE0-0x0000000189877E30
		public FloatParameter transition; // 0x30
	
		// Constructors
		public FrameTransition() {} // 0x000000018605D940-0x000000018605DA20
	
		// Methods
		// [XID] // 0x0000000189883810-0x0000000189883830
		public override CameraEvent CommandBufferEvent() => default; // 0x000000018605D830-0x000000018605D8D0
	}
}
