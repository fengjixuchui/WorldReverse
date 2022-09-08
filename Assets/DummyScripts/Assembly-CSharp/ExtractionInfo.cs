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

public sealed class ExtractionInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20188
{
	// Fields
	public ExtractionStatus status; // 0x10
	public LevelActionPoint levelExtractionPoint; // 0x18
	private bool fleeKillSelf; // 0x20
	private float fleeKillSelfStartTime; // 0x24

	// Nested types
	public enum ExtractionStatus // TypeDefIndex: 20189
	{
		Inactive = 0,
		OnMove = 1
	}

	// Constructors
	public ExtractionInfo() {} // 0x00000001830F79B0-0x00000001830F7A20

	// Methods
	[BlackList] // 0x0000000189680810-0x0000000189680850
	// [XID] // 0x0000000189680810-0x0000000189680850
	public override void AutoAllocTypeFields() {} // 0x00000001830F6860-0x00000001830F6900
	[BlackList] // 0x000000018968B290-0x000000018968B2D0
	// [XID] // 0x000000018968B290-0x000000018968B2D0
	public override void AutoRecycleTypeFields() {} // 0x00000001830F6900-0x00000001830F69B0
	[BlackList] // 0x0000000189695CF0-0x0000000189695D30
	// [XID] // 0x0000000189695CF0-0x0000000189695D30
	public override void ReturnToObjectPool() {} // 0x00000001830F7910-0x00000001830F79B0
	// [XID] // 0x00000001896A0230-0x00000001896A0250
	public override void Clear() {} // 0x00000001830F6A10-0x00000001830F6AB0
	// [XID] // 0x00000001896A75A0-0x00000001896A75C0
	public override void Enter(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x00000001830F77E0-0x00000001830F7910
	// [XID] // 0x00000001896AEAA0-0x00000001896AEAC0
	public override void Leave(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x00000001830F7640-0x00000001830F7720
	// [XID] // 0x00000001896B62A0-0x00000001896B62C0
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x00000001830F6AB0-0x00000001830F6DF0
	// [XID] // 0x00000001896BD4C0-0x00000001896BD4E0
	private static Vector3 GenerateExtractionPoint(AIKnowledge knowledge) => default; // 0x00000001830F6E80-0x00000001830F7550
}

