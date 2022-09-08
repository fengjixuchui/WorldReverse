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
	public sealed class MonoEffectPluginLineLink : BaseMonoEffectPlugin // TypeDefIndex: 19726
	{
		// Fields
		// [Header] // 0x00000001898B5100-0x00000001898B5130
		public int size; // 0x28
		private Vector3 beginPos; // 0x2C
		// [Header] // 0x00000001898BCC10-0x00000001898BCC40
		public LineRenderer lrComp; // 0x38
		private Transform followerTarget; // 0x40
		private bool isDestroy; // 0x48
		public bool reverse; // 0x49
		public bool fixedTarget; // 0x4A
		public Vector3 offsetTarget; // 0x4C
	
		// Constructors
		public MonoEffectPluginLineLink() {} // 0x0000000184E4AD50-0x0000000184E4AE30
	
		// Methods
		// [XID] // 0x00000001898C59B0-0x00000001898C59D0
		public override void Awaked() {} // 0x0000000184E49B30-0x0000000184E49C50
		// [XID] // 0x00000001898CD160-0x00000001898CD180
		public override void Init() {} // 0x0000000184E4A1E0-0x0000000184E4A280
		// [XID] // 0x00000001898D4A10-0x00000001898D4A30
		private void SetPath(Vector3 beginPos, Vector3 targetPos) {} // 0x0000000184E4A410-0x0000000184E4A560
		// [XID] // 0x00000001898DC430-0x00000001898DC450
		public override void Tick(float inDeltaTime) {} // 0x0000000184E4AA10-0x0000000184E4AD50
		// [XID] // 0x00000001898E3E40-0x00000001898E3E60
		private void Points(Vector3 start, Vector3 end) {} // 0x0000000184E49D40-0x0000000184E4A090
		// [XID] // 0x00000001898EB990-0x00000001898EB9B0
		public override bool IsToBeDeallocated() => default; // 0x0000000184E4A280-0x0000000184E4A320
		// [XID] // 0x00000001898F3180-0x00000001898F31A0
		public override void Clear() {} // 0x0000000184E49C50-0x0000000184E49D40
		// [XID] // 0x00000001898FA840-0x00000001898FA860
		public override void SetTargetPos(Vector3 pos) {} // 0x0000000184E4A560-0x0000000184E4AA10
	}
}
