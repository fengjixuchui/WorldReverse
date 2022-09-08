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
	public static class GameObjectExtensions // TypeDefIndex: 10056
	{
		// Methods
		// [XID] // 0x000000018961CAA0-0x000000018961CAC0
		private static int GiveUniqueNameIfNeeded(GameObject aGo, GameObject topGO, int uniqueId) => default; // 0x00000001853D4460-0x00000001853D45D0
		// [XID] // 0x0000000189618120-0x0000000189618140
		private static bool MergeMeshInto(Mesh fromMesh, Transform[] fromBones, UnityEngine.Material[] fromMaterials, List<Vector3> vertices, List<Vector3> normals, List<Vector2> uv1s, List<Vector2> uv2s, List<Vector2> uv3s, List<Vector2> uv4s, List<Color32> colors32, List<BoneWeight> boneWeights, List<Transform> bones, List<Matrix4x4> bindposes, Dictionary<UnityEngine.Material, List<int>> subMeshes, bool usesNegativeScale, Vector4 lightmapScaleOffset, Transform fromTransform, Transform topTransform, string submeshName, string[] skipSubmeshNames) => default; // 0x00000001853D46B0-0x00000001853D6C80
		// [XID] // 0x0000000189615350-0x0000000189615370
		private static Vector3 ApplyBindPose(Vector3 vertex, Transform bone, Matrix4x4 bindpose, float boneWeight) => default; // 0x00000001853CDEA0-0x00000001853CE1C0
		// [XID] // 0x00000001895F4C80-0x00000001895F4CA0
		private static Vector3 UnApplyBindPose(Vector3 vertex, Transform bone, Matrix4x4 bindpose, float boneWeight) => default; // 0x00000001853D9E50-0x00000001853DA1C0
	
		// Extension methods
		// [XID] // 0x0000000189A74940-0x0000000189A74980
		public static Bounds GetWorldBounds(this GameObject go) => default; // 0x00000001853D4180-0x00000001853D4460
		// [XID] // 0x0000000189A7F0A0-0x0000000189A7F0E0
		public static Vector3[] GetBoundsCorners(this Bounds bounds) => default; // 0x00000001853D20D0-0x00000001853D2330
		// [XID] // 0x0000000189A89E00-0x0000000189A89E40
		public static Vector3[] GetBoundsCenterAndCorners(this Bounds bounds) => default; // 0x00000001853D1E40-0x00000001853D20D0
		// [XID] // 0x0000000189A94310-0x0000000189A94350
		public static Vector3[] GetWorldBoundsCorners(this GameObject go) => default; // 0x00000001853D3DF0-0x00000001853D4180
		// [XID] // 0x0000000189A9E9D0-0x0000000189A9EA10
		public static Vector3[] GetWorldBoundsCenterAndCorners(this GameObject go) => default; // 0x00000001853D3A60-0x00000001853D3DF0
		// [XID] // 0x0000000189AA8EF0-0x0000000189AA8F30
		public static float GetModelComplexity(this GameObject go) => default; // 0x00000001853D2A80-0x00000001853D2C80
		// [XID] // 0x0000000189AB3B30-0x0000000189AB3B70
		public static string GetModelInfoString(this GameObject go) => default; // 0x00000001853D2C80-0x00000001853D3250
		// [XID] // 0x0000000189ABE640-0x0000000189ABE680
		public static GameObject TopParent(this GameObject go) => default; // 0x00000001853D9D20-0x00000001853D9E50
		// [XID] // 0x0000000189AC8E00-0x0000000189AC8E40
		public static GameObject FindParentWithName(this GameObject go, string parentName) => default; // 0x00000001853D1A40-0x00000001853D1BD0
		// [XID] // 0x0000000189AD3790-0x0000000189AD37D0
		public static GameObject FindMutualParent(this GameObject go1, GameObject go2) => default; // 0x00000001853D17D0-0x00000001853D1A40
		// [XID] // 0x0000000189ADE560-0x0000000189ADE5A0
		public static GameObject FindFirstChildWithName(this GameObject go, string childName) => default; // 0x00000001853D15B0-0x00000001853D17D0
		// [XID] // 0x0000000189AE8B50-0x0000000189AE8B90
		public static bool IsChildWithNameUnique(this GameObject go, string childName) => default; // 0x00000001853D45D0-0x00000001853D46B0
		// [XID] // 0x0000000189AF3860-0x0000000189AF38A0
		public static void CountChildrenWithName(this GameObject go, string childName, ref int total) {} // 0x00000001853D0F50-0x00000001853D1220
		// [XID] // 0x0000000189AFDCD0-0x0000000189AFDD10
		public static GameObject GetGameObjectNamed(this GameObject go, string aStr, GameObject parentGO) => default; // 0x00000001853D2330-0x00000001853D2510
		// [XID] // 0x0000000189B08380-0x0000000189B083C0
		public static void DestroyChildren(this GameObject go, bool disabledOnly) {} // 0x00000001853D1220-0x00000001853D15B0
		public static T GetFirstComponentInParents<T>(this GameObject go)
			where T : Component => default;
		public static T GetFirstComponentInChildren<T>(this GameObject go)
			where T : Component => default;
		// [IDTag] // 0x0000000189B21470-0x0000000189B214C0
		// [XID] // 0x0000000189B21470-0x0000000189B214C0
		public static Mesh[] GetMeshes(this GameObject aGo) => default; // 0x00000001853D2730-0x00000001853D27E0
		// [IDTag] // 0x0000000189B2E9E0-0x0000000189B2EA30
		// [XID] // 0x0000000189B2E9E0-0x0000000189B2EA30
		public static Mesh[] GetMeshes(this GameObject aGo, bool includeDisabled) => default; // 0x00000001853D27E0-0x00000001853D2A80
		// [XID] // 0x0000000189B3C030-0x0000000189B3C070
		public static int GetTotalVertexCount(this GameObject aGo) => default; // 0x00000001853D3840-0x00000001853D3A60
		// [XID] // 0x0000000189B46C20-0x0000000189B46C60
		public static Mesh Get1stSharedMesh(this GameObject aGo) => default; // 0x00000001853D1BD0-0x00000001853D1E40
		// [IDTag] // 0x0000000189B514B0-0x0000000189B51500
		// [XID] // 0x0000000189B514B0-0x0000000189B51500
		public static void SetMeshes(this GameObject aGo, Mesh[] meshes) {} // 0x00000001853D7360-0x00000001853D7420
		// [IDTag] // 0x0000000189B5ECE0-0x0000000189B5ED30
		// [XID] // 0x0000000189B5ECE0-0x0000000189B5ED30
		public static void SetMeshes(this GameObject aGo, Mesh[] meshes, int lodLevel) {} // 0x00000001853D7420-0x00000001853D7500
		// [IDTag] // 0x0000000189B6BF80-0x0000000189B6BFD0
		// [XID] // 0x0000000189B6BF80-0x0000000189B6BFD0
		public static void SetMeshes(this GameObject aGo, Mesh[] meshes, bool includeDisabled, int lodLevel) {} // 0x00000001853D6C80-0x00000001853D7360
		// [XID] // 0x0000000189B797D0-0x0000000189B79810
		public static UnityEngine.Material[] GetMaterials(this GameObject aGo, bool includeDisabled) => default; // 0x00000001853D2510-0x00000001853D2730
		// [IDTag] // 0x0000000189B84040-0x0000000189B84090
		// [XID] // 0x0000000189B84040-0x0000000189B84090
		public static Mesh[] CombineMeshes(this GameObject aGO) => default; // 0x00000001853CE1C0-0x00000001853CE290
		// [IDTag] // 0x0000000189B91480-0x0000000189B914D0
		// [XID] // 0x0000000189B91480-0x0000000189B914D0
		public static Mesh[] CombineMeshes(this GameObject aGO, string[] skipSubmeshNames) => default; // 0x00000001853CE290-0x00000001853D0F50
		// [IDTag] // 0x0000000189BA5CF0-0x0000000189BA5D40
		// [XID] // 0x0000000189BA5CF0-0x0000000189BA5D40
		public static void SetUpLODLevels(this GameObject go) {} // 0x00000001853D9920-0x00000001853D99D0
		// [IDTag] // 0x0000000189BB2EB0-0x0000000189BB2F00
		// [XID] // 0x0000000189BB2EB0-0x0000000189BB2F00
		public static void SetUpLODLevels(this GameObject go, float maxWeight) {} // 0x00000001853D9B80-0x00000001853D9D20
		// [IDTag] // 0x0000000189BC0480-0x0000000189BC04D0
		// [XID] // 0x0000000189BC0480-0x0000000189BC04D0
		public static void SetUpLODLevels(this GameObject go, float[] lodScreenSizes, float[] maxWeights) {} // 0x00000001853D99D0-0x00000001853D9B80
		// [XID] // 0x0000000189BCE3D0-0x0000000189BCE410
		public static Mesh[] SetUpLODLevelsWithLODSwitcher(this GameObject go, float[] lodScreenSizes, float[] maxWeights, bool recalcNormals, float removeSmallParts = 1f /* Metadata: 0x00AE6E56 */, float protectNormals = 1f /* Metadata: 0x00AE6E5A */, float protectUvs = 1f /* Metadata: 0x00AE6E5E */, float protectSubMeshesAndSharpEdges = 1f /* Metadata: 0x00AE6E62 */, float smallTrianglesFirst = 1f /* Metadata: 0x00AE6E66 */, int nrOfSteps = 1 /* Metadata: 0x00AE6E6A */) => default; // 0x00000001853D9370-0x00000001853D9920
		[DebuggerHidden] // 0x0000000189BD8810-0x0000000189BD8850
		// [XID] // 0x0000000189BD8810-0x0000000189BD8850
		public static IEnumerator SetUpLODLevelsWithLODSwitcherInBackground(this GameObject go, float[] lodScreenSizes, float[] maxWeights, bool recalcNormals, float removeSmallParts = 1f /* Metadata: 0x00AE6E6E */, float protectNormals = 1f /* Metadata: 0x00AE6E72 */, float protectUvs = 1f /* Metadata: 0x00AE6E76 */, float protectSubMeshesAndSharpEdges = 1f /* Metadata: 0x00AE6E7A */, float smallTrianglesFirst = 1f /* Metadata: 0x00AE6E7E */) => default; // 0x00000001853D91F0-0x00000001853D9370
		// [XID] // 0x00000001895EB630-0x00000001895EB670
		public static Mesh[] SetUpLODLevelsAndChildrenWithLODSwitcher(this GameObject go, float[] lodScreenSizes, float[] maxWeights, bool recalcNormals, float removeSmallParts, float protectNormals = 1f /* Metadata: 0x00AE6E82 */, float protectUvs = 1f /* Metadata: 0x00AE6E86 */, float protectSubMeshesAndSharpEdges = 1f /* Metadata: 0x00AE6E8A */, float smallTrianglesFirst = 1f /* Metadata: 0x00AE6E8E */, int nrOfSteps = 1 /* Metadata: 0x00AE6E92 */) => default; // 0x00000001853D8540-0x00000001853D91F0
		// [XID] // 0x00000001895F5DE0-0x00000001895F5E20
		public static Mesh[] SetUpLODLevelsAndChildrenWithLODGroup(this GameObject go, float[] relativeTransitionHeights, float[] maxWeights, bool recalcNormals, float removeSmallParts, float protectNormals = 1f /* Metadata: 0x00AE6E96 */, float protectUvs = 1f /* Metadata: 0x00AE6E9A */, float protectSubMeshesAndSharpEdges = 1f /* Metadata: 0x00AE6E9E */, float smallTrianglesFirst = 1f /* Metadata: 0x00AE6EA2 */, int nrOfSteps = 1 /* Metadata: 0x00AE6EA6 */) => default; // 0x00000001853D7500-0x00000001853D8540
		// [XID] // 0x0000000189600230-0x0000000189600270
		public static Mesh GetSimplifiedMesh(this GameObject go, float maxWeight, bool recalcNormals, float removeSmallParts, float protectNormals = 1f /* Metadata: 0x00AE6EAA */, float protectUvs = 1f /* Metadata: 0x00AE6EAE */, float protectSubMeshesAndSharpEdges = 1f /* Metadata: 0x00AE6EB2 */, float smallTrianglesFirst = 1f /* Metadata: 0x00AE6EB6 */, int nrOfSteps = 1 /* Metadata: 0x00AE6EBA */) => default; // 0x00000001853D3390-0x00000001853D3840
		[DebuggerHidden] // 0x000000018960AE70-0x000000018960AEB0
		// [XID] // 0x000000018960AE70-0x000000018960AEB0
		public static IEnumerator GetSimplifiedMeshInBackground(this GameObject go, float maxWeight, bool recalcNormals, float removeSmallParts, Action<Mesh> result) => default; // 0x00000001853D3250-0x00000001853D3390
	}
}
