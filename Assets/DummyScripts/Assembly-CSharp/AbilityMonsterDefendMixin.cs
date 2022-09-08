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

public sealed class AbilityMonsterDefendMixin : AbilityEntityDefenceMixin, IAutoAllocRecycle // TypeDefIndex: 14550
{
	// Fields
	private MonsterDefendMixin config; // 0xA8
	public const float DEFENCE_HALT_TIME_ADD = 0.12f; // Metadata: 0x00AEB7EB

	// Constructors
	public AbilityMonsterDefendMixin() {} // 0x00000001836B9EE0-0x00000001836B9F40

	// Methods
	// [XID] // 0x0000000189AB68D0-0x0000000189AB68F0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001836B9900-0x00000001836B9A40
	// [XID] // 0x0000000189ABE3C0-0x0000000189ABE3E0
	public override void Clear() {} // 0x00000001836B9A40-0x00000001836B9AF0
	// [XID] // 0x0000000189AC5F10-0x0000000189AC5F30
	protected override bool CheckCanBeDefence(EvtBeingHit evt) => default; // 0x00000001836B9AF0-0x00000001836B9C20
	// [XID] // 0x0000000189ACD3E0-0x0000000189ACD400
	protected override void OnDefenceSucc(EvtBeingHit evt) {} // 0x00000001836B95F0-0x00000001836B9900
	[BlackList] // 0x0000000189AD5200-0x0000000189AD5240
	// [XID] // 0x0000000189AD5200-0x0000000189AD5240
	public override void AutoAllocTypeFields() {} // 0x00000001836B9440-0x00000001836B94E0
	[BlackList] // 0x0000000189ADFCC0-0x0000000189ADFD00
	// [XID] // 0x0000000189ADFCC0-0x0000000189ADFD00
	public override void AutoRecycleTypeFields() {} // 0x00000001836B94E0-0x00000001836B9590
	[BlackList] // 0x0000000189AEA190-0x0000000189AEA1D0
	// [XID] // 0x0000000189AEA190-0x0000000189AEA1D0
	public override void ReturnToObjectPool() {} // 0x00000001836B9E40-0x00000001836B9EE0
}

