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

public sealed class ReturnToBornInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20229
{
	// Fields
	public Vector3? returnToPosition; // 0x10
	public Phase phase; // 0x20
	public bool hasFadeout; // 0x24
	public AccuracyMode accuracy; // 0x28

	// Nested types
	public enum Phase // TypeDefIndex: 20230
	{
		Inactive = 0,
		ReturnToBorn = 1,
		Fading = 2,
		Teleported = 3
	}

	public enum AccuracyMode // TypeDefIndex: 20231
	{
		Loose = 0,
		Exact = 1
	}

	// Constructors
	public ReturnToBornInfo() {} // 0x000000018201C0E0-0x000000018201C160

	// Methods
	[BlackList] // 0x0000000189834CF0-0x0000000189834D30
	// [XID] // 0x0000000189834CF0-0x0000000189834D30
	public override void AutoAllocTypeFields() {} // 0x000000018201AE60-0x000000018201AF00
	[BlackList] // 0x000000018983F370-0x000000018983F3B0
	// [XID] // 0x000000018983F370-0x000000018983F3B0
	public override void AutoRecycleTypeFields() {} // 0x000000018201AF00-0x000000018201AFC0
	[BlackList] // 0x0000000189849600-0x0000000189849640
	// [XID] // 0x0000000189849600-0x0000000189849640
	public override void ReturnToObjectPool() {} // 0x000000018201C040-0x000000018201C0E0
	// [XID] // 0x0000000189853820-0x0000000189853840
	public override void Clear() {} // 0x000000018201B4D0-0x000000018201B590
	// [XID] // 0x000000018985B2F0-0x000000018985B310
	public override void Enter(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x000000018201BD90-0x000000018201BEA0
	// [XID] // 0x0000000189862890-0x00000001898628B0
	public override void Leave(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x000000018201BBB0-0x000000018201BCD0
	// [XID] // 0x0000000189869CA0-0x0000000189869CC0
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x000000018201B590-0x000000018201BA30
	// [XID] // 0x0000000189870FC0-0x0000000189870FE0
	private void UpdatePhase(AIKnowledge knowledge) {} // 0x000000018201BEA0-0x000000018201C040
	// [XID] // 0x0000000189878970-0x0000000189878990
	private void PrepareReturnPlan(AIKnowledge knowledge, LCAIBeta lcai, AIMoveControlState moveState) {} // 0x000000018201AFC0-0x000000018201B470
}

