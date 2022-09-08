/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCWallCollision : VCBase // TypeDefIndex: 11973
{
	// Fields
	private LayerMask _collisionMask; // 0x108
	public float fadeDuration; // 0x10C
	// [Header] // 0x00000001899D97F0-0x00000001899D9820
	public string collisionEffectPattern; // 0x110
	private List<CollisionEntry> _collisions; // 0x118

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899E2760-0x00000001899E2780 */ get => default; } // 0x0000000184BCE3C0-0x0000000184BCE460 

	// Nested types
	private class CollisionEntry // TypeDefIndex: 11974
	{
		// Fields
		public Collider collider; // 0x10
		public Transform transform; // 0x18
		public Vector3 forward; // 0x20
		public float timer; // 0x2C
		public int patternIx; // 0x30
		public MonoEffectProxy effectProxy; // 0x38

		// Constructors
		public CollisionEntry() {} // 0x0000000184BDBD20-0x0000000184BDBD80
	}

	// Constructors
	public VCWallCollision() {} // 0x0000000184BCE320-0x0000000184BCE3C0

	// Methods
	// [XID] // 0x00000001899E9D30-0x00000001899E9D50
	public override void Init() {} // 0x0000000184BCD2E0-0x0000000184BCD8D0
	// [XID] // 0x00000001899F1510-0x00000001899F1530
	public override void Destroy() {} // 0x0000000184BCCA90-0x0000000184BCCC80
	// [XID] // 0x00000001899F8D70-0x00000001899F8D90
	protected override void Tick(float inDeltaTime) {} // 0x0000000184BCDFF0-0x0000000184BCE320
	// [XID] // 0x0000000189A00390-0x0000000189A003B0
	private Vector3 GetCollisoinPointOnWall(Transform playerTransform, Transform trans, Vector3 forward) => default; // 0x0000000184BCC4E0-0x0000000184BCC790
	// [XID] // 0x0000000189A07A60-0x0000000189A07A80
	private void CreateOrRefreshCollisionEntry(Collider collider, GameObject obj) {} // 0x0000000184BCCE20-0x0000000184BCD2E0
	// [XID] // 0x0000000189A0F0C0-0x0000000189A0F0E0
	private Vector3 ComputeForward(Transform wall, Transform player) => default; // 0x0000000184BCDBD0-0x0000000184BCDF00
	// [XID] // 0x0000000189A16760-0x0000000189A16780
	private void OnTriggerEnter(Collider collider, GameObject gameObject) {} // 0x0000000184BCCC80-0x0000000184BCCDA0
	// [XID] // 0x0000000189A1DC40-0x0000000189A1DC60
	private void OnTriggerStay(Collider collider, GameObject gameObject) {} // 0x0000000184BCC880-0x0000000184BCC9A0
	// [XID] // 0x0000000189A25250-0x0000000189A25270
	private void OnTriggerExit(Collider collider, GameObject gameObject) {} // 0x0000000184BCD930-0x0000000184BCDB60
	// [XID] // 0x0000000189A2C8C0-0x0000000189A2C8E0
	private void OnCollisionEnter(Collision collision, GameObject gameObject) {} // 0x0000000184BCC9A0-0x0000000184BCCA90
	// [XID] // 0x0000000189A33F40-0x0000000189A33F60
	private void OnCollisionStay(Collision collision, GameObject gameObject) {} // 0x0000000184BCDF00-0x0000000184BCDFF0
	// [XID] // 0x0000000189A3B6B0-0x0000000189A3B6D0
	private void OnCollisionExit(Collision collision, GameObject gameObject) {} // 0x0000000184BCC790-0x0000000184BCC880
}

