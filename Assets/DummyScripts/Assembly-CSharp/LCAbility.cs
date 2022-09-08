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
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class LCAbility : LCBase // TypeDefIndex: 11667
{
	// Fields
	[NonSerialized]
	public ActorAbilityPlugin abilityPlugin; // 0x130
	[InspectorCollapsedFoldout] // 0x000000018981F560-0x000000018981F570
	public ConfigEntityAbilityEntry[] allBornAbilities; // 0x138
	[NonSerialized]
	public List<Tuple<string, string>> staticConfigAbilities; // 0x140
	[NonSerialized]
	public List<Tuple<string, string>> dynamicConfigAbilities; // 0x148
	[NonSerialized]
	public bool muteCheckDoOffStage; // 0x150
	[InspectorCollapsedFoldout] // 0x000000018996D100-0x000000018996D130
	[ShowInInspector] // 0x000000018996D100-0x000000018996D130
	private List<ConfigBuffDebuffResistance> _resistanceBuffDebuffs; // 0x158
	[InspectorCollapsedFoldout] // 0x000000018996D100-0x000000018996D130
	[ShowInInspector] // 0x000000018996D100-0x000000018996D130
	private List<ConfigBuffDebuffAddition> _additionBuffDebuffs; // 0x160
	private HashSet<string> _serverGlobalValues; // 0x168
	public SyncAbilityState syncStateFromServer; // 0x170
	private Dictionary<int, Tuple<int, float>> _elementTypeResistances; // 0x178
	private AbilitySyncStateInfo _abilitySyncInfoOnChangeAuthority; // 0x180

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189ACEED0-0x0000000189ACEEF0 */ get => default; } // 0x00000001818A7F50-0x00000001818A7FF0 
	public AbilitySyncStateInfo abilitySyncInfoOnChangeAuthority { /* [XID] */ /* 0x00000001897B11E0-0x00000001897B1200 */ get => default; /* [XID] */ /* 0x00000001897B8DA0-0x00000001897B8DC0 */ set {} } // 0x00000001818A2600-0x00000001818A26B0 0x00000001818A6560-0x00000001818A6660

	// Nested types
	public enum SyncAbilityState // TypeDefIndex: 11668
	{
		NotSynced = 0,
		HasSynced = 1
	}

	// Constructors
	public LCAbility() {} // 0x00000001818A7ED0-0x00000001818A7F50

	// Methods
	// [XID] // 0x00000001896A69C0-0x00000001896A69E0
	public override void Destroy() {} // 0x00000001818A2C30-0x00000001818A2DC0
	// [XID] // 0x00000001896AE090-0x00000001896AE0B0
	public override void PreInit() {} // 0x00000001818A7CB0-0x00000001818A7DB0
	// [XID] // 0x0000000189AED5B0-0x0000000189AED5D0
	private void RefreshSyncState() {} // 0x00000001818A52A0-0x00000001818A5430
	// [XID] // 0x0000000189AFC4B0-0x0000000189AFC4D0
	public override void Init() {} // 0x00000001818A5780-0x00000001818A5840
	// [XID] // 0x00000001896C3F20-0x00000001896C3F40
	public void InitGlobalValues(ConfigGlobalValue config) {} // 0x00000001818A48B0-0x00000001818A4A70
	// [XID] // 0x0000000189B21560-0x0000000189B21580
	public bool IsServerGlobalValue(string str) => default; // 0x00000001818A5BF0-0x00000001818A5CC0
	// [XID] // 0x0000000189B03D50-0x0000000189B03D70
	protected virtual void InitAbilityPlugin() {} // 0x00000001818A69E0-0x00000001818A6B00
	// [XID] // 0x00000001896DA420-0x00000001896DA440
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x00000001818A7DB0-0x00000001818A7ED0
	// [XID] // 0x0000000189A5E440-0x0000000189A5E460
	public override void PostReInit() {} // 0x00000001818A7BF0-0x00000001818A7CB0
	// [XID] // 0x0000000189A6D250-0x0000000189A6D270
	public override void OnEntityReady() {} // 0x00000001818A6ED0-0x00000001818A7070
	// [XID] // 0x0000000189B301F0-0x0000000189B30210
	protected virtual void AddAbilityActionAndMixins(bool addAbilities = false /* Metadata: 0x00AEA684 */) {} // 0x00000001818A1030-0x00000001818A1270
	// [XID] // 0x0000000189A74B00-0x0000000189A74B20
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x00000001818A1870-0x00000001818A19C0
	// [XID] // 0x0000000189A7C510-0x0000000189A7C530
	protected static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001818A4F80-0x00000001818A5050
	// [XID] // 0x0000000189706920-0x0000000189706940
	protected override bool OnEvent(BaseEvent evt) => default; // 0x00000001818A7070-0x00000001818A76B0
	// [XID] // 0x000000018970E1D0-0x000000018970E1F0
	protected virtual void AddAllPreDynamicConfigAbilities() {} // 0x00000001818A68D0-0x00000001818A6970
	// [XID] // 0x0000000189715630-0x0000000189715650
	protected virtual void AddAllStaticConfigAbilities() {} // 0x00000001818A19C0-0x00000001818A2600
	// [XID] // 0x0000000189893E40-0x0000000189893E60
	protected virtual void AddAllDynamicConfigAbilities() {} // 0x00000001818A1600-0x00000001818A16A0
	// [XID] // 0x00000001897245B0-0x00000001897245D0
	protected void AddDynamicConfigAbility(string abilityName, string abilityOverride) {} // 0x00000001818A4A70-0x00000001818A4D00
	// [XID] // 0x0000000189717040-0x0000000189717060
	public void AddLevelEntityConfigAbilityFromSceneData(List<string> levelConfigNameList) {} // 0x00000001818A29A0-0x00000001818A2C30
	// [XID] // 0x000000018972D6B0-0x000000018972D6D0
	public void AddBuffDebuffResistance(ConfigBuffDebuffResistance resistance) {} // 0x00000001818A5840-0x00000001818A5910
	// [XID] // 0x000000018989F670-0x000000018989F690
	public void RemoveBuffDebuffResistance(ConfigBuffDebuffResistance resistance) {} // 0x00000001818A6660-0x00000001818A6750
	// [XID] // 0x0000000189734E30-0x0000000189734E50
	public void AddBuffDebuffAddition(ConfigBuffDebuffAddition addition) {} // 0x00000001818A7B20-0x00000001818A7BF0
	// [XID] // 0x0000000189747110-0x0000000189747130
	public void RemoveBuffDebuffAddition(ConfigBuffDebuffAddition addtion) {} // 0x00000001818A4E90-0x00000001818A4F80
	// [IDTag] // 0x0000000189751370-0x00000001897513B0
	// [XID] // 0x0000000189751370-0x00000001897513B0
	public bool IsResistance(AbilityState abilityState) => default; // 0x00000001818A6CD0-0x00000001818A6ED0
	// [XID] // 0x000000018975B8D0-0x000000018975B8F0
	public float GetAbilityStateDurationRatio(AbilityState abilityState) => default; // 0x00000001818A0B60-0x00000001818A0D30
	// [XID] // 0x0000000189782C90-0x0000000189782CB0
	public float GetAdditionBuffDebuffTimeRatio(AbilityState abilityState) => default; // 0x00000001818A5D40-0x00000001818A5EF0
	// [XID] // 0x00000001897AB020-0x00000001897AB040
	public BaseEntity GetResolvedAttackTarget() => default; // 0x00000001818A5EF0-0x00000001818A5FD0
	// [XID] // 0x00000001897720B0-0x00000001897720D0
	public void TriggerOwnerAbility(string abilityName, uint? otherID = default, uint? triggerID = default, Dictionary<string, float> abilitySpecials = null) {} // 0x00000001818A76B0-0x00000001818A7910
	// [XID] // 0x0000000189ADE6A0-0x0000000189ADE6C0
	private void ClearElementTypeResistance(bool deallocate) {} // 0x00000001818A09B0-0x00000001818A0A90
	// [XID] // 0x00000001897B2E20-0x00000001897B2E40
	public void AddElementTypeResistance(ElementType elementType, float durationRatio) {} // 0x00000001818A7910-0x00000001818A7B20
	// [XID] // 0x00000001897886E0-0x0000000189788700
	public void RemoveElementTypeResistance(ElementType elementType, float durationRatio) {} // 0x00000001818A16A0-0x00000001818A1870
	// [IDTag] // 0x000000018978FD40-0x000000018978FD80
	// [XID] // 0x000000018978FD40-0x000000018978FD80
	public bool IsResistance(ElementType elementType) => default; // 0x00000001818A6BC0-0x00000001818A6CD0
	// [XID] // 0x00000001897BA9F0-0x00000001897BAA10
	public float GetElementTypeDurationRatio(ElementType elementType) => default; // 0x00000001818A67B0-0x00000001818A68D0
	// [XID] // 0x0000000189654170-0x0000000189654190
	public OverrideMap CalculateInitedOverrideMap(string abilityName) => default; // 0x00000001818A5430-0x00000001818A5570
	// [XID] // 0x00000001897A9980-0x00000001897A99A0
	public bool HasUnlockedTalentParam(string abilityName, string paramName) => default; // 0x00000001818A14A0-0x00000001818A1600
	// [XID] // 0x00000001897F7140-0x00000001897F7160
	public void ChangeAuthority() {} // 0x00000001818A5910-0x00000001818A5B30
	// [XID] // 0x0000000189767A10-0x0000000189767A30
	public void ReinitAbilityComp() {} // 0x00000001818A27D0-0x00000001818A29A0
	// [XID] // 0x00000001897CFE10-0x00000001897CFE30
	public virtual void ClearOnDisconnect() {} // 0x00000001818A6B00-0x00000001818A6BC0
	// [XID] // 0x00000001897D7630-0x00000001897D7650
	protected void ValidateConfig() {} // 0x00000001818A5570-0x00000001818A5780
	// [XID] // 0x00000001897DEB40-0x00000001897DEB60
	private void ValidateAbilityConfig() {} // 0x00000001818A0D30-0x00000001818A1030
	// [XID] // 0x00000001897E6570-0x00000001897E6590
	private static int GetConfigHash(object obj) => default; // 0x00000001818A6220-0x00000001818A6470
	// [XID] // 0x0000000189B6C070-0x0000000189B6C090
	private object GetConfigData() => default; // 0x00000001818A4D00-0x00000001818A4E90
	// [XID] // 0x0000000189B12C60-0x0000000189B12C80
	private static void OnConfigHashCalculated(uint ownerID, int hashValue, object data, uint uniqId) {} // 0x00000001818A50C0-0x00000001818A5240
	// [XID] // 0x00000001897FD000-0x00000001897FD020
	private void ValidateCombatConfig() {} // 0x00000001818A5FD0-0x00000001818A6220
	// [XID] // 0x0000000189673D60-0x0000000189673D80
	private int GetCombatConfigHash(object obj) => default; // 0x00000001818A26B0-0x00000001818A27D0
	// [XID] // 0x000000018980BB70-0x000000018980BB90
	private static void OnCombatConfigHashCalculated(uint ownerID, int hashValue, object data, uint uniqId) {} // 0x00000001818A1270-0x00000001818A13F0
	// [XID] // 0x0000000189813340-0x0000000189813360
	public virtual void OnAbilityChanged(AvatarDataItem avatarDataItem) {} // 0x00000001818A13F0-0x00000001818A14A0
	[Preserve] // 0x000000018981AE90-0x000000018981AED0
	// [XID] // 0x000000018981AE90-0x000000018981AED0
	public override string Dump() => default; // 0x00000001818A2DC0-0x00000001818A48B0
}

