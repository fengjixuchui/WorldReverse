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

public sealed class AbilityTriggerMassiveElementTask : AbilityTask // TypeDefIndex: 20589
{
	// Fields
	private AbilityTriggerMassiveElementTaskBlackboard _blackboard; // 0x60
	private float _burningReduceDurability; // 0x68
	private float _freezeReduceDurability; // 0x6C
	private float _electricAddReduceDurability; // 0x70
	private LevelSceneGrassPlugin _grassScenePlugin; // 0x78
	private LevelSceneWaterPlugin _waterScenePlugin; // 0x80
	private LevelTileAttackPlugin _tilePlugin; // 0x88
	private Dictionary<int, ConfigMassiveElementTriggerAction> _massiveElementTriggerActionConfigDic; // 0x90
	private bool _isPreDoing; // 0x98
	public const float ELEMENT_BURNING_DURABILITY = 50f; // Metadata: 0x00AFDE3A

	// Properties
	public override bool isSingleInstance { /* [XID] */ /* 0x0000000189A5ECB0-0x0000000189A5ECD0 */ get => default; } // 0x0000000181C02CA0-0x0000000181C02D40 

	// Nested types
	public enum AbilityTriggerContainerType // TypeDefIndex: 20590
	{
		BURNING = 0,
		EXPLODE = 1,
		SUPERCONDUCTOR = 2,
		MELT = 3,
		STEAM = 4,
		FREEZE = 5,
		FROZEN = 6,
		ELECTRIC_ADD = 7,
		COUNT = 8
	}

	// Constructors
	public AbilityTriggerMassiveElementTask() {} // 0x0000000181C075B0-0x0000000181C07660

	// Methods
	// [XID] // 0x0000000189A66450-0x0000000189A66470
	public ConfigMassiveElementTriggerAction GetElementTriggerActionConfig(MassiveElementTriggerType triggerType) => default; // 0x0000000181C07100-0x0000000181C071F0
	// [XID] // 0x0000000189A6DB80-0x0000000189A6DBA0
	public override void Init(ConfigAbilityTask taskConfig, AbilityInstance instance, AbilityComponentProxy proxy) {} // 0x0000000181C02BA0-0x0000000181C02CA0
	// [XID] // 0x0000000189A75290-0x0000000189A752B0
	protected override void RegisterAbilityEvent(AbilityInstance instance, AbilityComponentProxy proxy) {} // 0x0000000181C01E10-0x0000000181C01F20
	// [XID] // 0x0000000189A7CF10-0x0000000189A7CF30
	protected override void UnregisterAbilityEvent(AbilityInstance instance, AbilityComponentProxy proxy) {} // 0x0000000181C03E60-0x0000000181C03F50
	// [XID] // 0x0000000189A84800-0x0000000189A84820
	private void InitConfig() {} // 0x0000000181C04F80-0x0000000181C05240
	// [XID] // 0x0000000189A8C100-0x0000000189A8C120
	public override void Clear() {} // 0x0000000181C02F20-0x0000000181C02FD0
	// [XID] // 0x0000000189A935B0-0x0000000189A935D0
	public override void OnPreUpdate() {} // 0x0000000181C05EB0-0x0000000181C05FE0
	// [XID] // 0x0000000189A9B080-0x0000000189A9B0A0
	public override void OnFlushUpdate() {} // 0x0000000181C03800-0x0000000181C03950
	// [XID] // 0x0000000189AA23F0-0x0000000189AA2410
	private void HandleElementEvents() {} // 0x0000000181C04800-0x0000000181C04AB0
	// [XID] // 0x0000000189AA9980-0x0000000189AA99A0
	private void HandleFlushDetachAbilities() {} // 0x0000000181C03F50-0x0000000181C04100
	// [XID] // 0x0000000189AB1760-0x0000000189AB1780
	private void HandleActionTileFlush() {} // 0x0000000181C02D40-0x0000000181C02DF0
	// [XID] // 0x0000000189AB8B00-0x0000000189AB8B20
	private void AttachAbility(int index, MassiveEntityProxy proxy, ConfigMassiveElementTriggerAction config) {} // 0x0000000181C024E0-0x0000000181C02630
	// [XID] // 0x0000000189AC0670-0x0000000189AC0690
	public void DetachAbility(int index, MassiveEntityProxy proxy) {} // 0x0000000181C04700-0x0000000181C04800
	// [XID] // 0x0000000189AC80D0-0x0000000189AC80F0
	public bool TickAbility(int index, MassiveEntityProxy proxy, float deltaTime) => default; // 0x0000000181C01930-0x0000000181C01A20
	// [XID] // 0x0000000189ACF750-0x0000000189ACF770
	private void EnqueueElementReactionEvent(MassiveElementTriggerType triggerType, MassiveEntityProxy proxy, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, uint sourceElementCasterID, ElementType reactorElementType, float durability, ElementReactionType elementReactionType) {} // 0x0000000181C029F0-0x0000000181C02BA0
	// [IDTag] // 0x0000000189AD74C0-0x0000000189AD7500
	// [XID] // 0x0000000189AD74C0-0x0000000189AD7500
	private void FireElementReactionEvent(int triggerType, MassiveEntityProxy proxy) {} // 0x0000000181C069C0-0x0000000181C06B20
	// [IDTag] // 0x0000000189AE1DB0-0x0000000189AE1DF0
	// [XID] // 0x0000000189AE1DB0-0x0000000189AE1DF0
	private void FireElementReactionEvent(MassiveEntityProxy proxy, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, uint sourceElementCasterID, ElementType reactorElementType, float durability, ElementReactionType elementReactionType) {} // 0x0000000181C06B20-0x0000000181C06CD0
	// [XID] // 0x0000000189AEC6C0-0x0000000189AEC6E0
	public override void ActiveTask(AbilityContext context, float CurrentTime) {} // 0x0000000181C02630-0x0000000181C02730
	// [XID] // 0x0000000189AF4150-0x0000000189AF4170
	public override bool OnTaskTick(AbilityContext context, float deltaTime) => default; // 0x0000000181C02310-0x0000000181C024E0
	// [XID] // 0x0000000189AFB920-0x0000000189AFB940
	protected override void HandleBeingHitCommand(AbilityContextBeingHitCommand command) {} // 0x0000000181C06DC0-0x0000000181C06F60
	// [XID] // 0x0000000189B02F90-0x0000000189B02FB0
	protected override void HandleEventCommand(AbilityContextEventCommand command) {} // 0x0000000181C01CF0-0x0000000181C01E10
	// [XID] // 0x0000000189B0A7A0-0x0000000189B0A7C0
	private void HandleAbilityMassiveGlobalDurabilityEvent(AbilityTaskEvent evt) {} // 0x0000000181C06800-0x0000000181C069C0
	// [XID] // 0x0000000189B11E20-0x0000000189B11E40
	private void HandleAbilityMassiveElementReactionEvent(AbilityTaskEvent evt) {} // 0x0000000181C05CF0-0x0000000181C05DE0
	// [XID] // 0x0000000189B19090-0x0000000189B190B0
	private void TryTriggerElementReaction(MassiveEntityProxy proxy, uint attackerId, uint targetId, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, ref float attackElementDurability) {} // 0x0000000181C06410-0x0000000181C06800
	// [XID] // 0x0000000189B207D0-0x0000000189B207F0
	private bool HasGlobalElement(ElementType elem) => default; // 0x0000000181C01B30-0x0000000181C01C00
	// [XID] // 0x0000000189B27E70-0x0000000189B27E90
	private bool IsReactionValid(MassiveEntityProxy proxy, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, ref float attackElementDurability, ElementType elem1, ElementType elem2) => default; // 0x0000000181C05B10-0x0000000181C05CF0
	// [XID] // 0x0000000189B2F1D0-0x0000000189B2F1F0
	private float ElementReduceReaction(MassiveEntityProxy proxy, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, ref float attackElementDurability, ElementType elem1, ElementType elem2) => default; // 0x0000000181C03330-0x0000000181C03610
	// [XID] // 0x0000000189B36B30-0x0000000189B36B50
	private bool TickCommonAbilityTrigger(AbilityContext context, float deltaTime, MassiveElementTriggerType triggerType, AbilityTriggerContainerType containerType) => default; // 0x0000000181C04260-0x0000000181C04540
	// [XID] // 0x0000000189B3E330-0x0000000189B3E350
	private bool TryTriggerAntiFire(MassiveEntityProxy proxy, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, uint sourceElementCasterID, ref float attackElementDurability) => default; // 0x0000000181C04100-0x0000000181C04260
	// [XID] // 0x0000000189B45FC0-0x0000000189B45FE0
	private bool TryTriggerBurning(MassiveEntityProxy proxy, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, uint sourceElementCasterID, ref float attackElementDurability) => default; // 0x0000000181C05850-0x0000000181C05A20
	// [XID] // 0x0000000189B4D490-0x0000000189B4D4B0
	private void TriggerBurningAction(MassiveEntityProxy proxy) {} // 0x0000000181C072C0-0x0000000181C07390
	// [XID] // 0x0000000189B54CB0-0x0000000189B54CD0
	private bool TickBurning(AbilityContext context, float deltaTime) => default; // 0x0000000181C05370-0x0000000181C057C0
	// [XID] // 0x0000000189B5C690-0x0000000189B5C6B0
	private bool TryTriggerExplode(MassiveEntityProxy proxy, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, uint sourceElementCasterID, ref float attackElementDurability) => default; // 0x0000000181C02FD0-0x0000000181C03170
	// [XID] // 0x0000000189B63D70-0x0000000189B63D90
	private void TriggerExplodeAction(MassiveEntityProxy proxy) {} // 0x0000000181C052A0-0x0000000181C05370
	// [XID] // 0x0000000189B6B500-0x0000000189B6B520
	private bool TickExplode(AbilityContext context, float deltaTime) => default; // 0x0000000181C06CD0-0x0000000181C06DC0
	// [XID] // 0x0000000189B72B50-0x0000000189B72B70
	private bool TryTriggerSuperconductorIce(MassiveEntityProxy proxy, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, uint sourceElementCasterID, ref float attackElementDurability) => default; // 0x0000000181C02DF0-0x0000000181C02F20
	// [XID] // 0x0000000189B7A090-0x0000000189B7A0B0
	private bool TryTriggerSuperconductorFrozen(MassiveEntityProxy proxy, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, uint sourceElementCasterID, ref float attackElementDurability) => default; // 0x0000000181C03610-0x0000000181C037A0
	// [XID] // 0x0000000189B817F0-0x0000000189B81810
	private bool TryTriggerSuperconductor(MassiveEntityProxy proxy, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, uint sourceElementCasterID, ref float attackElementDurability, ElementType elem1, ElementType elem2) => default; // 0x0000000181C02730-0x0000000181C02960
	// [XID] // 0x0000000189B88E90-0x0000000189B88EB0
	private bool IsDurabilityEnough(MassiveEntityProxy proxy, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, float attackElementDurability, ElementType elem1, ElementType elem2, float minDurability) => default; // 0x0000000181C04540-0x0000000181C04700
	// [XID] // 0x0000000189B90460-0x0000000189B90480
	private void TriggerSuperconductorAction(MassiveEntityProxy proxy) {} // 0x0000000181C03CC0-0x0000000181C03D90
	// [XID] // 0x0000000189B97890-0x0000000189B978B0
	private bool TickSuperconductor(AbilityContext context, float deltaTime) => default; // 0x0000000181C01C00-0x0000000181C01CF0
	// [XID] // 0x0000000189B9ECB0-0x0000000189B9ECD0
	private bool TryTriggerBothMelt(MassiveEntityProxy proxy, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, uint sourceElementCasterID, ref float attackElementDurability) => default; // 0x0000000181C03950-0x0000000181C03BF0
	// [XID] // 0x0000000189BA65C0-0x0000000189BA65E0
	private bool TryTriggerIceMelt(MassiveEntityProxy proxy, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, uint sourceElementCasterID, ref float attackElementDurability) => default; // 0x0000000181C01F20-0x0000000181C020E0
	// [XID] // 0x0000000189BAD8E0-0x0000000189BAD900
	private void TriggerMeltAction(MassiveEntityProxy proxy) {} // 0x0000000181C03170-0x0000000181C03240
	// [XID] // 0x0000000189BB5060-0x0000000189BB5080
	private bool TickMelt(AbilityContext context, float deltaTime) => default; // 0x0000000181C03240-0x0000000181C03330
	// [XID] // 0x0000000189BBC6A0-0x0000000189BBC6C0
	private bool TryTriggerSteam(MassiveEntityProxy proxy, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, uint sourceElementCasterID, ref float attackElementDurability) => default; // 0x0000000181C06F60-0x0000000181C07100
	// [XID] // 0x0000000189BC4300-0x0000000189BC4320
	private void TriggerSteamAction(MassiveEntityProxy proxy) {} // 0x0000000181C03BF0-0x0000000181C03CC0
	// [XID] // 0x0000000189BCBCC0-0x0000000189BCBCE0
	private bool TickSteam(AbilityContext context, float deltaTime) => default; // 0x0000000181C05A20-0x0000000181C05B10
	// [XID] // 0x0000000189BD3270-0x0000000189BD3290
	private bool TryTriggerFreeze(MassiveEntityProxy proxy, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, uint sourceElementCasterID, ref float attackElementDurability) => default; // 0x0000000181C020E0-0x0000000181C02310
	// [XID] // 0x0000000189BDABE0-0x0000000189BDAC00
	private void TriggerFreezeAction(MassiveEntityProxy proxy) {} // 0x0000000181C01860-0x0000000181C01930
	// [XID] // 0x00000001895E74F0-0x00000001895E7510
	private bool TickFreeze(AbilityContext context, float deltaTime) => default; // 0x0000000181C05FE0-0x0000000181C06410
	// [XID] // 0x00000001895EEDA0-0x00000001895EEDC0
	private bool TickFrozen(AbilityContext context, float deltaTime) => default; // 0x0000000181C071F0-0x0000000181C072C0
	// [XID] // 0x00000001895F6780-0x00000001895F67A0
	private bool TryTriggerElectricAdd(MassiveEntityProxy proxy, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, uint sourceElementCasterID, ref float attackElementDurability) => default; // 0x0000000181C07390-0x0000000181C075B0
	// [XID] // 0x00000001895FDB40-0x00000001895FDB60
	private void TriggerElectricAddAction(MassiveEntityProxy proxy) {} // 0x0000000181C03D90-0x0000000181C03E60
	// [XID] // 0x0000000189605350-0x0000000189605370
	private bool TickElectricAdd(AbilityContext context, float deltaTime) => default; // 0x0000000181C04BC0-0x0000000181C04F80
}

