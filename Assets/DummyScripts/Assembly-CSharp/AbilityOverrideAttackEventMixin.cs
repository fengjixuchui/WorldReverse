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

public sealed class AbilityOverrideAttackEventMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14554
{
	// Fields
	private OverrideAttackEventMixin config; // 0x70

	// Constructors
	public AbilityOverrideAttackEventMixin() {} // 0x00000001818F7ED0-0x00000001818F7F30

	// Methods
	// [XID] // 0x0000000189BC2180-0x0000000189BC21A0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001818F7730-0x00000001818F7870
	// [XID] // 0x0000000189BC9650-0x0000000189BC9670
	public override void Clear() {} // 0x00000001818F7870-0x00000001818F7920
	// [XID] // 0x0000000189BD0EB0-0x0000000189BD0ED0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001818F7920-0x00000001818F7A00
	// [XID] // 0x0000000189BD84A0-0x0000000189BD84C0
	public override bool OnEvent(BaseEvent evt) => default; // 0x00000001818F7D30-0x00000001818F7E30
	// [XID] // 0x0000000189BDFDE0-0x0000000189BDFE00
	private bool OnHittingOther(EvtHittingOther evt) => default; // 0x00000001818F7500-0x00000001818F7730
	// [XID] // 0x00000001895ECAA0-0x00000001895ECAC0
	private bool OnHittingOtherSingle(AttackResult attackResult, ConfigAttackEvent attackEvent) => default; // 0x00000001818F7A60-0x00000001818F7BF0
	[BlackList] // 0x00000001895F40F0-0x00000001895F4130
	// [XID] // 0x00000001895F40F0-0x00000001895F4130
	public override void AutoAllocTypeFields() {} // 0x00000001818F7350-0x00000001818F73F0
	[BlackList] // 0x00000001895FE810-0x00000001895FE850
	// [XID] // 0x00000001895FE810-0x00000001895FE850
	public override void AutoRecycleTypeFields() {} // 0x00000001818F73F0-0x00000001818F74A0
	[BlackList] // 0x0000000189609320-0x0000000189609360
	// [XID] // 0x0000000189609320-0x0000000189609360
	public override void ReturnToObjectPool() {} // 0x00000001818F7E30-0x00000001818F7ED0
}

