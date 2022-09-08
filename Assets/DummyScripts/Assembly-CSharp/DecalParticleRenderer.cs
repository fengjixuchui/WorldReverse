/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[ExecuteInEditMode] // 0x0000000189BD9060-0x0000000189BD90D0
// [RequireComponent] // 0x0000000189BD9060-0x0000000189BD90D0
public class DecalParticleRenderer : MonoBehaviour // TypeDefIndex: 26511
{
	// Fields
	public Mesh mesh; // 0x18
	public Mesh cylinderMesh; // 0x20
	public MeshType meshType; // 0x28
	private ParticleSystemRenderer _psr; // 0x30
	private MaterialPropertyBlock properties; // 0x38
	public bool setEulerAngleOnce; // 0x40
	private float lastEulerAnglesY; // 0x44

	// Properties
	private Mesh _mesh { get => default; } // 0x000000018339D9F0-0x000000018339DA60 

	// Nested types
	public enum MeshType // TypeDefIndex: 26512
	{
		Cube = 0,
		Cylinder = 1
	}

	private static class ShaderIDs // TypeDefIndex: 26513
	{
		// Fields
		public static readonly int eulerAngleY; // 0x00

		// Constructors
		static ShaderIDs() {} // 0x000000018339DB60-0x000000018339DBD0
	}

	// Constructors
	public DecalParticleRenderer() {} // 0x000000018339D980-0x000000018339D9F0

	// Methods
	private void Start() {} // 0x000000018339D5B0-0x000000018339D820
	public void Reset() {} // 0x000000018339D4F0-0x000000018339D5B0
	private void Update() {} // 0x000000018339D820-0x000000018339D980
}

