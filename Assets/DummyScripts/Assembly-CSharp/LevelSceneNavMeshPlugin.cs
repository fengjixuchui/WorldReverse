/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.AI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelSceneNavMeshPlugin : BaseComponentPlugin // TypeDefIndex: 12101
{
	// Fields
	private DynamicNavMeshPool _dynamicNavMeshPool; // 0x58
	private Transform _dynamicNavMeshTransform; // 0x60
	private Dictionary<uint, NavMeshBakeQuery> _buildSurfaceWaitingQueue; // 0x68
	private Dictionary<uint, NavMeshBakeData> _buildingSurfaces; // 0x70
	private HashSet<uint> _buildSurfaceFinishedSet; // 0x78
	public Action<NavMeshSurface> OnNavMeshBaked; // 0x80
	private static readonly Vector3 BOUND_EXTENT; // 0x00

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B3BE10-0x0000000189B3BE30 */ get => default; } // 0x000000018315C160-0x000000018315C200 

	// Nested types
	private struct NavMeshBakeQuery // TypeDefIndex: 12102
	{
		// Fields
		public DynamicNavMeshPool.Bucket queryingBucket; // 0x00
		public Bounds bounds; // 0x08
	}

	private struct NavMeshBakeData // TypeDefIndex: 12103
	{
		// Fields
		public DynamicNavMeshPool.Bucket bakingBucket; // 0x00
		public NavMeshData data; // 0x08
		public AsyncOperation operation; // 0x10
	}

	// Constructors
	public LevelSceneNavMeshPlugin() {} // 0x000000018315C100-0x000000018315C160
	static LevelSceneNavMeshPlugin() {} // 0x000000018315C060-0x000000018315C100

	// Methods
	// [XID] // 0x0000000189B43A20-0x0000000189B43A40
	public override void Init() {} // 0x000000018315A7E0-0x000000018315A9A0
	// [XID] // 0x0000000189B4B020-0x0000000189B4B040
	public override void Tick(float inDeltaTime) {} // 0x000000018315B600-0x000000018315C060
	// [XID] // 0x0000000189B528A0-0x0000000189B528C0
	public override void Destroy() {} // 0x00000001831597B0-0x0000000183159AA0
	// [XID] // 0x0000000189B5A260-0x0000000189B5A280
	public NavMeshSurface QueryExistingDynamicSurface(uint entityID, Vector3 startPos, Vector3 targetPos, out bool ready) {
		ready = default;
		return default;
	} // 0x000000018315B040-0x000000018315B1E0
	// [XID] // 0x0000000189B61720-0x0000000189B61740
	private Bounds CreateBounds(Vector3 point1, Vector3 point2) => default; // 0x000000018315AC40-0x000000018315AF50
	// [IDTag] // 0x0000000189B69290-0x0000000189B692D0
	// [XID] // 0x0000000189B69290-0x0000000189B692D0
	public bool RequestBuildDynamicNavMesh(uint entityID, Vector3 currentPos, List<Vector3> targets, ref NavMeshSurface assignSurface) => default; // 0x000000018315A1C0-0x000000018315A7E0
	// [IDTag] // 0x0000000189B73730-0x0000000189B73770
	// [XID] // 0x0000000189B73730-0x0000000189B73770
	public bool RequestBuildDynamicNavMesh(uint entityID, Vector3 currentPos, Vector3 targetPos, ref NavMeshSurface assignSurface) => default; // 0x0000000183159CE0-0x000000018315A1C0
	// [XID] // 0x0000000189B7DBA0-0x0000000189B7DBC0
	public void UnregisterDynamicSurfaceUser(uint entityID) {} // 0x0000000183159C20-0x0000000183159CE0
	// [XID] // 0x0000000189B85820-0x0000000189B85840
	public void OnEntityRemoved(uint entityID) {} // 0x000000018315A9A0-0x000000018315ABE0
	// [XID] // 0x0000000189B8C610-0x0000000189B8C630
	public void CancelBuildDynamicNavMesh(uint entityID) {} // 0x000000018315B4D0-0x000000018315B600
	// [XID] // 0x0000000189B93FD0-0x0000000189B93FF0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000183159B20-0x0000000183159C20
	// [XID] // 0x0000000189B9B590-0x0000000189B9B5B0
	public override bool OnEvent(BaseEvent evt) => default; // 0x000000018315B1E0-0x000000018315B4D0
}

