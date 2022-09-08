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
	public class MonoPrefabEffect : MonoBehaviour // TypeDefIndex: 19843
	{
		// Fields
		private ParticleSystem[] _allParticleSystems; // 0x18
		private ParticleSystemRenderer[] _allParticleSystemRenderers; // 0x20
		private Animation[] _allAnimations; // 0x28
		private Animator[] _allAnimators; // 0x30
		private MeshRenderer[] _allMeshRenderers; // 0x38
		private MaterialPropertyBlock _mpb; // 0x40
		private static int TimescaleID; // 0x00
		private float _lastTimeScale; // 0x48
	
		// Properties
		private float TimeScale { /* [XID] */ /* 0x00000001896CF440-0x00000001896CF460 */ get => default; } // 0x0000000183721860-0x00000001837219A0 
	
		// Constructors
		public MonoPrefabEffect() {} // 0x0000000183722420-0x0000000183722490
		static MonoPrefabEffect() {} // 0x00000001837223B0-0x0000000183722420
	
		// Methods
		// [XID] // 0x00000001896C7A70-0x00000001896C7A90
		private void Awake() {} // 0x0000000183721660-0x0000000183721860
		// [XID] // 0x00000001896D6660-0x00000001896D6680
		public void Update() {} // 0x00000001837222A0-0x00000001837223B0
		// [XID] // 0x00000001896DDCA0-0x00000001896DDCC0
		private void SetMaterialTimeScale(float timeScale) {} // 0x00000001837219A0-0x0000000183721E70
		// [XID] // 0x00000001896E52F0-0x00000001896E5310
		private void SetParticleAndAnimationPlaySpeed(float speed) {} // 0x0000000183721E70-0x00000001837222A0
	}
}
