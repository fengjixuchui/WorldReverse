/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ProBuilder2.Common;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

// [AddComponentMenu] // 0x00000001898A86C0-0x00000001898A87A0
[DisallowMultipleComponent] // 0x00000001898A86C0-0x00000001898A87A0
[ExecuteInEditMode] // 0x00000001898A86C0-0x00000001898A87A0
// [RequireComponent] // 0x00000001898A86C0-0x00000001898A87A0
// [RequireComponent] // 0x00000001898A86C0-0x00000001898A87A0
// [RequireComponent] // 0x00000001898A86C0-0x00000001898A87A0
public class pb_Object : MonoBehaviour // TypeDefIndex: 3413
{
	// Fields
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private pb_Face[] _quads; // 0x18
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private pb_IntArray[] _sharedIndices; // 0x20
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private Vector3[] _vertices; // 0x28
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private Vector2[] _uv; // 0x30
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private List<Vector4> _uv3; // 0x38
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private List<Vector4> _uv4; // 0x40
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private Vector4[] _tangents; // 0x48
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private pb_IntArray[] _sharedIndicesUV; // 0x50
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private Color[] _colors; // 0x58
	public bool userCollisions; // 0x60
	public bool isSelectable; // 0x61
	public pb_UnwrapParameters unwrapParameters; // 0x68
	public string asset_guid; // 0x70
	public bool dontDestroyMeshOnDelete; // 0x78
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private int[] m_selectedFaces; // 0x80
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private pb_Edge[] m_SelectedEdges; // 0x88
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private int[] m_selectedTriangles; // 0x90

	// Properties
	private pb_Face[] _faces { get => default; } // 0x000000018773A690-0x000000018773A6F0 
	public Mesh msh { get => default; set {} } // 0x000000018773AAC0-0x000000018773AB50 0x000000018773B1B0-0x000000018773B260
	public pb_Face[] faces { get => default; } // 0x000000018773A840-0x000000018773A8A0 
	public pb_Face[] quads { get => default; } // 0x000000018773AB50-0x000000018773ABE0 
	public pb_IntArray[] sharedIndices { get => default; } // 0x000000018773AC40-0x000000018773ACA0 
	public pb_IntArray[] sharedIndicesUV { get => default; } // 0x000000018773ABE0-0x000000018773AC40 
	public int id { get => default; } // 0x000000018773AA40-0x000000018773AAC0 
	public Vector3[] vertices { get => default; } // 0x000000018773AF80-0x000000018773AFE0 
	public Color[] colors { get => default; } // 0x000000018773A6F0-0x000000018773A750 
	public Vector2[] uv { get => default; } // 0x000000018773AEB0-0x000000018773AF10 
	public bool hasUv3 { get => default; } // 0x000000018773A8A0-0x000000018773A970 
	public bool hasUv4 { get => default; } // 0x000000018773A970-0x000000018773AA40 
	public List<Vector4> uv3 { get => default; } // 0x000000018773ADF0-0x000000018773AE50 
	public List<Vector4> uv4 { get => default; } // 0x000000018773AE50-0x000000018773AEB0 
	public int faceCount { get => default; } // 0x000000018773A750-0x000000018773A840 
	public int vertexCount { get => default; } // 0x000000018773AF10-0x000000018773AF80 
	public int triangleCount { get => default; } // 0x000000018773ACA0-0x000000018773ADF0 
	public pb_Face[] SelectedFaces { get => default; } // 0x000000018773A500-0x000000018773A5C0 
	public int SelectedFaceCount { get => default; } // 0x000000018773A490-0x000000018773A500 
	public int[] SelectedTriangles { get => default; } // 0x000000018773A630-0x000000018773A690 
	public int SelectedTriangleCount { get => default; } // 0x000000018773A5C0-0x000000018773A630 
	public pb_Edge[] SelectedEdges { get => default; } // 0x000000018773A430-0x000000018773A490 
	public int SelectedEdgeCount { get => default; } // 0x000000018773A3C0-0x000000018773A430 

	// Events
	public static event Action<pb_Object> onDestroyObject;
	internal static event Action<pb_Object> onElementSelectionChanged;

	// Constructors
	public pb_Object() {} // 0x000000018773A0E0-0x000000018773A1F0

	// Methods
	private void Awake() {} // 0x00000001877332E0-0x0000000187733520
	public static pb_Object InitWithObject(pb_Object pb) => default; // 0x00000001877353A0-0x0000000187735960
	public static pb_Object CreateInstanceWithPoints(Vector3[] vertices) => default; // 0x0000000187733DE0-0x0000000187733F70
	public static pb_Object CreateInstanceWithVerticesFaces(Vector3[] v, pb_Face[] f) => default; // 0x0000000187733F70-0x0000000187734050
	public static pb_Object CreateInstanceWithElements(Vector3[] v, Vector2[] u, Color[] c, pb_Face[] f, pb_IntArray[] si, pb_IntArray[] si_uv) => default; // 0x00000001877336F0-0x0000000187733A30
	public static pb_Object CreateInstanceWithElements(pb_Vertex[] vertices, pb_Face[] faces, pb_IntArray[] si, pb_IntArray[] si_uv) => default; // 0x0000000187733A30-0x0000000187733DE0
	public void Clear() {} // 0x00000001877335E0-0x00000001877336F0
	public Vector3[] GetNormals() => default; // 0x00000001877349A0-0x0000000187734B30
	public pb_IntArray[] GetSharedIndices() => default; // 0x0000000187734D40-0x0000000187734F50
	public pb_IntArray[] GetSharedIndicesUV() => default; // 0x0000000187734B30-0x0000000187734D40
	public void AddToFaceSelection(pb_Face face) {} // 0x0000000187733200-0x00000001877332E0
	public void SetSelectedFaces(IEnumerable<pb_Face> selected) {} // 0x0000000187738A80-0x0000000187738D30
	public void SetSelectedFaces(IEnumerable<int> selected) {} // 0x0000000187738880-0x0000000187738A80
	public void SetSelectedEdges(IEnumerable<pb_Edge> edges) {} // 0x0000000187738720-0x0000000187738880
	public void SetSelectedTriangles(int[] tris) {} // 0x0000000187738D30-0x0000000187738E40
	public void RemoveFromFaceSelectionAtIndex(int index) {} // 0x0000000187737FD0-0x0000000187738060
	public void RemoveFromFaceSelection(pb_Face face) {} // 0x0000000187738060-0x0000000187738140
	public void ClearSelection() {} // 0x0000000187733520-0x00000001877335E0
	public void SetVertices(Vector3[] v) {} // 0x0000000187739570-0x00000001877395D0
	public void SetVertices(IList<pb_Vertex> vertices, bool applyMesh = false /* Metadata: 0x00AC3CB4 */) {} // 0x0000000187739270-0x0000000187739570
	public void SetUV(Vector2[] uvs) {} // 0x0000000187739110-0x0000000187739170
	public void SetFaces(IEnumerable<pb_Face> faces) {} // 0x0000000187738540-0x0000000187738720
	public void SetSharedIndices(pb_IntArray[] si) {} // 0x0000000187738F20-0x0000000187738F80
	public void SetSharedIndices(IEnumerable<KeyValuePair<int, int>> si) {} // 0x0000000187738F80-0x0000000187739000
	public void SetSharedIndicesUV(pb_IntArray[] si) {} // 0x0000000187738EC0-0x0000000187738F20
	public void SetSharedIndicesUV(IEnumerable<KeyValuePair<int, int>> si) {} // 0x0000000187738E40-0x0000000187738EC0
	private void GeometryWithPoints(Vector3[] v) {} // 0x0000000187734050-0x00000001877344E0
	public void GeometryWithVerticesFaces(Vector3[] v, pb_Face[] f) {} // 0x0000000187734770-0x00000001877349A0
	private void GeometryWithVerticesFacesIndices(Vector3[] v, pb_Face[] f, pb_IntArray[] s) {} // 0x00000001877344E0-0x0000000187734770
	public MeshRebuildReason Verify() => default; // 0x0000000187739E10-0x000000018773A0E0
	public void ToMesh() {} // 0x0000000187739A10-0x0000000187739A80
	public void ToMesh(MeshTopology preferredTopology) {} // 0x00000001877395D0-0x0000000187739A10
	public void MakeUnique() {} // 0x0000000187735960-0x0000000187735F10
	public void Refresh(RefreshMask mask = RefreshMask.All | RefreshMask.UV | RefreshMask.Colors | RefreshMask.Normals | RefreshMask.Tangents | RefreshMask.Collisions /* Metadata: 0x00AC3CB5 */) {} // 0x0000000187737F20-0x0000000187737FD0
	public void RefreshCollisions() {} // 0x0000000187736050-0x00000001877369F0
	public int GetUnusedTextureGroup(int i = 1 /* Metadata: 0x00AC3CB7 */) => default; // 0x0000000187735230-0x00000001877353A0
	public int UnusedElementGroup(int i = 1 /* Metadata: 0x00AC3CBB */) => default; // 0x0000000187739CA0-0x0000000187739E10
	public void RefreshUV() {} // 0x0000000187737E70-0x0000000187737F20
	public void GetUVs(int channel, List<Vector4> uvs) {} // 0x0000000187734F50-0x0000000187735230
	public void SetUVs(int channel, List<Vector4> uvs) {} // 0x0000000187739170-0x0000000187739270
	public void RefreshUV(IEnumerable<pb_Face> facesToRefresh) {} // 0x0000000187736DD0-0x0000000187737E70
	public void SetFaceMaterial(pb_Face[] quad, UnityEngine.Material mat) {} // 0x0000000187738440-0x0000000187738540
	public void SetUV2(Vector2[] v) {} // 0x0000000187739060-0x0000000187739110
	public void RefreshColors() {} // 0x00000001877369F0-0x0000000187736BA0
	public void SetColors(Color[] InColors) {} // 0x0000000187738140-0x00000001877382B0
	public void SetFaceColor(pb_Face face, Color color) {} // 0x00000001877382B0-0x0000000187738440
	public void SetTangents(Vector4[] tangents) {} // 0x0000000187739000-0x0000000187739060
	public void RefreshNormals() {} // 0x0000000187736BA0-0x0000000187736CA0
	public void RefreshTangents() {} // 0x0000000187736CA0-0x0000000187736DD0
	public void OnDestroy() {} // 0x0000000187735F10-0x0000000187736050
}

