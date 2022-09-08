/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class QuadrupedsGoundIK : MonoBehaviour // TypeDefIndex: 8547
{
	// Fields
	public bool enable; // 0x18
	public float[] footOffset; // 0x20
	public float moveUpDist; // 0x28
	public float maxDist; // 0x2C
	public bool debugDrawChain; // 0x30
	public bool debugDrawRect; // 0x31
	public Color chainColor; // 0x34
	public float radius; // 0x44
	public float limitScale; // 0x48
	public float hipRotWeight; // 0x4C
	public float hipLiftWeight; // 0x50
	public float maxIKFootPosSpeed; // 0x54
	public float maxIKFootPosAcc; // 0x58
	// [Range] // 0x0000000189927470-0x0000000189927490
	public float dirDamping; // 0x5C
	// [Range] // 0x00000001899A8720-0x00000001899A8740
	public float maxslope; // 0x60
	public FBIKSolverParameter solverParam; // 0x64
	public int raycastLayerMask; // 0x94
	public int frontHipIndex; // 0x98
	public int backHipIndex; // 0x9C
	public bool lockFoot; // 0xA0
	public bool rotateFoot; // 0xA1
	private Animator animator; // 0xA8
	private Transform tf; // 0xB0
	private Matrix4x4 invDeltaMat; // 0xB8
	private QuadrupedIKState ikstate; // 0xF8
	private Vector3[] tempEffectors; // 0x100
	private Vector3[] animEffectorPos; // 0x108
	private float[] animHeightOffsetToGround; // 0x110
	private bool effectorsInitialized; // 0x118

	// Constructors
	public QuadrupedsGoundIK() {} // 0x000000018601C130-0x000000018601C2C0

	// Methods
	private void Start() {} // 0x000000018601BED0-0x000000018601C000
	public void Reset() {} // 0x000000018601A8F0-0x000000018601AA60
	private void UpdateParameters() {} // 0x000000018601C000-0x000000018601C130
	private void OnAnimatorIK(int layerIndex) {} // 0x0000000186019FC0-0x000000018601A8F0
	private void DoFootRaycast(Matrix4x4 matNoHipAdjust, float[] liftHeight, Vector3[] hitnormals, Vector3[] hitpositions, Vector3[] foots, int validFootCount, int layerMask) {} // 0x0000000186018BB0-0x00000001860193B0
	private void SolveAnklesRotations(Vector3[] hitnormals) {} // 0x000000018601AA60-0x000000018601AE60
	private void SolveHipPosition(Vector3[] hitnormals, Vector3[] hitpos, float[] footliftHeights) {} // 0x000000018601AE60-0x000000018601BED0
	private void LateUpdate() {} // 0x00000001860193B0-0x0000000186019FC0
}

