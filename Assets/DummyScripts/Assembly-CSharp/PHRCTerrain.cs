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

public sealed class PHRCTerrain : ProjectedHeightmapResultCache<Vector3> // TypeDefIndex: 14699
{
	// Fields
	public TerrainCollider terrainCollider; // 0x60
	private TerrainData terrainData; // 0x68
	private int resolution; // 0x70
	private Vector3 _terrainMin; // 0x74
	private Vector3 _terrainMax; // 0x80
	private float _originalTerrainHeight; // 0x8C
	private const uint TERRAIN_GRID_COUNT = 5; // Metadata: 0x00AEBDA8
	private const int TERRAIN_HEIGHTDATA_OFFSET = -2; // Metadata: 0x00AEBDAC
	private const uint TERRAINRESULTKEEPFRAMECOUNT = 10; // Metadata: 0x00AEBDB0

	// Constructors
	public PHRCTerrain() {} // Dummy constructor
	public PHRCTerrain(TerrainCollider inTC) {} // 0x0000000183EDBCC0-0x0000000183EDBE80

	// Methods
	// [XID] // 0x0000000189850080-0x00000001898500A0
	protected override void InternalFullProject(Vector3 pos, out Vector2 oStep, out uint oSizeX, out uint oSizeY) {
		oStep = default;
		oSizeX = default;
		oSizeY = default;
	} // 0x0000000183EDB6F0-0x0000000183EDB920
	// [XID] // 0x0000000189857340-0x0000000189857360
	protected override void InternalProjectAt(Vector3 pos, int i, int j) {} // 0x0000000183EDB920-0x0000000183EDBCC0
	// [XID] // 0x000000018985E500-0x000000018985E520
	protected override void InternalMergeHeightmap() {} // 0x0000000183EDB020-0x0000000183EDB6F0
	// [XID] // 0x0000000189865DF0-0x0000000189865E10
	protected override bool IsInValid() => default; // 0x0000000183EDAF20-0x0000000183EDB020
}

