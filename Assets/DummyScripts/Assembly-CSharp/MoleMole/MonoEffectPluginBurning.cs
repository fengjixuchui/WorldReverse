/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class MonoEffectPluginBurning : BaseMonoEffectPlugin // TypeDefIndex: 19692
	{
		// Fields
		private static readonly int NOISE_RANDOM_PARAM_ID; // 0x00
		public float randomPosRange; // 0x28
		public float randomScaleXMin; // 0x2C
		public float randomScaleXMax; // 0x30
		public float randomScaleYMin; // 0x34
		public float randomScaleYMax; // 0x38
		public float randomAppearTimeMin; // 0x3C
		public float randomAppearTimeMax; // 0x40
		public float randomDisappearTimeMin; // 0x44
		public float randomDisappearTimeMax; // 0x48
		private MeshRenderer _meshRenderer; // 0x50
		private Vector3 _maxScale; // 0x58
		private float _appearTime; // 0x64
		private float _appearLeftTime; // 0x68
		private float _disappearTime; // 0x6C
		private float _disappearLeftTime; // 0x70
		private Coroutine _disappearCoroutine; // 0x78
	
		// Constructors
		public MonoEffectPluginBurning() {} // 0x0000000184E37560-0x0000000184E37620
		static MonoEffectPluginBurning() {} // 0x0000000184E374F0-0x0000000184E37560
	
		// Methods
		// [XID] // 0x00000001898A79F0-0x00000001898A7A10
		public override void Awaked() {} // 0x0000000184E36900-0x0000000184E36A30
		// [XID] // 0x00000001898AF4F0-0x00000001898AF510
		public override void Init() {} // 0x0000000184E36CD0-0x0000000184E37090
		// [XID] // 0x00000001898B6910-0x00000001898B6930
		public override void Tick(float inDeltaTime) {} // 0x0000000184E372C0-0x0000000184E374F0
		// [XID] // 0x00000001898BE120-0x00000001898BE140
		public override bool IsToBeDeallocated() => default; // 0x0000000184E37090-0x0000000184E37140
		// [XID] // 0x00000001898C59D0-0x00000001898C59F0
		public override void Destroied() {} // 0x0000000184E36A30-0x0000000184E36B20
		// [XID] // 0x00000001898CD180-0x00000001898CD1A0
		public override void OnSetEffectStop() {} // 0x0000000184E371A0-0x0000000184E372C0
		[DebuggerHidden] // 0x00000001898D4A30-0x00000001898D4A70
		// [XID] // 0x00000001898D4A30-0x00000001898D4A70
		private IEnumerator DoDisappear() => default; // 0x0000000184E367F0-0x0000000184E36900
	}
}
