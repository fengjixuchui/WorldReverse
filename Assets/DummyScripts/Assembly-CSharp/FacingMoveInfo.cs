/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FacingMoveInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20190
{
	// Fields
	private float nextTickPickDirection; // 0x10
	private float nextTickBackRaycast; // 0x14
	private float nextTickMoveDirObstacleCheck; // 0x18
	private bool isBackClear; // 0x1C
	private VCMoveData.MotionDirection currentMoveDirection; // 0x20
	private static List<VCMoveData.MotionDirection> moveDirList; // 0x00

	// Constructors
	public FacingMoveInfo() {} // 0x00000001841D4E20-0x00000001841D4E90
	static FacingMoveInfo() {} // 0x00000001841D4D30-0x00000001841D4E20

	// Methods
	[BlackList] // 0x00000001896C4B00-0x00000001896C4B40
	// [XID] // 0x00000001896C4B00-0x00000001896C4B40
	public override void AutoAllocTypeFields() {} // 0x00000001841D3B80-0x00000001841D3C20
	[BlackList] // 0x00000001896CF360-0x00000001896CF3A0
	// [XID] // 0x00000001896CF360-0x00000001896CF3A0
	public override void AutoRecycleTypeFields() {} // 0x00000001841D3C20-0x00000001841D3CD0
	[BlackList] // 0x00000001896D9690-0x00000001896D96D0
	// [XID] // 0x00000001896D9690-0x00000001896D96D0
	public override void ReturnToObjectPool() {} // 0x00000001841D4C90-0x00000001841D4D30
	// [XID] // 0x00000001896E3D10-0x00000001896E3D30
	public override void Clear() {} // 0x00000001841D4030-0x00000001841D40E0
	// [XID] // 0x00000001896EB040-0x00000001896EB060
	public override void Enter(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x00000001841D4BB0-0x00000001841D4C90
	// [XID] // 0x00000001896F2430-0x00000001896F2450
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x00000001841D40E0-0x00000001841D47C0
	// [XID] // 0x00000001896F9D90-0x00000001896F9DB0
	private VCMoveData.MotionDirection GetNewMoveDirection(ConfigAIFacingMoveWeight weight) => default; // 0x00000001841D48B0-0x00000001841D4AF0
	// [XID] // 0x0000000189701560-0x0000000189701580
	private bool CheckLRHitWall(AIKnowledge aiKnowledge, float obstacleDetectRange) => default; // 0x00000001841D3CD0-0x00000001841D3FD0
}

