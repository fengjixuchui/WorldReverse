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

public sealed class BrownianMoveInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20028
{
	// Fields
	public BrownianMotionStatus status; // 0x10
	public float nextAvailableTick; // 0x14
	public float nextReCalculateCenterTick; // 0x18
	public Vector3 brownianCenter; // 0x1C

	// Nested types
	public enum BrownianMotionStatus // TypeDefIndex: 20029
	{
		Inactive = 0,
		Resting = 1,
		Moving = 2
	}

	// Constructors
	public BrownianMoveInfo() {} // 0x0000000181239A70-0x0000000181239AE0

	// Methods
	[BlackList] // 0x00000001899E91F0-0x00000001899E9230
	// [XID] // 0x00000001899E91F0-0x00000001899E9230
	public override void AutoAllocTypeFields() {} // 0x0000000181238720-0x00000001812387C0
	[BlackList] // 0x00000001899F3D90-0x00000001899F3DD0
	// [XID] // 0x00000001899F3D90-0x00000001899F3DD0
	public override void AutoRecycleTypeFields() {} // 0x00000001812387C0-0x0000000181238890
	[BlackList] // 0x00000001899FE1F0-0x00000001899FE230
	// [XID] // 0x00000001899FE1F0-0x00000001899FE230
	public override void ReturnToObjectPool() {} // 0x00000001812399D0-0x0000000181239A70
	// [XID] // 0x0000000189A086F0-0x0000000189A08710
	public override void Clear() {} // 0x00000001812388F0-0x0000000181238990
	// [XID] // 0x0000000189A0FD10-0x0000000189A0FD30
	public override void Enter(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x0000000181239340-0x0000000181239420
	// [XID] // 0x0000000189A171B0-0x0000000189A171D0
	public override void Leave(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x0000000181238E90-0x0000000181238F70
	// [XID] // 0x0000000189A1E840-0x0000000189A1E860
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x0000000181238990-0x0000000181238D10
	// [XID] // 0x0000000189A25FB0-0x0000000189A25FD0
	private void ReCalculateCenter(AIKnowledge knowledge, bool force = false /* Metadata: 0x00AFD18E */) {} // 0x0000000181239420-0x00000001812397A0
	// [XID] // 0x0000000189A2D350-0x0000000189A2D370
	private bool CheckLeaveZone(AIKnowledge knowledge) => default; // 0x00000001812397A0-0x00000001812399D0
	// [XID] // 0x0000000189A34E30-0x0000000189A34E50
	private Vector3 FindNextDestination(AIKnowledge knowledge) => default; // 0x0000000181238FD0-0x00000001812392E0
}

