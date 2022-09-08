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

namespace RootMotion
{
	[Serializable]
	public class BipedReferences // TypeDefIndex: 9939
	{
		// Fields
		public Transform root; // 0x10
		public Transform pelvis; // 0x18
		public Transform leftThigh; // 0x20
		public Transform leftCalf; // 0x28
		public Transform leftFoot; // 0x30
		public Transform rightThigh; // 0x38
		public Transform rightCalf; // 0x40
		public Transform rightFoot; // 0x48
		public Transform leftUpperArm; // 0x50
		public Transform leftForearm; // 0x58
		public Transform leftHand; // 0x60
		public Transform rightUpperArm; // 0x68
		public Transform rightForearm; // 0x70
		public Transform rightHand; // 0x78
		public Transform head; // 0x80
		public Transform[] spine; // 0x88
		public Transform[] eyes; // 0x90
	
		// Properties
		public virtual bool isFilled { /* [XID] */ /* 0x00000001899C67A0-0x00000001899C67C0 */ get => default; } // 0x0000000187340B40-0x0000000187341020 
		public bool isEmpty { /* [XID] */ /* 0x0000000189601C50-0x0000000189601C70 */ get => default; } // 0x0000000187340A90-0x0000000187340B40 
	
		// Nested types
		public struct AutoDetectParams // TypeDefIndex: 9940
		{
			// Fields
			public bool legsParentInSpine; // 0x00
			public bool includeEyes; // 0x01
	
			// Properties
			public static AutoDetectParams Default { /* [XID] */ /* 0x00000001896248D0-0x00000001896248F0 */ get => default; } // 0x00000001876C15D0-0x00000001876C16B0 
	
			// Constructors
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes) : this() {
				this.legsParentInSpine = default;
				this.includeEyes = default;
			} // 0x00000001876C1550-0x00000001876C15D0
		}
	
		// Constructors
		public BipedReferences() {} // 0x00000001873409E0-0x0000000187340A90
	
		// Methods
		// [XID] // 0x00000001896B13B0-0x00000001896B13D0
		public virtual bool IsEmpty(bool includeRoot) => default; // 0x000000018733EC20-0x000000018733F140
		// [XID] // 0x00000001899DC7E0-0x00000001899DC800
		public virtual bool Contains(Transform t, bool ignoreRoot = false /* Metadata: 0x00AE6D40 */) => default; // 0x000000018733D240-0x000000018733D780
		// [XID] // 0x00000001899E40C0-0x00000001899E40E0
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams) => default; // 0x000000018733CFA0-0x000000018733D240
		// [XID] // 0x00000001899EB530-0x00000001899EB550
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams) {} // 0x000000018733D980-0x000000018733E3E0
		// [XID] // 0x00000001899F3260-0x00000001899F3280
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams) {} // 0x000000018733CA60-0x000000018733CFA0
		// [XID] // 0x00000001899FA900-0x00000001899FA920
		public static bool SetupError(BipedReferences references, ref string errorMessage) => default; // 0x0000000187340080-0x0000000187340230
		// [XID] // 0x0000000189636480-0x00000001896364A0
		public static bool SetupWarning(BipedReferences references, ref string warningMessage) => default; // 0x0000000187340230-0x00000001873403E0
		// [XID] // 0x0000000189653F50-0x0000000189653F70
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm) => default; // 0x000000018733F140-0x000000018733F2A0
		// [XID] // 0x0000000189A10AE0-0x0000000189A10B00
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams) => default; // 0x000000018733C520-0x000000018733C6C0
		// [XID] // 0x0000000189653420-0x0000000189653440
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams) => default; // 0x000000018733C820-0x000000018733CA60
		// [XID] // 0x0000000189A1F6D0-0x0000000189A1F6F0
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms) {} // 0x000000018733D780-0x000000018733D980
		// [XID] // 0x0000000189A26BB0-0x0000000189A26BD0
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform) {} // 0x000000018733C6C0-0x000000018733C820
		// [XID] // 0x000000018966A830-0x000000018966A850
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage) => default; // 0x000000018733F2A0-0x000000018733F950
		// [XID] // 0x0000000189A35AA0-0x0000000189A35AC0
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage) => default; // 0x000000018733F950-0x000000018733FDE0
		// [XID] // 0x0000000189A3D110-0x0000000189A3D130
		private static bool SpineError(BipedReferences references, ref string errorMessage) => default; // 0x00000001873403E0-0x0000000187340930
		// [XID] // 0x000000018970EDA0-0x000000018970EDC0
		private static bool SpineWarning(BipedReferences references, ref string warningMessage) => default; // 0x0000000187340930-0x00000001873409E0
		// [XID] // 0x000000018964CB20-0x000000018964CB40
		private static bool EyesError(BipedReferences references, ref string errorMessage) => default; // 0x000000018733E3E0-0x000000018733E670
		// [XID] // 0x00000001897492C0-0x00000001897492E0
		private static bool EyesWarning(BipedReferences references, ref string warningMessage) => default; // 0x000000018733E670-0x000000018733E720
		// [XID] // 0x0000000189617ED0-0x0000000189617EF0
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage) => default; // 0x000000018733FDE0-0x0000000187340080
		// [XID] // 0x0000000189A62760-0x0000000189A62780
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage) => default; // 0x000000018733E720-0x000000018733EA30
		// [XID] // 0x0000000189681460-0x0000000189681480
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation) => default; // 0x000000018733EA30-0x000000018733EC20
	}
}
