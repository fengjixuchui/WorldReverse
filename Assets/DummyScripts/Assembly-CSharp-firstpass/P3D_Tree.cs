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

public class P3D_Tree // TypeDefIndex: 9439
{
	// Fields
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private Mesh mesh; // 0x10
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private int vertexCount; // 0x18
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private int subMeshIndex; // 0x1C
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private List<P3D_Node> nodes; // 0x20
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private List<P3D_Triangle> triangles; // 0x28
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private List<P3D_Vertex> vertices; // 0x30
	private static List<P3D_Triangle> potentials; // 0x00
	private static List<P3D_Result> results; // 0x08
	private static P3D_Tree tempInstance; // 0x10

	// Properties
	public List<P3D_Node> DebugNodes { get => default; } // 0x0000000187241000-0x0000000187241060 
	public List<P3D_Triangle> DebugTriangles { get => default; } // 0x0000000187241060-0x00000001872410C0 
	public List<P3D_Vertex> Vertices { get => default; } // 0x0000000187241240-0x00000001872412D0 
	public static P3D_Tree TempInstance { get => default; } // 0x0000000187241140-0x0000000187241240 
	public bool IsReady { get => default; } // 0x00000001872410C0-0x0000000187241140 

	// Constructors
	public P3D_Tree() {} // 0x0000000187240F30-0x0000000187241000
	static P3D_Tree() {} // 0x0000000187240E70-0x0000000187240F30

	// Methods
	public void Clear() {} // 0x000000018723CFA0-0x000000018723D1F0
	public void ClearResults() {} // 0x000000018723CDF0-0x000000018723CFA0
	public void SetMesh(Mesh newMesh, int newSubMeshIndex = 0 /* Metadata: 0x00AE5920 */, bool forceUpdate = false /* Metadata: 0x00AE5924 */) {} // 0x00000001872403C0-0x0000000187240520
	public void SetMesh(GameObject gameObject, int subMeshIndex = 0 /* Metadata: 0x00AE5925 */, bool forceUpdate = false /* Metadata: 0x00AE5929 */) {} // 0x0000000187240280-0x00000001872403C0
	public P3D_Result FindNearest(Vector3 point, float maxDistance) => default; // 0x000000018723F1A0-0x000000018723F420
	public P3D_Result FindBetweenNearest(Vector3 startPoint, Vector3 endPoint) => default; // 0x000000018723DFD0-0x000000018723E250
	public List<P3D_Result> FindBetweenAll(Vector3 startPoint, Vector3 endPoint) => default; // 0x000000018723DD60-0x000000018723DFD0
	public P3D_Result FindPerpendicularNearest(Vector3 point, float maxDistance) => default; // 0x000000018723F6C0-0x000000018723F950
	public List<P3D_Result> FindPerpendicularAll(Vector3 point, float maxDistance) => default; // 0x000000018723F420-0x000000018723F6C0
	public List<P3D_Result> FindFrontInSphereAll(Vector3 point, float radius, Vector3 front) => default; // 0x000000018723E550-0x000000018723E850
	public HashSet<P3D_Vertex> FindNearestInAreaAll(Transform modelToWorld, Camera camera, Vector2 screenPoint, float maxDistance) => default; // 0x000000018723EE70-0x000000018723F1A0
	public HashSet<P3D_Vertex> FindInAreaAll(Transform modelToWorld, Camera camera, Rect screenArea) => default; // 0x000000018723EC20-0x000000018723EE70
	public HashSet<P3D_Vertex> FindFrontNearestInArea(Transform modelToWorld, Camera camera, Vector2 screenPoint, float maxDistance, Vector3 modelFront) => default; // 0x000000018723E850-0x000000018723EC20
	public HashSet<P3D_Vertex> FindFrontInAreaAll(Transform modelToWorld, Camera camera, Rect screenArea, Vector3 modelFront) => default; // 0x000000018723E250-0x000000018723E550
	private void BeginSearchDistance(Vector3 point, float maxDistanceSqr) {} // 0x000000018723CD30-0x000000018723CDF0
	private void SearchDistance(P3D_Node node, Vector3 point, float maxDistanceSqr) {} // 0x000000018723FF60-0x00000001872400E0
	private void BeginSearchBetween(Vector3 startPoint, Vector3 endPoint) {} // 0x000000018723CB90-0x000000018723CD30
	private void SearchBetween(P3D_Node node, Ray ray, float maxDistance) {} // 0x000000018723FDC0-0x000000018723FF60
	private void SearchInSphere(P3D_Node node, Vector3 point, float radius) {} // 0x00000001872400E0-0x0000000187240280
	private void AddToPotentials(P3D_Node node) {} // 0x000000018723C7E0-0x000000018723C8E0
	private void AddToResults(P3D_Triangle triangle, Vector3 weights, float distance01) {} // 0x000000018723CA30-0x000000018723CB90
	private void AddToResults(P3D_Triangle triangle, Vector3 distances01) {} // 0x000000018723C8E0-0x000000018723CA30
	private P3D_Result GetResult(P3D_Triangle triangle, Vector3 weights, float distance01) => default; // 0x000000018723F950-0x000000018723FA60
	private void ExtractTriangles() {} // 0x000000018723D2D0-0x000000018723D960
	private void ExtractVertices() {} // 0x000000018723D960-0x000000018723DD60
	private void Pack(Dictionary<int, P3D_Vertex> dictionary, int index, Vector3 position, Vector3 triangleNormal) {} // 0x000000018723FA60-0x000000018723FBF0
	private void ConstructNodes() {} // 0x000000018723D1F0-0x000000018723D2D0
	private void Pack(P3D_Node node, int min, int max) {} // 0x000000018723FBF0-0x000000018723FDC0
	private void SortTriangles(int minIndex, int maxIndex) {} // 0x00000001872405F0-0x0000000187240E70
	private void SortTriangle(P3D_Triangle triangle, ref int minIndex, ref int maxIndex, bool abovePivot) {} // 0x0000000187240520-0x00000001872405F0
}

