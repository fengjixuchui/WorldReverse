/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class CombatProperty // TypeDefIndex: 20522
{
	// Fields
	public SafeFloat maxHP; // 0x10
	public SafeFloat HP; // 0x20
	public SafeFloat elemEnergy; // 0x30
	public SafeFloat maxElemEnergy; // 0x40
	public SafeFloat attackBase; // 0x50
	public SafeFloat attackPermanent; // 0x60
	public SafeFloat defenseBase; // 0x70
	public SafeFloat defensePermanent; // 0x80
	public SafeFloat addHurtBase; // 0x90
	public SafeFloat subHurtBase; // 0xA0
	public SafeFloat criticalHurtBase; // 0xB0
	public SafeFloat criticalBase; // 0xC0
	public SafeFloat antiCriticalBase; // 0xD0
	public SafeFloat physicalSubHurtBase; // 0xE0
	public SafeFloat fireSubHurtBase; // 0xF0
	public SafeFloat grassSubHurtBase; // 0x100
	public SafeFloat waterSubHurtBase; // 0x110
	public SafeFloat elecSubHurtBase; // 0x120
	public SafeFloat windSubHurtBase; // 0x130
	public SafeFloat iceSubHurtBase; // 0x140
	public SafeFloat rockSubHurtBase; // 0x150
	public SafeFloat physicalMuteHurtBase; // 0x160
	public SafeFloat fireMuteHurtBase; // 0x170
	public SafeFloat grassMuteHurtBase; // 0x180
	public SafeFloat waterMuteHurtBase; // 0x190
	public SafeFloat elecMuteHurtBase; // 0x1A0
	public SafeFloat windMuteHurtBase; // 0x1B0
	public SafeFloat iceMuteHurtBase; // 0x1C0
	public SafeFloat rockMuetHurtBase; // 0x1D0
	public SafeFloat physicalAddHurtBase; // 0x1E0
	public SafeFloat fireAddHurtBase; // 0x1F0
	public SafeFloat grassAddHurtBase; // 0x200
	public SafeFloat waterAddHurtBase; // 0x210
	public SafeFloat elecAddHurtBase; // 0x220
	public SafeFloat windAddHurtBase; // 0x230
	public SafeFloat iceAddHurtBase; // 0x240
	public SafeFloat rockAddHurtBase; // 0x250
	public SafeFloat hitHeadDmgRatioBase; // 0x260
	public SafeFloat defenseIgnoreRatioBase; // 0x270
	public SafeFloat defenseIgnoreDeltaBase; // 0x280
	public SafeFloat elementMasteryBase; // 0x290
	public SafeFloat elemReactSwirlFireDeltaBase; // 0x2A0
	public SafeFloat elemReactSwirlIceDeltaBase; // 0x2B0
	public SafeFloat elemReactSwirlWaterDeltaBase; // 0x2C0
	public SafeFloat elemReactSwirlElectricDeltaBase; // 0x2D0
	public SafeFloat elemReactSConductDeltaBase; // 0x2E0
	public SafeFloat elemReactSteamDeltaBase; // 0x2F0
	public SafeFloat elemReactMeltDeltaBase; // 0x300
	public SafeFloat elemReactElectricDeltaBase; // 0x310
	public SafeFloat elemReactBurnDeltaBase; // 0x320
	public SafeFloat elemReactFreezeDeltaBase; // 0x330
	public SafeFloat elemReactExplodeDeltaBase; // 0x340
	public SafeFloat effectHit; // 0x350
	public SafeFloat effectResist; // 0x360
	public SafeFloat freezeResist; // 0x370
	public SafeFloat torporResist; // 0x380
	public SafeFloat dizzyResist; // 0x390
	public SafeFloat freezeShorten; // 0x3A0
	public SafeFloat torporShorten; // 0x3B0
	public SafeFloat dizzyShorten; // 0x3C0
	public SafeFloat healAddBase; // 0x3D0
	public SafeFloat healedAddBase; // 0x3E0
	public SafeFloat chargeEfficiencyBase; // 0x3F0
	public SafeFloat skillCDMinusRatioBase; // 0x400
	public SafeFloat shieldCostMinusRatioBase; // 0x410
	public SafeFloat level; // 0x420
	public SafeFloat exp; // 0x430
	public ElementType elemType; // 0x440
	public SafeFloat weight; // 0x448
	public SafeFloat endure; // 0x458
	public SafeFloat endureShake; // 0x468
	public SafeFloat gaugeLength; // 0x478
	public SafeFloat waneSpeed; // 0x488
	public SafeFloat recoverTime; // 0x498
	public SafeFloat endurance; // 0x4A8
	public FixedBoolStack denyLockOn; // 0x4B8
	public FixedBoolStack isInvincible; // 0x4C0
	public FixedBoolStack islockHP; // 0x4C8
	public FixedBoolStack isGhostToAllied; // 0x4D0
	public FixedBoolStack isGhostToEnemy; // 0x4D8
	public FixedBoolStack canTriggerBullet; // 0x4E0
	public FixedBoolStack denyElementStick; // 0x4E8
	private LCAbilityState _ability; // 0x4F0
	public bool useAbilityProperty; // 0x4F8

	// Properties
	public float attack { /* [XID] */ /* 0x0000000189654D80-0x0000000189654DA0 */ get => default; } // 0x0000000184672300-0x00000001846725C0 
	public float nonExtraAttack { /* [XID] */ /* 0x000000018965C310-0x000000018965C330 */ get => default; } // 0x000000018466F260-0x000000018466F490 
	public float defense { /* [XID] */ /* 0x0000000189663A80-0x0000000189663AA0 */ get => default; } // 0x0000000184673270-0x0000000184673530 
	public float nonExtraDefense { /* [XID] */ /* 0x0000000189871F30-0x0000000189871F50 */ get => default; } // 0x0000000184670C30-0x0000000184670E70 
	public float addHurt { /* [XID] */ /* 0x0000000189673020-0x0000000189673040 */ get => default; } // 0x00000001846756D0-0x0000000184675850 
	public float subHurt { /* [XID] */ /* 0x0000000189645330-0x0000000189645350 */ get => default; } // 0x000000018466F6B0-0x000000018466F830 
	public float criticalHurt { /* [XID] */ /* 0x0000000189681F10-0x0000000189681F30 */ get => default; } // 0x0000000184674D40-0x0000000184674F60 
	public float nonExtraCriticalHurt { /* [XID] */ /* 0x0000000189880DB0-0x0000000189880DD0 */ get => default; } // 0x00000001846770C0-0x0000000184677240 
	public float critical { /* [XID] */ /* 0x0000000189734DF0-0x0000000189734E10 */ get => default; } // 0x000000018466E560-0x000000018466E780 
	public float nonExtraCritical { /* [XID] */ /* 0x0000000189698CD0-0x0000000189698CF0 */ get => default; } // 0x0000000184670300-0x0000000184670480 
	public float antiCritical { /* [XID] */ /* 0x00000001896A01B0-0x00000001896A01D0 */ get => default; } // 0x00000001846719C0-0x0000000184671BE0 
	public float nonExtraAntiCritical { /* [XID] */ /* 0x00000001896A7540-0x00000001896A7560 */ get => default; } // 0x0000000184676460-0x00000001846765E0 
	public float physicalSubHurt { /* [XID] */ /* 0x00000001896AEA00-0x00000001896AEA20 */ get => default; } // 0x0000000184673E80-0x00000001846740A0 
	public float nonExtraPhysicalSubHurt { /* [XID] */ /* 0x0000000189896C60-0x0000000189896C80 */ get => default; } // 0x0000000184671840-0x00000001846719C0 
	public float fireSubHurt { /* [XID] */ /* 0x00000001896BD420-0x00000001896BD440 */ get => default; } // 0x0000000184678B50-0x0000000184678D70 
	public float nonExtraFireSubHurt { /* [XID] */ /* 0x00000001896C4A20-0x00000001896C4A40 */ get => default; } // 0x00000001846747B0-0x0000000184674930 
	public float grassSubHurt { /* [XID] */ /* 0x000000018966AA10-0x000000018966AA30 */ get => default; } // 0x00000001846768E0-0x0000000184676B00 
	public float nonExtraGrassSubHurt { /* [XID] */ /* 0x0000000189A0C390-0x0000000189A0C3B0 */ get => default; } // 0x00000001846740A0-0x0000000184674220 
	public float waterSubHurt { /* [XID] */ /* 0x00000001896DAE00-0x00000001896DAE20 */ get => default; } // 0x000000018466FD60-0x000000018466FF80 
	public float nonExtraWaterSubHurt { /* [XID] */ /* 0x00000001896E25C0-0x00000001896E25E0 */ get => default; } // 0x0000000184677240-0x00000001846773C0 
	public float elecSubHurt { /* [XID] */ /* 0x00000001896E9AA0-0x00000001896E9AC0 */ get => default; } // 0x0000000184677E70-0x0000000184678090 
	public float nonExtraElecSubHurt { /* [XID] */ /* 0x00000001896F0CA0-0x00000001896F0CC0 */ get => default; } // 0x0000000184671170-0x00000001846712F0 
	public float windSubHurt { /* [XID] */ /* 0x00000001896F84E0-0x00000001896F8500 */ get => default; } // 0x00000001846760C0-0x00000001846762E0 
	public float nonExtraWindSubHurt { /* [XID] */ /* 0x00000001896FFE60-0x00000001896FFE80 */ get => default; } // 0x0000000184670600-0x0000000184670780 
	public float iceSubHurt { /* [XID] */ /* 0x0000000189707580-0x00000001897075A0 */ get => default; } // 0x0000000184674930-0x0000000184674B50 
	public float nonExtraIceSubHurt { /* [XID] */ /* 0x000000018970EE60-0x000000018970EE80 */ get => default; } // 0x0000000184677B70-0x0000000184677CF0 
	public float rockSubHurt { /* [XID] */ /* 0x00000001897162A0-0x00000001897162C0 */ get => default; } // 0x0000000184676D00-0x0000000184676F20 
	public float nonExtraRockSubHurt { /* [XID] */ /* 0x000000018971DCE0-0x000000018971DD00 */ get => default; } // 0x00000001846762E0-0x0000000184676460 
	public float physicalMuteHurt { /* [XID] */ /* 0x00000001897F5980-0x00000001897F59A0 */ get => default; } // 0x000000018466EEC0-0x000000018466F040 
	public float fireMuteHurt { /* [XID] */ /* 0x000000018972C8A0-0x000000018972C8C0 */ get => default; } // 0x0000000184672D30-0x0000000184672EB0 
	public float grassMuteHurt { /* [XID] */ /* 0x0000000189733FB0-0x0000000189733FD0 */ get => default; } // 0x000000018466FBE0-0x000000018466FD60 
	public float waterMuteHurt { /* [XID] */ /* 0x000000018973B750-0x000000018973B770 */ get => default; } // 0x0000000184671F60-0x00000001846720E0 
	public float elecMuteHurt { /* [XID] */ /* 0x0000000189743200-0x0000000189743220 */ get => default; } // 0x000000018466E180-0x000000018466E300 
	public float windMuteHurt { /* [XID] */ /* 0x000000018974AD80-0x000000018974ADA0 */ get => default; } // 0x0000000184670E70-0x0000000184670FF0 
	public float iceMuteHurt { /* [XID] */ /* 0x00000001896A29A0-0x00000001896A29C0 */ get => default; } // 0x0000000184673800-0x0000000184673980 
	public float rockMuetHurt { /* [XID] */ /* 0x00000001897EE1E0-0x00000001897EE200 */ get => default; } // 0x0000000184678820-0x00000001846789A0 
	public float physicalAddHurt { /* [XID] */ /* 0x00000001897610B0-0x00000001897610D0 */ get => default; } // 0x000000018466E780-0x000000018466E9A0 
	public float nonExtraPhysicalAddHurt { /* [XID] */ /* 0x0000000189768400-0x0000000189768420 */ get => default; } // 0x0000000184675550-0x00000001846756D0 
	public float fireAddHurtWithoutMastery { /* [XID] */ /* 0x000000018976FB10-0x000000018976FB30 */ get => default; } // 0x0000000184670780-0x0000000184670900 
	public float fireAddHurt { /* [XID] */ /* 0x0000000189777310-0x0000000189777330 */ get => default; } // 0x0000000184672990-0x0000000184672BB0 
	public float nonExtraFireAddHurt { /* [XID] */ /* 0x000000018989E0D0-0x000000018989E0F0 */ get => default; } // 0x0000000184678D70-0x0000000184678E20 
	public float grassAddHurtWithoutMastery { /* [XID] */ /* 0x0000000189786220-0x0000000189786240 */ get => default; } // 0x00000001846716C0-0x0000000184671840 
	public float grassAddHurt { /* [XID] */ /* 0x000000018978D8B0-0x000000018978D8D0 */ get => default; } // 0x0000000184670A10-0x0000000184670C30 
	public float nonExtraGrassAddHurt { /* [XID] */ /* 0x0000000189794D80-0x0000000189794DA0 */ get => default; } // 0x0000000184671BE0-0x0000000184671C90 
	public float waterAddHurtWithoutMastery { /* [XID] */ /* 0x000000018979D2F0-0x000000018979D310 */ get => default; } // 0x0000000184674300-0x0000000184674480 
	public float waterAddHurt { /* [XID] */ /* 0x00000001897A45D0-0x00000001897A45F0 */ get => default; } // 0x00000001846720E0-0x0000000184672300 
	public float nonExtraWaterAddHurt { /* [XID] */ /* 0x00000001897ABAC0-0x00000001897ABAE0 */ get => default; } // 0x0000000184670030-0x00000001846700E0 
	public float elecAddHurtWithoutMastery { /* [XID] */ /* 0x00000001898C9890-0x00000001898C98B0 */ get => default; } // 0x0000000184672BB0-0x0000000184672D30 
	public float elecAddHurt { /* [XID] */ /* 0x0000000189613BF0-0x0000000189613C10 */ get => default; } // 0x00000001846700E0-0x0000000184670300 
	public float nonExtraElecAddHurt { /* [XID] */ /* 0x00000001897C30D0-0x00000001897C30F0 */ get => default; } // 0x00000001846750E0-0x0000000184675190 
	public float windAddHurtWithoutMastery { /* [XID] */ /* 0x00000001898EF770-0x00000001898EF790 */ get => default; } // 0x0000000184670FF0-0x0000000184671170 
	public float windAddHurt { /* [XID] */ /* 0x0000000189648290-0x00000001896482B0 */ get => default; } // 0x000000018466F040-0x000000018466F260 
	public float nonExtraWindAddHurt { /* [XID] */ /* 0x00000001898E8040-0x00000001898E8060 */ get => default; } // 0x00000001846727E0-0x0000000184672890 
	public float iceAddHurtWithoutMastery { /* [XID] */ /* 0x00000001897E10C0-0x00000001897E10E0 */ get => default; } // 0x0000000184674F60-0x00000001846750E0 
	public float iceAddHurt { /* [XID] */ /* 0x00000001897E8810-0x00000001897E8830 */ get => default; } // 0x0000000184671D40-0x0000000184671F60 
	public float nonExtraIceAddHurt { /* [XID] */ /* 0x00000001897F0460-0x00000001897F0480 */ get => default; } // 0x000000018466FF80-0x0000000184670030 
	public float rockAddHurtWithoutMastery { /* [XID] */ /* 0x00000001899ACF10-0x00000001899ACF30 */ get => default; } // 0x0000000184670480-0x0000000184670600 
	public float rockAddHurt { /* [XID] */ /* 0x00000001896F3720-0x00000001896F3740 */ get => default; } // 0x000000018466F490-0x000000018466F6B0 
	public float nonExtraRockAddHurt { /* [XID] */ /* 0x00000001898069D0-0x00000001898069F0 */ get => default; } // 0x0000000184678770-0x0000000184678820 
	public float hitHeadDmgRatio { /* [XID] */ /* 0x000000018980E190-0x000000018980E1B0 */ get => default; } // 0x0000000184677CF0-0x0000000184677E70 
	public float defenseIgnoreRatio { /* [XID] */ /* 0x0000000189815890-0x00000001898158B0 */ get => default; } // 0x0000000184675310-0x0000000184675490 
	public float defenseIgnoreDelta { /* [XID] */ /* 0x000000018981D260-0x000000018981D280 */ get => default; } // 0x00000001846785F0-0x0000000184678770 
	public float elementMastery { /* [XID] */ /* 0x00000001899B30F0-0x00000001899B3110 */ get => default; } // 0x0000000184676B00-0x0000000184676D00 
	public float nonExtraElementMastery { /* [XID] */ /* 0x000000018988F740-0x000000018988F760 */ get => default; } // 0x0000000184673530-0x00000001846736B0 
	public float reactionAddHurtDelta { /* [XID] */ /* 0x0000000189833660-0x0000000189833680 */ get => default; } // 0x00000001846759D0-0x0000000184675AD0 
	public float elementAddHurtDelta { /* [XID] */ /* 0x00000001899AB850-0x00000001899AB870 */ get => default; } // 0x0000000184672890-0x0000000184672990 
	public float elemReactSwirlFireDelta { /* [XID] */ /* 0x00000001898421E0-0x0000000189842200 */ get => default; } // 0x00000001846783B0-0x0000000184678530 
	public float elemReactSwirlIceDelta { /* [XID] */ /* 0x00000001898495C0-0x00000001898495E0 */ get => default; } // 0x000000018466FA60-0x000000018466FBE0 
	public float elemReactSwirlWaterDelta { /* [XID] */ /* 0x000000018967E400-0x000000018967E420 */ get => default; } // 0x0000000184675850-0x00000001846759D0 
	public float elemReactSwirlElectricDelta { /* [XID] */ /* 0x00000001898582A0-0x00000001898582C0 */ get => default; } // 0x00000001846765E0-0x0000000184676760 
	public float elemReactSConductDelta { /* [XID] */ /* 0x000000018968D670-0x000000018968D690 */ get => default; } // 0x000000018466EBC0-0x000000018466ED40 
	public float elemReactSteamDelta { /* [XID] */ /* 0x0000000189866B10-0x0000000189866B30 */ get => default; } // 0x000000018466ED40-0x000000018466EEC0 
	public float elemReactMeltDelta { /* [XID] */ /* 0x000000018986E3D0-0x000000018986E3F0 */ get => default; } // 0x00000001846712F0-0x0000000184671470 
	public float elemReactElectricDelta { /* [XID] */ /* 0x0000000189875860-0x0000000189875880 */ get => default; } // 0x000000018466E000-0x000000018466E180 
	public float elemReactBurnDelta { /* [XID] */ /* 0x000000018987D3F0-0x000000018987D410 */ get => default; } // 0x0000000184676760-0x00000001846768E0 
	public float elemReactFreezeDelta { /* [XID] */ /* 0x00000001896C8660-0x00000001896C8680 */ get => default; } // 0x000000018466F830-0x000000018466F9B0 
	public float elemReactExplodeDelta { /* [XID] */ /* 0x000000018988BA20-0x000000018988BA40 */ get => default; } // 0x000000018466E3E0-0x000000018466E560 
	public SafeFloat healAdd { /* [XID] */ /* 0x0000000189727980-0x00000001897279A0 */ get => default; /* [XID] */ /* 0x0000000189893070-0x0000000189893090 */ set {} } // 0x0000000184678090-0x0000000184678230 0x0000000184678530-0x00000001846785F0
	public SafeFloat healedAdd { /* [XID] */ /* 0x00000001898A9310-0x00000001898A9330 */ get => default; /* [XID] */ /* 0x0000000189AB52A0-0x0000000189AB52C0 */ set {} } // 0x0000000184676F20-0x00000001846770C0 0x0000000184675490-0x0000000184675550
	public float chargeEfficiency { /* [XID] */ /* 0x00000001898B0B60-0x00000001898B0B80 */ get => default; } // 0x0000000184675C20-0x0000000184675E70 
	public float nonExtraChargeEfficiency { /* [XID] */ /* 0x0000000189888170-0x0000000189888190 */ get => default; } // 0x00000001846789A0-0x0000000184678B50 
	public float skillCDMinusRatio { /* [XID] */ /* 0x00000001898C7200-0x00000001898C7220 */ get => default; /* [XID] */ /* 0x00000001898BF9A0-0x00000001898BF9C0 */ set {} } // 0x000000018466E9A0-0x000000018466EBC0 0x000000018466E300-0x000000018466E3E0
	public float nonExtraSkillCDMinusRatio { /* [XID] */ /* 0x00000001898CE790-0x00000001898CE7B0 */ get => default; } // 0x0000000184675190-0x0000000184675310 
	public float shieldCostMinusRatio { /* [XID] */ /* 0x00000001898DDDC0-0x00000001898DDDE0 */ get => default; /* [XID] */ /* 0x00000001898D6170-0x00000001898D6190 */ set {} } // 0x00000001846725C0-0x00000001846727E0 0x0000000184674220-0x0000000184674300
	public float nonExtraShieldCostMinusRatio { /* [XID] */ /* 0x00000001898E56C0-0x00000001898E56E0 */ get => default; } // 0x0000000184678230-0x00000001846783B0 

	// Constructors
	public CombatProperty() {} // 0x0000000184679110-0x00000001846793F0
	public CombatProperty(LCAbilityState ability) {} // 0x0000000184678E20-0x0000000184679110

	// Methods
	// [XID] // 0x0000000189AA6420-0x0000000189AA6440
	public void ClearProperty() {} // 0x00000001846773C0-0x0000000184677B70
	// [XID] // 0x00000001899ECF00-0x00000001899ECF20
	public void SetBaseProperty(float level, float exp, float HP, float maxHP, float elemEnergy, float maxElemEnergy, float attackBase, float attackPermanent, float defenseBase, float defensePermanent, float hitHeadDmgRatioBase, float weight) {} // 0x0000000184674480-0x00000001846747B0
	// [XID] // 0x00000001898FC090-0x00000001898FC0B0
	public void SeStrikeProperty(float critical, float antiCritical, float criticalHurt) {} // 0x00000001846736B0-0x0000000184673800
	// [XID] // 0x0000000189813480-0x00000001898134A0
	public void SetElementProperty(float elementMastery, float fireSubHurt, float grassSubHurt, float waterSubHurt, float elecSubHurt, float windSubHurt, float iceSubHurt, float rockSubHurt, float fireAddHurt, float grassAddHurt, float waterAddHurt, float elecAddHurt, float windAddHurt, float iceAddHurt, float rockAddHurt, float physicalSubHurt, float physicalAddHurt) {} // 0x0000000184672EB0-0x0000000184673270
	// [XID] // 0x000000018990B050-0x000000018990B070
	public void SetEffectProperty(float effectHit, float effectResist, float freezeResist, float torporResist, float dizzyResist, float freezeShorten, float torporShorten, float dizzyShorten) {} // 0x0000000184675E70-0x00000001846760C0
	// [XID] // 0x0000000189912C80-0x0000000189912CA0
	public void SeEndureProperty(float endure, float endureShake, float gaugeLength, float waneSpeed, float recoverTime, float endurance) {} // 0x0000000184674B50-0x0000000184674D40
	// [XID] // 0x000000018991A5D0-0x000000018991A5F0
	public void CopyProperty(CombatProperty combatProperty) {} // 0x0000000184673980-0x0000000184673E80
	// [XID] // 0x00000001896572E0-0x0000000189657300
	public void Allocate(LCAbilityState ability) {} // 0x0000000184671C90-0x0000000184671D40
	// [XID] // 0x0000000189929460-0x0000000189929480
	public void Clear() {} // 0x0000000184671470-0x00000001846716C0
	// [XID] // 0x0000000189A97730-0x0000000189A97750
	public void Deallocate() {} // 0x000000018466F9B0-0x000000018466FA60
	// [XID] // 0x0000000189937ED0-0x0000000189937EF0
	public bool IsEndureFull() => default; // 0x0000000184670900-0x0000000184670A10
	// [XID] // 0x0000000189AE6060-0x0000000189AE6080
	private float GetClampedAllDelta(string propKey, float allDelta) => default; // 0x0000000184675AD0-0x0000000184675C20
}

