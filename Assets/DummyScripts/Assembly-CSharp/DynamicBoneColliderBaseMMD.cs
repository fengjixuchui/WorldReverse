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

public class DynamicBoneColliderBaseMMD : MonoBehaviour // TypeDefIndex: 31421
{
	// Fields
	public Direction m_Direction; // 0x18
	public Vector3 m_Center; // 0x1C
	public Bound m_Bound; // 0x28

	// Nested types
	public enum Direction // TypeDefIndex: 31422
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	public enum Bound // TypeDefIndex: 31423
	{
		Outside = 0,
		Inside = 1
	}

	// Constructors
	public DynamicBoneColliderBaseMMD() {} // 0x00000001830C2C40-0x00000001830C2CF0

	// Methods
	public virtual float CollideParticleRotateParent(VerletParticle p, VerletParticle parent, float particleRadius, float angleStep = 1f /* Metadata: 0x00B126FF */, bool childCompensate = false /* Metadata: 0x00B12703 */, MainDirection axis = MainDirection.Y /* Metadata: 0x00B12704 */, bool rotatePositive = true /* Metadata: 0x00B12708 */) => default; // 0x00000001830C2B00-0x00000001830C2B50
	public virtual float CollideLineRotateParent(StaticHorizonLine shl, float particleRadius, float angleStep = 1f /* Metadata: 0x00B12709 */, bool childCompensate = false /* Metadata: 0x00B1270D */, MainDirection axis = MainDirection.Y /* Metadata: 0x00B1270E */, bool rotatePositive = true /* Metadata: 0x00B12712 */) => default; // 0x00000001830C2A60-0x00000001830C2AB0
	public virtual void PrepareCollide() {} // 0x00000001830C2BF0-0x00000001830C2C40
	public virtual void CollideParticle(ref Vector3 particlePosition, float particleRadius) {} // 0x00000001830C2BA0-0x00000001830C2BF0
	public virtual void CollideParticle(VerletParticle particle, float particleRadius) {} // 0x00000001830C2B50-0x00000001830C2BA0
	public virtual void CollideParticleLine(ref Vector3 particlePosition, ref VerletParticle pParent, float lineRadius) {} // 0x00000001830C2AB0-0x00000001830C2B00
}

