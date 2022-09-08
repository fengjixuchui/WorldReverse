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

namespace Cinemachine.Utility
{
	public static class UnityVectorExtensions // TypeDefIndex: 6862
	{
		// Fields
		public const float Epsilon = 0.0001f; // Metadata: 0x00ADDF78
	
		// Methods
		// [XID] // 0x000000018991B590-0x000000018991B5B0
		public static int PointOnWhichSideOfLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point) => default; // 0x00000001866AD130-0x00000001866AD370
		// [XID] // 0x000000018982AC90-0x000000018982ACB0
		public static float SignedAngle(Vector3 from, Vector3 to, Vector3 refNormal) => default; // 0x00000001866ADA60-0x00000001866ADD30
		// [XID] // 0x0000000189BA5B70-0x0000000189BA5B90
		public static Vector3 SlerpWithReferenceUp(Vector3 vA, Vector3 vB, float t, Vector3 up) => default; // 0x00000001866ADD30-0x00000001866AE120
		// [XID] // 0x00000001898E2B20-0x00000001898E2B40
		public static Vector3 Cartesian2Spherial(Vector3 cPos) => default; // 0x00000001866ACB50-0x00000001866ACCD0
		// [XID] // 0x00000001899436F0-0x0000000189943710
		public static Vector3 Spherial2Cartesian(Vector3 sPos) => default; // 0x00000001866AE120-0x00000001866AE2F0
	
		// Extension methods
		// [IDTag] // 0x00000001898E0600-0x00000001898E0650
		// [XID] // 0x00000001898E0600-0x00000001898E0650
		public static float ClosestPointOnSegment(this Vector3 p, Vector3 s0, Vector3 s1) => default; // 0x00000001866ACEB0-0x00000001866AD130
		// [IDTag] // 0x00000001898EE000-0x00000001898EE050
		// [XID] // 0x00000001898EE000-0x00000001898EE050
		public static float ClosestPointOnSegment(this Vector2 p, Vector2 s0, Vector2 s1) => default; // 0x00000001866ACCD0-0x00000001866ACEB0
		// [XID] // 0x00000001898FB580-0x00000001898FB5C0
		public static Vector3 ProjectOntoPlane(this Vector3 vector, Vector3 planeNormal) => default; // 0x00000001866AD370-0x00000001866AD550
		// [XID] // 0x0000000189906090-0x00000001899060D0
		public static Vector3 ProjectPointOnLine(this Vector3 point, Vector3 linePoint, Vector3 lineVec) => default; // 0x00000001866AD830-0x00000001866ADA60
		// [XID] // 0x00000001899106B0-0x00000001899106F0
		public static Vector3 ProjectPointOnLineSegment(this Vector3 point, Vector3 linePoint1, Vector3 linePoint2) => default; // 0x00000001866AD550-0x00000001866AD830
		// [XID] // 0x0000000189922A90-0x0000000189922AD0
		public static bool AlmostZero(this Vector3 v) => default; // 0x00000001866ACA80-0x00000001866ACB50
	}
}
