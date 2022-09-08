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

public sealed class CombatFollowMoveInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20030
{
	// Fields
	private CombatFollowMoveStatus _preStatus; // 0x10
	public CombatFollowMoveStatus status; // 0x14
	public Vector3 curDestination; // 0x18

	// Nested types
	public enum CombatFollowMoveStatus // TypeDefIndex: 20031
	{
		Inactive = 0,
		FollowingInner = 1,
		FollowingMiddle = 2,
		FollowingOuter = 3
	}

	// Constructors
	public CombatFollowMoveInfo() {} // 0x0000000182166CC0-0x0000000182166D20

	// Methods
	[BlackList] // 0x0000000189A3C1C0-0x0000000189A3C200
	// [XID] // 0x0000000189A3C1C0-0x0000000189A3C200
	public override void AutoAllocTypeFields() {} // 0x0000000182165870-0x0000000182165910
	[BlackList] // 0x0000000189A46BB0-0x0000000189A46BF0
	// [XID] // 0x0000000189A46BB0-0x0000000189A46BF0
	public override void AutoRecycleTypeFields() {} // 0x0000000182165910-0x00000001821659D0
	[BlackList] // 0x0000000189A513F0-0x0000000189A51430
	// [XID] // 0x0000000189A513F0-0x0000000189A51430
	public override void ReturnToObjectPool() {} // 0x0000000182166C20-0x0000000182166CC0
	// [XID] // 0x0000000189A5BDC0-0x0000000189A5BDE0
	public override void OnPoolAllocated() {} // 0x0000000182166B30-0x0000000182166C20
	// [XID] // 0x0000000189A63530-0x0000000189A63550
	public override void Clear() {} // 0x0000000182165A30-0x0000000182165B20
	// [XID] // 0x0000000189A6AFB0-0x0000000189A6AFD0
	public override void Enter(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x00000001821669B0-0x0000000182166B30
	// [XID] // 0x0000000189A726A0-0x0000000189A726C0
	public override void Leave(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x00000001821665C0-0x00000001821666F0
	// [XID] // 0x0000000189A7A2F0-0x0000000189A7A310
	private bool IsMeleeTargetPosChanged(AIKnowledge aiKnowledge, LCAIManager aiManager, AIMoveSpeedLevel speedLevel, ref Vector3 meleePos) => default; // 0x00000001821666F0-0x00000001821668F0
	// [XID] // 0x0000000189A81710-0x0000000189A81730
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x0000000182165B20-0x0000000182166230
	// [XID] // 0x0000000189A891D0-0x0000000189A891F0
	public bool CanFollow(AIKnowledge aiKnowledge) => default; // 0x0000000182166380-0x0000000182166530
}

