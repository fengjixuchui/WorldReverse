/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MPActorAbilityPlugin : ActorAbilityPlugin // TypeDefIndex: 12140
{
	// Fields
	public const int INVOCATION_META_LOCALID = 0; // Metadata: 0x00AEB569
	public Action<BaseEntity, ActorModifier> onMPModiferAdded; // 0x1F8
	private List<AbilityEntryProxy> _invokeAbilities; // 0x200

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189AFAF20-0x0000000189AFAF40 */ get => default; } // 0x00000001823A20C0-0x00000001823A2200 

	// Nested types
	public delegate void MPRemoteActionHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, AbilityInvokeEntry invokeEntry); // TypeDefIndex: 12141; 0x0000000182126810-0x0000000182126C20

	public delegate void MPAuthorityActionHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context); // TypeDefIndex: 12142; 0x00000001821253F0-0x0000000182125890

	public class AbilityInvokeArgumentComparer : IEqualityComparer<AbilityInvokeArgument> // TypeDefIndex: 12143
	{
		// Constructors
		public AbilityInvokeArgumentComparer() {} // 0x0000000182125A90-0x0000000182125AF0

		// Methods
		// [XID] // 0x00000001897C2400-0x00000001897C2420
		public bool Equals(AbilityInvokeArgument x, AbilityInvokeArgument y) => default; // 0x0000000182125910-0x00000001821259E0
		// [XID] // 0x00000001897C9BA0-0x00000001897C9BC0
		public int GetHashCode(AbilityInvokeArgument obj) => default; // 0x00000001821259E0-0x0000000182125A90
	}

	public enum ParentAbilityEntityStatus // TypeDefIndex: 12144
	{
		TargetReady = 0,
		TargetNone = 1,
		TargetNotReady = 2
	}

	// Constructors
	public MPActorAbilityPlugin() {} // Dummy constructor
	public MPActorAbilityPlugin(LCAbility abilityActor) {} // 0x00000001823A1FF0-0x00000001823A20C0

	// Methods
	// [XID] // 0x0000000189B024E0-0x0000000189B02500
	public void ApplyModifier_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x000000018238C540-0x000000018238C970
	// [XID] // 0x0000000189B09AC0-0x0000000189B09AE0
	public void ApplyModifier_RemoteHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000182397C80-0x0000000182398260
	// [XID] // 0x0000000189B11500-0x0000000189B11520
	public void ApplyLevelModifier_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x000000018239ECE0-0x000000018239F200
	// [XID] // 0x0000000189B18750-0x0000000189B18770
	public void ApplyLevelModifier_RemoteHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000182398900-0x0000000182398EA0
	// [XID] // 0x0000000189B1FE10-0x0000000189B1FE30
	public void AttachModifier_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x000000018238DFB0-0x000000018238E350
	// [XID] // 0x0000000189B27560-0x0000000189B27580
	public void AttachModifier_RemoteHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, UnionAbilityInvokeEntry invokeEntry) {} // 0x000000018238A900-0x000000018238B0B0
	// [XID] // 0x0000000189B2E740-0x0000000189B2E760
	public void RemoveModifier_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000182391BA0-0x00000001823920E0
	// [XID] // 0x0000000189B35DF0-0x0000000189B35E10
	public void RemoveModifier_RemoteHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000182398260-0x0000000182398900
	// [XID] // 0x0000000189B3D540-0x0000000189B3D560
	public void RemoveUniqueModifier_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x000000018238C970-0x000000018238CD80
	// [XID] // 0x0000000189B453A0-0x0000000189B453C0
	public void RemoveUniqueModifier_RemoteHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, UnionAbilityInvokeEntry invokeEntry) {} // 0x000000018239F4B0-0x000000018239FA90
	// [XID] // 0x0000000189B4C9F0-0x0000000189B4CA10
	public void KillSelf_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000182396F60-0x0000000182397280
	// [XID] // 0x0000000189B54140-0x0000000189B54160
	public void KillSelf_RemoteHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, UnionAbilityInvokeEntry invokeEntry) {} // 0x00000001823A1800-0x00000001823A1AD0
	// [XID] // 0x0000000189B5BBA0-0x0000000189B5BBC0
	public void TriggerAbility_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x000000018238ED70-0x000000018238EFD0
	// [XID] // 0x0000000189B62FA0-0x0000000189B62FC0
	public void TriggerAbility_RemoteHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000182397280-0x00000001823974C0
	// [XID] // 0x0000000189B6A930-0x0000000189B6A950
	public void SetAnimatorTrigger_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x00000001823A1640-0x00000001823A1800
	// [XID] // 0x0000000189B72180-0x0000000189B721A0
	public void SetAnimatorTrigger_RemoteHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, UnionAbilityInvokeEntry invokeEntry) {} // 0x000000018239C120-0x000000018239C2D0
	// [XID] // 0x0000000189B79530-0x0000000189B79550
	public void TimeSlow_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x000000018238C310-0x000000018238C540
	// [XID] // 0x0000000189B80910-0x0000000189B80930
	public void TimeSlow_RemoteHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, UnionAbilityInvokeEntry invokeEntry) {} // 0x000000018238F670-0x000000018238F8A0
	// [XID] // 0x0000000189B88560-0x0000000189B88580
	public void SetCrashDamage_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000182396090-0x00000001823963B0
	// [XID] // 0x0000000189B8F780-0x0000000189B8F7A0
	public void SetCrashDamage_RemoteHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000182399BA0-0x0000000182399F80
	// [XID] // 0x0000000189B96CE0-0x0000000189B96D00
	public void FireEffect_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000182395020-0x0000000182395540
	// [XID] // 0x0000000189B9E150-0x0000000189B9E170
	public void FireEffect_RemoteHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, UnionAbilityInvokeEntry invokeEntry) {} // 0x000000018238DB20-0x000000018238DF00
	// [XID] // 0x0000000189BA5A50-0x0000000189BA5A70
	public void AttachEffect_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x00000001823A1AD0-0x00000001823A1F60
	// [XID] // 0x0000000189BACD60-0x0000000189BACD80
	public void AttachEffect_RemoteHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000182393C30-0x0000000182393FF0
	// [XID] // 0x0000000189BB4650-0x0000000189BB4670
	public void Summon_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x000000018238B5E0-0x000000018238BCC0
	// [XID] // 0x0000000189BBBC10-0x0000000189BBBC30
	public void CreateItem_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x00000001823A13D0-0x00000001823A1640
	// [XID] // 0x0000000189BC3AB0-0x0000000189BC3AD0
	public void CreateGadget_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000182396690-0x0000000182396A90
	// [XID] // 0x0000000189BCB280-0x0000000189BCB2A0
	public void CreateMovingPlatform_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x000000018239CF50-0x000000018239D3B0
	// [XID] // 0x0000000189BD2870-0x0000000189BD2890
	public void GenerateElemBall_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x000000018238B0B0-0x000000018238B5E0
	// [XID] // 0x0000000189BD9DF0-0x0000000189BD9E10
	public void TryFindBlinkPoint_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000182392B30-0x0000000182392E20
	// [XID] // 0x00000001895E68F0-0x00000001895E6910
	public void TryFindBlinkPoint_RemoteHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, UnionAbilityInvokeEntry invokeEntry) {} // 0x00000001823977A0-0x0000000182397C20
	// [XID] // 0x00000001895EE410-0x00000001895EE430
	public void TryFindBlinkPointByBorn_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000182395850-0x0000000182395B40
	// [XID] // 0x00000001895F5BB0-0x00000001895F5BD0
	public void ExecuteGadgetLua_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000182392A10-0x0000000182392B30
	// [XID] // 0x00000001895FD0B0-0x00000001895FD0D0
	public void ServerMonsterLog_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x00000001823963B0-0x0000000182396690
	// [XID] // 0x0000000189604A90-0x0000000189604AB0
	public void FlushRecordInvokeEntriesAndSend() {} // 0x000000018238CD80-0x000000018238CE70
	// [XID] // 0x000000018960C320-0x000000018960C340
	public override void OnEntityReady() {} // 0x000000018239FA90-0x000000018239FB30
	// [XID] // 0x0000000189613960-0x0000000189613980
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x000000018238DF00-0x000000018238DFB0
	// [XID] // 0x000000018961B230-0x000000018961B250
	public override void Destroy() {} // 0x000000018238EFD0-0x000000018238F090
	// [XID] // 0x0000000189622720-0x0000000189622740
	public override BaseAbilityMixin CreateInstancedAbilityMixin(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) => default; // 0x00000001823974C0-0x00000001823975C0
	// [IDTag] // 0x000000018962A080-0x000000018962A0C0
	// [XID] // 0x000000018962A080-0x000000018962A0C0
	public bool Command_MPTryRemoveModifier(uint casterID, uint instancedAbilityID, int modifierLocalID, uint serverBuffUID) => default; // 0x000000018238F900-0x000000018238FC30
	// [IDTag] // 0x0000000189634AE0-0x0000000189634B20
	// [XID] // 0x0000000189634AE0-0x0000000189634B20
	public override bool Command_MPTryRemoveModifier(ActorAbility instancedAbility, string modifierName) => default; // 0x000000018238FC30-0x000000018238FE80
	// [XID] // 0x000000018963EEF0-0x000000018963EF10
	private void MPSendCommandTryRemoveModifier(uint casterID, uint instancedAbilityID, int modifierLocalID, uint serverBuffUID) {} // 0x000000018239CD70-0x000000018239CF50
	// [IDTag] // 0x0000000189646800-0x0000000189646840
	// [XID] // 0x0000000189646800-0x0000000189646840
	private bool Command_MPTryApplyModifier(uint casterID, uint instancedAbilityID, int modifierLocalID, string parentAbilityName, string parentAbilityOverride, uint modifierApplyEntityId, uint serverBuffUID) => default; // 0x000000018238D480-0x000000018238DB20
	// [XID] // 0x0000000189651000-0x0000000189651020
	private void MPHandlePreApplyModifier(uint targetId, uint instancedAbilityId, int modifierLocalId, string parentAbilityName, string parentAbilityOverride, ref ParentAbilityEntityStatus targetStatus, ref BaseEntity target, ref ActorAbility instancedAbility, ref ConfigAbility parentAbilityConfig, ref ConfigAbilityModifier modifierConfig) {} // 0x0000000182393FF0-0x0000000182394F90
	// [XID] // 0x0000000189658750-0x0000000189658770
	private void MPHandlePostApplyModifierIfCasterInvalid(ParentAbilityEntityStatus targetStatus, ActorModifier modifier, uint targetId, uint instancedAbilityId, BaseEntity target) {} // 0x0000000182389780-0x0000000182389AB0
	// [IDTag] // 0x000000018965FD60-0x000000018965FDA0
	// [XID] // 0x000000018965FD60-0x000000018965FDA0
	public override bool Command_MPTryApplyModifier(ActorAbility instancedAbility, string modifierName, uint modifierApplyEntityId) => default; // 0x000000018238D190-0x000000018238D480
	// [XID] // 0x000000018966A7F0-0x000000018966A810
	private void MPSendCommandTryApplyModifier(uint casterID, uint instancedAbilityID, int modifierLocalID, string parentAbilityName, string parentAbilityOverride, uint modifierApplyEntityId, uint serverBuffUID) {} // 0x0000000182395540-0x0000000182395850
	// [XID] // 0x00000001896724D0-0x00000001896724F0
	public override void HandleActionTargetDispatch(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity other, BaseEvent evt, bool recoverFromServer, bool useActionBlackListForInvalidModifier) {} // 0x000000018239FEC0-0x00000001823A0170
	// [XID] // 0x0000000189679D40-0x0000000189679D60
	public override float CreateOrGetDynamicFloat(string key, float value, bool forceDoAtRemote) => default; // 0x0000000182392580-0x0000000182392700
	// [XID] // 0x0000000189681400-0x0000000189681420
	public override bool SetDynamicFloat(string key, float value, bool forceDoAtRemote) => default; // 0x000000018238CE70-0x000000018238CF80
	// [XID] // 0x0000000189688F00-0x0000000189688F20
	private void TrySyncToRemoteDynamicFloat(string key, float value) {} // 0x000000018239F2B0-0x000000018239F4B0
	// [XID] // 0x0000000189690A20-0x0000000189690A40
	public override void ClearDynamicFloat(string key, bool forceDoAtRemote) {} // 0x0000000182392700-0x0000000182392960
	// [XID] // 0x0000000189698280-0x00000001896982A0
	public override bool CanSyncAbilityMessageToRemote(bool remoteToAuthority = false /* Metadata: 0x00AEB558 */) => default; // 0x0000000182396AF0-0x0000000182396F60
	// [XID] // 0x000000018969F500-0x000000018969F520
	public override void PushDuringInitAbility() {} // 0x000000018238EB70-0x000000018238EC70
	// [XID] // 0x00000001896A68A0-0x00000001896A68C0
	public override void PopDuringInitAbility() {} // 0x0000000182393120-0x0000000182393330
	// [XID] // 0x00000001896ADF90-0x00000001896ADFB0
	public override void PushDuringChangeAbility() {} // 0x0000000182395F30-0x0000000182396030
	// [XID] // 0x00000001896B5620-0x00000001896B5640
	public override void PopDuringChangeAbility() {} // 0x000000018238CF80-0x000000018238D190
	// [XID] // 0x00000001896BC880-0x00000001896BC8A0
	public List<AbilityEntryProxy> GetInvokeAbilities() => default; // 0x0000000182392960-0x0000000182392A10
	// [XID] // 0x00000001896C3E00-0x00000001896C3E20
	public void ClearRecordInvokeEntries() {} // 0x0000000182395C20-0x0000000182395F30
	// [XID] // 0x00000001896CB2B0-0x00000001896CB2D0
	public void AddInvokeEntryDuringInitAbility(AbilityEntryProxy entryProxy, string abilityMessageInfo = null) {} // 0x0000000182390370-0x00000001823908F0
	// [XID] // 0x00000001896D28D0-0x00000001896D28F0
	protected override bool OnKill(EvtKill evt) => default; // 0x00000001823976A0-0x00000001823977A0
	// [XID] // 0x00000001896DA380-0x00000001896DA3A0
	protected override void SetKilled(bool killed) {} // 0x0000000182393600-0x0000000182393850
	// [XID] // 0x00000001896E1960-0x00000001896E1980
	public override void StartRecordInvokeEntry(uint instancedAbilityID, uint instancedModifierID, int modifierConfigLocalID, uint targetRuntimeID, int localID, out RecordInvokeEntryContext entry, uint evtID = 0 /* Metadata: 0x00AEB559 */, uint serverBuffUid = 0 /* Metadata: 0x00AEB55D */, bool inSBuffBucket = false /* Metadata: 0x00AEB561 */) {
		entry = default;
	} // 0x0000000182392E20-0x0000000182392FB0
	// [XID] // 0x00000001896E8ED0-0x00000001896E8EF0
	protected override void HandleAction(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, AbilityAttackTarget target, BaseEvent evt, ConfigAbilityPredicate[] predicatesForeach, bool recoverFromServer) {} // 0x00000001823908F0-0x0000000182391010
	// [XID] // 0x00000001896F00F0-0x00000001896F0110
	public void DispatchSingleAbilityInvoke(UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000182392380-0x0000000182392580
	// [XID] // 0x00000001896F79B0-0x00000001896F79D0
	private void CommonInvokeEntryDispatch(ActorAbility instancedAbility, ActorModifier instancedModifier, UnionAbilityInvokeEntry invokeEntry, BaseEntity target) {} // 0x0000000182398EA0-0x0000000182399BA0
	// [XID] // 0x00000001896FF490-0x00000001896FF4B0
	public override ActorModifier AddModifierOnIndex(ActorAbility instancedAbility, ConfigAbilityModifier modifierConfig, int index, ConfigAbility parentAbilityConfig, uint parentAbilityEntityID, ActorModifier attachedInstancedModifier, uint modifierApplyEntityId, bool isAttachedParentAbility, uint serverBuffUid, bool syncToServer = true /* Metadata: 0x00AEB562 */, bool inSBuffBucket = false /* Metadata: 0x00AEB563 */) => default; // 0x000000018239D420-0x000000018239E910
	// [XID] // 0x0000000189706860-0x0000000189706880
	protected override void RemoveModifierOnIndex(ActorModifier modifier, bool forceDoAtRemote, RemoveAbilityReason removeReason) {} // 0x000000018239C3B0-0x000000018239CCE0
	// [XID] // 0x000000018970E130-0x000000018970E150
	public override void RemoveAllDebuffModifiers() {} // 0x00000001823975C0-0x00000001823976A0
	// [XID] // 0x0000000189715550-0x0000000189715570
	protected override void RemoveAllDurationedOrDebuffs() {} // 0x000000018238E450-0x000000018238E530
	// [XID] // 0x000000018971D150-0x000000018971D170
	public override ActorAbility AddAbility(string abilityName, string abilityOverride, OverrideMap overrideMap, bool syncToServer, uint specifiedAbilityID) => default; // 0x000000018238A1E0-0x000000018238A900
	// [XID] // 0x00000001897244F0-0x0000000189724510
	protected override bool RemoveAbility(ActorAbility instancedAbility, bool forceDoAtRemote, RemoveAbilityReason removeAbilityReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB564 */, bool doRemoveFromAbilities = true /* Metadata: 0x00AEB568 */) => default; // 0x0000000182390110-0x0000000182390370
	// [XID] // 0x000000018972BB00-0x000000018972BB20
	protected override ActorAbility CreateAbilityInstance(string abilityName, string abilityOverride, OverrideMap overrideMap) => default; // 0x00000001823920E0-0x0000000182392380
	// [XID] // 0x0000000189733350-0x0000000189733370
	private void AuthorityCommonInvokeHandler(UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000182389AB0-0x000000018238A1E0
	// [XID] // 0x000000018973AB70-0x000000018973AB90
	private void MetaAuthorityInvokeHandler(UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000182393850-0x0000000182393C30
	// [XID] // 0x0000000189742320-0x0000000189742340
	private void MetaAuthorityCommand_ModifierChangeRequestHandler(UnionAbilityInvokeEntry invokeEntry) {} // 0x000000018238FE80-0x0000000182390110
	// [XID] // 0x0000000189749ED0-0x0000000189749EF0
	private void RemoteCommonInvokeHandler(UnionAbilityInvokeEntry invokeEntry) {} // 0x00000001823A0590-0x00000001823A13D0
	// [XID] // 0x0000000189751290-0x00000001897512B0
	private void MetaRemoteInvokeHandler(UnionAbilityInvokeEntry invokeEntry) {} // 0x00000001823A0170-0x00000001823A0590
	// [XID] // 0x00000001897586F0-0x0000000189758710
	protected override void DetachAbilityOwnedModifiers(ActorAbility actorAbility) {} // 0x000000018238F090-0x000000018238F440
	// [XID] // 0x0000000189760370-0x0000000189760390
	private void MetaHandleModifierChange(UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000182399F80-0x000000018239C050
	// [XID] // 0x00000001897676A0-0x00000001897676C0
	private void MetaHandleAddNewAbility(UnionAbilityInvokeEntry invokeEntry) {} // 0x000000018238BD20-0x000000018238C310
	// [XID] // 0x000000018976EDB0-0x000000018976EDD0
	private void MetaHandleRemoveAbility(UnionAbilityInvokeEntry invokeEntry) {} // 0x000000018239EAD0-0x000000018239EC80
	// [XID] // 0x00000001897769A0-0x00000001897769C0
	private void MetaHandleOverrideParam(UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000182391620-0x0000000182391B10
	// [XID] // 0x000000018977DDF0-0x000000018977DE10
	private void MetaHandleReInitOverrideMap(UnionAbilityInvokeEntry invokeEntry) {} // 0x000000018238E530-0x000000018238EB70
	// [XID] // 0x0000000189785760-0x0000000189785780
	private void MetaHandleClearOverrideParam(UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000182391010-0x0000000182391420
	// [XID] // 0x000000018978CC80-0x000000018978CCA0
	private void MetaHandleGlobalFloatValue(UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000182393330-0x0000000182393600
	// [XID] // 0x0000000189794100-0x0000000189794120
	private void MetaHandleClearGlobalFloatValue(UnionAbilityInvokeEntry invokeEntry) {} // 0x000000018239E910-0x000000018239EAD0
	// [XID] // 0x000000018979C510-0x000000018979C530
	private void MetaHandleSetKilledState(UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000182392FB0-0x0000000182393120
	// [XID] // 0x00000001897A3A30-0x00000001897A3A50
	private void MetaHandleSetModifierApplyEntityId(UnionAbilityInvokeEntry invokeEntry) {} // 0x000000018239FB30-0x000000018239FEC0
	// [XID] // 0x00000001897AADC0-0x00000001897AADE0
	private void MetaHandleModifierDurabilityChange(AbilityInvokeEntry invokeEntry) {} // 0x000000018239F200-0x000000018239F2B0
	// [XID] // 0x00000001897B2A30-0x00000001897B2A50
	private void MetaHandleElementReactionVisual(UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000182391420-0x0000000182391620
	// [XID] // 0x00000001897BA4B0-0x00000001897BA4D0
	private void MetaHandleSetPoseParameter(UnionAbilityInvokeEntry invokeEntry) {} // 0x000000018238F440-0x000000018238F5F0
		P5 = default;
	} // 0x0000000182395B40-0x0000000182395C20
}

