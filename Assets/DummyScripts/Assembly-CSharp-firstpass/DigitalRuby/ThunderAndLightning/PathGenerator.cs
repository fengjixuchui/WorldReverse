/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace DigitalRuby.ThunderAndLightning
{
	public static class PathGenerator // TypeDefIndex: 9686
	{
		// Fields
		public const int MinPointsForSpline = 4; // Metadata: 0x00AE5CF4
		public static bool Is2D; // 0x00
		private const float curveMultiplier = 3f; // Metadata: 0x00AE5CF8
		private const float splineMultiplier1 = -3f; // Metadata: 0x00AE5CFC
		private const float splineMultiplier2 = 3f; // Metadata: 0x00AE5D00
		private const float splineMultiplier3 = 2f; // Metadata: 0x00AE5D04
		private const float splineDistanceClamp = 1f; // Metadata: 0x00AE5D08
		private const float splineEpsilon = 0.0001f; // Metadata: 0x00AE5D0C
	
		// Methods
		// [XID] // 0x0000000189956920-0x0000000189956940
		public static float SquareRoot(float x) => default; // 0x000000018604FA90-0x000000018604FC10
		// [XID] // 0x0000000189648040-0x0000000189648060
		private static float Distance2D(ref Vector3 point1, ref Vector3 point2) => default; // 0x000000018604ED70-0x000000018604EE50
		// [XID] // 0x0000000189965CB0-0x0000000189965CD0
		private static float Distance3D(ref Vector3 point1, ref Vector3 point2) => default; // 0x000000018604EE50-0x000000018604EF40
		// [XID] // 0x000000018996D2D0-0x000000018996D2F0
		private static void GetCurvePoint2D(ref Vector3 start, ref Vector3 end, ref Vector3 ctr1, ref Vector3 ctr2, float t, out Vector3 point) {
			point = default;
		} // 0x000000018604EF40-0x000000018604F160
		// [XID] // 0x0000000189974BF0-0x0000000189974C10
		private static void GetCurvePoint3D(ref Vector3 start, ref Vector3 end, ref Vector3 ctr1, ref Vector3 ctr2, float t, out Vector3 point) {
			point = default;
		} // 0x000000018604F160-0x000000018604F3F0
		// [XID] // 0x00000001897BF840-0x00000001897BF860
		private static void CalculateNonuniformCatmullRom(float p1, float p2, float p3, float p4, float distance1, float distance2, float distance3, out Vector4 point) {
			point = default;
		} // 0x000000018604DBB0-0x000000018604DDD0
		// [XID] // 0x0000000189669BA0-0x0000000189669BC0
		private static float CalculatePolynomial(ref Vector4 point, float t) => default; // 0x000000018604DDD0-0x000000018604DEC0
		// [XID] // 0x000000018998B700-0x000000018998B720
		private static void ClampSplineDistances(ref float distance1, ref float distance2, ref float distance3) {} // 0x000000018604DEC0-0x000000018604DFA0
		// [XID] // 0x000000018964F6F0-0x000000018964F710
		private static void GetSplinePoint2D(ref Vector3 point1, ref Vector3 point2, ref Vector3 point3, ref Vector3 point4, float t, out Vector3 point) {
			point = default;
		} // 0x000000018604F3F0-0x000000018604F700
		// [XID] // 0x000000018999AC90-0x000000018999ACB0
		private static void GetSplinePoint3D(ref Vector3 point1, ref Vector3 point2, ref Vector3 point3, ref Vector3 point4, float t, out Vector3 point) {
			point = default;
		} // 0x000000018604F700-0x000000018604FA90
		// [XID] // 0x00000001899A2460-0x00000001899A2480
		public static float CreateCurve(ICollection<Vector3> path, Vector3 start, Vector3 end, Vector3 ctr1, Vector3 ctr2, int numberOfSegments, float startT) => default; // 0x000000018604DFA0-0x000000018604E370
		// [XID] // 0x0000000189BA2CD0-0x0000000189BA2CF0
		public static bool CreateSpline(ICollection<Vector3> path, IList<Vector3> points, int numberOfSegments, bool closePath) => default; // 0x000000018604E920-0x000000018604ED70
		// [XID] // 0x00000001899B1700-0x00000001899B1720
		public static bool CreateSplineWithSegmentDistance(ICollection<Vector3> path, IList<Vector3> points, float distancePerSegment, bool closePath) => default; // 0x000000018604E370-0x000000018604E920
	}
}
