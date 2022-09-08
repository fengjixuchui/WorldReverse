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

public sealed class FixedMoveInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20193
{
	// Fields
	public FixedMoveStatus status; // 0x10
	private Vector3 excutingTargetPoint; // 0x14
	private uint excutingActionPointLocalID; // 0x20
	public Vector3? targetPoint; // 0x24
	public Vector3? targetAbilityPoint; // 0x34
	public uint actionPointLocalID; // 0x44
	public float nextOvertimeTick; // 0x48
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public Dictionary<uint, float> actionPointNextOvertimeTickMap; // 0x50

	// Nested types
	public enum FixedMoveStatus // TypeDefIndex: 20194
	{
		Inactive = 0,
		MoveToPoint = 1,
		DoAction = 2
	}

	// Constructors
	public FixedMoveInfo() {} // 0x0000000181BC3700-0x0000000181BC3770

	// Methods
	[BlackList] // 0x000000018974DBD0-0x000000018974DC10
	// [XID] // 0x000000018974DBD0-0x000000018974DC10
	public override void AutoAllocTypeFields() {} // 0x0000000181BC27E0-0x0000000181BC28B0
	[BlackList] // 0x0000000189757D30-0x0000000189757D70
	// [XID] // 0x0000000189757D30-0x0000000189757D70
	public override void AutoRecycleTypeFields() {} // 0x0000000181BC28B0-0x0000000181BC29C0
	[BlackList] // 0x0000000189762770-0x00000001897627B0
	// [XID] // 0x0000000189762770-0x00000001897627B0
	public override void ReturnToObjectPool() {} // 0x0000000181BC3660-0x0000000181BC3700
	// [XID] // 0x000000018976CD60-0x000000018976CD80
	public override void Clear() {} // 0x0000000181BC2C70-0x0000000181BC2D40
	// [XID] // 0x0000000189774140-0x0000000189774160
	public override void Enter(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x0000000181BC3400-0x0000000181BC34E0
	// [XID] // 0x000000018977B8C0-0x000000018977B8E0
	public override void Leave(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x0000000181BC3260-0x0000000181BC3340
	// [XID] // 0x0000000189783350-0x0000000189783370
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x0000000181BC2D40-0x0000000181BC30E0
	// [XID] // 0x000000018978A940-0x000000018978A960
	private void TurnToDoAction(AIKnowledge aiKnowledge) {} // 0x0000000181BC2A20-0x0000000181BC2BB0
	// [XID] // 0x0000000189792060-0x0000000189792080
	private bool CheckDistance(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge) => default; // 0x0000000181BC34E0-0x0000000181BC3660
	// [XID] // 0x0000000189799690-0x00000001897996B0
	public void SetTargetAbilityPoint(Vector3? point) {} // 0x0000000181BC2BB0-0x0000000181BC2C70
}

