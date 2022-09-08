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
	public sealed class MonoEffectPluginLookAt : BaseMonoEffectPlugin // TypeDefIndex: 19727
	{
		// Fields
		public PitchType pitchType; // 0x28
		// [Header] // 0x0000000189902390-0x00000001899023C0
		public string FollowTargetPath; // 0x30
		// [Header] // 0x0000000189BD9390-0x0000000189BD93C0
		public bool IsNotAttachPoint; // 0x38
		// [Header] // 0x00000001899110D0-0x0000000189911100
		public bool NoFollowDestory; // 0x39
		// [Header] // 0x0000000189918CB0-0x0000000189918CE0
		public GameObject ActivateOnStart; // 0x40
		// [Header] // 0x000000018964A4D0-0x000000018964A500
		public bool FollowWhenDestroying; // 0x48
		private Transform _lookTarget; // 0x50
	
		// Nested types
		public enum PitchType // TypeDefIndex: 19728
		{
			None = 0,
			Rotate = 1,
			Move = 2
		}
	
		// Constructors
		public MonoEffectPluginLookAt() {} // 0x0000000184E4F4A0-0x0000000184E4F540
	
		// Methods
		// [XID] // 0x0000000189927B90-0x0000000189927BB0
		public override void Awaked() {} // 0x0000000184E4E460-0x0000000184E4E560
		// [XID] // 0x000000018992F3C0-0x000000018992F3E0
		public override void Init() {} // 0x0000000184E4E800-0x0000000184E4E8F0
		// [XID] // 0x0000000189936710-0x0000000189936730
		public override void SetLookAtParentTarget(Transform parent) {} // 0x0000000184E4EFA0-0x0000000184E4F4A0
		// [XID] // 0x000000018993E2F0-0x000000018993E310
		private void LookAt() {} // 0x0000000184E4EB80-0x0000000184E4EFA0
		// [XID] // 0x0000000189945900-0x0000000189945920
		public override void LateTick(float inDeltaTime) {} // 0x0000000184E4EA50-0x0000000184E4EB80
		// [XID] // 0x000000018994CD50-0x000000018994CD70
		public override bool IsToBeDeallocated() => default; // 0x0000000184E4E8F0-0x0000000184E4E9D0
		// [XID] // 0x0000000189954540-0x0000000189954560
		public override void Disabled() {} // 0x0000000184E4E640-0x0000000184E4E730
	}
}
