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
	// [PostProcess] // 0x0000000189AA7A90-0x0000000189AA7B00
	public sealed class ToonLightBuffer : PostProcessEffectSettings // TypeDefIndex: 9541
	{
		// Fields
		// [Range] // 0x0000000189AB5250-0x0000000189AB52A0
		// [Tooltip] // 0x0000000189AB5250-0x0000000189AB52A0
		public FloatParameter threshold; // 0x30
		// [Range] // 0x0000000189AC1650-0x0000000189AC16A0
		// [Tooltip] // 0x0000000189AC1650-0x0000000189AC16A0
		public IntParameter bufferSize; // 0x38
		// [Range] // 0x0000000189ACD880-0x0000000189ACD8E0
		// [Tooltip] // 0x0000000189ACD880-0x0000000189ACD8E0
		public IntParameter gaussWidth; // 0x40
		// [Header] // 0x0000000189AD9AF0-0x0000000189AD9B20
		public ToonLightBufferDebugParameter debug; // 0x48
	
		// Constructors
		public ToonLightBuffer() {} // 0x00000001862B3DE0-0x00000001862B3F60
	
		// Methods
		// [XID] // 0x0000000189AE16A0-0x0000000189AE16C0
		public override CameraEvent CommandBufferEvent() => default; // 0x00000001862B3CD0-0x00000001862B3D70
	}
}
