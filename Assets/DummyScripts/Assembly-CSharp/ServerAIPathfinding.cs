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

public sealed class ServerAIPathfinding : AIPathfinding // TypeDefIndex: 20501
{
	// Fields
	private static readonly Vector3 EXTEND_ON_TEMPLATE_COLLIDER; // 0x00
	private HashSet<int> _queryIDSet; // 0x40

	// Constructors
	public ServerAIPathfinding() {} // Dummy constructor
	public ServerAIPathfinding(AIKnowledge knowledge, AILODManager.BrainModuleType? lodType) {} // 0x000000018359A1C0-0x000000018359A2D0
	static ServerAIPathfinding() {} // 0x000000018359A120-0x000000018359A1C0

	// Methods
	// [XID] // 0x00000001898DC2F0-0x00000001898DC310
	public override void Destroy() {} // 0x00000001835984A0-0x00000001835986D0
	// [XID] // 0x00000001898E3D60-0x00000001898E3D80
	public override void ReInit() {} // 0x00000001835991B0-0x00000001835992C0
	// [XID] // 0x00000001898EB890-0x00000001898EB8B0
	public override void Clear() {} // 0x0000000183599090-0x00000001835991B0
	// [IDTag] // 0x00000001898F30E0-0x00000001898F3120
	// [XID] // 0x00000001898F30E0-0x00000001898F3120
	private void InnerQueryPath(PathQueryTask task, Vector3 start, Vector3 destination) {} // 0x0000000183599C50-0x000000018359A120
	// [IDTag] // 0x00000001898FDA60-0x00000001898FDAA0
	// [XID] // 0x00000001898FDA60-0x00000001898FDAA0
	private void InnerQueryPath(PathQueryTask task, Vector3 start, List<Vector3> destinations) {} // 0x0000000183599650-0x0000000183599C50
	// [IDTag] // 0x0000000189908310-0x0000000189908350
	// [XID] // 0x0000000189908310-0x0000000189908350
	public override PathQueryTask QueryPath(Vector3 start, Vector3 destination) => default; // 0x0000000183598B70-0x0000000183598CD0
	// [IDTag] // 0x0000000189912CA0-0x0000000189912CE0
	// [XID] // 0x0000000189912CA0-0x0000000189912CE0
	public override PathQueryTask QueryPath(Vector3 start, List<Vector3> destinations) => default; // 0x0000000183598CD0-0x0000000183598E00
	// [IDTag] // 0x000000018991D430-0x000000018991D470
	// [XID] // 0x000000018991D430-0x000000018991D470
	public override void QueryPath(PathQueryTask task, Vector3 start, Vector3 destination) {} // 0x0000000183598A20-0x0000000183598B70
	// [IDTag] // 0x0000000189927AD0-0x0000000189927B10
	// [XID] // 0x0000000189927AD0-0x0000000189927B10
	public override void QueryPath(PathQueryTask task, Vector3 start, List<Vector3> destinations) {} // 0x0000000183598E00-0x0000000183598F30
	// [XID] // 0x0000000189932120-0x0000000189932140
	public override float GetDistanceToAgentPathEnd(PathQueryTask pathQuery, Vector3 currentPosition) => default; // 0x00000001835993E0-0x00000001835995F0
	// [XID] // 0x0000000189939AB0-0x0000000189939AD0
	public override Vector3? GetNextConner(PathQueryTask pathQuery, Vector3 currentPosition, float almostReachedDistance) => default; // 0x0000000183598F30-0x0000000183599090
	// [XID] // 0x0000000189940D00-0x0000000189940D20
	public override Vector3? GetDirection(PathQueryTask pathQuery, Vector3 currentPosition, float almostReachedDistance) => default; // 0x00000001835988C0-0x0000000183598A20
	// [XID] // 0x00000001899486C0-0x00000001899486E0
	public override bool MoveToNextConner(PathQueryTask pathQuery) => default; // 0x00000001835992C0-0x0000000183599380
	// [XID] // 0x000000018994FE10-0x000000018994FE30
	public override void ResetAgent(Vector3 targetPos) {} // 0x00000001835986D0-0x00000001835988C0
	// [XID] // 0x00000001899573C0-0x00000001899573E0
	public override AITargetHasPathType HasPathToTarget(PathQueryTask pathQuery, Vector3 targetPosition, AITargetHasPathType defaultValue) => default; // 0x00000001835981E0-0x0000000183598440
}

