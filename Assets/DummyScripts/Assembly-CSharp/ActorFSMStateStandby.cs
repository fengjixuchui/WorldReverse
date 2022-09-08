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
public sealed class ActorFSMStateStandby : ActorFSMState, IAutoAllocRecycle // TypeDefIndex: 19942
{
	// Fields
	private const float PerformDurationMin = 3f; // Metadata: 0x00AFD126
	private float performingTime; // 0x30
	private float stateEnteringDelayTime; // 0x34
	private const float StateEnteringDelayMin = 0.2f; // Metadata: 0x00AFD12A
	private float steeringTime; // 0x38
	private const float SteeringDuration = 1f; // Metadata: 0x00AFD12E
	private float stateLeavingDelayTime; // 0x3C
	private const float StateLeavingDelayMin = 0.5f; // Metadata: 0x00AFD132
	private const float StateLeavingDelayMax = 1.5f; // Metadata: 0x00AFD136
	private const float StateLeavingCheckStartDelay = 1f; // Metadata: 0x00AFD13A
	private const float animTurnAngleMin = 5f; // Metadata: 0x00AFD13E
	private Vector3 steeringTarget; // 0x40
	private FocusToPlayerType focusToPlayerType; // 0x4C
	private bool didForcusToPlayer; // 0x50
	private const float FocusDurationMin = 3f; // Metadata: 0x00AFD142
	private const float FocusDurationMax = 5f; // Metadata: 0x00AFD146
	private NormalTimer focusTimer; // 0x58
	private static int STANDBY_HASH; // 0x00
	private SubState subState; // 0x60

	// Nested types
	private enum SubState // TypeDefIndex: 19943
	{
		None = 0,
		Entering = 1,
		Steering = 2,
		Waiting = 3,
		Leaving = 4
	}

	// Constructors
	public ActorFSMStateStandby() {} // 0x000000018353BA90-0x000000018353C000
	static ActorFSMStateStandby() {} // 0x000000018353BA20-0x000000018353BA90

	// Methods
	[BlackList] // 0x00000001898496E0-0x0000000189849720
	// [XID] // 0x00000001898496E0-0x0000000189849720
	public override void AutoAllocTypeFields() {} // 0x000000018353A1B0-0x000000018353A250
	[BlackList] // 0x0000000189853880-0x00000001898538C0
	// [XID] // 0x0000000189853880-0x00000001898538C0
	public override void AutoRecycleTypeFields() {} // 0x000000018353A250-0x000000018353A320
	[BlackList] // 0x000000018985DAD0-0x000000018985DB10
	// [XID] // 0x000000018985DAD0-0x000000018985DB10
	public override void ReturnToObjectPool() {} // 0x000000018353B980-0x000000018353BA20
	// [XID] // 0x00000001898684C0-0x00000001898684E0
	public void Init(NpcActor actor, ActorFSMBlackBoard board) {} // 0x000000018353A4A0-0x000000018353A5D0
	// [XID] // 0x000000018986F960-0x000000018986F980
	public override void Reason(float deltaTime) {} // 0x000000018353A5D0-0x000000018353A980
	// [XID] // 0x0000000189877030-0x0000000189877050
	public override void Act(float deltaTime) {} // 0x000000018353B070-0x000000018353B320
	// [XID] // 0x000000018987EA40-0x000000018987EA60
	public override void OnBeforePoolRecycled() {} // 0x000000018353B840-0x000000018353B920
	// [XID] // 0x0000000189885EE0-0x0000000189885F00
	private void PlayActionPointAnim(bool forcePlay) {} // 0x000000018353ACF0-0x000000018353AE10
	// [XID] // 0x000000018988D1E0-0x000000018988D200
	private int GetActionPointAnim() => default; // 0x000000018353B780-0x000000018353B840
	// [XID] // 0x00000001898947F0-0x0000000189894810
	private void DoEnterState() {} // 0x000000018353B320-0x000000018353B720
	// [XID] // 0x000000018989BE00-0x000000018989BE20
	public override void DoBeforeEntering() {} // 0x000000018353A980-0x000000018353AC30
	// [XID] // 0x00000001898A33A0-0x00000001898A33C0
	public override void DoBeforeLeaving() {} // 0x000000018353A0A0-0x000000018353A1B0
	// [XID] // 0x00000001898AA7A0-0x00000001898AA7C0
	private void LookForward() {} // 0x000000018353A380-0x000000018353A4A0
	// [XID] // 0x00000001898B21F0-0x00000001898B2210
	private void UpdateHeadCtrl() {} // 0x000000018353AE10-0x000000018353B010
}

