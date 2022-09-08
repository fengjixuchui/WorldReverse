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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AbilityEntityDefenceMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14532
{
	// Fields
	private EntityDefenceMixin config; // 0x70
	protected BaseEntity _entity; // 0x78
	protected EntityTimer _timer; // 0x80
	protected float beHitCount; // 0x88
	protected float triggerProbability; // 0x8C
	private bool _needDefence; // 0x90
	private bool isValid; // 0x91
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<int> configStateIDs; // 0x98
	private VCStateLayerController stateLayerController; // 0xA0

	// Constructors
	public AbilityEntityDefenceMixin() {} // 0x00000001822005C0-0x0000000182200630

	// Methods
	// [XID] // 0x0000000189A3B590-0x0000000189A3B5B0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001821FEE10-0x00000001821FF0C0
	// [XID] // 0x0000000189A430E0-0x0000000189A43100
	public override void OnPoolAllocated() {} // 0x00000001822001A0-0x0000000182200280
	// [XID] // 0x0000000189A4A5F0-0x0000000189A4A610
	public override void OnBeforePoolRecycled() {} // 0x00000001821FFD60-0x00000001821FFE40
	// [XID] // 0x0000000189A51E20-0x0000000189A51E40
	public override void Clear() {} // 0x00000001821FF1C0-0x00000001821FF2A0
	// [XID] // 0x0000000189A59710-0x0000000189A59730
	public override void OnAdded(bool syncToServer) {} // 0x00000001821FE6F0-0x00000001821FE7D0
	// [XID] // 0x0000000189A60F50-0x0000000189A60F70
	public void Reset() {} // 0x00000001821FED00-0x00000001821FEE10
	// [XID] // 0x0000000189A68D90-0x0000000189A68DB0
	public override void Tick(float inDeltaTime) {} // 0x0000000182200400-0x00000001822005C0
	// [XID] // 0x0000000189A70020-0x0000000189A70040
	protected static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001821FF3A0-0x00000001821FF480
	// [XID] // 0x0000000189A77800-0x0000000189A77820
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000182200090-0x00000001822001A0
	// [XID] // 0x0000000189A7EEE0-0x0000000189A7EF00
	protected static new EventID[] GetSelfOnEventResolvedIDsExcludingBase() => default; // 0x00000001821FF560-0x00000001821FF640
	// [XID] // 0x0000000189A868C0-0x0000000189A868E0
	public override bool OnEventResolved(BaseEvent evt) => default; // 0x00000001821FFF80-0x0000000182200090
	// [XID] // 0x0000000189A8E510-0x0000000189A8E530
	protected static new EventID[] GetSelfOnEventRemoteIDsExcludingBase() => default; // 0x00000001821FF480-0x00000001821FF560
	// [XID] // 0x0000000189A95950-0x0000000189A95970
	public override bool OnEventRemote(BaseEvent evt) => default; // 0x00000001821FFE40-0x00000001821FFF80
	// [XID] // 0x0000000189A9D220-0x0000000189A9D240
	private bool OnBeingHit(EvtBeingHit evt) => default; // 0x00000001821FF6A0-0x00000001821FFB10
	// [XID] // 0x0000000189AA4900-0x0000000189AA4920
	private bool OnBeingHitResolved(EvtBeingHit evt) => default; // 0x00000001821FE7D0-0x00000001821FE910
	// [XID] // 0x0000000189AABF70-0x0000000189AABF90
	protected virtual bool CheckCanBeDefence(EvtBeingHit evt) => default; // 0x00000001821FF2A0-0x00000001821FF3A0
	// [XID] // 0x0000000189AB38F0-0x0000000189AB3910
	protected virtual bool CheckDefenceCondition(EvtBeingHit evt) => default; // 0x00000001821FFB70-0x00000001821FFC20
	// [XID] // 0x0000000189ABB5D0-0x0000000189ABB5F0
	protected virtual void OnDefenceSucc(EvtBeingHit evt) {} // 0x00000001821FEC50-0x00000001821FED00
	[BlackList] // 0x0000000189AC2C50-0x0000000189AC2C90
	// [XID] // 0x0000000189AC2C50-0x0000000189AC2C90
	public override void AutoAllocTypeFields() {} // 0x00000001821FE9A0-0x00000001821FEA80
	[BlackList] // 0x0000000189ACD400-0x0000000189ACD440
	// [XID] // 0x0000000189ACD400-0x0000000189ACD440
	public override void AutoRecycleTypeFields() {} // 0x00000001821FEA80-0x00000001821FEB70
	[BlackList] // 0x0000000189AD7FF0-0x0000000189AD8030
	// [XID] // 0x0000000189AD7FF0-0x0000000189AD8030
	public override void ReturnToObjectPool() {} // 0x0000000182200360-0x0000000182200400
}

