/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SurroundInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20334
{
	// Fields
	public SurroundStatus status; // 0x10
	public bool clockwise; // 0x14
	public Vector3? fixedPoint; // 0x18
	public bool startBigTurn; // 0x28
	public float discardTickQueryBigTurn; // 0x2C
	public float nextTickBigTurnCheck; // 0x30

	// Nested types
	public enum SurroundStatus // TypeDefIndex: 20335
	{
		Idle = 0,
		Move = 1,
		QueryingBigTurn = 2,
		BigTurn = 3
	}

	// Constructors
	public SurroundInfo() {} // 0x0000000184E5B090-0x0000000184E5B100

	// Methods
	[BlackList] // 0x0000000189AE1E30-0x0000000189AE1E70
	// [XID] // 0x0000000189AE1E30-0x0000000189AE1E70
	public override void AutoAllocTypeFields() {} // 0x0000000184E59D80-0x0000000184E59E20
	[BlackList] // 0x0000000189AEC720-0x0000000189AEC760
	// [XID] // 0x0000000189AEC720-0x0000000189AEC760
	public override void AutoRecycleTypeFields() {} // 0x0000000184E59E20-0x0000000184E59EF0
	[BlackList] // 0x0000000189AF7120-0x0000000189AF7160
	// [XID] // 0x0000000189AF7120-0x0000000189AF7160
	public override void ReturnToObjectPool() {} // 0x0000000184E5AFF0-0x0000000184E5B090
	// [XID] // 0x0000000189B018A0-0x0000000189B018C0
	public override void Clear() {} // 0x0000000184E5A120-0x0000000184E5A1E0
	// [XID] // 0x0000000189B08DD0-0x0000000189B08DF0
	public override void Enter(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x0000000184E5ACA0-0x0000000184E5AD80
	// [XID] // 0x0000000189B108D0-0x0000000189B108F0
	public override void Leave(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x0000000184E5AA40-0x0000000184E5AB30
	// [XID] // 0x0000000189B17980-0x0000000189B179A0
	public override void OnPoseChanged() {} // 0x0000000184E5AB30-0x0000000184E5ABE0
	// [XID] // 0x0000000189B1F2E0-0x0000000189B1F300
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x0000000184E5A1E0-0x0000000184E5A600
	// [XID] // 0x0000000189B26AD0-0x0000000189B26AF0
	public void OnLeaveCombat() {} // 0x0000000184E59FB0-0x0000000184E5A060
	// [XID] // 0x0000000189B2A620-0x0000000189B2A640
	public void SetFixedPoint(Vector3? point) {} // 0x0000000184E59EF0-0x0000000184E59FB0
	// [XID] // 0x0000000189B35150-0x0000000189B35170
	public bool CheckClockwise(AIKnowledge aiKnowledge) => default; // 0x0000000184E5AD80-0x0000000184E5AFF0
	// [XID] // 0x0000000189B3CA20-0x0000000189B3CA40
	public bool CheckBigTurn(AIKnowledge knowledge, float detectDistance, float startOffsetUp, float startOffsetForward) => default; // 0x0000000184E5A690-0x0000000184E5A950
}

