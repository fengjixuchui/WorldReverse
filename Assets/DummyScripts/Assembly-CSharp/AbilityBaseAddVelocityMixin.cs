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

public class AbilityBaseAddVelocityMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14488
{
	// Fields
	private WindZone _windObject; // 0x70
	protected BaseEntity _entity; // 0x78

	// Nested types
	[RecycleType] // 0x00000001898422C0-0x00000001898422E0
	public class WindZoneEntity : IAutoAllocRecycle // TypeDefIndex: 14489
	{
		// Fields
		public int curZoneID; // 0x10
		public float forceValue; // 0x14
		public uint targetEntityId; // 0x18
		public float lastTime; // 0x1C
		public float controlTime; // 0x20
		public bool isDirty; // 0x24

		// Properties
		public BaseEntity targetEntity { /* [XID] */ /* 0x00000001897F1020-0x00000001897F1040 */ get => default; } // 0x00000001836CAE90-0x00000001836CAF70 
		public bool isInZone { /* [XID] */ /* 0x00000001897F88E0-0x00000001897F8900 */ get => default; } // 0x00000001836CADE0-0x00000001836CAE90 

		// Constructors
		public WindZoneEntity() {} // 0x00000001836CB240-0x00000001836CB2B0

		// Methods
		// [XID] // 0x00000001897E9450-0x00000001897E9470
		public bool IsFree(int zoneId) => default; // 0x00000001836CAF70-0x00000001836CB050
		// [XID] // 0x00000001897FFFA0-0x00000001897FFFC0
		public void OnBeforePoolRecycled() {} // 0x00000001836CB050-0x00000001836CB0F0
		// [XID] // 0x0000000189807660-0x0000000189807680
		public void OnPoolAllocated() {} // 0x00000001836CB0F0-0x00000001836CB1A0
		// [XID] // 0x000000018980ED00-0x000000018980ED20
		public static WindZoneEntity TryGetZoneEntity(List<WindZoneEntity> windZoneEntities, BaseEntity entity) => default; // 0x00000001836CAC70-0x00000001836CADE0
		[BlackList] // 0x0000000189816370-0x00000001898163B0
		// [XID] // 0x0000000189816370-0x00000001898163B0
		public virtual void AutoAllocTypeFields() {} // 0x00000001836CAB20-0x00000001836CABC0
		[BlackList] // 0x0000000189820FD0-0x0000000189821010
		// [XID] // 0x0000000189820FD0-0x0000000189821010
		public virtual void AutoRecycleTypeFields() {} // 0x00000001836CABC0-0x00000001836CAC70
		[BlackList] // 0x000000018982B3B0-0x000000018982B3F0
		// [XID] // 0x000000018982B3B0-0x000000018982B3F0
		public virtual void ReturnToObjectPool() {} // 0x00000001836CB1A0-0x00000001836CB240
	}

	// Constructors
	public AbilityBaseAddVelocityMixin() {} // 0x00000001836ADD90-0x00000001836ADDF0

	// Methods
	// [XID] // 0x00000001897856C0-0x00000001897856E0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001836AC990-0x00000001836ACAA0
	// [XID] // 0x000000018978CBA0-0x000000018978CBC0
	public override void Clear() {} // 0x00000001836ACB10-0x00000001836ACC80
	// [XID] // 0x0000000189794060-0x0000000189794080
	protected void InitWindZoneObject(float strength, float radius) {} // 0x00000001836AD280-0x00000001836AD4B0
	// [XID] // 0x000000018979C470-0x000000018979C490
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001836AC820-0x00000001836AC990
	// [XID] // 0x00000001897A3990-0x00000001897A39B0
	protected void UpdateWindZoneObject(Vector3 bornPos) {} // 0x00000001836AD4B0-0x00000001836AD610
	// [XID] // 0x00000001897AAD20-0x00000001897AAD40
	protected void AddVelocity(BaseShape2d shape, float deltaTime, WindZoneEntity entity, Vector3 bornPos, float forceGrowth, float forceFallen, float cattenuation, float cstrength, Vector3 forceDir, bool reverse = false /* Metadata: 0x00AEB78B */) {} // 0x00000001836ACC80-0x00000001836AD220
	// [XID] // 0x00000001897B2990-0x00000001897B29B0
	protected float ComputeForce(BaseShape2d shape, float attenuation, float strength, float dis, float weight = 100f /* Metadata: 0x00AEB78C */, bool reverse = false /* Metadata: 0x00AEB790 */) => default; // 0x00000001836AC550-0x00000001836AC7C0
	// [XID] // 0x00000001897BA3F0-0x00000001897BA410
	protected virtual void GetForceDir(BaseShape2d shape, Vector3 pos, out Vector3 dir, out float dis) {
		dir = default;
		dis = default;
	} // 0x00000001836AD6D0-0x00000001836ADCF0
	[BlackList] // 0x00000001897C22F0-0x00000001897C2330
	// [XID] // 0x00000001897C22F0-0x00000001897C2330
	public override void AutoAllocTypeFields() {} // 0x00000001836AC400-0x00000001836AC4A0
	[BlackList] // 0x00000001897CCBA0-0x00000001897CCBE0
	// [XID] // 0x00000001897CCBA0-0x00000001897CCBE0
	public override void AutoRecycleTypeFields() {} // 0x00000001836AC4A0-0x00000001836AC550
	[BlackList] // 0x00000001897D74F0-0x00000001897D7530
	// [XID] // 0x00000001897D74F0-0x00000001897D7530
	public override void ReturnToObjectPool() {} // 0x00000001836ADCF0-0x00000001836ADD90
}

