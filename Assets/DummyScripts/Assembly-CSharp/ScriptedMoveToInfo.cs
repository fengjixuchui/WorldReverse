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

public sealed class ScriptedMoveToInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20235
{
	// Fields
	public const float FADE_TIME = 1f; // Metadata: 0x00AFD41F
	public bool active; // 0x10
	public bool needDynamicAvoidance; // 0x11
	public ScriptedMoveStatus status; // 0x14
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<Vector3> _waypoints; // 0x18
	public int waypointIndex; // 0x20
	public AIMoveSpeedLevel? realtimeSpeedLevel; // 0x24
	public bool? is3D; // 0x2C
	private bool _exactlyMove; // 0x2E

	// Nested types
	public enum ScriptedMoveStatus // TypeDefIndex: 20236
	{
		Inactive = 0,
		CreateTask = 1,
		Moving = 2,
		Fading = 3,
		Fadout = 4
	}

	public enum ActionType // TypeDefIndex: 20237
	{
		Set = 0,
		Pause = 1,
		Resume = 2
	}

	public enum ReachPointState // TypeDefIndex: 20238
	{
		MiddlePoint = 0,
		FinalPoint = 1
	}

	// Constructors
	public ScriptedMoveToInfo() {} // 0x0000000182B56610-0x0000000182B56680

	// Methods
	[BlackList] // 0x0000000189A92020-0x0000000189A92060
	// [XID] // 0x0000000189A92020-0x0000000189A92060
	public override void AutoAllocTypeFields() {} // 0x0000000182B54E80-0x0000000182B54F50
	[BlackList] // 0x0000000189A9C630-0x0000000189A9C670
	// [XID] // 0x0000000189A9C630-0x0000000189A9C670
	public override void AutoRecycleTypeFields() {} // 0x0000000182B54F50-0x0000000182B55020
	[BlackList] // 0x0000000189AA6DC0-0x0000000189AA6E00
	// [XID] // 0x0000000189AA6DC0-0x0000000189AA6E00
	public override void ReturnToObjectPool() {} // 0x0000000182B56570-0x0000000182B56610
	// [XID] // 0x0000000189AB17C0-0x0000000189AB17E0
	public override void Clear() {} // 0x0000000182B55130-0x0000000182B55210
	// [XID] // 0x0000000189AB8B60-0x0000000189AB8B80
	public override void Enter(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x0000000182B56470-0x0000000182B56570
	// [XID] // 0x0000000189AC0690-0x0000000189AC06B0
	public override void Leave(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x0000000182B56020-0x0000000182B561A0
	// [XID] // 0x0000000189AC80F0-0x0000000189AC8110
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x0000000182B55210-0x0000000182B55A00
	// [XID] // 0x0000000189ACF7F0-0x0000000189ACF810
	private void OnActorHide(ILuaActor obj) {} // 0x0000000182B55080-0x0000000182B55130
	// [XID] // 0x0000000189AD7580-0x0000000189AD75A0
	private bool ReachedFinalWaypoint(AIKnowledge aiKnowledge) => default; // 0x0000000182B56200-0x0000000182B56410
	// [XID] // 0x0000000189ADEFD0-0x0000000189ADEFF0
	private void IncrementIndex() {} // 0x0000000182B55A90-0x0000000182B55B50
	// [XID] // 0x0000000189AE68C0-0x0000000189AE68E0
	public void Set(ActionType action, Vector3 currentPos, List<Vector3> route, VCBaseInputController controller, AIPathfinding pathfinder, LCAIBeta lcai, bool exactlyMove) {} // 0x0000000182B55BB0-0x0000000182B55F90
}

