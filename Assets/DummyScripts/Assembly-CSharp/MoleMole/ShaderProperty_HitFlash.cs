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
	public sealed class ShaderProperty_HitFlash : ShaderProperty_Base // TypeDefIndex: 20355
	{
		// Fields
		public Color _HitColor; // 0x18
		public float HitColorScaler; // 0x28
		public List<HitFlashColor> elementTypeColor; // 0x30
	
		// Constructors
		public ShaderProperty_HitFlash() {} // 0x0000000184EF4B50-0x0000000184EF4C00
	
		// Methods
		// [XID] // 0x0000000189BDC4E0-0x0000000189BDC500
		public override void StartLerp(BaseEntity entity, UnityEngine.Material targetMat, UnityEngine.Material sampleMat) {} // 0x0000000184EF4A80-0x0000000184EF4B50
		// [IDTag] // 0x00000001895E8D90-0x00000001895E8DD0
		// [XID] // 0x00000001895E8D90-0x00000001895E8DD0
		public override void LerpTo(UnityEngine.Material targetMat, ShaderProperty_Base to_, float normalized, int param) {} // 0x0000000184EF4420-0x0000000184EF4720
		// [IDTag] // 0x00000001895F34D0-0x00000001895F3510
		// [XID] // 0x00000001895F34D0-0x00000001895F3510
		public override void LerpTo(MaterialColorModifier.Multiplier multiplier, ShaderProperty_Base to_, float normalized) {} // 0x0000000184EF4720-0x0000000184EF47F0
		// [XID] // 0x00000001895FDB80-0x00000001895FDBA0
		public override int ResetValue(UnityEngine.Material targetMat, Color? color, float? param1, float? param2, ElementType? element) => default; // 0x0000000184EF48B0-0x0000000184EF4A80
	}
}
