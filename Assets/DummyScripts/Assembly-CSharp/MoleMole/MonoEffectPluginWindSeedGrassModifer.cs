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
	public sealed class MonoEffectPluginWindSeedGrassModifer : BaseMonoEffectPlugin // TypeDefIndex: 19750
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<ParticleSystemModifer> particleSystems; // 0x28
	
		// Nested types
		[Serializable]
		private class ParticleSystemModifer // TypeDefIndex: 19751
		{
			// Fields
			public ParticleSystem configParSys; // 0x10
			public float lerpRatio; // 0x18
			[NonSerialized]
			public Color resetColor; // 0x1C
	
			// Constructors
			public ParticleSystemModifer() {} // 0x0000000183CB2CF0-0x0000000183CB2D70
		}
	
		// Constructors
		public MonoEffectPluginWindSeedGrassModifer() {} // 0x0000000183C9CFE0-0x0000000183C9D060
	
		// Methods
		// [XID] // 0x00000001897741A0-0x00000001897741C0
		public override void Init() {} // 0x0000000183C9CA90-0x0000000183C9CF80
		// [XID] // 0x000000018977B9A0-0x000000018977B9C0
		public override void Clear() {} // 0x0000000183C9C800-0x0000000183C9CA90
	}
}
