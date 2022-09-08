/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class MonoBuffShader_Lerp : MonoBuffShader_Base // TypeDefIndex: 20343
	{
		// Fields
		[NonSerialized]
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public E_ShaderData id; // 0x30
		public ShaderProperty_Base FromProperty; // 0x38
		public ShaderProperty_Base ToProperty; // 0x40
		public float EnableDuration; // 0x48
		public float DisableDuration; // 0x4C
		public string Keyword; // 0x50
		public AnimationCurve LerpCurve; // 0x58
		public UnityEngine.Material NewShaderSampleMat; // 0x60
		public string NewShaderName; // 0x68
		public Texture NewTexture; // 0x70
		public string TexturePropertyName; // 0x78
	
		// Constructors
		public MonoBuffShader_Lerp() {} // 0x0000000184801720-0x0000000184801850
	
		// Methods
		// [XID] // 0x0000000189B38290-0x0000000189B382B0
		public override void InitOnLoaded() {} // 0x0000000184801680-0x0000000184801720
		public void Lerp<T>(UnityEngine.Material targetMat, float normalized, bool dir)
			where T : ShaderProperty_Base {}
		public void Lerp<T>(MaterialColorModifier.Multiplier multiplier, float normalized, bool dir)
			where T : ShaderProperty_Base {}
	}
}
