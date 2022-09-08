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

public sealed class AbilityModifySkillCDByModifierCountMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14549
{
	// Fields
	private ModifySkillCDByModifierCountMixin config; // 0x70

	// Constructors
	public AbilityModifySkillCDByModifierCountMixin() {} // 0x0000000181E98EF0-0x0000000181E98F50

	// Methods
	// [XID] // 0x0000000189A716F0-0x0000000189A71710
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000181E98560-0x0000000181E98710
	// [XID] // 0x0000000189A791D0-0x0000000189A791F0
	public override void Clear() {} // 0x0000000181E98A10-0x0000000181E98B40
	// [XID] // 0x0000000189A80860-0x0000000189A80880
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000181E98B40-0x0000000181E98C20
	// [XID] // 0x0000000189A88340-0x0000000189A88360
	public override bool ListenEvent(BaseEvent evt) => default; // 0x0000000181E98C80-0x0000000181E98D90
	// [XID] // 0x0000000189A8FC90-0x0000000189A8FCB0
	private bool OnApplyModifier(EvtApplyModifier evt) => default; // 0x0000000181E98710-0x0000000181E98A10
	[BlackList] // 0x0000000189A972B0-0x0000000189A972F0
	// [XID] // 0x0000000189A972B0-0x0000000189A972F0
	public override void AutoAllocTypeFields() {} // 0x0000000181E98330-0x0000000181E983D0
	[BlackList] // 0x0000000189AA15E0-0x0000000189AA1620
	// [XID] // 0x0000000189AA15E0-0x0000000189AA1620
	public override void AutoRecycleTypeFields() {} // 0x0000000181E983D0-0x0000000181E98480
	[BlackList] // 0x0000000189AABF30-0x0000000189AABF70
	// [XID] // 0x0000000189AABF30-0x0000000189AABF70
	public override void ReturnToObjectPool() {} // 0x0000000181E98E50-0x0000000181E98EF0
}

