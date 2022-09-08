/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityWindZoneMixin : AbilityBaseAddVelocityMixin, IAutoAllocRecycle // TypeDefIndex: 14603
{
	// Fields
	private WindZoneMixin config; // 0x80
	private BaseShape2d _shape; // 0x88
	private uint _maxNum; // 0x90
	private const float SYNC_INTERVAL = 0.1f; // Metadata: 0x00AEB95D
	private float _lastRefreshWindZoneTime; // 0x94
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<uint> _appliedModifierEntityRuntimeIDs; // 0x98
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<uint> _lcPickables; // 0xA0
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<WindZoneEntity> _windZoneCombatEntities; // 0xA8

	// Constructors
	public AbilityWindZoneMixin() {} // 0x00000001829BCAE0-0x00000001829BCB50

	// Methods
	// [XID] // 0x0000000189763120-0x0000000189763140
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001829BA8E0-0x00000001829BAB10
	// [XID] // 0x000000018976A8F0-0x000000018976A910
	public override void Clear() {} // 0x00000001829BAC00-0x00000001829BADE0
	// [XID] // 0x0000000189771ED0-0x0000000189771EF0
	public override void OnAdded(bool syncToServer) {} // 0x00000001829B9840-0x00000001829B9A60
	// [XID] // 0x0000000189779700-0x0000000189779720
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001829BA490-0x00000001829BA8E0
	// [XID] // 0x0000000189781080-0x00000001897810A0
	public override void Tick(float inDeltaTime) {} // 0x00000001829BB450-0x00000001829BCAE0
	// [XID] // 0x0000000189788540-0x0000000189788560
	public override void HandleMixinInvokeEntry(UnionAbilityInvokeEntry invokeEntry) {} // 0x00000001829B9D60-0x00000001829BA490
	// [XID] // 0x000000018978FC00-0x000000018978FC20
	private void UpdateWindZoneEntitis(List<WindZoneEntity> windZoneCombatEntities, BaseShape2d shape, float deltaTime, Vector3 bornPos, float forceGrowth, float forceFallen, float cattenuation, float cstrength, bool reverse) {} // 0x00000001829BAEA0-0x00000001829BB250
	[BlackList] // 0x00000001897973D0-0x0000000189797410
	// [XID] // 0x00000001897973D0-0x0000000189797410
	public override void AutoAllocTypeFields() {} // 0x00000001829B9AF0-0x00000001829B9BF0
	[BlackList] // 0x00000001897A2120-0x00000001897A2160
	// [XID] // 0x00000001897A2120-0x00000001897A2160
	public override void AutoRecycleTypeFields() {} // 0x00000001829B9BF0-0x00000001829B9D00
	[BlackList] // 0x00000001897AC900-0x00000001897AC940
	// [XID] // 0x00000001897AC900-0x00000001897AC940
	public override void ReturnToObjectPool() {} // 0x00000001829BB3B0-0x00000001829BB450
}

