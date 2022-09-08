/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct CollisionResult // TypeDefIndex: 31806
{
	// Fields
	public BaseEntity entity; // 0x00
	public Collider collider; // 0x08
	public Vector3 hitPoint; // 0x10
	public Vector3 hitForward; // 0x1C
	public uint patternIndex; // 0x28
	public int hitBodypartIndex; // 0x2C

	// Constructors
	public CollisionResult(BaseEntity entity, Collider hitCollider, Vector3 hitPoint, Vector3 hitForward) {
		this.entity = default;
		collider = default;
		this.hitPoint = default;
		this.hitForward = default;
		patternIndex = default;
		hitBodypartIndex = default;
	} // 0x0000000181959370-0x0000000181959430
	public CollisionResult(BaseEntity entity, Collider hitCollider, Vector3 hitPoint, Vector3 hitForward, uint patternIndex, int hitBodypartIndex) {
		this.entity = default;
		collider = default;
		this.hitPoint = default;
		this.hitForward = default;
		this.patternIndex = default;
		this.hitBodypartIndex = default;
	} // 0x0000000181959430-0x0000000181959520
}

