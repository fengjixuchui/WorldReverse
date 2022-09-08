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

public sealed class ClientAIPathfinding : AIPathfinding // TypeDefIndex: 20499
{
	// Fields
	private static readonly Vector3 EXTENT_INTERSECT_SURFACE; // 0x00
	private static readonly int AGENT_AREAMASK; // 0x0C
	private static readonly NavMeshBuildSettings AGENT_SETTING; // 0x10
	private Dictionary<int, RefreshSurfaceTask> refreshSurfaceTask; // 0x40
	private NavMeshQueryFilter queryFilter; // 0x48
	private NavMeshPath syncQueryPath; // 0x58
	private PathQueryTask _currentTask; // 0x60

	// Nested types
	private class RefreshSurfaceTask // TypeDefIndex: 20500
	{
		// Fields
		public NavMeshSurface surface; // 0x10
		public NavAgentSurfaceStatus surfaceStatus; // 0x18
		public PathQueryTask task; // 0x20
		public List<Vector3> multiDestination; // 0x28
		public float nextInternalUpdateSurfaceTick; // 0x30

		// Constructors
		public RefreshSurfaceTask() {} // 0x00000001813590A0-0x0000000181359100
	}

	// Constructors
	public ClientAIPathfinding() {} // Dummy constructor
	public ClientAIPathfinding(AIKnowledge knowledge, AILODManager.BrainModuleType? lodType) {} // 0x000000018136D6F0-0x000000018136D900
	static ClientAIPathfinding() {} // 0x000000018136D5C0-0x000000018136D6F0

	// Methods
	// [XID] // 0x00000001898203D0-0x00000001898203F0
	public override void Destroy() {} // 0x000000018136B160-0x000000018136B260
	// [XID] // 0x0000000189827A50-0x0000000189827A70
	public override void ReInit() {} // 0x000000018136C290-0x000000018136C3A0
	// [XID] // 0x000000018982ECB0-0x000000018982ECD0
	public override void Clear() {} // 0x000000018136BD00-0x000000018136BE20
	// [XID] // 0x0000000189836610-0x0000000189836630
	private void CalcNavMeshPath(RefreshSurfaceTask surfaceTask) {} // 0x000000018136CC90-0x000000018136CF50
	// [XID] // 0x000000018983D9E0-0x000000018983DA00
	private void DoCalcNavMeshPath(RefreshSurfaceTask surfaceTask) {} // 0x000000018136BE20-0x000000018136C290
	// [XID] // 0x0000000189845270-0x0000000189845290
	private bool SetSurface(RefreshSurfaceTask task, NavAgentSurfaceStatus toState, NavMeshSurface toSurface) => default; // 0x000000018136C460-0x000000018136C5F0
	// [XID] // 0x000000018984C760-0x000000018984C780
	private bool IsOnNavMesh(NavMeshSurface surface, Vector3 point) => default; // 0x000000018136A840-0x000000018136ABA0
	// [XID] // 0x00000001898537E0-0x0000000189853800
	private void FindSurface(RefreshSurfaceTask task) {} // 0x000000018136C650-0x000000018136CA00
	// [XID] // 0x000000018985B290-0x000000018985B2B0
	private void RefreshSurface(PathQueryTask task, List<Vector3> multiDestination, RefreshSurfaceTask surfaceTask = null) {} // 0x000000018136AE60-0x000000018136B160
	// [XID] // 0x00000001898627F0-0x0000000189862810
	private PathQueryTask.QueryStatus ToPathQueryTaskStatus(NavMeshPathStatus status) => default; // 0x000000018136CF50-0x000000018136D020
	// [IDTag] // 0x0000000189869BE0-0x0000000189869C20
	// [XID] // 0x0000000189869BE0-0x0000000189869C20
	private void InnerQueryPath(PathQueryTask task, Vector3 start, Vector3 destination) {} // 0x000000018136D370-0x000000018136D5C0
	// [IDTag] // 0x0000000189873E20-0x0000000189873E60
	// [XID] // 0x0000000189873E20-0x0000000189873E60
	private void InnerQueryPath(PathQueryTask task, Vector3 start, List<Vector3> destinations) {} // 0x000000018136D080-0x000000018136D370
	// [IDTag] // 0x000000018987E960-0x000000018987E9A0
	// [XID] // 0x000000018987E960-0x000000018987E9A0
	public override PathQueryTask QueryPath(Vector3 start, Vector3 destination) => default; // 0x000000018136B860-0x000000018136B9C0
	// [IDTag] // 0x0000000189888B00-0x0000000189888B40
	// [XID] // 0x0000000189888B00-0x0000000189888B40
	public override PathQueryTask QueryPath(Vector3 start, List<Vector3> destinations) => default; // 0x000000018136B9C0-0x000000018136BAF0
	// [IDTag] // 0x0000000189893090-0x00000001898930D0
	// [XID] // 0x0000000189893090-0x00000001898930D0
	public override void QueryPath(PathQueryTask task, Vector3 start, Vector3 destination) {} // 0x000000018136B710-0x000000018136B860
	// [IDTag] // 0x000000018989D2C0-0x000000018989D300
	// [XID] // 0x000000018989D2C0-0x000000018989D300
	public override void QueryPath(PathQueryTask task, Vector3 start, List<Vector3> destinations) {} // 0x000000018136B5E0-0x000000018136B710
	// [XID] // 0x00000001898A78B0-0x00000001898A78D0
	public override float GetDistanceToAgentPathEnd(PathQueryTask pathQuery, Vector3 currentPosition) => default; // 0x000000018136CA00-0x000000018136CC10
	// [XID] // 0x00000001898AF390-0x00000001898AF3B0
	public override Vector3? GetNextConner(PathQueryTask pathQuery, Vector3 currentPosition, float almostReachedDistance) => default; // 0x000000018136BAF0-0x000000018136BC50
	// [XID] // 0x00000001898B6810-0x00000001898B6830
	public override Vector3? GetDirection(PathQueryTask pathQuery, Vector3 currentPosition, float almostReachedDistance) => default; // 0x000000018136B480-0x000000018136B5E0
	// [XID] // 0x00000001898BE020-0x00000001898BE040
	public override bool MoveToNextConner(PathQueryTask pathQuery) => default; // 0x000000018136C3A0-0x000000018136C460
	// [XID] // 0x00000001898C58D0-0x00000001898C58F0
	public override void ResetAgent(Vector3 targetPos) {} // 0x000000018136B260-0x000000018136B480
	// [XID] // 0x00000001898CCFB0-0x00000001898CCFD0
	public override AITargetHasPathType HasPathToTarget(PathQueryTask pathQuery, Vector3 targetPosition, AITargetHasPathType defaultValue) => default; // 0x000000018136ABA0-0x000000018136AE00
	// [XID] // 0x00000001898D4950-0x00000001898D4970
	public override void UpdateTask(PathQueryTask task) {} // 0x000000018136BC50-0x000000018136BD00
}

