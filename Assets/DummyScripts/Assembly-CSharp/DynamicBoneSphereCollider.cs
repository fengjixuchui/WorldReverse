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

// [AddComponentMenu] // 0x0000000189ABE8F0-0x0000000189ABE920
public class DynamicBoneSphereCollider : DynamicBoneColliderBaseMMD // TypeDefIndex: 31430
{
	// Fields
	public float m_Radius; // 0x30

	// Constructors
	public DynamicBoneSphereCollider() {} // 0x00000001830C4500-0x00000001830C4570

	// Methods
	private void OnValidate() {} // 0x00000001830C3FF0-0x00000001830C4090
	public override float CollideParticleRotateParent(VerletParticle p, VerletParticle parent, float particleRadius, float angleStep, bool childCompensate, MainDirection axis, bool rotatePositive) => default; // 0x00000001830C3250-0x00000001830C3C60
	public override void CollideParticle(VerletParticle particle, float particleRadius) {} // 0x00000001830C3C60-0x00000001830C3E40
	private void PushParticleOutsideSphere(VerletParticle particle, float particleRadius, Vector3 sphereCenter, float sphereRadius) {} // 0x00000001830C42C0-0x00000001830C4500
	private void PullParticleInsideSphere(VerletParticle particle, float particleRadius, Vector3 sphereCenter, float sphereRadius) {} // 0x00000001830C4090-0x00000001830C42C0
	public override void CollideParticleLine(ref Vector3 particlePosition, ref VerletParticle pParent, float lineRadius) {} // 0x00000001830C2CF0-0x00000001830C3250
	private void OnDrawGizmosSelected() {} // 0x00000001830C3E40-0x00000001830C3FF0
}

