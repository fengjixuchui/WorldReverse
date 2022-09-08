/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class LODSwitcher : MonoBehaviour // TypeDefIndex: 10067
{
	// Fields
	public Mesh[] lodMeshes; // 0x18
	public GameObject[] lodGameObjects; // 0x20
	public float[] lodScreenSizes; // 0x28
	public float deactivateAtDistance; // 0x30
	public Camera customCamera; // 0x38
	private MeshFilter meshFilter; // 0x40
	private SkinnedMeshRenderer skinnedMeshRenderer; // 0x48
	private Vector3 centerOffset; // 0x50
	private float pixelsPerMeter; // 0x5C
	private float objectSize; // 0x60
	private int fixedLODLevel; // 0x64
	private int lodLevel; // 0x68
	private int frameOffset; // 0x6C
	private int frameInterval; // 0x70

	// Constructors
	public LODSwitcher() {} // 0x0000000186D1F5B0-0x0000000186D1F630

	// Methods
	private void Start() {} // 0x0000000186D1F130-0x0000000186D1F530
	public void ComputeDimensions() {} // 0x0000000186D1DA10-0x0000000186D1DF10
	public void SetCustomCamera(Camera aCamera) {} // 0x0000000186D1E880-0x0000000186D1E900
	public void SetFixedLODLevel(int aLevel) {} // 0x0000000186D1E900-0x0000000186D1EA00
	public void ReleaseFixedLODLevel() {} // 0x0000000186D1E5B0-0x0000000186D1E610
	public int GetLODLevel() => default; // 0x0000000186D1E010-0x0000000186D1E070
	public int MaxLODLevel() => default; // 0x0000000186D1E200-0x0000000186D1E270
	public Mesh GetMesh(int aLevel) => default; // 0x0000000186D1E160-0x0000000186D1E200
	public void SetMesh(Mesh aMesh, int aLevel) {} // 0x0000000186D1ED80-0x0000000186D1EF20
	public void SetRelativeScreenSize(float aValue, int aLevel) {} // 0x0000000186D1EF20-0x0000000186D1F130
	private void Update() {} // 0x0000000186D1F530-0x0000000186D1F5B0
	public Vector3 NearestCameraPositionForLOD(int aLevel) => default; // 0x0000000186D1E270-0x0000000186D1E5B0
	public float ScreenPortion() => default; // 0x0000000186D1E610-0x0000000186D1E880
	private void ComputeLODLevel() {} // 0x0000000186D1DF10-0x0000000186D1E010
	private void GetMeshFilter() {} // 0x0000000186D1E070-0x0000000186D1E160
	public void SetLODLevel(int newLodLevel) {} // 0x0000000186D1EA00-0x0000000186D1ED80
}

