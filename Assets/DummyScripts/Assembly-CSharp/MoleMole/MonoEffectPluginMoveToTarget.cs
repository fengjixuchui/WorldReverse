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
	// [RequireComponent] // 0x000000018996AE00-0x000000018996AE50
	public sealed class MonoEffectPluginMoveToTarget : BaseMonoEffectPlugin // TypeDefIndex: 19730
	{
		// Fields
		// [Header] // 0x0000000189976F10-0x0000000189976F40
		public float Velocity; // 0x28
		// [Header] // 0x000000018997FCD0-0x000000018997FD00
		public GameObject ActivateOnStart; // 0x30
		// [Header] // 0x00000001899891F0-0x0000000189989220
		public bool DestroyImmediatelyUponArrival; // 0x38
		// [Header] // 0x0000000189992260-0x0000000189992290
		public string ToAttachPoint; // 0x40
		private Transform _targetTransform; // 0x48
		private bool _active; // 0x50
	
		// Constructors
		public MonoEffectPluginMoveToTarget() {} // 0x0000000184E508C0-0x0000000184E50970
	
		// Methods
		// [XID] // 0x000000018999B660-0x000000018999B680
		public override void SetMoveToTarget(BaseEntity toEntity) {} // 0x0000000184E50410-0x0000000184E504F0
		// [XID] // 0x00000001899A2D50-0x00000001899A2D70
		public override void Awaked() {} // 0x0000000184E4FF60-0x0000000184E50060
		// [XID] // 0x00000001899AA880-0x00000001899AA8A0
		public override void Init() {} // 0x0000000184E50310-0x0000000184E50410
		// [XID] // 0x00000001899B21E0-0x00000001899B2200
		public override void Tick(float inDeltaTime) {} // 0x0000000184E504F0-0x0000000184E508C0
		// [XID] // 0x00000001899B95A0-0x00000001899B95C0
		public override void Disabled() {} // 0x0000000184E50140-0x0000000184E50230
	}
}
