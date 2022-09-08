/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;
using VerletEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class DynamicBoneCapsuleCollider : DynamicBoneColliderBaseMMD // TypeDefIndex: 31420
{
	// Fields
	public float m_Radius; // 0x30
	public float m_Height; // 0x34
	public LayerMask collideMask; // 0x38

	// Constructors
	public DynamicBoneCapsuleCollider() {} // 0x00000001830C29E0-0x00000001830C2A60

	// Methods
	private void OnValidate() {} // 0x00000001830C2440-0x00000001830C24F0
	public override float CollideParticleRotateParent(VerletParticle p, VerletParticle parent, float particleRadius, float angleStep, bool childCompensate, MainDirection axis, bool rotatePositive) => default; // 0x00000001830C1380-0x00000001830C1970
	public override float CollideLineRotateParent(StaticHorizonLine shl, float particleRadius, float angleStep = 1f /* Metadata: 0x00B126F5 */, bool childCompensate = false /* Metadata: 0x00B126F9 */, MainDirection axis = MainDirection.Y /* Metadata: 0x00B126FA */, bool rotatePositive = true /* Metadata: 0x00B126FE */) => default; // 0x00000001830C0D60-0x00000001830C1380
	private bool CheckCapsuleCollision(VerletParticle p, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius) => default; // 0x00000001830C0650-0x00000001830C09E0
	private bool CheckLineSphereCollision(Vector3 p0, Vector3 p1, float radius, Vector3 center) => default; // 0x00000001830C09E0-0x00000001830C0D60
	private bool CheckCapsuleCollisionRayCast(StaticHorizonLine p) => default; // 0x00000001830BFA10-0x00000001830BFB90
	private bool CheckCapsuleCollision(StaticHorizonLine p, float lineRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius) => default; // 0x00000001830BFB90-0x00000001830C0650
	public override void CollideParticle(VerletParticle particle, float particleRadius) {} // 0x00000001830C1970-0x00000001830C1CB0
	private static void OutsideCapsule(VerletParticle particle, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius) {} // 0x00000001830C24F0-0x00000001830C29E0
	private static void InsideCapsule(VerletParticle particle, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius) {} // 0x00000001830C1CB0-0x00000001830C2160
	private void OnDrawGizmosSelected() {} // 0x00000001830C2160-0x00000001830C2440
}

