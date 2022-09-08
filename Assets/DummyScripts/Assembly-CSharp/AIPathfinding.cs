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

public abstract class AIPathfinding : BrainModuleBase // TypeDefIndex: 20494
{
	// Fields
	private BaseEntityHandle _blockEntityHandle; // 0x30
	private static Dictionary<uint, PFAgentInfo> _avoidanceMap; // 0x00

	// Properties
	public BaseEntity blockEntity { /* [XID] */ /* 0x00000001897DC750-0x00000001897DC770 */ get; /* [XID] */ /* 0x00000001897E4150-0x00000001897E4170 */ set; } // 0x0000000182082110-0x00000001820821C0 0x0000000182081F30-0x0000000182081FF0

	// Nested types
	public struct PFAgentInfo // TypeDefIndex: 20495
	{
		// Fields
		public AIKnowledge knowledge; // 0x00
		public AIPathfinding pathfinder; // 0x08
	}

	// Constructors
	protected AIPathfinding() {} // Dummy constructor
	protected AIPathfinding(AIKnowledge knowledge, AILODManager.BrainModuleType? lodType) {} // 0x0000000182083030-0x00000001820830D0
	static AIPathfinding() {} // 0x0000000182082FA0-0x0000000182083030

	// Methods
	// [XID] // 0x0000000189A80CF0-0x0000000189A80D10
	public static AIPathfinding Create(AIKnowledge knowledge) => default; // 0x0000000182081BD0-0x0000000182081E90
	public abstract PathQueryTask QueryPath(Vector3 start, Vector3 destination);
	public abstract PathQueryTask QueryPath(Vector3 start, List<Vector3> destinations);
	public abstract void QueryPath(PathQueryTask task, Vector3 start, Vector3 destination);
	public abstract void QueryPath(PathQueryTask task, Vector3 start, List<Vector3> destinations);
	public abstract float GetDistanceToAgentPathEnd(PathQueryTask pathQuery, Vector3 currentPosition);
	public abstract Vector3? GetNextConner(PathQueryTask pathQuery, Vector3 currentPosition, float almostReachedDistance);
	public abstract Vector3? GetDirection(PathQueryTask pathQuery, Vector3 currentPosition, float almostReachedDistance);
	public abstract bool MoveToNextConner(PathQueryTask pathQuery);
	public abstract AITargetHasPathType HasPathToTarget(PathQueryTask pathQuery, Vector3 targetPosition, AITargetHasPathType defaultValue);
	// [XID] // 0x00000001897B6CC0-0x00000001897B6CE0
	public virtual void ReInit() {} // 0x0000000182081E90-0x0000000182081F30
	// [XID] // 0x000000018990F200-0x000000018990F220
	public virtual void Clear() {} // 0x0000000182081B30-0x0000000182081BD0
	// [XID] // 0x00000001897C61D0-0x00000001897C61F0
	public virtual void Destroy() {} // 0x0000000182081900-0x00000001820819A0
	public abstract void ResetAgent(Vector3 targetPos);
	// [XID] // 0x00000001897CDA40-0x00000001897CDA60
	public virtual void UpdateTask(PathQueryTask task) {} // 0x00000001820819A0-0x0000000182081A50
	// [XID] // 0x00000001897D4F90-0x00000001897D4FB0
	public static void StaticInit() {} // 0x00000001820821C0-0x0000000182082250
	// [XID] // 0x00000001897EBC80-0x00000001897EBCA0
	protected static void RegisterPFAgent(AIKnowledge agentKnowledge, AIPathfinding entityPathfinder) {} // 0x0000000182081FF0-0x0000000182082110
	// [XID] // 0x00000001897F35D0-0x00000001897F35F0
	protected static void UnregisterPFAgent(uint entityID) {} // 0x0000000182081A50-0x0000000182081B30
	// [XID] // 0x00000001897FAF90-0x00000001897FAFB0
	public static void UpdateDynamicAvoidance(List<BaseEntity> inteeEntityList) {} // 0x0000000182082250-0x0000000182082FA0
}

