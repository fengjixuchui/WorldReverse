/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace OrbCreationExtensions
{
	public static class MeshExtensions // TypeDefIndex: 10059
	{
		// Methods
		// [XID] // 0x0000000189763460-0x0000000189763480
		private static bool IsTriangleHidden(Vector3 v0, Vector3 v1, Vector3 v2, float maxDistance, List<Vector3> triMinCorners, List<Vector3> triMaxCorners, List<Vector3> hidingVs, List<int> hidingTs) => default; // 0x000000018722BF80-0x000000018722C3E0
		// [XID] // 0x000000018976ABD0-0x000000018976ABF0
		private static bool IsHidden(Vector3 v, Vector3 n, float maxDistance, List<Vector3> hidingVs, List<int> hidingTs, List<int> trianglesToCheck) => default; // 0x000000018722B980-0x000000018722BE90
		// [XID] // 0x00000001897721D0-0x00000001897721F0
		private static List<int> GetTrianglesWithinRange(Vector3 v0, Vector3 v1, Vector3 v2, float maxDistance, List<Vector3> triMinCorners, List<Vector3> triMaxCorners) => default; // 0x000000018722B3B0-0x000000018722B7A0
		// [XID] // 0x00000001896CE660-0x00000001896CE680
		public static float DistanceToPlane(Vector3 fromPos, Vector3 direction, Vector3 pointOnPlane, Vector3 normalPlane) => default; // 0x000000018722AE40-0x000000018722B090
		// [XID] // 0x0000000189781300-0x0000000189781320
		public static Vector3 GetNormal(Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x000000018722B090-0x000000018722B2E0
	
		// Extension methods
		// [XID] // 0x00000001896C3FE0-0x00000001896C4020
		public static void RecalculateTangents(this Mesh mesh) {} // 0x000000018722CCA0-0x000000018722D7F0
		// [XID] // 0x00000001896CE7E0-0x00000001896CE820
		public static Mesh ScaledRotatedTranslatedMesh(this Mesh mesh, Vector3 scale, Quaternion rotate, Vector3 translate) => default; // 0x000000018722D7F0-0x000000018722DCD0
		// [XID] // 0x00000001896D8BD0-0x00000001896D8C10
		public static bool IsSkinnedMesh(this Mesh mesh) => default; // 0x000000018722BE90-0x000000018722BF80
		// [XID] // 0x00000001896E3260-0x00000001896E32A0
		public static int GetTriangleCount(this Mesh orig) => default; // 0x000000018722B2E0-0x000000018722B3B0
		// [XID] // 0x00000001896ED540-0x00000001896ED580
		public static Mesh MakeLODMesh(this Mesh orig, float aMaxWeight, bool recalcNormals, float removeSmallParts = 1f /* Metadata: 0x00AE6EBE */, float protectNormals = 1f /* Metadata: 0x00AE6EC2 */, float protectUvs = 1f /* Metadata: 0x00AE6EC6 */, float protectSubMeshesAndSharpEdges = 1f /* Metadata: 0x00AE6ECA */, float smallTrianglesFirst = 1f /* Metadata: 0x00AE6ECE */) => default; // 0x000000018722C570-0x000000018722C6F0
		[DebuggerHidden] // 0x00000001896F7B30-0x00000001896F7B70
		// [XID] // 0x00000001896F7B30-0x00000001896F7B70
		public static IEnumerator MakeLODMeshInBackground(this Mesh mesh, float maxWeight, bool recalcNormals, float removeSmallParts, Action<Mesh> result) => default; // 0x000000018722C3E0-0x000000018722C570
		// [XID] // 0x00000001897051D0-0x0000000189705210
		public static Mesh[] MakeLODMeshes(this Mesh mesh, float[] maxWeights, bool recalcNormals, float removeSmallParts = 1f /* Metadata: 0x00AE6ED2 */, float protectNormals = 1f /* Metadata: 0x00AE6ED6 */, float protectUvs = 1f /* Metadata: 0x00AE6EDA */, float protectSubMeshesAndSharpEdges = 1f /* Metadata: 0x00AE6EDE */, float smallTrianglesFirst = 1f /* Metadata: 0x00AE6EE2 */, int nrOfSteps = 1 /* Metadata: 0x00AE6EE6 */) => default; // 0x000000018722C6F0-0x000000018722CA30
		// [XID] // 0x000000018970FD30-0x000000018970FD70
		public static Vector4 GetUvRange(this Mesh mesh) => default; // 0x000000018722B7A0-0x000000018722B980
		// [XID] // 0x000000018971A460-0x000000018971A4A0
		public static bool CheckUvsWithin01Range(this Mesh mesh) => default; // 0x0000000187229210-0x0000000187229340
		// [XID] // 0x0000000189724670-0x00000001897246B0
		public static void ClampUvs(this Mesh mesh) {} // 0x0000000187229340-0x00000001872294E0
		// [XID] // 0x000000018972EDB0-0x000000018972EDF0
		public static void WrapUvs(this Mesh mesh) {} // 0x000000018722E060-0x000000018722E210
		// [XID] // 0x00000001897393A0-0x00000001897393E0
		public static void SetAtlasRectForSubmesh(this Mesh mesh, Rect atlasRect, int submeshIndex) {} // 0x000000018722DCD0-0x000000018722E060
		// [XID] // 0x0000000189743D40-0x0000000189743D80
		public static void MergeSubmeshInto(this Mesh mesh, int from, int to) {} // 0x000000018722CA30-0x000000018722CCA0
		// [XID] // 0x000000018974E810-0x000000018974E850
		public static Mesh CopyAndRemoveSubmeshes(this Mesh orig, int[] submeshesToRemove) => default; // 0x000000018722A690-0x000000018722AE40
		// [XID] // 0x0000000189758850-0x0000000189758890
		public static Mesh CopyAndRemoveHiddenTriangles(this Mesh orig, int subMeshIdx, Matrix4x4 localToWorldMatrix, Mesh[] hidingMeshes, int[] hidingSubMeshes, Matrix4x4[] hidingLocalToWorldMatrices, float maxRemoveDistance = 0.01f /* Metadata: 0x00AE6EEA */) => default; // 0x00000001872294E0-0x000000018722A690
	}
}
