/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RootMotion.Dynamics
{
	// [AddComponentMenu] // 0x00000001896DBB60-0x00000001896DBBC0
	// [HelpURL] // 0x00000001896DBB60-0x00000001896DBBC0
	public class BipedRagdollCreator : RagdollCreator // TypeDefIndex: 9920
	{
		// Fields
		public bool canBuild; // 0x18
		public BipedRagdollReferences references; // 0x20
		public Options options; // 0xA8
	
		// Nested types
		[Serializable]
		public struct Options // TypeDefIndex: 9921
		{
			// Fields
			public float weight; // 0x00
			// [Header] // 0x000000018976AC10-0x000000018976AC40
			public bool spine; // 0x04
			public bool chest; // 0x05
			public bool hands; // 0x06
			public bool feet; // 0x07
			// [Header] // 0x00000001897738A0-0x00000001897738F0
			[HideInInspector] // 0x00000001897738A0-0x00000001897738F0
			public RagdollCreator.JointType joints; // 0x08
			public float jointRange; // 0x0C
			// [Header] // 0x000000018977F6A0-0x000000018977F6D0
			public float colliderLengthOverlap; // 0x10
			public RagdollCreator.ColliderType torsoColliders; // 0x14
			public RagdollCreator.ColliderType headCollider; // 0x18
			public RagdollCreator.ColliderType armColliders; // 0x1C
			public RagdollCreator.ColliderType handColliders; // 0x20
			public RagdollCreator.ColliderType legColliders; // 0x24
			public RagdollCreator.ColliderType footColliders; // 0x28
	
			// Properties
			public static Options Default { /* [XID] */ /* 0x0000000189B4AD70-0x0000000189B4AD90 */ get => default; } // 0x00000001876DF310-0x00000001876DF560 
		}
	
		// Constructors
		public BipedRagdollCreator() {} // 0x00000001876D38F0-0x00000001876D3E30
	
		// Methods
		// [ContextMenu] // 0x00000001896E91B0-0x00000001896E9200
		// [XID] // 0x00000001896E91B0-0x00000001896E9200
		private void OpenUserManual() {} // 0x00000001876D3840-0x00000001876D38F0
		// [ContextMenu] // 0x00000001896F3610-0x00000001896F3660
		// [XID] // 0x00000001896F3610-0x00000001896F3660
		private void OpenScriptReference() {} // 0x00000001876D36E0-0x00000001876D3790
		// [ContextMenu] // 0x00000001896FDEB0-0x00000001896FDF00
		// [XID] // 0x00000001896FDEB0-0x00000001896FDF00
		private void OpenTutorial() {} // 0x00000001876D3790-0x00000001876D3840
		// [XID] // 0x0000000189A39BF0-0x0000000189A39C10
		public static Options AutodetectOptions(BipedRagdollReferences r) => default; // 0x00000001876CE1E0-0x00000001876CE5C0
		// [XID] // 0x0000000189711600-0x0000000189711620
		public static void Create(BipedRagdollReferences r, Options options) {} // 0x00000001876D23B0-0x00000001876D2710
		// [XID] // 0x00000001898C06C0-0x00000001898C06E0
		private static void CreateColliders(BipedRagdollReferences r, Options options) {} // 0x00000001876CE730-0x00000001876CFA70
		// [XID] // 0x0000000189720180-0x00000001897201A0
		private static void CreateHandCollider(Transform hand, Transform lowerArm, Transform root, Options options) {} // 0x00000001876D0640-0x00000001876D0D30
		// [XID] // 0x0000000189727960-0x0000000189727980
		private static void CreateFootCollider(Transform foot, Transform lowerLeg, Transform upperLeg, Transform root, Options options) {} // 0x00000001876CFA70-0x00000001876D0640
		// [XID] // 0x000000018972EDF0-0x000000018972EE10
		private static Vector3 GetChildCentroid(Transform t, Vector3 fallback) => default; // 0x00000001876D2710-0x00000001876D2970
		// [XID] // 0x000000018989BEA0-0x000000018989BEC0
		private static void MassDistribution(BipedRagdollReferences r, Options o) {} // 0x00000001876D2F80-0x00000001876D36E0
		// [XID] // 0x000000018973E440-0x000000018973E460
		private static void CreateJoints(BipedRagdollReferences r, Options o) {} // 0x00000001876D0D30-0x00000001876D19C0
		// [XID] // 0x000000018990BEA0-0x000000018990BEC0
		private static void CreateLimbJoints(Transform connectedBone, Transform bone1, Transform bone2, Transform bone3, Transform root, Vector3 defaultWorldDirection, JointType jointType, RagdollCreator.CreateJointParams.Limits limits1, RagdollCreator.CreateJointParams.Limits limits2, RagdollCreator.CreateJointParams.Limits limits3) {} // 0x00000001876D19C0-0x00000001876D23B0
		// [XID] // 0x000000018974D210-0x000000018974D230
		public static void ClearBipedRagdoll(BipedRagdollReferences r) {} // 0x00000001876CE5C0-0x00000001876CE730
		// [XID] // 0x000000018991B1E0-0x000000018991B200
		public static bool IsClear(BipedRagdollReferences r) => default; // 0x00000001876D2DB0-0x00000001876D2F80
		// [XID] // 0x00000001898C7EA0-0x00000001898C7EC0
		private static Vector3 GetUpperArmToHeadCentroid(BipedRagdollReferences r) => default; // 0x00000001876D2B70-0x00000001876D2DB0
		// [XID] // 0x00000001897634A0-0x00000001897634C0
		private static Vector3 GetUpperArmCentroid(BipedRagdollReferences r) => default; // 0x00000001876D2970-0x00000001876D2B70
	}
}
