/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class ShaderProperty_OuterGlow : ShaderProperty_Base // TypeDefIndex: 20359
	{
		// Fields
		public static int emissionColorID; // 0x00
		public static int emissionStrengthLerpID; // 0x04
		public Color _ElementRimColor; // 0x18
		public float _EmissionStrengthLerp; // 0x28
		public List<OuterGlowColor> elementTypeColor; // 0x30
	
		// Constructors
		public ShaderProperty_OuterGlow() {} // 0x0000000184EF5FE0-0x0000000184EF6080
		static ShaderProperty_OuterGlow() {} // 0x0000000184EF5F40-0x0000000184EF5FE0
	
		// Methods
		// [XID] // 0x00000001896232E0-0x0000000189623300
		public override void StartLerp(BaseEntity entity, UnityEngine.Material targetMat, UnityEngine.Material sampleMat) {} // 0x0000000184EF5E70-0x0000000184EF5F40
		// [XID] // 0x000000018962AB20-0x000000018962AB40
		public override void LerpTo(UnityEngine.Material targetMat, ShaderProperty_Base to_, float normalized, int param) {} // 0x0000000184EF5970-0x0000000184EF5BA0
		// [XID] // 0x0000000189632260-0x0000000189632280
		public override int ResetValue(UnityEngine.Material targetMat, Color? color, float? param1, float? param2, ElementType? element) => default; // 0x0000000184EF5C60-0x0000000184EF5E70
	}
}
