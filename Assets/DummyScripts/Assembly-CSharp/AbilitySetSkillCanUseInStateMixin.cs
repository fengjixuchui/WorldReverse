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

public sealed class AbilitySetSkillCanUseInStateMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14566
{
	// Fields
	private SetSkillCanUseInStateMixin _config; // 0x70
	private LCAvatarCombat _lcCombat; // 0x78
	private int[] _stateIDList; // 0x80
	private bool _setted; // 0x88

	// Constructors
	public AbilitySetSkillCanUseInStateMixin() {} // 0x0000000183EAF2A0-0x0000000183EAF300

	// Methods
	// [XID] // 0x0000000189916760-0x0000000189916780
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000183EAEA90-0x0000000183EAED30
	// [XID] // 0x000000018991DF10-0x000000018991DF30
	public override void Clear() {} // 0x0000000183EAEDA0-0x0000000183EAEE50
	// [XID] // 0x0000000189925800-0x0000000189925820
	public override void OnAdded(bool syncToServer) {} // 0x0000000183EAE4B0-0x0000000183EAE570
	// [XID] // 0x000000018992CC70-0x000000018992CC90
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000183EAE9D0-0x0000000183EAEA90
	// [XID] // 0x00000001899341A0-0x00000001899341C0
	private void TryEnableSkillInState() {} // 0x0000000183EAE760-0x0000000183EAE970
	// [XID] // 0x000000018993BEB0-0x000000018993BED0
	private void TryDisableSkillInState() {} // 0x0000000183EAEFF0-0x0000000183EAF200
	[BlackList] // 0x0000000189943210-0x0000000189943250
	// [XID] // 0x0000000189943210-0x0000000189943250
	public override void AutoAllocTypeFields() {} // 0x0000000183EAE600-0x0000000183EAE6A0
	[BlackList] // 0x000000018994D9A0-0x000000018994D9E0
	// [XID] // 0x000000018994D9A0-0x000000018994D9E0
	public override void AutoRecycleTypeFields() {} // 0x0000000183EAE6A0-0x0000000183EAE760
	[BlackList] // 0x0000000189958330-0x0000000189958370
	// [XID] // 0x0000000189958330-0x0000000189958370
	public override void ReturnToObjectPool() {} // 0x0000000183EAF200-0x0000000183EAF2A0
}

