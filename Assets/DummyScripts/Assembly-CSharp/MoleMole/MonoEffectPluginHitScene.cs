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
	public sealed class MonoEffectPluginHitScene : BaseMonoEffectPlugin // TypeDefIndex: 19721
	{
		// Fields
		public const int PARTICAL_LIMITED = 30; // Metadata: 0x00AFCCD9
		// [Header] // 0x00000001897B3BA0-0x00000001897B3BD0
		public float checkMaxDistance; // 0x28
		private float _stopRange; // 0x2C
		// [Header] // 0x00000001897BD3B0-0x00000001897BD3E0
		public ParticleSystem[] avilableParticaleSystems; // 0x30
		// [Header] // 0x00000001897C6310-0x00000001897C6340
		public Transform[] transForScaleZ; // 0x38
		private float[] transForScaleZStartValue; // 0x40
		private bool _isInUse; // 0x48
		private bool _isHitScene; // 0x49
		// [Header] // 0x00000001897CF020-0x00000001897CF050
		public string hitEffectPartternName; // 0x50
		// [Header] // 0x00000001897D8720-0x00000001897D8750
		public float hitEffBackDis; // 0x58
		private int effectIndex; // 0x5C
		private MonoEffectProxy _hitProxy; // 0x60
	
		// Constructors
		public MonoEffectPluginHitScene() {} // 0x0000000184E46DE0-0x0000000184E46E90
	
		// Methods
		// [XID] // 0x00000001897E1160-0x00000001897E1180
		public override void Awaked() {} // 0x0000000184E45C90-0x0000000184E45E40
		// [XID] // 0x00000001897E89D0-0x00000001897E89F0
		public override void Init() {} // 0x0000000184E462A0-0x0000000184E464B0
		// [XID] // 0x00000001897F05C0-0x00000001897F05E0
		public override void Clear() {} // 0x0000000184E45EA0-0x0000000184E46020
		// [XID] // 0x00000001897F7CF0-0x00000001897F7D10
		public override void Tick(float inDeltaTime) {} // 0x0000000184E46AD0-0x0000000184E46DE0
		// [XID] // 0x00000001897FF370-0x00000001897FF390
		public override void Disabled() {} // 0x0000000184E46020-0x0000000184E461C0
		// [XID] // 0x0000000189806B30-0x0000000189806B50
		private void CheckHitScene() {} // 0x0000000184E464B0-0x0000000184E46A70
	}
}
