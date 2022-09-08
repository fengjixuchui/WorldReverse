/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityEliteShieldMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14531
{
	// Fields
	private EliteShieldMixin _config; // 0x70
	private BaseEntity _entity; // 0x78
	private float _maxShield; // 0x80
	private float _shield; // 0x84
	private VCBillboard _vcBillboard; // 0x88
	private SimpleSafeFloat[] _elementDamageRatios; // 0x90
	private SimpleSafeFloat[] _elementDamageSufferRatios; // 0x98
	private int _addedTimes; // 0xA0

	// Properties
	public float shield { /* [XID] */ /* 0x000000018997D320-0x000000018997D340 */ get => default; } // 0x0000000182A86530-0x0000000182A865E0 
	private bool isReady { /* [XID] */ /* 0x0000000189984EC0-0x0000000189984EE0 */ get => default; } // 0x0000000182A85390-0x0000000182A85440 

	// Constructors
	public AbilityEliteShieldMixin() {} // 0x0000000182A86EB0-0x0000000182A86F20

	// Methods
	// [XID] // 0x000000018998CAE0-0x000000018998CB00
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182A85440-0x0000000182A85750
	// [XID] // 0x00000001899947A0-0x00000001899947C0
	public override void Clear() {} // 0x0000000182A85B00-0x0000000182A85BB0
	// [XID] // 0x000000018999C010-0x000000018999C030
	public override void OnAdded(bool syncToServer) {} // 0x0000000182A84930-0x0000000182A84AE0
	// [XID] // 0x00000001899A38C0-0x00000001899A38E0
	public override void LazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182A84EA0-0x0000000182A84FA0
	// [XID] // 0x00000001899AB3F0-0x00000001899AB410
	private void CheckReady() {} // 0x0000000182A85750-0x0000000182A85A90
	// [XID] // 0x00000001899B2E50-0x00000001899B2E70
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000182A85120-0x0000000182A85390
	// [XID] // 0x00000001899B9F50-0x00000001899B9F70
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000182A85BB0-0x0000000182A85C90
	// [XID] // 0x00000001899C1B40-0x00000001899C1B60
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000182A86C70-0x0000000182A86D90
	// [XID] // 0x00000001899C8F40-0x00000001899C8F60
	private static new EventID[] GetSelfOnEventRemoteIDsExcludingBase() => default; // 0x0000000182A85C90-0x0000000182A85D70
	// [XID] // 0x00000001899D0A40-0x00000001899D0A60
	public override bool OnEventRemote(BaseEvent evt) => default; // 0x0000000182A86B50-0x0000000182A86C70
	// [XID] // 0x00000001899D7E70-0x00000001899D7E90
	private bool OnBeingHit(EvtBeingHit evt) => default; // 0x0000000182A85D70-0x0000000182A863A0
	// [XID] // 0x00000001899DF440-0x00000001899DF460
	public string GetShieldType() => default; // 0x0000000182A84CE0-0x0000000182A84DC0
	// [XID] // 0x00000001899E6FD0-0x00000001899E6FF0
	private void OnShieldBroken() {} // 0x0000000182A84FA0-0x0000000182A85120
	// [XID] // 0x00000001899EE3D0-0x00000001899EE3F0
	public float GetShieldDamage(BaseEntity entity, AttackResult attackResult) => default; // 0x0000000182A86820-0x0000000182A86B50
	[BlackList] // 0x00000001899F5D20-0x00000001899F5D60
	// [XID] // 0x00000001899F5D20-0x00000001899F5D60
	public override void AutoAllocTypeFields() {} // 0x0000000182A84B70-0x0000000182A84C10
	[BlackList] // 0x0000000189A002B0-0x0000000189A002F0
	// [XID] // 0x0000000189A002B0-0x0000000189A002F0
	public override void AutoRecycleTypeFields() {} // 0x0000000182A84C10-0x0000000182A84CE0
	[BlackList] // 0x0000000189A0A930-0x0000000189A0A970
	// [XID] // 0x0000000189A0A930-0x0000000189A0A970
	public override void ReturnToObjectPool() {} // 0x0000000182A86E10-0x0000000182A86EB0
}

