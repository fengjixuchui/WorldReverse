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

public class AbilityTriggerTypeSupportMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14593
{
	// Fields
	private TriggerTypeSupportMixin config; // 0x70
	protected AvatarEntity _avatar; // 0x78
	protected LCAvatarCombat _lcCombat; // 0x80
	protected LCAvatarCombat.SkillInfo _skillInfo; // 0x88
	private EntityTimer _durationTimer; // 0x90

	// Constructors
	public AbilityTriggerTypeSupportMixin() {} // 0x0000000180F1A0B0-0x0000000180F1A110

	// Methods
	// [XID] // 0x00000001898C1BF0-0x00000001898C1C10
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000180F19AC0-0x0000000180F19D00
	// [XID] // 0x00000001898C95A0-0x00000001898C95C0
	public override void Clear() {} // 0x0000000180F19D70-0x0000000180F19E70
	// [XID] // 0x00000001898D0E60-0x00000001898D0E80
	public override void OnAdded(bool syncToServer) {} // 0x0000000180F192A0-0x0000000180F19360
	// [XID] // 0x00000001898D8400-0x00000001898D8420
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000180F19920-0x0000000180F199E0
	// [XID] // 0x00000001898E02A0-0x00000001898E02C0
	protected void OnSupportTriggered(BaseEntity baseEntity, bool useTimer = true /* Metadata: 0x00AEB93F */) {} // 0x0000000180F19550-0x0000000180F197D0
	// [XID] // 0x00000001898E7DC0-0x00000001898E7DE0
	protected void OnDisableSupportSkill(bool useTimer = true /* Metadata: 0x00AEB940 */) {} // 0x0000000180F199E0-0x0000000180F19AC0
	// [XID] // 0x00000001898EF4C0-0x00000001898EF4E0
	protected void SetSkillButton(bool active) {} // 0x0000000180F19830-0x0000000180F19920
	[BlackList] // 0x00000001898F6D70-0x00000001898F6DB0
	// [XID] // 0x00000001898F6D70-0x00000001898F6DB0
	public override void AutoAllocTypeFields() {} // 0x0000000180F193F0-0x0000000180F19490
	[BlackList] // 0x0000000189901620-0x0000000189901660
	// [XID] // 0x0000000189901620-0x0000000189901660
	public override void AutoRecycleTypeFields() {} // 0x0000000180F19490-0x0000000180F19550
	[BlackList] // 0x000000018990BCE0-0x000000018990BD20
	// [XID] // 0x000000018990BCE0-0x000000018990BD20
	public override void ReturnToObjectPool() {} // 0x0000000180F1A010-0x0000000180F1A0B0
}

