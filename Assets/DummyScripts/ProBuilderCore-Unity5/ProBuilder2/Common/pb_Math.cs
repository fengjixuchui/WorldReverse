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
	public static class pb_Math // TypeDefIndex: 3408
	{
		// Fields
		public const float PHI = 1.618034f; // Metadata: 0x00AC3CA0
		public const float FLT_EPSILON = 1E-45f; // Metadata: 0x00AC3CA4
		public const float FLT_COMPARE_EPSILON = 0.0001f; // Metadata: 0x00AC3CA8
		public const float HANDLE_EPSILON = 0.0001f; // Metadata: 0x00AC3CAC
		private static Vector3 tv1; // 0x00
		private static Vector3 tv2; // 0x0C
		private static Vector3 tv3; // 0x18
		private static Vector3 tv4; // 0x24
	
		// Methods
		public static Vector2 PointInCircumference(float radius, float angleInDegrees, Vector2 origin) => default; // 0x0000000186BAB570-0x0000000186BAB670
		public static Vector3 PointInSphere(float radius, float latitudeAngle, float longitudeAngle) => default; // 0x0000000186BABAB0-0x0000000186BABC10
		public static float SignedAngle(Vector2 a, Vector2 b) => default; // 0x0000000186BAD0E0-0x0000000186BAD1C0
		public static float SqrDistance(Vector3 a, Vector3 b) => default; // 0x0000000186BAD4F0-0x0000000186BAD590
		public static float TriangleArea(Vector3 x, Vector3 y, Vector3 z) => default; // 0x0000000186BADB70-0x0000000186BADE10
		public static float PolygonArea(Vector3[] vertices, int[] indices) => default; // 0x0000000186BABC10-0x0000000186BABE00
		public static Vector2 Perpendicular(Vector2 a, Vector2 b) => default; // 0x0000000186BAB420-0x0000000186BAB4D0
		public static Vector2 Perpendicular(Vector2 a) => default; // 0x0000000186BAB4D0-0x0000000186BAB570
		public static Vector2 ReflectPoint(Vector2 point, Vector2 a, Vector2 b) => default; // 0x0000000186BACBE0-0x0000000186BACE00
		public static float DistancePointLineSegment(Vector2 p, Vector2 v, Vector2 w) => default; // 0x0000000186BA83F0-0x0000000186BA8600
		public static float DistancePointLineSegment(Vector3 p, Vector3 v, Vector3 w) => default; // 0x0000000186BA8600-0x0000000186BA8950
		public static Vector3 GetNearestPointRayRay(Vector3 ao, Vector3 ad, Vector3 bo, Vector3 bd) => default; // 0x0000000186BA8C50-0x0000000186BA8FF0
		public static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, ref Vector2 intersect) => default; // 0x0000000186BA8950-0x0000000186BA8B10
		public static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3) => default; // 0x0000000186BA8B10-0x0000000186BA8C50
		public static bool PointInPolygon(Vector2[] polygon, Vector2 point, int[] indices = null) => default; // 0x0000000186BAB670-0x0000000186BAB8F0
		public static bool PointInPolygon(Vector2[] polygon, pb_Bounds2D polyBounds, pb_Edge[] edges, Vector2 point) => default; // 0x0000000186BAB8F0-0x0000000186BABAB0
		public static bool RectIntersectsLineSegment(Rect rect, Vector2 a, Vector2 b) => default; // 0x0000000186BACA00-0x0000000186BACBE0
		public static bool RayIntersectsTriangle(Ray InRay, Vector3 InTriangleA, Vector3 InTriangleB, Vector3 InTriangleC, out float OutDistance, out Vector3 OutPoint) {
			OutDistance = default;
			OutPoint = default;
			return default;
		} // 0x0000000186BAC490-0x0000000186BACA00
		public static bool RayIntersectsTriangle2(Vector3 origin, Vector3 dir, Vector3 vert0, Vector3 vert1, Vector3 vert2, ref float distance, ref Vector3 normal) => default; // 0x0000000186BABE00-0x0000000186BAC490
		public static float Secant(float x) => default; // 0x0000000186BAD040-0x0000000186BAD0E0
		public static Vector3 Normal(Vector3 p0, Vector3 p1, Vector3 p2) => default; // 0x0000000186BAACB0-0x0000000186BAAEC0
		public static Vector3 Normal(IList<pb_Vertex> vertices, IList<int> indices = null) => default; // 0x0000000186BAA3C0-0x0000000186BAA910
		public static Vector3 Normal(pb_Object pb, pb_Face face) => default; // 0x0000000186BAA910-0x0000000186BAACB0
		public static Vector3 Normal(IList<Vector3> p) => default; // 0x0000000186BAAEC0-0x0000000186BAB420
		public static void NormalTangentBitangent(pb_Object pb, pb_Face face, out Vector3 normal, out Vector3 tangent, out Vector3 bitangent) {
			normal = default;
			tangent = default;
			bitangent = default;
		} // 0x0000000186BA9780-0x0000000186BAA3C0
		public static bool IsCardinalAxis(Vector3 v, float epsilon = 1E-05f /* Metadata: 0x00AC3C7C */) => default; // 0x0000000186BA90C0-0x0000000186BA9350
		public static T Max<T>(T[] array)
			where T : IComparable<T> => default;
		public static T Min<T>(T[] array)
			where T : IComparable<T> => default;
		public static float LargestValue(Vector3 v) => default; // 0x0000000186BA93C0-0x0000000186BA9450
		public static float LargestValue(Vector2 v) => default; // 0x0000000186BA9350-0x0000000186BA93C0
		public static Vector2 SmallestVector2(Vector2[] v) => default; // 0x0000000186BAD1C0-0x0000000186BAD300
		public static Vector2 SmallestVector2(Vector2[] v, int[] indices) => default; // 0x0000000186BAD300-0x0000000186BAD4F0
		public static Vector2 LargestVector2(Vector2[] v) => default; // 0x0000000186BA9640-0x0000000186BA9780
		public static Vector2 LargestVector2(Vector2[] v, int[] indices) => default; // 0x0000000186BA9450-0x0000000186BA9640
		public static Vector3 BoundsCenter(Vector3[] verts) => default; // 0x0000000186BA7C30-0x0000000186BA7FE0
		public static Vector2 Average(IList<Vector2> v, IList<int> indices = null) => default; // 0x0000000186BA7310-0x0000000186BA7560
		public static Vector3 Average(IList<Vector3> v, IList<int> indices = null) => default; // 0x0000000186BA7560-0x0000000186BA7C30
		public static Vector4 Average(IList<Vector4> v, IList<int> indices = null) => default; // 0x0000000186BA6C20-0x0000000186BA6F80
		public static Color Average(IList<Color> c, IList<int> indices = null) => default; // 0x0000000186BA6F80-0x0000000186BA7310
		public static bool ContainsApprox(Vector3[] v, Vector3 p, float eps) => default; // 0x0000000186BA8060-0x0000000186BA8170
		public static int Wrap(int value, int lowerBound, int upperBound) => default; // 0x0000000186BADE10-0x0000000186BADEA0
		public static int Clamp(int value, int lowerBound, int upperBound) => default; // 0x0000000186BA7FE0-0x0000000186BA8060
		public static void Cross(Vector3 a, Vector3 b, ref float x, ref float y, ref float z) {} // 0x0000000186BA8260-0x0000000186BA8330
		public static void Cross(Vector3 a, Vector3 b, ref Vector3 res) {} // 0x0000000186BA8330-0x0000000186BA83F0
		public static void Cross(float ax, float ay, float az, float bx, float by, float bz, ref float x, ref float y, ref float z) {} // 0x0000000186BA8170-0x0000000186BA8260
		public static void Subtract(Vector3 a, Vector3 b, ref Vector3 res) {} // 0x0000000186BAD590-0x0000000186BAD630
	
		// Extension methods
		public static Vector2 RotateAroundPoint(this Vector2 v, Vector2 origin, float theta) => default; // 0x0000000186BACE00-0x0000000186BACF60
		public static Vector2 ScaleAroundPoint(this Vector2 v, Vector2 origin, Vector2 scale) => default; // 0x0000000186BACF60-0x0000000186BAD040
		public static Vector3 Average<T>(this IList<T> v, Func<T, Vector3> selector, IList<int> indices = null) => default;
		public static bool Approx2(this Vector2 v, Vector2 b, float delta = 0.0001f /* Metadata: 0x00AC3C80 */) => default; // 0x0000000186BA6550-0x0000000186BA6680
		public static bool Approx3(this Vector3 v, Vector3 b, float delta = 0.0001f /* Metadata: 0x00AC3C84 */) => default; // 0x0000000186BA6680-0x0000000186BA67F0
		public static bool Approx4(this Vector4 v, Vector4 b, float delta = 0.0001f /* Metadata: 0x00AC3C88 */) => default; // 0x0000000186BA67F0-0x0000000186BA69A0
		public static bool ApproxC(this Color a, Color b, float delta = 0.0001f /* Metadata: 0x00AC3C8C */) => default; // 0x0000000186BA69A0-0x0000000186BA6B50
		public static bool Approx(this float a, float b, float delta = 0.0001f /* Metadata: 0x00AC3C90 */) => default; // 0x0000000186BA6B50-0x0000000186BA6C20
		public static Vector2 ToMask(this Vector2 vec, float delta = 1E-45f /* Metadata: 0x00AC3C94 */) => default; // 0x0000000186BAD630-0x0000000186BAD770
		public static Vector3 ToMask(this Vector3 vec, float delta = 1E-45f /* Metadata: 0x00AC3C98 */) => default; // 0x0000000186BAD770-0x0000000186BAD930
		public static Vector3 ToSignedMask(this Vector3 vec, float delta = 1E-45f /* Metadata: 0x00AC3C9C */) => default; // 0x0000000186BAD930-0x0000000186BADB70
		public static Vector3 Abs(this Vector3 v) => default; // 0x0000000186BA6460-0x0000000186BA6550
		public static int IntSum(this Vector3 mask) => default; // 0x0000000186BA8FF0-0x0000000186BA90C0
	}
}
