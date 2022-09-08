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

public static class CollisionDetectPattern // TypeDefIndex: 31805
{
	// Fields
	public static Color debugMeshColor; // 0x00
	public static Color debugMeshOutlineColor; // 0x10
	private const int NON_ALLOC_CACHE_SIZE = 100; // Metadata: 0x00B1370F
	private static RaycastHit[] _raycastHitsBuffer; // 0x20
	private static Collider[] _collidersBuffer; // 0x28
	private static List<CollisionResult> results; // 0x30
	private static RaycastHit _raycastHitBuffer; // 0x38
	private static int[] _indexArrayBuffer; // 0x78
	private static Vector3[] _sphereCheckDirections; // 0x80
	private static RaycastHit _hitscanHit; // 0x88

	// Constructors
	static CollisionDetectPattern() {} // 0x00000001848B6960-0x00000001848B75A0

	// Methods
	// [XID] // 0x0000000189B363F0-0x0000000189B36410
	private static bool CanAddToResults(List<CollisionResult> results, BaseEntity entity, Collider hitCollider, bool includeNullEntity = false /* Metadata: 0x00B1370D */) => default; // 0x00000001848AF8A0-0x00000001848AFB00
	// [XID] // 0x0000000189636620-0x0000000189636640
	private static bool CheckStartingPointInsideness(Collider collider, Vector3 startingPoint, Vector3 forward, List<CollisionResult> outResults, bool includeNullEntity, out RaycastHit hit) {
		hit = default;
		return default;
	} // 0x00000001848A6790-0x00000001848A6E90
	// [XID] // 0x0000000189B45970-0x0000000189B45990
	public static CollisionResult? FanCollisionHitOnce(Vector3 fanCenterPoint, float radius, Vector3 direction, float fanAngle, CircleDetectDirection detectDirection, LayerMask mask) => default; // 0x00000001848B3E40-0x00000001848B4920
	// [XID] // 0x0000000189B4CDD0-0x0000000189B4CDF0
	public static List<CollisionResult> FanCylinderCollisionDetectBySphere(Vector3 centerPoint, float radius, Vector3 direction, float fanAngle, float height, LayerMask mask, bool includeNullEntity) => default; // 0x00000001848AFB00-0x00000001848B3E40
	// [XID] // 0x00000001896452D0-0x00000001896452F0
	public static List<CollisionResult> FanCylinderCoDecByOverlapCapsule(Vector3 centerPoint, float radius, Vector3 direction, float fanAngle, float height, LayerMask mask, bool includeNullEntity) => default; // 0x00000001848A6E90-0x00000001848AB4C0
	// [XID] // 0x0000000189B5C100-0x0000000189B5C120
	public static List<CollisionResult> SphereCollisionDetectBySphere(Vector3 centerPoint, float radius, LayerMask mask, bool includeNullEntity) => default; // 0x00000001848B54F0-0x00000001848B6960
	// [XID] // 0x00000001896D14E0-0x00000001896D1500
	public static CollisionResult? SphereCollisionHitOnce(Vector3 centerPoint, float radius, LayerMask mask) => default; // 0x00000001848AF020-0x00000001848AF8A0
	// [XID] // 0x0000000189B6AEA0-0x0000000189B6AEC0
	public static List<CollisionResult> BoxCollisionDetectByBox(Vector3 centerPoint, Vector3 size, Quaternion rot, LayerMask mask, bool includeNullEntity) => default; // 0x00000001848AB6B0-0x00000001848AF020
	// [XID] // 0x0000000189B72540-0x0000000189B72560
	public static CollisionResult? HitscanSingleDetect(Vector3 rayCenterPoint, Vector3 rayForward, float maxDistance, LayerMask mask, bool mustHitEntity = true /* Metadata: 0x00B1370E */) => default; // 0x00000001848B4C10-0x00000001848B54F0
	// [XID] // 0x000000018963DC50-0x000000018963DC70
	public static int[] MakeCenteredIndices(int count) => default; // 0x00000001848AB4C0-0x00000001848AB6B0
	// [XID] // 0x000000018970B3B0-0x000000018970B3D0
	private static bool CenterHit(Vector3 origin, Collider collider, out RaycastHit castHit) {
		castHit = default;
		return default;
	} // 0x00000001848B4920-0x00000001848B4C10
}

