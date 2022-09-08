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
	public abstract class ShaderProperty_Base : MonoBehaviour // TypeDefIndex: 20347
	{
		// Constructors
		protected ShaderProperty_Base() {} // 0x0000000184EF20F0-0x0000000184EF2150
	
		// Methods
		// [XID] // 0x0000000189B8E2C0-0x0000000189B8E2E0
		public virtual void StartLerp(BaseEntity entity, UnityEngine.Material targetMat, UnityEngine.Material sampleMat) {} // 0x0000000184EF2020-0x0000000184EF20F0
		// [XID] // 0x0000000189B741A0-0x0000000189B741C0
		public virtual int ResetValue(UnityEngine.Material targetMat, Color? color, float? param1, float? param2, ElementType? element) => default; // 0x0000000184EF1F10-0x0000000184EF2020
		public abstract void LerpTo(UnityEngine.Material targetMat, ShaderProperty_Base to, float normalized, int param = 0 /* Metadata: 0x00AFD821 */);
		// [XID] // 0x0000000189B7B710-0x0000000189B7B730
		public virtual void LerpTo(MaterialColorModifier.Multiplier multiplier, ShaderProperty_Base to_, float normalized) {} // 0x0000000184EF1E40-0x0000000184EF1F10
	}
}
