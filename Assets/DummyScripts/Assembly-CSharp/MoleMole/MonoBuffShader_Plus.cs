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
	public sealed class MonoBuffShader_Plus : MonoBuffShader_Base // TypeDefIndex: 20344
	{
		// Fields
		[NonSerialized]
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public E_ShaderPlus id; // 0x30
		public ShaderProperty_Base FromProperty; // 0x38
		public ShaderProperty_Base ToProperty; // 0x40
		public float EnableDuration; // 0x48
		public float DisableDuration; // 0x4C
		public AnimationCurve LerpCurve; // 0x50
	
		// Constructors
		public MonoBuffShader_Plus() {} // 0x0000000184801950-0x0000000184801A20
	
		// Methods
		// [XID] // 0x0000000189B474D0-0x0000000189B474F0
		public override void InitOnLoaded() {} // 0x00000001848018B0-0x0000000184801950
		public void Lerp<T>(UnityEngine.Material targetMat, float normalized, bool dir = true /* Metadata: 0x00AFD81A */, int param = 0 /* Metadata: 0x00AFD81B */)
			where T : ShaderProperty_Base {}
		public void StartLerp<T>(BaseEntity entity, UnityEngine.Material targetMat, UnityEngine.Material sampleMat, bool dir = true /* Metadata: 0x00AFD81F */)
			where T : ShaderProperty_Base {}
		public int ResetValue<T>(UnityEngine.Material mat, Color? color, float? param1, float? param2, ElementType? element, bool isFrom = true /* Metadata: 0x00AFD820 */)
			where T : ShaderProperty_Base => default;
	}
}
