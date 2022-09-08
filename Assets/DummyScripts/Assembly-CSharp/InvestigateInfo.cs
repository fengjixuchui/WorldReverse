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

public sealed class InvestigateInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20206
{
	// Fields
	public InvestigateStatus status; // 0x10
	public Vector3 startPos; // 0x14
	public Vector3 inspectPos; // 0x20
	public Vector3 searchPos; // 0x2C
	public Vector3 interestPosition; // 0x38
	public bool becomeInterested; // 0x44
	public bool needInvestigate; // 0x45
	public float inspectEndTick; // 0x48

	// Nested types
	public enum InvestigateStatus // TypeDefIndex: 20207
	{
		Inactive = 0,
		Inspect = 1,
		LookAround = 2,
		ReturnToStart = 3
	}

	// Constructors
	public InvestigateInfo() {} // 0x00000001843C2280-0x00000001843C22F0

	// Methods
	[BlackList] // 0x0000000189B66F00-0x0000000189B66F40
	// [XID] // 0x0000000189B66F00-0x0000000189B66F40
	public override void AutoAllocTypeFields() {} // 0x00000001843C1480-0x00000001843C1520
	[BlackList] // 0x0000000189B71410-0x0000000189B71450
	// [XID] // 0x0000000189B71410-0x0000000189B71450
	public override void AutoRecycleTypeFields() {} // 0x00000001843C1520-0x00000001843C1620
	[BlackList] // 0x0000000189B7B790-0x0000000189B7B7D0
	// [XID] // 0x0000000189B7B790-0x0000000189B7B7D0
	public override void ReturnToObjectPool() {} // 0x00000001843C21E0-0x00000001843C2280
	// [XID] // 0x0000000189B86230-0x0000000189B86250
	public override void OnPoolAllocated() {} // 0x00000001843C20A0-0x00000001843C21E0
	// [XID] // 0x0000000189B8D2D0-0x0000000189B8D2F0
	public override void Clear() {} // 0x00000001843C1730-0x00000001843C1880
	// [XID] // 0x0000000189B949F0-0x0000000189B94A10
	public override void Enter(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x00000001843C1F40-0x00000001843C20A0
	// [XID] // 0x0000000189B9C0A0-0x0000000189B9C0C0
	public override void Leave(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x00000001843C1DA0-0x00000001843C1E80
	// [XID] // 0x0000000189BA3830-0x0000000189BA3850
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x00000001843C1880-0x00000001843C1BC0
	// [XID] // 0x0000000189B2A640-0x0000000189B2A660
	public bool IsInvestigating() => default; // 0x00000001843C1620-0x00000001843C16D0
}

