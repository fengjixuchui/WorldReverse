/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using motion4hi;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HumanoidMoveEffectPlugin : BaseMoveEffectPlugin // TypeDefIndex: 12049
{
	// Fields
	private VCHumanoidMove _vcHumanoidMove; // 0xA8
	private AnimatorController _cont; // 0xB0
	private Transform _rFoot; // 0xB8
	private Transform _lFoot; // 0xC0
	private Transform _rCalf; // 0xC8
	private Transform _lCalf; // 0xD0
	private Transform _rThigh; // 0xD8
	private Transform _lThigh; // 0xE0
	private Transform _lHand; // 0xE8
	private Transform _rHand; // 0xF0
	private Transform _waterPointTrans; // 0xF8
	private Transform _waterSpaceFollowPointTrans; // 0x100
	private Transform _waterTrans; // 0x108
	private Vector3 _curWaterTransStartPos; // 0x110
	private HumanoidMoveFSMBaseMoveState _curState; // 0x120
	private VCHumanoidMoveData _humanoidMoveData; // 0x128
	private int _swimMoveRippleEffectId; // 0x130
	private int _swimIdleRippleEffectId; // 0x134
	private int _swimDashEffectId; // 0x138
	private int _walkOnWaterDeepEffectId; // 0x13C
	private int _sprintEffectId; // 0x140
	private int _waterLayerMask; // 0x144
	private bool _enableCalfToThighWalkStepEffect; // 0x148
	private const string CURRENT_WATER_SURFACE_POINT_NAME = "WaterPoint"; // Metadata: 0x00AEB3B2
	private const string CURRENT_WATER_CUSTOM_SPACE_NAME = "WaterSpaceFollowPoint"; // Metadata: 0x00AEB3C0
	private const float RUN_DEEP_WATER_EFFECT_THRESHOLD = 0.3f; // Metadata: 0x00AEB3D9
	private const float WATER_BIG_SPLASH_VELOCITY_THRESHOLD = 12f; // Metadata: 0x00AEB3DD
	private const float WATER_SMALL_SPLASH_VELOCITY_THRESHOLD = 7f; // Metadata: 0x00AEB3E1
	private ConfigFootprint _footprintConfig; // 0x150

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018973E2E0-0x000000018973E300 */ get => default; } // 0x000000018186E6E0-0x000000018186E780 

	// Constructors
	public HumanoidMoveEffectPlugin() {} // Dummy constructor
	public HumanoidMoveEffectPlugin(VCHumanoidMove moveComponent) {} // 0x000000018186E610-0x000000018186E6E0

	// Methods
	// [XID] // 0x0000000189745550-0x0000000189745570
	public override void Init() {} // 0x000000018186C6D0-0x000000018186C9F0
	// [XID] // 0x000000018974D050-0x000000018974D070
	public override void LateTick(float inDeltaTime) {} // 0x000000018186CD70-0x000000018186D200
	// [XID] // 0x0000000189754590-0x00000001897545B0
	public void UpdateSprinteEffect() {} // 0x0000000181868B20-0x0000000181868D60
	// [XID] // 0x000000018975B7F0-0x000000018975B810
	public void OnWalkStepOnWater(AnimatorEventWaterEffectStep evt, float inDeltaTime) {} // 0x000000018186A8A0-0x000000018186ABA0
	// [XID] // 0x0000000189763220-0x0000000189763240
	public void OnSwimDashHandEffect(AnimatorEventSwimDashHandEffect evt, float inDeltaTime) {} // 0x000000018186B640-0x000000018186C170
	// [XID] // 0x000000018976A9F0-0x000000018976AA10
	public void PlayJumpWaterEffect(float inDeltaTime) {} // 0x000000018186C9F0-0x000000018186CD70
	// [XID] // 0x0000000189771FD0-0x0000000189771FF0
	public void OnJumpLanded(float inDeltaTime) {} // 0x0000000181869100-0x00000001818695E0
	// [XID] // 0x0000000189779800-0x0000000189779820
	private void FireWalkOnWaterEffect(Vector3 calf, Vector3 foot, Vector3 thigh, float inDeltaTime) {} // 0x000000018186ABA0-0x000000018186B640
	// [XID] // 0x0000000189781180-0x00000001897811A0
	protected override void UpdateWaterEffect(float inDeltaTime) {} // 0x0000000181869730-0x000000018186A540
	// [XID] // 0x0000000189788640-0x0000000189788660
	private void UpdateMoveWaterEffect(float inDeltaTime) {} // 0x000000018186D980-0x000000018186E3D0
	// [XID] // 0x000000018978FD00-0x000000018978FD20
	public void SetCalfToThighWalkStepEffect(bool Enable) {} // 0x000000018186A5A0-0x000000018186A650
	// [XID] // 0x0000000189797550-0x0000000189797570
	private void DisableSwimEffect() {} // 0x0000000181869660-0x0000000181869730
	// [XID] // 0x000000018979F450-0x000000018979F470
	private void DetachEffect(ref int id) {} // 0x000000018186E520-0x000000018186E610
	// [XID] // 0x00000001897A6A60-0x00000001897A6A80
	public override void OnDisable() {} // 0x000000018186E450-0x000000018186E520
	// [XID] // 0x00000001897AE1C0-0x00000001897AE1E0
	public void OnAnimatorEventWalkStep(AnimatorEventWalkStep step) {} // 0x000000018186C170-0x000000018186C6D0
	// [XID] // 0x00000001897B6290-0x00000001897B62B0
	private bool IsEntityInOccluder() => default; // 0x0000000181868D60-0x0000000181868FD0
	// [XID] // 0x00000001897BE040-0x00000001897BE060
	private void InitFootprint() {} // 0x0000000181868FD0-0x0000000181869100
	// [XID] // 0x00000001897C5640-0x00000001897C5660
	public void ShowFootsprint(MoleMole.SceneSurfaceMaterial surface, Vector3 pos) {} // 0x000000018186D200-0x000000018186D760
	// [XID] // 0x00000001897CCCA0-0x00000001897CCCC0
	private ConfigFootprintEffect GetFootprintEffect(SceneSurfaceType configSurface) => default; // 0x000000018186A650-0x000000018186A8A0
	// [XID] // 0x00000001897A6B20-0x00000001897A6B40
	public bool ShiftWorld(Vector3 deltaShift) => default; // 0x000000018186D760-0x000000018186D910
}

