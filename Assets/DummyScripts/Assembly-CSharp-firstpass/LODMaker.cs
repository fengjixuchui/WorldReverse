/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class LODMaker // TypeDefIndex: 10066
{
	// Methods
	public static Mesh MakeLODMesh(Mesh orig, float aMaxWeight, bool recalcNormals = true /* Metadata: 0x00AE6EEE */, float removeSmallParts = 1f /* Metadata: 0x00AE6EEF */, bool reuseOldMesh = false /* Metadata: 0x00AE6EF3 */) => default; // 0x0000000186D15C10-0x0000000186D15CF0
	public static Mesh MakeLODMesh(Mesh orig, float aMaxWeight, float removeSmallParts, float protectNormals, float protectUvs, float smallTrianglesFirst, float protectSubMeshesAndSharpEdges, bool recalcNormals, bool reuseOldMesh = false /* Metadata: 0x00AE6EF4 */) => default; // 0x0000000186D15CF0-0x0000000186D15F90
	private static void GetWeights(float aMaxWeight, float removeSmallParts, float protectNormals, float protectUvs, float smallTrianglesFirst, float protectSubMeshesAndSharpEdges, out float sideLengthWeight, out float oldAngleWeight, out float newAngleWeight, out float uvWeight, out float areaDiffWeight, out float normalWeight, out float vertexWeight, out float centerDistanceWeight) {
		sideLengthWeight = default;
		oldAngleWeight = default;
		newAngleWeight = default;
		uvWeight = default;
		areaDiffWeight = default;
		normalWeight = default;
		vertexWeight = default;
		centerDistanceWeight = default;
	} // 0x0000000186D133B0-0x0000000186D13510
	public static void MakeLODMeshInBackground(object data) {} // 0x0000000186D140C0-0x0000000186D15C10
	private static Mesh MakeLODMesh(Mesh orig, float maxWeight, float removeSmallParts, float sideLengthWeight, float oldAngleWeight, float newAngleWeight, float uvWeight, float areaDiffWeight, float normalWeight, float vertexWeight, float centerDistanceWeight, bool recalcNormals, bool reuseOldMesh) => default; // 0x0000000186D15F90-0x0000000186D16E30
	private static void MakeLODMesh(Vector3[] vs, Vector3[] ns, Vector2[] uv1s, Vector2[] uv2s, Vector2[] uv3s, Vector2[] uv4s, Color32[] colors32, int[] ts, ref Matrix4x4[] bindposes, BoneWeight[] bws, ref int[] subMeshOffsets, Bounds meshBounds, float maxWeight, float removeSmallParts, float sideLengthWeight, float oldAngleWeight, float newAngleWeight, float uvWeight, float areaDiffWeight, float normalWeight, float vertexWeight, float centerDistanceWeight, out List<Vector3> newVs, out List<Vector3> newNs, out List<Vector2> newUv1s, out List<Vector2> newUv2s, out List<Vector2> newUv3s, out List<Vector2> newUv4s, out List<Color32> newColors32, out List<int> newTs, out List<BoneWeight> newBws) {
		newVs = default;
		newNs = default;
		newUv1s = default;
		newUv2s = default;
		newUv3s = default;
		newUv4s = default;
		newColors32 = default;
		newTs = default;
		newBws = default;
	} // 0x0000000186D16E30-0x0000000186D1AA90
	private static bool AnyWeightOK(float[] weights, float aMaxWeight) => default; // 0x0000000186D0E5F0-0x0000000186D0E690
	private static int[] GetAdjacentTriangles(int[] ts, int tIdx, List<List<int>> trianglesPerVertex, int[] uniqueVs, int[] triangleGroups, List<List<int>> trianglesPerGroup) => default; // 0x0000000186D0FC40-0x0000000186D103E0
	private static void SetTriangleGroup(int tIdx0, int tIdx1, int[] triangleGroups, List<List<int>> trianglesPerGroup) {} // 0x0000000186D1D510-0x0000000186D1DA10
	private static void GetTotalAngleAndCenterDistanceForCorner(int[] ts, Vector3[] vs, int[] movedVs, int vertexIdx, Vector3[] centerDistances, ref float totalAngle, ref Vector3 totalCenterDist) {} // 0x0000000186D107D0-0x0000000186D111C0
	private static void GetTotalAngleAndCenterDistanceForNewCorner(int[] ts, Vector3[] vs, int[] movedVs, int[] uniqueVs, int vertexIdx, int newIdx, Vector3[] centerDistances, float maxWeight, ref float totalAngle, ref Vector3 totalCenterDist, ref bool flipsTriangles) {} // 0x0000000186D111C0-0x0000000186D11FE0
	private static void GetUVStretchAndAreaForCorner(int[] ts, Vector3[] vs, int[] movedVs, int[] uniqueVs, Vector2[] uvs, int cFrom, int cTo, ref float affectedUvAreaDiff, ref float affectedAreaDiff, ref float totalUvAreaDiff, ref float totalAreaDiff) {} // 0x0000000186D11FE0-0x0000000186D12C10
	private static float GetNormalDiffForCorners(Vector3[] ns, int corner1, int corner2) => default; // 0x0000000186D106A0-0x0000000186D107D0
	private static void MergeVertices(ref int oldV, int newV, bool[] hasTwinVS, Vector3[] vs, int[] triangles, Vector2[] uv1s, Vector2[] uv2s, Vector2[] uv3s, Vector2[] uv4s, Color32[] colors32, bool[] deletedVertices, int[] movedVs, int[] uniqueVs, int[] movedUv1s, int[] movedUv2s, int[] movedUv3s, int[] movedUv4s, int[] movedColors, List<List<int>> trianglesPerVertex, bool logYN) {} // 0x0000000186D1AA90-0x0000000186D1B030
	private static void MoveVertex(int oldV, int newV, int[] movedVs, int[] uniqueVs, int[] movedUv1s, int[] movedUv2s, int[] movedUv3s, int[] movedUv4s, int[] movedColors) {} // 0x0000000186D1B030-0x0000000186D1B330
	private static void FillNewMeshArray(Vector3[] vs, bool[] vdel, int[] movedVs, Vector3[] ns, Vector2[] uv1s, int[] movedUv1s, Vector2[] uv2s, int[] movedUv2s, Vector2[] uv3s, int[] movedUv3s, Vector2[] uv4s, int[] movedUv4s, Color32[] colors32, int[] movedColors, BoneWeight[] bws, List<Vector3> newVs, List<Vector3> newNs, List<Vector2> newUv1s, List<Vector2> newUv2s, List<Vector2> newUv3s, List<Vector2> newUv4s, List<Color32> newColors32, List<BoneWeight> newBws, int[] o2n) {} // 0x0000000186D0EDF0-0x0000000186D0F640
	private static void FillNewMeshTriangles(int[] oldTriangles, int[] o2n, List<int> newTriangles, int[] subMeshOffsets, int[] triangleGroups, List<int> newTGrps) {} // 0x0000000186D0F640-0x0000000186D0FA90
	public static void RemoveUnusedVertices(List<Vector3> vs, List<Vector3> ns, List<Vector2> uv1s, List<Vector2> uv2s, List<Vector2> uv3s, List<Vector2> uv4s, List<Color32> colors32, List<BoneWeight> bws, List<int> ts) {} // 0x0000000186D1C1B0-0x0000000186D1C6D0
	public static void RemoveUnusedVertices(List<Vector3> vs, List<Vector3> ns, List<Vector2> uv1s, List<Vector2> uv2s, List<Vector2> uv3s, List<Vector2> uv4s, List<Color32> colors32, List<BoneWeight> bws, List<List<int>> subMeshes) {} // 0x0000000186D1C6D0-0x0000000186D1CD80
	public static void RemoveUnusedVertices(List<Vector3> vs, List<Vector3> ns, List<Vector2> uv1s, List<Vector2> uv2s, List<Vector2> uv3s, List<Vector2> uv4s, List<Color32> colors32, List<BoneWeight> bws, Dictionary<UnityEngine.Material, List<int>> subMeshes) {} // 0x0000000186D1CD80-0x0000000186D1D510
	private static void RemoveEmptyTriangles(List<Vector3> newVs, List<Vector3> newNs, List<Vector2> newUv1s, List<Vector2> newUv2s, List<Vector2> newUv3s, List<Vector2> newUv4s, List<Color32> newColors32, List<int> newTs, List<BoneWeight> newBws, int[] subMeshOffsets, List<int> newTGrps) {} // 0x0000000186D1B330-0x0000000186D1BA90
	private static void RemoveMiniTriangleGroups(float removeSmallParts, Vector3 sizeMultiplier, float aMaxWeight, List<Vector3> newVs, List<int> newTs, int[] subMeshOffsets, List<int> newTGrps) {} // 0x0000000186D1BA90-0x0000000186D1C1B0
	public static Mesh CreateNewMesh(Vector3[] vs, Vector3[] ns, Vector2[] uv1s, Vector2[] uv2s, Vector2[] uv3s, Vector2[] uv4s, Color32[] colors32, int[] ts, BoneWeight[] bws, Matrix4x4[] bindposes, int[] subMeshOffsets, bool recalcNormals) => default; // 0x0000000186D0E8F0-0x0000000186D0EA20
	public static void FillMesh(Mesh mesh, Vector3[] vs, Vector3[] ns, Vector2[] uv1s, Vector2[] uv2s, Vector2[] uv3s, Vector2[] uv4s, Color32[] colors32, int[] ts, BoneWeight[] bws, Matrix4x4[] bindposes, int[] subMeshOffsets, bool recalcNormals) {} // 0x0000000186D0EA20-0x0000000186D0EDF0
	private static float AngleCornerDiff(float angle) => default; // 0x0000000186D0E3D0-0x0000000186D0E500
	private static float AngleDiff(float angle) => default; // 0x0000000186D0E500-0x0000000186D0E5F0
	private static float Area(Vector3 p0, Vector3 p1, Vector3 p2) => default; // 0x0000000186D0E690-0x0000000186D0E8F0
	private static int GetVertexEqualTo(Vector3 v, List<int> orderedVertices, Vector3[] vs) => default; // 0x0000000186D12C10-0x0000000186D12F10
	private static List<int> GetVerticesEqualTo(Vector3 v, List<int> orderedVertices, Vector3[] vs) => default; // 0x0000000186D12F10-0x0000000186D130D0
	private static List<int> GetVerticesWithinBox(Vector3 from, Vector3 to, List<int> orderedVertices, Vector3[] vs) => default; // 0x0000000186D130D0-0x0000000186D133B0
	private static int GetLastVertexWithYSmaller(float y, List<int> orderedVertices, Vector3[] vs, int limitSearchRange) => default; // 0x0000000186D103E0-0x0000000186D106A0
	private static bool IsVertexObscured(Vector3[] vs, Vector3[] ns, int[] ts, bool[] vObscured, int[] uniqueVs, Vector3 vertexBoxSize, List<int> orderedVertices, List<List<int>> trianglesPerVertex, int[] subMeshIdxPerVertex, float maxObscureDist, bool hiddenByOtherSubmesh, Vector3 vertex, Vector3 normal, int i) => default; // 0x0000000186D13510-0x0000000186D13F90
	public static float FindCollision(Vector3 fromPos, Vector3 direction, Vector3 pointOnPlane, Vector3 normalPlane) => default; // 0x0000000186D0FA90-0x0000000186D0FC40
	private static void Log(string msg) {} // 0x0000000186D13F90-0x0000000186D140C0
}

