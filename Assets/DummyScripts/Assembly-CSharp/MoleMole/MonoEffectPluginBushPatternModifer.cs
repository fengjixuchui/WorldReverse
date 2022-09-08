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
	public sealed class MonoEffectPluginBushPatternModifer : BaseMonoEffectPlugin // TypeDefIndex: 19694
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<BushPatternModifierConfig> _modifierConfigs; // 0x28
		private List<ParticleSystemModifer> _resetModifers; // 0x30
		private ParticleSystemModifer _recordModifier; // 0x38
	
		// Nested types
		[Serializable]
		private struct ParticleSystemModifer // TypeDefIndex: 19695
		{
			// Fields
			public ParticleSystem configParSys; // 0x00
			public bool overrideColor; // 0x08
			public Color startColor; // 0x0C
			public int overrideMaxParticle; // 0x1C
			public Mesh renderMesh; // 0x20
			public UnityEngine.Material renderMaterial; // 0x28
	
			// Methods
			// [XID] // 0x0000000189939BB0-0x0000000189939BD0
			public void Clear() {} // 0x0000000184E56010-0x0000000184E56130
		}
	
		[Serializable]
		private struct BushPatternModifierConfig // TypeDefIndex: 19696
		{
			// Fields
			public int effectConfigID; // 0x00
			public List<ParticleSystemModifer> parSysModifiers; // 0x08
		}
	
		// Constructors
		public MonoEffectPluginBushPatternModifer() {} // 0x0000000184E381E0-0x0000000184E382F0
	
		// Methods
		// [XID] // 0x000000018992ABC0-0x000000018992ABE0
		public override void Init() {} // 0x0000000184E37A90-0x0000000184E381E0
		// [XID] // 0x0000000189932180-0x00000001899321A0
		private void ResetModifiers() {} // 0x0000000184E37680-0x0000000184E37A90
	}
}
