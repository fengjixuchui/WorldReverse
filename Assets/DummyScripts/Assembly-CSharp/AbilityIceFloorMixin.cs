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

public sealed class AbilityIceFloorMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14545
{
	// Fields
	private IceFloorMixin _config; // 0x70
	private BaseEntity _entity; // 0x78
	private LCBaseCombat _combatComp; // 0x80
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<CollisionResult> _checkColResults; // 0x88
	private Vector3 _lastPos; // 0x90
	private float _intervalTime; // 0x9C
	private Coroutine _curoutine; // 0xA0

	// Constructors
	public AbilityIceFloorMixin() {} // 0x0000000181F5A9E0-0x0000000181F5AA50

	// Methods
	// [XID] // 0x0000000189967330-0x0000000189967350
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000181F59AE0-0x0000000181F59C60
	// [XID] // 0x000000018996E5A0-0x000000018996E5C0
	public override void Clear() {} // 0x0000000181F59D50-0x0000000181F59ED0
	// [XID] // 0x0000000189976030-0x0000000189976050
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000181F599D0-0x0000000181F59AE0
	// [XID] // 0x000000018997D300-0x000000018997D320
	public override void Tick(float inDeltaTime) {} // 0x0000000181F5A420-0x0000000181F5A9E0
	// [XID] // 0x0000000189984EA0-0x0000000189984EC0
	private List<CollisionResult> CheckAndCreateGWByBox(ref AttackResultContext resultContext, Vector3 curPos) => default; // 0x0000000181F59F30-0x0000000181F5A2C0
	[BlackList] // 0x000000018998CAA0-0x000000018998CAE0
	// [XID] // 0x000000018998CAA0-0x000000018998CAE0
	public override void AutoAllocTypeFields() {} // 0x0000000181F597A0-0x0000000181F59880
	[BlackList] // 0x0000000189997510-0x0000000189997550
	// [XID] // 0x0000000189997510-0x0000000189997550
	public override void AutoRecycleTypeFields() {} // 0x0000000181F59880-0x0000000181F59970
	[BlackList] // 0x00000001899A2210-0x00000001899A2250
	// [XID] // 0x00000001899A2210-0x00000001899A2250
	public override void ReturnToObjectPool() {} // 0x0000000181F5A380-0x0000000181F5A420
}

