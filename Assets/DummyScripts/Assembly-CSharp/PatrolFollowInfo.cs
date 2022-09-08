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

public sealed class PatrolFollowInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20223
{
	// Fields
	public PatrolFollowStatus status; // 0x10
	private LCAIBeta leader; // 0x18
	public Vector3 offsetPosition; // 0x20
	private Vector3? lastLeaderPosition; // 0x2C

	// Nested types
	public enum PatrolFollowStatus // TypeDefIndex: 20224
	{
		Inactive = 0,
		Charging = 1
	}

	// Constructors
	public PatrolFollowInfo() {} // 0x0000000181D66F20-0x0000000181D66F80

	// Methods
	[BlackList] // 0x0000000189BC2ED0-0x0000000189BC2F10
	// [XID] // 0x0000000189BC2ED0-0x0000000189BC2F10
	public override void AutoAllocTypeFields() {} // 0x0000000181D66020-0x0000000181D660C0
	[BlackList] // 0x0000000189BCD500-0x0000000189BCD540
	// [XID] // 0x0000000189BCD500-0x0000000189BCD540
	public override void AutoRecycleTypeFields() {} // 0x0000000181D660C0-0x0000000181D661A0
	[BlackList] // 0x0000000189BD7970-0x0000000189BD79B0
	// [XID] // 0x0000000189BD7970-0x0000000189BD79B0
	public override void ReturnToObjectPool() {} // 0x0000000181D66E80-0x0000000181D66F20
	// [XID] // 0x00000001895E7530-0x00000001895E7550
	public override void Clear() {} // 0x0000000181D662D0-0x0000000181D66390
	// [XID] // 0x00000001895EEE00-0x00000001895EEE20
	public void SetPatrolLeader(LCAIBeta leader, AIKnowledge aiKnowledge) {} // 0x0000000181D661A0-0x0000000181D66270
	// [XID] // 0x00000001895F67E0-0x00000001895F6800
	public Vector3 GetTargetPos() => default; // 0x0000000181D66B30-0x0000000181D66D30
	// [XID] // 0x00000001895FDC20-0x00000001895FDC40
	public bool IsLeaderValid() => default; // 0x0000000181D668E0-0x0000000181D669E0
	// [XID] // 0x0000000189605410-0x0000000189605430
	public override void Enter(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x0000000181D66D90-0x0000000181D66E80
	// [XID] // 0x000000018960CE20-0x000000018960CE40
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x0000000181D66390-0x0000000181D668E0
}

