/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class AbilityProperty // TypeDefIndex: 16853
{
	// Fields
	public const string ENTITY_CHARGE_SPEED_RATIO_DELTA = "Entity_ChargeSpeedRatioDelta"; // Metadata: 0x00AF48A2
	public const string ENTITY_MASS_RATIO = "Entity_MassRatio"; // Metadata: 0x00AF48C2
	public const string ENTITY_WEIGHT_RATIO = "Entity_WeightRatio"; // Metadata: 0x00AF48D6
	public const string ENTITY_LIFE_TIME_DELTA = "Entity_LifeTimeDelta"; // Metadata: 0x00AF48EC
	public const string ENTITY_ANIMATOR_MOVE_SPEED = "Animator_MoveSpeedRatio"; // Metadata: 0x00AF4904
	public const string ENTITY_ANIMATOR_ATTACK_SPEED = "Animator_AttackSpeedRatio"; // Metadata: 0x00AF491F
	public const string ENTITY_ANIMATOR_OVERALL_SPEED = "Animator_OverallSpeedRatio"; // Metadata: 0x00AF493C
	public const string ENTITY_ANIMATOR_OVERALL_SPEED_MULTIPLIED = "Animator_OverallSpeedRatioMultiplied"; // Metadata: 0x00AF495A
	public const string ACTOR_ANI_DAMAGE_DELTA = "Actor_AniDamageDelta"; // Metadata: 0x00AF4982
	public const string ACTOR_ANI_DEFENCE_DELTA = "Actor_AniDefenceDelta"; // Metadata: 0x00AF499A
	public const string ACTOR_MAX_STAMINA_RATIO = "Actor_MaxStaminaRatio"; // Metadata: 0x00AF49B3
	public const string ACTOR_MAX_STAMINA_DELTA = "Actor_MaxStaminaDelta"; // Metadata: 0x00AF49CC
	public const string ACTOR_COST_STAMINA_DELTA = "Actor_CostStaminaDelta"; // Metadata: 0x00AF49E5
	public const string ACTOR_COST_STAMINA_RATIO = "Actor_CostStaminaRatio"; // Metadata: 0x00AF49FF
	public const string ACTOR_RECOVER_STAMINA_DELTA = "Actor_RecoverStaminaDelta"; // Metadata: 0x00AF4A19
	public const string ACTOR_RECOVER_STAMINA_RATIO = "Actor_RecoverStaminaRatio"; // Metadata: 0x00AF4A36
	public const string ACTOR_DEBUFF_DURATION_RATIO_DELTA = "Actor_DebuffDurationRatioDelta"; // Metadata: 0x00AF4A53
	public const string ACTOR_WEIGHT_DELTA = "Actor_WeightDelta"; // Metadata: 0x00AF4A75
	public const string ACTOR_ENDURE_DELTA = "Actor_EndureDelta"; // Metadata: 0x00AF4A8A
	public const string ACTOR_TIME_SCALE_RATIO = "Actor_TimeScaleRatio"; // Metadata: 0x00AF4A9F
	public const string ACTOR_ADD_GRAVITY_SCALE = "Actor_AddGravityScale"; // Metadata: 0x00AF4AB7
	public const string ACTOR_RATIO_BULLET_MOVE_SPEED_RATIO = "Actor_BulletMoveSpeedRatio"; // Metadata: 0x00AF4AD0
	public const string ACTOR_RATIO_BULLET_MOVE_ANGULAR_VELOCITY_RATIO = "Actor_BulletMoveAngularVelocityRatio"; // Metadata: 0x00AF4AEE
	public const string ACTOR_RATIO_BULLET_MOVE_SURROUND_RADIUS_RATIO = "Actor_BulletMoveSurroundRadiusRatio"; // Metadata: 0x00AF4B16
	public const string ACTOR_ADSORBATE_PICK_RADIUS_DELTA = "Actor_AdsorbatePickRadiusDelta"; // Metadata: 0x00AF4B3D
	public const string ACTOR_ENERGY_COST_DELTA = "Actor_EnergyCostDelta"; // Metadata: 0x00AF4B5F
	public const string ACTOR_FALLING_DAMAGE_RATIO = "Actor_FallingDamageRatio"; // Metadata: 0x00AF4B78
	public const string ACTOR_HP_THRESHOLD_RATIO = "Actor_HpThresholdRatio"; // Metadata: 0x00AF4B94
	public const string ACTOR_FLY_BACK_SPEED_MAX_RATIO = "Actor_FlyBackSpeedMaxRatio"; // Metadata: 0x00AF4BAE
	public const string ACTOR_FLY_HORIZONTAL_SPEED_MAX_RATIO = "Actor_FlyHorizontalSpeedMaxRatio"; // Metadata: 0x00AF4BCC
	public const string ACTOR_FLY_ROTATION_ANGULAR_VELOCITY_RATIO = "Actor_FlyRotationAngularVelocityRatio"; // Metadata: 0x00AF4BF0
	public const string ACTOR_FLY_DOWN_SPEED_RATIO = "Actor_FlyDownSpeedRatio"; // Metadata: 0x00AF4C19
	public const string ACTOR_FLY_FORWARD_SPEED_MAX_RATIO = "Actor_FlyForwardSpeedMaxRatio"; // Metadata: 0x00AF4C34
	public const string ACTOR_FLY_OVERALL_SPEED_RATIO = "Actor_FlyOverallSpeedRatio"; // Metadata: 0x00AF4C55
	public const string ACTOR_MAX_HP_RATIO = "Actor_MaxHPRatio"; // Metadata: 0x00AF4C73
	public const string ACTOR_MAX_HP_DELTA = "Actor_MaxHPDelta"; // Metadata: 0x00AF4C87
	public const string ACTOR_DEFENCE_RATIO = "Actor_DefenceRatio"; // Metadata: 0x00AF4C9B
	public const string ACTOR_DEFENCE_DELTA = "Actor_DefenceDelta"; // Metadata: 0x00AF4CB1
	public const string ACTOR_ATTACK_RATIO = "Actor_AttackRatio"; // Metadata: 0x00AF4CC7
	public const string ACTOR_ATTACK_DELTA = "Actor_AttackDelta"; // Metadata: 0x00AF4CDC
	public const string ACTOR_CRITICAL_DELTA = "Actor_CriticalDelta"; // Metadata: 0x00AF4CF1
	public const string ACTOR_ANTI_CRITICAL_DELTA = "Actor_AntiCriticalDelta"; // Metadata: 0x00AF4D08
	public const string ACTOR_CRITICAL_HURT_DELTA = "Actor_CriticalHurtDelta"; // Metadata: 0x00AF4D23
	public const string ACTOR_HIT_HEAD_DMG_RATIO = "Actor_HitHeadDmgRatio"; // Metadata: 0x00AF4D3E
	public const string ACTOR_CHARGE_EFFICIENCY_DELTA = "Actor_ChargeEfficiencyDelta"; // Metadata: 0x00AF4D57
	public const string ACTOR_ADD_HURT_DELTA = "Actor_AddHurtDelta"; // Metadata: 0x00AF4D76
	public const string ACTOR_SUB_HURT_DELTA = "Actor_SubHurtDelta"; // Metadata: 0x00AF4D8C
	public const string ACTOR_HEAL_ADD_DELTA = "Actor_HealAddDelta"; // Metadata: 0x00AF4DA2
	public const string ACTOR_HEALED_ADD_DELTA = "Actor_HealedAddDelta"; // Metadata: 0x00AF4DB8
	public const string ACTOR_EFFECT_HIT_DELTA = "Actor_EffectHitDelta"; // Metadata: 0x00AF4DD0
	public const string ACTOR_EFFECT_RESIST_DELTA = "Actor_EffectResistDelta"; // Metadata: 0x00AF4DE8
	public const string ACTOR_FREEZE_RESIST_DELTA = "Actor_FreezeResistDelta"; // Metadata: 0x00AF4E03
	public const string ACTOR_TORPOR_RESIST_DELTA = "Actor_TorporResistDelta"; // Metadata: 0x00AF4E1E
	public const string ACTOR_DIZZY_RESIST_DELTA = "Actor_DizzyResistDelta"; // Metadata: 0x00AF4E39
	public const string ACTOR_FREEZE_SHORTEN_DELTA = "Actor_FreezeShortenDelta"; // Metadata: 0x00AF4E53
	public const string ACTOR_TORPOR_SHORTEN_DELTA = "Actor_TorporShortenDelta"; // Metadata: 0x00AF4E6F
	public const string ACTOR_DIZZY_SHORTEN_DELTA = "Actor_DizzyShortenDelta"; // Metadata: 0x00AF4E8B
	public const string ACTOR_FIRE_ADD_HURT_DELTA = "Actor_FireAddHurtDelta"; // Metadata: 0x00AF4EA6
	public const string ACTOR_ELEC_ADD_HURT_DELTA = "Actor_ElecAddHurtDelta"; // Metadata: 0x00AF4EC0
	public const string ACTOR_WATER_ADD_HURT_DELTA = "Actor_WaterAddHurtDelta"; // Metadata: 0x00AF4EDA
	public const string ACTOR_GRASS_ADD_HURT_DELTA = "Actor_GrassAddHurtDelta"; // Metadata: 0x00AF4EF5
	public const string ACTOR_WIND_ADD_HURT_DELTA = "Actor_WindAddHurtDelta"; // Metadata: 0x00AF4F10
	public const string ACTOR_ICE_ADD_HURT_DELTA = "Actor_IceAddHurtDelta"; // Metadata: 0x00AF4F2A
	public const string ACTOR_ROCK_ADD_HURT_DELTA = "Actor_RockAddHurtDelta"; // Metadata: 0x00AF4F43
	public const string ACTOR_PHYSICAL_ADD_HURT_DELTA = "Actor_PhysicalAddHurtDelta"; // Metadata: 0x00AF4F5D
	public const string ACTOR_PHYSICAL_SUB_HURT_DELTA = "Actor_PhysicalSubHurtDelta"; // Metadata: 0x00AF4F7B
	public const string ACTOR_FIRE_SUB_HURT_DELTA = "Actor_FireSubHurtDelta"; // Metadata: 0x00AF4F99
	public const string ACTOR_ELEC_SUB_HURT_DELTA = "Actor_ElecSubHurtDelta"; // Metadata: 0x00AF4FB3
	public const string ACTOR_WATER_SUB_HURT_DELTA = "Actor_WaterSubHurtDelta"; // Metadata: 0x00AF4FCD
	public const string ACTOR_GRASS_SUB_HURT_DELTA = "Actor_GrassSubHurtDelta"; // Metadata: 0x00AF4FE8
	public const string ACTOR_WIND_SUB_HURT_DELTA = "Actor_WindSubHurtDelta"; // Metadata: 0x00AF5003
	public const string ACTOR_ICE_SUB_HURT_DELTA = "Actor_IceSubHurtDelta"; // Metadata: 0x00AF501D
	public const string ACTOR_ROCK_SUB_HURT_DELTA = "Actor_RockSubHurtDelta"; // Metadata: 0x00AF5036
	public const string ACTOR_ELEM_ATTACK_ROCK_RATIO = "Actor_ElemAttackByRockRatio"; // Metadata: 0x00AF5050
	public const string ACTOR_ELEM_DEFENSE_ROCK_RATIO = "Actor_ElemDefenseByRockRatio"; // Metadata: 0x00AF506F
	public const string ACTOR_ELEM_MASTERY_DELTA = "Actor_ElemMasteryDelta"; // Metadata: 0x00AF508F
	public const string ACTOR_ELEM_REACT_SWIRL_FIRE_DELTA = "Actor_ElemReactSwirlFireDelta"; // Metadata: 0x00AF50A9
	public const string ACTOR_ELEM_REACT_SWIRL_ICE_DELTA = "Actor_ElemReactSwirlIceDelta"; // Metadata: 0x00AF50CA
	public const string ACTOR_ELEM_REACT_SWIRL_WATER_DELTA = "Actor_ElemReactSwirlWaterDelta"; // Metadata: 0x00AF50EA
	public const string ACTOR_ELEM_REACT_SWIRL_ELECTRIC_DELTA = "Actor_ElemReactSwirlElectricDelta"; // Metadata: 0x00AF510C
	public const string ACTOR_ELEM_REACT_SCONDUCT_DELTA = "Actor_ElemReactSConductDelta"; // Metadata: 0x00AF5131
	public const string ACTOR_ELEM_REACT_STEAM_DELTA = "Actor_ElemReactSteamDelta"; // Metadata: 0x00AF5151
	public const string ACTOR_ELEM_REACT_MELT_DELTA = "Actor_ElemReactMeltDelta"; // Metadata: 0x00AF516E
	public const string ACTOR_ELEM_REACT_ELECTRIC_DELTA = "Actor_ElemReactElectricDelta"; // Metadata: 0x00AF518A
	public const string ACTOR_ELEM_REACT_BURN_DELTA = "Actor_ElemReactBurnDelta"; // Metadata: 0x00AF51AA
	public const string ACTOR_ELEM_REACT_FREEZE_DELTA = "Actor_ElemReactFreezeDelta"; // Metadata: 0x00AF51C6
	public const string ACTOR_ELEM_REACT_EXPLODE_DELTA = "Actor_ElemReactExplodeDelta"; // Metadata: 0x00AF51E4
	public const string ACTOR_DEFENCE_IGNORE_RATIO = "Actor_DefenseIgnoreRatio"; // Metadata: 0x00AF5203
	public const string ACTOR_DEFENCE_IGNORE_DELTA = "Actor_DefenseIgnoreDelta"; // Metadata: 0x00AF521F
	public const string ACTOR_PHYSICAL_MUTE_HURT_DELTA = "Actor_PhysicalMuteHurtDelta"; // Metadata: 0x00AF523B
	public const string ACTOR_FIRE_MUTE_HURT_DELTA = "Actor_FireMuteHurtDelta"; // Metadata: 0x00AF525A
	public const string ACTOR_ELEC_MUTE_HURT_DELTA = "Actor_ElecMuteHurtDelta"; // Metadata: 0x00AF5275
	public const string ACTOR_WATER_MUTE_HURT_DELTA = "Actor_WaterMuteHurtDelta"; // Metadata: 0x00AF5290
	public const string ACTOR_GRASS_MUTE_HURT_DELTA = "Actor_GrassMuteHurtDelta"; // Metadata: 0x00AF52AC
	public const string ACTOR_WIND_MUTE_HURT_DELTA = "Actor_WindMuteHurtDelta"; // Metadata: 0x00AF52C8
	public const string ACTOR_ICE_MUTE_HURT_DELTA = "Actor_IceMuteHurtDelta"; // Metadata: 0x00AF52E3
	public const string ACTOR_ROCK_MUTE_HURT_DELTA = "Actor_RockMuteHurtDelta"; // Metadata: 0x00AF52FD
	public const string ACTOR_SKILL_CD_MINUS_RATIO = "Actor_SkillCDMinusRatio"; // Metadata: 0x00AF5318
	public const string ACTOR_SHIELD_COST_MINUS_RATIO = "Actor_ShieldCostMinusRatio"; // Metadata: 0x00AF5333
	public const string ACTOR_ATTACK_EXTRA_DELTA = "Actor_AttackExtraDelta"; // Metadata: 0x00AF5351
	public const string ACTOR_DEFENCE_EXTRA_DELTA = "Actor_DefenceExtraDelta"; // Metadata: 0x00AF536B
	public const string ACTOR_CRITICAL_EXTRA_DELTA = "Actor_CriticalExtraDelta"; // Metadata: 0x00AF5386
	public const string ACTOR_ANTI_CRITICAL_EXTRA_DELTA = "Actor_AntiCriticalExtraDelta"; // Metadata: 0x00AF53A2
	public const string ACTOR_CRITICAL_HURT_EXTRA_DELTA = "Actor_CriticalHurtExtraDelta"; // Metadata: 0x00AF53C2
	public const string ACTOR_CHARGE_EFFICIENCY_EXTRA_DELTA = "Actor_ChargeEfficiencyExtraDelta"; // Metadata: 0x00AF53E2
	public const string ACTOR_ELEM_MASTERY_EXTRA_DELTA = "Actor_ElemMasteryExtraDelta"; // Metadata: 0x00AF5406
	public const string ACTOR_PHYSICAL_SUB_HURT_EXTRA_DELTA = "Actor_PhysicalSubHurtExtraDelta"; // Metadata: 0x00AF5425
	public const string ACTOR_FIRE_ADD_HURT_EXTRA_DELTA = "Actor_FireAddHurtExtraDelta"; // Metadata: 0x00AF5448
	public const string ACTOR_ELEC_ADD_HURT_EXTRA_DELTA = "Actor_ElecAddHurtExtraDelta"; // Metadata: 0x00AF5467
	public const string ACTOR_WATER_ADD_HURT_EXTRA_DELTA = "Actor_WaterAddHurtExtraDelta"; // Metadata: 0x00AF5486
	public const string ACTOR_GRASS_ADD_HURT_EXTRA_DELTA = "Actor_GrassAddHurtExtraDelta"; // Metadata: 0x00AF54A6
	public const string ACTOR_WIND_ADD_HURT_EXTRA_DELTA = "Actor_WindAddHurtExtraDelta"; // Metadata: 0x00AF54C6
	public const string ACTOR_ICE_ADD_HURT_EXTRA_DELTA = "Actor_IceAddHurtExtraDelta"; // Metadata: 0x00AF54E5
	public const string ACTOR_ROCK_ADD_HURT_EXTRA_DELTA = "Actor_RockAddHurtExtraDelta"; // Metadata: 0x00AF5503
	public const string ACTOR_FIRE_SUB_HURT_EXTRA_DELTA = "Actor_FireSubHurtExtraDelta"; // Metadata: 0x00AF5522
	public const string ACTOR_ELEC_SUB_HURT_EXTRA_DELTA = "Actor_ElecSubHurtExtraDelta"; // Metadata: 0x00AF5541
	public const string ACTOR_WATER_SUB_HURT_EXTRA_DELTA = "Actor_WaterSubHurtExtraDelta"; // Metadata: 0x00AF5560
	public const string ACTOR_GRASS_SUB_HURT_EXTRA_DELTA = "Actor_GrassSubHurtExtraDelta"; // Metadata: 0x00AF5580
	public const string ACTOR_WIND_SUB_HURT_EXTRA_DELTA = "Actor_WindSubHurtExtraDelta"; // Metadata: 0x00AF55A0
	public const string ACTOR_ICE_SUB_HURT_EXTRA_DELTA = "Actor_IceSubHurtExtraDelta"; // Metadata: 0x00AF55BF
	public const string ACTOR_ROCK_SUB_HURT_EXTRA_DELTA = "Actor_RockSubHurtExtraDelta"; // Metadata: 0x00AF55DD
	public const string ACTOR_SKILL_CD_MINUS_EXTRA_RATIO = "Actor_SkillCDMinusExtraRatio"; // Metadata: 0x00AF55FC
	public const string ACTOR_SHIELD_COST_MINUS_EXTRA_RATIO = "Actor_ShieldCostMinusExtraRatio"; // Metadata: 0x00AF561C
	public const string ACTOR_PHYSICAL_ADD_HURT_EXTRA_DELTA = "Actor_PhysicalAddHurtExtraDelta"; // Metadata: 0x00AF563F

	// Methods
	// [XID] // 0x0000000189BCC1C0-0x0000000189BCC1E0
	public static void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184BDB1D0-0x0000000184BDBD20
}

