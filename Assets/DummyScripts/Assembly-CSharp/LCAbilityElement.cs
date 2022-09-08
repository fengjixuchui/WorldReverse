/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using UniRx;
using UnityEngine;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCAbilityElement : LCBase // TypeDefIndex: 11669
{
	// Fields
	[InspectorCollapsedFoldout] // 0x000000018979CFE0-0x000000018979D020
	[InspectorCollectionShowItemDropdown] // 0x000000018979CFE0-0x000000018979D020
	[ShowInInspector] // 0x000000018979CFE0-0x000000018979D020
	private Dictionary<int, List<ActorModifier>> _elementModifierMap; // 0x130
	public Action onElementModifierChanged; // 0x138
	private List<Tuple<ActorModifier, float, IElementDurability, float>?> _modifierDurabilities; // 0x140
	private List<Tuple<int, float, float>?> _elemOverloadDurabilities; // 0x148
	[InspectorCollapsedFoldout] // 0x0000000189BC1460-0x0000000189BC14A0
	[InspectorCollectionShowItemDropdown] // 0x0000000189BC1460-0x0000000189BC14A0
	[ShowInInspector] // 0x0000000189BC1460-0x0000000189BC14A0
	private List<Tuple<ElementReactionType, float, float>> _elemAccuDurabilities; // 0x150
	private LCAbility _levelAbilityCom; // 0x158
	private LCAbility _selfLCAbility; // 0x160
	private LCAbilityState _lcAbilityState; // 0x168
	private VCBillboard _vcBillboard; // 0x170
	private float _purgeRate; // 0x178
	private float _purgeIncement; // 0x17C
	private bool _ignorePurgeRate; // 0x180
	private LevelSceneGrassPlugin _grassScenePlugin; // 0x188
	private LevelSceneWaterPlugin _waterScenePlugin; // 0x190
	private LevelSceneBushPlugin _bushScenePlugin; // 0x198
	private EntityTimerReceiver _shakeInterval; // 0x1A0
	private bool _showReactionText; // 0x1A8
	public string elementDecrateGroup; // 0x1B0
	public string reactionDebugString; // 0x1B8
	private bool triggeredReaction; // 0x1C0
	public const int defaultTickIntervalRatio = 6; // Metadata: 0x00AEA69A
	public const int massiveTickIntervalRatio = 33; // Metadata: 0x00AEA69E
	private ConductiveEnv _conductiveEnv; // 0x1C4
	public Action<ElementReactionType, BaseEntity> onCasterElementReaction; // 0x1C8
	public Vector3 elementReactionPos; // 0x1D0
	public bool triggerFrozenBroken; // 0x1DC
	private static Dictionary<int, ElementReactionTrigger[]> _reactionTriggers; // 0x00
	private static Dictionary<StrikeType, ElementReactionTrigger[]> _strikeTriggers; // 0x08
	private float _lastCrystallizeTime; // 0x1E0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899B15C0-0x00000001899B15E0 */ get => default; } // 0x00000001812E7C30-0x00000001812E7CD0 

	// Nested types
	public enum ConductiveEnv // TypeDefIndex: 11670
	{
		None = 0,
		Rain = 1,
		Water = 2
	}

	private class ReactionData // TypeDefIndex: 11671
	{
		// Fields
		public float initialDurability; // 0x10
		public float elementDurability; // 0x14
		public float elementAddHurtDelta; // 0x18
		public ElementReactionDamageChange reactionDamage; // 0x1C
		public bool allowElementStick; // 0x2C
		public CombatProperty casterProperty; // 0x30

		// Constructors
		public ReactionData() {} // 0x00000001815AD2E0-0x00000001815AD340

		// Methods
		// [XID] // 0x00000001899BA3E0-0x00000001899BA400
		public void Clear() {} // 0x00000001815AD220-0x00000001815AD2E0
	}

	private struct ReactionParams // TypeDefIndex: 11672
	{
		// Fields
		public LCAbilityElement lcAbilityElement; // 0x00
		public ElementReactionSourceType reactionSourceType; // 0x08
		public ElementType sourceElementType; // 0x0C
		public uint sourceElementCasterID; // 0x10
		public float sourceElementRank; // 0x14
		public ActorModifier sourceModifier; // 0x18
		public ReactionData reactionData; // 0x20
		public Vector3 hitPos; // 0x28

		// Constructors
		public ReactionParams(LCAbilityElement lcAbilityElement, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, uint sourceElementCasterID, float sourceElementRank, ActorModifier sourceModifier, ReactionData reactionData, Vector3 hitPos) {
			this.lcAbilityElement = default;
			this.reactionSourceType = default;
			this.sourceElementType = default;
			this.sourceElementCasterID = default;
			this.sourceElementRank = default;
			this.sourceModifier = default;
			this.reactionData = default;
			this.hitPos = default;
		} // 0x00000001815ADD70-0x00000001815ADE70
	}

	private delegate void ElementReactionTrigger(ReactionParams param); // TypeDefIndex: 11673; 0x00000001815ACEE0-0x00000001815AD1A0

	private struct DurabilityProxy // TypeDefIndex: 11674
	{
		// Fields
		private float durability; // 0x00
		private float ratio; // 0x04

		// Constructors
		public DurabilityProxy(float f1, float f2) {
			durability = default;
			ratio = default;
		} // 0x00000001815AEE90-0x00000001815AEF30

		// Methods
		// [XID] // 0x0000000189BDBC40-0x0000000189BDBC60
		public float Value() => default; // 0x00000001815AED40-0x00000001815AED50
		// [XID] // 0x000000018990D780-0x000000018990D7A0
		public float OriginalValue() => default; // 0x00000001815AEBA0-0x00000001815AEC70
		// [XID] // 0x00000001895F7710-0x00000001895F7730
		public void Reduce(DurabilityProxy proxy) {} // 0x00000001815AEAD0-0x00000001815AEBA0
		// [XID] // 0x00000001895E85D0-0x00000001895E85F0
		public void SetValue(DurabilityProxy proxy) {} // 0x00000001815AEC70-0x00000001815AED40
		// [XID] // 0x0000000189924410-0x0000000189924430
		public static float GetValue(float f1, float f2) => default; // 0x00000001815AED50-0x00000001815AEE90
	}

	// Constructors
	public LCAbilityElement() {} // 0x00000001812E7B80-0x00000001812E7C30
	static LCAbilityElement() {} // 0x00000001812E5900-0x00000001812E7B80

	// Methods
	// [XID] // 0x00000001899B8A80-0x00000001899B8AA0
	public override void PreInit() {} // 0x00000001812E52C0-0x00000001812E5900
	// [XID] // 0x0000000189843300-0x0000000189843320
	public override void OnEntityReady() {} // 0x00000001812E31A0-0x00000001812E33A0
	// [XID] // 0x00000001899C7BD0-0x00000001899C7BF0
	public override void PostReInit() {} // 0x00000001812E51D0-0x00000001812E52C0
	// [XID] // 0x00000001899CF370-0x00000001899CF390
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001812D5330-0x00000001812D5410
	// [XID] // 0x00000001899D6850-0x00000001899D6870
	protected override bool OnEvent(BaseEvent e) => default; // 0x00000001812E33A0-0x00000001812E34B0
	// [XID] // 0x00000001898CF890-0x00000001898CF8B0
	public override void Destroy() {} // 0x00000001812D0A10-0x00000001812D0B00
	// [XID] // 0x00000001898DEF70-0x00000001898DEF90
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x00000001812CF740-0x00000001812CF8A0
	// [XID] // 0x00000001899ECD20-0x00000001899ECD40
	public override void OnEnable() {} // 0x00000001812E30E0-0x00000001812E31A0
	// [XID] // 0x00000001899F4AE0-0x00000001899F4B00
	public override void OnDisable() {} // 0x00000001812E3020-0x00000001812E30E0
	// [XID] // 0x00000001899FC0C0-0x00000001899FC0E0
	protected override bool IsTickableForEntityTickManager() => default; // 0x00000001812D89B0-0x00000001812D8AD0
	// [XID] // 0x0000000189A034D0-0x0000000189A034F0
	private void TickElements(float deltaTime) {} // 0x00000001812E4860-0x00000001812E4B70
	// [XID] // 0x0000000189A0AB50-0x0000000189A0AB70
	public bool CheckModifierDurability(ActorModifier modifier) => default; // 0x00000001812CF4D0-0x00000001812CF740
	// [IDTag] // 0x0000000189A122E0-0x0000000189A12320
	// [XID] // 0x0000000189A122E0-0x0000000189A12320
	private float GetReduceDurability(Tuple<ActorModifier, float, IElementDurability, float> realTuple, float deltaTime) => default; // 0x00000001812D63D0-0x00000001812D66E0
	// [XID] // 0x0000000189876670-0x0000000189876690
	private void TickModifierDurability(float nowTime) {} // 0x00000001812D2250-0x00000001812D2630
	// [XID] // 0x00000001898A2A60-0x00000001898A2A80
	private void TickElemOverloadDurability(float nowTime) {} // 0x00000001812CD3A0-0x00000001812CD6F0
	// [XID] // 0x00000001898A9FA0-0x00000001898A9FC0
	private void TickElemAccuDurability(float nowTime) {} // 0x00000001812D7F10-0x00000001812D81B0
	// [XID] // 0x0000000189A327B0-0x0000000189A327D0
	public void OnEventBeingHit(EvtBeingHit evtBeingHit) {} // 0x00000001812DF090-0x00000001812DF3F0
	// [XID] // 0x0000000189A3A0D0-0x0000000189A3A0F0
	private void OnBeingHitPreHandle(AttackResult attackResult) {} // 0x00000001812CC010-0x00000001812CC0E0
	// [XID] // 0x00000001899210B0-0x00000001899210D0
	private void OnBeingHitHandleStrike(EvtBeingHit evtBeingHit, AttackResult attackResult, ActorModifier instancedModifier) {} // 0x00000001812D5BE0-0x00000001812D5F20
	// [XID] // 0x0000000189A48FB0-0x0000000189A48FD0
	private void OnBeingHitHandleElement(EvtBeingHit evtBeingHit, AttackResult attackResult, ActorModifier instancedModifier) {} // 0x00000001812E2210-0x00000001812E2860
	// [XID] // 0x0000000189A508C0-0x0000000189A508E0
	public void OnElementModifierApplied(ActorModifier modifier, float durability, float duration) {} // 0x00000001812E4ED0-0x00000001812E5000
	// [XID] // 0x00000001899C1E30-0x00000001899C1E50
	public void OnModifierPostApplied(ActorModifier modifier) {} // 0x00000001812CEB60-0x00000001812CEFA0
	// [XID] // 0x0000000189A5FA10-0x0000000189A5FA30
	public void OnElementModifierRemoved(ActorModifier modifier, ref bool elementModifierChanged) {} // 0x00000001812D6080-0x00000001812D6190
	// [XID] // 0x0000000189A67330-0x0000000189A67350
	public void OnModiferPostRemoved(ActorModifier modifier, bool elementModifierChanged, RemoveAbilityReason removeReason) {} // 0x00000001812DFF30-0x00000001812E00B0
	// [XID] // 0x00000001899C9260-0x00000001899C9280
	public void SyncModifierElementDurability(ActorModifier modifier, ref float reduceElementRatio, ref float remainingElementDurability) {} // 0x00000001812DDED0-0x00000001812DE0E0
	// [XID] // 0x0000000189A761F0-0x0000000189A76210
	private IElementDurability CreateElementDurability(ConfigAbilityModifier config, float elementDurability, bool isAdd, IElementDurability durability = null) => default; // 0x00000001812E43A0-0x00000001812E4660
	// [XID] // 0x0000000189A7DBE0-0x0000000189A7DC00
	private void AddModifierElementDurability(ActorModifier modifier, float durability, float duration) {} // 0x00000001812D2630-0x00000001812D28E0
	// [XID] // 0x0000000189A85490-0x0000000189A854B0
	public void RefreshModifierElementDurability(ActorModifier modifier, float elemDurability, float? reduceDurability = default) {} // 0x00000001812E1330-0x00000001812E18A0
	// [XID] // 0x0000000189A8CE80-0x0000000189A8CEA0
	public void PrelongModifierElementDurability(ActorModifier modifier, float elemDurability) {} // 0x00000001812CD7A0-0x00000001812CDB10
	// [XID] // 0x0000000189A94190-0x0000000189A941B0
	private float CalcOriginElementDurability(ActorModifier modifier, float elementDurability) => default; // 0x00000001812CCFD0-0x00000001812CD110
	// [XID] // 0x0000000189A9BB60-0x0000000189A9BB80
	public void RefreshAndAddDurabilityModifierElementDurability(ActorModifier modifier, float elemDurability, float elemDuration) {} // 0x00000001812D72A0-0x00000001812D7690
	// [XID] // 0x0000000189AA3040-0x0000000189AA3060
	public void RemoveModifierElementDurability(ActorModifier modifier) {} // 0x00000001812D3F10-0x00000001812D4130
	// [XID] // 0x00000001898E6520-0x00000001898E6540
	public void RemoveAllModifiersElementDurability() {} // 0x00000001812D6BC0-0x00000001812D6D40
	// [XID] // 0x0000000189AB23B0-0x0000000189AB23D0
	private void TryRemoveSpecialModifiers() {} // 0x00000001812E0C50-0x00000001812E0D30
	// [XID] // 0x0000000189AB9820-0x0000000189AB9840
	private void CheckRemoveIfMissBothElement(ElementType elem1, ElementType elem2, AbilityState state) {} // 0x00000001812D5F20-0x00000001812D6080
	// [IDTag] // 0x0000000189AC13B0-0x0000000189AC13F0
	// [XID] // 0x0000000189AC13B0-0x0000000189AC13F0
	private void CheckRemoveIfMissOneElement(ElementType elem1, ElementType elem2, AbilityState state) {} // 0x00000001812CD240-0x00000001812CD3A0
	// [IDTag] // 0x0000000189ACBCD0-0x0000000189ACBD10
	// [XID] // 0x0000000189ACBCD0-0x0000000189ACBD10
	private void CheckRemoveIfMissOneElement(ElementType elem1, AbilityState state) {} // 0x00000001812CD110-0x00000001812CD240
	// [XID] // 0x00000001899DB160-0x00000001899DB180
	private void CheckRemoveShock() {} // 0x00000001812E1CD0-0x00000001812E1D90
	// [XID] // 0x0000000189ADE480-0x0000000189ADE4A0
	private void CheckRemoveBurning() {} // 0x00000001812D6990-0x00000001812D6BC0
	// [XID] // 0x00000001899BD4D0-0x00000001899BD4F0
	private void CheckRemoveWet() {} // 0x00000001812E34B0-0x00000001812E3560
	// [XID] // 0x0000000189AED350-0x0000000189AED370
	private void CheckRemoveRock() {} // 0x00000001812CB560-0x00000001812CB610
	// [XID] // 0x00000001899CC470-0x00000001899CC490
	private void CheckRemoveFrozen() {} // 0x00000001812D81B0-0x00000001812D8260
	// [XID] // 0x0000000189AFC380-0x0000000189AFC3A0
	private void CheckRemoveGrassGrowing() {} // 0x00000001812DBC70-0x00000001812DBD30
	// [XID] // 0x00000001896C9DC0-0x00000001896C9DE0
	private void UpdatePurgeIncrement() {} // 0x00000001812E36C0-0x00000001812E3790
	// [XID] // 0x0000000189867AF0-0x0000000189867B10
	private void TickPurgeRate(float deltaTime) {} // 0x00000001812CB770-0x00000001812CB970
	// [IDTag] // 0x0000000189B12B30-0x0000000189B12B70
	// [XID] // 0x0000000189B12B30-0x0000000189B12B70
	private float GetReduceDurability(float deltaTime, ActorModifier modifier, float originReduceDurability, float remainingDurability) => default; // 0x00000001812D66E0-0x00000001812D6990
	// [XID] // 0x000000018988C970-0x000000018988C990
	private BaseEntity GetTimeScaleEntity(ActorModifier modifier) => default; // 0x00000001812D1750-0x00000001812D1920
	// [XID] // 0x0000000189B245E0-0x0000000189B24600
	private void AddFilterElementModifier(ActorModifier modifier) {} // 0x00000001812DB0A0-0x00000001812DB310
	// [XID] // 0x00000001897D7930-0x00000001897D7950
	private void RemoveFilterElementModifier(ActorModifier modifier, ref bool elementModifierChanged) {} // 0x00000001812DD810-0x00000001812DD9F0
	// [XID] // 0x00000001898D71D0-0x00000001898D71F0
	private void ClearElementModifiers() {} // 0x00000001812E3F10-0x00000001812E4130
	// [IDTag] // 0x0000000189B3A9E0-0x0000000189B3AA20
	// [XID] // 0x0000000189B3A9E0-0x0000000189B3AA20
	public bool HasElementTypeModifiers(ElementType elementType, bool checkOverrideWeaponElement = false /* Metadata: 0x00AEA68D */) => default; // 0x00000001812E0800-0x00000001812E0A60
	// [IDTag] // 0x0000000189B45500-0x0000000189B45540
	// [XID] // 0x0000000189B45500-0x0000000189B45540
	public bool HasElementTypeModifiers(ElementType[] elementTypes) => default; // 0x00000001812E06F0-0x00000001812E0800
	// [XID] // 0x0000000189B4FB70-0x0000000189B4FB90
	public void GetElementUITypes(List<ElementStateExcelConfig> elems, int count) {} // 0x00000001812DF450-0x00000001812DF910
	// [XID] // 0x00000001899883E0-0x0000000189988400
	private bool HasForceFireModifiers() => default; // 0x00000001812DA9A0-0x00000001812DABC0
	// [XID] // 0x0000000189B5EC20-0x0000000189B5EC40
	public float GetMaxElementDurabilityByType(ElementType elementType) => default; // 0x00000001812CC0E0-0x00000001812CC460
	// [XID] // 0x0000000189B66260-0x0000000189B66280
	public float GetAllElementDurabilityByType(ElementType elementType) => default; // 0x00000001812E0210-0x00000001812E06F0
	// [XID] // 0x0000000189B6D810-0x0000000189B6D830
	public void ReduceDurabiltyByType(ElementType sourceElementType, ElementType reduceElementyType, float reduceDurability) {} // 0x00000001812CEFA0-0x00000001812CF4D0
	// [XID] // 0x0000000189893E20-0x0000000189893E40
	private void ReduceModifierDurability(ElementType sourceElementType, int modifierDurabilityIndex, float reduceDurability, float? deltaTime = default) {} // 0x00000001812D04B0-0x00000001812D0A10
	// [XID] // 0x0000000189B7C350-0x0000000189B7C370
	private void AddModifierDurability(int modifierDurabilityIndex, float addedDurability) {} // 0x00000001812D2E50-0x00000001812D3180
	// [XID] // 0x0000000189B83EE0-0x0000000189B83F00
	private int GetModifierIndexFromDurabilityList(ActorModifier modifier) => default; // 0x00000001812CE9A0-0x00000001812CEB60
	// [XID] // 0x0000000189B8AEC0-0x0000000189B8AEE0
	private int GetModifierIndexFromDurabilityListByConfig(ConfigAbilityModifier modifierConfig) => default; // 0x00000001812D8F10-0x00000001812D90E0
	// [XID] // 0x0000000189B92660-0x0000000189B92680
	private void RemoveElementModifiersByType(ElementType elementType) {} // 0x00000001812CC460-0x00000001812CC660
	// [XID] // 0x000000018986F180-0x000000018986F1A0
	public float GetElementRemainingDurability(ActorModifier modifier) => default; // 0x00000001812D1F00-0x00000001812D2130
	// [XID] // 0x0000000189BA1260-0x0000000189BA1280
	public float GetElementRemainingTime(ActorModifier modifier) => default; // 0x00000001812DFCD0-0x00000001812DFF30
	// [XID] // 0x0000000189BA88C0-0x0000000189BA88E0
	public float GetElementReduceDurability(ActorModifier modifier) => default; // 0x00000001812CB970-0x00000001812CBB80
	// [XID] // 0x0000000189BAFBA0-0x0000000189BAFBC0
	public void ReduceModiferDurabilityByName(ElementType sourceElementType, string name, float reduceDurability) {} // 0x00000001812E18A0-0x00000001812E1B30
	// [XID] // 0x0000000189BB7360-0x0000000189BB7380
	public void AddModiferDurabilityByName(string name, float addDurability) {} // 0x00000001812DA0E0-0x00000001812DA350
	// [XID] // 0x0000000189BBE910-0x0000000189BBE930
	public void ClampModiferDurabilityByName(ElementType sourceElementType, string name, float addDurability, float minValue, float maxValue) {} // 0x00000001812D57F0-0x00000001812D5B70
	// [XID] // 0x0000000189BC6610-0x0000000189BC6630
	public void AddModiferDurabilityBySort(ElementType sourceElementType, float addDurability, ElementType modifyElementType, SortModifierType sortModifier) {} // 0x00000001812D45E0-0x00000001812D4E50
	// [XID] // 0x0000000189BCE2A0-0x0000000189BCE2C0
	public void GetElementRemainTime(Dictionary<ElementType, float> elemRemainTime) {} // 0x00000001812DC740-0x00000001812DCC50
	// [XID] // 0x0000000189BD5590-0x0000000189BD55B0
	public void DoShakeOff() {} // 0x00000001812DABC0-0x00000001812DB0A0
	// [XID] // 0x0000000189B21540-0x0000000189B21560
	public void PrintAllModifiersDurablity() {} // 0x00000001812CCC40-0x00000001812CCFD0
	// [XID] // 0x0000000189696DB0-0x0000000189696DD0
	private void TrySyncElementReactionToRemote(ElementReactionType reactionType, ElementType sourceElementType, ElementType reactorElementType, int hitIndex) {} // 0x00000001812D90E0-0x00000001812D9360
	// [XID] // 0x00000001895F1260-0x00000001895F1280
	private void TrySyncBaseReactionDamage(uint sourceCasterID, uint reactionType, string abilityName) {} // 0x00000001812DE2B0-0x00000001812DE540
	[Preserve] // 0x00000001895F8D80-0x00000001895F8DC0
	// [XID] // 0x00000001895F8D80-0x00000001895F8DC0
	public override string Dump() => default; // 0x00000001812D0B00-0x00000001812D1190
	// [XID] // 0x0000000189603260-0x0000000189603280
	private static void TriggerAntiFire(ReactionParams param) {} // 0x00000001812D95A0-0x00000001812D97E0
	// [XID] // 0x0000000189702490-0x00000001897024B0
	private static void TriggerBurning(ReactionParams param) {} // 0x00000001812DFA90-0x00000001812DFCD0
	// [XID] // 0x0000000189612210-0x0000000189612230
	private static void TriggerExplode(ReactionParams param) {} // 0x00000001812D6D40-0x00000001812D6F80
	// [XID] // 0x0000000189867AD0-0x0000000189867AF0
	private static void TriggerWet(ReactionParams param) {} // 0x00000001812D4360-0x00000001812D45E0
	// [XID] // 0x0000000189956980-0x00000001899569A0
	private static void TriggerStream(ReactionParams param) {} // 0x00000001812CE240-0x00000001812CE480
	// [XID] // 0x00000001898E6500-0x00000001898E6520
	private static void TriggerElectricModifier(ReactionParams param) {} // 0x00000001812CFD60-0x00000001812CFEE0
	// [XID] // 0x00000001896300D0-0x00000001896300F0
	private static void TriggerGrassGrowing(ReactionParams param) {} // 0x00000001812D3180-0x00000001812D33D0
	// [XID] // 0x0000000189637D60-0x0000000189637D80
	private static void TriggerFreeze(ReactionParams param) {} // 0x00000001812E2860-0x00000001812E2AA0
	// [XID] // 0x0000000189947E30-0x0000000189947E50
	private static void TriggerFrozen(ReactionParams param) {} // 0x00000001812D1D80-0x00000001812D1F00
	// [XID] // 0x00000001896468E0-0x0000000189646900
	private static void TriggerFrozenMelt(ReactionParams param) {} // 0x00000001812D6190-0x00000001812D63D0
	// [XID] // 0x000000018996D350-0x000000018996D370
	private static void TriggerIceMelt(ReactionParams param) {} // 0x00000001812D84A0-0x00000001812D86E0
	// [XID] // 0x0000000189983DB0-0x0000000189983DD0
	private static void TriggerBothMelt(ReactionParams param) {} // 0x00000001812D5410-0x00000001812D5650
	// [XID] // 0x000000018998B7C0-0x000000018998B7E0
	private static void TriggerSuperconductorIce(ReactionParams param) {} // 0x00000001812DA700-0x00000001812DA940
	// [XID] // 0x00000001896646D0-0x00000001896646F0
	private static void TriggerSuperconductorFrozen(ReactionParams param) {} // 0x00000001812E2AA0-0x00000001812E2CE0
	// [XID] // 0x00000001899C4EF0-0x00000001899C4F10
	private static void TriggerSwirlFire(ReactionParams param) {} // 0x00000001812D2C10-0x00000001812D2E50
	// [XID] // 0x0000000189673AC0-0x0000000189673AE0
	private static void TriggerSwirlIce(ReactionParams param) {} // 0x00000001812DB310-0x00000001812DB550
	// [XID] // 0x000000018967B1C0-0x000000018967B1E0
	private static void TriggerSwirlFrozen(ReactionParams param) {} // 0x00000001812D8AD0-0x00000001812D8D10
	// [XID] // 0x0000000189682B00-0x0000000189682B20
	private static void TriggerSwirlWater(ReactionParams param) {} // 0x00000001812D8260-0x00000001812D84A0
	// [XID] // 0x000000018968A6E0-0x000000018968A700
	private static void TriggerSwirlElectric(ReactionParams param) {} // 0x00000001812DD270-0x00000001812DD4B0
	// [XID] // 0x0000000189ACA6D0-0x0000000189ACA6F0
	private static void TriggerRock(ReactionParams param) {} // 0x00000001812DE0E0-0x00000001812DE2B0
	// [XID] // 0x0000000189AD9B60-0x0000000189AD9B80
	private static void TriggerCrystallizeFire(ReactionParams param) {} // 0x00000001812CC8C0-0x00000001812CCA90
	// [XID] // 0x00000001896A0C80-0x00000001896A0CA0
	private static void TriggerCrystallizeIce(ReactionParams param) {} // 0x00000001812E5000-0x00000001812E51D0
	// [XID] // 0x0000000189AFF5F0-0x0000000189AFF610
	private static void TriggerCrystallizeFrozen(ReactionParams param) {} // 0x00000001812E1160-0x00000001812E1330
	// [XID] // 0x0000000189B0E5D0-0x0000000189B0E5F0
	private static void TriggerCrystallizeWater(ReactionParams param) {} // 0x00000001812D9D10-0x00000001812D9EE0
	// [XID] // 0x0000000189B1D1A0-0x0000000189B1D1C0
	private static void TriggerCrystallizeElectric(ReactionParams param) {} // 0x00000001812DC410-0x00000001812DC5E0
	// [XID] // 0x0000000189B2BBE0-0x0000000189B2BC00
	private static void TriggerStickWater(ReactionParams param) {} // 0x00000001812D9420-0x00000001812D95A0
	// [XID] // 0x00000001896C57B0-0x00000001896C57D0
	private static void TriggerStickIce(ReactionParams param) {} // 0x00000001812DECF0-0x00000001812DEE70
	// [XID] // 0x0000000189B51680-0x0000000189B516A0
	private static void TriggerStickRock(ReactionParams param) {} // 0x00000001812DD4B0-0x00000001812DD5C0
	// [XID] // 0x00000001896D3FE0-0x00000001896D4000
	private static void TriggerStickFire(ReactionParams param) {} // 0x00000001812DF910-0x00000001812DFA90
	// [XID] // 0x0000000189B6F0A0-0x0000000189B6F0C0
	private static void TriggerStickWind(ReactionParams param) {} // 0x00000001812E0AD0-0x00000001812E0C50
	// [XID] // 0x0000000189B7DD00-0x0000000189B7DD20
	private static void TriggerStickElectric(ReactionParams param) {} // 0x00000001812DEB70-0x00000001812DECF0
	// [XID] // 0x00000001896EA6E0-0x00000001896EA700
	private static void TriggerFrozenBroken(ReactionParams param) {} // 0x00000001812CF8A0-0x00000001812CF9B0
	// [XID] // 0x000000018960DE70-0x000000018960DE90
	private static void UpdateElementParam(ElementReactionType reactType, ReactionParams param, float beforeDurability) {} // 0x00000001812D28E0-0x00000001812D2C10
	// [XID] // 0x00000001896F90A0-0x00000001896F90C0
	private static float GetElementReactionAddHurt(CombatProperty combatProperty, ElementReactionType reactType) => default; // 0x00000001812E3790-0x00000001812E3960
	// [XID] // 0x0000000189BAE690-0x0000000189BAE6B0
	private bool TryTriggerAntiFire(ReactionParams param) => default; // 0x00000001812DA350-0x00000001812DA550
	// [XID] // 0x0000000189718B90-0x0000000189718BB0
	private bool TryTriggerBurning(ReactionParams param) => default; // 0x00000001812DD9F0-0x00000001812DDED0
	// [XID] // 0x000000018970FBB0-0x000000018970FBD0
	private bool TryTriggerBurned(ElementReactionSourceType reactionSourceType, uint sourceElementCasterID) => default; // 0x00000001812CE480-0x00000001812CE6A0
	// [XID] // 0x0000000189716D70-0x0000000189716D90
	private bool TryTriggerExplode(ReactionParams param) => default; // 0x00000001812D4130-0x00000001812D4360
	// [XID] // 0x000000018971E7A0-0x000000018971E7C0
	private bool TryTriggerWet(ReactionParams param) => default; // 0x00000001812CE800-0x00000001812CE9A0
	// [XID] // 0x00000001898D71B0-0x00000001898D71D0
	private bool TryTriggerStream(ReactionParams param) => default; // 0x00000001812E4660-0x00000001812E4860
	// [XID] // 0x000000018972D4B0-0x000000018972D4D0
	private bool TryTriggerElectricModifier(ReactionParams param) => default; // 0x00000001812DE720-0x00000001812DEB00
	// [XID] // 0x0000000189A43400-0x0000000189A43420
	public bool TryTriggerConductive(ConductiveEnv env, uint? sourceElementCasterID = default) => default; // 0x00000001812E1B30-0x00000001812E1CD0
	// [XID] // 0x00000001899E2910-0x00000001899E2930
	public void CheckRemoveConductive(ConductiveEnv env) {} // 0x00000001812E00B0-0x00000001812E0210
	// [XID] // 0x0000000189922940-0x0000000189922960
	private bool TryTriggerGrassGrowing(ReactionParams param) => default; // 0x00000001812DBD30-0x00000001812DBFD0
	// [XID] // 0x000000018974B810-0x000000018974B830
	private bool TryTriggerFreeze(ReactionParams param) => default; // 0x00000001812D1190-0x00000001812D1570
	// [XID] // 0x0000000189752C10-0x0000000189752C30
	private bool TryTriggerFrozen(ReactionParams param) => default; // 0x00000001812D02A0-0x00000001812D0450
	// [XID] // 0x0000000189965D30-0x0000000189965D50
	private bool TryTriggerFrozenMelt(ReactionParams param) => default; // 0x00000001812E3C00-0x00000001812E3F10
	// [XID] // 0x0000000189974C10-0x0000000189974C30
	private bool TryTriggerIceMelt(ReactionParams param) => default; // 0x00000001812CFB60-0x00000001812CFD60
	// [XID] // 0x00000001897690D0-0x00000001897690F0
	private bool TryTriggerBothMelt(ReactionParams param) => default; // 0x00000001812D6F80-0x00000001812D72A0
	// [XID] // 0x00000001899932D0-0x00000001899932F0
	private bool TryTriggerSuperconductorIce(ReactionParams param) => default; // 0x00000001812D3580-0x00000001812D3720
	// [XID] // 0x0000000189777FF0-0x0000000189778010
	private bool TryTriggerSuperconductorFrozen(ReactionParams param) => default; // 0x00000001812D5190-0x00000001812D5330
	// [XID] // 0x000000018977F500-0x000000018977F520
	private bool TryTriggerSuperconductor(ReactionParams param, ElementType elem1, ElementType elem2, string abilityName) => default; // 0x00000001812D1AD0-0x00000001812D1D80
	// [XID] // 0x0000000189786F00-0x0000000189786F20
	private bool TryTriggerSwirlFire(ReactionParams param) => default; // 0x00000001812CF9B0-0x00000001812CFB60
	// [XID] // 0x000000018978E5A0-0x000000018978E5C0
	private bool TryTriggerSwirlIce(ReactionParams param) => default; // 0x00000001812DA550-0x00000001812DA700
	// [XID] // 0x0000000189795C60-0x0000000189795C80
	private bool TryTriggerSwirlFrozen(ReactionParams param) => default; // 0x00000001812D1920-0x00000001812D1AD0
	// [XID] // 0x000000018979DF30-0x000000018979DF50
	private bool TryTriggerSwirlWater(ReactionParams param) => default; // 0x00000001812D33D0-0x00000001812D3580
	// [XID] // 0x0000000189AC2F70-0x0000000189AC2F90
	private bool TryTriggerSwirlElectric(ReactionParams param) => default; // 0x00000001812CCA90-0x00000001812CCC40
	// [XID] // 0x00000001899D3B90-0x00000001899D3BB0
	private bool TryTriggerSwirl(ReactionParams param, ElementType elem1, ElementType elem2, string abilityName, ElementReactionType reactionAccuType, ElementReactionType reactionType) => default; // 0x00000001812D86E0-0x00000001812D89B0
	// [XID] // 0x00000001897B4860-0x00000001897B4880
	private float TryTriggerAccuSwirl(ReactionParams param, ElementType elem1, ElementType elem2, string abilityName, ElementReactionType reactionType) => default; // 0x00000001812DD5C0-0x00000001812DD810
	// [XID] // 0x00000001897BC770-0x00000001897BC790
	private float UpdateElemAccuDurabilities(ElementReactionType reactionType, float minDurability) => default; // 0x00000001812CBD40-0x00000001812CC010
	// [XID] // 0x0000000189AD2110-0x0000000189AD2130
	private bool TryTriggerRock(ReactionParams param) => default; // 0x00000001812D7CA0-0x00000001812D7F10
	// [XID] // 0x00000001897CB560-0x00000001897CB580
	private bool TryTriggerCrystallizeFire(ReactionParams param) => default; // 0x00000001812D5650-0x00000001812D57F0
	// [XID] // 0x0000000189AF8030-0x0000000189AF8050
	private bool TryTriggerCrystallizeIce(ReactionParams param) => default; // 0x00000001812DCDE0-0x00000001812DCF80
	// [XID] // 0x0000000189B06D50-0x0000000189B06D70
	private bool TryTriggerCrystallizeFrozen(ReactionParams param) => default; // 0x00000001812D3720-0x00000001812D38C0
	// [XID] // 0x0000000189B156F0-0x0000000189B15710
	private bool TryTriggerCrystallizeWater(ReactionParams param) => default; // 0x00000001812D9F40-0x00000001812DA0E0
	// [XID] // 0x0000000189B24790-0x0000000189B247B0
	private bool TryTriggerCrystallizeElectric(ReactionParams param) => default; // 0x00000001812CE0A0-0x00000001812CE240
	// [XID] // 0x0000000189AE8BD0-0x0000000189AE8BF0
	private bool TryTriggerCrystallize(ReactionParams param, ElementType elem1, ElementType elem2, string abilityName, ElementReactionType reactionType) => default; // 0x00000001812E3960-0x00000001812E3C00
	// [XID] // 0x0000000189B3AC70-0x0000000189B3AC90
	private bool TryTriggerStick(ReactionParams param, ElementReactionType elementReactionType, string abilityName, string abilityDuration, string abilityDurability, AbilityState state) => default; // 0x00000001812D97E0-0x00000001812D9B40
	// [XID] // 0x0000000189B330D0-0x0000000189B330F0
	private bool TryTriggerStickWater(ReactionParams param) => default; // 0x00000001812D9BB0-0x00000001812D9D10
	// [XID] // 0x0000000189B49E60-0x0000000189B49E80
	private bool TryTriggerStickIce(ReactionParams param) => default; // 0x00000001812CE6A0-0x00000001812CE800
	// [XID] // 0x000000018980EE60-0x000000018980EE80
	private bool TryTriggerStickRock(ReactionParams param) => default; // 0x00000001812DE540-0x00000001812DE6A0
	// [XID] // 0x00000001898164D0-0x00000001898164F0
	private bool TryTriggerStickFire(ReactionParams param) => default; // 0x00000001812DC5E0-0x00000001812DC740
	// [XID] // 0x0000000189B76740-0x0000000189B76760
	private bool TryTriggerStickWind(ReactionParams param) => default; // 0x00000001812D4E50-0x00000001812D4FB0
	// [XID] // 0x0000000189B85A20-0x0000000189B85A40
	private bool TryTriggerStickElectric(ReactionParams param) => default; // 0x00000001812E3560-0x00000001812E36C0
	// [XID] // 0x000000018982CC10-0x000000018982CC30
	private void TryTriggerFrozenBroken(ReactionParams param) {} // 0x00000001812CFEE0-0x00000001812D00E0
	// [XID] // 0x00000001898343A0-0x00000001898343C0
	private void TryTriggerElementReactionOnAdded(ElementType sourceElementType, ElementReactionSourceType reactionSourceType, CombatProperty combatProperty, float attackElementDurability, uint sourceElementCasterID, ActorModifier sourceModifier, float elementRank, Vector3 hitPos, out ElementReactionDamageChange damageChange) {
		damageChange = default;
	} // 0x00000001812DB550-0x00000001812DBAF0
	// [XID] // 0x0000000189994A60-0x0000000189994A80
	private void TryTriggerElementReactionOnAddedRemote(ElementType sourceElementType, ElementReactionSourceType reactionSourceType, float attackElementDurability, uint sourceElementCasterID, out ElementReactionDamageChange damageChange) {
		damageChange = default;
	} // 0x00000001812E4B70-0x00000001812E4ED0
	// [XID] // 0x0000000189843110-0x0000000189843130
	private void TryTriggerElementReactionOnRemoved(ElementType removeElementType, uint sourceElementCasterID) {} // 0x00000001812D8D10-0x00000001812D8F10
	// [XID] // 0x000000018984A390-0x000000018984A3B0
	private void FireElementReactionEvent(ReactionParams param, ElementType reactorElementType, float durability, ElementReactionType elementReactionType) {} // 0x00000001812E1D90-0x00000001812E2210
	// [XID] // 0x0000000189A16920-0x0000000189A16940
	private void OnFireElementReactionEventByMassivelyEntity(BaseEntity selfEntity, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, uint sourceElementCasterID, ElementType reactorElementType, float durability, ElementReactionType elementReactionType) {} // 0x00000001812D76F0-0x00000001812D7A40
	// [XID] // 0x0000000189859090-0x00000001898590B0
	private void SyncAndNotifyElementReactionVisual(ElementReactionType elementReactionType, ElementType sourceElementType, ElementType reactorElementType, int hitIndex) {} // 0x00000001812CB610-0x00000001812CB770
	// [XID] // 0x0000000189860270-0x0000000189860290
	public bool NotifyShowElementReactionVisual(ElementReactionType elementReactionType, ElementType sourceElementType, ElementType reactorElementType, int hitIndex) => default; // 0x00000001812DCF80-0x00000001812DD270
	// [XID] // 0x0000000189B9B860-0x0000000189B9B880
	private uint GetElementReactionLogConfigID(BaseEntity entity, BaseEntity owner, out uint level, out Vector3 pos) {
		level = default;
		pos = default;
		return default;
	} // 0x00000001812E2CE0-0x00000001812E3020
	// [XID] // 0x000000018986F040-0x000000018986F060
	private void FireElementReactionToOwner(BaseEntity reactionCaster, EvtElementReaction evtElementReaction) {} // 0x00000001812E4130-0x00000001812E43A0
	// [XID] // 0x00000001898C8060-0x00000001898C8080
	private void OnEventElementReaction(EvtElementReaction evtElementReaction) {} // 0x00000001812D9360-0x00000001812D9420
	// [XID] // 0x000000018987E0F0-0x000000018987E110
	private bool IsDurabilityEnough(ElementReactionSourceType reactionSourceType, ElementType sourceElementType, float attackElementDurability, ElementType elem1, ElementType elem2, float minDurability) => default; // 0x00000001812DBAF0-0x00000001812DBC70
	// [XID] // 0x0000000189885160-0x0000000189885180
	private bool IsReactionValid(ElementReactionSourceType reactionSourceType, ElementType sourceElementType, float attackElementDurability, ElementType elem1, ElementType elem2) => default; // 0x00000001812DEE70-0x00000001812DF090
	// [XID] // 0x00000001895FEAD0-0x00000001895FEAF0
	private bool TriggerAbilityAndReaction(ReactionParams param, ElementType elem1, ElementType elem2, string abilityName, float durability, ElementReactionType reactionType) => default; // 0x00000001812D7A40-0x00000001812D7CA0
	// [XID] // 0x0000000189BC5220-0x0000000189BC5240
	private float ElementReduceDurability(ElementReactionSourceType reactionSourceType, ElementType sourceElementType, ref float attackElementDurability, ElementType elem1, ElementType elem2) => default; // 0x00000001812E0D30-0x00000001812E1160
	// [XID] // 0x000000018969E2E0-0x000000018969E300
	private void TryRemoveElemOverload(ElementReactionType reactionType, ElementType elem1, ElementType elem2) {} // 0x00000001812D1570-0x00000001812D1750
	// [XID] // 0x00000001898A2810-0x00000001898A2830
	private void UpdateElemOverloadValue(int typeIndex, float value, uint? sourceElementCasterID = default) {} // 0x00000001812CBB80-0x00000001812CBD40
	// [XID] // 0x000000018984A530-0x000000018984A550
	private bool CheckDurabiltyByOverload(ReactionParams param, ElementType elem1, ElementType elem2, float minDurability, string abilityName, ElementReactionType reactionType) => default; // 0x00000001812CDB10-0x00000001812CE0A0
	// [XID] // 0x0000000189BBD4D0-0x0000000189BBD4F0
	private bool ElementReduceReaction(ReactionParams param, ElementType elem1, ElementType elem2, string abilityName, ElementReactionType reactionType, out float minDurability) {
		minDurability = default;
		return default;
	} // 0x00000001812D4FB0-0x00000001812D5190
	// [XID] // 0x00000001898432E0-0x0000000189843300
	private bool ElementOverloadReaction(ReactionParams param, ElementType elem1, ElementType elem2, string abilityName, ElementReactionType reactionType) => default; // 0x00000001812D00E0-0x00000001812D02A0
	// [XID] // 0x00000001898C8040-0x00000001898C8060
	private bool TryTriggerOwnReaction(ReactionParams param, bool checkMotifier, AbilityState state, string abilityName, ElementReactionType reaction) => default; // 0x00000001812CC660-0x00000001812CC8C0
	// [XID] // 0x00000001898C7EC0-0x00000001898C7EE0
	public static float GetElementLevelCo(BaseEntity caster, BaseEntity target, out float B1, ElementReactionType reactType = ElementReactionType.None /* Metadata: 0x00AEA68E */) {
		B1 = default;
		return default;
	} // 0x00000001812D38C0-0x00000001812D3F10
	// [XID] // 0x00000001898CF6E0-0x00000001898CF700
	private static uint ClampWorldLevel(uint worldLevel) => default; // 0x00000001812DCC50-0x00000001812DCDE0
	// [IDTag] // 0x00000001898D6F30-0x00000001898D6F70
	// [XID] // 0x00000001898D6F30-0x00000001898D6F70
	public void UpdateBaseReactionDamage(string abilityName, uint sourceElementCasterID, ActorModifier sourceModifier, ElementReactionType reactType = ElementReactionType.None /* Metadata: 0x00AEA692 */, string baseReactionDamageName = null) {} // 0x00000001812DBFD0-0x00000001812DC2D0
	// [IDTag] // 0x00000001898E1AE0-0x00000001898E1B20
	// [XID] // 0x00000001898E1AE0-0x00000001898E1B20
	private void UpdateBaseReactionDamage(string abilityName, ReactionParams param, ElementReactionType reactType = ElementReactionType.None /* Metadata: 0x00AEA696 */, string baseReactionDamageName = null) {} // 0x00000001812DC2D0-0x00000001812DC410
	// [XID] // 0x0000000189BAA320-0x0000000189BAA340
	private void UpdateElementReactionLog(string name, ActorModifier sourceModifier) {} // 0x00000001812D2190-0x00000001812D2250
}

