/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public static class pb_Spline // TypeDefIndex: 3428
	{
		// Methods
		public static pb_Object Extrude(IList<pb_BezierPoint> points, float radius = 0.5f /* Metadata: 0x00AC3D1C */, int columns = 32 /* Metadata: 0x00AC3D20 */, int rows = 16 /* Metadata: 0x00AC3D24 */, bool closeLoop = false /* Metadata: 0x00AC3D28 */, bool smooth = true /* Metadata: 0x00AC3D29 */) => default; // 0x00000001894CD110-0x00000001894CD1F0
		public static void Extrude(IList<pb_BezierPoint> bezierPoints, float radius, int columns, int rows, bool closeLoop, bool smooth, ref pb_Object target) {} // 0x00000001894CD000-0x00000001894CD110
		public static List<Vector3> GetControlPoints(IList<pb_BezierPoint> bezierPoints, int subdivisionsPerSegment, bool closeLoop, List<Quaternion> rotations) => default; // 0x00000001894CD8D0-0x00000001894CDC50
		public static void Extrude(IList<Vector3> points, float radius, int radiusRows, bool closeLoop, bool smooth, ref pb_Object target, IList<Quaternion> pointRotations = null) {} // 0x00000001894CD1F0-0x00000001894CD8D0
		private static Quaternion GetRingRotation(IList<Vector3> points, int i, bool closeLoop, out float secant) {
			secant = default;
			return default;
		} // 0x00000001894CDC50-0x00000001894CE4B0
		private static Vector3[] VertexRing(Quaternion orientation, Vector3 offset, float radius, int segments) => default; // 0x00000001894CE4B0-0x00000001894CE8A0
	}
}
