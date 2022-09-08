/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal static class TypeTool // TypeDefIndex: 14766
{
	// Fields
	private static Dictionary<System.Type, byte> _typeIndexDict; // 0x00
	private static Dictionary<byte, System.Type> _indexTypeDict; // 0x08
	internal static Dictionary<string, ConfigAbility> sConfigAbilityDict; // 0x10
	internal static Dictionary<uint, ConfigAbility> sConfigAbilityTypeDict; // 0x18
	internal static ConfigDummyAbilityRegister sConfigDummyAbilityRegister; // 0x20
	internal static Dictionary<string, ConfigAbilityAction> sConfigAbilityActionDict; // 0x28
	internal static Dictionary<uint, ConfigAbilityAction> sConfigAbilityActionTypeDict; // 0x30
	internal static BaseUtilityActionRegister sBaseUtilityActionRegister; // 0x38
	internal static ApplyModifierRegister sApplyModifierRegister; // 0x40
	internal static ApplyLevelModifierRegister sApplyLevelModifierRegister; // 0x48
	internal static AttachModifierRegister sAttachModifierRegister; // 0x50
	internal static RemoveUniqueModifierRegister sRemoveUniqueModifierRegister; // 0x58
	internal static FireEffectRegister sFireEffectRegister; // 0x60
	internal static FireSubEmitterEffectRegister sFireSubEmitterEffectRegister; // 0x68
	internal static FireEffectForStormRegister sFireEffectForStormRegister; // 0x70
	internal static FireEffectToTargetRegister sFireEffectToTargetRegister; // 0x78
	internal static FireHitEffectRegister sFireHitEffectRegister; // 0x80
	internal static AvatarSkillStartRegister sAvatarSkillStartRegister; // 0x88
	internal static EntityDoSkillRegister sEntityDoSkillRegister; // 0x90
	internal static AvatarEnterFocusRegister sAvatarEnterFocusRegister; // 0x98
	internal static AvatarExitFocusRegister sAvatarExitFocusRegister; // 0xA0
	internal static AvatarExitClimbRegister sAvatarExitClimbRegister; // 0xA8
	internal static AvatarCameraParamRegister sAvatarCameraParamRegister; // 0xB0
	internal static AvatarEnterCameraShotRegister sAvatarEnterCameraShotRegister; // 0xB8
	internal static AvatarExitCameraShotRegister sAvatarExitCameraShotRegister; // 0xC0
	internal static PlayEmoSyncRegister sPlayEmoSyncRegister; // 0xC8
	internal static ControlEmotionRegister sControlEmotionRegister; // 0xD0
	internal static SpawnAttachRegister sSpawnAttachRegister; // 0xD8
	internal static TurnDirectionRegister sTurnDirectionRegister; // 0xE0
	internal static TurnDirectionToPosRegister sTurnDirectionToPosRegister; // 0xE8
	internal static SetCameraLockTimeRegister sSetCameraLockTimeRegister; // 0xF0
	internal static FireMonsterBeingHitAfterImageRegister sFireMonsterBeingHitAfterImageRegister; // 0xF8
	internal static AttachEffectRegister sAttachEffectRegister; // 0x100
	internal static AttachLightRegister sAttachLightRegister; // 0x108
	internal static AddGlobalValueRegister sAddGlobalValueRegister; // 0x110
	internal static SetGlobalValueRegister sSetGlobalValueRegister; // 0x118
	internal static MultiplyGlobalValueRegister sMultiplyGlobalValueRegister; // 0x120
	internal static CopyGlobalValueRegister sCopyGlobalValueRegister; // 0x128
	internal static SetGlobalValueListRegister sSetGlobalValueListRegister; // 0x130
	internal static SetGlobalValueToOverrideMapRegister sSetGlobalValueToOverrideMapRegister; // 0x138
	internal static SetRandomOverrideMapValueRegister sSetRandomOverrideMapValueRegister; // 0x140
	internal static SetOverrideMapValueRegister sSetOverrideMapValueRegister; // 0x148
	internal static SetCrystalShieldHpToOverrideMapRegister sSetCrystalShieldHpToOverrideMapRegister; // 0x150
	internal static SetSystemValueToOverrideMapRegister sSetSystemValueToOverrideMapRegister; // 0x158
	internal static SetGlobalValueByTargetDistanceRegister sSetGlobalValueByTargetDistanceRegister; // 0x160
	internal static ClearGlobalValueRegister sClearGlobalValueRegister; // 0x168
	internal static SumTargetWeightToSelfGlobalValueRegister sSumTargetWeightToSelfGlobalValueRegister; // 0x170
	internal static SetGlobalPosRegister sSetGlobalPosRegister; // 0x178
	internal static AddGlobalPosRegister sAddGlobalPosRegister; // 0x180
	internal static ClearGlobalPosRegister sClearGlobalPosRegister; // 0x188
	internal static SetGlobalDirRegister sSetGlobalDirRegister; // 0x190
	internal static PushPosRegister sPushPosRegister; // 0x198
	internal static ClearPosRegister sClearPosRegister; // 0x1A0
	internal static GetPosRegister sGetPosRegister; // 0x1A8
	internal static DamageByAttackValueRegister sDamageByAttackValueRegister; // 0x1B0
	internal static PredicatedRegister sPredicatedRegister; // 0x1B8
	internal static HealSPRegister sHealSPRegister; // 0x1C0
	internal static HealHPRegister sHealHPRegister; // 0x1C8
	internal static LoseHPRegister sLoseHPRegister; // 0x1D0
	internal static ReviveAvatarRegister sReviveAvatarRegister; // 0x1D8
	internal static ReviveDeadAvatarRegister sReviveDeadAvatarRegister; // 0x1E0
	internal static EnableRocketJumpRegister sEnableRocketJumpRegister; // 0x1E8
	internal static ForceTriggerJumpRegister sForceTriggerJumpRegister; // 0x1F0
	internal static EnableAfterImageRegister sEnableAfterImageRegister; // 0x1F8
	internal static ActTimeSlowRegister sActTimeSlowRegister; // 0x200
	internal static TriggerAbilityRegister sTriggerAbilityRegister; // 0x208
	internal static RemoveModifierRegister sRemoveModifierRegister; // 0x210
	internal static SetAIParamRegister sSetAIParamRegister; // 0x218
	internal static FireAudioRegister sFireAudioRegister; // 0x220
	internal static ActCameraShakeRegister sActCameraShakeRegister; // 0x228
	internal static ActCameraRadialBlurRegister sActCameraRadialBlurRegister; // 0x230
	internal static SetAnimatorBoolRegister sSetAnimatorBoolRegister; // 0x238
	internal static SetAnimatorIntRegister sSetAnimatorIntRegister; // 0x240
	internal static SetAnimatorFloatRegister sSetAnimatorFloatRegister; // 0x248
	internal static SetAnimatorTriggerRegister sSetAnimatorTriggerRegister; // 0x250
	internal static ResetAnimatorTriggerRegister sResetAnimatorTriggerRegister; // 0x258
	internal static DebugLogRegister sDebugLogRegister; // 0x260
	internal static TriggerBulletRegister sTriggerBulletRegister; // 0x268
	internal static TriggerAttackEventRegister sTriggerAttackEventRegister; // 0x270
	internal static TriggerAttackTargetMapEventRegister sTriggerAttackTargetMapEventRegister; // 0x278
	internal static EnableWetElectricHitBoxRegister sEnableWetElectricHitBoxRegister; // 0x280
	internal static CreateEntityRegister sCreateEntityRegister; // 0x288
	internal static CreateGadgetRegister sCreateGadgetRegister; // 0x290
	internal static CreateMovingPlatformRegister sCreateMovingPlatformRegister; // 0x298
	internal static TryTriggerPlatformStartMoveRegister sTryTriggerPlatformStartMoveRegister; // 0x2A0
	internal static KillGadgetRegister sKillGadgetRegister; // 0x2A8
	internal static KillSelfRegister sKillSelfRegister; // 0x2B0
	internal static TriggerAudioRegister sTriggerAudioRegister; // 0x2B8
	internal static TriggerDropEquipPartsRegister sTriggerDropEquipPartsRegister; // 0x2C0
	internal static TriggerThrowEquipPartRegister sTriggerThrowEquipPartRegister; // 0x2C8
	internal static TriggerCreateGadgetToEquipPartRegister sTriggerCreateGadgetToEquipPartRegister; // 0x2D0
	internal static TriggerAuxWeaponTransRegister sTriggerAuxWeaponTransRegister; // 0x2D8
	internal static TriggerGadgetInteractiveRegister sTriggerGadgetInteractiveRegister; // 0x2E0
	internal static TriggerSetVisibleRegister sTriggerSetVisibleRegister; // 0x2E8
	internal static TriggerSetCastShadowRegister sTriggerSetCastShadowRegister; // 0x2F0
	internal static TriggerSetPassThroughRegister sTriggerSetPassThroughRegister; // 0x2F8
	internal static TriggerSetRenderersEnableRegister sTriggerSetRenderersEnableRegister; // 0x300
	internal static TriggerHideWeaponRegister sTriggerHideWeaponRegister; // 0x308
	internal static TriggerTauntRegister sTriggerTauntRegister; // 0x310
	internal static TriggerSetChestLockRegister sTriggerSetChestLockRegister; // 0x318
	internal static ClearLockTargetRegister sClearLockTargetRegister; // 0x320
	internal static SetPoseBoolRegister sSetPoseBoolRegister; // 0x328
	internal static SetPoseIntRegister sSetPoseIntRegister; // 0x330
	internal static SetPoseFloatRegister sSetPoseFloatRegister; // 0x338
	internal static TriggerFaceAnimationRegister sTriggerFaceAnimationRegister; // 0x340
	internal static EnableCrashDamageRegister sEnableCrashDamageRegister; // 0x348
	internal static SetCrashDamageRegister sSetCrashDamageRegister; // 0x350
	internal static TryFindBlinkPointRegister sTryFindBlinkPointRegister; // 0x358
	internal static TryFindBlinkPointByBornRegister sTryFindBlinkPointByBornRegister; // 0x360
	internal static DoBlinkRegister sDoBlinkRegister; // 0x368
	internal static AvatarDoBlinkRegister sAvatarDoBlinkRegister; // 0x370
	internal static EnableHitBoxByNameRegister sEnableHitBoxByNameRegister; // 0x378
	internal static EnablePushColliderNameRegister sEnablePushColliderNameRegister; // 0x380
	internal static EnableSceneTransformByNameRegister sEnableSceneTransformByNameRegister; // 0x388
	internal static GenerateElemBallRegister sGenerateElemBallRegister; // 0x390
	internal static RandomedRegister sRandomedRegister; // 0x398
	internal static HideUIBillBoardRegister sHideUIBillBoardRegister; // 0x3A0
	internal static SendEffectTriggerRegister sSendEffectTriggerRegister; // 0x3A8
	internal static ChangeFollowDampTimeRegister sChangeFollowDampTimeRegister; // 0x3B0
	internal static SetSelfAttackTargetRegister sSetSelfAttackTargetRegister; // 0x3B8
	internal static ForceInitMassiveEntityRegister sForceInitMassiveEntityRegister; // 0x3C0
	internal static EnableHeadControlRegister sEnableHeadControlRegister; // 0x3C8
	internal static EnablePartControlRegister sEnablePartControlRegister; // 0x3D0
	internal static StartDitherRegister sStartDitherRegister; // 0x3D8
	internal static SummonRegister sSummonRegister; // 0x3E0
	internal static AttachAbilityStateResistanceRegister sAttachAbilityStateResistanceRegister; // 0x3E8
	internal static FireAISoundEventRegister sFireAISoundEventRegister; // 0x3F0
	internal static AddElementDurabilityRegister sAddElementDurabilityRegister; // 0x3F8
	internal static SetPartControlTargetRegister sSetPartControlTargetRegister; // 0x400
	internal static DropSubfieldRegister sDropSubfieldRegister; // 0x408
	internal static EnableGadgetInteeRegister sEnableGadgetInteeRegister; // 0x410
	internal static RemoveVelocityForceRegister sRemoveVelocityForceRegister; // 0x418
	internal static ExecuteGroupTriggerRegister sExecuteGroupTriggerRegister; // 0x420
	internal static ReTriggerAISkillInitialCDRegister sReTriggerAISkillInitialCDRegister; // 0x428
	internal static SetAISkillCDAvailableNowRegister sSetAISkillCDAvailableNowRegister; // 0x430
	internal static SetAISkillGCDRegister sSetAISkillGCDRegister; // 0x438
	internal static EnableAIStealthyRegister sEnableAIStealthyRegister; // 0x440
	internal static UnlockSkillRegister sUnlockSkillRegister; // 0x448
	internal static AddAvatarSkillInfoRegister sAddAvatarSkillInfoRegister; // 0x450
	internal static RemoveAvatarSkillInfoRegister sRemoveAvatarSkillInfoRegister; // 0x458
	internal static SetCanDieImmediatelyRegister sSetCanDieImmediatelyRegister; // 0x460
	internal static PlayEmojiBubbleRegister sPlayEmojiBubbleRegister; // 0x468
	internal static AttachBulletAimPointRegister sAttachBulletAimPointRegister; // 0x470
	internal static EnableBulletCollisionPluginTriggerRegister sEnableBulletCollisionPluginTriggerRegister; // 0x478
	internal static GuidePaimonDisappearEndRegister sGuidePaimonDisappearEndRegister; // 0x480
	internal static SetPaimonLookAtCameraRegister sSetPaimonLookAtCameraRegister; // 0x488
	internal static PaimonActionRegister sPaimonActionRegister; // 0x490
	internal static SetPaimonLookAtAvatarRegister sSetPaimonLookAtAvatarRegister; // 0x498
	internal static SetPaimonTempOffsetRegister sSetPaimonTempOffsetRegister; // 0x4A0
	internal static SetKeepInAirVelocityForceRegister sSetKeepInAirVelocityForceRegister; // 0x4A8
	internal static ForceAirStateFlyRegister sForceAirStateFlyRegister; // 0x4B0
	internal static ToNearstAnchorPointRegister sToNearstAnchorPointRegister; // 0x4B8
	internal static PushDvalinS01ProcessRegister sPushDvalinS01ProcessRegister; // 0x4C0
	internal static SetDvalinS01FlyStateRegister sSetDvalinS01FlyStateRegister; // 0x4C8
	internal static RegistToStageScriptRegister sRegistToStageScriptRegister; // 0x4D0
	internal static SyncToStageScriptRegister sSyncToStageScriptRegister; // 0x4D8
	internal static CalcDvalinS04RebornPointRegister sCalcDvalinS04RebornPointRegister; // 0x4E0
	internal static TriggerPlayerDieRegister sTriggerPlayerDieRegister; // 0x4E8
	internal static ResetEnviroEularRegister sResetEnviroEularRegister; // 0x4F0
	internal static SetEmissionScalerRegister sSetEmissionScalerRegister; // 0x4F8
	internal static EnterCameraLockRegister sEnterCameraLockRegister; // 0x500
	internal static ShowUICombatBarRegister sShowUICombatBarRegister; // 0x508
	internal static ShowScreenEffectRegister sShowScreenEffectRegister; // 0x510
	internal static AddServerBuffRegister sAddServerBuffRegister; // 0x518
	internal static RemoveServerBuffRegister sRemoveServerBuffRegister; // 0x520
	internal static ModifyAvatarSkillCDRegister sModifyAvatarSkillCDRegister; // 0x528
	internal static ResetAbilitySpecialRegister sResetAbilitySpecialRegister; // 0x530
	internal static EnableAvatarFlyStateTrailRegister sEnableAvatarFlyStateTrailRegister; // 0x538
	internal static ShowReminderRegister sShowReminderRegister; // 0x540
	internal static UpdateReactionDamageRegister sUpdateReactionDamageRegister; // 0x548
	internal static ExecuteGadgetLuaRegister sExecuteGadgetLuaRegister; // 0x550
	internal static SetWeaponBindStateRegister sSetWeaponBindStateRegister; // 0x558
	internal static SetWeaponAttachPointRealNameRegister sSetWeaponAttachPointRealNameRegister; // 0x560
	internal static SetAvatarCanShakeOffRegister sSetAvatarCanShakeOffRegister; // 0x568
	internal static EnableMainInterfaceRegister sEnableMainInterfaceRegister; // 0x570
	internal static ChangePlayModeRegister sChangePlayModeRegister; // 0x578
	internal static EnableCameraDofRegister sEnableCameraDofRegister; // 0x580
	internal static EnableHitAutoRedirectRegister sEnableHitAutoRedirectRegister; // 0x588
	internal static ClearEnduraRegister sClearEnduraRegister; // 0x590
	internal static RushMoveRegister sRushMoveRegister; // 0x598
	internal static ResetAIAttackTargetRegister sResetAIAttackTargetRegister; // 0x5A0
	internal static ResetAIResistTauntLevelRegister sResetAIResistTauntLevelRegister; // 0x5A8
	internal static SetSurroundAnchorRegister sSetSurroundAnchorRegister; // 0x5B0
	internal static SetCombatFixedMovePointRegister sSetCombatFixedMovePointRegister; // 0x5B8
	internal static SetAvatarHitBucketsRegister sSetAvatarHitBucketsRegister; // 0x5C0
	internal static ResetAvatarHitBucketsRegister sResetAvatarHitBucketsRegister; // 0x5C8
	internal static SetAISkillCDMultiplierRegister sSetAISkillCDMultiplierRegister; // 0x5D0
	internal static RegisterAIActionPointRegister sRegisterAIActionPointRegister; // 0x5D8
	internal static ReleaseAIActionPointRegister sReleaseAIActionPointRegister; // 0x5E0
	internal static SetNeuronEnableRegister sSetNeuronEnableRegister; // 0x5E8
	internal static SetNeuronMuteRegister sSetNeuronMuteRegister; // 0x5F0
	internal static BroadcastNeuronStimulateRegister sBroadcastNeuronStimulateRegister; // 0x5F8
	internal static IssueCommandRegister sIssueCommandRegister; // 0x600
	internal static ResetAIThreatBroadcastRangeRegister sResetAIThreatBroadcastRangeRegister; // 0x608
	internal static SetAIHitFeelingRegister sSetAIHitFeelingRegister; // 0x610
	internal static SetVelocityIgnoreAirGYRegister sSetVelocityIgnoreAirGYRegister; // 0x618
	internal static UseItemRegister sUseItemRegister; // 0x620
	internal static RepeatedRegister sRepeatedRegister; // 0x628
	internal static SetEntityScaleRegister sSetEntityScaleRegister; // 0x630
	internal static CallLuaTaskRegister sCallLuaTaskRegister; // 0x638
	internal static DungeonFogEffectsRegister sDungeonFogEffectsRegister; // 0x640
	internal static DoTileActionRegister sDoTileActionRegister; // 0x648
	internal static DoWatcherSystemActionRegister sDoWatcherSystemActionRegister; // 0x650
	internal static ShowProgressBarActionRegister sShowProgressBarActionRegister; // 0x658
	internal static ChangeTagRegister sChangeTagRegister; // 0x660
	internal static UseSkillEliteSetRegister sUseSkillEliteSetRegister; // 0x668
	internal static FixedMonsterRushMoveRegister sFixedMonsterRushMoveRegister; // 0x670
	internal static FixedAvatarRushMoveRegister sFixedAvatarRushMoveRegister; // 0x678
	internal static AttachElementTypeResistanceRegister sAttachElementTypeResistanceRegister; // 0x680
	internal static AddGlobalValueToTargetRegister sAddGlobalValueToTargetRegister; // 0x688
	internal static ReviveElemEnergyRegister sReviveElemEnergyRegister; // 0x690
	internal static AddClimateMeterRegister sAddClimateMeterRegister; // 0x698
	internal static ResetClimateMeterRegister sResetClimateMeterRegister; // 0x6A0
	internal static FireGainCrystalSeedEventRegister sFireGainCrystalSeedEventRegister; // 0x6A8
	internal static EnableMonsterMoveOnWaterRegister sEnableMonsterMoveOnWaterRegister; // 0x6B0
	internal static ChangeEnviroWeatherRegister sChangeEnviroWeatherRegister; // 0x6B8
	internal static SyncEntityPositionByNormalizedTimeRegister sSyncEntityPositionByNormalizedTimeRegister; // 0x6C0
	internal static EquipAffixStartRegister sEquipAffixStartRegister; // 0x6C8
	internal static ShowExtraAbilityRegister sShowExtraAbilityRegister; // 0x6D0
	internal static SetExtraAbilityEnableRegister sSetExtraAbilityEnableRegister; // 0x6D8
	internal static SetExtraAbilityStateRegister sSetExtraAbilityStateRegister; // 0x6E0
	internal static UpdateUidValueRegister sUpdateUidValueRegister; // 0x6E8
	internal static ForceUseSkillSuccessRegister sForceUseSkillSuccessRegister; // 0x6F0
	internal static ServerLuaCallRegister sServerLuaCallRegister; // 0x6F8
	internal static DoWidgetSystemActionRegister sDoWidgetSystemActionRegister; // 0x700
	internal static ChangeGadgetUIInteractHintRegister sChangeGadgetUIInteractHintRegister; // 0x708
	internal static KillPlayEntityRegister sKillPlayEntityRegister; // 0x710
	internal static DummyActionRegister sDummyActionRegister; // 0x718
	internal static BanEntityMarkRegister sBanEntityMarkRegister; // 0x720
	internal static FireUIEffectRegister sFireUIEffectRegister; // 0x728
	internal static SetSkillAnchorRegister sSetSkillAnchorRegister; // 0x730
	internal static ServerMonsterLogRegister sServerMonsterLogRegister; // 0x738
	internal static EnablePositionSynchronizationRegister sEnablePositionSynchronizationRegister; // 0x740
	internal static ReviveStaminaRegister sReviveStaminaRegister; // 0x748
	internal static Dictionary<string, SelectTargets> sSelectTargetsDict; // 0x750
	internal static Dictionary<uint, SelectTargets> sSelectTargetsTypeDict; // 0x758
	internal static SelectTargetsByShapeRegister sSelectTargetsByShapeRegister; // 0x760
	internal static SelectTargetsByEquipPartsRegister sSelectTargetsByEquipPartsRegister; // 0x768
	internal static SelectTargetsByChildrenRegister sSelectTargetsByChildrenRegister; // 0x770
	internal static SelectTargetsByTagRegister sSelectTargetsByTagRegister; // 0x778
	internal static SelectTargetsBySelfGroupRegister sSelectTargetsBySelfGroupRegister; // 0x780
	internal static SelectTargetsByLCTriggerRegister sSelectTargetsByLCTriggerRegister; // 0x788
	internal static SelectTargetsByLCTriggerAllRegister sSelectTargetsByLCTriggerAllRegister; // 0x790
	internal static Dictionary<string, ConfigAbilityMixin> sConfigAbilityMixinDict; // 0x798
	internal static Dictionary<uint, ConfigAbilityMixin> sConfigAbilityMixinTypeDict; // 0x7A0
	internal static DebugMixinRegister sDebugMixinRegister; // 0x7A8
	internal static RelyOnElementMixinRegister sRelyOnElementMixinRegister; // 0x7B0
	internal static ReplaceEventPatternMixinRegister sReplaceEventPatternMixinRegister; // 0x7B8
	internal static AttachToStateIDMixinRegister sAttachToStateIDMixinRegister; // 0x7C0
	internal static AttachToMonsterAirStateMixinRegister sAttachToMonsterAirStateMixinRegister; // 0x7C8
	internal static AttachToNormalizedTimeMixinRegister sAttachToNormalizedTimeMixinRegister; // 0x7D0
	internal static AttachToAnimatorStateIDMixinRegister sAttachToAnimatorStateIDMixinRegister; // 0x7D8
	internal static AttachToPoseIDMixinRegister sAttachToPoseIDMixinRegister; // 0x7E0
	internal static AttachToGadgetStateMixinRegister sAttachToGadgetStateMixinRegister; // 0x7E8
	internal static AttachToGadgetStateMutexMixinRegister sAttachToGadgetStateMutexMixinRegister; // 0x7F0
	internal static AttachModifierByStackingMixinRegister sAttachModifierByStackingMixinRegister; // 0x7F8
	internal static AttachToAIAlertnessMixinRegister sAttachToAIAlertnessMixinRegister; // 0x800
	internal static AttachModifierToPredicateMixinRegister sAttachModifierToPredicateMixinRegister; // 0x808
	internal static DoActionByEventMixinRegister sDoActionByEventMixinRegister; // 0x810
	internal static ButtonHoldChargeMixinRegister sButtonHoldChargeMixinRegister; // 0x818
	internal static SkillButtonHoldChargeMixinRegister sSkillButtonHoldChargeMixinRegister; // 0x820
	internal static AvatarSteerByCameraMixinRegister sAvatarSteerByCameraMixinRegister; // 0x828
	internal static SteerAttackMixinRegister sSteerAttackMixinRegister; // 0x830
	internal static SteerAttackMoveMixinRegister sSteerAttackMoveMixinRegister; // 0x838
	internal static SteerAttackTraceMixinRegister sSteerAttackTraceMixinRegister; // 0x840
	internal static ShieldBarMixinRegister sShieldBarMixinRegister; // 0x848
	internal static ChargeBarMixinRegister sChargeBarMixinRegister; // 0x850
	internal static ElementShieldMixinRegister sElementShieldMixinRegister; // 0x858
	internal static EliteShieldMixinRegister sEliteShieldMixinRegister; // 0x860
	internal static OverrideAttackEventMixinRegister sOverrideAttackEventMixinRegister; // 0x868
	internal static AttachModifierToSelfGlobalValueMixinRegister sAttachModifierToSelfGlobalValueMixinRegister; // 0x870
	internal static TriggerTypeSupportMixinRegister sTriggerTypeSupportMixinRegister; // 0x878
	internal static TriggerElementSupportMixinRegister sTriggerElementSupportMixinRegister; // 0x880
	internal static TriggerBeHitSupportMixinRegister sTriggerBeHitSupportMixinRegister; // 0x888
	internal static TriggerRageSupportMixinRegister sTriggerRageSupportMixinRegister; // 0x890
	internal static WindZoneMixinRegister sWindZoneMixinRegister; // 0x898
	internal static TornadoMixinRegister sTornadoMixinRegister; // 0x8A0
	internal static AirFlowMixinRegister sAirFlowMixinRegister; // 0x8A8
	internal static WindSeedSpawnerMixinRegister sWindSeedSpawnerMixinRegister; // 0x8B0
	internal static CollisionMixinRegister sCollisionMixinRegister; // 0x8B8
	internal static VelocityDetectMixinRegister sVelocityDetectMixinRegister; // 0x8C0
	internal static WeightDetectRegionMixinRegister sWeightDetectRegionMixinRegister; // 0x8C8
	internal static ChangeFieldMixinRegister sChangeFieldMixinRegister; // 0x8D0
	internal static SwitchSkillIDMixinRegister sSwitchSkillIDMixinRegister; // 0x8D8
	internal static AvatarChangeSkillMixinRegister sAvatarChangeSkillMixinRegister; // 0x8E0
	internal static AvatarLevelSkillMixinRegister sAvatarLevelSkillMixinRegister; // 0x8E8
	internal static OnAvatarUseSkillMixinRegister sOnAvatarUseSkillMixinRegister; // 0x8F0
	internal static CostStaminaMixinRegister sCostStaminaMixinRegister; // 0x8F8
	internal static EntityDefenceMixinRegister sEntityDefenceMixinRegister; // 0x900
	internal static MonsterDefendMixinRegister sMonsterDefendMixinRegister; // 0x908
	internal static BeingHitMixinRegister sBeingHitMixinRegister; // 0x910
	internal static AutoDefenceMixinRegister sAutoDefenceMixinRegister; // 0x918
	internal static AttackHittingSceneMixinRegister sAttackHittingSceneMixinRegister; // 0x920
	internal static TriggerWitchTimeMixinRegister sTriggerWitchTimeMixinRegister; // 0x928
	internal static TriggerWeatherMixinRegister sTriggerWeatherMixinRegister; // 0x930
	internal static TriggerPostProcessEffectMixinRegister sTriggerPostProcessEffectMixinRegister; // 0x938
	internal static ModifyDamageMixinRegister sModifyDamageMixinRegister; // 0x940
	internal static ClusterTriggerMixinRegister sClusterTriggerMixinRegister; // 0x948
	internal static ModifySkillCDByModifierCountMixinRegister sModifySkillCDByModifierCountMixinRegister; // 0x950
	internal static ReviveElemEnergyMixinRegister sReviveElemEnergyMixinRegister; // 0x958
	internal static RejectAttackMixinRegister sRejectAttackMixinRegister; // 0x960
	internal static AttackCostElementMixinRegister sAttackCostElementMixinRegister; // 0x968
	internal static ApplyInertiaVelocityMixinRegister sApplyInertiaVelocityMixinRegister; // 0x970
	internal static ChangePropTypeValueMixinRegister sChangePropTypeValueMixinRegister; // 0x978
	internal static ExtendLifetimeByPickedGadgetMixinRegister sExtendLifetimeByPickedGadgetMixinRegister; // 0x980
	internal static DoActionByEnergyChangeMixinRegister sDoActionByEnergyChangeMixinRegister; // 0x988
	internal static DoReviveMixinRegister sDoReviveMixinRegister; // 0x990
	internal static IceFloorMixinRegister sIceFloorMixinRegister; // 0x998
	internal static HitLevelGaugeMixinRegister sHitLevelGaugeMixinRegister; // 0x9A0
	internal static RecycleModifierMixinRegister sRecycleModifierMixinRegister; // 0x9A8
	internal static CurLocalAvatarMixinRegister sCurLocalAvatarMixinRegister; // 0x9B0
	internal static AttachToDayNightMixinRegister sAttachToDayNightMixinRegister; // 0x9B8
	internal static DoActionByCreateGadgetMixinRegister sDoActionByCreateGadgetMixinRegister; // 0x9C0
	internal static EnviroFollowRotateMixinRegister sEnviroFollowRotateMixinRegister; // 0x9C8
	internal static BoxClampWindZoneMixinRegister sBoxClampWindZoneMixinRegister; // 0x9D0
	internal static DvalinS01BoxMoxeMixinRegister sDvalinS01BoxMoxeMixinRegister; // 0x9D8
	internal static FixDvalinS04MoveMixinRegister sFixDvalinS04MoveMixinRegister; // 0x9E0
	internal static DvalinS01PathEffsMixinRegister sDvalinS01PathEffsMixinRegister; // 0x9E8
	internal static CameraLockMixinRegister sCameraLockMixinRegister; // 0x9F0
	internal static AvatarLockForwardFlyMixinRegister sAvatarLockForwardFlyMixinRegister; // 0x9F8
	internal static TriggerResistDamageTextMixinRegister sTriggerResistDamageTextMixinRegister; // 0xA00
	internal static StageReadyMixinRegister sStageReadyMixinRegister; // 0xA08
	internal static AttachModifierToElementDurabilityMixinRegister sAttachModifierToElementDurabilityMixinRegister; // 0xA10
	internal static DoActionByStateIDMixinRegister sDoActionByStateIDMixinRegister; // 0xA18
	internal static DoActionByAnimatorStateIDMixinRegister sDoActionByAnimatorStateIDMixinRegister; // 0xA20
	internal static DoActionByPoseIDMixinRegister sDoActionByPoseIDMixinRegister; // 0xA28
	internal static OverrideStickElemUIMixinRegister sOverrideStickElemUIMixinRegister; // 0xA30
	internal static GlobalMainShieldMixinRegister sGlobalMainShieldMixinRegister; // 0xA38
	internal static GlobalSubShieldMixinRegister sGlobalSubShieldMixinRegister; // 0xA40
	internal static AttachModifierToHPPercentMixinRegister sAttachModifierToHPPercentMixinRegister; // 0xA48
	internal static DoActionByTeamStatusMixinRegister sDoActionByTeamStatusMixinRegister; // 0xA50
	internal static DoActionByElementReactionMixinRegister sDoActionByElementReactionMixinRegister; // 0xA58
	internal static AnimatorRotationCompensateMixinRegister sAnimatorRotationCompensateMixinRegister; // 0xA60
	internal static TileAttackMixinRegister sTileAttackMixinRegister; // 0xA68
	internal static Dictionary<string, TileShapeInfo> sTileShapeInfoDict; // 0xA70
	internal static Dictionary<uint, TileShapeInfo> sTileShapeInfoTypeDict; // 0xA78
	internal static SphereTileShapeInfoRegister sSphereTileShapeInfoRegister; // 0xA80
	internal static TileComplexMixinRegister sTileComplexMixinRegister; // 0xA88
	internal static TileAttackManagerMixinRegister sTileAttackManagerMixinRegister; // 0xA90
	internal static DoTileActionManagerMixinRegister sDoTileActionManagerMixinRegister; // 0xA98
	internal static TileComplexManagerMixinRegister sTileComplexManagerMixinRegister; // 0xAA0
	internal static MonsterReadyMixinRegister sMonsterReadyMixinRegister; // 0xAA8
	internal static DoActionByKillingMixinRegister sDoActionByKillingMixinRegister; // 0xAB0
	internal static ShaderLerpMixinRegister sShaderLerpMixinRegister; // 0xAB8
	internal static ElementAdjustMixinRegister sElementAdjustMixinRegister; // 0xAC0
	internal static AttachToElementTypeMixinRegister sAttachToElementTypeMixinRegister; // 0xAC8
	internal static AttachToAbilityStateMixinRegister sAttachToAbilityStateMixinRegister; // 0xAD0
	internal static WatcherSystemMixinRegister sWatcherSystemMixinRegister; // 0xAD8
	internal static ElementOuterGlowEffectMixinRegister sElementOuterGlowEffectMixinRegister; // 0xAE0
	internal static ApplyModifierWithSharedDurabilityMixinRegister sApplyModifierWithSharedDurabilityMixinRegister; // 0xAE8
	internal static PlayerUidNotifyMixinRegister sPlayerUidNotifyMixinRegister; // 0xAF0
	internal static AttachToPlayStageMixinRegister sAttachToPlayStageMixinRegister; // 0xAF8
	internal static ServerCreateGadgetOnKillMixinRegister sServerCreateGadgetOnKillMixinRegister; // 0xB00
	internal static CameraBlurMixinRegister sCameraBlurMixinRegister; // 0xB08
	internal static DoActionByGainCrystalSeedMixinRegister sDoActionByGainCrystalSeedMixinRegister; // 0xB10
	internal static ModifyElementDecrateMixinRegister sModifyElementDecrateMixinRegister; // 0xB18
	internal static ElementHittingOtherPredicatedMixinRegister sElementHittingOtherPredicatedMixinRegister; // 0xB20
	internal static ResistClimateMixinRegister sResistClimateMixinRegister; // 0xB28
	internal static ServerUpdateGlobalValueMixinRegister sServerUpdateGlobalValueMixinRegister; // 0xB30
	internal static ElementReactionShockMixinRegister sElementReactionShockMixinRegister; // 0xB38
	internal static BillboardMarkMixinRegister sBillboardMarkMixinRegister; // 0xB40
	internal static AttachModifierToTargetDistanceMixinRegister sAttachModifierToTargetDistanceMixinRegister; // 0xB48
	internal static MoveStateMixinRegister sMoveStateMixinRegister; // 0xB50
	internal static ServerFinishWatcherMixinRegister sServerFinishWatcherMixinRegister; // 0xB58
	internal static DummyMixinRegister sDummyMixinRegister; // 0xB60
	internal static UrgentHotFixMixinRegister sUrgentHotFixMixinRegister; // 0xB68
	internal static FieldEntityCountChangeMixinRegister sFieldEntityCountChangeMixinRegister; // 0xB70
	internal static TDPlayMixinRegister sTDPlayMixinRegister; // 0xB78
	internal static CircleBarrageMixinRegister sCircleBarrageMixinRegister; // 0xB80
	internal static VelocityForceMixinRegister sVelocityForceMixinRegister; // 0xB88
	internal static ScenePropSyncMixinRegister sScenePropSyncMixinRegister; // 0xB90
	internal static BanEntityMarkMixinRegister sBanEntityMarkMixinRegister; // 0xB98
	internal static EntityMarkShowTypeMixinRegister sEntityMarkShowTypeMixinRegister; // 0xBA0
	internal static EntityDitherMixinRegister sEntityDitherMixinRegister; // 0xBA8
	internal static EntityInVisibleMixinRegister sEntityInVisibleMixinRegister; // 0xBB0
	internal static SetSkillCanUseInStateMixinRegister sSetSkillCanUseInStateMixinRegister; // 0xBB8
	internal static HomeworldEnterEditorMixinRegister sHomeworldEnterEditorMixinRegister; // 0xBC0
	internal static Dictionary<string, ConfigAbilityPredicate> sConfigAbilityPredicateDict; // 0xBC8
	internal static Dictionary<uint, ConfigAbilityPredicate> sConfigAbilityPredicateTypeDict; // 0xBD0
	internal static RelationalOperationPredicateRegister sRelationalOperationPredicateRegister; // 0xBD8
	internal static ByTargetHPRatioRegister sByTargetHPRatioRegister; // 0xBE0
	internal static ByTargetRaycastVisiableRegister sByTargetRaycastVisiableRegister; // 0xBE8
	internal static ByLocalAvatarStaminaRegister sByLocalAvatarStaminaRegister; // 0xBF0
	internal static ByLocalAvatarStaminaRatioRegister sByLocalAvatarStaminaRatioRegister; // 0xBF8
	internal static ByTargetHPValueRegister sByTargetHPValueRegister; // 0xC00
	internal static ByHitDamageRegister sByHitDamageRegister; // 0xC08
	internal static ByHitEnBreakRegister sByHitEnBreakRegister; // 0xC10
	internal static ByHitCriticalRegister sByHitCriticalRegister; // 0xC18
	internal static ByTargetOverrideMapValueRegister sByTargetOverrideMapValueRegister; // 0xC20
	internal static ByWetHitColliderRegister sByWetHitColliderRegister; // 0xC28
	internal static ByHitBoxNameRegister sByHitBoxNameRegister; // 0xC30
	internal static ByHitBoxTypeRegister sByHitBoxTypeRegister; // 0xC38
	internal static ByHasElementRegister sByHasElementRegister; // 0xC40
	internal static ByHasAbilityStateRegister sByHasAbilityStateRegister; // 0xC48
	internal static ByNotRegister sByNotRegister; // 0xC50
	internal static ByAnyRegister sByAnyRegister; // 0xC58
	internal static ByHasAttackTargetRegister sByHasAttackTargetRegister; // 0xC60
	internal static ByTargetIsGhostToEnemyRegister sByTargetIsGhostToEnemyRegister; // 0xC68
	internal static ByTargetIsSelfRegister sByTargetIsSelfRegister; // 0xC70
	internal static ByTargetElementRegister sByTargetElementRegister; // 0xC78
	internal static ByTargetWeightRegister sByTargetWeightRegister; // 0xC80
	internal static ByAnimatorFloatRegister sByAnimatorFloatRegister; // 0xC88
	internal static ByAnimatorIntRegister sByAnimatorIntRegister; // 0xC90
	internal static ByAnimatorBoolRegister sByAnimatorBoolRegister; // 0xC98
	internal static ByTargetGlobalValueRegister sByTargetGlobalValueRegister; // 0xCA0
	internal static ByScenePropStateRegister sByScenePropStateRegister; // 0xCA8
	internal static ByAvatarInWaterDepthRegister sByAvatarInWaterDepthRegister; // 0xCB0
	internal static ByEntityTypesRegister sByEntityTypesRegister; // 0xCB8
	internal static ByHitImpulseRegister sByHitImpulseRegister; // 0xCC0
	internal static ByHitElementRegister sByHitElementRegister; // 0xCC8
	internal static ByHitStrikeTypeRegister sByHitStrikeTypeRegister; // 0xCD0
	internal static ByIsMoveOnWaterRegister sByIsMoveOnWaterRegister; // 0xCD8
	internal static ByAttackTagsRegister sByAttackTagsRegister; // 0xCE0
	internal static BySceneSurfaceTypeRegister sBySceneSurfaceTypeRegister; // 0xCE8
	internal static ByUnlockTalentParamRegister sByUnlockTalentParamRegister; // 0xCF0
	internal static ByConductiveRegister sByConductiveRegister; // 0xCF8
	internal static BySkillReadyRegister sBySkillReadyRegister; // 0xD00
	internal static ByTargetPositionToSelfPositionRegister sByTargetPositionToSelfPositionRegister; // 0xD08
	internal static ByTargetForwardAndSelfPositionRegister sByTargetForwardAndSelfPositionRegister; // 0xD10
	internal static BySelfForwardAndTargetPositionRegister sBySelfForwardAndTargetPositionRegister; // 0xD18
	internal static ByEnergyRatioRegister sByEnergyRatioRegister; // 0xD20
	internal static BySummonTagValueRegister sBySummonTagValueRegister; // 0xD28
	internal static ByAttackNotHitSceneRegister sByAttackNotHitSceneRegister; // 0xD30
	internal static ByIsCombatRegister sByIsCombatRegister; // 0xD38
	internal static ByTargetAltitudeRegister sByTargetAltitudeRegister; // 0xD40
	internal static ByStageIsReadyTempRegister sByStageIsReadyTempRegister; // 0xD48
	internal static ByItemNumberRegister sByItemNumberRegister; // 0xD50
	internal static ByHasComponentTagRegister sByHasComponentTagRegister; // 0xD58
	internal static ByHasFeatureTagRegister sByHasFeatureTagRegister; // 0xD60
	internal static ByAvatarElementTypeRegister sByAvatarElementTypeRegister; // 0xD68
	internal static ByAvatarWeaponTypeRegister sByAvatarWeaponTypeRegister; // 0xD70
	internal static ByAvatarBodyTypeRegister sByAvatarBodyTypeRegister; // 0xD78
	internal static ByCurTeamHasFeatureTagRegister sByCurTeamHasFeatureTagRegister; // 0xD80
	internal static ByCurTeamHasElementTypeRegister sByCurTeamHasElementTypeRegister; // 0xD88
	internal static ByCurTeamElementTypeSortRegister sByCurTeamElementTypeSortRegister; // 0xD90
	internal static ByCurTeamHasWeaponTypeRegister sByCurTeamHasWeaponTypeRegister; // 0xD98
	internal static ByCurTeamWeaponTypeSortRegister sByCurTeamWeaponTypeSortRegister; // 0xDA0
	internal static ByCurTeamHasBodyTypeRegister sByCurTeamHasBodyTypeRegister; // 0xDA8
	internal static ByCurTeamBodyTypeSortRegister sByCurTeamBodyTypeSortRegister; // 0xDB0
	internal static ByBigTeamHasFeatureTagRegister sByBigTeamHasFeatureTagRegister; // 0xDB8
	internal static ByBigTeamHasElementTypeRegister sByBigTeamHasElementTypeRegister; // 0xDC0
	internal static ByBigTeamElementTypeSortRegister sByBigTeamElementTypeSortRegister; // 0xDC8
	internal static ByBigTeamHasWeaponTypeRegister sByBigTeamHasWeaponTypeRegister; // 0xDD0
	internal static ByBigTeamWeaponTypeSortRegister sByBigTeamWeaponTypeSortRegister; // 0xDD8
	internal static ByBigTeamHasBodyTypeRegister sByBigTeamHasBodyTypeRegister; // 0xDE0
	internal static ByBigTeamBodyTypeSortRegister sByBigTeamBodyTypeSortRegister; // 0xDE8
	internal static ByAttackTypeRegister sByAttackTypeRegister; // 0xDF0
	internal static ByCompareWithTargetRegister sByCompareWithTargetRegister; // 0xDF8
	internal static ByEntityAppearVisionTypeRegister sByEntityAppearVisionTypeRegister; // 0xE00
	internal static ByElementTriggerEntityTypeRegister sByElementTriggerEntityTypeRegister; // 0xE08
	internal static ByElementReactionSourceTypeRegister sByElementReactionSourceTypeRegister; // 0xE10
	internal static ByElementReactionTypeRegister sByElementReactionTypeRegister; // 0xE18
	internal static ByTargetConfigIDRegister sByTargetConfigIDRegister; // 0xE20
	internal static ByIsLocalAvatarRegister sByIsLocalAvatarRegister; // 0xE28
	internal static ByTargetGadgetStateRegister sByTargetGadgetStateRegister; // 0xE30
	internal static ByDieStateFlagRegister sByDieStateFlagRegister; // 0xE38
	internal static ByHasShieldRegister sByHasShieldRegister; // 0xE40
	internal static ByGlobalPosToGroundRegister sByGlobalPosToGroundRegister; // 0xE48
	internal static ByEquipAffixReadyRegister sByEquipAffixReadyRegister; // 0xE50
	internal static ByIsTargetCampRegister sByIsTargetCampRegister; // 0xE58
	internal static ByHasChildGadgetRegister sByHasChildGadgetRegister; // 0xE60
	internal static ByTargetLayoutAreaRegister sByTargetLayoutAreaRegister; // 0xE68
	internal static ByIsGadgetExistAroundRegister sByIsGadgetExistAroundRegister; // 0xE70
	internal static ByEntityIsAliveRegister sByEntityIsAliveRegister; // 0xE78
	internal static ByMonsterAirStateRegister sByMonsterAirStateRegister; // 0xE80
	internal static ByGameTimeIsLockedRegister sByGameTimeIsLockedRegister; // 0xE88
	internal static ByTargetIsCasterRegister sByTargetIsCasterRegister; // 0xE90
	internal static ByHitElementDurabilityRegister sByHitElementDurabilityRegister; // 0xE98
	internal static ByHasTagRegister sByHasTagRegister; // 0xEA0
	internal static ByCurrentSceneTypesRegister sByCurrentSceneTypesRegister; // 0xEA8
	internal static ByTargetTypeRegister sByTargetTypeRegister; // 0xEB0
	internal static ByCurrentSceneIdRegister sByCurrentSceneIdRegister; // 0xEB8
	internal static Dictionary<string, ConfigAbilityTask> sConfigAbilityTaskDict; // 0xEC0
	internal static Dictionary<uint, ConfigAbilityTask> sConfigAbilityTaskTypeDict; // 0xEC8
	internal static ConfigDummyAbilityTaskRegister sConfigDummyAbilityTaskRegister; // 0xED0
	internal static ConfigTriggerMassiveElementTaskRegister sConfigTriggerMassiveElementTaskRegister; // 0xED8
	internal static Dictionary<string, ConfigAIThreatScoreBaseSetting> sConfigAIThreatScoreBaseSettingDict; // 0xEE0
	internal static Dictionary<uint, ConfigAIThreatScoreBaseSetting> sConfigAIThreatScoreBaseSettingTypeDict; // 0xEE8
	internal static ConfigAITSAbilityGlobalValueSettingRegister sConfigAITSAbilityGlobalValueSettingRegister; // 0xEF0
	internal static ConfigAITSTargetDistanceSettingRegister sConfigAITSTargetDistanceSettingRegister; // 0xEF8
	internal static ConfigAITSTargetBearingSettingRegister sConfigAITSTargetBearingSettingRegister; // 0xF00
	internal static Dictionary<string, ConfigAITacticBaseSetting> sConfigAITacticBaseSettingDict; // 0xF08
	internal static Dictionary<uint, ConfigAITacticBaseSetting> sConfigAITacticBaseSettingTypeDict; // 0xF10
	internal static ConfigAIReturnToBornPosSettingRegister sConfigAIReturnToBornPosSettingRegister; // 0xF18
	internal static ConfigAIWanderSettingRegister sConfigAIWanderSettingRegister; // 0xF20
	internal static ConfigAIFollowScriptedPathSettingRegister sConfigAIFollowScriptedPathSettingRegister; // 0xF28
	internal static ConfigAIFollowServerRouteSettingRegister sConfigAIFollowServerRouteSettingRegister; // 0xF30
	internal static ConfigAIInvestigateSettingRegister sConfigAIInvestigateSettingRegister; // 0xF38
	internal static ConfigAIReactActionPointSettingRegister sConfigAIReactActionPointSettingRegister; // 0xF40
	internal static ConfigAIPatrolFollowSettingRegister sConfigAIPatrolFollowSettingRegister; // 0xF48
	internal static ConfigAICombatFollowMoveSettingRegister sConfigAICombatFollowMoveSettingRegister; // 0xF50
	internal static ConfigAIMeleeChargeSettingRegister sConfigAIMeleeChargeSettingRegister; // 0xF58
	internal static ConfigAIFacingMoveSettingRegister sConfigAIFacingMoveSettingRegister; // 0xF60
	internal static ConfigAISurroundSettingRegister sConfigAISurroundSettingRegister; // 0xF68
	internal static ConfigAIFindBackSettingRegister sConfigAIFindBackSettingRegister; // 0xF70
	internal static ConfigAICombatFixedMoveSettingRegister sConfigAICombatFixedMoveSettingRegister; // 0xF78
	internal static ConfigAICrabMoveSettingRegister sConfigAICrabMoveSettingRegister; // 0xF80
	internal static ConfigAIFleeSettingRegister sConfigAIFleeSettingRegister; // 0xF88
	internal static ConfigAISpacialChaseSettingRegister sConfigAISpacialChaseSettingRegister; // 0xF90
	internal static ConfigAISpacialProbeSettingRegister sConfigAISpacialProbeSettingRegister; // 0xF98
	internal static ConfigAISpacialAdjustSettingRegister sConfigAISpacialAdjustSettingRegister; // 0xFA0
	internal static ConfigAIBirdCirclingSettingRegister sConfigAIBirdCirclingSettingRegister; // 0xFA8
	internal static ConfigAIScriptedMoveToSettingRegister sConfigAIScriptedMoveToSettingRegister; // 0xFB0
	internal static ConfigAILandingSettingRegister sConfigAILandingSettingRegister; // 0xFB8
	internal static ConfigAIExtractionSettingRegister sConfigAIExtractionSettingRegister; // 0xFC0
	internal static ConfigAIBrownianMotionSettingRegister sConfigAIBrownianMotionSettingRegister; // 0xFC8
	internal static Dictionary<string, ConfigBaseAttackPattern> sConfigBaseAttackPatternDict; // 0xFD0
	internal static Dictionary<uint, ConfigBaseAttackPattern> sConfigBaseAttackPatternTypeDict; // 0xFD8
	internal static ConfigSimpleAttackPatternRegister sConfigSimpleAttackPatternRegister; // 0xFE0
	internal static ConfigAttackUsePrefabRegister sConfigAttackUsePrefabRegister; // 0xFE8
	internal static ConfigAttackTrailRegister sConfigAttackTrailRegister; // 0xFF0
	internal static ConfigAttackDoubleTrailRegister sConfigAttackDoubleTrailRegister; // 0xFF8
	internal static ConfigAttackBoxRegister sConfigAttackBoxRegister; // 0x1000
	internal static ConfigAttackCircleRegister sConfigAttackCircleRegister; // 0x1008
	internal static ConfigAttackSphereRegister sConfigAttackSphereRegister; // 0x1010
	internal static Dictionary<string, ConfigAudioEventCullingRuleBase> sConfigAudioEventCullingRuleBaseDict; // 0x1018
	internal static Dictionary<uint, ConfigAudioEventCullingRuleBase> sConfigAudioEventCullingRuleBaseTypeDict; // 0x1020
	internal static ConfigRuleCullingDistanceRegister sConfigRuleCullingDistanceRegister; // 0x1028
	internal static ConfigRuleWaitDistanceRegister sConfigRuleWaitDistanceRegister; // 0x1030
	internal static ConfigRuleLimitFrameGlobalRegister sConfigRuleLimitFrameGlobalRegister; // 0x1038
	internal static ConfigRuleLimitFrameRegister sConfigRuleLimitFrameRegister; // 0x1040
	internal static ConfigRuleCullingEventNameContainRegister sConfigRuleCullingEventNameContainRegister; // 0x1048
	internal static ConfigRuleCullingEventRegister sConfigRuleCullingEventRegister; // 0x1050
	internal static Dictionary<string, ConfigAudioOperation> sConfigAudioOperationDict; // 0x1058
	internal static Dictionary<uint, ConfigAudioOperation> sConfigAudioOperationTypeDict; // 0x1060
	internal static ConfigAudioEventOpRegister sConfigAudioEventOpRegister; // 0x1068
	internal static ConfigAudioEmitterOpRegister sConfigAudioEmitterOpRegister; // 0x1070
	internal static ConfigAudioPositionedOpRegister sConfigAudioPositionedOpRegister; // 0x1078
	internal static ConfigAudioPositionedEventOpRegister sConfigAudioPositionedEventOpRegister; // 0x1080
	internal static ConfigAudioPositionedEmitterOpRegister sConfigAudioPositionedEmitterOpRegister; // 0x1088
	internal static Dictionary<string, AudioSettingSlider> sAudioSettingSliderDict; // 0x1090
	internal static Dictionary<uint, AudioSettingSlider> sAudioSettingSliderTypeDict; // 0x1098
	internal static AudioSettingSlider_PostEventRegister sAudioSettingSlider_PostEventRegister; // 0x10A0
	internal static AudioSettingSlider_PostVoiceRegister sAudioSettingSlider_PostVoiceRegister; // 0x10A8
	internal static Dictionary<string, ConfigClimateInfoBase> sConfigClimateInfoBaseDict; // 0x10B0
	internal static Dictionary<uint, ConfigClimateInfoBase> sConfigClimateInfoBaseTypeDict; // 0x10B8
	internal static ConfigClimateInfoRegister sConfigClimateInfoRegister; // 0x10C0
	internal static Dictionary<string, ConfigBeHitBlendShake> sConfigBeHitBlendShakeDict; // 0x10C8
	internal static Dictionary<uint, ConfigBeHitBlendShake> sConfigBeHitBlendShakeTypeDict; // 0x10D0
	internal static ConfigBeHitBlendShakeByAinmatorRegister sConfigBeHitBlendShakeByAinmatorRegister; // 0x10D8
	internal static Dictionary<string, ConfigEffectAttachShape> sConfigEffectAttachShapeDict; // 0x10E0
	internal static Dictionary<uint, ConfigEffectAttachShape> sConfigEffectAttachShapeTypeDict; // 0x10E8
	internal static ConfigEffectAttachBoxRegister sConfigEffectAttachBoxRegister; // 0x10F0
	internal static ConfigEffectAttachSkinnedMeshRegister sConfigEffectAttachSkinnedMeshRegister; // 0x10F8
	internal static ConfigEffectAttachMeshRegister sConfigEffectAttachMeshRegister; // 0x1100
	internal static Dictionary<string, ConfigBillboard> sConfigBillboardDict; // 0x1108
	internal static Dictionary<uint, ConfigBillboard> sConfigBillboardTypeDict; // 0x1110
	internal static ConfigCombatBillboardRegister sConfigCombatBillboardRegister; // 0x1118
	internal static ConfigProgressBillboardRegister sConfigProgressBillboardRegister; // 0x1120
	internal static ConfigGadgetIconBillboardRegister sConfigGadgetIconBillboardRegister; // 0x1128
	internal static Dictionary<string, ConfigCoopBaseNode> sConfigCoopBaseNodeDict; // 0x1130
	internal static Dictionary<uint, ConfigCoopBaseNode> sConfigCoopBaseNodeTypeDict; // 0x1138
	internal static ConfigCoopTalkNodeRegister sConfigCoopTalkNodeRegister; // 0x1140
	internal static ConfigCoopCondNodeRegister sConfigCoopCondNodeRegister; // 0x1148
	internal static ConfigCoopSelectNodeRegister sConfigCoopSelectNodeRegister; // 0x1150
	internal static ConfigCoopActionNodeRegister sConfigCoopActionNodeRegister; // 0x1158
	internal static ConfigCoopEndNodeRegister sConfigCoopEndNodeRegister; // 0x1160
	internal static Dictionary<string, ConfigBaseCutscene> sConfigBaseCutsceneDict; // 0x1168
	internal static Dictionary<uint, ConfigBaseCutscene> sConfigBaseCutsceneTypeDict; // 0x1170
	internal static ConfigTimelineRegister sConfigTimelineRegister; // 0x1178
	internal static Dictionary<string, DebugBlletinInfo> sDebugBlletinInfoDict; // 0x1180
	internal static Dictionary<uint, DebugBlletinInfo> sDebugBlletinInfoTypeDict; // 0x1188
	internal static DebugBoardInfoRegister sDebugBoardInfoRegister; // 0x1190
	internal static Dictionary<string, ConfigBornDirectionType> sConfigBornDirectionTypeDict; // 0x1198
	internal static Dictionary<uint, ConfigBornDirectionType> sConfigBornDirectionTypeTypeDict; // 0x11A0
	internal static ConfigDirectionByDefaultRegister sConfigDirectionByDefaultRegister; // 0x11A8
	internal static ConfigDirectionByEntityRegister sConfigDirectionByEntityRegister; // 0x11B0
	internal static ConfigDirectionByAttackTargetRegister sConfigDirectionByAttackTargetRegister; // 0x11B8
	internal static ConfigDirectionByAttachPointRegister sConfigDirectionByAttachPointRegister; // 0x11C0
	internal static ConfigDirectionByBackToHitBoxCenterRegister sConfigDirectionByBackToHitBoxCenterRegister; // 0x11C8
	internal static ConfigDirectionByLookAtEntityRegister sConfigDirectionByLookAtEntityRegister; // 0x11D0
	internal static ConfigDirectionByGroundNormalRegister sConfigDirectionByGroundNormalRegister; // 0x11D8
	internal static ConfigDirectionByGlobalValueRegister sConfigDirectionByGlobalValueRegister; // 0x11E0
	internal static ConfigDirectionByWorldRegister sConfigDirectionByWorldRegister; // 0x11E8
	internal static Dictionary<string, BornRandom> sBornRandomDict; // 0x11F0
	internal static Dictionary<uint, BornRandom> sBornRandomTypeDict; // 0x11F8
	internal static BornRandomFromCenterRegister sBornRandomFromCenterRegister; // 0x1200
	internal static BornRandomInShapeRegister sBornRandomInShapeRegister; // 0x1208
	internal static Dictionary<string, ConfigBornType> sConfigBornTypeDict; // 0x1210
	internal static Dictionary<uint, ConfigBornType> sConfigBornTypeTypeDict; // 0x1218
	internal static ConfigBornByTargetRegister sConfigBornByTargetRegister; // 0x1220
	internal static ConfigBornBySelfRegister sConfigBornBySelfRegister; // 0x1228
	internal static ConfigBornBySelfOwnerRegister sConfigBornBySelfOwnerRegister; // 0x1230
	internal static ConfigBornByAttachPointRegister sConfigBornByAttachPointRegister; // 0x1238
	internal static ConfigBornByStormLightningRegister sConfigBornByStormLightningRegister; // 0x1240
	internal static ConfigBornByWorldRegister sConfigBornByWorldRegister; // 0x1248
	internal static ConfigBornByGlobalValueRegister sConfigBornByGlobalValueRegister; // 0x1250
	internal static ConfigBornByCollisionPointRegister sConfigBornByCollisionPointRegister; // 0x1258
	internal static ConfigBornByRushToPointRegister sConfigBornByRushToPointRegister; // 0x1260
	internal static ConfigBornByTeleportToPointRegister sConfigBornByTeleportToPointRegister; // 0x1268
	internal static ConfigBornByPredicatePointRegister sConfigBornByPredicatePointRegister; // 0x1270
	internal static ConfigBornByHitPointRegister sConfigBornByHitPointRegister; // 0x1278
	internal static ConfigBornByElementPosRegister sConfigBornByElementPosRegister; // 0x1280
	internal static Dictionary<string, ConfigActionPointSelectType> sConfigActionPointSelectTypeDict; // 0x1288
	internal static Dictionary<uint, ConfigActionPointSelectType> sConfigActionPointSelectTypeTypeDict; // 0x1290
	internal static SelectActionPointByIDRegister sSelectActionPointByIDRegister; // 0x1298
	internal static SelectActionPointBySelfPosRegister sSelectActionPointBySelfPosRegister; // 0x12A0
	internal static SelectActionPointByTargetPosRegister sSelectActionPointByTargetPosRegister; // 0x12A8
	internal static SelectActionPointByAwayFromAvatarRegister sSelectActionPointByAwayFromAvatarRegister; // 0x12B0
	internal static SelectActionPointByTargetOrientationRegister sSelectActionPointByTargetOrientationRegister; // 0x12B8
	internal static SelectActionPointByAllAvatarsOrientationRegister sSelectActionPointByAllAvatarsOrientationRegister; // 0x12C0
	internal static ConfigBornByActionPointRegister sConfigBornByActionPointRegister; // 0x12C8
	internal static ConfigBornByTargetLinearPointRegister sConfigBornByTargetLinearPointRegister; // 0x12D0
	internal static Dictionary<string, ConfigHeadControl> sConfigHeadControlDict; // 0x12D8
	internal static Dictionary<uint, ConfigHeadControl> sConfigHeadControlTypeDict; // 0x12E0
	internal static ConfigMonsterHeadControlRegister sConfigMonsterHeadControlRegister; // 0x12E8
	internal static Dictionary<string, ConfigEntity> sConfigEntityDict; // 0x12F0
	internal static Dictionary<uint, ConfigEntity> sConfigEntityTypeDict; // 0x12F8
	internal static Dictionary<string, ConfigGadgetPredicate> sConfigGadgetPredicateDict; // 0x1300
	internal static Dictionary<uint, ConfigGadgetPredicate> sConfigGadgetPredicateTypeDict; // 0x1308
	internal static ConfigPredicateByTimeRegister sConfigPredicateByTimeRegister; // 0x1310
	internal static ConfigPredicateByPlatformRegister sConfigPredicateByPlatformRegister; // 0x1318
	internal static ConfigPredicateByInteractRegister sConfigPredicateByInteractRegister; // 0x1320
	internal static Dictionary<string, ConfigGadgetStateAction> sConfigGadgetStateActionDict; // 0x1328
	internal static Dictionary<uint, ConfigGadgetStateAction> sConfigGadgetStateActionTypeDict; // 0x1330
	internal static ConfigGadgetStateFireEffectRegister sConfigGadgetStateFireEffectRegister; // 0x1338
	internal static ConfigGadgetStateSetAnimTriggerRegister sConfigGadgetStateSetAnimTriggerRegister; // 0x1340
	internal static ConfigGadgetStateSetAnimIntRegister sConfigGadgetStateSetAnimIntRegister; // 0x1348
	internal static ConfigGadgetStateFireAISoundRegister sConfigGadgetStateFireAISoundRegister; // 0x1350
	internal static ConfigGadgetStateEnableGadgetInteeRegister sConfigGadgetStateEnableGadgetInteeRegister; // 0x1358
	internal static ConfigGadgetStateEnableActionRegister sConfigGadgetStateEnableActionRegister; // 0x1360
	internal static ConfigGadgetStateSendEffectTriggerRegister sConfigGadgetStateSendEffectTriggerRegister; // 0x1368
	internal static Dictionary<string, ConfigControlPart> sConfigControlPartDict; // 0x1370
	internal static Dictionary<uint, ConfigControlPart> sConfigControlPartTypeDict; // 0x1378
	internal static ConfigControlPartByIKRegister sConfigControlPartByIKRegister; // 0x1380
	internal static ConfigControlPartByIKCCDRegister sConfigControlPartByIKCCDRegister; // 0x1388
	internal static ConfigGadgetRegister sConfigGadgetRegister; // 0x1390
	internal static ConfigCharacterRegister sConfigCharacterRegister; // 0x1398
	internal static ConfigAvatarRegister sConfigAvatarRegister; // 0x13A0
	internal static ConfigMonsterRegister sConfigMonsterRegister; // 0x13A8
	internal static ConfigNpcRegister sConfigNpcRegister; // 0x13B0
	internal static ConfigLevelEntityRegister sConfigLevelEntityRegister; // 0x13B8
	internal static ConfigTransPointEntityRegister sConfigTransPointEntityRegister; // 0x13C0
	internal static Dictionary<string, ConfigEntityAudio> sConfigEntityAudioDict; // 0x13C8
	internal static Dictionary<uint, ConfigEntityAudio> sConfigEntityAudioTypeDict; // 0x13D0
	internal static ConfigGadgetAudioRegister sConfigGadgetAudioRegister; // 0x13D8
	internal static ConfigCharacterAudioRegister sConfigCharacterAudioRegister; // 0x13E0
	internal static ConfigAvatarAudioRegister sConfigAvatarAudioRegister; // 0x13E8
	internal static ConfigMonsterAudioRegister sConfigMonsterAudioRegister; // 0x13F0
	internal static Dictionary<string, ConfigBaseGadgetTriggerAction> sConfigBaseGadgetTriggerActionDict; // 0x13F8
	internal static Dictionary<uint, ConfigBaseGadgetTriggerAction> sConfigBaseGadgetTriggerActionTypeDict; // 0x1400
	internal static ConfigGadgetDoAttackEventRegister sConfigGadgetDoAttackEventRegister; // 0x1408
	internal static ConfigGadgetTriggerAbilityRegister sConfigGadgetTriggerAbilityRegister; // 0x1410
	internal static ConfigGadgetDamageByAttackValueRegister sConfigGadgetDamageByAttackValueRegister; // 0x1418
	internal static Dictionary<string, ConfigGadgetPattern> sConfigGadgetPatternDict; // 0x1420
	internal static Dictionary<uint, ConfigGadgetPattern> sConfigGadgetPatternTypeDict; // 0x1428
	internal static ConfigGadgetCollidedPatternRegister sConfigGadgetCollidedPatternRegister; // 0x1430
	internal static ConfigBulletPatternRegister sConfigBulletPatternRegister; // 0x1438
	internal static Dictionary<string, ConfigBaseGuide> sConfigBaseGuideDict; // 0x1440
	internal static Dictionary<uint, ConfigBaseGuide> sConfigBaseGuideTypeDict; // 0x1448
	internal static ConfigGuideActionRegister sConfigGuideActionRegister; // 0x1450
	internal static ConfigGuideConditionRegister sConfigGuideConditionRegister; // 0x1458
	internal static ConfigAvatarEquipChangedConditionRegister sConfigAvatarEquipChangedConditionRegister; // 0x1460
	internal static ConfigGuideOpenStateConditionRegister sConfigGuideOpenStateConditionRegister; // 0x1468
	internal static ConfigGuideLevelConditionRegister sConfigGuideLevelConditionRegister; // 0x1470
	internal static ConfigGuideOpenUIConditionRegister sConfigGuideOpenUIConditionRegister; // 0x1478
	internal static ConfigGuideAvatarChangeConditionRegister sConfigGuideAvatarChangeConditionRegister; // 0x1480
	internal static ConfigGuideCanGetPersonalLineKeyConditionRegister sConfigGuideCanGetPersonalLineKeyConditionRegister; // 0x1488
	internal static ConfigGuideClimateTypeConditionRegister sConfigGuideClimateTypeConditionRegister; // 0x1490
	internal static ConfigGuideTeamMemberConditionRegister sConfigGuideTeamMemberConditionRegister; // 0x1498
	internal static ConfigGuideAvatarStateConditionRegister sConfigGuideAvatarStateConditionRegister; // 0x14A0
	internal static ConfigGuideButtonClickConditionRegister sConfigGuideButtonClickConditionRegister; // 0x14A8
	internal static ConfigGuideTabItemConditionRegister sConfigGuideTabItemConditionRegister; // 0x14B0
	internal static ConfigGuideTheatreMechanicusBuildingSelectConditionRegister sConfigGuideTheatreMechanicusBuildingSelectConditionRegister; // 0x14B8
	internal static ConfigGuideTheatreMechanicusInfoSelectConditionRegister sConfigGuideTheatreMechanicusInfoSelectConditionRegister; // 0x14C0
	internal static ConfigGuideHasItemConditionRegister sConfigGuideHasItemConditionRegister; // 0x14C8
	internal static ConfigGuideCameraConditionRegister sConfigGuideCameraConditionRegister; // 0x14D0
	internal static ConfigGuideAvatarActionConditionRegister sConfigGuideAvatarActionConditionRegister; // 0x14D8
	internal static ConfigGuideDelayFinishConditionRegister sConfigGuideDelayFinishConditionRegister; // 0x14E0
	internal static ConfigGuideMultiSinglePlayerConditionRegister sConfigGuideMultiSinglePlayerConditionRegister; // 0x14E8
	internal static ConfigGuideMultiPlayerConditionRegister sConfigGuideMultiPlayerConditionRegister; // 0x14F0
	internal static ConfigGuideHasAvatarConditionRegister sConfigGuideHasAvatarConditionRegister; // 0x14F8
	internal static ConfigGuideKillMonsterConditionRegister sConfigGuideKillMonsterConditionRegister; // 0x1500
	internal static ConfigGuideCheckTaskFinishConditionRegister sConfigGuideCheckTaskFinishConditionRegister; // 0x1508
	internal static ConfigGuideCheckQuestStateConditionRegister sConfigGuideCheckQuestStateConditionRegister; // 0x1510
	internal static ConfigGuideNavigationConditionRegister sConfigGuideNavigationConditionRegister; // 0x1518
	internal static ConfigGuideOpenPaimonNavigationConditionRegister sConfigGuideOpenPaimonNavigationConditionRegister; // 0x1520
	internal static ConfigGuideVirtualDialActionConditionRegister sConfigGuideVirtualDialActionConditionRegister; // 0x1528
	internal static ConfigGuideCheckPlatformConditionRegister sConfigGuideCheckPlatformConditionRegister; // 0x1530
	internal static ConfigGuideCheckAimConditionRegister sConfigGuideCheckAimConditionRegister; // 0x1538
	internal static ConfigGuideLevelTypeConditionRegister sConfigGuideLevelTypeConditionRegister; // 0x1540
	internal static ConfigGuidePressKeyConditionRegister sConfigGuidePressKeyConditionRegister; // 0x1548
	internal static ConfigGuideMapClickConditionRegister sConfigGuideMapClickConditionRegister; // 0x1550
	internal static ConfigGuideSceneIdConditionRegister sConfigGuideSceneIdConditionRegister; // 0x1558
	internal static ConfigGuideDungeonIdConditionRegister sConfigGuideDungeonIdConditionRegister; // 0x1560
	internal static ConfigGuideFoundationBuildConditionRegister sConfigGuideFoundationBuildConditionRegister; // 0x1568
	internal static ConfigGuideMechanicusPickCardConditionRegister sConfigGuideMechanicusPickCardConditionRegister; // 0x1570
	internal static ConfigGuidePageCheckBaseConditionRegister sConfigGuidePageCheckBaseConditionRegister; // 0x1578
	internal static ConfigGuideHideandSeekSkillCategoryConditionRegister sConfigGuideHideandSeekSkillCategoryConditionRegister; // 0x1580
	internal static ConfigGuideUIMaskActionRegister sConfigGuideUIMaskActionRegister; // 0x1588
	internal static ConfigGuideShowPageRegister sConfigGuideShowPageRegister; // 0x1590
	internal static ConfigGuideInfoDialogActionRegister sConfigGuideInfoDialogActionRegister; // 0x1598
	internal static ConfigGuideSetOpenStateActionRegister sConfigGuideSetOpenStateActionRegister; // 0x15A0
	internal static ConfigGuideAddTaskActionRegister sConfigGuideAddTaskActionRegister; // 0x15A8
	internal static ConfigGuideEndTaskActionRegister sConfigGuideEndTaskActionRegister; // 0x15B0
	internal static ConfigGuidePauseActionRegister sConfigGuidePauseActionRegister; // 0x15B8
	internal static ConfigGuideForceAvatarMoveActionRegister sConfigGuideForceAvatarMoveActionRegister; // 0x15C0
	internal static ConfigGuideCameraControlActionRegister sConfigGuideCameraControlActionRegister; // 0x15C8
	internal static ConfigGuideDelayDoActionRegister sConfigGuideDelayDoActionRegister; // 0x15D0
	internal static ConfigGuideDoActionByPredicateRegister sConfigGuideDoActionByPredicateRegister; // 0x15D8
	internal static ConfigGuideShowTutorialActionRegister sConfigGuideShowTutorialActionRegister; // 0x15E0
	internal static ConfigGuideShowPanelActionRegister sConfigGuideShowPanelActionRegister; // 0x15E8
	internal static ConfigGuideSwitchInputContextActionRegister sConfigGuideSwitchInputContextActionRegister; // 0x15F0
	internal static ConfigGuideFinishQuestActionRegister sConfigGuideFinishQuestActionRegister; // 0x15F8
	internal static Dictionary<string, ConfigBaseInterAction> sConfigBaseInterActionDict; // 0x1600
	internal static Dictionary<uint, ConfigBaseInterAction> sConfigBaseInterActionTypeDict; // 0x1608
	internal static ConfigLuaActionRegister sConfigLuaActionRegister; // 0x1610
	internal static ConfigDialogInterActionRegister sConfigDialogInterActionRegister; // 0x1618
	internal static ConfigDialogNextActionRegister sConfigDialogNextActionRegister; // 0x1620
	internal static ConfigDialogSelectActionRegister sConfigDialogSelectActionRegister; // 0x1628
	internal static ConfigBodyLangInterActionRegister sConfigBodyLangInterActionRegister; // 0x1630
	internal static ConfigSteerInterActionRegister sConfigSteerInterActionRegister; // 0x1638
	internal static ConfigLookAtInterActionRegister sConfigLookAtInterActionRegister; // 0x1640
	internal static ConfigLookAtEyeCtrlInterActionRegister sConfigLookAtEyeCtrlInterActionRegister; // 0x1648
	internal static ConfigCameraMoveInterActionRegister sConfigCameraMoveInterActionRegister; // 0x1650
	internal static ConfigCutsceneInterActionRegister sConfigCutsceneInterActionRegister; // 0x1658
	internal static ConfigVisibleInterActionRegister sConfigVisibleInterActionRegister; // 0x1660
	internal static ConfigAudioStateInterActionRegister sConfigAudioStateInterActionRegister; // 0x1668
	internal static ConfigShopExchangeInterActionRegister sConfigShopExchangeInterActionRegister; // 0x1670
	internal static ConfigGadgetTouchActionRegister sConfigGadgetTouchActionRegister; // 0x1678
	internal static ConfigUITriggerInterActionRegister sConfigUITriggerInterActionRegister; // 0x1680
	internal static ConfigEmoSyncInterActionRegister sConfigEmoSyncInterActionRegister; // 0x1688
	internal static ConfigEmotionInterActionRegister sConfigEmotionInterActionRegister; // 0x1690
	internal static ConfigBlackScreenActionRegister sConfigBlackScreenActionRegister; // 0x1698
	internal static ConfigCameraShakeActionRegister sConfigCameraShakeActionRegister; // 0x16A0
	internal static ConfigShowMessageActionRegister sConfigShowMessageActionRegister; // 0x16A8
	internal static ConfigAudioPlayActionRegister sConfigAudioPlayActionRegister; // 0x16B0
	internal static ConfigVideoPlayActionRegister sConfigVideoPlayActionRegister; // 0x16B8
	internal static ConfigFirstSightActionRegister sConfigFirstSightActionRegister; // 0x16C0
	internal static ConfigCameraDOFActionRegister sConfigCameraDOFActionRegister; // 0x16C8
	internal static ConfigMoveToActionRegister sConfigMoveToActionRegister; // 0x16D0
	internal static ConfigRequestMsgActionRegister sConfigRequestMsgActionRegister; // 0x16D8
	internal static ConfigEmojiBubbleActionRegister sConfigEmojiBubbleActionRegister; // 0x16E0
	internal static ConfigTimeProtectActionRegister sConfigTimeProtectActionRegister; // 0x16E8
	internal static ConfigSimpleBlackScreenActionRegister sConfigSimpleBlackScreenActionRegister; // 0x16F0
	internal static ConfigSimpleUIShowInterActionRegister sConfigSimpleUIShowInterActionRegister; // 0x16F8
	internal static ConfigOpenBlossomMarkInterActionRegister sConfigOpenBlossomMarkInterActionRegister; // 0x1700
	internal static ConfigSpeechBubbleActionRegister sConfigSpeechBubbleActionRegister; // 0x1708
	internal static ConfigEmotionTemplateActionRegister sConfigEmotionTemplateActionRegister; // 0x1710
	internal static ConfigSitOrStandActionRegister sConfigSitOrStandActionRegister; // 0x1718
	internal static ConfigPlayEffectActionRegister sConfigPlayEffectActionRegister; // 0x1720
	internal static ConfigTeleportToActionRegister sConfigTeleportToActionRegister; // 0x1728
	internal static ConfigSetAnimatorActionRegister sConfigSetAnimatorActionRegister; // 0x1730
	internal static ConfigPlayPostEffectActionRegister sConfigPlayPostEffectActionRegister; // 0x1738
	internal static Dictionary<string, ConfigLCBaseIntee> sConfigLCBaseInteeDict; // 0x1740
	internal static Dictionary<uint, ConfigLCBaseIntee> sConfigLCBaseInteeTypeDict; // 0x1748
	internal static ConfigLCGadgetInteeRegister sConfigLCGadgetInteeRegister; // 0x1750
	internal static Dictionary<string, IndicatorCondition> sIndicatorConditionDict; // 0x1758
	internal static Dictionary<uint, IndicatorCondition> sIndicatorConditionTypeDict; // 0x1760
	internal static IndicatorConditionGadgetStateRegister sIndicatorConditionGadgetStateRegister; // 0x1768
	internal static IndicatorConditionAllowInteractRegister sIndicatorConditionAllowInteractRegister; // 0x1770
	internal static IndicatorConditionDummyPointDistanceRegister sIndicatorConditionDummyPointDistanceRegister; // 0x1778
	internal static IndicatorConditionAvatarDistanceRegister sIndicatorConditionAvatarDistanceRegister; // 0x1780
	internal static IndicatorConditionKilledRegister sIndicatorConditionKilledRegister; // 0x1788
	internal static Dictionary<string, ConfigLBaseMark> sConfigLBaseMarkDict; // 0x1790
	internal static Dictionary<uint, ConfigLBaseMark> sConfigLBaseMarkTypeDict; // 0x1798
	internal static ConfigLMapMarkRegister sConfigLMapMarkRegister; // 0x17A0
	internal static Dictionary<string, ConfigVBaseMark> sConfigVBaseMarkDict; // 0x17A8
	internal static Dictionary<uint, ConfigVBaseMark> sConfigVBaseMarkTypeDict; // 0x17B0
	internal static ConfigVMapMarkRegister sConfigVMapMarkRegister; // 0x17B8
	internal static ConfigVCustomMapMarkRegister sConfigVCustomMapMarkRegister; // 0x17C0
	internal static Dictionary<string, ConfigMove> sConfigMoveDict; // 0x17C8
	internal static Dictionary<uint, ConfigMove> sConfigMoveTypeDict; // 0x17D0
	internal static Dictionary<string, ConfigMoveCorrection> sConfigMoveCorrectionDict; // 0x17D8
	internal static Dictionary<uint, ConfigMoveCorrection> sConfigMoveCorrectionTypeDict; // 0x17E0
	internal static ConfigSimpleMoveRegister sConfigSimpleMoveRegister; // 0x17E8
	internal static ConfigRigidbodyMoveRegister sConfigRigidbodyMoveRegister; // 0x17F0
	internal static ConfigAnimatorMoveRegister sConfigAnimatorMoveRegister; // 0x17F8
	internal static ConfigNPCMoveRegister sConfigNPCMoveRegister; // 0x1800
	internal static ConfigPlatformMoveRegister sConfigPlatformMoveRegister; // 0x1808
	internal static ConfigScenePropAnimatorMoveRegister sConfigScenePropAnimatorMoveRegister; // 0x1810
	internal static ConfigWindmillMoveRegister sConfigWindmillMoveRegister; // 0x1818
	internal static Dictionary<string, ConfigBulletMoveAngle> sConfigBulletMoveAngleDict; // 0x1820
	internal static Dictionary<uint, ConfigBulletMoveAngle> sConfigBulletMoveAngleTypeDict; // 0x1828
	internal static ConfigBulletMoveAngleByVelocityRegister sConfigBulletMoveAngleByVelocityRegister; // 0x1830
	internal static ConfigBulletMoveAngleRotatingRegister sConfigBulletMoveAngleRotatingRegister; // 0x1838
	internal static ConfigBulletMoveRegister sConfigBulletMoveRegister; // 0x1840
	internal static ConfigLinerBulletMoveRegister sConfigLinerBulletMoveRegister; // 0x1848
	internal static ConfigAnimationBulletMoveRegister sConfigAnimationBulletMoveRegister; // 0x1850
	internal static ConfigSurroundBulletMoveRegister sConfigSurroundBulletMoveRegister; // 0x1858
	internal static ConfigPinballBulletMoveRegister sConfigPinballBulletMoveRegister; // 0x1860
	internal static ConfigParabolaBulletMoveCorrectionRegister sConfigParabolaBulletMoveCorrectionRegister; // 0x1868
	internal static ConfigParabolaBulletMoveRegister sConfigParabolaBulletMoveRegister; // 0x1870
	internal static ConfigTrackBulletMoveRegister sConfigTrackBulletMoveRegister; // 0x1878
	internal static ConfigLinerParabolaBulletMoveRegister sConfigLinerParabolaBulletMoveRegister; // 0x1880
	internal static ConfigItanoCircusBulletMoveRegister sConfigItanoCircusBulletMoveRegister; // 0x1888
	internal static ConfigFollowMoveRegister sConfigFollowMoveRegister; // 0x1890
	internal static Dictionary<string, ConfigMusicCondition> sConfigMusicConditionDict; // 0x1898
	internal static Dictionary<uint, ConfigMusicCondition> sConfigMusicConditionTypeDict; // 0x18A0
	internal static ConfigMusicTrueConditionRegister sConfigMusicTrueConditionRegister; // 0x18A8
	internal static ConfigMusicNegativeConditionRegister sConfigMusicNegativeConditionRegister; // 0x18B0
	internal static ConfigMusicBinaryConditionRegister sConfigMusicBinaryConditionRegister; // 0x18B8
	internal static ConfigMusicConjunctiveConditionRegister sConfigMusicConjunctiveConditionRegister; // 0x18C0
	internal static ConfigMusicDisjunctiveConditionRegister sConfigMusicDisjunctiveConditionRegister; // 0x18C8
	internal static ConfigMusicParameterConditionRegister sConfigMusicParameterConditionRegister; // 0x18D0
	internal static ConfigMusicInt32ConditionRegister sConfigMusicInt32ConditionRegister; // 0x18D8
	internal static ConfigMusicInt32EqualityConditionRegister sConfigMusicInt32EqualityConditionRegister; // 0x18E0
	internal static ConfigMusicInt32InequalityConditionRegister sConfigMusicInt32InequalityConditionRegister; // 0x18E8
	internal static ConfigMusicInt32GreaterThanConditionRegister sConfigMusicInt32GreaterThanConditionRegister; // 0x18F0
	internal static ConfigMusicInt32LessThanConditionRegister sConfigMusicInt32LessThanConditionRegister; // 0x18F8
	internal static ConfigMusicInt32NoGreaterThanConditionRegister sConfigMusicInt32NoGreaterThanConditionRegister; // 0x1900
	internal static ConfigMusicInt32NoLessThanConditionRegister sConfigMusicInt32NoLessThanConditionRegister; // 0x1908
	internal static ConfigMusicUInt32ConditionRegister sConfigMusicUInt32ConditionRegister; // 0x1910
	internal static ConfigMusicUInt32EqualityConditionRegister sConfigMusicUInt32EqualityConditionRegister; // 0x1918
	internal static ConfigMusicUInt32InequalityConditionRegister sConfigMusicUInt32InequalityConditionRegister; // 0x1920
	internal static ConfigMusicUInt32GreaterThanConditionRegister sConfigMusicUInt32GreaterThanConditionRegister; // 0x1928
	internal static ConfigMusicUInt32LessThanConditionRegister sConfigMusicUInt32LessThanConditionRegister; // 0x1930
	internal static ConfigMusicUInt32NoGreaterThanConditionRegister sConfigMusicUInt32NoGreaterThanConditionRegister; // 0x1938
	internal static ConfigMusicUInt32NoLessThanConditionRegister sConfigMusicUInt32NoLessThanConditionRegister; // 0x1940
	internal static ConfigMusicUInt32MultiConditionRegister sConfigMusicUInt32MultiConditionRegister; // 0x1948
	internal static ConfigMusicSingleConditionRegister sConfigMusicSingleConditionRegister; // 0x1950
	internal static ConfigMusicSingleEqualityConditionRegister sConfigMusicSingleEqualityConditionRegister; // 0x1958
	internal static ConfigMusicSingleInequalityConditionRegister sConfigMusicSingleInequalityConditionRegister; // 0x1960
	internal static ConfigMusicSingleGreaterThanConditionRegister sConfigMusicSingleGreaterThanConditionRegister; // 0x1968
	internal static ConfigMusicSingleLessThanConditionRegister sConfigMusicSingleLessThanConditionRegister; // 0x1970
	internal static ConfigMusicSingleNoGreaterThanConditionRegister sConfigMusicSingleNoGreaterThanConditionRegister; // 0x1978
	internal static ConfigMusicSingleNoLessThanConditionRegister sConfigMusicSingleNoLessThanConditionRegister; // 0x1980
	internal static ConfigMusicDoubleConditionRegister sConfigMusicDoubleConditionRegister; // 0x1988
	internal static ConfigMusicDoubleEqualityConditionRegister sConfigMusicDoubleEqualityConditionRegister; // 0x1990
	internal static ConfigMusicDoubleInequalityConditionRegister sConfigMusicDoubleInequalityConditionRegister; // 0x1998
	internal static ConfigMusicDoubleGreaterThanConditionRegister sConfigMusicDoubleGreaterThanConditionRegister; // 0x19A0
	internal static ConfigMusicDoubleLessThanConditionRegister sConfigMusicDoubleLessThanConditionRegister; // 0x19A8
	internal static ConfigMusicDoubleNoGreaterThanConditionRegister sConfigMusicDoubleNoGreaterThanConditionRegister; // 0x19B0
	internal static ConfigMusicDoubleNoLessThanConditionRegister sConfigMusicDoubleNoLessThanConditionRegister; // 0x19B8
	internal static ConfigMusicBooleanConditionRegister sConfigMusicBooleanConditionRegister; // 0x19C0
	internal static ConfigMusicStringConditionRegister sConfigMusicStringConditionRegister; // 0x19C8
	internal static ConfigMusicStringEqualityConditionRegister sConfigMusicStringEqualityConditionRegister; // 0x19D0
	internal static ConfigMusicStringContainmentConditionRegister sConfigMusicStringContainmentConditionRegister; // 0x19D8
	internal static ConfigMusicUInt32ListConditionRegister sConfigMusicUInt32ListConditionRegister; // 0x19E0
	internal static ConfigMusicUInt32ListEmptinessConditionRegister sConfigMusicUInt32ListEmptinessConditionRegister; // 0x19E8
	internal static ConfigMusicUInt32ListMemberConditionRegister sConfigMusicUInt32ListMemberConditionRegister; // 0x19F0
	internal static ConfigMusicUInt32ListPresenceConditionRegister sConfigMusicUInt32ListPresenceConditionRegister; // 0x19F8
	internal static ConfigMusicUInt32ListAbsenceConditionRegister sConfigMusicUInt32ListAbsenceConditionRegister; // 0x1A00
	internal static ConfigMusicUInt32ListMultiMemberConditionRegister sConfigMusicUInt32ListMultiMemberConditionRegister; // 0x1A08
	internal static ConfigMusicUInt32ListAllPresenceConditionRegister sConfigMusicUInt32ListAllPresenceConditionRegister; // 0x1A10
	internal static ConfigMusicUInt32ListNonePresenceConditionRegister sConfigMusicUInt32ListNonePresenceConditionRegister; // 0x1A18
	internal static ConfigMusicUInt32ListPartialPresenceConditionRegister sConfigMusicUInt32ListPartialPresenceConditionRegister; // 0x1A20
	internal static Dictionary<string, ConfigMusicStimulusHandler> sConfigMusicStimulusHandlerDict; // 0x1A28
	internal static Dictionary<uint, ConfigMusicStimulusHandler> sConfigMusicStimulusHandlerTypeDict; // 0x1A30
	internal static ConfigMusicParameterizedStimulusHandlerRegister sConfigMusicParameterizedStimulusHandlerRegister; // 0x1A38
	internal static ConfigMusicIntStimulusHandlerRegister sConfigMusicIntStimulusHandlerRegister; // 0x1A40
	internal static ConfigMusicUIntStimulusHandlerRegister sConfigMusicUIntStimulusHandlerRegister; // 0x1A48
	internal static ConfigMusicFloatStimulusHandlerRegister sConfigMusicFloatStimulusHandlerRegister; // 0x1A50
	internal static ConfigMusicStringStimulusHandlerRegister sConfigMusicStringStimulusHandlerRegister; // 0x1A58
	internal static ConfigMusicMultiValueParameterizedStimulusHandlerRegister sConfigMusicMultiValueParameterizedStimulusHandlerRegister; // 0x1A60
	internal static ConfigMusicUIntMultiValueStimulusHandlerRegister sConfigMusicUIntMultiValueStimulusHandlerRegister; // 0x1A68
	internal static ConfigMusicUIntPresenceStimulusHandlerRegister sConfigMusicUIntPresenceStimulusHandlerRegister; // 0x1A70
	internal static ConfigMusicUIntAbsenceStimulusHandlerRegister sConfigMusicUIntAbsenceStimulusHandlerRegister; // 0x1A78
	internal static ConfigMusicStringMultiValueStimulusHandlerRegister sConfigMusicStringMultiValueStimulusHandlerRegister; // 0x1A80
	internal static ConfigMusicStringPresenceStimulusHandlerRegister sConfigMusicStringPresenceStimulusHandlerRegister; // 0x1A88
	internal static ConfigMusicStringAbsenceStimulusHandlerRegister sConfigMusicStringAbsenceStimulusHandlerRegister; // 0x1A90
	internal static Dictionary<string, ConfigLevelNpcBornPos> sConfigLevelNpcBornPosDict; // 0x1A98
	internal static Dictionary<uint, ConfigLevelNpcBornPos> sConfigLevelNpcBornPosTypeDict; // 0x1AA0
	internal static ConfigLevelNpcBornPosNoGroupRegister sConfigLevelNpcBornPosNoGroupRegister; // 0x1AA8
	internal static Dictionary<string, ConfigRecordActorBase> sConfigRecordActorBaseDict; // 0x1AB0
	internal static Dictionary<uint, ConfigRecordActorBase> sConfigRecordActorBaseTypeDict; // 0x1AB8
	internal static ConfigRecordEntityRegister sConfigRecordEntityRegister; // 0x1AC0
	internal static ConfigRecordEffectRegister sConfigRecordEffectRegister; // 0x1AC8
	internal static Dictionary<string, ConfigScenePoint> sConfigScenePointDict; // 0x1AD0
	internal static Dictionary<uint, ConfigScenePoint> sConfigScenePointTypeDict; // 0x1AD8
	internal static SceneTransPointRegister sSceneTransPointRegister; // 0x1AE0
	internal static DungeonEntryRegister sDungeonEntryRegister; // 0x1AE8
	internal static DungeonExitRegister sDungeonExitRegister; // 0x1AF0
	internal static DungeonWayPointRegister sDungeonWayPointRegister; // 0x1AF8
	internal static DungeonSlipRevivePointRegister sDungeonSlipRevivePointRegister; // 0x1B00
	internal static DungeonQuitPointRegister sDungeonQuitPointRegister; // 0x1B08
	internal static DungeonRewardPointRegister sDungeonRewardPointRegister; // 0x1B10
	internal static PersonalSceneJumpPointRegister sPersonalSceneJumpPointRegister; // 0x1B18
	internal static SceneBuildingPointRegister sSceneBuildingPointRegister; // 0x1B20
	internal static ConfigForceFieldRegister sConfigForceFieldRegister; // 0x1B28
	internal static ConfigConstForceFieldRegister sConfigConstForceFieldRegister; // 0x1B30
	internal static ConfigAirflowFieldRegister sConfigAirflowFieldRegister; // 0x1B38
	internal static ConfigFireGrassAirflowFieldRegister sConfigFireGrassAirflowFieldRegister; // 0x1B40
	internal static ConfigSpeedupFieldRegister sConfigSpeedupFieldRegister; // 0x1B48
	internal static ConfigCannonFieldRegister sConfigCannonFieldRegister; // 0x1B50
	internal static ConfigRiseFieldRegister sConfigRiseFieldRegister; // 0x1B58
	internal static ConfigLocalEntityRegister sConfigLocalEntityRegister; // 0x1B60
	internal static ConfigWindmillRegister sConfigWindmillRegister; // 0x1B68
	internal static ConfigLocalTriggerRegister sConfigLocalTriggerRegister; // 0x1B70
	internal static ConfigLoadingDoorRegister sConfigLoadingDoorRegister; // 0x1B78
	internal static Dictionary<string, ConfigBaseShape> sConfigBaseShapeDict; // 0x1B80
	internal static Dictionary<uint, ConfigBaseShape> sConfigBaseShapeTypeDict; // 0x1B88
	internal static ConfigShapeCircleRegister sConfigShapeCircleRegister; // 0x1B90
	internal static ConfigShapeRectRegister sConfigShapeRectRegister; // 0x1B98
	internal static ConfigShapeSectorRegister sConfigShapeSectorRegister; // 0x1BA0
	internal static ConfigShapePolygonRegister sConfigShapePolygonRegister; // 0x1BA8
	internal static ConfigShapeSphereRegister sConfigShapeSphereRegister; // 0x1BB0
	internal static Dictionary<string, TemplateParam> sTemplateParamDict; // 0x1BB8
	internal static Dictionary<uint, TemplateParam> sTemplateParamTypeDict; // 0x1BC0
	internal static TemplateParamFloatRegister sTemplateParamFloatRegister; // 0x1BC8
	internal static TemplateParamInt32Register sTemplateParamInt32Register; // 0x1BD0
	internal static TemplateParamStringRegister sTemplateParamStringRegister; // 0x1BD8
	internal static Dictionary<string, ConfigSkin> sConfigSkinDict; // 0x1BE0
	internal static Dictionary<uint, ConfigSkin> sConfigSkinTypeDict; // 0x1BE8
	internal static ConfigMonsterSkinRegister sConfigMonsterSkinRegister; // 0x1BF0
	internal static Dictionary<string, ConfigBaseStateIDInfo> sConfigBaseStateIDInfoDict; // 0x1BF8
	internal static Dictionary<uint, ConfigBaseStateIDInfo> sConfigBaseStateIDInfoTypeDict; // 0x1C00
	internal static ConfigNormalStateIDInfoRegister sConfigNormalStateIDInfoRegister; // 0x1C08
	internal static ConfigAvatarStateIDInfoRegister sConfigAvatarStateIDInfoRegister; // 0x1C10
	internal static ConfigMonsterStateIDInfoRegister sConfigMonsterStateIDInfoRegister; // 0x1C18
	internal static ConfigNpcStateIDInfoRegister sConfigNpcStateIDInfoRegister; // 0x1C20
	internal static Dictionary<string, ConfigBaseStateLayer> sConfigBaseStateLayerDict; // 0x1C28
	internal static Dictionary<uint, ConfigBaseStateLayer> sConfigBaseStateLayerTypeDict; // 0x1C30
	internal static ConfigNormalStateLayerRegister sConfigNormalStateLayerRegister; // 0x1C38
	internal static Dictionary<string, ConfigTalentMixin> sConfigTalentMixinDict; // 0x1C40
	internal static Dictionary<uint, ConfigTalentMixin> sConfigTalentMixinTypeDict; // 0x1C48
	internal static AddAbilityRegister sAddAbilityRegister; // 0x1C50
	internal static ModifyAbilityRegister sModifyAbilityRegister; // 0x1C58
	internal static UnlockTalentParamRegister sUnlockTalentParamRegister; // 0x1C60
	internal static UnlockControllerConditionsRegister sUnlockControllerConditionsRegister; // 0x1C68
	internal static ModifySkillCDRegister sModifySkillCDRegister; // 0x1C70
	internal static ModifySkillCostRegister sModifySkillCostRegister; // 0x1C78
	internal static ModifySkillPointRegister sModifySkillPointRegister; // 0x1C80
	internal static AddTalentExtraLevelRegister sAddTalentExtraLevelRegister; // 0x1C88
	internal static Dictionary<string, ConfigDialogGroup> sConfigDialogGroupDict; // 0x1C90
	internal static Dictionary<uint, ConfigDialogGroup> sConfigDialogGroupTypeDict; // 0x1C98
	internal static ConfigFreeDialogGroupRegister sConfigFreeDialogGroupRegister; // 0x1CA0
	internal static ConfigNarratorDialogGroupRegister sConfigNarratorDialogGroupRegister; // 0x1CA8
	internal static ConfigBlossomDialogGroupRegister sConfigBlossomDialogGroupRegister; // 0x1CB0
	internal static ConfigActivityDialogGroupRegister sConfigActivityDialogGroupRegister; // 0x1CB8
	internal static ConfigCoopDialogGroupRegister sConfigCoopDialogGroupRegister; // 0x1CC0
	internal static ConfigGadgetDialogGroupRegister sConfigGadgetDialogGroupRegister; // 0x1CC8
	internal static Dictionary<string, ConfigBaseInputAction> sConfigBaseInputActionDict; // 0x1CD0
	internal static Dictionary<uint, ConfigBaseInputAction> sConfigBaseInputActionTypeDict; // 0x1CD8
	internal static ConfigCompoundInputActionRegister sConfigCompoundInputActionRegister; // 0x1CE0
	internal static Dictionary<string, ConfigBaseWidget> sConfigBaseWidgetDict; // 0x1CE8
	internal static Dictionary<uint, ConfigBaseWidget> sConfigBaseWidgetTypeDict; // 0x1CF0
	internal static ConfigWidgetAnchorPointRegister sConfigWidgetAnchorPointRegister; // 0x1CF8
	internal static ConfigWidgetBonfireRegister sConfigWidgetBonfireRegister; // 0x1D00
	internal static ConfigWidgetCondenseResinRegister sConfigWidgetCondenseResinRegister; // 0x1D08
	internal static ConfigWidgetLunchBoxRegister sConfigWidgetLunchBoxRegister; // 0x1D10
	internal static ConfigWidgetOneoffGatherPointDetectorRegister sConfigWidgetOneoffGatherPointDetectorRegister; // 0x1D18
	internal static ConfigWidgetClientDetectorRegister sConfigWidgetClientDetectorRegister; // 0x1D20
	internal static ConfigWidgetClientCollectorRegister sConfigWidgetClientCollectorRegister; // 0x1D28
	internal static ConfigWidgetAttachAvatarRegister sConfigWidgetAttachAvatarRegister; // 0x1D30
	internal static ConfigWidgetTreasureMapDetectorRegister sConfigWidgetTreasureMapDetectorRegister; // 0x1D38
	internal static ConfigWidgetGadgetBuilderRegister sConfigWidgetGadgetBuilderRegister; // 0x1D40
	internal static ConfigWidgetTakePhotoRegister sConfigWidgetTakePhotoRegister; // 0x1D48
	internal static ConfigWidgetBlessingCameraRegister sConfigWidgetBlessingCameraRegister; // 0x1D50
	internal static ConfigWidgetMiracleRingRegister sConfigWidgetMiracleRingRegister; // 0x1D58
	internal static ConfigWidgetWaterSpriteRegister sConfigWidgetWaterSpriteRegister; // 0x1D60
	internal static ConfigWidgetWaterSpriteToyRegister sConfigWidgetWaterSpriteToyRegister; // 0x1D68
	internal static ConfigWidgetAbilityGroupGeneratorRegister sConfigWidgetAbilityGroupGeneratorRegister; // 0x1D70
	internal static ConfigWidgetOpenPageRegister sConfigWidgetOpenPageRegister; // 0x1D78
	internal static Dictionary<string, ConfigWidgetAction> sConfigWidgetActionDict; // 0x1D80
	internal static Dictionary<uint, ConfigWidgetAction> sConfigWidgetActionTypeDict; // 0x1D88
	internal static ConfigWidgetAction_PrintDebugRegister sConfigWidgetAction_PrintDebugRegister; // 0x1D90
	internal static ConfigWidgetAction_CreateLocalGadgetRegister sConfigWidgetAction_CreateLocalGadgetRegister; // 0x1D98
	internal static ConfigWidgetAction_CreateSeverGadgetRegister sConfigWidgetAction_CreateSeverGadgetRegister; // 0x1DA0
	internal static ConfigWidgetAction_AddAbilityGroupRegister sConfigWidgetAction_AddAbilityGroupRegister; // 0x1DA8
	internal static ConfigWidgetAction_AddDynamicValueRegister sConfigWidgetAction_AddDynamicValueRegister; // 0x1DB0
	internal static ConfigWidgetAction_RemoveDynamicValueRegister sConfigWidgetAction_RemoveDynamicValueRegister; // 0x1DB8
	internal static ConfigWidgetAction_TakePhotoRegister sConfigWidgetAction_TakePhotoRegister; // 0x1DC0
	internal static Dictionary<string, ConfigWidgetPredict> sConfigWidgetPredictDict; // 0x1DC8
	internal static Dictionary<uint, ConfigWidgetPredict> sConfigWidgetPredictTypeDict; // 0x1DD0
	internal static ConfigWidgetPredict_CollisionDetectRegister sConfigWidgetPredict_CollisionDetectRegister; // 0x1DD8
	internal static ConfigWidgetPredict_HasDynamicValueRegister sConfigWidgetPredict_HasDynamicValueRegister; // 0x1DE0
	internal static ConfigWidgetPredict_CheckEqualDynamicValueRegister sConfigWidgetPredict_CheckEqualDynamicValueRegister; // 0x1DE8
	internal static ConfigWidgetPredict_CheckCurrentEquipRegister sConfigWidgetPredict_CheckCurrentEquipRegister; // 0x1DF0
	internal static ConfigWidgetPredict_AlwaysPassRegister sConfigWidgetPredict_AlwaysPassRegister; // 0x1DF8
	internal static Dictionary<string, ConfigBaseWidgetToy> sConfigBaseWidgetToyDict; // 0x1E00
	internal static Dictionary<uint, ConfigBaseWidgetToy> sConfigBaseWidgetToyTypeDict; // 0x1E08
	internal static ConfigWidgetToyGeneralRegister sConfigWidgetToyGeneralRegister; // 0x1E10
	internal static ConfigWidgetToyAnchorPointRegister sConfigWidgetToyAnchorPointRegister; // 0x1E18
	internal static ConfigWidgetToyBonfireRegister sConfigWidgetToyBonfireRegister; // 0x1E20
	internal static ConfigWidgetToyLunchBoxRegister sConfigWidgetToyLunchBoxRegister; // 0x1E28
	internal static ConfigWidgetToyClintDetectorRegister sConfigWidgetToyClintDetectorRegister; // 0x1E30
	internal static ConfigWidgetToyOneoffGatherPointDetectorRegister sConfigWidgetToyOneoffGatherPointDetectorRegister; // 0x1E38
	internal static ConfigWidgetToyClintCollectorRegister sConfigWidgetToyClintCollectorRegister; // 0x1E40
	internal static ConfigWidgetToyAttachAvatarRegister sConfigWidgetToyAttachAvatarRegister; // 0x1E48
	internal static ConfigWidgetToyTreasureMapDetectorRegister sConfigWidgetToyTreasureMapDetectorRegister; // 0x1E50
	internal static ConfigWidgetToyAbilityGroupGeneratorRegister sConfigWidgetToyAbilityGroupGeneratorRegister; // 0x1E58
	internal static ConfigWidgetToyBlessingCameraRegister sConfigWidgetToyBlessingCameraRegister; // 0x1E60
	internal static ConfigWidgetToyGadgetBuilderRegister sConfigWidgetToyGadgetBuilderRegister; // 0x1E68
	internal static ConfigWidgetToyMiracleRingRegister sConfigWidgetToyMiracleRingRegister; // 0x1E70
	internal static ConfigWidgetToyOpenPageRegister sConfigWidgetToyOpenPageRegister; // 0x1E78
	internal static ConfigWidgetToyWaterSpriteRegister sConfigWidgetToyWaterSpriteRegister; // 0x1E80
	internal static ConfigWidgetToyTakePhotoRegister sConfigWidgetToyTakePhotoRegister; // 0x1E88
	internal static ConfigWidgetToyCreateGadgetBaseRegister sConfigWidgetToyCreateGadgetBaseRegister; // 0x1E90
	internal static ConfigWidgetToyAdeptiAbodeRegister sConfigWidgetToyAdeptiAbodeRegister; // 0x1E98

	// Constructors
	static TypeTool() {} // 0x000000018174FA30-0x000000018175C730

	// Methods
	// [XID] // 0x00000001896CB1F0-0x00000001896CB210
	private static void Init() {} // 0x000000018174A470-0x000000018174A690
	// [XID] // 0x0000000189B0E5F0-0x0000000189B0E610
	private static void RegisterTypeIndex(System.Type type, byte index) {} // 0x000000018174F040-0x000000018174F170
	// [XID] // 0x00000001896DA2A0-0x00000001896DA2C0
	public static byte GetTypeIndex(System.Type type) => default; // 0x0000000181747FF0-0x0000000181748170
	// [XID] // 0x00000001896E18C0-0x00000001896E18E0
	public static bool GetTypeFromIndex(byte index, out System.Type type) {
		type = default;
		return default;
	} // 0x000000018174A690-0x000000018174A810
	// [IDTag] // 0x00000001896E8DF0-0x00000001896E8E30
	// [XID] // 0x00000001896E8DF0-0x00000001896E8E30
	internal static ConfigAbility createConfigAbility(string name) => default; // 0x000000018174E320-0x000000018174E430
	// [IDTag] // 0x00000001896F3310-0x00000001896F3350
	// [XID] // 0x00000001896F3310-0x00000001896F3350
	internal static ConfigAbility createConfigAbility(uint typeIndex, bool useObjectPool) => default; // 0x000000018174E430-0x000000018174E550
	// [IDTag] // 0x00000001896FDB90-0x00000001896FDBD0
	// [XID] // 0x00000001896FDB90-0x00000001896FDBD0
	internal static ConfigAbilityAction createConfigAbilityAction(string name) => default; // 0x000000018174DC90-0x000000018174DDA0
	// [IDTag] // 0x0000000189707F40-0x0000000189707F80
	// [XID] // 0x0000000189707F40-0x0000000189707F80
	internal static ConfigAbilityAction createConfigAbilityAction(uint typeIndex, bool useObjectPool) => default; // 0x000000018174DDA0-0x000000018174DEC0
	// [IDTag] // 0x0000000189712830-0x0000000189712870
	// [XID] // 0x0000000189712830-0x0000000189712870
	internal static SelectTargets createSelectTargets(string name) => default; // 0x000000018174E780-0x000000018174E890
	// [IDTag] // 0x000000018971CFD0-0x000000018971D010
	// [XID] // 0x000000018971CFD0-0x000000018971D010
	internal static SelectTargets createSelectTargets(uint typeIndex, bool useObjectPool) => default; // 0x000000018174E890-0x000000018174E9B0
	// [IDTag] // 0x0000000189727620-0x0000000189727660
	// [XID] // 0x0000000189727620-0x0000000189727660
	internal static ConfigAbilityMixin createConfigAbilityMixin(string name) => default; // 0x0000000181748D80-0x0000000181748E90
	// [IDTag] // 0x0000000189731B40-0x0000000189731B80
	// [XID] // 0x0000000189731B40-0x0000000189731B80
	internal static ConfigAbilityMixin createConfigAbilityMixin(uint typeIndex, bool useObjectPool) => default; // 0x0000000181748C60-0x0000000181748D80
	// [IDTag] // 0x000000018973C5C0-0x000000018973C600
	// [XID] // 0x000000018973C5C0-0x000000018973C600
	internal static TileShapeInfo createTileShapeInfo(string name) => default; // 0x000000018174F4C0-0x000000018174F5D0
	// [IDTag] // 0x0000000189746D40-0x0000000189746D80
	// [XID] // 0x0000000189746D40-0x0000000189746D80
	internal static TileShapeInfo createTileShapeInfo(uint typeIndex, bool useObjectPool) => default; // 0x000000018174F3A0-0x000000018174F4C0
	// [IDTag] // 0x0000000189751150-0x0000000189751190
	// [XID] // 0x0000000189751150-0x0000000189751190
	internal static ConfigAbilityPredicate createConfigAbilityPredicate(string name) => default; // 0x000000018174BAB0-0x000000018174BBC0
	// [IDTag] // 0x000000018975B6B0-0x000000018975B6F0
	// [XID] // 0x000000018975B6B0-0x000000018975B6F0
	internal static ConfigAbilityPredicate createConfigAbilityPredicate(uint typeIndex, bool useObjectPool) => default; // 0x000000018174B990-0x000000018174BAB0
	// [IDTag] // 0x0000000189765F30-0x0000000189765F70
	// [XID] // 0x0000000189765F30-0x0000000189765F70
	internal static ConfigAbilityTask createConfigAbilityTask(string name) => default; // 0x0000000181747850-0x0000000181747960
	// [IDTag] // 0x00000001897705F0-0x0000000189770630
	// [XID] // 0x00000001897705F0-0x0000000189770630
	internal static ConfigAbilityTask createConfigAbilityTask(uint typeIndex, bool useObjectPool) => default; // 0x0000000181747730-0x0000000181747850
	// [IDTag] // 0x000000018977AD10-0x000000018977AD50
	// [XID] // 0x000000018977AD10-0x000000018977AD50
	internal static ConfigAIThreatScoreBaseSetting createConfigAIThreatScoreBaseSetting(string name) => default; // 0x000000018174EAD0-0x000000018174EBE0
	// [IDTag] // 0x0000000189785640-0x0000000189785680
	// [XID] // 0x0000000189785640-0x0000000189785680
	internal static ConfigAIThreatScoreBaseSetting createConfigAIThreatScoreBaseSetting(uint typeIndex, bool useObjectPool) => default; // 0x000000018174E9B0-0x000000018174EAD0
	// [IDTag] // 0x000000018978FB80-0x000000018978FBC0
	// [XID] // 0x000000018978FB80-0x000000018978FBC0
	internal static ConfigAITacticBaseSetting createConfigAITacticBaseSetting(string name) => default; // 0x000000018174D2C0-0x000000018174D3D0
	// [IDTag] // 0x000000018979A1C0-0x000000018979A200
	// [XID] // 0x000000018979A1C0-0x000000018979A200
	internal static ConfigAITacticBaseSetting createConfigAITacticBaseSetting(uint typeIndex, bool useObjectPool) => default; // 0x000000018174D1A0-0x000000018174D2C0
	// [IDTag] // 0x00000001897A52A0-0x00000001897A52E0
	// [XID] // 0x00000001897A52A0-0x00000001897A52E0
	internal static ConfigBaseAttackPattern createConfigBaseAttackPattern(string name) => default; // 0x000000018174DEC0-0x000000018174DFD0
	// [IDTag] // 0x00000001897AFA20-0x00000001897AFA60
	// [XID] // 0x00000001897AFA20-0x00000001897AFA60
	internal static ConfigBaseAttackPattern createConfigBaseAttackPattern(uint typeIndex, bool useObjectPool) => default; // 0x000000018174DFD0-0x000000018174E0F0
	// [IDTag] // 0x00000001897BA350-0x00000001897BA390
	// [XID] // 0x00000001897BA350-0x00000001897BA390
	internal static ConfigAudioEventCullingRuleBase createConfigAudioEventCullingRuleBase(string name) => default; // 0x000000018174CA00-0x000000018174CB10
	// [IDTag] // 0x00000001897C5480-0x00000001897C54C0
	// [XID] // 0x00000001897C5480-0x00000001897C54C0
	internal static ConfigAudioEventCullingRuleBase createConfigAudioEventCullingRuleBase(uint typeIndex, bool useObjectPool) => default; // 0x000000018174C8E0-0x000000018174CA00
	// [IDTag] // 0x00000001897CFB90-0x00000001897CFBD0
	// [XID] // 0x00000001897CFB90-0x00000001897CFBD0
	internal static ConfigAudioOperation createConfigAudioOperation(string name) => default; // 0x000000018174CE60-0x000000018174CF70
	// [IDTag] // 0x00000001897DA7C0-0x00000001897DA800
	// [XID] // 0x00000001897DA7C0-0x00000001897DA800
	internal static ConfigAudioOperation createConfigAudioOperation(uint typeIndex, bool useObjectPool) => default; // 0x000000018174CD40-0x000000018174CE60
	// [IDTag] // 0x00000001897E4AC0-0x00000001897E4B00
	// [XID] // 0x00000001897E4AC0-0x00000001897E4B00
	internal static AudioSettingSlider createAudioSettingSlider(string name) => default; // 0x0000000181749980-0x0000000181749A90
	// [IDTag] // 0x00000001897EF620-0x00000001897EF660
	// [XID] // 0x00000001897EF620-0x00000001897EF660
	internal static AudioSettingSlider createAudioSettingSlider(uint typeIndex, bool useObjectPool) => default; // 0x0000000181749A90-0x0000000181749BB0
	// [IDTag] // 0x00000001897FA170-0x00000001897FA1B0
	// [XID] // 0x00000001897FA170-0x00000001897FA1B0
	internal static ConfigClimateInfoBase createConfigClimateInfoBase(string name) => default; // 0x000000018174F6F0-0x000000018174F800
	// [IDTag] // 0x00000001898045E0-0x0000000189804620
	// [XID] // 0x00000001898045E0-0x0000000189804620
	internal static ConfigClimateInfoBase createConfigClimateInfoBase(uint typeIndex, bool useObjectPool) => default; // 0x000000018174F5D0-0x000000018174F6F0
	// [IDTag] // 0x000000018980EC80-0x000000018980ECC0
	// [XID] // 0x000000018980EC80-0x000000018980ECC0
	internal static ConfigBeHitBlendShake createConfigBeHitBlendShake(string name) => default; // 0x000000018174AC70-0x000000018174AD80
	// [IDTag] // 0x0000000189819830-0x0000000189819870
	// [XID] // 0x0000000189819830-0x0000000189819870
	internal static ConfigBeHitBlendShake createConfigBeHitBlendShake(uint typeIndex, bool useObjectPool) => default; // 0x000000018174AD80-0x000000018174AEA0
	// [IDTag] // 0x00000001898239C0-0x0000000189823A00
	// [XID] // 0x00000001898239C0-0x0000000189823A00
	internal static ConfigEffectAttachShape createConfigEffectAttachShape(string name) => default; // 0x00000001817486F0-0x0000000181748800
	// [IDTag] // 0x000000018982E180-0x000000018982E1C0
	// [XID] // 0x000000018982E180-0x000000018982E1C0
	internal static ConfigEffectAttachShape createConfigEffectAttachShape(uint typeIndex, bool useObjectPool) => default; // 0x00000001817485D0-0x00000001817486F0
	// [IDTag] // 0x0000000189838800-0x0000000189838840
	// [XID] // 0x0000000189838800-0x0000000189838840
	internal static ConfigBillboard createConfigBillboard(string name) => default; // 0x0000000181748290-0x00000001817483A0
	// [IDTag] // 0x0000000189842F50-0x0000000189842F90
	// [XID] // 0x0000000189842F50-0x0000000189842F90
	internal static ConfigBillboard createConfigBillboard(uint typeIndex, bool useObjectPool) => default; // 0x0000000181748170-0x0000000181748290
	// [IDTag] // 0x000000018984D220-0x000000018984D260
	// [XID] // 0x000000018984D220-0x000000018984D260
	internal static ConfigCoopBaseNode createConfigCoopBaseNode(string name) => default; // 0x000000018174AB60-0x000000018174AC70
	// [IDTag] // 0x00000001898572E0-0x0000000189857320
	// [XID] // 0x00000001898572E0-0x0000000189857320
	internal static ConfigCoopBaseNode createConfigCoopBaseNode(uint typeIndex, bool useObjectPool) => default; // 0x000000018174AA40-0x000000018174AB60
	// [IDTag] // 0x0000000189861730-0x0000000189861770
	// [XID] // 0x0000000189861730-0x0000000189861770
	internal static ConfigBaseCutscene createConfigBaseCutscene(string name) => default; // 0x000000018174A130-0x000000018174A240
	// [IDTag] // 0x000000018986BEF0-0x000000018986BF30
	// [XID] // 0x000000018986BEF0-0x000000018986BF30
	internal static ConfigBaseCutscene createConfigBaseCutscene(uint typeIndex, bool useObjectPool) => default; // 0x000000018174A010-0x000000018174A130
	// [IDTag] // 0x00000001898762F0-0x0000000189876330
	// [XID] // 0x00000001898762F0-0x0000000189876330
	internal static DebugBlletinInfo createDebugBlletinInfo(string name) => default; // 0x000000018174CB10-0x000000018174CC20
	// [IDTag] // 0x0000000189880A90-0x0000000189880AD0
	// [XID] // 0x0000000189880A90-0x0000000189880AD0
	internal static DebugBlletinInfo createDebugBlletinInfo(uint typeIndex, bool useObjectPool) => default; // 0x000000018174CC20-0x000000018174CD40
	// [IDTag] // 0x000000018988AD70-0x000000018988ADB0
	// [XID] // 0x000000018988AD70-0x000000018988ADB0
	internal static ConfigBornDirectionType createConfigBornDirectionType(string name) => default; // 0x000000018174EE10-0x000000018174EF20
	// [IDTag] // 0x0000000189895100-0x0000000189895140
	// [XID] // 0x0000000189895100-0x0000000189895140
	internal static ConfigBornDirectionType createConfigBornDirectionType(uint typeIndex, bool useObjectPool) => default; // 0x000000018174EF20-0x000000018174F040
	// [IDTag] // 0x000000018989F360-0x000000018989F3A0
	// [XID] // 0x000000018989F360-0x000000018989F3A0
	internal static BornRandom createBornRandom(string name) => default; // 0x000000018174C480-0x000000018174C590
	// [IDTag] // 0x00000001898A9B60-0x00000001898A9BA0
	// [XID] // 0x00000001898A9B60-0x00000001898A9BA0
	internal static BornRandom createBornRandom(uint typeIndex, bool useObjectPool) => default; // 0x000000018174C590-0x000000018174C6B0
	// [IDTag] // 0x00000001898B4230-0x00000001898B4270
	// [XID] // 0x00000001898B4230-0x00000001898B4270
	internal static ConfigBornType createConfigBornType(string name) => default; // 0x000000018174DB80-0x000000018174DC90
	// [IDTag] // 0x00000001898BEAA0-0x00000001898BEAE0
	// [XID] // 0x00000001898BEAA0-0x00000001898BEAE0
	internal static ConfigBornType createConfigBornType(uint typeIndex, bool useObjectPool) => default; // 0x000000018174DA60-0x000000018174DB80
	// [IDTag] // 0x00000001898C9520-0x00000001898C9560
	// [XID] // 0x00000001898C9520-0x00000001898C9560
	internal static ConfigActionPointSelectType createConfigActionPointSelectType(string name) => default; // 0x000000018174C020-0x000000018174C130
	// [IDTag] // 0x00000001898D3B30-0x00000001898D3B70
	// [XID] // 0x00000001898D3B30-0x00000001898D3B70
	internal static ConfigActionPointSelectType createConfigActionPointSelectType(uint typeIndex, bool useObjectPool) => default; // 0x000000018174C130-0x000000018174C250
	// [IDTag] // 0x00000001898DEB50-0x00000001898DEB90
	// [XID] // 0x00000001898DEB50-0x00000001898DEB90
	internal static ConfigHeadControl createConfigHeadControl(string name) => default; // 0x0000000181747DC0-0x0000000181747ED0
	// [IDTag] // 0x00000001898E9670-0x00000001898E96B0
	// [XID] // 0x00000001898E9670-0x00000001898E96B0
	internal static ConfigHeadControl createConfigHeadControl(uint typeIndex, bool useObjectPool) => default; // 0x0000000181747ED0-0x0000000181747FF0
	// [IDTag] // 0x00000001898F3BA0-0x00000001898F3BE0
	// [XID] // 0x00000001898F3BA0-0x00000001898F3BE0
	internal static ConfigEntity createConfigEntity(string name) => default; // 0x000000018174B880-0x000000018174B990
	// [IDTag] // 0x00000001898FE460-0x00000001898FE4A0
	// [XID] // 0x00000001898FE460-0x00000001898FE4A0
	internal static ConfigEntity createConfigEntity(uint typeIndex, bool useObjectPool) => default; // 0x000000018174B760-0x000000018174B880
	// [IDTag] // 0x0000000189908D30-0x0000000189908D70
	// [XID] // 0x0000000189908D30-0x0000000189908D70
	internal static ConfigGadgetPredicate createConfigGadgetPredicate(string name) => default; // 0x00000001817490C0-0x00000001817491D0
	// [IDTag] // 0x00000001899136C0-0x0000000189913700
	// [XID] // 0x00000001899136C0-0x0000000189913700
	internal static ConfigGadgetPredicate createConfigGadgetPredicate(uint typeIndex, bool useObjectPool) => default; // 0x00000001817491D0-0x00000001817492F0
	// [IDTag] // 0x000000018991DE70-0x000000018991DEB0
	// [XID] // 0x000000018991DE70-0x000000018991DEB0
	internal static ConfigGadgetStateAction createConfigGadgetStateAction(string name) => default; // 0x000000018174E550-0x000000018174E660
	// [IDTag] // 0x00000001899287B0-0x00000001899287F0
	// [XID] // 0x00000001899287B0-0x00000001899287F0
	internal static ConfigGadgetStateAction createConfigGadgetStateAction(uint typeIndex, bool useObjectPool) => default; // 0x000000018174E660-0x000000018174E780
	// [IDTag] // 0x0000000189932E20-0x0000000189932E60
	// [XID] // 0x0000000189932E20-0x0000000189932E60
	internal static ConfigControlPart createConfigControlPart(string name) => default; // 0x0000000181749640-0x0000000181749750
	// [IDTag] // 0x000000018993D6A0-0x000000018993D6E0
	// [XID] // 0x000000018993D6A0-0x000000018993D6E0
	internal static ConfigControlPart createConfigControlPart(uint typeIndex, bool useObjectPool) => default; // 0x0000000181749520-0x0000000181749640
	// [IDTag] // 0x00000001899479B0-0x00000001899479F0
	// [XID] // 0x00000001899479B0-0x00000001899479F0
	internal static ConfigEntityAudio createConfigEntityAudio(string name) => default; // 0x000000018174B530-0x000000018174B640
	// [IDTag] // 0x0000000189952310-0x0000000189952350
	// [XID] // 0x0000000189952310-0x0000000189952350
	internal static ConfigEntityAudio createConfigEntityAudio(uint typeIndex, bool useObjectPool) => default; // 0x000000018174B640-0x000000018174B760
	// [IDTag] // 0x000000018995C7E0-0x000000018995C820
	// [XID] // 0x000000018995C7E0-0x000000018995C820
	internal static ConfigBaseGadgetTriggerAction createConfigBaseGadgetTriggerAction(string name) => default; // 0x0000000181747500-0x0000000181747610
	// [IDTag] // 0x0000000189967270-0x00000001899672B0
	// [XID] // 0x0000000189967270-0x00000001899672B0
	internal static ConfigBaseGadgetTriggerAction createConfigBaseGadgetTriggerAction(uint typeIndex, bool useObjectPool) => default; // 0x0000000181747610-0x0000000181747730
	// [IDTag] // 0x0000000189971D70-0x0000000189971DB0
	// [XID] // 0x0000000189971D70-0x0000000189971DB0
	internal static ConfigGadgetPattern createConfigGadgetPattern(string name) => default; // 0x00000001817492F0-0x0000000181749400
	// [IDTag] // 0x000000018997BEA0-0x000000018997BEE0
	// [XID] // 0x000000018997BEA0-0x000000018997BEE0
	internal static ConfigGadgetPattern createConfigGadgetPattern(uint typeIndex, bool useObjectPool) => default; // 0x0000000181749400-0x0000000181749520
	// [IDTag] // 0x0000000189986710-0x0000000189986750
	// [XID] // 0x0000000189986710-0x0000000189986750
	internal static ConfigBaseGuide createConfigBaseGuide(string name) => default; // 0x0000000181748A30-0x0000000181748B40
	// [IDTag] // 0x0000000189991510-0x0000000189991550
	// [XID] // 0x0000000189991510-0x0000000189991550
	internal static ConfigBaseGuide createConfigBaseGuide(uint typeIndex, bool useObjectPool) => default; // 0x0000000181748B40-0x0000000181748C60
	// [IDTag] // 0x000000018999BFB0-0x000000018999BFF0
	// [XID] // 0x000000018999BFB0-0x000000018999BFF0
	internal static ConfigBaseInterAction createConfigBaseInterAction(string name) => default; // 0x00000001817483A0-0x00000001817484B0
	// [IDTag] // 0x00000001899A6970-0x00000001899A69B0
	// [XID] // 0x00000001899A6970-0x00000001899A69B0
	internal static ConfigBaseInterAction createConfigBaseInterAction(uint typeIndex, bool useObjectPool) => default; // 0x00000001817484B0-0x00000001817485D0
	// [IDTag] // 0x00000001899B1400-0x00000001899B1440
	// [XID] // 0x00000001899B1400-0x00000001899B1440
	internal static ConfigLCBaseIntee createConfigLCBaseIntee(string name) => default; // 0x000000018174B300-0x000000018174B410
	// [IDTag] // 0x00000001899BB870-0x00000001899BB8B0
	// [XID] // 0x00000001899BB870-0x00000001899BB8B0
	internal static ConfigLCBaseIntee createConfigLCBaseIntee(uint typeIndex, bool useObjectPool) => default; // 0x000000018174B410-0x000000018174B530
	// [IDTag] // 0x00000001899C6460-0x00000001899C64A0
	// [XID] // 0x00000001899C6460-0x00000001899C64A0
	internal static IndicatorCondition createIndicatorCondition(string name) => default; // 0x0000000181748800-0x0000000181748910
	// [IDTag] // 0x00000001899D09E0-0x00000001899D0A20
	// [XID] // 0x00000001899D09E0-0x00000001899D0A20
	internal static IndicatorCondition createIndicatorCondition(uint typeIndex, bool useObjectPool) => default; // 0x0000000181748910-0x0000000181748A30
	// [IDTag] // 0x00000001899DAE20-0x00000001899DAE60
	// [XID] // 0x00000001899DAE20-0x00000001899DAE60
	internal static ConfigLBaseMark createConfigLBaseMark(string name) => default; // 0x000000018174C370-0x000000018174C480
	// [IDTag] // 0x00000001899E5A70-0x00000001899E5AB0
	// [XID] // 0x00000001899E5A70-0x00000001899E5AB0
	internal static ConfigLBaseMark createConfigLBaseMark(uint typeIndex, bool useObjectPool) => default; // 0x000000018174C250-0x000000018174C370
	// [IDTag] // 0x00000001899EFF00-0x00000001899EFF40
	// [XID] // 0x00000001899EFF00-0x00000001899EFF40
	internal static ConfigVBaseMark createConfigVBaseMark(string name) => default; // 0x000000018174D4F0-0x000000018174D600
	// [IDTag] // 0x00000001899FA550-0x00000001899FA590
	// [XID] // 0x00000001899FA550-0x00000001899FA590
	internal static ConfigVBaseMark createConfigVBaseMark(uint typeIndex, bool useObjectPool) => default; // 0x000000018174D3D0-0x000000018174D4F0
	// [IDTag] // 0x0000000189A04A00-0x0000000189A04A40
	// [XID] // 0x0000000189A04A00-0x0000000189A04A40
	internal static ConfigMove createConfigMove(string name) => default; // 0x0000000181747CB0-0x0000000181747DC0
	// [IDTag] // 0x0000000189A0EF20-0x0000000189A0EF60
	// [XID] // 0x0000000189A0EF20-0x0000000189A0EF60
	internal static ConfigMove createConfigMove(uint typeIndex, bool useObjectPool) => default; // 0x0000000181747B90-0x0000000181747CB0
	// [IDTag] // 0x0000000189A194D0-0x0000000189A19510
	// [XID] // 0x0000000189A194D0-0x0000000189A19510
	internal static ConfigMoveCorrection createConfigMoveCorrection(string name) => default; // 0x000000018174F800-0x000000018174F910
	// [IDTag] // 0x0000000189A23B70-0x0000000189A23BB0
	// [XID] // 0x0000000189A23B70-0x0000000189A23BB0
	internal static ConfigMoveCorrection createConfigMoveCorrection(uint typeIndex, bool useObjectPool) => default; // 0x000000018174F910-0x000000018174FA30
	// [IDTag] // 0x0000000189A2DDC0-0x0000000189A2DE00
	// [XID] // 0x0000000189A2DDC0-0x0000000189A2DE00
	internal static ConfigBulletMoveAngle createConfigBulletMoveAngle(string name) => default; // 0x000000018174D720-0x000000018174D830
	// [IDTag] // 0x0000000189A388F0-0x0000000189A38930
	// [XID] // 0x0000000189A388F0-0x0000000189A38930
	internal static ConfigBulletMoveAngle createConfigBulletMoveAngle(uint typeIndex, bool useObjectPool) => default; // 0x000000018174D600-0x000000018174D720
	// [IDTag] // 0x0000000189A43060-0x0000000189A430A0
	// [XID] // 0x0000000189A43060-0x0000000189A430A0
	internal static ConfigMusicCondition createConfigMusicCondition(string name) => default; // 0x0000000181749870-0x0000000181749980
	// [IDTag] // 0x0000000189A4D530-0x0000000189A4D570
	// [XID] // 0x0000000189A4D530-0x0000000189A4D570
	internal static ConfigMusicCondition createConfigMusicCondition(uint typeIndex, bool useObjectPool) => default; // 0x0000000181749750-0x0000000181749870
	// [IDTag] // 0x0000000189A57BA0-0x0000000189A57BE0
	// [XID] // 0x0000000189A57BA0-0x0000000189A57BE0
	internal static ConfigMusicStimulusHandler createConfigMusicStimulusHandler(string name) => default; // 0x000000018174BCE0-0x000000018174BDF0
	// [IDTag] // 0x0000000189A62400-0x0000000189A62440
	// [XID] // 0x0000000189A62400-0x0000000189A62440
	internal static ConfigMusicStimulusHandler createConfigMusicStimulusHandler(uint typeIndex, bool useObjectPool) => default; // 0x000000018174BBC0-0x000000018174BCE0
	// [IDTag] // 0x0000000189A6CF30-0x0000000189A6CF70
	// [XID] // 0x0000000189A6CF30-0x0000000189A6CF70
	internal static ConfigLevelNpcBornPos createConfigLevelNpcBornPos(string name) => default; // 0x000000018174E0F0-0x000000018174E200
	// [IDTag] // 0x0000000189A77760-0x0000000189A777A0
	// [XID] // 0x0000000189A77760-0x0000000189A777A0
	internal static ConfigLevelNpcBornPos createConfigLevelNpcBornPos(uint typeIndex, bool useObjectPool) => default; // 0x000000018174E200-0x000000018174E320
	// [IDTag] // 0x0000000189A82220-0x0000000189A82260
	// [XID] // 0x0000000189A82220-0x0000000189A82260
	internal static ConfigRecordActorBase createConfigRecordActorBase(string name) => default; // 0x000000018174CF70-0x000000018174D080
	// [IDTag] // 0x0000000189A8CD00-0x0000000189A8CD40
	// [XID] // 0x0000000189A8CD00-0x0000000189A8CD40
	internal static ConfigRecordActorBase createConfigRecordActorBase(uint typeIndex, bool useObjectPool) => default; // 0x000000018174D080-0x000000018174D1A0
	// [IDTag] // 0x0000000189A97250-0x0000000189A97290
	// [XID] // 0x0000000189A97250-0x0000000189A97290
	internal static ConfigScenePoint createConfigScenePoint(string name) => default; // 0x0000000181747960-0x0000000181747A70
	// [IDTag] // 0x0000000189AA1560-0x0000000189AA15A0
	// [XID] // 0x0000000189AA1560-0x0000000189AA15A0
	internal static ConfigScenePoint createConfigScenePoint(uint typeIndex, bool useObjectPool) => default; // 0x0000000181747A70-0x0000000181747B90
	// [IDTag] // 0x0000000189AABEF0-0x0000000189AABF30
	// [XID] // 0x0000000189AABEF0-0x0000000189AABF30
	internal static ConfigBaseShape createConfigBaseShape(string name) => default; // 0x000000018174BF10-0x000000018174C020
	// [IDTag] // 0x0000000189AB6830-0x0000000189AB6870
	// [XID] // 0x0000000189AB6830-0x0000000189AB6870
	internal static ConfigBaseShape createConfigBaseShape(uint typeIndex, bool useObjectPool) => default; // 0x000000018174BDF0-0x000000018174BF10
	// [IDTag] // 0x0000000189AC1250-0x0000000189AC1290
	// [XID] // 0x0000000189AC1250-0x0000000189AC1290
	internal static TemplateParam createTemplateParam(string name) => default; // 0x000000018174D950-0x000000018174DA60
	// [IDTag] // 0x0000000189ACBB30-0x0000000189ACBB70
	// [XID] // 0x0000000189ACBB30-0x0000000189ACBB70
	internal static TemplateParam createTemplateParam(uint typeIndex, bool useObjectPool) => default; // 0x000000018174D830-0x000000018174D950
	// [IDTag] // 0x0000000189AD6A10-0x0000000189AD6A50
	// [XID] // 0x0000000189AD6A10-0x0000000189AD6A50
	internal static ConfigSkin createConfigSkin(string name) => default; // 0x000000018174A240-0x000000018174A350
	// [IDTag] // 0x0000000189AE1470-0x0000000189AE14B0
	// [XID] // 0x0000000189AE1470-0x0000000189AE14B0
	internal static ConfigSkin createConfigSkin(uint typeIndex, bool useObjectPool) => default; // 0x000000018174A350-0x000000018174A470
	// [IDTag] // 0x0000000189AEBB50-0x0000000189AEBB90
	// [XID] // 0x0000000189AEBB50-0x0000000189AEBB90
	internal static ConfigBaseStateIDInfo createConfigBaseStateIDInfo(string name) => default; // 0x0000000181749CD0-0x0000000181749DE0
	// [IDTag] // 0x0000000189AF64A0-0x0000000189AF64E0
	// [XID] // 0x0000000189AF64A0-0x0000000189AF64E0
	internal static ConfigBaseStateIDInfo createConfigBaseStateIDInfo(uint typeIndex, bool useObjectPool) => default; // 0x0000000181749BB0-0x0000000181749CD0
	// [IDTag] // 0x0000000189B00A90-0x0000000189B00AD0
	// [XID] // 0x0000000189B00A90-0x0000000189B00AD0
	internal static ConfigBaseStateLayer createConfigBaseStateLayer(string name) => default; // 0x0000000181749DE0-0x0000000181749EF0
	// [IDTag] // 0x0000000189B0B080-0x0000000189B0B0C0
	// [XID] // 0x0000000189B0B080-0x0000000189B0B0C0
	internal static ConfigBaseStateLayer createConfigBaseStateLayer(uint typeIndex, bool useObjectPool) => default; // 0x0000000181749EF0-0x000000018174A010
	// [IDTag] // 0x0000000189B15470-0x0000000189B154B0
	// [XID] // 0x0000000189B15470-0x0000000189B154B0
	internal static ConfigTalentMixin createConfigTalentMixin(string name) => default; // 0x0000000181748FB0-0x00000001817490C0
	// [IDTag] // 0x0000000189B1FCB0-0x0000000189B1FCF0
	// [XID] // 0x0000000189B1FCB0-0x0000000189B1FCF0
	internal static ConfigTalentMixin createConfigTalentMixin(uint typeIndex, bool useObjectPool) => default; // 0x0000000181748E90-0x0000000181748FB0
	// [IDTag] // 0x0000000189B2A2E0-0x0000000189B2A320
	// [XID] // 0x0000000189B2A2E0-0x0000000189B2A320
	internal static ConfigDialogGroup createConfigDialogGroup(string name) => default; // 0x000000018174ED00-0x000000018174EE10
	// [IDTag] // 0x0000000189B34470-0x0000000189B344B0
	// [XID] // 0x0000000189B34470-0x0000000189B344B0
	internal static ConfigDialogGroup createConfigDialogGroup(uint typeIndex, bool useObjectPool) => default; // 0x000000018174EBE0-0x000000018174ED00
	// [IDTag] // 0x0000000189B3F030-0x0000000189B3F070
	// [XID] // 0x0000000189B3F030-0x0000000189B3F070
	internal static ConfigBaseInputAction createConfigBaseInputAction(string name) => default; // 0x000000018174AFC0-0x000000018174B0D0
	// [IDTag] // 0x0000000189B49AD0-0x0000000189B49B10
	// [XID] // 0x0000000189B49AD0-0x0000000189B49B10
	internal static ConfigBaseInputAction createConfigBaseInputAction(uint typeIndex, bool useObjectPool) => default; // 0x000000018174AEA0-0x000000018174AFC0
	// [IDTag] // 0x0000000189B54020-0x0000000189B54060
	// [XID] // 0x0000000189B54020-0x0000000189B54060
	internal static ConfigBaseWidget createConfigBaseWidget(string name) => default; // 0x000000018174A810-0x000000018174A920
	// [IDTag] // 0x0000000189B5EAC0-0x0000000189B5EB00
	// [XID] // 0x0000000189B5EAC0-0x0000000189B5EB00
	internal static ConfigBaseWidget createConfigBaseWidget(uint typeIndex, bool useObjectPool) => default; // 0x000000018174A920-0x000000018174AA40
	// [IDTag] // 0x0000000189B69190-0x0000000189B691D0
	// [XID] // 0x0000000189B69190-0x0000000189B691D0
	internal static ConfigWidgetAction createConfigWidgetAction(string name) => default; // 0x000000018174F290-0x000000018174F3A0
	// [IDTag] // 0x0000000189B735D0-0x0000000189B73610
	// [XID] // 0x0000000189B735D0-0x0000000189B73610
	internal static ConfigWidgetAction createConfigWidgetAction(uint typeIndex, bool useObjectPool) => default; // 0x000000018174F170-0x000000018174F290
	// [IDTag] // 0x0000000189B7DA40-0x0000000189B7DA80
	// [XID] // 0x0000000189B7DA40-0x0000000189B7DA80
	internal static ConfigWidgetPredict createConfigWidgetPredict(string name) => default; // 0x000000018174B0D0-0x000000018174B1E0
	// [IDTag] // 0x0000000189B88420-0x0000000189B88460
	// [XID] // 0x0000000189B88420-0x0000000189B88460
	internal static ConfigWidgetPredict createConfigWidgetPredict(uint typeIndex, bool useObjectPool) => default; // 0x000000018174B1E0-0x000000018174B300
	// [IDTag] // 0x0000000189B92540-0x0000000189B92580
	// [XID] // 0x0000000189B92540-0x0000000189B92580
	internal static ConfigBaseWidgetToy createConfigBaseWidgetToy(string name) => default; // 0x000000018174C6B0-0x000000018174C7C0
	// [IDTag] // 0x0000000189B9C9F0-0x0000000189B9CA30
	// [XID] // 0x0000000189B9C9F0-0x0000000189B9CA30
	internal static ConfigBaseWidgetToy createConfigBaseWidgetToy(uint typeIndex, bool useObjectPool) => default; // 0x000000018174C7C0-0x000000018174C8E0
}

