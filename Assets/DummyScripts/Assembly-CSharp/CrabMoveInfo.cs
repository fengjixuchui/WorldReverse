/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CrabMoveInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20033
{
	// Fields
	public CrabMoveStatus status; // 0x10
	public bool clockwise; // 0x14
	private float _moveTimeup; // 0x18
	private float _waitTimeup; // 0x1C

	// Nested types
	public enum CrabMoveStatus // TypeDefIndex: 20034
	{
		Rest = 0,
		Moving = 1
	}

	// Constructors
	public CrabMoveInfo() {} // 0x00000001848CDBB0-0x00000001848CDC20

	// Methods
	[BlackList] // 0x0000000189ABEF90-0x0000000189ABEFD0
	// [XID] // 0x0000000189ABEF90-0x0000000189ABEFD0
	public override void AutoAllocTypeFields() {} // 0x00000001848CD170-0x00000001848CD210
	[BlackList] // 0x0000000189AC9860-0x0000000189AC98A0
	// [XID] // 0x0000000189AC9860-0x0000000189AC98A0
	public override void AutoRecycleTypeFields() {} // 0x00000001848CD210-0x00000001848CD2C0
	[BlackList] // 0x0000000189AD4590-0x0000000189AD45D0
	// [XID] // 0x0000000189AD4590-0x0000000189AD45D0
	public override void ReturnToObjectPool() {} // 0x00000001848CDB10-0x00000001848CDBB0
	// [XID] // 0x0000000189ADF050-0x0000000189ADF070
	public override void Clear() {} // 0x00000001848CD320-0x00000001848CD3D0
	// [XID] // 0x0000000189AE6900-0x0000000189AE6920
	public override void Enter(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x00000001848CDA30-0x00000001848CDB10
	// [XID] // 0x0000000189AEE2E0-0x0000000189AEE300
	public override void Leave(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x00000001848CD890-0x00000001848CD970
	// [XID] // 0x0000000189AF5950-0x0000000189AF5970
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x00000001848CD3D0-0x00000001848CD710
}

