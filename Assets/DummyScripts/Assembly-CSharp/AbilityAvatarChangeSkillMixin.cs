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

public sealed class AbilityAvatarChangeSkillMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14483
{
	// Fields
	private AvatarChangeSkillMixin _config; // 0x70
	private LCAvatarCombat _lcCombat; // 0x78
	private VCAvatarFocus _vcFocus; // 0x80
	private VCHumanoidMove _vcMove; // 0x88
	private LCAvatarCombat.SkillInfo _currentSkillInfo; // 0x90
	private LCAvatarCombat.SkillInfo _aimSkillInfo; // 0x98
	private LCAvatarCombat.SkillInfo _jumpSkillInfo; // 0xA0
	private LCAvatarCombat.SkillInfo _flySkillInfo; // 0xA8

	// Constructors
	public AbilityAvatarChangeSkillMixin() {} // 0x000000018225E0C0-0x000000018225E120

	// Methods
	// [XID] // 0x0000000189BDE960-0x0000000189BDE980
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018225D240-0x000000018225D4D0
	// [XID] // 0x00000001895EB3F0-0x00000001895EB410
	private void RefreshInfo() {} // 0x000000018225DD60-0x000000018225DF50
	// [XID] // 0x00000001895F2840-0x00000001895F2860
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x000000018225D820-0x000000018225D900
	// [XID] // 0x00000001895FA1A0-0x00000001895FA1C0
	public override bool OnEvent(BaseEvent evt) => default; // 0x000000018225DC10-0x000000018225DCE0
	// [XID] // 0x0000000189601B30-0x0000000189601B50
	public override void Clear() {} // 0x000000018225D740-0x000000018225D820
	// [XID] // 0x0000000189609360-0x0000000189609380
	public override void OnAdded(bool syncToServer) {} // 0x000000018225CC80-0x000000018225CD60
	// [XID] // 0x0000000189610AE0-0x0000000189610B00
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x000000018225D170-0x000000018225D240
	// [XID] // 0x0000000189617DB0-0x0000000189617DD0
	public override void Tick(float inDeltaTime) {} // 0x000000018225DFF0-0x000000018225E0C0
	// [XID] // 0x000000018961FA90-0x000000018961FAB0
	private bool CheckShouldChangeSkill() => default; // 0x000000018225D550-0x000000018225D6D0
	// [XID] // 0x0000000189626D50-0x0000000189626D70
	private void ChangeCurrentSkillInfo(LCAvatarCombat.SkillInfo skillInfo) {} // 0x000000018225CF70-0x000000018225D110
	// [XID] // 0x000000018962E6A0-0x000000018962E6C0
	private void ResetCurrentSkillInfo() {} // 0x000000018225DA40-0x000000018225DBB0
	[BlackList] // 0x0000000189636360-0x00000001896363A0
	// [XID] // 0x0000000189636360-0x00000001896363A0
	public override void AutoAllocTypeFields() {} // 0x000000018225CDF0-0x000000018225CE90
	[BlackList] // 0x0000000189640600-0x0000000189640640
	// [XID] // 0x0000000189640600-0x0000000189640640
	public override void AutoRecycleTypeFields() {} // 0x000000018225CE90-0x000000018225CF70
	[BlackList] // 0x000000018964AE20-0x000000018964AE60
	// [XID] // 0x000000018964AE20-0x000000018964AE60
	public override void ReturnToObjectPool() {} // 0x000000018225DF50-0x000000018225DFF0
}

