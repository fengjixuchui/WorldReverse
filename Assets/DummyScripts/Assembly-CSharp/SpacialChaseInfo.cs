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

public sealed class SpacialChaseInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20329
{
	// Fields
	public SpacialChaseStatus status; // 0x10
	public Vector3 chasingPoint; // 0x14
	public float segmentAngleVariance; // 0x20

	// Nested types
	public enum SpacialChaseStatus // TypeDefIndex: 20330
	{
		Chasing = 0,
		Finished = 1
	}

	// Constructors
	public SpacialChaseInfo() {} // 0x0000000184AD8ED0-0x0000000184AD8F40

	// Methods
	[BlackList] // 0x0000000189A216F0-0x0000000189A21730
	// [XID] // 0x0000000189A216F0-0x0000000189A21730
	public override void AutoAllocTypeFields() {} // 0x0000000184AD7AA0-0x0000000184AD7B40
	[BlackList] // 0x0000000189A2BBB0-0x0000000189A2BBF0
	// [XID] // 0x0000000189A2BBB0-0x0000000189A2BBF0
	public override void AutoRecycleTypeFields() {} // 0x0000000184AD7B40-0x0000000184AD7C00
	[BlackList] // 0x0000000189A36650-0x0000000189A36690
	// [XID] // 0x0000000189A36650-0x0000000189A36690
	public override void ReturnToObjectPool() {} // 0x0000000184AD8E30-0x0000000184AD8ED0
	// [XID] // 0x0000000189A40C90-0x0000000189A40CB0
	public override void OnPoolAllocated() {} // 0x0000000184AD8D50-0x0000000184AD8E30
	// [XID] // 0x0000000189A48310-0x0000000189A48330
	public override void Clear() {} // 0x0000000184AD8360-0x0000000184AD8450
	// [XID] // 0x0000000189A4FBE0-0x0000000189A4FC00
	public override void Enter(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x0000000184AD8B50-0x0000000184AD8D50
	// [XID] // 0x0000000189A57110-0x0000000189A57130
	public override void Leave(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x0000000184AD89B0-0x0000000184AD8A90
	// [XID] // 0x0000000189A5ECD0-0x0000000189A5ECF0
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x0000000184AD8450-0x0000000184AD87D0
	// [XID] // 0x0000000189A664B0-0x0000000189A664D0
	private Vector3 FindFlyToPosition(AIKnowledge knowledge) => default; // 0x0000000184AD7C00-0x0000000184AD8300
}

