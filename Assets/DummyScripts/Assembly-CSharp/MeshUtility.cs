/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class MeshUtility // TypeDefIndex: 31585
{
	// Fields
	private static GameObject _drawParent; // 0x00

	// Constructors
	static MeshUtility() {} // 0x0000000181FA8C70-0x0000000181FA8CD0

	// Methods
	// [XID] // 0x00000001895F4730-0x00000001895F4750
	public static GameObject DrawSphere(Vector3 center, float radius, Color color, float duration = 0f /* Metadata: 0x00B13358 */) => default; // 0x0000000181FA63C0-0x0000000181FA67D0
	// [XID] // 0x00000001895FBF20-0x00000001895FBF40
	public static GameObject DrawCube(Vector3 center, Quaternion rotation, Vector3 size, Color color, float duration = 0f /* Metadata: 0x00B1335C */) => default; // 0x0000000181FA4DF0-0x0000000181FA5240
	// [XID] // 0x0000000189603940-0x0000000189603960
	public static GameObject DrawAttachedCube(Transform parentTrans, Vector3 size, bool bottomCenter, Color color, float duration = 0f /* Metadata: 0x00B13360 */) => default; // 0x0000000181FA45A0-0x0000000181FA4AF0
	// [XID] // 0x000000018960B2A0-0x000000018960B2C0
	private static GameObject GetMeshGameObject(Color color) => default; // 0x0000000181FA89C0-0x0000000181FA8BB0
	// [XID] // 0x0000000189612690-0x00000001896126B0
	public static GameObject DrawSector(Vector3 center, Vector3 direction, float angle, float radius, Color color, float duration = 0f /* Metadata: 0x00B13364 */) => default; // 0x0000000181FA4AF0-0x0000000181FA4DF0
	// [XID] // 0x00000001896A6A60-0x00000001896A6A80
	public static List<Vector3> GetSectorPosList(Vector3 center, Vector3 direction, float angle, float radius) => default; // 0x0000000181FA7060-0x0000000181FA7510
	// [XID] // 0x00000001896214D0-0x00000001896214F0
	private static Mesh DrawSectorMesh(Vector3 center, Vector3 direction, float angle, float radius) => default; // 0x0000000181FA67D0-0x0000000181FA7060
	// [XID] // 0x0000000189628E20-0x0000000189628E40
	public static GameObject DrawCircle(Vector3 center, float radius, float height, Color color, float duration = 0f /* Metadata: 0x00B13368 */) => default; // 0x0000000181FA8560-0x0000000181FA89C0
	// [XID] // 0x00000001896307A0-0x00000001896307C0
	public static GameObject DrawPlane(Vector3[] vertices, Color color, float duration = 0f /* Metadata: 0x00B1336C */) => default; // 0x0000000181FA3D60-0x0000000181FA4120
	// [XID] // 0x0000000189638200-0x0000000189638220
	public static Matrix4x4 GetYAxisMatrix(float angle) => default; // 0x0000000181FA7D10-0x0000000181FA7EC0
	// [XID] // 0x000000018963F620-0x000000018963F640
	public static Matrix4x4 GetZAxisMatrix(float angle) => default; // 0x0000000181FA4120-0x0000000181FA42D0
	// [XID] // 0x0000000189646D70-0x0000000189646D90
	private static Mesh DrawPlaneMesh(Vector3[] vertices) => default; // 0x0000000181FA42D0-0x0000000181FA45A0
	// [XID] // 0x000000018964E530-0x000000018964E550
	public static List<GameObject> Draw6DirectionGrid(int width, int height, UnityEngine.Material meshMaterial, float gridSize, float duration = 0f /* Metadata: 0x00B13370 */) => default; // 0x0000000181FA8150-0x0000000181FA8560
	// [XID] // 0x0000000189655D60-0x0000000189655D80
	public static GameObject Draw6Edge(UnityEngine.Material meshMaterial, float gridSize, float duration = 0f /* Metadata: 0x00B13374 */) => default; // 0x0000000181FA5E20-0x0000000181FA6250
	// [XID] // 0x000000018965D520-0x000000018965D540
	public static Mesh Draw6DirectionMesh(float gridSize) => default; // 0x0000000181FA7510-0x0000000181FA7D10
	// [XID] // 0x0000000189664C20-0x0000000189664C40
	private static void SetParent(GameObject go) {} // 0x0000000181FA7EC0-0x0000000181FA8090
	// [XID] // 0x000000018966C1B0-0x000000018966C1D0
	public static void ClearAllDrawObjs() {} // 0x0000000181FA6250-0x0000000181FA63C0
	// [IDTag] // 0x0000000189674070-0x00000001896740B0
	// [XID] // 0x0000000189674070-0x00000001896740B0
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration = 0f /* Metadata: 0x00B13378 */, float width = 0.01f /* Metadata: 0x00B1337C */) {} // 0x0000000181FA59C0-0x0000000181FA5E20
	// [IDTag] // 0x000000018967E630-0x000000018967E670
	// [XID] // 0x000000018967E630-0x000000018967E670
	public static void DrawLine(List<Vector3> posList, Color color, float duration = 0f /* Metadata: 0x00B13380 */, float width = 0.01f /* Metadata: 0x00B13384 */) {} // 0x0000000181FA5540-0x0000000181FA59C0
	// [XID] // 0x0000000189689370-0x0000000189689390
	private static void CancelDraw(GameObject go) {} // 0x0000000181FA8090-0x0000000181FA8150
	// [XID] // 0x0000000189691030-0x0000000189691050
	public static List<Vector3> GetCirclePosList(Vector3 centerPoint, float radius, Vector3 axis, int stepAngle = 1 /* Metadata: 0x00B13388 */) => default; // 0x0000000181FA5240-0x0000000181FA5540
	// [XID] // 0x0000000189698770-0x0000000189698790
	private static Shader GetShader(bool transparent) => default; // 0x0000000181FA8BB0-0x0000000181FA8C70
}

