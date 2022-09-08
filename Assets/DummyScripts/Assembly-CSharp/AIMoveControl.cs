/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AIMoveControl : AIBaseControl // TypeDefIndex: 20421
{
	// Fields
	private LCAIBeta _lcai; // 0x18
	private AILocomotionHandler _loco; // 0x20
	private AIPathfinding _pathfinder; // 0x28
	private AIMoveControlState _moveFSM; // 0x30

	// Constructors
	public AIMoveControl() {} // Dummy constructor
	public AIMoveControl(LCAIBeta ai, AIKnowledge knowledge, AIPathfinding pathfinder) {} // 0x0000000182AD5330-0x0000000182AD53F0

	// Methods
	// [XID] // 0x000000018977EAA0-0x000000018977EAC0
	public void RefreshMoveTaskByPosition(Vector3 position) {} // 0x0000000182AD4CB0-0x0000000182AD4E50
	// [XID] // 0x0000000189786240-0x0000000189786260
	public void Clear(BaseEntity.ClearReason reason) {} // 0x0000000182AD4E50-0x0000000182AD4F10
	// [XID] // 0x000000018978D8D0-0x000000018978D8F0
	public void ExecuteMove(AIDecision decision, float deltaTime) {} // 0x0000000182AD4F10-0x0000000182AD5290
	// [XID] // 0x0000000189794DA0-0x0000000189794DC0
	public AILocomotionHandler GetLocomotion() => default; // 0x0000000182AD5290-0x0000000182AD5330
}

