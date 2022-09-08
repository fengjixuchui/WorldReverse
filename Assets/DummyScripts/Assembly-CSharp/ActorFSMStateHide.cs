/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public sealed class ActorFSMStateHide : ActorFSMState, IAutoAllocRecycle // TypeDefIndex: 19936
{
	// Fields
	private SubState subState; // 0x30
	private const float DITHER_EFFECT_DURATION = 2f; // Metadata: 0x00AFD0D6
	private const float DITHER_TIMER_DURATION = 2.2f; // Metadata: 0x00AFD0DA
	private NormalTimer ditherTimer; // 0x38

	// Nested types
	private enum SubState // TypeDefIndex: 19937
	{
		None = 0,
		Waiting = 1,
		TransitToHide = 2,
		TransitToUnHide = 3,
		ReadyToLeave = 4
	}

	// Constructors
	public ActorFSMStateHide() {} // 0x0000000184AA11A0-0x0000000184AA1200

	// Methods
	[BlackList] // 0x00000001896474F0-0x0000000189647530
	// [XID] // 0x00000001896474F0-0x0000000189647530
	public override void AutoAllocTypeFields() {} // 0x0000000184A9FB90-0x0000000184A9FC30
	[BlackList] // 0x0000000189651C20-0x0000000189651C60
	// [XID] // 0x0000000189651C20-0x0000000189651C60
	public override void AutoRecycleTypeFields() {} // 0x0000000184A9FC30-0x0000000184A9FCE0
	[BlackList] // 0x000000018965C450-0x000000018965C490
	// [XID] // 0x000000018965C450-0x000000018965C490
	public override void ReturnToObjectPool() {} // 0x0000000184AA1100-0x0000000184AA11A0
	// [XID] // 0x0000000189666B90-0x0000000189666BB0
	public void Init(NpcActor actor, ActorFSMBlackBoard board) {} // 0x0000000184AA03F0-0x0000000184AA05B0
	// [XID] // 0x000000018966E1B0-0x000000018966E1D0
	public override void OnBeforePoolRecycled() {} // 0x0000000184AA0E30-0x0000000184AA0F10
	// [XID] // 0x0000000189675FC0-0x0000000189675FE0
	public override void Reason(float deltaTime) {} // 0x0000000184AA05B0-0x0000000184AA0710
	// [XID] // 0x000000018967D8E0-0x000000018967D900
	public override void Act(float deltaTime) {} // 0x0000000184AA0A80-0x0000000184AA0DD0
	// [XID] // 0x0000000189684EA0-0x0000000189684EC0
	private bool IsOnHidingPosition() => default; // 0x0000000184AA0150-0x0000000184AA0310
	// [XID] // 0x000000018968CA00-0x000000018968CA20
	private Vector3 GetHidingPosition() => default; // 0x0000000184A9FCE0-0x0000000184A9FE90
	// [XID] // 0x0000000189694510-0x0000000189694530
	public override void PerformResetState() {} // 0x0000000184AA00B0-0x0000000184AA0150
	// [XID] // 0x000000018969BB10-0x000000018969BB30
	private bool IsHidePattern() => default; // 0x0000000184AA07B0-0x0000000184AA0900
	// [XID] // 0x00000001896A3180-0x00000001896A31A0
	private void DoReset() {} // 0x0000000184AA0F70-0x0000000184AA1100
	// [XID] // 0x00000001896AA5F0-0x00000001896AA610
	public override void DoBeforeEntering() {} // 0x0000000184AA0710-0x0000000184AA07B0
	// [XID] // 0x00000001896B14B0-0x00000001896B14D0
	public override void DoBeforeLeaving() {} // 0x0000000184A9FA90-0x0000000184A9FB90
	// [XID] // 0x00000001896B8FD0-0x00000001896B8FF0
	private void OnDitherHideFinished(ILuaActor obj) {} // 0x0000000184AA0310-0x0000000184AA03F0
	// [XID] // 0x00000001896C0310-0x00000001896C0330
	private void OnDitherUnHideFinished(ILuaActor obj) {} // 0x0000000184A9FE90-0x0000000184A9FF50
	// [XID] // 0x00000001896C7A50-0x00000001896C7A70
	public void PerformFSMTransition(GeneralPattern targetPattern) {} // 0x0000000184A9FFB0-0x0000000184AA00B0
}

