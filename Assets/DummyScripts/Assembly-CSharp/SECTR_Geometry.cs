/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class SECTR_Geometry // TypeDefIndex: 31942
{
	// Fields
	public const float kVERTEX_EPSILON = 0.001f; // Metadata: 0x00B13A4E
	public const float kBOUNDS_CHEAT = 0.01f; // Metadata: 0x00B13A52

	// Methods
	public static Bounds ComputeBounds(Light light) => default; // 0x0000000181B56990-0x0000000181B57060
	public static Bounds ComputeBounds(Terrain terrain) => default; // 0x0000000181B56710-0x0000000181B56990
	public static bool FrustumIntersectsBounds(Bounds bounds, List<Plane> frustum, int inMask, out int outMask) {
		outMask = default;
		return default;
	} // 0x0000000181B573A0-0x0000000181B576E0
	public static bool FrustumContainsBounds(Bounds bounds, List<Plane> frustum) => default; // 0x0000000181B57060-0x0000000181B573A0
	public static bool BoundsContainsBounds(Bounds container, Bounds contained) => default; // 0x0000000181B56250-0x0000000181B56330
	public static bool BoundsIntersectsSphere(Bounds bounds, Vector3 sphereCenter, float sphereRadius) => default; // 0x0000000181B56330-0x0000000181B564E0
	public static Bounds ProjectBounds(Bounds bounds, Vector3 projection) => default; // 0x0000000181B57B40-0x0000000181B57CE0
	public static bool IsPointInFrontOfPlane(Vector3 position, Vector3 center, Vector3 normal) => default; // 0x0000000181B576E0-0x0000000181B57820
	public static bool IsPolygonConvex(Vector3[] verts) => default; // 0x0000000181B57820-0x0000000181B57B40
	public static int CompareVectorsCW(Vector3 a, Vector3 b, Vector3 centroid, Vector3 normal) => default; // 0x0000000181B564E0-0x0000000181B56710
}

