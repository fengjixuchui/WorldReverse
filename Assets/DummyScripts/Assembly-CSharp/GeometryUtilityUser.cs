/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class GeometryUtilityUser // TypeDefIndex: 31546
{
	// Fields
	private static float[] RootVector; // 0x00
	private static float[] ComVector; // 0x08

	// Nested types
	private enum EPlaneSide // TypeDefIndex: 31547
	{
		Left = 0,
		Right = 1,
		Bottom = 2,
		Top = 3,
		Near = 4,
		Far = 5
	}

	// Constructors
	static GeometryUtilityUser() {} // 0x0000000182E66D60-0x0000000182E66E10

	// Methods
	// [IDTag] // 0x0000000189952910-0x0000000189952950
	// [XID] // 0x0000000189952910-0x0000000189952950
	public static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, ref Plane[] OutPlanes) {} // 0x0000000182E65B50-0x0000000182E66B70
	// [IDTag] // 0x000000018995CFE0-0x000000018995D020
	// [XID] // 0x000000018995CFE0-0x000000018995D020
	public static void CalculateFrustumPlanes(Camera InCamera, ref Plane[] OutPlanes) {} // 0x0000000182E649F0-0x0000000182E65B50
	// [XID] // 0x00000001899679B0-0x00000001899679D0
	private static void CalcPlane(ref Plane InPlane, float InA, float InB, float InC, float InDistance) {} // 0x0000000182E66B70-0x0000000182E66D60
	// [XID] // 0x000000018996EB30-0x000000018996EB50
	public static bool ContainsSphere(Vector3 center, float radius, Plane[] frustumPlanes) => default; // 0x0000000182E64790-0x0000000182E649F0
}

