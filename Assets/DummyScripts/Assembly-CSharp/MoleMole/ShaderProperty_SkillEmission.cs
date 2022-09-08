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
	public sealed class ShaderProperty_SkillEmission : ShaderProperty_Base // TypeDefIndex: 20363
	{
		// Fields
		public static int emissionColorID; // 0x00
		public static int emissionScalerID; // 0x04
		[NonSerialized]
		public Color? emissionColor; // 0x18
		[NonSerialized]
		public float? emissionScaler; // 0x2C
		[NonSerialized]
		public Color originalEmissionColor; // 0x34
		[NonSerialized]
		public float originalEmissionScaler; // 0x44
	
		// Constructors
		public ShaderProperty_SkillEmission() {} // 0x0000000184EF7480-0x0000000184EF7520
		static ShaderProperty_SkillEmission() {} // 0x0000000184EF73E0-0x0000000184EF7480
	
		// Methods
		// [XID] // 0x0000000189657B30-0x0000000189657B50
		public override void StartLerp(BaseEntity entity, UnityEngine.Material targetMat, UnityEngine.Material sampleMat) {} // 0x0000000184EF71B0-0x0000000184EF73E0
		// [XID] // 0x000000018965F240-0x000000018965F260
		public override void LerpTo(UnityEngine.Material targetMat, ShaderProperty_Base to_, float normalized, int param) {} // 0x0000000184EF6BB0-0x0000000184EF6E80
		// [XID] // 0x0000000189666A50-0x0000000189666A70
		public override int ResetValue(UnityEngine.Material targetMat, Color? color, float? param1, float? param2, ElementType? element) => default; // 0x0000000184EF6F40-0x0000000184EF71B0
	}
}
