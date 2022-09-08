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

public sealed class WanderInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20338
{
	// Fields
	public WanderStatus status; // 0x10
	public float nextAvailableTick; // 0x14
	public SimplePolygon? wanderArea; // 0x18
	public PathQueryTask wanderToPosPathCheckQuery; // 0x30
	public Vector3? wanderToPosCandidate; // 0x38

	// Nested types
	public enum WanderStatus // TypeDefIndex: 20339
	{
		Inactive = 0,
		Wandering = 1
	}

	// Constructors
	public WanderInfo() {} // 0x0000000184C4E9B0-0x0000000184C4EA50

	// Methods
	[BlackList] // 0x00000001895FC570-0x00000001895FC5B0
	// [XID] // 0x00000001895FC570-0x00000001895FC5B0
	public override void AutoAllocTypeFields() {} // 0x0000000184C4DA00-0x0000000184C4DAA0
	[BlackList] // 0x0000000189606D20-0x0000000189606D60
	// [XID] // 0x0000000189606D20-0x0000000189606D60
	public override void AutoRecycleTypeFields() {} // 0x0000000184C4DAA0-0x0000000184C4DB90
	[BlackList] // 0x00000001896117C0-0x0000000189611800
	// [XID] // 0x00000001896117C0-0x0000000189611800
	public override void ReturnToObjectPool() {} // 0x0000000184C4E910-0x0000000184C4E9B0
	// [XID] // 0x000000018961BDD0-0x000000018961BDF0
	public override void OnPoolAllocated() {} // 0x0000000184C4E840-0x0000000184C4E910
	// [XID] // 0x0000000189623340-0x0000000189623360
	public override void Clear() {} // 0x0000000184C4DBF0-0x0000000184C4DCE0
	// [XID] // 0x000000018962AB80-0x000000018962ABA0
	public override void Enter(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x0000000184C4E760-0x0000000184C4E840
	// [XID] // 0x00000001896322C0-0x00000001896322E0
	public override void Leave(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x0000000184C4E3B0-0x0000000184C4E4A0
	// [XID] // 0x0000000189639DB0-0x0000000189639DD0
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x0000000184C4DCE0-0x0000000184C4DFF0
	// [XID] // 0x0000000189641280-0x00000001896412A0
	public bool InWanderArea(Vector3 bornPos, Vector3 checkPos, ConfigAIWanderData wanderSetting) => default; // 0x0000000184C4E4A0-0x0000000184C4E6A0
	// [XID] // 0x0000000189648C00-0x0000000189648C20
	public void TriggerCD(AIKnowledge knowledge, bool byFail = false /* Metadata: 0x00AFD673 */) {} // 0x0000000184C4E0E0-0x0000000184C4E2C0
}

