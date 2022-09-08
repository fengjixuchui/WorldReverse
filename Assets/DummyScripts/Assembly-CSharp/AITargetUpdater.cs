/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AITargetUpdater : BrainModuleBase // TypeDefIndex: 20440
{
	// Fields
	private AIPathfinding _pathfinder; // 0x30
	private PathQueryTask _targetPathQuery; // 0x38
	private float _targetPathQueryNextTick; // 0x40
	private static float TARGET_PATHQUERY_INTERVAL; // 0x00
	private int lastQueryId; // 0x44

	// Constructors
	public AITargetUpdater() {} // Dummy constructor
	public AITargetUpdater(AIKnowledge knowledge, AIPathfinding pathfinder) {} // 0x0000000183059D80-0x0000000183059E70
	static AITargetUpdater() {} // 0x0000000183059D20-0x0000000183059D80

	// Methods
	// [XID] // 0x0000000189929480-0x00000001899294A0
	protected override void ClearInternal(BaseEntity.ClearReason reason) {} // 0x0000000183059610-0x00000001830596E0
	// [XID] // 0x0000000189930B40-0x0000000189930B60
	protected override void UpdateMainThreadInternal(float deltaTime) {} // 0x0000000183059760-0x0000000183059830
	// [XID] // 0x0000000189937EF0-0x0000000189937F10
	protected override void UpdateComputeThreadInternal(float deltaTime) {} // 0x0000000183058D70-0x0000000183058E40
	// [XID] // 0x000000018993F9A0-0x000000018993F9C0
	private void Collect(AITargetKnowledge tk) {} // 0x00000001830589A0-0x0000000183058D70
	// [XID] // 0x0000000189947080-0x00000001899470A0
	private void DebugLogFindPath(AITargetKnowledge tk, AITargetHasPathType hasPathToTarget) {} // 0x00000001830598A0-0x0000000183059D20
	// [XID] // 0x000000018994E6E0-0x000000018994E700
	private void Process(AITargetKnowledge tk) {} // 0x0000000183058EC0-0x0000000183059610
}

