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

public sealed class AbilityDoActionByElementReactionMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14508
{
	// Fields
	private DoActionByElementReactionMixin config; // 0x70
	private float _sqrRange; // 0x78
	private bool _ignoreEntityTypeCheck; // 0x7C
	private bool _ignoreReactionTypeCheck; // 0x7D

	// Constructors
	public AbilityDoActionByElementReactionMixin() {} // 0x0000000180FD0990-0x0000000180FD09F0

	// Methods
	// [XID] // 0x000000018975B710-0x000000018975B730
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000180FD0190-0x0000000180FD0380
	// [XID] // 0x0000000189763140-0x0000000189763160
	public override void Clear() {} // 0x0000000180FD03F0-0x0000000180FD04A0
	// [XID] // 0x000000018976A910-0x000000018976A930
	protected override void AddEventListener() {} // 0x0000000180FCF870-0x0000000180FCF9E0
	// [XID] // 0x0000000189771EF0-0x0000000189771F10
	protected override void RemoveEventListener() {} // 0x0000000180FD0500-0x0000000180FD0670
	// [XID] // 0x0000000189779720-0x0000000189779740
	public override void OnAdded(bool syncToServer) {} // 0x0000000180FCF5D0-0x0000000180FCF690
	// [XID] // 0x00000001897810A0-0x00000001897810C0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000180FD00E0-0x0000000180FD0190
	// [XID] // 0x0000000189788560-0x0000000189788580
	private void OnCasterElementReaction(ElementReactionType reactionType, BaseEntity target) {} // 0x0000000180FCFCC0-0x0000000180FD00E0
	// [XID] // 0x000000018978FC20-0x000000018978FC40
	public override void HandleMixinInvokeEntry(UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000180FCFA40-0x0000000180FCFCC0
	[BlackList] // 0x0000000189797430-0x0000000189797470
	// [XID] // 0x0000000189797430-0x0000000189797470
	public override void AutoAllocTypeFields() {} // 0x0000000180FCF720-0x0000000180FCF7C0
	[BlackList] // 0x00000001897A2160-0x00000001897A21A0
	// [XID] // 0x00000001897A2160-0x00000001897A21A0
	public override void AutoRecycleTypeFields() {} // 0x0000000180FCF7C0-0x0000000180FCF870
	[BlackList] // 0x00000001897AC940-0x00000001897AC980
	// [XID] // 0x00000001897AC940-0x00000001897AC980
	public override void ReturnToObjectPool() {} // 0x0000000180FD08F0-0x0000000180FD0990
}

