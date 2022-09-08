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

public sealed class AbilityClusterTriggerMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14502
{
	// Fields
	private ClusterTriggerMixin config; // 0x70
	private float[] _valueSteps; // 0x78
	private EntityTimer _timer; // 0x80
	private float leastTriggerNum; // 0x88
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<BaseEntity> _tmpToDestroy; // 0x90

	// Constructors
	public AbilityClusterTriggerMixin() {} // 0x000000018181E940-0x000000018181E9B0

	// Methods
	// [XID] // 0x0000000189B6A850-0x0000000189B6A870
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018181D940-0x000000018181DD80
	// [XID] // 0x0000000189B720A0-0x0000000189B720C0
	public override void OnPoolAllocated() {} // 0x000000018181E560-0x000000018181E640
	// [XID] // 0x0000000189B79450-0x0000000189B79470
	public override void OnBeforePoolRecycled() {} // 0x000000018181E480-0x000000018181E560
	// [XID] // 0x0000000189B80830-0x0000000189B80850
	public override void Clear() {} // 0x000000018181DE00-0x000000018181DF00
	// [XID] // 0x0000000189B88480-0x0000000189B884A0
	public override void Tick(float inDeltaTime) {} // 0x000000018181E740-0x000000018181E940
	// [XID] // 0x0000000189B8F680-0x0000000189B8F6A0
	private void CheckCluster(float deltaTime, Vector3 bornPos) {} // 0x000000018181DF00-0x000000018181E100
	// [XID] // 0x0000000189B96B80-0x0000000189B96BA0
	private bool CheckEntity(Vector3 bornPos) => default; // 0x000000018181D510-0x000000018181D5D0
	// [XID] // 0x0000000189B9E070-0x0000000189B9E090
	private int GetClusterNum(Vector3 bornPos) => default; // 0x000000018181E160-0x000000018181E220
	// [XID] // 0x0000000189BA5970-0x0000000189BA5990
	private void TickModifierByValue(float curValue) {} // 0x000000018181D5D0-0x000000018181D940
	// [XID] // 0x0000000189BACC80-0x0000000189BACCA0
	private int CalculateCurrentStep(float curValue) => default; // 0x000000018181E2E0-0x000000018181E420
	[BlackList] // 0x0000000189BB4550-0x0000000189BB4590
	// [XID] // 0x0000000189BB4550-0x0000000189BB4590
	public override void AutoAllocTypeFields() {} // 0x000000018181D2F0-0x000000018181D3D0
	[BlackList] // 0x0000000189BBE7B0-0x0000000189BBE7F0
	// [XID] // 0x0000000189BBE7B0-0x0000000189BBE7F0
	public override void AutoRecycleTypeFields() {} // 0x000000018181D3D0-0x000000018181D4B0
	[BlackList] // 0x0000000189BC9670-0x0000000189BC96B0
	// [XID] // 0x0000000189BC9670-0x0000000189BC96B0
	public override void ReturnToObjectPool() {} // 0x000000018181E6A0-0x000000018181E740
}

