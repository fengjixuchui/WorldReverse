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
	public abstract class RagdollCreator : MonoBehaviour // TypeDefIndex: 9924
	{
		// Nested types
		[Serializable]
		public enum ColliderType // TypeDefIndex: 9925
		{
			Box = 0,
			Capsule = 1
		}
	
		[Serializable]
		public enum JointType // TypeDefIndex: 9926
		{
			Configurable = 0,
			Character = 1
		}
	
		[Serializable]
		public enum Direction // TypeDefIndex: 9927
		{
			X = 0,
			Y = 1,
			Z = 2
		}
	
		public struct CreateJointParams // TypeDefIndex: 9928
		{
			// Fields
			public Rigidbody rigidbody; // 0x00
			public Rigidbody connectedBody; // 0x08
			public Transform child; // 0x10
			public Vector3 worldSwingAxis; // 0x18
			public Limits limits; // 0x24
			public JointType type; // 0x34
	
			// Nested types
			public struct Limits // TypeDefIndex: 9929
			{
				// Fields
				public float minSwing; // 0x00
				public float maxSwing; // 0x04
				public float swing2; // 0x08
				public float twist; // 0x0C
	
				// Constructors
				public Limits(float minSwing, float maxSwing, float swing2, float twist) {
					this.minSwing = default;
					this.maxSwing = default;
					this.swing2 = default;
					this.twist = default;
				} // 0x000000018777D490-0x000000018777D4A0
			}
	
			// Constructors
			public CreateJointParams(Rigidbody rigidbody, Rigidbody connectedBody, Transform child, Vector3 worldSwingAxis, Limits limits, JointType type) {
				this.rigidbody = default;
				this.connectedBody = default;
				this.child = default;
				this.worldSwingAxis = default;
				this.limits = default;
				this.type = default;
			} // 0x000000018777D2A0-0x000000018777D390
		}
	
		// Constructors
		protected RagdollCreator() {} // 0x000000018779AA00-0x000000018779AA60
	
		// Methods
		// [XID] // 0x0000000189817F50-0x0000000189817F70
		public static void ClearAll(Transform root) {} // 0x00000001877974C0-0x0000000187797750
		// [XID] // 0x000000018981F800-0x000000018981F820
		protected static void ClearTransform(Transform transform) {} // 0x0000000187797750-0x0000000187797A00
		// [IDTag] // 0x0000000189826DD0-0x0000000189826E10
		// [XID] // 0x0000000189826DD0-0x0000000189826E10
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width) {} // 0x0000000187798150-0x0000000187798820
		// [IDTag] // 0x0000000189831200-0x0000000189831240
		// [XID] // 0x0000000189831200-0x0000000189831240
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width, float proportionAspect, Vector3 widthDirection) {} // 0x0000000187797A00-0x0000000187798150
		// [XID] // 0x000000018983B850-0x000000018983B870
		protected static float GetScaleF(Transform t) => default; // 0x000000018779A710-0x000000018779A800
		// [XID] // 0x0000000189843250-0x0000000189843270
		protected static Vector3 Abs(Vector3 v) => default; // 0x00000001877973C0-0x00000001877974C0
		// [XID] // 0x000000018984A470-0x000000018984A490
		protected static void Vector3Abs(ref Vector3 v) {} // 0x000000018779A900-0x000000018779AA00
		// [XID] // 0x0000000189851A60-0x0000000189851A80
		protected static Vector3 DirectionIntToVector3(int dir) => default; // 0x0000000187799BE0-0x0000000187799D40
		// [XID] // 0x00000001899BBA90-0x00000001899BBAB0
		protected static Vector3 DirectionToVector3(Direction dir) => default; // 0x0000000187799D40-0x0000000187799EA0
		// [XID] // 0x00000001898F4920-0x00000001898F4940
		protected static int DirectionVector3ToInt(Vector3 dir) => default; // 0x0000000187799EA0-0x000000018779A0E0
		// [XID] // 0x00000001898FCD40-0x00000001898FCD60
		protected static Vector3 GetLocalOrthoDirection(Transform transform, Vector3 worldDir) => default; // 0x000000018779A300-0x000000018779A710
		// [XID] // 0x00000001899C36B0-0x00000001899C36D0
		protected static Rigidbody GetConnectedBody(Transform bone, ref Transform[] bones) => default; // 0x000000018779A0E0-0x000000018779A300
		// [XID] // 0x00000001898F5630-0x00000001898F5650
		protected static void CreateJoint(CreateJointParams p) {} // 0x0000000187798820-0x0000000187799BE0
		// [XID] // 0x00000001899046E0-0x0000000189904700
		private static SoftJointLimit ToSoftJointLimit(float limit) => default; // 0x000000018779A800-0x000000018779A900
	}
}
