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

public sealed class AbilityTriggerResistDamageTextMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14592
{
	// Fields
	private TriggerResistDamageTextMixin config; // 0x70

	// Constructors
	public AbilityTriggerResistDamageTextMixin() {} // 0x00000001822FBA70-0x00000001822FBAD0

	// Methods
	// [XID] // 0x000000018987DF30-0x000000018987DF50
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001822FB340-0x00000001822FB480
	// [XID] // 0x0000000189884FC0-0x0000000189884FE0
	public override void Clear() {} // 0x00000001822FB480-0x00000001822FB530
	// [XID] // 0x000000018988C560-0x000000018988C580
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001822FB530-0x00000001822FB610
	// [XID] // 0x0000000189893AF0-0x0000000189893B10
	public override bool OnEvent(BaseEvent evt) => default; // 0x00000001822FB8D0-0x00000001822FB9D0
	// [XID] // 0x000000018989B1F0-0x000000018989B210
	private bool OnBeingHit(EvtBeingHit evt) => default; // 0x00000001822FB610-0x00000001822FB730
	[BlackList] // 0x00000001898A25F0-0x00000001898A2630
	// [XID] // 0x00000001898A25F0-0x00000001898A2630
	public override void AutoAllocTypeFields() {} // 0x00000001822FB190-0x00000001822FB230
	[BlackList] // 0x00000001898ACD00-0x00000001898ACD40
	// [XID] // 0x00000001898ACD00-0x00000001898ACD40
	public override void AutoRecycleTypeFields() {} // 0x00000001822FB230-0x00000001822FB2E0
	[BlackList] // 0x00000001898B7330-0x00000001898B7370
	// [XID] // 0x00000001898B7330-0x00000001898B7370
	public override void ReturnToObjectPool() {} // 0x00000001822FB9D0-0x00000001822FBA70
}

