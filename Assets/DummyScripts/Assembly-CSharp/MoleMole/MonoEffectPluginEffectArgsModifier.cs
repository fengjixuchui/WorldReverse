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
	public sealed class MonoEffectPluginEffectArgsModifier : BaseMonoEffectPlugin // TypeDefIndex: 19706
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<PatternModifierConfig> _modifierConfigs; // 0x28
		private List<ParticleSystemModifer> _resetModifers; // 0x30
		private bool _hasSavedResetArgs; // 0x38
	
		// Nested types
		[Serializable]
		private struct ParticleSystemModifer // TypeDefIndex: 19707
		{
			// Fields
			public Transform configParSys; // 0x00
			public bool overrideColor; // 0x08
			public Color startColor; // 0x0C
			public int overrideMaxParticle; // 0x1C
			public bool overrideTrailColor; // 0x20
			public Gradient trailColorGradient; // 0x28
			public Mesh renderMesh; // 0x30
			public UnityEngine.Material renderMaterial; // 0x38
	
			// Methods
			// [XID] // 0x0000000189AF5990-0x0000000189AF59B0
			public void Clear() {} // 0x0000000184E55F30-0x0000000184E56010
		}
	
		[Serializable]
		private struct PatternModifierConfig // TypeDefIndex: 19708
		{
			// Fields
			public int templateID; // 0x00
			public List<ParticleSystemModifer> parSysModifiers; // 0x08
		}
	
		// Constructors
		public MonoEffectPluginEffectArgsModifier() {} // 0x0000000184E3D1C0-0x0000000184E3D290
	
		// Methods
		// [XID] // 0x0000000189ACF910-0x0000000189ACF930
		public override void Awaked() {} // 0x0000000184E3B980-0x0000000184E3BA30
		// [XID] // 0x0000000189AD7640-0x0000000189AD7660
		public override void OnDeallocate() {} // 0x0000000184E3C820-0x0000000184E3C8D0
		// [XID] // 0x0000000189ADF0B0-0x0000000189ADF0D0
		public void ModifyEffectArgs(int templateID) {} // 0x0000000184E3C010-0x0000000184E3C7C0
		// [XID] // 0x0000000189AE69A0-0x0000000189AE69C0
		private void SaveResetArgs() {} // 0x0000000184E3C8D0-0x0000000184E3D1C0
		// [XID] // 0x0000000189AEE380-0x0000000189AEE3A0
		private void ResetArgs() {} // 0x0000000184E3BA30-0x0000000184E3BFB0
	}
}
