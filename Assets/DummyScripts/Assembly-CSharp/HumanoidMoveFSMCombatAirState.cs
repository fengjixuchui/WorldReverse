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

public sealed class HumanoidMoveFSMCombatAirState : HumanoidMoveFSMAirState // TypeDefIndex: 14657
{
	// Fields
	public const float V_Y_MIN = -20f; // Metadata: 0x00AEBB37
	public const float IN_AIR_MIN_TIME = 0.1f; // Metadata: 0x00AEBB3B
	private VCCharacterCombat _characterCombat; // 0x188
	private float _startedTime; // 0x190

	// Constructors
	public HumanoidMoveFSMCombatAirState() {} // Dummy constructor
	public HumanoidMoveFSMCombatAirState(HumanoidMoveFSM fsm, VCHumanoidMove vcHumanoidMove, HumanoidMoveFSM.FSMStateID stateID) {} // 0x00000001835CB470-0x00000001835CB530

	// Methods
	// [XID] // 0x00000001899A9A40-0x00000001899A9A60
	protected override bool DealAirJump() => default; // 0x00000001835CA0E0-0x00000001835CA210
	// [XID] // 0x00000001899B1440-0x00000001899B1460
	public override void LateTick() {} // 0x00000001835CAC70-0x00000001835CB150
	// [XID] // 0x00000001899B88C0-0x00000001899B88E0
	public override bool CanDoJump() => default; // 0x00000001835CAA30-0x00000001835CABF0
	// [XID] // 0x00000001899C0190-0x00000001899C01B0
	protected override void SetAirMotionflag() {} // 0x00000001835C9FF0-0x00000001835CA0E0
	// [XID] // 0x00000001899C79F0-0x00000001899C7A10
	public override void Enter(HumanoidMoveFSM.FSMStateID formerStateId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x00000001835CB200-0x00000001835CB3B0
	// [XID] // 0x00000001899D66B0-0x00000001899D66D0
	protected override void Reset() {} // 0x00000001835C9DE0-0x00000001835C9F20
	// [XID] // 0x00000001899DDD90-0x00000001899DDDB0
	protected override void Land(LandSpeedLevel landSpeedLevel) {} // 0x00000001835CA3F0-0x00000001835CAA30
	// [XID] // 0x00000001899E5AF0-0x00000001899E5B10
	public override void SyncLateTick() {} // 0x00000001835CB150-0x00000001835CB200
	// [XID] // 0x00000001899ECBC0-0x00000001899ECBE0
	public override void CreateSyncTaskByTimeInterval() {} // 0x00000001835CA2F0-0x00000001835CA390
}

