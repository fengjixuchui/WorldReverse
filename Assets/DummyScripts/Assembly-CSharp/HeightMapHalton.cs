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

public class HeightMapHalton // TypeDefIndex: 14695
{
	// Fields
	private int _pointNumber; // 0x10
	private const int MAX_FACE_NUMBER = 15; // Metadata: 0x00AEBD93
	private const float FACE_NORMAL_DIFF_THRESHOLD = 0.05f; // Metadata: 0x00AEBD97
	private Vector2[] _halton; // 0x18
	private Vector2[] _realXZPos; // 0x20
	private Vector2[] _starRayRealPosMultiplier; // 0x28
	private float[] _starRayDist; // 0x30
	private float[] _distances; // 0x38
	private Vector3[] _normals; // 0x40
	private Vector3[] _hitpoints; // 0x48
	private int[] _faceNormalIndex; // 0x50
	private RaycastHit hitInfo; // 0x58
	private Ray ray; // 0x98
	private Matrix4x4 boxToWorld; // 0xB0
	private float _starRayDepth; // 0xF0
	private bool[] _starRayMask; // 0xF8
	private Vector3 _right; // 0x100

	// Constructors
	public HeightMapHalton() {} // Dummy constructor
	public HeightMapHalton(int pointNumber, float starRayDepth, float range) {} // 0x00000001813F6CF0-0x00000001813F73F0

	// Methods
	// [XID] // 0x000000018978E3C0-0x000000018978E3E0
	public void ResetStayRayMask() {} // 0x00000001813F5710-0x00000001813F57D0
	// [XID] // 0x00000001898DD070-0x00000001898DD090
	public void Project(Vector3 targetPosition, Vector3 direction, Vector3 up, float depth, int layerMask) {} // 0x00000001813F59C0-0x00000001813F6560
	// [XID] // 0x000000018979DDF0-0x000000018979DE10
	private float GetHaltonValue(int index, int radix) => default; // 0x00000001813F5600-0x00000001813F5710
	// [XID] // 0x00000001897A52E0-0x00000001897A5300
	private Vector2 GenerateHaltonOffset(int index) => default; // 0x00000001813F58B0-0x00000001813F59C0
	// [XID] // 0x00000001897AC8E0-0x00000001897AC900
	public Vector3 GetVertexNormal(Vector3 position) => default; // 0x00000001813F4F70-0x00000001813F5600
	// [XID] // 0x00000001897B46C0-0x00000001897B46E0
	private float getWeight(float dist) => default; // 0x00000001813F57D0-0x00000001813F58B0
	// [XID] // 0x00000001897BC5F0-0x00000001897BC610
	public void LinearRegression(out Plane plane) {
		plane = default;
	} // 0x00000001813F6560-0x00000001813F6CF0
}

