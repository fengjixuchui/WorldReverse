/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SnowSurfaceBlock3x3 // TypeDefIndex: 14757
{
	// Fields
	public static readonly int N; // 0x00
	public static readonly int count; // 0x04
	public Vector3 center; // 0x10
	public long centerId; // 0x20
	public Vector3 subBlockSize; // 0x28
	public SceneWidgetPool<Matrix4x4, Matrix4x4> objToWorldMatrixItr; // 0x38
	public SnowSurfaceBlock1x1[] entities; // 0x48

	// Constructors
	public SnowSurfaceBlock3x3() {} // 0x00000001827C9720-0x00000001827C97F0
	static SnowSurfaceBlock3x3() {} // 0x00000001827C96A0-0x00000001827C9720

	// Methods
	// [XID] // 0x0000000189B511F0-0x0000000189B51210
	public void Setup(long centerId, Vector3 center, Vector3 subBlockSize, long[] entityIds, VisualSnowSurface.InstanceBatchPool.InstanceBatch poolBatch) {} // 0x00000001827C8AB0-0x00000001827C8E80
	// [XID] // 0x0000000189B58B40-0x0000000189B58B60
	public void Update(long[] entityIds) {} // 0x00000001827C8FD0-0x00000001827C91D0
	// [XID] // 0x0000000189B602B0-0x0000000189B602D0
	public bool ContainsNotMeltingEntity(long id) => default; // 0x00000001827C8E80-0x00000001827C8FD0
	// [XID] // 0x0000000189B67A90-0x0000000189B67AB0
	public void MeltEntity(long id) {} // 0x00000001827C9530-0x00000001827C96A0
	// [XID] // 0x0000000189B6ECD0-0x0000000189B6ECF0
	public bool CanBeRemoved() => default; // 0x00000001827C93F0-0x00000001827C9530
	// [XID] // 0x0000000189B76490-0x0000000189B764B0
	public void Release() {} // 0x00000001827C91D0-0x00000001827C9280
	// [XID] // 0x0000000189B7DA80-0x0000000189B7DAA0
	public bool UpdateAnimation(float delta) => default; // 0x00000001827C9280-0x00000001827C93F0
}

