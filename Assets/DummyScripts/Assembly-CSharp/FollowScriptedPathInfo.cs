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

public sealed class FollowScriptedPathInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20197
{
	// Fields
	public FollowPathStatus status; // 0x10
	public int currentIndex; // 0x14
	public bool movingForward; // 0x18
	public float waitFinishTick; // 0x1C

	// Nested types
	public enum FollowPathStatus // TypeDefIndex: 20198
	{
		ResumePath = 0,
		MoveToNextPoint = 1,
		WaitOnPoint = 2,
		Reached = 3,
		Done = 4
	}

	// Constructors
	public FollowScriptedPathInfo() {} // 0x0000000182041650-0x00000001820416C0

	// Methods
	[BlackList] // 0x000000018980C730-0x000000018980C770
	// [XID] // 0x000000018980C730-0x000000018980C770
	public override void AutoAllocTypeFields() {} // 0x00000001820401D0-0x0000000182040270
	[BlackList] // 0x0000000189817120-0x0000000189817160
	// [XID] // 0x0000000189817120-0x0000000189817160
	public override void AutoRecycleTypeFields() {} // 0x0000000182040270-0x0000000182040320
	[BlackList] // 0x0000000189821AF0-0x0000000189821B30
	// [XID] // 0x0000000189821AF0-0x0000000189821B30
	public override void ReturnToObjectPool() {} // 0x00000001820415B0-0x0000000182041650
	// [XID] // 0x000000018982C230-0x000000018982C250
	public override void Clear() {} // 0x00000001820405E0-0x0000000182040690
	// [XID] // 0x00000001898336E0-0x0000000189833700
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x0000000182040690-0x0000000182040E20
	// [XID] // 0x000000018983ABE0-0x000000018983AC00
	private bool IsArrive(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, ConfigAIFollowScriptedPathData followSetting) => default; // 0x0000000182040380-0x00000001820405E0
	// [XID] // 0x0000000189842220-0x0000000189842240
	public AIWaypoint GetCurrentWaypoint(AIWaypointRoute route) => default; // 0x0000000182041490-0x00000001820415B0
	// [XID] // 0x0000000189849640-0x0000000189849660
	private void RequestUpcomingPath(AIWaypointRoute route, uint runtimeID) {} // 0x0000000182040E20-0x0000000182041370
}

