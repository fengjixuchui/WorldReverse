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
	public static class pb_HandleUtility // TypeDefIndex: 3397
	{
		// Fields
		private const float MAX_EDGE_SELECT_DISTANCE = 20f; // Metadata: 0x00AC3C3F
	
		// Methods
		public static bool FaceRaycast(Ray InWorldRay, pb_Object mesh, out pb_RaycastHit hit, HashSet<pb_Face> ignore = null) {
			hit = default;
			return default;
		} // 0x0000000186B9EE10-0x0000000186B9EEE0
		public static bool FaceRaycast(Ray InWorldRay, pb_Object mesh, out pb_RaycastHit hit, float distance, Culling cullingMode, HashSet<pb_Face> ignore = null) {
			hit = default;
			return default;
		} // 0x0000000186B9E530-0x0000000186B9EE10
		public static bool FaceRaycast(Ray InWorldRay, pb_Object mesh, out List<pb_RaycastHit> hits, float distance, Culling cullingMode, HashSet<pb_Face> ignore = null) {
			hits = default;
			return default;
		} // 0x0000000186B9DBE0-0x0000000186B9E530
		public static bool WorldRaycast(Ray InWorldRay, Transform transform, Vector3[] vertices, int[] triangles, out pb_RaycastHit hit, float distance = 1F / 0F /* Metadata: 0x00AC3C2F */, Culling cullingMode = Culling.Front /* Metadata: 0x00AC3C33 */) {
			hit = default;
			return default;
		} // 0x0000000186B9FB60-0x0000000186B9FF00
		public static bool MeshRaycast(Ray InRay, Vector3[] vertices, int[] triangles, out pb_RaycastHit hit, float distance = 1F / 0F /* Metadata: 0x00AC3C37 */, Culling cullingMode = Culling.Front /* Metadata: 0x00AC3C3B */) {
			hit = default;
			return default;
		} // 0x0000000186B9F4B0-0x0000000186B9F800
		public static bool EdgeRaycast(Camera cam, Vector2 mousePosition, pb_Object mesh, pb_Edge[] edges, Vector3[] verticesInWorldSpace, out pb_Edge edge) {
			edge = default;
			return default;
		} // 0x0000000186B9D0F0-0x0000000186B9DBE0
		public static GameObject ObjectRaycast(Camera cam, Vector2 mousePosition, GameObject[] objects) => default; // 0x0000000186B9F800-0x0000000186B9F850
		public static float DistancePoint2DToLine(Camera cam, Vector2 mousePosition, Vector3 worldPosition1, Vector3 worldPosition2) => default; // 0x0000000186B9CFA0-0x0000000186B9D0F0
		public static bool PointIsOccluded(Camera cam, pb_Object pb, Vector3 worldPoint) => default; // 0x0000000186B9F850-0x0000000186B9FAD0
		public static bool IsOccluded(Camera cam, pb_Object pb, pb_Face face) => default; // 0x0000000186B9F1F0-0x0000000186B9F4B0
	
		// Extension methods
		public static Ray InverseTransformRay(this Transform transform, Ray InWorldRay) => default; // 0x0000000186B9EEE0-0x0000000186B9F1F0
	}
}
