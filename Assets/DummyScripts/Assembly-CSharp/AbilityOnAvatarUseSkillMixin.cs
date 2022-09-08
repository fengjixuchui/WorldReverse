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

public sealed class AbilityOnAvatarUseSkillMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14553
{
	// Fields
	private OnAvatarUseSkillMixin _config; // 0x70
	private LCAvatarCombat _combat; // 0x78
	private uint _skillId; // 0x80
	private int _triggerId; // 0x84

	// Constructors
	public AbilityOnAvatarUseSkillMixin() {} // 0x0000000183AC5E50-0x0000000183AC5EB0

	// Methods
	// [XID] // 0x0000000189B76510-0x0000000189B76530
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000183AC4F40-0x0000000183AC5180
	// [XID] // 0x0000000189B7DAC0-0x0000000189B7DAE0
	private void OnAnimatorStateChanged(EvtAnimatorStateChangedBeforeClear evt) {} // 0x0000000183AC5400-0x0000000183AC55F0
	// [XID] // 0x0000000189B85740-0x0000000189B85760
	public override void Clear() {} // 0x0000000183AC5180-0x0000000183AC52A0
	// [XID] // 0x0000000189B8C4F0-0x0000000189B8C510
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000183AC52A0-0x0000000183AC53A0
	// [XID] // 0x0000000189B93EF0-0x0000000189B93F10
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000183AC5730-0x0000000183AC58F0
	// [XID] // 0x0000000189B9B4B0-0x0000000189B9B4D0
	private void OnSkill(uint skillID, int tagHash, UseSkillType skillType) {} // 0x0000000183AC58F0-0x0000000183AC5DB0
	[BlackList] // 0x0000000189BA2BB0-0x0000000189BA2BF0
	// [XID] // 0x0000000189BA2BB0-0x0000000189BA2BF0
	public override void AutoAllocTypeFields() {} // 0x0000000183AC4D90-0x0000000183AC4E30
	[BlackList] // 0x0000000189BACC40-0x0000000189BACC80
	// [XID] // 0x0000000189BACC40-0x0000000189BACC80
	public override void AutoRecycleTypeFields() {} // 0x0000000183AC4E30-0x0000000183AC4EE0
	[BlackList] // 0x0000000189BB7200-0x0000000189BB7240
	// [XID] // 0x0000000189BB7200-0x0000000189BB7240
	public override void ReturnToObjectPool() {} // 0x0000000183AC5DB0-0x0000000183AC5E50
}

