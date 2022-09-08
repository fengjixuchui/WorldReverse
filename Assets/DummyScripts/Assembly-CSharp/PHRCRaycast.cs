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

public sealed class PHRCRaycast : ProjectedHeightmapResultCache<RaycastHeightData> // TypeDefIndex: 14701
{
	// Fields
	private const uint RAYCAST_GRID_COUNT = 7; // Metadata: 0x00AEBDB4
	private const int RAYCAST_GRID_OFFSET = -3; // Metadata: 0x00AEBDB8
	private const float PROJSTEPSCALE = 1.1f; // Metadata: 0x00AEBDBC
	private float _projectStep; // 0x60
	private float _projectPullback; // 0x64
	private float _projectDepth; // 0x68
	private float _fullprojectDirtyY; // 0x6C

	// Constructors
	public PHRCRaycast() {} // 0x00000001834922E0-0x0000000183492350

	// Methods
	// [XID] // 0x000000018986D4B0-0x000000018986D4D0
	public override void PreInit(Vector3 pos, ProjectedHeightmapProcessChain inOwner) {} // 0x0000000183491A40-0x0000000183491B60
	// [XID] // 0x0000000189874910-0x0000000189874930
	protected override bool ShouldFullProjectByYChange(float inY) => default; // 0x0000000183491C00-0x0000000183491CC0
	// [XID] // 0x000000018987C4C0-0x000000018987C4E0
	protected override void InternalFullProject(Vector3 pos, out Vector2 oStep, out uint oSizeX, out uint oSizeY) {
		oStep = default;
		oSizeX = default;
		oSizeY = default;
	} // 0x0000000183491880-0x0000000183491A40
	// [XID] // 0x00000001898835B0-0x00000001898835D0
	protected override void InternalProjectAt(Vector3 pos, int i, int j) {} // 0x0000000183491CC0-0x00000001834922E0
	// [XID] // 0x000000018988ADB0-0x000000018988ADD0
	protected override void InternalMergeHeightmap() {} // 0x0000000183491220-0x0000000183491800
	// [XID] // 0x0000000189892160-0x0000000189892180
	protected override bool IsInValid() => default; // 0x0000000183491180-0x0000000183491220
}

