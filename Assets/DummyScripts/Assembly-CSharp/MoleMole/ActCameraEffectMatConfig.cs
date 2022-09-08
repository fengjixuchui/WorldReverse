/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class ActCameraEffectMatConfig : ScriptableObject // TypeDefIndex: 19666
	{
		// Fields
		public UnityEngine.Material postEffectMaterial; // 0x18
		public ActCameraEffectMatConfigKeyFloat[] modifyValue; // 0x20
		public ActCameraEffectMatConfigKeyColor[] modifyColor; // 0x28
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public float fadeinTime; // 0x30
		public ActCameraEffectMatConfigKeyCurve[] fadeInCurve; // 0x38
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public float fadeoutTime; // 0x40
		public ActCameraEffectMatConfigKeyCurve[] fadeOutCurve; // 0x48
	
		// Constructors
		public ActCameraEffectMatConfig() {} // 0x0000000181A3F150-0x0000000181A3F1C0
	}
}
