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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HumanoidMoveFSMFlyGateLoadingState : HumanoidMoveFSMBaseMoveState // TypeDefIndex: 14664
{
	// Fields
	private const float ANGULAR_VELOCITY = 10f; // Metadata: 0x00AEBB90
	private const float MOVE_RADUIUS = 10f; // Metadata: 0x00AEBB94
	private Vector3 _initPosition; // 0x140
	private Quaternion _initRotation; // 0x14C
	private float angle; // 0x15C

	// Constructors
	public HumanoidMoveFSMFlyGateLoadingState() {} // Dummy constructor
	public HumanoidMoveFSMFlyGateLoadingState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x0000000181A12E80-0x0000000181A12F10

	// Methods
	// [XID] // 0x000000018968D290-0x000000018968D2B0
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x0000000181A12BC0-0x0000000181A12E20
	// [XID] // 0x000000018969C5F0-0x000000018969C610
	public override void LateTick() {} // 0x0000000181A125B0-0x0000000181A128F0
	// [XID] // 0x00000001896A3B90-0x00000001896A3BB0
	public override void CreateSyncTaskByTimeInterval() {} // 0x0000000181A12490-0x0000000181A12530
	// [XID] // 0x00000001896AAF20-0x00000001896AAF40
	public override void Exit(HumanoidMoveFSM.FSMStateID nextState) {} // 0x0000000181A12A80-0x0000000181A12BC0
	// [XID] // 0x00000001896B2030-0x00000001896B2050
	public override void ShiftWorld(bool isRemote, Vector3 deltaShift) {} // 0x0000000181A128F0-0x0000000181A12A80
}

