/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HumanoidMoveFSMDropState : HumanoidMoveFSMAirState // TypeDefIndex: 14661
{
	// Fields
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private bool _enableJumpOffWall; // 0x188
	private float _enterDropTime; // 0x18C
	private bool _crouchDrop; // 0x190

	// Constructors
	public HumanoidMoveFSMDropState() {} // Dummy constructor
	public HumanoidMoveFSMDropState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x00000001825B9670-0x00000001825B9710

	// Methods
	// [XID] // 0x0000000189B557A0-0x0000000189B557C0
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x00000001825B9260-0x00000001825B9470
	// [XID] // 0x0000000189B648B0-0x0000000189B648D0
	public override void LateTick() {} // 0x00000001825B8A20-0x00000001825B8FA0
	// [XID] // 0x0000000189B6BD00-0x0000000189B6BD20
	private void CheckJamProtection() {} // 0x00000001825B7970-0x00000001825B7F90
	// [XID] // 0x0000000189B73630-0x0000000189B73650
	protected override void Land(LandSpeedLevel landSpeedLevel) {} // 0x00000001825B82C0-0x00000001825B89A0
	// [XID] // 0x0000000189B7AAD0-0x0000000189B7AAF0
	public override void OnAnimatorMove() {} // 0x00000001825B77F0-0x00000001825B7970
	// [XID] // 0x0000000189B82310-0x0000000189B82330
	private void StartDrop() {} // 0x00000001825B9130-0x00000001825B9260
	// [XID] // 0x0000000189B89B90-0x0000000189B89BB0
	private void UpdateDropDown() {} // 0x00000001825B94E0-0x00000001825B9580
	// [XID] // 0x0000000189B91120-0x0000000189B91140
	protected override void Reset() {} // 0x00000001825B7610-0x00000001825B7720
	// [XID] // 0x0000000189B98390-0x0000000189B983B0
	private bool IsInDropDownLitTag() => default; // 0x00000001825B7F90-0x00000001825B8080
	// [XID] // 0x0000000189B9F8A0-0x0000000189B9F8C0
	private bool IsInDropDownTag() => default; // 0x00000001825B9580-0x00000001825B9670
	// [XID] // 0x0000000189BA7150-0x0000000189BA7170
	protected override MotionState GetCurrentSyncMotionState() => default; // 0x00000001825B73B0-0x00000001825B7450
	// [XID] // 0x0000000189BAE280-0x0000000189BAE2A0
	protected override void CreateFirstSyncPacket() {} // 0x00000001825B8080-0x00000001825B82C0
	// [XID] // 0x0000000189BB5BD0-0x0000000189BB5BF0
	public override void ShiftWorld(bool isRemote, Vector3 deltaShift) {} // 0x00000001825B8FA0-0x00000001825B9130
}

