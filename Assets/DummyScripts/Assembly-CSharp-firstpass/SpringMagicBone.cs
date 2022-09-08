/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class SpringMagicBone : MonoBehaviour // TypeDefIndex: 9854
{
	// Fields
	// [Header] // 0x0000000189AD1FC0-0x0000000189AD2040
	// [Range] // 0x0000000189AD1FC0-0x0000000189AD2040
	// [Tooltip] // 0x0000000189AD1FC0-0x0000000189AD2040
	public float Stiffness; // 0x18
	// [Range] // 0x0000000189AE2AC0-0x0000000189AE2B20
	// [Tooltip] // 0x0000000189AE2AC0-0x0000000189AE2B20
	public float Damping; // 0x1C
	// [Header] // 0x0000000189AEF310-0x0000000189AEF390
	// [Range] // 0x0000000189AEF310-0x0000000189AEF390
	// [Tooltip] // 0x0000000189AEF310-0x0000000189AEF390
	public float Damp_FTL; // 0x20
	// [Range] // 0x0000000189927470-0x0000000189927490
	public float ConstrainIntensity; // 0x24
	public Vector3 G; // 0x28
	// [Header] // 0x0000000189B06C90-0x0000000189B06CC0
	public bool EnablePlaneCollision; // 0x34
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public bool UsePlaneCollision; // 0x35
	public Vector3 PlaneLocalForward; // 0x38
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public Vector3 PlaneForward; // 0x44
	public float planeOffset; // 0x50
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public Vector3 PlanePosition; // 0x54
	public Transform planeRoot; // 0x60
	// [Header] // 0x0000000189B25FE0-0x0000000189B26010
	public bool EnableCapsuleCollision; // 0x68
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public bool UseCapsuleCollision; // 0x69
	public List<CapsuleCollider> capsuleColliders; // 0x70
	// [Header] // 0x0000000189B36190-0x0000000189B361C0
	public BoneParticle[] boneParticleList; // 0x78
	// [Header] // 0x0000000189B3F310-0x0000000189B3F340
	public float DisplayBallSize; // 0x80
	public float DisplayBoneSize; // 0x84
	// [Header] // 0x0000000189B484A0-0x0000000189B484D0
	public Transform RootBone; // 0x88
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public Vector3 rootPosition; // 0x90
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public Quaternion rootRotation; // 0x9C
	// [Header] // 0x0000000189B60530-0x0000000189B60560
	public bool m_enable; // 0xAC
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public int particlesStartIndex; // 0xB0
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public int particleCount; // 0xB4
	// [Header] // 0x0000000189B77F50-0x0000000189B77F90
	[HideInInspector] // 0x0000000189B77F50-0x0000000189B77F90
	public bool IsSimulate; // 0xB8
	private static Vector3 VECTOR_ZERO; // 0x00

	// Properties
	public bool HasPlaneCollision { get => default; } // 0x0000000186F2C810-0x0000000186F2C880 
	public bool HasCapsuleCollision { get => default; } // 0x0000000186F2C7A0-0x0000000186F2C810 

	// Nested types
	[Serializable]
	public struct BoneParticle // TypeDefIndex: 9855
	{
		// Fields
		public bool isRoot; // 0x00
		public Transform boneTfm; // 0x08
		public Vector3 initLocalPosition; // 0x10
		public Quaternion initLocalRotation; // 0x1C
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float lengthToParent; // 0x2C
		public float jointRadius; // 0x30
		public float boneRadius; // 0x34
		public float stiffness; // 0x38
		public bool IsCollide; // 0x3C
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 pos; // 0x40
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 endPos; // 0x4C
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 prevPos; // 0x58
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 velocity; // 0x64

		// Constructors
		public BoneParticle(Transform boneTransform, bool root) {
			isRoot = default;
			boneTfm = default;
			initLocalPosition = default;
			initLocalRotation = default;
			lengthToParent = default;
			jointRadius = default;
			boneRadius = default;
			stiffness = default;
			IsCollide = default;
			pos = default;
			endPos = default;
			prevPos = default;
			velocity = default;
		} // 0x0000000186F1AD90-0x0000000186F1AE90
		public BoneParticle(BoneParticle copyTarget) {
			isRoot = default;
			boneTfm = default;
			initLocalPosition = default;
			initLocalRotation = default;
			lengthToParent = default;
			jointRadius = default;
			boneRadius = default;
			stiffness = default;
			IsCollide = default;
			pos = default;
			endPos = default;
			prevPos = default;
			velocity = default;
		} // 0x0000000186F1AE90-0x0000000186F1AF10
	}

	// Constructors
	public SpringMagicBone() {} // 0x0000000186F2C6D0-0x0000000186F2C7A0
	static SpringMagicBone() {} // 0x0000000186F2C630-0x0000000186F2C6D0

	// Methods
	public void Enabled() {} // 0x0000000186F28740-0x0000000186F287B0
	public void Disabled() {} // 0x0000000186F270A0-0x0000000186F27100
	private void Update() {} // 0x0000000186F2C5E0-0x0000000186F2C630
	public void InitilzeBones() {} // 0x0000000186F2A0B0-0x0000000186F2A400
	public void Reset() {} // 0x0000000186F2A400-0x0000000186F2A5A0
	public void InitVariables() {} // 0x0000000186F29E90-0x0000000186F2A0B0
	public void CheckEnable() {} // 0x0000000186F26FE0-0x0000000186F270A0
	// [Il2CppSetOption] // 0x0000000189B840F0-0x0000000189B84190
	// [Il2CppSetOption] // 0x0000000189B840F0-0x0000000189B84190
	public void SimulateVelocity(float dt, BoneParticle[] particles) {} // 0x0000000186F2B960-0x0000000186F2BBD0
	public void SimulateSolveConstrains(float dt, BoneParticle[] particles) {} // 0x0000000186F2B8D0-0x0000000186F2B960
	// [Il2CppSetOption] // 0x0000000189B95700-0x0000000189B957A0
	// [Il2CppSetOption] // 0x0000000189B95700-0x0000000189B957A0
	public void SimulateSolveConstrainsNoCollision(float dt, BoneParticle[] particles) {} // 0x0000000186F2A910-0x0000000186F2AF70
	// [Il2CppSetOption] // 0x0000000189BA73F0-0x0000000189BA7490
	// [Il2CppSetOption] // 0x0000000189BA73F0-0x0000000189BA7490
	public void SimulateSolveConstrainsWithCollision(float dt, BoneParticle[] particles) {} // 0x0000000186F2AF70-0x0000000186F2B8D0
	// [Il2CppSetOption] // 0x0000000189BB8A80-0x0000000189BB8B20
	// [Il2CppSetOption] // 0x0000000189BB8A80-0x0000000189BB8B20
	public void SimulateAssignment(float dt, BoneParticle[] particles) {} // 0x0000000186F2A5A0-0x0000000186F2A910
	private Vector3 GetConstrainPositionOnPlane(Vector3 temPosition, Vector3 parentPosition, float lengthToParent, float jointRadius, Vector3 planeUp, Vector3 planePosition) => default; // 0x0000000186F296D0-0x0000000186F299D0
	private Vector3 GetConstrainPositionOnPlane(BoneParticle bp, BoneParticle parentBP, Vector3 planeUp, Vector3 planePosition) => default; // 0x0000000186F29390-0x0000000186F296D0
	private void SolveCollision(BoneParticle bp, BoneParticle parentBP, float dt) {} // 0x0000000186F2BF60-0x0000000186F2C2A0
	private void SolveBoneCollision(BoneParticle bp, BoneParticle parentBP, CapsuleCollider col, float dt) {} // 0x0000000186F2BBD0-0x0000000186F2BF60
	private Vector3 GetBonePositionAfterCollision(BoneParticle bp, BoneParticle parentBP, CapsuleCollider col, Vector3 cloestPoint) => default; // 0x0000000186F289B0-0x0000000186F28E30
	private bool CheckCapsuleIntersectCapsule(Vector3 capApointA, Vector3 capApointB, float capARadius, Vector3 cloestPointA, Vector3 capBpointA, Vector3 capBpointB, float capBRadius, Vector3 cloestPointB) => default; // 0x0000000186F26990-0x0000000186F26FE0
	private Vector3 GetBoneCloestPointToCap(BoneParticle bp, BoneParticle parentBP, CapsuleCollider capsule, out float distance, out Vector3 innerPoint) {
		distance = default;
		innerPoint = default;
		return default;
	} // 0x0000000186F287B0-0x0000000186F289B0
	public static bool CalculateLineLineIntersection(Vector3 line1Point1, Vector3 line1Point2, Vector3 line2Point1, Vector3 line2Point2, out Vector3 resultSegmentPoint1, out Vector3 resultSegmentPoint2) {
		resultSegmentPoint1 = default;
		resultSegmentPoint2 = default;
		return default;
	} // 0x0000000186F25D90-0x0000000186F26390
	private void SolveJointCollision(BoneParticle bp, BoneParticle parentBP, CapsuleCollider col, float dt) {} // 0x0000000186F2C2A0-0x0000000186F2C5E0
	private Vector3 GetJointPositionAfterCollision(BoneParticle bp, BoneParticle parentBP, CapsuleCollider col, Vector3 cloestPoint) => default; // 0x0000000186F299D0-0x0000000186F29E90
	private Vector3 GetColestPointToCap(Vector3 point, CapsuleCollider capsule) => default; // 0x0000000186F29280-0x0000000186F29390
	public void CapsuleColliderToMathData(CapsuleCollider capsule, out Vector3 pointA, out Vector3 pointB, out float radius) {
		pointA = default;
		pointB = default;
		radius = default;
	} // 0x0000000186F26390-0x0000000186F26990
	private Vector3 GetCloestPointToSegement(Vector3 point, Vector3 segA, Vector3 segB) => default; // 0x0000000186F28E30-0x0000000186F29280
	public void DisplayPlane() {} // 0x0000000186F27690-0x0000000186F280B0
	public void DrawArrow(Vector3 from, Vector3 direction) {} // 0x0000000186F28250-0x0000000186F28740
	public void DisplayJoint(BoneParticle bp) {} // 0x0000000186F275D0-0x0000000186F27690
	public void DisplaySphereBone(BoneParticle bp, BoneParticle parentBone) {} // 0x0000000186F280B0-0x0000000186F28250
	public void DisplayBone(Transform from, Vector3 to, float ballSize, float boneSize) {} // 0x0000000186F27100-0x0000000186F275D0
}

