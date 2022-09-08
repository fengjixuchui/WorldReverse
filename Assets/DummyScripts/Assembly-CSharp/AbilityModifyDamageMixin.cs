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

public sealed class AbilityModifyDamageMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14547
{
	// Fields
	private ModifyDamageMixin config; // 0x70

	// Constructors
	public AbilityModifyDamageMixin() {} // 0x0000000184648D70-0x0000000184648DD0

	// Methods
	// [XID] // 0x00000001899C3570-0x00000001899C3590
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000184647EF0-0x0000000184647FF0
	// [XID] // 0x00000001899CAA00-0x00000001899CAA20
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000184647FF0-0x00000001846480D0
	// [XID] // 0x00000001899D1FF0-0x00000001899D2010
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000184648950-0x0000000184648A60
	// [XID] // 0x00000001899D9710-0x00000001899D9730
	private bool OnHittingOther(EvtHittingOther evt) => default; // 0x0000000184647D40-0x0000000184647EF0
	// [XID] // 0x00000001899E0D70-0x00000001899E0D90
	private bool OnHittingOtherSignle(uint attackeeID, AttackResult attackResult, EvtHittingOther evt) => default; // 0x0000000184648750-0x0000000184648950
	// [XID] // 0x00000001899E8940-0x00000001899E8960
	private bool CheckConditionSingle(AttackResult attackResult) => default; // 0x0000000184648A60-0x0000000184648CD0
	// [XID] // 0x00000001899F0020-0x00000001899F0040
	private void ModifyDamageSingle(AttackResult attackResult) {} // 0x00000001846480D0-0x0000000184648610
	[BlackList] // 0x00000001899F7620-0x00000001899F7660
	// [XID] // 0x00000001899F7620-0x00000001899F7660
	public override void AutoAllocTypeFields() {} // 0x0000000184647B90-0x0000000184647C30
	[BlackList] // 0x0000000189A01880-0x0000000189A018C0
	// [XID] // 0x0000000189A01880-0x0000000189A018C0
	public override void AutoRecycleTypeFields() {} // 0x0000000184647C30-0x0000000184647CE0
	[BlackList] // 0x0000000189A0C150-0x0000000189A0C190
	// [XID] // 0x0000000189A0C150-0x0000000189A0C190
	public override void ReturnToObjectPool() {} // 0x0000000184648CD0-0x0000000184648D70
}

