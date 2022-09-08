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
	public sealed class MonoEffectPluginDisableOnPropertyBlock : BaseMonoEffectPlugin // TypeDefIndex: 19705
	{
		// Fields
		// [Header] // 0x0000000189A76CE0-0x0000000189A76D10
		public string RendererGOName; // 0x28
		// [Header] // 0x0000000189A7FBD0-0x0000000189A7FC00
		public string PropertyName; // 0x30
		// [Header] // 0x0000000189A891F0-0x0000000189A89220
		public float Threshold; // 0x38
		// [Header] // 0x0000000189A921C0-0x0000000189A921F0
		public bool Reverse; // 0x3C
		private bool _disabled; // 0x3D
		private ParticleSystemRenderer[] _allRenderers; // 0x40
		private Renderer _targetRenderer; // 0x48
		private int _targetPropertyHash; // 0x50
		private MaterialPropertyBlock _block; // 0x58
	
		// Constructors
		public MonoEffectPluginDisableOnPropertyBlock() {} // 0x0000000184E3B8E0-0x0000000184E3B980
	
		// Methods
		// [XID] // 0x0000000189A9B200-0x0000000189A9B220
		public override void Awaked() {} // 0x0000000184E3B1E0-0x0000000184E3B2C0
		// [XID] // 0x0000000189AA2490-0x0000000189AA24B0
		public override void Init() {} // 0x0000000184E3B490-0x0000000184E3B5A0
		// [XID] // 0x0000000189AA9A20-0x0000000189AA9A40
		private void SetupRenderer(BaseEntity owner) {} // 0x0000000184E3AF60-0x0000000184E3B1E0
		// [XID] // 0x0000000189AB18E0-0x0000000189AB1900
		public override void LateTick(float inDeltaTime) {} // 0x0000000184E3B5A0-0x0000000184E3B810
		// [XID] // 0x0000000189AB8BC0-0x0000000189AB8BE0
		private bool RendererActive() => default; // 0x0000000184E3B2C0-0x0000000184E3B3B0
		// [XID] // 0x0000000189AC0710-0x0000000189AC0730
		private bool CheckThreshold(float value) => default; // 0x0000000184E3B810-0x0000000184E3B8E0
	}
}
