/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	[Serializable]
	public class pb_Face // TypeDefIndex: 3396
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int[] _indices; // 0x10
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int[] _distinctIndices; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private pb_Edge[] _edges; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _smoothingGroup; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private pb_UV _uv; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material _mat; // 0x38
		public bool manualUV; // 0x40
		public int elementGroup; // 0x44
		public int textureGroup; // 0x48
	
		// Properties
		public int[] indices { get => default; } // 0x0000000187732F60-0x0000000187732FC0 
		public int[] distinctIndices { get => default; } // 0x0000000187732E60-0x0000000187732EE0 
		public pb_Edge[] edges { get => default; } // 0x0000000187732EE0-0x0000000187732F60 
		public int smoothingGroup { get => default; set {} } // 0x0000000187733020-0x0000000187733080 0x0000000187733140-0x00000001877331A0
		public UnityEngine.Material material { get => default; set {} } // 0x0000000187732FC0-0x0000000187733020 0x00000001877330E0-0x0000000187733140
		public pb_UV uv { get => default; set {} } // 0x0000000187733080-0x00000001877330E0 0x00000001877331A0-0x0000000187733200
		public int this[int i] { get => default; } // 0x0000000187732D90-0x0000000187732E60 
	
		// Constructors
		public pb_Face() {} // 0x0000000187732D20-0x0000000187732D90
		public pb_Face(int[] i) {} // 0x0000000187732880-0x0000000187732960
		public pb_Face(int[] i, UnityEngine.Material m, pb_UV u, int smoothingGroup, int textureGroup, int elementGroup, bool manualUV) {} // 0x0000000187732960-0x0000000187732A40
		public pb_Face(pb_Face face) {} // 0x0000000187732A40-0x0000000187732D20
	
		// Methods
		public void CopyFrom(pb_Face other) {} // 0x000000018772F250-0x000000018772F530
		[Obsolete] // 0x00000001896D5DA0-0x00000001896D5DD0
		public void SetMaterial(UnityEngine.Material material) {} // 0x0000000187730D50-0x0000000187730DB0
		[Obsolete] // 0x00000001896DEEC0-0x00000001896DEEF0
		public void SetUV(pb_UV uvs) {} // 0x0000000187730E10-0x0000000187730E70
		[Obsolete] // 0x00000001896E78B0-0x00000001896E78E0
		public void SetSmoothingGroup(int smoothing) {} // 0x0000000187730DB0-0x0000000187730E10
		public bool IsValid() => default; // 0x00000001877305C0-0x0000000187730670
		public Vector3[] GetDistinctVertices(Vector3[] verts) => default; // 0x000000018772FA30-0x000000018772FB80
		public int[] GetTriangle(int index) => default; // 0x0000000187730340-0x00000001877305C0
		public pb_Edge[] GetAllEdges() => default; // 0x000000018772F530-0x000000018772FA30
		public void SetIndices(int[] i) {} // 0x0000000187730C90-0x0000000187730D50
		public void ShiftIndices(int offset) {} // 0x0000000187731040-0x0000000187731100
		public int SmallestIndexValue() => default; // 0x0000000187731100-0x0000000187731200
		public void ShiftIndicesToZero() {} // 0x0000000187730E70-0x0000000187731040
		public void ReverseIndices() {} // 0x0000000187730BD0-0x0000000187730C90
		public void RebuildCaches() {} // 0x0000000187730B60-0x0000000187730BD0
		private pb_Edge[] CacheEdges() => default; // 0x000000018772EB00-0x000000018772F060
		private int[] CacheDistinctIndices() => default; // 0x000000018772EA40-0x000000018772EB00
		public bool Contains(int[] triangle) => default; // 0x000000018772F060-0x000000018772F250
		public static int[] AllTriangles(pb_Face[] q) => default; // 0x000000018772E6F0-0x000000018772E840
		public static int[] AllTriangles(List<pb_Face> q) => default; // 0x000000018772E840-0x000000018772EA40
		public static int[] AllTrianglesDistinct(pb_Face[] q) => default; // 0x000000018772E570-0x000000018772E6F0
		public static List<int> AllTrianglesDistinct(List<pb_Face> f) => default; // 0x000000018772E380-0x000000018772E570
		public MeshTopology ToQuadOrTriangles(out int[] quadOrTris) {
			quadOrTris = default;
			return default;
		} // 0x0000000187731200-0x00000001877313D0
		public int[] ToQuad() => default; // 0x0000000187731A10-0x0000000187731A90
		public bool ToQuad(out int[] quad) {
			quad = default;
			return default;
		} // 0x00000001877313D0-0x0000000187731A10
		[Obsolete] // 0x00000001896F0530-0x00000001896F0560
		public static int MeshTriangles(pb_Face[] faces, out int[][] submeshes, out UnityEngine.Material[] materials) {
			submeshes = default;
			materials = default;
			return default;
		} // 0x0000000187730670-0x0000000187730B60
		public static int GetMeshIndices(pb_Face[] faces, out pb_Submesh[] submeshes, MeshTopology preferredTopology = MeshTopology.Triangles /* Metadata: 0x00AC3C2B */) {
			submeshes = default;
			return default;
		} // 0x000000018772FB80-0x0000000187730340
		public override string ToString() => default; // 0x00000001877324E0-0x0000000187732880
		public string ToStringDetailed() => default; // 0x0000000187731A90-0x00000001877324E0
	}
}
