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

public static class HeightmapProjection // TypeDefIndex: 14696
{
	// Fields
	private const int DEFAULT_COLLIDER_BUFFER_LENGTH = 8; // Metadata: 0x00AEBDA0
	private const int DEFAULT_VERTICE_BUFFER_LENGTH = 128; // Metadata: 0x00AEBDA4
	private static readonly HashSet<int> _processedSamplePoint; // 0x00
	private static Collider[] _overlappedColliderBuffer; // 0x08

	// Properties
	public static bool debugDrawOriginalTris { get; set; } // 0x0000000184A75460-0x0000000184A754F0 0x0000000184A77210-0x0000000184A772A0
	public static bool debugDrawClippedTris { get; set; } // 0x0000000184A75B70-0x0000000184A75C00 0x0000000184A77990-0x0000000184A77A20
	private static int _defaultLayerMask { /* [XID] */ /* 0x00000001897F6D40-0x00000001897F6D60 */ get; } // 0x0000000184A75C00-0x0000000184A75CC0 

	// Constructors
	static HeightmapProjection() {} // 0x0000000184A77A20-0x0000000184A77AC0

	// Methods
	// [XID] // 0x00000001897FE380-0x00000001897FE3A0
	public static void Project(Vector3 start, Vector3 forward, Vector3 up, float width, float length, float depth, Bounds enclosingCubeOfInterest, float raycastPullBack, ProjectedHeightmap onto, bool useCustomLayerMask = false /* Metadata: 0x00AEBD9B */, int customLayerMask = 0 /* Metadata: 0x00AEBD9C */) {} // 0x0000000184A76520-0x0000000184A77100
	// [XID] // 0x0000000189805AB0-0x0000000189805AD0
	private static void EnsureColliderBuffer() {} // 0x0000000184A77100-0x0000000184A77210
	// [XID] // 0x000000018980D2E0-0x000000018980D300
	private static void EnsureColliderBufferCapacity(int size) {} // 0x0000000184A75240-0x0000000184A75370
	// [XID] // 0x00000001898149D0-0x00000001898149F0
	private static int MostSignificantBitOf(int value) => default; // 0x0000000184A75370-0x0000000184A75460
	// [XID] // 0x000000018981C4E0-0x000000018981C500
	private static void AddTerrainColliderTriangles(List<Vector3> vertices, TerrainCollider collider, Bounds enclosingCube) {} // 0x0000000184A772A0-0x0000000184A77990
	// [XID] // 0x0000000189823A20-0x0000000189823A40
	private static void DetectHeightByRaycast(float raycastDepth, Vector3 raycastPullBack, Matrix4x4 mWorldToUnifiedBox, Matrix4x4 mUnifiedBoxToWorld, ProjectedHeightmap heightmap, HashSet<int> skipSet, int layerMask) {} // 0x0000000184A75630-0x0000000184A75B70
	// [XID] // 0x000000018982B350-0x000000018982B370
	private static void FindOverlappingSampleRegion(Matrix4x4 mWorldToUnifiedBox, Collider collider, ProjectedHeightmap heightmap, out int mMin, out int mMax, out int nMin, out int nMax) {
		mMin = default;
		mMax = default;
		nMin = default;
		nMax = default;
	} // 0x0000000184A76290-0x0000000184A76520
	// [XID] // 0x0000000189832750-0x0000000189832770
	private static void FindOverlappingLocalRegion(Bounds worldBounds, Matrix4x4 mWorldToUnifiedBox, out float localXMin, out float localXMax, out float localYMin, out float localYMax) {
		localXMin = default;
		localXMax = default;
		localYMin = default;
		localYMax = default;
	} // 0x0000000184A75CC0-0x0000000184A76290
	// [XID] // 0x0000000189839DB0-0x0000000189839DD0
	private static void ExtendIfBeyond(Vector3 v, ref float xMin, ref float xMax, ref float yMin, ref float yMax) {} // 0x0000000184A754F0-0x0000000184A75630
}

