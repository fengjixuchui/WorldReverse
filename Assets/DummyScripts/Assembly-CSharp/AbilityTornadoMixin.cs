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

public sealed class AbilityTornadoMixin : AbilityBaseAddVelocityMixin, IAutoAllocRecycle // TypeDefIndex: 14586
{
	// Fields
	private TornadoMixin config; // 0x80
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<TornadoSubZone> _tornadoStages; // 0x88
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public List<WindZoneEntity> _windZoneCombatEntities; // 0x90
	private const float SYNC_INTERVAL = 0.1f; // Metadata: 0x00AEB93B
	private float _lastRefreshWindZoneTime; // 0x98

	// Nested types
	[RecycleType] // 0x00000001898422C0-0x00000001898422E0
	public class TornadoSubZone : IAutoAllocRecycle // TypeDefIndex: 14587
	{
		// Fields
		public BaseShape2d shape; // 0x10
		public ConfigTornadoZone config; // 0x18
		// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
		public List<uint> appliedModifierEntityRuntimeIDs; // 0x20

		// Constructors
		public TornadoSubZone() {} // 0x0000000184EBC000-0x0000000184EBC080

		// Methods
		// [XID] // 0x00000001896CCC40-0x00000001896CCC60
		public void OnBeforePoolRecycled() {} // 0x0000000184EBBE20-0x0000000184EBBEC0
		// [XID] // 0x00000001896D3E60-0x00000001896D3E80
		public void OnPoolAllocated() {} // 0x0000000184EBBEC0-0x0000000184EBBF60
		[BlackList] // 0x00000001896DB7E0-0x00000001896DB820
		// [XID] // 0x00000001896DB7E0-0x00000001896DB820
		public virtual void AutoAllocTypeFields() {} // 0x0000000184EBBCA0-0x0000000184EBBD70
		[BlackList] // 0x00000001896E5CA0-0x00000001896E5CE0
		// [XID] // 0x00000001896E5CA0-0x00000001896E5CE0
		public virtual void AutoRecycleTypeFields() {} // 0x0000000184EBBD70-0x0000000184EBBE20
		[BlackList] // 0x00000001896F0010-0x00000001896F0050
		// [XID] // 0x00000001896F0010-0x00000001896F0050
		public virtual void ReturnToObjectPool() {} // 0x0000000184EBBF60-0x0000000184EBC000
	}

	// Constructors
	public AbilityTornadoMixin() {} // 0x0000000184ECC680-0x0000000184ECC6F0

	// Methods
	// [XID] // 0x000000018965B7D0-0x000000018965B7F0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000184ECA4D0-0x0000000184ECA830
	// [XID] // 0x0000000189662BB0-0x0000000189662BD0
	public override void Clear() {} // 0x0000000184ECAA30-0x0000000184ECABC0
	// [XID] // 0x000000018966A710-0x000000018966A730
	private void ClearTornadoStage() {} // 0x0000000184ECABC0-0x0000000184ECAD70
	// [XID] // 0x00000001896723B0-0x00000001896723D0
	public override void OnAdded(bool syncToServer) {} // 0x0000000184EC96C0-0x0000000184EC9810
	// [XID] // 0x0000000189679C60-0x0000000189679C80
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000184ECA1E0-0x0000000184ECA4D0
	// [XID] // 0x0000000189681320-0x0000000189681340
	private void RemoveModifier(BaseEntity entity, string name) {} // 0x0000000184ECA830-0x0000000184ECA940
	// [XID] // 0x0000000189688DA0-0x0000000189688DC0
	private bool UpdateAllWindZoneEntitis(float deltaTime, Vector3 bornPos) => default; // 0x0000000184ECAF10-0x0000000184ECB3E0
	// [XID] // 0x00000001896908E0-0x0000000189690900
	public override void Tick(float inDeltaTime) {} // 0x0000000184ECB500-0x0000000184ECC680
	// [XID] // 0x00000001896981A0-0x00000001896981C0
	public override void HandleMixinInvokeEntry(UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000184EC9AD0-0x0000000184ECA1E0
	[BlackList] // 0x000000018969F400-0x000000018969F440
	// [XID] // 0x000000018969F400-0x000000018969F440
	public override void AutoAllocTypeFields() {} // 0x0000000184EC98A0-0x0000000184EC9990
	[BlackList] // 0x00000001896A9920-0x00000001896A9960
	// [XID] // 0x00000001896A9920-0x00000001896A9960
	public override void AutoRecycleTypeFields() {} // 0x0000000184EC9990-0x0000000184EC9A70
	[BlackList] // 0x00000001896B3C10-0x00000001896B3C50
	// [XID] // 0x00000001896B3C10-0x00000001896B3C50
	public override void ReturnToObjectPool() {} // 0x0000000184ECB460-0x0000000184ECB500
}

