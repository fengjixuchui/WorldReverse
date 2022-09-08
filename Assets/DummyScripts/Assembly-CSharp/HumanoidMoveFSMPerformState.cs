/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HumanoidMoveFSMPerformState : HumanoidMoveFSMMoveState // TypeDefIndex: 14680
{
	// Fields
	private int _sitDownHash; // 0x1D8
	private int _sitLoopHash; // 0x1DC
	private int _sitBLoopHash; // 0x1E0
	private int _delayCount; // 0x1E4
	private const int DELAY_COUNT = 5; // Metadata: 0x00AEBD2F
	private bool _isSit; // 0x1E8

	// Constructors
	public HumanoidMoveFSMPerformState() {} // Dummy constructor
	public HumanoidMoveFSMPerformState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x0000000182E0B210-0x0000000182E0B300

	// Methods
	// [XID] // 0x0000000189905C20-0x0000000189905C40
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x0000000182E0ACC0-0x0000000182E0B1B0
	// [XID] // 0x0000000189914D30-0x0000000189914D50
	public override void Exit(HumanoidMoveFSM.FSMStateID nextState) {} // 0x0000000182E0ABD0-0x0000000182E0ACC0
	// [XID] // 0x000000018991C990-0x000000018991C9B0
	public override void OnAnimatorMove() {} // 0x0000000182E09C10-0x0000000182E09E30
	// [XID] // 0x00000001899241F0-0x0000000189924210
	public override void LateTick() {} // 0x0000000182E0A6D0-0x0000000182E0A8B0
	// [XID] // 0x000000018992B6A0-0x000000018992B6C0
	public override void SyncLateTick() {} // 0x0000000182E0AB20-0x0000000182E0ABD0
	// [XID] // 0x0000000189932E80-0x0000000189932EA0
	protected override void DealSprintBS() {} // 0x0000000182E0A120-0x0000000182E0A260
	// [XID] // 0x000000018993A740-0x000000018993A760
	public override void CreateSyncTaskByTimeInterval() {} // 0x0000000182E0A310-0x0000000182E0A590
	// [XID] // 0x0000000189941790-0x00000001899417B0
	public override void InitSyncWithCurrentTask(bool setPosition) {} // 0x0000000182E0A8B0-0x0000000182E0AB20
	// [XID] // 0x00000001899492B0-0x00000001899492D0
	public override void OnStayInPlace() {} // 0x0000000182E09EB0-0x0000000182E0A050
	// [XID] // 0x0000000189950B50-0x0000000189950B70
	private int CheckSitPos() => default; // 0x0000000182E099D0-0x0000000182E09AE0
	// [XID] // 0x0000000189958310-0x0000000189958330
	public override bool IsInSit() => default; // 0x0000000182E0A260-0x0000000182E0A310
}

