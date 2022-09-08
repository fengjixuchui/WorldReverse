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

public sealed class AbilityWatcherSystemMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14599
{
	// Fields
	private WatcherSystemMixin _config; // 0x70
	private bool _predicatePass; // 0x78
	private uint _listenTargetId; // 0x7C
	private int _listenStateId; // 0x80

	// Constructors
	public AbilityWatcherSystemMixin() {} // 0x000000018462A240-0x000000018462A2B0

	// Methods
	// [XID] // 0x0000000189B03AD0-0x0000000189B03AF0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000184626D60-0x0000000184626EA0
	// [XID] // 0x0000000189B0B120-0x0000000189B0B140
	public override void Clear() {} // 0x0000000184627710-0x00000001846277C0
	// [XID] // 0x0000000189B12A10-0x0000000189B12A30
	public override void OnAdded(bool syncToServer) {} // 0x0000000184625A60-0x0000000184625B20
	// [XID] // 0x0000000189B19C60-0x0000000189B19C80
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000184626AD0-0x0000000184626B80
	// [XID] // 0x0000000189B21290-0x0000000189B212B0
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x00000001846279F0-0x0000000184627AC0
	// [XID] // 0x0000000189B28B00-0x0000000189B28B20
	public override bool ListenEvent(BaseEvent evt) => default; // 0x0000000184629150-0x00000001846293E0
	// [XID] // 0x0000000189B2FEF0-0x0000000189B2FF10
	protected override void AddEventListener() {} // 0x0000000184625DD0-0x0000000184626920
	// [XID] // 0x0000000189B377C0-0x0000000189B377E0
	protected override void RemoveEventListener() {} // 0x0000000184627D50-0x0000000184628600
	// [XID] // 0x0000000189B3F0B0-0x0000000189B3F0D0
	private bool OnElementReaction(EvtElementReaction evt) => default; // 0x000000018462A0C0-0x000000018462A1A0
	// [XID] // 0x0000000189B469A0-0x0000000189B469C0
	private void OnElementReactionBush(EvtElementReaction evt) {} // 0x0000000184626C90-0x0000000184626D60
	// [XID] // 0x0000000189B4E150-0x0000000189B4E170
	private void OnElementReactionGrass(EvtElementReaction evt) {} // 0x0000000184626980-0x0000000184626A50
	// [XID] // 0x0000000189B557E0-0x0000000189B55800
	private void OnElementReactionWater(EvtElementReaction evt) {} // 0x0000000184625D00-0x0000000184625DD0
	// [XID] // 0x0000000189B5D1F0-0x0000000189B5D210
	private void OnElementReactionInternal(EvtElementReaction evt) {} // 0x0000000184629E00-0x000000018462A040
	// [XID] // 0x0000000189B648F0-0x0000000189B64910
	private bool OnAttackLanded(EvtAttackLanded evt) => default; // 0x0000000184628EE0-0x0000000184629150
	// [XID] // 0x0000000189B6BD60-0x0000000189B6BD80
	private bool OnDoSkillSucc(EvtDoSkillSucc evt) => default; // 0x0000000184628600-0x0000000184628AF0
	// [XID] // 0x0000000189B73650-0x0000000189B73670
	private bool OnShieldAdded(EvtShieldAdded evt) => default; // 0x0000000184626EA0-0x0000000184627190
	// [XID] // 0x0000000189B7AAF0-0x0000000189B7AB10
	private bool OnWatcherSysAction(EvtWatcherSysAction evt) => default; // 0x0000000184629B70-0x0000000184629E00
	// [XID] // 0x0000000189B82330-0x0000000189B82350
	private bool OnChangeProp(EvtChangeProp evt) => default; // 0x00000001846298B0-0x0000000184629B70
	// [XID] // 0x0000000189B89BD0-0x0000000189B89BF0
	private void OnGainFirstWindSeedBullet(EvtWindSeedMixinInfo evt) {} // 0x00000001846277C0-0x00000001846279F0
	// [XID] // 0x0000000189B91160-0x0000000189B91180
	private void OnGainSecondWindSeedBullet(EvtWindSeedMixinInfo evt) {} // 0x00000001846293E0-0x0000000184629610
	// [XID] // 0x0000000189B983B0-0x0000000189B983D0
	private void OnSpawnWindFieldByWindSeed(EvtWindSeedMixinInfo evt) {} // 0x0000000184627B20-0x0000000184627D50
	// [XID] // 0x0000000189B9F8C0-0x0000000189B9F8E0
	private void OnStateIDChanged(EvtStateIDChanged evt) {} // 0x0000000184629670-0x00000001846297F0
	// [XID] // 0x0000000189BA7190-0x0000000189BA71B0
	private bool OnApplyModifier(EvtApplyModifier evt) => default; // 0x0000000184627190-0x00000001846276A0
	// [XID] // 0x0000000189BAE2C0-0x0000000189BAE2E0
	private bool ChangeListenTarget(EvtAvatarChanged evt) => default; // 0x0000000184628B50-0x0000000184628EE0
	// [XID] // 0x0000000189BB5C10-0x0000000189BB5C30
	private void SendWatcherTriggerPassMsg() {} // 0x0000000184626B80-0x0000000184626C90
	[BlackList] // 0x0000000189BBD1F0-0x0000000189BBD230
	// [XID] // 0x0000000189BBD1F0-0x0000000189BBD230
	public override void AutoAllocTypeFields() {} // 0x0000000184625BB0-0x0000000184625C50
	[BlackList] // 0x0000000189BC7C20-0x0000000189BC7C60
	// [XID] // 0x0000000189BC7C20-0x0000000189BC7C60
	public override void AutoRecycleTypeFields() {} // 0x0000000184625C50-0x0000000184625D00
	[BlackList] // 0x0000000189BD2750-0x0000000189BD2790
	// [XID] // 0x0000000189BD2750-0x0000000189BD2790
	public override void ReturnToObjectPool() {} // 0x000000018462A1A0-0x000000018462A240
}

