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

public sealed class AbilityAttackCostElementMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14480
{
	// Fields
	private AttackCostElementMixin config; // 0x70
	private LCAbilityElement _abilityElement; // 0x78

	// Constructors
	public AbilityAttackCostElementMixin() {} // 0x0000000181800200-0x0000000181800260

	// Methods
	// [XID] // 0x0000000189AF35C0-0x0000000189AF35E0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001817FF200-0x00000001817FF370
	// [XID] // 0x0000000189AFAE40-0x0000000189AFAE60
	public override void Clear() {} // 0x00000001817FF3F0-0x00000001817FF4A0
	// [XID] // 0x0000000189B02400-0x0000000189B02420
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001817FF4A0-0x00000001817FF580
	// [XID] // 0x0000000189B099A0-0x0000000189B099C0
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000181800060-0x0000000181800160
	// [XID] // 0x0000000189B11420-0x0000000189B11440
	private static new EventID[] GetSelfOnEventRemoteIDsExcludingBase() => default; // 0x00000001817FF580-0x00000001817FF660
	// [XID] // 0x0000000189B18670-0x0000000189B18690
	public override bool OnEventRemote(BaseEvent evt) => default; // 0x00000001817FFE60-0x00000001817FFF60
	// [XID] // 0x0000000189B1FD30-0x0000000189B1FD50
	private static new EventID[] GetSelfOnEventResolvedIDsExcludingBase() => default; // 0x00000001817FF660-0x00000001817FF740
	// [XID] // 0x0000000189B27480-0x0000000189B274A0
	public override bool OnEventResolved(BaseEvent evt) => default; // 0x00000001817FFF60-0x0000000181800060
	// [XID] // 0x0000000189B2E660-0x0000000189B2E680
	private bool OnBeingHit(EvtBeingHit evt) => default; // 0x00000001817FF740-0x00000001817FFCC0
	// [XID] // 0x0000000189B35D10-0x0000000189B35D30
	private bool OnBeingHitResolved(EvtBeingHit evt) => default; // 0x00000001817FEE90-0x00000001817FEF40
	[BlackList] // 0x0000000189B3D440-0x0000000189B3D480
	// [XID] // 0x0000000189B3D440-0x0000000189B3D480
	public override void AutoAllocTypeFields() {} // 0x00000001817FEFD0-0x00000001817FF070
	[BlackList] // 0x0000000189B48190-0x0000000189B481D0
	// [XID] // 0x0000000189B48190-0x0000000189B481D0
	public override void AutoRecycleTypeFields() {} // 0x00000001817FF070-0x00000001817FF120
	[BlackList] // 0x0000000189B527E0-0x0000000189B52820
	// [XID] // 0x0000000189B527E0-0x0000000189B52820
	public override void ReturnToObjectPool() {} // 0x0000000181800160-0x0000000181800200
}

