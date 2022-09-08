/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using RootMotion;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RootMotion.Dynamics
{
	[Serializable]
	public struct BipedRagdollReferences // TypeDefIndex: 9922
	{
		// Fields
		public Transform root; // 0x00
		public Transform hips; // 0x08
		public Transform spine; // 0x10
		public Transform chest; // 0x18
		public Transform head; // 0x20
		public Transform leftUpperLeg; // 0x28
		public Transform leftLowerLeg; // 0x30
		public Transform leftFoot; // 0x38
		public Transform rightUpperLeg; // 0x40
		public Transform rightLowerLeg; // 0x48
		public Transform rightFoot; // 0x50
		public Transform leftUpperArm; // 0x58
		public Transform leftLowerArm; // 0x60
		public Transform leftHand; // 0x68
		public Transform rightUpperArm; // 0x70
		public Transform rightLowerArm; // 0x78
		public Transform rightHand; // 0x80
	
		// Methods
		// [XID] // 0x000000018978FF80-0x000000018978FFA0
		public bool IsValid(ref string msg) => default; // 0x00000001876D5890-0x00000001876D58C0
		// [XID] // 0x00000001898A9DE0-0x00000001898A9E00
		private bool IsChildRecursive(Transform t, Transform parent) => default; // 0x00000001876D4B40-0x00000001876D4FE0
		// [XID] // 0x000000018979F6F0-0x000000018979F710
		public bool IsEmpty(bool considerRoot) => default; // 0x00000001876D4FE0-0x00000001876D5890
		// [XID] // 0x00000001897A6BC0-0x00000001897A6BE0
		public bool Contains(Transform t, bool ignoreRoot = false /* Metadata: 0x00AE6CE3 */) => default; // 0x00000001876D3E30-0x00000001876D3E40
		// [XID] // 0x00000001897AE2C0-0x00000001897AE2E0
		public Transform[] GetRagdollTransforms() => default; // 0x00000001876D49B0-0x00000001876D4B40
		// [XID] // 0x0000000189931630-0x0000000189931650
		public static BipedRagdollReferences FromAvatar(Animator animator) => default; // 0x00000001876D3E40-0x00000001876D4170
		// [XID] // 0x00000001897BE1E0-0x00000001897BE200
		public static BipedRagdollReferences FromBipedReferences(BipedReferences biped) => default; // 0x00000001876D4170-0x00000001876D49B0
	}
}
