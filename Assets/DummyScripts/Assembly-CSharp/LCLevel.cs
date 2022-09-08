/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UniRx;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCLevel : LCBase // TypeDefIndex: 11737
{
	// Fields
	private EntityTimer _timer; // 0x130
	private List<string> _levelConfigName; // 0x138
	private LevelSyncAbilityPlugin _abilitySyncPlugin; // 0x140
	private LevelSyncCombatPlugin _combatSyncPlugin; // 0x148
	private LevelConfigValidationPlugin _configValidationPlugin; // 0x150
	private float _timeSlowTimer; // 0x158
	private Action _timeSlowDoneCallback; // 0x160
	public MPActorAbilityPlugin lastRecordedPlugin; // 0x168
	private List<Tuple<uint, string>> _clientAbilityInfos; // 0x170
	private List<Tuple<uint, string>> _serverAbilityInfos; // 0x178
	private List<Tuple<uint, string>> _toAddAbilities; // 0x180
	private List<Tuple<uint, string>> _toRemoveAbilities; // 0x188
	private List<ActorModifier> _appliedModifiersTemp; // 0x190
	private Dictionary<uint, Action> _entitiesReadyCallbacks; // 0x198
	private Dictionary<uint, Action> _entitiesActionInvokeCallbacks; // 0x1A0
	private HashSet<uint> _entitiesTryToAppear; // 0x1A8
	private List<uint> _bornLocalGadgetIds; // 0x1B8

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018984A470-0x000000018984A490 */ get => default; } // 0x0000000181405990-0x0000000181405A30 
	public EntityTimer Timer { /* [XID] */ /* 0x0000000189662EA0-0x0000000189662EC0 */ get => default; } // 0x0000000181403190-0x0000000181403240 
	public bool isReconnectingSceneInitFinish { /* [XID] */ /* 0x0000000189B19E00-0x0000000189B19E40 */ get; /* [XID] */ /* 0x0000000189B24580-0x0000000189B245C0 */ set; } // 0x0000000181404190-0x00000001814041F0 0x0000000181403590-0x0000000181403600

	// Nested types
	public enum AbilityRecoverReason // TypeDefIndex: 11738
	{
		Reconnect = 0,
		ChangeAuthority = 1
	}

	// Constructors
	public LCLevel() {} // 0x0000000181405840-0x0000000181405990

	// Methods
	// [XID] // 0x0000000189851A60-0x0000000189851A80
	public override void Init() {} // 0x0000000181401CF0-0x0000000181401FA0
	// [XID] // 0x00000001899BBA90-0x00000001899BBAB0
	public override void Destroy() {} // 0x00000001813FD0B0-0x00000001813FD210
	// [XID] // 0x00000001899C36B0-0x00000001899C36D0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001813FE100-0x00000001813FE1D0
	// [XID] // 0x00000001899CAB40-0x00000001899CAB60
	protected override bool OnEvent(BaseEvent e) => default; // 0x0000000181404F10-0x00000001814052D0
	// [XID] // 0x00000001898E4AC0-0x00000001898E4AE0
	private void HandleEvtMovingWaterChangeState(EvtMovingWaterChangeState evt) {} // 0x00000001813F9D70-0x00000001813F9F50
	// [XID] // 0x00000001899D98E0-0x00000001899D9900
	private void HandleStageCreate() {} // 0x0000000181405510-0x00000001814056D0
	// [XID] // 0x00000001898CDD70-0x00000001898CDD90
	private void HandleStageReady() {} // 0x00000001814029D0-0x0000000181402B90
	// [XID] // 0x00000001899E8A60-0x00000001899E8A80
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x00000001813FE020-0x00000001813FE100
	// [XID] // 0x00000001899F0180-0x00000001899F01A0
	protected override bool ListenEvent(BaseEvent evt) => default; // 0x00000001814036F0-0x00000001814037B0
	// [XID] // 0x0000000189937410-0x0000000189937430
	protected override void Tick(float inDeltaTime) {} // 0x00000001814056D0-0x0000000181405840
	// [XID] // 0x0000000189964370-0x0000000189964390
	public void TimeSlow(float duration, float slowRatio, uint sourceID, Action doneCallback) {} // 0x00000001813F9BF0-0x00000001813F9D70
	// [XID] // 0x00000001899993A0-0x00000001899993C0
	public void SetLevelConfigNameList(RepeatedField<string> levelConfigNameList) {} // 0x0000000181403340-0x0000000181403590
	// [XID] // 0x00000001897A0C80-0x00000001897A0CA0
	public List<string> GetLevelConfigNameList() => default; // 0x00000001813FAB40-0x00000001813FABF0
	// [XID] // 0x00000001898D5750-0x00000001898D5770
	public void HandleEntityReady(uint entityRuntimeID) {} // 0x0000000181403240-0x0000000181403340
	// [XID] // 0x000000018974A1F0-0x000000018974A210
	public void HandleEntityCachedActionInvoke(uint entityRuntimeID) {} // 0x0000000181400180-0x0000000181400280
	// [XID] // 0x0000000189A23E30-0x0000000189A23E50
	public void CheckAbilityNeedSyncFromServer(BaseEntity entity, AbilitySyncStateInfo serverAbilityInfo) {} // 0x0000000181401FA0-0x00000001814020B0
	// [XID] // 0x0000000189A2B0E0-0x0000000189A2B100
	public void RecoverEntityAbilityFromServer(BaseEntity entity, AbilitySyncStateInfo serverAbilityInfo, bool createNewAbiltiySyncInfo = true /* Metadata: 0x00AEA770 */, AbilityRecoverReason recoverReason = AbilityRecoverReason.Reconnect /* Metadata: 0x00AEA771 */) {} // 0x0000000181402200-0x0000000181402970
	// [XID] // 0x0000000189A32790-0x0000000189A327B0
	private void ApplyEntityAbilityStateInfo(BaseEntity entity, AbilitySyncStateInfo abilitySyncStateInfo) {} // 0x0000000181402DF0-0x0000000181403190
	// [XID] // 0x0000000189A3A090-0x0000000189A3A0B0
	private void HandleReconnectActions(BaseEntity entity, AbilityRecoverReason recoverReason) {} // 0x00000001814037B0-0x0000000181403AE0
	// [XID] // 0x0000000189A41980-0x0000000189A419A0
	private void ApplyMixinRecoverData(LCAbility abilityCom, RepeatedMessageField<AbilityMixinRecoverInfo> mixinRecoverData) {} // 0x00000001813FD210-0x00000001813FD6F0
	// [XID] // 0x000000018981C820-0x000000018981C840
	private void RefreshAvatarAppliedAbilities(LCAbility abilityCom, AbilitySyncStateInfo abilitySyncStateInfo) {} // 0x00000001813FACB0-0x00000001813FBFD0
	// [XID] // 0x0000000189A508A0-0x0000000189A508C0
	private void CheckAbilitySyncStateFailed(LCAbility abilityCom, RepeatedMessageField<AbilityScalarValueEntry> dynamicValueMap, RepeatedMessageField<AbilityAppliedAbility> recoverAppliedAbilities, RepeatedMessageField<AbilityAppliedModifier> recoverAppliedModifiers) {} // 0x0000000181400280-0x00000001814016E0
	// [XID] // 0x0000000189A57DA0-0x0000000189A57DC0
	private ConfigAbilityModifier GetRecoverModifierConfig(BaseEntity entity, AbilityAppliedModifier appliedModifier) => default; // 0x00000001813FFE10-0x0000000181400180
	// [XID] // 0x0000000189A5F9D0-0x0000000189A5F9F0
	private int GetValidRecoverAppliedModifierCount(RepeatedMessageField<AbilityAppliedModifier> appliedModifiers, BaseEntity entity) => default; // 0x00000001813FA3D0-0x00000001813FA6C0
	// [XID] // 0x0000000189A672F0-0x0000000189A67310
	private bool CheckDynamicFloatMapHasKeyAndEqual(RepeatedMessageField<AbilityScalarValueEntry> dynamicValueMap, string key, float value) => default; // 0x00000001813FC1E0-0x00000001813FC500
	// [XID] // 0x0000000189A6E940-0x0000000189A6E960
	private bool CheckAbilityOverrideMapEqual(LCAbility abilityCom, AbilityAppliedAbility recoverAppliedAbility) => default; // 0x00000001813FC9E0-0x00000001813FD0B0
	// [XID] // 0x00000001897859C0-0x00000001897859E0
	private void DeallocateAbilitySyncStateInfo(AbilitySyncStateInfo abilitySyncStateInfo) {} // 0x00000001813FC100-0x00000001813FC1E0
	// [XID] // 0x0000000189A7DBA0-0x0000000189A7DBC0
	private void PostProcessAppliedModifiers(LCAbility abilityCom) {} // 0x00000001813F9FB0-0x00000001813FA3D0
	// [XID] // 0x0000000189A85450-0x0000000189A85470
	private void PreProcessAppliedAbilityMixins(LCAbility abilityCom) {} // 0x00000001813FA6C0-0x00000001813FAAC0
	// [XID] // 0x00000001896DA510-0x00000001896DA530
	private void PostProcessAppliedMixins(LCAbility abilityCom) {} // 0x00000001813FC500-0x00000001813FC9E0
	// [XID] // 0x0000000189A94170-0x0000000189A94190
	private void ApplyAppliedAbilities(LCAbility abilityCom, RepeatedMessageField<AbilityAppliedAbility> appliedAbilities) {} // 0x00000001814016E0-0x0000000181401CF0
	// [XID] // 0x0000000189A9BB20-0x0000000189A9BB40
	public void AddEntityTryToAppear(uint entityId) {} // 0x00000001813FBFD0-0x00000001813FC100
	// [XID] // 0x0000000189AA2FE0-0x0000000189AA3000
	public void RemoveEntityTryToAppear(uint entityId) {} // 0x0000000181404CA0-0x0000000181404D60
	// [XID] // 0x00000001899735A0-0x00000001899735C0
	public bool IsEntityTryToAppear(uint entityId) => default; // 0x00000001813FE410-0x00000001813FE4E0
	// [XID] // 0x0000000189AB2390-0x0000000189AB23B0
	public void AddEntityReadyCallback(uint entityId, Action callback) {} // 0x0000000181404D60-0x0000000181404F10
	// [XID] // 0x0000000189AB97E0-0x0000000189AB9800
	public void RemoveParentEntityReadyCallback(uint entityId) {} // 0x0000000181403600-0x00000001814036F0
	// [XID] // 0x0000000189AC1350-0x0000000189AC1370
	public void RemoveEntityReadyCallback(uint ownerID, Action action) {} // 0x00000001814020B0-0x0000000181402200
	// [XID] // 0x0000000189AC8C80-0x0000000189AC8CA0
	public void AddEntityActionInvokeCallback(uint entityId, Action callback) {} // 0x0000000181402C40-0x0000000181402DF0
	// [IDTag] // 0x0000000189AD0400-0x0000000189AD0440
	// [XID] // 0x0000000189AD0400-0x0000000189AD0440
	public void RemoveEntityActionInvokeCallback(uint entityId) {} // 0x00000001814052D0-0x00000001814053C0
	// [IDTag] // 0x0000000189ADB150-0x0000000189ADB190
	// [XID] // 0x0000000189ADB150-0x0000000189ADB190
	public void RemoveEntityActionInvokeCallback(uint ownerID, Action action) {} // 0x00000001814053C0-0x0000000181405510
	// [XID] // 0x0000000189AE5F00-0x0000000189AE5F20
	private void ApplyAppliedModifiers(LCAbility abilityCom, RepeatedMessageField<AbilityAppliedModifier> appliedModifiers) {} // 0x00000001813FE4E0-0x00000001813FFE10
	// [XID] // 0x0000000189983DD0-0x0000000189983DF0
	private ActorModifier ApplyAppliedModfier(LCAbility abilityCom, ConfigAbility configAbility, ActorAbility parentAbility, uint parentAbilityEntityID, int modifierLocalId, uint instancedModifierId, AbilityAttachedModifier attachedInstancedModifier, uint modifierApplyId, bool attachedParentAbility, uint serverBuffUid, bool isSBuffBucket) => default; // 0x00000001814044C0-0x0000000181404C20
	// [XID] // 0x0000000189672740-0x0000000189672760
	private void AuthorityStartModifierThinkTimerAndDurability(ActorAbility instancedAbility, ActorModifier actorModifier, bool recoverfromServer = false /* Metadata: 0x00AEA775 */, float remainDurability = 0f /* Metadata: 0x00AEA776 */) {} // 0x00000001813FE280-0x00000001813FE410
	// [XID] // 0x0000000189B94170-0x0000000189B94190
	public void LazySetModifierParentAbility(ActorModifier modifier, ActorAbility parentAbility, bool recoverFromServer = false /* Metadata: 0x00AEA77A */, float remainDurability = 0f /* Metadata: 0x00AEA77B */) {} // 0x0000000181403E10-0x0000000181404190
	// [XID] // 0x0000000189B03C50-0x0000000189B03C70
	private void ApplyDynamicValueMap(LCAbility abilityCom, RepeatedMessageField<AbilityScalarValueEntry> dynamicValueMap) {} // 0x00000001813FD770-0x00000001813FDA80
	// [XID] // 0x0000000189B0B2A0-0x0000000189B0B2C0
	public void ApplyEntityServerGlobalValue(BaseEntity entity, AbilitySyncStateInfo stateInfo) {} // 0x0000000181403D00-0x0000000181403E10
	// [XID] // 0x0000000189B12B10-0x0000000189B12B30
	private void ApplyServerGlobalValue(LCAbility abilityCom, RepeatedMessageField<AbilityScalarValueEntry> dynamicValueMap) {} // 0x00000001814041F0-0x00000001814044C0
	// [XID] // 0x0000000189B2E860-0x0000000189B2E880
	public void AddBornLocalGadget(uint entityId) {} // 0x0000000181403AE0-0x0000000181403C10
	// [XID] // 0x0000000189B35F30-0x0000000189B35F50
	public void RemoveBornLocalGadget(uint entityId) {} // 0x00000001813FDA80-0x00000001813FDB70
	// [XID] // 0x0000000189B3D600-0x0000000189B3D620
	public void ClearRedundantLocalGadgets() {} // 0x00000001813FDBF0-0x00000001813FDEF0
	// [XID] // 0x000000018995CAE0-0x000000018995CB00
	public void OnFrameEnd() {} // 0x00000001813FABF0-0x00000001813FACB0
	// [XID] // 0x0000000189A310C0-0x0000000189A310E0
	public LevelSyncAbilityPlugin GetAbilitySyncPlugin() => default; // 0x00000001813FDEF0-0x00000001813FDFA0
	// [XID] // 0x0000000189B541C0-0x0000000189B541E0
	public LevelSyncCombatPlugin GetCombatSyncPlugin() => default; // 0x00000001813FE1D0-0x00000001813FE280
	// [XID] // 0x00000001898A2A80-0x00000001898A2AA0
	public LevelConfigValidationPlugin GetConfigValidationPlugin() => default; // 0x0000000181402B90-0x0000000181402C40
}

