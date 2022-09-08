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

public sealed class AbilityAutoDefenceMixin : AbilityEntityDefenceMixin, IAutoAllocRecycle // TypeDefIndex: 14482
{
	// Constructors
	public AbilityAutoDefenceMixin() {} // 0x0000000184011850-0x00000001840118B0

	// Methods
	// [XID] // 0x0000000189BA1140-0x0000000189BA1160
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001840112D0-0x0000000184011430
	// [XID] // 0x0000000189BA87C0-0x0000000189BA87E0
	public override void Clear() {} // 0x0000000184011430-0x00000001840114D0
	// [XID] // 0x0000000189BAFAC0-0x0000000189BAFAE0
	protected override bool CheckDefenceCondition(EvtBeingHit evt) => default; // 0x0000000184011530-0x0000000184011670
	// [XID] // 0x0000000189BB7240-0x0000000189BB7260
	protected override void OnDefenceSucc(EvtBeingHit evt) {} // 0x0000000184011140-0x00000001840112D0
	[BlackList] // 0x0000000189BBE7F0-0x0000000189BBE830
	// [XID] // 0x0000000189BBE7F0-0x0000000189BBE830
	public override void AutoAllocTypeFields() {} // 0x0000000184010F20-0x0000000184010FC0
	[BlackList] // 0x0000000189BC96B0-0x0000000189BC96F0
	// [XID] // 0x0000000189BC96B0-0x0000000189BC96F0
	public override void AutoRecycleTypeFields() {} // 0x0000000184010FC0-0x0000000184011060
	[BlackList] // 0x0000000189BD3FD0-0x0000000189BD4010
	// [XID] // 0x0000000189BD3FD0-0x0000000189BD4010
	public override void ReturnToObjectPool() {} // 0x00000001840117B0-0x0000000184011850
}

