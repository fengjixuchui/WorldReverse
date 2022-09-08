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

public sealed class HumanoidMoveFSMFlyFollowRouteState : HumanoidMoveFSMBaseMoveState // TypeDefIndex: 14663
{
	// Fields
	private const float ANGULAR_VELOCITY = 10f; // Metadata: 0x00AEBB54
	private const float MOVE_RADUIUS = 10f; // Metadata: 0x00AEBB58
	private int currentMarkType; // 0x140
	private int effectIndex; // 0x144
	private int currentIndex; // 0x148
	private Vector3 nextPos; // 0x14C
	private bool authorityUseSimulateRoute; // 0x158
	private PlatformRoutePlugin _routePlugin; // 0x160
	private const string DEFAULT_EFFECT = "Eff_Avatar_Girl_Catalyst_Mona_LiquidStrike_Spray"; // Metadata: 0x00AEBB5C
	private PlatformInfo info; // 0x168

	// Constructors
	public HumanoidMoveFSMFlyFollowRouteState() {} // Dummy constructor
	public HumanoidMoveFSMFlyFollowRouteState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x00000001827CF330-0x00000001827CF410

	// Methods
	// [XID] // 0x000000018960DA30-0x000000018960DA50
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x00000001827CDDF0-0x00000001827CE030
	// [XID] // 0x000000018961C900-0x000000018961C920
	public void InitFromProto(AvatarFollowRouteNotify ntf = null) {} // 0x00000001827CC360-0x00000001827CC700
	// [XID] // 0x0000000189623E80-0x0000000189623EA0
	public void InitWithRoute(Route r, uint time) {} // 0x00000001827CC8D0-0x00000001827CCC20
	// [XID] // 0x00000001896439A0-0x00000001896439C0
	private void HandleMarkType(int type) {} // 0x00000001827CCF00-0x00000001827CD120
	// [XID] // 0x0000000189632DB0-0x0000000189632DD0
	public override void InitSyncWithCurrentTask(bool setPosition) {} // 0x00000001827CD910-0x00000001827CDB60
	// [XID] // 0x000000018963A8F0-0x000000018963A910
	public Route BuildTestRoute() => default; // 0x00000001827CB100-0x00000001827CC2C0
	// [XID] // 0x0000000189641FD0-0x0000000189641FF0
	public override void LateTick() {} // 0x00000001827CD200-0x00000001827CD4E0
	// [XID] // 0x0000000189649840-0x0000000189649860
	private void TryMoveToNextRoutePoint() {} // 0x00000001827CED00-0x00000001827CF2D0
	// [XID] // 0x0000000189650F40-0x0000000189650F60
	public override void CreateSyncTaskByTimeInterval() {} // 0x00000001827CCCA0-0x00000001827CCF00
	// [XID] // 0x0000000189658690-0x00000001896586B0
	protected override MotionState GetCurrentSyncMotionState() => default; // 0x00000001827CC2C0-0x00000001827CC360
	// [XID] // 0x000000018965FC80-0x000000018965FCA0
	public override void SyncLateTick() {} // 0x00000001827CDB60-0x00000001827CDC60
	// [XID] // 0x0000000189667760-0x0000000189667780
	private void ProcessCurrentMoveTask() {} // 0x00000001827CE030-0x00000001827CE6D0
	// [XID] // 0x000000018966EFA0-0x000000018966EFC0
	protected override void DoSteer() {} // 0x00000001827CD4E0-0x00000001827CD810
	// [XID] // 0x00000001896768D0-0x00000001896768F0
	private void TransferToOtherSyncState() {} // 0x00000001827CE6D0-0x00000001827CEC90
	// [XID] // 0x000000018967E120-0x000000018967E140
	public override void Exit(HumanoidMoveFSM.FSMStateID nextState) {} // 0x00000001827CDC60-0x00000001827CDDF0
	// [XID] // 0x0000000189685910-0x0000000189685930
	public override void ShiftWorld(bool isRemote, Vector3 deltaShift) {} // 0x00000001827CD810-0x00000001827CD910
}

