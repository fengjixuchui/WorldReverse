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
using UnityEngine.AI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class DynamicNavMeshPool // TypeDefIndex: 14739
{
	// Fields
	public Bucket[] buckets; // 0x10
	public const int POOL_SIZE_RELEASE = 0; // Metadata: 0x00AEBE8F
	public const int POOL_SIZE_DEVMODE = 10; // Metadata: 0x00AEBE93
	public bool releaseMode; // 0x18

	// Nested types
	public enum BucketStatus // TypeDefIndex: 14740
	{
		NotReady = 0,
		Ready = 1
	}

	public class Bucket // TypeDefIndex: 14741
	{
		// Fields
		public int index; // 0x10
		public NavMeshSurface bucketSurface; // 0x18
		public BucketStatus bucketStatus; // 0x20
		public uint ownerID; // 0x24
		public List<uint> userIDs; // 0x28

		// Constructors
		public Bucket() {} // 0x0000000182B23D20-0x0000000182B23DC0

		// Methods
		// [XID] // 0x00000001898AB200-0x00000001898AB220
		public bool InUse() => default; // 0x0000000182B23C70-0x0000000182B23D20
		// [XID] // 0x00000001898B2B60-0x00000001898B2B80
		public void AcquireSurface(uint entityID) {} // 0x0000000182B23B60-0x0000000182B23C70
		// [XID] // 0x00000001898BA9C0-0x00000001898BA9E0
		public void GiveupSurface(uint entityID) {} // 0x0000000182B23A10-0x0000000182B23B60
	}

	// Constructors
	public DynamicNavMeshPool() {} // Dummy constructor
	public DynamicNavMeshPool(Transform root) {} // 0x0000000182B2A6C0-0x0000000182B2AA50

	// Methods
	// [XID] // 0x000000018988DA70-0x000000018988DA90
	public Bucket RequestBakeNewSurface() => default; // 0x0000000182B2A4B0-0x0000000182B2A5B0
	// [XID] // 0x0000000189895140-0x0000000189895160
	public Bucket CheckIsInAnySurface(Vector3 startPoint, Vector3 targetPoint) => default; // 0x0000000182B2A080-0x0000000182B2A4B0
	// [XID] // 0x000000018989C7F0-0x000000018989C810
	public void RemoveSurfaceUser(uint userID) {} // 0x0000000182B2A5B0-0x0000000182B2A6C0
	// [XID] // 0x00000001898A4080-0x00000001898A40A0
	public void RetargetRuntimeID(uint oldRuntimeID, uint newRuntimeID) {} // 0x0000000182B29EC0-0x0000000182B2A080
}

