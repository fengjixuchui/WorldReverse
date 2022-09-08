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

public sealed class VCCameraCharacterLowQualityShadow : VCBase // TypeDefIndex: 11839
{
	// Fields
	public float MaxRange; // 0x108
	private static readonly int MAX_ENTITY_COUNT; // 0x00
	private static readonly float MAX_HEIGHT; // 0x04
	private static readonly float DELTA_HEIGHT; // 0x08
	private static readonly float BOUND_SCALE; // 0x0C
	private Camera _mainCamera; // 0x110
	private Vector3 _camPos; // 0x118
	private Matrix4x4[] _obj2WorldMatries; // 0x128
	private Matrix4x4 _localCubeMatrix; // 0x130
	private Matrix4x4 _localToWorldMatrix; // 0x170
	private int _curCount; // 0x1B0
	private Mesh _cubeMesh; // 0x1B8
	private UnityEngine.Material _cubeMaterial; // 0x1C0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001896E1A00-0x00000001896E1A20 */ get => default; } // 0x000000018208F5E0-0x000000018208F680 

	// Constructors
	public VCCameraCharacterLowQualityShadow() {} // 0x000000018208F450-0x000000018208F5E0
	static VCCameraCharacterLowQualityShadow() {} // 0x000000018208F3D0-0x000000018208F450

	// Methods
	// [XID] // 0x00000001896E8F50-0x00000001896E8F70
	public override void OnEnable() {} // 0x000000018208F320-0x000000018208F3D0
	// [XID] // 0x0000000189AA31A0-0x0000000189AA31C0
	public override void OnDisable() {} // 0x000000018208F270-0x000000018208F320
	// [XID] // 0x00000001896F7A30-0x00000001896F7A50
	protected override void LateTick(float inDeltaTime) {} // 0x000000018208EC00-0x000000018208F200
	// [XID] // 0x0000000189A942F0-0x0000000189A94310
	private void AddEntityToShadow(BaseEntity entity, bool checkStatus = false /* Metadata: 0x00AEACED */) {} // 0x000000018208E740-0x000000018208EC00
}

