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

public sealed class AbilityChargeBarMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14500
{
	// Fields
	private ChargeBarMixin _config; // 0x70
	private float _lastValue; // 0x78
	private LCAbilityElement _lcElement; // 0x80
	private float _maxDurability; // 0x88
	private bool _isInitMaxValue; // 0x8C

	// Constructors
	public AbilityChargeBarMixin() {} // 0x000000018405AF60-0x000000018405AFD0

	// Methods
	// [XID] // 0x0000000189AA4920-0x0000000189AA4940
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018405A840-0x000000018405AA10
	// [XID] // 0x0000000189AABF90-0x0000000189AABFB0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x000000018405A770-0x000000018405A840
	// [XID] // 0x0000000189AB3910-0x0000000189AB3930
	public override void Clear() {} // 0x000000018405AB00-0x000000018405ABE0
	// [XID] // 0x0000000189ABB630-0x0000000189ABB650
	public override void Tick(float inDeltaTime) {} // 0x000000018405ADA0-0x000000018405AF60
	// [XID] // 0x0000000189AC2C90-0x0000000189AC2CB0
	private void ChangeChargeBarValue(float value, bool isAdd, bool isRestart) {} // 0x000000018405A570-0x000000018405A710
	[BlackList] // 0x0000000189ACA340-0x0000000189ACA380
	// [XID] // 0x0000000189ACA340-0x0000000189ACA380
	public override void AutoAllocTypeFields() {} // 0x000000018405A410-0x000000018405A4B0
	[BlackList] // 0x0000000189AD5240-0x0000000189AD5280
	// [XID] // 0x0000000189AD5240-0x0000000189AD5280
	public override void AutoRecycleTypeFields() {} // 0x000000018405A4B0-0x000000018405A570
	[BlackList] // 0x0000000189ADFD40-0x0000000189ADFD80
	// [XID] // 0x0000000189ADFD40-0x0000000189ADFD80
	public override void ReturnToObjectPool() {} // 0x000000018405AD00-0x000000018405ADA0
}

