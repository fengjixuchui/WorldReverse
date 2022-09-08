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

public sealed class FindBackInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20191
{
	// Fields
	public FindBackStatus status; // 0x10
	public float nextAvailableTick; // 0x14
	public float nextOvertimeTick; // 0x18
	public float nextPhaseChangeTick; // 0x1C
	public Vector3 currentChasePos; // 0x20
	public Vector3 currentBackPos; // 0x2C

	// Nested types
	public enum FindBackStatus // TypeDefIndex: 20192
	{
		Inactive = 0,
		Chasing = 1,
		FindBack = 2,
		Finish = 3
	}

	// Constructors
	public FindBackInfo() {} // 0x0000000181FA9D50-0x0000000181FA9DC0

	// Methods
	[BlackList] // 0x0000000189708D60-0x0000000189708DA0
	// [XID] // 0x0000000189708D60-0x0000000189708DA0
	public override void AutoAllocTypeFields() {} // 0x0000000181FA8CD0-0x0000000181FA8D70
	[BlackList] // 0x0000000189713540-0x0000000189713580
	// [XID] // 0x0000000189713540-0x0000000189713580
	public override void AutoRecycleTypeFields() {} // 0x0000000181FA8D70-0x0000000181FA8E50
	[BlackList] // 0x000000018971DDA0-0x000000018971DDE0
	// [XID] // 0x000000018971DDA0-0x000000018971DDE0
	public override void ReturnToObjectPool() {} // 0x0000000181FA9CB0-0x0000000181FA9D50
	// [XID] // 0x0000000189728230-0x0000000189728250
	public override void Clear() {} // 0x0000000181FA8EB0-0x0000000181FA8FB0
	// [XID] // 0x000000018972F970-0x000000018972F990
	public override void Enter(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x0000000181FA9B70-0x0000000181FA9CB0
	// [XID] // 0x0000000189737360-0x0000000189737380
	public override void Leave(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x0000000181FA99D0-0x0000000181FA9AB0
	// [XID] // 0x000000018973EE60-0x000000018973EE80
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x0000000181FA8FB0-0x0000000181FA9850
}

