/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleeInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20195
{
	// Fields
	public FleeStatus status; // 0x10
	public Vector3? fleePoint; // 0x14
	public float nextAvailableTick; // 0x24
	public int fleeNumberRemaining; // 0x28
	public const sbyte SAMPLE_COUNT = 9; // Metadata: 0x00AFD30C
	public const float EXPAND_FLEE_ANGLE = 120f; // Metadata: 0x00AFD30D
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<float> _rawFleeDirArcs; // 0x30
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<Vector3> _candidateFleeDirections; // 0x38
	public PathQueryTask fleePathQuery; // 0x40
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<Vector3> _candidateFleePointToQueryPath; // 0x48
	private bool fleeKillSelf; // 0x50
	private float fleeKillSelfStartTime; // 0x54

	// Nested types
	public enum FleeStatus // TypeDefIndex: 20196
	{
		Inactive = 0,
		Fleeing = 1,
		FleeFinish = 2,
		RotateToTarget = 3
	}

	// Constructors
	public FleeInfo() {} // 0x0000000182A7A230-0x0000000182A7A2A0

	// Methods
	[BlackList] // 0x00000001897B83E0-0x00000001897B8420
	// [XID] // 0x00000001897B83E0-0x00000001897B8420
	public override void AutoAllocTypeFields() {} // 0x0000000182A78590-0x0000000182A78690
	[BlackList] // 0x00000001897C3170-0x00000001897C31B0
	// [XID] // 0x00000001897C3170-0x00000001897C31B0
	public override void AutoRecycleTypeFields() {} // 0x0000000182A78690-0x0000000182A787A0
	[BlackList] // 0x00000001897CDB00-0x00000001897CDB40
	// [XID] // 0x00000001897CDB00-0x00000001897CDB40
	public override void ReturnToObjectPool() {} // 0x0000000182A7A190-0x0000000182A7A230
	// [XID] // 0x00000001897D86A0-0x00000001897D86C0
	public override void OnPoolAllocated() {} // 0x0000000182A7A0C0-0x0000000182A7A190
	// [XID] // 0x00000001897DF790-0x00000001897DF7B0
	public override void Clear() {} // 0x0000000182A794E0-0x0000000182A795A0
	// [XID] // 0x00000001897E6F70-0x00000001897E6F90
	public override void Enter(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x0000000182A79F90-0x0000000182A7A0C0
	// [XID] // 0x00000001897EEC60-0x00000001897EEC80
	public override void Leave(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x0000000182A79DE0-0x0000000182A79ED0
	// [XID] // 0x00000001897F6300-0x00000001897F6320
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x0000000182A795A0-0x0000000182A79AA0
	// [XID] // 0x00000001897FD9C0-0x00000001897FD9E0
	private bool FindFleePosition(AIKnowledge knowledge, LCAIBeta lcai) => default; // 0x0000000182A78800-0x0000000182A794E0
	// [XID] // 0x0000000189805210-0x0000000189805230
	public void TriggerCD(AIKnowledge knowledge, bool byFail = false /* Metadata: 0x00AFD30B */) {} // 0x0000000182A79B90-0x0000000182A79CF0
}

