/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityEnviroFollowRotateMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14536
{
	// Fields
	public const float DELTA_ENVIRO_LOCAL_ANGLE = 45f; // Metadata: 0x00AEB7D6
	public const float DELTA_ENVIRO_FIX_ANGLE = 15f; // Metadata: 0x00AEB7DA
	public const float MOVING_SPEED = 30f; // Metadata: 0x00AEB7DE
	private EnviroFollowRotateMixin _config; // 0x70
	private Transform _enviroTrans; // 0x78
	private MonoTestDvalinS01 _stage; // 0x80
	private Quaternion _lastTargetRotation; // 0x88
	private Quaternion _originalRot; // 0x98
	private bool initialized; // 0xA8
	private bool inCutScene; // 0xA9
	private const float DRAGON_OFF_Z_SCALE = 0.01f; // Metadata: 0x00AEB7E2
	private Vector3 _dragonLocalOffSet; // 0xAC
	private Vector3 _offSpeed; // 0xB8

	// Constructors
	public AbilityEnviroFollowRotateMixin() {} // 0x0000000184ACD1A0-0x0000000184ACD270

	// Methods
	// [XID] // 0x0000000189BCE160-0x0000000189BCE180
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000184ACB270-0x0000000184ACB3B0
	// [XID] // 0x0000000189BD54D0-0x0000000189BD54F0
	private bool CheckInit() => default; // 0x0000000184ACC0B0-0x0000000184ACC570
	// [XID] // 0x0000000189BDD0D0-0x0000000189BDD0F0
	protected override void AddEventListener() {} // 0x0000000184ACAFE0-0x0000000184ACB160
	// [XID] // 0x00000001895E9AC0-0x00000001895E9AE0
	protected override void RemoveEventListener() {} // 0x0000000184ACC570-0x0000000184ACC6F0
	// [XID] // 0x00000001895F1160-0x00000001895F1180
	public override void OnAdded(bool syncToServer) {} // 0x0000000184ACACD0-0x0000000184ACAD90
	// [XID] // 0x00000001895F8CC0-0x00000001895F8CE0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000184ACB1C0-0x0000000184ACB270
	// [XID] // 0x00000001896000B0-0x00000001896000D0
	private void OnCutSceneStart(ConfigBaseCutscene configCutscne) {} // 0x0000000184ACB6A0-0x0000000184ACB7C0
	// [XID] // 0x0000000189607720-0x0000000189607740
	private void OnCutSceneFinish(ConfigBaseCutscene configCutscne) {} // 0x0000000184ACB540-0x0000000184ACB640
	// [XID] // 0x000000018960F2B0-0x000000018960F2D0
	public override void Clear() {} // 0x0000000184ACB4A0-0x0000000184ACB540
	// [XID] // 0x0000000189616850-0x0000000189616870
	public override void Tick(float inDeltaTime) {} // 0x0000000184ACC990-0x0000000184ACD1A0
	// [XID] // 0x000000018961E140-0x000000018961E160
	private void UpdateEnviroRotation(float deltaTime) {} // 0x0000000184ACB7C0-0x0000000184ACC0B0
	[BlackList] // 0x0000000189625610-0x0000000189625650
	// [XID] // 0x0000000189625610-0x0000000189625650
	public override void AutoAllocTypeFields() {} // 0x0000000184ACAE20-0x0000000184ACAEC0
	[BlackList] // 0x000000018962FEF0-0x000000018962FF30
	// [XID] // 0x000000018962FEF0-0x000000018962FF30
	public override void AutoRecycleTypeFields() {} // 0x0000000184ACAEC0-0x0000000184ACAFE0
	[BlackList] // 0x000000018963A930-0x000000018963A970
	// [XID] // 0x000000018963A930-0x000000018963A970
	public override void ReturnToObjectPool() {} // 0x0000000184ACC8F0-0x0000000184ACC990
}

