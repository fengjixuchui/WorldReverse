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
	public sealed class ShaderProperty_Emission : ShaderProperty_Base // TypeDefIndex: 20352
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
		public ShaderProperty_Emission() {} // 0x0000000184EF3D50-0x0000000184EF3DF0
		static ShaderProperty_Emission() {} // 0x0000000184EF3CB0-0x0000000184EF3D50
	
		// Methods
		// [XID] // 0x0000000189BB6750-0x0000000189BB6770
		public override void StartLerp(BaseEntity entity, UnityEngine.Material targetMat, UnityEngine.Material sampleMat) {} // 0x0000000184EF3A80-0x0000000184EF3CB0
		// [XID] // 0x0000000189BBDDE0-0x0000000189BBDE00
		public override void LerpTo(UnityEngine.Material targetMat, ShaderProperty_Base to_, float normalized, int param) {} // 0x0000000184EF3480-0x0000000184EF3750
		// [XID] // 0x0000000189BC5AC0-0x0000000189BC5AE0
		public override int ResetValue(UnityEngine.Material targetMat, Color? color, float? param1, float? param2, ElementType? element) => default; // 0x0000000184EF3810-0x0000000184EF3A80
	}
}
