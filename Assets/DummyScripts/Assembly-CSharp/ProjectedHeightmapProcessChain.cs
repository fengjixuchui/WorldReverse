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

public class ProjectedHeightmapProcessChain // TypeDefIndex: 14702
{
	// Fields
	public ProjectedHeightmap heightmap; // 0x10
	private List<PHRCTerrain> _terrainResults; // 0x18
	private PHRCRaycast _raycastResult; // 0x20
	private Vector3 _currentPos; // 0x28
	private float _radius; // 0x34
	private float _height; // 0x38
	public float _boxDepth; // 0x3C
	public float _boxWidth; // 0x40
	private float _boxLength; // 0x44
	public bool _bDirty; // 0x48
	public bool _bForceMergeInUnityThread; // 0x49
	public Matrix4x4 mWorldToUnifiedBox; // 0x4C
	private const int SAMPLE_RATE = 4; // Metadata: 0x00AEBDC0
	private const float SCAN_BOX_RADIUS_SCALE = 1f; // Metadata: 0x00AEBDC4
	private const float SCAN_BOX_HEIGHT_SCALE = 0.5f; // Metadata: 0x00AEBDC8
	private const float SCAN_BOX_DEPTH_RATIO = 2f; // Metadata: 0x00AEBDCC
	private const float SCAN_BOX_WIDTH_RATIO = 2f; // Metadata: 0x00AEBDD0
	private const float SCAN_BOX_LENGTH_RATIO = 2f; // Metadata: 0x00AEBDD4
	private static Collider[] _overlappedColliderBuffer; // 0x00
	private HeightmapPlugin.OncePerFrameMultivariateCorrelationCoefficient _mcc; // 0x90
	public float _mccValue; // 0x98
	private ComputeThreadTaskHeightmap _computeThread; // 0xA0
	private Vector3 _projectPos; // 0xA8
	private Vector3 _boxForward; // 0xB4
	private Vector3 _boxUp; // 0xC0
	private Vector3 _boxRight; // 0xCC
	private Quaternion _boxRotation; // 0xD8
	private Transform _bindingTransform; // 0xE8
	public Plane linearRegressionPlane; // 0xF0
	public Vector3 linearRegressionPlaneNormal; // 0x100
	private static bool bForceDirty; // 0x08

	// Properties
	public bool bActive { /* [XID] */ /* 0x0000000189899BF0-0x0000000189899C10 */ get => default; } // 0x00000001812981C0-0x0000000181298290 

	// Constructors
	public ProjectedHeightmapProcessChain() {} // Dummy constructor
	public ProjectedHeightmapProcessChain(Transform inTrans, float inRadius, float inHeight) {} // 0x0000000181298910-0x0000000181298C80
	static ProjectedHeightmapProcessChain() {} // 0x00000001812988B0-0x0000000181298910

	// Methods
	// [XID] // 0x00000001898A0D10-0x00000001898A0D30
	public void Destroy() {} // 0x0000000181297F70-0x0000000181298020
	// [XID] // 0x00000001897BE280-0x00000001897BE2A0
	public void MergeHeightmapInComputeThread() {} // 0x00000001812975B0-0x0000000181297CA0
	// [IDTag] // 0x00000001898AFE70-0x00000001898AFEB0
	// [XID] // 0x00000001898AFE70-0x00000001898AFEB0
	public float GetSmoothedGroundHeight(Vector3 pos) => default; // 0x00000001812983C0-0x00000001812984A0
	// [IDTag] // 0x00000001898BA9E0-0x00000001898BAA20
	// [XID] // 0x00000001898BA9E0-0x00000001898BAA20
	public float GetSmoothedGroundHeight(float x, float z) => default; // 0x00000001812984A0-0x0000000181298580
	// [XID] // 0x00000001897A6C20-0x00000001897A6C40
	private PHRCTerrain FindPHRCTerrain(TerrainCollider inTC) => default; // 0x0000000181298020-0x00000001812981C0
	// [XID] // 0x00000001897AE470-0x00000001897AE490
	private PHRCTerrain AddTerrainResultCache(TerrainCollider inTC) => default; // 0x0000000181298290-0x00000001812983C0
	// [XID] // 0x0000000189775030-0x0000000189775050
	public void Project(Transform trans, bool bForceRescan) {} // 0x0000000181298580-0x00000001812988B0
	// [XID] // 0x00000001898DB350-0x00000001898DB370
	private void ProjectByColliders(Vector3 pos, int hitCount, bool bForceRescan) {} // 0x0000000181297CA0-0x0000000181297F70
}

