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
	public static class PhysXTools // TypeDefIndex: 9895
	{
		// Methods
		// [XID] // 0x00000001898134E0-0x0000000189813500
		public static Vector3 GetCenterOfMass(Rigidbody[] rigidbodies) => default; // 0x00000001876E0C70-0x00000001876E0FB0
		// [XID] // 0x000000018987E0D0-0x000000018987E0F0
		public static Vector3 GetCenterOfMassVelocity(Rigidbody[] rigidbodies) => default; // 0x00000001876E0930-0x00000001876E0C70
		// [XID] // 0x00000001898226D0-0x00000001898226F0
		public static void DivByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor) {} // 0x00000001876E0230-0x00000001876E0400
		// [XID] // 0x0000000189829CD0-0x0000000189829CF0
		public static void ScaleByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor) {} // 0x00000001876E13D0-0x00000001876E15E0
		// [XID] // 0x0000000189831240-0x0000000189831260
		public static Vector3 GetFromToAcceleration(Vector3 fromV, Vector3 toV) => default; // 0x00000001876E0FB0-0x00000001876E1220
		// [XID] // 0x0000000189A2F870-0x0000000189A2F890
		public static Vector3 GetAngularAcceleration(Quaternion fromR, Quaternion toR) => default; // 0x00000001876E0560-0x00000001876E0930
		// [IDTag] // 0x000000018983FFE0-0x0000000189840020
		// [XID] // 0x000000018983FFE0-0x0000000189840020
		public static void AddFromToTorque(Rigidbody r, Quaternion toR, ForceMode forceMode) {} // 0x00000001876DF910-0x00000001876DFCE0
		// [IDTag] // 0x000000018984A490-0x000000018984A4D0
		// [XID] // 0x000000018984A490-0x000000018984A4D0
		public static void AddFromToTorque(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode) {} // 0x00000001876DFCE0-0x00000001876E00D0
		// [XID] // 0x0000000189854630-0x0000000189854650
		public static void AddFromToForce(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode) {} // 0x00000001876DF560-0x00000001876DF910
		// [XID] // 0x0000000189AF3780-0x0000000189AF37A0
		public static Vector3 GetLinearAcceleration(Vector3 fromPoint, Vector3 toPoint) => default; // 0x00000001876E1220-0x00000001876E13D0
		// [XID] // 0x0000000189755100-0x0000000189755120
		public static Quaternion ToJointSpace(ConfigurableJoint joint) => default; // 0x00000001876E15E0-0x00000001876E1820
		// [XID] // 0x000000018986AB30-0x000000018986AB50
		public static Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass) => default; // 0x00000001876E00D0-0x00000001876E0230
		// [XID] // 0x0000000189A28100-0x0000000189A28120
		public static Vector3 Div(Vector3 v, Vector3 v2) => default; // 0x00000001876E0400-0x00000001876E0560
	}
}
