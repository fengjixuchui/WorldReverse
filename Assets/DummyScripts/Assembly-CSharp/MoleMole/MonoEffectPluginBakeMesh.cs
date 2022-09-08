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
	public sealed class MonoEffectPluginBakeMesh : BaseMonoEffectPlugin // TypeDefIndex: 19688
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<NameFloat> _floatArgs; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<NameColor> _colorArgs; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<NameInt> _intArgs; // 0x38
	
		// Properties
		public List<NameFloat> floatArgs { /* [XID] */ /* 0x0000000189891720-0x0000000189891740 */ get => default; } // 0x00000001846A2370-0x00000001846A2410 
		public List<NameColor> colorArgs { /* [XID] */ /* 0x0000000189899090-0x00000001898990B0 */ get => default; } // 0x00000001846A22D0-0x00000001846A2370 
		public List<NameInt> intArgs { /* [XID] */ /* 0x00000001898A0250-0x00000001898A0270 */ get => default; } // 0x00000001846A2410-0x00000001846A24B0 
	
		// Nested types
		[Serializable]
		public class NameColor // TypeDefIndex: 19689
		{
			// Fields
			public string name; // 0x10
			public Color value; // 0x18
	
			// Constructors
			public NameColor() {} // 0x0000000184E55D40-0x0000000184E55DA0
		}
	
		[Serializable]
		public class NameFloat // TypeDefIndex: 19690
		{
			// Fields
			public string name; // 0x10
			public float value; // 0x18
	
			// Constructors
			public NameFloat() {} // 0x0000000184E55DA0-0x0000000184E55E00
		}
	
		[Serializable]
		public class NameInt // TypeDefIndex: 19691
		{
			// Fields
			public string name; // 0x10
			public int value; // 0x18
	
			// Constructors
			public NameInt() {} // 0x0000000184E55E00-0x0000000184E55F30
		}
	
		// Constructors
		public MonoEffectPluginBakeMesh() {} // 0x00000001846A2240-0x00000001846A22D0
	
		// Methods
		// [XID] // 0x000000018986CA50-0x000000018986CA70
		public override void Awaked() {} // 0x00000001846A1D90-0x00000001846A1E30
		// [XID] // 0x0000000189873EE0-0x0000000189873F00
		public override void Init() {} // 0x00000001846A20A0-0x00000001846A2140
		// [XID] // 0x000000018987B9A0-0x000000018987B9C0
		public override bool IsToBeDeallocated() => default; // 0x00000001846A2140-0x00000001846A21E0
		// [XID] // 0x0000000189882B30-0x0000000189882B50
		public override void Clear() {} // 0x00000001846A1E90-0x00000001846A1F30
		// [XID] // 0x000000018988A270-0x000000018988A290
		public override void Disabled() {} // 0x00000001846A1F30-0x00000001846A1FD0
	}
}
