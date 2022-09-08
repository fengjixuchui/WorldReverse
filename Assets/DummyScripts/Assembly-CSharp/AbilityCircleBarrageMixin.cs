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

public sealed class AbilityCircleBarrageMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14501
{
	// Fields
	private CircleBarrageMixin _config; // 0x70
	private int _waveLeft; // 0x78
	private float _waveCD; // 0x7C
	private float _triggerCD; // 0x80
	public Transform shootPoint; // 0x88

	// Constructors
	public AbilityCircleBarrageMixin() {} // 0x0000000181E665F0-0x0000000181E66660

	// Methods
	// [XID] // 0x0000000189AEA230-0x0000000189AEA250
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000181E65170-0x0000000181E653E0
	// [XID] // 0x0000000189AF1D50-0x0000000189AF1D70
	public override void Clear() {} // 0x0000000181E654D0-0x0000000181E65580
	// [XID] // 0x0000000189AF9700-0x0000000189AF9720
	private void RefreshShootPoint() {} // 0x0000000181E65FA0-0x0000000181E660A0
	// [XID] // 0x0000000189B00B50-0x0000000189B00B70
	private void RefreshFireCD() {} // 0x0000000181E66300-0x0000000181E663E0
	// [XID] // 0x0000000189B08130-0x0000000189B08150
	public override void OnAdded(bool syncToServer) {} // 0x0000000181E64B80-0x0000000181E64C50
	// [XID] // 0x0000000189B0F990-0x0000000189B0F9B0
	public override void LazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000181E64FA0-0x0000000181E650A0
	// [XID] // 0x0000000189B16BC0-0x0000000189B16BE0
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000181E64E40-0x0000000181E64F40
	// [XID] // 0x0000000189B1E3E0-0x0000000189B1E400
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000181E650A0-0x0000000181E65170
	// [XID] // 0x0000000189B25CC0-0x0000000189B25CE0
	public override void Tick(float inDeltaTime) {} // 0x0000000181E66480-0x0000000181E665F0
	// [XID] // 0x0000000189B2CFF0-0x0000000189B2D010
	private void Fire() {} // 0x0000000181E65580-0x0000000181E657E0
	// [XID] // 0x0000000189B344D0-0x0000000189B344F0
	private void FanTriggerBullets(Quaternion rot, Vector3 up, int num, float angle) {} // 0x0000000181E657E0-0x0000000181E65BE0
	// [XID] // 0x0000000189B3BD70-0x0000000189B3BD90
	private void TriggerBullet(uint bulletID, Vector3 bornPos, Quaternion bornRot) {} // 0x0000000181E65BE0-0x0000000181E65F40
	[BlackList] // 0x0000000189B43920-0x0000000189B43960
	// [XID] // 0x0000000189B43920-0x0000000189B43960
	public override void AutoAllocTypeFields() {} // 0x0000000181E64CE0-0x0000000181E64D80
	[BlackList] // 0x0000000189B4E170-0x0000000189B4E1B0
	// [XID] // 0x0000000189B4E170-0x0000000189B4E1B0
	public override void AutoRecycleTypeFields() {} // 0x0000000181E64D80-0x0000000181E64E40
	[BlackList] // 0x0000000189B58B80-0x0000000189B58BC0
	// [XID] // 0x0000000189B58B80-0x0000000189B58BC0
	public override void ReturnToObjectPool() {} // 0x0000000181E663E0-0x0000000181E66480
}

